Imports System.Data.SqlClient
Public Class Teacher_Nav
    Public dbconn As New SqlConnection
    Public dbcomm As New SqlCommand
    Public sql As String
    Public dbread As SqlDataReader
    Public teacherid As String
    Private Sub Teacher_Nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBLKSDataSet3.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter2.Fill(Me.DBLKSDataSet3.Student)
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

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Login.Show()
        Me.Close()
    End Sub

    Public Sub schedule()
        sql = "select * from HeaderSchedule as hs join Teacher as t on hs.TeacherID=t.TeacherID join Subject as s on hs.SubjectID=s.SubjectID join Class as c on hs.ClassID=c.ClassID"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read()
                DataGridView1.Rows.Add(dbread("SubjectID"), dbread("Name_sb"), dbread("Name_c"), dbread("Day"), dbread("Time"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
            Exit Sub
        End Try
    End Sub

    Public Sub profil()
        sql = "select * from Teacher where TeacherID='" & teacherid & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            dbread.Read()
            txtId.Text = teacherid
            txtName.Text = dbread("Name_t")
            txtAddress.Text = dbread("Address")
            DateTimePicker1.Value = dbread("DateofBirth")
            txtPhone.Text = dbread("NoHp")
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub btnDeleteTeacher_Click(sender As Object, e As EventArgs) Handles btnDeleteTeacher.Click
        profil()
    End Sub

    Private Sub btnInsertTeacher_Click(sender As Object, e As EventArgs) Handles btnInsertTeacher.Click
        sql = "update Teacher set Name_t='" & txtName.Text & "',DateofBirth='" & DateTimePicker1.Value.ToShortDateString & "',Address='" & txtAddress.Text & "',NoHp='" & txtPhone.Text & "' where TeacherID='" & txtId.Text & "'"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index
        sql = "select * from Subject where SubjectID='" & DataGridView1.Item(0, i).Value & "'"

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
End Class