CREATE TABLE TipoCliente(
	i_tipoCliente INT PRIMARY KEY IDENTITY(0,1),
	s_descTipoCliente VARCHAR(100) NOT NULL
);

CREATE TABLE Cliente(
	i_cliente INT PRIMARY KEY NOT NULL IDENTITY(0,1),
	s_nome VARCHAR(50) NOT NULL,
	s_cpf VARCHAR(11) NOT NULL,
	d_nasc DATETIME
);
ALTER TABLE Cliente ADD i_tipo INT NOT NULL;
ALTER TABLE Cliente ALTER COLUMN d_nasc DATE;
-- ALTER TABLE <tabela_origem> ADD CONSTRAINT <nome_restricao> FOREIGN KEY (<campo_tabela_origem>) REFERENCES <tabela_destino> (<campo_tabela_destino>);
ALTER TABLE Cliente ADD CONSTRAINT FK_tipoCliente FOREIGN KEY (i_tipo) REFERENCES TipoCliente (i_tipoCliente);

INSERT INTO TipoCliente VALUES ('Pessoa Fisica');
INSERT INTO TipoCliente VALUES ('Pessoa Juridica');
INSERT INTO TipoCliente VALUES ('Especial');

INSERT INTO Cliente VALUES ('Lucio de Freitas Pereira','10245452702','1992/11/26',1);
INSERT INTO Cliente VALUES ('Sergio Lucio','51692354845','1957/11/27',2);
INSERT INTO Cliente VALUES ('Joao Marques','34343434343','1945/03/20',1);
INSERT INTO Cliente VALUES ('Bonefácio Fernandes','54545454545','1967/01/30',0);
INSERT INTO Cliente VALUES ('Marcelo Almeida','12121212121','1963/12/21',2);
INSERT INTO Cliente VALUES ('Pedro Siqueira','24242424242','1998/05/14',1);
INSERT INTO Cliente VALUES ('Jaqueline Passos','39393939393','1966/09/25',2);
INSERT INTO Cliente VALUES ('Marcelo Rezende','79797979797','1955/10/01',0);
INSERT INTO Cliente (s_nome,s_cpf,i_tipo) VALUES ('Joao Guilherme','52485698741',1);

UPDATE Cliente SET d_nasc = '1998/06/14' FROM Cliente WHERE i_cliente = 9; 

CREATE TABLE Cliente_aux(
	i_cliente INT PRIMARY KEY NOT NULL IDENTITY(0,1),
	s_nome VARCHAR(50) NOT NULL,
	s_cpf VARCHAR(11) NOT NULL,
	d_nasc DATETIME
);
ALTER TABLE Cliente_aux ADD i_tipo_aux INT NOT NULL;
-- ALTER TABLE <tabela_origem> ADD CONSTRAINT <nome_restricao> FOREIGN KEY (<campo_tabela_origem>) REFERENCES <tabela_destino> (<campo_tabela_destino>);
ALTER TABLE Cliente_aux ADD CONSTRAINT FK_tipoCliente_aux FOREIGN KEY (i_tipo_aux) REFERENCES TipoCliente (i_tipoCliente);

INSERT INTO Cliente_aux(s_nome,s_cpf,d_nasc,i_tipo_aux) SELECT s_nome,s_cpf,d_nasc,i_tipo FROM Cliente;


UPDATE Cliente SET s_nome='Lucio F Pereira' WHERE i_cliente = 1;


-----------------------------------------------------------------------------

CREATE TABLE Venda(
	i_venda INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	i_cliente INT NOT NULL,
	d_data DATE,
	f_valor FLOAT 
);
ALTER TABLE Venda ADD CONSTRAINT FK_Venda FOREIGN KEY (i_cliente) REFERENCES Cliente (i_cliente);


SELECT DISTINCT i_cliente FROM Venda;

SELECT i_cliente FROM Cliente;



INSERT INTO Cliente VALUES ((SELECT MAX(c.i_cliente)+1 AS i_cliente FROM Cliente c),'Vespertino','1212452147','1999-05-14',1);
-----------------------------------------------------------------------------

SELECT c.* FROM (SELECT * FROM Cliente) c;


CREATE VIEW nomesClientes AS SELECT i_cliente, s_nome FROM Cliente;

SELECT * FROM nomesClientes

CREATE VIEW AniversarioMesAtual AS SELECT i_cliente, s_nome, DAY(d_nasc) AS 'Dia Aniversário' FROM Cliente WHERE MONTH(d_nasc) = MONTH(CAST(GETDATE() AS DATE));

SELECT * FROM AniversarioMesAtual;


SELECT * FROM Cliente WHERE s_cpf  like '%0%';

SELECT c.*, tc.s_descTipoCliente FROM Cliente c INNER JOIN TipoCliente tc ON c.i_tipo = tc.i_tipoCliente;

-----------------------------------------------------------------------------

SELECT c.*, tc.s_descTipoCliente FROM Cliente c INNER JOIN TipoCliente tc ON c.i_tipo = tc.i_tipoCliente;

SELECT v.*, c.s_nome,tc.s_descTipoCliente FROM Venda v INNER JOIN Cliente c ON v.i_cliente = c.i_cliente INNER JOIN TipoCliente tc ON v.i_cliente = tc.i_tipoCliente; 

SELECT COUNT (i_cliente) AS [QUANTIDADE DE CLIENTES], i_tipo AS [TIPOS DE CLIENTES] FROM Cliente GROUP BY i_tipo;

SELECT v.d_data, COUNT (v.i_venda) AS [QUANTIDADE DE VENDAS DO DIA] FROM Venda v GROUP BY d_data;
SELECT v.d_data, COUNT (v.i_venda) AS [QUANTIDADE DE VENDAS DO DIA] FROM Venda v GROUP BY d_data HAVING d_data > '2020-10-01';

