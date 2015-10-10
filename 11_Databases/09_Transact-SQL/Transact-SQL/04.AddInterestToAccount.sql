CREATE PROCEDURE usp_AddInterestToPersonAccountForOneMonth(@accountId int, @interestRate float)
AS
	UPDATE Accounts
	SET Balance = dbo.ufn_CalculateSumWithInterest(
			Balance, @interestRate, 1
		)
	WHERE Id = @accountId
GO

EXEC usp_AddInterestToPersonAccountForOneMonth 1, 5

SELECT *
FROM Accounts