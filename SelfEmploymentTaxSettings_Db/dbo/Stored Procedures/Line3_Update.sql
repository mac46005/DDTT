﻿CREATE PROCEDURE [dbo].[Line3_Update]
	@MultiplyBy MONEY
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[1040ES_Line3]
	SET MultiplyBy = @MultiplyBy
	WHERE Id = 0;
END