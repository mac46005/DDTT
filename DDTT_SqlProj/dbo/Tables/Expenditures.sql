CREATE TABLE [dbo].[Expenditures]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Amount] MONEY NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [Note] NVARCHAR(150) NULL, 
    [ExpenseTypeId] INT NOT NULL
)
