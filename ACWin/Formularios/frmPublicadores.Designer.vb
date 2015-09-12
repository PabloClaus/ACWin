<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPublicadores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lwPublicadores = New System.Windows.Forms.ListView()
        Me.chApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefonoCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefonoMovil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefonoTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFechaNacimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFechaBautismo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrivilegio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrecursor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chGrupo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lwPublicadores
        '
        Me.lwPublicadores.AllowColumnReorder = True
        Me.lwPublicadores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chApellido, Me.chNombre, Me.chDireccion, Me.chTelefonoCasa, Me.chTelefonoMovil, Me.chTelefonoTrabajo, Me.chFechaNacimiento, Me.chFechaBautismo, Me.chPrivilegio, Me.chPrecursor, Me.chGrupo})
        Me.lwPublicadores.FullRowSelect = True
        Me.lwPublicadores.GridLines = True
        Me.lwPublicadores.Location = New System.Drawing.Point(13, 65)
        Me.lwPublicadores.Name = "lwPublicadores"
        Me.lwPublicadores.Size = New System.Drawing.Size(1024, 377)
        Me.lwPublicadores.TabIndex = 0
        Me.lwPublicadores.UseCompatibleStateImageBehavior = False
        Me.lwPublicadores.View = System.Windows.Forms.View.Details
        '
        'chApellido
        '
        Me.chApellido.Text = "Apellido"
        Me.chApellido.Width = 92
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre"
        Me.chNombre.Width = 86
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 87
        '
        'chTelefonoCasa
        '
        Me.chTelefonoCasa.Text = "Teléfono Casa"
        Me.chTelefonoCasa.Width = 91
        '
        'chTelefonoMovil
        '
        Me.chTelefonoMovil.Text = "Telefono Móvil"
        Me.chTelefonoMovil.Width = 90
        '
        'chTelefonoTrabajo
        '
        Me.chTelefonoTrabajo.Text = "Teléfono Trabajo"
        Me.chTelefonoTrabajo.Width = 102
        '
        'chFechaNacimiento
        '
        Me.chFechaNacimiento.Text = "Fecha Nacimiento"
        Me.chFechaNacimiento.Width = 107
        '
        'chFechaBautismo
        '
        Me.chFechaBautismo.Text = "Fecha Bautismo"
        Me.chFechaBautismo.Width = 108
        '
        'chPrivilegio
        '
        Me.chPrivilegio.Text = "Privilegio"
        Me.chPrivilegio.Width = 84
        '
        'chPrecursor
        '
        Me.chPrecursor.Text = "Precursor"
        Me.chPrecursor.Width = 77
        '
        'chGrupo
        '
        Me.chGrupo.Text = "Grupo"
        Me.chGrupo.Width = 81
        '
        'btNuevo
        '
        Me.btNuevo.Location = New System.Drawing.Point(13, 36)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btNuevo.TabIndex = 1
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(99, 36)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(185, 36)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Publicadores"
        '
        'frmPublicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1049, 454)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.lwPublicadores)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPublicadores"
        Me.Text = "ABM Publicadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lwPublicadores As System.Windows.Forms.ListView
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents chApellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefonoCasa As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefonoMovil As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefonoTrabajo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFechaNacimiento As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFechaBautismo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPrivilegio As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPrecursor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chGrupo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
