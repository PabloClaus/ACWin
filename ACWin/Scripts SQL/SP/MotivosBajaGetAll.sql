use [ACWIN.MDF]

IF OBJECT_ID('[MotivosBajaGetAll]') IS NOT NULL DROP PROCEDURE [MotivosBajaGetAll]
GO

CREATE PROCEDURE [MotivosBajaGetAll]
AS 
  
Select *
From MaestroMotivoBaja
Order by Id_MMB ASC

