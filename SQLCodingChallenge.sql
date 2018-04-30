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
(),(),();