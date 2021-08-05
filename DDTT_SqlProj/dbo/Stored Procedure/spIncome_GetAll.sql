CREATE PROCEDURE [dbo].[spIncome_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,DD_Pay_Id,Tip_Id
	FROM dbo.Incomes;
END