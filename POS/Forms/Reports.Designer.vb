﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
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
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label_New = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label_Paid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label_Hold = New System.Windows.Forms.Label()
        Me.asdasd = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.VwTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Vw_TransactionsTableAdapter = New POS.pos_dbDataSetTableAdapters.vw_TransactionsTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PersonnelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonnelTableAdapter = New POS.pos_dbDataSetTableAdapters.PersonnelTableAdapter()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Paid_Capl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IconButtonPrint = New FontAwesome.Sharp.IconButton()
        Me.Label_ReturnVoid = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(259, 185)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(67, 16)
        Label11.TabIndex = 41
        Label11.Text = "Period from"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(492, 185)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(55, 16)
        Label12.TabIndex = 43
        Label12.Text = "Period to"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(1021, 84)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 16)
        Label2.TabIndex = 46
        Label2.Text = "Personnel"
        Label2.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(46, 201)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 21)
        Label3.TabIndex = 47
        Label3.Text = "List Of Sales"
        '
        'Label_New
        '
        Me.Label_New.AutoSize = True
        Me.Label_New.BackColor = System.Drawing.Color.Green
        Me.Label_New.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_New.ForeColor = System.Drawing.Color.White
        Me.Label_New.Location = New System.Drawing.Point(180, 62)
        Me.Label_New.Name = "Label_New"
        Me.Label_New.Size = New System.Drawing.Size(87, 25)
        Me.Label_New.TabIndex = 11
        Me.Label_New.Text = "-- --- --"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(182, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total New"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Green
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconSize = 139
        Me.IconPictureBox1.Location = New System.Drawing.Point(50, 22)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(280, 139)
        Me.IconPictureBox1.TabIndex = 8
        Me.IconPictureBox1.TabStop = False
        '
        'Label_Paid
        '
        Me.Label_Paid.AutoSize = True
        Me.Label_Paid.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label_Paid.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Paid.ForeColor = System.Drawing.Color.White
        Me.Label_Paid.Location = New System.Drawing.Point(475, 62)
        Me.Label_Paid.Name = "Label_Paid"
        Me.Label_Paid.Size = New System.Drawing.Size(87, 25)
        Me.Label_Paid.TabIndex = 16
        Me.Label_Paid.Text = "-- --- --"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(477, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Paid"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconSize = 139
        Me.IconPictureBox2.Location = New System.Drawing.Point(345, 22)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(280, 139)
        Me.IconPictureBox2.TabIndex = 13
        Me.IconPictureBox2.TabStop = False
        '
        'Label_Hold
        '
        Me.Label_Hold.AutoSize = True
        Me.Label_Hold.BackColor = System.Drawing.Color.Red
        Me.Label_Hold.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hold.ForeColor = System.Drawing.Color.White
        Me.Label_Hold.Location = New System.Drawing.Point(768, 62)
        Me.Label_Hold.Name = "Label_Hold"
        Me.Label_Hold.Size = New System.Drawing.Size(87, 25)
        Me.Label_Hold.TabIndex = 21
        Me.Label_Hold.Text = "-- --- --"
        '
        'asdasd
        '
        Me.asdasd.AutoSize = True
        Me.asdasd.BackColor = System.Drawing.Color.Red
        Me.asdasd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asdasd.ForeColor = System.Drawing.Color.White
        Me.asdasd.Location = New System.Drawing.Point(770, 46)
        Me.asdasd.Name = "asdasd"
        Me.asdasd.Size = New System.Drawing.Size(72, 16)
        Me.asdasd.TabIndex = 19
        Me.asdasd.Text = "Total Hold"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Red
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.HSquare
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconSize = 139
        Me.IconPictureBox3.Location = New System.Drawing.Point(638, 22)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(280, 139)
        Me.IconPictureBox3.TabIndex = 18
        Me.IconPictureBox3.TabStop = False
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(6, 7)
        Me.CategoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(956, 301)
        Me.CategoryDataGridView.TabIndex = 22
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(262, 204)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 21)
        Me.DateTimePicker1.TabIndex = 42
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(495, 204)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(227, 21)
        Me.DateTimePicker2.TabIndex = 44
        '
        'Vw_TransactionsTableAdapter
        '
        Me.Vw_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.PersonnelBindingSource
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1024, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 24)
        Me.ComboBox1.TabIndex = 45
        Me.ComboBox1.Visible = False
        '
        'PersonnelBindingSource
        '
        Me.PersonnelBindingSource.DataMember = "Personnel"
        Me.PersonnelBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'PersonnelTableAdapter
        '
        Me.PersonnelTableAdapter.ClearBeforeFill = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1141, 84)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 16)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "All Personnel"
        Me.LinkLabel1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(477, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Sell.Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(477, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Capl.Price"
        '
        'Label_Paid_Capl
        '
        Me.Label_Paid_Capl.AutoSize = True
        Me.Label_Paid_Capl.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label_Paid_Capl.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Paid_Capl.ForeColor = System.Drawing.Color.White
        Me.Label_Paid_Capl.Location = New System.Drawing.Point(475, 103)
        Me.Label_Paid_Capl.Name = "Label_Paid_Capl"
        Me.Label_Paid_Capl.Size = New System.Drawing.Size(87, 25)
        Me.Label_Paid_Capl.TabIndex = 50
        Me.Label_Paid_Capl.Text = "-- --- --"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(123, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Search Product Name:"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSearch.Location = New System.Drawing.Point(262, 230)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(12)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(460, 21)
        Me.TextBoxSearch.TabIndex = 52
        '
        'Chart2
        '
        Me.Chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.Location = New System.Drawing.Point(6, 6)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(956, 288)
        Me.Chart2.TabIndex = 54
        Me.Chart2.Text = "Chart2"
        Title1.Name = "asdasd"
        Title1.Text = "TOTAL SOLD PER DAY"
        Me.Chart2.Titles.Add(Title1)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 261)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(976, 344)
        Me.TabControl1.TabIndex = 55
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CategoryDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(968, 315)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(968, 315)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Analytics"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.IconButtonPrint.Location = New System.Drawing.Point(737, 212)
        Me.IconButtonPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButtonPrint.Name = "IconButtonPrint"
        Me.IconButtonPrint.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.IconButtonPrint.Rotation = 0R
        Me.IconButtonPrint.Size = New System.Drawing.Size(159, 36)
        Me.IconButtonPrint.TabIndex = 56
        Me.IconButtonPrint.Text = "View Details"
        Me.IconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPrint.UseVisualStyleBackColor = False
        '
        'Label_ReturnVoid
        '
        Me.Label_ReturnVoid.AutoSize = True
        Me.Label_ReturnVoid.BackColor = System.Drawing.Color.Red
        Me.Label_ReturnVoid.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ReturnVoid.ForeColor = System.Drawing.Color.White
        Me.Label_ReturnVoid.Location = New System.Drawing.Point(768, 119)
        Me.Label_ReturnVoid.Name = "Label_ReturnVoid"
        Me.Label_ReturnVoid.Size = New System.Drawing.Size(87, 25)
        Me.Label_ReturnVoid.TabIndex = 58
        Me.Label_ReturnVoid.Text = "-- --- --"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(770, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Total Return/Void"
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
        Me.InvoiceNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.InvoiceNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        Me.InvoiceNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceNoDataGridViewTextBoxColumn.Visible = False
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 115
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
        Me.PaymentStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PaymentStatusDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
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
        Me.ProductCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ProductCodeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 108
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
        Me.OriginalPriceDataGridViewTextBoxColumn.HeaderText = "Capl.Price"
        Me.OriginalPriceDataGridViewTextBoxColumn.Name = "OriginalPriceDataGridViewTextBoxColumn"
        Me.OriginalPriceDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.FinalPriceDataGridViewTextBoxColumn.HeaderText = "Sell.Price"
        Me.FinalPriceDataGridViewTextBoxColumn.Name = "FinalPriceDataGridViewTextBoxColumn"
        Me.FinalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.QuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TotalAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        DataGridViewCellStyle7.Format = "f"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.CreatedAtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedAtDataGridViewTextBoxColumn.Width = 88
        '
        'CreatedByDataGridViewTextBoxColumn
        '
        Me.CreatedByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreatedByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.Name = "CreatedByDataGridViewTextBoxColumn"
        Me.CreatedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedByDataGridViewTextBoxColumn.Visible = False
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1229, 617)
        Me.Controls.Add(Me.Label_ReturnVoid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IconButtonPrint)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label_Paid_Capl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label_Hold)
        Me.Controls.Add(Me.asdasd)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.Label_Paid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.Label_New)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonnelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_New As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label_Paid As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label_Hold As Label
    Friend WithEvents asdasd As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents VwTransactionsBindingSource As BindingSource
    Friend WithEvents Vw_TransactionsTableAdapter As pos_dbDataSetTableAdapters.vw_TransactionsTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PersonnelBindingSource As BindingSource
    Friend WithEvents PersonnelTableAdapter As pos_dbDataSetTableAdapters.PersonnelTableAdapter
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_Paid_Capl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents IconButtonPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents Label_ReturnVoid As Label
    Friend WithEvents Label9 As Label
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
