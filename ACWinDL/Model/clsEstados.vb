﻿Namespace Model
    Public Class clsEstados
        Inherits List(Of clsEstado)
#Region "Propiedades"
#End Region
#Region "Constructores"
        Public Sub New()
        End Sub
#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"
        Public Sub dbGetAll()
            Try
                Using lObjConexion = New SqlClient.SqlConnection(My.Settings.CadenaDeConexion)
                    lObjConexion.Open()
                    Using lObjSqlCommand = New SqlClient.SqlCommand("EstadosGetAll", lObjConexion)
                        With lObjSqlCommand
                            .CommandType = CommandType.StoredProcedure
                            Using lObjSqlDataReader As SqlClient.SqlDataReader = lObjSqlCommand.ExecuteReader
                                Do While lObjSqlDataReader.Read()
                                    Me.Add(New clsEstado(lObjSqlDataReader))
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

