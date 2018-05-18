<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarPagos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnConsultarPago = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbCuota = New System.Windows.Forms.ComboBox()
        Me.CuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.AniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtbRut = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscarRut = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscarED = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscarDepto = New System.Windows.Forms.TextBox()
        Me.cmbEdificio = New System.Windows.Forms.ComboBox()
        Me.TorresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.ResidenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnResidentes = New System.Windows.Forms.Button()
        Me.ResidenteTableAdapter = New Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter()
        Me.TorresTableAdapter = New Sigcom.ProvecDataSetTableAdapters.torresTableAdapter()
        Me.MesesTableAdapter = New Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter()
        Me.AniosTableAdapter = New Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter()
        Me.CuotaTableAdapter = New Sigcom.ProvecDataSetTableAdapters.cuotaTableAdapter()
        Me.btnAtrasados = New System.Windows.Forms.Button()
        Me.btnTotales = New System.Windows.Forms.Button()
        Me.btnListaResidentes = New System.Windows.Forms.Button()
        Me.lblRut = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.TextBox()
        Me.lblEdificio = New System.Windows.Forms.TextBox()
        Me.lblDepto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDepto)
        Me.GroupBox1.Controls.Add(Me.lblEdificio)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblRut)
        Me.GroupBox1.Controls.Add(Me.btnConsultarPago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.cmbCuota)
        Me.GroupBox1.Controls.Add(Me.cmbAnio)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Pago"
        '
        'btnConsultarPago
        '
        Me.btnConsultarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnConsultarPago.ForeColor = System.Drawing.Color.White
        Me.btnConsultarPago.Location = New System.Drawing.Point(148, 359)
        Me.btnConsultarPago.Name = "btnConsultarPago"
        Me.btnConsultarPago.Size = New System.Drawing.Size(142, 47)
        Me.btnConsultarPago.TabIndex = 7
        Me.btnConsultarPago.Text = "Consultar Pago"
        Me.btnConsultarPago.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Depto:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(0, 359)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(142, 47)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(102, 321)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(187, 29)
        Me.dtpFecha.TabIndex = 13
        Me.dtpFecha.Value = New Date(2014, 8, 17, 0, 0, 0, 0)
        '
        'cmbCuota
        '
        Me.cmbCuota.DataSource = Me.CuotaBindingSource
        Me.cmbCuota.DisplayMember = "valorCuota"
        Me.cmbCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuota.FormattingEnabled = True
        Me.cmbCuota.Location = New System.Drawing.Point(102, 287)
        Me.cmbCuota.Name = "cmbCuota"
        Me.cmbCuota.Size = New System.Drawing.Size(187, 30)
        Me.cmbCuota.TabIndex = 6
        '
        'CuotaBindingSource
        '
        Me.CuotaBindingSource.DataMember = "cuota"
        Me.CuotaBindingSource.DataSource = Me.ProvecDataSet
        '
        'ProvecDataSet
        '
        Me.ProvecDataSet.DataSetName = "ProvecDataSet"
        Me.ProvecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbAnio
        '
        Me.cmbAnio.DataSource = Me.AniosBindingSource
        Me.cmbAnio.DisplayMember = "anio"
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(102, 251)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(187, 30)
        Me.cmbAnio.TabIndex = 5
        '
        'AniosBindingSource
        '
        Me.AniosBindingSource.DataMember = "anios"
        Me.AniosBindingSource.DataSource = Me.ProvecDataSet
        '
        'cmbMes
        '
        Me.cmbMes.DataSource = Me.MesesBindingSource
        Me.cmbMes.DisplayMember = "meses"
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(102, 215)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(187, 30)
        Me.cmbMes.TabIndex = 4
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "meses"
        Me.MesesBindingSource.DataSource = Me.ProvecDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Apellido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Edificio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT:"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(22, 430)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(142, 47)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(169, 430)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(142, 47)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(551, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(142, 47)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(362, 430)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(142, 47)
        Me.btnVolver.TabIndex = 13
        Me.btnVolver.Text = "Volver Inicio"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtbRut)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnBuscarRut)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnBuscarED)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBuscarDepto)
        Me.GroupBox2.Controls.Add(Me.cmbEdificio)
        Me.GroupBox2.Controls.Add(Me.cmbRut)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 297)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Búsqueda Residente"
        '
        'mtbRut
        '
        Me.mtbRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtbRut.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtbRut.Location = New System.Drawing.Point(217, 209)
        Me.mtbRut.Mask = "##,###,###-A"
        Me.mtbRut.Name = "mtbRut"
        Me.mtbRut.Size = New System.Drawing.Size(142, 29)
        Me.mtbRut.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(173, 22)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Pegue o Ingrese RUT:"
        '
        'btnBuscarRut
        '
        Me.btnBuscarRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRut.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRut.Location = New System.Drawing.Point(217, 244)
        Me.btnBuscarRut.Name = "btnBuscarRut"
        Me.btnBuscarRut.Size = New System.Drawing.Size(142, 47)
        Me.btnBuscarRut.TabIndex = 10
        Me.btnBuscarRut.Text = "Buscar por RUT"
        Me.btnBuscarRut.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(28, 244)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(142, 47)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnBuscarED
        '
        Me.btnBuscarED.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarED.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarED.ForeColor = System.Drawing.Color.White
        Me.btnBuscarED.Location = New System.Drawing.Point(156, 142)
        Me.btnBuscarED.Name = "btnBuscarED"
        Me.btnBuscarED.Size = New System.Drawing.Size(203, 61)
        Me.btnBuscarED.TabIndex = 3
        Me.btnBuscarED.Text = "Buscar por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edificio y Depto"
        Me.btnBuscarED.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 22)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Depto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 22)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Edificio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "RUT:"
        '
        'txtBuscarDepto
        '
        Me.txtBuscarDepto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtBuscarDepto.Location = New System.Drawing.Point(156, 108)
        Me.txtBuscarDepto.Name = "txtBuscarDepto"
        Me.txtBuscarDepto.Size = New System.Drawing.Size(203, 29)
        Me.txtBuscarDepto.TabIndex = 2
        '
        'cmbEdificio
        '
        Me.cmbEdificio.DataSource = Me.TorresBindingSource
        Me.cmbEdificio.DisplayMember = "nombreTorre"
        Me.cmbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEdificio.FormattingEnabled = True
        Me.cmbEdificio.Location = New System.Drawing.Point(156, 69)
        Me.cmbEdificio.Name = "cmbEdificio"
        Me.cmbEdificio.Size = New System.Drawing.Size(203, 30)
        Me.cmbEdificio.TabIndex = 1
        '
        'TorresBindingSource
        '
        Me.TorresBindingSource.DataMember = "torres"
        Me.TorresBindingSource.DataSource = Me.ProvecDataSet
        '
        'cmbRut
        '
        Me.cmbRut.DataSource = Me.ResidenteBindingSource
        Me.cmbRut.DisplayMember = "rutResidente"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(156, 28)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(203, 30)
        Me.cmbRut.TabIndex = 0
        '
        'ResidenteBindingSource
        '
        Me.ResidenteBindingSource.DataMember = "residente"
        Me.ResidenteBindingSource.DataSource = Me.ProvecDataSet
        '
        'btnResidentes
        '
        Me.btnResidentes.BackColor = System.Drawing.Color.Gray
        Me.btnResidentes.ForeColor = System.Drawing.Color.White
        Me.btnResidentes.Location = New System.Drawing.Point(362, 315)
        Me.btnResidentes.Name = "btnResidentes"
        Me.btnResidentes.Size = New System.Drawing.Size(142, 47)
        Me.btnResidentes.TabIndex = 12
        Me.btnResidentes.Text = "Reg. Residentes"
        Me.btnResidentes.UseVisualStyleBackColor = False
        '
        'ResidenteTableAdapter
        '
        Me.ResidenteTableAdapter.ClearBeforeFill = True
        '
        'TorresTableAdapter
        '
        Me.TorresTableAdapter.ClearBeforeFill = True
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'AniosTableAdapter
        '
        Me.AniosTableAdapter.ClearBeforeFill = True
        '
        'CuotaTableAdapter
        '
        Me.CuotaTableAdapter.ClearBeforeFill = True
        '
        'btnAtrasados
        '
        Me.btnAtrasados.BackColor = System.Drawing.Color.Gray
        Me.btnAtrasados.ForeColor = System.Drawing.Color.White
        Me.btnAtrasados.Location = New System.Drawing.Point(551, 371)
        Me.btnAtrasados.Name = "btnAtrasados"
        Me.btnAtrasados.Size = New System.Drawing.Size(142, 47)
        Me.btnAtrasados.TabIndex = 24
        Me.btnAtrasados.Text = "Ir Atrasados"
        Me.btnAtrasados.UseVisualStyleBackColor = False
        '
        'btnTotales
        '
        Me.btnTotales.BackColor = System.Drawing.Color.Gray
        Me.btnTotales.ForeColor = System.Drawing.Color.White
        Me.btnTotales.Location = New System.Drawing.Point(362, 368)
        Me.btnTotales.Name = "btnTotales"
        Me.btnTotales.Size = New System.Drawing.Size(142, 47)
        Me.btnTotales.TabIndex = 25
        Me.btnTotales.Text = "Ir a Totales"
        Me.btnTotales.UseVisualStyleBackColor = False
        '
        'btnListaResidentes
        '
        Me.btnListaResidentes.BackColor = System.Drawing.Color.Gray
        Me.btnListaResidentes.ForeColor = System.Drawing.Color.White
        Me.btnListaResidentes.Location = New System.Drawing.Point(551, 318)
        Me.btnListaResidentes.Name = "btnListaResidentes"
        Me.btnListaResidentes.Size = New System.Drawing.Size(142, 47)
        Me.btnListaResidentes.TabIndex = 26
        Me.btnListaResidentes.Text = "Lista Residentes"
        Me.btnListaResidentes.UseVisualStyleBackColor = False
        '
        'lblRut
        '
        Me.lblRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRut.Enabled = False
        Me.lblRut.Location = New System.Drawing.Point(102, 38)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(187, 29)
        Me.lblRut.TabIndex = 26
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombre.Enabled = False
        Me.lblNombre.Location = New System.Drawing.Point(102, 74)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(187, 29)
        Me.lblNombre.TabIndex = 31
        '
        'lblApellido
        '
        Me.lblApellido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblApellido.Enabled = False
        Me.lblApellido.Location = New System.Drawing.Point(102, 109)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(187, 29)
        Me.lblApellido.TabIndex = 32
        '
        'lblEdificio
        '
        Me.lblEdificio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEdificio.Enabled = False
        Me.lblEdificio.Location = New System.Drawing.Point(102, 144)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(187, 29)
        Me.lblEdificio.TabIndex = 33
        '
        'lblDepto
        '
        Me.lblDepto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDepto.Enabled = False
        Me.lblDepto.Location = New System.Drawing.Point(102, 179)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(187, 29)
        Me.lblDepto.TabIndex = 34
        '
        'RegistrarPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(730, 503)
        Me.Controls.Add(Me.btnListaResidentes)
        Me.Controls.Add(Me.btnTotales)
        Me.Controls.Add(Me.btnAtrasados)
        Me.Controls.Add(Me.btnResidentes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "RegistrarPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCuota As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBuscarDepto As System.Windows.Forms.TextBox
    Friend WithEvents cmbEdificio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarED As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRut As System.Windows.Forms.Button
    Friend WithEvents btnResidentes As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnConsultarPago As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents ResidenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResidenteTableAdapter As Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter
    Friend WithEvents TorresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TorresTableAdapter As Sigcom.ProvecDataSetTableAdapters.torresTableAdapter
    Friend WithEvents MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesesTableAdapter As Sigcom.ProvecDataSetTableAdapters.mesesTableAdapter
    Friend WithEvents AniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AniosTableAdapter As Sigcom.ProvecDataSetTableAdapters.aniosTableAdapter
    Friend WithEvents CuotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CuotaTableAdapter As Sigcom.ProvecDataSetTableAdapters.cuotaTableAdapter
    Friend WithEvents btnAtrasados As System.Windows.Forms.Button
    Friend WithEvents btnTotales As System.Windows.Forms.Button
    Friend WithEvents btnListaResidentes As System.Windows.Forms.Button
    Friend WithEvents mtbRut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDepto As System.Windows.Forms.TextBox
    Friend WithEvents lblEdificio As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblRut As System.Windows.Forms.TextBox
End Class
