USE Project;

-- Drop tables if they exist
DROP TABLE IF EXISTS WishlistItem;
DROP TABLE IF EXISTS OrderItem;
DROP TABLE IF EXISTS Payment;
DROP TABLE IF EXISTS Review;
DROP TABLE IF EXISTS SellerProduct;
DROP TABLE IF EXISTS Fashion;
DROP TABLE IF EXISTS HomeAppliances;
DROP TABLE IF EXISTS Electronics;
DROP TABLE IF EXISTS Seller;
DROP TABLE IF EXISTS Report;
DROP TABLE IF EXISTS Admin;
DROP TABLE IF EXISTS ShoppingCart;
DROP TABLE IF EXISTS Notifications;
DROP TABLE IF EXISTS Shipments;
DROP TABLE IF EXISTS Orders;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Category;
DROP TABLE IF EXISTS ReviewStatus;


-- Customer Table
CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(16),
    PaymentPreference NVARCHAR(50),
    Address NVARCHAR(150),
    State NVARCHAR(50)
);

-- Admin Table
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    AdminName NVARCHAR(50)
);

-- Seller Table
CREATE TABLE Seller (
    SellerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    Password NVARCHAR(16)
);

-- Orders Table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    OrderDate DATE,
    PaymentOption NVARCHAR(50),
    ShippingOption NVARCHAR(50),
    Status NVARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE
);

-- Category Table
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50)
);


-- Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    CategoryID INT,
    Name NVARCHAR(100),
    Description NVARCHAR(MAX),
    Price DECIMAL(10, 2),
    StockQ INT,
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);



CREATE TABLE ReviewStatus (
    StatusID INT PRIMARY KEY IDENTITY(1,1),
    StatusName NVARCHAR(50)
);
INSERT INTO ReviewStatus (StatusName) VALUES ('Pending');
INSERT INTO ReviewStatus (StatusName) VALUES ('Approved');
INSERT INTO ReviewStatus (StatusName) VALUES ('Rejected');


-- Review Table
CREATE TABLE Review (
    ReviewID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    ProductID INT,
    OrderID INT,
    Rating INT,
    Comment NVARCHAR(MAX),
    StatusId INT
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE NO ACTION,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE NO ACTION,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE NO ACTION,
	FOREIGN KEY (StatusID) REFERENCES ReviewStatus(StatusID) ON DELETE NO ACTION
);

