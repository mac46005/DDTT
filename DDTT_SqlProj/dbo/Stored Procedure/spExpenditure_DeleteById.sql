CREATE PROCEDURE [dbo].[spExpenditure_DeleteById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.Expenditures
	WHERE Id = @Id;
END
