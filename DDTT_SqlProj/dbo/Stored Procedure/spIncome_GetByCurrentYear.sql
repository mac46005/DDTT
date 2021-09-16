CREATE PROCEDURE [dbo].[spIncome_GetByCurrentYear]
	@Year INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM((BasePay + Tip)) AS TotalYearly
	FROM dbo.Incomes
	WHERE YEAR(TimeStamp) = @Year
END