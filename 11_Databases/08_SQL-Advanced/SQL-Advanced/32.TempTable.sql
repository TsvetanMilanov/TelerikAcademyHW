SELECT *
INTO #TempTable
FROM EmployeesProjects

DROP TABLE EmployeesProjects

SELECT *
INTO EmployeesProjects
FROM #TempTable

DROP TABLE #TempTable