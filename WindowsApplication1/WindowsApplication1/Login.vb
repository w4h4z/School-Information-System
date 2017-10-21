Imports System.Data.SqlClient

Public Class Login
    Public dbconn As New SqlConnection
    Public dbcomm As New SqlCommand
    Public sql As String
    Public dbread As SqlDataReader
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = False

        dbconn = New SqlConnection("data source=LENOVO-PC;database=DBLKS;integrated security=true")

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "select * from [dbo].[User] where Username='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            dbread.Read()
            If dbread.HasRows Then
                If dbread("Role") = "admin" Then
                    Admin_Nav.Show()
                    dbread.Close()
                    Me.Close()
                ElseIf dbread("Role") = "teacher"
                    Teacher_Nav.teacherid = TextBox1.Text
                    Teacher_Nav.Show()
                    dbread.Close()
                    Me.Close()
                ElseIf dbread("Role") = "student"
                    Student_Nav.studentid = TextBox1.Text
                    Student_Nav.Show()
                    dbread.Close()
                    Me.Close()
                ElseIf dbread("Role") = "store"
                    Store.cashier = TextBox1.Text
                    Store.Show()
                    dbread.Close()
                    Me.Close()
                End If
            Else
                Panel3.Visible = True
                dbread.Close()
                Exit Sub
            End If
                dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
    End Sub
End Class
