UPDATE Users
SET [Password] = NULL
WHERE (DATEDIFF(DAY, LastLoginTime, GETDATE()) - DATEDIFF(DAY, '2010-03-10', GETDATE()) > 0) OR LastLoginTime IS NULL