CREATE PROCEDURE [dbo].[spIncome_GetById]
	@Id = id
AS
BEGIN
	SET NOCOUNT ON;
	SELECT FROM dbo.Incomes
	WHERE Id = @Id+
END
