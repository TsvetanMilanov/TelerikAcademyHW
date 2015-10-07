SELECT d.Name, e.JobTitle, AVG(e.Salary)
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle