Imports System.Data.SqlClient
Public Class PointOfSale
    Private Sub PointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'RefreshData()

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False

        Panel1.Visible = False
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
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Public Sub RefreshData_Details(tran_id)
        Dim query = "SELECT * FROM TransactionDetails WHERE TransactionHeaderId = '" + tran_id.ToString().Trim() + "'"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim query = "SELECT * FROM Product WHERE ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%'"
        CommonQuery(query, DataGridView1)
    End Sub

    Private Sub AddtoCart()
        Dim command1 As New SqlCommand("insert into TransactionDetails values (@TransactionHeaderId,@ProductCode,@ProductName,@CategoryName,@BrandName,@SupplierName,@Barcode,@OriginalPrice,@DiscountedPerc,@DiscountedPrice,@FinalPrice,@Quantity,@TotalAmount,@CreatedAt,@CreatedBy)", conn)
        command1.Parameters.Add("@TransactionHeaderId", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = BarcodeTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryNameComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@BrandName", SqlDbType.VarChar).Value = BrandNameComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@SupplierName", SqlDbType.VarChar).Value = SupplierNameComboBox.Text.ToString().Trim()
        command1.Parameters.Add("@OriginalPrice", SqlDbType.VarChar).Value = OriginalPriceTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@DiscountedPerc", SqlDbType.VarChar).Value = DiscountedPercTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@DiscountedPrice", SqlDbType.VarChar).Value = DiscountedPriceTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@FinalPrice", SqlDbType.VarChar).Value = FinalPriceTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@TotalAmount", SqlDbType.VarChar).Value = TextBox_TotalPerProduct.Text.ToString().Trim()
        command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else

                ' Update Quantity of Product
                Dim command_upd As New SqlCommand("UPDATE Product SET Quantity = (Product.Quantity - " + QuantityTextBox.Text.ToString().Trim() + ") WHERE ProductCode = '" + ProductCodeTextBox.Text.ToString().Trim() + "'", conn)
                command_upd.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = QuantityTextBox.Text.ToString().Trim()
                command_upd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
                result = command_upd.ExecuteNonQuery()
                ' Update Quantity of Product

                RefreshData_Details(IdTextBox.Text.ToString().Trim())
                RefreshData()
                Grandtotal()
                ' ClearEntry()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddtoCart()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ProductCodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        BarcodeTextBox.Text = ""
        CategoryNameComboBox.Text = ""
        BrandNameComboBox.Text = ""
        SupplierNameComboBox.Text = ""
        OriginalPriceTextBox.Text = "0.00"
        DiscountedPercTextBox.Text = "0.00"
        DiscountedPriceTextBox.Text = "0.00"
        DiscountedPriceTextBox.Text = "0.00"
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "1"

        ProductCodeTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        ProductNameTextBox.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        BarcodeTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        CategoryNameComboBox.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        BrandNameComboBox.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        SupplierNameComboBox.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        OriginalPriceTextBox.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString()
        DiscountedPercTextBox.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString()

        DiscountedPriceTextBox.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString()
        FinalPriceTextBox.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        'QuantityTextBox.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString()

        Try
            Dim lb() As Byte = DataGridView2.CurrentRow.Cells(3).Value
            Dim lstr As New System.IO.MemoryStream(lb)
            ProductImagePictureBox.Image = Image.FromStream(lstr)
            ProductImagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            ProductImagePictureBox.Image = My.Resources.box
        End Try

        Panel1.Visible = True
        TextBox_TotalPerProduct.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString()
        'AddtoCart()

    End Sub

    Private Sub ClearEntry()
        ProductCodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        FinalPriceTextBox.Text = "0.00"
        QuantityTextBox.Text = "0.00"
        TextBox_TotalPerProduct.Text = "0.00"
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        Try
            TextBox_TotalPerProduct.Text = (Double.Parse(FinalPriceTextBox.Text) * Double.Parse(QuantityTextBox.Text)).ToString("##,##0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNewTransaction_Click(sender As Object, e As EventArgs) Handles btnNewTransaction.Click
        Panel1.Visible = False
        Dim invoice_nbr As String
        invoice_nbr = GetLastRow("TransactionHeader", "InvoiceNo").ToString().PadLeft(10, "0")

        RefreshData()
        RefreshData_Details(invoice_nbr.ToString().Trim)

        Dim command1 As New SqlCommand("insert into TransactionHeader values (@PersonnelId,@InvoiceNo,@CustomerName,@GrandTotal,@PaymentAmount,@PaymentChange,@PaymentStatus,@CreatedAt,@CreatedBy)", conn)
        command1.Parameters.Add("@PersonnelId", SqlDbType.VarChar).Value = 1
        command1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar).Value = invoice_nbr
        command1.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = "Walk-In Customer"
        command1.Parameters.Add("@GrandTotal", SqlDbType.VarChar).Value = "0.00"
        command1.Parameters.Add("@PaymentAmount", SqlDbType.VarChar).Value = "0.00"
        command1.Parameters.Add("@PaymentChange", SqlDbType.VarChar).Value = "0.00"
        command1.Parameters.Add("@PaymentStatus", SqlDbType.VarChar).Value = "New"
        command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else

                Dim query = "SELECT * FROM TransactionHeader WHERE InvoiceNo = '" + invoice_nbr + "'"
                Try
                    Dim conn As SqlConnection = New SqlConnection(connection)
                    Dim cmd As SqlCommand = New SqlCommand(query, conn)
                    Dim da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        IdTextBox.Text = dt.Rows(0)("Id").ToString()
                        PersonnelIdTextBox.Text = dt.Rows(0)("PersonnelId").ToString()
                        InvoiceNoTextBox.Text = dt.Rows(0)("InvoiceNo").ToString()
                        CustomerNameTextBox.Text = dt.Rows(0)("CustomerName").ToString()
                        GrandTotalTextBox.Text = dt.Rows(0)("GrandTotal").ToString()
                        PaymentAmountTextBox.Text = dt.Rows(0)("PaymentAmount").ToString()
                        PaymentChangeTextBox.Text = dt.Rows(0)("PaymentChange").ToString()
                        PaymentStatusTextBox.Text = dt.Rows(0)("PaymentStatus").ToString()

                        GroupBox1.Visible = True
                        GroupBox2.Visible = True
                        GroupBox3.Visible = True
                        'GroupBox4.Visible = True

                    Else
                        MsgBox("No Data Found!", MsgBoxStyle.Critical)
                    End If

                Catch ex As Exception
                    MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                    Return
                End Try

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False

        Dim pn As New PayNow
        pn.PersonnelIdTextBox.Text = PersonnelIdTextBox.Text
        pn.InvoiceNoTextBox.Text = InvoiceNoTextBox.Text
        pn.CustomerNameTextBox.Text = CustomerNameTextBox.Text
        pn.GrandTotalTextBox.Text = GrandTotalTextBox.Text
        pn.PaymentAmountTextBox.Text = GrandTotalTextBox.Text
        pn.PaymentChangeTextBox.Text = PaymentChangeTextBox.Text
        pn.PaymentStatusTextBox.Text = PaymentStatusTextBox.Text
        pn.IconButton1.Visible = True
        pn.Receipt(InvoiceNoTextBox.Text.ToString().Trim)

        pn.ShowDialog()
    End Sub

    Private Sub Grandtotal()
        Dim query = "SELECT SUM(TotalAmount) AS TotalAmount FROM TransactionDetails WHERE TransactionHeaderId = '" + IdTextBox.Text.ToString.Trim + "'"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                GrandTotalTextBox.Text = Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                GrandTotalTextBox.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim command1 As New SqlCommand("Update TransactionHeader SET PersonnelId= @PersonnelId,CustomerName= @CustomerName,GrandTotal= @GrandTotal,PaymentAmount= @PaymentAmount,PaymentStatus= @PaymentStatus where InvoiceNo = @InvoiceNo", conn)
        command1.Parameters.Add("@PersonnelId", SqlDbType.VarChar).Value = PersonnelIdTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@InvoiceNo", SqlDbType.VarChar).Value = InvoiceNoTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = CustomerNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@GrandTotal", SqlDbType.VarChar).Value = GrandTotalTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentAmount", SqlDbType.VarChar).Value = PaymentAmountTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentChange", SqlDbType.VarChar).Value = PaymentChangeTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@PaymentStatus", SqlDbType.VarChar).Value = "Hold"
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Updated!", MsgBoxStyle.Critical)
            Else
                MsgBox("Payment Hold", MsgBoxStyle.Information)

                GroupBox1.Visible = False
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                GroupBox4.Visible = False

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.Columns(e.ColumnIndex).Name.ToString.Trim = "ColumnRemove" Then
            Try
                conn.Open()

                Dim command_delete As New SqlCommand("DELETE FROM TransactionDetails WHERE Id = @Id", conn)
                command_delete.Parameters.Add("@Id", SqlDbType.VarChar).Value = DataGridView2.CurrentRow.Cells(0).Value.ToString()
                result = command_delete.ExecuteNonQuery()

                Dim command_upd As New SqlCommand("UPDATE Product SET Quantity = (Product.Quantity + 1) WHERE ProductCode = @ProductCode", conn)
                command_upd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = DataGridView2.CurrentRow.Cells(2).Value.ToString()
                result = command_upd.ExecuteNonQuery()

                conn.Close()

                RefreshData_Details(IdTextBox.Text.ToString().Trim())
                RefreshData()
                Grandtotal()

            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try
        End If
    End Sub
End Class