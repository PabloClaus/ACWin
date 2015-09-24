Namespace Model
    Public Class clsPublicadorMotivoBaja
#Region "Propiedades"
        Public Property ObjMotivoBaja As clsMotivoBaja
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
                        Case Is = "FechaBaja_P"
                            Me.Fecha = aReader.Item(i)
                    End Select
                End If
            Next
            Me.ObjMotivoBaja = New clsMotivoBaja(aReader)
        End Sub
#End Region
#Region "Metodos"

#End Region
#Region "Base de datos"

#End Region
    End Class
End Namespace

