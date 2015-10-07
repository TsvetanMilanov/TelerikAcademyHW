BEGIN TRAN

ALTER TABLE WorkHours
DROP CONSTRAINT FK_EmployeeId
ALTER TABLE EmployeesProjects
DROP CONSTRAINT FK_EmployeesProjects_Employees
ALTER TABLE Departments
DROP CONSTRAINT FK_Departments_Employees

ALTER TABLE WorkHours
ADD CONSTRAINT FK_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId) ON DELETE CASCADE
ALTER TABLE EmployeesProjects
ADD CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId) ON DELETE CASCADE
ALTER TABLE Departments
ADD CONSTRAINT FK_Departments_Employees FOREIGN KEY (ManagerId) REFERENCES Employees(EmployeeId) ON DELETE CASCADE

DELETE Employees

ROLLBACK TRAN