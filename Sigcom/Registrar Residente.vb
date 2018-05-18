Imports MySql.Data.MySqlClient
Public Class Registrar_Residente
    Public Function DatosCompletos() As Boolean
        Dim Completos As Boolean = True
        If (mtbRut.MaskCompleted) Then
            If (txtNombre.Text <> "") Then
                If (txtApellido.Text <> "") Then
                    If (cmbEdificio.SelectedIndex > -1) Then
                        If (txtDepto.Text <> "") Then
                            Completos = True
                        Else
                            Completos = False
                            MsgBox("Debe ingresar el depto.", MsgBoxStyle.Information)
                            txtDepto.Focus()
                        End If
                    Else
                        Completos = False
                        MsgBox("Debe escoger la torre. También puede agregar nueva torre en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
                        cmbEdificio.Focus()
                    End If
                Else
                    Completos = False
                    MsgBox("Debe ingresar Apellidos", MsgBoxStyle.Information)
                    txtApellido.Focus()
                End If
            Else
                Completos = False
                MsgBox("Debe ingresar el nombre", MsgBoxStyle.Information)
                txtNombre.Focus()
            End If
        Else
            Completos = False
            MsgBox("Debe ingresar el rut", MsgBoxStyle.Information)
            mtbRut.Focus()
        End If
        Return (Completos)
    End Function
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
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

    Private Sub btnRegistrarPagos_Click(sender As Object, e As EventArgs) Handles btnIrPagos.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        RegistrarPagos.Show()
    End Sub

    Private Sub cmbRut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRut.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente FROM residente WHERE rutResidente='" & cmbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                mtbRut.Text = cmbRut.Text
                cmbEdificio.Text = Rec("TorreResidente")
                txtDepto.Text = Rec("DeptoResidente")
                txtApellido.Text = Rec("ApellidosResidente")
                txtNombre.Text = Rec("NombresResidente")
                txtEmail.Text = Rec("emailResidente")
                txtTelefono.Text = Rec("telefonoResidente")
                btnModificar.Visible = True
                btnEliminar.Visible = True
            End If
            btnModificar.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarRut_Click(sender As Object, e As EventArgs) Handles btnBuscarRut.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente FROM residente WHERE rutResidente='" & mtbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                cmbEdificio.Text = Rec("TorreResidente")
                txtDepto.Text = Rec("DeptoResidente")
                txtApellido.Text = Rec("ApellidosResidente")
                txtNombre.Text = Rec("NombresResidente")
                txtEmail.Text = Rec("emailResidente")
                txtTelefono.Text = Rec("telefonoResidente")
                btnModificar.Visible = True
                btnEliminar.Visible = True
            Else
                MsgBox("No se encontró resultado.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Call LimpiarBusqueda()
    End Sub
    Sub LimpiarBusqueda()
        cmbRut.SelectedIndex = -1
        mtbRut.Text = ""
        txtDepto.Clear()
        Call Limpiar()
    End Sub

    Private Sub btnBuscarED_Click(sender As Object, e As EventArgs) Handles btnBuscarED.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT * FROM residente WHERE TorreResidente='" & cmbEdificio.Text & "'and DeptoResidente='" & txtDepto.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                cmbRut.Text = Rec("rutResidente")
                'cmbTorre.Text = Rec("TorreResidente")
                'txtDepto.Text = Rec("DeptoResidente")
                txtApellido.Text = Rec("ApellidosResidente")
                txtNombre.Text = Rec("NombresResidente")
                txtEmail.Text = Rec("emailResidente")
                txtTelefono.Text = Rec("telefonoResidente")
            Else
                MsgBox("No se encontró resultado. Intente de nuevo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If (DatosCompletos()) = True Then
            Dim MiBd As New ClaseBd
            Try
                Dim CadSql As String
                Dim Rec As MySqlDataReader
                CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente FROM residente WHERE rutResidente = '" & mtbRut.Text & "'or TorreResidente='" & cmbEdificio.Text & "'and DeptoResidente='" & txtDepto.Text & "'"
                Rec = MiBd.EjecutarConsulta(CadSql)
                If Rec.Read Then
                    MsgBox("Alguno de los datos que ingresó ya están registrados", MsgBoxStyle.Information)
                Else
                    Rec.Close()
                    CadSql = "Insert into residente(rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente) values ('" & mtbRut.Text & "', '" & txtNombre.Text & "', '" & txtApellido.Text & "', '" & cmbEdificio.Text & "','" & txtDepto.Text & "', '" & txtEmail.Text & "', '" & txtTelefono.Text & "')"
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Se registró exitosamente el Residente", MsgBoxStyle.Information)
                        Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
                        Call Limpiar()
                    Else
                        MsgBox("No Se registró el Residente", MsgBoxStyle.Information)
                    End If
                    Rec.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Return
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        Dim MiBd As New ClaseBd
        If (DatosCompletos()) Then
            Try
                Dim Rut As String
                Dim CadSql As String
                CadSql = "Delete from residente Where rutResidente='" _
                       & mtbRut.Text & "';"
                Rut = mtbRut.Text
                If MsgBox("¿Desea eliminar al residente: " + Rut + " ? Se perderá toda la información, sin embargo, los pagos se mantendrán registrados", vbQuestion + vbYesNo) = vbYes Then
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Residente eliminado con exito", MsgBoxStyle.Information)
                        Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
                        Call Limpiar()
                    Else
                        MsgBox("Error al eliminar Residente. No puede Cambiar al residente de Edificio ni Depto. Puede eliminarlo y volver a registrar", MsgBoxStyle.Information)
                    End If
                Else
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If (DatosCompletos()) = True Then
            Try
                Dim MiBd As New ClaseBd
                Dim CadSql As String
                CadSql = "UPDATE residente SET rutResidente='" & mtbRut.Text & "',NombresResidente='" & txtNombre.Text & "',ApellidosResidente='" & txtApellido.Text & "',TorreResidente='" & cmbEdificio.Text & "',DeptoResidente='" & txtDepto.Text & "',emailResidente='" & txtEmail.Text & "',telefonoResidente='" & txtTelefono.Text & "' WHERE TorreResidente='" & cmbEdificio.Text & "' and DeptoResidente='" & txtDepto.Text & "';"
                If MsgBox("¿Está seguro que desea modificar los datos del Residente? Importante: Tenga cuidado con duplicar información. Por ejemplo, dos residentes para un mismo Depto. y Edificio", vbQuestion + vbYesNo) = vbYes Then
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Residente modificado con exito", MsgBoxStyle.Information)
                        Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
                        Call Limpiar()
                    Else
                        MsgBox("Error al modificar Residente", MsgBoxStyle.Information)
                        Call Limpiar()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmbEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEdificio.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub Registrar_Residente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        Try
            Me.TorresTableAdapter.Fill(Me.ProvecDataSet.torres)
            Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
            Call Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Limpiar()
        mtbRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDepto.Clear()
        txtEmail.Clear()
        txtTelefono.Clear()
        cmbEdificio.SelectedIndex = -1
        cmbRut.SelectedIndex = -1
        btnModificar.Visible = False
        btnEliminar.Visible = False
        mtbRut.Focus()
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case vbBack
            Case Else
                e.KeyChar = vbNullChar
        End Select
    End Sub

    Private Sub mtbRut_LostFocus(sender As Object, e As EventArgs) Handles mtbRut.LostFocus
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente FROM residente WHERE rutResidente='" & mtbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                cmbEdificio.Text = Rec("TorreResidente")
                txtDepto.Text = Rec("DeptoResidente")
                txtApellido.Text = Rec("ApellidosResidente")
                txtNombre.Text = Rec("NombresResidente")
                txtEmail.Text = Rec("emailResidente")
                txtTelefono.Text = Rec("telefonoResidente")
                btnModificar.Visible = True
                btnEliminar.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call Limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListaResidentes.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Listado_Residentes.Show()
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