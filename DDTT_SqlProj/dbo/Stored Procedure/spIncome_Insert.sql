CREATE PROCEDURE [dbo].[spIncome_Insert]
	@JobTypeId INT,
	@BasePay MONEY,
	@Tip MONEY,
	@TimeStamp DATETIME2
AS
BEGIN
	INSERT INTO dbo.Incomes(JobTypeId,BasePay,Tip,TimeStamp)
	VALUES(@JobTypeId,@BasePay,@Tip,@TimeStamp);
END
