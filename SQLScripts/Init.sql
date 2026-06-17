-- Library Database Script

-- Create Tables

USE JPULLEN;

CREATE TABLE Role (
    RoleID INT NOT NULL,
    RoleName VARCHAR(100) NOT NULL
);

CREATE TABLE Staff (
    StaffID INT NOT NULL,
    RoleID INT NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NULL,
    PhoneNum VARCHAR(20) NULL,
    DateJoined DATE NOT NULL,
    Status VARCHAR(50) NOT NULL
);

CREATE TABLE Genre (
    GenreID INT NOT NULL,
    GenreName VARCHAR(100) NOT NULL
);

CREATE TABLE Publisher (
    PublisherID INT NOT NULL,
    Name VARCHAR(200) NOT NULL
);

CREATE TABLE MasterAuthor (
    AuthorID INT NOT NULL,
    Name VARCHAR(100) NOT NULL
);

CREATE TABLE MasterBooks (
    BookID INT NOT NULL,
    AuthorID INT NOT NULL,
    GenreID INT NOT NULL,
    PublisherID INT NOT NULL,
    Title VARCHAR(200) NOT NULL,
    ISBN VARCHAR(100) NOT NULL,
);

CREATE TABLE CopiesOfBook (
    CopyID INT NOT NULL,
    BookID INT NOT NULL,
    Barcode VARCHAR(100) NOT NULL,
    Status BIT NOT NULL
);

CREATE TABLE Members (
    MemberID INT NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    PhoneNum VARCHAR(20) NOT NULL,
    DOB DATE NOT NULL,
    DateJoined DATE NOT NULL,
    MembershipExpiry DATE NOT NULL,
    Status VARCHAR(50) NOT NULL
);

CREATE TABLE Loans (
    LoanID INT NOT NULL,
    CopyID INT NOT NULL,
    MemberID INT NOT NULL,
    IssuedByStaffID INT NOT NULL,
    DateIssued DATE NOT NULL,
    DateDue DATE NOT NULL,
    DateReturned DATE NULL
);

CREATE TABLE Location (
    LocationID INT NOT NULL,
    CopyID INT NOT NULL,
    Floor int NOT NULL,
    Section int NOT NULL,
    ShelfUnit int NOT NULL,
    NumberAcross int NOT NULL
);

CREATE TABLE Shifts (
    ShiftID INT NOT NULL,
    StaffID INT NOT NULL,
    ShiftStartDate DATE NOT NULL,
    TimeStart TIME NOT NULL,
    ShiftEndDate DATE NULL,
    TimeEnd TIME NULL
);