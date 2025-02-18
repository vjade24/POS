Imports System.Data.SqlClient
Public Class PersonnelName
    Dim conn As SqlConnection = New SqlConnection(connection)
    Dim result As Integer
    Private Sub DateRemitted_ValueChanged(sender As Object, e As EventArgs) Handles DateRemitted.ValueChanged
        TotalAmount_View()
    End Sub
    Private Sub TotalAmount_View()
        Dim query As String
        query = "SELECT ISNULL(SUM(TotalAmount),0) AS TotalAmount FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateRemitted.Value + "') AND CONVERT(date,'" + DateRemitted.Value + "') "
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TotalAmount.Text = Double.Parse(dt.Rows(0)("TotalAmount").ToString()).ToString("###,##0.00")
            Else
                TotalAmount.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Public Sub RefreshData()
        Dim query = "SELECT * FROM Remittance ORDER BY Id DESC"
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            RemittanceDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Private Sub PersonnelName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.Remittance' table. You can move, or remove it, as needed.
        Me.RemittanceTableAdapter.Fill(Me.Pos_dbDataSet.Remittance)
        PersonnelName1.Text = user_login
        TotalAmount_View()
        IconButtonPrint.Visible = False
        If user_type = "Admin" Then
            GroupBox1.Visible = True
            RemittanceDataGridView.Columns(3).Visible = True
        Else
            RemittanceDataGridView.Columns(3).Visible = False
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub ClearEntry()
        TotalAmount.Text = "0.00"
        CashOnHand.Text = "0.00"
        PersonnelName1.Text = user_login
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TotalAmount.Text = "0.00" Then
            MsgBox("NO TOTAL AMOUNT", MsgBoxStyle.Information)
        Else
            Dim OBJ As New ReportViewer
            OBJ.StringReportFile = "cryRemittanceDetails"
            OBJ.StringQuery = "SELECT * FROM vw_Transactions_nologo WHERE PaymentStatus = 'Paid' AND CONVERT(date,CreatedAt) BETWEEN CONVERT(date,'" + DateRemitted.Value + "') AND CONVERT(date,'" + DateRemitted.Value + "') ORDER BY CreatedAt DESC"
            OBJ.Show()
        End If
    End Sub

    Private Sub RemittanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RemittanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Pos_dbDataSet)

    End Sub

    Private Sub ViewRemittanceReceipt(insertedId)
        Dim OBJ As New ReportViewer
        OBJ.StringReportFile = "cryRemittanceReceipt"
        If insertedId = "" Then
            OBJ.StringQuery = "SELECT TOP 1 * FROM vw_Remittance ORDER BY Id"
        Else
            OBJ.StringQuery = "SELECT * FROM vw_Remittance WHERE Id = '" + insertedId + "'"
        End If
        OBJ.Show()
    End Sub
    Private Sub RemittanceDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RemittanceDataGridView.CellClick
        TextBoxId.Text = ""
        TotalAmount.Text = "0.00"
        TextBoxCashonHandDisplay.Text = "0.00"
        TextBoxTotalsDisplay.Text = "0.00"

        TextBoxId.Text = RemittanceDataGridView.CurrentRow.Cells(0).Value.ToString()
        DateRemitted.Value = DateTime.Parse(RemittanceDataGridView.CurrentRow.Cells(1).Value.ToString())
        TotalAmount.Text = Double.Parse(RemittanceDataGridView.CurrentRow.Cells(2).Value.ToString()).ToString("###,##0.00")
        TextBoxCashonHandDisplay.Text = Double.Parse(RemittanceDataGridView.CurrentRow.Cells(3).Value.ToString()).ToString("###,##0.00")
        TextBoxTotalsDisplay.Text = (Double.Parse(TotalAmount.Text) - Double.Parse(TextBoxCashonHandDisplay.Text)).ToString("###,##0.00")
        IconButtonPrint.Visible = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim insertedId As Integer
        If Double.Parse(TotalAmount.Text.ToString().Trim()) <= 0 Then
            MsgBox("TOTAL AMOUNT is Required!", MsgBoxStyle.Critical)
            Return
        End If
        If Double.Parse(CashOnHand.Text.ToString().Trim()) <= 0 Then
            MsgBox("Cash On Hand is Required! ", MsgBoxStyle.Critical)
            CashOnHand.Select()
            Return
        End If
        Dim command1 As New SqlCommand("insert into Remittance values (@DateRemitted,@TotalAmount,@CashOnHand,@PersonnelName,@CreatedAt,@CreatedBy)", conn)
        command1.Parameters.Add("@DateRemitted", SqlDbType.VarChar).Value = DateRemitted.Value.ToString().Trim()
        command1.Parameters.Add("@TotalAmount", SqlDbType.VarChar).Value = TotalAmount.Text.ToString().Trim()
        command1.Parameters.Add("@CashOnHand", SqlDbType.VarChar).Value = CashOnHand.Text.ToString().Trim()
        command1.Parameters.Add("@PersonnelName", SqlDbType.VarChar).Value = PersonnelName1.Text
        command1.Parameters.Add("@CreatedAt", SqlDbType.VarChar).Value = DateTime.Now()
        command1.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = user_login

        Try
            conn.Open()
            'insertedId = Convert.ToInt32(command1.ExecuteScalar())
            result = command1.ExecuteNonQuery()
            If result = 0 Then
                MsgBox("No Data Inserted!", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully Inserted!", MsgBoxStyle.Information)
                RefreshData()
                ClearEntry()
                'ViewRemittanceReceipt("")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            conn.Close()
        End Try
    End Sub

    Private Sub IconButtonPrint_Click(sender As Object, e As EventArgs) Handles IconButtonPrint.Click
        ViewRemittanceReceipt(TextBoxId.Text.ToString())
    End Sub
End Class