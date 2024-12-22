-- Create the Customers table
CREATE TABLE Customers (
    Id INT PRIMARY KEY NOT NULL,        -- Primary Key, non-nullable
    Name VARCHAR(100) NULL,             -- Name, nullable
    Password VARCHAR(10) NULL,          -- Password, nullable
    Ph_no VARCHAR(10) NOT NULL          -- Phone number, non-nullable
);

-- Create the Inventory table
CREATE TABLE Inventory (
    Fid INT PRIMARY KEY NOT NULL,       -- Primary Key, non-nullable
    Fname VARCHAR(100) NULL,            -- Name, nullable
    Rate DECIMAL(18, 0) NULL            -- Rate, nullable
);

-- Create the Stock table
CREATE TABLE Stock (
    Fid INT PRIMARY KEY NOT NULL,       -- Primary Key, non-nullable
    Qty INT NULL                        -- Quantity, nullable
);

-- Create the Token_Money table
CREATE TABLE Token_Money (
    Id INT PRIMARY KEY NOT NULL,        -- Primary Key, non-nullable
    Balance DECIMAL(18, 0) NULL         -- Balance, nullable
);


-- Insert data into Customers
INSERT INTO Customers (Id, Name, Password, Ph_no)
VALUES 
(1, 'John Doe', 'pass123', '1234'),
(2, 'Jane Smith', 'secure1', '5678'),
(3, 'Alice Brown', 'mypwd99', '9012'),
(4, 'Bob White', 'qwerty22', '3456'),
(5, 'Charlie Black', 'zxcvb77', '7890');

-- Insert data into Inventory
INSERT INTO Inventory (Fid, Fname, Rate)
VALUES 
(101, 'Oats', 17),
(102, 'Maggie', 15),
(103, 'Butter', 7),
(104, 'Chocolate', 20),
(105, 'Bread', 10);

-- Insert data into Stock
INSERT INTO Stock (Fid, Qty)
VALUES 
(101, 5),
(102, 10),
(103, 7),
(104, 20),
(105, 15);

-- Insert data into Token_Money
INSERT INTO Token_Money (Id, Balance)
VALUES 
(1, 300),
(2, 300),
(3, 300),
(4, 300),
(5, 300);
