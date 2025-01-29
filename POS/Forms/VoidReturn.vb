Imports System.Data.SqlClient
Public Class VoidReturn
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub VoidReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.ReturnVoidReason' table. You can move, or remove it, as needed.
        Me.ReturnVoidReasonTableAdapter.Fill(Me.Pos_dbDataSet.ReturnVoidReason)
        'TODO: This line of code loads data into the 'Pos_dbDataSet.vw_Transactions_nologo' table. You can move, or remove it, as needed.
        'Me.Vw_Transactions_nologoTableAdapter.Fill(Me.Pos_dbDataSet.vw_Transactions_nologo)
        LoadReport()
        'ClearEntry()
        IconButtonPrint.Visible = False
    End Sub
    Private Sub LoadReport()
        Dim query As String
        query = "SELECT * FROM vw_Transactions_nologo WHERE PaymentStatus='Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateTimePicker1.Value + "') AND CONVERT(date,'" + DateTimePicker2.Value + "') AND ProductName LIKE '%" + TextBoxSearch.Text.ToString().Trim() + "%' ORDER BY InvoiceNo DESC"
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
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReport()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadReport()
    End Sub
    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        LoadReport()
    End Sub
    Private Sub ClearEntry()
        TextBoxDetailsId.Text = ""
        TextBoxHeadersId.Text = ""
        TextBoxVoidRetrunQty.Text = "0"
        TextBoxInvoice.Text = ""
        TextBoxQty.Text = ""
        TextBoxCreatedAt.Text = ""
        ProductCode.Text = "--"
        TextBoxProductName.Text = ""
        TextBoxVoidRetrunQty.Text = "0"
        TextBoxVoidReturnAmount.Text = "0.00"
        TextBoxSellingPrice.Text = "0.00"
        TextBoxGrandTotal.Text = "0.00"
        UserNameTextBox.Text = ""
        PasswordTextBox.Text = ""
        ComboBoxVoidReturnReason.SelectedIndex = 0
    End Sub
    Private Sub CategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellClick
        ClearEntry()
        TextBoxDetailsId.Text = CategoryDataGridView.CurrentRow.Cells(28).Value.ToString()
        TextBoxHeadersId.Text = CategoryDataGridView.CurrentRow.Cells(7).Value.ToString()
        TextBoxInvoice.Text = CategoryDataGridView.CurrentRow.Cells(1).Value.ToString()
        ProductCode.Text = CategoryDataGridView.CurrentRow.Cells(8).Value.ToString()
        TextBoxProductName.Text = CategoryDataGridView.CurrentRow.Cells(9).Value.ToString()
        TextBoxQty.Text = Int32.Parse(CategoryDataGridView.CurrentRow.Cells(18).Value.ToString())
        TextBoxCreatedAt.Text = DateTime.Parse(CategoryDataGridView.CurrentRow.Cells(20).Value.ToString())
        TextBoxGrandTotal.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(3).Value.ToString())
        TextBoxSellingPrice.Text = Double.Parse(CategoryDataGridView.CurrentRow.Cells(17).Value.ToString())
        TextBoxVoidRetrunQty.Focus()
        IconButtonPrint.Visible = True
    End Sub

    Private Sub IconButtonPrint_Click(sender As Object, e As EventArgs) Handles IconButtonPrint.Click
        Dim userfound As Boolean
        Dim userfoundMsg As String
        userfound = False
        userfoundMsg = ""
        Dim query As String = "SELECT TOP 1 * FROM Personnel where UserName = '" + UserNameTextBox.Text.ToString().Trim() + "' and Password = '" + PasswordTextBox.Text.ToString.Trim() + "'"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If UserNameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            userfound = False
            userfoundMsg = "User name and Password is Required!"
        Else
            If dt.Rows.Count > 0 Then

                If dt.Rows(0)("IsActive") = "0" Then
                    userfound = False
                    userfoundMsg = "This User is Inactive Already!"
                Else
                    userfound = True
                    userfoundMsg = "Ok, User found!"
                End If
            Else
                userfound = False
                userfoundMsg = "No User Found!"
            End If
        End If

        If Int32.Parse(TextBoxVoidRetrunQty.Text.ToString()) <= 0 Then
            MsgBox("Input Atleast 1 (one) Quantity!", MsgBoxStyle.Critical)
            TextBoxVoidRetrunQty.Focus()
            Return
        ElseIf Int32.Parse(TextBoxVoidRetrunQty.Text.ToString()) > Int32.Parse(TextBoxQty.Text.ToString()) Then
            MsgBox("Must not be greater than Old Quantity", MsgBoxStyle.Critical)
            TextBoxVoidRetrunQty.Focus()
            Return
        ElseIf ComboBoxVoidReturnReason.Text.ToString().Trim() = "" Then
            MsgBox("Reason of Return/Void is Required!", MsgBoxStyle.Critical)
            ComboBoxVoidReturnReason.Focus()
            Return
        ElseIf userfound = False Then
            MsgBox(userfoundMsg, MsgBoxStyle.Critical)
            Return
        Else
            TextBoxVoidReturnAmount.Text = Int32.Parse(TextBoxVoidRetrunQty.Text.ToString()) * Double.Parse(TextBoxSellingPrice.Text)

            Dim command1 As New SqlCommand("insert into TransactionReturnVoid values (@TransactionHeaderId,@TransactionDetailsId,@ProductCode,@ProductName,@OldQuantity,@ReturnVoidQty,@ReturnVoidAmount,@ReturnVoidReason,@CreatedAt,@CreatedBy)", conn)
            command1.Parameters.Add("@TransactionHeaderId", SqlDbType.VarChar).Value = TextBoxHeadersId.Text.ToString().Trim()
            command1.Parameters.Add("@TransactionDetailsId", SqlDbType.VarChar).Value = TextBoxDetailsId.Text.ToString().Trim()
            command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCode.Text.ToString().Trim()
            command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = TextBoxProductName.Text.ToString().Trim()
            command1.Parameters.Add("@OldQuantity", SqlDbType.VarChar).Value = Int64.Parse(TextBoxQty.Text.ToString().Trim())
            command1.Parameters.Add("@ReturnVoidQty", SqlDbType.VarChar).Value = Int64.Parse(TextBoxVoidRetrunQty.Text.ToString().Trim())
            command1.Parameters.Add("@ReturnVoidAmount", SqlDbType.VarChar).Value = Double.Parse(TextBoxVoidReturnAmount.Text.ToString().Trim())
            command1.Parameters.Add("@ReturnVoidReason", SqlDbType.VarChar).Value = ComboBoxVoidReturnReason.SelectedItem.ToString().Trim()
            command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
            command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
            Try
                conn.Open()
                result = command1.ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
                Else
                    MsgBox("Successfully Inserted!", MsgBoxStyle.Information)

                    Dim header As New SqlCommand("Update TransactionHeader SET GrandTotal= @GrandTotal where Id = @Id", conn)
                    header.Parameters.Add("@Id", SqlDbType.VarChar).Value = TextBoxHeadersId.Text.ToString().Trim()
                    header.Parameters.Add("@GrandTotal", SqlDbType.VarChar).Value = Double.Parse(TextBoxGrandTotal.Text.ToString().Trim()) - Double.Parse(TextBoxVoidReturnAmount.Text.ToString().Trim())
                    header.ExecuteNonQuery()

                    Dim details As New SqlCommand("Update TransactionDetails SET Quantity= @Quantity,TotalAmount=(TotalAmount-@TotalAmount) where Id = @Id", conn)
                    details.Parameters.Add("@Id", SqlDbType.VarChar).Value = TextBoxDetailsId.Text.ToString().Trim()
                    details.Parameters.Add("@Quantity", SqlDbType.VarChar).Value = Int64.Parse(TextBoxQty.Text.ToString().Trim()) - Int64.Parse(TextBoxVoidRetrunQty.Text.ToString().Trim())
                    details.Parameters.Add("@TotalAmount", SqlDbType.VarChar).Value = Double.Parse(TextBoxVoidReturnAmount.Text.ToString().Trim())
                    details.ExecuteNonQuery()
                    LoadReport()
                    ClearEntry()
                End If
                conn.Close()
            Catch ex As Exception
                MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
                conn.Close()
            End Try

        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim OBJ As New ReportViewer
        OBJ.StringReportFile = "cryReturnVoid"
        OBJ.StringQuery = "SELECT * FROM TransactionReturnVoid"
        OBJ.Show()
    End Sub
End Class