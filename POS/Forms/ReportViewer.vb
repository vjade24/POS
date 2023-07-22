
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports CrystalDecisions
Imports System.IO
Public Class ReportViewer
    Public Property StringQuery As String
    Public Property StringReportFile As String
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As New DataTable()
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(StringQuery, conn)
            'cmd.CommandType = CommandType.StoredProcedure
            Dim adp As New SqlDataAdapter()
            adp.SelectCommand = cmd
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim cryRpt As New ReportDocument
                Dim report_path As String = Path.Combine(Application.StartupPath, StringReportFile + ".rpt").Replace("bin\Debug", "\Reports").Replace("bin\Release", "\Reports")

                cryRpt.Load(report_path)
                cryRpt.SetDataSource(dt)
                CrystalReportViewer1.Zoom(75)
                CrystalReportViewer1.ReportSource = cryRpt
                CrystalReportViewer1.Refresh()
            Else
                MsgBox("NO DATA FOUND!", MsgBoxStyle.Exclamation)
                Me.Hide()
                'Dim cryRpt As New ReportDocument
                'CrystalReportViewer1.ReportSource = cryRpt
                'CrystalReportViewer1.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString().Trim(), MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class