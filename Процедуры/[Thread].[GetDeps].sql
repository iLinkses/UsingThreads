USE [dbo]
GO

/****** Object:  StoredProcedure [Thread].[GetDeps]    Script Date: 19.07.2020 14:40:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		АНС
-- Create date: 18.07.2020
-- Description:	Получает список отделов
-- =============================================
CREATE PROCEDURE [Thread].[GetDeps]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	SELECT 0 AS id,
			'Все отделы' AS name
	UNION
	SELECT	id,
			name
	FROM dbo.deps
END
GO

