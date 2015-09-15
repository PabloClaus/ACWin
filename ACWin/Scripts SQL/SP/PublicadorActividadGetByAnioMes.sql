use [ACWIN.MDF]

IF OBJECT_ID('[PublicadorActividadGetByAnioMes]') IS NOT NULL DROP PROCEDURE [PublicadorActividadGetByAnioMes]
GO

CREATE PROCEDURE [PublicadorActividadGetByAnioMes](
@Id_P_A Int,
@Id_MA_A Int,
@Id_MM_A Int
)
AS 
  
SELECT A.*
FROM Actividad A
WHERE A.Id_P_A = @Id_P_A AND
      A.Id_MM_A = @Id_MM_A  AND A.Id_MA_A = @Id_MA_A

