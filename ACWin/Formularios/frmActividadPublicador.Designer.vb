<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividadPublicador
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAnio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLibors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFolletos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevistas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevisitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEstudiosBiblicos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreditos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNotas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTardio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkTardio = New System.Windows.Forms.CheckBox()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.nudLibros = New System.Windows.Forms.NumericUpDown()
        Me.nudFolletos = New System.Windows.Forms.NumericUpDown()
        Me.nudHoras = New System.Windows.Forms.NumericUpDown()
        Me.nudRevistas = New System.Windows.Forms.NumericUpDown()
        Me.nudRevisitas = New System.Windows.Forms.NumericUpDown()
        Me.nudEstudios = New System.Windows.Forms.NumericUpDown()
        Me.nudCreditos = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNombrePublicador = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.nudLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFolletos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRevisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chAnio, Me.chMes, Me.chLibors, Me.chFolletos, Me.chHoras, Me.chRevistas, Me.chRevisitas, Me.chEstudiosBiblicos, Me.chCreditos, Me.chNotas, Me.chTardio})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(850, 335)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "Id"
        Me.chId.Width = 0
        '
        'chAnio
        '
        Me.chAnio.Text = "Año"
        '
        'chMes
        '
        Me.chMes.Text = "Mes"
        '
        'chLibors
        '
        Me.chLibors.Text = "Libros"
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
        'chCreditos
        '
        Me.chCreditos.Text = "Créditos"
        '
        'chNotas
        '
        Me.chNotas.Text = "Notas"
        Me.chNotas.Width = 176
        '
        'chTardio
        '
        Me.chTardio.Text = "Tardío"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(800, 54)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(62, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Libros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Folletos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Horas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Revistas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Revisitas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Estudios"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(500, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Créditos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(562, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Notas"
        '
        'chkTardio
        '
        Me.chkTardio.AutoSize = True
        Me.chkTardio.Location = New System.Drawing.Point(743, 57)
        Me.chkTardio.Name = "chkTardio"
        Me.chkTardio.Size = New System.Drawing.Size(56, 17)
        Me.chkTardio.TabIndex = 13
        Me.chkTardio.Text = "Tardio"
        Me.chkTardio.UseVisualStyleBackColor = True
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
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(562, 54)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(175, 20)
        Me.txtNotas.TabIndex = 22
        '
        'nudLibros
        '
        Me.nudLibros.Location = New System.Drawing.Point(135, 54)
        Me.nudLibros.Name = "nudLibros"
        Me.nudLibros.Size = New System.Drawing.Size(58, 20)
        Me.nudLibros.TabIndex = 23
        '
        'nudFolletos
        '
        Me.nudFolletos.Location = New System.Drawing.Point(196, 54)
        Me.nudFolletos.Name = "nudFolletos"
        Me.nudFolletos.Size = New System.Drawing.Size(57, 20)
        Me.nudFolletos.TabIndex = 24
        '
        'nudHoras
        '
        Me.nudHoras.Location = New System.Drawing.Point(256, 54)
        Me.nudHoras.Name = "nudHoras"
        Me.nudHoras.Size = New System.Drawing.Size(57, 20)
        Me.nudHoras.TabIndex = 25
        '
        'nudRevistas
        '
        Me.nudRevistas.Location = New System.Drawing.Point(316, 54)
        Me.nudRevistas.Name = "nudRevistas"
        Me.nudRevistas.Size = New System.Drawing.Size(57, 20)
        Me.nudRevistas.TabIndex = 26
        '
        'nudRevisitas
        '
        Me.nudRevisitas.Location = New System.Drawing.Point(376, 54)
        Me.nudRevisitas.Name = "nudRevisitas"
        Me.nudRevisitas.Size = New System.Drawing.Size(57, 20)
        Me.nudRevisitas.TabIndex = 27
        '
        'nudEstudios
        '
        Me.nudEstudios.Location = New System.Drawing.Point(435, 54)
        Me.nudEstudios.Name = "nudEstudios"
        Me.nudEstudios.Size = New System.Drawing.Size(62, 20)
        Me.nudEstudios.TabIndex = 28
        '
        'nudCreditos
        '
        Me.nudCreditos.Location = New System.Drawing.Point(500, 54)
        Me.nudCreditos.Name = "nudCreditos"
        Me.nudCreditos.Size = New System.Drawing.Size(59, 20)
        Me.nudCreditos.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Actividad"
        '
        'lblNombrePublicador
        '
        Me.lblNombrePublicador.AutoSize = True
        Me.lblNombrePublicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePublicador.Location = New System.Drawing.Point(90, 10)
        Me.lblNombrePublicador.Name = "lblNombrePublicador"
        Me.lblNombrePublicador.Size = New System.Drawing.Size(160, 20)
        Me.lblNombrePublicador.TabIndex = 31
        Me.lblNombrePublicador.Text = "Nombre Publicador"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(800, 421)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(62, 23)
        Me.btnAceptar.TabIndex = 58
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(732, 421)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 23)
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(881, 447)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblNombrePublicador)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.nudCreditos)
        Me.Controls.Add(Me.nudEstudios)
        Me.Controls.Add(Me.nudRevisitas)
        Me.Controls.Add(Me.nudRevistas)
        Me.Controls.Add(Me.nudHoras)
        Me.Controls.Add(Me.nudFolletos)
        Me.Controls.Add(Me.nudLibros)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.cboMes)
        Me.Controls.Add(Me.cboAnio)
        Me.Controls.Add(Me.chkTardio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ListView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActividad"
        Me.Text = "Actividad"
        CType(Me.nudLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFolletos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRevistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRevisitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAnio As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMes As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLibors As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFolletos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chHoras As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevistas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevisitas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEstudiosBiblicos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCreditos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNotas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTardio As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkTardio As System.Windows.Forms.CheckBox
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents nudLibros As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFolletos As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHoras As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRevistas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRevisitas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudEstudios As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCreditos As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNombrePublicador As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
