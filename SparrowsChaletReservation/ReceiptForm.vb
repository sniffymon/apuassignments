Imports Microsoft.Reporting.WinForms
Public Class ReceiptForm
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim supamount, staamount, supcost, stacost As String
        staamount = CheckOut.standardchalets
        supamount = CheckOut.supremechalets
        supcost = CheckOut.supremeprice
        stacost = CheckOut.standardprice
        Dim StandardAmountP As New ReportParameter("StandardAmount", staamount)
        Dim SupremeAmountP As New ReportParameter("SupremeAmount", supamount)
        Dim StandardcostP As New ReportParameter("Standardcost", stacost)
        Dim SupremecostP As New ReportParameter("Supremecost", supcost)
        'Dim DateParameter As New ReportParameter("BookedChalets", Date.Now.ToString("yyyy-MM-dd"))
        ReportViewer1.LocalReport.SetParameters(StandardAmountP)
        ReportViewer1.LocalReport.SetParameters(SupremeAmountP)
        ReportViewer1.LocalReport.SetParameters(StandardcostP)
        ReportViewer1.LocalReport.SetParameters(SupremecostP)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class