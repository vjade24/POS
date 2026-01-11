<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.SloganTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnLogin = New FontAwesome.Sharp.IconButton()
        UserNameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(155, 230)
        UserNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(79, 16)
        UserNameLabel.TabIndex = 7
        UserNameLabel.Text = "User Name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(155, 281)
        PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(70, 16)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Password:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label1.Location = New System.Drawing.Point(216, 28)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 20)
        Label1.TabIndex = 18
        Label1.Text = "Login"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label2.Location = New System.Drawing.Point(88, 187)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(367, 20)
        Label2.TabIndex = 20
        Label2.Text = "POINT OF SALE AND INVENTORY SYSTEM"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label3.Location = New System.Drawing.Point(375, 453)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 12)
        Label3.TabIndex = 21
        Label3.Text = "VJA Productions"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label4.Location = New System.Drawing.Point(390, 440)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(66, 12)
        Label4.TabIndex = 22
        Label4.Text = "POWERED BY"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(111, 96)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(200, 204)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 6
        Me.LogoPictureBox.TabStop = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(156, 251)
        Me.UserNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(170, 26)
        Me.UserNameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(155, 302)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(170, 26)
        Me.PasswordTextBox.TabIndex = 2
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StoreNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreNameTextBox.ForeColor = System.Drawing.Color.White
        Me.StoreNameTextBox.Location = New System.Drawing.Point(19, 302)
        Me.StoreNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StoreNameTextBox.Multiline = True
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.ReadOnly = True
        Me.StoreNameTextBox.Size = New System.Drawing.Size(384, 53)
        Me.StoreNameTextBox.TabIndex = 12
        Me.StoreNameTextBox.TabStop = False
        Me.StoreNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SloganTextBox
        '
        Me.SloganTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SloganTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SloganTextBox.ForeColor = System.Drawing.Color.White
        Me.SloganTextBox.Location = New System.Drawing.Point(19, 351)
        Me.SloganTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SloganTextBox.Name = "SloganTextBox"
        Me.SloganTextBox.ReadOnly = True
        Me.SloganTextBox.Size = New System.Drawing.Size(384, 15)
        Me.SloganTextBox.TabIndex = 13
        Me.SloganTextBox.TabStop = False
        Me.SloganTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(158, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.LogoPictureBox)
        Me.PanelRight.Controls.Add(Me.StoreNameTextBox)
        Me.PanelRight.Controls.Add(Me.SloganTextBox)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(424, 508)
        Me.PanelRight.TabIndex = 15
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(302, 308)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(424, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 33)
        Me.Panel1.TabIndex = 19
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(470, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(33, 33)
        Me.BtnClose.TabIndex = 20
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.BtnLogin)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Me.UserNameTextBox)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(UserNameLabel)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(PasswordLabel)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(424, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 475)
        Me.Panel2.TabIndex = 21
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.BtnLogin.IconColor = System.Drawing.Color.White
        Me.BtnLogin.IconSize = 30
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.Location = New System.Drawing.Point(155, 347)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Padding = New System.Windows.Forms.Padding(40, 0, 0, 0)
        Me.BtnLogin.Rotation = 0R
        Me.BtnLogin.Size = New System.Drawing.Size(170, 39)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelRight)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.PanelRight.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents SloganTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRight As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLogin As FontAwesome.Sharp.IconButton
End Class
