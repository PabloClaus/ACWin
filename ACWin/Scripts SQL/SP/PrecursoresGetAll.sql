use [ACWIN.MDF]

IF OBJECT_ID('[PrecursoresGetAll]') IS NOT NULL DROP PROCEDURE [PrecursoresGetAll]
GO

CREATE PROCEDURE [PrecursoresGetAll]
AS 
  
Select *
From MaestroPrecursor
Order by Nombre_MP ASC
