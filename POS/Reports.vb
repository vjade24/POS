Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChart()
    End Sub

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
End Class