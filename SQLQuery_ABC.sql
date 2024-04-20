CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255),
    StockQuantity INT,
    StorageLocation VARCHAR(100)
);


CREATE TABLE Order (
    OrderID INT PRIMARY KEY,
    ProductID INT,
    EmployeeID INT,
    CustomerName VARCHAR(255),
    OrderDate DATE,
    Quantity INT,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);


CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(255),
    Salary DECIMAL(10, 2)
);