Imports System.Data.SqlClient

Public Class Login

    Public Sub StoreInfo()
        Dim query As String = "SELECT TOP 1 * FROM Store where IsActive = '1'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            StoreNameTextBox.Text = dt.Rows(0)("StoreName").ToString()
            StoreNameTextBox.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            SloganTextBox.Text = dt.Rows(0)("Slogan").ToString()
            SloganTextBox.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            PanelRight.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnLogin.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            Try
                Dim lb() As Byte = dt.Rows(0)("Logo")
                Dim lstr As New System.IO.MemoryStream(lb)
                LogoPictureBox.Image = Image.FromStream(lstr)
            Catch ex As Exception
                LogoPictureBox.Image = My.Resources._1
            End Try
        Else
            MsgBox("No Store Information!", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StoreInfo()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim query As String = "SELECT TOP 1 * FROM Personnel where UserName = '" + UserNameTextBox.Text.ToString().Trim() + "' and Password = '" + PasswordTextBox.Text.ToString.Trim() + "'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If UserNameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("User name and Password is Required!", MsgBoxStyle.Critical)
        Else
            If dt.Rows.Count > 0 Then

                If dt.Rows(0)("IsActive") = "0" Then
                    MsgBox("This User is Inactive Already!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Welcome, " + dt.Rows(0)("FirstName") + " " + dt.Rows(0)("LastName") + " as " + dt.Rows(0)("Type") + "!", MsgBoxStyle.Information)
                    Main.TextBoxRight.Text = dt.Rows(0)("FirstName")
                    UserNameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Main.Show()
                End If

            Else
                MsgBox("No User Found!", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

End Class