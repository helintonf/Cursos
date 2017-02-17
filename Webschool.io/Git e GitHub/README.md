


#A01 - Introdução
    
##O que é Git-SCM

- `S`istema de `C`ontrole de `V`ersão `distribuido`.
- SCM -> `Source Control Management`.
- Criado por Linus Torvalds(2005).
- Auxiliar no Desenvolvimento do Linux.

##Gerencia de Configuração de Software

- Identificação
- Documentação
- Controle
- Auditoria

###Queremos saber:

- Oque mudou e quando?
- Porque mudou?
- Quem fez a mudança?
- Podemos reproduzir a mudança?

###Artefatos:

- Codigo fonte.
- Documentação.
- Manual de usuario.

##Ferramentas de Controle de Versão

- Subversion (SVN).
- Mercurial.
- CVS -Concurrent Versioning System.
- Bazaar.
- Git é o mais rápido e eficiente.

##O que é GitHub

- Servidor de repositórios Git.
- Surgiu em 2008.
- +10 milhões de repositórios.
- +10 milhões de usuários.

#A02 - git workflow.

##git init 

- Será criado o diretório configurado como um repositorio Git.
- Todas as configurações do repositório ficam na pasta .git.

##git remote

- git remote -v
    + mostrar os as configurações dos repositorios remotos

```git

git remote add origin git@gitghub.com:endereco

```

##git status

- Estado do repositório.
- Estados dos arquivos
    + Não monitorado (untracked).
    + Modificado (modified).
    + Preparado (staged).
    + Consolidado (commited).

##git log

- historico do commit.
- git log --decorate
    + estiliza o log para ficar melhor a visibilidade.
- git log --oneline
    + exibe o log em apenas uma linha.

##git add

- Adiciona os arquivos novos e modificados para o próximo commit.

##git commit

- Registra o commit com todos os arquivos que usou "git add".
- Se o parâmetro de mensagem não for passado abrirá um editor de texto para escrever a mensagem.

```git

git commit -m "mensagem"

```

##git push

- Envia alterações (commits) de uma branch para o repositório remoto.
- O envio é rejeitado se o repositório local não estiver sincronizado.
- Enviar commits para o repositorio remoto na primeira vez.
    + git push -u origin master

```git

git push origin"destino" master"branch" / <remote> <branch>

```

##git checkout

- remover arquivo para ultima alteração.

```git

git checkout --<arquivo> 

```

##git diff [path]

- diferença entre comits, branchs e (arquivos ?)
- git diff HEAD~1

##git Workflow

- Basicamente a maior parte do trabalho com git consiste nestas tarefas:
    + Editar.
    + Commitar.
    + Sincronizar com o repositório remoto.

```java

| Tags |0.1||0.2| |1.0|            //Nome das versões
         |    |     | 
|Master| O--->O---->O              //Principal, usuario final.
|Hotfix|  \`0´      |              //Correções dos erros e falhas.
|Release|  \ \      0              //Lançamento de Versões finais do produto com grande mudanças e fim de um ciclo de desenvolvimento.
|Develop|   O-0-->O´--->O          //Desenvolvimento versões não estaveis.
|Feature|    `0-0´       `0--->0   //Desenvolvimento de funções do sistema.

```

