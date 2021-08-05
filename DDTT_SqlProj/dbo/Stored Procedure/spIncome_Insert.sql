CREATE PROCEDURE [dbo].[spIncome_Insert]
	@Id INT OUTPUT,
	@DD_Pay_Id INT,
	@Tip_Id INT
AS
BEGIN
	INSERT INTO dbo.Incomes(DD_Pay_Id,Tip_Id)
	VALUES(@DD_Pay_Id,@Tip_Id)
	SELECT @Id = SCOPE_IDENTITY();
END
