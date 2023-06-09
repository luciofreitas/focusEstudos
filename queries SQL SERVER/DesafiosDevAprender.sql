/*A equipe de producao de produtos precisa do nome de todas as pecas que pesam mais que 500Kg mas nao mais que 700Kg*/
SELECT Name FROM Production.Product WHERE Weight > 500 AND Weight < 700;

/*Foi pedido pelo marketing uma relacao de todos os empregados que sao casados e sao assalariados*/
SELECT * FROM HumanResources.Employee WHERE MaritalStatus = 'M' AND SalariedFlag = 'TRUE';

/*Um usuario chamado Peter Krebs esta devendo um pagamento, consiga o email dele para que possaamos enviar uma cobranca
voce vai ter que usar a tabela person.person e depois a tabela person.emailaddress*/
SELECT * FROM Person.Person WHERE FirstName = 'Peter' AND LastName = 'Krebs';
SELECT * FROM Person.EmailAddress WHERE BusinessEntityID = 26;

/*Quantos produtos temos cadastrados em nossa tabela de produtos*/
SELECT COUNT(*) FROM  Production.Product;

/*Quantos tamanhos de produtos temos cadastrado em nossa tabela*/
SELECT * FROM Production.Product;
SELECT COUNT(Size) FROM Production.Product;

/*Quantos tamanhos unicos de produtos temos cadastrado em nossa tabela*/
SELECT * FROM Production.Product;
SELECT COUNT(DISTINCT Size) FROM Production.Product;

/*Obter o ProductId dos 10 produtos mais caros cadastrados no sistema, listando do mais caro para o mais barato*/
SELECT TOP 10 ProductId, ListPrice FROM Production.Product ORDER BY ListPrice DESC

/*Obter o nome e o numero dos produtos que tem o ProductId entre 1 e 4*/
SELECT TOP 4 Name, ProductNumber FROM Production.Product ORDER BY ProductID ASC;

/*Quantos produtos temos cadastrados no sistema que custam mais que 1500 dolares*/
SELECT COUNT (*) FROM Production.Product WHERE ListPrice > 1500;

/*Quantas pessoas temos com o sobrenome que inicia com a letra P*/
SELECT COUNT(*) FROM Person.Person WHERE LastName LIKE 'p%';

/*Em quantas cidades �nicas est�o cadastrados nossos clientes*/
SELECT COUNT(DISTINCT City) FROM Person.Address;

/*Quais s�o as cidades unicas que temos cadastrados em nosso sistema*/
SELECT DISTINCT City FROM Person.Address;

/*Quantos produtos vermelhos tem preco entrew 500 a 1000 dolares*/
SELECT COUNT(Color) FROM Production.Product WHERE Color='red' AND ListPrice BETWEEN 500 AND 1000;

/*Quantos produtos cadastrados tem a palavra 'road' no nome deles*/
SELECT COUNT(*) FROM Production.Product WHERE Name LIKE '%road%';

/*Quantos de cada produto foi vendido at� hoje*/
SELECT ProductID,COUNT(PRODUCTID) FROM Sales.SalesOrderDetail GROUP BY PRODUCTID;

/*Quantos nomes de cada nomes temos cadastrado em nosso banco de dados*/
SELECT FirstName, COUNT(FirstName) AS "CONTAGEM" FROM Person.Person GROUP BY FirstName;

/*A m�dia de pre�o para os produtos que s�o prata*/
SELECT Color, AVG(ListPrice) AS MEDIAPRECO FROM Production.Product WHERE Color = 'silver' GROUP BY Color;

/*Quantas pessoas tem o mesmo MiddleName agrupadas por MiddleName*/
SELECT MiddleName, COUNT(MiddleName) AS TOTAL FROM Person.Person GROUP BY MiddleName;

/*Quantidade que cada produto � vendido na loja*/
SELECT ProductID, SUM(OrderQty) AS TOTAL FROM Sales.SalesOrderDetail GROUP BY ProductID;

/*Quais foram as 10 vendas que no total tiveram os maiores valores de venda(line total) por produto do maior valor para o menor*/
SELECT TOP 10 ProductID, SUM(LineTotal) AS TOTAL FROM Sales.SalesOrderDetail GROUP BY ProductID ORDER BY SUM(LineTotal) DESC;

/*Quantos produtos e qual a quantidade m�dia de produtos temos cadastrados nas nossas ordem de servi�o (workOrder), agrupados por productID*/
SELECT ProductID, COUNT(ProductID) AS CONTAGEM, AVG(OrderQty) AS MEDIA FROM Production.WorkOrder GROUP BY ProductID;

