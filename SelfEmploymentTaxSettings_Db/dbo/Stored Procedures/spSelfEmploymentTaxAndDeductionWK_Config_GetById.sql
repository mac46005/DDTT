CREATE PROCEDURE [dbo].[spSelfEmploymentTaxAndDeductionWK_Config_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM dbo.SelfEmploymentTaxAndDeductionWK_Config
	WHERE Id = @Id;
END
