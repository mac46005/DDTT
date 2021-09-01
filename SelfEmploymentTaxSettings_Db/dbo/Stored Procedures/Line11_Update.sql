CREATE PROCEDURE [dbo].[Line11_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line11]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END