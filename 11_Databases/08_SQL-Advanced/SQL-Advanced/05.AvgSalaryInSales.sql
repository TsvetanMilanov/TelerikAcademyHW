SELECT AVG(Salary) AS 'Average Salary in Sales'
FROM Employees e
	JOIN Departments d ON
	e.DepartmentID = d.DepartmentID
WHERE d.Name LIKE 'Sales'