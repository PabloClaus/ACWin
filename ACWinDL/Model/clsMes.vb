﻿Namespace Model
    Public Class clsMes
#Region "Propiedades"
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property ColPublicador As List(Of clsPublicador)
        Public Property ColMesActividad As List(Of clsMesActividad)
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
                        Case Is = "Id_MM"
                            Me.Id = aReader.Item(i)
                        Case Is = "Nombre_MM"
                            Me.Nombre = aReader.Item(i)
                    End Select
                End If
            Next
        End Sub
#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"

#End Region
    End Class
End Namespace

