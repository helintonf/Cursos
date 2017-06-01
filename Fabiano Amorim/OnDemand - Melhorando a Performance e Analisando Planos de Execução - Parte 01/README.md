# Agenda

- Introdução à otimização no SQL Server.
- Detalhes sobre operador Key/RID Lookup.
- Detalhes sobre operador Sort.
- Detalhes sobre operador Merge Join.


# #A01 - Otimizador de Consultas

- Na linguaguem **ANSI SQL** você `diz oque quer`, e não `como/onde buscar` a informação.
- Otimizador de consultas decide qual é o melhor caminho para ler os dados.

## Exemplo

- Selecionar o endereço de todos os alunos que trabalham com informática s são do sexo feminino:

```sql

SELECT a.Nome, e.Endereco 
FROM Alunos_Classe AS a
INNER JOIN Endereco AS e
ON a.ID_End = e.ID_End
WHERE a.Ramo_Atividade = 'TI'
AND a.Sexo = 'F'

```

- **Código 01**

```java

FOR EACH(Alunos_Classe){
    IF(Alunos_Classe.Ramo_Atividade = 'TI'){
        IF(Alunos_Classe.Sexo = 'F'){
            FOR EACH(Endereco){
                IF(Endereco.ID_End = Alunos_Classe.ID_End){
                    PRINT('Aluno: ' + Alunos_Classe.Nome);
                    PRINT('ENdereço: '+ Endereco.Endereco);
                }
            }
        }
    }
}

```

- **Código 02 Otimizado**

```java

FOR EACH(Alunos_Classe){ //FOR EACH(Endereco){
    IF(Alunos_Classe.Sexo = 'F'){
    IF(Alunos_Classe.Ramo_Atividade = 'TI'){        
            FOR EACH(Endereco){ //FOR EACH(Alunos_Classe){
                IF(Endereco.ID_End = Alunos_Classe.ID_End){
                    PRINT('Aluno: ' + Alunos_Classe.Nome);
                    PRINT('ENdereço: '+ Endereco.Endereco);
                }
            }
        }
    }
}

```

- *fazer o `filtro` e `join` mas seleto possivel primeiro sempre de menor para o maior filtro*

## Oque o Otimizador de Consultas faz

- **Parse**
    + Valida se o código digitado é válido. 
    + Gera um Query Tree que é uma representação gráfica do comando em formato de uma árvore.
- **Algebrizer**
    + Onde as tabelas e campos na query tree são comparados com o metadata do banco e dados para validar se os objetos acessados realmente existem.
    + Nesta fase um '*' será expandido pelo nome das colunas, os datatypes das colunas são carregados, views expandidas, um sinônimo é interpretado.
- **Optimize**
    + Faz a mágica acontecer!


