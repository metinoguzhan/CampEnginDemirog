use Northwind


--SELECT 
SELECT * FROM Customers

SELECT ContactName,CompanyName,City FROM Customers

SELECT ContactName Adi,CompanyName SirketAdi,City Sehir FROM Customers


--WHERE 
SELECT * FROM Customers WHERE City = 'London'

SELECT * FROM Customers WHERE City = 'Berlin'


-- sql case insensitive
SELECT * FROM Products

SELECT * FROM Products WHERE CategoryID = 1 or CategoryID = 3

SELECT * FROM Products WHERE CategoryID = 1 and UnitPrice >= 10


--Order by 

SELECT * FROM Products order by ProductName

SELECT * FROM Products order by CategoryId,ProductName

SELECT * FROM Products order by UnitPrice asc --ascending

SELECT * FROM Products order by UnitPrice desc --descending

SELECT * FROM Products where CategoryID = 1 order by UnitPrice desc 


--Group By 

SELECT COUNT(*) FROM Products

SELECT COUNT(*) FROM Products WHERE CategoryID = 1

SELECT CategoryID,COUNT(*) AS Adet FROM Products GROUP BY CategoryID

SELECT CategoryID,COUNT(*) AS Adet FROM Products GROUP BY CategoryID HAVING COUNT(*)<10

SELECT CategoryID,COUNT(*) AS Adet FROM Products WHERE UnitPrice>20 GROUP BY CategoryID HAVING COUNT(*)<10


--Join Kullanımı

SELECT CategoryName,* 
FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName
FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID


--DTO -> Data Transformaation Object

SELECT Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName
FROM Products
INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
WHERE Products.UnitPrice>10

SELECT * FROM Products P
LEFT JOIN [Order Details] OD ON P.ProductID = OD.ProductID

SELECT * FROM Customers C
LEFT OUTER JOIN Orders O ON C.CustomerID = O.CustomerID 
WHERE O.CustomerId IS NULL

SELECT * FROM Orders O 
RIGHT OUTER JOIN Customers C ON C.CustomerID = O.CustomerID 
WHERE O.CustomerId IS NULL

SELECT * FROM Products P
INNER JOIN [Order Details] OD ON P.ProductID = OD.ProductID
INNER JOIN Orders O ON O.OrderID = OD.OrderID








