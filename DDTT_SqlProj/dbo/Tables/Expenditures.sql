CREATE TABLE [dbo].[Expenditures]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [JobTypeId] INT NOT NULL,
    [Amount] MONEY NOT NULL, 
    [TimeStamp] DATETIME2 NOT NULL, 
    [ExpenseTypeId] INT NOT NULL, 
    [Note] NVARCHAR(150) NULL, 
    
    CONSTRAINT [FK_Expenditures_ExpenseTypesTable] FOREIGN KEY ([ExpenseTypeId]) REFERENCES [ExpenseTypes]([Id]), 
    CONSTRAINT [FK_Expenditures_ToJobType] FOREIGN KEY (JobTypeId) REFERENCES [JobTypes]([Id])
)
