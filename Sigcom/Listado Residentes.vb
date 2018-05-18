Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Listado_Residentes

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

    Private Sub btnRegistraResidentes_Click(sender As Object, e As EventArgs) Handles btnRegistraResidentes.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Registrar_Residente.Show()
    End Sub

    Private Sub btnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        txtBuscar.Clear()
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Try
            Dim doc As New Document(PageSize.LETTER, 5, 5, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe Residentes.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("Recuerde tener instalado Adobe PDF Reader")
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
        Dim datatable As New PdfPTable(dgvListResidentes.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgvListResidentes)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim encabezado As New Paragraph("Sistema de Gastos Comunes", New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim texto As New Phrase("Listado de Residentes " + txtBuscar.Text + " al día " + Now.Date(), New Font(Font.Name = "Arial", 10, Font.Bold))
        For i As Integer = 0 To dgvListResidentes.ColumnCount - 1
            datatable.AddCell(dgvListResidentes.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        For i As Integer = 0 To dgvListResidentes.RowCount - 1
            For j As Integer = 0 To dgvListResidentes.ColumnCount - 1
                datatable.AddCell(dgvListResidentes(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)

        Try
            Dim DV As New DataView(ProvecDataSet.residente)
            If rbRut.Checked Then
                DV.RowFilter = String.Format("rutResidente like'%{0}%'", txtBuscar.Text)
                dgvListResidentes.DataSource = DV
            End If
            If rbNombre.Checked Then
                DV.RowFilter = String.Format("NombresResidente like'%{0}%'", txtBuscar.Text)
                dgvListResidentes.DataSource = DV
            End If
            If rbApellido.Checked Then
                DV.RowFilter = String.Format("ApellidosResidente like '%{0}%'", txtBuscar.Text)
                dgvListResidentes.DataSource = DV
            End If
            If rbEdificio.Checked Then
                DV.RowFilter = String.Format("TorreResidente like '%{0}%'", txtBuscar.Text)
                dgvListResidentes.DataSource = DV
            End If
            If rbDepto.Checked Then
                DV.RowFilter = String.Format("DeptoResidente like '%{0}%'", txtBuscar.Text)
                dgvListResidentes.DataSource = DV
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Listado_Residentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProvecDataSet.residente' Puede moverla o quitarla según sea necesario.
        Me.ResidenteTableAdapter.Fill(Me.ProvecDataSet.residente)
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIrAtrasados.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Atrasados.Show()
    End Sub

    Private Sub btnTotales_Click(sender As Object, e As EventArgs) Handles btnTotales.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        Totales.Show()
    End Sub

    Private Sub btnRegistrPago_Click(sender As Object, e As EventArgs) Handles btnRegistrPago.Click
        'Acelerador
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Close()
        RegistrarPagos.Show()
    End Sub
End Class