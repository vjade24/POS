<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PointOfSale
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
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim FinalPriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim BarcodeLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim BrandNameLabel As System.Windows.Forms.Label
        Dim SupplierNameLabel As System.Windows.Forms.Label
        Dim OriginalPriceLabel As System.Windows.Forms.Label
        Dim DiscountedPercLabel As System.Windows.Forms.Label
        Dim DiscountedPriceLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim PersonnelIdLabel As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim PaymentAmountLabel As System.Windows.Forms.Label
        Dim PaymentChangeLabel As System.Windows.Forms.Label
        Dim PaymentStatusLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim MinimumPriceLabel As System.Windows.Forms.Label
        Dim MaximumPriceLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PointOfSale))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.TransactionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New POS.pos_dbDataSetTableAdapters.SupplierTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.BrandTableAdapter = New POS.pos_dbDataSetTableAdapters.BrandTableAdapter()
        Me.CategoryTableAdapter = New POS.pos_dbDataSetTableAdapters.CategoryTableAdapter()
        Me.ProductTableAdapter = New POS.pos_dbDataSetTableAdapters.ProductTableAdapter()
        Me.CategoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionHeaderIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPercDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRemove = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TransactionDetailsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionDetailsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransactionDetailsTableAdapter = New POS.pos_dbDataSetTableAdapters.TransactionDetailsTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxRemainingQuantity = New System.Windows.Forms.TextBox()
        Me.MaximumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.MinimumPriceTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountedPercTextBox = New System.Windows.Forms.TextBox()
        Me.OriginalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierNameComboBox = New System.Windows.Forms.ComboBox()
        Me.BrandNameComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalPerProduct = New System.Windows.Forms.TextBox()
        Me.btnAddToCart = New FontAwesome.Sharp.IconButton()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.FinalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxInvoice = New System.Windows.Forms.ComboBox()
        Me.IconButtonSearch = New FontAwesome.Sharp.IconButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PaymentStatusTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentChangeTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentAmountTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelIdTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.btnNewTransaction = New FontAwesome.Sharp.IconButton()
        Me.TransactionHeaderTableAdapter = New POS.pos_dbDataSetTableAdapters.TransactionHeaderTableAdapter()
        Me.TransactionDetailsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MinimumPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductCodeLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        FinalPriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        BarcodeLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        BrandNameLabel = New System.Windows.Forms.Label()
        SupplierNameLabel = New System.Windows.Forms.Label()
        OriginalPriceLabel = New System.Windows.Forms.Label()
        DiscountedPercLabel = New System.Windows.Forms.Label()
        DiscountedPriceLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        PersonnelIdLabel = New System.Windows.Forms.Label()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        PaymentAmountLabel = New System.Windows.Forms.Label()
        PaymentChangeLabel = New System.Windows.Forms.Label()
        PaymentStatusLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        MinimumPriceLabel = New System.Windows.Forms.Label()
        MaximumPriceLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.TransactionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDetailsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TransactionHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionDetailsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TransactionDetailsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(17, 28)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(88, 16)
        ProductCodeLabel.TabIndex = 0
        ProductCodeLabel.Text = "Product Code:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(17, 122)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(90, 16)
        ProductNameLabel.TabIndex = 2
        ProductNameLabel.Text = "Product Name:"
        '
        'FinalPriceLabel
        '
        FinalPriceLabel.AutoSize = True
        FinalPriceLabel.Location = New System.Drawing.Point(148, 165)
        FinalPriceLabel.Name = "FinalPriceLabel"
        FinalPriceLabel.Size = New System.Drawing.Size(73, 16)
        FinalPriceLabel.TabIndex = 4
        FinalPriceLabel.Text = "Selling Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(17, 208)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(59, 16)
        QuantityLabel.TabIndex = 6
        QuantityLabel.Text = "Quantity:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(271, 250)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(58, 16)
        Label4.TabIndex = 27
        Label4.Text = "Sub Total"
        '
        'BarcodeLabel
        '
        BarcodeLabel.AutoSize = True
        BarcodeLabel.Location = New System.Drawing.Point(144, 28)
        BarcodeLabel.Name = "BarcodeLabel"
        BarcodeLabel.Size = New System.Drawing.Size(57, 16)
        BarcodeLabel.TabIndex = 28
        BarcodeLabel.Text = "Barcode:"
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(17, 74)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(98, 16)
        CategoryNameLabel.TabIndex = 29
        CategoryNameLabel.Text = "Category Name:"
        '
        'BrandNameLabel
        '
        BrandNameLabel.AutoSize = True
        BrandNameLabel.Location = New System.Drawing.Point(271, 28)
        BrandNameLabel.Name = "BrandNameLabel"
        BrandNameLabel.Size = New System.Drawing.Size(79, 16)
        BrandNameLabel.TabIndex = 30
        BrandNameLabel.Text = "Brand Name:"
        '
        'SupplierNameLabel
        '
        SupplierNameLabel.AutoSize = True
        SupplierNameLabel.Location = New System.Drawing.Point(148, 74)
        SupplierNameLabel.Name = "SupplierNameLabel"
        SupplierNameLabel.Size = New System.Drawing.Size(90, 16)
        SupplierNameLabel.TabIndex = 31
        SupplierNameLabel.Text = "Supplier Name:"
        '
        'OriginalPriceLabel
        '
        OriginalPriceLabel.AutoSize = True
        OriginalPriceLabel.Location = New System.Drawing.Point(17, 165)
        OriginalPriceLabel.Name = "OriginalPriceLabel"
        OriginalPriceLabel.Size = New System.Drawing.Size(81, 16)
        OriginalPriceLabel.TabIndex = 32
        OriginalPriceLabel.Text = "Capital Price:"
        '
        'DiscountedPercLabel
        '
        DiscountedPercLabel.AutoSize = True
        DiscountedPercLabel.Location = New System.Drawing.Point(1013, 355)
        DiscountedPercLabel.Name = "DiscountedPercLabel"
        DiscountedPercLabel.Size = New System.Drawing.Size(99, 16)
        DiscountedPercLabel.TabIndex = 33
        DiscountedPercLabel.Text = "Discounted Perc:"
        DiscountedPercLabel.Visible = False
        '
        'DiscountedPriceLabel
        '
        DiscountedPriceLabel.AutoSize = True
        DiscountedPriceLabel.Location = New System.Drawing.Point(148, 208)
        DiscountedPriceLabel.Name = "DiscountedPriceLabel"
        DiscountedPriceLabel.Size = New System.Drawing.Size(101, 16)
        DiscountedPriceLabel.TabIndex = 34
        DiscountedPriceLabel.Text = "Discounted Price:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(20, 17)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 27
        IdLabel.Text = "Id:"
        '
        'PersonnelIdLabel
        '
        PersonnelIdLabel.AutoSize = True
        PersonnelIdLabel.Location = New System.Drawing.Point(70, 17)
        PersonnelIdLabel.Name = "PersonnelIdLabel"
        PersonnelIdLabel.Size = New System.Drawing.Size(76, 16)
        PersonnelIdLabel.TabIndex = 29
        PersonnelIdLabel.Text = "Personnel Id:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Location = New System.Drawing.Point(144, 17)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(70, 16)
        InvoiceNoLabel.TabIndex = 31
        InvoiceNoLabel.Text = "Invoice No:"
        '
        'PaymentAmountLabel
        '
        PaymentAmountLabel.AutoSize = True
        PaymentAmountLabel.Location = New System.Drawing.Point(285, 17)
        PaymentAmountLabel.Name = "PaymentAmountLabel"
        PaymentAmountLabel.Size = New System.Drawing.Size(42, 16)
        PaymentAmountLabel.TabIndex = 35
        PaymentAmountLabel.Text = "P.Amt:"
        '
        'PaymentChangeLabel
        '
        PaymentChangeLabel.AutoSize = True
        PaymentChangeLabel.Location = New System.Drawing.Point(342, 16)
        PaymentChangeLabel.Name = "PaymentChangeLabel"
        PaymentChangeLabel.Size = New System.Drawing.Size(56, 16)
        PaymentChangeLabel.TabIndex = 37
        PaymentChangeLabel.Text = "Change:"
        '
        'PaymentStatusLabel
        '
        PaymentStatusLabel.AutoSize = True
        PaymentStatusLabel.Location = New System.Drawing.Point(401, 16)
        PaymentStatusLabel.Name = "PaymentStatusLabel"
        PaymentStatusLabel.Size = New System.Drawing.Size(44, 16)
        PaymentStatusLabel.TabIndex = 39
        PaymentStatusLabel.Text = "Status:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(220, 16)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(59, 16)
        CustomerNameLabel.TabIndex = 40
        CustomerNameLabel.Text = "Customer"
        '
        'MinimumPriceLabel
        '
        MinimumPriceLabel.AutoSize = True
        MinimumPriceLabel.Location = New System.Drawing.Point(1016, 410)
        MinimumPriceLabel.Name = "MinimumPriceLabel"
        MinimumPriceLabel.Size = New System.Drawing.Size(89, 16)
        MinimumPriceLabel.TabIndex = 35
        MinimumPriceLabel.Text = "Minimum Price:"
        MinimumPriceLabel.Visible = False
        '
        'MaximumPriceLabel
        '
        MaximumPriceLabel.AutoSize = True
        MaximumPriceLabel.Location = New System.Drawing.Point(1143, 410)
        MaximumPriceLabel.Name = "MaximumPriceLabel"
        MaximumPriceLabel.Size = New System.Drawing.Size(94, 16)
        MaximumPriceLabel.TabIndex = 36
        MaximumPriceLabel.Text = "Maximum Price:"
        MaximumPriceLabel.Visible = False
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(276, 79)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(119, 16)
        Label5.TabIndex = 38
        Label5.Text = "Remaining Quantity:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSearch.Location = New System.Drawing.Point(88, 29)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(12)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(156, 21)
        Me.TextBoxSearch.TabIndex = 19
        '
        'TransactionDetailsBindingSource
        '
        Me.TransactionDetailsBindingSource.DataMember = "TransactionDetails"
        Me.TransactionDetailsBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Me.BrandTableAdapter
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.StoreTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'CategoryBindingSource2
        '
        Me.CategoryBindingSource2.DataMember = "Category"
        Me.CategoryBindingSource2.DataSource = Me.Pos_dbDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 79)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(518, 591)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product List"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 50
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TransactionHeaderIdDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.OriginalPriceDataGridViewTextBoxColumn, Me.DiscountedPercDataGridViewTextBoxColumn, Me.DiscountedPriceDataGridViewTextBoxColumn, Me.FinalPriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn, Me.ColumnRemove})
        Me.DataGridView2.DataSource = Me.TransactionDetailsBindingSource3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(15, 21)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 50
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(488, 487)
        Me.DataGridView2.TabIndex = 34
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'TransactionHeaderIdDataGridViewTextBoxColumn
        '
        Me.TransactionHeaderIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionHeaderId"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn.HeaderText = "TransactionHeaderId"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn.Name = "TransactionHeaderIdDataGridViewTextBoxColumn"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionHeaderIdDataGridViewTextBoxColumn.Visible = False
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCodeDataGridViewTextBoxColumn.Visible = False
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryNameDataGridViewTextBoxColumn
        '
        Me.CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn"
        Me.CategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryNameDataGridViewTextBoxColumn.Visible = False
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        Me.BrandNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.BrandNameDataGridViewTextBoxColumn.Visible = False
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierNameDataGridViewTextBoxColumn.Visible = False
        '
        'BarcodeDataGridViewTextBoxColumn
        '
        Me.BarcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.HeaderText = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn.Name = "BarcodeDataGridViewTextBoxColumn"
        Me.BarcodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarcodeDataGridViewTextBoxColumn.Visible = False
        '
        'OriginalPriceDataGridViewTextBoxColumn
        '
        Me.OriginalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice"
        Me.OriginalPriceDataGridViewTextBoxColumn.HeaderText = "OriginalPrice"
        Me.OriginalPriceDataGridViewTextBoxColumn.Name = "OriginalPriceDataGridViewTextBoxColumn"
        Me.OriginalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.OriginalPriceDataGridViewTextBoxColumn.Visible = False
        '
        'DiscountedPercDataGridViewTextBoxColumn
        '
        Me.DiscountedPercDataGridViewTextBoxColumn.DataPropertyName = "DiscountedPerc"
        Me.DiscountedPercDataGridViewTextBoxColumn.HeaderText = "DiscountedPerc"
        Me.DiscountedPercDataGridViewTextBoxColumn.Name = "DiscountedPercDataGridViewTextBoxColumn"
        Me.DiscountedPercDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountedPercDataGridViewTextBoxColumn.Visible = False
        '
        'DiscountedPriceDataGridViewTextBoxColumn
        '
        Me.DiscountedPriceDataGridViewTextBoxColumn.DataPropertyName = "DiscountedPrice"
        Me.DiscountedPriceDataGridViewTextBoxColumn.HeaderText = "DiscountedPrice"
        Me.DiscountedPriceDataGridViewTextBoxColumn.Name = "DiscountedPriceDataGridViewTextBoxColumn"
        Me.DiscountedPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountedPriceDataGridViewTextBoxColumn.Visible = False
        '
        'FinalPriceDataGridViewTextBoxColumn
        '
        Me.FinalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FinalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn.Name = "FinalPriceDataGridViewTextBoxColumn"
        Me.FinalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.FinalPriceDataGridViewTextBoxColumn.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.QuantityDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TotalAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalAmountDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedAtDataGridViewTextBoxColumn.Visible = False
        '
        'CreatedByDataGridViewTextBoxColumn
        '
        Me.CreatedByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.Name = "CreatedByDataGridViewTextBoxColumn"
        Me.CreatedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedByDataGridViewTextBoxColumn.Visible = False
        '
        'ColumnRemove
        '
        Me.ColumnRemove.FillWeight = 25.0!
        Me.ColumnRemove.HeaderText = ""
        Me.ColumnRemove.Image = CType(resources.GetObject("ColumnRemove.Image"), System.Drawing.Image)
        Me.ColumnRemove.Name = "ColumnRemove"
        Me.ColumnRemove.ReadOnly = True
        Me.ColumnRemove.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TransactionDetailsBindingSource3
        '
        Me.TransactionDetailsBindingSource3.DataMember = "TransactionDetails"
        Me.TransactionDetailsBindingSource3.DataSource = Me.Pos_dbDataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.GrandTotalTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 520)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 67)
        Me.Panel1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Grand Total"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.ForestGreen
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(214, 0)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(149, 67)
        Me.IconButton1.TabIndex = 25
        Me.IconButton1.Text = "Pay Now"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Red
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.BtnSave.IconColor = System.Drawing.Color.White
        Me.BtnSave.IconSize = 30
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(363, 0)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.BtnSave.Rotation = 0R
        Me.BtnSave.Size = New System.Drawing.Size(149, 67)
        Me.BtnSave.TabIndex = 24
        Me.BtnSave.Text = "Hold"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "GrandTotal", True))
        Me.GrandTotalTextBox.Enabled = False
        Me.GrandTotalTextBox.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(40, 21)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(135, 37)
        Me.GrandTotalTextBox.TabIndex = 34
        Me.GrandTotalTextBox.Text = "0.00"
        Me.GrandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TransactionHeaderBindingSource
        '
        Me.TransactionHeaderBindingSource.DataMember = "TransactionHeader"
        Me.TransactionHeaderBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'TransactionDetailsBindingSource2
        '
        Me.TransactionDetailsBindingSource2.DataMember = "TransactionDetails"
        Me.TransactionDetailsBindingSource2.DataSource = Me.Pos_dbDataSet
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'BrandBindingSource1
        '
        Me.BrandBindingSource1.DataMember = "Brand"
        Me.BrandBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(543, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(427, 268)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Search:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 50
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn1, Me.MinimumPrice, Me.MaximumPrice})
        Me.DataGridView1.DataSource = Me.ProductBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(21, 66)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(390, 187)
        Me.DataGridView1.TabIndex = 3
        '
        'TransactionDetailsTableAdapter
        '
        Me.TransactionDetailsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxRemainingQuantity)
        Me.GroupBox3.Controls.Add(DiscountedPriceLabel)
        Me.GroupBox3.Controls.Add(Me.DiscountedPriceTextBox)
        Me.GroupBox3.Controls.Add(OriginalPriceLabel)
        Me.GroupBox3.Controls.Add(Me.OriginalPriceTextBox)
        Me.GroupBox3.Controls.Add(SupplierNameLabel)
        Me.GroupBox3.Controls.Add(Me.SupplierNameComboBox)
        Me.GroupBox3.Controls.Add(BrandNameLabel)
        Me.GroupBox3.Controls.Add(Me.BrandNameComboBox)
        Me.GroupBox3.Controls.Add(CategoryNameLabel)
        Me.GroupBox3.Controls.Add(Me.CategoryNameComboBox)
        Me.GroupBox3.Controls.Add(BarcodeLabel)
        Me.GroupBox3.Controls.Add(Me.BarcodeTextBox)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox_TotalPerProduct)
        Me.GroupBox3.Controls.Add(Me.btnAddToCart)
        Me.GroupBox3.Controls.Add(QuantityLabel)
        Me.GroupBox3.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox3.Controls.Add(FinalPriceLabel)
        Me.GroupBox3.Controls.Add(Me.FinalPriceTextBox)
        Me.GroupBox3.Controls.Add(ProductNameLabel)
        Me.GroupBox3.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox3.Controls.Add(ProductCodeLabel)
        Me.GroupBox3.Controls.Add(Me.ProductCodeTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(543, 355)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 315)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Details"
        '
        'TextBoxRemainingQuantity
        '
        Me.TextBoxRemainingQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity", True))
        Me.TextBoxRemainingQuantity.Enabled = False
        Me.TextBoxRemainingQuantity.Location = New System.Drawing.Point(276, 98)
        Me.TextBoxRemainingQuantity.Name = "TextBoxRemainingQuantity"
        Me.TextBoxRemainingQuantity.Size = New System.Drawing.Size(118, 21)
        Me.TextBoxRemainingQuantity.TabIndex = 39
        Me.TextBoxRemainingQuantity.Text = "0"
        Me.TextBoxRemainingQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaximumPriceTextBox
        '
        Me.MaximumPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MaximumPrice", True))
        Me.MaximumPriceTextBox.Enabled = False
        Me.MaximumPriceTextBox.Location = New System.Drawing.Point(1144, 429)
        Me.MaximumPriceTextBox.Name = "MaximumPriceTextBox"
        Me.MaximumPriceTextBox.Size = New System.Drawing.Size(126, 21)
        Me.MaximumPriceTextBox.TabIndex = 37
        Me.MaximumPriceTextBox.Text = "0.00"
        Me.MaximumPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaximumPriceTextBox.Visible = False
        '
        'MinimumPriceTextBox
        '
        Me.MinimumPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "MinimumPrice", True))
        Me.MinimumPriceTextBox.Enabled = False
        Me.MinimumPriceTextBox.Location = New System.Drawing.Point(1016, 429)
        Me.MinimumPriceTextBox.Name = "MinimumPriceTextBox"
        Me.MinimumPriceTextBox.Size = New System.Drawing.Size(124, 21)
        Me.MinimumPriceTextBox.TabIndex = 36
        Me.MinimumPriceTextBox.Text = "0.00"
        Me.MinimumPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MinimumPriceTextBox.Visible = False
        '
        'DiscountedPriceTextBox
        '
        Me.DiscountedPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "DiscountedPrice", True))
        Me.DiscountedPriceTextBox.Location = New System.Drawing.Point(151, 227)
        Me.DiscountedPriceTextBox.Name = "DiscountedPriceTextBox"
        Me.DiscountedPriceTextBox.Size = New System.Drawing.Size(121, 21)
        Me.DiscountedPriceTextBox.TabIndex = 35
        Me.DiscountedPriceTextBox.Text = "0.00"
        Me.DiscountedPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountedPercTextBox
        '
        Me.DiscountedPercTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "DiscountedPerc", True))
        Me.DiscountedPercTextBox.Enabled = False
        Me.DiscountedPercTextBox.Location = New System.Drawing.Point(1016, 378)
        Me.DiscountedPercTextBox.Name = "DiscountedPercTextBox"
        Me.DiscountedPercTextBox.Size = New System.Drawing.Size(121, 21)
        Me.DiscountedPercTextBox.TabIndex = 34
        Me.DiscountedPercTextBox.Visible = False
        '
        'OriginalPriceTextBox
        '
        Me.OriginalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "OriginalPrice", True))
        Me.OriginalPriceTextBox.Enabled = False
        Me.OriginalPriceTextBox.Location = New System.Drawing.Point(17, 184)
        Me.OriginalPriceTextBox.Name = "OriginalPriceTextBox"
        Me.OriginalPriceTextBox.Size = New System.Drawing.Size(121, 21)
        Me.OriginalPriceTextBox.TabIndex = 33
        Me.OriginalPriceTextBox.Text = "0.00"
        Me.OriginalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SupplierNameComboBox
        '
        Me.SupplierNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "SupplierName", True))
        Me.SupplierNameComboBox.Enabled = False
        Me.SupplierNameComboBox.FormattingEnabled = True
        Me.SupplierNameComboBox.Location = New System.Drawing.Point(151, 95)
        Me.SupplierNameComboBox.Name = "SupplierNameComboBox"
        Me.SupplierNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SupplierNameComboBox.TabIndex = 32
        '
        'BrandNameComboBox
        '
        Me.BrandNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "BrandName", True))
        Me.BrandNameComboBox.Enabled = False
        Me.BrandNameComboBox.FormattingEnabled = True
        Me.BrandNameComboBox.Location = New System.Drawing.Point(274, 47)
        Me.BrandNameComboBox.Name = "BrandNameComboBox"
        Me.BrandNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.BrandNameComboBox.TabIndex = 31
        '
        'CategoryNameComboBox
        '
        Me.CategoryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "CategoryName", True))
        Me.CategoryNameComboBox.Enabled = False
        Me.CategoryNameComboBox.FormattingEnabled = True
        Me.CategoryNameComboBox.Location = New System.Drawing.Point(17, 95)
        Me.CategoryNameComboBox.Name = "CategoryNameComboBox"
        Me.CategoryNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.CategoryNameComboBox.TabIndex = 30
        '
        'BarcodeTextBox
        '
        Me.BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Barcode", True))
        Me.BarcodeTextBox.Enabled = False
        Me.BarcodeTextBox.Location = New System.Drawing.Point(147, 47)
        Me.BarcodeTextBox.Name = "BarcodeTextBox"
        Me.BarcodeTextBox.Size = New System.Drawing.Size(121, 21)
        Me.BarcodeTextBox.TabIndex = 29
        '
        'TextBox_TotalPerProduct
        '
        Me.TextBox_TotalPerProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "FinalPrice", True))
        Me.TextBox_TotalPerProduct.Enabled = False
        Me.TextBox_TotalPerProduct.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.TextBox_TotalPerProduct.Location = New System.Drawing.Point(272, 267)
        Me.TextBox_TotalPerProduct.Name = "TextBox_TotalPerProduct"
        Me.TextBox_TotalPerProduct.Size = New System.Drawing.Size(126, 37)
        Me.TextBox_TotalPerProduct.TabIndex = 28
        Me.TextBox_TotalPerProduct.Text = "0.00"
        Me.TextBox_TotalPerProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddToCart.FlatAppearance.BorderSize = 0
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToCart.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAddToCart.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btnAddToCart.IconColor = System.Drawing.Color.White
        Me.btnAddToCart.IconSize = 30
        Me.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddToCart.Location = New System.Drawing.Point(17, 265)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Rotation = 0R
        Me.btnAddToCart.Size = New System.Drawing.Size(118, 38)
        Me.btnAddToCart.TabIndex = 26
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(17, 227)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(118, 21)
        Me.QuantityTextBox.TabIndex = 7
        Me.QuantityTextBox.Text = "0"
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FinalPriceTextBox
        '
        Me.FinalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "FinalPrice", True))
        Me.FinalPriceTextBox.Enabled = False
        Me.FinalPriceTextBox.Location = New System.Drawing.Point(151, 184)
        Me.FinalPriceTextBox.Name = "FinalPriceTextBox"
        Me.FinalPriceTextBox.Size = New System.Drawing.Size(121, 21)
        Me.FinalPriceTextBox.TabIndex = 5
        Me.FinalPriceTextBox.Text = "0.00"
        Me.FinalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Enabled = False
        Me.ProductNameTextBox.Location = New System.Drawing.Point(17, 141)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(381, 21)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductCode", True))
        Me.ProductCodeTextBox.Enabled = False
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(17, 47)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(118, 21)
        Me.ProductCodeTextBox.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ComboBoxInvoice)
        Me.Panel2.Controls.Add(Me.IconButtonSearch)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.btnNewTransaction)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 73)
        Me.Panel2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Invoice No:"
        '
        'ComboBoxInvoice
        '
        Me.ComboBoxInvoice.FormattingEnabled = True
        Me.ComboBoxInvoice.Location = New System.Drawing.Point(690, 34)
        Me.ComboBoxInvoice.Name = "ComboBoxInvoice"
        Me.ComboBoxInvoice.Size = New System.Drawing.Size(130, 24)
        Me.ComboBoxInvoice.TabIndex = 44
        '
        'IconButtonSearch
        '
        Me.IconButtonSearch.BackColor = System.Drawing.Color.OrangeRed
        Me.IconButtonSearch.FlatAppearance.BorderSize = 0
        Me.IconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButtonSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSearch.ForeColor = System.Drawing.Color.White
        Me.IconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButtonSearch.IconColor = System.Drawing.Color.White
        Me.IconButtonSearch.IconSize = 30
        Me.IconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonSearch.Location = New System.Drawing.Point(825, 20)
        Me.IconButtonSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButtonSearch.Name = "IconButtonSearch"
        Me.IconButtonSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.IconButtonSearch.Rotation = 0R
        Me.IconButtonSearch.Size = New System.Drawing.Size(146, 38)
        Me.IconButtonSearch.TabIndex = 43
        Me.IconButtonSearch.Text = "Find New/Hold"
        Me.IconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonSearch.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(IdLabel)
        Me.GroupBox4.Controls.Add(CustomerNameLabel)
        Me.GroupBox4.Controls.Add(Me.PaymentStatusTextBox)
        Me.GroupBox4.Controls.Add(Me.CustomerNameTextBox)
        Me.GroupBox4.Controls.Add(PaymentStatusLabel)
        Me.GroupBox4.Controls.Add(Me.PaymentChangeTextBox)
        Me.GroupBox4.Controls.Add(Me.IdTextBox)
        Me.GroupBox4.Controls.Add(PaymentChangeLabel)
        Me.GroupBox4.Controls.Add(PersonnelIdLabel)
        Me.GroupBox4.Controls.Add(Me.PaymentAmountTextBox)
        Me.GroupBox4.Controls.Add(Me.PersonnelIdTextBox)
        Me.GroupBox4.Controls.Add(PaymentAmountLabel)
        Me.GroupBox4.Controls.Add(InvoiceNoLabel)
        Me.GroupBox4.Controls.Add(Me.InvoiceNoTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(183, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(495, 67)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'PaymentStatusTextBox
        '
        Me.PaymentStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "PaymentStatus", True))
        Me.PaymentStatusTextBox.Enabled = False
        Me.PaymentStatusTextBox.Location = New System.Drawing.Point(404, 36)
        Me.PaymentStatusTextBox.Name = "PaymentStatusTextBox"
        Me.PaymentStatusTextBox.Size = New System.Drawing.Size(67, 21)
        Me.PaymentStatusTextBox.TabIndex = 40
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "CustomerName", True))
        Me.CustomerNameTextBox.Enabled = False
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(221, 36)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(58, 21)
        Me.CustomerNameTextBox.TabIndex = 41
        '
        'PaymentChangeTextBox
        '
        Me.PaymentChangeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "PaymentChange", True))
        Me.PaymentChangeTextBox.Enabled = False
        Me.PaymentChangeTextBox.Location = New System.Drawing.Point(341, 36)
        Me.PaymentChangeTextBox.Name = "PaymentChangeTextBox"
        Me.PaymentChangeTextBox.Size = New System.Drawing.Size(57, 21)
        Me.PaymentChangeTextBox.TabIndex = 38
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(23, 36)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(44, 21)
        Me.IdTextBox.TabIndex = 28
        '
        'PaymentAmountTextBox
        '
        Me.PaymentAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "PaymentAmount", True))
        Me.PaymentAmountTextBox.Enabled = False
        Me.PaymentAmountTextBox.Location = New System.Drawing.Point(285, 36)
        Me.PaymentAmountTextBox.Name = "PaymentAmountTextBox"
        Me.PaymentAmountTextBox.Size = New System.Drawing.Size(50, 21)
        Me.PaymentAmountTextBox.TabIndex = 36
        '
        'PersonnelIdTextBox
        '
        Me.PersonnelIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "PersonnelId", True))
        Me.PersonnelIdTextBox.Enabled = False
        Me.PersonnelIdTextBox.Location = New System.Drawing.Point(73, 36)
        Me.PersonnelIdTextBox.Name = "PersonnelIdTextBox"
        Me.PersonnelIdTextBox.Size = New System.Drawing.Size(68, 21)
        Me.PersonnelIdTextBox.TabIndex = 30
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionHeaderBindingSource, "InvoiceNo", True))
        Me.InvoiceNoTextBox.Enabled = False
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(147, 36)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(68, 21)
        Me.InvoiceNoTextBox.TabIndex = 32
        '
        'btnNewTransaction
        '
        Me.btnNewTransaction.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNewTransaction.FlatAppearance.BorderSize = 0
        Me.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewTransaction.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNewTransaction.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTransaction.ForeColor = System.Drawing.Color.White
        Me.btnNewTransaction.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNewTransaction.IconColor = System.Drawing.Color.White
        Me.btnNewTransaction.IconSize = 30
        Me.btnNewTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewTransaction.Location = New System.Drawing.Point(19, 19)
        Me.btnNewTransaction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewTransaction.Name = "btnNewTransaction"
        Me.btnNewTransaction.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNewTransaction.Rotation = 0R
        Me.btnNewTransaction.Size = New System.Drawing.Size(146, 38)
        Me.btnNewTransaction.TabIndex = 27
        Me.btnNewTransaction.Text = "New Transaction"
        Me.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewTransaction.UseVisualStyleBackColor = False
        '
        'TransactionHeaderTableAdapter
        '
        Me.TransactionHeaderTableAdapter.ClearBeforeFill = True
        '
        'TransactionDetailsBindingSource1
        '
        Me.TransactionDetailsBindingSource1.DataMember = "TransactionDetails"
        Me.TransactionDetailsBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 25.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 123
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn2.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "PCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ProductImage"
        Me.DataGridViewImageColumn1.HeaderText = "ProductImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Barcode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CategoryName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BrandName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BrandName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SupplierName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SupplierName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "OriginalPrice"
        Me.DataGridViewTextBoxColumn8.HeaderText = "OriginalPrice"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DiscountedPerc"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DiscountedPerc"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DiscountedDateFrom"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DiscountedDateFrom"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DiscountedDateTo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "DiscountedDateTo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DiscountedPrice"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DiscountedPrice"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FinalPrice"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn13.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "SellingPrice"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Quantity"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn14.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsInstock"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsInstock"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
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
        'PointOfSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1299, 678)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(MaximumPriceLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(DiscountedPercLabel)
        Me.Controls.Add(Me.DiscountedPercTextBox)
        Me.Controls.Add(Me.MaximumPriceTextBox)
        Me.Controls.Add(MinimumPriceLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MinimumPriceTextBox)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PointOfSale"
        Me.Text = "PointOfSale"
        CType(Me.TransactionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDetailsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TransactionHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionDetailsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TransactionDetailsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As pos_dbDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BrandTableAdapter As pos_dbDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents CategoryTableAdapter As pos_dbDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents ProductTableAdapter As pos_dbDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents CategoryBindingSource2 As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandBindingSource1 As BindingSource
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CategoryBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents TransactionDetailsBindingSource As BindingSource
    Friend WithEvents TransactionDetailsTableAdapter As pos_dbDataSetTableAdapters.TransactionDetailsTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox_TotalPerProduct As TextBox
    Friend WithEvents btnAddToCart As FontAwesome.Sharp.IconButton
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents FinalPriceTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents DiscountedPriceTextBox As TextBox
    Friend WithEvents DiscountedPercTextBox As TextBox
    Friend WithEvents OriginalPriceTextBox As TextBox
    Friend WithEvents SupplierNameComboBox As ComboBox
    Friend WithEvents BrandNameComboBox As ComboBox
    Friend WithEvents CategoryNameComboBox As ComboBox
    Friend WithEvents BarcodeTextBox As TextBox
    Friend WithEvents btnNewTransaction As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TransactionHeaderBindingSource As BindingSource
    Friend WithEvents TransactionHeaderTableAdapter As pos_dbDataSetTableAdapters.TransactionHeaderTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents PersonnelIdTextBox As TextBox
    Friend WithEvents InvoiceNoTextBox As TextBox
    Friend WithEvents GrandTotalTextBox As TextBox
    Friend WithEvents PaymentAmountTextBox As TextBox
    Friend WithEvents PaymentChangeTextBox As TextBox
    Friend WithEvents PaymentStatusTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TransactionDetailsBindingSource2 As BindingSource
    Friend WithEvents TransactionDetailsBindingSource1 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TransactionDetailsBindingSource3 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionHeaderIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPercDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRemove As DataGridViewImageColumn
    Friend WithEvents MaximumPriceTextBox As TextBox
    Friend WithEvents MinimumPriceTextBox As TextBox
    Friend WithEvents IconButtonSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ComboBoxInvoice As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRemainingQuantity As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents MinimumPrice As DataGridViewTextBoxColumn
    Friend WithEvents MaximumPrice As DataGridViewTextBoxColumn
End Class
