


--#A03 Criar Bando de Dados

	CREATE DATABASE db_Biblioteca ON PRIMARY (
				NAME = db_Biblioteca,
				FILENAME = 'C:\Users\helinton.fioramonte\Pessoal\GitHub\teste\SQL\db_Biblioteca.MDF',
				SIZE = 6MB,
				MAXSIZE = 20MB,
				FILEGROWTH = 10%
				)

--#A05 Criar Tabelas

	USE db_Biblioteca

	CREATE TABLE tbl_Livro(
		ID_Livro SMALLINT PRIMARY KEY IDENTITY(100,1),
		Nome_Livro VARCHAR(50) NOT NULL,
		ISBN VARCHAR(30) NOT NULL UNIQUE,
		ID_Autor SMALLINT NOT NULL,
		Data_Pub DATETIME NOT NULL,
		Preco_Livro MONEY NOT NULL
		)

	CREATE TABLE tbl_autores(
		ID_Autor SMALLINT PRIMARY KEY,
		Nome_Autor VARCHAR(50),
		SobreNome_Autor VARCHAR(60),
		)

	CREATE TABLE tbl_editoras(
		ID_Editora SMALLINT PRIMARY KEY IDENTITY,
		Nome_Editora VARCHAR(50) NOT NULL
		)

--#A06 Testando IDENTITY, Auto incremento de valores em colunas
	
	USE db_Biblioteca

	CREATE TABLE tbl_teste_identidade(
		ID_Teste SMALLINT PRIMARY KEY IDENTITY,
		Valor SMALLINT NOT NULL
		)

	INSERT INTO tbl_teste_identidade (Valor) VALUES (10);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (20);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (30);
	INSERT INTO tbl_teste_identidade (Valor) VALUES (40);

	SELECT * FROM tbl_teste_identidade

--#A07 ALTER e DROP TABLE - Alterar e Excluir Tabelas e Colunas
	
	--DROP
		ALTER TABLE tbl_Livro
			DROP COLUMN ID_Autor

		DROP TABLE tbl_teste_identidade

	--ADD
		ALTER TABLE tbl_Livro
			ADD ID_Autor SMALLINT NOT NULL
			CONSTRAINT fk_ID_Autor FOREIGN KEY (ID_Autor)
			REFERENCES tbl_autores

		ALTER TABLE tbl_Livro
			ADD ID_Editora SMALLINT NOT NULL
			CONSTRAINT fk_id_editora FOREIGN KEY (ID_Editora)
			REFERENCES tbl_editoras

	--ALTER
		ALTER TABLE tbl_Livro
			ALTER COLUMN ID_Autor
				SMALLINT

--#A08 INSERT INTO ... VALUES - Inserrir dados nas Tabelas


--#A17 - Operador UNION
	
	--Ex. UNION:
		SELECT ID_Autor FROM tbl_autores
		UNION
		SELECT ID_Autor FROM tbl_Livro

	--Ex. Pessoa Generalização:
		SELECT Nome_Cliente FROM tbd_Clientes
		UNION
		SELECT Nome_Funcionario FROM  tbd_Funcionarios

--#A32 - Cláusula WITH TIES

	SELECT TOP (3) WITH TIES nome_time , pontos FROM tbl_times
	ORDER BY pontos DESC

--#A35 - CTE Commom Table Expression (SubConsultas)

	--Ex. Loja - Totalizar todos os produtos comprados por cliente:
		SELECT CL.Nome_Cliente AS Cliente,
		PR.Preco_Produto * CO.Quantidade AS Total
		FROM Clientes AS CL
		INNER JOIN Compras AS CO ON CL.ID_Cliente = CO.ID_Cliente
		INNER JOIN Produtos AS PR ON CO.ID_Produto = PR.ID_Produto
		--GROUP BY CL.Nome_Cliente

	--Ex. Loja com CTE
		WITH ConsultaCTE (Cliente,Total)
		AS (SELECT CL.Nome_Cliente AS Cliente, 
			PR.Preco_Produto * CO.Quantidade AS Total
			FROM Clientes AS CL
			INNER JOIN Compras AS CO ON CL.ID_Cliente = CO.ID_Cliente
			INNER JOIN Produtos AS PR ON CO.ID_Produto = PR.ID_Produto)

		SELECT Cliente, SUM(Total) AS ValorTotal
		FROM ConsultaCTE
		GROUP BY Cliente
		ORDER BY ValorTotal

