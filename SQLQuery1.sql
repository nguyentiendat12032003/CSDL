CREATE TABLE Products (
    ProductID INT PRIMARY KEY AUTO_INCREMENT,
    ProductName VARCHAR(255) NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY AUTO_INCREMENT,
    OrderDate DATE NOT NULL,
    CustomerName VARCHAR(255) NOT NULL,
    CustomerAddress VARCHAR(255) NOT NULL
);

CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY AUTO_INCREMENT,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Products (ProductName, UnitPrice, Stock) VALUES
('Laptop', 1000.00, 50),
('Smartphone', 500.00, 100),
('Tablet', 300.00, 75);

INSERT INTO Orders (OrderDate, CustomerName, CustomerAddress) VALUES
('2024-05-01', 'John Doe', '123 Main St'),
('2024-05-03', 'Jane Smith', '456 Elm St');

INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 2, 1000.00),
(1, 2, 1, 500.00),
(2, 3, 3, 300.00);
