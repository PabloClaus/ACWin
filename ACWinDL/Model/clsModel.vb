Namespace Model
    Public Class clsModel
#Region "Propiedades"
        Public Property Id As Integer
        Public Property Nombre As String
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

#End Region
    End Class
End Namespace

