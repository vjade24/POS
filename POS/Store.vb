Imports System.Data.SqlClient
Imports System.IO
Public Class Store
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim query As String = "SELECT TOP 1 * FROM Store where IsActive = '1'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim ms As New MemoryStream
            ProductImagePictureBox.Image.Save(ms, ProductImagePictureBox.Image.RawFormat)
            Dim command1 As New SqlCommand("update Store set StoreName =@StoreName,Slogan=@Slogan,Logo=@Logo,ThemeColor=@ThemeColor,TinNo=@TinNo,ContactNo=@ContactNo,IsActive=@IsActive,CreatedAt=@CreatedAt,CreatedBy=@CreatedBy,StoreAddress=@StoreAddress,ExpiryDate=@ExpiryDate WHERE Id =@Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
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
            command1.Parameters.Add("@ExpiryDate", SqlDbType.VarChar).Value = ExpiryDateDateTimePicker.Value.ToString().Trim()
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated Store Information!", MsgBoxStyle.Information)
                    'Me.Hide()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        Else
            Dim ms As New MemoryStream
            ProductImagePictureBox.Image.Save(ms, ProductImagePictureBox.Image.RawFormat)
            Dim command1 As New SqlCommand("insert into Store values (@StoreName,@Slogan,@Logo,@ThemeColor,@TinNo,@ContactNo,@IsActive,@CreatedAt,@CreatedBy,@StoreAddress,@ExpiryDate)", conn)
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
            command1.Parameters.Add("@ExpiryDate", SqlDbType.VarChar).Value = ExpiryDateDateTimePicker.Value.ToString().Trim()
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
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files(*.Jpg)|*.jpg;*.png;"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProductImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT TOP 1 * FROM Store where IsActive = '1'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            IdTextBox.Text = dt.Rows(0)("Id").ToString()
            StoreNameTextBox.Text = dt.Rows(0)("StoreName").ToString()
            SloganTextBox.Text = dt.Rows(0)("Slogan").ToString()
            ThemeColorComboBox.Text = dt.Rows(0)("ThemeColor").ToString()
            TinNoTextBox.Text = dt.Rows(0)("TinNo").ToString()
            ContactNoTextBox.Text = dt.Rows(0)("ContactNo").ToString()
            TextBox1.Text = dt.Rows(0)("StoreAddress").ToString()
            ExpiryDateDateTimePicker.Value = dt.Rows(0)("ExpiryDate").ToString()

            storeTheme = dt.Rows(0)("ThemeColor").ToString().Trim()
            Try
                Dim lb() As Byte = dt.Rows(0)("Logo")
                Dim lstr As New System.IO.MemoryStream(lb)
                ProductImagePictureBox.Image = Image.FromStream(lstr)
            Catch ex As Exception
                ProductImagePictureBox.Image = My.Resources._1
            End Try
        Else
            MsgBox("No Store Information!", MsgBoxStyle.Critical)
            Me.Hide()
        End If
    End Sub
End Class