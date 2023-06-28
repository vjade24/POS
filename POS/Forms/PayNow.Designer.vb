<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayNow
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
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim PaymentStatusLabel As System.Windows.Forms.Label
        Dim PaymentChangeLabel As System.Windows.Forms.Label
        Dim PersonnelIdLabel As System.Windows.Forms.Label
        Dim PaymentAmountLabel As System.Windows.Forms.Label
        Dim InvoiceNoLabel As System.Windows.Forms.Label
        Dim GrandTotalLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PaymentStatusTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentChangeTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentAmountTextBox = New System.Windows.Forms.TextBox()
        Me.PersonnelIdTextBox = New System.Windows.Forms.TextBox()
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CustomerNameLabel = New System.Windows.Forms.Label()
        PaymentStatusLabel = New System.Windows.Forms.Label()
        PaymentChangeLabel = New System.Windows.Forms.Label()
        PersonnelIdLabel = New System.Windows.Forms.Label()
        PaymentAmountLabel = New System.Windows.Forms.Label()
        InvoiceNoLabel = New System.Windows.Forms.Label()
        GrandTotalLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerNameLabel.Location = New System.Drawing.Point(51, 218)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(142, 21)
        CustomerNameLabel.TabIndex = 53
        CustomerNameLabel.Text = "Customer Name:"
        '
        'PaymentStatusLabel
        '
        PaymentStatusLabel.AutoSize = True
        PaymentStatusLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentStatusLabel.Location = New System.Drawing.Point(50, 108)
        PaymentStatusLabel.Name = "PaymentStatusLabel"
        PaymentStatusLabel.Size = New System.Drawing.Size(137, 21)
        PaymentStatusLabel.TabIndex = 52
        PaymentStatusLabel.Text = "Payment Status:"
        '
        'PaymentChangeLabel
        '
        PaymentChangeLabel.AutoSize = True
        PaymentChangeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentChangeLabel.Location = New System.Drawing.Point(54, 392)
        PaymentChangeLabel.Name = "PaymentChangeLabel"
        PaymentChangeLabel.Size = New System.Drawing.Size(153, 21)
        PaymentChangeLabel.TabIndex = 50
        PaymentChangeLabel.Text = "Payment Change:"
        '
        'PersonnelIdLabel
        '
        PersonnelIdLabel.AutoSize = True
        PersonnelIdLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PersonnelIdLabel.Location = New System.Drawing.Point(198, 108)
        PersonnelIdLabel.Name = "PersonnelIdLabel"
        PersonnelIdLabel.Size = New System.Drawing.Size(107, 21)
        PersonnelIdLabel.TabIndex = 42
        PersonnelIdLabel.Text = "Personnel Id:"
        '
        'PaymentAmountLabel
        '
        PaymentAmountLabel.AutoSize = True
        PaymentAmountLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentAmountLabel.Location = New System.Drawing.Point(54, 336)
        PaymentAmountLabel.Name = "PaymentAmountLabel"
        PaymentAmountLabel.Size = New System.Drawing.Size(153, 21)
        PaymentAmountLabel.TabIndex = 48
        PaymentAmountLabel.Text = "Payment Amount:"
        '
        'InvoiceNoLabel
        '
        InvoiceNoLabel.AutoSize = True
        InvoiceNoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InvoiceNoLabel.Location = New System.Drawing.Point(51, 162)
        InvoiceNoLabel.Name = "InvoiceNoLabel"
        InvoiceNoLabel.Size = New System.Drawing.Size(98, 21)
        InvoiceNoLabel.TabIndex = 44
        InvoiceNoLabel.Text = "Invoice No:"
        '
        'GrandTotalLabel
        '
        GrandTotalLabel.AutoSize = True
        GrandTotalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GrandTotalLabel.Location = New System.Drawing.Point(54, 280)
        GrandTotalLabel.Name = "GrandTotalLabel"
        GrandTotalLabel.Size = New System.Drawing.Size(108, 21)
        GrandTotalLabel.TabIndex = 46
        GrandTotalLabel.Text = "Grand Total:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(78, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(242, 32)
        Label1.TabIndex = 56
        Label1.Text = "PAYMENT DETAILS"
        '
        'PaymentStatusTextBox
        '
        Me.PaymentStatusTextBox.Enabled = False
        Me.PaymentStatusTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentStatusTextBox.Location = New System.Drawing.Point(51, 132)
        Me.PaymentStatusTextBox.Name = "PaymentStatusTextBox"
        Me.PaymentStatusTextBox.Size = New System.Drawing.Size(146, 27)
        Me.PaymentStatusTextBox.TabIndex = 54
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(51, 244)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(297, 27)
        Me.CustomerNameTextBox.TabIndex = 55
        '
        'PaymentChangeTextBox
        '
        Me.PaymentChangeTextBox.Enabled = False
        Me.PaymentChangeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentChangeTextBox.Location = New System.Drawing.Point(54, 412)
        Me.PaymentChangeTextBox.Name = "PaymentChangeTextBox"
        Me.PaymentChangeTextBox.Size = New System.Drawing.Size(297, 27)
        Me.PaymentChangeTextBox.TabIndex = 51
        Me.PaymentChangeTextBox.Text = "0.00"
        Me.PaymentChangeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PaymentAmountTextBox
        '
        Me.PaymentAmountTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentAmountTextBox.Location = New System.Drawing.Point(54, 356)
        Me.PaymentAmountTextBox.Name = "PaymentAmountTextBox"
        Me.PaymentAmountTextBox.Size = New System.Drawing.Size(297, 27)
        Me.PaymentAmountTextBox.TabIndex = 49
        Me.PaymentAmountTextBox.Text = "0.00"
        Me.PaymentAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PersonnelIdTextBox
        '
        Me.PersonnelIdTextBox.Enabled = False
        Me.PersonnelIdTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonnelIdTextBox.Location = New System.Drawing.Point(202, 132)
        Me.PersonnelIdTextBox.Name = "PersonnelIdTextBox"
        Me.PersonnelIdTextBox.Size = New System.Drawing.Size(146, 27)
        Me.PersonnelIdTextBox.TabIndex = 43
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.Enabled = False
        Me.GrandTotalTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(54, 300)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(297, 27)
        Me.GrandTotalTextBox.TabIndex = 47
        Me.GrandTotalTextBox.Text = "0.00"
        Me.GrandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InvoiceNoTextBox
        '
        Me.InvoiceNoTextBox.Enabled = False
        Me.InvoiceNoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceNoTextBox.Location = New System.Drawing.Point(51, 188)
        Me.InvoiceNoTextBox.Name = "InvoiceNoTextBox"
        Me.InvoiceNoTextBox.Size = New System.Drawing.Size(297, 27)
        Me.InvoiceNoTextBox.TabIndex = 45
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.ForestGreen
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(54, 468)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(85, 0, 0, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(297, 38)
        Me.IconButton1.TabIndex = 58
        Me.IconButton1.Text = "    Pay Now"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(388, 27)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(624, 502)
        Me.CrystalReportViewer1.TabIndex = 59
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(385, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(131, 16)
        Me.LinkLabel1.TabIndex = 60
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Payment Receipt"
        '
        'PayNow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 541)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CustomerNameLabel)
        Me.Controls.Add(Me.PaymentStatusTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(PaymentStatusLabel)
        Me.Controls.Add(Me.PaymentChangeTextBox)
        Me.Controls.Add(PaymentChangeLabel)
        Me.Controls.Add(PersonnelIdLabel)
        Me.Controls.Add(Me.PaymentAmountTextBox)
        Me.Controls.Add(Me.PersonnelIdTextBox)
        Me.Controls.Add(PaymentAmountLabel)
        Me.Controls.Add(InvoiceNoLabel)
        Me.Controls.Add(Me.GrandTotalTextBox)
        Me.Controls.Add(Me.InvoiceNoTextBox)
        Me.Controls.Add(GrandTotalLabel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PayNow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayNow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaymentStatusTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents PaymentChangeTextBox As TextBox
    Friend WithEvents PaymentAmountTextBox As TextBox
    Friend WithEvents PersonnelIdTextBox As TextBox
    Friend WithEvents GrandTotalTextBox As TextBox
    Friend WithEvents InvoiceNoTextBox As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
