CREATE PROCEDURE [dbo].[spIncome_GetAll]
AS
BEGIN
	SELECT p.* , t.*
	FROM dbo.DD_Pays p
	LEFT JOIN dbo.Tips t
	ON p.TipId = t.Id;
END
