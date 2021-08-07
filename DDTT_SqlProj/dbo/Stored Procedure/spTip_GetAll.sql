CREATE PROCEDURE [dbo].[spTip_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,Amount,TimeStamp
	FROM dbo.Tips;
END
