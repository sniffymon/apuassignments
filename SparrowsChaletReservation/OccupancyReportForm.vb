Imports Microsoft.Reporting.WinForms
Public Class OccupancyReportForm
    Private Sub OccupancyReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        Dim DateToday As New ReportParameter("DateToday", Date.Today.ToShortDateString)
        ReportViewer1.LocalReport.SetParameters(DateToday)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class