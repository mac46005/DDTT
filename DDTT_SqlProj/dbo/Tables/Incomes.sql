CREATE TABLE [dbo].[Incomes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [JobTypeId] INT NOT NULL, 
    [BasePay] MONEY NOT NULL, 
    [Tip] MONEY NOT NULL, 
    [TimeStamp] NCHAR(10) NOT NULL
)
