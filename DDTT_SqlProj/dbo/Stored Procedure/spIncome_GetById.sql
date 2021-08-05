CREATE PROCEDURE [dbo].[spIncome_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,DD_Pay_Id,Tip_Id
	FROM dbo.Incomes
	WHERE Id = @Id;
END
