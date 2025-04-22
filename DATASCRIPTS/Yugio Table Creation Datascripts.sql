
GO 

USE ytcg-eguideDB;

GO



CREATE TABLE StarterPack(
	Id int IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL,
	[Type] NVARCHAR(64) NOT NULL,
	FrameType NVARCHAR(16),
	[Description] NVARCHAR(128) NOT NULL,
	Atk int NOT NULL, 
	Def int NOT NULL,
	[Level] int NOT NULL,
	Race NVARCHAR(32) NOT NULL,
	Attribute NVARCHAR(32) NOT NULL,
	ImageURL NVARCHAR(256) 
);

GO 

CREATE TABLE [User](
	Id int IDENTITY(1,1) PRIMARY KEY,
	Username VARCHAR(32) NOT NULL,
	[Password] VARCHAR(64) NOT NULL,
	
	);

GO

CREATE TABLE OwnedCards(
UserId int FOREIGN KEY REFERENCES [User](Id),
StarterId int FOREIGN KEY REFERENCES StarterPack(Id),
IsOwned BIT,
);

GO 
INSERT INTO [User] Values ('Guest', '00000000'
);

SELECT * FROM [User];
SELECT * FROM [ytcg-eguideDB];