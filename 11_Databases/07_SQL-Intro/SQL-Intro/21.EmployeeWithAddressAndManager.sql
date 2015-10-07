SELECT e.FirstName, e.LastName, a.AddressText AS 'Address', m.FirstName AS ManagerFirstName, m.LastName AS ManagerLastName
FROM Employees e JOIN Employees m ON e.ManagerID = m.EmployeeID
JOIN Addresses a ON e.AddressID = a.AddressID