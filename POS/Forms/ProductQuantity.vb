Imports System.Data.SqlClient
Public Class ProductQuantity
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim command1 As New SqlCommand("INSERT INTO ProductQuantity values (@ProductCode,@ProductName,@OldQuantity,@NewQuantity,@CreatedAt,@CreatedBy,@TotalQuantity)", conn)
        command1.Parameters.Add("@Id", SqlDbType.VarChar).Value = IdTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductNameTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@OldQuantity", SqlDbType.VarChar).Value = OldQuantityTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@NewQuantity", SqlDbType.VarChar).Value = NewQuantityTextBox.Text.ToString().Trim()
        command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login
        command1.Parameters.Add("@TotalQuantity", SqlDbType.VarChar).Value = TotalQuantityTextBox.Text.ToString().Trim()
        Try
            conn.Open()
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Inserted and Add Quantity!", MsgBoxStyle.Information)
                ' Update Quantity of Product
                Dim command_upd As New SqlCommand("UPDATE Product SET Quantity = @TotalQuantity WHERE ProductCode = '" + ProductCodeTextBox.Text.ToString().Trim() + "'", conn)
                command_upd.Parameters.Add("@ProductCode", SqlDbType.VarChar).Value = ProductCodeTextBox.Text.ToString().Trim()
                command_upd.Parameters.Add("@TotalQuantity", SqlDbType.VarChar).Value = TotalQuantityTextBox.Text.ToString().Trim()
                result = command_upd.ExecuteNonQuery()
                ' Update Quantity of Product
                Me.Hide()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub
    Private Sub NewQuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles NewQuantityTextBox.TextChanged
        TotalQuantityTextBox.Text = Int32.Parse(OldQuantityTextBox.Text) + Int32.Parse(NewQuantityTextBox.Text)
    End Sub
    Public Sub RefreshData(ByVal ProductCode)
        Dim query = "SELECT * FROM ProductQuantity WHERE ProductCode = '" + ProductCode.ToString().Trim() + "' ORDER BY Id DESC"
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

End Class