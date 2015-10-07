SELECT e.FirstName, e.LastName, ISNULL(CONVERT(nvarchar(50), e.ManagerID), '(no manager)') AS Manager
FROM Employees e