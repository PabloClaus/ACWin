Namespace Model
    Public Class clsPublicadorMotivoAlta
#Region "Propiedades"
        Public Property ObjMotivoAlta As clsMotivoAlta
        Public Property Fecha As Date
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
                        Case Is = "FechaAlta_P"
                            Me.Fecha = aReader.Item(i)
                    End Select
                End If
            Next
            Me.ObjMotivoAlta = New clsMotivoAlta(aReader)
        End Sub
#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"

#End Region
    End Class
End Namespace

