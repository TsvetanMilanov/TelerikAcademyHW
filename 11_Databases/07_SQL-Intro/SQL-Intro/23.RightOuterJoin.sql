SELECT e.FirstName, e.LastName, m.FirstName AS ManagerFirstName, m.LastName AS ManagerLastName
FROM Employees m RIGHT OUTER JOIN Employees e ON e.ManagerID = m.EmployeeID