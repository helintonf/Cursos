--Teoria

#A01

	SQL: Structured Query Language
		-Linguagem de Consulta Estruturada padrão para acesso a Banco de Dados.
		-Usada em inpumeros sistemas, como MySQL, SQL Server, Oracle, Sybase, Access, DB2, PostgreSQL, etc.
		-Cada sistema pode usar um "dialeto" do SQL, como T-SQL (SQL Server), PL/SQL (Oracle), JET SQL (Access), etc.

	Funções do SQL	
		-Permite o acesso a dados em SGBDR.
		-Permite definir os dados no banco de dados e manipulá-los.
		-Pode ser embutido em outras linguagues usando módulos SQL, bibliotecas, etc.
		-Permite criar e excluir bancos de dados e tabelas.
		-Permite a criação de Visões(exibições), Stored Procedures e Funções em um Banco de Dados.
		-Permite configurar permissões de acesso em tabelas, procedimentos e visões.

	Grupos de Comados
		-Os comandos SQL podem ser divididos em quatro grupos princiais:
			-DDL = Data Definition Language
				-CREATE
					-Criar uma nova tabela, visão, objeto no BD.
				-ALTER
					-Modifica um objeto existente no BD, como uma tabela.
				-DROP
					-Exclui uma tabela inteira, uma exibição de uma tabela, objeto no banco de dados.
			-DML = Data Manipulation Language
				-INSERT
					-Cria um registro(linha).
				-UPDATE
					-Modifica registros.
				-DELETE
					-Exclui registros.
			-DCL = Data Control Language
				-GRANT
					-Dá privilégios a um usuário
				-REVOKE
					-Retira privilégios a um usuário
			-DQL = Data Query Language
				-SELECT
					-Obtém registros especificados de uma ou mais tabelas atraves de consultas.

#A02

	SGBDR:
		-Sistema Gerenciador de Banco de Dados Relacional.
		-Trata-se de um sistema de gerenciamento de bancos de dados baseado no modelo relacional introduzido por E.F.Codd.

		Composição:
			-Tabelas(Relação).
				-Objetos onde são armazenados os dados em um banco de dados relacional.
				-Uma tabela é uma coleção de entradas de dados relacionados e consiste em linhas e colunas.
			-Campos(Colunas).
				-São enditades que representam os atributos dos dados como:
					-Nome;
					-Data de Nascimento;
					-Salário;
					-Preço, etc.
				-Um campo é uma coluna em uma tabela que mantém informações específicas sobre cada registro.
			-Registros(Linhas).
				-Linha ou Tupla.
				-Cada entrada individual em uma tabela.
				-Trata-se de um conjunto de campos relaiconados que caracterizam os dados de uma entidade única.

		Tipos de Dados:
			char(n)
				-String de caracteres de tamanho fixo, máximo de 8000 caracteres.
			varchar(n)
				-String de caracteres de tamanho variavel, máximo de 8000 caracteres.
			nchar(n)
				-Dados Unicode de tamanho fixo, máximo de 4000 caracteres.
			nvarchar(n)
				-Dados Unicode de tamanho variavel, maximo de 4000 caracteres.
			bit
				-0,1 ou null.
			tinyint
				-Números inteiros de 0 a 255.
				-1 byte.
			smallint
				-Números inteiros de -32768 a 32767.
				-2 bytes.
			int
				-Números inteiros entre -2,147,483,648 e 2,147,483,647.
				-4 bytes.
			bigint
				-Números entre -9,223,372,036,854,775,808 e 9,223,372,036,854,775,807.
				-8 bytes.
			real
				-Números de ponto flutuante entre -3.4 x 10°38 e 3.4 x 10°38
				-4 bytes.
			datetime
				-De 01/01/1753 a 31/12/9999, com uma precisão de 3.33 milisegundos.
				-8 bytes.
			smalldatetime
				-De 01/01/1900 a 06/06/2079, com uma precisão de 1 minuto.
				-4 bytes.
			date
				-Data apenas de 01/01/0001 a 31/12/9999
				-3 bytes.
			time
				-Hora apenas. Precisão de até 100 nanossegundos.
				-3 a 5 bytes
			text
				-Cadeia de caracteres de tamanho variavel. Até 2 GB de dados.
			money
				-Dados monetários de -922,337,203,685,477.5808 até 922,337,203,685,477.5807.
				-8 bytes.

