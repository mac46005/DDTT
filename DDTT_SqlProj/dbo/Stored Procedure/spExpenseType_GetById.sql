CREATE PROCEDURE [dbo].[spExpenseType_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,CategoryName
	FROM dbo.ExpenseTypes
	WHERE Id = @Id;
END