/*Quais nomes no sistema tem uma ocorrencia maior que 10 vezes*/
SELECT FirstName, COUNT(FirstName) AS Quantidade FROM Person.Person GROUP BY FirstName HAVING COUNT(FirstName) > 10;

/*Quais nomes no sistema tem uma ocorrencia maior que 10 vezes, por�m somente onde o t�tulo � 'Mr. '*/
SELECT FirstName, COUNT(FirstName) AS Quantidade FROM Person.Person WHERE Title ='Mr. ' GROUP BY FirstName HAVING COUNT(FirstName) > 10;

/*Quais produtos que no total de vendas est�o entre 162k a 500k*/
SELECT ProductID, SUM(LineTotal) AS TOTAL FROM Sales.SalesOrderDetail GROUP BY ProductID HAVING SUM(LineTotal) BETWEEN 162000 AND 500000;

/*Estamos querendo identificar as prov�ncias (stateProvinceId) com o maior numero de cadastros no nosso sistema, ent�o � preciso encontrar
quais prov�ncias est�o registradas no banco de dados mais que 1000 vezes*/
SELECT StateProvinceID, COUNT(StateProvinceID) AS TOTAL_TERRITORIO FROM Person.Address GROUP BY StateProvinceID HAVING COUNT(StateProvinceID) > 1000; 

/*Sendo que se trata de uma multinacional os gerentes querem saber quais produtos (productID) n�o est�o trazendo em m�dia no m�nimo 1 milh�o em total de vendas (lineTotal)*/
SELECT ProductID, AVG(LineTotal) AS MEDIA_TOTAL FROM Sales.SalesOrderDetail GROUP BY ProductID HAVING NOT AVG(LineTotal) >= 1000000;

/*Encontrar o FirstName e o LastName person.person em portugues*/
SELECT FirstName AS PrimeiroNome, LastName AS UltimoNome FROM Person.Person;

/*ProductNumber da tabela production.product "Numero do produto"*/
SELECT ProductNumber AS "Numero do Produto" FROM Production.Product;

/*Entrar na tabela sales.SalesOrderDetail e renomear unitPrice para Pre�o Unit�rio*/
SELECT UnitPrice AS "PRECO UNITARIO" FROM sales.SalesOrderDetail;

/*Junte as informa��es das seguintes colunas de diferentes tabelas: BusinessEntityId, FirstName, LastName, EmailAddress*/
SELECT TOP 10 * FROM Person.Person;
SELECT TOP 10 * FROM Person.EmailAddress;
SELECT p.BusinessEntityID, p.FirstName, p.LastName, pe.EmailAddress FROM Person.Person AS p INNER JOIN Person.EmailAddress AS pe ON p.BusinessEntityID = pe.BusinessEntityID;

/*Junte as informe��es ListPrice, Nome do Produto, Nome da Subcategoria*/
SELECT TOP 10 p.Name, sc.Name,p.ListPrice FROM Production.Product AS p INNER JOIN Production.ProductSubcategory AS sc ON p.ProductSubcategoryID = sc.ProductSubcategoryID;

/*Juntar todas as colunas das tabelas*/
SELECT TOP 10 * FROM Person.BusinessEntityAddress AS ba INNER JOIN Person.Address pa ON pa.AddressID = ba.AddressID;

/*Juntar as seguintes informa��es BusinessEntityId, Name, PhoneNumberTypeId, PhoneNumber*/
SELECT TOP 10 pp.BusinessEntityID, pn.Name, pp.PhoneNumberTypeID, pp.PhoneNumber FROM Person.PersonPhone AS pp INNER JOIN Person.PhoneNumberType AS pn ON pp.PhoneNumberTypeID = pn.PhoneNumberTypeID;

/*Juntar as seguintes informa��es AddressID, City, StateProvinceId, Nome do Estado*/
SELECT TOP 10 a.AddressID, a.City, sp.StateProvinceID,sp.Name FROM Person.Address AS a INNER JOIN Person.StateProvince AS sp ON a.StateProvinceID = sp.StateProvinceID;

/*Quero descobrir quais pessoas tem um cart�o de credito registrado*/
SELECT * FROM Person.Person AS pp INNER JOIN Sales.PersonCreditCard AS pc ON pp.BusinessEntityID = pc.BusinessEntityID;
-- INNER JOIN: 19118 LINHAS

