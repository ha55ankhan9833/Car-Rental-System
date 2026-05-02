-------------Table Creation---------------------
CREATE TABLE Cars (
    CarID INT PRIMARY KEY IDENTITY(1,1),
    CarName VARCHAR(50) NOT NULL,
    Model VARCHAR(20) NOT NULL,
    RentPerDay DECIMAL(10,2) NOT NULL CHECK (RentPerDay > 0),
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('Available', 'Booked'))
)

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName VARCHAR(50) NOT NULL,
    Phone VARCHAR(15) NOT NULL UNIQUE,
    CNIC VARCHAR(20) NOT NULL UNIQUE
)

CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    CarID INT NOT NULL,
    BookingDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    Status VARCHAR(20) DEFAULT 'Booked',

    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (CarID) REFERENCES Cars(CarID),

    CHECK (ReturnDate >= BookingDate)
)

CREATE TABLE Returns (
    ReturnID INT PRIMARY KEY IDENTITY(1,1),
    BookingID INT NOT NULL,
    ActualReturnDate DATE NOT NULL DEFAULT GETDATE(),

    FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID)
)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50),
    Password VARCHAR(50)
);

INSERT INTO Users VALUES ('admin','123')
-------------Record Insertion-----------------------

INSERT INTO Cars (CarName, Model, RentPerDay, Status) VALUES
('Corolla', '2022', 5000, 'Available'),
('Civic', '2023', 7000, 'Available'),
('City', '2021', 4500, 'Available'),
('Mehran', '2018', 2000, 'Available'),
('Alto', '2020', 3000, 'Available'),
('Cultus', '2019', 3500, 'Available'),
('Fortuner', '2023', 15000, 'Available'),
('Sportage', '2022', 12000, 'Available'),
('Vitz', '2021', 4000, 'Available'),
('Swift', '2022', 4200, 'Available'),
('Elantra', '2023', 8000, 'Available'),
('Sonata', '2023', 14000, 'Available'),
('Hilux', '2022', 13000, 'Available'),
('BRV', '2021', 6000, 'Available'),
('HRV', '2022', 9000, 'Available'),
('Accord', '2020', 10000, 'Available'),
('Passo', '2019', 3800, 'Available'),
('WagonR', '2020', 3200, 'Available'),
('Prius', '2022', 8500, 'Available'),
('Land Cruiser', '2023', 20000, 'Available')

INSERT INTO Customers (CustomerName, Phone, CNIC) VALUES
('Ali Khan', '03001234567', '35202-1234567-1'),
('Ahmed Raza', '03011234567', '35202-1234567-2'),
('Hassan Ali', '03021234567', '35202-1234567-3'),
('Usman Tariq', '03031234567', '35202-1234567-4'),
('Bilal Ahmed', '03041234567', '35202-1234567-5'),
('Zain Malik', '03051234567', '35202-1234567-6'),
('Saad Khan', '03061234567', '35202-1234567-7'),
('Omer Farooq', '03071234567', '35202-1234567-8'),
('Hamza Ali', '03081234567', '35202-1234567-9'),
('Talha Riaz', '03091234567', '35202-1234567-0'),
('Fahad Khan', '03101234567', '35202-2234567-1'),
('Imran Ali', '03111234567', '35202-2234567-2'),
('Noman Iqbal', '03121234567', '35202-2234567-3'),
('Adnan Shah', '03131234567', '35202-2234567-4'),
('Kashif Ali', '03141234567', '35202-2234567-5'),
('Rizwan Khan', '03151234567', '35202-2234567-6'),
('Danish Ali', '03161234567', '35202-2234567-7'),
('Awais Khan', '03171234567', '35202-2234567-8'),
('Shahid Ali', '03181234567', '35202-2234567-9'),
('Jawad Ahmed', '03191234567', '35202-2234567-0')

INSERT INTO Bookings (CustomerID, CarID, BookingDate, ReturnDate) VALUES
(1,1,'2026-04-01','2026-04-03'),
(2,2,'2026-04-02','2026-04-05'),
(3,3,'2026-04-03','2026-04-06'),
(4,4,'2026-04-04','2026-04-07'),
(5,5,'2026-04-05','2026-04-08'),
(6,6,'2026-04-06','2026-04-09'),
(7,7,'2026-04-07','2026-04-10'),
(8,8,'2026-04-08','2026-04-11'),
(9,9,'2026-04-09','2026-04-12'),
(10,10,'2026-04-10','2026-04-13'),
(11,11,'2026-04-11','2026-04-14'),
(12,12,'2026-04-12','2026-04-15'),
(13,13,'2026-04-13','2026-04-16'),
(14,14,'2026-04-14','2026-04-17'),
(15,15,'2026-04-15','2026-04-18'),
(16,16,'2026-04-16','2026-04-19'),
(17,17,'2026-04-17','2026-04-20'),
(18,18,'2026-04-18','2026-04-21'),
(19,19,'2026-04-19','2026-04-22'),
(20,20,'2026-04-20','2026-04-23')

