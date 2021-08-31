CREATE PROCEDURE [dbo].[Line5_Update]
	@SS_TaxMaxIncome MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line5]
	SET SS_TaxMaxIncome = @SS_TaxMaxIncome
	WHERE Id = 0;
END