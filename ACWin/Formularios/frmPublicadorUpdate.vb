Public Class frmPublicadorUpd
    Dim pObjPublicador As ACWinDL.Model.clsPublicador
    Private Sub frmPublicadorAdd_Load(ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatosGenerales()
        LoadCboSexo()
        LoadCboGrupo()
        LoadCboEstado()
        LoadCboPrivilegio()
        LoadCboPrecursor()
    End Sub

    Friend Sub LoadObjPublicador(ByVal Id As Integer)
        pObjPublicador = New ACWinDL.Model.clsPublicador With {.Id = Id}
        pObjPublicador.dbGet()
    End Sub

    Private Sub LoadDatosGenerales()
        With pObjPublicador
            Me.txtApellido.Text = .Apellido
            Me.txtNombre.Text = .Nombre
            Me.txtDireccion.Text = .Direccion
        End With
    End Sub

    Private Sub LoadCboSexo()
        Dim lColSexo As New ACWinDL.Model.clsSexos
        lColSexo.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjSexo In lColSexo
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjSexo.Id, .Valor = lObjSexo.Nombre})
        Next
        Me.cboSexo.DataSource = lObjItems
        Me.cboSexo.DisplayMember = "Valor"
        Me.cboSexo.ValueMember = "Id"
        Me.cboSexo.SelectedIndex = pObjPublicador.ObjSexo.Id
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

    Private Sub LoadCboEstado()
        Dim lColEstado As New ACWinDL.Model.clsEstados
        lColEstado.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjEstado In lColEstado
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjEstado.Id, .Valor = lObjEstado.Nombre})
        Next
        Me.cboEstado.DataSource = lObjItems
        Me.cboEstado.DisplayMember = "Valor"
        Me.cboEstado.ValueMember = "Id"
    End Sub

    Private Sub LoadCboPrivilegio()
        Dim lColPrivilegio As New ACWinDL.Model.clsPrivilegios
        lColPrivilegio.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjPrivilegio In lColPrivilegio
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjPrivilegio.Id, .Valor = lObjPrivilegio.Nombre})
        Next
        Me.cboPrivilegio.DataSource = lObjItems
        Me.cboPrivilegio.DisplayMember = "Valor"
        Me.cboPrivilegio.ValueMember = "Id"
    End Sub

    Private Sub LoadCboPrecursor()
        Dim lColPrecursor As New ACWinDL.Model.clsPrecursores
        lColPrecursor.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjPrecursor In lColPrecursor
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjPrecursor.Id, .Valor = lObjPrecursor.Nombre})
        Next
        Me.cboPrecursor.DataSource = lObjItems
        Me.cboPrecursor.DisplayMember = "Valor"
        Me.cboPrecursor.ValueMember = "Id"
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text.Length > 0 And txtApellido.Text.Length > 0 Then
            Dim lObjPublicador = New ACWinDL.Model.clsPublicador With {.Id = pObjPublicador.Id, _
                                                                       .Nombre = txtNombre.Text, _
                                                                       .Apellido = txtApellido.Text, _
                                                                       .Direccion = txtDireccion.Text, _
                                                                       .FechaBautismo = dtpFechaBautismo.Value.ToShortDateString, _
                                                                       .FechaNacimiento = dtpFechaNacimiento.Value.ToShortDateString, _
                                                                       .Ungido = chkUngido.Checked, _
                                                                       .TelefonoCasa = txtTelefonoCasa.Text, _
                                                                       .TelefonoMovil = txtTelefonoMovil.Text, _
                                                                       .TelefonoTrabajo = txtTelefonoTrabajo.Text, _
                                                                       .EMail = txtEMail.Text}
            lObjPublicador.ObjSexo = New ACWinDL.Model.clsSexo With {.Id = cboSexo.SelectedValue}
            lObjPublicador.ObjEstado = New ACWinDL.Model.clsEstado With {.Id = cboEstado.SelectedValue}
            lObjPublicador.ObjGrupo = New ACWinDL.Model.clsGrupo With {.Id = cboGrupo.SelectedValue}
            lObjPublicador.ObjPrecursor = New ACWinDL.Model.clsPrecursor With {.Id = cboPrecursor.SelectedValue}
            lObjPublicador.ObjPrivilegio = New ACWinDL.Model.clsPrivilegio With {.Id = cboPrivilegio.SelectedValue}
            lObjPublicador.dbUpdate()


            Dim lObjLWItem As ListViewItem = frmPublicadores.lwPublicadores.Items.Cast(Of ListViewItem).First(Function(x) x.Text = Convert.ToString(lObjPublicador.Id))
            lObjLWItem.SubItems.Add(lObjPublicador.Apellido)
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
            frmPublicadores.lwPublicadores.Items.Add(lObjLWItem)

            MessageBox.Show("Cambios guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPublicadores.Refresh()
            Me.Dispose()
        Else
            MessageBox.Show("Faltan cargar los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

End Class