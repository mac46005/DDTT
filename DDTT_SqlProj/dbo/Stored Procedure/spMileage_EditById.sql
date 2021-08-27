CREATE PROCEDURE [dbo].[spMileage_EditById]
	@Id INT,
	@JobTypeId INT,
	@Amount MONEY,
	@TimeStamp DATETIME2(7)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.Mileages
	SET 
	JobTypeId = @JobTypeId,
	Amount = @Amount,
	TimeStamp = @TimeStamp
	WHERE Id = @Id
END
