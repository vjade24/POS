﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim BarcodeLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim BrandNameLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim OriginalPriceLabel As System.Windows.Forms.Label
        Dim FinalPriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim MinimumPriceLabel As System.Windows.Forms.Label
        Dim MaximumPriceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BrandTableAdapter = New POS.pos_dbDataSetTableAdapters.BrandTableAdapter()
        Me.CategoryTableAdapter = New POS.pos_dbDataSetTableAdapters.CategoryTableAdapter()
        Me.LblAddEditMode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelChangePrice = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAddQuantity = New System.Windows.Forms.LinkLabel()
        Me.CheckBoxExpiryDate = New System.Windows.Forms.CheckBox()
        Me.ExpiryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.MaximumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.MinimumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandNameComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierNameComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OriginalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.FinalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.BtnDelete = New FontAwesome.Sharp.IconButton()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductImage = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDateFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDateTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsInstock = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MinimumPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconButtonPrint = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.BtnAdd = New FontAwesome.Sharp.IconButton()
        Me.ProductTableAdapter = New POS.pos_dbDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SupplierTableAdapter = New POS.pos_dbDataSetTableAdapters.SupplierTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        ProductCodeLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        BarcodeLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        BrandNameLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        OriginalPriceLabel = New System.Windows.Forms.Label()
        FinalPriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        MinimumPriceLabel = New System.Windows.Forms.Label()
        MaximumPriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(845, 64)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 16)
        IdLabel.TabIndex = 0
        IdLabel.Text = "ID"
        IdLabel.Visible = False
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductCodeLabel.Location = New System.Drawing.Point(111, 19)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(115, 18)
        ProductCodeLabel.TabIndex = 26
        ProductCodeLabel.Text = "Product Code:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(112, 72)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(118, 18)
        ProductNameLabel.TabIndex = 28
        ProductNameLabel.Text = "Product Name:"
        '
        'BarcodeLabel
        '
        BarcodeLabel.AutoSize = True
        BarcodeLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BarcodeLabel.Location = New System.Drawing.Point(318, 19)
        BarcodeLabel.Name = "BarcodeLabel"
        BarcodeLabel.Size = New System.Drawing.Size(76, 18)
        BarcodeLabel.TabIndex = 30
        BarcodeLabel.Text = "Barcode:"
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryNameLabel.Location = New System.Drawing.Point(112, 128)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(130, 18)
        CategoryNameLabel.TabIndex = 32
        CategoryNameLabel.Text = "Category Name:"
        '
        'BrandNameLabel
        '
        BrandNameLabel.AutoSize = True
        BrandNameLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandNameLabel.Location = New System.Drawing.Point(316, 128)
        BrandNameLabel.Name = "BrandNameLabel"
        BrandNameLabel.Size = New System.Drawing.Size(104, 18)
        BrandNameLabel.TabIndex = 34
        BrandNameLabel.Text = "Brand Name:"
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.AutoSize = True
        SupplierNameLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupplierNameLabel.Location = New System.Drawing.Point(526, 128)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(119, 18)
        SupplierNameLabel.TabIndex = 36
        SupplierNameLabel.Text = "Supplier Name:"
        '
        'OriginalPriceLabel
        '
        OriginalPriceLabel.AutoSize = True
        OriginalPriceLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OriginalPriceLabel.Location = New System.Drawing.Point(110, 195)
        OriginalPriceLabel.Name = "OriginalPriceLabel"
        OriginalPriceLabel.Size = New System.Drawing.Size(109, 18)
        OriginalPriceLabel.TabIndex = 38
        OriginalPriceLabel.Text = "Capital Price:"
        '
        'FinalPriceLabel
        '
        FinalPriceLabel.AutoSize = True
        FinalPriceLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinalPriceLabel.Location = New System.Drawing.Point(318, 194)
        FinalPriceLabel.Name = "FinalPriceLabel"
        FinalPriceLabel.Size = New System.Drawing.Size(102, 18)
        FinalPriceLabel.TabIndex = 48
        FinalPriceLabel.Text = "Selling Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(524, 17)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(73, 18)
        QuantityLabel.TabIndex = 50
        QuantityLabel.Text = "Quantity:"
        '
        'MinimumPriceLabel
        '
        MinimumPriceLabel.AutoSize = True
        MinimumPriceLabel.Location = New System.Drawing.Point(845, 106)
        MinimumPriceLabel.Name = "MinimumPriceLabel"
        MinimumPriceLabel.Size = New System.Drawing.Size(89, 16)
        MinimumPriceLabel.TabIndex = 55
        MinimumPriceLabel.Text = "Minimum Price:"
        MinimumPriceLabel.Visible = False
        AddHandler MinimumPriceLabel.Click, AddressOf Me.MinimumPriceLabel_Click
        '
        'MaximumPriceLabel
        '
        MaximumPriceLabel.AutoSize = True
        MaximumPriceLabel.Location = New System.Drawing.Point(845, 149)
        MaximumPriceLabel.Name = "MaximumPriceLabel"
        MaximumPriceLabel.Size = New System.Drawing.Size(94, 16)
        MaximumPriceLabel.TabIndex = 56
        MaximumPriceLabel.Text = "Maximum Price:"
        MaximumPriceLabel.Visible = False
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'LblAddEditMode
        '
        Me.LblAddEditMode.AutoSize = True
        Me.LblAddEditMode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddEditMode.ForeColor = System.Drawing.Color.Red
        Me.LblAddEditMode.Location = New System.Drawing.Point(114, 284)
        Me.LblAddEditMode.Name = "LblAddEditMode"
        Me.LblAddEditMode.Size = New System.Drawing.Size(16, 16)
        Me.LblAddEditMode.TabIndex = 24
        Me.LblAddEditMode.Text = "--"
        Me.LblAddEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabelChangePrice)
        Me.GroupBox1.Controls.Add(Me.LinkLabelAddQuantity)
        Me.GroupBox1.Controls.Add(Me.CheckBoxExpiryDate)
        Me.GroupBox1.Controls.Add(Me.ExpiryDateDateTimePicker)
        Me.GroupBox1.Controls.Add(MaximumPriceLabel)
        Me.GroupBox1.Controls.Add(Me.MaximumPriceTextBox)
        Me.GroupBox1.Controls.Add(MinimumPriceLabel)
        Me.GroupBox1.Controls.Add(Me.MinimumPriceTextBox)
        Me.GroupBox1.Controls.Add(ProductCodeLabel)
        Me.GroupBox1.Controls.Add(Me.ProductCodeTextBox)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox1.Controls.Add(BarcodeLabel)
        Me.GroupBox1.Controls.Add(Me.BarcodeTextBox)
        Me.GroupBox1.Controls.Add(CategoryNameLabel)
        Me.GroupBox1.Controls.Add(Me.CategoryNameComboBox)
        Me.GroupBox1.Controls.Add(BrandNameLabel)
        Me.GroupBox1.Controls.Add(Me.BrandNameComboBox)
        Me.GroupBox1.Controls.Add(SupplierNameLabel)
        Me.GroupBox1.Controls.Add(Me.SupplierNameComboBox)
        Me.GroupBox1.Controls.Add(OriginalPriceLabel)
        Me.GroupBox1.Controls.Add(Me.OriginalPriceTextBox)
        Me.GroupBox1.Controls.Add(FinalPriceLabel)
        Me.GroupBox1.Controls.Add(Me.FinalPriceTextBox)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.LblAddEditMode)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 337)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(951, 330)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'LinkLabelChangePrice
        '
        Me.LinkLabelChangePrice.AutoSize = True
        Me.LinkLabelChangePrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelChangePrice.Location = New System.Drawing.Point(222, 195)
        Me.LinkLabelChangePrice.Name = "LinkLabelChangePrice"
        Me.LinkLabelChangePrice.Size = New System.Drawing.Size(96, 17)
        Me.LinkLabelChangePrice.TabIndex = 61
        Me.LinkLabelChangePrice.TabStop = True
        Me.LinkLabelChangePrice.Text = "Change Price"
        '
        'LinkLabelAddQuantity
        '
        Me.LinkLabelAddQuantity.AutoSize = True
        Me.LinkLabelAddQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelAddQuantity.Location = New System.Drawing.Point(640, 20)
        Me.LinkLabelAddQuantity.Name = "LinkLabelAddQuantity"
        Me.LinkLabelAddQuantity.Size = New System.Drawing.Size(94, 17)
        Me.LinkLabelAddQuantity.TabIndex = 60
        Me.LinkLabelAddQuantity.TabStop = True
        Me.LinkLabelAddQuantity.Text = "Add Quantity"
        '
        'CheckBoxExpiryDate
        '
        Me.CheckBoxExpiryDate.AutoSize = True
        Me.CheckBoxExpiryDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxExpiryDate.Location = New System.Drawing.Point(529, 191)
        Me.CheckBoxExpiryDate.Name = "CheckBoxExpiryDate"
        Me.CheckBoxExpiryDate.Size = New System.Drawing.Size(113, 22)
        Me.CheckBoxExpiryDate.TabIndex = 59
        Me.CheckBoxExpiryDate.Text = "Expiry Date:"
        Me.CheckBoxExpiryDate.UseVisualStyleBackColor = True
        '
        'ExpiryDateDateTimePicker
        '
        Me.ExpiryDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "ExpiryDate", True))
        Me.ExpiryDateDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpiryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ExpiryDateDateTimePicker.Location = New System.Drawing.Point(531, 217)
        Me.ExpiryDateDateTimePicker.Name = "ExpiryDateDateTimePicker"
        Me.ExpiryDateDateTimePicker.Size = New System.Drawing.Size(198, 27)
        Me.ExpiryDateDateTimePicker.TabIndex = 10
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaximumPriceTextBox
        '
        Me.MaximumPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MaximumPrice", True))
        Me.MaximumPriceTextBox.Location = New System.Drawing.Point(845, 168)
        Me.MaximumPriceTextBox.Name = "MaximumPriceTextBox"
        Me.MaximumPriceTextBox.Size = New System.Drawing.Size(61, 21)
        Me.MaximumPriceTextBox.TabIndex = 57
        Me.MaximumPriceTextBox.Text = "0.00"
        Me.MaximumPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaximumPriceTextBox.Visible = False
        '
        'MinimumPriceTextBox
        '
        Me.MinimumPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MinimumPrice", True))
        Me.MinimumPriceTextBox.Location = New System.Drawing.Point(845, 125)
        Me.MinimumPriceTextBox.Name = "MinimumPriceTextBox"
        Me.MinimumPriceTextBox.Size = New System.Drawing.Size(64, 21)
        Me.MinimumPriceTextBox.TabIndex = 56
        Me.MinimumPriceTextBox.Text = "0.00"
        Me.MinimumPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MinimumPriceTextBox.Visible = False
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductCode", True))
        Me.ProductCodeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(114, 43)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(200, 27)
        Me.ProductCodeTextBox.TabIndex = 1
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(113, 95)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(616, 27)
        Me.ProductNameTextBox.TabIndex = 4
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Barcode", True))
        Me.BarcodeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeTextBox.Location = New System.Drawing.Point(319, 42)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(200, 27)
        Me.BarcodeTextBox.TabIndex = 2
        '
        'CategoryNameComboBox
        '
        Me.CategoryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "CategoryName", True))
        Me.CategoryNameComboBox.DataSource = Me.CategoryBindingSource2
        Me.CategoryNameComboBox.DisplayMember = "CategoryName"
        Me.CategoryNameComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameComboBox.FormattingEnabled = True
        Me.CategoryNameComboBox.Location = New System.Drawing.Point(113, 151)
        Me.CategoryNameComboBox.Name = "CategoryNameComboBox"
        Me.CategoryNameComboBox.Size = New System.Drawing.Size(200, 29)
        Me.CategoryNameComboBox.TabIndex = 5
        Me.CategoryNameComboBox.ValueMember = "CategoryName"
        '
        'CategoryBindingSource2
        '
        Me.CategoryBindingSource2.DataMember = "Category"
        Me.CategoryBindingSource2.DataSource = Me.Pos_dbDataSet
        '
        'BrandNameComboBox
        '
        Me.BrandNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "BrandName", True))
        Me.BrandNameComboBox.DataSource = Me.BrandBindingSource1
        Me.BrandNameComboBox.DisplayMember = "BrandName"
        Me.BrandNameComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandNameComboBox.FormattingEnabled = True
        Me.BrandNameComboBox.Location = New System.Drawing.Point(319, 151)
        Me.BrandNameComboBox.Name = "BrandNameComboBox"
        Me.BrandNameComboBox.Size = New System.Drawing.Size(200, 29)
        Me.BrandNameComboBox.TabIndex = 6
        Me.BrandNameComboBox.ValueMember = "BrandName"
        '
        'BrandBindingSource1
        '
        Me.BrandBindingSource1.DataMember = "Brand"
        Me.BrandBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "SupplierName", True))
        Me.SupplierNameComboBox.DataSource = Me.SupplierBindingSource
        Me.SupplierNameComboBox.DisplayMember = "SupplierName"
        Me.SupplierNameComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierNameComboBox.FormattingEnabled = True
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(529, 151)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(200, 29)
        Me.SupplierNameComboBox.TabIndex = 7
        Me.SupplierNameComboBox.ValueMember = "SupplierName"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'OriginalPriceTextBox
        '
        Me.OriginalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "OriginalPrice", True))
        Me.OriginalPriceTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginalPriceTextBox.Location = New System.Drawing.Point(113, 217)
        Me.OriginalPriceTextBox.Name = "OriginalPriceTextBox"
        Me.OriginalPriceTextBox.Size = New System.Drawing.Size(200, 27)
        Me.OriginalPriceTextBox.TabIndex = 8
        Me.OriginalPriceTextBox.Text = "0.00"
        Me.OriginalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FinalPriceTextBox
        '
        Me.FinalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "FinalPrice", True))
        Me.FinalPriceTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalPriceTextBox.Location = New System.Drawing.Point(321, 217)
        Me.FinalPriceTextBox.Name = "FinalPriceTextBox"
        Me.FinalPriceTextBox.Size = New System.Drawing.Size(200, 27)
        Me.FinalPriceTextBox.TabIndex = 9
        Me.FinalPriceTextBox.Text = "0.00"
        Me.FinalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(527, 42)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(202, 27)
        Me.QuantityTextBox.TabIndex = 3
        Me.QuantityTextBox.Text = "0"
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(845, 84)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(46, 21)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.BtnSave.IconColor = System.Drawing.Color.White
        Me.BtnSave.IconSize = 30
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(619, 274)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.BtnSave.Rotation = 0R
        Me.BtnSave.Size = New System.Drawing.Size(112, 36)
        Me.BtnSave.TabIndex = 23
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnDelete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.IconChar = FontAwesome.Sharp.IconChar.TimesCircleO
        Me.BtnDelete.IconColor = System.Drawing.Color.White
        Me.BtnDelete.IconSize = 30
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(501, 274)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.BtnDelete.Rotation = 0R
        Me.BtnDelete.Size = New System.Drawing.Size(112, 36)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Search:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSearch.Location = New System.Drawing.Point(76, 30)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(12)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxSearch.TabIndex = 19
        '
        'CategoryDataGridView
        '
        Me.CategoryDataGridView.AllowUserToAddRows = False
        Me.CategoryDataGridView.AllowUserToDeleteRows = False
        Me.CategoryDataGridView.AutoGenerateColumns = False
        Me.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CategoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.CategoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDataGridView.ColumnHeadersHeight = 30
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProductCode, Me.ProductName, Me.ProductImage, Me.Barcode, Me.CategoryName, Me.BrandName, Me.SupplierName, Me.OriginalPrice, Me.DiscountedPerc, Me.DiscountedDateFrom, Me.DiscountedDateTo, Me.DiscountedPrice, Me.FinalPrice, Me.Quantity, Me.IsInstock, Me.MinimumPrice, Me.MaximumPrice, Me.ExpiryDate})
        Me.CategoryDataGridView.DataSource = Me.ProductBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(21, 66)
        Me.CategoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(916, 229)
        Me.CategoryDataGridView.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'ProductCode
        '
        Me.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductCode.DataPropertyName = "ProductCode"
        Me.ProductCode.FillWeight = 30.89826!
        Me.ProductCode.HeaderText = "PrdCode"
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = True
        Me.ProductCode.Width = 81
        '
        'ProductName
        '
        Me.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.FillWeight = 593.4011!
        Me.ProductName.HeaderText = "ProductName"
        Me.ProductName.MinimumWidth = 100
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.Width = 108
        '
        'ProductImage
        '
        Me.ProductImage.DataPropertyName = "ProductImage"
        Me.ProductImage.HeaderText = "ProductImage"
        Me.ProductImage.Name = "ProductImage"
        Me.ProductImage.ReadOnly = True
        Me.ProductImage.Visible = False
        '
        'Barcode
        '
        Me.Barcode.DataPropertyName = "Barcode"
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        Me.Barcode.Visible = False
        '
        'CategoryName
        '
        Me.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CategoryName.DataPropertyName = "CategoryName"
        Me.CategoryName.FillWeight = 15.14015!
        Me.CategoryName.HeaderText = "CategoryName"
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        Me.CategoryName.Width = 116
        '
        'BrandName
        '
        Me.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.BrandName.DataPropertyName = "BrandName"
        Me.BrandName.FillWeight = 15.14015!
        Me.BrandName.HeaderText = "BrandName"
        Me.BrandName.Name = "BrandName"
        Me.BrandName.ReadOnly = True
        Me.BrandName.Width = 97
        '
        'SupplierName
        '
        Me.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SupplierName.DataPropertyName = "SupplierName"
        Me.SupplierName.FillWeight = 15.14015!
        Me.SupplierName.HeaderText = "SupplierName"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.ReadOnly = True
        Me.SupplierName.Width = 108
        '
        'OriginalPrice
        '
        Me.OriginalPrice.DataPropertyName = "OriginalPrice"
        Me.OriginalPrice.HeaderText = "OriginalPrice"
        Me.OriginalPrice.Name = "OriginalPrice"
        Me.OriginalPrice.ReadOnly = True
        Me.OriginalPrice.Visible = False
        '
        'DiscountedPerc
        '
        Me.DiscountedPerc.DataPropertyName = "DiscountedPerc"
        Me.DiscountedPerc.HeaderText = "DiscountedPerc"
        Me.DiscountedPerc.Name = "DiscountedPerc"
        Me.DiscountedPerc.ReadOnly = True
        Me.DiscountedPerc.Visible = False
        '
        'DiscountedDateFrom
        '
        Me.DiscountedDateFrom.DataPropertyName = "DiscountedDateFrom"
        Me.DiscountedDateFrom.HeaderText = "DiscountedDateFrom"
        Me.DiscountedDateFrom.Name = "DiscountedDateFrom"
        Me.DiscountedDateFrom.ReadOnly = True
        Me.DiscountedDateFrom.Visible = False
        '
        'DiscountedDateTo
        '
        Me.DiscountedDateTo.DataPropertyName = "DiscountedDateTo"
        Me.DiscountedDateTo.HeaderText = "DiscountedDateTo"
        Me.DiscountedDateTo.Name = "DiscountedDateTo"
        Me.DiscountedDateTo.ReadOnly = True
        Me.DiscountedDateTo.Visible = False
        '
        'DiscountedPrice
        '
        Me.DiscountedPrice.DataPropertyName = "DiscountedPrice"
        Me.DiscountedPrice.HeaderText = "DiscountedPrice"
        Me.DiscountedPrice.Name = "DiscountedPrice"
        Me.DiscountedPrice.ReadOnly = True
        Me.DiscountedPrice.Visible = False
        '
        'FinalPrice
        '
        Me.FinalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FinalPrice.DataPropertyName = "FinalPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FinalPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.FinalPrice.FillWeight = 15.14015!
        Me.FinalPrice.HeaderText = "SellingPrice"
        Me.FinalPrice.Name = "FinalPrice"
        Me.FinalPrice.ReadOnly = True
        Me.FinalPrice.Width = 91
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.FillWeight = 15.14015!
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 80
        '
        'IsInstock
        '
        Me.IsInstock.DataPropertyName = "IsInstock"
        Me.IsInstock.HeaderText = "IsInstock"
        Me.IsInstock.Name = "IsInstock"
        Me.IsInstock.ReadOnly = True
        Me.IsInstock.Visible = False
        '
        'MinimumPrice
        '
        Me.MinimumPrice.DataPropertyName = "MinimumPrice"
        Me.MinimumPrice.HeaderText = "MinimumPrice"
        Me.MinimumPrice.Name = "MinimumPrice"
        Me.MinimumPrice.ReadOnly = True
        Me.MinimumPrice.Visible = False
        '
        'MaximumPrice
        '
        Me.MaximumPrice.DataPropertyName = "MaximumPrice"
        Me.MaximumPrice.HeaderText = "MaximumPrice"
        Me.MaximumPrice.Name = "MaximumPrice"
        Me.MaximumPrice.ReadOnly = True
        Me.MaximumPrice.Visible = False
        '
        'ExpiryDate
        '
        Me.ExpiryDate.DataPropertyName = "ExpiryDate"
        Me.ExpiryDate.HeaderText = "ExpiryDate"
        Me.ExpiryDate.Name = "ExpiryDate"
        Me.ExpiryDate.ReadOnly = True
        Me.ExpiryDate.Visible = False
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.IconButtonPrint)
        Me.GroupBox2.Controls.Add(Me.IconButton2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox2.Controls.Add(Me.CategoryDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(951, 319)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(819, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Latest 100 records"
        '
        'IconButtonPrint
        '
        Me.IconButtonPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.IconButtonPrint.FlatAppearance.BorderSize = 0
        Me.IconButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPrint.ForeColor = System.Drawing.Color.White
        Me.IconButtonPrint.IconChar = FontAwesome.Sharp.IconChar.File
        Me.IconButtonPrint.IconColor = System.Drawing.Color.White
        Me.IconButtonPrint.IconSize = 30
        Me.IconButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPrint.Location = New System.Drawing.Point(249, 22)
        Me.IconButtonPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButtonPrint.Name = "IconButtonPrint"
        Me.IconButtonPrint.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.IconButtonPrint.Rotation = 0R
        Me.IconButtonPrint.Size = New System.Drawing.Size(159, 36)
        Me.IconButtonPrint.TabIndex = 23
        Me.IconButtonPrint.Text = "Print Product List"
        Me.IconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPrint.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.ForestGreen
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Retweet
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(703, 22)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(114, 36)
        Me.IconButton2.TabIndex = 22
        Me.IconButton2.Text = "Refresh"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnAdd.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.BtnAdd.IconColor = System.Drawing.Color.White
        Me.BtnAdd.IconSize = 30
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(823, 22)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.BtnAdd.Rotation = 0R
        Me.BtnAdd.Size = New System.Drawing.Size(114, 36)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Me.BrandTableAdapter
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductPriceTableAdapter = Nothing
        Me.TableAdapterManager.ProductQuantityTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.RemittanceTableAdapter = Nothing
        Me.TableAdapterManager.StoreTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Products"
        Me.Text = "Products"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BrandTableAdapter As pos_dbDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents CategoryTableAdapter As pos_dbDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents LblAddEditMode As Label
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CategoryBindingSource1 As BindingSource
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As pos_dbDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents CategoryNameComboBox As ComboBox
    Friend WithEvents BrandNameComboBox As ComboBox
    Friend WithEvents SupplierNameComboBox As ComboBox
    Friend WithEvents OriginalPriceTextBox As TextBox
    Friend WithEvents FinalPriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CategoryBindingSource2 As BindingSource
    Friend WithEvents BrandBindingSource1 As BindingSource
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As pos_dbDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents MaximumPriceTextBox As TextBox
    Friend WithEvents MinimumPriceTextBox As TextBox
    Friend WithEvents ExpiryDateDateTimePicker As DateTimePicker
    Friend WithEvents CheckBoxExpiryDate As CheckBox
    Friend WithEvents LinkLabelChangePrice As LinkLabel
    Friend WithEvents LinkLabelAddQuantity As LinkLabel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCode As DataGridViewTextBoxColumn
    Shadows WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductImage As DataGridViewImageColumn
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents CategoryName As DataGridViewTextBoxColumn
    Friend WithEvents BrandName As DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents OriginalPrice As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPerc As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDateFrom As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDateTo As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPrice As DataGridViewTextBoxColumn
    Friend WithEvents FinalPrice As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents IsInstock As DataGridViewCheckBoxColumn
    Friend WithEvents MinimumPrice As DataGridViewTextBoxColumn
    Friend WithEvents MaximumPrice As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDate As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
