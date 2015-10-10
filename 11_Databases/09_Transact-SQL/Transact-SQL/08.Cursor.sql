DECLARE @employeeId int
DECLARE EmployeeCursor CURSOR
FOR
SELECT Employees.EmployeeID
FROM Employees

OPEN EmployeeCursor

FETCH NEXT FROM EmployeeCursor INTO @employeeId

CREATE TABLE #tempTable (Name nvarchar(50), Town nvarchar(50))

WHILE @@FETCH_STATUS = 0
BEGIN
	INSERT INTO #tempTable
	SELECT e.FirstName, t.Name
	FROM Employees e
		JOIN Addresses a
		ON e.AddressID = a.AddressID
		JOIN Towns t
		ON a.TownID = t.TownID
	WHERE EmployeeID = @employeeId

	FETCH NEXT FROM EmployeeCursor INTO @employeeId	
END

SELECT Town, Name
FROM #tempTable
GROUP BY Town, Name

CLOSE EmployeeCursor
DROP TABLE #tempTable