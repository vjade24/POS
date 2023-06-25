<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelSide = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnStoreInfo = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BtnSupplier = New FontAwesome.Sharp.IconButton()
        Me.BtnPersonnel = New FontAwesome.Sharp.IconButton()
        Me.BtnAnalytics = New FontAwesome.Sharp.IconButton()
        Me.BtnReports = New FontAwesome.Sharp.IconButton()
        Me.BtnBrand = New FontAwesome.Sharp.IconButton()
        Me.BtnCategory = New FontAwesome.Sharp.IconButton()
        Me.BtnProducts = New FontAwesome.Sharp.IconButton()
        Me.BtnPOS = New FontAwesome.Sharp.IconButton()
        Me.BtnDashBoard = New FontAwesome.Sharp.IconButton()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.TextBoxRight = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconPictureBoxTop = New FontAwesome.Sharp.IconPictureBox()
        Me.LblBreadCrump = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PanelSide.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconPictureBoxTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSide
        '
        Me.PanelSide.Controls.Add(Me.Panel2)
        Me.PanelSide.Controls.Add(Me.Panel1)
        Me.PanelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSide.Location = New System.Drawing.Point(0, 0)
        Me.PanelSide.Name = "PanelSide"
        Me.PanelSide.Size = New System.Drawing.Size(267, 732)
        Me.PanelSide.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LogoPictureBox)
        Me.Panel2.Controls.Add(Me.StoreNameTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 170)
        Me.Panel2.TabIndex = 16
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.POS.My.Resources.Resources._1
        Me.LogoPictureBox.Location = New System.Drawing.Point(72, 13)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(129, 128)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 14
        Me.LogoPictureBox.TabStop = False
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StoreNameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreNameTextBox.ForeColor = System.Drawing.Color.White
        Me.StoreNameTextBox.Location = New System.Drawing.Point(0, 143)
        Me.StoreNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StoreNameTextBox.Multiline = True
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.ReadOnly = True
        Me.StoreNameTextBox.Size = New System.Drawing.Size(267, 35)
        Me.StoreNameTextBox.TabIndex = 15
        Me.StoreNameTextBox.TabStop = False
        Me.StoreNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnStoreInfo)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.BtnSupplier)
        Me.Panel1.Controls.Add(Me.BtnPersonnel)
        Me.Panel1.Controls.Add(Me.BtnAnalytics)
        Me.Panel1.Controls.Add(Me.BtnReports)
        Me.Panel1.Controls.Add(Me.BtnBrand)
        Me.Panel1.Controls.Add(Me.BtnCategory)
        Me.Panel1.Controls.Add(Me.BtnProducts)
        Me.Panel1.Controls.Add(Me.BtnPOS)
        Me.Panel1.Controls.Add(Me.BtnDashBoard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 560)
        Me.Panel1.TabIndex = 2
        '
        'BtnStoreInfo
        '
        Me.BtnStoreInfo.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnStoreInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnStoreInfo.FlatAppearance.BorderSize = 0
        Me.BtnStoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStoreInfo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnStoreInfo.ForeColor = System.Drawing.Color.White
        Me.BtnStoreInfo.IconChar = FontAwesome.Sharp.IconChar.Inbox
        Me.BtnStoreInfo.IconColor = System.Drawing.Color.White
        Me.BtnStoreInfo.IconSize = 30
        Me.BtnStoreInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStoreInfo.Location = New System.Drawing.Point(0, 450)
        Me.BtnStoreInfo.Name = "BtnStoreInfo"
        Me.BtnStoreInfo.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnStoreInfo.Rotation = 0R
        Me.BtnStoreInfo.Size = New System.Drawing.Size(267, 50)
        Me.BtnStoreInfo.TabIndex = 22
        Me.BtnStoreInfo.Text = "Store Info"
        Me.BtnStoreInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStoreInfo.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.Control
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton1.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 507)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(267, 53)
        Me.IconButton1.TabIndex = 21
        Me.IconButton1.Text = "Logout"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'BtnSupplier
        '
        Me.BtnSupplier.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSupplier.FlatAppearance.BorderSize = 0
        Me.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplier.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSupplier.ForeColor = System.Drawing.Color.White
        Me.BtnSupplier.IconChar = FontAwesome.Sharp.IconChar.User
        Me.BtnSupplier.IconColor = System.Drawing.Color.White
        Me.BtnSupplier.IconSize = 30
        Me.BtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSupplier.Location = New System.Drawing.Point(0, 400)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnSupplier.Rotation = 0R
        Me.BtnSupplier.Size = New System.Drawing.Size(267, 50)
        Me.BtnSupplier.TabIndex = 20
        Me.BtnSupplier.Text = "Supplier"
        Me.BtnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSupplier.UseVisualStyleBackColor = False
        '
        'BtnPersonnel
        '
        Me.BtnPersonnel.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPersonnel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPersonnel.FlatAppearance.BorderSize = 0
        Me.BtnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPersonnel.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnPersonnel.ForeColor = System.Drawing.Color.White
        Me.BtnPersonnel.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.BtnPersonnel.IconColor = System.Drawing.Color.White
        Me.BtnPersonnel.IconSize = 30
        Me.BtnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPersonnel.Location = New System.Drawing.Point(0, 350)
        Me.BtnPersonnel.Name = "BtnPersonnel"
        Me.BtnPersonnel.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnPersonnel.Rotation = 0R
        Me.BtnPersonnel.Size = New System.Drawing.Size(267, 50)
        Me.BtnPersonnel.TabIndex = 19
        Me.BtnPersonnel.Text = "Personnel"
        Me.BtnPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPersonnel.UseVisualStyleBackColor = False
        '
        'BtnAnalytics
        '
        Me.BtnAnalytics.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnAnalytics.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAnalytics.FlatAppearance.BorderSize = 0
        Me.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnalytics.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAnalytics.ForeColor = System.Drawing.Color.White
        Me.BtnAnalytics.IconChar = FontAwesome.Sharp.IconChar.Signal
        Me.BtnAnalytics.IconColor = System.Drawing.Color.White
        Me.BtnAnalytics.IconSize = 30
        Me.BtnAnalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnalytics.Location = New System.Drawing.Point(0, 300)
        Me.BtnAnalytics.Name = "BtnAnalytics"
        Me.BtnAnalytics.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnAnalytics.Rotation = 0R
        Me.BtnAnalytics.Size = New System.Drawing.Size(267, 50)
        Me.BtnAnalytics.TabIndex = 18
        Me.BtnAnalytics.Text = "Analytics"
        Me.BtnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAnalytics.UseVisualStyleBackColor = False
        '
        'BtnReports
        '
        Me.BtnReports.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReports.FlatAppearance.BorderSize = 0
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.IconChar = FontAwesome.Sharp.IconChar.File
        Me.BtnReports.IconColor = System.Drawing.Color.White
        Me.BtnReports.IconSize = 30
        Me.BtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReports.Location = New System.Drawing.Point(0, 250)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnReports.Rotation = 0R
        Me.BtnReports.Size = New System.Drawing.Size(267, 50)
        Me.BtnReports.TabIndex = 17
        Me.BtnReports.Text = "Reports"
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReports.UseVisualStyleBackColor = False
        '
        'BtnBrand
        '
        Me.BtnBrand.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBrand.FlatAppearance.BorderSize = 0
        Me.BtnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrand.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnBrand.ForeColor = System.Drawing.Color.White
        Me.BtnBrand.IconChar = FontAwesome.Sharp.IconChar.FolderOpen
        Me.BtnBrand.IconColor = System.Drawing.Color.White
        Me.BtnBrand.IconSize = 30
        Me.BtnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrand.Location = New System.Drawing.Point(0, 200)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnBrand.Rotation = 0R
        Me.BtnBrand.Size = New System.Drawing.Size(267, 50)
        Me.BtnBrand.TabIndex = 16
        Me.BtnBrand.Text = "Brand"
        Me.BtnBrand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBrand.UseVisualStyleBackColor = False
        '
        'BtnCategory
        '
        Me.BtnCategory.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCategory.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCategory.FlatAppearance.BorderSize = 0
        Me.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCategory.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnCategory.ForeColor = System.Drawing.Color.White
        Me.BtnCategory.IconChar = FontAwesome.Sharp.IconChar.ChevronDown
        Me.BtnCategory.IconColor = System.Drawing.Color.White
        Me.BtnCategory.IconSize = 30
        Me.BtnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCategory.Location = New System.Drawing.Point(0, 150)
        Me.BtnCategory.Name = "BtnCategory"
        Me.BtnCategory.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnCategory.Rotation = 0R
        Me.BtnCategory.Size = New System.Drawing.Size(267, 50)
        Me.BtnCategory.TabIndex = 15
        Me.BtnCategory.Text = "Category"
        Me.BtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCategory.UseVisualStyleBackColor = False
        '
        'BtnProducts
        '
        Me.BtnProducts.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProducts.FlatAppearance.BorderSize = 0
        Me.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnProducts.ForeColor = System.Drawing.Color.White
        Me.BtnProducts.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.BtnProducts.IconColor = System.Drawing.Color.White
        Me.BtnProducts.IconSize = 30
        Me.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducts.Location = New System.Drawing.Point(0, 100)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnProducts.Rotation = 0R
        Me.BtnProducts.Size = New System.Drawing.Size(267, 50)
        Me.BtnProducts.TabIndex = 14
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProducts.UseVisualStyleBackColor = False
        '
        'BtnPOS
        '
        Me.BtnPOS.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnPOS.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPOS.FlatAppearance.BorderSize = 0
        Me.BtnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPOS.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnPOS.ForeColor = System.Drawing.Color.White
        Me.BtnPOS.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.BtnPOS.IconColor = System.Drawing.Color.White
        Me.BtnPOS.IconSize = 30
        Me.BtnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPOS.Location = New System.Drawing.Point(0, 50)
        Me.BtnPOS.Name = "BtnPOS"
        Me.BtnPOS.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnPOS.Rotation = 0R
        Me.BtnPOS.Size = New System.Drawing.Size(267, 50)
        Me.BtnPOS.TabIndex = 13
        Me.BtnPOS.Text = "Point of Sale"
        Me.BtnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPOS.UseVisualStyleBackColor = False
        '
        'BtnDashBoard
        '
        Me.BtnDashBoard.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnDashBoard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashBoard.FlatAppearance.BorderSize = 0
        Me.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashBoard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDashBoard.ForeColor = System.Drawing.Color.White
        Me.BtnDashBoard.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.BtnDashBoard.IconColor = System.Drawing.Color.White
        Me.BtnDashBoard.IconSize = 30
        Me.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashBoard.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashBoard.Name = "BtnDashBoard"
        Me.BtnDashBoard.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnDashBoard.Rotation = 0R
        Me.BtnDashBoard.Size = New System.Drawing.Size(267, 50)
        Me.BtnDashBoard.TabIndex = 12
        Me.BtnDashBoard.Text = "Dashboard"
        Me.BtnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashBoard.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.Panel4)
        Me.PanelTop.Controls.Add(Me.Panel3)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(267, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(982, 56)
        Me.PanelTop.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.IconPictureBox2)
        Me.Panel4.Controls.Add(Me.TextBoxRight)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(214, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(768, 56)
        Me.Panel4.TabIndex = 1
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconSize = 53
        Me.IconPictureBox2.Location = New System.Drawing.Point(715, 0)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(53, 56)
        Me.IconPictureBox2.TabIndex = 18
        Me.IconPictureBox2.TabStop = False
        '
        'TextBoxRight
        '
        Me.TextBoxRight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxRight.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRight.ForeColor = System.Drawing.Color.White
        Me.TextBoxRight.Location = New System.Drawing.Point(4, 16)
        Me.TextBoxRight.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRight.Name = "TextBoxRight"
        Me.TextBoxRight.ReadOnly = True
        Me.TextBoxRight.Size = New System.Drawing.Size(704, 26)
        Me.TextBoxRight.TabIndex = 16
        Me.TextBoxRight.TabStop = False
        Me.TextBoxRight.Text = "---"
        Me.TextBoxRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.IconPictureBoxTop)
        Me.Panel3.Controls.Add(Me.LblBreadCrump)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 56)
        Me.Panel3.TabIndex = 0
        '
        'IconPictureBoxTop
        '
        Me.IconPictureBoxTop.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBoxTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconPictureBoxTop.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconPictureBoxTop.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconPictureBoxTop.IconColor = System.Drawing.Color.White
        Me.IconPictureBoxTop.IconSize = 56
        Me.IconPictureBoxTop.Location = New System.Drawing.Point(0, 0)
        Me.IconPictureBoxTop.Name = "IconPictureBoxTop"
        Me.IconPictureBoxTop.Size = New System.Drawing.Size(56, 56)
        Me.IconPictureBoxTop.TabIndex = 17
        Me.IconPictureBoxTop.TabStop = False
        '
        'LblBreadCrump
        '
        Me.LblBreadCrump.AutoSize = True
        Me.LblBreadCrump.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBreadCrump.ForeColor = System.Drawing.Color.White
        Me.LblBreadCrump.Location = New System.Drawing.Point(62, 16)
        Me.LblBreadCrump.Name = "LblBreadCrump"
        Me.LblBreadCrump.Size = New System.Drawing.Size(125, 25)
        Me.LblBreadCrump.TabIndex = 16
        Me.LblBreadCrump.Text = "Dashboard"
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(267, 56)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(982, 676)
        Me.PanelMain.TabIndex = 2
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 732)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelSide)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.PanelSide.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconPictureBoxTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSide As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblBreadCrump As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxRight As TextBox
    Friend WithEvents BtnSupplier As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPersonnel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnAnalytics As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnReports As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBrand As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCategory As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnProducts As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPOS As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDashBoard As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBoxTop As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelMain As Panel
    Friend WithEvents BtnStoreInfo As FontAwesome.Sharp.IconButton
End Class