--#A36 VARIÁVEIS - Declaração e atribuição
	
	--Ex. Declaração:
		DECLARE @idade INT,
				@nome VARCHAR(40),
				@data_nasc DATE,
				@valor MONEY;

	--Ex. Atribuição SET:
		SET @idade = 27
		SET @nome = 'Helinton'
		SET @data_nasc = GETDATE()

	--Ex. Atribuição SELECT:
		DECLARE @livro VARCHAR(30)
		SELECT @livro = nome_livro FROM tbl_livro WHERE ID_Livro = 101
		SELECT @livro AS 'Nome do Livro'

	--Ex. Consulta:
		SELECT @idade AS Idade, @nome AS Nome, @data_nasc AS 'Data de Nascimento', @valor AS Salário

	--Ex. Cáculo:
		DECLARE @preco MONEY, @quantidade INT, @nome VARCHAR(30)

		SET @quantidade = 5

		SELECT @preco = Preco_Livro, @nome = Nome_Livro FROM tbl_Livro WHERE ID_Livro = 103

		SELECT @nome AS 'Nome do Livro', @preco AS 'Valor Unitario',@quantidade AS 'Quantidade', @preco * @quantidade AS 'Valor Total'


--#A38 - IF/ELSE - Estrutura de decisão
	--Ex. Condição
		DECLARE @numero INT,
				@texto VARCHAR(10)

		SET @numero = 20
		SET @texto = 'Helinton'

		IF @numero = 20
			SELECT 'Número correto!'
		IF @texto = 'Helinton'
			BEGIN
				SET @numero = 30
				SELECT @numero
			END;
		ELSE
			BEGIN
				SET @numero = 40
				SELECT 'Número incorreto!'
			END;

	--Ex. Aluno:
		DECLARE @nome VARCHAR(30),
				@media REAL,
				@resultado VARCHAR(10)

		SELECT @nome = nome_aluno,
			   @media = (tbl_alunos.nota1 + tbl_alunos.nota2 + tbl_alunos.nota3 + tbl_alunos.nota4)/4.00
		FROM tbl_alunos
		WHERE nome_aluno = 'helinton'			   
			IF @media >= 7.00
				BEGIN
					SELECT @resultado = 'Aprovado';
				END;
			ELSE
				BEGIN
					SELECT @resultado = 'Reprovado';
				END;

		SELECT 'O aluno '+@nome+'está '+@resultado+' com média '+ CAST(@media AS VARCHAR);

--#A39 - Loop WHILE

	--Ex. WHILE:
		DECLARE @valor INT
		SET @valor = 0

		WHILE @valor < 10
			BEGIN
				PRINT 'Número: '+ CAST(@valor AS VARCHAR(2))
				SET @valor = @valor +1
			END;

	--Ex. Biblioteca:
		DECLARE @codigo INT
		SET @codigo = 100

		WHILE @codigo < 106
			BEGIN
				SELECT ID_Livro AS ID, Nome_Livro AS Livro, Preco_Livro AS Preço
				FROM tbl_Livro
				WHERE ID_Livro = @codigo
				SET @codigo = @codigo + 1
			END;

	--Ex. WHILE, IF E EXISTS:
		DECLARE @codigo INT
		SET @codigo = 100

		WHILE @codigo <= 107
			BEGIN	
				IF EXISTS(SELECT ID_Livro AS ID FROM tbl_Livro AS L WHERE L.ID_Livro = @codigo )		
					BEGIN			
						SELECT ID_Livro AS ID, Nome_Livro AS Livro, Preco_Livro AS Preço
						FROM tbl_Livro
						WHERE ID_Livro = @codigo			
					END;
				SET @codigo = @codigo + 1
			END;	



