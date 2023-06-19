
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Public Class PayNow
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim command1 As New SqlCommand("Update TransactionHeader SET PersonnelId= @PersonnelId,CustomerName= @CustomerName,GrandTotal= @GrandTotal,PaymentAmount= @PaymentAmount,PaymentStatus= @PaymentStatus where InvoiceNo = @InvoiceNo", conn)
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
                Receipt()
                'Me.Hide()
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
    Private Sub Receipt()
        Try
            Using dt As New DataTable()
                Using conn As SqlConnection = New SqlConnection(connection)
                    Using cmd As SqlCommand = New SqlCommand("select * from vw_Transactions WHERE InvoiceNo = '" + InvoiceNoTextBox.Text.ToString().Trim() + "'", conn)
                        Using adp As New SqlDataAdapter()
                            adp.SelectCommand = cmd
                            adp.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Dim cryRpt As New ReportDocument
                                Dim report_path As String = Path.Combine(Application.StartupPath, "cryStoreReceipt.rpt").Replace("bin\Debug", "\Reports").Replace("bin\Release", "\Reports")
                                cryRpt.Load(report_path)
                                cryRpt.SetDataSource(dt)
                                CrystalReportViewer1.ReportSource = cryRpt
                                CrystalReportViewer1.Zoom(75)
                                CrystalReportViewer1.Refresh()
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

End Class