CREATE FUNCTION ufn_CheckIfMatches(@sequence nvarchar(100), @characters nvarchar(100))
RETURNS INT
BEGIN
	DECLARE @sequenceLength int = LEN(@sequence)
	DECLARE @index int = 1
	DECLARE @currentSymbol nvarchar(1)
	
	WHILE(@index <= @sequenceLength)
	BEGIN
		SET @currentSymbol = LOWER(SUBSTRING(@sequence, @index, 1));
		IF(CHARINDEX(@currentSymbol, LOWER(@characters)) <= 0)
		BEGIN
			RETURN 0
		END

		SET @index = @index + 1
	END

	RETURN 1
END
GO

CREATE FUNCTION ufn_ReturnMatches (@characters nvarchar(100))
RETURNS @result TABLE(Match nvarchar(100))
BEGIN
	INSERT @result
	SELECT Match
	FROM
		(SELECT e.FirstName
		 FROM Employees e
         UNION
         SELECT e.LastName
		 FROM Employees e
         UNION 
         SELECT t.Name
		 FROM Towns t) as temp(Match)
    WHERE dbo.ufn_CheckIfMatches(Match, @characters) > 0

	RETURN
END

GO

SELECT *
 FROM dbo.ufn_ReturnMatches('oistmiahf')