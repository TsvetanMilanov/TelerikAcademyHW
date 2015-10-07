SELECT FirstName, LastName
FROM Employees
WHERE EmployeeID IN (
	SELECT e.ManagerID
	FROM Employees e
	GROUP BY e.ManagerID
	HAVING COUNT(e.EmployeeID) = 5)