Imports System.Data.SqlClient

Public Class Main

    Public Sub StoreInfo()
        Dim query As String = "SELECT TOP 1 * FROM Store where IsActive = '1'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            PanelSide.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            PanelTop.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            StoreNameTextBox.Text = dt.Rows(0)("StoreName").ToString()
            StoreNameTextBox.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            TextBoxRight.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())

            BtnDashBoard.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnPOS.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnProducts.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnCategory.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnBrand.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnReports.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnAnalytics.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnPersonnel.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())
            BtnSupplier.BackColor = ColorTranslator.FromHtml(dt.Rows(0)("ThemeColor").ToString())

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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StoreInfo()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub


    'Fields'
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Sub ActiveButton(senderBtn As Object, customColor As Color)
        DisableButton()
        currentBtn = CType(senderBtn, Button)
        currentBtn.BackColor = Color.FromArgb(31, 30, 68)
        currentBtn.ForeColor = customColor
        IconPictureBoxTop.IconChar = senderBtn.IconChar
    End Sub

    'Public Sub ActiveButtonOnGrid(senderBtn As Object, customColor As Color)
    '    DisableButton()
    '    currentBtn = CType(senderBtn, Button)
    '    currentBtn.BackColor = Color.FromArgb(31, 30, 68)
    '    currentBtn.ForeColor = customColor
    '    IconPictureBoxTop.IconChar = senderBtn.IconChar
    'End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = ColorTranslator.FromHtml(storeTheme)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub BtnDashBoard_Click(sender As Object, e As EventArgs) Handles BtnDashBoard.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Dashboard, "")
    End Sub

    Private Sub BtnPOS_Click(sender As Object, e As EventArgs) Handles BtnPOS.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New PointOfSale, "Point of Sale")
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Products, "")
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles BtnCategory.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Category, "")
    End Sub

    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles BtnBrand.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Brand, "")
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Reports, "")
    End Sub

    Private Sub BtnAnalytics_Click(sender As Object, e As EventArgs) Handles BtnAnalytics.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Analytics, "")
    End Sub

    Private Sub BtnPersonnel_Click(sender As Object, e As EventArgs) Handles BtnPersonnel.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Personnel, "")
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        ActiveButton(sender, RGBColors.color1)
        OpenChildForm(New Supplier, "")
    End Sub

    Public Structure RGBColors
        Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
        Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
        Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure

    Public Sub OpenChildForm(childForm As Form, breadcrumpText As String)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(childForm)
        PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        If (breadcrumpText = "") Then
            LblBreadCrump.Text = childForm.Text
        Else
            LblBreadCrump.Text = breadcrumpText
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class