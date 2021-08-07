CREATE PROCEDURE [dbo].[spTip_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Amount,TimeStamp
	FROM dbo.Tips
	WHERE Id = @Id;
END
