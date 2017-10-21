Public Class Info_Subject
    Public subject As String
    Public desc As String
    Public assignment As String
    Public mid As String
    Public final As String
    Private Sub Info_Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = subject
        Label17.Text = desc
        Label8.Text = assignment
        Label9.Text = mid
        Label10.Text = final
    End Sub
End Class