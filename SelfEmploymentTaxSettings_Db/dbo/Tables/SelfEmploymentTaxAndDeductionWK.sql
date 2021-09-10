CREATE TABLE [dbo].[SelfEmploymentTaxAndDeductionWK]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATETIME2 NOT NULL, 
    [Line1a] MONEY NOT NULL, 
    [Lineb] MONEY NOT NULL, 
    [Line2] MONEY NOT NULL, 
    [Line3] MONEY NOT NULL, 
    [Line4] MONEY NOT NULL, 
    [Line5] MONEY NOT NULL, 
    [Line6] MONEY NOT NULL, 
    [Line7] MONEY NOT NULL, 
    [Line8] MONEY NOT NULL, 
    [Line9] MONEY NOT NULL, 
    [Line10] MONEY NOT NULL, 
    [Line11] MONEY NOT NULL
)
