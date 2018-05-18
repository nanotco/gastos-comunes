Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Atrasados

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Principal.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRegistrarResidente.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Registrar_Residente.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRegistrarPagos.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        RegistrarPagos.Show()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Dim MiBd As New ClaseBd
        Dim Rec As MySqlDataReader
        Try
            MiBd.AbrirConexion()
            Dim CadSql As String
            CadSql = "SELECT * FROM residente WHERE NOT EXISTS (SELECT * FROM detalle_pago  WHERE rutResidente = RutResidentePago and anioPago='" & cmbAnio.Text & "'and MesPago = '" & cmbMes.Text & "')"
            Rec = MiBd.EjecutarConsulta(CadSql)
            Dim Fila As Integer
            While Rec.Read
                With dgvAtrasados
                    .RowCount = .RowCount + 1
                    Fila = .RowCount - 1
                    .Item(0, Fila).Value = Rec("rutResidente")
                    .Item(1, Fila).Value = Rec("NombresResidente")
                    .Item(2, Fila).Value = Rec("ApellidosResidente")
                    .Item(3, Fila).Value = Rec("TorreResidente")
                    .Item(4, Fila).Value = Rec("DeptoResidente")
                    .Item(5, Fila).Value = Rec("emailResidente")
                    .Item(6, Fila).Value = Rec("telefonoResidente")
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'If Not Rec Is Nothing Then
            'Rec.Close()
            'Rec = Nothing
            'MiBd.CerrarConexion()
            'End If
        End Try
        btnBuscar.Enabled = False
        cmbAnio.Enabled = False
        cmbMes.Enabled = False
    End Sub

    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        dgvAtrasados.Rows.Clear()
        btnBuscar.Enabled = True
        cmbAnio.Enabled = True
        cmbMes.Enabled = True
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            Dim doc As New Document(PageSize.LETTER, 5, 5, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe Atrasados.pdf"
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
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(dgvAtrasados.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgvAtrasados)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim encabezado As New Paragraph("Sistema de Gastos Comunes", New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim texto As New Phrase("Detalle de Residentes Atrasados: " + cmbMes.Text + " " + cmbAnio.Text + " al día " + Now.Date(), New Font(Font.Name = "Arial", 10, Font.Bold))
        For i As Integer = 0 To dgvAtrasados.ColumnCount - 1
            datatable.AddCell(dgvAtrasados.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        For i As Integer = 0 To dgvAtrasados.RowCount - 1
            For j As Integer = 0 To dgvAtrasados.ColumnCount - 1
                datatable.AddCell(dgvAtrasados(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub
    Private Sub Atrasados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.meses' Puede moverla o quitarla según sea necesario.
        Me.MesesTableAdapter.Fill(Me.ProvecDataSet.meses)
        'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.anios' Puede moverla o quitarla según sea necesario.
        Me.AniosTableAdapter.Fill(Me.ProvecDataSet.anios)
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub btnListadoResidentes_Click(sender As Object, e As EventArgs) Handles btnListadoResidentes.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Listado_Residentes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Totales.Show()
    End Sub
End Class