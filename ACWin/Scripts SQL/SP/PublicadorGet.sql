use [ACWIN.MDF]

IF OBJECT_ID('[PublicadoresGetAll]') IS NOT NULL DROP PROCEDURE [PublicadoresGetAll]
GO

CREATE PROCEDURE [PublicadoresGetAll]
AS 
  
SELECT Publicador.*,
       MaestroEstado.*,
       MaestroSexo.*,
       Grupo.*,
       MaestroPrivilegio.*,
       MaestroPrecursor.*
  FROM (((([ACWIN.MDF].dbo.Publicador Publicador
           INNER JOIN [ACWIN.MDF].dbo.MaestroSexo MaestroSexo
              ON (Publicador.Id_MS_P = MaestroSexo.Id_MS))
          INNER JOIN [ACWIN.MDF].dbo.MaestroEstado MaestroEstado
             ON (Publicador.Id_ME_P = MaestroEstado.Id_ME))
         INNER JOIN [ACWIN.MDF].dbo.Grupo Grupo
            ON (Publicador.Id_G_P = Grupo.Id_G))
        INNER JOIN [ACWIN.MDF].dbo.MaestroPrivilegio MaestroPrivilegio
           ON (Publicador.Id_MPR_P = MaestroPrivilegio.Id_MPR))
       INNER JOIN [ACWIN.MDF].dbo.MaestroPrecursor MaestroPrecursor
          ON (Publicador.Id_MP_P = MaestroPrecursor.Id_MP)
ORDER BY Publicador.Apellido_P ASC
