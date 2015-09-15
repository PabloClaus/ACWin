Public Class frmActividadPublicadores
    Private pObjListViewColumnSorter As New clsListViewColumnSorter
    Private pColPublicadores As New ACWinDL.Model.clsPublicadores

    Private Sub frmActividadPublicadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lwActividadPublicadores.ListViewItemSorter = pObjListViewColumnSorter
        pColPublicadores.dbGetAll()
        LoadCboGrupo()
        LoadCboMes(Date.Today.AddMonths(-1))
        LoadCboAnio(Date.Today.AddMonths(-1))
        LoadlwActividadPublicadores(Date.Today.AddMonths(-1))


    End Sub

    Private Sub LoadlwActividadPublicadores(ByVal aMesVigente As Date)
        For Each lObjPublicador In pColPublicadores
            lObjPublicador.ColActividad.Clear()
            lObjPublicador.dbActividadGet(aMesVigente.Year, aMesVigente.Month)
        Next
        For Each lObjPublicador In pColPublicadores
            Dim lObjLWItem As New ListViewItem(lObjPublicador.Id)
            lObjLWItem.Name = lObjPublicador.Id
            lObjLWItem.SubItems.Add(lObjPublicador.Apellido + " " + lObjPublicador.Nombre)
            If lObjPublicador.ColActividad.Count > 0 Then
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Libros)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Folletos)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Horas)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Revistas)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Revisitas)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Estudios)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Notas)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Credito)
                lObjLWItem.SubItems.Add(lObjPublicador.ColActividad.First().Tardio)
            End If
            lwActividadPublicadores.Items.Add(lObjLWItem)
        Next
        lblAnioMesMostrado.Text = aMesVigente.ToString("MMMM yyyy")
    End Sub

    Private Sub LoadCboGrupo()
        Dim lColGrupo As New ACWinDL.Model.clsGrupos
        lColGrupo.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjGrupo In lColGrupo
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjGrupo.Id, .Valor = lObjGrupo.Nombre})
        Next
        Me.cboGrupo.DataSource = lObjItems
        Me.cboGrupo.DisplayMember = "Valor"
        Me.cboGrupo.ValueMember = "Id"
    End Sub

    Private Sub LoadCboAnio(ByVal aMesVigente As Date)
        Dim lColAnio As New ACWinDL.Model.clsAnios
        lColAnio.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjAnio In lColAnio
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjAnio.Id, .Valor = lObjAnio.Id})
        Next
        Me.cboAnio.DataSource = lObjItems
        Me.cboAnio.DisplayMember = "Valor"
        Me.cboAnio.ValueMember = "Id"
        Me.cboAnio.SelectedIndex = Me.cboAnio.FindStringExact(aMesVigente.Year)
    End Sub

    Private Sub LoadCboMes(ByVal aMesVigente As Date)
        Dim lColMes As New ACWinDL.Model.clsMeses
        lColMes.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjMes In lColMes
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjMes.Id, .Valor = lObjMes.Nombre})
        Next
        Me.cboMes.DataSource = lObjItems
        Me.cboMes.DisplayMember = "Valor"
        Me.cboMes.ValueMember = "Id"
        Me.cboMes.SelectedIndex = Me.cboMes.FindStringExact(aMesVigente.ToString("MMMM"))
    End Sub



    Private Sub lwActividadPublicadores_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lwActividadPublicadores.ColumnClick
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
        lwActividadPublicadores.Sort()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim lMesVigente As New Date(cboAnio.SelectedValue, cboMes.SelectedValue, 1)
        lwActividadPublicadores.Items.Clear()
        LoadlwActividadPublicadores(lMesVigente)
    End Sub
End Class