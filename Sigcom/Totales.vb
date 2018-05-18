Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Totales
    Sub Total()
        Dim total As Double = 0
        Dim iTotal As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgvTotales(6, i).Value)
        Next
        txtTotal.Text = Format(total, "$ #,##")
    End Sub
    Sub NuevaConsulta()
        cmbAnio.SelectedIndex = -1
        cmbMes.SelectedIndex = -1
        cmbEdificio.SelectedIndex = -1
        cmbRut.SelectedIndex = -1
        Call Total()
        cmbAnio.Enabled = True
        cmbMes.Enabled = True
        cmbEdificio.Enabled = True
        cmbRut.Enabled = True
    End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRegistrarPago.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        RegistrarPagos.Show()
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Call NuevaConsulta()
        Call Total()
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(dgvTotales.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgvTotales)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim encabezado As New Paragraph("Sistema de Gastos Comunes", New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim texto As New Phrase("Detalle de pagos de: " + cmbMes.Text + " " + cmbAnio.Text + " " + cmbEdificio.Text + " " + cmbRut.Text + " al día " + Now.Date(), New Font(Font.Name = "Arial", 10, Font.Bold))
        Dim total As New Paragraph("El total de " + cmbMes.Text + " " + cmbAnio.Text + " " + cmbEdificio.Text + " " + cmbRut.Text + " es: " + txtTotal.Text + " al día " + Now.Date(), New Font(Font.Name = "Arial", 10, Font.Bold))
        For i As Integer = 0 To dgvTotales.ColumnCount - 1
            datatable.AddCell(dgvTotales.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        For i As Integer = 0 To dgvTotales.RowCount - 1
            For j As Integer = 0 To dgvTotales.ColumnCount - 1
                datatable.AddCell(dgvTotales(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
        document.Add(total)
    End Sub
    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            If cmbAnio.SelectedIndex = -1 Then
                MsgBox("Seleccione año. Presione nueva consulta si es necesario. Recuerde seguir el orden indicado: 1°, 2°, 3°")
                cmbAnio.Focus()
                Return
            End If
            Dim doc As New Document(PageSize.LETTER, 20, 20, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe Recaudaciones.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
            Me.TorresTableAdapter.Fill(Me.ProvecDataSet.torres)
            Me.MesesTableAdapter.Fill(Me.ProvecDataSet.meses)
            Me.AniosTableAdapter.Fill(Me.ProvecDataSet.anios)
            Me.Detalle_pagoTableAdapter.Fill(Me.ProvecDataSet.detalle_pago)
            Call NuevaConsulta()
            Call Total()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        Dim GC As New DataView(ProvecDataSet.detalle_pago)
        GC.RowFilter = String.Format("anioPago like'%{0}%'", cmbAnio.Text)
        dgvTotales.DataSource = GC
        Call Total()
        cmbAnio.Enabled = False
        If (cmbAnio.SelectedIndex > -1) And (cmbMes.SelectedIndex > -1) And (cmbEdificio.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And MesPago LIKE '%" & Me.cmbMes.Text & "%' And EdificioPago LIKE '%" & Me.cmbEdificio.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        Dim GC As New DataView(ProvecDataSet.detalle_pago)
        GC.RowFilter = String.Format("MesPago like'%{0}%'", cmbMes.Text)
        dgvTotales.DataSource = GC
        cmbAnio.Enabled = False
        Call Total()
        If (cmbAnio.SelectedIndex > -1) And (cmbMes.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And MesPago LIKE '%" & Me.cmbMes.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
        cmbMes.Enabled = False
        cmbRut.Enabled = False
        If (cmbAnio.SelectedIndex > -1) And (cmbMes.SelectedIndex > -1) And (cmbEdificio.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And MesPago LIKE '%" & Me.cmbMes.Text & "%' And EdificioPago LIKE '%" & Me.cmbEdificio.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
        cmbRut.Enabled = False
    End Sub

    Private Sub cmbEdificio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEdificio.SelectedIndexChanged
        Dim GC As New DataView(ProvecDataSet.detalle_pago)
        GC.RowFilter = String.Format("EdificioPago like'%{0}%'", cmbEdificio.Text)
        dgvTotales.DataSource = GC
        cmbAnio.Enabled = False
        cmbMes.Enabled = False
        Call Total()
        If (cmbAnio.SelectedIndex > -1) And (cmbEdificio.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And EdificioPago LIKE '%" & Me.cmbEdificio.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
        If (cmbMes.SelectedIndex > -1) And (cmbEdificio.SelectedIndex > -1) Then
            GC.RowFilter = "MesPago LIKE '%" & Me.cmbMes.Text & "%' And EdificioPago LIKE '%" & Me.cmbEdificio.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
        cmbRut.Enabled = False
        If (cmbAnio.SelectedIndex > -1) And (cmbMes.SelectedIndex > -1) And (cmbEdificio.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And MesPago LIKE '%" & Me.cmbMes.Text & "%' And EdificioPago LIKE '%" & Me.cmbEdificio.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
        cmbEdificio.Enabled = False
        cmbRut.Enabled = False
    End Sub

    Private Sub cmbRut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRut.SelectedIndexChanged
        Dim GC As New DataView(ProvecDataSet.detalle_pago)
        GC.RowFilter = String.Format("RutResidentePago like'%{0}%'", cmbRut.Text)
        dgvTotales.DataSource = GC
        Call Total()
        cmbMes.Enabled = False
        cmbEdificio.Enabled = False
        cmbAnio.Enabled = False
        If (cmbAnio.SelectedIndex > -1) And (cmbRut.SelectedIndex > -1) Then
            GC.RowFilter = "anioPago LIKE '%" & Me.cmbAnio.Text & "%' And RutResidentePago LIKE '%" & Me.cmbRut.Text & "%'"
            dgvTotales.DataSource = GC
        End If
        Call Total()
    End Sub

    Private Sub btnAtrasados_Click(sender As Object, e As EventArgs) Handles btnAtrasados.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Atrasados.Show()
    End Sub
End Class