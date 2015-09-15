use [ACWIN.MDF]

IF OBJECT_ID('[PublicadorActividadGet]') IS NOT NULL DROP PROCEDURE [PublicadorActividadGet]
GO

CREATE PROCEDURE [PublicadorActividadGet](
@Id_P_A Int
)
AS 
  
SELECT A.*
FROM Actividad A
WHERE A.Id_P_A = @Id_P_A

