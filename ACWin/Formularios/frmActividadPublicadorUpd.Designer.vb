<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividadPublicadorUpd
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
        Me.lblNombrePublicador = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudCreditos = New System.Windows.Forms.NumericUpDown()
        Me.nudEstudios = New System.Windows.Forms.NumericUpDown()
        Me.nudRevisitas = New System.Windows.Forms.NumericUpDown()
        Me.nudRevistas = New System.Windows.Forms.NumericUpDown()
        Me.nudHoras = New System.Windows.Forms.NumericUpDown()
        Me.nudFolletos = New System.Windows.Forms.NumericUpDown()
        Me.nudLibros = New System.Windows.Forms.NumericUpDown()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.cboMes = New System.Windows.Forms.ComboBox()
        Me.cboAnio = New System.Windows.Forms.ComboBox()
        Me.chkTardio = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.nudCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRevisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRevistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFolletos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombrePublicador
        '
        Me.lblNombrePublicador.AutoSize = True
        Me.lblNombrePublicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePublicador.Location = New System.Drawing.Point(93, 9)
        Me.lblNombrePublicador.Name = "lblNombrePublicador"
        Me.lblNombrePublicador.Size = New System.Drawing.Size(160, 20)
        Me.lblNombrePublicador.TabIndex = 55
        Me.lblNombrePublicador.Text = "Nombre Publicador"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 20)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Actividad"
        '
        'nudCreditos
        '
        Me.nudCreditos.Location = New System.Drawing.Point(503, 53)
        Me.nudCreditos.Name = "nudCreditos"
        Me.nudCreditos.Size = New System.Drawing.Size(59, 20)
        Me.nudCreditos.TabIndex = 53
        '
        'nudEstudios
        '
        Me.nudEstudios.Location = New System.Drawing.Point(438, 53)
        Me.nudEstudios.Name = "nudEstudios"
        Me.nudEstudios.Size = New System.Drawing.Size(62, 20)
        Me.nudEstudios.TabIndex = 52
        '
        'nudRevisitas
        '
        Me.nudRevisitas.Location = New System.Drawing.Point(379, 53)
        Me.nudRevisitas.Name = "nudRevisitas"
        Me.nudRevisitas.Size = New System.Drawing.Size(57, 20)
        Me.nudRevisitas.TabIndex = 51
        '
        'nudRevistas
        '
        Me.nudRevistas.Location = New System.Drawing.Point(319, 53)
        Me.nudRevistas.Name = "nudRevistas"
        Me.nudRevistas.Size = New System.Drawing.Size(57, 20)
        Me.nudRevistas.TabIndex = 50
        '
        'nudHoras
        '
        Me.nudHoras.Location = New System.Drawing.Point(259, 53)
        Me.nudHoras.Name = "nudHoras"
        Me.nudHoras.Size = New System.Drawing.Size(57, 20)
        Me.nudHoras.TabIndex = 49
        '
        'nudFolletos
        '
        Me.nudFolletos.Location = New System.Drawing.Point(199, 53)
        Me.nudFolletos.Name = "nudFolletos"
        Me.nudFolletos.Size = New System.Drawing.Size(57, 20)
        Me.nudFolletos.TabIndex = 48
        '
        'nudLibros
        '
        Me.nudLibros.Location = New System.Drawing.Point(138, 53)
        Me.nudLibros.Name = "nudLibros"
        Me.nudLibros.Size = New System.Drawing.Size(58, 20)
        Me.nudLibros.TabIndex = 47
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(565, 53)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(175, 20)
        Me.txtNotas.TabIndex = 46
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.Enabled = False
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(77, 53)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(58, 21)
        Me.cboMes.TabIndex = 45
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.Enabled = False
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(15, 53)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(59, 21)
        Me.cboAnio.TabIndex = 44
        '
        'chkTardio
        '
        Me.chkTardio.AutoSize = True
        Me.chkTardio.Location = New System.Drawing.Point(746, 56)
        Me.chkTardio.Name = "chkTardio"
        Me.chkTardio.Size = New System.Drawing.Size(56, 17)
        Me.chkTardio.TabIndex = 43
        Me.chkTardio.Text = "Tardio"
        Me.chkTardio.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(565, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Notas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(503, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Créditos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(438, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Estudios"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Revisitas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(319, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Revistas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Horas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Folletos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Libros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Mes"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(672, 91)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 23)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(740, 91)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(62, 23)
        Me.btnAceptar.TabIndex = 56
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmActividadUpd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(824, 126)
        Me.Controls.Add(Me.btnAceptar)
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
        Me.Controls.Add(Me.btnCancelar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActividadUpd"
        Me.Text = "Actualizar Informe"
        CType(Me.nudCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRevisitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRevistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFolletos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombrePublicador As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudCreditos As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudEstudios As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRevisitas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRevistas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHoras As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFolletos As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLibros As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNotas As System.Windows.Forms.TextBox
    Friend WithEvents cboMes As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
    Friend WithEvents chkTardio As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
