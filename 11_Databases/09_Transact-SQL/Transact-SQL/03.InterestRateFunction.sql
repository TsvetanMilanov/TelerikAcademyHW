CREATE FUNCTION ufn_CalculateSumWithInterest (@sum money, @yearlyInterestRate float, @months int)
RETURNS money
BEGIN
	DECLARE @monthlyInterestRate float = @yearlyInterestRate / 12;

	RETURN @sum + (@sum * @months * @monthlyInterestRate);
END

GO

SELECT FirstName, LastName, dbo.ufn_CalculateSumWithInterest(a.Balance, 7, 5) AS NewBalance
FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId