SELECT e.FirstName, e.LastName, m.FirstName AS ManagerFirstName, m.LastName AS ManagerLastName
FROM Employees e JOIN Employees m ON e.ManagerID = m.EmployeeID