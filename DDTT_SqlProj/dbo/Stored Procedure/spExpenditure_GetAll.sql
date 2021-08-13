CREATE PROCEDURE [dbo].[spExpenditure_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,JobTypeId,Amount,TimeStamp,Note,ExpenseTypeId
	FROM dbo.Expenditures;
END
