CREATE PROCEDURE [dbo].[spMileage_Insert]
	/*@Id INT OUTPUT,*/
	@JobTypeId INT,
	@Amount MONEY,
	@TimeStamp DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Mileages(JobTypeId,Amount,TimeStamp)
	VALUES(@JobTypeId,@Amount,@TimeStamp)
	/*SELECT @Id = SCOPE_IDENTITY();*/
END
