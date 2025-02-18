Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.vw_Transactions_nologo' table. You can move, or remove it, as needed.
        Me.Vw_Transactions_nologoTableAdapter.Fill(Me.Pos_dbDataSet.vw_Transactions_nologo)

        Dashboard_Totals()
        Dashboard_Recent_Activities()
        Dashboard_Top_Selling()

        If user_type = "Admin" Then
            'TabControl1.TabPages.Remove(TabPage1)
            'TabControl1.SelectedTab = TabPage2
        Else
            TabControl1.TabPages.Remove(TabPage1)
            TabControl1.SelectedTab = TabPage2
        End If


    End Sub

    Private Sub Dashboard_Totals()
        If user_type = "Admin" Then
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
        Else
            Try
                Dim dt As New DataTable()
                Dim conn As SqlConnection = New SqlConnection(connection)
                Dim cmd As SqlCommand = New SqlCommand("sp_dashboard_not_admin", conn)
                cmd.Parameters.Add(New SqlParameter("@par_date", DateTime.Now))
                cmd.Parameters.Add(New SqlParameter("@par_createdby", user_login))
                cmd.CommandType = CommandType.StoredProcedure
                Dim adp As New SqlDataAdapter()
                adp.SelectCommand = cmd
                adp.Fill(dt)
                If dt.Rows.Count > 0 Then
                    'Label_total_income.Text = "P" + dt.Rows(0)("total_income").ToString()
                    'Label_total_income_today.Text = "P" + dt.Rows(0)("total_income_today").ToString()
                    Label_total_income.Text = "--"
                    Label_total_income_today.Text = "--"
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
        End If
    End Sub

    Private Sub Dashboard_Recent_Activities()
        Dim query As String
        If user_type = "Admin" Then
            query = "SELECT TOP 20 InvoiceNo,CustomerName,PaymentStatus,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions GROUP BY InvoiceNo,CustomerName,PaymentStatus ORDER BY InvoiceNo DESC"
        Else
            query = "SELECT TOP 20 InvoiceNo,CustomerName,PaymentStatus,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions WHERE CreatedBy = '" + user_login + "' GROUP BY InvoiceNo,CustomerName,PaymentStatus ORDER BY InvoiceNo DESC"
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
        If user_type = "Admin" Then
            query = "SELECT TOP 20 ProductCode,ProductName,SUM(Quantity) AS Quantity FROM vw_Transactions GROUP BY ProductCode,ProductName ORDER BY SUM(Quantity) DESC"
        Else
            query = "SELECT TOP 20 ProductCode,ProductName,SUM(Quantity) AS Quantity FROM vw_Transactions WHERE CreatedBy = '" + user_login + "' GROUP BY ProductCode,ProductName ORDER BY SUM(Quantity) DESC"
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

    Private Sub LoadChart_BarChart()
        With Chart3
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim query = "SELECT MONTH(CreatedAt) AS MonthNameInt,LEFT(DATENAME(MONTH, CreatedAt),3) AS MonthNameDesc,DATENAME(YEAR, CreatedAt) AS YearDesc,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions  WHERE PaymentStatus = 'Paid' GROUP BY MONTH(CreatedAt),DATENAME(MONTH, CreatedAt) ,DATENAME(YEAR, CreatedAt) ORDER BY MONTH(CreatedAt) ASC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim ds As New DataSet

            da.Fill(ds, "MonthNameDesc")
            Chart3.DataSource = ds.Tables("MonthNameDesc")
            Dim series1 As Series = Chart3.Series("Series1")
            'series1.ChartType = SeriesChartType.Bar
            series1.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
            series1.Color = Color.FromArgb(150, Color.Red)
            series1.BackSecondaryColor = Color.FromArgb(50, Color.Red)
            ' Disable X-axis gridlines
            Chart3.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            Chart3.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            ' Disable Y-axis gridlines
            Chart3.ChartAreas(0).AxisY.MajorGrid.Enabled = False
            Chart3.ChartAreas(0).AxisY.MinorGrid.Enabled = False
            'series1.Name = "TOTAL SOLD PER MONTH"

            With Chart3
                '.Series(0)("PieLabelStyle") = "Outside"
                '.Series(0).BorderWidth = 1
                '.Series(0).BorderColor = System.Drawing.Color.Red
                '.ChartAreas(0).Area3DStyle.Enable3D = True

                .Series(series1.Name).XValueMember = "MonthNameDesc"
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
    Private Sub LoadChart_BarChart_perday()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With
        Dim query = "SELECT TOP  7 FORMAT(CreatedAt,'MMM d, yy') AS DayDescr ,FORMAT(CreatedAt,'yyyy-MM-dd') AS DayDescr1,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' GROUP BY  FORMAT(CreatedAt,'MMM d, yy') ,FORMAT(CreatedAt,'yyyy-MM-dd')ORDER BY FORMAT(CreatedAt,'yyyy-MM-dd') ASC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim ds As New DataSet

            da.Fill(ds, "DayDescr")
            Chart1.DataSource = ds.Tables("DayDescr")
            Dim series1 As Series = Chart1.Series("Series1")
            series1.ChartType = SeriesChartType.SplineArea
            series1.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
            series1.Color = Color.FromArgb(250, Color.DodgerBlue)
            series1.BackSecondaryColor = Color.FromArgb(100, Color.DodgerBlue)
            ' Disable X-axis gridlines
            Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
            Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False

            ' Disable Y-axis gridlines
            'Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
            'Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = False
            'series1.Name = "TOTAL SOLD PER MONTH"

            With Chart1
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
    Dim colorMap As New Dictionary(Of String, Color) From {
        {"Hold", Color.Orange},
        {"New", Color.ForestGreen},
        {"Paid", Color.DodgerBlue},
        {"Return/Void", Color.Red}
    }
    Private Sub LoadChart_Donut()
        Dim query = "SELECT PaymentStatus, ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo GROUP BY PaymentStatus UNION SELECT 'Return/Void' AS PaymentStatus,ISNULL(SUM(ReturnVoidAmount),0) AS TotalAmount  FROM TransactionReturnVoid"
        Try
            Using conn As New SqlConnection(connection)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ' Clear existing series
                        Chart2.Series.Clear()

                        ' Create a new Doughnut series
                        Dim series As New Series("Payments")
                        series.ChartType = SeriesChartType.Doughnut

                        ' Read data from SQL query result
                        While reader.Read()
                            Dim status As String = reader("PaymentStatus").ToString()
                            Dim amount As Double = Convert.ToDouble(reader("TotalAmount"))
                            'series.Points.AddXY(status, amount)

                            Dim pointIndex As Integer = series.Points.AddXY(status, amount)

                            ' Apply color based on PaymentStatus
                            If colorMap.ContainsKey(status) Then
                                series.Points(pointIndex).Color = colorMap(status)
                            Else
                                series.Points(pointIndex).Color = Color.Gray ' Default color for unknown statuses
                            End If
                        End While

                        Chart2.Series.Add(series)

                        With Chart2
                            .Series(0)("PieLabelStyle") = "Outside"
                            .Legends(0).Docking = Docking.Bottom
                            .Series(0).BorderWidth = 1
                            '.Series(0).BorderColor = System.Drawing.Color.Red
                            .ChartAreas(0).Area3DStyle.Enable3D = True

                            .Series(0).LabelFormat = "{###,##0.00}"
                            .Series(0).IsValueShownAsLabel = True

                            .Series(0).LegendText = "#VALX (#PERCENT)"
                        End With

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        LoadChart_BarChart()
        LoadChart_BarChart_perday()
        LoadChart_Donut()
    End Sub
End Class