CREATE PROCEDURE [dbo].[spIncome_GetByCurrentYear]
	@Year INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT SUM()
	FROM dbo.Incomes
	WHERE YEAR(TimeStamp) = @Year
END