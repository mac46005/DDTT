CREATE PROCEDURE [dbo].[spExpenseType_Insert]
	/*@Id INT OUTPUT,*/
	@CategoryName NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.ExpenseTypes(CategoryName)
	VALUES(@CategoryName)
	/*SELECT @Id = SCOPE_IDENTITY();*/
END
