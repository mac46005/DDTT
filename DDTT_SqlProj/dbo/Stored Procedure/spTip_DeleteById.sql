﻿CREATE PROCEDURE [dbo].[spTip_DeleteById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.Tips
	WHERE Id = @Id;
END