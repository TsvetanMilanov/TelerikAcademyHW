SELECT COUNT(*)
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name LIKE 'Sales'