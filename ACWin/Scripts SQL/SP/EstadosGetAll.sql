use [ACWIN.MDF]

IF OBJECT_ID('[EstadosGetAll]') IS NOT NULL DROP PROCEDURE [EstadosGetAll]
GO

CREATE PROCEDURE [EstadosGetAll]
AS 
  
Select *
From MaestroEstado
Order by Nombre_ME DESC
