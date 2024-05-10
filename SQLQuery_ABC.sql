CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255),
    StockQuantity INT,
    StorageLocation VARCHAR(100)
);

CREATE TABLE [Employee] (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(255),
    Salary DECIMAL(10, 2)
);

CREATE TABLE [Order] (
    OrderID INT PRIMARY KEY,
    ProductID INT,
    EmployeeID INT,
    CustomerName VARCHAR(255),
    OrderDate DATE,
    Quantity INT,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

INSERT INTO Product (ProductID, ProductName, StockQuantity, StorageLocation)
VALUES
    (1, 'Desk Lamp', 50, 'A1'),
    (2, 'Office Chair', 100, 'B2'),
    (3, 'Computer Monitor', 75, 'C3'),
    (4, 'Keyboard', 80, 'D4'),
    (5, 'Mouse', 90, 'E5'),
    (6, 'Printer', 30, 'F6'),
    (7, 'Desk', 20, 'G7'),
    (8, 'Filing Cabinet', 40, 'H8'),
    (9, 'Whiteboard', 15, 'I9'),
    (10, 'Scanner', 25, 'J10');

INSERT INTO Employee (EmployeeID, EmployeeName, Salary)
VALUES
    (1, 'John Doe', 50000.00),
    (2, 'Jane Smith', 55000.00),
    (3, 'Michael Johnson', 60000.00),
    (4, 'Emily Brown', 52000.00),
    (5, 'David Wilson', 58000.00);

INSERT INTO [Order] (OrderID, ProductID, EmployeeID, CustomerName, OrderDate, Quantity)
VALUES
    (1, 1, 1, 'Alice Johnson', '2024-04-20', 2),
    (2, 3, 2, 'Bob Smith', '2024-04-21', 1),
    (3, 5, 3, 'Charlie Brown', '2024-04-22', 3),
    (4, 2, 4, 'Diana Wilson', '2024-04-23', 2),
    (5, 4, 5, 'Emma Davis', '2024-04-24', 1);
