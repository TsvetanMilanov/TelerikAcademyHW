CREATE PROCEDURE usp_SelectPeopleWithBalanceBiggerThan (@minimumBalance money)
AS
	SELECT *
	FROM Persons p
		JOIN Accounts a
		on p.Id = a.PersonId
	WHERE a.Balance > @minimumBalance
GO

EXEC usp_SelectPeopleWithBalanceBiggerThan 25000