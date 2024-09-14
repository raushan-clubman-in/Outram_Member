Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class Memberstatus
    Inherits System.Windows.Forms.Form
    Dim FltrStr, status, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Dim SNO As Integer = 1
    Public selectNo As Integer
    Dim txtobj1 As TextObject
    Dim gconnection As New GlobalClass
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chk_History As System.Windows.Forms.CheckBox
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chk_sumry As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_all As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_date As System.Windows.Forms.RadioButton
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents ChK_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_details As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chk_member_status_det As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Dojwisediff As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Memberstatus))
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChK_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.chk_STATUS = New System.Windows.Forms.CheckBox
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Chk_sumry = New System.Windows.Forms.CheckBox
        Me.Chk_History = New System.Windows.Forms.CheckBox
        Me.chk_member_status_det = New System.Windows.Forms.CheckBox
        Me.Chk_Dojwisediff = New System.Windows.Forms.CheckBox
        Me.Chk_details = New System.Windows.Forms.CheckBox
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.rdb_date = New System.Windows.Forms.RadioButton
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.rdb_all = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(528, 600)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 4
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(648, 600)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 5
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(408, 600)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(288, 600)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 2
        Me.CmdView.Text = "View[F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChK_Memberstatus)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.chk_STATUS)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Chk_sumry)
        Me.GroupBox1.Controls.Add(Me.Chk_History)
        Me.GroupBox1.Controls.Add(Me.chk_member_status_det)
        Me.GroupBox1.Controls.Add(Me.Chk_Dojwisediff)
        Me.GroupBox1.Controls.Add(Me.Chk_details)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(48, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 312)
        Me.GroupBox1.TabIndex = 409
        Me.GroupBox1.TabStop = False
        '
        'ChK_Memberstatus
        '
        Me.ChK_Memberstatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.ChK_Memberstatus.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK_Memberstatus.Items.AddRange(New Object() {"ABSENTEE", "ACTIVE", "CEASED", "DEFAULTER", "EXPIRED", "INACTIVE", "LIVE", "POSTED", "RESIGNED", "SUSPENDED", "TERMINATED"})
        Me.ChK_Memberstatus.Location = New System.Drawing.Point(296, 40)
        Me.ChK_Memberstatus.Name = "ChK_Memberstatus"
        Me.ChK_Memberstatus.Size = New System.Drawing.Size(216, 259)
        Me.ChK_Memberstatus.Sorted = True
        Me.ChK_Memberstatus.TabIndex = 1
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(8, 16)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(240, 23)
        Me.chk_PrintAll.TabIndex = 9
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(8, 40)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(282, 259)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 0
        '
        'chk_STATUS
        '
        Me.chk_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.chk_STATUS.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_STATUS.Location = New System.Drawing.Point(296, 16)
        Me.chk_STATUS.Name = "chk_STATUS"
        Me.chk_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.chk_STATUS.TabIndex = 10
        Me.chk_STATUS.Text = "Print All Status"
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(176, 280)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(232, 21)
        Me.txtStatus.TabIndex = 2336
        Me.txtStatus.Text = ""
        Me.txtStatus.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(16, 280)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(248, 21)
        Me.txtCategory.TabIndex = 2335
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'Chk_sumry
        '
        Me.Chk_sumry.BackColor = System.Drawing.Color.Transparent
        Me.Chk_sumry.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_sumry.Location = New System.Drawing.Point(592, 56)
        Me.Chk_sumry.Name = "Chk_sumry"
        Me.Chk_sumry.Size = New System.Drawing.Size(168, 32)
        Me.Chk_sumry.TabIndex = 2332
        Me.Chk_sumry.Text = "Summary"
        '
        'Chk_History
        '
        Me.Chk_History.BackColor = System.Drawing.Color.Transparent
        Me.Chk_History.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_History.Location = New System.Drawing.Point(592, 216)
        Me.Chk_History.Name = "Chk_History"
        Me.Chk_History.Size = New System.Drawing.Size(200, 24)
        Me.Chk_History.TabIndex = 8
        Me.Chk_History.Text = "Member Status History "
        '
        'chk_member_status_det
        '
        Me.chk_member_status_det.BackColor = System.Drawing.Color.Transparent
        Me.chk_member_status_det.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_member_status_det.Location = New System.Drawing.Point(592, 80)
        Me.chk_member_status_det.Name = "chk_member_status_det"
        Me.chk_member_status_det.Size = New System.Drawing.Size(208, 40)
        Me.chk_member_status_det.TabIndex = 2337
        Me.chk_member_status_det.Text = "Member Status Details"
        '
        'Chk_Dojwisediff
        '
        Me.Chk_Dojwisediff.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Dojwisediff.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Dojwisediff.Location = New System.Drawing.Point(592, 160)
        Me.Chk_Dojwisediff.Name = "Chk_Dojwisediff"
        Me.Chk_Dojwisediff.Size = New System.Drawing.Size(288, 48)
        Me.Chk_Dojwisediff.TabIndex = 2338
        Me.Chk_Dojwisediff.Text = "Membership Date of Join (Years)   "
        '
        'Chk_details
        '
        Me.Chk_details.BackColor = System.Drawing.Color.Transparent
        Me.Chk_details.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_details.Location = New System.Drawing.Point(592, 120)
        Me.Chk_details.Name = "Chk_details"
        Me.Chk_details.Size = New System.Drawing.Size(288, 40)
        Me.Chk_details.TabIndex = 2335
        Me.Chk_details.Text = "Member Details Date Of Join wise"
        '
        'Dtp_From
        '
        Me.Dtp_From.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(176, 16)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(114, 21)
        Me.Dtp_From.TabIndex = 2330
        '
        'rdb_date
        '
        Me.rdb_date.BackColor = System.Drawing.Color.Transparent
        Me.rdb_date.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_date.Location = New System.Drawing.Point(8, -56)
        Me.rdb_date.Name = "rdb_date"
        Me.rdb_date.Size = New System.Drawing.Size(168, 48)
        Me.rdb_date.TabIndex = 2333
        Me.rdb_date.Text = "DOJ  Between Date"
        Me.rdb_date.Visible = False
        '
        'Dtp_To
        '
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(328, 16)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(110, 21)
        Me.Dtp_To.TabIndex = 2331
        '
        'rdb_all
        '
        Me.rdb_all.BackColor = System.Drawing.Color.Transparent
        Me.rdb_all.Checked = True
        Me.rdb_all.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_all.Location = New System.Drawing.Point(808, -104)
        Me.rdb_all.Name = "rdb_all"
        Me.rdb_all.Size = New System.Drawing.Size(64, 25)
        Me.rdb_all.TabIndex = 2334
        Me.rdb_all.TabStop = True
        Me.rdb_all.Text = "All"
        Me.rdb_all.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 423
        Me.Label2.Text = "MEMBER CATEGORY "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 424
        Me.Label3.Text = "MEMBER STATUS"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(760, 16)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 12
        Me.cmd_MCodeToHelp.Visible = False
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(600, 16)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 11
        Me.cmd_MCodefromHelp.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 406
        Me.Label7.Text = "From"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(632, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 18)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "To"
        Me.Label8.Visible = False
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(656, 16)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(104, 21)
        Me.tbx_filter_To.TabIndex = 7
        Me.tbx_filter_To.Text = ""
        Me.tbx_filter_To.Visible = False
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(496, 16)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(96, 21)
        Me.tbx_Filter_From.TabIndex = 6
        Me.tbx_Filter_From.Text = ""
        Me.tbx_Filter_From.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 29)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "MEMBER STATUS REPORT"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Dtp_From)
        Me.GroupBox2.Controls.Add(Me.rdb_date)
        Me.GroupBox2.Controls.Add(Me.Dtp_To)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox2.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox2.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 440)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 88)
        Me.GroupBox2.TabIndex = 2336
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Membership"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 18)
        Me.Label4.TabIndex = 2337
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 18)
        Me.Label5.TabIndex = 2337
        Me.Label5.Text = "Date of Join From :"
        '
        'Memberstatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1000, 670)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.rdb_all)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Memberstatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Status"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Memberstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        'ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        ssql = "select isnull(subtypecode,'') as subtypecode,isnull(subtypedesc,'') as subtypedesc from subcategorymaster"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("subtypedesc"))
        Next
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        chk_Filter_Field.Focus()
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.cmdPrint.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub Memberstatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If CmdClear.Enabled = True Then
                    Call CmdClear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If CmdView.Enabled = True Then
                    Call CmdView_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If cmdPrint.Enabled = True Then
                    Call cmdPrint_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmdexit.Enabled = True Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim MEMBERTYPE As New DataTable
        'Dim Fill_Chk_str As String
        'Cmb_add_filter.Enabled = True
        'Try
        '    chk_Filter_Field.Items.Clear()
        '    If cmb_Filter_By.Text = "Member Category" Then
        '        selectNo = 0
        '        FltrStr = "MemberTypeCode in ('"
        '        Fill_Chk_str = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        '        MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        '        Dim Itration
        '        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        '        Next
        '    ElseIf cmb_Filter_By.Text = "Member Status" Then
        '        selectNo = 1
        '        FltrStr = "CurentStatus in('"
        '        chk_Filter_Field.Items.Clear()
        '        chk_Filter_Field.Items.AddRange(Lst_status.Items())
        '    End If
        'Catch ex As Exception
        '    MsgBox("An invalided input…Please close the report filter and reopen it.")
        '    Exit Sub
        'End Try
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        tbx_Filter_From.Text = ""
        tbx_filter_To.Text = ""
        chk_PrintAll.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
        chk_STATUS.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
        If rdb_date.Checked = True Then
            Dtp_From.Visible = True
            Dtp_To.Visible = True
        Else
            Dtp_From.Visible = False
            Dtp_To.Visible = False
        End If
        chk_Filter_Field.Focus()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    tbx_Filter_From.Focus()
        'End If
    End Sub

    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                Call cmd_MCodefromHelp_Click(sender, e)
                tbx_filter_To.Focus()
            End If
        End If
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        status = ""
        DispString = ""
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(TempString(1))
                    addFltrStr = FltrStr & Trim(TempString(selectNo))
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(DispString) & "," & Trim(TempString(1))
                    addFltrStr = addFltrStr & "','" & Trim(TempString(selectNo))
                End If
            Next i
            For i = 0 To ChK_Memberstatus.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = TempString(1)
                Else
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = status & "','" & TempString(1)
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Filter_From.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_filter_To.Focus()
        End If
    End Sub
    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub


    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub
    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_filter_To.TextChanged

    End Sub

    Private Sub chk_STATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_STATUS.CheckedChanged
        Dim Iteration As Integer
        If chk_STATUS.Checked = True Then
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetSelected(Iteration, True)
                    ChK_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub chk_PrintAll_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        ElseIf (ChK_Memberstatus.CheckedItems.Count <= 0) Then

            MessageBox.Show("Select the Member Status Items")
            Exit Sub
        End If
        PRINTREP = False
        If Chk_sumry.Checked = True Then
            Call Summary1()
        ElseIf Chk_History.Checked = True Then
            Call Member_Status_Report1()
        ElseIf Chk_details.Checked = True Then
            Call Member_Status_Report2()
        ElseIf chk_member_status_det.Checked = True Then
            Call Member_Status_Details()
        ElseIf Chk_Dojwisediff.Checked = True Then
            Call Member_Dateofjoin_Status()
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        If Chk_sumry.Checked = True Then
            Call Summary1()
        Else
            Call Member_Status_Report()
        End If
    End Sub
    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            tbx_filter_To.Text = Trim(vform.keyfield & "")
            'tbx_filter_To.Text = Trim(vform.keyfield1)
            CmdView.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            tbx_Filter_From.Text = Trim(vform.keyfield & "")
            'tbx_filter_To.Text = Trim(vform.keyfield1)
            tbx_filter_To.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Member_Status_Report()
        Dim dr1, dr2 As DataRow
        Dim str()() As String
        Dim Ssql, Ssql1, tmp As String
        Dim cnt, i, j, row, pagesize, pageno As Integer
        Dim STR0, STR1, STR2, STR3, STR4, STR5, STR6, STR7, STR8, STR9 As String
        Try
            Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            If chkdatevalidate = False Then Exit Sub
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text <> "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
            End If
            If ChK_Memberstatus.CheckedItems.Count = 0 Then
                MsgBox("Please Select Any One Status From the List ")
                Exit Sub
            End If
            Call chkfilterfield()
            If Chk_History.Checked = True Then
                Ssql1 = " SELECT COUNT(*) FROM MEMBERMASTER "
                If chk_Filter_Field.CheckedItems.Count = 0 Then
                    tmp = " where  curentstatus in('" & status & "') "
                Else
                    tmp = " where  membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "') "
                End If
                Ssql1 = Ssql1 & tmp
                sqlstring = " select  M.mcode,M.mname,isnull(curentstatus,'') as curentstatus,isnull(STATUSDATEfrom,'') as STATUSDATEfrom,isnull(STATUSDATEto,'') as STATUSDATEto, isnull(presentstatus,'') as presentstatus,isnull(newstatus,'') as newstatus, isnull(effectivefrom,'') as effectivefrom,isnull(effectiveto,'') as effectiveto  "
                sqlstring = sqlstring & " FROM 	membermaster M LEFT OUTER JOIN MEMBERLEDGER L ON M.MCODE = L.MCODE  "
                sqlstring = sqlstring & " where  	membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "') "

                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    Ssql = Ssql & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    Ssql1 = Ssql1 & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    'Else
                    '    sqlstring = sqlstring & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    '    Ssql = Ssql & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    '    Ssql1 = Ssql1 & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                End If
                If rdb_all.Checked = False Then
                    sqlstring = sqlstring & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    Ssql = Ssql & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    Ssql1 = Ssql1 & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                End If

                'sqlstring = sqlstring & " ORDER BY M.MCODE,EFFECTIVEFROM "
                sqlstring = sqlstring & " ORDER BY M.prefixmcode,M.msorderno,M.mcode asc"
            Else
                Ssql1 = " SELECT COUNT(*) FROM MEMBERMASTER "
                Ssql = " select  DISTINCT curentstatus FROM membermaster where  membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "') "
                sqlstring = "select  mcode,mname,curentstatus,isnull(statusdatefrom,'') as statusdatefrom,isnull(statusdateto,'') as statusdateto FROM membermaster "
                If chk_Filter_Field.CheckedItems.Count = 0 Then
                    tmp = " where  curentstatus in('" & status & "') "
                Else
                    tmp = " where  membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "') "
                End If
                sqlstring = sqlstring & tmp
                Ssql1 = Ssql1 & tmp
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    Ssql = Ssql & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    Ssql1 = Ssql1 & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                    'Else
                    'sqlstring = sqlstring & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    'Ssql = Ssql & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    'Ssql1 = Ssql1 & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                End If

                If rdb_all.Checked = False Then
                    sqlstring = sqlstring & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    Ssql = Ssql & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                    Ssql1 = Ssql1 & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                End If

                'sqlstring = sqlstring & " ORDER BY MCODE, CURENTSTATUS "
                sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno,mcode asc "

            End If
            addlist = gconnection.GetValues(sqlstring)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            pagesize = 0

            If Len(DispString) <= 58 Then
                Filewrite.WriteLine(Chr(27) + "E" & "MEMBER STATUS LIST : " & Trim(DispString) & Chr(27) + "F")
                pagesize = pagesize + 1
            Else
                Filewrite.Write(Chr(27) + "E" & "MEMBER STATUS LIST : ")
                j = 0
                For i = 1 To Len(Trim(DispString))
                    If j = 0 Then
                        Filewrite.WriteLine(Mid(Trim(DispString), 1, 58))
                        pagesize = pagesize + 1
                        i = i + 57
                    Else
                        Filewrite.WriteLine(Mid(Trim(DispString), i, 116))
                        pagesize = pagesize + 1
                        i = i + 86
                    End If
                    j = j + 1
                Next
            End If
            Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(119, "-"))
            Filewrite.WriteLine("|SNo |CODE       |NAME                                             |STATUS             |FROM DATE     |TO DATE        |")
            Filewrite.WriteLine(StrDup(119, "-"))
            SNO = 1
            For row = 0 To addlist.Rows.Count - 1
                If pagesize > 60 Then
                    pagesize = 0
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(119, "-"))
                    Filewrite.WriteLine("USER NAME : " & gUsername & Space(30) & "DATE : " & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 58 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "MEMBER STATUS LIST OF MEMBERS : " & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "MEMBER STATUS LIST OF MEMBERS : ")
                        j = 0
                        For i = 1 To Len(Trim(DispString))
                            If j = 0 Then
                                Filewrite.WriteLine(Mid(Trim(DispString), 1, 58))
                                pagesize = pagesize + 1
                                i = i + 57
                            Else
                                Filewrite.WriteLine(Mid(Trim(DispString), i, 116))
                                pagesize = pagesize + 1
                                i = i + 86
                            End If
                            j = j + 1
                        Next
                    End If
                    Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO : " & Trim(CStr(pageno)))
                    Filewrite.WriteLine(StrDup(119, "-"))
                    Filewrite.WriteLine("|SNo |CODE       |NAME                                             |STATUS             |FROM DATE     |TO DATE        |")
                    Filewrite.WriteLine(StrDup(119, "-"))
                End If
                STR1 = Mid("|" & (addlist.Rows(row).Item("mcode")), 1, 11)
                STR2 = Mid("|" & Trim((addlist.Rows(row).Item("mname"))), 1, 31)
                If Chk_History.Checked = False Then
                    STR3 = ("|" & addlist.Rows(row).Item("curentstatus"))
                    If (Format(addlist.Rows(row).Item("statusdatefrom"), "dd-MMM-yyyy")) = "01-Jan-1900" Then
                        STR4 = ("")
                    Else
                        STR4 = ("|" & Format(addlist.Rows(row).Item("statusdatefrom"), "dd-MMM-yyyy")) & " "
                    End If
                    If (Format(addlist.Rows(row).Item("statusdateto"), "dd-MMM-yyyy")) = "01-Jan-1900" Then
                        STR5 = ("")
                    Else
                        STR5 = ("|" & Format(addlist.Rows(row).Item("statusdateto"), "dd-MMM-yyyy") & Space(4) & "|")
                    End If
                Else
                    STR3 = (addlist.Rows(row).Item("newstatus"))
                    If STR3 = "" Then
                        STR3 = "|CURRENT:" & (addlist.Rows(row).Item("curentstatus"))
                    End If
                    If (Format(addlist.Rows(row).Item("effectivefrom"), "dd-MMM-yyyy")) = "01-Jan-1900" Then
                        STR4 = ("")
                    Else
                        STR4 = ("|" & Format(addlist.Rows(row).Item("effectivefrom"), "dd-MMM-yyyy")) & " "
                    End If
                    If (Format(addlist.Rows(row).Item("effectiveto"), "dd-MMM-yyyy")) = "01-Jan-1900" Then
                        STR5 = ("")
                    Else
                        STR5 = ("|" & Format(addlist.Rows(row).Item("effectiveto"), "dd-MMM-yyyy") & Space(4) & "|")
                    End If
                End If
                Filewrite.WriteLine("{0,-5}{1,-12}{2,-50}{3,-20}{4,-15}{5,-15}", SNO, STR1, STR2, STR3, STR4, STR5)
                SNO = SNO + 1
                pagesize = pagesize + 1
            Next row
            SNO = SNO - 1
            Filewrite.WriteLine(StrDup(119, "-"))
            If Chk_History.Checked = False Then
                Filewrite.WriteLine("TOTAL NO. OF MEMBERS = " & Trim(CStr(SNO)) & Space(5) & "USER NAME : " & gUsername & Space(15) & "DATE : " & Format(Date.Now, "dd/MM/yyyy"))
            Else
                Filewrite.WriteLine("USER NAME : " & gUsername & Space(15) & "DATE : " & Format(Date.Now, "dd/MM/yyyy"))
            End If

            Filewrite.WriteLine(StrDup(119, "-") & Chr(12))
            If Chk_History.Checked = False Then
                gconnection.getDataSet(Ssql, "TEST")
                If pagesize > 55 Then
                    pagesize = 0
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(119, "-"))
                    Filewrite.WriteLine("USER NAME : " & gUsername & Space(30) & "DATE : " & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 58 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "MEMBER STATUS LIST OF MEMBERS : " & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "MEMBER STATUS LIST OF MEMBERS : ")
                        j = 0
                        For i = 1 To Len(Trim(DispString))
                            If j = 0 Then
                                Filewrite.WriteLine(Mid(Trim(DispString), 1, 58))
                                pagesize = pagesize + 1
                                i = i + 57
                            Else
                                Filewrite.WriteLine(Mid(Trim(DispString), i, 116))
                                pagesize = pagesize + 1
                                i = i + 86
                            End If
                            j = j + 1
                        Next
                    End If
                    Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO : " & Trim(CStr(pageno)))
                    Filewrite.WriteLine(StrDup(119, "-"))
                    Filewrite.WriteLine("|SNo |CODE       |NAME                                            |STATUS             | FROM DATE   | TO DATE       |")
                    Filewrite.WriteLine(StrDup(119, "-"))
                End If
                If gdataset.Tables("TEST").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("TEST").Rows.Count - 1
                        tmp = Ssql1 & " AND CURENTSTATUS = '" & gdataset.Tables("TEST").Rows(i).Item(0) & "' "
                        gconnection.getDataSet(tmp, "TEST1")
                        Filewrite.WriteLine(UCase(gdataset.Tables("TEST").Rows(i).Item(0)) & Space(15 - Len(gdataset.Tables("TEST").Rows(i).Item(0))) & " : " & gdataset.Tables("TEST1").Rows(0).Item(0))
                    Next
                End If
            End If
            Filewrite.WriteLine(StrDup(119, "-") & Chr(12))
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox("Data not found..!")
            Exit Sub
        End Try
    End Sub
    Private Sub Summary()
        Dim dr1, dr2 As DataRow
        Dim str()() As String
        Dim Total As Integer
        Dim Ssql, Ssql1, tmp As String
        Dim cnt, i, j, row, pagesize, pageno As Integer
        Dim STR0, STR1, STR2, STR3, STR4, STR5, STR6, STR7, STR8, STR9 As String
        Try
            Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            If chkdatevalidate = False Then Exit Sub
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text <> "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
            End If
            If ChK_Memberstatus.CheckedItems.Count = 0 Then
                MsgBox("Please Select Any One Status From the List ")
                Exit Sub
            End If
            Call chkfilterfield()
            If Chk_sumry.Checked = True Then
                Ssql1 = " SELECT MEMBERTYPECODE,TYPEDESC,COUNT(*) AS VALUE FROM MEMBERMASTER A, MEMBERTYPE B WHERE A.MEMBERTYPECODE = B.MEMBERTYPE AND CURENTSTATUS = 'LIVE'  "
                If chk_Filter_Field.CheckedItems.Count = 0 Then
                    'tmp = " where  curentstatus in('" & status & "') "
                Else
                    tmp = " AND membertypecode in ('" & addFltrStr & "')" & " "
                End If
                Ssql1 = Ssql1 & tmp
                'sqlstring = " select  M.mcode,M.mname,isnull(curentstatus,'') as curentstatus,isnull(STATUSDATEfrom,'') as STATUSDATEfrom,isnull(STATUSDATEto,'') as STATUSDATEto, isnull(presentstatus,'') as presentstatus,isnull(newstatus,'') as newstatus, isnull(effectivefrom,'') as effectivefrom,isnull(effectiveto,'') as effectiveto  "
                'sqlstring = sqlstring & " FROM 	membermaster M LEFT OUTER JOIN MEMBERLEDGER L ON M.MCODE = L.MCODE  "
                'sqlstring = sqlstring & " where  	membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "') "

                'If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                '    sqlstring = sqlstring & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                '    Ssql = Ssql & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                '    Ssql1 = Ssql1 & " AND M.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
                'Else
                '    sqlstring = sqlstring & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                '    Ssql = Ssql & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                '    Ssql1 = Ssql1 & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
                'End If
                'sqlstring = sqlstring & " ORDER BY M.MCODE,EFFECTIVEFROM "
                Ssql1 = Ssql1 & "GROUP BY MEMBERTYPECODE,TYPEDESC ORDER BY MEMBERTYPECODE"
                'Ssql1 = Ssql1 & "GROUP BY MEMBERTYPECODE,TYPEDESC ORDER BY A.prefixmcode,A.msorderno,A.mcode asc"
            End If
            addlist = gconnection.GetValues(Ssql1)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Total = 0
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            pagesize = 0
            Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(70, "-"))
            Filewrite.WriteLine("|TYPE CODE     |TYPE NAME                         |TOTAL LIVE MEMBER|")
            Filewrite.WriteLine(StrDup(70, "-"))
            SNO = 1
            For row = 0 To addlist.Rows.Count - 1
                Filewrite.Write("{0,-14}", "|" & addlist.Rows(row).Item("MEMBERTYPECODE"))
                Filewrite.Write("{0,-35}", "|" & addlist.Rows(row).Item("TYPEDESC"))
                Filewrite.WriteLine("{0,10}", addlist.Rows(row).Item("VALUE"))
                Total = Total + addlist.Rows(row).Item("VALUE")
            Next
            Filewrite.WriteLine(StrDup(70, "-"))
            Filewrite.WriteLine("{0,-49}{1,10}", "Total Live Member", Total)
            Filewrite.WriteLine(StrDup(70, "-"))
            Total = 0
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox("Data not found..!")
            Exit Sub
        End Try
    End Sub

    Private Sub rdb_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_date.CheckedChanged
        Try
            If rdb_date.Checked = True Then
                Dtp_From.Visible = True
                Dtp_To.Visible = True
            Else
                Dtp_From.Visible = False
                Dtp_To.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub Summary1()
        Try
            Dim SQL As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_MemberStatusSummary
            SQL = "SELECT * FROM VW_MEMBERSTATUS_SUMMARY"


            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'If chk_Filter_Field.

            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems

                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gUsername)

            SQL = SQL & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"

            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                'SQL = SQL & " and DOJ between '" & Dtp_From.Text & "' and '" & Dtp_To.Text & "'"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
            End If

            SQL = SQL & " ORDER BY membertypecode asc"
            Viewer.ssql = SQL
            Viewer.Report = r
            Viewer.TableName = "VW_MEMBERSTATUS_SUMMARY"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Member_Status_Report1()
        Try
            Dim SQL As String

            Dim Viewer As New ReportViwer
            Dim r As New Cry_MemberStatusHistory
            SQL = "SELECT * FROM MM_Memberledger"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            ' SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and NEWATATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                'SQL = SQL & " where mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            Else
                'MessageBox.Show("SELECT FROM AND TO MCODE NUMBER !")
            End If
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " where effectivefrom between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gUsername)
            'SQL = SQL & "GROUP BY mcode,mname,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADDDATE,membertypecode,type,curentstatus HAVING count(*) > 1"
            Viewer.ssql = SQL
            Viewer.Report = r
            'Viewer.TableName = "VW_MEMBERSTATUS_HISTORY"
            Viewer.TableName = "MM_Memberledger"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Chk_sumry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_sumry.CheckedChanged
        If (Chk_sumry.Checked = True) Then
            chk_member_status_det.Checked = False
            Chk_History.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
        End If
    End Sub

    Private Sub Chk_History_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_History.CheckedChanged
        If (Chk_History.Checked = True) Then
            Label5.Text = "Effective From"
            chk_member_status_det.Checked = False
            Chk_sumry.Checked = False
            Chk_details.Checked = False
            Label7.Visible = True
            tbx_Filter_From.Visible = True
            tbx_filter_To.Visible = True
            cmd_MCodefromHelp.Visible = True
            cmd_MCodeToHelp.Visible = True
            Chk_Dojwisediff.Checked = False

            'rdb_all.Visible = True
            'rdb_date.Visible = True
            'Dtp_From.Visible = True
            'Dtp_To.Visible = True
        End If
    End Sub

    Private Sub Dtp_To_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_To.ValueChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Dtp_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_From.ValueChanged

    End Sub

    Private Sub rdb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_all.CheckedChanged

    End Sub

    Private Sub ChK_Memberstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChK_Memberstatus.SelectedIndexChanged

    End Sub
    Public Sub Member_Status_Report2()
        Try
            Dim SQL As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_memberhistoryreport
            SQL = "SELECT * FROM MM_MEMBERMASTER"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            If (txtCategory.Text <> "") Then
                SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            Else
                'MessageBox.Show("SELECT FROM AND TO MCODE NUMBER !")
            End If
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " and doj between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)
            'SQL = SQL & "GROUP BY mcode,mname,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADDDATE,membertypecode,type,curentstatus HAVING count(*) > 1"
            Viewer.ssql = SQL
            Viewer.Report = r
            Viewer.TableName = "MM_MEMBERMASTER"
            'Viewer.TableName = "MM_Memberledger"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Chk_details_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_details.CheckedChanged
        Label5.Text = "Date of Join From"
        chk_member_status_det.Checked = False
        Chk_History.Checked = False
        Chk_sumry.Checked = False
        Chk_Dojwisediff.Checked = False
    End Sub
    Public Sub Member_Status_Details()
        Try
            Dim SQL As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Member_Status_Det
            SQL = "SELECT * FROM MM_MEMBERMASTER"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            If (txtCategory.Text <> "") Then
                SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            Else
                'MessageBox.Show("SELECT FROM AND TO MCODE NUMBER !")
            End If

            SQL = SQL & " order by mcode Asc"

            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = SQL
            Viewer.Report = r
            Viewer.TableName = "MM_MEMBERMASTER"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Member_Dateofjoin_Status()
        Try
            Dim SQL As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_DojwiseList
            SQL = "SELECT * FROM MM_VIEW_DATEOFJOIN"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            If (txtCategory.Text <> "") Then
                SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            Else

            End If

            SQL = SQL & " order by mcode Asc"
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = SQL
            Viewer.Report = r
            Viewer.TableName = "MM_VIEW_DATEOFJOIN"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chk_member_status_det_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_member_status_det.CheckedChanged
        Chk_sumry.Checked = False
        Chk_details.Checked = False
        Chk_History.Checked = False
        Chk_Dojwisediff.Checked = False
    End Sub

    Private Sub chk_member_status_det_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_member_status_det.Click
    End Sub

    Private Sub Chk_details_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_details.Click
        Chk_Dojwisediff.Checked = False
    End Sub
End Class