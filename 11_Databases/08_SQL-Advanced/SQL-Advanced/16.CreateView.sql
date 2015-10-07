CREATE VIEW V_SelectActiveUsers AS
SELECT *
FROM Users
WHERE DATEDIFF(DAY, LastLoginTime, GETDATE()) = 0

GO
/*
SELECT *
FROM V_SelectActiveUsers
*/