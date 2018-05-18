<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atrasados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Atrasados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.AniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAtrasados = New System.Windows.Forms.DataGridView()
        Me.residente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrarResidente = New System.Windows.Forms.Button()
        Me.btnRegistrarPagos = New System.Windows.Forms.Button()
        Me.AniosTableAdapter = New Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter()
        Me.MesesTableAdapter = New Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter()
        Me.btnListadoResidentes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAtrasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbAnio)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.btnPDF)
        Me.GroupBox1.Controls.Add(Me.btnNuevaConsulta)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 67)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(304, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(167, 47)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbAnio
        '
        Me.cmbAnio.DataSource = Me.AniosBindingSource
        Me.cmbAnio.DisplayMember = "anio"
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(8, 23)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(121, 30)
        Me.cmbAnio.TabIndex = 0
        '
        'AniosBindingSource
        '
        Me.AniosBindingSource.DataMember = "anios"
        Me.AniosBindingSource.DataSource = Me.ProvecDataSet
        '
        'ProvecDataSet
        '
        Me.ProvecDataSet.DataSetName = "ProvecDataSet"
        Me.ProvecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbMes
        '
        Me.cmbMes.DataSource = Me.MesesBindingSource
        Me.cmbMes.DisplayMember = "meses"
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(135, 23)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(163, 30)
        Me.cmbMes.TabIndex = 1
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "meses"
        Me.MesesBindingSource.DataSource = Me.ProvecDataSet
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPDF.ForeColor = System.Drawing.Color.White
        Me.btnPDF.Location = New System.Drawing.Point(831, 14)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(167, 47)
        Me.btnPDF.TabIndex = 4
        Me.btnPDF.Text = "Generar PDF"
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(477, 14)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(167, 47)
        Me.btnNuevaConsulta.TabIndex = 3
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAtrasados)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1002, 531)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'dgvAtrasados
        '
        Me.dgvAtrasados.AllowUserToAddRows = False
        Me.dgvAtrasados.AllowUserToDeleteRows = False
        Me.dgvAtrasados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAtrasados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvAtrasados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAtrasados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAtrasados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvAtrasados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAtrasados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAtrasados.ColumnHeadersHeight = 40
        Me.dgvAtrasados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.residente, Me.nombre, Me.apellido, Me.edificio, Me.dto, Me.email, Me.telefono})
        Me.dgvAtrasados.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAtrasados.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.dgvAtrasados.Location = New System.Drawing.Point(8, 28)
        Me.dgvAtrasados.Name = "dgvAtrasados"
        Me.dgvAtrasados.ReadOnly = True
        Me.dgvAtrasados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvAtrasados.RowHeadersWidth = 40
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.dgvAtrasados.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAtrasados.Size = New System.Drawing.Size(988, 489)
        Me.dgvAtrasados.TabIndex = 7
        '
        'residente
        '
        Me.residente.HeaderText = "Residente"
        Me.residente.Name = "residente"
        Me.residente.ReadOnly = True
        Me.residente.Width = 110
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 98
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 96
        '
        'edificio
        '
        Me.edificio.HeaderText = "Edificio"
        Me.edificio.Name = "edificio"
        Me.edificio.ReadOnly = True
        Me.edificio.Width = 90
        '
        'dto
        '
        Me.dto.HeaderText = "Dto"
        Me.dto.Name = "dto"
        Me.dto.ReadOnly = True
        Me.dto.Width = 63
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 76
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 101
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(865, 610)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(147, 47)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(702, 610)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(157, 47)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistrarResidente
        '
        Me.btnRegistrarResidente.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrarResidente.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarResidente.Location = New System.Drawing.Point(523, 610)
        Me.btnRegistrarResidente.Name = "btnRegistrarResidente"
        Me.btnRegistrarResidente.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistrarResidente.TabIndex = 7
        Me.btnRegistrarResidente.Text = "Registrar Residente"
        Me.btnRegistrarResidente.UseVisualStyleBackColor = False
        '
        'btnRegistrarPagos
        '
        Me.btnRegistrarPagos.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrarPagos.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarPagos.Location = New System.Drawing.Point(350, 610)
        Me.btnRegistrarPagos.Name = "btnRegistrarPagos"
        Me.btnRegistrarPagos.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistrarPagos.TabIndex = 6
        Me.btnRegistrarPagos.Text = "Registrar Pago"
        Me.btnRegistrarPagos.UseVisualStyleBackColor = False
        '
        'AniosTableAdapter
        '
        Me.AniosTableAdapter.ClearBeforeFill = True
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'btnListadoResidentes
        '
        Me.btnListadoResidentes.BackColor = System.Drawing.Color.Gray
        Me.btnListadoResidentes.ForeColor = System.Drawing.Color.White
        Me.btnListadoResidentes.Location = New System.Drawing.Point(169, 610)
        Me.btnListadoResidentes.Name = "btnListadoResidentes"
        Me.btnListadoResidentes.Size = New System.Drawing.Size(167, 47)
        Me.btnListadoResidentes.TabIndex = 10
        Me.btnListadoResidentes.Text = "Listado Residentes"
        Me.btnListadoResidentes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(8, 610)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 47)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Totales"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Atrasados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnListadoResidentes)
        Me.Controls.Add(Me.btnRegistrarPagos)
        Me.Controls.Add(Me.btnRegistrarResidente)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Atrasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atrasados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAtrasados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnNuevaConsulta As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarResidente As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarPagos As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents dgvAtrasados As System.Windows.Forms.DataGridView
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents AniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AniosTableAdapter As Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter
    Friend WithEvents MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesesTableAdapter As Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter
    Friend WithEvents residente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnListadoResidentes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
