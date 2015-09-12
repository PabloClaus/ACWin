Namespace Model
    Public Class clsPublicador
#Region "Propiedades"
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Apellido As String
        Public Property Direccion As String
        Public Property EMail As String
        Public Property FechaNacimiento As Date
        Public Property FechaBautismo As Date
        Public Property Ungido As Boolean
        Public Property TelefonoCasa As String
        Public Property TelefonoMovil As String
        Public Property TelefonoTrabajo As String
        Public Property ObjSexo As clsSexo
        Public Property ObjPrivilegio As clsPrivilegio
        Public Property ObjPrecursor As clsPrecursor
        Public Property ObjEstado As clsEstado
        Public Property ObjGrupo As clsGrupo
        Public Property ColActividad As List(Of clsActividad)
#End Region
#Region "Constructores"
        Public Sub New()
        End Sub

        Public Sub New(ByVal aReader As SqlClient.SqlDataReader)
            SetearObjetoSegunReader(aReader)
        End Sub
        Public Sub SetearObjetoSegunReader(ByVal aReader As SqlClient.SqlDataReader)
            For i = 0 To aReader.FieldCount - 1
                If Not IsDBNull(aReader.Item(i)) Then
                    Select Case aReader.GetName(i)
                        Case Is = "Id_P"
                            Me.Id = aReader.Item(i)
                        Case Is = "Nombre_P"
                            Me.Nombre = aReader.Item(i)
                        Case Is = "Apellido_P"
                            Me.Apellido = aReader.Item(i)
                        Case Is = "Direccion_P"
                            Me.Direccion = aReader.Item(i)
                        Case Is = "EMail_P"
                            Me.EMail = aReader.Item(i)
                        Case Is = "FechaNacimiento_P"
                            Me.FechaNacimiento = aReader.Item(i)
                        Case Is = "FechaBautismo_P"
                            Me.FechaBautismo = aReader.Item(i)
                        Case Is = "Ungido_P"
                            Me.Ungido = aReader.Item(i)
                        Case Is = "TelefonoCasa_P"
                            Me.TelefonoCasa = aReader.Item(i)
                        Case Is = "TelefonoMovil_P"
                            Me.TelefonoMovil = aReader.Item(i)
                        Case Is = "TelefonoTrabajo_P"
                            Me.TelefonoTrabajo = aReader.Item(i)
                    End Select
                End If
            Next
            Me.ObjSexo = New clsSexo(aReader)
            Me.ObjPrivilegio = New clsPrivilegio(aReader)
            Me.ObjPrecursor = New clsPrecursor(aReader)
            Me.ObjEstado = New clsEstado(aReader)
            Me.ObjGrupo = New clsGrupo(aReader)
        End Sub
#End Region
#Region "Metodos"
        Public Sub dbAdd()
            Try
                Using lObjConexion = New SqlClient.SqlConnection(My.Settings.CadenaDeConexion)
                    lObjConexion.Open()
                    Using lObjSqlCommand = New SqlClient.SqlCommand("PublicadorAdd", lObjConexion)
                        With lObjSqlCommand
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add("@Id_P", SqlDbType.Int, 300000, "Id")
                            .Parameters("@Id_P").Direction = ParameterDirection.Output
                            .Parameters.AddWithValue("@Nombre_P", Nombre)
                            .Parameters.AddWithValue("@Apellido_P", Apellido)
                            .Parameters.AddWithValue("@Direccion_P", Direccion)
                            .Parameters.AddWithValue("@EMail_P", EMail)
                            .Parameters.AddWithValue("@FechaNacimiento_P", FechaNacimiento)
                            .Parameters.AddWithValue("@FechaBautismo_P", FechaBautismo)
                            .Parameters.AddWithValue("@Ungido_P", Ungido)
                            .Parameters.AddWithValue("@TelefonoCasa_P", TelefonoCasa)
                            .Parameters.AddWithValue("@TelefonoMovil_P", TelefonoMovil)
                            .Parameters.AddWithValue("@TelefonoTrabajo_P", TelefonoTrabajo)
                            .Parameters.AddWithValue("@Id_MS_P", ObjSexo.Id)
                            .Parameters.AddWithValue("@Id_MPR_P", ObjPrivilegio.Id)
                            .Parameters.AddWithValue("@Id_MP_P", ObjPrecursor.Id)
                            .Parameters.AddWithValue("@Id_ME_P", ObjEstado.Id)
                            .Parameters.AddWithValue("@Id_G_P", ObjGrupo.Id)
                            .ExecuteNonQuery()
                            Me.Id = .Parameters("@Id_P").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Base de datos"

#End Region
    End Class
End Namespace