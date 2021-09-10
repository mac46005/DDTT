CREATE PROCEDURE [dbo].[spSelfEmploymentTaxAndDeductionWK_Config_GetByDate]
	@Year DATETIME2(7)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM dbo.SelfEmploymentTaxAndDeductionWK_Config
	WHERE Year = @Year
END
