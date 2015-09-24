Namespace Model
    Public Class clsMotivosBaja
        Inherits List(Of clsMotivoBaja)
#Region "Propiedades"
#End Region
#Region "Constructores"
        Public Sub New()
        End Sub

        'Public Sub New(ByVal aReader As SqlClient.SqlDataReader)
        '    SetearObjetoSegunReader(aReader)
        'End Sub
        'Public Sub SetearObjetoSegunReader(ByVal aReader As SqlClient.SqlDataReader)
        '    For i = 0 To aReader.FieldCount - 1
        '        If Not IsDBNull(aReader.Item(i)) Then
        '            Select Case aReader.GetName(i)
        '                Case Is = "Id_S"
        '                    Me.Id = aReader.Item(i)
        '                Case Is = "Nombre_S"
        '                    Me.Nombre = aReader.Item(i)
        '                Case Is = "Comentario_S"
        '                    Me.Comentario = aReader.Item(i)
        '            End Select
        '        End If
        '    Next
        'Me.ObjTacografo = New clsTacografo(aReader)
        'End Sub
#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"
        Public Sub dbGetAll()
            Try
                Using lObjConexion = New SqlClient.SqlConnection(My.Settings.CadenaDeConexion)
                    lObjConexion.Open()
                    Using lObjSqlCommand = New SqlClient.SqlCommand("MotivosBajaGetAll", lObjConexion)
                        With lObjSqlCommand
                            .CommandType = CommandType.StoredProcedure
                            Using lObjSqlDataReader As SqlClient.SqlDataReader = lObjSqlCommand.ExecuteReader
                                Do While lObjSqlDataReader.Read()
                                    Me.Add(New clsMotivoBaja(lObjSqlDataReader))
                                Loop
                            End Using
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
    End Class
End Namespace

