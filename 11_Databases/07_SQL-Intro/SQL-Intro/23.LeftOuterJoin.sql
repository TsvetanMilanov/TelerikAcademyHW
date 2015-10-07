SELECT e.FirstName, e.LastName, m.FirstName AS ManagerFirstName, m.LastName AS ManagerLastName
FROM Employees e LEFT OUTER JOIN Employees m ON e.ManagerID = m.EmployeeID