#A03

	Criando Banco de Dados:
		CREATE DATABASE NOME_BANCO ON PRIMARY (
			NAME = <NOME_BANCO>,
			FILENAME = <'CAMINHO'>,
			SIZE = <TAMANHO_MB_KB>,
			MAXSIZE = <TAMANHO_MAXIMO_MB_KB>,
			FILEGROWTH = <TAMANHO_CRESCIMENTO_MB_%>
			)

	USE <BANCO_DE_DADOS>
		-Comando USE instrui o SGBDR a utilizar o banco de dados especificado para rodar os comandos.

	sp_helpdb <BANCO_DE_DADOS>
		-informa o tamanho, taxa de crescimento, e local do banco de dados.

#A04

	SQL Constraints (Restrições)
		-Restrições são regras aplicadas nas colunas de uma tabela.
		-São usadas para limitar os tipos de dados que são inseridos.
		-Podem ser especificadas no momento de criação da tabela (CREATE).
		-Ou após a tabela ter sido criada (ALTER).

		NOT NULL
			-A constraint NOT NULL impõe a uma coluna a NÃO aceitar valores NULL.
			-Obriga um campo a sempre possuir um valor.
			-Deste modo, não é possível inserir um registro (ou atualizar) sem entrar com um valor neste campo. 

		UNIQUE
			-Identifica de forma única cada registro em uma tabela.
			-As constraints UNIQUE e PRIMARY KEY garantem a unicidade em uma coluna ou conjunto de colunas.
			-Uma constraint PRIMARY KEY automaticamente possui uma restrição UNIQUE definida.
			-pode ter várias constraints UNIQUE em uma tabela, mas apenas uma PRIMARY KEY por tabela.

		PRIMARY KEY
			-Identifica de forma única cada registro em uma tabela.
			-devem conter valores únicos.
			-não pode conter valores NULL.
			-Cada tabela deve ter apenas uma PRIMARY KEY.

		FOREIGN KEY
			-É um campo que aponta para uma chave primária em outra tabela.

		CHECK
			-É usada para limitar uma faixa de valores que podem ser colocados em uma coluna.
			-Permite apenas determinados valores para a coluna.
			-Se for definida para a tabela, poderá limitar os valores em algumas colunas com base nos valores de outras colunas do registro.

		DEFAULT
			-É usada para inserir um valor padrão em uma coluna.
			-O valor padrão será adicionado a todos os novos registros caso nenhum outro valor seja especificado.

		IDENTITY(n<INICIAR_SEQUENCIA>,n<INCREMENTO>)
			-Deixa o campo com auto incremento.

#A05
	
	Criar Tabela
		CREATE TABLE NOME_TABELA(CAMPOS_TIPOS_CONSTRAINTS);

	sp_help <NOME_TABELA>
		-informa os índices, chaves, campos atributos, tipos de atributos de uma tabela.
		-Informa tambem as Stored procedures, comendos pré-programados de uma tabela.

#A06

	AUTO INCREMENT (IDENTITY)
		-Permite que um número único seja gerado quando um novo registro é inserido em uma tabela.
		-SQL SERVER é IDENTITY(identidade), cujo valor inicial padrão é 1, e se incremeta em 1.
		-Para que o valor de IDENTITY inicie em 100 e se incremente de 2 em 2, use IDENTITY(100,2).
		-SOMENTE PODE SER USADO NA CRIAÇÃO DA COLUNA!
		-SOMENTE PODE USAR UMA COLUNA IDENTITY POR TABELA.

