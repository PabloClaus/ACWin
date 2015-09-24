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
        LoadCboMotivoAlta()
        LoadCboMotivoBaja()
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
            Me.txtTelefonoCasa.Text = .TelefonoCasa
            Me.txtTelefonoMovil.Text = .TelefonoMovil
            Me.txtTelefonoTrabajo.Text = .TelefonoTrabajo
            Me.txtEMail.Text = .EMail
            Me.dtpFechaBautismo.Value = .FechaBautismo
            Me.dtpFechaNacimiento.Value = .FechaNacimiento
            Me.chkUngido.Checked = .Ungido
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
        Me.cboSexo.SelectedIndex = Me.cboSexo.FindStringExact(pObjPublicador.ObjSexo.Nombre)
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
        Me.cboGrupo.SelectedIndex = Me.cboGrupo.FindStringExact(pObjPublicador.ObjGrupo.Nombre)
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
        Me.cboEstado.SelectedIndex = Me.cboEstado.FindStringExact(pObjPublicador.ObjEstado.Nombre)
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
        Me.cboPrivilegio.SelectedIndex = Me.cboPrivilegio.FindStringExact(pObjPublicador.ObjPrivilegio.Nombre)
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
        Me.cboPrecursor.SelectedIndex = Me.cboPrecursor.FindStringExact(pObjPublicador.ObjPrecursor.Nombre)
    End Sub

    Private Sub LoadCboMotivoAlta()
        Dim lColMotivoAlta As New ACWinDL.Model.clsMotivosAlta
        lColMotivoAlta.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjMotivoAlta In lColMotivoAlta
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjMotivoAlta.Id, .Valor = lObjMotivoAlta.Nombre})
        Next
        Me.cboMotivoAlta.DataSource = lObjItems
        Me.cboMotivoAlta.DisplayMember = "Valor"
        Me.cboMotivoAlta.ValueMember = "Id"
        Me.cboMotivoAlta.SelectedIndex = Me.cboMotivoAlta.FindStringExact(pObjPublicador.ObjPublicadorMotivoAlta.ObjMotivoAlta.Nombre)
    End Sub

    Private Sub LoadCboMotivoBaja()
        Dim lColMotivoBaja As New ACWinDL.Model.clsMotivosBaja
        lColMotivoBaja.dbGetAll()
        Dim lObjItems As New List(Of Model.clsComboBoxItem)
        For Each lObjMotivoBaja In lColMotivoBaja
            lObjItems.Add(New Model.clsComboBoxItem With {.Id = lObjMotivoBaja.Id, .Valor = lObjMotivoBaja.Nombre})
        Next
        Me.cboMotivoBaja.DataSource = lObjItems
        Me.cboMotivoBaja.DisplayMember = "Valor"
        Me.cboMotivoBaja.ValueMember = "Id"
        Me.cboMotivoBaja.SelectedIndex = Me.cboMotivoBaja.FindStringExact(pObjPublicador.ObjPublicadorMotivoBaja.ObjMotivoBaja.Nombre)
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
            lObjPublicador.ObjSexo = New ACWinDL.Model.clsSexo With {.Id = cboSexo.SelectedValue, .Nombre = cboSexo.SelectedItem.Valor}
            lObjPublicador.ObjEstado = New ACWinDL.Model.clsEstado With {.Id = cboEstado.SelectedValue, .Nombre = cboEstado.SelectedItem.Valor}
            lObjPublicador.ObjGrupo = New ACWinDL.Model.clsGrupo With {.Id = cboGrupo.SelectedValue, .Nombre = cboGrupo.SelectedItem.Valor}
            lObjPublicador.ObjPrecursor = New ACWinDL.Model.clsPrecursor With {.Id = cboPrecursor.SelectedValue, .Nombre = cboPrecursor.SelectedItem.Valor}
            lObjPublicador.ObjPrivilegio = New ACWinDL.Model.clsPrivilegio With {.Id = cboPrivilegio.SelectedValue, .Nombre = cboPrivilegio.SelectedItem.Valor}
            lObjPublicador.ObjPublicadorMotivoAlta = New ACWinDL.Model.clsPublicadorMotivoAlta With {.Fecha = dtpFechaInicioMotivoAlta.Value.ToShortDateString}
            lObjPublicador.ObjPublicadorMotivoAlta.ObjMotivoAlta = New ACWinDL.Model.clsMotivoAlta With {.Id = cboMotivoAlta.SelectedValue}
            lObjPublicador.ObjPublicadorMotivoBaja = New ACWinDL.Model.clsPublicadorMotivoBaja With {.Fecha = dtpFechaInicioMotivoBaja.Value.ToShortDateString}
            lObjPublicador.ObjPublicadorMotivoBaja.ObjMotivoBaja = New ACWinDL.Model.clsMotivoBaja With {.Id = cboMotivoBaja.SelectedValue}
            lObjPublicador.dbUpdate()


            Dim lIndex As Integer = frmPublicadores.lwPublicadores.Items.IndexOfKey(Convert.ToString(lObjPublicador.Id))
            frmPublicadores.lwPublicadores.Items.RemoveByKey(Convert.ToString(lObjPublicador.Id))
            Dim lObjLWItem As New ListViewItem(lObjPublicador.Id)
            lObjLWItem.Name = lObjPublicador.Id
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
            frmPublicadores.lwPublicadores.Items.Insert(lIndex, lObjLWItem)

            MessageBox.Show("Cambios guardados correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmPublicadores.Refresh()
            Me.Dispose()
        Else
            MessageBox.Show("Faltan cargar los campos obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub

    Private Sub chkBaja_CheckedChanged(sender As Object, e As EventArgs) Handles chkBaja.CheckedChanged
        gbBaja.Enabled = chkBaja.Checked
    End Sub

End Class