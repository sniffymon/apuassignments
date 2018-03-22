Imports Microsoft.Reporting.WinForms
Public Class OccupancyReport
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DateParameter As New ReportParameter("DateToday", Date.Now.ToString("yyyy-MM-dd"))
        ReportViewer1.LocalReport.SetParameters(DateParameter)
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class