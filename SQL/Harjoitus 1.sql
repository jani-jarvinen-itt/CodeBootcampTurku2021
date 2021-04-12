
-- Harjoitus 1.1: "Kaikki suomalaiset asiakkaat"
SELECT * FROM Customers
WHERE Country = 'Finland'

-- Harjoitus 1.2: "Kaikki tilaukset asiakkaalle 'Que Delícia'"
SELECT *
FROM Orders, Customers
WHERE Orders.CustomerID = Customers.CustomerID AND
Customers.CompanyName = 'Que Delícia'

SELECT *
FROM Orders
INNER JOIN Customers
ON Orders.CustomerID = Customers.CustomerID
WHERE CompanyName = 'Que Delícia'

SELECT *
FROM Orders
WHERE CustomerID = (
	SELECT CustomerID
	FROM Customers
	WHERE CompanyName = 'Que Delícia'
)


-- Harjoitus 1.3: "Kaikki työntekijät Lontoosta"
SELECT *
FROM Employees
WHERE City = 'London'
