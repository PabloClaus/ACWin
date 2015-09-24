use [ACWIN.MDF]

IF OBJECT_ID('[MotivosAltaGetAll]') IS NOT NULL DROP PROCEDURE [MotivosAltaGetAll]
GO

CREATE PROCEDURE [MotivosAltaGetAll]
AS 
  
Select *
From MaestroMotivoAlta
Order by Id_MMA ASC

