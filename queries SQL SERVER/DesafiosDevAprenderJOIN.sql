/*Todos os clientes que moram na mesma região*/
SELECT a.Region, a.ContactName, b.Region, b.ContactName FROM Customers AS a, Customers AS b WHERE a.Region = b.Region; 

/*Encontrar nome e data de contratação de todos os funcionário que foram contratados no mesmo ano*/
SELECT a.FirstName,a.HireDate, b.FirstName, b.HireDate FROM Employees AS a, Employees AS b WHERE DATEPART(YEAR,a.HireDate) = DATEPART(YEAR,b.HireDate);

/*Encontrar na tabela detalho do pedido [Order Details] quais os produtos tem o mesmo percentual de desconto*/
SELECT a.ProductID, a.Discount, b.ProductID, b.Discount FROM [Order Details] AS a, [Order Details] AS b WHERE a.Discount = b.Discount;

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM [Order Details];