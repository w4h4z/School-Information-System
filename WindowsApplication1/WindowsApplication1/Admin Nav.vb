Imports System.Data.SqlClient
Public Class Admin_Nav
    Public dbconn As New SqlConnection
    Public dbcomm As New SqlCommand
    Public sql As String
    Public dbread As SqlDataReader
    Private Sub Admin_Nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBLKSDataSet1.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.DBLKSDataSet1.Subject)
        'TODO: This line of code loads data into the 'DBLKSDataSet1._Class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.DBLKSDataSet1._Class)
        'TODO: This line of code loads data into the 'DBLKSDataSet2.Teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter1.Fill(Me.DBLKSDataSet2.Teacher)
        'TODO: This line of code loads data into the 'DBLKSDataSet1.Teacher' table. You can move, or remove it, as needed.
        'Me.TeacherTableAdapter.Fill(Me.DBLKSDataSet1.Teacher)
        'TODO: This line of code loads data into the 'DBLKSDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.DBLKSDataSet1.Student)
        'TODO: This line of code loads data into the 'DBLKSDataSet.Student' table. You can move, or remove it, as needed.
        'Me.StudentTableAdapter.Fill(Me.DBLKSDataSet.Student)

        dbconn = New SqlConnection("data source=LENOVO-PC;database=DBLKS;integrated security=true")

        Try
            dbconn.Open()
            studentNull()
            studentNotNull()
            schedule()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub TeacherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherToolStripMenuItem.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub ClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassToolStripMenuItem.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    'Student

    Private Sub btnInsertStudent_Click(sender As Object, e As EventArgs) Handles btnInsertStudent.Click
        Dim studentid As Integer
        sql = "insert into Student(Name_st,DateofBirth,Gender,Address,NoHp) output inserted.StudentID values('" & txtNameStudent.Text & "','" & DateTimePickerStudent.Value.Date & "','" & cbGenderStudent.Text & "','" & txtAddressStudent.Text & "','" & txtNoHpStudent.Text & "')"

        If txtNameStudent.Text = "" Or cbGenderStudent.Text = "Select" Or txtAddressStudent.Text = "" Or txtNoHpStudent.Text = "" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                studentid = dbcomm.ExecuteScalar()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            Dim sql1 As String = "insert into [dbo].[User](Username,Password,Role,StudentID) values('" & studentid & "','student','student','" & studentid & "')"

            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Insert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            resetStudent()
            Me.StudentTableAdapter1.Fill(Me.DBLKSDataSet1.Student)
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        txtIdStudent.Text = DataGridView1.Item(0, i).Value
        txtNameStudent.Text = DataGridView1.Item(1, i).Value
        txtAddressStudent.Text = DataGridView1.Item(4, i).Value
        cbGenderStudent.Text = DataGridView1.Item(3, i).Value
        DateTimePickerStudent.Value = DataGridView1.Item(2, i).Value
        txtNoHpStudent.Text = DataGridView1.Item(5, i).Value
    End Sub

    Private Sub btnDeleteSudent_Click(sender As Object, e As EventArgs) Handles btnDeleteSudent.Click
        sql = "delete Student where StudentID='" & txtIdStudent.Text & "'"
        Dim sql1 As String = "delete [dbo].[User] where StudentID='" & txtIdStudent.Text & "'"

        If txtIdStudent.Text = "" Then
            MsgBox("Select data first", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Delete data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            resetStudent()
            Me.StudentTableAdapter1.Fill(Me.DBLKSDataSet1.Student)
        End If
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        btnSaveStudent.Enabled = True
        btnCancelStudent.Enabled = True
    End Sub

    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        sql = "update Student set Name_st='" & txtNameStudent.Text & "', DateofBirth='" & DateTimePickerStudent.Value.Date & "',Gender='" & cbGenderStudent.Text & "',Address='" & txtAddressStudent.Text & "',NoHp='" & txtNoHpStudent.Text & "' where StudentID='" & txtIdStudent.Text & "'"

        If txtIdStudent.Text = "" Then
            MsgBox("Select data first", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtNameStudent.Text = "" Or cbGenderStudent.Text = "Select" Or txtAddressStudent.Text = "" Or txtNoHpStudent.Text = ""
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Update data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            resetStudent()
            Me.StudentTableAdapter1.Fill(Me.DBLKSDataSet1.Student)
            btnSaveStudent.Enabled = False
            btnCancelStudent.Enabled = False
        End If
    End Sub

    Public Sub resetStudent()
        txtIdStudent.Text = ""
        txtNameStudent.Text = ""
        txtAddressStudent.Text = ""
        cbGenderStudent.Text = ""
        DateTimePickerStudent.Value = Date.Now
        txtNoHpStudent.Text = ""
    End Sub

    Private Sub btnCancelStudent_Click(sender As Object, e As EventArgs) Handles btnCancelStudent.Click
        btnSaveStudent.Enabled = False
        btnCancelStudent.Enabled = False
        resetStudent()
    End Sub

    Private Sub txtNoHpStudent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHpStudent.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'End Student


    'Teacher

    Private Sub txtNoHpteacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHpteacher.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnUpdateTeacher_Click(sender As Object, e As EventArgs) Handles btnUpdateTeacher.Click
        btnCancelTeacher.Enabled = True
        btnSaveTeacher.Enabled = True
    End Sub

    Private Sub btnCancelTeacher_Click(sender As Object, e As EventArgs) Handles btnCancelTeacher.Click
        btnCancelTeacher.Enabled = False
        btnSaveTeacher.Enabled = False
    End Sub

    Public Sub resetTeacher()
        txtIdTeacher.Text = ""
        txtNameTeacher.Text = ""
        txtAddressTeacher.Text = ""
        cbGenderTeacher.Text = ""
        DateTimePickerTeacher.Value = Date.Now
        txtNoHpteacher.Text = ""
    End Sub

    Private Sub DataGridView2_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Dim i As Integer = DataGridView2.CurrentRow.Index
        txtIdTeacher.Text = DataGridView2.Item(0, i).Value
        txtNameTeacher.Text = DataGridView2.Item(1, i).Value
        txtAddressTeacher.Text = DataGridView2.Item(4, i).Value
        cbGenderTeacher.Text = DataGridView2.Item(3, i).Value
        DateTimePickerTeacher.Value = DataGridView2.Item(2, i).Value
        txtNoHpteacher.Text = DataGridView2.Item(5, i).Value
    End Sub

    Private Sub btnInsertTeacher_Click(sender As Object, e As EventArgs) Handles btnInsertTeacher.Click
        Dim teacherid As Integer
        sql = "insert into teacher(Name_t,DateofBirth,Gender,Address,NoHp) output inserted.TeacherID values('" & txtNameTeacher.Text & "','" & DateTimePickerTeacher.Value.Date & "','" & cbGenderTeacher.Text & "','" & txtAddressTeacher.Text & "','" & txtNoHpteacher.Text & "')"

        If txtNameTeacher.Text = "" Or cbGenderTeacher.Text = "Select" Or txtAddressTeacher.Text = "" Or txtNoHpteacher.Text = "" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                teacherid = dbcomm.ExecuteScalar()
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            Dim sql1 As String = "insert into [dbo].[User](Username,Password,Role,TeacherID) values('" & teacherid & "','teacher','teacher','" & teacherid & "')"

            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Insert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            resetTeacher()
            Me.TeacherTableAdapter1.Fill(Me.DBLKSDataSet2.Teacher)
        End If
    End Sub

    Private Sub btnDeleteTeacher_Click(sender As Object, e As EventArgs) Handles btnDeleteTeacher.Click
        sql = "delete teacher where teacherID='" & txtIdTeacher.Text & "'"
        Dim sql1 As String = "delete [dbo].[User] where TeacherID='" & txtIdTeacher.Text & "'"
        If txtIdTeacher.Text = "" Then
            MsgBox("Select data first", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Delete data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            resetTeacher()
            Me.TeacherTableAdapter1.Fill(Me.DBLKSDataSet2.Teacher)
        End If
    End Sub

    Private Sub btnSaveTeacher_Click(sender As Object, e As EventArgs) Handles btnSaveTeacher.Click
        sql = "update teacher set Name_t='" & txtNameTeacher.Text & "', DateofBirth='" & DateTimePickerTeacher.Value.Date & "',Gender='" & cbGenderTeacher.Text & "',Address='" & txtAddressTeacher.Text & "',NoHp='" & txtNoHpteacher.Text & "' where teacherID='" & txtIdTeacher.Text & "'"

        If txtIdTeacher.Text = "" Then
            MsgBox("Select data first", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf txtNameTeacher.Text = "" Or cbGenderTeacher.Text = "Select" Or txtAddressTeacher.Text = "" Or txtNoHpteacher.Text = ""
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Update data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            resetTeacher()
            Me.TeacherTableAdapter1.Fill(Me.DBLKSDataSet2.Teacher)
            btnSaveTeacher.Enabled = False
            btnCancelTeacher.Enabled = False
        End If
    End Sub

    'End Teacher

    'Start Class
    Public Sub studentNull()
        DataGridView3.Rows.Clear()
        sql = "select * from Student LEFT OUTER JOIN DetailClass ON DetailClass.StudentID = Student.StudentID WHERE DetailClass.ClassID IS NULL "

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read()
                DataGridView3.Rows.Add(dbread("StudentID"), dbread("Name_st"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Public Sub studentNotNull()
        DataGridView4.Rows.Clear()
        sql = "select * from Student as s join DetailClass as dc on s.StudentID=dc.StudentID where dc.ClassID='" & ComboBox1.SelectedValue & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read()
                DataGridView4.Rows.Add(dbread("StudentID"), dbread("Name_st"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        studentNotNull()
    End Sub

    Private Sub btnInsertClass_Click(sender As Object, e As EventArgs) Handles btnInsertClass.Click
        Dim i As Integer = DataGridView3.CurrentRow.Index
        sql = "insert into DetailClass(ClassID,StudentID) values('" & ComboBox1.SelectedValue & "', '" & DataGridView3.Item(0, i).Value & "')"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            MsgBox("Insert data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        studentNotNull()
        studentNull()
    End Sub

    Private Sub btnDeleteClass_Click(sender As Object, e As EventArgs) Handles btnDeleteClass.Click
        Dim i As Integer = DataGridView4.CurrentRow.Index
        sql = "delete DetailClass where StudentID='" & DataGridView4.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            MsgBox("delete data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        studentNotNull()
        studentNull()
    End Sub

    'End Class

    'Schedule

    Public Sub schedule()
        DataGridView5.Rows.Clear()
        sql = "select * from HeaderSchedule as hs join Teacher as t on hs.TeacherID=t.TeacherID join Subject as s on hs.SubjectID=s.SubjectID join Class as c on hs.ClassID=c.ClassID"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                DataGridView5.Rows.Add(dbread("ScheduleID"), dbread("SubjectID"), dbread("Name_sb"), dbread("TeacherID"), dbread("Name_t"), dbread("Name_c"), dbread("Day"), dbread("Time"))
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Public Sub reset()
        cbSubject.SelectedIndex = 0
        cbTeacher.SelectedIndex = 0
        cbClass.SelectedIndex = 0
        cbDay.Text = "Select"
        cbTime.Text = "Select"
    End Sub

    Private Sub btnUpdateSchedule_Click(sender As Object, e As EventArgs) Handles btnUpdateSchedule.Click
        btnSaveSchedule.Enabled = True
        btnCancelSchedule.Enabled = True
    End Sub

    Private Sub btnCancelSchedule_Click(sender As Object, e As EventArgs) Handles btnCancelSchedule.Click
        btnSaveSchedule.Enabled = False
        btnCancelSchedule.Enabled = False
        reset()
    End Sub

    Private Sub btnInsertSchedule_Click(sender As Object, e As EventArgs) Handles btnInsertSchedule.Click
        sql = "insert into HeaderSchedule(TeacherID,SubjectID,ClassID,Day,Time) values('" & cbTeacher.SelectedValue & "','" & cbSubject.SelectedValue & "','" & cbClass.SelectedValue & "','" & cbDay.Text & "','" & cbTime.Text & "')"

        If cbDay.Text = "Select" Or cbTime.Text = "Select" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Insert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            reset()
            schedule()
        End If
    End Sub

    Private Sub DataGridView5_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView5.CellMouseClick
        Dim i As Integer = DataGridView5.CurrentRow.Index
        sql = "select * from HeaderSchedule as hs join Teacher as t on hs.TeacherID=t.TeacherID join Subject as s on hs.SubjectID=s.SubjectID join Class as c on hs.ClassID=c.ClassID where ScheduleID='" & DataGridView5.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            cbSubject.SelectedValue = dbread("SubjectID")
            cbTeacher.SelectedValue = dbread("TeacherID")
            cbClass.SelectedValue = dbread("ClassID")
            cbDay.Text = dbread("Day")
            cbTime.Text = dbread("Time")
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub btnDeleteSchedule_Click(sender As Object, e As EventArgs) Handles btnDeleteSchedule.Click
        Dim i As Integer = DataGridView5.CurrentRow.Index

        sql = "delete HeaderSchedule where ScheduleID='" & DataGridView5.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            MsgBox("Delete data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        reset()
        schedule()
    End Sub

    Private Sub btnSaveSchedule_Click(sender As Object, e As EventArgs) Handles btnSaveSchedule.Click
        Dim i As Integer = DataGridView5.CurrentRow.Index

        sql = "update HeaderSchedule set TeacherID='" & cbTeacher.SelectedValue & "',SubjectID='" & cbSubject.SelectedValue & "',ClassID='" & cbClass.SelectedValue & "',Day='" & cbDay.Text & "',Time='" & cbTime.Text & "' where ScheduleID='" & DataGridView5.Item(0, i).Value & "'"


        If cbDay.Text = "Select" Or cbTime.Text = "Select" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Update data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            reset()
            schedule()
            btnSaveSchedule.Enabled = False
            btnCancelSchedule.Enabled = False
        End If
    End Sub

    'End Schedule
End Class


