use [ACWIN.MDF]

IF OBJECT_ID('[MesesGetAll]') IS NOT NULL DROP PROCEDURE [MesesGetAll]
GO

CREATE PROCEDURE [MesesGetAll]
AS 
  
Select *
From MaestroMes
Order by Id_MM ASC

