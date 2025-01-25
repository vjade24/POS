<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoidReturn
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
        Dim Label12 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.VwTransactionsnologoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.Vw_Transactions_nologoTableAdapter = New POS.pos_dbDataSetTableAdapters.vw_Transactions_nologoTableAdapter()
        Me.PersonnelIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrandTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.StoreNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SloganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThemeColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label12 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransactionsnologoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(384, 46)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(67, 17)
        Label12.TabIndex = 57
        Label12.Text = "Period to"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(151, 46)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(83, 17)
        Label11.TabIndex = 55
        Label11.Text = "Period from"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Search Product Name:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSearch.Location = New System.Drawing.Point(154, 91)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(12)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(460, 21)
        Me.TextBoxSearch.TabIndex = 60
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(387, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(227, 23)
        Me.DateTimePicker2.TabIndex = 58
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(154, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 23)
        Me.DateTimePicker1.TabIndex = 56
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.CategoryDataGridView.ColumnHeadersHeight = 50
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonnelIdDataGridViewTextBoxColumn, Me.InvoiceNoDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.GrandTotalDataGridViewTextBoxColumn, Me.PaymentAmountDataGridViewTextBoxColumn, Me.PaymentChangeDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn, Me.TransactionHeaderIdDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.OriginalPriceDataGridViewTextBoxColumn, Me.DiscountedPercDataGridViewTextBoxColumn, Me.DiscountedPriceDataGridViewTextBoxColumn, Me.FinalPriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn, Me.StoreNameDataGridViewTextBoxColumn, Me.SloganDataGridViewTextBoxColumn, Me.ThemeColorDataGridViewTextBoxColumn, Me.TinNoDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.StoreAddressDataGridViewTextBoxColumn})
        Me.CategoryDataGridView.DataSource = Me.VwTransactionsnologoBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(12, 128)
        Me.CategoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(956, 301)
        Me.CategoryDataGridView.TabIndex = 54
        '
        'VwTransactionsnologoBindingSource
        '
        Me.VwTransactionsnologoBindingSource.DataMember = "vw_Transactions_nologo"
        Me.VwTransactionsnologoBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_Transactions_nologoTableAdapter
        '
        Me.Vw_Transactions_nologoTableAdapter.ClearBeforeFill = True
        '
        'PersonnelIdDataGridViewTextBoxColumn
        '
        Me.PersonnelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonnelId"
        Me.PersonnelIdDataGridViewTextBoxColumn.HeaderText = "PersonnelId"
        Me.PersonnelIdDataGridViewTextBoxColumn.Name = "PersonnelIdDataGridViewTextBoxColumn"
        Me.PersonnelIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.PersonnelIdDataGridViewTextBoxColumn.Visible = False
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        Me.InvoiceNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrandTotalDataGridViewTextBoxColumn
        '
        Me.GrandTotalDataGridViewTextBoxColumn.DataPropertyName = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn.HeaderText = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn.Name = "GrandTotalDataGridViewTextBoxColumn"
        Me.GrandTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrandTotalDataGridViewTextBoxColumn.Visible = False
        '
        'PaymentAmountDataGridViewTextBoxColumn
        '
        Me.PaymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount"
        Me.PaymentAmountDataGridViewTextBoxColumn.HeaderText = "PaymentAmount"
        Me.PaymentAmountDataGridViewTextBoxColumn.Name = "PaymentAmountDataGridViewTextBoxColumn"
        Me.PaymentAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentAmountDataGridViewTextBoxColumn.Visible = False
        '
        'PaymentChangeDataGridViewTextBoxColumn
        '
        Me.PaymentChangeDataGridViewTextBoxColumn.DataPropertyName = "PaymentChange"
        Me.PaymentChangeDataGridViewTextBoxColumn.HeaderText = "PaymentChange"
        Me.PaymentChangeDataGridViewTextBoxColumn.Name = "PaymentChangeDataGridViewTextBoxColumn"
        Me.PaymentChangeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentChangeDataGridViewTextBoxColumn.Visible = False
        '
        'PaymentStatusDataGridViewTextBoxColumn
        '
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        Me.PaymentStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentStatusDataGridViewTextBoxColumn.Visible = False
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
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 123
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
        Me.FinalPriceDataGridViewTextBoxColumn.DataPropertyName = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn.HeaderText = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn.Name = "FinalPriceDataGridViewTextBoxColumn"
        Me.FinalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.FinalPriceDataGridViewTextBoxColumn.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 87
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.TotalAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedByDataGridViewTextBoxColumn
        '
        Me.CreatedByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.Name = "CreatedByDataGridViewTextBoxColumn"
        Me.CreatedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StoreNameDataGridViewTextBoxColumn
        '
        Me.StoreNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName"
        Me.StoreNameDataGridViewTextBoxColumn.HeaderText = "StoreName"
        Me.StoreNameDataGridViewTextBoxColumn.Name = "StoreNameDataGridViewTextBoxColumn"
        Me.StoreNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreNameDataGridViewTextBoxColumn.Visible = False
        '
        'SloganDataGridViewTextBoxColumn
        '
        Me.SloganDataGridViewTextBoxColumn.DataPropertyName = "Slogan"
        Me.SloganDataGridViewTextBoxColumn.HeaderText = "Slogan"
        Me.SloganDataGridViewTextBoxColumn.Name = "SloganDataGridViewTextBoxColumn"
        Me.SloganDataGridViewTextBoxColumn.ReadOnly = True
        Me.SloganDataGridViewTextBoxColumn.Visible = False
        '
        'ThemeColorDataGridViewTextBoxColumn
        '
        Me.ThemeColorDataGridViewTextBoxColumn.DataPropertyName = "ThemeColor"
        Me.ThemeColorDataGridViewTextBoxColumn.HeaderText = "ThemeColor"
        Me.ThemeColorDataGridViewTextBoxColumn.Name = "ThemeColorDataGridViewTextBoxColumn"
        Me.ThemeColorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ThemeColorDataGridViewTextBoxColumn.Visible = False
        '
        'TinNoDataGridViewTextBoxColumn
        '
        Me.TinNoDataGridViewTextBoxColumn.DataPropertyName = "TinNo"
        Me.TinNoDataGridViewTextBoxColumn.HeaderText = "TinNo"
        Me.TinNoDataGridViewTextBoxColumn.Name = "TinNoDataGridViewTextBoxColumn"
        Me.TinNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TinNoDataGridViewTextBoxColumn.Visible = False
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNoDataGridViewTextBoxColumn.Visible = False
        '
        'StoreAddressDataGridViewTextBoxColumn
        '
        Me.StoreAddressDataGridViewTextBoxColumn.DataPropertyName = "StoreAddress"
        Me.StoreAddressDataGridViewTextBoxColumn.HeaderText = "StoreAddress"
        Me.StoreAddressDataGridViewTextBoxColumn.Name = "StoreAddressDataGridViewTextBoxColumn"
        Me.StoreAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreAddressDataGridViewTextBoxColumn.Visible = False
        '
        'VoidReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 588)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CategoryDataGridView)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VoidReturn"
        Me.Text = "VoidReturn"
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransactionsnologoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents VwTransactionsnologoBindingSource As BindingSource
    Friend WithEvents Vw_Transactions_nologoTableAdapter As pos_dbDataSetTableAdapters.vw_Transactions_nologoTableAdapter
    Friend WithEvents PersonnelIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrandTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents StoreNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SloganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThemeColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TinNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StoreAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
