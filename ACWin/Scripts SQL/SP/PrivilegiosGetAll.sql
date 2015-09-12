use [ACWIN.MDF]

IF OBJECT_ID('[PrivilegiosGetAll]') IS NOT NULL DROP PROCEDURE [PrivilegiosGetAll]
GO

CREATE PROCEDURE [PrivilegiosGetAll]
AS 
  
Select *
From MaestroPrivilegio
Order by Id_MPR ASC
