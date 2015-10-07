SELECT t.Name, COUNT(*) AS ManagersInTown
FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name, e.ManagerID
HAVING e.ManagerID IS NULL