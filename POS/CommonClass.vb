Imports System.Data.SqlClient
Module CommonClass

    Public connection = My.Settings.pos_dbConnectionString

    'Public StoreName = "Vincent Jade Alivio Production"
    'Public StoreNameColor = Color.DodgerBlue
    'Public SloganColor = Color.DodgerBlue
    'Public PanelRightColor = Color.DodgerBlue
    'Public Slogan = "Fix before Up"
    'Public LogoPictureBoxPic = My.Resources._1

    Public Sub CommonQuery(query, DataGridView)
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

End Module
