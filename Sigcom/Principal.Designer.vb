<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResidentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosComunesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbDatosCondominio = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.CondominioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvecDataSet = New Sigcom.ProvecDataSet()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.grbAcercade = New System.Windows.Forms.GroupBox()
        Me.TextBoxDescription = New System.Windows.Forms.Label()
        Me.LabelCompanyName = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.CondominioTableAdapter = New Sigcom.ProvecDataSetTableAdapters.condominioTableAdapter()
        Me.MenuStrip.SuspendLayout()
        Me.grbDatosCondominio.SuspendLayout()
        CType(Me.CondominioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAcercade.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.CondominioToolStripMenuItem, Me.ResidentesToolStripMenuItem, Me.GastosComunesToolStripMenuItem, Me.HelpMenu, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(984, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.BackColor = System.Drawing.Color.Transparent
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(62, 21)
        Me.FileMenu.Text = "&Archivo"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.InicioToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(150, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'CondominioToolStripMenuItem
        '
        Me.CondominioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem})
        Me.CondominioToolStripMenuItem.Name = "CondominioToolStripMenuItem"
        Me.CondominioToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.CondominioToolStripMenuItem.Text = "Condominio"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.InformaciónToolStripMenuItem.Text = "Administrar Datos "
        '
        'ResidentesToolStripMenuItem
        '
        Me.ResidentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoToolStripMenuItem1, Me.ListadoToolStripMenuItem, Me.RegistrarToolStripMenuItem})
        Me.ResidentesToolStripMenuItem.Name = "ResidentesToolStripMenuItem"
        Me.ResidentesToolStripMenuItem.Size = New System.Drawing.Size(81, 21)
        Me.ResidentesToolStripMenuItem.Text = "Residentes"
        '
        'ListadoToolStripMenuItem1
        '
        Me.ListadoToolStripMenuItem1.Name = "ListadoToolStripMenuItem1"
        Me.ListadoToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ListadoToolStripMenuItem1.Text = "Atrasados"
        '
        'ListadoToolStripMenuItem
        '
        Me.ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        Me.ListadoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ListadoToolStripMenuItem.Text = "Listado"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'GastosComunesToolStripMenuItem
        '
        Me.GastosComunesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem1, Me.TotalesToolStripMenuItem})
        Me.GastosComunesToolStripMenuItem.Name = "GastosComunesToolStripMenuItem"
        Me.GastosComunesToolStripMenuItem.Size = New System.Drawing.Size(115, 21)
        Me.GastosComunesToolStripMenuItem.Text = "Gastos Comunes"
        '
        'RegistrarToolStripMenuItem1
        '
        Me.RegistrarToolStripMenuItem1.Name = "RegistrarToolStripMenuItem1"
        Me.RegistrarToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.RegistrarToolStripMenuItem1.Text = "Registrar"
        '
        'TotalesToolStripMenuItem
        '
        Me.TotalesToolStripMenuItem.Name = "TotalesToolStripMenuItem"
        Me.TotalesToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TotalesToolStripMenuItem.Text = "Totales"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(55, 21)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(138, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'grbDatosCondominio
        '
        Me.grbDatosCondominio.AutoSize = True
        Me.grbDatosCondominio.Controls.Add(Me.lblNombre)
        Me.grbDatosCondominio.Controls.Add(Me.lblDireccion)
        Me.grbDatosCondominio.Controls.Add(Me.lblEmail)
        Me.grbDatosCondominio.Controls.Add(Me.lblTelefono)
        Me.grbDatosCondominio.Controls.Add(Me.lblRut)
        Me.grbDatosCondominio.Controls.Add(Me.Label13)
        Me.grbDatosCondominio.Controls.Add(Me.Label12)
        Me.grbDatosCondominio.Controls.Add(Me.Label5)
        Me.grbDatosCondominio.Controls.Add(Me.Label4)
        Me.grbDatosCondominio.Controls.Add(Me.Label3)
        Me.grbDatosCondominio.Controls.Add(Me.Label2)
        Me.grbDatosCondominio.Controls.Add(Me.Label1)
        Me.grbDatosCondominio.Location = New System.Drawing.Point(134, 49)
        Me.grbDatosCondominio.Name = "grbDatosCondominio"
        Me.grbDatosCondominio.Size = New System.Drawing.Size(685, 304)
        Me.grbDatosCondominio.TabIndex = 9
        Me.grbDatosCondominio.TabStop = False
        Me.grbDatosCondominio.Text = "Datos del Condominio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(123, 104)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 22)
        Me.lblNombre.TabIndex = 17
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.ForeColor = System.Drawing.Color.Black
        Me.lblDireccion.Location = New System.Drawing.Point(123, 151)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(0, 22)
        Me.lblDireccion.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(123, 238)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 22)
        Me.lblEmail.TabIndex = 15
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.ForeColor = System.Drawing.Color.Black
        Me.lblTelefono.Location = New System.Drawing.Point(123, 195)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(0, 22)
        Me.lblTelefono.TabIndex = 14
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.ForeColor = System.Drawing.Color.Black
        Me.lblRut.Location = New System.Drawing.Point(123, 57)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(0, 22)
        Me.lblRut.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(342, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 22)
        Me.Label13.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(117, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 22)
        Me.Label12.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT:"
        '
        'cmbRut
        '
        Me.cmbRut.DataSource = Me.CondominioBindingSource
        Me.cmbRut.DisplayMember = "rut"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(825, 182)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(177, 30)
        Me.cmbRut.TabIndex = 10
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
        'MonthCalendar1
        '
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar1.Location = New System.Drawing.Point(825, 106)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'grbAcercade
        '
        Me.grbAcercade.Controls.Add(Me.TextBoxDescription)
        Me.grbAcercade.Controls.Add(Me.LabelCompanyName)
        Me.grbAcercade.Controls.Add(Me.LabelCopyright)
        Me.grbAcercade.Controls.Add(Me.LabelVersion)
        Me.grbAcercade.Controls.Add(Me.LabelProductName)
        Me.grbAcercade.Location = New System.Drawing.Point(132, 378)
        Me.grbAcercade.Name = "grbAcercade"
        Me.grbAcercade.Size = New System.Drawing.Size(926, 249)
        Me.grbAcercade.TabIndex = 11
        Me.grbAcercade.TabStop = False
        Me.grbAcercade.Text = "Acerca del Programa"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.AutoSize = True
        Me.TextBoxDescription.Location = New System.Drawing.Point(41, 198)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxDescription.TabIndex = 5
        Me.TextBoxDescription.Text = "Descripción"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.AutoSize = True
        Me.LabelCompanyName.Location = New System.Drawing.Point(41, 157)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(87, 22)
        Me.LabelCompanyName.TabIndex = 4
        Me.LabelCompanyName.Text = "Compañía"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Location = New System.Drawing.Point(41, 114)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(85, 22)
        Me.LabelCopyright.TabIndex = 3
        Me.LabelCopyright.Text = "Copyright"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(41, 80)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(68, 22)
        Me.LabelVersion.TabIndex = 2
        Me.LabelVersion.Text = "Versión"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Location = New System.Drawing.Point(41, 41)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(73, 22)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nombre"
        '
        'CondominioTableAdapter
        '
        Me.CondominioTableAdapter.ClearBeforeFill = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Sigcom.My.Resources.Resources.images
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.grbAcercade)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.grbDatosCondominio)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.cmbRut)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gastos Comunes"
        Me.TransparencyKey = System.Drawing.Color.Teal
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.grbDatosCondominio.ResumeLayout(False)
        Me.grbDatosCondominio.PerformLayout()
        CType(Me.CondominioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAcercade.ResumeLayout(False)
        Me.grbAcercade.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ResidentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosComunesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CondominioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grbDatosCondominio As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents grbAcercade As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents ProvecDataSet As Sigcom.ProvecDataSet
    Friend WithEvents CondominioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CondominioTableAdapter As Sigcom.ProvecDataSetTableAdapters.condominioTableAdapter
    Friend WithEvents ListadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
