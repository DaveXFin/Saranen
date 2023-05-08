-- SQLite

-- Part 1 
-- a.
SELECT * FROM Customers
WHERE Country='Finland'

-- b.
SELECT * FROM Orders
WHERE CustomerID = (SELECT CustomerID
					FROM Customers
					WHERE CompanyName = 'Que Delícia')

-- c.
SELECT * FROM Employees
WHERE City = 'London' AND Country = 'UK';

-- Part 2 
-- a.
SELECT COUNT(*) 
FROM Customers

-- b.
SELECT SUM(UnitPrice*UnitsInStock) AS StockValue 
FROM Products 


-- c.

-- Not including the discount
SELECT SUM(UnitPrice*Quantity) AS TofuSales
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

-- Including the discount
SELECT SUM(UnitPrice*Quantity * (1-Discount)) AS TofuSales
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74


