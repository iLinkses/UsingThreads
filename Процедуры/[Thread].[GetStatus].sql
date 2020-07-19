USE [dbo]
GO

/****** Object:  StoredProcedure [Thread].[GetStatus]    Script Date: 19.07.2020 14:42:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		АНС
-- Create date: 18.07.2020
-- Description:	Получает список статусов
-- =============================================
CREATE PROCEDURE [Thread].[GetStatus] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 0 AS id,
			'Все статусы' AS name
	UNION
    SELECT	id,
			name
	FROM dbo.status
END
GO

