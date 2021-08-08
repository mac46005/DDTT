CREATE PROCEDURE [dbo].[spExpenseType_DeleteById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.ExpenseTypes
	WHERE Id = @Id;
END
