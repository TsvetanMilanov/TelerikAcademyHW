DBCC DROPCLEANBUFFERS;

GO

SELECT *
FROM Logs
WHERE '1990-01-01' < [Date] AND [Date] < '1995-01-01'
-- Search in the Logs table without index on Date column -> 0:18 min.

GO

CREATE NONCLUSTERED INDEX IDX_Logs_Date
ON Logs([Date])
INCLUDE (Id, [Text])

GO

DBCC DROPCLEANBUFFERS;

GO

SELECT *
FROM Logs
WHERE '1990-01-01' < [Date] AND [Date] < '1995-01-01'
-- Search in the Logs table with index on Date column -> 0:01 min.

GO

DBCC DROPCLEANBUFFERS;

GO

SELECT *
FROM Logs
WHERE [Text] LIKE '%abc%'
-- Search in the Text column without a fulltext index -> 0:18 min.

GO

CREATE FULLTEXT CATALOG LogsFullTextCatalog
WITH ACCENT_SENSITIVITY = OFF

GO

CREATE FULLTEXT INDEX ON Logs([Text])
KEY INDEX PK_Logs_Id
ON LogsFullTextCatalog
WITH CHANGE_TRACKING AUTO

GO

DBCC DROPCLEANBUFFERS;

GO

SELECT *
FROM Logs
WHERE [Text] LIKE '%abc%'
-- Search in the Text column with a fulltext index -> 0:14 min.

GO