<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Residente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Residente))
        Me.gbRegistrar = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnBuscarRut = New System.Windows.Forms.Button()
        Me.mtbRut = New System.Windows.Forms.MaskedTextBox()
        Me.cmbEdificio = New System.Windows.Forms.ComboBox()
        Me.TorresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbBuscar = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscarED = New System.Windows.Forms.Button()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.ResidenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIrPagos = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ResidenteTableAdapter = New Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter()
        Me.TorresTableAdapter = New Sigcom.ProvecDataSetTableAdapters.torresTableAdapter()
        Me.btnListaResidentes = New System.Windows.Forms.Button()
        Me.btnAtrasados = New System.Windows.Forms.Button()
        Me.btnTotales = New System.Windows.Forms.Button()
        Me.gbRegistrar.SuspendLayout()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbBuscar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRegistrar
        '
        Me.gbRegistrar.Controls.Add(Me.btnRegistrar)
        Me.gbRegistrar.Controls.Add(Me.btnBuscarRut)
        Me.gbRegistrar.Controls.Add(Me.mtbRut)
        Me.gbRegistrar.Controls.Add(Me.cmbEdificio)
        Me.gbRegistrar.Controls.Add(Me.btnModificar)
        Me.gbRegistrar.Controls.Add(Me.txtTelefono)
        Me.gbRegistrar.Controls.Add(Me.txtEmail)
        Me.gbRegistrar.Controls.Add(Me.txtDepto)
        Me.gbRegistrar.Controls.Add(Me.txtApellido)
        Me.gbRegistrar.Controls.Add(Me.txtNombre)
        Me.gbRegistrar.Controls.Add(Me.Label7)
        Me.gbRegistrar.Controls.Add(Me.Label6)
        Me.gbRegistrar.Controls.Add(Me.Label5)
        Me.gbRegistrar.Controls.Add(Me.Label4)
        Me.gbRegistrar.Controls.Add(Me.Label3)
        Me.gbRegistrar.Controls.Add(Me.Label2)
        Me.gbRegistrar.Controls.Add(Me.Label1)
        Me.gbRegistrar.Location = New System.Drawing.Point(22, 41)
        Me.gbRegistrar.Name = "gbRegistrar"
        Me.gbRegistrar.Size = New System.Drawing.Size(359, 363)
        Me.gbRegistrar.TabIndex = 0
        Me.gbRegistrar.TabStop = False
        Me.gbRegistrar.Text = "Registrar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(188, 310)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(142, 47)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnBuscarRut
        '
        Me.btnBuscarRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarRut.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRut.Location = New System.Drawing.Point(198, 31)
        Me.btnBuscarRut.Name = "btnBuscarRut"
        Me.btnBuscarRut.Size = New System.Drawing.Size(132, 47)
        Me.btnBuscarRut.TabIndex = 90
        Me.btnBuscarRut.Text = "Buscar"
        Me.btnBuscarRut.UseVisualStyleBackColor = False
        '
        'mtbRut
        '
        Me.mtbRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtbRut.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.mtbRut.Location = New System.Drawing.Point(89, 43)
        Me.mtbRut.Mask = "##,###,###-A"
        Me.mtbRut.Name = "mtbRut"
        Me.mtbRut.Size = New System.Drawing.Size(103, 29)
        Me.mtbRut.TabIndex = 0
        '
        'cmbEdificio
        '
        Me.cmbEdificio.DataSource = Me.TorresBindingSource
        Me.cmbEdificio.DisplayMember = "nombreTorre"
        Me.cmbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEdificio.FormattingEnabled = True
        Me.cmbEdificio.Location = New System.Drawing.Point(89, 155)
        Me.cmbEdificio.Name = "cmbEdificio"
        Me.cmbEdificio.Size = New System.Drawing.Size(241, 30)
        Me.cmbEdificio.TabIndex = 3
        '
        'TorresBindingSource
        '
        Me.TorresBindingSource.DataMember = "torres"
        Me.TorresBindingSource.DataSource = Me.ProvecDataSet
        '
        'ProvecDataSet
        '
        Me.ProvecDataSet.DataSetName = "ProvecDataSet"
        Me.ProvecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(6, 310)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(138, 43)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTelefono.Location = New System.Drawing.Point(89, 263)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(241, 29)
        Me.txtTelefono.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.Location = New System.Drawing.Point(89, 228)
        Me.txtEmail.MaxLength = 28
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(241, 29)
        Me.txtEmail.TabIndex = 5
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDepto.Location = New System.Drawing.Point(89, 193)
        Me.txtDepto.MaxLength = 4
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.Size = New System.Drawing.Size(241, 29)
        Me.txtDepto.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtApellido.Location = New System.Drawing.Point(89, 117)
        Me.txtApellido.MaxLength = 12
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(241, 29)
        Me.txtApellido.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre.Location = New System.Drawing.Point(89, 82)
        Me.txtNombre.MaxLength = 12
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(241, 29)
        Me.txtNombre.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edificio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Depto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT:"
        '
        'grbBuscar
        '
        Me.grbBuscar.Controls.Add(Me.PictureBox1)
        Me.grbBuscar.Controls.Add(Me.btnBuscarED)
        Me.grbBuscar.Controls.Add(Me.btnNuevaConsulta)
        Me.grbBuscar.Controls.Add(Me.Label8)
        Me.grbBuscar.Controls.Add(Me.cmbRut)
        Me.grbBuscar.Location = New System.Drawing.Point(387, 41)
        Me.grbBuscar.Name = "grbBuscar"
        Me.grbBuscar.Size = New System.Drawing.Size(320, 253)
        Me.grbBuscar.TabIndex = 1
        Me.grbBuscar.TabStop = False
        Me.grbBuscar.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Sigcom.My.Resources.Resources.grande_flecha_318_10423
        Me.PictureBox1.Location = New System.Drawing.Point(6, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarED
        '
        Me.btnBuscarED.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarED.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarED.ForeColor = System.Drawing.Color.White
        Me.btnBuscarED.Location = New System.Drawing.Point(134, 155)
        Me.btnBuscarED.Name = "btnBuscarED"
        Me.btnBuscarED.Size = New System.Drawing.Size(182, 59)
        Me.btnBuscarED.TabIndex = 10
        Me.btnBuscarED.Text = "Buscar Por " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edificio y Depto"
        Me.btnBuscarED.UseVisualStyleBackColor = False
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevaConsulta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(134, 85)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(182, 47)
        Me.btnNuevaConsulta.TabIndex = 9
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 22)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "RUT:"
        '
        'cmbRut
        '
        Me.cmbRut.DataSource = Me.ResidenteBindingSource
        Me.cmbRut.DisplayMember = "rutResidente"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(132, 40)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(182, 30)
        Me.cmbRut.TabIndex = 8
        '
        'ResidenteBindingSource
        '
        Me.ResidenteBindingSource.DataMember = "residente"
        Me.ResidenteBindingSource.DataSource = Me.ProvecDataSet
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(28, 420)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(138, 43)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnIrPagos
        '
        Me.btnIrPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIrPagos.BackColor = System.Drawing.Color.Gray
        Me.btnIrPagos.ForeColor = System.Drawing.Color.White
        Me.btnIrPagos.Location = New System.Drawing.Point(387, 304)
        Me.btnIrPagos.Name = "btnIrPagos"
        Me.btnIrPagos.Size = New System.Drawing.Size(142, 47)
        Me.btnIrPagos.TabIndex = 11
        Me.btnIrPagos.Text = "Ir a Pagos"
        Me.btnIrPagos.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(560, 304)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(143, 47)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(387, 420)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(142, 43)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.Text = "Volver Inicio"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(560, 420)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(143, 43)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ResidenteTableAdapter
        '
        Me.ResidenteTableAdapter.ClearBeforeFill = True
        '
        'TorresTableAdapter
        '
        Me.TorresTableAdapter.ClearBeforeFill = True
        '
        'btnListaResidentes
        '
        Me.btnListaResidentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnListaResidentes.BackColor = System.Drawing.Color.Gray
        Me.btnListaResidentes.ForeColor = System.Drawing.Color.White
        Me.btnListaResidentes.Location = New System.Drawing.Point(560, 361)
        Me.btnListaResidentes.Name = "btnListaResidentes"
        Me.btnListaResidentes.Size = New System.Drawing.Size(143, 43)
        Me.btnListaResidentes.TabIndex = 17
        Me.btnListaResidentes.Text = "Lista Residentes"
        Me.btnListaResidentes.UseVisualStyleBackColor = False
        '
        'btnAtrasados
        '
        Me.btnAtrasados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAtrasados.BackColor = System.Drawing.Color.Gray
        Me.btnAtrasados.ForeColor = System.Drawing.Color.White
        Me.btnAtrasados.Location = New System.Drawing.Point(387, 361)
        Me.btnAtrasados.Name = "btnAtrasados"
        Me.btnAtrasados.Size = New System.Drawing.Size(142, 43)
        Me.btnAtrasados.TabIndex = 18
        Me.btnAtrasados.Text = "Atrasados"
        Me.btnAtrasados.UseVisualStyleBackColor = False
        '
        'btnTotales
        '
        Me.btnTotales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTotales.BackColor = System.Drawing.Color.Gray
        Me.btnTotales.ForeColor = System.Drawing.Color.White
        Me.btnTotales.Location = New System.Drawing.Point(210, 420)
        Me.btnTotales.Name = "btnTotales"
        Me.btnTotales.Size = New System.Drawing.Size(142, 43)
        Me.btnTotales.TabIndex = 19
        Me.btnTotales.Text = "Ir a Totales"
        Me.btnTotales.UseVisualStyleBackColor = False
        '
        'Registrar_Residente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(726, 499)
        Me.Controls.Add(Me.btnTotales)
        Me.Controls.Add(Me.btnAtrasados)
        Me.Controls.Add(Me.btnListaResidentes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnIrPagos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.grbBuscar)
        Me.Controls.Add(Me.gbRegistrar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Registrar_Residente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Residente"
        Me.gbRegistrar.ResumeLayout(False)
        Me.gbRegistrar.PerformLayout()
        CType(Me.TorresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbBuscar.ResumeLayout(False)
        Me.grbBuscar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRegistrar As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEdificio As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDepto As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarRut As System.Windows.Forms.Button
    Friend WithEvents mtbRut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevaConsulta As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarED As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnIrPagos As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents ResidenteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResidenteTableAdapter As Sigcom.ProvecDataSetTableAdapters.residenteTableAdapter
    Friend WithEvents TorresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TorresTableAdapter As Sigcom.ProvecDataSetTableAdapters.torresTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnListaResidentes As System.Windows.Forms.Button
    Friend WithEvents btnAtrasados As System.Windows.Forms.Button
    Friend WithEvents btnTotales As System.Windows.Forms.Button
End Class
