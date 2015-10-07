SELECT d.Name, e.JobTitle, MIN(e.Salary) AS MinSalary, MIN(e.FirstName + ' ' + e.LastName) AS Employee
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle