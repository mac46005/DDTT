CREATE PROCEDURE [dbo].[Line2_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line4]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END