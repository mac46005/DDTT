CREATE TABLE [dbo].[Mileages]
(
    
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JobTypeId] INT NOT NULL,
    [Amount] MONEY NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_Mileages_ToJobType] FOREIGN KEY ([JobTypeId]) REFERENCES [JobTypes]([Id])
)
