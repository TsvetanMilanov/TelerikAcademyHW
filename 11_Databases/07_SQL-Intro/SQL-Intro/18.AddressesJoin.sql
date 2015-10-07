SELECT e.FirstName, e.LastName, a.AddressText
FROM Employees e JOIN Addresses a ON e.AddressID = a.AddressID