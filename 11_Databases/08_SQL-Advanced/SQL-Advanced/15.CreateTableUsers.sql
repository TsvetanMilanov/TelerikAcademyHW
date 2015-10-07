CREATE TABLE Users (
	UserId int IDENTITY,
	Username nvarchar(50) NOT NULL UNIQUE,
	[Password] nvarchar(150) CHECK(LEN(LTRIM(RTRIM([Password])))>=5),
	FullName nvarchar(100) NOT NULL,
	LastLoginTime datetime default GETDATE(),
	CONSTRAINT PK_UserId PRIMARY KEY (UserId)
)