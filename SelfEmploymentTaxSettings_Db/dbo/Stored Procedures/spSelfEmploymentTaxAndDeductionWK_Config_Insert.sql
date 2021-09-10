CREATE PROCEDURE [dbo].[spSelfEmploymentTaxAndDeductionWK_Config_Insert]
	@Year DATETIME2(7),
	@Line3 MONEY,
	@Line4 MONEY,
	@Line5 MONEY,
	@Line9 MONEY,
	@Line11 MONEY
AS
	INSERT INTO dbo.SelfEmploymentTaxAndDeductionWK_Config(Year,Line3,Line4,Line5,Line9,Line11)
	VALUES(@Year,@Line3,@Line4,@Line5,@Line9,@Line11);
RETURN 0