SELECT * FROM Cliente ORDER BY right (s_cpf,3); -- ordenando pelos 3 ultimos digitos do cpf

insert into cliente values ('Valkisneide','11223344556',null,1);
insert into cliente values ('Alcinclésio','65544332211',null,2);
insert into cliente values ('Nestisgerson','74125896300',null,3);
insert into cliente values ('Mordonório','36925814799',null,1);
insert into cliente values ('Mordonório','36925814799',null,2)
insert into cliente values ('Salomildo','98765432147',null,3);

SELECT * FROM Cliente WHERE d_nasc > '1940-01-01' AND s_nome LIKE 'M%';
SELECT * FROM Cliente WHERE d_nasc > '1940-01-01' OR s_nome LIKE 'M%';
SELECT * FROM Cliente WHERE  NOT i_tipo = 1;

SELECT TOP 5 * FROM Cliente;

SELECT * FROM Venda WHERE f_valor = (SELECT MIN(f_valor) FROM Venda);

SELECT ROUND(SUM(f_valor),2) FROM Venda;
SELECT ROUND(AVG(f_valor),2) FROM Venda;
SELECT ROUND(SUM(f_valor),2) FROM Venda;
SELECT COUNT(f_valor) AS 'QUANTIDADE VENDAS', ROUND(AVG(f_valor),2) FROM Venda WHERE f_valor > (SELECT MIN(f_valor) FROM Venda) AND f_valor < (SELECT MAX(f_valor) FROM Venda);

SELECT * FROM Cliente WHERE right(s_cpf,3) IN (242,702,343);	 
SELECT * FROM Cliente WHERE d_nasc IN(
	SELECT d_nasc FROM Cliente WHERE d_nasc > '1960-01-01' AND
	d_nasc < '2010-01-01'
);

SELECT * FROM Cliente WHERE i_tipo BETWEEN 1 AND 10;

SELECT * FROM Venda WHERE
(d_data BETWEEN '2020-07-01' AND '2020-11-01') AND
i_cliente NOT IN (3,10) AND f_valor > 20;

SELECT * FROM Cliente c1, Cliente c2 WHERE c1.i_tipo = c2.i_tipo ORDER BY c1.i_tipo;

SELECT 'Cliente' AS Tabela, * FROM Cliente 
UNION
SELECT 'ClienteAux',* FROM Cliente_aux;

SELECT * FROM Cliente c WHERE  EXISTS(SELECT * FROM Venda v WHERE v.i_cliente = c.i_cliente);
SELECT * FROM Cliente c WHERE i_cliente = (SELECT i_cliente FROM Venda);

SELECT 
	i_cliente,
	s_nome,
	s_cpf,
	CASE
		WHEN d_nasc IS NULL THEN CURRENT_TIMESTAMP
		ELSE d_nasc
	END 'd_nasc',
	i_tipo,
	CASE
	WHEN (DATEDIFF(YEAR,CURRENT_TIMESTAMP,d_nasc)) >18 THEN 'Maior'
	ELSE 'Menor'
	END 'Maior ou Menor Idade'
FROM Cliente;

----------------------------------------------------
UPDATE produtovenda SET i_qtde=null WHERE i_venda =2;

SELECT *,(f_precoun * ISNULL(i_qtde,0)) AS 'TOTAL' FROM produtovenda;

SELECT * FROM produtovenda;

DROP PROCEDURE IF EXISTS canal
GO
CREATE PROCEDURE canal(
	@Curso VARCHAR(50) = 'SQL' 
)
AS
BEGIN
	DECLARE @x VARCHAR(50)
	SET @x = 'youtube.com/cfbcursos'
	SELECT @x AS CANAL,@Curso AS CURSO
END
GO

EXEC canal

 DROP PROCEDURE IF EXISTS idade
 GO
 CREATE PROCEDURE idade(
 @idCliente INT,
 @idade INT OUTPUT,
 @res VARCHAR(10) OUTPUT
 )
 AS
 BEGIN
	DECLARE @dt DATETIME
	SET @dt = (SELECT d_nasc FROM Cliente WHERE i_cliente = @idCliente)
	SET @idade = DATEDIFF(YEAR, @dt,CURRENT_TIMESTAMP);
		IF(@idade >=18)
			SET @res = 'Maior';
		ELSE
			SET @res = 'Menor';
 END
 GO
 DECLARE @idadeCliente INT
 DECLARE @res VARCHAR(10)
 EXEC idade 1,@idadeCliente OUTPUT, @res OUTPUT
 SELECT @idadeCliente AS Idade, @res AS 'MAIOR OU MENOR';


 DROP PROCEDURE IF EXISTS loopWhile
 GO
 CREATE PROCEDURE loopWhile(
	@max INT,
	@soma INT OUTPUT
 )
AS
BEGIN 
DECLARE @x INT = 0
	WHILE(@x < @max)
	BEGIN
		SET @x = @x + 1;
	END
	SET @soma = @x;
END

DECLARE @ret INT;
EXEC loopWhile 10,@ret
SELECT @ret
---------------------------------------


---------------------------------------

SELECT * FROM Cliente_aux;
SELECT * FROM Cliente;
SELECT * FROM TipoCliente
SELECT * FROM Venda;


create table produtovenda(
 i_produtovenda int NOT NULL IDENTITY(1,1),
    i_venda int NOT NULL,
    s_dscproduto varchar(50) NOT NULL,
    f_precoun float NOT NULL,
    i_qtde int,
    PRIMARY KEY (i_produtovenda),
    FOREIGN KEY (i_venda) REFERENCES venda (i_venda)
);

