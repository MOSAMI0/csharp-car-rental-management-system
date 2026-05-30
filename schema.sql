-- =========================================================================
-- Car Rental Management System Database Schema
-- DBMS: Microsoft SQL Server
-- Created for: csharp-car-rental-management-system
-- =========================================================================

-- Create Database
CREATE DATABASE Car_Rental;
GO

USE Car_Rental;
GO

-- 1. Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(50) NOT NULL
);

-- Seed Default Admin User
INSERT INTO Users (Username, Password, Role) 
VALUES ('admin', '1234', 'Admin');
GO

-- 2. Makes Table
CREATE TABLE Makes (
    MakeID INT IDENTITY(1,1) PRIMARY KEY,
    MakeName NVARCHAR(100) UNIQUE NOT NULL
);

-- Seed Default Makes
INSERT INTO Makes (MakeName) VALUES 
('Toyota'), ('Honda'), ('Ford'), ('Hyundai'), ('Mercedes-Benz'), ('BMW');
GO

-- 3. Models Table
CREATE TABLE Models (
    ModelID INT IDENTITY(1,1) PRIMARY KEY,
    ModelName NVARCHAR(100) UNIQUE NOT NULL
);

-- Seed Default Models
INSERT INTO Models (ModelName) VALUES 
('Camry'), ('Corolla'), ('Civic'), ('Accord'), ('Mustang'), ('Elantra'), ('C-Class'), ('3 Series');
GO

-- 4. FuelTypes Table
CREATE TABLE FuelTypes (
    FuelTypeID INT IDENTITY(1,1) PRIMARY KEY,
    FuelTypeName NVARCHAR(50) UNIQUE NOT NULL
);

-- Seed Default Fuel Types
INSERT INTO FuelTypes (FuelTypeName) VALUES 
('Petrol'), ('Diesel'), ('Hybrid'), ('Electric');
GO

-- 5. VehicleCategories Table
CREATE TABLE VehicleCategories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(50) UNIQUE NOT NULL
);

-- Seed Default Categories
INSERT INTO VehicleCategories (CategoryName) VALUES 
('Sedan'), ('SUV'), ('Sports'), ('Luxury'), ('Hatchback');
GO

-- 6. Car_Details Helper/Lookup Table
-- This handles the distinct combinations of Models, Categories, FuelTypes, and Years
CREATE TABLE Car_Details (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    MakeID INT FOREIGN KEY REFERENCES Makes(MakeID) ON DELETE CASCADE,
    ModelID INT FOREIGN KEY REFERENCES Models(ModelID) ON DELETE CASCADE,
    CategoryID INT FOREIGN KEY REFERENCES VehicleCategories(CategoryID) ON DELETE CASCADE,
    FuelTypeID INT FOREIGN KEY REFERENCES FuelTypes(FuelTypeID) ON DELETE CASCADE,
    Year INT NOT NULL
);

-- Seed Default Car Details Configurations
INSERT INTO Car_Details (MakeID, ModelID, CategoryID, FuelTypeID, Year) VALUES
(1, 1, 1, 1, 2023), -- Toyota Camry Sedan Petrol
(1, 1, 1, 3, 2024), -- Toyota Camry Sedan Hybrid
(1, 2, 1, 1, 2022), -- Toyota Corolla Sedan Petrol
(2, 3, 1, 1, 2023), -- Honda Civic Sedan Petrol
(3, 5, 3, 1, 2024), -- Ford Mustang Sports Petrol
(4, 6, 1, 1, 2023), -- Hyundai Elantra Sedan Petrol
(5, 7, 4, 1, 2024), -- Mercedes C-Class Luxury Petrol
(6, 8, 4, 2, 2023); -- BMW 3 Series Luxury Diesel
GO

-- 7. Vehicles Table
CREATE TABLE Vehicles (
    VehicleID INT IDENTITY(1,1) PRIMARY KEY,
    MakeID INT NOT NULL FOREIGN KEY REFERENCES Makes(MakeID),
    ModelID INT NOT NULL FOREIGN KEY REFERENCES Models(ModelID),
    Year INT NOT NULL,
    FuelTypeID INT NOT NULL FOREIGN KEY REFERENCES FuelTypes(FuelTypeID),
    CategoryID INT NOT NULL FOREIGN KEY REFERENCES VehicleCategories(CategoryID),
    PlateNumber NVARCHAR(50) UNIQUE NOT NULL,
    Mileage INT NOT NULL,
    RentalPricePerDay DECIMAL(18,2) NOT NULL,
    IsAvailableForRent BIT DEFAULT 1 NOT NULL,
    ImagePath NVARCHAR(500) NULL
);

