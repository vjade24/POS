Imports System.Data.SqlClient
Imports System.IO
Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.Pos_dbDataSet.Supplier)
        Me.BrandTableAdapter.Fill(Me.Pos_dbDataSet.Brand)
        Me.CategoryTableAdapter.Fill(Me.Pos_dbDataSet.Category)
        RefreshData()
        BtnSave.Enabled = False
        BtnDelete.Enabled = False
        GroupBox1.Visible = False
        ExpiryDateDateTimePicker.Visible = False
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Product ORDER BY Id DESC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            CategoryDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim query = "SELECT * FROM Product WHERE ProductCode LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR BarCode LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR CategoryName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR BrandName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR SupplierName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR Quantity LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR FinalPrice LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, CategoryDataGridView)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LblAddEditMode.Text = "(Create new Record)"

        IdTextBox.Text = ""
        ProductCodeTextBox.Text = ""
        ProductCodeTextBox.Select()
        ProductNameTextBox.Text = ""
        ProductImagePictureBox.Image = My.Resources.box
        BarcodeTextBox.Text = ""
        CategoryNameComboBox.Text = ""
        BrandNameComboBox.Text = ""
        SupplierNameComboBox.Text = ""
        OriginalPriceTextBox.Text = "0.00"
        'DiscountedPriceTextBox.Text = "0.00"
        'DiscountedDateFromDateTimePicker.ResetText()
        'DiscountedDateToDateTimePicker.ResetText()
        'DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0"
        'IsInstockCheckBox.Checked = False
        MinimumPriceTextBox.Text = "0.00"
        MaximumPriceTextBox.Text = "0.00"
        ExpiryDateDateTimePicker.ResetText()

        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        ProductCodeTextBox.Enabled = True
        'BarcodeTextBox.Enabled = True
        'QuantityTextBox.Enabled = True
        'OriginalPriceTextBox.Enabled = True
        'DiscountedPercTextBox.Enabled = True
        'FinalPriceTextBox.Enabled = True

        IdTextBox.Text = GetLastRow("Product", "Id")

        GroupBox1.Visible = True
        LinkLabelAddQuantity.Visible = False
        LinkLabelChangePrice.Visible = False
        QuantityTextBox.Enabled = True
        OriginalPriceTextBox.Enabled = True
        FinalPriceTextBox.Enabled = True
        Searchtextbox()
    End Sub
    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        IdTextBox.Text = ""
        ProductCodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        ProductImagePictureBox.Image = My.Resources.VJA
        BarcodeTextBox.Text = ""
        CategoryNameComboBox.Text = ""
        BrandNameComboBox.Text = ""
        SupplierNameComboBox.Text = ""
        OriginalPriceTextBox.Text = "0.00"
        'DiscountedPercTextBox.Text = "0.00"
        'DiscountedPriceTextBox.Text = "0.00"
        'DiscountedDateFromDateTimePicker.ResetText()
        'DiscountedDateToDateTimePicker.ResetText()
        'DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0"
        MinimumPriceTextBox.Text = "0.00"
        MaximumPriceTextBox.Text = "0.00"
        ExpiryDateDateTimePicker.ResetText()
        'IsInstockCheckBox.Checked = False

        IdTextBox.Text = CategoryDataGridView.CurrentRow.Cells(0).Value.ToString()
        ProductCodeTextBox.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        ProductNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(2).Value.ToString()
        'ProductImagePictureBox.Image = CategoryDataGridView.CurrentRow.Cells(3).Value
        BarcodeTextBox.Text = CategoryDataGridView.CurrentRow.Cells(4).Value.ToString()
        CategoryNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(5).Value.ToString()
        BrandNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(6).Value.ToString()
        SupplierNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(7).Value.ToString()
        OriginalPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(8).Value.ToString()).ToString("###,##0.00")
        'DiscountedPercTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(9).Value.ToString()).ToString("###,##0.00")
        'DiscountedDateFromDateTimePicker.Value = CategoryDataGridView.CurrentRow.Cells(10).Value.ToString()
        'DiscountedDateToDateTimePicker.Value = CategoryDataGridView.CurrentRow.Cells(11).Value.ToString()
        'DiscountedPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(12).Value.ToString()).ToString("###,##0.00")
        FinalPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(13).Value.ToString()).ToString("###,##0.00")
        QuantityTextBox.Text = CategoryDataGridView.CurrentRow.Cells(14).Value.ToString()
        'IsInstockCheckBox.Checked = CategoryDataGridView.CurrentRow.Cells(15).Value.ToString()


        MinimumPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(16).Value.ToString()).ToString("###,##0.00")
        MaximumPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(17).Value.ToString()).ToString("###,##0.00")

        If CategoryDataGridView.CurrentRow.Cells(18).Value.ToString().Trim() Is "" Then
            CheckBoxExpiryDate.Checked = False
            ExpiryDateDateTimePicker.Visible = False
        Else
            CheckBoxExpiryDate.Checked = True
            ExpiryDateDateTimePicker.Value = DateTime.Parse(CategoryDataGridView.CurrentRow.Cells(18).Value.ToString())
        End If

        Try
            Dim lb() As Byte = CategoryDataGridView.CurrentRow.Cells(3).Value
            Dim lstr As New System.IO.MemoryStream(lb)
            ProductImagePictureBox.Image = Image.FromStream(lstr)
            ProductImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            ProductImagePictureBox.Image = My.Resources.box
        End Try

        ProductCodeTextBox.Enabled = False
        'BarcodeTextBox.Enabled = False
        'QuantityTextBox.Enabled = False
        'OriginalPriceTextBox.Enabled = False
        'DiscountedPercTextBox.Enabled = False
        'FinalPriceTextBox.Enabled = False

        GroupBox1.Visible = True
        LinkLabelAddQuantity.Visible = True
        LinkLabelChangePrice.Visible = True

        QuantityTextBox.Enabled = False
        OriginalPriceTextBox.Enabled = False
        FinalPriceTextBox.Enabled = False
    End Sub

    Private Sub ClearEntry()
        IdTextBox.Text = ""
        ProductCodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        ProductImagePictureBox.Image = My.Resources.box
        BarcodeTextBox.Text = ""
        CategoryNameComboBox.Text = ""
        BrandNameComboBox.Text = ""
        SupplierNameComboBox.Text = ""
        OriginalPriceTextBox.Text = "0.00"
        'DiscountedPercTextBox.Text = "0.00"
        'DiscountedPriceTextBox.Text = "0.00"
        'DiscountedDateFromDateTimePicker.ResetText()
        'DiscountedDateToDateTimePicker.ResetText()
        'DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0"
        'IsInstockCheckBox.Checked = False
        MinimumPriceTextBox.Text = "0.00"
        MaximumPriceTextBox.Text = "0.00"
        ExpiryDateDateTimePicker.ResetText()

        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim query = "SELECT TOP 1 * FROM TransactionDetails Where ProductCode = '" + ProductCodeTextBox.Text.ToString().Trim() + "'"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("THIS PRODUCT IS ALREADY USED ON POINT OF SALE, YOU CANNOT DELETE!", MsgBoxStyle.Critical)
                Return
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record (" + CategoryDataGridView.CurrentRow.Cells(0).Value.ToString() + ")", "Delete Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("You pressed No")
        ElseIf result = DialogResult.Yes Then
            Try
                Dim command1 As New SqlCommand("delete Product where Id = @Id", conn)
                command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
                Try
                    conn.Open()
                    result = command1.ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("No Data Deleted!", MsgBoxStyle.Critical)
                    Else
                        MsgBox("Successfully Deleted!", MsgBoxStyle.Information)
                        GroupBox1.Visible = False
                    End If
                    conn.Close()
                Catch ex As Exception
                    MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                    conn.Close()
                End Try

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
        RefreshData()
        ClearEntry()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If ProductCodeTextBox.Text.ToString().Trim() = "" Then
            MsgBox("PRODUCT CODE IS REQUIRED", MsgBoxStyle.Critical)
            ProductCodeTextBox.Select()
            Return
        End If
        If BarcodeTextBox.Text.ToString().Trim() = "" Then
            MsgBox("BARCODE IS REQUIRED", MsgBoxStyle.Critical)
            BarcodeTextBox.Select()
            Return
        End If
        If QuantityTextBox.Text.ToString().Trim() = "" Then
            MsgBox("PRODUCT QUANTITY IS REQUIRED", MsgBoxStyle.Critical)
            QuantityTextBox.Select()
            Return
        End If
        'If Int32.Parse(QuantityTextBox.Text.ToString().Trim()) <= 0 Then
        '    MsgBox("PRODUCT QUANTITY MUST BE ATLEAST 1(ONE) QUANTITY ", MsgBoxStyle.Critical)
        '    QuantityTextBox.Select()
        '    Return
        'End If
        If ProductNameTextBox.Text.ToString().Trim() = "" Then
            MsgBox("PRODUCT NAME IS REQUIRED", MsgBoxStyle.Critical)
            ProductNameTextBox.Select()
            Return
        End If
        If CategoryNameComboBox.Text.ToString().Trim() = "" Then
            MsgBox("CATEGORY IS REQUIRED", MsgBoxStyle.Critical)
            CategoryNameComboBox.Select()
            Return
        End If
        If BrandNameComboBox.Text.ToString().Trim() = "" Then
            MsgBox("BRAND NAME IS REQUIRED", MsgBoxStyle.Critical)
            BrandNameComboBox.Select()
            Return
        End If
        If SupplierNameComboBox.Text.ToString().Trim() = "" Then
            MsgBox("SUPPLIER NAME IS REQUIRED", MsgBoxStyle.Critical)
            SupplierNameComboBox.Select()
            Return
        End If
        If OriginalPriceTextBox.Text.ToString().Trim() = "" Then
            MsgBox("ORIGINAL PRICE IS REQUIRED", MsgBoxStyle.Critical)
            OriginalPriceTextBox.Select()
            Return
        End If
        If Double.Parse(OriginalPriceTextBox.Text.ToString().Trim()) <= 0 Then
            MsgBox("ORIGINAL PRICE MUST BE ATLEAST 1(ONE) ", MsgBoxStyle.Critical)
            OriginalPriceTextBox.Select()
            Return
        End If
        'If MinimumPriceTextBox.Text.ToString().Trim() = "" Then
        '    MsgBox("MINIMUM PRICE IS REQUIRED", MsgBoxStyle.Critical)
        '    MinimumPriceTextBox.Select()
        '    Return
        'End If
        'If Double.Parse(MinimumPriceTextBox.Text.ToString().Trim()) <= 0 Then
        '    MsgBox("MINIMUM PRICE MUST BE ATLEAST 1(ONE) ", MsgBoxStyle.Critical)
        '    MinimumPriceTextBox.Select()
        '    Return
        'End If
        'If MaximumPriceTextBox.Text.ToString().Trim() = "" Then
        '    MsgBox("MAXIMUM PRICE IS REQUIRED", MsgBoxStyle.Critical)
        '    MaximumPriceTextBox.Select()
        '    Return
        'End If
        'If Double.Parse(MaximumPriceTextBox.Text.ToString().Trim()) <= 0 Then
        '    MsgBox("MAXIMUM PRICE MUST BE ATLEAST 1(ONE) ", MsgBoxStyle.Critical)
        '    MaximumPriceTextBox.Select()
        '    Return
        'End If
        If FinalPriceTextBox.Text.ToString().Trim() = "" Then
            MsgBox("FINAL PRICE IS REQUIRED", MsgBoxStyle.Critical)
            FinalPriceTextBox.Select()
            Return
        End If
        If Double.Parse(FinalPriceTextBox.Text.ToString().Trim()) <= 0 Then
            MsgBox("FINAL PRICE MUST BE ATLEAST 1(ONE) ", MsgBoxStyle.Critical)
            FinalPriceTextBox.Select()
            Return
        End If

        Dim ms As New MemoryStream
        ProductImagePictureBox.Image.Save(ms, ProductImagePictureBox.Image.RawFormat)
        If LblAddEditMode.Text = "(Create new Record)" Then

            Dim query = "SELECT * FROM Product Where ProductCode = '" + ProductCodeTextBox.Text.ToString().Trim() + "' OR Barcode = '" + BarcodeTextBox.Text.ToString().Trim() + "'"
            Try
                Dim conn As SqlConnection = New SqlConnection(connection)
                Dim cmd As SqlCommand = New SqlCommand(query, conn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("THIS PRODUCT CODE OR BARCODE IS ALREADY EXISTS", MsgBoxStyle.Critical)
                    ProductCodeTextBox.Select()
                    Return
                End If
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                Return
            End Try


            Dim command1 As New SqlCommand("insert into Product values (@ProductCode,@ProductName,@ProductImage,@Barcode,@CategoryName,@BrandName,@SupplierName,@OriginalPrice,@DiscountedPerc,@DiscountedDateFrom,@DiscountedDateTo,@DiscountedPrice,@FinalPrice,@Quantity,@IsInstock,@CreatedAt,@CreatedBy,@MinimumPrice,@MaximumPrice,@ExpiryDate)", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductImage", SqlDbType.Image).Value = ms.ToArray
            command1.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = BarcodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = BrandNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@OriginalPrice", SqlDbType.VarChar).Value = OriginalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedPerc", SqlDbType.VarChar).Value = ""
            command1.Parameters.Add("@DiscountedDateFrom", SqlDbType.VarChar).Value = DateTime.Now
            command1.Parameters.Add("@DiscountedDateTo", SqlDbType.VarChar).Value = DateTime.Now
            command1.Parameters.Add("@DiscountedPrice", SqlDbType.VarChar).Value = "0.00"
            command1.Parameters.Add("@FinalPrice", SqlDbType.VarChar).Value = FinalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsInstock", SqlDbType.VarChar).Value = "1"
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
            command1.Parameters.Add("@MinimumPrice", SqlDbType.VarChar).Value = MinimumPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@MaximumPrice", SqlDbType.VarChar).Value = MaximumPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ExpiryDate", SqlDbType.VarChar).Value = If(CheckBoxExpiryDate.Checked = True, ExpiryDateDateTimePicker.Value.ToString().Trim(), DBNull.Value)
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                    GroupBox1.Visible = False
                    RefreshData()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        ElseIf LblAddEditMode.Text = "(Update existing Record)" Then
            Dim command1 As New SqlCommand("update Product set ProductCode=@ProductCode,ProductName=@ProductName,ProductImage=@ProductImage,Barcode=@Barcode,CategoryName=@CategoryName,BrandName=@BrandName,SupplierName=@SupplierName,OriginalPrice=@OriginalPrice,DiscountedPerc =@DiscountedPerc,DiscountedDateFrom=@DiscountedDateFrom,DiscountedDateTo=@DiscountedDateTo,DiscountedPrice=@DiscountedPrice,FinalPrice=@FinalPrice,Quantity=@Quantity,IsInstock=@IsInstock,MinimumPrice=@MinimumPrice,MaximumPrice=@MaximumPrice,ExpiryDate=@ExpiryDate where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductImage", SqlDbType.Image).Value = ms.ToArray
            command1.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = BarcodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = BrandNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@OriginalPrice", SqlDbType.VarChar).Value = OriginalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedPerc", SqlDbType.VarChar).Value = ""
            command1.Parameters.Add("@DiscountedDateFrom", SqlDbType.VarChar).Value = DateTime.Now
            command1.Parameters.Add("@DiscountedDateTo", SqlDbType.VarChar).Value = DateTime.Now
            command1.Parameters.Add("@DiscountedPrice", SqlDbType.VarChar).Value = "0.00"
            command1.Parameters.Add("@FinalPrice", SqlDbType.VarChar).Value = FinalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsInstock", SqlDbType.VarChar).Value = "1"
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
            command1.Parameters.Add("@MinimumPrice", SqlDbType.VarChar).Value = MinimumPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@MaximumPrice", SqlDbType.VarChar).Value = MaximumPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ExpiryDate", SqlDbType.VarChar).Value = If(CheckBoxExpiryDate.Checked = True, ExpiryDateDateTimePicker.Value.ToString().Trim(), DBNull.Value)
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    GroupBox1.Visible = False
                    RefreshData()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files(*.Jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ProductImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub QuantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show(“Please enter numbers only”)
            e.Handled = True
        End If
    End Sub

    Private Sub OriginalPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles OriginalPriceTextBox.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    MessageBox.Show(“Please enter numbers only”)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub FinalPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FinalPriceTextBox.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    MessageBox.Show(“Please enter numbers only”)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub OriginalPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles OriginalPriceTextBox.TextChanged
        If OriginalPriceTextBox.Text <> "" Then
            MinimumPriceTextBox.Text = OriginalPriceTextBox.Text
        Else
            MinimumPriceTextBox.Text = "0.00"
        End If
    End Sub

    Private Sub MinimumPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MinimumPriceTextBox.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    MessageBox.Show(“Please enter numbers only”)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub MaximumPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaximumPriceTextBox.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    MessageBox.Show(“Please enter numbers only”)
        '    e.Handled = True
        'End If
    End Sub

    Private Sub CheckBoxExpiryDate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExpiryDate.CheckedChanged
        If CheckBoxExpiryDate.Checked = True Then
            ExpiryDateDateTimePicker.Visible = True
        Else
            ExpiryDateDateTimePicker.Visible = False
        End If
    End Sub

    Private Sub LinkLabelAddQuantity_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelAddQuantity.LinkClicked
        Dim prdQ As New ProductQuantity

        GroupBox1.Visible = False
        prdQ.IdTextBox.Text = ""
        prdQ.ProductCodeTextBox.Text = ""
        prdQ.ProductNameTextBox.Text = ""
        prdQ.OldQuantityTextBox.Text = "0"
        prdQ.NewQuantityTextBox.Text = "0"

        prdQ.IdTextBox.Text = ""
        prdQ.ProductCodeTextBox.Text = ProductCodeTextBox.Text.ToString().Trim()
        prdQ.ProductNameTextBox.Text = ProductNameTextBox.Text.ToString().Trim()
        prdQ.OldQuantityTextBox.Text = QuantityTextBox.Text.ToString().Trim()
        prdQ.TotalQuantityTextBox.Text = QuantityTextBox.Text.ToString().Trim()
        prdQ.NewQuantityTextBox.Select()
        prdQ.RefreshData(ProductCodeTextBox.Text.ToString().Trim())

        prdQ.ShowDialog()
    End Sub


    'Private Sub DiscountedPercTextBox_TextChanged(sender As Object, e As EventArgs)
    '    Try
    '        Dim dicounted_price As Double
    '        dicounted_price = Double.Parse(OriginalPriceTextBox.Text) * (Double.Parse(DiscountedPercTextBox.Text) / 100)
    '        DiscountedPriceTextBox.Text = dicounted_price.ToString("###,##0.00")

    '        Dim final_price As Double
    '        final_price = Double.Parse(OriginalPriceTextBox.Text) - Double.Parse(DiscountedPriceTextBox.Text)
    '        FinalPriceTextBox.Text = final_price.ToString("###,##0.00")
    '    Catch ex As Exception
    '        DiscountedPriceTextBox.Text = "0.00"

    '    End Try
    'End Sub

    'Private Sub OriginalPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles OriginalPriceTextBox.TextChanged
    '    Try
    '        Dim final_price As Double
    '        final_price = Double.Parse(OriginalPriceTextBox.Text) - Double.Parse(DiscountedPriceTextBox.Text)
    '        FinalPriceTextBox.Text = final_price.ToString("###,##0.00")

    '        Dim dicounted_price As Double
    '        dicounted_price = Double.Parse(OriginalPriceTextBox.Text) * (Double.Parse(DiscountedPercTextBox.Text) / 100)
    '        DiscountedPriceTextBox.Text = dicounted_price.ToString("###,##0.00")
    '    Catch ex As Exception
    '        FinalPriceTextBox.Text = "0.00"
    '    End Try
    'End Sub


    Public Sub Searchtextbox()
        ProductNameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
        ProductNameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        getData(DataCollection)
        ProductNameTextBox.AutoCompleteCustomSource = DataCollection
    End Sub
    Public Sub getData(ByVal dataCollection As AutoCompleteStringCollection)
        Dim query = "SELECT ProductName FROM Product ORDER BY Id DESC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataSet
            da.Fill(dt)
            For Each row As DataRow In dt.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next

        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try

    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        RefreshData()
    End Sub

    Private Sub LinkLabelChangePrice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelChangePrice.LinkClicked
        Dim prdPrice As New ProductPrice

        GroupBox1.Visible = False
        prdPrice.IdTextBox.Text = ""
        prdPrice.ProductCodeTextBox.Text = ""
        prdPrice.ProductNameTextBox.Text = ""
        prdPrice.OldOriginalPriceTextBox.Text = "0.00"
        prdPrice.OldFinalPriceTextBox.Text = "0.00"
        prdPrice.NewOriginalPriceTextBox.Text = "0.00"
        prdPrice.NewFinalPriceTextBox.Text = "0.00"

        prdPrice.IdTextBox.Text = ""
        prdPrice.ProductCodeTextBox.Text = ProductCodeTextBox.Text.ToString().Trim()
        prdPrice.ProductNameTextBox.Text = ProductNameTextBox.Text.ToString().Trim()
        prdPrice.OldOriginalPriceTextBox.Text = OriginalPriceTextBox.Text.ToString().Trim()
        prdPrice.OldFinalPriceTextBox.Text = FinalPriceTextBox.Text.ToString.Trim()
        prdPrice.NewOriginalPriceTextBox.Text = OriginalPriceTextBox.Text.ToString().Trim()
        prdPrice.NewFinalPriceTextBox.Text = FinalPriceTextBox.Text.ToString.Trim()
        prdPrice.NewOriginalPriceTextBox.Select()
        prdPrice.RefreshData(ProductCodeTextBox.Text.ToString().Trim())

        prdPrice.ShowDialog()
    End Sub
End Class