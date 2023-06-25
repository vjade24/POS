<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Store
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim SloganLabel As System.Windows.Forms.Label
        Dim TinNoLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim ThemeColorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ExpiryDateLabel As System.Windows.Forms.Label
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.SloganTextBox = New System.Windows.Forms.TextBox()
        Me.TinNoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.ThemeColorComboBox = New System.Windows.Forms.ComboBox()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.StoreTableAdapter = New POS.pos_dbDataSetTableAdapters.StoreTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IdLabel = New System.Windows.Forms.Label()
        StoreNameLabel = New System.Windows.Forms.Label()
        SloganLabel = New System.Windows.Forms.Label()
        TinNoLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        ThemeColorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ExpiryDateLabel = New System.Windows.Forms.Label()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(427, 65)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 17)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Location = New System.Drawing.Point(24, 66)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(88, 17)
        StoreNameLabel.TabIndex = 4
        StoreNameLabel.Text = "Store Name:"
        '
        'SloganLabel
        '
        SloganLabel.AutoSize = True
        SloganLabel.Location = New System.Drawing.Point(24, 116)
        SloganLabel.Name = "SloganLabel"
        SloganLabel.Size = New System.Drawing.Size(56, 17)
        SloganLabel.TabIndex = 6
        SloganLabel.Text = "Slogan:"
        '
        'TinNoLabel
        '
        TinNoLabel.AutoSize = True
        TinNoLabel.Location = New System.Drawing.Point(24, 218)
        TinNoLabel.Name = "TinNoLabel"
        TinNoLabel.Size = New System.Drawing.Size(51, 17)
        TinNoLabel.TabIndex = 12
        TinNoLabel.Text = "Tin No:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(231, 220)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(90, 17)
        ContactNoLabel.TabIndex = 14
        ContactNoLabel.Text = "Contact No:"
        '
        'ThemeColorLabel
        '
        ThemeColorLabel.AutoSize = True
        ThemeColorLabel.Location = New System.Drawing.Point(24, 166)
        ThemeColorLabel.Name = "ThemeColorLabel"
        ThemeColorLabel.Size = New System.Drawing.Size(94, 17)
        ThemeColorLabel.TabIndex = 19
        ThemeColorLabel.Text = "Theme Color:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 268)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 17)
        Label1.TabIndex = 57
        Label1.Text = "Address"
        '
        'ExpiryDateLabel
        '
        ExpiryDateLabel.AutoSize = True
        ExpiryDateLabel.Location = New System.Drawing.Point(21, 387)
        ExpiryDateLabel.Name = "ExpiryDateLabel"
        ExpiryDateLabel.Size = New System.Drawing.Size(83, 17)
        ExpiryDateLabel.TabIndex = 59
        ExpiryDateLabel.Text = "Expiry Date:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(427, 87)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(147, 23)
        Me.IdTextBox.TabIndex = 3
        Me.IdTextBox.Visible = False
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.Location = New System.Drawing.Point(24, 88)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(397, 23)
        Me.StoreNameTextBox.TabIndex = 5
        '
        'SloganTextBox
        '
        Me.SloganTextBox.Location = New System.Drawing.Point(24, 138)
        Me.SloganTextBox.Name = "SloganTextBox"
        Me.SloganTextBox.Size = New System.Drawing.Size(397, 23)
        Me.SloganTextBox.TabIndex = 7
        '
        'TinNoTextBox
        '
        Me.TinNoTextBox.Location = New System.Drawing.Point(24, 240)
        Me.TinNoTextBox.Name = "TinNoTextBox"
        Me.TinNoTextBox.Size = New System.Drawing.Size(190, 23)
        Me.TinNoTextBox.TabIndex = 13
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.Location = New System.Drawing.Point(234, 240)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(187, 23)
        Me.ContactNoTextBox.TabIndex = 15
        '
        'ThemeColorComboBox
        '
        Me.ThemeColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "ThemeColor", True))
        Me.ThemeColorComboBox.FormattingEnabled = True
        Me.ThemeColorComboBox.Items.AddRange(New Object() {"#FF1E90FF", "#eb4034"})
        Me.ThemeColorComboBox.Location = New System.Drawing.Point(24, 188)
        Me.ThemeColorComboBox.Name = "ThemeColorComboBox"
        Me.ThemeColorComboBox.Size = New System.Drawing.Size(397, 25)
        Me.ThemeColorComboBox.TabIndex = 20
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "Store"
        Me.StoreBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(430, 394)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 36)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Cube
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(427, 272)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(147, 36)
        Me.IconButton1.TabIndex = 56
        Me.IconButton1.Text = "Browse"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 290)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(397, 84)
        Me.TextBox1.TabIndex = 58
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductImagePictureBox.Image = Global.POS.My.Resources.Resources.box
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(427, 116)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Padding = New System.Windows.Forms.Padding(10)
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(150, 150)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 59
        Me.ProductImagePictureBox.TabStop = False
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StoreTableAdapter = Me.StoreTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StoreBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(24, 407)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(397, 23)
        Me.ExpiryDateDateTimePicker.TabIndex = 60
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 450)
        Me.Controls.Add(ExpiryDateLabel)
        Me.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.Controls.Add(Me.ProductImagePictureBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(ThemeColorLabel)
        Me.Controls.Add(Me.ThemeColorComboBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(StoreNameLabel)
        Me.Controls.Add(Me.StoreNameTextBox)
        Me.Controls.Add(SloganLabel)
        Me.Controls.Add(Me.SloganTextBox)
        Me.Controls.Add(TinNoLabel)
        Me.Controls.Add(Me.TinNoTextBox)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Store"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store"
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents SloganTextBox As TextBox
    Friend WithEvents TinNoTextBox As TextBox
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents StoreBindingSource As BindingSource
    Friend WithEvents StoreTableAdapter As pos_dbDataSetTableAdapters.StoreTableAdapter
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ThemeColorComboBox As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents ExpiryDateDateTimePicker As DateTimePicker
End Class
