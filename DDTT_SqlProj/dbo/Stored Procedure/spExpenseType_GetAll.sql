CREATE PROCEDURE [dbo].[spExpenseType_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,CategoryName
	FROM dbo.ExpenseTypes;
END
