Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Principal
    'Cargar datos del condominio
    Sub DatosCondominio()
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT rut,nombre,direccion,telefono,email FROM condominio WHERE rut= '" & cmbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                lblRut.Text = Rec("rut")
                lblNombre.Text = Rec("nombre")
                lblDireccion.Text = Rec("direccion")
                lblTelefono.Text = Rec("telefono")
                lblEmail.Text = Rec("email")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Inicio.Close()
    End Sub
    Private m_ChildFormNumber As Integer

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.condominio' Puede moverla o quitarla según sea necesario.
        Me.CondominioTableAdapter.Fill(Me.ProvecDataSet.condominio)
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Call DatosCondominio()
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
            Me.TextBoxDescription.Text = My.Application.Info.Description
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Acerca_de.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Me.Hide()
        Registrar_Residente.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem1.Click
        Me.Hide()
        RegistrarPagos.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Me.Hide()
        Listado_Residentes.Show()
    End Sub

    Private Sub TotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesToolStripMenuItem.Click
        Me.Hide()
        Totales.Show()
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        Me.Hide()
        Condominio.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem1.Click
        Me.Hide()
        Atrasados.Show()
    End Sub
End Class
