Imports System.Data.SqlClient
Public Class Personnel
    Private Sub Personnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Personnel"
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
        Dim query = "SELECT * FROM Personnel WHERE BrandName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, CategoryDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LblAddEditMode.Text = "(Create new Record)"
        IdTextBox.Text = ""
        TypeComboBox.Text = ""
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        BirthDateDateTimePicker.ResetText()
        AddressTextBox1.Text = ""
        ContactNoTextBox1.Text = ""
        UserNameTextBox.Text = ""
        PasswordTextBox.Text = ""
        IsActiveCheckBox.Checked = False

        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        IdTextBox.Text = GetLastRow("Personnel", "Id")

    End Sub
    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        IdTextBox.Text = ""
        TypeComboBox.Text = ""
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        BirthDateDateTimePicker.Text = ""
        AddressTextBox1.Text = ""
        ContactNoTextBox1.Text = ""
        UserNameTextBox.Text = ""
        PasswordTextBox.Text = ""
        IsActiveCheckBox.Checked = False

        IdTextBox.Text = CategoryDataGridView.CurrentRow.Cells(0).Value.ToString()
        TypeComboBox.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        FirstNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(2).Value.ToString()
        LastNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(3).Value.ToString()
        MiddleNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(4).Value.ToString()
        BirthDateDateTimePicker.Value = DateTime.Parse(CategoryDataGridView.CurrentRow.Cells(5).Value.ToString())
        AddressTextBox1.Text = CategoryDataGridView.CurrentRow.Cells(6).Value.ToString()
        ContactNoTextBox1.Text = CategoryDataGridView.CurrentRow.Cells(7).Value.ToString()
        UserNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(8).Value.ToString()
        PasswordTextBox.Text = CategoryDataGridView.CurrentRow.Cells(9).Value.ToString()
        IsActiveCheckBox.Checked = Boolean.Parse(CategoryDataGridView.CurrentRow.Cells(10).Value.ToString())

    End Sub

    Private Sub ClearEntry()
        IdTextBox.Text = ""
        TypeComboBox.Text = ""
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        MiddleNameTextBox.Text = ""
        BirthDateDateTimePicker.ResetText()
        AddressTextBox1.Text = ""
        ContactNoTextBox1.Text = ""
        UserNameTextBox.Text = ""
        PasswordTextBox.Text = ""
        IsActiveCheckBox.Checked = False

        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record (" + CategoryDataGridView.CurrentRow.Cells(0).Value.ToString() + ")", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try
                Dim command1 As New SqlCommand("delete Personnel where Id = @Id", conn)
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

        If LblAddEditMode.Text = "(Create new Record)" Then
            Dim command1 As New SqlCommand("insert into Personnel values (@Type,@FirstName,@LastName,@MiddleName,@BirthDate,@Address,@ContactNo,@UserName,@Password,@IsActive,@CreatedAt,@CreatedBy)", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Type", SqlDbType.VarChar).Value = TypeComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = BirthDateDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@Address", SqlDbType.VarChar).Value = AddressTextBox1.Text.ToString().Trim()
            command1.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = ContactNoTextBox1.Text.ToString().Trim()
            command1.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsActive", SqlDbType.VarChar).Value = IsActiveCheckBox.Checked
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
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
            Dim command1 As New SqlCommand("update Personnel set Type = @Type,FirstName = @FirstName,LastName=@LastName,MiddleName=@MiddleName,BirthDate=@BirthDate,Address=@Address,ContactNo=@ContactNo,UserName=@UserName,Password=@Password,IsActive=@IsActive where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Type", SqlDbType.VarChar).Value = TypeComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = BirthDateDateTimePicker.Value.ToString().Trim()
            command1.Parameters.Add("@Address", SqlDbType.VarChar).Value = AddressTextBox1.Text.ToString().Trim()
            command1.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = ContactNoTextBox1.Text.ToString().Trim()
            command1.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsActive", SqlDbType.VarChar).Value = IsActiveCheckBox.Checked
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
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