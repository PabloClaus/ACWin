Namespace Model
    Public Class clsActividad
#Region "Propiedades"
        Public Property Id As Integer
        Public Property Folletos As Integer
        Public Property Horas As Integer
        Public Property Revistas As Integer
        Public Property Revisitas As Integer
        Public Property Estudios As Integer
        Public Property Notas As String
        Public Property Credito As Integer
        Public Property Tardio As Boolean
        Public Property ObjMes As clsMes
        Public Property ObjAnio As clsAnio

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
                        Case Is = "Id_A"
                            Me.Id = aReader.Item(i)
                        Case Is = "Folletos_A"
                            Me.Folletos = aReader.Item(i)
                        Case Is = "Horas_A"
                            Me.Horas = aReader.Item(i)
                        Case Is = "Revistas_A"
                            Me.Revistas = aReader.Item(i)
                        Case Is = "Revisitas_A"
                            Me.Revisitas = aReader.Item(i)
                        Case Is = "Estudios_A"
                            Me.Estudios = aReader.Item(i)
                        Case Is = "Notas_A"
                            Me.Notas = aReader.Item(i)
                        Case Is = "Credito_A"
                            Me.Credito = aReader.Item(i)
                        Case Is = "Tardio_A"
                            Me.Tardio = aReader.Item(i)
                    End Select
                End If
            Next
            Me.ObjMes = New clsMes(aReader)
            Me.ObjAnio = New clsAnio(aReader)
        End Sub




#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"

#End Region
    End Class
End Namespace

