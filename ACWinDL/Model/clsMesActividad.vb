Namespace Model
    Public Class clsMesActividad
#Region "Propiedades"
        Public Property Agrupacion As String
        Public Property Cantidad As Integer
        Public Property Folletos As Integer
        Public Property Horas As Integer
        Public Property Revistas As Integer
        Public Property Revisitas As Integer
        Public Property Estudios As Integer
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
                        Case Is = "Agrupacion_MA"
                            Me.Agrupacion = aReader.Item(i)
                        Case Is = "Cantidad_MA"
                            Me.Cantidad = aReader.Item(i)
                        Case Is = "Folletos_MA"
                            Me.Folletos = aReader.Item(i)
                        Case Is = "Horas_MA"
                            Me.Horas = aReader.Item(i)
                        Case Is = "Revistas_MA"
                            Me.Revistas = aReader.Item(i)
                        Case Is = "Revisitas_MA"
                            Me.Revisitas = aReader.Item(i)
                        Case Is = "Estudios_MA"
                            Me.Estudios = aReader.Item(i)
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

