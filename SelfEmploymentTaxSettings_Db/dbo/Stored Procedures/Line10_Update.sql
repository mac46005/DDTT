CREATE PROCEDURE [dbo].[Line10_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line10]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END