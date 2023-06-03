Imports System.Data.SqlClient
Public Class Supplier
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Supplier"
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
        Dim query = "SELECT * FROM Supplier WHERE SupplierName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, CategoryDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LblAddEditMode.Text = "(Create new Record)"
        IdTextBox.Text = ""
        SupplierNameTextBox.Text = ""
        ContactNoTextBox.Text = ""
        AddressTextBox.Text = ""
        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        IdTextBox.Text = GetLastRow("Supplier", "Id")

    End Sub
    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        IdTextBox.Text = ""
        SupplierNameTextBox.Text = ""
        ContactNoTextBox.Text = ""
        AddressTextBox.Text = ""

        IdTextBox.Text = CategoryDataGridView.CurrentRow.Cells(0).Value.ToString()
        SupplierNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        ContactNoTextBox.Text = CategoryDataGridView.CurrentRow.Cells(2).Value.ToString()
        AddressTextBox.Text = CategoryDataGridView.CurrentRow.Cells(3).Value.ToString()

    End Sub

    Private Sub ClearEntry()
        IdTextBox.Text = ""
        SupplierNameTextBox.Text = ""
        ContactNoTextBox.Text = ""
        AddressTextBox.Text = ""
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record (" + CategoryDataGridView.CurrentRow.Cells(0).Value.ToString() + ")", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try
                Dim command1 As New SqlCommand("delete Supplier where Id = @Id", conn)
                command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
                Try
                    conn.Open()
                    result = command1.ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("No Data Deleted!", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                    conn.Close()
                End Try

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
        RefreshData()
        ClearEntry()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim formMain As New Main
        If LblAddEditMode.Text = "(Create new Record)" Then
            Dim command1 As New SqlCommand("insert into Supplier values (@SupplierName,@ContactNo,@Address,@CreatedAt,@CreatedBy)", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = ContactNoTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Address", SqlDbType.VarChar).Value = AddressTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = formMain.TextBoxRight.Text
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                    RefreshData()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        ElseIf LblAddEditMode.Text = "(Update existing Record)" Then

            Dim command1 As New SqlCommand("update Supplier set SupplierName= @SupplierName,ContactNo =@ContactNo,Address=@Address where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = ContactNoTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Address", SqlDbType.VarChar).Value = AddressTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = formMain.TextBoxRight.Text
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    RefreshData()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If

    End Sub
End Class