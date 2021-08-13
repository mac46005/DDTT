CREATE PROCEDURE [dbo].[spExpenditure_Insert]
	@Id INT OUTPUT,
	@JobTypeId INT,
	@Amount MONEY,
	@TimeStamp DATETIME2,
	@ExpenseTypeId INT,
	@Note NVARCHAR
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Expenditures(JobTypeId,Amount,TimeStamp,ExpenseTypeId,Note)
	VALUES(@JobTypeId,@Amount,@TimeStamp,@ExpenseTypeId,@Note)
	SELECT @Id = SCOPE_IDENTITY();
END