SELECT * FROM Person.Person AS pp LEFT JOIN Sales.PersonCreditCard AS pc ON pp.BusinessEntityID = pc.BusinessEntityID WHERE pc.BusinessEntityID IS NULL;
--  LEFT JOIN: 19972 LINHAS

/*Fa�a uni�o de duas sele��es de nomes que tenham em algum lugar no nome Chan e Decal */
SELECT ProductID, Name, ProductNumber FROM Production.Product WHERE Name like '%Chain%'
UNION
SELECT ProductID, Name, ProductNumber FROM Production.Product WHERE Name like '%Decal%'
ORDER BY Name

/*Fa�a uni�o de duas sele��es de FirstName, title e middleName com title = 'Mr. ' e middleName = 'A'*/
SELECT FirstName, Title, MiddleName FROM Person.Person WHERE Title ='Mr. '
UNION
SELECT FirstName, Title, MiddleName FROM Person.Person WHERE MiddleName = 'A'

/*Fa�a uni�o de duas sele��es de ProductID, Name, de produtos onde come�am com a Letra A e o ListPrice � maior que 100000*/
SELECT ProductID, Name FROM Production.Product WHERE Name like 'A%'
UNION
SELECT ProductID, Name FROM Production.Product WHERE ListPrice > 100000;

/*DATEPART*/
SELECT TOP 10 SalesOrderID, DATEPART(month,OrderDate) AS Mes FROM Sales.SalesOrderHeader;
SELECT AVG(TotalDue) AS Media, DATEPART(month,OrderDate) AS Mes FROM Sales.SalesOrderHeader GROUP BY DATEPART(month,OrderDate) ORDER BY Mes

/*Opera��es em String*/
SELECT CONCAT(BusinessEntityID, FirstName,' ',LastName) AS NOME_COMPLETO FROM Person.Person;
SELECT UPPER(FirstName) FROM Person.Person;
SELECT LOWER(FirstName) FROM Person.Person;
SELECT LEN(FirstName) FROM Person.Person;
SELECT FirstName, SUBSTRING(FirstName,1,3) FROM Person.Person;
SELECT REPLACE(ProductNumber,'-','#') AS ProductNumber FROM Production.Product;

/*Fun��es Matem�ticas*/
SELECT (UnitPrice + LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT (UnitPrice - LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT (UnitPrice * LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT (UnitPrice / LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT SUM(LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT AVG(LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT MIN(LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT MAX(LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;
SELECT ROUND(LineTotal,2) AS RESULTADO, LineTotal FROM Sales.SalesOrderDetail;
SELECT SQRT(LineTotal) AS RESULTADO FROM Sales.SalesOrderDetail;

/*Montar um relat�rio que tenha todos os produtos cadastrados que tem pre�o de venda acima de m�dia*/
SELECT TOP 10 * FROM Production.Product WHERE ListPrice > (SELECT AVG(ListPrice) FROM Production.Product) ORDER BY ListPrice DESC;

/*O nome dos meus funcion�rios que tem o cargo de "Design Engineer"*/
SELECT FirstName FROM Person.Person WHERE BusinessEntityID IN (SELECT BusinessEntityID FROM HumanResources.Employee WHERE JobTitle = 'Design Engineer');

/*Encontrar todos os endere�os que est�o no estado de 'Alberta' contendo todas as informa��es*/
SELECT * FROM Person.Address WHERE StateProvinceID IN (SELECT StateProvinceID FROM Person.StateProvince WHERE Name ='Alberta'); 

/*Encontrar os 10 produtos que tem a maior quantidade de estoque ordenados do que tem mais para o que tem menos*/
SELECT TOP 10 Name FROM Production.Product WHERE SafetyStockLevel IN (SELECT SafetyStockLevel FROM Production.Product) ORDER BY SafetyStockLevel DESC;


SELECT * FROM Production.Product;
SELECT * FROM Production.ProductSubcategory;
SELECT * FROM Production.WorkOrder;
SELECT * FROM Sales.SalesOrderDetail;
SELECT * FROM Sales.SalesOrderHeader;
SELECT * FROM Person.Person;
SELECT * FROM Person.Address;
SELECT * FROM Person.StateProvince;
SELECT * FROM Person.PhoneNumberType;
SELECT * FROM Person.PersonPhone;
SELECT * FROM HumanResources.Employee;
SELECT * FROM HumanResources.EmployeeDepartmentHistory;