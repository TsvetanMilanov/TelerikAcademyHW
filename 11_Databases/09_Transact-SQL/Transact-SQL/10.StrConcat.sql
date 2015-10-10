SELECT t.Name AS 'Town Name', Aggregates.StrConcat(e.FirstName + ' ' + e.LastName) AS 'People In Town'
FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name