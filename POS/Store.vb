Imports System.Data.SqlClient
Imports System.IO
Public Class Store
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim ms As New MemoryStream
        ProductImagePictureBox.Image.Save(ms, ProductImagePictureBox.Image.RawFormat)
        Dim command1 As New SqlCommand("insert into Store values (@StoreName,@Slogan,@Logo,@ThemeColor,@TinNo,@ContactNo,@IsActive,@CreatedAt,@CreatedBy,@StoreAddress)", conn)
        command1.Parameters.Add("@StoreName", SqlDbType.VarChar).Value = StoreNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@Slogan", SqlDbType.VarChar).Value = SloganTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@Logo", SqlDbType.Image).Value = ms.ToArray
        command1.Parameters.Add("@ThemeColor", SqlDbType.VarChar).Value = ThemeColorComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@TinNo", SqlDbType.VarChar).Value = TinNoTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = ContactNoTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@IsActive", SqlDbType.VarChar).Value = "1"
        command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Admin"
        command1.Parameters.Add("@StoreAddress", SqlDbType.VarChar).Value = TextBox1.Text.ToString().Trim()
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Added Store Information!", MsgBoxStyle.Information)
                Me.Hide()

                Dim lgin As New Login
                lgin.Show()

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files(*.Jpg)|*.jpg;*.png;"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProductImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class