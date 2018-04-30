USE adventureworksLT;
GO

CREATE DATABASE ProductsDb;

USE ProductsDb;
GO

--CREATE SCHEMA SchemaName;
--GO
	
CREATE TABLE Products
(
ID int primary key identity(1,1),
[Name] nvarchar(200) not null,
Price decimal(10,2)
);

CREATE TABLE Orders
(
ID int primary key identity(1,1),
ProductID int,
CustomerID int
);

CREATE TABLE Customers
(
ID int primary key identity(1,1),
Firstname nvarchar(40) not null,
Lastname nvarchar(40) not null,
CardNumber nvarchar(20)
);
GO

-- Products - insert three rows
INSERT INTO Products VALUES 
('Mr. Sparkles Cleaner', 4.99),
('Duff Beer', 3.98),
('Generic Pretzels', 2.99);

-- Customers - insert three rows
INSERT INTO Customers VALUES 
('Homer', 'Simpson', '1234'),
('Marge', 'Simpson', '5678'),
('Barney', 'Gumble', '0000');

-- Orders - insert three rows
INSERT INTO Orders VALUES 
(2, 1),
(1, 2),
(3, 3);

--other reqs
INSERT INTO Products
VALUES ('iPhone', 200);

INSERT INTO Customers
VALUES('Tina', 'Smith');

--create order
INSERT INTO Orders
VALUES(4, 4);

-- report all orders by Tina Smith
SELECT ID, ProductID, CustomerID 
FROM Orders;

SELECT COUNT(*)
FROM Orders
WHERE ProductID = 
	(SELECT ID
	FROM Products
	WHERE [Name] = 'iPhone');

-- increase iphone price to 250
UPDATE Products
SET Price = 250
WHERE [Name] = 'iPhone';

SELECT * FROM Products;
SELECT * FROM Customers;
SELECT * FROM Orders;