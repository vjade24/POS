Imports System.Data.SqlClient
Public Class CategoryCRUD
    Dim conn As SqlConnection = New SqlConnection(connection)
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Result As Boolean
        Dim command1 As New SqlCommand("insert into Category values (@CategoryName,@CreatedAt,@CreatedBy)", conn)
        command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = DateTime.Now
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Admin"
        Try
            conn.Open()
            Result = command1.ExecuteNonQuery()
            If Result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                Clearentry()

                Me.Close()
                Me.Dispose()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try

        Category.RefreshData()
        Category.Label1.Text = "aasdasdasd"

    End Sub

    Private Sub Clearentry()
        CategoryNameTextBox.Text = ""
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub IdLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged

    End Sub

    Private Sub CategoryNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryNameTextBox.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

    End Sub
End Class