CREATE PROCEDURE [dbo].[Line9_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line9]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END
