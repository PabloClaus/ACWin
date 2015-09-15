use [ACWIN.MDF]

IF OBJECT_ID('[AniosGetAll]') IS NOT NULL DROP PROCEDURE [AniosGetAll]
GO

CREATE PROCEDURE [AniosGetAll]
AS 
  
Select *
From MaestroAnio
Where Id_MA between Year(DateAdd(month,-24,GetDate())) and Year(GetDate())
Order by Id_MA ASC

