Public Class frmActividadPublicador
    Dim pObjPublicador As ACWinDL.Model.clsPublicador
    Friend Sub LoadObjPublicador(ByVal Id As Integer)
        pObjPublicador = New ACWinDL.Model.clsPublicador With {.Id = Id}
        pObjPublicador.dbActividadGetAll()
    End Sub

    Private Sub frmActividadPublicador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each lObjActividad In pObjPublicador.ColActividad
            Dim lObjLWItem As New ListViewItem(lObjActividad.Id)
            lObjLWItem.Name = lObjActividad.Id
            lObjLWItem.SubItems.Add(lObjActividad.ObjAnio.Id)
            lObjLWItem.SubItems.Add(lObjActividad.ObjMes.Nombre)
            lObjLWItem.SubItems.Add(lObjActividad.Libros)
            lObjLWItem.SubItems.Add(lObjActividad.Folletos)
            lObjLWItem.SubItems.Add(lObjActividad.Horas)
            lObjLWItem.SubItems.Add(lObjActividad.Revistas)
            lObjLWItem.SubItems.Add(lObjActividad.Revisitas)
            lObjLWItem.SubItems.Add(lObjActividad.Estudios)
            lObjLWItem.SubItems.Add(lObjActividad.Credito)
            lObjLWItem.SubItems.Add(lObjActividad.Notas)
            lObjLWItem.SubItems.Add(lObjActividad.Tardio)
            lwActividadPublicador.Items.Add(lObjLWItem)
        Next
    End Sub
End Class