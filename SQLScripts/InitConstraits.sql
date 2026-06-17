-- Primary Key Constraints

ALTER TABLE Role ADD CONSTRAINT PK_Role PRIMARY KEY (RoleID);
ALTER TABLE Staff ADD CONSTRAINT PK_Staff PRIMARY KEY (StaffID);
ALTER TABLE Genre ADD CONSTRAINT PK_Genre PRIMARY KEY (GenreID);
ALTER TABLE Publisher ADD CONSTRAINT PK_Publisher PRIMARY KEY (PublisherID);
ALTER TABLE MasterAuthor ADD CONSTRAINT PK_MasterAuthor PRIMARY KEY (AuthorID);
ALTER TABLE MasterBooks ADD CONSTRAINT PK_MasterBooks PRIMARY KEY (BookID);
ALTER TABLE CopiesOfBook ADD CONSTRAINT PK_CopiesOfBook PRIMARY KEY (CopyID);
ALTER TABLE Members ADD CONSTRAINT PK_Members PRIMARY KEY (MemberID);
ALTER TABLE Loans ADD CONSTRAINT PK_Loans PRIMARY KEY (LoanID);
ALTER TABLE Location ADD CONSTRAINT PK_Location PRIMARY KEY (LocationID);
ALTER TABLE Shifts ADD CONSTRAINT PK_Shifts PRIMARY KEY (ShiftID);

-- Foreign Key Constraints

ALTER TABLE Staff ADD CONSTRAINT FK_Staff_Role FOREIGN KEY (RoleID) REFERENCES Role (RoleID);
ALTER TABLE MasterBooks ADD CONSTRAINT FK_MasterBooks_Author FOREIGN KEY (AuthorID) REFERENCES MasterAuthor (AuthorID);
ALTER TABLE MasterBooks ADD CONSTRAINT FK_MasterBooks_Genre FOREIGN KEY (GenreID) REFERENCES Genre (GenreID);
ALTER TABLE MasterBooks ADD CONSTRAINT FK_MasterBooks_Publisher FOREIGN KEY (PublisherID) REFERENCES Publisher (PublisherID);
ALTER TABLE CopiesOfBook ADD CONSTRAINT FK_CopiesOfBook_MasterBooks FOREIGN KEY (BookID) REFERENCES MasterBooks (BookID);
ALTER TABLE Loans ADD CONSTRAINT FK_Loans_CopiesOfBook FOREIGN KEY (CopyID) REFERENCES CopiesOfBook (CopyID);
ALTER TABLE Loans ADD CONSTRAINT FK_Loans_Members FOREIGN KEY (MemberID) REFERENCES Members (MemberID);
ALTER TABLE Loans ADD CONSTRAINT FK_Loans_Staff FOREIGN KEY (IssuedByStaffID) REFERENCES Staff (StaffID);
ALTER TABLE Location ADD CONSTRAINT FK_Location_CopiesOfBook FOREIGN KEY (CopyID) REFERENCES CopiesOfBook (CopyID);
ALTER TABLE Shifts ADD CONSTRAINT FK_Shifts_Staff FOREIGN KEY (StaffID) REFERENCES Staff (StaffID);

-- Permissions

GRANT SELECT ON Role TO [csharp];
GRANT SELECT ON Staff TO [csharp];
GRANT SELECT ON Genre TO [csharp];
GRANT SELECT ON Publisher TO [csharp];
GRANT SELECT ON MasterAuthor TO [csharp];
GRANT SELECT ON MasterBooks TO [csharp];
GRANT SELECT ON CopiesOfBook TO [csharp];
GRANT SELECT ON Members TO [csharp];
GRANT SELECT ON Loans TO [csharp];
GRANT SELECT ON Location TO [csharp];
GRANT SELECT ON Shifts TO [csharp];

