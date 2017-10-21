<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Nav
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminNavToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbTime = New System.Windows.Forms.ComboBox()
        Me.cbDay = New System.Windows.Forms.ComboBox()
        Me.cbClass = New System.Windows.Forms.ComboBox()
        Me.cbTeacher = New System.Windows.Forms.ComboBox()
        Me.cbSubject = New System.Windows.Forms.ComboBox()
        Me.btnSaveSchedule = New System.Windows.Forms.Button()
        Me.btnCancelSchedule = New System.Windows.Forms.Button()
        Me.btnUpdateSchedule = New System.Windows.Forms.Button()
        Me.btnDeleteSchedule = New System.Windows.Forms.Button()
        Me.btnInsertSchedule = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.btnCancelStudent = New System.Windows.Forms.Button()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnDeleteSudent = New System.Windows.Forms.Button()
        Me.btnInsertStudent = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbGenderStudent = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerStudent = New System.Windows.Forms.DateTimePicker()
        Me.txtAddressStudent = New System.Windows.Forms.RichTextBox()
        Me.txtNoHpStudent = New System.Windows.Forms.TextBox()
        Me.txtNameStudent = New System.Windows.Forms.TextBox()
        Me.txtIdStudent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBLKSDataSet1 = New WindowsApplication1.DBLKSDataSet1()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveTeacher = New System.Windows.Forms.Button()
        Me.btnCancelTeacher = New System.Windows.Forms.Button()
        Me.btnUpdateTeacher = New System.Windows.Forms.Button()
        Me.btnDeleteTeacher = New System.Windows.Forms.Button()
        Me.btnInsertTeacher = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbGenderTeacher = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePickerTeacher = New System.Windows.Forms.DateTimePicker()
        Me.txtAddressTeacher = New System.Windows.Forms.RichTextBox()
        Me.txtNoHpteacher = New System.Windows.Forms.TextBox()
        Me.txtNameTeacher = New System.Windows.Forms.TextBox()
        Me.txtIdTeacher = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TeacherIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NametDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHpDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBLKSDataSet2 = New WindowsApplication1.DBLKSDataSet2()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteClass = New System.Windows.Forms.Button()
        Me.btnInsertClass = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DBLKSDataSet = New WindowsApplication1.DBLKSDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New WindowsApplication1.DBLKSDataSetTableAdapters.StudentTableAdapter()
        Me.StudentTableAdapter1 = New WindowsApplication1.DBLKSDataSet1TableAdapters.StudentTableAdapter()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherTableAdapter = New WindowsApplication1.DBLKSDataSet1TableAdapters.TeacherTableAdapter()
        Me.TeacherBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherTableAdapter1 = New WindowsApplication1.DBLKSDataSet2TableAdapters.TeacherTableAdapter()
        Me.ClassTableAdapter = New WindowsApplication1.DBLKSDataSet1TableAdapters.ClassTableAdapter()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectTableAdapter = New WindowsApplication1.DBLKSDataSet1TableAdapters.SubjectTableAdapter()
        Me.TeacherBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLKSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLKSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DBLKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminNavToolStripMenuItem, Me.ManageToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(98, 582)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminNavToolStripMenuItem
        '
        Me.AdminNavToolStripMenuItem.Enabled = False
        Me.AdminNavToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.AdminNavToolStripMenuItem.Name = "AdminNavToolStripMenuItem"
        Me.AdminNavToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.AdminNavToolStripMenuItem.Size = New System.Drawing.Size(84, 39)
        Me.AdminNavToolStripMenuItem.Text = "Admin Nav"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleToolStripMenuItem, Me.StudentToolStripMenuItem, Me.TeacherToolStripMenuItem, Me.ClassToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(84, 39)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Padding = New System.Windows.Forms.Padding(3)
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(128, 26)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(84, 39)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(84, 39)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MistyRose
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(100, 556)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 26)
        Me.Panel2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Eras Bold ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(883, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "LKS Software Apps"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(100, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1013, 525)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1005, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label26)
        Me.SplitContainer3.Panel2.Controls.Add(Me.DataGridView5)
        Me.SplitContainer3.Size = New System.Drawing.Size(999, 490)
        Me.SplitContainer3.SplitterDistance = 375
        Me.SplitContainer3.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbTime)
        Me.GroupBox3.Controls.Add(Me.cbDay)
        Me.GroupBox3.Controls.Add(Me.cbClass)
        Me.GroupBox3.Controls.Add(Me.cbTeacher)
        Me.GroupBox3.Controls.Add(Me.cbSubject)
        Me.GroupBox3.Controls.Add(Me.btnSaveSchedule)
        Me.GroupBox3.Controls.Add(Me.btnCancelSchedule)
        Me.GroupBox3.Controls.Add(Me.btnUpdateSchedule)
        Me.GroupBox3.Controls.Add(Me.btnDeleteSchedule)
        Me.GroupBox3.Controls.Add(Me.btnInsertSchedule)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(322, 361)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manage Schedule"
        '
        'cbTime
        '
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.Items.AddRange(New Object() {"06.15-08.30", "09.00-11.15", "12.00-13.30", "13.30-15.00"})
        Me.cbTime.Location = New System.Drawing.Point(112, 197)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.Size = New System.Drawing.Size(167, 21)
        Me.cbTime.TabIndex = 35
        Me.cbTime.Text = "Select"
        '
        'cbDay
        '
        Me.cbDay.FormattingEnabled = True
        Me.cbDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"})
        Me.cbDay.Location = New System.Drawing.Point(112, 157)
        Me.cbDay.Name = "cbDay"
        Me.cbDay.Size = New System.Drawing.Size(167, 21)
        Me.cbDay.TabIndex = 34
        Me.cbDay.Text = "Select"
        '
        'cbClass
        '
        Me.cbClass.DataSource = Me.ClassBindingSource1
        Me.cbClass.DisplayMember = "Name_c"
        Me.cbClass.FormattingEnabled = True
        Me.cbClass.Location = New System.Drawing.Point(112, 118)
        Me.cbClass.Name = "cbClass"
        Me.cbClass.Size = New System.Drawing.Size(167, 21)
        Me.cbClass.TabIndex = 33
        Me.cbClass.ValueMember = "ClassID"
        '
        'cbTeacher
        '
        Me.cbTeacher.DataSource = Me.TeacherBindingSource3
        Me.cbTeacher.DisplayMember = "Name_t"
        Me.cbTeacher.FormattingEnabled = True
        Me.cbTeacher.Location = New System.Drawing.Point(112, 80)
        Me.cbTeacher.Name = "cbTeacher"
        Me.cbTeacher.Size = New System.Drawing.Size(167, 21)
        Me.cbTeacher.TabIndex = 32
        Me.cbTeacher.ValueMember = "TeacherID"
        '
        'cbSubject
        '
        Me.cbSubject.DataSource = Me.SubjectBindingSource
        Me.cbSubject.DisplayMember = "Name_sb"
        Me.cbSubject.FormattingEnabled = True
        Me.cbSubject.Location = New System.Drawing.Point(112, 41)
        Me.cbSubject.Name = "cbSubject"
        Me.cbSubject.Size = New System.Drawing.Size(167, 21)
        Me.cbSubject.TabIndex = 31
        Me.cbSubject.ValueMember = "SubjectID"
        '
        'btnSaveSchedule
        '
        Me.btnSaveSchedule.Enabled = False
        Me.btnSaveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSchedule.Location = New System.Drawing.Point(197, 300)
        Me.btnSaveSchedule.Name = "btnSaveSchedule"
        Me.btnSaveSchedule.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSchedule.TabIndex = 30
        Me.btnSaveSchedule.Text = "Save"
        Me.btnSaveSchedule.UseVisualStyleBackColor = True
        '
        'btnCancelSchedule
        '
        Me.btnCancelSchedule.Enabled = False
        Me.btnCancelSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelSchedule.Location = New System.Drawing.Point(116, 300)
        Me.btnCancelSchedule.Name = "btnCancelSchedule"
        Me.btnCancelSchedule.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelSchedule.TabIndex = 29
        Me.btnCancelSchedule.Text = "Cancel"
        Me.btnCancelSchedule.UseVisualStyleBackColor = True
        '
        'btnUpdateSchedule
        '
        Me.btnUpdateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSchedule.Location = New System.Drawing.Point(116, 271)
        Me.btnUpdateSchedule.Name = "btnUpdateSchedule"
        Me.btnUpdateSchedule.Size = New System.Drawing.Size(156, 23)
        Me.btnUpdateSchedule.TabIndex = 28
        Me.btnUpdateSchedule.Text = "Update"
        Me.btnUpdateSchedule.UseVisualStyleBackColor = True
        '
        'btnDeleteSchedule
        '
        Me.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSchedule.Location = New System.Drawing.Point(116, 243)
        Me.btnDeleteSchedule.Name = "btnDeleteSchedule"
        Me.btnDeleteSchedule.Size = New System.Drawing.Size(72, 23)
        Me.btnDeleteSchedule.TabIndex = 27
        Me.btnDeleteSchedule.Text = "Delete"
        Me.btnDeleteSchedule.UseVisualStyleBackColor = True
        '
        'btnInsertSchedule
        '
        Me.btnInsertSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertSchedule.Location = New System.Drawing.Point(197, 243)
        Me.btnInsertSchedule.Name = "btnInsertSchedule"
        Me.btnInsertSchedule.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertSchedule.TabIndex = 26
        Me.btnInsertSchedule.Text = "Insert"
        Me.btnInsertSchedule.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Time"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(51, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Day"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(45, 121)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 13)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Class"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(30, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(47, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Teacher"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(34, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Subject"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Eras Bold ITC", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(259, 45)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(142, 22)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Data Schedule"
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column10, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.DataGridView5.Location = New System.Drawing.Point(4, 98)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.Size = New System.Drawing.Size(612, 353)
        Me.DataGridView5.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1005, 496)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(999, 490)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveStudent)
        Me.GroupBox1.Controls.Add(Me.btnCancelStudent)
        Me.GroupBox1.Controls.Add(Me.btnUpdateStudent)
        Me.GroupBox1.Controls.Add(Me.btnDeleteSudent)
        Me.GroupBox1.Controls.Add(Me.btnInsertStudent)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbGenderStudent)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerStudent)
        Me.GroupBox1.Controls.Add(Me.txtAddressStudent)
        Me.GroupBox1.Controls.Add(Me.txtNoHpStudent)
        Me.GroupBox1.Controls.Add(Me.txtNameStudent)
        Me.GroupBox1.Controls.Add(Me.txtIdStudent)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 404)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Student"
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.Enabled = False
        Me.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveStudent.Location = New System.Drawing.Point(212, 367)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(70, 23)
        Me.btnSaveStudent.TabIndex = 11
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.UseVisualStyleBackColor = True
        '
        'btnCancelStudent
        '
        Me.btnCancelStudent.Enabled = False
        Me.btnCancelStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelStudent.Location = New System.Drawing.Point(131, 367)
        Me.btnCancelStudent.Name = "btnCancelStudent"
        Me.btnCancelStudent.Size = New System.Drawing.Size(67, 23)
        Me.btnCancelStudent.TabIndex = 12
        Me.btnCancelStudent.Text = "Cancel"
        Me.btnCancelStudent.UseVisualStyleBackColor = True
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStudent.Location = New System.Drawing.Point(131, 338)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(151, 23)
        Me.btnUpdateStudent.TabIndex = 9
        Me.btnUpdateStudent.Text = "Update"
        Me.btnUpdateStudent.UseVisualStyleBackColor = True
        '
        'btnDeleteSudent
        '
        Me.btnDeleteSudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSudent.Location = New System.Drawing.Point(131, 310)
        Me.btnDeleteSudent.Name = "btnDeleteSudent"
        Me.btnDeleteSudent.Size = New System.Drawing.Size(67, 23)
        Me.btnDeleteSudent.TabIndex = 8
        Me.btnDeleteSudent.Text = "Delete"
        Me.btnDeleteSudent.UseVisualStyleBackColor = True
        '
        'btnInsertStudent
        '
        Me.btnInsertStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertStudent.Location = New System.Drawing.Point(212, 310)
        Me.btnInsertStudent.Name = "btnInsertStudent"
        Me.btnInsertStudent.Size = New System.Drawing.Size(70, 23)
        Me.btnInsertStudent.TabIndex = 7
        Me.btnInsertStudent.Text = "Insert"
        Me.btnInsertStudent.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Gender"
        '
        'cbGenderStudent
        '
        Me.cbGenderStudent.FormattingEnabled = True
        Me.cbGenderStudent.Items.AddRange(New Object() {"L", "P"})
        Me.cbGenderStudent.Location = New System.Drawing.Point(131, 210)
        Me.cbGenderStudent.Name = "cbGenderStudent"
        Me.cbGenderStudent.Size = New System.Drawing.Size(151, 21)
        Me.cbGenderStudent.TabIndex = 4
        Me.cbGenderStudent.Text = "Select"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Student Name"
        '
        'DateTimePickerStudent
        '
        Me.DateTimePickerStudent.Location = New System.Drawing.Point(131, 244)
        Me.DateTimePickerStudent.Name = "DateTimePickerStudent"
        Me.DateTimePickerStudent.Size = New System.Drawing.Size(181, 20)
        Me.DateTimePickerStudent.TabIndex = 5
        '
        'txtAddressStudent
        '
        Me.txtAddressStudent.Location = New System.Drawing.Point(131, 108)
        Me.txtAddressStudent.Name = "txtAddressStudent"
        Me.txtAddressStudent.Size = New System.Drawing.Size(181, 83)
        Me.txtAddressStudent.TabIndex = 3
        Me.txtAddressStudent.Text = ""
        '
        'txtNoHpStudent
        '
        Me.txtNoHpStudent.Location = New System.Drawing.Point(131, 279)
        Me.txtNoHpStudent.Name = "txtNoHpStudent"
        Me.txtNoHpStudent.Size = New System.Drawing.Size(151, 20)
        Me.txtNoHpStudent.TabIndex = 6
        '
        'txtNameStudent
        '
        Me.txtNameStudent.Location = New System.Drawing.Point(131, 72)
        Me.txtNameStudent.Name = "txtNameStudent"
        Me.txtNameStudent.Size = New System.Drawing.Size(151, 20)
        Me.txtNameStudent.TabIndex = 2
        '
        'txtIdStudent
        '
        Me.txtIdStudent.Enabled = False
        Me.txtIdStudent.Location = New System.Drawing.Point(131, 37)
        Me.txtIdStudent.Name = "txtIdStudent"
        Me.txtIdStudent.Size = New System.Drawing.Size(151, 20)
        Me.txtIdStudent.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Student ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Eras Bold ITC", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(259, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Data Student"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.NamestDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.NoHpDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(38, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(557, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 80
        '
        'NamestDataGridViewTextBoxColumn
        '
        Me.NamestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NamestDataGridViewTextBoxColumn.DataPropertyName = "Name_st"
        Me.NamestDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NamestDataGridViewTextBoxColumn.Name = "NamestDataGridViewTextBoxColumn"
        Me.NamestDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamestDataGridViewTextBoxColumn.Width = 60
        '
        'DateofBirthDataGridViewTextBoxColumn
        '
        Me.DateofBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth"
        Me.DateofBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.Name = "DateofBirthDataGridViewTextBoxColumn"
        Me.DateofBirthDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofBirthDataGridViewTextBoxColumn.Width = 91
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Width = 67
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 70
        '
        'NoHpDataGridViewTextBoxColumn
        '
        Me.NoHpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NoHpDataGridViewTextBoxColumn.DataPropertyName = "NoHp"
        Me.NoHpDataGridViewTextBoxColumn.HeaderText = "NoHp"
        Me.NoHpDataGridViewTextBoxColumn.Name = "NoHpDataGridViewTextBoxColumn"
        Me.NoHpDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoHpDataGridViewTextBoxColumn.Width = 60
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me.DBLKSDataSet1
        '
        'DBLKSDataSet1
        '
        Me.DBLKSDataSet1.DataSetName = "DBLKSDataSet1"
        Me.DBLKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1005, 496)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer2.Size = New System.Drawing.Size(999, 490)
        Me.SplitContainer2.SplitterDistance = 375
        Me.SplitContainer2.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveTeacher)
        Me.GroupBox2.Controls.Add(Me.btnCancelTeacher)
        Me.GroupBox2.Controls.Add(Me.btnUpdateTeacher)
        Me.GroupBox2.Controls.Add(Me.btnDeleteTeacher)
        Me.GroupBox2.Controls.Add(Me.btnInsertTeacher)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbGenderTeacher)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerTeacher)
        Me.GroupBox2.Controls.Add(Me.txtAddressTeacher)
        Me.GroupBox2.Controls.Add(Me.txtNoHpteacher)
        Me.GroupBox2.Controls.Add(Me.txtNameTeacher)
        Me.GroupBox2.Controls.Add(Me.txtIdTeacher)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 404)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manage Teacher"
        '
        'btnSaveTeacher
        '
        Me.btnSaveTeacher.Enabled = False
        Me.btnSaveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveTeacher.Location = New System.Drawing.Point(212, 367)
        Me.btnSaveTeacher.Name = "btnSaveTeacher"
        Me.btnSaveTeacher.Size = New System.Drawing.Size(70, 23)
        Me.btnSaveTeacher.TabIndex = 11
        Me.btnSaveTeacher.Text = "Save"
        Me.btnSaveTeacher.UseVisualStyleBackColor = True
        '
        'btnCancelTeacher
        '
        Me.btnCancelTeacher.Enabled = False
        Me.btnCancelTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelTeacher.Location = New System.Drawing.Point(131, 367)
        Me.btnCancelTeacher.Name = "btnCancelTeacher"
        Me.btnCancelTeacher.Size = New System.Drawing.Size(67, 23)
        Me.btnCancelTeacher.TabIndex = 12
        Me.btnCancelTeacher.Text = "Cancel"
        Me.btnCancelTeacher.UseVisualStyleBackColor = True
        '
        'btnUpdateTeacher
        '
        Me.btnUpdateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateTeacher.Location = New System.Drawing.Point(131, 338)
        Me.btnUpdateTeacher.Name = "btnUpdateTeacher"
        Me.btnUpdateTeacher.Size = New System.Drawing.Size(151, 23)
        Me.btnUpdateTeacher.TabIndex = 9
        Me.btnUpdateTeacher.Text = "Update"
        Me.btnUpdateTeacher.UseVisualStyleBackColor = True
        '
        'btnDeleteTeacher
        '
        Me.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTeacher.Location = New System.Drawing.Point(131, 310)
        Me.btnDeleteTeacher.Name = "btnDeleteTeacher"
        Me.btnDeleteTeacher.Size = New System.Drawing.Size(67, 23)
        Me.btnDeleteTeacher.TabIndex = 8
        Me.btnDeleteTeacher.Text = "Delete"
        Me.btnDeleteTeacher.UseVisualStyleBackColor = True
        '
        'btnInsertTeacher
        '
        Me.btnInsertTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertTeacher.Location = New System.Drawing.Point(212, 310)
        Me.btnInsertTeacher.Name = "btnInsertTeacher"
        Me.btnInsertTeacher.Size = New System.Drawing.Size(70, 23)
        Me.btnInsertTeacher.TabIndex = 7
        Me.btnInsertTeacher.Text = "Insert"
        Me.btnInsertTeacher.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Phone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Date of Birth"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(61, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Gender"
        '
        'cbGenderTeacher
        '
        Me.cbGenderTeacher.FormattingEnabled = True
        Me.cbGenderTeacher.Items.AddRange(New Object() {"L", "P"})
        Me.cbGenderTeacher.Location = New System.Drawing.Point(131, 210)
        Me.cbGenderTeacher.Name = "cbGenderTeacher"
        Me.cbGenderTeacher.Size = New System.Drawing.Size(151, 21)
        Me.cbGenderTeacher.TabIndex = 4
        Me.cbGenderTeacher.Text = "Select"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Teacher Name"
        '
        'DateTimePickerTeacher
        '
        Me.DateTimePickerTeacher.Location = New System.Drawing.Point(131, 244)
        Me.DateTimePickerTeacher.Name = "DateTimePickerTeacher"
        Me.DateTimePickerTeacher.Size = New System.Drawing.Size(181, 20)
        Me.DateTimePickerTeacher.TabIndex = 5
        '
        'txtAddressTeacher
        '
        Me.txtAddressTeacher.Location = New System.Drawing.Point(131, 108)
        Me.txtAddressTeacher.Name = "txtAddressTeacher"
        Me.txtAddressTeacher.Size = New System.Drawing.Size(181, 83)
        Me.txtAddressTeacher.TabIndex = 3
        Me.txtAddressTeacher.Text = ""
        '
        'txtNoHpteacher
        '
        Me.txtNoHpteacher.Location = New System.Drawing.Point(131, 279)
        Me.txtNoHpteacher.Name = "txtNoHpteacher"
        Me.txtNoHpteacher.Size = New System.Drawing.Size(151, 20)
        Me.txtNoHpteacher.TabIndex = 6
        '
        'txtNameTeacher
        '
        Me.txtNameTeacher.Location = New System.Drawing.Point(131, 72)
        Me.txtNameTeacher.Name = "txtNameTeacher"
        Me.txtNameTeacher.Size = New System.Drawing.Size(151, 20)
        Me.txtNameTeacher.TabIndex = 2
        '
        'txtIdTeacher
        '
        Me.txtIdTeacher.Enabled = False
        Me.txtIdTeacher.Location = New System.Drawing.Point(131, 37)
        Me.txtIdTeacher.Name = "txtIdTeacher"
        Me.txtIdTeacher.Size = New System.Drawing.Size(151, 20)
        Me.txtIdTeacher.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(48, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Teacher ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Eras Bold ITC", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(259, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 22)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Data Teacher"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherIDDataGridViewTextBoxColumn, Me.NametDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn1, Me.GenderDataGridViewTextBoxColumn1, Me.AddressDataGridViewTextBoxColumn1, Me.NoHpDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.TeacherBindingSource2
        Me.DataGridView2.Location = New System.Drawing.Point(38, 98)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(557, 353)
        Me.DataGridView2.TabIndex = 0
        '
        'TeacherIDDataGridViewTextBoxColumn
        '
        Me.TeacherIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TeacherIDDataGridViewTextBoxColumn.DataPropertyName = "TeacherID"
        Me.TeacherIDDataGridViewTextBoxColumn.HeaderText = "TeacherID"
        Me.TeacherIDDataGridViewTextBoxColumn.Name = "TeacherIDDataGridViewTextBoxColumn"
        Me.TeacherIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TeacherIDDataGridViewTextBoxColumn.Width = 83
        '
        'NametDataGridViewTextBoxColumn
        '
        Me.NametDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NametDataGridViewTextBoxColumn.DataPropertyName = "Name_t"
        Me.NametDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NametDataGridViewTextBoxColumn.Name = "NametDataGridViewTextBoxColumn"
        Me.NametDataGridViewTextBoxColumn.ReadOnly = True
        Me.NametDataGridViewTextBoxColumn.Width = 60
        '
        'DateofBirthDataGridViewTextBoxColumn1
        '
        Me.DateofBirthDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateofBirthDataGridViewTextBoxColumn1.DataPropertyName = "DateofBirth"
        Me.DateofBirthDataGridViewTextBoxColumn1.HeaderText = "Date of Birth"
        Me.DateofBirthDataGridViewTextBoxColumn1.Name = "DateofBirthDataGridViewTextBoxColumn1"
        Me.DateofBirthDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DateofBirthDataGridViewTextBoxColumn1.Width = 65
        '
        'GenderDataGridViewTextBoxColumn1
        '
        Me.GenderDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GenderDataGridViewTextBoxColumn1.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.Name = "GenderDataGridViewTextBoxColumn1"
        Me.GenderDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn1.Width = 67
        '
        'AddressDataGridViewTextBoxColumn1
        '
        Me.AddressDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AddressDataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn1.Name = "AddressDataGridViewTextBoxColumn1"
        Me.AddressDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn1.Width = 70
        '
        'NoHpDataGridViewTextBoxColumn1
        '
        Me.NoHpDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NoHpDataGridViewTextBoxColumn1.DataPropertyName = "NoHp"
        Me.NoHpDataGridViewTextBoxColumn1.HeaderText = "Phone Number"
        Me.NoHpDataGridViewTextBoxColumn1.Name = "NoHpDataGridViewTextBoxColumn1"
        Me.NoHpDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NoHpDataGridViewTextBoxColumn1.Width = 95
        '
        'TeacherBindingSource2
        '
        Me.TeacherBindingSource2.DataMember = "Teacher"
        Me.TeacherBindingSource2.DataSource = Me.DBLKSDataSet2
        '
        'DBLKSDataSet2
        '
        Me.DBLKSDataSet2.DataSetName = "DBLKSDataSet2"
        Me.DBLKSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.DataGridView4)
        Me.TabPage4.Controls.Add(Me.btnDeleteClass)
        Me.TabPage4.Controls.Add(Me.btnInsertClass)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1005, 496)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(562, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Participate Student"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView4.Location = New System.Drawing.Point(565, 183)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(408, 261)
        Me.DataGridView4.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'btnDeleteClass
        '
        Me.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteClass.Location = New System.Drawing.Point(478, 317)
        Me.btnDeleteClass.Name = "btnDeleteClass"
        Me.btnDeleteClass.Size = New System.Drawing.Size(63, 31)
        Me.btnDeleteClass.TabIndex = 5
        Me.btnDeleteClass.Text = "<<"
        Me.btnDeleteClass.UseVisualStyleBackColor = True
        '
        'btnInsertClass
        '
        Me.btnInsertClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertClass.Location = New System.Drawing.Point(478, 262)
        Me.btnInsertClass.Name = "btnInsertClass"
        Me.btnInsertClass.Size = New System.Drawing.Size(63, 31)
        Me.btnInsertClass.TabIndex = 4
        Me.btnInsertClass.Text = ">>"
        Me.btnInsertClass.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(45, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "List Student"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView3.Location = New System.Drawing.Point(48, 183)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(408, 261)
        Me.DataGridView3.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "StudentID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ClassBindingSource
        Me.ComboBox1.DisplayMember = "Name_c"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(407, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(194, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "ClassID"
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "Class"
        Me.ClassBindingSource.DataSource = Me.DBLKSDataSet1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(305, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Class Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(100, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 56)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Eras Bold ITC", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(387, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SMK Nusantara"
        '
        'DBLKSDataSet
        '
        Me.DBLKSDataSet.DataSetName = "DBLKSDataSet"
        Me.DBLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.DBLKSDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "Teacher"
        Me.TeacherBindingSource.DataSource = Me.DBLKSDataSet1
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'TeacherBindingSource1
        '
        Me.TeacherBindingSource1.DataMember = "Teacher"
        Me.TeacherBindingSource1.DataSource = Me.DBLKSDataSet1
        '
        'TeacherTableAdapter1
        '
        Me.TeacherTableAdapter1.ClearBeforeFill = True
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        Me.SubjectBindingSource.DataSource = Me.DBLKSDataSet1
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'TeacherBindingSource3
        '
        Me.TeacherBindingSource3.DataMember = "Teacher"
        Me.TeacherBindingSource3.DataSource = Me.DBLKSDataSet2
        '
        'ClassBindingSource1
        '
        Me.ClassBindingSource1.DataMember = "Class"
        Me.ClassBindingSource1.DataSource = Me.DBLKSDataSet1
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "ScheduleID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 88
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "SubjectID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 79
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Subject"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 68
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "TeacherID"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 83
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Teacher Name"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 95
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Class Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Day"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 51
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Time"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 55
        '
        'Admin_Nav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_Nav"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Nav"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLKSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLKSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DBLKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminNavToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBLKSDataSet As DBLKSDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As DBLKSDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents DBLKSDataSet1 As DBLKSDataSet1
    Friend WithEvents StudentBindingSource1 As BindingSource
    Friend WithEvents StudentTableAdapter1 As DBLKSDataSet1TableAdapters.StudentTableAdapter
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoHpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbGenderStudent As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerStudent As DateTimePicker
    Friend WithEvents txtAddressStudent As RichTextBox
    Friend WithEvents txtNoHpStudent As TextBox
    Friend WithEvents txtNameStudent As TextBox
    Friend WithEvents txtIdStudent As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveStudent As Button
    Friend WithEvents btnCancelStudent As Button
    Friend WithEvents btnUpdateStudent As Button
    Friend WithEvents btnDeleteSudent As Button
    Friend WithEvents btnInsertStudent As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSaveTeacher As Button
    Friend WithEvents btnCancelTeacher As Button
    Friend WithEvents btnUpdateTeacher As Button
    Friend WithEvents btnDeleteTeacher As Button
    Friend WithEvents btnInsertTeacher As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbGenderTeacher As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePickerTeacher As DateTimePicker
    Friend WithEvents txtAddressTeacher As RichTextBox
    Friend WithEvents txtNoHpteacher As TextBox
    Friend WithEvents txtNameTeacher As TextBox
    Friend WithEvents txtIdTeacher As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As DBLKSDataSet1TableAdapters.TeacherTableAdapter
    Friend WithEvents TeacherBindingSource1 As BindingSource
    Friend WithEvents DBLKSDataSet2 As DBLKSDataSet2
    Friend WithEvents TeacherBindingSource2 As BindingSource
    Friend WithEvents TeacherTableAdapter1 As DBLKSDataSet2TableAdapters.TeacherTableAdapter
    Friend WithEvents TeacherIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NametDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NoHpDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents btnDeleteClass As Button
    Friend WithEvents btnInsertClass As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label19 As Label
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As DBLKSDataSet1TableAdapters.ClassTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSaveSchedule As Button
    Friend WithEvents btnCancelSchedule As Button
    Friend WithEvents btnUpdateSchedule As Button
    Friend WithEvents btnDeleteSchedule As Button
    Friend WithEvents btnInsertSchedule As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbTime As ComboBox
    Friend WithEvents cbDay As ComboBox
    Friend WithEvents cbClass As ComboBox
    Friend WithEvents cbTeacher As ComboBox
    Friend WithEvents cbSubject As ComboBox
    Friend WithEvents SubjectBindingSource As BindingSource
    Friend WithEvents SubjectTableAdapter As DBLKSDataSet1TableAdapters.SubjectTableAdapter
    Friend WithEvents ClassBindingSource1 As BindingSource
    Friend WithEvents TeacherBindingSource3 As BindingSource
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
