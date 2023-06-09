/*Quais os departamentos que os 5 funcionários que mais recebem na empresa estão*/
SELECT TOP 5 CONCAT(pp.FirstName,' ',pp.MiddleName,' ',pp.LastName) AS [Nome Completo], hd.Name AS DEPARTAMENTO, heph.Rate AS SALARIO FROM Person.Person pp
JOIN HumanResources.EmployeeDepartmentHistory hed ON pp.BusinessEntityID = hed.BusinessEntityID
JOIN HumanResources.Department hd ON hd.DepartmentID = hed.DepartmentID
JOIN HumanResources.EmployeePayHistory heph ON heph.BusinessEntityID = pp.BusinessEntityID
ORDER BY heph.Rate DESC;

SELECT * FROM HumanResources.EmployeePayHistory;
SELECT * FROM HumanResources.Department;
SELECT * FROM HumanResources.EmployeeDepartmentHistory;
SELECT * FROM Person.Person;

/*Qual dos sexos que mais vendeu na empresa e quanto venderam*/ 
SELECT he.Gender AS SEXO, (ppv.StandardPrice * ppv.OnOrderQty) AS [TOTAL EM $ QUE VENDEU] FROM  HumanResources.Employee he JOIN Purchasing.ProductVendor ppv ON he.BusinessEntityID = ppv.BusinessEntityID
WHERE he.Gender = 'F' AND he.CurrentFlag = 1 ORDER BY (ppv.StandardPrice * ppv.OnOrderQty) DESC;



SELECT * FROM HumanResources.Employee;
SELECT * FROM Purchasing.ProductVendor;
SELECT * FROM Production.Product;




