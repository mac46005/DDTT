﻿CREATE PROCEDURE [dbo].[spDDPay_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,Amount,TimeStamp
	FROM dbo.DD_Pays
	WHERE Id = @Id;
END
