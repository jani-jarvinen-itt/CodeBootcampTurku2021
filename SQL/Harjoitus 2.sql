
-- Harjoitus 2.1: "Kuinka monta asiakasta Northwindillä on?"
SELECT COUNT(CustomerID) AS 'Lukumäärä'
FROM Customers


-- Harjoitus 2.2: "Mikä on Northwindin varastoarvo tällä hetkellä?"
SELECT SUM(UnitPrice*UnitsInStock) AS 'Varastoarvo'
FROM Products


-- Harjoitus 2.3: "Mikä on Northwindin varastoarvo tällä hetkellä?"
SELECT SUM(UnitPrice * Quantity * (1-Discount))
FROM [Order Details]
WHERE ProductID = 14

SELECT SUM(UnitPrice * Quantity * (1-Discount))
FROM [Order Details]
WHERE ProductID = (
	SELECT ProductId
	FROM Products
	WHERE ProductName = 'Tofu'
)

SELECT SUM(UnitPrice * Quantity * (1-Discount))
FROM [Order Details]
WHERE ProductID IN (
	SELECT ProductId
	FROM Products
	WHERE ProductName LIKE '%Tofu%'
)