INSERT INTO Returns (BookingID, ActualReturnDate) VALUES
(1,'2026-04-03'),
(2,'2026-04-05'),
(3,'2026-04-06'),
(4,'2026-04-07'),
(5,'2026-04-08'),
(6,'2026-04-09'),
(7,'2026-04-10'),
(8,'2026-04-11'),
(9,'2026-04-12'),
(10,'2026-04-13'),
(11,'2026-04-14'),
(12,'2026-04-15'),
(13,'2026-04-16'),
(14,'2026-04-17'),
(15,'2026-04-18'),
(16,'2026-04-19'),
(17,'2026-04-20'),
(18,'2026-04-21'),
(19,'2026-04-22'),
(20,'2026-04-23')
--------------viewing all records-----------------
select * from Cars
select * from Customers
select * from Bookings
select * from Returns

--------------Stored Procedures-------------------
------------Car Insertion-------------
CREATE PROCEDURE AddCar
    @CarName VARCHAR(50),
    @Model VARCHAR(20),
    @Rent DECIMAL(10,2),
    @Status VARCHAR(20)
AS
BEGIN
    INSERT INTO Cars (CarName, Model, RentPerDay, Status)
    VALUES (@CarName, @Model, @Rent, @Status);
END

--------------update car-----------
CREATE PROCEDURE UpdateCar
    @CarID INT,
    @CarName VARCHAR(50),
    @Model VARCHAR(20),
    @Rent DECIMAL(10,2),
    @Status VARCHAR(20)
AS
BEGIN
    UPDATE Cars
    SET CarName = @CarName,
        Model = @Model,
        RentPerDay = @Rent,
        Status = @Status
    WHERE CarID = @CarID;
END
--------------Delete Car-----------
CREATE PROCEDURE DeleteCar
    @CarID INT
AS
BEGIN
    DELETE FROM Cars WHERE CarID = @CarID;
END

---------------Customer Insertion----------
CREATE PROCEDURE AddCustomer
    @Name VARCHAR(50),
    @Phone VARCHAR(15),
    @CNIC VARCHAR(20)
AS
BEGIN
    INSERT INTO Customers (CustomerName, Phone, CNIC)
    VALUES (@Name, @Phone, @CNIC);
END
-------------Update Customer------------
CREATE PROCEDURE UpdateCustomer
    @CustomerID INT,
    @Name VARCHAR(50),
    @Phone VARCHAR(15),
    @CNIC VARCHAR(20)
AS
BEGIN
    UPDATE Customers
    SET CustomerName = @Name,
        Phone = @Phone,
        CNIC = @CNIC
    WHERE CustomerID = @CustomerID;
END
------------Delete Customer------------
CREATE PROCEDURE DeleteCustomer
    @CustomerID INT
AS
BEGIN
    DELETE FROM Customers WHERE CustomerID = @CustomerID;
END
--------------Booking Procedure--------
CREATE PROCEDURE BookCar
    @CustomerID INT,
    @CarID INT,
    @BookingDate DATE,
    @ReturnDate DATE
AS
BEGIN
    INSERT INTO Bookings (CustomerID, CarID, BookingDate, ReturnDate)
    VALUES (@CustomerID, @CarID, @BookingDate, @ReturnDate);
END
------------Return Procedure------------
CREATE PROCEDURE ReturnCar
    @BookingID INT
AS
BEGIN
    INSERT INTO Returns (BookingID)
    VALUES (@BookingID);

    UPDATE Bookings
    SET Status = 'Returned'
    WHERE BookingID = @BookingID;
END

-------------------------------------Triggers----------------------------
---------------When Car is Booked → Status = Booked--------------
CREATE TRIGGER trg_BookCar
ON Bookings
AFTER INSERT
AS
BEGIN
    UPDATE Cars
    SET Status = 'Booked'
    WHERE CarID IN (SELECT CarID FROM inserted);
END

----------------Trigger: When Car is Returned → Status = Available----------
CREATE TRIGGER trg_ReturnCar
ON Returns
AFTER INSERT
AS
BEGIN
    UPDATE Cars
    SET Status = 'Available'
    WHERE CarID IN (
        SELECT b.CarID
        FROM Bookings b
        JOIN inserted i ON b.BookingID = i.BookingID
    );
END

SELECT * FROM Bookings WHERE CustomerID = 21

DELETE FROM Bookings
WHERE CustomerID = 21;

DELETE FROM Customers
WHERE CustomerID = 21;

select * from Customers

----------Calculate total rent---------
CREATE FUNCTION CalculateRent (
    @BookingID INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @days INT, @rent DECIMAL(10,2);

    SELECT @days = DATEDIFF(DAY, BookingDate, ReturnDate),
           @rent = c.RentPerDay
    FROM Bookings b
    JOIN Cars c ON b.CarID = c.CarID
    WHERE b.BookingID = @BookingID;

    RETURN @days * @rent;
END

select * from bookings 
select * from Cars
select dbo.CalculateRent(22) as TotalRent