CREATE SCHEMA Aggregates;

GO

CREATE ASSEMBLY CustomAggregates
   AUTHORIZATION dbo
   FROM 'E:\Ceco\Telerik\HomeWork\11_Databases\09_Transact-SQL\Transact-SQL\Transact-SQL\SqlStringConcat\bin\Debug\SqlStringConcat.dll'
   WITH PERMISSION_SET = SAFE;

CREATE AGGREGATE Aggregates.StrConcat(@sequence nvarchar(100)) RETURNS nvarchar(MAX)
   EXTERNAL NAME CustomAggregates.[SqlStringConcat.StringConcat];
   
EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO
EXEC sp_configure 'clr enabled'
GO

SELECT Aggregates.StrConcat(FirstName + ' ' + LastName)
FROM Employees