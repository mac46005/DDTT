CREATE PROCEDURE [dbo].[spIncome_DeleteById]
	@Id INT
AS
BEGIN
	DELETE FROM dbo.Incomes
	WHERE Id = @Id;
END