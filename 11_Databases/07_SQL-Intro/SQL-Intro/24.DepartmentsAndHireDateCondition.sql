SELECT FirstName, LastName, d.Name AS DepartmentName, YEAR(e.HireDate) AS HireYear
FROM Employees e JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE ((d.Name LIKE 'Sales' OR d.Name LIKE 'Finance') AND (YEAR(e.HireDate) BETWEEN 1995 AND 2005))