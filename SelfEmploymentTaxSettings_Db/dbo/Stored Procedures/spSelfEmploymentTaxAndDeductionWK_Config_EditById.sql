CREATE PROCEDURE [dbo].[spSelfEmploymentTaxAndDeductionWK_Config_EditById]
	@Id INT,
	@Year DATETIME2(7),
	@Line3 MONEY,
	@Line4 MONEY,
	@Line5 MONEY,
	@Line9 MONEY,
	@Line11 MONEY
AS
	UPDATE dbo.SelfEmploymentTaxAndDeductionWK_Config
	SET
	Year = @Year,
	Line3 = @Line3,
	Line4 = @Line4,
	Line5 = @Line5,
	Line9 = @Line9,
	Line11 = @Line11
	WHERE Id = @Id;
RETURN 0
