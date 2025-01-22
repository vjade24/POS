<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonnelName
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
        Me.DateRemitted = New System.Windows.Forms.DateTimePicker()
        Me.TotalAmount = New System.Windows.Forms.TextBox()
        Me.CashOnHand = New System.Windows.Forms.TextBox()
        Me.PersonnelName1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.RemittanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemittanceTableAdapter = New POS.pos_dbDataSetTableAdapters.RemittanceTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.RemittanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRemittedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashOnHandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonnelNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPrint = New FontAwesome.Sharp.IconButton()
        Me.TextBoxCashonHandDisplay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTotalsDisplay = New System.Windows.Forms.TextBox()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemittanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemittanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateRemitted
        '
        Me.DateRemitted.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRemitted.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateRemitted.Location = New System.Drawing.Point(81, 173)
        Me.DateRemitted.Name = "DateRemitted"
        Me.DateRemitted.Size = New System.Drawing.Size(200, 27)
        Me.DateRemitted.TabIndex = 0
        '
        'TotalAmount
        '
        Me.TotalAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(34, 57)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.Size = New System.Drawing.Size(200, 27)
        Me.TotalAmount.TabIndex = 1
        Me.TotalAmount.Text = "0.00"
        Me.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CashOnHand
        '
        Me.CashOnHand.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashOnHand.Location = New System.Drawing.Point(81, 234)
        Me.CashOnHand.Name = "CashOnHand"
        Me.CashOnHand.Size = New System.Drawing.Size(200, 27)
        Me.CashOnHand.TabIndex = 2
        Me.CashOnHand.Text = "0.00"
        Me.CashOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PersonnelName1
        '
        Me.PersonnelName1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonnelName1.Location = New System.Drawing.Point(81, 24)
        Me.PersonnelName1.Name = "PersonnelName1"
        Me.PersonnelName1.ReadOnly = True
        Me.PersonnelName1.Size = New System.Drawing.Size(200, 27)
        Me.PersonnelName1.TabIndex = 3
        Me.PersonnelName1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date Remit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Amount"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(154, 37)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 17)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View details"
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RemittanceBindingSource
        '
        Me.RemittanceBindingSource.DataMember = "Remittance"
        Me.RemittanceBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'RemittanceTableAdapter
        '
        Me.RemittanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductPriceTableAdapter = Nothing
        Me.TableAdapterManager.ProductQuantityTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.RemittanceTableAdapter = Me.RemittanceTableAdapter
        Me.TableAdapterManager.StoreTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TextBoxId
        '
        Me.TextBoxId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(81, 57)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.ReadOnly = True
        Me.TextBoxId.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxId.TabIndex = 13
        Me.TextBoxId.Visible = False
        '
        'RemittanceDataGridView
        '
        Me.RemittanceDataGridView.AllowUserToAddRows = False
        Me.RemittanceDataGridView.AllowUserToDeleteRows = False
        Me.RemittanceDataGridView.AutoGenerateColumns = False
        Me.RemittanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RemittanceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.RemittanceDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RemittanceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RemittanceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemittanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RemittanceDataGridView.ColumnHeadersHeight = 50
        Me.RemittanceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DateRemittedDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.CashOnHandDataGridViewTextBoxColumn, Me.PersonnelNameDataGridViewTextBoxColumn, Me.CreatedAtDataGridViewTextBoxColumn, Me.CreatedByDataGridViewTextBoxColumn})
        Me.RemittanceDataGridView.DataSource = Me.RemittanceBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RemittanceDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.RemittanceDataGridView.EnableHeadersVisualStyles = False
        Me.RemittanceDataGridView.Location = New System.Drawing.Point(303, 126)
        Me.RemittanceDataGridView.Name = "RemittanceDataGridView"
        Me.RemittanceDataGridView.ReadOnly = True
        Me.RemittanceDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.RemittanceDataGridView.RowHeadersVisible = False
        Me.RemittanceDataGridView.RowHeadersWidth = 50
        Me.RemittanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RemittanceDataGridView.Size = New System.Drawing.Size(646, 430)
        Me.RemittanceDataGridView.TabIndex = 14
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DateRemittedDataGridViewTextBoxColumn
        '
        Me.DateRemittedDataGridViewTextBoxColumn.DataPropertyName = "DateRemitted"
        Me.DateRemittedDataGridViewTextBoxColumn.HeaderText = "DateRemitted"
        Me.DateRemittedDataGridViewTextBoxColumn.Name = "DateRemittedDataGridViewTextBoxColumn"
        Me.DateRemittedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalAmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashOnHandDataGridViewTextBoxColumn
        '
        Me.CashOnHandDataGridViewTextBoxColumn.DataPropertyName = "CashOnHand"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CashOnHandDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CashOnHandDataGridViewTextBoxColumn.HeaderText = "CashOnHand"
        Me.CashOnHandDataGridViewTextBoxColumn.Name = "CashOnHandDataGridViewTextBoxColumn"
        Me.CashOnHandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PersonnelNameDataGridViewTextBoxColumn
        '
        Me.PersonnelNameDataGridViewTextBoxColumn.DataPropertyName = "PersonnelName"
        Me.PersonnelNameDataGridViewTextBoxColumn.HeaderText = "PersonnelName"
        Me.PersonnelNameDataGridViewTextBoxColumn.Name = "PersonnelNameDataGridViewTextBoxColumn"
        Me.PersonnelNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAtDataGridViewTextBoxColumn
        '
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
        Me.CreatedByDataGridViewTextBoxColumn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalsDisplay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxCashonHandDisplay)
        Me.GroupBox1.Controls.Add(Me.TotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 227)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnAdd.IconColor = System.Drawing.Color.White
        Me.btnAdd.IconSize = 30
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(81, 268)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAdd.Rotation = 0R
        Me.btnAdd.Size = New System.Drawing.Size(200, 38)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Save Remittance"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.IconButtonPrint.Location = New System.Drawing.Point(790, 83)
        Me.IconButtonPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButtonPrint.Name = "IconButtonPrint"
        Me.IconButtonPrint.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.IconButtonPrint.Rotation = 0R
        Me.IconButtonPrint.Size = New System.Drawing.Size(159, 36)
        Me.IconButtonPrint.TabIndex = 29
        Me.IconButtonPrint.Text = "Print Remittance"
        Me.IconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPrint.UseVisualStyleBackColor = False
        '
        'TextBoxCashonHandDisplay
        '
        Me.TextBoxCashonHandDisplay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCashonHandDisplay.Location = New System.Drawing.Point(34, 109)
        Me.TextBoxCashonHandDisplay.Name = "TextBoxCashonHandDisplay"
        Me.TextBoxCashonHandDisplay.ReadOnly = True
        Me.TextBoxCashonHandDisplay.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxCashonHandDisplay.TabIndex = 9
        Me.TextBoxCashonHandDisplay.Text = "0.00"
        Me.TextBoxCashonHandDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Cash on Hand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cash on Hand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total"
        '
        'TextBoxTotalsDisplay
        '
        Me.TextBoxTotalsDisplay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalsDisplay.Location = New System.Drawing.Point(34, 162)
        Me.TextBoxTotalsDisplay.Name = "TextBoxTotalsDisplay"
        Me.TextBoxTotalsDisplay.ReadOnly = True
        Me.TextBoxTotalsDisplay.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxTotalsDisplay.TabIndex = 31
        Me.TextBoxTotalsDisplay.Text = "0.00"
        Me.TextBoxTotalsDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PersonnelName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 588)
        Me.Controls.Add(Me.IconButtonPrint)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RemittanceDataGridView)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PersonnelName1)
        Me.Controls.Add(Me.CashOnHand)
        Me.Controls.Add(Me.DateRemitted)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PersonnelName"
        Me.Text = "Remittance"
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemittanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemittanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateRemitted As DateTimePicker
    Friend WithEvents TotalAmount As TextBox
    Friend WithEvents CashOnHand As TextBox
    Friend WithEvents PersonnelName1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents RemittanceBindingSource As BindingSource
    Friend WithEvents RemittanceTableAdapter As pos_dbDataSetTableAdapters.RemittanceTableAdapter
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents RemittanceDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRemittedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashOnHandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnelNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTotalsDisplay As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCashonHandDisplay As TextBox
    Friend WithEvents Label3 As Label
End Class
