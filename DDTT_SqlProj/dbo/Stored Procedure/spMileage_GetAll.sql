CREATE PROCEDURE [dbo].[spMileage_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,Amount,TimeStamp
	FROM dbo.Mileages;
END
