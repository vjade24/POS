
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Drawing.Printing

Public Class PayNow
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Double.Parse(PaymentAmountTextBox.Text.ToString.Trim()) < Double.Parse(GrandTotalTextBox.Text.ToString.Trim()) Then
            MsgBox("PAYMENT IS NOT VALID!", MsgBoxStyle.Critical)
            Return
        End If

        Dim command1 As New SqlCommand("Update TransactionHeader SET PersonnelId= @PersonnelId,CustomerName= @CustomerName,GrandTotal= @GrandTotal,PaymentAmount= @PaymentAmount,PaymentChange= @PaymentChange,PaymentStatus= @PaymentStatus where InvoiceNo = @InvoiceNo", conn)
        command1.Parameters.Add("@PersonnelId", SqlDbType.VarChar).Value = PersonnelIdTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar).Value = InvoiceNoTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = CustomerNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@GrandTotal", SqlDbType.VarChar).Value = GrandTotalTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentAmount", SqlDbType.VarChar).Value = PaymentAmountTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentChange", SqlDbType.VarChar).Value = PaymentChangeTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentStatus", SqlDbType.VarChar).Value = "Paid"
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Updated!", MsgBoxStyle.Critical)
            Else
                MsgBox("Payment Successfully Paid", MsgBoxStyle.Information)
                IconButton1.Visible = False
                Dim result_msg As DialogResult = MessageBox.Show("YOU WANT TO PRINT RECEIPT?", "", MessageBoxButtons.YesNo)
                If result_msg = DialogResult.No Then
                    Me.Hide()
                Else
                    Receipt(InvoiceNoTextBox.Text.ToString().Trim())
                    Me.Hide()
                End If
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub PaymentAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles PaymentAmountTextBox.TextChanged
        Try
            Dim changes As Double
            changes = Double.Parse(PaymentAmountTextBox.Text.ToString()) - Double.Parse(GrandTotalTextBox.Text.ToString())
            PaymentChangeTextBox.Text = changes.ToString("###,##0.00")
        Catch ex As Exception
            PaymentChangeTextBox.Text = "0.00"
        End Try
    End Sub
    Public Sub Receipt(invoice_nbr)
        Try
            Using dt As New DataTable()
                Using conn As SqlConnection = New SqlConnection(connection)
                    Using cmd As SqlCommand = New SqlCommand("select * from vw_Transactions WHERE InvoiceNo = '" + invoice_nbr.ToString().Trim() + "' ORDER BY ProductName", conn)
                        Using adp As New SqlDataAdapter()
                            adp.SelectCommand = cmd
                            adp.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Dim cryRpt As New ReportDocument
                                Dim report_path As String = Path.Combine(Application.StartupPath, "cryStoreReceipt.rpt").Replace("bin\Debug", "\Reports").Replace("bin\Release", "\Reports")
                                cryRpt.Load(report_path)
                                cryRpt.SetDataSource(dt)
                                CrystalReportViewer1.ReportSource = cryRpt
                                CrystalReportViewer1.Zoom(100)
                                CrystalReportViewer1.Refresh()

                                cryRpt.PrintOptions.PrinterName = GetDefaultPrinter()
                                cryRpt.PrintToPrinter(1, False, 0, 0)
                            Else
                                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
                                Dim cryRpt As New ReportDocument
                                CrystalReportViewer1.ReportSource = cryRpt
                                CrystalReportViewer1.Refresh()
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Receipt(InvoiceNoTextBox.Text.ToString().Trim())
    End Sub

    Private Function GetDefaultPrinter() As String
        Dim settings As PrinterSettings = New PrinterSettings()
        For Each printer As String In PrinterSettings.InstalledPrinters
            settings.PrinterName = printer
            If settings.IsDefaultPrinter Then
                Return printer
            End If
        Next
        Return String.Empty
    End Function
End Class