--#A40 - Stored Procedures
	
	#01)Criação e Execução

		--Ex01. Criar Stored Procedures
			CREATE PROCEDURE teste 
			AS
			SELECT 'Helinton fioramonte' AS Nome

			EXECUTE teste

		--Ex02. Biblioteca acessando banco
			CREATE PROCEDURE p_LivroValor
			AS
			SELECT Nome_Livro, Preco_Livro
			FROM tbl_Livro

		--Ex03. Visualizar conteúdo de SP:
			EXEC sp_helptext p_LivroValor

		--Ex04. Criptografar Stored Procedure
			CREATE PROCEDURE p_LivroISBN
				WITH ENCRYPTION
			AS
				SELECT Nome_Livro, ISBN
				FROM tbl_Livro

	#02)Alteração e Parâmetros de Entrada

		--Ex01. Modificar Stored Procedure
			ALTER PROCEDURE teste (@par1 AS INT)
			AS
			SELECT @par1

		--Ex02. Parâmetros de Entrada acessando banco
			ALTER PROCEDURE p_LivroValor (@ID SMALLINT)
			AS
			SELECT Nome_Livro AS Livro, Preco_Livro AS Preço
			FROM tbl_Livro
			WHERE ID_Livro = @ID

			EXEC p_LivroValor 107

		--Ex03. Múltiplos parâmetros de entrada
			ALTER PROCEDURE teste (@par1 AS INT, @par2 VARCHAR(20))
			AS
			BEGIN
				SELECT @par1
				SELECT @par2
			END;

			--Executar por posição:
				EXEC teste 22,'Laranja'
			--Executar por nome:
				EXEC teste @par1=25,@par2='Abacate'

	#03)Parâmetros de Entrada e INSERT

		--Ex01. Multiplos parametros:
			ALTER PROCEDURE p_LivroValor(@ID SMALLINT, @Preco MONEY)
			AS
			SELECT Nome_Livro AS Livro, Preco_Livro AS Preço
			FROM tbl_Livro
			WHERE ID_Livro > @ID AND Preco_Livro > @Preco

			EXEC p_LivroValor @ID = 100, @Preco = 60

		--Ex02. Fornecer o ID e a Quantidade e retornar o valor total pago
			ALTER PROCEDURE p_LivroValor (@ID SMALLINT, @Quantidade SMALLINT)
			AS
			SELECT Nome_Livro AS Livro, Preco_Livro * @Quantidade AS Preço
			FROM tbl_Livro
			WHERE ID_Livro = @ID

			EXEC p_LivroValor @ID=107,@Quantidade =10

		--Ex03. Inserção de dados
			CREATE PROCEDURE p_insere_editora(@nome VARCHAR(50))
			AS 
			INSERT INTO tbl_editoras (Nome_Editora) 
			VALUES(@Nome)

			EXEC p_insere_editora @nome = 'Editoral'

	#04)Parâmetros de Saída, RETURN e Valor Padrão

		--Ex01. Parâmetros com valor padrão
			CREATE PROCEDURE p_teste_valor_padrão (@par1 INT, @par2 VARCHAR(20) = 'Valor Padrão!')
			AS
			SELECT 'Valor do parâmetro 1: '+ CAST(@par1 AS VARCHAR)
			SELECT 'Valor do parâmetro 2:'+ @par2

			EXEC p_teste_valor_padrão 30
			EXEC p_teste_valor_padrão @par1 = 40, @par2 = 'Valor Modificado'

		--Ex02. Parâmetros de saída
			ALTER PROCEDURE teste (@par1 AS INT OUTPUT)
			AS
			SELECT @par1 * 2
			RETURN

			DECLARE @valor AS INT = 15
			EXEC teste @valor OUTPUT
			PRINT @valor

		--Ex03. Usando o parâmetro RETURN
			ALTER PROCEDURE p_LivroValor(
				@Quantidade SMALLINT,
				@Cod SMALLINT = -10,
				@ID SMALLINT
				)
			AS
			SET NOCOUNT ON --Para não mostrar as linhas afetas nas mesagens
			IF EXISTS(SELECT ID_Livro FROM tbl_Livro WHERE ID_Livro = @ID)
				BEGIN
					SELECT Nome_Livro AS Livro, Preco_Livro * @Quantidade AS Preço
					FROM tbl_Livro
					WHERE ID_Livro = @ID
					RETURN 1
				END
			ELSE
				RETURN @Cod

			DECLARE @Codigo INT
			EXEC @Codigo = p_LivroValor @ID = 103, @Quantidade = 10
			PRINT @Codigo

