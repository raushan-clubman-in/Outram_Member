Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Public Class MemberwiseSubscriptionDetails
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J As Integer
    Dim STR_STATUS, STR_TYPE, STR_OPCTION, STRSUBS As String
    Dim ssql, sqlstring As String
    Dim txtobj1 As TextObject


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChKLIST_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_MEMBERCATEGORY As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_MEMBER As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Opt_Datewise As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Memberwise As System.Windows.Forms.RadioButton
    Friend WithEvents Txt_membercode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberwiseSubscriptionDetails))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CHKLIST_MEMBER = New System.Windows.Forms.CheckedListBox
        Me.ChKLIST_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.chklist_Category = New System.Windows.Forms.CheckedListBox
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox
        Me.CHK_STATUS = New System.Windows.Forms.CheckBox
        Me.CHK_MEMBERCATEGORY = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Opt_Datewise = New System.Windows.Forms.RadioButton
        Me.Opt_Memberwise = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_membercode = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 29)
        Me.Label1.TabIndex = 411
        '
        'CHKLIST_MEMBER
        '
        Me.CHKLIST_MEMBER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_MEMBER.Location = New System.Drawing.Point(120, 96)
        Me.CHKLIST_MEMBER.Name = "CHKLIST_MEMBER"
        Me.CHKLIST_MEMBER.Size = New System.Drawing.Size(288, 319)
        Me.CHKLIST_MEMBER.TabIndex = 432
        '
        'ChKLIST_Memberstatus
        '
        Me.ChKLIST_Memberstatus.BackColor = System.Drawing.Color.White
        Me.ChKLIST_Memberstatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKLIST_Memberstatus.Location = New System.Drawing.Point(672, 96)
        Me.ChKLIST_Memberstatus.Name = "ChKLIST_Memberstatus"
        Me.ChKLIST_Memberstatus.Size = New System.Drawing.Size(224, 319)
        Me.ChKLIST_Memberstatus.Sorted = True
        Me.ChKLIST_Memberstatus.TabIndex = 431
        '
        'chklist_Category
        '
        Me.chklist_Category.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Category.Location = New System.Drawing.Point(424, 96)
        Me.chklist_Category.Name = "chklist_Category"
        Me.chklist_Category.Size = New System.Drawing.Size(232, 319)
        Me.chklist_Category.TabIndex = 430
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SELECT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(120, 72)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(141, 24)
        Me.CHK_SELECT.TabIndex = 437
        Me.CHK_SELECT.Text = "SELECT ALL"
        '
        'CHK_STATUS
        '
        Me.CHK_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CHK_STATUS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHK_STATUS.Location = New System.Drawing.Point(672, 72)
        Me.CHK_STATUS.Name = "CHK_STATUS"
        Me.CHK_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.CHK_STATUS.TabIndex = 436
        Me.CHK_STATUS.Text = "SELECT ALL"
        '
        'CHK_MEMBERCATEGORY
        '
        Me.CHK_MEMBERCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MEMBERCATEGORY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MEMBERCATEGORY.Location = New System.Drawing.Point(424, 72)
        Me.CHK_MEMBERCATEGORY.Name = "CHK_MEMBERCATEGORY"
        Me.CHK_MEMBERCATEGORY.Size = New System.Drawing.Size(141, 24)
        Me.CHK_MEMBERCATEGORY.TabIndex = 435
        Me.CHK_MEMBERCATEGORY.Text = "SELECT ALL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Opt_Datewise)
        Me.GroupBox1.Controls.Add(Me.Opt_Memberwise)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 416)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 48)
        Me.GroupBox1.TabIndex = 438
        Me.GroupBox1.TabStop = False
        '
        'Opt_Datewise
        '
        Me.Opt_Datewise.AllowDrop = True
        Me.Opt_Datewise.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Datewise.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Opt_Datewise.Location = New System.Drawing.Point(152, 12)
        Me.Opt_Datewise.Name = "Opt_Datewise"
        Me.Opt_Datewise.Size = New System.Drawing.Size(288, 24)
        Me.Opt_Datewise.TabIndex = 433
        Me.Opt_Datewise.Text = "Datewise for All Member"
        '
        'Opt_Memberwise
        '
        Me.Opt_Memberwise.AllowDrop = True
        Me.Opt_Memberwise.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Memberwise.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Opt_Memberwise.Location = New System.Drawing.Point(8, 13)
        Me.Opt_Memberwise.Name = "Opt_Memberwise"
        Me.Opt_Memberwise.Size = New System.Drawing.Size(136, 24)
        Me.Opt_Memberwise.TabIndex = 432
        Me.Opt_Memberwise.Text = " MemberWise"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmd_view)
        Me.GroupBox2.Controls.Add(Me.Btn_close)
        Me.GroupBox2.Controls.Add(Me.cmd_Clear)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 552)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 48)
        Me.GroupBox2.TabIndex = 439
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(400, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 441
        Me.Button1.Text = "Export"
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Location = New System.Drawing.Point(280, 10)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 12
        Me.cmd_view.Text = "VIEW [F9]"
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(528, 10)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Location = New System.Drawing.Point(152, 10)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Dtp_From)
        Me.GroupBox3.Controls.Add(Me.Dtp_To)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txt_membercode)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 464)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 88)
        Me.GroupBox3.TabIndex = 440
        Me.GroupBox3.TabStop = False
        '
        'Dtp_From
        '
        Me.Dtp_From.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_From.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(480, 32)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(114, 26)
        Me.Dtp_From.TabIndex = 2338
        '
        'Dtp_To
        '
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(632, 32)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(110, 26)
        Me.Dtp_To.TabIndex = 2339
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(600, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 22)
        Me.Label4.TabIndex = 2341
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 22)
        Me.Label5.TabIndex = 2340
        Me.Label5.Text = "Date of Join From :"
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(288, 32)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 397
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 22)
        Me.Label7.TabIndex = 396
        Me.Label7.Text = "Membership No:"
        '
        'Txt_membercode
        '
        Me.Txt_membercode.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Txt_membercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_membercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_membercode.Location = New System.Drawing.Point(184, 32)
        Me.Txt_membercode.Name = "Txt_membercode"
        Me.Txt_membercode.Size = New System.Drawing.Size(104, 26)
        Me.Txt_membercode.TabIndex = 395
        Me.Txt_membercode.Text = ""
        '
        'MemberwiseSubscriptionDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 670)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CHK_SELECT)
        Me.Controls.Add(Me.CHK_STATUS)
        Me.Controls.Add(Me.CHK_MEMBERCATEGORY)
        Me.Controls.Add(Me.CHKLIST_MEMBER)
        Me.Controls.Add(Me.ChKLIST_Memberstatus)
        Me.Controls.Add(Me.chklist_Category)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MemberwiseSubscriptionDetails"
        Me.Text = "MemberwiseSubscriptionDetails"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MemberwiseSubscriptionDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MemberType_Load()
        Member_Master_Load()
        Status_load()

    End Sub
    Private Sub MemberType_Load()
        Try
            Dim DT As New DataTable
            chklist_Category.Items.Clear()
            ssql = " Select isnull(subtypecode,'') as subtypecode,isnull(subtypedesc,'') as subtypedesc From subcategorymaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Category.Items.Add(DT.Rows(Iteration).Item("subtypecode") & "." & DT.Rows(Iteration).Item("subtypedesc"))
                Next
            Else
                chklist_Category.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Member_Master_Load()
        Try
            Dim DT As New DataTable
            CHKLIST_MEMBER.Items.Clear()
            ssql = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_MEMBER.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
                Next
            Else
                CHKLIST_MEMBER.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Status_load()
        Try
            Dim i As Integer
            Dim dt As DataTable
            ChKLIST_Memberstatus.Items.Clear()
            sqlstring = "SELECT distinct(Name) FROM MemberStatusMaster where freeze<>'Y'and isnull(name,'')<>''  "
            dt = gconnection.GetValues(sqlstring)
            Dim Itration
            If dt.Rows.Count > 0 Then
                For Itration = 0 To (dt.Rows.Count - 1)
                    ChKLIST_Memberstatus.Items.Add(dt.Rows(Itration).Item("Name"))
                Next
            Else
                CHKLIST_MEMBER.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_SELECT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SELECT.CheckedChanged
        Try
            If CHK_SELECT.Checked = True Then
                For Iteration = 0 To (CHKLIST_MEMBER.Items.Count - 1)
                    CHKLIST_MEMBER.SetSelected(Iteration, True)
                    CHKLIST_MEMBER.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_MEMBER.Items.Count - 1)
                    CHKLIST_MEMBER.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_MEMBERCATEGORY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_MEMBERCATEGORY.CheckedChanged
        Try
            If CHK_MEMBERCATEGORY.Checked = True Then
                For Iteration = 0 To (chklist_Category.Items.Count - 1)
                    chklist_Category.SetSelected(Iteration, True)
                    chklist_Category.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Category.Items.Count - 1)
                    chklist_Category.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_STATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_STATUS.CheckedChanged
        Try
            If CHK_STATUS.Checked = True Then
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetSelected(Iteration, True)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MemberwiseSubscriptionDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F9 Then
                Call cmd_view_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
                Call Btn_close_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                'If CHK_SUBSCRIPTION.Checked = True Then
                '    CHK_SUBSCRIPTION.Checked = False
                'Else
                '    CHK_SUBSCRIPTION.Checked = True
                'End If
                If CHK_SELECT.Checked = True Then
                    CHK_SELECT.Checked = False
                Else
                    CHK_SELECT.Checked = True
                End If
                If CHK_MEMBERCATEGORY.Checked = True Then
                    CHK_MEMBERCATEGORY.Checked = False
                Else
                    CHK_MEMBERCATEGORY.Checked = True
                End If
                If CHK_STATUS.Checked = True Then
                    CHK_STATUS.Checked = False
                Else
                    CHK_STATUS.Checked = True
                End If
                Exit Sub
            End If
            If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Btn_close.Enabled = True Then
                    Btn_close_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Hide()
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        STR_OPCTION = ""
        STR_STATUS = ""
        STR_TYPE = ""
        STRSUBS = ""
        If MeValidate() = False Then Exit Sub
        sqlstring = "Select ReceiptsNo,ReceiptsDate,PreviousDate_from,PreviousDate_To,FromDate,ToDate,Slcode,Slname,subsCode,Subsdesc,Subsamount,TaxAmount,Discount,Amount,TotalAmount,Paymentmode,Instrumentno,InstrumentDate,Bankname,Membertype,isnull(Freeze,'') as Freeze,AddDateTime from Subscriptionreceipts where Slcode='" & Trim(Txt_membercode.Text) & "'"
        gconnection.getDataSet(sqlstring, "SUBS")
        If gdataset.Tables("SUBS").Rows.Count > 0 Then
            sqlstring = "select * from MM_View_subscriptionreceipts where SLCODE='" & Trim(Txt_membercode.Text) & "'"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_SubcriptionReceipts
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(SERVICETAXNO)
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = UCase(gCompanyAddress(5))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = sqlstring
            Viewer.Report = r
            Viewer.TableName = "MM_View_subscriptionreceipts"
            Viewer.Show()
        Else
            MessageBox.Show("This Member Does't Belongs To Subcription", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            CHK_MEMBERCATEGORY.Checked = False
            CHK_STATUS.Checked = False
            CHK_SELECT.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MeValidate() As Boolean
        Try
            MeValidate = True
            Dim MTYPECODE(0) As String

            If chklist_Category.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Category.CheckedItems.Count - 1
                    MTYPECODE = Split(chklist_Category.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
                For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
                    STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            Else
                MsgBox("Please Select The Member Status Name", vbInformation)
                MeValidate = False
                Exit Function
            End If
            If CHKLIST_MEMBER.CheckedItems.Count > 0 Then
                For I = 0 To CHKLIST_MEMBER.CheckedItems.Count - 1
                    MTYPECODE = Split(CHKLIST_MEMBER.CheckedItems(I), ".")
                    STR_OPCTION = STR_OPCTION & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_OPCTION = Mid(STR_OPCTION, 1, Len(STR_OPCTION) - 2)
            Else
                MsgBox("Please Select The Member(S)", vbInformation)
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class
