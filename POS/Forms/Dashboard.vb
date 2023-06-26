Imports System.Data.SqlClient
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dashboard_Totals()
        Dashboard_Recent_Activities()
        Dashboard_Top_Selling()
    End Sub

    Private Sub Dashboard_Totals()
        Try
            Dim dt As New DataTable()
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand("sp_dashboard", conn)
            cmd.Parameters.Add(New SqlParameter("@par_date", DateTime.Now))
            cmd.CommandType = CommandType.StoredProcedure
            Dim adp As New SqlDataAdapter()
            adp.SelectCommand = cmd
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_total_income.Text = "P" + dt.Rows(0)("total_income").ToString()
                Label_total_income_today.Text = "P" + dt.Rows(0)("total_income_today").ToString()
                Label_total_customer.Text = dt.Rows(0)("total_customer").ToString()
                Label_total_customer_today.Text = dt.Rows(0)("total_customer_today").ToString()
                Label_total_supplier.Text = dt.Rows(0)("total_supplier").ToString()
                Label_total_supplier_today.Text = dt.Rows(0)("total_supplier_today").ToString()
                Label_total_product.Text = dt.Rows(0)("total_products").ToString()
                Label_total_product_today.Text = dt.Rows(0)("total_products_today").ToString()
            Else
                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Dashboard_Recent_Activities()
        Dim query As String
        If user_login = "admin" Then
            query = "SELECT InvoiceNo,CustomerName,PaymentStatus,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions GROUP BY InvoiceNo,CustomerName,PaymentStatus ORDER BY InvoiceNo DESC"
        Else
            query = "SELECT InvoiceNo,CustomerName,PaymentStatus,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions WHERE CreatedBy = '" + user_login + "' GROUP BY InvoiceNo,CustomerName,PaymentStatus ORDER BY InvoiceNo DESC"
        End If

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
    Private Sub Dashboard_Top_Selling()
        Dim query As String
        If user_login = "admin" Then
            query = "SELECT ProductCode,ProductName,SUM(Quantity) AS Quantity FROM vw_Transactions GROUP BY ProductCode,ProductName ORDER BY SUM(Quantity) DESC"
        Else
            query = "SELECT ProductCode,ProductName,SUM(Quantity) AS Quantity FROM vw_Transactions WHERE CreatedBy = '" + user_login + "' GROUP BY ProductCode,ProductName ORDER BY SUM(Quantity) DESC"
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub CategoryDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CategoryDataGridView.CellFormatting
        If e.ColumnIndex = 6 And e.Value IsNot Nothing Then
            If e.Value.ToString.Trim = "Paid" Then
                e.CellStyle.ForeColor = Color.DodgerBlue
            ElseIf e.Value.ToString.Trim = "New" Then
                e.CellStyle.ForeColor = Color.Green
            Else
                e.CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class