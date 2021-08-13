CREATE PROCEDURE [dbo].[spExpenditure_Insert]
	@Id INT OUTPUT,
	@JobTypeId INT,
	@Amount MONEY,
	@TimeStamp DATETIME2,
	@Note NVARCHAR
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Expenditures(JobTypeId,Amount,TimeStamp,Note)
	VALUES(@JobTypeId,@Amount,@TimeStamp,@Note)
	SELECT @Id = SCOPE_IDENTITY();
END
