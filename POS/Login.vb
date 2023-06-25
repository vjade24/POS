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
            If DateTime.Now > DateTime.Parse(dt.Rows(0)("ExpiryDate").ToString()) Then
                MsgBox("Application Expired, Please contact Administrator", MsgBoxStyle.Critical)
                Me.Close()
            Else
                StoreNameTextBox.Text = dt.Rows(0)("StoreName").ToString()
                StoreNameTextBox.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
                SloganTextBox.Text = dt.Rows(0)("Slogan").ToString()
                SloganTextBox.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
                PanelRight.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
                BtnLogin.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())

                storeTheme = dt.Rows(0)("ThemeColor").ToString().Trim()

                Try
                    Dim lb() As Byte = dt.Rows(0)("Logo")
                    Dim lstr As New System.IO.MemoryStream(lb)
                    LogoPictureBox.Image = Image.FromStream(lstr)
                Catch ex As Exception
                    LogoPictureBox.Image = My.Resources._1
                End Try
            End If

        Else
            MsgBox("No Store Information!", MsgBoxStyle.Critical)
            Me.Hide()
            Store.ShowDialog()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StoreInfo()
        UserNameTextBox.Select()
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

    Private Sub BtnLogin_Click_1(sender As Object, e As EventArgs) Handles BtnLogin.Click
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
                    UserNameTextBox.Text = ""
                    PasswordTextBox.Text = ""

                    Dim formMain As New Main
                    formMain.TextBoxRight.Text = dt.Rows(0)("FirstName")

                    formMain.ActiveButton(sender, Color.FromArgb(172, 126, 241))
                    formMain.OpenChildForm(New Dashboard, "")

                    user_login = dt.Rows(0)("UserName").ToString().Trim()

                    If dt.Rows(0)("Type").ToString.Trim() = "Admin" Then
                        formMain.BtnDashBoard.Visible = True
                        formMain.BtnPOS.Visible = True
                        formMain.BtnProducts.Visible = True
                        formMain.BtnCategory.Visible = True
                        formMain.BtnBrand.Visible = True
                        formMain.BtnReports.Visible = True
                        formMain.BtnAnalytics.Visible = True
                        formMain.BtnPersonnel.Visible = True
                        formMain.BtnSupplier.Visible = True
                        formMain.BtnStoreInfo.Visible = False

                        If dt.Rows(0)("UserName").ToString().Trim() = "vja" Then
                            formMain.BtnStoreInfo.Visible = True
                        End If


                    ElseIf dt.Rows(0)("Type").ToString.Trim() = "Cashier" Then
                            formMain.BtnDashBoard.Visible = True
                            formMain.BtnPOS.Visible = True
                            formMain.BtnProducts.Visible = False
                            formMain.BtnCategory.Visible = False
                            formMain.BtnBrand.Visible = False
                            formMain.BtnReports.Visible = True
                            formMain.BtnAnalytics.Visible = False
                            formMain.BtnPersonnel.Visible = False
                            formMain.BtnSupplier.Visible = False
                            formMain.BtnStoreInfo.Visible = False
                        Else
                            formMain.BtnDashBoard.Visible = False
                        formMain.BtnPOS.Visible = False
                        formMain.BtnProducts.Visible = False
                        formMain.BtnCategory.Visible = False
                        formMain.BtnBrand.Visible = False
                        formMain.BtnReports.Visible = False
                        formMain.BtnAnalytics.Visible = False
                        formMain.BtnPersonnel.Visible = False
                        formMain.BtnSupplier.Visible = False
                        formMain.BtnStoreInfo.Visible = False
                    End If

                    formMain.Show()
                    Me.Hide()
                End If

            Else
                MsgBox("No User Found!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

End Class