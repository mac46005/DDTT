CREATE PROCEDURE [dbo].[spExpenditure_Insert]
	@Id INT OUTPUT,
	@Amount MONEY,
	@TimeStamp DATETIME2,
	@Note NVARCHAR
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Expenditures(Amount,TimeStamp,Note)
	VALUES(@Amount,@TimeStamp,@Note)
	SELECT @Id = SCOPE_IDENTITY();
END
