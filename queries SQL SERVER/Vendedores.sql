CREATE TABLE [Vendedores](
	MATRICULA CHAR(5) PRIMARY KEY NOT NULL,
	NOME_COMPLETO VARCHAR(100),
	CIDADE VARCHAR(100),
	PERCENTUAL_COMISSAO FLOAT,
	DATA_INICIO DATE,
	TEM_DEPENDENTE BIT
)

INSERT INTO [Vendedores]
VALUES(
'00285',
'Maria Joaquina',
'Vitoria',
0.3,
'2022-11-24',
'TRUE'
)

UPDATE [Vendedores] SET PERCENTUAL_COMISSAO = PERCENTUAL_COMISSAO +1 WHERE TEM_DEPENDENTE = 1; 


UPDATE [Vendedores]
SET NOME_COMPLETO = 'Joao Siqueira Freitas'
WHERE MATRICULA = '00255'


SELECT  * FROM [Vendedores] WHERE PERCENTUAL_COMISSAO > 0.08;

SELECT * FROM [Vendedores];

SELECT * FROM [Vendedores] WHERE YEAR(DATA_INICIO) = 2021;

-- DROP TABLE [VENDEDORES]
