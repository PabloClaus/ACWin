Public Class frmPublicadores

    Private pObjListViewColumnSorter As New clsListViewColumnSorter

    Private Sub frmPublicadores_Load(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load

        lwPublicadores.ListViewItemSorter = pObjListViewColumnSorter

        Dim lColPublicadores As New ACWinDL.Model.clsPublicadores
        lColPublicadores.dbGetAll()
        For Each lObjPublicador In lColPublicadores
            Dim lObjLWItem As New ListViewItem(lObjPublicador.Apellido)
            lObjLWItem.SubItems.Add(lObjPublicador.Nombre)
            lObjLWItem.SubItems.Add(lObjPublicador.Direccion)
            lObjLWItem.SubItems.Add(lObjPublicador.TelefonoCasa)
            lObjLWItem.SubItems.Add(lObjPublicador.TelefonoMovil)
            lObjLWItem.SubItems.Add(lObjPublicador.TelefonoTrabajo)
            lObjLWItem.SubItems.Add(lObjPublicador.FechaNacimiento)
            lObjLWItem.SubItems.Add(lObjPublicador.FechaBautismo)
            lObjLWItem.SubItems.Add(lObjPublicador.ObjPrivilegio.Nombre)
            lObjLWItem.SubItems.Add(lObjPublicador.ObjPrecursor.Nombre)
            lObjLWItem.SubItems.Add(lObjPublicador.ObjGrupo.Nombre)
            lwPublicadores.Items.Add(lObjLWItem)
        Next
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        frmPublicadorAdd.ShowDialog(Me)
    End Sub

    Private Sub lwPublicadores_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lwPublicadores.ColumnClick
        ' Determine if clicked column is already the column that is being sorted.
        If e.Column = pObjListViewColumnSorter.SortColumn Then
            ' Reverse the current sort direction for this column.
            If pObjListViewColumnSorter.Order = SortOrder.Ascending Then
                pObjListViewColumnSorter.Order = SortOrder.Descending
            Else
                pObjListViewColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            pObjListViewColumnSorter.SortColumn = e.Column
            pObjListViewColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        lwPublicadores.Sort()
    End Sub
End Class