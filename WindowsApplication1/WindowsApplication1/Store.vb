Imports System.Data.SqlClient
Public Class Store
    Public dbconn As New SqlConnection
    Public dbcomm As New SqlCommand
    Public sql As String
    Public dbread As SqlDataReader
    Public cashier As String
    Public price As Integer
    Public total As Integer
    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBLKSDataSet4.Beli' table. You can move, or remove it, as needed.
        Me.BeliTableAdapter.Fill(Me.DBLKSDataSet4.Beli)
        'TODO: This line of code loads data into the 'DBLKSDataSet4.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DBLKSDataSet4.Barang)
        'TODO: This line of code loads data into the 'DBLKSDataSet4.Teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter2.Fill(Me.DBLKSDataSet4.Teacher)
        'TODO: This line of code loads data into the 'DBLKSDataSet4.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter2.Fill(Me.DBLKSDataSet4.Student)
        Panel1.Location = New Point(81, 0)

        dbconn = New SqlConnection("data source=LENOVO-PC;database=DBLKS;integrated security=true")

        Try
            dbconn.Open()
            struck()
            harga()
            Stock()
            report()
            cbCashier.SelectedValue = cashier
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        TabControl1.SelectTab(2)
    End Sub

    Public Sub struck()
        DataGridView5.Rows.Clear()
        sql = "select * from Jual as j join Barang as b on j.id_barang=b.id_barang join Teacher as t on j.TeacherID=t.TeacherID join Student as s on j.StudentID=s.StudentID"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read()
                DataGridView5.Rows.Add(dbread("id_jual"), dbread("Name_t"), dbread("Name_st"), dbread("nama_barang"), dbread("quantity"), dbread("total"), dbread("date").toshortdatestring)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            dbread.Close()
        End Try
    End Sub

    Public Sub reset()
        txtQuantity.Text = ""
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub harga()
        sql = "select * from Barang where id_barang='" & cbItem.SelectedValue & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()
            price = dbread("jual")
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            dbread.Close()
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtQuantity.Text = "" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim a As Integer = txtQuantity.Text
            total = a * price
            sql = "insert into Jual(StudentID,TeacherID,id_barang,quantity,total,date) values('" & cbCustomer.SelectedValue & "','" & cbCashier.SelectedValue & "','" & cbItem.SelectedValue & "','" & txtQuantity.Text & "','" & total & "','" & DateTimePicker1.Text & "')"
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            Dim b As Integer = txtQuantity.Text
            Dim sql1 As String = "update Barang set stock=stock-" & b & " where id_barang='" & cbItem.SelectedValue & "'"

            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            Dim jual As String
            Dim beli As String
            Dim sql2 As String = "select * from Barang where id_barang='" & cbItem.SelectedValue & "'"
            Try
                dbcomm = New SqlCommand(sql2, dbconn)
                dbread = dbcomm.ExecuteReader()
                dbread.Read()
                jual = dbread("jual")
                beli = dbread("beli")
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try


            Dim sql3 As String = "insert into Transaksi(nama_barang,jual,beli,quantity,total,date) values('" & cbItem.Text & "','" & jual & "','" & beli & "','" & txtQuantity.Text & "','" & total & "','" & DateTimePicker1.Text & "')"

            Try
                dbcomm = New SqlCommand(sql3, dbconn)
                dbread = dbcomm.ExecuteReader()
                MsgBox("Insert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            struck()
            reset()
        End If
    End Sub

    Private Sub cbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbItem.SelectedIndexChanged
        harga()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        'Dim a As Integer = txtQuantity.Text
        'total = txtQuantity.Text * price
        'txtPrice.Text = total
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = DataGridView5.CurrentRow.Index
        sql = "delete Jual where id_jual='" & DataGridView5.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            MsgBox("Delete data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        struck()
        reset()
    End Sub

    'item

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuy.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSell.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub resetItem()
        txtId.Text = ""
        txtName.Text = ""
        txtStock.Text = ""
        txtBuy.Text = ""
        txtSell.Text = ""
        txtStock.Text = ""
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        resetItem()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        txtId.Text = DataGridView1.Item(0, i).Value
        txtName.Text = DataGridView1.Item(1, i).Value
        txtStock.Text = DataGridView1.Item(2, i).Value
        txtBuy.Text = DataGridView1.Item(3, i).Value
        txtSell.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub btnInsertStudent_Click(sender As Object, e As EventArgs) Handles btnInsertStudent.Click
        sql = "insert into Barang(nama_barang,stock,jual,beli) values('" & txtName.Text & "', '" & txtStock.Text & "', '" & txtBuy.Text & "', '" & txtSell.Text & "')"

        If txtId.Text = "" Or txtName.Text = "" Or txtStock.Text = "" Or txtSell.Text = "" Or txtBuy.Text = "" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader
                MsgBox(" ThenInsert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            Me.BarangTableAdapter.Fill(Me.DBLKSDataSet4.Barang)
            resetItem()
        End If
    End Sub

    Private Sub btnDeleteSudent_Click(sender As Object, e As EventArgs) Handles btnDeleteSudent.Click
        Dim i As Integer = DataGridView1.CurrentRow.Index

        sql = "delete Barang where id_barang='" & DataGridView1.Item(0, i).Value & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            MsgBox("delete data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        Me.BarangTableAdapter.Fill(Me.DBLKSDataSet4.Barang)
        resetItem()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        sql = "update Barang set nama_barang='" & txtName.Text & "', stock='" & txtStock.Text & "',jual='" & txtSell.Text & "',beli='" & txtBuy.Text & "' where id_barang='" & txtId.Text & "'"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            MsgBox("update data success", MsgBoxStyle.Information)
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
        Me.BarangTableAdapter.Fill(Me.DBLKSDataSet4.Barang)
        resetItem()
    End Sub

    'stock

    Public Sub Stock()
        DataGridView2.Rows.Clear()
        sql = "select * from Beli as b join Barang as ba on b.id_barang=ba.id_barang"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read()
                DataGridView2.Rows.Add(dbread("id_beli"), dbread("id_barang"), dbread("nama_barang"), dbread("quantity"), dbread("date").toshortdatestring)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub

    Private Sub txtNameTeacher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityItem.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnInsertStock_Click(sender As Object, e As EventArgs) Handles btnInsertStock.Click
        sql = "insert into Beli(id_barang,quantity,date) values('" & cbItem.SelectedValue & "','" & txtQuantityItem.Text & "', '" & DateTimePicker1.Text & "')"
        Dim qty As Integer = txtQuantityItem.Text
        Dim sql1 As String = "update Barang set stock=stock+" & qty & " where id_barang='" & cbItem.SelectedValue & "'"

        If txtQuantityItem.Text = "" Then
            MsgBox("All data must be fill", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Try
                dbcomm = New SqlCommand(sql, dbconn)
                dbread = dbcomm.ExecuteReader
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try

            Try
                dbcomm = New SqlCommand(sql1, dbconn)
                dbread = dbcomm.ExecuteReader
                MsgBox("insert data success", MsgBoxStyle.Information)
                dbread.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                dbread.Close()
            End Try
            Stock()
            Me.BarangTableAdapter.Fill(Me.DBLKSDataSet4.Barang)
            txtQuantity.Text = ""
        End If
    End Sub

    Private Sub btnCancelStock_Click(sender As Object, e As EventArgs) Handles btnCancelStock.Click
        txtQuantity.Text = ""
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Public Sub report()
        sql = "select nama_barang,jual,beli,quantity,total,date,(jual*quantity-beli*quantity) as keuntungan from Transaksi"

        Try
            dbcomm = New SqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader
            While dbread.Read()
                DataGridView3.Rows.Add(dbread("nama_barang"), dbread("beli"), dbread("jual"), dbread("quantity"), dbread("total"), dbread("keuntungan"), dbread("date").toshortdatestring)
            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            dbread.Close()
        End Try
    End Sub
End Class