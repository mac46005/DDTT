CREATE PROCEDURE [dbo].[spIncome_ThisMonth]
	@Today DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM((BasePay + Tip)) AS TOTALINCOME
	FROM dbo.Incomes
	WHERE YEAR(@Today) = YEAR(TimeStamp) AND MONTH(@Today) = MONTH(TimeStamp)
END
