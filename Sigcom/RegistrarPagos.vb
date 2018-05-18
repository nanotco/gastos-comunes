Imports MySql.Data.MySqlClient
Public Class RegistrarPagos
    Public Function DatosCompletos() As Boolean
        Dim Completos As Boolean = True
        If lblRut.Text = "" Then
            If (cmbMes.SelectedIndex = -1) Then
                If cmbAnio.SelectedIndex = -1 Then
                    If (cmbCuota.SelectedIndex = False) Then
                        Completos = True
                        MsgBox("Debe escoger la cuota.También puede agregar nueva cuota en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
                    End If
                    Completos = True
                Else
                    Completos = False
                    MsgBox("Debe escoger el año.También puede agregar nuevo año en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
                End If
                Completos = True
            Else
                Completos = False
                'MsgBox("Debe elegir el mes")
            End If
            Completos = True
        Else
            Completos = False
            'MsgBox("Debe elegir el rut")
        End If
        Return (Completos)
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub btnResidentes_Click(sender As Object, e As EventArgs) Handles btnResidentes.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Registrar_Residente.Show()
    End Sub

    Private Sub btnConsultarPago_Click(sender As Object, e As EventArgs) Handles btnConsultarPago.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If lblRut.Text = "" Then
            MsgBox("Realice una búsqueda de Residente primero", MsgBoxStyle.Information)
            cmbRut.Focus()
            Return
        End If
        If cmbMes.SelectedIndex = -1 Then
            MsgBox("Seleccione mes", MsgBoxStyle.Information)
            cmbMes.Focus()
            Return
        End If
        If cmbAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione año. También puede agregar nuevo año en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
            cmbAnio.Focus()
            Return
        End If
        If cmbCuota.SelectedIndex = -1 Then
            MsgBox("Seleccione cuota. También puede agregar nueva cuota en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
            cmbCuota.Focus()
            Return
        End If
        If (DatosCompletos()) = False Then
            Dim MiBd As New ClaseBd
            Try
                Dim CadSql As String
                Dim Rec As MySqlDataReader
                CadSql = "SELECT idPago,EdificioPago,DeptoPago,RutResidentePago,MesPago,anioPago,valorCuota,FechaPago FROM detalle_pago WHERE EdificioPago='" & lblEdificio.Text & "'and DeptoPago = '" & lblDepto.Text & "'and MesPago = '" & cmbMes.Text & "'and anioPago = '" & cmbAnio.Text & "'"
                Rec = MiBd.EjecutarConsulta(CadSql)
                If Rec.Read Then
                    MsgBox("Se encontró un pago relacionado con la consulta. Revise la cuota y fecha de pago", MsgBoxStyle.Information)
                    cmbCuota.Text = Rec("valorCuota")
                    dtpFecha.Text = Rec("FechaPago")
                    btnModificar.Visible = True
                    btnEliminar.Visible = True
                    cmbRut.Focus()
                Else
                    MsgBox("No se encontró registro en la Base de Datos relacionado con la consulta.", MsgBoxStyle.Information)
                    End If
                    Rec.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If lblRut.Text = "" Then
            MsgBox("Realice una búsqueda de Residente primero", MsgBoxStyle.Information)
            cmbRut.Focus()
            Return
        End If
        If cmbMes.SelectedIndex = -1 Then
            MsgBox("Seleccione mes", MsgBoxStyle.Information)
            cmbMes.Focus()
            Return
        End If
        If cmbAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione año. También puede agregar nuevo año en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
            cmbAnio.Focus()
            Return
        End If
        If cmbCuota.SelectedIndex = -1 Then
            MsgBox("Seleccione cuota. También puede agregar nueva cuota en la pestaña Condominio del menú principal", MsgBoxStyle.Information)
            cmbCuota.Focus()
            Return
        End If
        If (DatosCompletos()) = False Then
           Dim MiBd As New ClaseBd
            Try
                Dim CadSql As String
                Dim Rec As MySqlDataReader
                CadSql = "SELECT idPago,EdificioPago,DeptoPago,RutResidentePago,MesPago,anioPago,valorCuota,FechaPago FROM detalle_pago WHERE EdificioPago='" & lblEdificio.Text & "'and DeptoPago = '" & lblDepto.Text & "'and MesPago = '" & cmbMes.Text & "'and anioPago = '" & cmbAnio.Text & "'"
                Rec = MiBd.EjecutarConsulta(CadSql)
                If Rec.Read Then
                    MsgBox("Ya existe el pago registrado en la Base de Datos.", MsgBoxStyle.Information)
                    cmbCuota.Text = Rec("valorCuota")
                    dtpFecha.Text = Rec("FechaPago")
                    btnModificar.Visible = True
                    btnEliminar.Visible = True
                    cmbRut.Focus()
                Else
                    Rec.Close()
                    CadSql = "Insert detalle_pago(EdificioPago,DeptoPago,RutResidentePago,MesPago,anioPago,valorCuota,FechaPago) values ('" & lblEdificio.Text & "', '" & lblDepto.Text & "', '" & lblRut.Text & "', '" & cmbMes.Text & "','" & cmbAnio.Text & "','" & cmbCuota.Text & "','" & dtpFecha.Text & "')"
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Se registró exitosamente el Pago", MsgBoxStyle.Information)
                        cmbRut.Focus()
                    Else
                        MsgBox("No Se registró el Pago", MsgBoxStyle.Information)
                    End If
                    Rec.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Seleccione RUT", MsgBoxStyle.Information)
            cmbRut.Focus()
        End If
    End Sub

    Private Sub btnBuscarED_Click(sender As Object, e As EventArgs) Handles btnBuscarED.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente FROM residente WHERE TorreResidente='" & cmbEdificio.Text & "'and DeptoResidente='" & txtBuscarDepto.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                lblRut.Text = Rec("rutResidente")
                lblEdificio.Text = Rec("TorreResidente")
                lblDepto.Text = Rec("DeptoResidente")
                lblApellido.Text = Rec("ApellidosResidente")
                lblNombre.Text = Rec("NombresResidente")
                Call LimpiarBusqueda()
            Else
                MsgBox("No se encontró resultado. Intente de nuevo")
                Call LimpiarBusqueda()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LimpiarBusqueda()
        cmbRut.SelectedIndex = -1
        cmbEdificio.SelectedIndex = -1
        txtBuscarDepto.Clear()
        mtbRut.Text = ""
    End Sub
    Sub LimpiarCampos()
        cmbRut.SelectedIndex = -1
        cmbEdificio.SelectedIndex = -1
        txtBuscarDepto.Clear()
        mtbRut.Text = ""
        lblRut.Text = ""
        lblEdificio.Text = ""
        lblDepto.Text = ""
        lblApellido.Text = ""
        lblNombre.Text = ""
        dtpFecha.Value = Date.Today
    End Sub
    Private Sub cmbRut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRut.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente FROM residente WHERE rutResidente='" & cmbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                lblRut.Text = Rec("rutResidente")
                lblEdificio.Text = Rec("TorreResidente")
                lblDepto.Text = Rec("DeptoResidente")
                lblApellido.Text = Rec("ApellidosResidente")
                lblNombre.Text = Rec("NombresResidente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEdificio.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
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
                lblRut.Text = Rec("rutResidente")
                lblEdificio.Text = Rec("TorreResidente")
                lblDepto.Text = Rec("DeptoResidente")
                lblApellido.Text = Rec("ApellidosResidente")
                lblNombre.Text = Rec("NombresResidente")
            Else
                MsgBox("No se encontró resultado. Intente de nuevo")
                Call LimpiarBusqueda()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call LimpiarBusqueda()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        If cmbMes.SelectedIndex = -1 Then
            MsgBox("Seleccione mes", MsgBoxStyle.Information)
            cmbMes.Focus()
            Return
        End If
        If cmbAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione año", MsgBoxStyle.Information)
            cmbAnio.Focus()
            Return
        End If
        If cmbCuota.SelectedIndex = -1 Then
            MsgBox("Seleccione cuota", MsgBoxStyle.Information)
            cmbCuota.Focus()
            Return
        End If
        If (DatosCompletos()) = False Then
            Try
                Dim MiBd As New ClaseBd
                Dim CadSql As String
                If MsgBox("Lo único que se modificará será el valor de la cuota y fecha de pago. ¿Desea continuar?", vbQuestion + vbYesNo) = vbYes Then
                    CadSql = "UPDATE detalle_pago SET valorCuota='" & cmbCuota.Text & "',FechaPago='" & dtpFecha.Text & "' WHERE RutResidentePago='" & lblRut.Text & "' and MesPago = '" & cmbMes.Text & "'and anioPago = '" & cmbAnio.Text & "';"
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Pago modificado con exito", MsgBoxStyle.Information)
                        Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
                        Call Limpiar()
                    Else
                        MsgBox("Error al modificar Pago. Recuerde que solo puede cambiar el valor cuota y fecha de pago", MsgBoxStyle.Information)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        If Inicio.cmbUsuario.Text <> "administrador" Then
            MsgBox("Ud no tiene permiso para realizar la acción. Contacte al administrador del condominio")
            Return
        End If
        If cmbMes.SelectedIndex = -1 Then
            MsgBox("Seleccione mes", MsgBoxStyle.Information)
            cmbMes.Focus()
            Return
        End If
        If cmbAnio.SelectedIndex = -1 Then
            MsgBox("Seleccione año", MsgBoxStyle.Information)
            cmbAnio.Focus()
            Return
        End If
        If cmbCuota.SelectedIndex = -1 Then
            MsgBox("Seleccione cuota", MsgBoxStyle.Information)
            cmbCuota.Focus()
            Return
        End If
        If (DatosCompletos()) = False Then
            Dim MiBd As New ClaseBd
            Try
                Dim Rut As String
                Dim CadSql As String
                CadSql = "Delete from detalle_pago Where RutResidentePago='" & lblRut.Text & "'and MesPago='" & cmbMes.Text & "'and anioPago='" & cmbAnio.Text & "';"
                Rut = lblRut.Text
                If MsgBox("¿Desea eliminar pago al residente: " + Rut, vbQuestion + vbYesNo) = vbYes Then
                    If MiBd.EjecutarIUD(CadSql) > 0 Then
                        MsgBox("Pago eliminado con exito", MsgBoxStyle.Information)
                        Call Limpiar()
                    Else
                        MsgBox("Error al eliminar Pago", MsgBoxStyle.Information)
                    End If
                Else
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RegistrarPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            cmbRut.Focus()
            Me.CuotaTableAdapter.Fill(Me.ProvecDataSet.cuota)
            Me.AniosTableAdapter.Fill(Me.ProvecDataSet.anios)
            Me.MesesTableAdapter.Fill(Me.ProvecDataSet.meses)
            Me.TorresTableAdapter.Fill(Me.ProvecDataSet.torres)
            Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
            Call Limpiar()
            dtpFecha.Value = Date.Today
            btnModificar.Visible = False
            btnEliminar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Limpiar()
        txtBuscarDepto.Clear()
        cmbRut.SelectedIndex = -1
        cmbEdificio.SelectedIndex = -1
        mtbRut.Text = ""
        cmbRut.Focus()
        btnModificar.Visible = False
        btnEliminar.Visible = False
        dtpFecha.Value = Date.Today
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call LimpiarCampos()
    End Sub

    Private Sub mtbRut_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case e.KeyChar
            Case "0" To "9"
            Case "k", "K"
                e.KeyChar = "K"
            Case Else
                e.KeyChar = vbNullChar
        End Select
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

    Private Sub btnListaResidentes_Click(sender As Object, e As EventArgs) Handles btnListaResidentes.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Listado_Residentes.Show()
    End Sub

    Private Sub mtbRut_LostFocus(sender As Object, e As EventArgs) Handles mtbRut.LostFocus
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            Dim CadSql As String
            CadSql = "SELECT rutResidente,NombresResidente,ApellidosResidente,TorreResidente,DeptoResidente,emailResidente, telefonoResidente FROM residente WHERE rutResidente='" & mtbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                lblRut.Text = Rec("rutResidente")
                lblEdificio.Text = Rec("TorreResidente")
                lblDepto.Text = Rec("DeptoResidente")
                lblApellido.Text = Rec("ApellidosResidente")
                lblNombre.Text = Rec("NombresResidente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtbRut_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtbRut.MaskInputRejected

    End Sub
End Class