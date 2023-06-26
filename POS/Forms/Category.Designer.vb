<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category
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
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New POS.pos_dbDataSetTableAdapters.CategoryTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblAddEditMode = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSave = New FontAwesome.Sharp.IconButton()
        Me.BtnDelete = New FontAwesome.Sharp.IconButton()
        Me.CategoryNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAdd = New FontAwesome.Sharp.IconButton()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(13, 21)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 16)
        IdLabel.TabIndex = 0
        IdLabel.Text = "ID"
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryNameLabel.Location = New System.Drawing.Point(13, 67)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(98, 16)
        CategoryNameLabel.TabIndex = 2
        CategoryNameLabel.Text = "Category Name:"
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.Pos_dbDataSet
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Search:"
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
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CategoryNameDataGridViewTextBoxColumn, Me.CreatedAt, Me.CreatedBy})
        Me.CategoryDataGridView.DataSource = Me.CategoryBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CategoryDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.CategoryDataGridView.EnableHeadersVisualStyles = False
        Me.CategoryDataGridView.Location = New System.Drawing.Point(16, 61)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.CategoryDataGridView.RowHeadersVisible = False
        Me.CategoryDataGridView.RowHeadersWidth = 50
        Me.CategoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoryDataGridView.Size = New System.Drawing.Size(928, 337)
        Me.CategoryDataGridView.TabIndex = 3
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSearch.Location = New System.Drawing.Point(74, 26)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(9)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(142, 21)
        Me.TextBoxSearch.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblAddEditMode)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.CategoryNameTextBox)
        Me.GroupBox1.Controls.Add(CategoryNameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 437)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 214)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category Information"
        '
        'LblAddEditMode
        '
        Me.LblAddEditMode.AutoSize = True
        Me.LblAddEditMode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddEditMode.ForeColor = System.Drawing.Color.Red
        Me.LblAddEditMode.Location = New System.Drawing.Point(108, 41)
        Me.LblAddEditMode.Name = "LblAddEditMode"
        Me.LblAddEditMode.Size = New System.Drawing.Size(16, 16)
        Me.LblAddEditMode.TabIndex = 24
        Me.LblAddEditMode.Text = "--"
        Me.LblAddEditMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdTextBox
        '
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(16, 39)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(88, 21)
        Me.IdTextBox.TabIndex = 1
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
        Me.BtnSave.Location = New System.Drawing.Point(270, 152)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
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
        Me.BtnDelete.Location = New System.Drawing.Point(16, 152)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BtnDelete.Rotation = 0R
        Me.BtnDelete.Size = New System.Drawing.Size(112, 36)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(16, 85)
        Me.CategoryNameTextBox.Multiline = True
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(367, 62)
        Me.CategoryNameTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnAdd)
        Me.GroupBox2.Controls.Add(Me.TextBoxSearch)
        Me.GroupBox2.Controls.Add(Me.CategoryDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 420)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Category List"
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
        Me.BtnAdd.Location = New System.Drawing.Point(833, 20)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BtnAdd.Rotation = 0R
        Me.BtnAdd.Size = New System.Drawing.Size(111, 36)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "Add New"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryNameDataGridViewTextBoxColumn
        '
        Me.CategoryNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.FillWeight = 98.47716!
        Me.CategoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName"
        Me.CategoryNameDataGridViewTextBoxColumn.Name = "CategoryNameDataGridViewTextBoxColumn"
        Me.CategoryNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreatedAt
        '
        Me.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreatedAt.DataPropertyName = "CreatedAt"
        Me.CreatedAt.HeaderText = "CreatedAt"
        Me.CreatedAt.Name = "CreatedAt"
        Me.CreatedAt.ReadOnly = True
        Me.CreatedAt.Visible = False
        '
        'CreatedBy
        '
        Me.CreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CreatedBy.DataPropertyName = "CreatedBy"
        Me.CreatedBy.HeaderText = "CreatedBy"
        Me.CreatedBy.Name = "CreatedBy"
        Me.CreatedBy.ReadOnly = True
        Me.CreatedBy.Visible = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 676)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Category"
        Me.Text = "Category"
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents BtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents CategoryBindingSource1 As BindingSource
    Friend WithEvents CategoryTableAdapter As pos_dbDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents BtnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents CategoryNameTextBox As TextBox
    Friend WithEvents LblAddEditMode As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedAt As DataGridViewTextBoxColumn
    Friend WithEvents CreatedBy As DataGridViewTextBoxColumn
End Class
