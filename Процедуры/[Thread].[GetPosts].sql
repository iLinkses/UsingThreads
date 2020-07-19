USE [dbo]
GO

/****** Object:  StoredProcedure [Thread].[GetPosts]    Script Date: 19.07.2020 14:41:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		АНС
-- Create date: 18.07.2020
-- Description:	Получает список должностей
-- =============================================
CREATE PROCEDURE [Thread].[GetPosts] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 0 AS id,
			'Все должности' AS name
	UNION
    SELECT	id,
			name
	FROM dbo.post
END
GO

