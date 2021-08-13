﻿CREATE PROCEDURE [dbo].[spExpenditure_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,JobTypeId,Amount,TimeStamp,ExpenseTypeId,Note
	FROM dbo.Expenditures
	WHERE Id = @Id;
END