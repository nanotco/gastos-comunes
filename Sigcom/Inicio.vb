Imports MySql.Data.MySqlClient
Public Class Inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        If cmbUsuario.Text = "administrador" And txtClave.Text = "master" Then
            Principal.Show()
            Me.Hide()
            txtClave.Text = ""
        End If
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Dim usuario As String
        Dim clave As String
        Try
            Dim CadSql As String
            CadSql = "SELECT usuario,clave FROM usuarios WHERE usuario='" & cmbUsuario.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                usuario = Rec("usuario")
                clave = Rec("clave")
                If txtClave.Text = clave Then
                    Principal.Show()
                    Me.Hide()
                    txtClave.Text = ""
                Else
                    MsgBox("Contraseña incorrecta, intente de nuevo o contacte al administrador del condominio", MsgBoxStyle.Information)
                    txtClave.Text = ""
                    txtClave.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtClave.Focus()
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            Me.UsuariosTableAdapter.Fill(Me.ProvecDataSet.usuarios)
        Catch ex As Exception
            MsgBox("Encienda el servicio de MySql ubicado en Xampp para establecer la conexión a la Base de Datos. Vaya a Xampp Control Panel en el escritorio, luego en el servicio MySQL, presione el botón Start. Recuerde que la Base de Datos debe estar correctamente importada, tal como se indica en el manual de instalación.", MsgBoxStyle.Information)
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        If txtClave.Text = "master" Then
            btnIngresar.Focus()
        End If
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Dim clave As String
        Try
            Dim CadSql As String
            CadSql = "SELECT usuario,clave FROM usuarios WHERE usuario='" & cmbUsuario.Text & "' and clave='" & txtClave.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                clave = Rec("clave")
                If txtClave.Text = clave Then
                    btnIngresar.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