#A07

	Alterar Tabelas
		-É possível alterar a estrutura de uma tabela após ter sido criada, acrescentando ou excluindo atributos (campos).

	ALTER TABLE - DROP
		-ALTER TABLE <nome_tabela>	--DELETAR COLUNA
			-DROP COLUMN <nome_coluna>

		Excluir uma constraint:
			-ALTER TABLE <nome_tabela>	--DELETAR CONSTRAINT
				-DROP CONSTRAINT <nome_constraint>

	ALTER TABLE - ADD 
		-ALTER TABLE <nome_tabela>	--ADICIONAR COLUNA
			-ADD <nome_coluna_tipos_constraints>
			CONSTRAINT <chaves PK, FK, etc.>
			REFERENCES <nome_tabela_referencia_chave>

		ALTER TABLE <nome_tabela>	--ADICIONAR CONSTRAINT
			-ADD PRIMARY KEY (<coluna_constraints>)

			-A coluna deve existir antes de ser transformada em chave primária.

	ALTER TABLE - ALTER --ALTERAR
		-ALTER TABLE <nome_tabela>
			-ALTER COLUMN <nome_coluna>
				-<tipo_dados> SMALLINT

		-Alterar antes de inserir dados.

	DROP TABLE 	--Excluir tabela
		-DROP TABLE <nome_tabela>

#A08

	Inserir Dados
		-inserir dados em uma tabela:
			INSERT INTO nome_tabela(coluna01,coluna02,...)
				VALUES (valor01,valor02,...)


#A17 - Operador UNION
	-Permite combinar duas ou mais declarações SELECT.
	-Cada declaração SELECT deve ter o mesmo número de colunas, tipos de dados e ordem das colunas.
	-Mesmo retorno.
	-Unir tabelas do mesmo tipo.
	-Soma e concatena os resultados.

	SELECT colunas FROM tabela1
	UNION
	SELECT colunas FROM tabela2


#A32 - Cláusula WITH TIES
	-Alguns valores deixam de ser exibidos princialmente quando tem o mesmo valor do ultimo da lista retornada.
	-Verifica se existe algum item como mesmo valor do ultimo do TOP
	-A lista tem que esta ordenada e depois do TOP.

	SELECT TOP (3) WITH TIES nome_time , pontos FROM tbl_times
	ORDER BY pontos DESC

#A35 - 	CTE Commom Table Expression (SubConsultas)
	-Subconsultas e CTE com Tabelas Derivadas.

	CTE:
		-Commom Table Expression
		-Expressão de tabela comum.

		-Variação de uma subconsulta, similar a uma exibição (VIEW).
		-Pode ser acessada múltiplas vezes dentro da consulta principal, como se fosse uma exibição ou tabela.

#A36 - Variáveis

	Variáveis
		-Podem ser declaradas no corpo de um batch ou procedimento.
		-Pode-se atribuir-lhes valores usando-se:
			-SET.
			-SELECT.
		-Vairáveis são iniciadas por padrão com NULL.

	Declaração de Variáveis
		-DECLARE @nome_var <tipo>

		-Usar palavra DECLARE apenas uma vez para todas as variáveis.
		-Dar para agrupalas por tipo na declaração.

	Atribuir valores:
		-01)Com SET
			-SET nome_var = valor_var

			-Valor especifico que não vem da tabela de dados.
			-Atribuir SET um pra cada variável.

		-02)Com SELECT
			-SELECT nome_var = coluna FROM tabela WHERE condição

			-Usado para pegar um valor do banco de dados para atribuir na variavel.
			-Exibe apenas 1 registro, ou o ultimo registro da coluna.

	Exibir os valores(consulta)
		-SELECT nomes_var AS aliases




#A38 - IF/ELSE 

	Condicional IF/ELSE
		-É possível realizar teste condicionais em declarações SQL usando-se a estrutura IF/ELSE
		-É possivel somente uma linha de comando uma declaração.
		-Apenas uma linha de código é executada após os comandos:
			IF Condição
				Declaração

			IF Condição
				Declaração
			ELSE
				Declaração

		-Para executar blocos de código, use as palavras BEGIN e END:
			IF condição 
				BEGIN
					Bloco de códigos
				END;


#A39 - Loop WHILE
	-É usado para executar código REPETIDAMENTE enquanto uma condição for verdadeira.
	-Executa apensa um comando.
	-Se for necessário executar um bloco de comandos, use BEGIN / END;
	-Sintaxe:
		WHILE condição
			BEGIN
				Bloco de códigos
			END;