--#A41 - Funções

	#01)Função Escalar

		--Ex01. Funções Escalares:
			CREATE FUNCTION nota_media(@nome VARCHAR(30))
			RETURNS REAL
			AS
			BEGIN
				DECLARE @media REAL
				SELECT @media = (nota1+nota2+nota3+nota4 * 2)/5.00
				FROM tbl_alunos
				WHERE nome_aluno = @nome
				RETURN @media
			END

			SELECT dbo.nota_media('Fábio')

		--Ex02. Biblioteca
			CREATE FUNCTION livro_parcelado(@nome VARCHAR(30),@parcelas SMALLINT = 1)
				RETURNS REAL
				AS
				BEGIN
					DECLARE @valor REAL
					SELECT @valor = Preco_Livro / @parcelas
					FROM tbl_Livro
					WHERE Nome_Livro = @nome
					RETURN @valor
				END

				SELECT dbo.livro_parcelado('Nova Ordem Mundial',1)

	#02)Valor de Tabela Embutida

		--Ex01. Biblioteca
			CREATE FUNCTION retorna_itens(@valor REAL)
			RETURNS Table
			AS
			RETURN(
				SELECT L.Nome_Livro, A.Nome_Autor, E.Nome_Editora
				FROM tbl_livro AS L
				INNER JOIN tbl_autores AS A ON L.ID_Autor = A.ID_Autor
				INNER JOIN tbl_editoras AS E ON L.ID_Editora = E.ID_Editora
				WHERE L.Preco_Livro > @valor
				)

			SELECT Nome_Livro, Nome_Autor
			FROM retorna_itens(62.00)

	#03)Valor de Tabela com Várias Instruções

		--Ex01. Biblioteca
			CREATE FUNCTION multi_tabela()
			RETURNS @valores Table
				(Nome_Livro VARCHAR(50),
				Data_Pub DATETIME, Nome_Editora VARCHAR(50),
				Preco_Livro MONEY)
			AS
			BEGIN
				INSERT @valores (Nome_Livro, Data_Pub, Nome_Editora, Preco_Livro)
				SELECT L.Nome_Livro, L.Data_Pub, E.Nome_Editora, L.Preco_Livro
				FROM tbl_livro AS L
				INNER JOIN tbl_editoras AS E ON L.ID_Editora = E.ID_Editora
				RETURN
			END

			SELECT * FROM multi_tabela()

--#AE01 - Exists
	SELECT * FROM aluno a
	WHERE NOT EXISTS (SELECT 1  FROM turmaitem ti
			WHERE ti.codigoaluno = a.codigo)

--#AE02 - row_number() over
	SELECT ROW_NUMBER() OVER(ORDER BY A.Data_Pub ASC) AS Livro, A.Nome_Livro
	FROM tbl_Livro A
	ORDER BY A.Data_Pub