-- ShoppingCart Table
CREATE TABLE ShoppingCart (
    CartID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    ProductID INT,
    Quantity INT,
    AddedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- OrderItem Table
CREATE TABLE OrderItem (
    OrderItemID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- Payment Table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    PaymentMethod NVARCHAR(50),
    PaymentDate DATE,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE
);

-- Fashion Table
CREATE TABLE Fashion (
    ProductID INT PRIMARY KEY,
    FashionProductType NVARCHAR(50),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- Home Appliances Table
CREATE TABLE HomeAppliances (
    ProductID INT PRIMARY KEY,
    HomeAppliancesType NVARCHAR(50),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- Electronics Table
CREATE TABLE Electronics (
    ProductID INT PRIMARY KEY,
    ElectronicsType NVARCHAR(50),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- WishlistItem Table
CREATE TABLE WishlistItem (
    WishlistItemID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    ProductID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- Shipments Table
CREATE TABLE Shipments (
    ShipmentID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT,
    AssignedTo NVARCHAR(100),
    EstimatedDeliveryDate DATE,
    ActualDeliveryDate DATE,
    Status NVARCHAR(50),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID) ON DELETE CASCADE
);

-- Notifications Table
CREATE TABLE Notifications (
    NotificationID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    ShipmentID INT,
    Message NVARCHAR(MAX),
    NotificationDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID) ON DELETE NO ACTION,
    FOREIGN KEY (ShipmentID) REFERENCES Shipments(ShipmentID) ON DELETE CASCADE
);



-- SellerProduct Table
CREATE TABLE SellerProduct (
    SellerProductID INT PRIMARY KEY IDENTITY(1,1),
    SellerID INT,
    ProductID INT,
    FOREIGN KEY (SellerID) REFERENCES Seller(SellerID) ON DELETE CASCADE,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID) ON DELETE CASCADE
);

-- Report Table
CREATE TABLE Report (
    ReportID INT PRIMARY KEY IDENTITY(1,1),
    AdminID INT,
    GeneratedDate DATE,
    ReportType NVARCHAR(50),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID) ON DELETE CASCADE
);


-- Inserting into Customer Table
INSERT INTO Customer (FirstName, LastName, Email, Password, PaymentPreference, Address, State)
VALUES 
('John', 'Doe', 'john.doe@example.com', 'password123', 'Credit Card', '123 Main St, City', 'New York'),
('Jane', 'Smith', 'jane.smith@example.com', 'password456', 'PayPal', '456 Elm St, City', 'California'),
('Michael', 'Johnson', 'michael.johnson@example.com', 'password789', 'Debit Card', '789 Oak St, City', 'Texas'),
('Emily', 'Brown', 'emily.brown@example.com', 'password101', 'Credit Card', '321 Pine St, City', 'Florida'),
('David', 'Williams', 'david.williams@example.com', 'password202', 'PayPal', '654 Maple St, City', 'Nevada'),
('Sarah', 'Davis', 'sarah.davis@example.com', 'password303', 'Debit Card', '987 Birch St, City', 'Ohio');

-- Inserting into Admin Table
INSERT INTO Admin (AdminName)
VALUES 
('Admin1'),
('Admin2'),
('Admin3'),
('Admin4'),
('Admin5'),
('Admin6');

-- Inserting into Seller Table
INSERT INTO Seller (FirstName, LastName, Email, Password)
VALUES 
('Alice', 'Green', 'alice.green@example.com', 'sellerpass123'),
('Bob', 'White', 'bob.white@example.com', 'sellerpass456'),
('Charlie', 'Blue', 'charlie.blue@example.com', 'sellerpass789'),
('Diana', 'Yellow', 'diana.yellow@example.com', 'sellerpass101'),
('Eve', 'Purple', 'eve.purple@example.com', 'sellerpass202'),
('Frank', 'Orange', 'frank.orange@example.com', 'sellerpass303');

-- Inserting into Orders Table
INSERT INTO Orders (CustomerID, OrderDate, PaymentOption, ShippingOption, Status)
VALUES 
(1, '2024-11-01', 'Credit Card', 'Standard', 'Pending'),
(2, '2024-11-02', 'PayPal', 'Express', 'Shipped'),
(3, '2024-11-03', 'Debit Card', 'Standard', 'Delivered'),
(4, '2024-11-04', 'Credit Card', 'Standard', 'Cancelled'),
(5, '2024-11-05', 'PayPal', 'Express', 'Pending'),
(6, '2024-11-06', 'Debit Card', 'Standard', 'Shipped');

-- Inserting into Category Table
INSERT INTO Category (Name)
VALUES 
('Electronics'),
('Fashion'),
('Home Appliances'),
('Books'),
('Toys'),
('Furniture');

-- Inserting into Products Table
INSERT INTO Products (CategoryID, Name, Description, Price, StockQ)
VALUES 
(1, 'Laptop', 'A high-performance laptop', 999.99, 50),
(1, 'Smartphone', 'A latest model smartphone', 799.99, 100),
(2, 'Jacket', 'A warm winter jacket', 49.99, 200),
(2, 'Shoes', 'Comfortable running shoes', 89.99, 150),
(3, 'Washing Machine', 'A large capacity washing machine', 499.99, 30),
(4, 'Novel', 'A bestseller fiction novel', 19.99, 500);

-- Inserting into Review Table
INSERT INTO Review (CustomerID, ProductID, OrderID, Rating, Comment, StatusID)
VALUES 
(1, 1, 1, 5, 'Great product! Highly recommend.', 1),
(2, 2, 2, 4, 'Good quality, but the delivery was late.', 2),
(3, 3, 3, 2, 'The product was damaged upon arrival.', 3),
(4, 4, 4, 3, 'It works, but could be better.', 1),
(5, 5, 5, 5, 'Excellent product! Exceeded expectations.', 2),
(6, 6, 6, 1, 'Terrible product, do not buy!', 3);


-- Inserting into ShoppingCart Table
INSERT INTO ShoppingCart (CustomerID, ProductID, Quantity)
VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 1),
(4, 4, 3),
(5, 5, 1),
(6, 6, 2);

-- Inserting into OrderItem Table
INSERT INTO OrderItem (OrderID, ProductID, Quantity, Price)
VALUES 
(1, 1, 1, 999.99),
(2, 2, 2, 799.99),
(3, 3, 1, 499.99),
(4, 4, 3, 89.99),
(5, 5, 1, 499.99),
(6, 6, 2, 19.99);

