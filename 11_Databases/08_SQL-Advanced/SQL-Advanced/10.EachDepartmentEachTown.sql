SELECT t.Name AS Town, d.Name AS Department, COUNT(e.EmployeeID) AS 'Employees in department'
FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, t.Name
ORDER BY t.Name