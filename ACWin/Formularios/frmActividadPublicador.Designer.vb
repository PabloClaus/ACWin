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
        Me.lwActividadPublicador = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAnio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLibors = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFolletos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevistas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRevisitas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chEstudiosBiblicos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCredito = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNotas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTardio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNombrePublicador = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lwActividadPublicador
        '
        Me.lwActividadPublicador.BackColor = System.Drawing.SystemColors.Info
        Me.lwActividadPublicador.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chAnio, Me.chMes, Me.chLibors, Me.chFolletos, Me.chHoras, Me.chRevistas, Me.chRevisitas, Me.chEstudiosBiblicos, Me.chCredito, Me.chNotas, Me.chTardio})
        Me.lwActividadPublicador.FullRowSelect = True
        Me.lwActividadPublicador.GridLines = True
        Me.lwActividadPublicador.Location = New System.Drawing.Point(12, 80)
        Me.lwActividadPublicador.Name = "lwActividadPublicador"
        Me.lwActividadPublicador.Size = New System.Drawing.Size(850, 335)
        Me.lwActividadPublicador.TabIndex = 0
        Me.lwActividadPublicador.UseCompatibleStateImageBehavior = False
        Me.lwActividadPublicador.View = System.Windows.Forms.View.Details
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
        'chCredito
        '
        Me.chCredito.Text = "Crédito"
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
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(12, 51)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(62, 23)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
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
        'frmActividadPublicador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(881, 447)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblNombrePublicador)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lwActividadPublicador)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActividadPublicador"
        Me.Text = "Actividad Publicador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lwActividadPublicador As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chAnio As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMes As System.Windows.Forms.ColumnHeader
    Friend WithEvents chLibors As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFolletos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chHoras As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevistas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRevisitas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEstudiosBiblicos As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCredito As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNotas As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTardio As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNombrePublicador As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
