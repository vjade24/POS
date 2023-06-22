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
    End Sub
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Product"
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
        Dim query = "SELECT * FROM Product WHERE ProductCode LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' OR BarCode LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
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
        DiscountedPriceTextBox.Text = "0.00"
        DiscountedDateFromDateTimePicker.ResetText()
        DiscountedDateToDateTimePicker.ResetText()
        DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0.00"
        IsInstockCheckBox.Checked = False

        BtnSave.Enabled = True
        BtnDelete.Enabled = False

        ProductCodeTextBox.Enabled = True
        BarcodeTextBox.Enabled = True
        QuantityTextBox.Enabled = True

        IdTextBox.Text = GetLastRow("Product", "Id")

    End Sub
    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        BtnSave.Enabled = True
        BtnDelete.Enabled = True
        LblAddEditMode.Text = "(Update existing Record)"

        IdTextBox.Text = ""
        ProductCodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        ProductImagePictureBox.Image = My.Resources._1
        BarcodeTextBox.Text = ""
        CategoryNameComboBox.Text = ""
        BrandNameComboBox.Text = ""
        SupplierNameComboBox.Text = ""
        OriginalPriceTextBox.Text = "0.00"
        DiscountedPercTextBox.Text = "0.00"
        DiscountedPriceTextBox.Text = "0.00"
        DiscountedDateFromDateTimePicker.ResetText()
        DiscountedDateToDateTimePicker.ResetText()
        DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0.00"
        IsInstockCheckBox.Checked = False

        IdTextBox.Text = CategoryDataGridView.CurrentRow.Cells(0).Value.ToString()
        ProductCodeTextBox.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        ProductNameTextBox.Text = CategoryDataGridView.CurrentRow.Cells(2).Value.ToString()
        'ProductImagePictureBox.Image = CategoryDataGridView.CurrentRow.Cells(3).Value
        BarcodeTextBox.Text = CategoryDataGridView.CurrentRow.Cells(4).Value.ToString()
        CategoryNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(5).Value.ToString()
        BrandNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(6).Value.ToString()
        SupplierNameComboBox.Text = CategoryDataGridView.CurrentRow.Cells(7).Value.ToString()
        OriginalPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(8).Value.ToString()).ToString("###,##0.00")
        DiscountedPercTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(9).Value.ToString()).ToString("###,##0.00")
        DiscountedDateFromDateTimePicker.Value = CategoryDataGridView.CurrentRow.Cells(10).Value.ToString()
        DiscountedDateToDateTimePicker.Value = CategoryDataGridView.CurrentRow.Cells(11).Value.ToString()
        DiscountedPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(12).Value.ToString()).ToString("###,##0.00")
        FinalPriceTextBox.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(13).Value.ToString()).ToString("###,##0.00")
        QuantityTextBox.Text = CategoryDataGridView.CurrentRow.Cells(14).Value.ToString()
        IsInstockCheckBox.Checked = CategoryDataGridView.CurrentRow.Cells(15).Value.ToString()

        Try
            Dim lb() As Byte = CategoryDataGridView.CurrentRow.Cells(3).Value
            Dim lstr As New System.IO.MemoryStream(lb)
            ProductImagePictureBox.Image = Image.FromStream(lstr)
            ProductImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            ProductImagePictureBox.Image = My.Resources.box
        End Try

        ProductCodeTextBox.Enabled = False
        BarcodeTextBox.Enabled = False
        QuantityTextBox.Enabled = False


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
        DiscountedPercTextBox.Text = "0.00"
        DiscountedPriceTextBox.Text = "0.00"
        DiscountedDateFromDateTimePicker.ResetText()
        DiscountedDateToDateTimePicker.ResetText()
        DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0.00"
        IsInstockCheckBox.Checked = False

        BtnSave.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
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
                Return
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try

        Dim ms As New MemoryStream
        ProductImagePictureBox.Image.Save(ms, ProductImagePictureBox.Image.RawFormat)
        If LblAddEditMode.Text = "(Create new Record)" Then
            Dim command1 As New SqlCommand("insert into Product values (@ProductCode,@ProductName,@ProductImage,@Barcode,@CategoryName,@BrandName,@SupplierName,@OriginalPrice,@DiscountedPerc,@DiscountedDateFrom,@DiscountedDateTo,@DiscountedPrice,@FinalPrice,@Quantity,@IsInstock,@CreatedAt,@CreatedBy)", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductImage", SqlDbType.Image).Value = ms.ToArray
            command1.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = BarcodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = BrandNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@OriginalPrice", SqlDbType.VarChar).Value = OriginalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedPerc", SqlDbType.VarChar).Value = DiscountedPercTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedDateFrom", SqlDbType.VarChar).Value = DiscountedDateFromDateTimePicker.Value
            command1.Parameters.Add("@DiscountedDateTo", SqlDbType.VarChar).Value = DiscountedDateToDateTimePicker.Value
            command1.Parameters.Add("@DiscountedPrice", SqlDbType.VarChar).Value = DiscountedPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@FinalPrice", SqlDbType.VarChar).Value = FinalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsInstock", SqlDbType.VarChar).Value = IsInstockCheckBox.Checked
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                    RefreshData()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        ElseIf LblAddEditMode.Text = "(Update existing Record)" Then
            Dim command1 As New SqlCommand("update Product set ProductCode=@ProductCode,ProductName=@ProductName,ProductImage=@ProductImage,Barcode=@Barcode,CategoryName=@CategoryName,BrandName=@BrandName,SupplierName=@SupplierName,OriginalPrice=@OriginalPrice,DiscountedPerc =@DiscountedPerc,DiscountedDateFrom=@DiscountedDateFrom,DiscountedDateTo=@DiscountedDateTo,DiscountedPrice=@DiscountedPrice,FinalPrice=@FinalPrice,Quantity=@Quantity,IsInstock=@IsInstock where Id = @Id", conn)
            command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@ProductImage", SqlDbType.Image).Value = ms.ToArray
            command1.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = BarcodeTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = BrandNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameComboBox.Text.ToString().Trim()
            command1.Parameters.Add("@OriginalPrice", SqlDbType.VarChar).Value = OriginalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedPerc", SqlDbType.VarChar).Value = DiscountedPercTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@DiscountedDateFrom", SqlDbType.VarChar).Value = DiscountedDateFromDateTimePicker.Value
            command1.Parameters.Add("@DiscountedDateTo", SqlDbType.VarChar).Value = DiscountedDateToDateTimePicker.Value
            command1.Parameters.Add("@DiscountedPrice", SqlDbType.VarChar).Value = DiscountedPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@FinalPrice", SqlDbType.VarChar).Value = FinalPriceTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
            command1.Parameters.Add("@IsInstock", SqlDbType.VarChar).Value = IsInstockCheckBox.Checked
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Updated!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
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

    Private Sub DiscountedPercTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountedPercTextBox.TextChanged
        Try
            Dim dicounted_price As Double
            dicounted_price = Double.Parse(OriginalPriceTextBox.Text) * (Double.Parse(DiscountedPercTextBox.Text) / 100)
            DiscountedPriceTextBox.Text = dicounted_price.ToString("###,##0.00")

            Dim final_price As Double
            final_price = Double.Parse(OriginalPriceTextBox.Text) - Double.Parse(DiscountedPriceTextBox.Text)
            FinalPriceTextBox.Text = final_price.ToString("###,##0.00")
        Catch ex As Exception
            DiscountedPriceTextBox.Text = "0.00"

        End Try
    End Sub

    Private Sub OriginalPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles OriginalPriceTextBox.TextChanged
        Try
            Dim final_price As Double
            final_price = Double.Parse(OriginalPriceTextBox.Text) - Double.Parse(DiscountedPriceTextBox.Text)
            FinalPriceTextBox.Text = final_price.ToString("###,##0.00")

            Dim dicounted_price As Double
            dicounted_price = Double.Parse(OriginalPriceTextBox.Text) * (Double.Parse(DiscountedPercTextBox.Text) / 100)
            DiscountedPriceTextBox.Text = dicounted_price.ToString("###,##0.00")
        Catch ex As Exception
            FinalPriceTextBox.Text = "0.00"
        End Try
    End Sub
End Class