CREATE PROCEDURE [dbo].[spMileage_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,JobTypeId,Amount,TimeStamp
	FROM dbo.Mileages
	WHERE Id = @Id;
END
