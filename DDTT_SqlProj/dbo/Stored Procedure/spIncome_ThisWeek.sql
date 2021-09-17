CREATE PROCEDURE [dbo].[spIncome_ThisWeek]
	@Today DATETIME,
	@Monday DATETIME

AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM((BasePay + Tip))
	FROM dbo.Incomes
	WHERE TimeStamp <= @Today AND TimeStamp >= @Monday;
END