#A40 - Stored Procedures

	#01)Criação e Execução 

		Stored Procedures:
			-Procedimentos Armazenados.
			-São lotes (batches) de declarações SQL que podem ser executadas como uma subrotina.
			-Permite centralizar a lógica de acesso aos dados em um único local, facilitando a manutenção e otimização de código.
			-Também é possível ajustar permissões de acesso aos usuários, definindo quem pode ou não executá-las.

		Criar uma Stored Procedures:
			CREATE PROCEDURE nome_procedimento (@Parâmetros Tipo_dados)
			AS
				Bloco de códigos

		Executar uma Stored Procedures:
			EXEC nome_procedimento

			-Se o procedimento armazenado for o primeiro comando de um batch, não é necessario usar a palavra EXEC.
			
		Visualizar conteúdo de SP:
			-Use o procedimento armazenado sp_helptext para extrair o conteúdo de texto de uma stored procedure:

			EXEC sp_helptext nome_procedimento

		Criptografar Stored Procedure:
			CREATE PROCEDURE nome_procedimento (@Parâmetros Tipo_dados)
				WITH ENCRYPTION
			AS
				Bloco de códigos

	#02)Alteração e Parâmetros de Entrada

		Modificar Stored Procedure:
			ALTER PROCEDURE nome_procedimento (@Parâmetros AS tipo_dados)
			AS 
			Bloco de códigos da sp.

		Parâmetros de Entrada:
			EXEC nome_procedimento (Parâmetros)

		Executar:
			-Por posição:
				EXEC nome_procedimento 22,'teste'
			-Por nome:
				EXEC nome_procedimento @par2 = 'teste', @par1 = 22

	#03)Parâmetros de Entrada e INSERT
		CREATE PROCEDURE nome_procedimento(@Parâmetros)
			AS 
			INSERT INTO nome_tabela (colunas) 
			VALUES(@Parâmetros)

	#04)Parâmetros de Saída, RETURN e Valor Padrão
		-Parametro pode ser opcional pq ele tem um valor padrao

		Parâmetros de Saída
			-Os parâmetros de saída habilitam um procedimento armazenado a retornar dados ao procedimento chamador.
			-Usamos a palavra-chave OUTPUT quando o procedimento é criado, e também quando é chamado.
			-No Procedimento armazenado, o procedimento de saída aparece como uma variável local;
			-No procedimento chamador, uma variável deve ser criada para receber o parâmetro de saída.
			-Parâmetros biderecional.
			-Passagem de valores por referencia.

		Comando RETURN
			-O comando RETURN termina incondicionalmente o procedimento e retorna um valor inteiro ao chamador.
			-Pode ser usado para retornar status de sucesso ou falha do procedimento.
			-NÃO RETORNA O VALOR DO PROCESSAMENTO, MAS DO STATUS.

		SET NOCOUNT ON 
			-Para não contar as linhas afetadas.


#A41 - Funções Definidas pelo Usuário
	
	#01)Função Escalar
		Funções Definidas pelo Usuário
			-Podemor criar funções (UDFs)para realizar diversas tarefas nos bancos de dados, tais como:
				-Inserir lógica complexa em uma consulta.
				-Criar novas funções para expressões complexas.
				-Substituir exibições com a vantagem de aceitar parâmetros.

			-Funções Escalares.
				-Retorna apenas um único valor específico.

					CREATE FUNCTION nome_função(<parâmetros>)
					RETURNS tipo_dados_retorno
					AS
					BEGIN
						Bloco de códigos
						RETURN expressão_retorno
					END

	#02)Valor de Tabela Embutida
		-São similares a uma exibição, porém permitem utilizar parâmetros.
		-Retornam um conjunto completo de dados.

		CREATE FUNCTION nome_função(parâmetros)
		RETURNS Table
		AS
		RETURN (Declaração_Select)

#AE01 - Exists
	-Faz um sub SELECT para testar alguma confição.
	-Trazer todos os alnos que não estão em turmas:
		SELECT * FROM aluno a
		WHERE NOT EXISTS (SELECT 1  FROM turmaitem ti
				WHERE ti.codigoaluno = a.codigo)

