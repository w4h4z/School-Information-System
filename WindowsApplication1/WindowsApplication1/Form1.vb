Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBLKSDataSet6.View_1' table. You can move, or remove it, as needed.
        Me.View_1TableAdapter.Fill(Me.DBLKSDataSet6.View_1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class