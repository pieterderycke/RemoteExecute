CREATE TABLE [dbo].[Command]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Type] INT NOT NULL,
	[Text] NTEXT NOT NULL,
	[CommandSetId] INT NOT NULL, 
    CONSTRAINT [FK_Command_CommandSet] FOREIGN KEY ([CommandSetId]) REFERENCES [CommandSet]([Id])
)
