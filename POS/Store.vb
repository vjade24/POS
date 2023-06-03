Public Class Store
    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pos_dbDataSet.Store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.Pos_dbDataSet.Store)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub
End Class