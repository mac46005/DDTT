﻿CREATE PROCEDURE [dbo].[spJobType_GetById]
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Id,Job
	FROM dbo.JobTypes
	WHERE Id = @Id;
END
