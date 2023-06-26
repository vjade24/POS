﻿
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Analytics
    Private Sub Analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Analytics_SoldByMonth()
        LoadChart()
        LoadChart_BarChart()
    End Sub

    'Private Sub Analytics_SoldByMonth()
    '    Try
    '        Using dt As New DataTable()
    '            Using conn As SqlConnection = New SqlConnection(connection)
    '                Using cmd As SqlCommand = New SqlCommand("select * from vw_Transactions ORDER BY ProductName", conn)
    '                    Using adp As New SqlDataAdapter()
    '                        adp.SelectCommand = cmd
    '                        adp.Fill(dt)
    '                        If dt.Rows.Count > 0 Then
    '                            Dim cryRpt As New ReportDocument
    '                            Dim report_path As String = Path.Combine(Application.StartupPath, "cryAnalytics_SoldByMonth.rpt").Replace("bin\Debug", "\Reports").Replace("bin\Release", "\Reports")
    '                            cryRpt.Load(report_path)
    '                            cryRpt.SetDataSource(dt)
    '                            CrystalReportViewer1.ReportSource = cryRpt
    '                            CrystalReportViewer1.Zoom(100)
    '                            CrystalReportViewer1.Refresh()

    '                        Else
    '                            MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
    '                            Dim cryRpt As New ReportDocument
    '                            'CrystalReportViewer1.ReportSource = cryRpt
    '                            'CrystalReportViewer1.Refresh()
    '                        End If
    '                    End Using
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub

    Private Sub LoadChart()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim query = "SELECT ProductCode,ProductName,SUM(Quantity) AS Quantity FROM vw_Transactions GROUP BY ProductCode,ProductName ORDER BY SUM(Quantity) DESC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim ds As New DataSet

            da.Fill(ds, "ProductName")
            Chart1.DataSource = ds.Tables("ProductName")
            Dim series1 As Series = Chart1.Series("Series1")
            series1.ChartType = SeriesChartType.Pie
            series1.Name = "Test Name"

            With Chart1
                .Series(0)("PieLabelStyle") = "Outside"
                .Series(0).BorderWidth = 1
                '.Series(0).BorderColor = System.Drawing.Color.Red
                .ChartAreas(0).Area3DStyle.Enable3D = True

                .Series(series1.Name).XValueMember = "ProductName"
                .Series(series1.Name).YValueMembers = "Quantity"

                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).IsValueShownAsLabel = True

                .Series(0).LegendText = "#VALX (#PERCENT)"
            End With

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub LoadChart_BarChart()
        With Chart2
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim query = "SELECT MONTH(CreatedAt) AS MonthNameInt,DATENAME(MONTH, CreatedAt) AS MonthNameDesc,DATENAME(YEAR, CreatedAt) AS YearDesc,SUM(TotalAmount) AS TotalAmount FROM vw_Transactions GROUP BY MONTH(CreatedAt),DATENAME(MONTH, CreatedAt) ,DATENAME(YEAR, CreatedAt) ORDER BY MONTH(CreatedAt) ASC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim ds As New DataSet

            da.Fill(ds, "MonthNameDesc")
            Chart2.DataSource = ds.Tables("MonthNameDesc")
            Dim series1 As Series = Chart2.Series("Series1")
            'series1.ChartType = SeriesChartType.Bar
            'series1.Name = "TOTAL SOLD PER MONTH"

            With Chart2
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
End Class