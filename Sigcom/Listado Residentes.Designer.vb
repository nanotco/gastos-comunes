<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_Residentes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado_Residentes))
        Me.grbBusqueda = New System.Windows.Forms.GroupBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbApellido = New System.Windows.Forms.RadioButton()
        Me.rbEdificio = New System.Windows.Forms.RadioButton()
        Me.rbDepto = New System.Windows.Forms.RadioButton()
        Me.rbRut = New System.Windows.Forms.RadioButton()
        Me.grbResultados = New System.Windows.Forms.GroupBox()
        Me.dgvListResidentes = New System.Windows.Forms.DataGridView()
        Me.RutResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TorreResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptoResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoResidenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistraResidentes = New System.Windows.Forms.Button()
        Me.ResidenteTableAdapter = New Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter()
        Me.btnIrAtrasados = New System.Windows.Forms.Button()
        Me.btnTotales = New System.Windows.Forms.Button()
        Me.btnRegistrPago = New System.Windows.Forms.Button()
        Me.grbBusqueda.SuspendLayout()
        Me.grbResultados.SuspendLayout()
        CType(Me.dgvListResidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbBusqueda
        '
        Me.grbBusqueda.Controls.Add(Me.btnPDF)
        Me.grbBusqueda.Controls.Add(Me.btnNuevaConsulta)
        Me.grbBusqueda.Controls.Add(Me.txtBuscar)
        Me.grbBusqueda.Controls.Add(Me.rbNombre)
        Me.grbBusqueda.Controls.Add(Me.rbApellido)
        Me.grbBusqueda.Controls.Add(Me.rbEdificio)
        Me.grbBusqueda.Controls.Add(Me.rbDepto)
        Me.grbBusqueda.Controls.Add(Me.rbRut)
        Me.grbBusqueda.Location = New System.Drawing.Point(8, 1)
        Me.grbBusqueda.Name = "grbBusqueda"
        Me.grbBusqueda.Size = New System.Drawing.Size(1008, 67)
        Me.grbBusqueda.TabIndex = 0
        Me.grbBusqueda.TabStop = False
        Me.grbBusqueda.Text = "Búsqueda"
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPDF.ForeColor = System.Drawing.Color.White
        Me.btnPDF.Location = New System.Drawing.Point(833, 14)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(167, 47)
        Me.btnPDF.TabIndex = 7
        Me.btnPDF.Text = "Generar PDF"
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(586, 14)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(167, 47)
        Me.btnNuevaConsulta.TabIndex = 6
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBuscar.Location = New System.Drawing.Point(422, 23)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(158, 29)
        Me.txtBuscar.TabIndex = 5
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbNombre.Location = New System.Drawing.Point(60, 23)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(91, 26)
        Me.rbNombre.TabIndex = 1
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = False
        '
        'rbApellido
        '
        Me.rbApellido.AutoSize = True
        Me.rbApellido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbApellido.Location = New System.Drawing.Point(157, 24)
        Me.rbApellido.Name = "rbApellido"
        Me.rbApellido.Size = New System.Drawing.Size(89, 26)
        Me.rbApellido.TabIndex = 2
        Me.rbApellido.TabStop = True
        Me.rbApellido.Text = "Apellido"
        Me.rbApellido.UseVisualStyleBackColor = False
        '
        'rbEdificio
        '
        Me.rbEdificio.AutoSize = True
        Me.rbEdificio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbEdificio.Location = New System.Drawing.Point(252, 23)
        Me.rbEdificio.Name = "rbEdificio"
        Me.rbEdificio.Size = New System.Drawing.Size(83, 26)
        Me.rbEdificio.TabIndex = 3
        Me.rbEdificio.TabStop = True
        Me.rbEdificio.Text = "Edificio"
        Me.rbEdificio.UseVisualStyleBackColor = False
        '
        'rbDepto
        '
        Me.rbDepto.AutoSize = True
        Me.rbDepto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbDepto.Location = New System.Drawing.Point(341, 23)
        Me.rbDepto.Name = "rbDepto"
        Me.rbDepto.Size = New System.Drawing.Size(75, 26)
        Me.rbDepto.TabIndex = 4
        Me.rbDepto.TabStop = True
        Me.rbDepto.Text = "Depto"
        Me.rbDepto.UseVisualStyleBackColor = False
        '
        'rbRut
        '
        Me.rbRut.AutoSize = True
        Me.rbRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbRut.Location = New System.Drawing.Point(6, 23)
        Me.rbRut.Name = "rbRut"
        Me.rbRut.Size = New System.Drawing.Size(59, 26)
        Me.rbRut.TabIndex = 0
        Me.rbRut.TabStop = True
        Me.rbRut.Text = "RUT"
        Me.rbRut.UseVisualStyleBackColor = False
        '
        'grbResultados
        '
        Me.grbResultados.Controls.Add(Me.dgvListResidentes)
        Me.grbResultados.Location = New System.Drawing.Point(12, 74)
        Me.grbResultados.Name = "grbResultados"
        Me.grbResultados.Size = New System.Drawing.Size(1004, 525)
        Me.grbResultados.TabIndex = 1
        Me.grbResultados.TabStop = False
        Me.grbResultados.Text = "Resultados"
        '
        'dgvListResidentes
        '
        Me.dgvListResidentes.AllowUserToAddRows = False
        Me.dgvListResidentes.AllowUserToDeleteRows = False
        Me.dgvListResidentes.AutoGenerateColumns = False
        Me.dgvListResidentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvListResidentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvListResidentes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvListResidentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListResidentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvListResidentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListResidentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListResidentes.ColumnHeadersHeight = 40
        Me.dgvListResidentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutResidenteDataGridViewTextBoxColumn, Me.NombresResidenteDataGridViewTextBoxColumn, Me.ApellidosResidenteDataGridViewTextBoxColumn, Me.TorreResidenteDataGridViewTextBoxColumn, Me.DeptoResidenteDataGridViewTextBoxColumn, Me.EmailResidenteDataGridViewTextBoxColumn, Me.TelefonoResidenteDataGridViewTextBoxColumn})
        Me.dgvListResidentes.DataSource = Me.ResidenteBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListResidentes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListResidentes.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvListResidentes.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.dgvListResidentes.Location = New System.Drawing.Point(6, 28)
        Me.dgvListResidentes.Name = "dgvListResidentes"
        Me.dgvListResidentes.ReadOnly = True
        Me.dgvListResidentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListResidentes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListResidentes.RowHeadersWidth = 40
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvListResidentes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListResidentes.Size = New System.Drawing.Size(992, 489)
        Me.dgvListResidentes.TabIndex = 7
        '
        'RutResidenteDataGridViewTextBoxColumn
        '
        Me.RutResidenteDataGridViewTextBoxColumn.DataPropertyName = "rutResidente"
        Me.RutResidenteDataGridViewTextBoxColumn.HeaderText = "Residente"
        Me.RutResidenteDataGridViewTextBoxColumn.Name = "RutResidenteDataGridViewTextBoxColumn"
        Me.RutResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutResidenteDataGridViewTextBoxColumn.Width = 110
        '
        'NombresResidenteDataGridViewTextBoxColumn
        '
        Me.NombresResidenteDataGridViewTextBoxColumn.DataPropertyName = "NombresResidente"
        Me.NombresResidenteDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombresResidenteDataGridViewTextBoxColumn.Name = "NombresResidenteDataGridViewTextBoxColumn"
        Me.NombresResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombresResidenteDataGridViewTextBoxColumn.Width = 98
        '
        'ApellidosResidenteDataGridViewTextBoxColumn
        '
        Me.ApellidosResidenteDataGridViewTextBoxColumn.DataPropertyName = "ApellidosResidente"
        Me.ApellidosResidenteDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidosResidenteDataGridViewTextBoxColumn.Name = "ApellidosResidenteDataGridViewTextBoxColumn"
        Me.ApellidosResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosResidenteDataGridViewTextBoxColumn.Width = 96
        '
        'TorreResidenteDataGridViewTextBoxColumn
        '
        Me.TorreResidenteDataGridViewTextBoxColumn.DataPropertyName = "TorreResidente"
        Me.TorreResidenteDataGridViewTextBoxColumn.HeaderText = "Edificio"
        Me.TorreResidenteDataGridViewTextBoxColumn.Name = "TorreResidenteDataGridViewTextBoxColumn"
        Me.TorreResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.TorreResidenteDataGridViewTextBoxColumn.Width = 90
        '
        'DeptoResidenteDataGridViewTextBoxColumn
        '
        Me.DeptoResidenteDataGridViewTextBoxColumn.DataPropertyName = "DeptoResidente"
        Me.DeptoResidenteDataGridViewTextBoxColumn.HeaderText = "Dto"
        Me.DeptoResidenteDataGridViewTextBoxColumn.Name = "DeptoResidenteDataGridViewTextBoxColumn"
        Me.DeptoResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeptoResidenteDataGridViewTextBoxColumn.Width = 63
        '
        'EmailResidenteDataGridViewTextBoxColumn
        '
        Me.EmailResidenteDataGridViewTextBoxColumn.DataPropertyName = "emailResidente"
        Me.EmailResidenteDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailResidenteDataGridViewTextBoxColumn.Name = "EmailResidenteDataGridViewTextBoxColumn"
        Me.EmailResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailResidenteDataGridViewTextBoxColumn.Width = 76
        '
        'TelefonoResidenteDataGridViewTextBoxColumn
        '
        Me.TelefonoResidenteDataGridViewTextBoxColumn.DataPropertyName = "telefonoResidente"
        Me.TelefonoResidenteDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoResidenteDataGridViewTextBoxColumn.Name = "TelefonoResidenteDataGridViewTextBoxColumn"
        Me.TelefonoResidenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoResidenteDataGridViewTextBoxColumn.Width = 101
        '
        'ResidenteBindingSource
        '
        Me.ResidenteBindingSource.DataMember = "residente"
        Me.ResidenteBindingSource.DataSource = Me.ProvecDataSet
        '
        'ProvecDataSet
        '
        Me.ProvecDataSet.DataSetName = "ProvecDataSet"
        Me.ProvecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(861, 605)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(155, 47)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(700, 605)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(155, 47)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistraResidentes
        '
        Me.btnRegistraResidentes.BackColor = System.Drawing.Color.Gray
        Me.btnRegistraResidentes.ForeColor = System.Drawing.Color.White
        Me.btnRegistraResidentes.Location = New System.Drawing.Point(527, 605)
        Me.btnRegistraResidentes.Name = "btnRegistraResidentes"
        Me.btnRegistraResidentes.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistraResidentes.TabIndex = 9
        Me.btnRegistraResidentes.Text = "Registrar Residente"
        Me.btnRegistraResidentes.UseVisualStyleBackColor = False
        '
        'ResidenteTableAdapter
        '
        Me.ResidenteTableAdapter.ClearBeforeFill = True
        '
        'btnIrAtrasados
        '
        Me.btnIrAtrasados.BackColor = System.Drawing.Color.Gray
        Me.btnIrAtrasados.ForeColor = System.Drawing.Color.White
        Me.btnIrAtrasados.Location = New System.Drawing.Point(354, 605)
        Me.btnIrAtrasados.Name = "btnIrAtrasados"
        Me.btnIrAtrasados.Size = New System.Drawing.Size(167, 47)
        Me.btnIrAtrasados.TabIndex = 12
        Me.btnIrAtrasados.Text = "Ir a Atrasados"
        Me.btnIrAtrasados.UseVisualStyleBackColor = False
        '
        'btnTotales
        '
        Me.btnTotales.BackColor = System.Drawing.Color.Gray
        Me.btnTotales.ForeColor = System.Drawing.Color.White
        Me.btnTotales.Location = New System.Drawing.Point(181, 605)
        Me.btnTotales.Name = "btnTotales"
        Me.btnTotales.Size = New System.Drawing.Size(167, 47)
        Me.btnTotales.TabIndex = 13
        Me.btnTotales.Text = "Totales"
        Me.btnTotales.UseVisualStyleBackColor = False
        '
        'btnRegistrPago
        '
        Me.btnRegistrPago.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrPago.ForeColor = System.Drawing.Color.White
        Me.btnRegistrPago.Location = New System.Drawing.Point(14, 605)
        Me.btnRegistrPago.Name = "btnRegistrPago"
        Me.btnRegistrPago.Size = New System.Drawing.Size(161, 47)
        Me.btnRegistrPago.TabIndex = 14
        Me.btnRegistrPago.Text = "Registrar Pago"
        Me.btnRegistrPago.UseVisualStyleBackColor = False
        '
        'Listado_Residentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.btnRegistrPago)
        Me.Controls.Add(Me.btnTotales)
        Me.Controls.Add(Me.btnIrAtrasados)
        Me.Controls.Add(Me.btnRegistraResidentes)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.grbResultados)
        Me.Controls.Add(Me.grbBusqueda)
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Listado_Residentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Residentes"
        Me.grbBusqueda.ResumeLayout(False)
        Me.grbBusqueda.PerformLayout()
        Me.grbResultados.ResumeLayout(False)
        CType(Me.dgvListResidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnNuevaConsulta As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbEdificio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDepto As System.Windows.Forms.RadioButton
    Friend WithEvents rbRut As System.Windows.Forms.RadioButton
    Friend WithEvents grbResultados As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistraResidentes As System.Windows.Forms.Button
    Friend WithEvents dgvListResidentes As System.Windows.Forms.DataGridView
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents ResidenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResidenteTableAdapter As Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter
    Friend WithEvents RutResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TorreResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptoResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoResidenteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnIrAtrasados As System.Windows.Forms.Button
    Friend WithEvents btnTotales As System.Windows.Forms.Button
    Friend WithEvents btnRegistrPago As System.Windows.Forms.Button
End Class
