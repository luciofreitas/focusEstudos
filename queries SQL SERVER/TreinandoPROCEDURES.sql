--COM PARAMETRO
CREATE PROCEDURE retornarDobro(
@V1_Entrada INT NULL =0
)
AS
BEGIN
	SELECT @V1_Entrada * 2 AS RESULTADO
END
GO

EXEC retornarDobro = 10
EXEC retornarDobro @V1_Entrada = 7500

--SEM PARAMETRO
CREATE PROCEDURE helloWorld
AS
BEGIN
	SELECT 'Ola, estou execurando minha primeira Stored Procedre!' AS RESULTADO
END
GO

EXEC helloWorld


DROP PROCEDURE IF EXISTS retornarDobro
GO

CREATE PROCEDURE retornarDobro(
	@V1_Entrada INT NULL = 0 OUTPUT
)
AS
BEGIN
	SET @V1_Entrada = @V1_Entrada * 2
	SELECT @V1_Entrada AS V1_Entrada_Procedure
END
GO

--SEM OUTPUT
DECLARE @Valor INT = 10

--EXECUTA A PROCEDURE
EXEC retornarDobro @Valor

--COM OUTPUT
DECLARE @Valor INT = 10

--EXECUTA A PROCEDURE
EXEC retornarDobro @Valor OUTPUT

SELECT @Valor AS Retorno
GO
---------------------------------------------
CREATE TABLE Cliente(
	Id_Cliente INT IDENTITY(1,1) NOT NULL,
	Nm_Cliente VARCHAR(100) NOT NULL,
	Dt_Nascimento DATE NOT NULL,
	Fl_Sexo TINYINT NOT NULL
)

INSERT INTO Cliente (Nm_Cliente, Dt_Nascimento, Fl_Sexo)
VALUES
	('Fabricio Lima', '19800106', 1),
	('Luiz Lima', '19890922',1),
	('Fabiano Amorim', '19620927',1),
	('Dirceu Resende', '19740516',1),
	('Rodrigo Ribeiro', '19500108',1)

SELECT * FROM Cliente

--Abrir outra query e executar o SELECT aaixo com o usuario "teste"
USE TreinamentoPROCEDURE

CREATE PROCEDURE retornarClientes
AS
BEGIN
	SELECT *
	FROM Cliente
	ORDER BY Nm_Cliente
END
GO

EXEC retornarClientes

-- LIBERAR A PERMISSAO NA PROCEDURE DE OUTROS USUARIOS
GRANT EXECUTE ON retornarClientes TO nomeUsuario