CREATE PROCEDURE [dbo].[spTip_Insert]
	@Id INT OUTPUT,
	@Amount MONEY,
	@TimeStamp DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Tips(Amount,TimeStamp)
	VALUES(@Amount,@TimeStamp)
	SELECT @Id = SCOPE_IDENTITY();
END
