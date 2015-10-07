SELECT FirstName + ' ' + LastName AS 'Full name', Salary, d.Name AS Department
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT MIN(Salary) FROM Employees empl
	 WHERE e.DepartmentID = empl.DepartmentID)