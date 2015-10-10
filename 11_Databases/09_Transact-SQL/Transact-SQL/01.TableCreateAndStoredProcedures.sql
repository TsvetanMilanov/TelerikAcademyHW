CREATE TABLE Persons (
	Id int IDENTITY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN int,
	CONSTRAINT PK_PersonId PRIMARY KEY (Id)
)

GO

CREATE TABLE Accounts (
	Id int IDENTITY,
	PersonId int,
	Balance money,
	CONSTRAINT PK_AccountId PRIMARY KEY (Id),
	CONSTRAINT FK_PersonId FOREIGN KEY (PersonId) REFERENCES Persons(Id)
)

GO

INSERT INTO Persons
VALUES('FirstName 1', 'LastName 1', 18334864)
INSERT INTO Persons
VALUES('FirstName 2', 'LastName 2', 78334864)
INSERT INTO Persons
VALUES('FirstName 3', 'LastName 3', 48334864)

GO

INSERT INTO Accounts
VALUES(1, 25000)
INSERT INTO Accounts
VALUES(2, 45000)
INSERT INTO Accounts
VALUES(3, 100000)

GO

CREATE PROC usp_SelectFullNameOfAllPersons
AS
	SELECT FirstName + ' ' + LastName AS FullName
	FROM Persons
GO

EXEC usp_SelectFullNameOfAllPersons