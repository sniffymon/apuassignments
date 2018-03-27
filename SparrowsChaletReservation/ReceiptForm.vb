Imports Microsoft.Reporting.WinForms
Public Class ReceiptForm
    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AmountOwedP As New ReportParameter("AmountOwed", (CheckOut.overalltotal - CheckOut.ChaletDeposit))
        Dim TotalDepositP As New ReportParameter("TotalDeposit", CheckOut.ChaletDeposit)
        Dim TotalAmountP As New ReportParameter("TotalAmount", CheckOut.overalltotal)
        Dim StandardAmountP As New ReportParameter("StandardAmount", CheckOut.standardchalets)
        Dim SupremeAmountP As New ReportParameter("SupremeAmount", CheckOut.supremechalets)
        Dim StandardcostP As New ReportParameter("Standardcost", CheckOut.standardprice)
        Dim SupremecostP As New ReportParameter("Supremecost", CheckOut.supremeprice)
        'Dim DateParameter As New ReportParameter("BookedChalets", Date.Now.ToString("yyyy-MM-dd"))
        ReportViewer1.LocalReport.SetParameters(AmountOwedP)
        ReportViewer1.LocalReport.SetParameters(TotalDepositP)
        ReportViewer1.LocalReport.SetParameters(TotalAmountP)
        ReportViewer1.LocalReport.SetParameters(StandardAmountP)
        ReportViewer1.LocalReport.SetParameters(SupremeAmountP)
        ReportViewer1.LocalReport.SetParameters(StandardcostP)
        ReportViewer1.LocalReport.SetParameters(SupremecostP)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class