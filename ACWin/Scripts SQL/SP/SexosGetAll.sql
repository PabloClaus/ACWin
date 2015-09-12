use [ACWIN.MDF]

IF OBJECT_ID('[SexosGetAll]') IS NOT NULL DROP PROCEDURE [SexosGetAll]
GO

CREATE PROCEDURE [SexosGetAll]
AS 
  
Select *
From MaestroSexo
Order by Nombre_MS ASC
