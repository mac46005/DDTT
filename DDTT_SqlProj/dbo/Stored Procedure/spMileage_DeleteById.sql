CREATE PROCEDURE [dbo].[spMileage_DeleteById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.Mileages
	WHERE Id = @Id;
END
