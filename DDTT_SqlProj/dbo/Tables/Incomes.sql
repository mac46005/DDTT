CREATE TABLE [dbo].[Incomes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [JobTypeId] INT NOT NULL, 
    [BasePay] MONEY NULL, 
    [Tip] MONEY NULL, 
    [TimeStamp] DATETIME2 NULL
)
