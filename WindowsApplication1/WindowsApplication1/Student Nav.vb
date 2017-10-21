Imports System.Data.SqlClient
Public Class Student_Nav
    Public dbconn As New SqlConnection
    Public dbcomm As New SqlCommand
    Public sql As String
    Public dbread As SqlDataReader
    Public studentid As String

    Private Sub Student_Nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn = New SqlConnection("data source=LENOVO-PC;database=DBLKS;integrated security=true")

        Try
            dbconn.Open()
            schedule()
            profil()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Panel1.Location = New Point(105, 0)
    End Sub

    Private Sub ManageToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub HelpToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Login.Show()
        Me.Close()
    End Sub

    Public Sub profil()
        sql = "select * from Student where StudentID='" & studentid & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            dbread.Read()
            txtId.Text = studentid
            txtName.Text = dbread("Name_st")
            txtAddress.Text = dbread("Address")
            DateTimePicker1.Value = dbread("DateofBirth")
            txtPhone.Text = dbread("NoHp")
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Public Sub schedule()
        sql = "select * from Student JOIN DetailClass ON DetailClass.StudentID = Student.StudentID join HeaderSchedule as hs on hs.ClassID=DetailClass.ClassID join Teacher as t on t.TeacherID=hs.TeacherID join Subject as s on hs.SubjectID=s.SubjectID join Class as c on hs.ClassID=c.ClassID where student.StudentID='" & studentid & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read()
                DataGridView2.Rows.Add(dbread("SubjectID"), dbread("Name_sb"), dbread("Name_c"), dbread("Day"), dbread("Time"), dbread("Name_t"))
            End While
            dbread.Close()
            Info_Subject.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = DataGridView2.CurrentRow.Index
        sql = "select * from Subject where SubjectID='" & DataGridView2.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            Info_Subject.subject = dbread("Name_sb")
            Info_Subject.desc = dbread("Description")
            Info_Subject.assignment = dbread("Assignment")
            Info_Subject.mid = dbread("Mid_Exam")
            Info_Subject.final = dbread("Final_Exam")
            dbread.Close()
            Info_Subject.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub btnInsertSchedule_Click(sender As Object, e As EventArgs) Handles btnInsertSchedule.Click
        sql = "update Student set Name_st='" & txtName.Text & "',DateofBirth='" & DateTimePicker1.Value.ToShortDateString & "',Address='" & txtAddress.Text & "',NoHp='" & txtPhone.Text & "' where StudentID='" & txtId.Text & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            MsgBox("Update data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        profil()
    End Sub

    Private Sub btnDeleteSchedule_Click(sender As Object, e As EventArgs) Handles btnDeleteSchedule.Click
        profil()
    End Sub
End Class