CREATE TABLE Logs (
	LogID int IDENTITY,
	AccountID int,
	OldSum money,
	NewSum money,
	CONSTRAINT PK_LogID PRIMARY KEY (LogID)
)

GO

CREATE TRIGGER tr_UpdateSum ON Accounts
FOR UPDATE
AS
	DECLARE @accountId int;
	DECLARE @oldSum money;
	DECLARE @newSum money;

	SELECT @accountId = a.Id FROM inserted a;
	SELECT @oldSum = a.Balance FROM deleted a;
	SELECT @newSum = a.Balance FROM inserted a;

	INSERT INTO Logs
	VALUES(@accountId, @oldSum, @newSum)
GO

EXEC usp_WithdrawMoney 1, 3000

EXEC usp_DepositMoney 1, 3000

EXEC usp_WithdrawMoney 2, 5000

EXEC usp_DepositMoney 2, 5000

EXEC usp_WithdrawMoney 3, 6000

EXEC usp_DepositMoney 3, 6000

SELECT *
FROM Logs