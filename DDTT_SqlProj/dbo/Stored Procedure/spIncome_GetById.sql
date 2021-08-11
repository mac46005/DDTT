CREATE PROCEDURE [dbo].[spIncome_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,JobTypeId,BasePay,Tip,TimeStamp
	FROM dbo.Incomes
	WHERE Id = @Id;
END
