<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Store
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
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim SloganLabel As System.Windows.Forms.Label
        Dim TinNoLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim ThemeColorLabel As System.Windows.Forms.Label
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.SloganTextBox = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TinNoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pos_dbDataSet = New POS.pos_dbDataSet()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreTableAdapter = New POS.pos_dbDataSetTableAdapters.StoreTableAdapter()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New POS.pos_dbDataSetTableAdapters.TableAdapterManager()
        Me.ThemeColorComboBox = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LblBreadCrump = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        StoreNameLabel = New System.Windows.Forms.Label()
        SloganLabel = New System.Windows.Forms.Label()
        TinNoLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        ThemeColorLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(67, 101)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 17)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Location = New System.Drawing.Point(67, 130)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(88, 17)
        StoreNameLabel.TabIndex = 4
        StoreNameLabel.Text = "Store Name:"
        '
        'SloganLabel
        '
        SloganLabel.AutoSize = True
        SloganLabel.Location = New System.Drawing.Point(67, 159)
        SloganLabel.Name = "SloganLabel"
        SloganLabel.Size = New System.Drawing.Size(56, 17)
        SloganLabel.TabIndex = 6
        SloganLabel.Text = "Slogan:"
        '
        'TinNoLabel
        '
        TinNoLabel.AutoSize = True
        TinNoLabel.Location = New System.Drawing.Point(67, 219)
        TinNoLabel.Name = "TinNoLabel"
        TinNoLabel.Size = New System.Drawing.Size(51, 17)
        TinNoLabel.TabIndex = 12
        TinNoLabel.Text = "Tin No:"
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.Location = New System.Drawing.Point(67, 248)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(90, 17)
        ContactNoLabel.TabIndex = 14
        ContactNoLabel.Text = "Contact No:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(167, 98)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(190, 23)
        Me.IdTextBox.TabIndex = 3
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.Location = New System.Drawing.Point(167, 127)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(397, 23)
        Me.StoreNameTextBox.TabIndex = 5
        '
        'SloganTextBox
        '
        Me.SloganTextBox.Location = New System.Drawing.Point(167, 156)
        Me.SloganTextBox.Name = "SloganTextBox"
        Me.SloganTextBox.Size = New System.Drawing.Size(397, 23)
        Me.SloganTextBox.TabIndex = 7
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Location = New System.Drawing.Point(570, 126)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(147, 142)
        Me.LogoPictureBox.TabIndex = 9
        Me.LogoPictureBox.TabStop = False
        '
        'TinNoTextBox
        '
        Me.TinNoTextBox.Location = New System.Drawing.Point(167, 216)
        Me.TinNoTextBox.Name = "TinNoTextBox"
        Me.TinNoTextBox.Size = New System.Drawing.Size(190, 23)
        Me.TinNoTextBox.TabIndex = 13
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.Location = New System.Drawing.Point(167, 245)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(190, 23)
        Me.ContactNoTextBox.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.LblBreadCrump)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 42)
        Me.Panel2.TabIndex = 19
        '
        'Pos_dbDataSet
        '
        Me.Pos_dbDataSet.DataSetName = "pos_dbDataSet"
        Me.Pos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "Store"
        Me.StoreBindingSource.DataSource = Me.Pos_dbDataSet
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(764, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(33, 42)
        Me.BtnClose.TabIndex = 21
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.PersonnelTableAdapter = Nothing
        Me.TableAdapterManager.ProductLedgerTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.StoreTableAdapter = Me.StoreTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.TransactionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TransactionHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.pos_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ThemeColorLabel
        '
        ThemeColorLabel.AutoSize = True
        ThemeColorLabel.Location = New System.Drawing.Point(67, 188)
        ThemeColorLabel.Name = "ThemeColorLabel"
        ThemeColorLabel.Size = New System.Drawing.Size(94, 17)
        ThemeColorLabel.TabIndex = 19
        ThemeColorLabel.Text = "Theme Color:"
        '
        'ThemeColorComboBox
        '
        Me.ThemeColorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "ThemeColor", True))
        Me.ThemeColorComboBox.FormattingEnabled = True
        Me.ThemeColorComboBox.Location = New System.Drawing.Point(167, 185)
        Me.ThemeColorComboBox.Name = "ThemeColorComboBox"
        Me.ThemeColorComboBox.Size = New System.Drawing.Size(397, 25)
        Me.ThemeColorComboBox.TabIndex = 20
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(167, 274)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(190, 36)
        Me.BtnSave.TabIndex = 21
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'LblBreadCrump
        '
        Me.LblBreadCrump.AutoSize = True
        Me.LblBreadCrump.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBreadCrump.ForeColor = System.Drawing.Color.White
        Me.LblBreadCrump.Location = New System.Drawing.Point(12, 9)
        Me.LblBreadCrump.Name = "LblBreadCrump"
        Me.LblBreadCrump.Size = New System.Drawing.Size(184, 25)
        Me.LblBreadCrump.TabIndex = 22
        Me.LblBreadCrump.Text = "Store Information"
        '
        'Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 354)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(ThemeColorLabel)
        Me.Controls.Add(Me.ThemeColorComboBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(StoreNameLabel)
        Me.Controls.Add(Me.StoreNameTextBox)
        Me.Controls.Add(SloganLabel)
        Me.Controls.Add(Me.SloganTextBox)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(TinNoLabel)
        Me.Controls.Add(Me.TinNoTextBox)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Store"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Pos_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents SloganTextBox As TextBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents TinNoTextBox As TextBox
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Pos_dbDataSet As pos_dbDataSet
    Friend WithEvents StoreBindingSource As BindingSource
    Friend WithEvents StoreTableAdapter As pos_dbDataSetTableAdapters.StoreTableAdapter
    Friend WithEvents BtnClose As Button
    Friend WithEvents TableAdapterManager As pos_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ThemeColorComboBox As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents LblBreadCrump As Label
End Class
