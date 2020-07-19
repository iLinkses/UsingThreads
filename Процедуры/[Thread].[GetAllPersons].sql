USE [dbo]
GO

/****** Object:  StoredProcedure [Thread].[GetAllPersons]    Script Date: 19.07.2020 14:40:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		АНС
-- Create date: 18.07.2020
-- Description:	Получает список сотрудников
-- =============================================
CREATE PROCEDURE [Thread].[GetAllPersons]
	@DateStart datetime,
	@DateEnd datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT	P.second_name + ' ' + LEFT(P.first_name, 1) + '.' + LEFT(P.last_name, 1) + '.' AS FIO,
			S.id AS IdStatus,
			S.name AS NameStatus,
			D.id AS IdDep,
			D.name AS NameDep,
			PST.id AS IdPost,
			PST.name AS NamePost,
			P.date_employ,
			P.date_uneploy
	FROM dbo.persons P
	INNER JOIN dbo.status S ON S.id = P.status
	INNER JOIN dbo.deps D ON D.id = P.id_dep
	INNER JOIN dbo.post PST ON PST.id = p.id_post
	WHERE (CONVERT(date, P.date_employ) BETWEEN CONVERT(date, @DateStart) AND CONVERT(date, @DateEnd))
	OR (CONVERT(date, P.date_uneploy) BETWEEN CONVERT(date, @DateStart) AND CONVERT(date, @DateEnd))
	ORDER BY p.second_name
END
GO

