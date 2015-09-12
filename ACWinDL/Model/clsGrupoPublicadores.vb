Namespace Model
    Public Class clsGrupoPublicadores
#Region "Propiedades"
        Public Property ObjGrupo As New clsGrupo
        Public Property ObjSuperintendente As New clsPublicador
        Public Property ColPublicador As New List(Of clsPublicador)
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

