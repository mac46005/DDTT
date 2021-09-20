CREATE PROCEDURE [dbo].[spIncome_ThisYear]
	@Today DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM((BasePay + Tip)) AS TotalIncome
	FROM dbo.Incomes
	WHERE YEAR(@Today) = YEAR(TimeStamp)
END
