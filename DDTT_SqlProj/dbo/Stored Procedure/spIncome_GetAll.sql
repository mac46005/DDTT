CREATE PROCEDURE [dbo].[spIncome_GetAll]
AS
BEGIN
	SELECT Id,JobTypeId,BasePay,Tip,TimeStamp
	FROM dbo.Incomes;
END
