use [ACWIN.MDF]

IF OBJECT_ID('[PublicadorAdd]') IS NOT NULL DROP PROCEDURE [PublicadorAdd]
GO

CREATE PROCEDURE [PublicadorAdd]
(
  @Id_P int output,
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
  @Id_MMA_P int
)

AS 
  INSERT INTO Publicador(
  Nombre_P,
  Apellido_P,
  Direccion_P,
  EMail_P,
  FechaNacimiento_P,
  FechaBautismo_P,
  Ungido_P,
  TelefonoCasa_P,
  TelefonoMovil_P,
  TelefonoTrabajo_P,
  Id_MS_P,
  Id_MPR_P,
  Id_MP_P,
  Id_ME_P,
  Id_G_P,
  FechaAlta_P,
  Id_MMA_P
) VALUES (
  @Nombre_P,
  @Apellido_P,
  @Direccion_P,
  @EMail_P,
  @FechaNacimiento_P,
  @FechaBautismo_P,
  @Ungido_P,
  @TelefonoCasa_P,
  @TelefonoMovil_P,
  @TelefonoTrabajo_P,
  @Id_MS_P,
  @Id_MPR_P,
  @Id_MP_P,
  @Id_ME_P,
  @Id_G_P,
  @FechaAlta_P,
  @Id_MMA_P
)
Set @Id_P = @@Identity

