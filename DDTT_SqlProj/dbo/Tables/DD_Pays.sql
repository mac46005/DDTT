CREATE TABLE [dbo].[DD_Pays]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Amount] MONEY NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [TipId] INT NULL
)
