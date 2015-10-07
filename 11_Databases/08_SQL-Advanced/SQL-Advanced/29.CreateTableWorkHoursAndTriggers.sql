CREATE TABLE WorkHours (
	ReportId int IDENTITY,
	EmployeeId int NOT NULL,
	[Date] datetime NOT NULL default GETDATE(),
	Task nvarchar(100) NOT NULL,
	[Hours] int NOT NULL,
	Comment nvarchar(200) NOT NULL,
	CONSTRAINT PK_ReportId PRIMARY KEY (ReportId),
	CONSTRAINT FK_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId)
)

CREATE TABLE WorkHoursLogs (
	LogId int IDENTITY,
	ReportId int NOT NULL,
	EmployeeId int NOT NULL,
	[Date] datetime NOT NULL default GETDATE(),
	Task nvarchar(100) NOT NULL,
	[Hours] int NOT NULL,
	Comment nvarchar(200) NOT NULL,
	CommandType nvarchar(20) NOT NULL,
	CONSTRAINT PK_LogId PRIMARY KEY (LogId)
)

GO

CREATE TRIGGER tr_AfterInsertInWorkHours ON dbo.WorkHours
FOR INSERT
AS
DECLARE @reportId int;
DECLARE @employeeId int;
DECLARE @date datetime;
DECLARE @task nvarchar(100);
DECLARE @hours int;
DECLARE @comment nvarchar(200);

SELECT @reportId = r.ReportId FROM inserted r;
SELECT @employeeId = r.EmployeeId FROM inserted r;
SELECT @date = r.[Date] FROM inserted r;
SELECT @task = r.Task FROM inserted r;
SELECT @hours = r.[Hours] FROM inserted r;
SELECT @comment = r.Comment FROM inserted r;

INSERT INTO WorkHoursLogs (ReportId, EmployeeId, [Date], Task, [Hours], Comment, CommandType)
VALUES(@reportId, @employeeId, @date, @task, @hours, @comment, 'INSERT')

GO

CREATE TRIGGER tr_AfterUpdateInWorkHours ON dbo.WorkHours
FOR UPDATE
AS
DECLARE @reportId int;
DECLARE @employeeId int;
DECLARE @date datetime;
DECLARE @task nvarchar(100);
DECLARE @hours int;
DECLARE @comment nvarchar(200);

SELECT @reportId = r.ReportId FROM inserted r;
SELECT @employeeId = r.EmployeeId FROM inserted r;
SELECT @date = r.[Date] FROM inserted r;
SELECT @task = r.Task FROM inserted r;
SELECT @hours = r.[Hours] FROM inserted r;
SELECT @comment = r.Comment FROM inserted r;

INSERT INTO WorkHoursLogs (ReportId, EmployeeId, [Date], Task, [Hours], Comment, CommandType)
VALUES(@reportId, @employeeId, @date, @task, @hours, @comment, 'UPDATE')

GO

CREATE TRIGGER tr_AfterDeleteInWorkHours ON dbo.WorkHours
AFTER DELETE
AS
DECLARE @reportId int;
DECLARE @employeeId int;
DECLARE @date datetime;
DECLARE @task nvarchar(100);
DECLARE @hours int;
DECLARE @comment nvarchar(200);

SELECT @reportId = r.ReportId FROM deleted r;
SELECT @employeeId = r.EmployeeId FROM deleted r;
SELECT @date = r.[Date] FROM deleted r;
SELECT @task = r.Task FROM deleted r;
SELECT @hours = r.[Hours] FROM deleted r;
SELECT @comment = r.Comment FROM deleted r;

INSERT INTO WorkHoursLogs (ReportId, EmployeeId, [Date], Task, [Hours], Comment, CommandType)
VALUES(@reportId, @employeeId, @date, @task, @hours, @comment, 'DELETE')

GO

INSERT INTO WorkHours (EmployeeId, Task, [Hours], Comment)
VALUES(1, 'Task 1', 5, 'Comment 1')

INSERT INTO WorkHours (EmployeeId, Task, [Hours], Comment)
VALUES(1, 'Task 2', 6, 'Comment 2')

INSERT INTO WorkHours (EmployeeId, Task, [Hours], Comment)
VALUES(1, 'Task 3', 7, 'Comment 3')

GO

UPDATE WorkHours
SET [Hours] = 8
WHERE ReportId = 1

GO

DELETE WorkHours
WHERE ReportId = 2
