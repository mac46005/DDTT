CREATE TABLE [dbo].[SelfEmploymentTaxAndDeductionWK_Config]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Year] DATETIME2 NOT NULL, 
    [Line3] MONEY NOT NULL, 
    [Line4] MONEY NOT NULL, 
    [Line5] MONEY NOT NULL, 
    [Line9] MONEY NOT NULL, 
    [Line11] MONEY NOT NULL
)
