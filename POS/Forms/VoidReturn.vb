Imports System.Data.SqlClient
Public Class VoidReturn
    Private Sub VoidReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.vw_Transactions_nologo' table. You can move, or remove it, as needed.
        'Me.Vw_Transactions_nologoTableAdapter.Fill(Me.Pos_dbDataSet.vw_Transactions_nologo)
        LoadReport()
    End Sub
    Private Sub LoadReport()
        Dim query As String
        query = "SELECT * FROM vw_Transactions_nologo WHERE PaymentStatus='Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' ORDER BY InvoiceNo DESC"
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
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport()
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        LoadReport()
    End Sub
End Class