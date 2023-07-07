<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductQuantity
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
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim OldQuantityLabel As System.Windows.Forms.Label
        Dim NewQuantityLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim TotalQuantityLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.ProductQuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductQuantityTableAdapter = New POS.pos_dbDataSetTableAdapters.ProductQuantityTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.OldQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.NewQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TotalQuantityTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet1 = New POS.pos_dbDataSet()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        ProductCodeLabel = New System.Windows.Forms.Label()
        OldQuantityLabel = New System.Windows.Forms.Label()
        NewQuantityLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        TotalQuantityLabel = New System.Windows.Forms.Label()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductQuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductQuantityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(432, 63)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(136, 63)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(88, 16)
        ProductCodeLabel.TabIndex = 3
        ProductCodeLabel.Text = "Product Code:"
        '
        'OldQuantityLabel
        '
        OldQuantityLabel.AutoSize = True
        OldQuantityLabel.Location = New System.Drawing.Point(226, 48)
        OldQuantityLabel.Name = "OldQuantityLabel"
        OldQuantityLabel.Size = New System.Drawing.Size(82, 16)
        OldQuantityLabel.TabIndex = 5
        OldQuantityLabel.Text = "Old Quantity:"
        '
        'NewQuantityLabel
        '
        NewQuantityLabel.AutoSize = True
        NewQuantityLabel.Location = New System.Drawing.Point(226, 91)
        NewQuantityLabel.Name = "NewQuantityLabel"
        NewQuantityLabel.Size = New System.Drawing.Size(87, 16)
        NewQuantityLabel.TabIndex = 7
        NewQuantityLabel.Text = "New Quantity:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(134, 90)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(90, 16)
        ProductNameLabel.TabIndex = 12
        ProductNameLabel.Text = "Product Name:"
        '
        'TotalQuantityLabel
        '
        TotalQuantityLabel.AutoSize = True
        TotalQuantityLabel.Location = New System.Drawing.Point(226, 134)
        TotalQuantityLabel.Name = "TotalQuantityLabel"
        TotalQuantityLabel.Size = New System.Drawing.Size(88, 16)
        TotalQuantityLabel.TabIndex = 24
        TotalQuantityLabel.Text = "Total Quantity:"
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductQuantityBindingSource
        '
        Me.ProductQuantityBindingSource.DataMember = "ProductQuantity"
        Me.ProductQuantityBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'ProductQuantityTableAdapter
        '
        Me.ProductQuantityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductPriceTableAdapter = Nothing
        Me.TableAdapterManager.ProductQuantityTableAdapter = Me.ProductQuantityTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StoreTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(460, 60)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(55, 21)
        Me.IdTextBox.TabIndex = 2
        Me.IdTextBox.Visible = False
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "ProductCode", True))
        Me.ProductCodeTextBox.Enabled = False
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(230, 60)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(196, 21)
        Me.ProductCodeTextBox.TabIndex = 4
        '
        'OldQuantityTextBox
        '
        Me.OldQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "OldQuantity", True))
        Me.OldQuantityTextBox.Enabled = False
        Me.OldQuantityTextBox.Location = New System.Drawing.Point(229, 67)
        Me.OldQuantityTextBox.Name = "OldQuantityTextBox"
        Me.OldQuantityTextBox.Size = New System.Drawing.Size(161, 21)
        Me.OldQuantityTextBox.TabIndex = 6
        Me.OldQuantityTextBox.Text = "0"
        Me.OldQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NewQuantityTextBox
        '
        Me.NewQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "NewQuantity", True))
        Me.NewQuantityTextBox.Location = New System.Drawing.Point(229, 110)
        Me.NewQuantityTextBox.Name = "NewQuantityTextBox"
        Me.NewQuantityTextBox.Size = New System.Drawing.Size(161, 21)
        Me.NewQuantityTextBox.TabIndex = 8
        Me.NewQuantityTextBox.Text = "0"
        Me.NewQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(133, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(674, 319)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(TotalQuantityLabel)
        Me.TabPage1.Controls.Add(Me.TotalQuantityTextBox)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(OldQuantityLabel)
        Me.TabPage1.Controls.Add(Me.NewQuantityTextBox)
        Me.TabPage1.Controls.Add(Me.OldQuantityTextBox)
        Me.TabPage1.Controls.Add(NewQuantityLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(666, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product Quantity"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TotalQuantityTextBox
        '
        Me.TotalQuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "TotalQuantity", True))
        Me.TotalQuantityTextBox.Enabled = False
        Me.TotalQuantityTextBox.Location = New System.Drawing.Point(229, 153)
        Me.TotalQuantityTextBox.Name = "TotalQuantityTextBox"
        Me.TotalQuantityTextBox.Size = New System.Drawing.Size(161, 21)
        Me.TotalQuantityTextBox.TabIndex = 25
        Me.TotalQuantityTextBox.Text = "0"
        Me.TotalQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.BtnSave.Text = "Add Quantity"
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
        Me.TabPage2.Text = "Product Quantity History"
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
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.OldQuantityDataGridViewTextBoxColumn, Me.NewQuantityDataGridViewTextBoxColumn, Me.TotalQuantity, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn})
        Me.CategoryDataGridView.DataSource = Me.ProductQuantityBindingSource1
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle6
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
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Visible = False
        '
        'OldQuantityDataGridViewTextBoxColumn
        '
        Me.OldQuantityDataGridViewTextBoxColumn.DataPropertyName = "OldQuantity"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OldQuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OldQuantityDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.OldQuantityDataGridViewTextBoxColumn.HeaderText = "OldQuantity"
        Me.OldQuantityDataGridViewTextBoxColumn.Name = "OldQuantityDataGridViewTextBoxColumn"
        Me.OldQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewQuantityDataGridViewTextBoxColumn
        '
        Me.NewQuantityDataGridViewTextBoxColumn.DataPropertyName = "NewQuantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NewQuantityDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.NewQuantityDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.NewQuantityDataGridViewTextBoxColumn.HeaderText = "NewQuantity"
        Me.NewQuantityDataGridViewTextBoxColumn.Name = "NewQuantityDataGridViewTextBoxColumn"
        Me.NewQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalQuantity
        '
        Me.TotalQuantity.DataPropertyName = "TotalQuantity"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TotalQuantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.TotalQuantity.FillWeight = 75.0!
        Me.TotalQuantity.HeaderText = "TotalQuantity"
        Me.TotalQuantity.Name = "TotalQuantity"
        Me.TotalQuantity.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
        Me.CreatedAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CreatedAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt"
        DataGridViewCellStyle5.Format = "f"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CreatedAtDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CreatedAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt"
        Me.CreatedAtDataGridViewTextBoxColumn.Name = "CreatedAtDataGridViewTextBoxColumn"
        Me.CreatedAtDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedAtDataGridViewTextBoxColumn.Width = 89
        '
        'CreatedByDataGridViewTextBoxColumn
        '
        Me.CreatedByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.FillWeight = 7.733801!
        Me.CreatedByDataGridViewTextBoxColumn.HeaderText = "CreatedBy"
        Me.CreatedByDataGridViewTextBoxColumn.Name = "CreatedByDataGridViewTextBoxColumn"
        Me.CreatedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedByDataGridViewTextBoxColumn.Visible = False
        '
        'ProductQuantityBindingSource1
        '
        Me.ProductQuantityBindingSource1.DataMember = "ProductQuantity"
        Me.ProductQuantityBindingSource1.DataSource = Me.Pos_dbDataSet1
        '
        'Pos_dbDataSet1
        '
        Me.Pos_dbDataSet1.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductQuantityBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Enabled = False
        Me.ProductNameTextBox.Location = New System.Drawing.Point(230, 90)
        Me.ProductNameTextBox.Multiline = True
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(573, 31)
        Me.ProductNameTextBox.TabIndex = 13
        '
        'ProductQuantity
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
        Me.Name = "ProductQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Quantity"
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductQuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductQuantityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents ProductQuantityBindingSource As BindingSource
    Friend WithEvents ProductQuantityTableAdapter As pos_dbDataSetTableAdapters.ProductQuantityTableAdapter
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents OldQuantityTextBox As TextBox
    Friend WithEvents NewQuantityTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents Pos_dbDataSet1 As pos_dbDataSet
    Friend WithEvents ProductQuantityBindingSource1 As BindingSource
    Friend WithEvents TotalQuantityTextBox As TextBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OldQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NewQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalQuantity As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
