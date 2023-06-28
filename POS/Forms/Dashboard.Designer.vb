<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_total_income = New System.Windows.Forms.Label()
        Me.Label_total_income_today = New System.Windows.Forms.Label()
        Me.Label_total_customer_today = New System.Windows.Forms.Label()
        Me.Label_total_customer = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label_total_supplier_today = New System.Windows.Forms.Label()
        Me.Label_total_supplier = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label_total_product_today = New System.Windows.Forms.Label()
        Me.Label_total_product = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.VwTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PersonnelIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrandTotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentAmountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentChangeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarcodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPercDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedByDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwTransactionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_TransactionsTableAdapter = New POS.pos_dbDataSetTableAdapters.vw_TransactionsTableAdapter()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransactionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Orange
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 139
        Me.IconPictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(233, 139)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(144, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Today"
        '
        'Label_total_income
        '
        Me.Label_total_income.AutoSize = True
        Me.Label_total_income.BackColor = System.Drawing.Color.Orange
        Me.Label_total_income.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_income.ForeColor = System.Drawing.Color.White
        Me.Label_total_income.Location = New System.Drawing.Point(142, 52)
        Me.Label_total_income.Name = "Label_total_income"
        Me.Label_total_income.Size = New System.Drawing.Size(51, 16)
        Me.Label_total_income.TabIndex = 6
        Me.Label_total_income.Text = "-- --- --"
        '
        'Label_total_income_today
        '
        Me.Label_total_income_today.AutoSize = True
        Me.Label_total_income_today.BackColor = System.Drawing.Color.Orange
        Me.Label_total_income_today.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_income_today.ForeColor = System.Drawing.Color.White
        Me.Label_total_income_today.Location = New System.Drawing.Point(142, 105)
        Me.Label_total_income_today.Name = "Label_total_income_today"
        Me.Label_total_income_today.Size = New System.Drawing.Size(51, 16)
        Me.Label_total_income_today.TabIndex = 7
        Me.Label_total_income_today.Text = "-- --- --"
        '
        'Label_total_customer_today
        '
        Me.Label_total_customer_today.AutoSize = True
        Me.Label_total_customer_today.BackColor = System.Drawing.Color.ForestGreen
        Me.Label_total_customer_today.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_customer_today.ForeColor = System.Drawing.Color.White
        Me.Label_total_customer_today.Location = New System.Drawing.Point(381, 105)
        Me.Label_total_customer_today.Name = "Label_total_customer_today"
        Me.Label_total_customer_today.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_customer_today.TabIndex = 12
        Me.Label_total_customer_today.Text = "-- --- --"
        '
        'Label_total_customer
        '
        Me.Label_total_customer.AutoSize = True
        Me.Label_total_customer.BackColor = System.Drawing.Color.ForestGreen
        Me.Label_total_customer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_customer.ForeColor = System.Drawing.Color.White
        Me.Label_total_customer.Location = New System.Drawing.Point(381, 52)
        Me.Label_total_customer.Name = "Label_total_customer"
        Me.Label_total_customer.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_customer.TabIndex = 11
        Me.Label_total_customer.Text = "-- --- --"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(383, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Today"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.ForestGreen
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(375, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Customer"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconSize = 139
        Me.IconPictureBox2.Location = New System.Drawing.Point(251, 12)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(233, 139)
        Me.IconPictureBox2.TabIndex = 8
        Me.IconPictureBox2.TabStop = False
        '
        'Label_total_supplier_today
        '
        Me.Label_total_supplier_today.AutoSize = True
        Me.Label_total_supplier_today.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label_total_supplier_today.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_supplier_today.ForeColor = System.Drawing.Color.White
        Me.Label_total_supplier_today.Location = New System.Drawing.Point(621, 105)
        Me.Label_total_supplier_today.Name = "Label_total_supplier_today"
        Me.Label_total_supplier_today.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_supplier_today.TabIndex = 17
        Me.Label_total_supplier_today.Text = "-- --- --"
        '
        'Label_total_supplier
        '
        Me.Label_total_supplier.AutoSize = True
        Me.Label_total_supplier.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label_total_supplier.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_supplier.ForeColor = System.Drawing.Color.White
        Me.Label_total_supplier.Location = New System.Drawing.Point(621, 52)
        Me.Label_total_supplier.Name = "Label_total_supplier"
        Me.Label_total_supplier.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_supplier.TabIndex = 16
        Me.Label_total_supplier.Text = "-- --- --"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(623, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Today"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(623, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Total Supplier"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserSecret
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconSize = 139
        Me.IconPictureBox3.Location = New System.Drawing.Point(491, 12)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(233, 139)
        Me.IconPictureBox3.TabIndex = 13
        Me.IconPictureBox3.TabStop = False
        '
        'Label_total_product_today
        '
        Me.Label_total_product_today.AutoSize = True
        Me.Label_total_product_today.BackColor = System.Drawing.Color.Red
        Me.Label_total_product_today.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_product_today.ForeColor = System.Drawing.Color.White
        Me.Label_total_product_today.Location = New System.Drawing.Point(860, 105)
        Me.Label_total_product_today.Name = "Label_total_product_today"
        Me.Label_total_product_today.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_product_today.TabIndex = 22
        Me.Label_total_product_today.Text = "-- --- --"
        '
        'Label_total_product
        '
        Me.Label_total_product.AutoSize = True
        Me.Label_total_product.BackColor = System.Drawing.Color.Red
        Me.Label_total_product.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_total_product.ForeColor = System.Drawing.Color.White
        Me.Label_total_product.Location = New System.Drawing.Point(860, 52)
        Me.Label_total_product.Name = "Label_total_product"
        Me.Label_total_product.Size = New System.Drawing.Size(87, 25)
        Me.Label_total_product.TabIndex = 21
        Me.Label_total_product.Text = "-- --- --"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Red
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(862, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Today"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Red
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(862, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Total Products"
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.Red
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Tachometer
        Me.IconPictureBox4.IconColor = System.Drawing.Color.White
        Me.IconPictureBox4.IconSize = 139
        Me.IconPictureBox4.Location = New System.Drawing.Point(730, 12)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(233, 139)
        Me.IconPictureBox4.TabIndex = 18
        Me.IconPictureBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CategoryDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 493)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recent Activities"
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
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CategoryDataGridView.ColumnHeadersHeight = 50
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonnelIdDataGridViewTextBoxColumn, Me.InvoiceNoDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.GrandTotalDataGridViewTextBoxColumn, Me.PaymentAmountDataGridViewTextBoxColumn, Me.PaymentChangeDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn, Me.TransactionHeaderIdDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.BarcodeDataGridViewTextBoxColumn, Me.OriginalPriceDataGridViewTextBoxColumn, Me.DiscountedPercDataGridViewTextBoxColumn, Me.DiscountedPriceDataGridViewTextBoxColumn, Me.FinalPriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn})
        Me.CategoryDataGridView.DataSource = Me.VwTransactionsBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(14, 21)
        Me.CategoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(448, 455)
        Me.CategoryDataGridView.TabIndex = 22
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PaymentStatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        Me.PaymentStatusDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Visible = False
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
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Visible = False
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TotalAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
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
        'VwTransactionsBindingSource
        '
        Me.VwTransactionsBindingSource.DataMember = "vw_Transactions"
        Me.VwTransactionsBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 493)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Top Selling Products"
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PersonnelIdDataGridViewTextBoxColumn1, Me.InvoiceNoDataGridViewTextBoxColumn1, Me.CustomerNameDataGridViewTextBoxColumn1, Me.GrandTotalDataGridViewTextBoxColumn1, Me.PaymentAmountDataGridViewTextBoxColumn1, Me.PaymentChangeDataGridViewTextBoxColumn1, Me.PaymentStatusDataGridViewTextBoxColumn1, Me.TransactionHeaderIdDataGridViewTextBoxColumn1, Me.ProductCodeDataGridViewTextBoxColumn1, Me.ProductNameDataGridViewTextBoxColumn1, Me.CategoryNameDataGridViewTextBoxColumn1, Me.BrandNameDataGridViewTextBoxColumn1, Me.SupplierNameDataGridViewTextBoxColumn1, Me.BarcodeDataGridViewTextBoxColumn1, Me.OriginalPriceDataGridViewTextBoxColumn1, Me.DiscountedPercDataGridViewTextBoxColumn1, Me.DiscountedPriceDataGridViewTextBoxColumn1, Me.FinalPriceDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.TotalAmountDataGridViewTextBoxColumn1, Me.CreatedAtDataGridViewTextBoxColumn1, Me.CreatedByDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.VwTransactionsBindingSource1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(14, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(450, 455)
        Me.DataGridView1.TabIndex = 22
        '
        'PersonnelIdDataGridViewTextBoxColumn1
        '
        Me.PersonnelIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonnelId"
        Me.PersonnelIdDataGridViewTextBoxColumn1.HeaderText = "PersonnelId"
        Me.PersonnelIdDataGridViewTextBoxColumn1.Name = "PersonnelIdDataGridViewTextBoxColumn1"
        Me.PersonnelIdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PersonnelIdDataGridViewTextBoxColumn1.Visible = False
        '
        'InvoiceNoDataGridViewTextBoxColumn1
        '
        Me.InvoiceNoDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn1.HeaderText = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn1.Name = "InvoiceNoDataGridViewTextBoxColumn1"
        Me.InvoiceNoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.InvoiceNoDataGridViewTextBoxColumn1.Visible = False
        '
        'CustomerNameDataGridViewTextBoxColumn1
        '
        Me.CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1"
        Me.CustomerNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn1.Visible = False
        '
        'GrandTotalDataGridViewTextBoxColumn1
        '
        Me.GrandTotalDataGridViewTextBoxColumn1.DataPropertyName = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn1.HeaderText = "GrandTotal"
        Me.GrandTotalDataGridViewTextBoxColumn1.Name = "GrandTotalDataGridViewTextBoxColumn1"
        Me.GrandTotalDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GrandTotalDataGridViewTextBoxColumn1.Visible = False
        '
        'PaymentAmountDataGridViewTextBoxColumn1
        '
        Me.PaymentAmountDataGridViewTextBoxColumn1.DataPropertyName = "PaymentAmount"
        Me.PaymentAmountDataGridViewTextBoxColumn1.HeaderText = "PaymentAmount"
        Me.PaymentAmountDataGridViewTextBoxColumn1.Name = "PaymentAmountDataGridViewTextBoxColumn1"
        Me.PaymentAmountDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PaymentAmountDataGridViewTextBoxColumn1.Visible = False
        '
        'PaymentChangeDataGridViewTextBoxColumn1
        '
        Me.PaymentChangeDataGridViewTextBoxColumn1.DataPropertyName = "PaymentChange"
        Me.PaymentChangeDataGridViewTextBoxColumn1.HeaderText = "PaymentChange"
        Me.PaymentChangeDataGridViewTextBoxColumn1.Name = "PaymentChangeDataGridViewTextBoxColumn1"
        Me.PaymentChangeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PaymentChangeDataGridViewTextBoxColumn1.Visible = False
        '
        'PaymentStatusDataGridViewTextBoxColumn1
        '
        Me.PaymentStatusDataGridViewTextBoxColumn1.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn1.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn1.Name = "PaymentStatusDataGridViewTextBoxColumn1"
        Me.PaymentStatusDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PaymentStatusDataGridViewTextBoxColumn1.Visible = False
        '
        'TransactionHeaderIdDataGridViewTextBoxColumn1
        '
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1.DataPropertyName = "TransactionHeaderId"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1.HeaderText = "TransactionHeaderId"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1.Name = "TransactionHeaderIdDataGridViewTextBoxColumn1"
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TransactionHeaderIdDataGridViewTextBoxColumn1.Visible = False
        '
        'ProductCodeDataGridViewTextBoxColumn1
        '
        Me.ProductCodeDataGridViewTextBoxColumn1.DataPropertyName = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn1.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn1.Name = "ProductCodeDataGridViewTextBoxColumn1"
        Me.ProductCodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CategoryNameDataGridViewTextBoxColumn1
        '
        Me.CategoryNameDataGridViewTextBoxColumn1.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn1.HeaderText = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn1.Name = "CategoryNameDataGridViewTextBoxColumn1"
        Me.CategoryNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CategoryNameDataGridViewTextBoxColumn1.Visible = False
        '
        'BrandNameDataGridViewTextBoxColumn1
        '
        Me.BrandNameDataGridViewTextBoxColumn1.DataPropertyName = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn1.HeaderText = "BrandName"
        Me.BrandNameDataGridViewTextBoxColumn1.Name = "BrandNameDataGridViewTextBoxColumn1"
        Me.BrandNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.BrandNameDataGridViewTextBoxColumn1.Visible = False
        '
        'SupplierNameDataGridViewTextBoxColumn1
        '
        Me.SupplierNameDataGridViewTextBoxColumn1.DataPropertyName = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn1.HeaderText = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn1.Name = "SupplierNameDataGridViewTextBoxColumn1"
        Me.SupplierNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SupplierNameDataGridViewTextBoxColumn1.Visible = False
        '
        'BarcodeDataGridViewTextBoxColumn1
        '
        Me.BarcodeDataGridViewTextBoxColumn1.DataPropertyName = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.BarcodeDataGridViewTextBoxColumn1.Name = "BarcodeDataGridViewTextBoxColumn1"
        Me.BarcodeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.BarcodeDataGridViewTextBoxColumn1.Visible = False
        '
        'OriginalPriceDataGridViewTextBoxColumn1
        '
        Me.OriginalPriceDataGridViewTextBoxColumn1.DataPropertyName = "OriginalPrice"
        Me.OriginalPriceDataGridViewTextBoxColumn1.HeaderText = "OriginalPrice"
        Me.OriginalPriceDataGridViewTextBoxColumn1.Name = "OriginalPriceDataGridViewTextBoxColumn1"
        Me.OriginalPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OriginalPriceDataGridViewTextBoxColumn1.Visible = False
        '
        'DiscountedPercDataGridViewTextBoxColumn1
        '
        Me.DiscountedPercDataGridViewTextBoxColumn1.DataPropertyName = "DiscountedPerc"
        Me.DiscountedPercDataGridViewTextBoxColumn1.HeaderText = "DiscountedPerc"
        Me.DiscountedPercDataGridViewTextBoxColumn1.Name = "DiscountedPercDataGridViewTextBoxColumn1"
        Me.DiscountedPercDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DiscountedPercDataGridViewTextBoxColumn1.Visible = False
        '
        'DiscountedPriceDataGridViewTextBoxColumn1
        '
        Me.DiscountedPriceDataGridViewTextBoxColumn1.DataPropertyName = "DiscountedPrice"
        Me.DiscountedPriceDataGridViewTextBoxColumn1.HeaderText = "DiscountedPrice"
        Me.DiscountedPriceDataGridViewTextBoxColumn1.Name = "DiscountedPriceDataGridViewTextBoxColumn1"
        Me.DiscountedPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DiscountedPriceDataGridViewTextBoxColumn1.Visible = False
        '
        'FinalPriceDataGridViewTextBoxColumn1
        '
        Me.FinalPriceDataGridViewTextBoxColumn1.DataPropertyName = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn1.HeaderText = "FinalPrice"
        Me.FinalPriceDataGridViewTextBoxColumn1.Name = "FinalPriceDataGridViewTextBoxColumn1"
        Me.FinalPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FinalPriceDataGridViewTextBoxColumn1.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuantityDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        Me.QuantityDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn1
        '
        Me.TotalAmountDataGridViewTextBoxColumn1.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn1.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn1.Name = "TotalAmountDataGridViewTextBoxColumn1"
        Me.TotalAmountDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TotalAmountDataGridViewTextBoxColumn1.Visible = False
        '
        'CreatedAtDataGridViewTextBoxColumn1
        '
        Me.CreatedAtDataGridViewTextBoxColumn1.DataPropertyName = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn1.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn1.Name = "CreatedAtDataGridViewTextBoxColumn1"
        Me.CreatedAtDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CreatedAtDataGridViewTextBoxColumn1.Visible = False
        '
        'CreatedByDataGridViewTextBoxColumn1
        '
        Me.CreatedByDataGridViewTextBoxColumn1.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn1.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn1.Name = "CreatedByDataGridViewTextBoxColumn1"
        Me.CreatedByDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CreatedByDataGridViewTextBoxColumn1.Visible = False
        '
        'VwTransactionsBindingSource1
        '
        Me.VwTransactionsBindingSource1.DataMember = "vw_Transactions"
        Me.VwTransactionsBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'Vw_TransactionsTableAdapter
        '
        Me.Vw_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 676)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_total_product_today)
        Me.Controls.Add(Me.Label_total_product)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IconPictureBox4)
        Me.Controls.Add(Me.Label_total_supplier_today)
        Me.Controls.Add(Me.Label_total_supplier)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.Label_total_customer_today)
        Me.Controls.Add(Me.Label_total_customer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.Label_total_income_today)
        Me.Controls.Add(Me.Label_total_income)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransactionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_total_income As Label
    Friend WithEvents Label_total_income_today As Label
    Friend WithEvents Label_total_customer_today As Label
    Friend WithEvents Label_total_customer As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label_total_supplier_today As Label
    Friend WithEvents Label_total_supplier As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label_total_product_today As Label
    Friend WithEvents Label_total_product As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents VwTransactionsBindingSource As BindingSource
    Friend WithEvents Vw_TransactionsTableAdapter As pos_dbDataSetTableAdapters.vw_TransactionsTableAdapter
    Friend WithEvents VwTransactionsBindingSource1 As BindingSource
    Friend WithEvents PersonnelIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GrandTotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentChangeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TransactionHeaderIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BarcodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents OriginalPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPercDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FinalPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
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
End Class