-- Seed Default Vehicles
INSERT INTO Vehicles (MakeID, ModelID, Year, FuelTypeID, CategoryID, PlateNumber, Mileage, RentalPricePerDay, IsAvailableForRent) VALUES
(1, 1, 2023, 1, 1, 'T-CAM-99', 15000, 50.00, 1),
(1, 2, 2022, 1, 1, 'T-COR-12', 22000, 35.00, 1),
(2, 3, 2023, 1, 1, 'H-CIV-55', 8000,  40.00, 1),
(3, 5, 2024, 1, 3, 'F-MUS-01', 3000,  120.00, 1),
(5, 7, 2024, 1, 4, 'M-BENZ-7', 5000,  150.00, 1);
GO

-- 8. Customer Table
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    ContactInformation NVARCHAR(200) NULL,
    DriverLicenseNumber NVARCHAR(50) UNIQUE NOT NULL,
    ImagePath NVARCHAR(500) NULL
);

-- Seed Default Customers
INSERT INTO Customer (Name, ContactInformation, DriverLicenseNumber) VALUES
('John Doe', 'john.doe@example.com | +1 555-0199', 'DL-987654321'),
('Alice Smith', 'alice.smith@example.com | +1 555-0245', 'DL-123456789'),
('Bob Johnson', 'bob.johnson@example.com | +1 555-0312', 'DL-456789123');
GO

-- 9. RentalBooking Table
CREATE TABLE RentalBooking (
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customer(CustomerID) ON DELETE CASCADE,
    VehicleID INT NOT NULL FOREIGN KEY REFERENCES Vehicles(VehicleID) ON DELETE CASCADE,
    RentalStartDate DATETIME NOT NULL,
    RentalEndDate DATETIME NOT NULL,
    PickupLocation NVARCHAR(250) NULL,
    DropoffLocation NVARCHAR(250) NULL,
    InitialRentalDays INT NOT NULL,
    RentalPricePerDay DECIMAL(18,2) NOT NULL,
    InitialTotalDueAmount DECIMAL(18,2) NOT NULL,
    InitialCheckNotes NVARCHAR(MAX) NULL,
    StartMileage INT NOT NULL
);
GO

-- 10. VehicleReturns Table
CREATE TABLE VehicleReturns (
    ReturnID INT IDENTITY(1,1) PRIMARY KEY,
    BookingID INT NOT NULL FOREIGN KEY REFERENCES RentalBooking(BookingID) ON DELETE CASCADE,
    ActualReturnDate DATETIME NOT NULL,
    ActualRentalDays INT NOT NULL,
    Mileage INT NOT NULL, -- Ending Mileage
    ConsumedMileage INT NOT NULL,
    FinalCheckNotes NVARCHAR(MAX) NULL,
    AdditionalCharges DECIMAL(18,2) DEFAULT 0 NOT NULL,
    ActualTotalDueAmount DECIMAL(18,2) NOT NULL
);
GO

-- 11. RentalTransaction Table
CREATE TABLE RentalTransaction (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    BookingID INT NOT NULL FOREIGN KEY REFERENCES RentalBooking(BookingID),
    ReturnID INT NULL FOREIGN KEY REFERENCES VehicleReturns(ReturnID),
    PaymentMethod NVARCHAR(50) NOT NULL,
    PaidAmount DECIMAL(18,2) NOT NULL,
    ActualAmount DECIMAL(18,2) NOT NULL,
    RemainingAmount AS (ActualAmount - PaidAmount),
    RefundAmount AS (CASE WHEN PaidAmount > ActualAmount THEN PaidAmount - ActualAmount ELSE 0 END),
    TransactionDate DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- 12. VehicleMaintenance Table
CREATE TABLE VehicleMaintenance (
    MaintenanceID INT IDENTITY(1,1) PRIMARY KEY,
    VehicleID INT NOT NULL FOREIGN KEY REFERENCES Vehicles(VehicleID) ON DELETE CASCADE,
    Description NVARCHAR(MAX) NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
    IsCompleted BIT DEFAULT 0 NOT NULL,
    MaintenanceDate DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- 13. VehicleMaintenanceHistory Table
CREATE TABLE VehicleMaintenanceHistory (
    HistoryID INT IDENTITY(1,1) PRIMARY KEY,
    MaintenanceID INT NOT NULL,
    VehicleID INT NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Cost DECIMAL(18,2) NOT NULL,
    MaintenanceDate DATETIME NOT NULL
);
GO

-- =========================================================================
-- Views Creation
-- =========================================================================

-- View for Active Bookings (Not yet returned)
CREATE VIEW vw_ActiveBookings AS
SELECT 
    b.BookingID,
    c.Name AS CustomerName,
    v.PlateNumber,
    b.RentalStartDate,
    b.RentalEndDate,
    b.InitialRentalDays,
    b.RentalPricePerDay,
    b.InitialTotalDueAmount,
    (c.Name + ' - ' + v.PlateNumber + ' (' + CONVERT(NVARCHAR(10), b.RentalStartDate, 120) + ')') AS BookingInfo
FROM RentalBooking b
INNER JOIN Customer c ON b.CustomerID = c.CustomerID
INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
LEFT JOIN VehicleReturns r ON b.BookingID = r.BookingID
WHERE r.ReturnID IS NULL;
GO
