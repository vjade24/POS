﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateRemitted = New System.Windows.Forms.DateTimePicker()
        Me.TotalAmount = New System.Windows.Forms.TextBox()
        Me.CashOnHand = New System.Windows.Forms.TextBox()
        Me.PersonnelName1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnGenrate = New System.Windows.Forms.Button()
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.RemittanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemittanceTableAdapter = New POS.pos_dbDataSetTableAdapters.RemittanceTableAdapter()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.btnPrint = New System.Windows.Forms.Button()
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
        'btnGenrate
        '
        Me.btnGenrate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenrate.Location = New System.Drawing.Point(81, 279)
        Me.btnGenrate.Name = "btnGenrate"
        Me.btnGenrate.Size = New System.Drawing.Size(200, 36)
        Me.btnGenrate.TabIndex = 9
        Me.btnGenrate.Text = "Save"
        Me.btnGenrate.UseVisualStyleBackColor = True
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
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(795, 84)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(154, 36)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RemittanceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
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
        Me.RemittanceDataGridView.Size = New System.Drawing.Size(646, 337)
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
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CashOnHandDataGridViewTextBoxColumn
        '
        Me.CashOnHandDataGridViewTextBoxColumn.DataPropertyName = "CashOnHand"
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
        Me.GroupBox1.Controls.Add(Me.TotalAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 107)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Admin"
        '
        'PersonnelName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 588)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RemittanceDataGridView)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnGenrate)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnGenrate As Button
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents RemittanceBindingSource As BindingSource
    Friend WithEvents RemittanceTableAdapter As pos_dbDataSetTableAdapters.RemittanceTableAdapter
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnPrint As Button
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents RemittanceDataGridView As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRemittedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CashOnHandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonnelNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedByDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
End Class
