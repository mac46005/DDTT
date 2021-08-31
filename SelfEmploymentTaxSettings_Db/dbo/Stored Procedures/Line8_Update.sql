CREATE PROCEDURE [dbo].[Line8_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line8]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END
