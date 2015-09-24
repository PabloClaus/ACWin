use [ACWIN.MDF]

IF OBJECT_ID('[PublicadorUpd]') IS NOT NULL DROP PROCEDURE [PublicadorUpd]
GO

CREATE PROCEDURE [PublicadorUpd]
(
  @Id_P int,
  @Nombre_P nvarchar(50),
  @Apellido_P nvarchar(50),
  @Direccion_P nvarchar(200),
  @EMail_P nvarchar(50),
  @FechaNacimiento_P date,
  @FechaBautismo_P date,
  @Ungido_P bit,
  @TelefonoCasa_P nvarchar(50),
  @TelefonoMovil_P nvarchar(50),
  @TelefonoTrabajo_P nvarchar(50),
  @Id_MS_P int,
  @Id_MPR_P int,
  @Id_MP_P int,
  @Id_ME_P int,
  @Id_G_P int,
  @FechaAlta_P date,
  @FechaBaja_P date,
  @Id_MMB_P int,
  @Id_MMA_P int
)

AS 
  UPDATE Publicador
  SET
    Nombre_P = @Nombre_P,
    Apellido_P = @Apellido_P,
    Direccion_P = @Direccion_P,
    EMail_P = @EMail_P,
    FechaNacimiento_P = @FechaNacimiento_P,
    FechaBautismo_P = @FechaBautismo_P,
    Ungido_P = @Ungido_P,
    TelefonoCasa_P = @TelefonoCasa_P,
    TelefonoMovil_P = @TelefonoMovil_P,
    TelefonoTrabajo_P = @TelefonoTrabajo_P,
    Id_MS_P = @Id_MS_P,
    Id_MPR_P = @Id_MPR_P,
    Id_MP_P =  @Id_MP_P,
    Id_ME_P = @Id_ME_P,
    Id_G_P = @Id_G_P,
    FechaAlta_P = @FechaAlta_P,
    FechaBaja_P = @FechaBaja_P,
    Id_MMB_P = @Id_MMB_P,
    Id_MMA_P = @Id_MMA_P
WHERE Id_P = @Id_P

