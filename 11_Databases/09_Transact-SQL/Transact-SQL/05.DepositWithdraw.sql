CREATE PROCEDURE usp_WithdrawMoney(@accountId int, @money money)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance = Balance - @money
		WHERE Id = @accountId
		
		IF (SELECT Balance FROM Accounts WHERE Id = @accountId) < 0
		BEGIN
			ROLLBACK TRAN
		END
		ELSE
		BEGIN
			COMMIT TRAN
		END
GO

CREATE PROCEDURE usp_DepositMoney(@accountId int, @money money)
AS
	BEGIN TRAN
		UPDATE Accounts
		SET Balance = Balance + @money
		WHERE Id = @accountId
	COMMIT TRAN
GO

EXEC usp_WithdrawMoney 2, 5000

EXEC usp_DepositMoney 2, 5000

SELECT *
FROM Accounts