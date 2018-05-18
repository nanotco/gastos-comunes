<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Condominio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Condominio))
        Me.grbCondominio = New System.Windows.Forms.GroupBox()
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.CondominioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mtbRut = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbAnios = New System.Windows.Forms.GroupBox()
        Me.btnGuardarAnio = New System.Windows.Forms.Button()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grbCuotas = New System.Windows.Forms.GroupBox()
        Me.btnGuardarCuota = New System.Windows.Forms.Button()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grbEdificios = New System.Windows.Forms.GroupBox()
        Me.btnGuardarEdificio = New System.Windows.Forms.Button()
        Me.txtEdificio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grbUsuarios = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRegistarUsuario = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grnAdmUsuarios = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbusuario = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.txtConfirmarAdm = New System.Windows.Forms.TextBox()
        Me.btnCambiarClave = New System.Windows.Forms.Button()
        Me.txtClaveAdmn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.CondominioTableAdapter = New Sigcom.ProvecDataSetTableAdapters.condominioTableAdapter()
        Me.UsuariosTableAdapter = New Sigcom.ProvecDataSetTableAdapters.usuariosTableAdapter()
        Me.btnRegistrarPagos = New System.Windows.Forms.Button()
        Me.btnRegistrResidente = New System.Windows.Forms.Button()
        Me.btnTotales = New System.Windows.Forms.Button()
        Me.btnAtrasados = New System.Windows.Forms.Button()
        Me.grbCondominio.SuspendLayout()
        CType(Me.CondominioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAnios.SuspendLayout()
        Me.grbCuotas.SuspendLayout()
        Me.grbEdificios.SuspendLayout()
        Me.grbUsuarios.SuspendLayout()
        Me.grnAdmUsuarios.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCondominio
        '
        Me.grbCondominio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbCondominio.Controls.Add(Me.cmbRut)
        Me.grbCondominio.Controls.Add(Me.btnModificar)
        Me.grbCondominio.Controls.Add(Me.btnRegistrar)
        Me.grbCondominio.Controls.Add(Me.txtEmail)
        Me.grbCondominio.Controls.Add(Me.txttelefono)
        Me.grbCondominio.Controls.Add(Me.txtDireccion)
        Me.grbCondominio.Controls.Add(Me.txtNombre)
        Me.grbCondominio.Controls.Add(Me.mtbRut)
        Me.grbCondominio.Controls.Add(Me.Label5)
        Me.grbCondominio.Controls.Add(Me.Label4)
        Me.grbCondominio.Controls.Add(Me.Label3)
        Me.grbCondominio.Controls.Add(Me.Label2)
        Me.grbCondominio.Controls.Add(Me.Label1)
        Me.grbCondominio.Location = New System.Drawing.Point(12, 3)
        Me.grbCondominio.Name = "grbCondominio"
        Me.grbCondominio.Size = New System.Drawing.Size(463, 289)
        Me.grbCondominio.TabIndex = 10
        Me.grbCondominio.TabStop = False
        Me.grbCondominio.Text = "Datos del Condominio"
        '
        'cmbRut
        '
        Me.cmbRut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbRut.DataSource = Me.CondominioBindingSource
        Me.cmbRut.DisplayMember = "rut"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.ForeColor = System.Drawing.Color.Black
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(290, 38)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(167, 30)
        Me.cmbRut.TabIndex = 6
        '
        'CondominioBindingSource
        '
        Me.CondominioBindingSource.DataMember = "condominio"
        Me.CondominioBindingSource.DataSource = Me.ProvecDataSet
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
        Me.btnModificar.Location = New System.Drawing.Point(94, 233)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(167, 47)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(290, 233)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistrar.TabIndex = 5
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEmail.Location = New System.Drawing.Point(94, 188)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(363, 29)
        Me.txtEmail.TabIndex = 4
        '
        'txttelefono
        '
        Me.txttelefono.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttelefono.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txttelefono.Location = New System.Drawing.Point(94, 153)
        Me.txttelefono.MaxLength = 12
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(363, 29)
        Me.txttelefono.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDireccion.Location = New System.Drawing.Point(94, 118)
        Me.txtDireccion.MaxLength = 40
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(363, 29)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre.Location = New System.Drawing.Point(94, 78)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(363, 29)
        Me.txtNombre.TabIndex = 1
        '
        'mtbRut
        '
        Me.mtbRut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtbRut.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mtbRut.Location = New System.Drawing.Point(94, 39)
        Me.mtbRut.Mask = "##,###,###-A"
        Me.mtbRut.Name = "mtbRut"
        Me.mtbRut.Size = New System.Drawing.Size(112, 29)
        Me.mtbRut.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT:"
        '
        'grbAnios
        '
        Me.grbAnios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbAnios.Controls.Add(Me.btnGuardarAnio)
        Me.grbAnios.Controls.Add(Me.txtAnio)
        Me.grbAnios.Controls.Add(Me.Label8)
        Me.grbAnios.Location = New System.Drawing.Point(557, 172)
        Me.grbAnios.Name = "grbAnios"
        Me.grbAnios.Size = New System.Drawing.Size(442, 120)
        Me.grbAnios.TabIndex = 16
        Me.grbAnios.TabStop = False
        Me.grbAnios.Text = "Años"
        '
        'btnGuardarAnio
        '
        Me.btnGuardarAnio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardarAnio.ForeColor = System.Drawing.Color.White
        Me.btnGuardarAnio.Location = New System.Drawing.Point(258, 42)
        Me.btnGuardarAnio.Name = "btnGuardarAnio"
        Me.btnGuardarAnio.Size = New System.Drawing.Size(167, 47)
        Me.btnGuardarAnio.TabIndex = 11
        Me.btnGuardarAnio.Text = "Guardar"
        Me.btnGuardarAnio.UseVisualStyleBackColor = False
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAnio.Location = New System.Drawing.Point(131, 51)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(121, 29)
        Me.txtAnio.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nuevo Año:"
        '
        'grbCuotas
        '
        Me.grbCuotas.Controls.Add(Me.btnGuardarCuota)
        Me.grbCuotas.Controls.Add(Me.txtCuota)
        Me.grbCuotas.Controls.Add(Me.Label6)
        Me.grbCuotas.Location = New System.Drawing.Point(557, 298)
        Me.grbCuotas.Name = "grbCuotas"
        Me.grbCuotas.Size = New System.Drawing.Size(443, 120)
        Me.grbCuotas.TabIndex = 17
        Me.grbCuotas.TabStop = False
        Me.grbCuotas.Text = "Valor de la Cuota"
        '
        'btnGuardarCuota
        '
        Me.btnGuardarCuota.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarCuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardarCuota.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCuota.Location = New System.Drawing.Point(259, 46)
        Me.btnGuardarCuota.Name = "btnGuardarCuota"
        Me.btnGuardarCuota.Size = New System.Drawing.Size(167, 47)
        Me.btnGuardarCuota.TabIndex = 13
        Me.btnGuardarCuota.Text = "Guardar"
        Me.btnGuardarCuota.UseVisualStyleBackColor = False
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCuota.Location = New System.Drawing.Point(132, 55)
        Me.txtCuota.MaxLength = 6
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(121, 29)
        Me.txtCuota.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nueva Cuota:"
        '
        'grbEdificios
        '
        Me.grbEdificios.Controls.Add(Me.btnGuardarEdificio)
        Me.grbEdificios.Controls.Add(Me.txtEdificio)
        Me.grbEdificios.Controls.Add(Me.Label7)
        Me.grbEdificios.Location = New System.Drawing.Point(12, 298)
        Me.grbEdificios.Name = "grbEdificios"
        Me.grbEdificios.Size = New System.Drawing.Size(463, 120)
        Me.grbEdificios.TabIndex = 18
        Me.grbEdificios.TabStop = False
        Me.grbEdificios.Text = "Edificios"
        '
        'btnGuardarEdificio
        '
        Me.btnGuardarEdificio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarEdificio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardarEdificio.ForeColor = System.Drawing.Color.White
        Me.btnGuardarEdificio.Location = New System.Drawing.Point(290, 39)
        Me.btnGuardarEdificio.Name = "btnGuardarEdificio"
        Me.btnGuardarEdificio.Size = New System.Drawing.Size(167, 47)
        Me.btnGuardarEdificio.TabIndex = 9
        Me.btnGuardarEdificio.Text = "Guardar"
        Me.btnGuardarEdificio.UseVisualStyleBackColor = False
        '
        'txtEdificio
        '
        Me.txtEdificio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEdificio.Location = New System.Drawing.Point(130, 46)
        Me.txtEdificio.MaxLength = 10
        Me.txtEdificio.Name = "txtEdificio"
        Me.txtEdificio.Size = New System.Drawing.Size(154, 29)
        Me.txtEdificio.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nuevo Edificio:"
        '
        'grbUsuarios
        '
        Me.grbUsuarios.Controls.Add(Me.Label11)
        Me.grbUsuarios.Controls.Add(Me.txtConfirmar)
        Me.grbUsuarios.Controls.Add(Me.txtClave)
        Me.grbUsuarios.Controls.Add(Me.Label10)
        Me.grbUsuarios.Controls.Add(Me.btnRegistarUsuario)
        Me.grbUsuarios.Controls.Add(Me.txtUsuario)
        Me.grbUsuarios.Controls.Add(Me.Label9)
        Me.grbUsuarios.Location = New System.Drawing.Point(12, 437)
        Me.grbUsuarios.Name = "grbUsuarios"
        Me.grbUsuarios.Size = New System.Drawing.Size(463, 157)
        Me.grbUsuarios.TabIndex = 19
        Me.grbUsuarios.TabStop = False
        Me.grbUsuarios.Text = "Usuarios del Programa"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Confirmar:"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConfirmar.Location = New System.Drawing.Point(104, 110)
        Me.txtConfirmar.MaxLength = 10
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmar.Size = New System.Drawing.Size(141, 29)
        Me.txtConfirmar.TabIndex = 16
        '
        'txtClave
        '
        Me.txtClave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClave.Location = New System.Drawing.Point(104, 74)
        Me.txtClave.MaxLength = 10
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(141, 29)
        Me.txtClave.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Clave:"
        '
        'btnRegistarUsuario
        '
        Me.btnRegistarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnRegistarUsuario.Location = New System.Drawing.Point(290, 65)
        Me.btnRegistarUsuario.Name = "btnRegistarUsuario"
        Me.btnRegistarUsuario.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistarUsuario.TabIndex = 17
        Me.btnRegistarUsuario.Text = "Registrar"
        Me.btnRegistarUsuario.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.Location = New System.Drawing.Point(104, 37)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(141, 29)
        Me.txtUsuario.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Usuario:"
        '
        'grnAdmUsuarios
        '
        Me.grnAdmUsuarios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grnAdmUsuarios.Controls.Add(Me.Label14)
        Me.grnAdmUsuarios.Controls.Add(Me.cmbusuario)
        Me.grnAdmUsuarios.Controls.Add(Me.Label12)
        Me.grnAdmUsuarios.Controls.Add(Me.btnEliminarUsuario)
        Me.grnAdmUsuarios.Controls.Add(Me.txtConfirmarAdm)
        Me.grnAdmUsuarios.Controls.Add(Me.btnCambiarClave)
        Me.grnAdmUsuarios.Controls.Add(Me.txtClaveAdmn)
        Me.grnAdmUsuarios.Controls.Add(Me.Label13)
        Me.grnAdmUsuarios.Location = New System.Drawing.Point(557, 437)
        Me.grnAdmUsuarios.Name = "grnAdmUsuarios"
        Me.grnAdmUsuarios.Size = New System.Drawing.Size(443, 157)
        Me.grnAdmUsuarios.TabIndex = 20
        Me.grnAdmUsuarios.TabStop = False
        Me.grnAdmUsuarios.Text = "Administrar Usuarios del Programa"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 22)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Usuario:"
        '
        'cmbusuario
        '
        Me.cmbusuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbusuario.DataSource = Me.UsuariosBindingSource
        Me.cmbusuario.DisplayMember = "usuario"
        Me.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusuario.ForeColor = System.Drawing.Color.Black
        Me.cmbusuario.FormattingEnabled = True
        Me.cmbusuario.Location = New System.Drawing.Point(111, 32)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(141, 30)
        Me.cmbusuario.TabIndex = 18
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ProvecDataSet
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Confirmar:"
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(258, 92)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(167, 47)
        Me.btnEliminarUsuario.TabIndex = 22
        Me.btnEliminarUsuario.Text = "Eliminar"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = False
        '
        'txtConfirmarAdm
        '
        Me.txtConfirmarAdm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtConfirmarAdm.Location = New System.Drawing.Point(111, 106)
        Me.txtConfirmarAdm.MaxLength = 10
        Me.txtConfirmarAdm.Name = "txtConfirmarAdm"
        Me.txtConfirmarAdm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarAdm.Size = New System.Drawing.Size(141, 29)
        Me.txtConfirmarAdm.TabIndex = 20
        '
        'btnCambiarClave
        '
        Me.btnCambiarClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCambiarClave.ForeColor = System.Drawing.Color.White
        Me.btnCambiarClave.Location = New System.Drawing.Point(258, 28)
        Me.btnCambiarClave.Name = "btnCambiarClave"
        Me.btnCambiarClave.Size = New System.Drawing.Size(167, 47)
        Me.btnCambiarClave.TabIndex = 21
        Me.btnCambiarClave.Text = "Cambiar Clave"
        Me.btnCambiarClave.UseVisualStyleBackColor = False
        '
        'txtClaveAdmn
        '
        Me.txtClaveAdmn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtClaveAdmn.Location = New System.Drawing.Point(111, 71)
        Me.txtClaveAdmn.MaxLength = 10
        Me.txtClaveAdmn.Name = "txtClaveAdmn"
        Me.txtClaveAdmn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAdmn.Size = New System.Drawing.Size(141, 29)
        Me.txtClaveAdmn.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 22)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Clave:"
        '
        'calendar
        '
        Me.calendar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.calendar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.calendar.Location = New System.Drawing.Point(668, 3)
        Me.calendar.Name = "calendar"
        Me.calendar.ShowWeekNumbers = True
        Me.calendar.TabIndex = 21
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Gray
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(844, 602)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(155, 47)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(681, 602)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(155, 47)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'CondominioTableAdapter
        '
        Me.CondominioTableAdapter.ClearBeforeFill = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'btnRegistrarPagos
        '
        Me.btnRegistrarPagos.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrarPagos.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarPagos.Location = New System.Drawing.Point(520, 602)
        Me.btnRegistrarPagos.Name = "btnRegistrarPagos"
        Me.btnRegistrarPagos.Size = New System.Drawing.Size(155, 47)
        Me.btnRegistrarPagos.TabIndex = 25
        Me.btnRegistrarPagos.Text = "Registrar Pago"
        Me.btnRegistrarPagos.UseVisualStyleBackColor = False
        '
        'btnRegistrResidente
        '
        Me.btnRegistrResidente.BackColor = System.Drawing.Color.Gray
        Me.btnRegistrResidente.ForeColor = System.Drawing.Color.White
        Me.btnRegistrResidente.Location = New System.Drawing.Point(347, 602)
        Me.btnRegistrResidente.Name = "btnRegistrResidente"
        Me.btnRegistrResidente.Size = New System.Drawing.Size(167, 47)
        Me.btnRegistrResidente.TabIndex = 26
        Me.btnRegistrResidente.Text = "Registrar Residente"
        Me.btnRegistrResidente.UseVisualStyleBackColor = False
        '
        'btnTotales
        '
        Me.btnTotales.BackColor = System.Drawing.Color.Gray
        Me.btnTotales.ForeColor = System.Drawing.Color.White
        Me.btnTotales.Location = New System.Drawing.Point(12, 602)
        Me.btnTotales.Name = "btnTotales"
        Me.btnTotales.Size = New System.Drawing.Size(155, 47)
        Me.btnTotales.TabIndex = 27
        Me.btnTotales.Text = "Totales"
        Me.btnTotales.UseVisualStyleBackColor = False
        '
        'btnAtrasados
        '
        Me.btnAtrasados.BackColor = System.Drawing.Color.Gray
        Me.btnAtrasados.ForeColor = System.Drawing.Color.White
        Me.btnAtrasados.Location = New System.Drawing.Point(173, 602)
        Me.btnAtrasados.Name = "btnAtrasados"
        Me.btnAtrasados.Size = New System.Drawing.Size(168, 47)
        Me.btnAtrasados.TabIndex = 28
        Me.btnAtrasados.Text = "Atrasados"
        Me.btnAtrasados.UseVisualStyleBackColor = False
        '
        'Condominio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1030, 661)
        Me.Controls.Add(Me.btnAtrasados)
        Me.Controls.Add(Me.btnTotales)
        Me.Controls.Add(Me.btnRegistrResidente)
        Me.Controls.Add(Me.btnRegistrarPagos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.grnAdmUsuarios)
        Me.Controls.Add(Me.grbUsuarios)
        Me.Controls.Add(Me.grbEdificios)
        Me.Controls.Add(Me.grbCuotas)
        Me.Controls.Add(Me.grbAnios)
        Me.Controls.Add(Me.grbCondominio)
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Condominio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condominio"
        Me.grbCondominio.ResumeLayout(False)
        Me.grbCondominio.PerformLayout()
        CType(Me.CondominioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAnios.ResumeLayout(False)
        Me.grbAnios.PerformLayout()
        Me.grbCuotas.ResumeLayout(False)
        Me.grbCuotas.PerformLayout()
        Me.grbEdificios.ResumeLayout(False)
        Me.grbEdificios.PerformLayout()
        Me.grbUsuarios.ResumeLayout(False)
        Me.grbUsuarios.PerformLayout()
        Me.grnAdmUsuarios.ResumeLayout(False)
        Me.grnAdmUsuarios.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbCondominio As System.Windows.Forms.GroupBox
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents mtbRut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grbAnios As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarAnio As System.Windows.Forms.Button
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grbCuotas As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarCuota As System.Windows.Forms.Button
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grbEdificios As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardarEdificio As System.Windows.Forms.Button
    Friend WithEvents txtEdificio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRegistarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents grnAdmUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents txtConfirmarAdm As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarClave As System.Windows.Forms.Button
    Friend WithEvents txtClaveAdmn As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents calendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents CondominioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CondominioTableAdapter As Sigcom.ProvecDataSetTableAdapters.condominioTableAdapter
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As Sigcom.ProvecDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents btnRegistrarPagos As System.Windows.Forms.Button
    Friend WithEvents btnRegistrResidente As System.Windows.Forms.Button
    Friend WithEvents btnTotales As System.Windows.Forms.Button
    Friend WithEvents btnAtrasados As System.Windows.Forms.Button
End Class
