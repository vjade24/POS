
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
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
        TotalReturnVoid("")

        LoadPersonnel()
        ComboBox1.Text = ""
    End Sub
    Private Sub LoadReport(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT * FROM vw_Transactions_nologo WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "' AND ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' ORDER BY InvoiceNo DESC"
        Else
            query = "SELECT * FROM vw_Transactions_nologo WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' ORDER BY InvoiceNo DESC"
        End If

        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            CategoryDataGridView.DataSource = dt
            LoadChart_BarChart()
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
        TotalReturnVoid("")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")
        TotalReturnVoid("")
    End Sub

    Private Sub TotalNew(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'New' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'New' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
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
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') "
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
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Hold' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Hold' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "')"
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
        TotalReturnVoid(ComboBox1.SelectedValue.ToString())
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ComboBox1.Text = ""
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalHold("")
        TotalReturnVoid("")
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
            query = "SELECT ISNULL(SUM(ISNULL(OriginalPrice,0) * ISNULL(Quantity,0)),0)  AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(ISNULL(OriginalPrice,0) * ISNULL(Quantity,0)),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') "
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
    Private Sub TotalReturnVoid(CreatedBy)
        Dim query As String
        If CreatedBy.ToString.Trim IsNot "" Then
            query = "SELECT ISNULL(SUM(ReturnVoidAmount),0) AS TotalAmount FROM TransactionReturnVoid WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND  CreatedBy = '" + CreatedBy.ToString.Trim() + "'"
        Else
            query = "SELECT ISNULL(SUM(ReturnVoidAmount),0) AS TotalAmount FROM TransactionReturnVoid WHERE CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') "
        End If
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label_ReturnVoid.Text = "P " + Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                Label_ReturnVoid.Text = "P 0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        LoadReport("")
        TotalNew("")
        TotalPaid("")
        TotalPaidCapl("")
        TotalReturnVoid("")
        TotalHold("")
    End Sub
    Private Sub LoadChart_BarChart()
        With Chart2
            .Series.Clear()
            .Series.Add("Series1")
        End With

        'Dim query = "SELECT MONTH(CreatedAt) AS MonthNameInt,DATENAME(MONTH, CreatedAt) AS MonthNameDesc,DATENAME(YEAR, CreatedAt) AS YearDesc,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions  WHERE PaymentStatus = 'Paid' GROUP BY MONTH(CreatedAt),DATENAME(MONTH, CreatedAt) ,DATENAME(YEAR, CreatedAt) ORDER BY MONTH(CreatedAt) ASC"
        Dim query = "SELECT TOP  7 FORMAT(CreatedAt,'MMM dd, yyyy') AS DayDescr ,FORMAT(CreatedAt,'yyyy-MM-dd') AS DayDescr1,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' GROUP BY  FORMAT(CreatedAt,'MMM dd, yyyy') ,FORMAT(CreatedAt,'yyyy-MM-dd')ORDER BY FORMAT(CreatedAt,'yyyy-MM-dd') ASC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim ds As New DataSet

            da.Fill(ds, "DayDescr")
            Chart2.DataSource = ds.Tables("DayDescr")
            Dim series1 As Series = Chart2.Series("Series1")
            'series1.ChartType = SeriesChartType.Bar
            'series1.Name = "TOTAL SOLD PER MONTH"

            With Chart2
                '.Series(0)("PieLabelStyle") = "Outside"
                '.Series(0).BorderWidth = 1
                '.Series(0).BorderColor = System.Drawing.Color.Red
                '.ChartAreas(0).Area3DStyle.Enable3D = True

                .Series(series1.Name).XValueMember = "DayDescr"
                .Series(series1.Name).YValueMembers = "TotalAmount"

                .Series(0).LabelFormat = "{###,##0.00}"
                .Series(0).IsValueShownAsLabel = True

                '.Series(0).LegendText = "#VALX (#PERCENT)"
            End With

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub IconButtonPrint_Click(sender As Object, e As EventArgs) Handles IconButtonPrint.Click
        'If TotalAmount.Text = "0.00" Then
        '    MsgBox("NO TOTAL AMOUNT", MsgBoxStyle.Information)
        'Else
        Dim OBJ As New ReportViewer
            OBJ.StringReportFile = "cryRemittanceDetails"
        OBJ.StringQuery = "SELECT * FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') ORDER BY CreatedAt DESC"
        OBJ.Show()
        'End If
    End Sub
End Class