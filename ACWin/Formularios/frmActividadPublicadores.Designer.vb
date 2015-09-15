<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividadPublicadores
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
        Me.lwActividadPublicadores = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPublicador = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLibros = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFolletos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevistas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevisitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEstudiosBiblicos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNotas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreditos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTardio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblAnioMesMostrado = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboGrupo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSinInformar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lwActividadPublicadores
        '
        Me.lwActividadPublicadores.BackColor = System.Drawing.SystemColors.Info
        Me.lwActividadPublicadores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chPublicador, Me.chLibros, Me.chFolletos, Me.chHoras, Me.chRevistas, Me.chRevisitas, Me.chEstudiosBiblicos, Me.chNotas, Me.chCreditos, Me.chTardio})
        Me.lwActividadPublicadores.FullRowSelect = True
        Me.lwActividadPublicadores.GridLines = True
        Me.lwActividadPublicadores.Location = New System.Drawing.Point(12, 102)
        Me.lwActividadPublicadores.Name = "lwActividadPublicadores"
        Me.lwActividadPublicadores.Size = New System.Drawing.Size(850, 350)
        Me.lwActividadPublicadores.TabIndex = 0
        Me.lwActividadPublicadores.UseCompatibleStateImageBehavior = False
        Me.lwActividadPublicadores.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "Id"
        Me.chId.Width = 0
        '
        'chPublicador
        '
        Me.chPublicador.Text = "Publicador"
        Me.chPublicador.Width = 158
        '
        'chLibros
        '
        Me.chLibros.Text = "Libros"
        '
        'chFolletos
        '
        Me.chFolletos.Text = "Folletos"
        '
        'chHoras
        '
        Me.chHoras.Text = "Horas"
        '
        'chRevistas
        '
        Me.chRevistas.Text = "Revistas"
        '
        'chRevisitas
        '
        Me.chRevisitas.Text = "Revisitas"
        '
        'chEstudiosBiblicos
        '
        Me.chEstudiosBiblicos.Text = "Estudios B"
        Me.chEstudiosBiblicos.Width = 67
        '
        'chNotas
        '
        Me.chNotas.Text = "Notas"
        Me.chNotas.Width = 176
        '
        'chCreditos
        '
        Me.chCreditos.Text = "Créditos"
        '
        'chTardio
        '
        Me.chTardio.Text = "Tardío"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Año"
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(12, 54)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(59, 21)
        Me.cboAnio.TabIndex = 14
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(74, 54)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(58, 21)
        Me.cboMes.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Actividad Publicadores"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(800, 458)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(62, 23)
        Me.btnAceptar.TabIndex = 58
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(732, 458)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 23)
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblAnioMesMostrado
        '
        Me.lblAnioMesMostrado.AutoSize = True
        Me.lblAnioMesMostrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioMesMostrado.Location = New System.Drawing.Point(13, 83)
        Me.lblAnioMesMostrado.Name = "lblAnioMesMostrado"
        Me.lblAnioMesMostrado.Size = New System.Drawing.Size(69, 16)
        Me.lblAnioMesMostrado.TabIndex = 61
        Me.lblAnioMesMostrado.Text = "Año/Mes"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(150, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 23)
        Me.btnBuscar.TabIndex = 62
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboGrupo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkSinInformar)
        Me.GroupBox1.Location = New System.Drawing.Point(624, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 57)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cboGrupo
        '
        Me.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupo.FormattingEnabled = True
        Me.cboGrupo.Location = New System.Drawing.Point(6, 30)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Size = New System.Drawing.Size(126, 21)
        Me.cboGrupo.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Grupo"
        '
        'chkSinInformar
        '
        Me.chkSinInformar.AutoSize = True
        Me.chkSinInformar.Location = New System.Drawing.Point(138, 34)
        Me.chkSinInformar.Name = "chkSinInformar"
        Me.chkSinInformar.Size = New System.Drawing.Size(82, 17)
        Me.chkSinInformar.TabIndex = 61
        Me.chkSinInformar.Text = "Sin Informar"
        Me.chkSinInformar.UseVisualStyleBackColor = True
        '
        'frmActividadPublicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(881, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblAnioMesMostrado)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.cboAnio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lwActividadPublicadores)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActividadPublicadores"
        Me.Text = "Actividad Publicadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lwActividadPublicadores As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLibros As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFolletos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chHoras As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevistas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevisitas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEstudiosBiblicos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCreditos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNotas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTardio As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chPublicador As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAnioMesMostrado As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkSinInformar As System.Windows.Forms.CheckBox
End Class
