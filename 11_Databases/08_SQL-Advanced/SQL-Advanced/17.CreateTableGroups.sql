CREATE TABLE Groups (
	GroupId int IDENTITY,
	Name nvarchar(100) UNIQUE,
	CONSTRAINT PK_GroupId PRIMARY KEY (GroupId)
)