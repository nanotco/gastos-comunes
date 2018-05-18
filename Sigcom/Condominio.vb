Imports MySql.Data.MySqlClient
Public Class Condominio

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub cmbRut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRut.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Call Condominio()
        If cmbRut.SelectedIndex = 1 Then
            btnModificar.Enabled = True
            btnRegistrar.Enabled = False
        End If
    End Sub
    Sub Condominio()
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT rut,nombre,direccion,telefono,email FROM condominio WHERE rut= '" & cmbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                mtbRut.Text = Rec("rut")
                txtNombre.Text = Rec("nombre")
                txtDireccion.Text = Rec("direccion")
                txtTelefono.Text = Rec("telefono")
                txtEmail.Text = Rec("email")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        If cmbRut.SelectedIndex > -1 Then
            MsgBox("Ya existe un condominio Registrado. Recuerde que sólo se puede registrar un Condominio.")
            Return
        End If
        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If txtNombre.Text = "" Then
            MsgBox("Ingrese Nombre del Condominio")
            txtNombre.Focus()
            Return
        End If
        If mtbRut.Text = "" Then
            MsgBox("Ingrese Rut del Condominio")
            mtbRut.Focus()
            Return
        End If
        If txtDireccion.Text = "" Then
            MsgBox("Ingrese dirección del Condominio")
            txtDireccion.Focus()
            Return
        End If
        If txttelefono.Text = "" Then
            MsgBox("Ingrese Teléfono del Condominio")
            txttelefono.Focus()
            Return
        End If
        Dim MiBd As New ClaseBd
        Dim CadSql As String
        Dim Rec As MySqlDataReader
        Try
            CadSql = "SELECT * FROM condominio WHERE rut='" & mtbRut.Text & "'or nombre= '" & txtNombre.Text & "'or telefono= '" & txttelefono.Text & "'or email= '" & txtEmail.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe Registro del Condominio en la Base de Datos", MsgBoxStyle.Information)
                btnModificar.Enabled = True
                Rec.Close()
                Return
            Else
                Rec.Close()
                CadSql = "INSERT INTO condominio (rut,nombre,direccion,telefono,email)VALUES ('" & mtbRut.Text & "', '" & txtNombre.Text & "', '" & txtDireccion.Text & "', '" & txttelefono.Text & "','" & txtEmail.Text & "')"
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Se registró con éxito")
                    Me.CondominioTableAdapter.Fill(Me.ProvecDataSet.condominio)
                    Principal.CondominioTableAdapter.Fill(Me.ProvecDataSet.condominio)
                Else
                    MsgBox("No se registró el condominio")
                End If
                Rec.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarAnio_Click(sender As Object, e As EventArgs) Handles btnGuardarAnio.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If txtAnio.Text = "" Then
            MsgBox("Ingrese año")
            txtAnio.Focus()
            Return
        End If
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT anio FROM anios WHERE anio = '" & txtAnio.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe el año registrado en la Base de Datos", MsgBoxStyle.Information)
                Rec.Close()
                Return
            Else
                Rec.Close()
                CadSql = "Insert into anios(anio)  values ('" & txtAnio.Text & "')"
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Se registró exitosamente el nuevo año", MsgBoxStyle.Information)
                    txtAnio.Clear()
                Else
                    MsgBox("No se registró el Año")
                End If
                Rec.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtAnio.Clear()
    End Sub

    Private Sub btnGuardarEdificio_Click(sender As Object, e As EventArgs) Handles btnGuardarEdificio.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If txtEdificio.Text = "" Then
            MsgBox("Ingrese nueva torre del Condominio")
            txtEdificio.Focus()
            Return
        End If
        Dim MiBd As New ClaseBd
        Dim CadSql As String
        Dim Rec As MySqlDataReader
        Try
            CadSql = "SELECT nombreTorre FROM torres WHERE nombreTorre='" & txtEdificio.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe Edificio en la Base de Datos", MsgBoxStyle.Information)
                Rec.Close()
                Return
            Else
                Rec.Close()
                CadSql = "INSERT INTO torres (nombreTorre) VALUES ('" & txtEdificio.Text & "')"
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Se registró con éxito")
                Else
                    MsgBox("No se registró la torre")
                End If
                Rec.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistarUsuario_Click(sender As Object, e As EventArgs) Handles btnRegistarUsuario.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If txtUsuario.Text = "" Then
            MsgBox("Ingrese Usuario")
            txtUsuario.Focus()
            Return
        End If
        If txtClave.Text = "" Then
            MsgBox("Ingrese clave")
            txtClave.Focus()
            Return
        End If
        If txtConfirmar.Text = "" Then
            MsgBox("Confirme Clave")
            txtConfirmar.Focus()
            Return
        End If
        If txtClave.Text = txtConfirmar.Text Then
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            Try
                CadSql = "SELECT usuario,clave FROM usuarios WHERE usuario='" & txtUsuario.Text & "'"
                Rec = MiBd.EjecutarConsulta(CadSql)
                If Rec.Read Then
                    MsgBox("Ya existe usuario en la Base de Datos", MsgBoxStyle.Information)
                    Rec.Close()
                    Return
                Else
                    Rec.Close()
                    CadSql = "INSERT INTO usuarios(usuario,clave) VALUES ('" & txtUsuario.Text & "', '" & txtClave.Text & "')"
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Se registró con éxito")
                        Me.UsuariosTableAdapter.Fill(Me.ProvecDataSet.usuarios)
                        txtUsuario.Clear()
                        txtClave.Clear()
                        txtConfirmar.Clear()
                    Else
                        MsgBox("No se registró el usuario")
                    End If
                    Rec.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No concuerda la clave")
        End If
    End Sub

    Private Sub btnGuardarCuota_Click(sender As Object, e As EventArgs) Handles btnGuardarCuota.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If txtCuota.Text = "" Then
            MsgBox("Ingrese cuota del Condominio")
            txtCuota.Focus()
            Return
        End If
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT valorCuota FROM cuota WHERE valorCuota = '" & txtCuota.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe la cuota registrada en la Base de Datos", MsgBoxStyle.Information)
                Rec.Close()
                Return
            Else
               Rec.Close()
                CadSql = "Insert into cuota(valorCuota)  values ('" & txtCuota.Text & "')"
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Se registró exitosamente el nuevo valor cuota", MsgBoxStyle.Information)
                    txtCuota.Clear()
                Else
                    MsgBox("No se registró la cuota")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtCuota.Clear()
    End Sub

    Private Sub btnCambiarClave_Click(sender As Object, e As EventArgs) Handles btnCambiarClave.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        If cmbusuario.Text <> Inicio.cmbUsuario.Text Then
            MsgBox("Solo puede modificar su propia clave")
            Return
        End If
        If txtClaveAdmn.Text = "" Then
            MsgBox("Ingrese clave")
            txtClaveAdmn.Focus()
            Return
        End If
        If txtConfirmarAdm.Text = "" Then
            MsgBox("Confirme Clave")
            txtConfirmarAdm.Focus()
            Return
        End If
        If txtClaveAdmn.Text <> txtConfirmarAdm.Text Then
            MsgBox("No concuerda la clave")
        Else
            Try
                Dim MiBd As New ClaseBd
                Dim CadSql As String
                CadSql = "UPDATE usuarios SET clave='" & txtClaveAdmn.Text & "' where usuario='" & cmbusuario.Text & "';"
                If MsgBox("¿Está seguro que desea modificar los datos del usuario? ", vbQuestion + vbYesNo) = vbYes Then
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Clave modificada con éxito", MsgBoxStyle.Information)
                        txtClaveAdmn.Clear()
                        txtConfirmarAdm.Clear()
                    Else
                        MsgBox("Error al modificar clave", MsgBoxStyle.Information)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEliminarUsuario_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If cmbusuario.Text = "administrador" Then
            MsgBox("No puede eliminar al administrador")
            Return
        End If
        If cmbusuario.Text <> "administrador" Then
            btnEliminarUsuario.Enabled = True
            Try
                Dim MiBd As New ClaseBd
                Dim Usuario As String
                Dim CadSql As String
                CadSql = "DELETE FROM usuarios WHERE usuario='" _
                       & cmbusuario.Text & "';"
                Usuario = cmbusuario.Text
                If MsgBox("¿Desea eliminar al usuario: " + Usuario + " ? ", vbQuestion + vbYesNo) = vbYes Then
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Usuario eliminado con exito", MsgBoxStyle.Information)
                        Me.UsuariosTableAdapter.Fill(Me.ProvecDataSet.usuarios)
                    Else
                        MsgBox("Error al eliminar Usuario", MsgBoxStyle.Information)
                    End If
                Else
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Condominio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ProvecDataSet.usuarios)
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        cmbRut.Focus()
        Me.CondominioTableAdapter.Fill(Me.ProvecDataSet.condominio)
        Call Condominio()
                Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            CadSql = "UPDATE condominio SET rut='" & mtbRut.Text & "',nombre='" & txtNombre.Text & "',direccion='" & txtDireccion.Text & "',telefono='" & txttelefono.Text & "',email='" & txtEmail.Text & "';"
            If MsgBox("¿Está seguro que desea modificar los datos del Condominio? ", vbQuestion + vbYesNo) = vbYes Then
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Condominio modificado con exito", MsgBoxStyle.Information)
                    Me.CondominioTableAdapter.Fill(Me.ProvecDataSet.condominio)
                Else
                    MsgBox("Error al modificar Condominio", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarPagos_Click(sender As Object, e As EventArgs) Handles btnRegistrarPagos.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        RegistrarPagos.Show()
    End Sub

    Private Sub btnRegistrResidente_Click(sender As Object, e As EventArgs) Handles btnRegistrResidente.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Registrar_Residente.Show()
    End Sub

    Private Sub btnTotales_Click(sender As Object, e As EventArgs) Handles btnTotales.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Totales.Show()
    End Sub

    Private Sub btnAtrasados_Click(sender As Object, e As EventArgs) Handles btnAtrasados.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Atrasados.Show()
    End Sub
End Class