
Imports System.Data.SqlClient
Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DateTimePicker1.Value = DateTime.Now.Month.ToString().Trim() + "/01/" + DateTime.Now.Year().ToString().Trim()
        'DateTimePicker2.Value = DateTime.Parse(DateTimePicker1.Value).AddMonths(1).AddDays(-1)

        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now

        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")

        LoadPersonnel()
        ComboBox1.Text = ""
    End Sub
    Private Sub LoadReport(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT * FROM vw_Transactions WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "' ORDER BY InvoiceNo DESC"
        Else
            query = "SELECT * FROM vw_Transactions WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') ORDER BY InvoiceNo DESC"
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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")
    End Sub

    Private Sub TotalNew(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'New' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'New' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
        End If
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

    Private Sub TotalPaid(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') "
        End If
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

    Private Sub TotalHold(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Hold' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Hold' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
        End If
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
    Private Sub LoadPersonnel()
        Dim query = "SELECT CONCAT(FirstName,' ', MiddleName,' ', LastName) AS FullName,UserName FROM Personnel"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataSet()
            Dim dt_table As New DataTable()
            da.Fill(dt)
            da.Fill(dt_table)
            If dt_table.Rows.Count > 0 Then

                ComboBox1.DataSource = dt.Tables(0)
                ComboBox1.ValueMember = "UserName"
                ComboBox1.DisplayMember = "FullName"

            Else
                MsgBox("No Hold or New Data Found!", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        LoadReport(ComboBox1.SelectedValue.ToString())
        TotalNew(ComboBox1.SelectedValue.ToString())
        TotalPaid(ComboBox1.SelectedValue.ToString())
        TotalPaidCapl(ComboBox1.SelectedValue.ToString())
        TotalHold(ComboBox1.SelectedValue.ToString())
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox1.Text = ""
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")
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

    Private Sub TotalPaidCapl(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT (ISNULL(SUM(OriginalPrice),0) * ISNULL(SUM(Quantity),0))  AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT (ISNULL(SUM(OriginalPrice),0) * ISNULL(SUM(Quantity),0)) AS TotalAmount FROM vw_Transactions WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') "
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_Paid_Capl.Text = "P " + Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                Label_Paid_Capl.Text = "P 0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
End Class