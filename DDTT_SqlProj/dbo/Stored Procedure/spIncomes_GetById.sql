CREATE PROCEDURE [dbo].[spIncomes_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,JobTypeId,BasePay,Tip,TimeStamp
	FROM dbo.Incomes
	WHERE Id = @Id;
END