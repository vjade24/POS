
Imports System.Data.SqlClient
Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DateTimePicker1.Value = DateTime.Now.Month.ToString().Trim() + "/01/" + DateTime.Now.Year().ToString().Trim()
        'DateTimePicker2.Value = DateTime.Parse(DateTimePicker1.Value).AddMonths(1).AddDays(-1)

        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now

        LoadReport()
        TotalNew()
        TotalPaid()
        TotalHold()
    End Sub
    Private Sub LoadReport()
        Dim query As String
        query = "SELECT * FROM vw_Transactions WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') ORDER BY InvoiceNo DESC"

        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            CategoryDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport()
        TotalNew()
        TotalPaid()
        TotalHold()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport()
        TotalNew()
        TotalPaid()
        TotalHold()
    End Sub

    Private Sub TotalNew()
        Dim query As String
        query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'New' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_New.Text = "P " + Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                Label_New.Text = "P 0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub TotalPaid()
        Dim query As String
        query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_Paid.Text = "P " + Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                Label_Paid.Text = "P 0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub TotalHold()
        Dim query As String
        query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Hold' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_Hold.Text = "P " + Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                Label_Hold.Text = "P 0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
End Class