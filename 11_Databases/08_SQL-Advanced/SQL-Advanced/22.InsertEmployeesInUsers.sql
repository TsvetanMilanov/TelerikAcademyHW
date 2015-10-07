INSERT INTO Users (FullName, Username, [Password], LastLoginTime)
SELECT FirstName + ' ' + LastName, SUBSTRING(FirstName, 0, 3) + ISNULL(MiddleName, '') + LOWER(LastName), SUBSTRING(FirstName, 0, 5) + LOWER(LastName), NULL
FROM Employees