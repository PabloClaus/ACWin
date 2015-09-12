use [ACWIN.MDF]

IF OBJECT_ID('[GruposGetAll]') IS NOT NULL DROP PROCEDURE [GruposGetAll]
GO

CREATE PROCEDURE [GruposGetAll]
AS 
  
Select *
From Grupo
Order by Nombre_G ASC
