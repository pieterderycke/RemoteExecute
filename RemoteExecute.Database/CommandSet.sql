CREATE TABLE [dbo].[CommandSet]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [AK_CommandSet_Name] UNIQUE ([Name]) 
)
