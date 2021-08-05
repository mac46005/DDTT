﻿CREATE PROCEDURE [dbo].[spDDPay_Insert]
	@Id INT OUTPUT,
	@Amount MONEY,
	@TimeStamp DATETIME2
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.DD_Pays(Amount,TimeStamp)
	VALUES(@Amount,@TimeStamp)
	SELECT @Id = SCOPE_IDENTITY();
END