<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Totales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Totales))
        Me.gbBusqueda = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.ResidenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.cmbEdificio = New System.Windows.Forms.ComboBox()
        Me.TorresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.AniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.gbResultados = New System.Windows.Forms.GroupBox()
        Me.dgvTotales = New System.Windows.Forms.DataGridView()
        Me.IdPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdificioPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutResidentePagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorCuotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallepagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrarPago = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Detalle_pagoTableAdapter = New Sigcom.ProvecDataSetTableAdapters.detalle_pagoTableAdapter()
        Me.AniosTableAdapter = New Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter()
        Me.MesesTableAdapter = New Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter()
        Me.TorresTableAdapter = New Sigcom.ProvecDataSetTableAdapters.torresTableAdapter()
        Me.ResidenteTableAdapter = New Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter()
        Me.btnAtrasados = New System.Windows.Forms.Button()
        Me.gbBusqueda.SuspendLayout()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultados.SuspendLayout()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallepagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBusqueda
        '
        Me.gbBusqueda.Controls.Add(Me.Label5)
        Me.gbBusqueda.Controls.Add(Me.Label4)
        Me.gbBusqueda.Controls.Add(Me.Label3)
        Me.gbBusqueda.Controls.Add(Me.Label2)
        Me.gbBusqueda.Controls.Add(Me.cmbRut)
        Me.gbBusqueda.Controls.Add(Me.cmbEdificio)
        Me.gbBusqueda.Controls.Add(Me.cmbMes)
        Me.gbBusqueda.Controls.Add(Me.cmbAnio)
        Me.gbBusqueda.Controls.Add(Me.btnPDF)
        Me.gbBusqueda.Controls.Add(Me.btnNuevaConsulta)
        Me.gbBusqueda.Location = New System.Drawing.Point(10, 2)
        Me.gbBusqueda.Name = "gbBusqueda"
        Me.gbBusqueda.Size = New System.Drawing.Size(934, 67)
        Me.gbBusqueda.TabIndex = 1
        Me.gbBusqueda.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Por RUT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(243, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "3° Edificio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2° Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1° Año"
        '
        'cmbRut
        '
        Me.cmbRut.DataSource = Me.ResidenteBindingSource
        Me.cmbRut.DisplayMember = "rutResidente"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(373, 23)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(121, 30)
        Me.cmbRut.TabIndex = 3
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
        'cmbEdificio
        '
        Me.cmbEdificio.DataSource = Me.TorresBindingSource
        Me.cmbEdificio.DisplayMember = "nombreTorre"
        Me.cmbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEdificio.FormattingEnabled = True
        Me.cmbEdificio.Location = New System.Drawing.Point(246, 23)
        Me.cmbEdificio.Name = "cmbEdificio"
        Me.cmbEdificio.Size = New System.Drawing.Size(121, 30)
        Me.cmbEdificio.TabIndex = 2
        '
        'TorresBindingSource
        '
        Me.TorresBindingSource.DataMember = "torres"
        Me.TorresBindingSource.DataSource = Me.ProvecDataSet
        '
        'cmbMes
        '
        Me.cmbMes.DataSource = Me.MesesBindingSource
        Me.cmbMes.DisplayMember = "meses"
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(109, 23)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(131, 30)
        Me.cmbMes.TabIndex = 1
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "meses"
        Me.MesesBindingSource.DataSource = Me.ProvecDataSet
        '
        'cmbAnio
        '
        Me.cmbAnio.DataSource = Me.AniosBindingSource
        Me.cmbAnio.DisplayMember = "anio"
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(6, 23)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(97, 30)
        Me.cmbAnio.TabIndex = 0
        '
        'AniosBindingSource
        '
        Me.AniosBindingSource.DataMember = "anios"
        Me.AniosBindingSource.DataSource = Me.ProvecDataSet
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPDF.ForeColor = System.Drawing.Color.White
        Me.btnPDF.Location = New System.Drawing.Point(759, 14)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(167, 47)
        Me.btnPDF.TabIndex = 5
        Me.btnPDF.Text = "Generar PDF"
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(500, 14)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(167, 47)
        Me.btnNuevaConsulta.TabIndex = 4
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = False
        '
        'gbResultados
        '
        Me.gbResultados.Controls.Add(Me.dgvTotales)
        Me.gbResultados.Location = New System.Drawing.Point(10, 73)
        Me.gbResultados.Name = "gbResultados"
        Me.gbResultados.Size = New System.Drawing.Size(934, 523)
        Me.gbResultados.TabIndex = 2
        Me.gbResultados.TabStop = False
        Me.gbResultados.Text = "Resultados"
        '
        'dgvTotales
        '
        Me.dgvTotales.AllowUserToAddRows = False
        Me.dgvTotales.AllowUserToDeleteRows = False
        Me.dgvTotales.AutoGenerateColumns = False
        Me.dgvTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvTotales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvTotales.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTotales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvTotales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTotales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTotales.ColumnHeadersHeight = 40
        Me.dgvTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagoDataGridViewTextBoxColumn, Me.EdificioPagoDataGridViewTextBoxColumn, Me.DeptoPagoDataGridViewTextBoxColumn, Me.RutResidentePagoDataGridViewTextBoxColumn, Me.MesPagoDataGridViewTextBoxColumn, Me.AnioPagoDataGridViewTextBoxColumn, Me.ValorCuotaDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
        Me.dgvTotales.DataSource = Me.DetallepagoBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotales.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTotales.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTotales.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.dgvTotales.Location = New System.Drawing.Point(23, 28)
        Me.dgvTotales.Name = "dgvTotales"
        Me.dgvTotales.ReadOnly = True
        Me.dgvTotales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvTotales.RowHeadersWidth = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvTotales.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTotales.Size = New System.Drawing.Size(888, 489)
        Me.dgvTotales.TabIndex = 6
        '
        'IdPagoDataGridViewTextBoxColumn
        '
        Me.IdPagoDataGridViewTextBoxColumn.DataPropertyName = "idPago"
        Me.IdPagoDataGridViewTextBoxColumn.HeaderText = "N° Pago"
        Me.IdPagoDataGridViewTextBoxColumn.Name = "IdPagoDataGridViewTextBoxColumn"
        Me.IdPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPagoDataGridViewTextBoxColumn.Width = 97
        '
        'EdificioPagoDataGridViewTextBoxColumn
        '
        Me.EdificioPagoDataGridViewTextBoxColumn.DataPropertyName = "EdificioPago"
        Me.EdificioPagoDataGridViewTextBoxColumn.HeaderText = "Edificio"
        Me.EdificioPagoDataGridViewTextBoxColumn.Name = "EdificioPagoDataGridViewTextBoxColumn"
        Me.EdificioPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EdificioPagoDataGridViewTextBoxColumn.Width = 90
        '
        'DeptoPagoDataGridViewTextBoxColumn
        '
        Me.DeptoPagoDataGridViewTextBoxColumn.DataPropertyName = "DeptoPago"
        Me.DeptoPagoDataGridViewTextBoxColumn.HeaderText = "Dto"
        Me.DeptoPagoDataGridViewTextBoxColumn.Name = "DeptoPagoDataGridViewTextBoxColumn"
        Me.DeptoPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeptoPagoDataGridViewTextBoxColumn.Width = 63
        '
        'RutResidentePagoDataGridViewTextBoxColumn
        '
        Me.RutResidentePagoDataGridViewTextBoxColumn.DataPropertyName = "RutResidentePago"
        Me.RutResidentePagoDataGridViewTextBoxColumn.HeaderText = "Residente"
        Me.RutResidentePagoDataGridViewTextBoxColumn.Name = "RutResidentePagoDataGridViewTextBoxColumn"
        Me.RutResidentePagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutResidentePagoDataGridViewTextBoxColumn.Width = 110
        '
        'MesPagoDataGridViewTextBoxColumn
        '
        Me.MesPagoDataGridViewTextBoxColumn.DataPropertyName = "MesPago"
        Me.MesPagoDataGridViewTextBoxColumn.HeaderText = "Mes Pago"
        Me.MesPagoDataGridViewTextBoxColumn.Name = "MesPagoDataGridViewTextBoxColumn"
        Me.MesPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MesPagoDataGridViewTextBoxColumn.Width = 110
        '
        'AnioPagoDataGridViewTextBoxColumn
        '
        Me.AnioPagoDataGridViewTextBoxColumn.DataPropertyName = "anioPago"
        Me.AnioPagoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AnioPagoDataGridViewTextBoxColumn.Name = "AnioPagoDataGridViewTextBoxColumn"
        Me.AnioPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnioPagoDataGridViewTextBoxColumn.Width = 65
        '
        'ValorCuotaDataGridViewTextBoxColumn
        '
        Me.ValorCuotaDataGridViewTextBoxColumn.DataPropertyName = "valorCuota"
        Me.ValorCuotaDataGridViewTextBoxColumn.HeaderText = "Cuota"
        Me.ValorCuotaDataGridViewTextBoxColumn.Name = "ValorCuotaDataGridViewTextBoxColumn"
        Me.ValorCuotaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorCuotaDataGridViewTextBoxColumn.Width = 80
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago"
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaPagoDataGridViewTextBoxColumn.Width = 122
        '
        'DetallepagoBindingSource
        '
        Me.DetallepagoBindingSource.DataMember = "detalle_pago"
        Me.DetallepagoBindingSource.DataSource = Me.ProvecDataSet
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(802, 604)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(142, 47)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(658, 604)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(142, 47)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistrarPago
        '
        Me.btnRegistrarPago.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrarPago.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarPago.Location = New System.Drawing.Point(510, 604)
        Me.btnRegistrarPago.Name = "btnRegistrarPago"
        Me.btnRegistrarPago.Size = New System.Drawing.Size(142, 47)
        Me.btnRegistrarPago.TabIndex = 7
        Me.btnRegistrarPago.Text = "Registrar Pago"
        Me.btnRegistrarPago.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 616)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Noto Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(67, 604)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(289, 47)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Detalle_pagoTableAdapter
        '
        Me.Detalle_pagoTableAdapter.ClearBeforeFill = True
        '
        'AniosTableAdapter
        '
        Me.AniosTableAdapter.ClearBeforeFill = True
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'TorresTableAdapter
        '
        Me.TorresTableAdapter.ClearBeforeFill = True
        '
        'ResidenteTableAdapter
        '
        Me.ResidenteTableAdapter.ClearBeforeFill = True
        '
        'btnAtrasados
        '
        Me.btnAtrasados.BackColor = System.Drawing.Color.Gray
        Me.btnAtrasados.ForeColor = System.Drawing.Color.White
        Me.btnAtrasados.Location = New System.Drawing.Point(362, 604)
        Me.btnAtrasados.Name = "btnAtrasados"
        Me.btnAtrasados.Size = New System.Drawing.Size(142, 47)
        Me.btnAtrasados.TabIndex = 14
        Me.btnAtrasados.Text = "Atrasados"
        Me.btnAtrasados.UseVisualStyleBackColor = False
        '
        'Totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(954, 661)
        Me.Controls.Add(Me.btnAtrasados)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrarPago)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbResultados)
        Me.Controls.Add(Me.gbBusqueda)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Totales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totales"
        Me.gbBusqueda.ResumeLayout(False)
        Me.gbBusqueda.PerformLayout()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultados.ResumeLayout(False)
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallepagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents btnNuevaConsulta As System.Windows.Forms.Button
    Friend WithEvents gbResultados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTotales As System.Windows.Forms.DataGridView
    Friend WithEvents cmbEdificio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrarPago As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents DetallepagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Detalle_pagoTableAdapter As Sigcom.ProvecDataSetTableAdapters.detalle_pagoTableAdapter
    Friend WithEvents IdPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdificioPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutResidentePagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnioPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorCuotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AniosTableAdapter As Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter
    Friend WithEvents MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesesTableAdapter As Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter
    Friend WithEvents TorresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TorresTableAdapter As Sigcom.ProvecDataSetTableAdapters.torresTableAdapter
    Friend WithEvents ResidenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResidenteTableAdapter As Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter
    Friend WithEvents btnAtrasados As System.Windows.Forms.Button
End Class