-- Inserting into Payment Table
INSERT INTO Payment (OrderID, PaymentMethod, PaymentDate)
VALUES 
(1, 'Credit Card', '2024-11-01'),
(2, 'PayPal', '2024-11-02'),
(3, 'Debit Card', '2024-11-03'),
(4, 'Credit Card', '2024-11-04'),
(5, 'PayPal', '2024-11-05'),
(6, 'Debit Card', '2024-11-06');

-- Inserting into Fashion Table
INSERT INTO Fashion (ProductID, FashionProductType)
VALUES 
(1, 'Laptop Sleeve'),
(2, 'Smartphone Case'),
(3, 'Winter Coat'),
(4, 'Running Shoes'),
(5, 'Washing Machine'),
(6, 'Leather Jacket');

-- Inserting into Home Appliances Table
INSERT INTO HomeAppliances (ProductID, HomeAppliancesType)
VALUES 
(1, 'Laptop'),
(2, 'Smartphone'),
(3, 'Washing Machine'),
(4, 'Dryer'),
(5, 'Refrigerator'),
(6, 'Microwave');

-- Inserting into Electronics Table
INSERT INTO Electronics (ProductID, ElectronicsType)
VALUES 
(1, 'Laptop'),
(2, 'Smartphone'),
(3, 'Washing Machine'),
(4, 'Headphones'),
(5, 'Speaker'),
(6, 'Television');

-- Inserting into WishlistItem Table
INSERT INTO WishlistItem (CustomerID, ProductID)
VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6);

-- Inserting into Shipments Table
INSERT INTO Shipments (OrderID, AssignedTo, EstimatedDeliveryDate, ActualDeliveryDate, Status)
VALUES 
(1, 'Courier1', '2024-11-07', '2024-11-08', 'Delivered'),
(2, 'Courier2', '2024-11-09', '2024-11-10', 'Shipped'),
(3, 'Courier3', '2024-11-11', '2024-11-12', 'Shipped'),
(4, 'Courier4', '2024-11-13', '2024-11-14', 'Pending'),
(5, 'Courier5', '2024-11-15', '2024-11-16', 'Delivered'),
(6, 'Courier6', '2024-11-17', '2024-11-18', 'Shipped');

-- Inserting into Notifications Table
INSERT INTO Notifications (CustomerID, ShipmentID, Message)
VALUES 
(1, 1, 'Your order has been delivered.'),
(2, 2, 'Your order is on the way!'),
(3, 3, 'Your order has been shipped.'),
(4, 4, 'Your order is pending delivery.'),
(5, 5, 'Your order has been delivered.'),
(6, 6, 'Your order has been shipped.');

-- Inserting into SellerProduct Table
INSERT INTO SellerProduct (SellerID, ProductID)
VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6);

-- Inserting into Report Table
INSERT INTO Report (AdminID, GeneratedDate, ReportType)
VALUES 
(1, '2024-11-01', 'Sales Report'),
(2, '2024-11-02', 'Customer Activity Report'),
(3, '2024-11-03', 'Inventory Report'),
(4, '2024-11-04', 'Shipment Report'),
(5, '2024-11-05', 'Payment Report'),
(6, '2024-11-06', 'Order Processing Report');


select * from Shipments

select * from OrderItem
select * from orders
SELECT * from products
SELECT * from ShoppingCart
select * from Notifications
Select * from SellerProduct
select * from Review
select * from ReviewStatus

SELECT 
    CustomerID,
    ProductID,
    SUM(Quantity) AS TotalQuantity,
    MAX(AddedDate) AS LastAddedDate
FROM ShoppingCart
GROUP BY CustomerID, ProductID;

delete from ShoppingCart

--Order update query check
SELECT O.OrderID, 
       C.FirstName + ' ' + C.LastName AS [Customer Name], 
       P.Name AS ProductDetails, 
       OI.Quantity, 
       O.OrderDate, 
       O.Status
FROM Orders O
JOIN Customer C ON O.CustomerID = C.CustomerID
JOIN OrderItem OI ON O.OrderID = OI.OrderID
JOIN Products P ON OI.ProductID = P.ProductID




SELECT O.OrderID, 
       C.FirstName + ' ' + C.LastName AS CustomerName, 
       O.OrderDate, 
       O.Status
FROM Orders O
JOIN Customer C ON O.CustomerID = C.CustomerID
WHERE O.Status IN ('Pending', 'In Progress', 'In Transit')


SELECT r.ReviewID, r.CustomerID, r.ProductID, r.Rating, r.Comment, s.StatusName
FROM Review r
INNER JOIN ReviewStatus s ON r.StatusID = s.StatusID
WHERE r.StatusID = 1;


select * from Customer