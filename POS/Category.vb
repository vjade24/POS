Imports System.Data.SqlClient
Public Class Category
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.Category' table. You can move, or remove it, as needed.
        'Me.CategoryTableAdapter.Fill(Me.Pos_dbDataSet.Category)
        RefreshData()
    End Sub
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Category"
        'CommonQuery(query, CategoryDataGridView)

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

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim query = "SELECT * FROM Category WHERE CategoryName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, CategoryDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim form As New CategoryCRUD
        form.lblHeader.Text = "Create new Record"
        form.ShowDialog()
    End Sub
End Class