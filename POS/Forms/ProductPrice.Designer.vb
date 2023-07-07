<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductPrice
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
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim OldOriginalPriceLabel As System.Windows.Forms.Label
        Dim OldFinalPriceLabel As System.Windows.Forms.Label
        Dim NewOriginalPriceLabel As System.Windows.Forms.Label
        Dim NewFinalPriceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OldOriginalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.OldFinalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.NewOriginalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.NewFinalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductPriceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTableAdapter = New POS.pos_dbDataSetTableAdapters.ProductPriceTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldOriginalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldFinalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewOriginalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewFinalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductCodeLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        OldOriginalPriceLabel = New System.Windows.Forms.Label()
        OldFinalPriceLabel = New System.Windows.Forms.Label()
        NewOriginalPriceLabel = New System.Windows.Forms.Label()
        NewFinalPriceLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ProductPriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPriceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(132, 81)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(88, 16)
        ProductCodeLabel.TabIndex = 16
        ProductCodeLabel.Text = "Product Code:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(130, 108)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(90, 16)
        ProductNameLabel.TabIndex = 18
        ProductNameLabel.Text = "Product Name:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(428, 81)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 14
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'OldOriginalPriceLabel
        '
        OldOriginalPriceLabel.AutoSize = True
        OldOriginalPriceLabel.Location = New System.Drawing.Point(111, 64)
        OldOriginalPriceLabel.Name = "OldOriginalPriceLabel"
        OldOriginalPriceLabel.Size = New System.Drawing.Size(104, 16)
        OldOriginalPriceLabel.TabIndex = 29
        OldOriginalPriceLabel.Text = "Old Capital Price:"
        '
        'OldFinalPriceLabel
        '
        OldFinalPriceLabel.AutoSize = True
        OldFinalPriceLabel.Location = New System.Drawing.Point(111, 117)
        OldFinalPriceLabel.Name = "OldFinalPriceLabel"
        OldFinalPriceLabel.Size = New System.Drawing.Size(96, 16)
        OldFinalPriceLabel.TabIndex = 31
        OldFinalPriceLabel.Text = "Old Selling Price:"
        '
        'NewOriginalPriceLabel
        '
        NewOriginalPriceLabel.AutoSize = True
        NewOriginalPriceLabel.Location = New System.Drawing.Point(320, 64)
        NewOriginalPriceLabel.Name = "NewOriginalPriceLabel"
        NewOriginalPriceLabel.Size = New System.Drawing.Size(109, 16)
        NewOriginalPriceLabel.TabIndex = 33
        NewOriginalPriceLabel.Text = "New Capital Price:"
        '
        'NewFinalPriceLabel
        '
        NewFinalPriceLabel.AutoSize = True
        NewFinalPriceLabel.Location = New System.Drawing.Point(320, 117)
        NewFinalPriceLabel.Name = "NewFinalPriceLabel"
        NewFinalPriceLabel.Size = New System.Drawing.Size(101, 16)
        NewFinalPriceLabel.TabIndex = 35
        NewFinalPriceLabel.Text = "New Selling Price:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(129, 158)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(674, 319)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(OldOriginalPriceLabel)
        Me.TabPage1.Controls.Add(Me.OldOriginalPriceTextBox)
        Me.TabPage1.Controls.Add(OldFinalPriceLabel)
        Me.TabPage1.Controls.Add(Me.OldFinalPriceTextBox)
        Me.TabPage1.Controls.Add(NewOriginalPriceLabel)
        Me.TabPage1.Controls.Add(Me.NewOriginalPriceTextBox)
        Me.TabPage1.Controls.Add(NewFinalPriceLabel)
        Me.TabPage1.Controls.Add(Me.NewFinalPriceTextBox)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(666, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product Price"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'OldOriginalPriceTextBox
        '
        Me.OldOriginalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductPriceBindingSource, "OldOriginalPrice", True))
        Me.OldOriginalPriceTextBox.Enabled = False
        Me.OldOriginalPriceTextBox.Location = New System.Drawing.Point(114, 83)
        Me.OldOriginalPriceTextBox.Name = "OldOriginalPriceTextBox"
        Me.OldOriginalPriceTextBox.Size = New System.Drawing.Size(200, 21)
        Me.OldOriginalPriceTextBox.TabIndex = 30
        Me.OldOriginalPriceTextBox.Text = "0.00"
        Me.OldOriginalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProductPriceBindingSource
        '
        Me.ProductPriceBindingSource.DataMember = "ProductPrice"
        Me.ProductPriceBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OldFinalPriceTextBox
        '
        Me.OldFinalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductPriceBindingSource, "OldFinalPrice", True))
        Me.OldFinalPriceTextBox.Enabled = False
        Me.OldFinalPriceTextBox.Location = New System.Drawing.Point(114, 136)
        Me.OldFinalPriceTextBox.Name = "OldFinalPriceTextBox"
        Me.OldFinalPriceTextBox.Size = New System.Drawing.Size(200, 21)
        Me.OldFinalPriceTextBox.TabIndex = 32
        Me.OldFinalPriceTextBox.Text = "0.00"
        Me.OldFinalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NewOriginalPriceTextBox
        '
        Me.NewOriginalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductPriceBindingSource, "NewOriginalPrice", True))
        Me.NewOriginalPriceTextBox.Location = New System.Drawing.Point(323, 83)
        Me.NewOriginalPriceTextBox.Name = "NewOriginalPriceTextBox"
        Me.NewOriginalPriceTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NewOriginalPriceTextBox.TabIndex = 34
        Me.NewOriginalPriceTextBox.Text = "0.00"
        Me.NewOriginalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NewFinalPriceTextBox
        '
        Me.NewFinalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductPriceBindingSource, "NewFinalPrice", True))
        Me.NewFinalPriceTextBox.Location = New System.Drawing.Point(323, 136)
        Me.NewFinalPriceTextBox.Name = "NewFinalPriceTextBox"
        Me.NewFinalPriceTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NewFinalPriceTextBox.TabIndex = 36
        Me.NewFinalPriceTextBox.Text = "0.00"
        Me.NewFinalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.BtnSave.IconColor = System.Drawing.Color.White
        Me.BtnSave.IconSize = 30
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(229, 181)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.BtnSave.Rotation = 0R
        Me.BtnSave.Size = New System.Drawing.Size(161, 36)
        Me.BtnSave.TabIndex = 24
        Me.BtnSave.Text = "Change Price"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CategoryDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(666, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Product Price History"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.OldOriginalPriceDataGridViewTextBoxColumn, Me.OldFinalPriceDataGridViewTextBoxColumn, Me.NewOriginalPriceDataGridViewTextBoxColumn, Me.NewFinalPriceDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn})
        Me.CategoryDataGridView.DataSource = Me.ProductPriceBindingSource1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(6, 17)
        Me.CategoryDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(647, 240)
        Me.CategoryDataGridView.TabIndex = 4
        '
        'ProductPriceBindingSource1
        '
        Me.ProductPriceBindingSource1.DataMember = "ProductPrice"
        Me.ProductPriceBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.Enabled = False
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(226, 78)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(196, 21)
        Me.ProductCodeTextBox.TabIndex = 17
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(456, 78)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(55, 21)
        Me.IdTextBox.TabIndex = 15
        Me.IdTextBox.Visible = False
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Enabled = False
        Me.ProductNameTextBox.Location = New System.Drawing.Point(226, 108)
        Me.ProductNameTextBox.Multiline = True
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(573, 31)
        Me.ProductNameTextBox.TabIndex = 20
        '
        'ProductPriceTableAdapter
        '
        Me.ProductPriceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductPriceTableAdapter = Me.ProductPriceTableAdapter
        Me.TableAdapterManager.ProductQuantityTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StoreTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCodeDataGridViewTextBoxColumn.Visible = False
        '
        'OldOriginalPriceDataGridViewTextBoxColumn
        '
        Me.OldOriginalPriceDataGridViewTextBoxColumn.DataPropertyName = "OldOriginalPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.OldOriginalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OldOriginalPriceDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.OldOriginalPriceDataGridViewTextBoxColumn.HeaderText = "OldOriginalPrice"
        Me.OldOriginalPriceDataGridViewTextBoxColumn.Name = "OldOriginalPriceDataGridViewTextBoxColumn"
        Me.OldOriginalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OldFinalPriceDataGridViewTextBoxColumn
        '
        Me.OldFinalPriceDataGridViewTextBoxColumn.DataPropertyName = "OldFinalPrice"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.OldFinalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.OldFinalPriceDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.OldFinalPriceDataGridViewTextBoxColumn.HeaderText = "OldFinalPrice"
        Me.OldFinalPriceDataGridViewTextBoxColumn.Name = "OldFinalPriceDataGridViewTextBoxColumn"
        Me.OldFinalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewOriginalPriceDataGridViewTextBoxColumn
        '
        Me.NewOriginalPriceDataGridViewTextBoxColumn.DataPropertyName = "NewOriginalPrice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.NewOriginalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.NewOriginalPriceDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NewOriginalPriceDataGridViewTextBoxColumn.HeaderText = "NewOriginalPrice"
        Me.NewOriginalPriceDataGridViewTextBoxColumn.Name = "NewOriginalPriceDataGridViewTextBoxColumn"
        Me.NewOriginalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewFinalPriceDataGridViewTextBoxColumn
        '
        Me.NewFinalPriceDataGridViewTextBoxColumn.DataPropertyName = "NewFinalPrice"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.NewFinalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.NewFinalPriceDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NewFinalPriceDataGridViewTextBoxColumn.HeaderText = "NewFinalPrice"
        Me.NewFinalPriceDataGridViewTextBoxColumn.Name = "NewFinalPriceDataGridViewTextBoxColumn"
        Me.NewFinalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        DataGridViewCellStyle6.Format = "f"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CreatedAtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedAtDataGridViewTextBoxColumn.Width = 89
        '
        'CreatedByDataGridViewTextBoxColumn
        '
        Me.CreatedByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.Name = "CreatedByDataGridViewTextBoxColumn"
        Me.CreatedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedByDataGridViewTextBoxColumn.Visible = False
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Visible = False
        '
        'ProductPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ProductCodeTextBox)
        Me.Controls.Add(ProductCodeLabel)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(IdLabel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ProductPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Price"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ProductPriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPriceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents ProductPriceBindingSource As BindingSource
    Friend WithEvents ProductPriceTableAdapter As pos_dbDataSetTableAdapters.ProductPriceTableAdapter
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OldOriginalPriceTextBox As TextBox
    Friend WithEvents OldFinalPriceTextBox As TextBox
    Friend WithEvents NewOriginalPriceTextBox As TextBox
    Friend WithEvents NewFinalPriceTextBox As TextBox
    Friend WithEvents ProductPriceBindingSource1 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OldOriginalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OldFinalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewOriginalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewFinalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
