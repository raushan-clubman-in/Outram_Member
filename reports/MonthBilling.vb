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
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class MonthBilling
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, sqlstring2, sqlstring3, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5, ssql6, bildt, duedt As String
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim posting, posting1, dt As New DataTable
    Dim GCONN As New GlobalClass
    Dim MNTH2 As Object

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
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Rnd_Summary As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Details As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitWise As System.Windows.Forms.TextBox
    Friend WithEvents chk_PrintAllUnitWise As System.Windows.Forms.CheckBox
    Friend WithEvents chk_UnitWise As System.Windows.Forms.CheckedListBox
    Friend WithEvents Gbx_summardet As System.Windows.Forms.GroupBox
    Friend WithEvents RDOCOMBINEDYES As System.Windows.Forms.RadioButton
    Friend WithEvents RDOCOMBINEDNO As System.Windows.Forms.RadioButton
    Friend WithEvents LBL_COMBINED As System.Windows.Forms.Label
    Friend WithEvents Rnd_summardet As System.Windows.Forms.RadioButton
    Friend WithEvents PIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents RND_billforward As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Posdetails As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_subscription As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Excel As System.Windows.Forms.Button
    Friend WithEvents Rnd_Xml As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Billutil As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_msg As System.Windows.Forms.TextBox
    Friend WithEvents Grp_sms As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmd_sms As System.Windows.Forms.Button
    Friend WithEvents cmd_ver As System.Windows.Forms.Button
    Friend WithEvents ssgrid_sms As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Txt_msg1 As System.Windows.Forms.TextBox
    Friend WithEvents rdb_plain As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_mem As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MonthBilling))
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.txt_Tomcode = New System.Windows.Forms.TextBox
        Me.txt_Tomname = New System.Windows.Forms.TextBox
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.DTPduedate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Rnd_Summary = New System.Windows.Forms.RadioButton
        Me.Rnd_Details = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmd_ver = New System.Windows.Forms.Button
        Me.Btn_Excel = New System.Windows.Forms.Button
        Me.txt_note = New System.Windows.Forms.TextBox
        Me.txtUnitWise = New System.Windows.Forms.TextBox
        Me.chk_PrintAllUnitWise = New System.Windows.Forms.CheckBox
        Me.chk_UnitWise = New System.Windows.Forms.CheckedListBox
        Me.Gbx_summardet = New System.Windows.Forms.GroupBox
        Me.Rnd_Xml = New System.Windows.Forms.RadioButton
        Me.Rnd_Posdetails = New System.Windows.Forms.RadioButton
        Me.Rnd_subscription = New System.Windows.Forms.RadioButton
        Me.RDOCOMBINEDYES = New System.Windows.Forms.RadioButton
        Me.RDOCOMBINEDNO = New System.Windows.Forms.RadioButton
        Me.LBL_COMBINED = New System.Windows.Forms.Label
        Me.Rnd_summardet = New System.Windows.Forms.RadioButton
        Me.RND_billforward = New System.Windows.Forms.RadioButton
        Me.Rnd_Billutil = New System.Windows.Forms.RadioButton
        Me.PIC1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_msg = New System.Windows.Forms.TextBox
        Me.Grp_sms = New System.Windows.Forms.GroupBox
        Me.rdb_mem = New System.Windows.Forms.RadioButton
        Me.rdb_plain = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_msg1 = New System.Windows.Forms.TextBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmd_sms = New System.Windows.Forms.Button
        Me.ssgrid_sms = New AxFPUSpreadADO.AxfpSpread
        Me.GroupBox4.SuspendLayout()
        Me.Gbx_summardet.SuspendLayout()
        Me.Grp_sms.SuspendLayout()
        CType(Me.ssgrid_sms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.Location = New System.Drawing.Point(184, 16)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 12
        Me.cmd_view.Text = "VIEW [F9]"
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Image = CType(resources.GetObject("Btn_close.Image"), System.Drawing.Image)
        Me.Btn_close.Location = New System.Drawing.Point(296, 16)
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
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(72, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(400, 280)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(120, 24)
        Me.txt_Tomcode.TabIndex = 606
        Me.txt_Tomcode.Text = ""
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(400, 312)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(224, 24)
        Me.txt_Tomname.TabIndex = 608
        Me.txt_Tomname.Text = ""
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(184, 280)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(120, 24)
        Me.txt_mcode.TabIndex = 603
        Me.txt_mcode.Text = ""
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp1.Image = CType(resources.GetObject("cmd_MemberCodeHelp1.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(520, 280)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp1.TabIndex = 607
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(184, 312)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(208, 24)
        Me.txt_mname.TabIndex = 605
        Me.txt_mname.Text = ""
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(304, 280)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 604
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(96, 104)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(264, 24)
        Me.chk_PrintAll.TabIndex = 610
        Me.chk_PrintAll.Text = "Select All Categorys"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 611
        Me.Label3.Text = "MCODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 612
        Me.Label1.Text = "MNAME"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(96, 128)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(368, 137)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 609
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 16)
        Me.Label10.TabIndex = 602
        Me.Label10.Text = "MEMBER BILL FOR THE MONTH OF : "
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(328, 72)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 24)
        Me.CbxMonth.TabIndex = 601
        '
        'DTPduedate
        '
        Me.DTPduedate.CustomFormat = "dd/MM/yyyy"
        Me.DTPduedate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPduedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPduedate.Location = New System.Drawing.Point(184, 344)
        Me.DTPduedate.Name = "DTPduedate"
        Me.DTPduedate.Size = New System.Drawing.Size(144, 24)
        Me.DTPduedate.TabIndex = 626
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "DUE DATE"
        '
        'Rnd_Summary
        '
        Me.Rnd_Summary.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Summary.Checked = True
        Me.Rnd_Summary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Summary.Location = New System.Drawing.Point(280, 8)
        Me.Rnd_Summary.Name = "Rnd_Summary"
        Me.Rnd_Summary.TabIndex = 628
        Me.Rnd_Summary.TabStop = True
        Me.Rnd_Summary.Text = "Bill"
        Me.Rnd_Summary.Visible = False
        '
        'Rnd_Details
        '
        Me.Rnd_Details.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Details.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Details.Location = New System.Drawing.Point(280, 35)
        Me.Rnd_Details.Name = "Rnd_Details"
        Me.Rnd_Details.Size = New System.Drawing.Size(104, 16)
        Me.Rnd_Details.TabIndex = 627
        Me.Rnd_Details.Text = "Bill Annexure"
        Me.Rnd_Details.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_ver)
        Me.GroupBox4.Controls.Add(Me.cmd_Clear)
        Me.GroupBox4.Controls.Add(Me.cmd_view)
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Location = New System.Drawing.Point(96, 536)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(584, 64)
        Me.GroupBox4.TabIndex = 629
        Me.GroupBox4.TabStop = False
        '
        'cmd_ver
        '
        Me.cmd_ver.BackgroundImage = CType(resources.GetObject("cmd_ver.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ver.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ver.ForeColor = System.Drawing.Color.White
        Me.cmd_ver.Location = New System.Drawing.Point(408, 16)
        Me.cmd_ver.Name = "cmd_ver"
        Me.cmd_ver.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ver.TabIndex = 640
        Me.cmd_ver.Text = "SMS[F5]"
        '
        'Btn_Excel
        '
        Me.Btn_Excel.BackgroundImage = CType(resources.GetObject("Btn_Excel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Excel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.ForeColor = System.Drawing.Color.White
        Me.Btn_Excel.Location = New System.Drawing.Point(-24, 560)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Excel.TabIndex = 639
        Me.Btn_Excel.Text = "Excel[F12]"
        Me.Btn_Excel.Visible = False
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(648, 512)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(16, 32)
        Me.txt_note.TabIndex = 630
        Me.txt_note.Text = ""
        Me.txt_note.Visible = False
        '
        'txtUnitWise
        '
        Me.txtUnitWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitWise.Location = New System.Drawing.Point(856, 312)
        Me.txtUnitWise.Name = "txtUnitWise"
        Me.txtUnitWise.Size = New System.Drawing.Size(8, 21)
        Me.txtUnitWise.TabIndex = 636
        Me.txtUnitWise.Text = ""
        Me.txtUnitWise.Visible = False
        '
        'chk_PrintAllUnitWise
        '
        Me.chk_PrintAllUnitWise.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAllUnitWise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAllUnitWise.Location = New System.Drawing.Point(816, 104)
        Me.chk_PrintAllUnitWise.Name = "chk_PrintAllUnitWise"
        Me.chk_PrintAllUnitWise.Size = New System.Drawing.Size(8, 16)
        Me.chk_PrintAllUnitWise.TabIndex = 635
        Me.chk_PrintAllUnitWise.Text = "Print All Unit Wise"
        Me.chk_PrintAllUnitWise.Visible = False
        '
        'chk_UnitWise
        '
        Me.chk_UnitWise.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_UnitWise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_UnitWise.Location = New System.Drawing.Point(864, 128)
        Me.chk_UnitWise.Name = "chk_UnitWise"
        Me.chk_UnitWise.Size = New System.Drawing.Size(8, 194)
        Me.chk_UnitWise.Sorted = True
        Me.chk_UnitWise.TabIndex = 634
        Me.chk_UnitWise.Visible = False
        '
        'Gbx_summardet
        '
        Me.Gbx_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Xml)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Posdetails)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_subscription)
        Me.Gbx_summardet.Controls.Add(Me.RDOCOMBINEDYES)
        Me.Gbx_summardet.Controls.Add(Me.RDOCOMBINEDNO)
        Me.Gbx_summardet.Controls.Add(Me.LBL_COMBINED)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Summary)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Details)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_summardet)
        Me.Gbx_summardet.Controls.Add(Me.RND_billforward)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Billutil)
        Me.Gbx_summardet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_summardet.Location = New System.Drawing.Point(96, 440)
        Me.Gbx_summardet.Name = "Gbx_summardet"
        Me.Gbx_summardet.Size = New System.Drawing.Size(584, 96)
        Me.Gbx_summardet.TabIndex = 637
        Me.Gbx_summardet.TabStop = False
        Me.Gbx_summardet.Text = "PRINT DETAILS"
        '
        'Rnd_Xml
        '
        Me.Rnd_Xml.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Xml.Checked = True
        Me.Rnd_Xml.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Xml.Location = New System.Drawing.Point(416, 8)
        Me.Rnd_Xml.Name = "Rnd_Xml"
        Me.Rnd_Xml.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_Xml.TabIndex = 655
        Me.Rnd_Xml.TabStop = True
        Me.Rnd_Xml.Text = "Xml"
        '
        'Rnd_Posdetails
        '
        Me.Rnd_Posdetails.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Posdetails.Checked = True
        Me.Rnd_Posdetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Posdetails.Location = New System.Drawing.Point(448, 72)
        Me.Rnd_Posdetails.Name = "Rnd_Posdetails"
        Me.Rnd_Posdetails.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_Posdetails.TabIndex = 654
        Me.Rnd_Posdetails.TabStop = True
        Me.Rnd_Posdetails.Text = "POS"
        Me.Rnd_Posdetails.Visible = False
        '
        'Rnd_subscription
        '
        Me.Rnd_subscription.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_subscription.Checked = True
        Me.Rnd_subscription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_subscription.Location = New System.Drawing.Point(416, 8)
        Me.Rnd_subscription.Name = "Rnd_subscription"
        Me.Rnd_subscription.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_subscription.TabIndex = 653
        Me.Rnd_subscription.TabStop = True
        Me.Rnd_subscription.Text = "SUBSSCRIPTION"
        Me.Rnd_subscription.Visible = False
        '
        'RDOCOMBINEDYES
        '
        Me.RDOCOMBINEDYES.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDYES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOCOMBINEDYES.Location = New System.Drawing.Point(152, 29)
        Me.RDOCOMBINEDYES.Name = "RDOCOMBINEDYES"
        Me.RDOCOMBINEDYES.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDYES.TabIndex = 629
        Me.RDOCOMBINEDYES.Text = "YES"
        Me.RDOCOMBINEDYES.Visible = False
        '
        'RDOCOMBINEDNO
        '
        Me.RDOCOMBINEDNO.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOCOMBINEDNO.Location = New System.Drawing.Point(208, 29)
        Me.RDOCOMBINEDNO.Name = "RDOCOMBINEDNO"
        Me.RDOCOMBINEDNO.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDNO.TabIndex = 630
        Me.RDOCOMBINEDNO.Text = "NO"
        Me.RDOCOMBINEDNO.Visible = False
        '
        'LBL_COMBINED
        '
        Me.LBL_COMBINED.AutoSize = True
        Me.LBL_COMBINED.BackColor = System.Drawing.Color.Transparent
        Me.LBL_COMBINED.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_COMBINED.Location = New System.Drawing.Point(16, 32)
        Me.LBL_COMBINED.Name = "LBL_COMBINED"
        Me.LBL_COMBINED.Size = New System.Drawing.Size(122, 18)
        Me.LBL_COMBINED.TabIndex = 631
        Me.LBL_COMBINED.Text = "COMBINED PRINT"
        Me.LBL_COMBINED.Visible = False
        '
        'Rnd_summardet
        '
        Me.Rnd_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_summardet.Checked = True
        Me.Rnd_summardet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_summardet.Location = New System.Drawing.Point(280, 32)
        Me.Rnd_summardet.Name = "Rnd_summardet"
        Me.Rnd_summardet.Size = New System.Drawing.Size(96, 24)
        Me.Rnd_summardet.TabIndex = 632
        Me.Rnd_summardet.TabStop = True
        Me.Rnd_summardet.Text = "Bill/Annexure"
        Me.Rnd_summardet.Visible = False
        '
        'RND_billforward
        '
        Me.RND_billforward.BackColor = System.Drawing.Color.Transparent
        Me.RND_billforward.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RND_billforward.Location = New System.Drawing.Point(280, 64)
        Me.RND_billforward.Name = "RND_billforward"
        Me.RND_billforward.Size = New System.Drawing.Size(256, 24)
        Me.RND_billforward.TabIndex = 643
        Me.RND_billforward.Text = "Summary Details"
        '
        'Rnd_Billutil
        '
        Me.Rnd_Billutil.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Billutil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Billutil.Location = New System.Drawing.Point(416, 40)
        Me.Rnd_Billutil.Name = "Rnd_Billutil"
        Me.Rnd_Billutil.Size = New System.Drawing.Size(136, 16)
        Me.Rnd_Billutil.TabIndex = 644
        Me.Rnd_Billutil.Text = "BILL+UTILISATION"
        Me.Rnd_Billutil.Visible = False
        '
        'PIC1
        '
        Me.PIC1.Location = New System.Drawing.Point(528, 72)
        Me.PIC1.Name = "PIC1"
        Me.PIC1.Size = New System.Drawing.Size(112, 104)
        Me.PIC1.TabIndex = 638
        Me.PIC1.TabStop = False
        Me.PIC1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 639
        Me.Label2.Text = "REMARKS"
        '
        'txt_msg
        '
        Me.txt_msg.Location = New System.Drawing.Point(184, 384)
        Me.txt_msg.Multiline = True
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(424, 48)
        Me.txt_msg.TabIndex = 640
        Me.txt_msg.Text = ""
        '
        'Grp_sms
        '
        Me.Grp_sms.BackColor = System.Drawing.Color.LightSlateGray
        Me.Grp_sms.Controls.Add(Me.rdb_mem)
        Me.Grp_sms.Controls.Add(Me.rdb_plain)
        Me.Grp_sms.Controls.Add(Me.Label6)
        Me.Grp_sms.Controls.Add(Me.Label4)
        Me.Grp_sms.Controls.Add(Me.Txt_msg1)
        Me.Grp_sms.Controls.Add(Me.cmdexit)
        Me.Grp_sms.Controls.Add(Me.cmdclear)
        Me.Grp_sms.Controls.Add(Me.cmd_sms)
        Me.Grp_sms.Controls.Add(Me.ssgrid_sms)
        Me.Grp_sms.Location = New System.Drawing.Point(24, 56)
        Me.Grp_sms.Name = "Grp_sms"
        Me.Grp_sms.Size = New System.Drawing.Size(680, 480)
        Me.Grp_sms.TabIndex = 641
        Me.Grp_sms.TabStop = False
        Me.Grp_sms.Visible = False
        '
        'rdb_mem
        '
        Me.rdb_mem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_mem.Location = New System.Drawing.Point(328, 288)
        Me.rdb_mem.Name = "rdb_mem"
        Me.rdb_mem.Size = New System.Drawing.Size(128, 32)
        Me.rdb_mem.TabIndex = 644
        Me.rdb_mem.Text = "Member Outstanding"
        '
        'rdb_plain
        '
        Me.rdb_plain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_plain.Location = New System.Drawing.Point(168, 296)
        Me.rdb_plain.Name = "rdb_plain"
        Me.rdb_plain.TabIndex = 643
        Me.rdb_plain.Text = "Plain Text"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 642
        Me.Label6.Text = "General Text"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 641
        Me.Label4.Text = "Message Format"
        '
        'Txt_msg1
        '
        Me.Txt_msg1.Location = New System.Drawing.Point(176, 344)
        Me.Txt_msg1.Multiline = True
        Me.Txt_msg1.Name = "Txt_msg1"
        Me.Txt_msg1.Size = New System.Drawing.Size(440, 64)
        Me.Txt_msg1.TabIndex = 640
        Me.Txt_msg1.Text = ""
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(448, 424)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 639
        Me.cmdexit.Text = "Exit"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdclear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.White
        Me.cmdclear.Image = CType(resources.GetObject("cmdclear.Image"), System.Drawing.Image)
        Me.cmdclear.Location = New System.Drawing.Point(312, 424)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(104, 32)
        Me.cmdclear.TabIndex = 638
        Me.cmdclear.Text = "Clear"
        '
        'cmd_sms
        '
        Me.cmd_sms.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_sms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_sms.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_sms.ForeColor = System.Drawing.Color.White
        Me.cmd_sms.Image = CType(resources.GetObject("cmd_sms.Image"), System.Drawing.Image)
        Me.cmd_sms.Location = New System.Drawing.Point(176, 424)
        Me.cmd_sms.Name = "cmd_sms"
        Me.cmd_sms.Size = New System.Drawing.Size(104, 32)
        Me.cmd_sms.TabIndex = 637
        Me.cmd_sms.Text = "SEND SMS"
        '
        'ssgrid_sms
        '
        Me.ssgrid_sms.ContainingControl = Me
        Me.ssgrid_sms.DataSource = Nothing
        Me.ssgrid_sms.Location = New System.Drawing.Point(48, 24)
        Me.ssgrid_sms.Name = "ssgrid_sms"
        Me.ssgrid_sms.OcxState = CType(resources.GetObject("ssgrid_sms.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_sms.Size = New System.Drawing.Size(600, 248)
        Me.ssgrid_sms.TabIndex = 636
        '
        'MonthBilling
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 614)
        Me.Controls.Add(Me.Grp_sms)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnitWise)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Tomcode)
        Me.Controls.Add(Me.txt_Tomname)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PIC1)
        Me.Controls.Add(Me.chk_PrintAllUnitWise)
        Me.Controls.Add(Me.chk_UnitWise)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DTPduedate)
        Me.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Gbx_summardet)
        Me.Controls.Add(Me.Btn_Excel)
        Me.Name = "MonthBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonthBilling"
        Me.GroupBox4.ResumeLayout(False)
        Me.Gbx_summardet.ResumeLayout(False)
        Me.Grp_sms.ResumeLayout(False)
        CType(Me.ssgrid_sms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click


        If Rnd_Summary.Checked = True Then
            If gCompanyname = "HYDERABAD GOLF ASSOCIATION" Or gCompanyname = "HGA1112" Then
                Call GETSUMMARY_PRINT1()
            Else
                Call GETSUMMARY_PRINT_OTHERS()
            End If
        End If
        If Rnd_Billutil.Checked = True Then
            Call pdfgen()
            Exit Sub
        End If
        If RND_billforward.Checked = True Then
            If gCompanyname = "HYDERABAD GOLF ASSOCIATION" Or gCompanyname = "HGA1112" Then
                Call bill_Summary_details()
            Else
                Call bill_Summary_details()
            End If
        End If
        If Rnd_Details.Checked = True Then
            Call GETSUMMARY_PRINT()
        End If
        If Rnd_summardet.Checked = True Then
            Call GETSUMMARYANDDETAILS()
        End If
        If Rnd_Xml.Checked = True Then
            Call Xml()

        End If
    End Sub
    Private Sub pdfgen()
        Dim i As Integer
        Dim SSQL, TYPE(), HNAME, mcode, Years As String
        Dim posdesc(), groupcode(), itemcode(), sqlstring, membercode() As String
        Dim POSDESC2(), GROUPDESC2(), month2 As String
        Dim sqlstringCancel, VFilePathPdf, smsql As String
        Dim totalamt, totaltax, totalser, totaltips As Double
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "04"
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "05"
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "06"
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "07"
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "08"
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "09"
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "10"
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "11"
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : Years = Mid(gFinancialyearStart, 7, 4) : month2 = "12"
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : Years = Mid(gFinancialYearEnd, 7, 4) : month2 = "01"
        'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : Years = Mid(gFinancialYearEnd, 7, 4) : month2 = "02"
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
            MNTH2 = Year(gFinancialYearEnd) Mod 4
            month1 = 2
            If MNTH2 = 0 Then
                noofdays = 29
                bildt = "29-feb-" & Year(gFinancialYearEnd)
            Else
                noofdays = 28
                bildt = "28-feb-" & Year(gFinancialYearEnd)
            End If
            month2 = "02"
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : Years = Mid(gFinancialYearEnd, 7, 4) : month2 = "03"

        SSQL = "SELECT ITEMCODE,ITEMDESC,QTY AS QTY,AMOUNT AS AMOUNT,TAXAMOUNT,POSDesc,SER_CHG,PACKAMOUNT,KOTDETAILS,KOTDATE,RATE,mcode,"
        SSQL = SSQL & "MNAME,BILLAMOUNT AS BILLAMOUNT FROM VIEWKOTDETAILS "
        SSQL = SSQL & " WHERE MONTH(KOTDATE) = "
        SSQL = SSQL & " MONTH('" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "')"

        'If chklist_Type.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " and  ITEMDESC IN("
        '    For i = 0 To chklist_Type.CheckedItems.Count - 1
        '        TYPE = Split(chklist_Type.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "
        '        HNAME = HNAME & " " & Trim(TYPE(0))
        '        'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"

        '    'If chklist_Type.CheckedItems.Count <> 0 Then
        '    '    SSQL = SSQL & " and  TAXCODE IN("
        '    '    For i = 0 To chklist_Type.CheckedItems.Count - 1
        '    '        TYPE = Split(chklist_Type.CheckedItems(i), "-->")
        '    '        SSQL = SSQL & " '" & TYPE(1) & "', "
        '    '        HNAME = HNAME & " " & Trim(TYPE(0))
        '    '        'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
        '    '    Next
        '    '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    '    SSQL = SSQL & ")"
        'End If



        'If LstGroup.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND GROUPCODE IN ("
        '    For i = 0 To LstGroup.CheckedItems.Count - 1
        '        TYPE = Split(LstGroup.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        'If lstcategory.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " and CATEGORY in ("
        '    For i = 0 To lstcategory.CheckedItems.Count - 1
        '        SSQL = SSQL & " '" & lstcategory.CheckedItems(i) & "', "
        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        'If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND POSCODE IN ("
        '    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '        TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        ''====

        'If CheckedListBox1.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND SCODE IN ("
        '    For i = 0 To CheckedListBox1.CheckedItems.Count - 1
        '        TYPE = Split(CheckedListBox1.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"

        'End If

        ''========

        If Trim(txt_mcode.Text) <> "" Then
            'SSQL = SSQL & " AND MCODE ='" & Trim(txt_mcode.Text) & "'"
            SSQL = SSQL & " AND MCODE BETWEEN '" & Trim(txt_mcode.Text) & "' AND '" & Trim(txt_Tomcode.Text) & "' "
        Else
            MsgBox("PLEASE PROVIDE MEMBERCODE")
            Exit Sub
        End If



        SSQL = SSQL & " AND PAYMENTMODE IN ('CREDIT')"



        'SSQL = SSQL & " order by mcode"
        ''''  If chklist_Membername.CheckedItems.Count <> 0 Then
        ''''SSQL = SSQL & " AND mcode IN ("
        '''' For i = 0 To chklist_Membername.CheckedItems.Count - 1
        ''''   SSQL = SSQL & " '" & chklist_Membername.CheckedItems(i) & "', "
        ''SSQL = SSQL & " '" & TYPE(1) & "', "

        ''''  Next
        ''''   SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        ''''   SSQL = SSQL & ") order by mcode"
        ''''   Else
        ''''   MsgBox("Select the MCODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        ''''   Exit Sub
        ''''   End If



        'If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
        '    SSQL = SSQL & " AND MCODE between '" & Trim(txt_mcode.Text) & "' and '" & Trim(txt_Tomcode.Text) & "'"
        'Else
        '    If chklist_Membername.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND MCODE IN ("
        '        For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '            membercode = Split(chklist_Membername.CheckedItems(i), "-->")
        '            SSQL = SSQL & "'" & membercode(0) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ") "


        '    End If

        'End If
        SSQL = SSQL & "order by MCODE,kotdate,kotdetails"
        gconnection.getDataSet(SSQL, "RAN")
        totalamt = 0
        totaltax = 0
        Dim doc As New Document
        Dim SNO As Integer
        Dim BFTIMES As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim TIMES As New Font(BFTIMES, 9, Font.Italic, Color.BLACK)
        Dim BFTIMES1 As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim TIMES1 As New Font(BFTIMES, 14, Font.Italic, Color.BLACK)
        Dim TIMES2 As New Font(BFTIMES, 10, Font.Italic, Color.BLACK)
        Dim pdt As New PdfPTable(9)
        Dim col As New PdfPCell
        SNO = 1
        If gdataset.Tables("RAN").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("RAN").Rows.Count - 1
                If mcode <> Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) Then

                    If SNO <> 1 Then

                        'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        'doc.Add(col)
                        col = New PdfPCell(New Phrase("", TIMES))

                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                        col = New PdfPCell(New Phrase("TOTAL", TIMES1))
                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totalamt), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totaltax), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totalser), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totaltips), "0.00"), 1, 10).ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                        col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt + totalser + totaltips), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                        col = New PdfPCell(New Phrase(Format(Val(totaltax), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                        col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        doc.Add(pdt)
                        'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        'smsql = "         TOTAL                                            " & Format(totalamt, "0.00") & Space(2) & Format(totaltax, "0.00") & Space(2) & Format(totalamt + totaltax, "0.00")
                        'doc.Add(New Paragraph(smsql))
                        'smsql = "-------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        doc.Close()
                        totalamt = 0
                        totaltax = 0
                        totalser = 0
                        totaltips = 0
                    End If

                    doc = New Document
                    VFilePathPdf = AppPath & "\REPORTS\" & Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) & "@" & Years & "@" & month2 & ".pdf"
                    If File.Exists(VFilePathPdf) Then
                        File.Delete(VFilePathPdf)
                    End If
                    PdfWriter.GetInstance(doc, New FileStream(VFilePathPdf, FileMode.OpenOrCreate))
                    doc.Open()
                    SNO = 1
                    smsql = "MEMBER POS CONSUMPTION DETAILS "
                    doc.Add(New Paragraph(smsql, TIMES1))
                    smsql = "PERIOD FOR THE MONTH OF  " & MonthName(Month(Format(CbxMonth.Value, "dd/MMM/yyyy")), False) & "," & Year(Format(CbxMonth.Value, "dd/MMM/yyyy"))
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = gCompanyname
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = gCompanyAddress(0) & "," & gCompanyAddress(1) & "," & gCompanyAddress(2)
                    doc.Add(New Paragraph(smsql, TIMES))

                    smsql = "MEMBER DETAILS FOR :-" & Trim(gdataset.Tables("RAN").Rows(i).Item("MNAME")) & "[" & Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) & "]"
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = "RUN DATE :" & Format(Now, "dd-MMM-yyyy HH:mm")
                    doc.Add(New Paragraph(smsql, TIMES))
                    smsql = "--"
                    doc.Add(New Paragraph(smsql, TIMES))
                    'Dim col As New MultiColumnText
                    'col.AddSimpleColumn(10.0F, 15.0F)
                    'col.AddSimpleColumn(16.0F, 27.0F)
                    'col.AddSimpleColumn(28.0F, 42.0F)
                    'col.AddSimpleColumn(43.0F, 60.0F)
                    'col.AddSimpleColumn(61.0F, 81.0F)
                    'col.AddSimpleColumn(82.0F, 87.0F)
                    'col.AddSimpleColumn(88.0F, 98.0F)
                    'col.AddSimpleColumn(99.0F, 109.0F)
                    'col.AddSimpleColumn(110.0F, 120.0F)
                    pdt = New PdfPTable(10)
                    pdt.TotalWidth = 580.0F
                    doc.Add(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                    'col = New PdfPCell(New Phrase(smsql, TIMES))
                    'col.Border = 0
                    'col.Width = 600.0F
                    'pdt.AddCell(col)
                    pdt.LockedWidth = True
                    col = New PdfPCell(New Phrase("SNO  ", TIMES))
                    'col.Border = 0
                    'col.Width = 3.0F
                    pdt.AddCell(col)

                    col = New PdfPCell(New Phrase("KOT DATE     ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("LOCATION       ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("KOTDETAILS        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("ITEMDESC             ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("AMOUNT     ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("VAT        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("S.TAX        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("TIPS        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("TOTAL      ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                    'doc.Add(New Paragraph(smsql))
                    'smsql = "SNo   KOT DATE     LOCATION       KOTDETAILS        ITEMDESC             QTY   RATE       AMOUNT     TAX        TOTAMT       "
                    'doc.Add(New Paragraph(smsql, TIMES))

                    'Dim para As New Paragraph(smsql, TIMES)
                    'col.AddElement(para)
                    'doc.Add(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------"
                    'doc.Add(New Paragraph(smsql))
                    'smsql = Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5) & Space(1)
                    col = New PdfPCell(New Phrase(Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd-MMM-yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd-MMM-yyyy"), 1, 11))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT") + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))
                    ' col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    ' doc.Add(New Paragraph(smsql, TIMES))
                    totalamt = totalamt + gdataset.Tables("RAN").Rows(i).Item("AMOUNT")
                    totaltax = totaltax + gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT")
                    totalser = totalser + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT")
                    totaltips = totaltips + gdataset.Tables("RAN").Rows(i).Item("SER_CHG")
                Else
                    'smsql = Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)
                    ''& Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    'smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)

                    'smsql = smsql & Space(1) & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("RATE"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("RATE"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    'doc.Add(New Paragraph(smsql, TIMES))
                    col = New PdfPCell(New Phrase(Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))), TIMES))
                    ' col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))

                    'col.HorizontalAlignment = 2
                    'pdt.AddCell(col)
                    'col.Border = 0
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT") + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))
                    ' col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    ' doc.Add(New Paragraph(smsql, TIMES))
                    totalamt = totalamt + gdataset.Tables("RAN").Rows(i).Item("AMOUNT")
                    totaltax = totaltax + gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT")
                    totalser = totalser + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT")
                    totaltips = totaltips + gdataset.Tables("RAN").Rows(i).Item("SER_CHG")
                End If
                SNO = SNO + 1
                mcode = Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE"))
            Next
            col = New PdfPCell(New Phrase("", TIMES))

            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
            col = New PdfPCell(New Phrase("TOTAL", TIMES1))
            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totalamt), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totaltax), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totalser), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totaltips), "0.00"), 1, 10).ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
            col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt + totalser + totaltips), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
            col = New PdfPCell(New Phrase(Format(Val(totaltax), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
            col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'doc.Add(pdt)
            'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
            'doc.Add(New Paragraph(smsql))
            'smsql = "         TOTAL                                            " & Format(totalamt, "0.00") & Space(2) & Format(totaltax, "0.00") & Space(2) & Format(totalamt + totaltax, "0.00")
            'doc.Add(New Paragraph(smsql))
            'smsql = "-------------------------------------------------------------------------------------------------------------------"
            'doc.Add(New Paragraph(smsql))
            'doc.Close()
            totalamt = 0
            totaltax = 0
            totalser = 0
            totaltips = 0
            doc.Add(pdt)
            doc.Close()
            If Dir(VFilePathPdf) <> "" Then
                System.Diagnostics.Process.Start(VFilePathPdf)
            Else
                MsgBox(VFilePathPdf & "  File not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If


        'doc.AddHeader()
        'Dim r1 As New VatItemWiseBillwise

        'Dim Viewer As New ReportViwer

        'Dim TXTOBJ3 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ3 = r1.ReportDefinition.ReportObjects("Text13")
        'TXTOBJ3.Text = " From  " & Format(mskFromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskTodate.Value, "dd/MM/yyyy") & ""


        'Dim TXTOBJ4 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ4 = r1.ReportDefinition.ReportObjects("Text15")
        'TXTOBJ4.Text = HNAME

        'Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ5 = r1.ReportDefinition.ReportObjects("Text14")
        'TXTOBJ5.Text = gCompanyname

        'Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ1 = r1.ReportDefinition.ReportObjects("Text2")
        'TXTOBJ1.Text = "UserName : " & gUsername



        'Viewer.ssql = SSQL
        'Viewer.Report = r1
        'Viewer.TableName = "VIEWITEMWISESALESUMMARY_TAXWISE"
        'Viewer.Show()




        'SSQL = SSQL & "GROUP BY ITEMCODE,ITEMDESC "
        'Dim heading() As String = {"SALES REGISTER [ITEM WISE]", "ALL"}
        'Dim objSaleregistersummary As New BILLWISE_TAX
        'objSaleregistersummary.Detailsection(SSQL, heading, HNAME, mskFromdate.Value, mskTodate.Value)
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        chk_PrintAll.Checked = False
        txt_mcode.Text = ""
        txt_Tomcode.Text = ""
        txt_mname.Text = ""
        txt_Tomname.Text = ""
        txt_note.Text = ""

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub

    Private Sub MonthBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grp_sms.Visible = False
        PIC1.Image = New Bitmap(AppPath & "\tnbsa logo.JPG")
        GCONN.SaveCLUBFoto(AppPath & "\tnbsa logo.JPG", "RSIFRONT")
        Dim SQLSTRING As String
        Dim I As Integer
        SQLSTRING = "SELECT clublogo FROM accountsSetUp "
        GCONN.getDataSet(SQLSTRING, "PHOTO")
        'If gdataset.Tables("PHOTO").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("PHOTO").Rows.Count - 1
        '        With SSGRID
        '            .Row = I + 1
        '            .Col = 1
        '            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MCODE")
        '            .Col = 2
        '            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MNAME")
        '            .MaxRows = .MaxRows + 1
        '        End With
        '    Next
        'End If

        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(SUBTYPECODE,'') as membertype,isnull(SUBtypedesc,'') as typedesc from SUBCATEGORYMASTER "
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        LoadUnitNO()
        chk_Filter_Field.Focus()
        RDOCOMBINEDNO.Checked = True
    End Sub
    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp1.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        Else
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        End If
        M_Groupby = ""
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Tomcode.Text = Trim(vform.keyfield & "")
            Call txt_Tomcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Validation()

        boolchk = True
    End Sub
    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "' AND MEMBERTYPECODE <> 'NM' ORDER BY MCODE "
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    txt_Tomcode.Focus()
                Else
                    txt_mcode.Text = ""
                    txt_mcode.Focus()
                End If
            Else
                'txt_mcode.Text = ""
                'txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        Else
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        End If
        M_Groupby = ""
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Tomcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Tomcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Tomcode.Text) = "" Then
                Call cmd_MemberCodeHelp1_Click(sender, e)
            Else
                txt_Tomcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_Tomcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tomcode.Validated
        Try
            If Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_Tomcode.Text) & "' AND MEMBERTYPECODE <> 'NM' ORDER BY MCODE"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_Tomcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_Tomname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    cmd_view.Focus()
                Else
                    txt_Tomcode.Text = ""
                    txt_Tomcode.Focus()
                End If
            Else
                'txt_Tomcode.Text = ""
                'txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
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

    Private Sub chk_UnitWise_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_UnitWise.SelectedIndexChanged

    End Sub
    Public Sub LoadUnitNO()
        sqlstring = "select unitname from tbl_unitmaster where freeze='N'"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            chk_UnitWise.Items.Add(dt.Rows(Itration).Item("unitname"))
        Next
    End Sub

    Private Sub chk_PrintAllUnitWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAllUnitWise.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAllUnitWise.Checked = True Then

            For Iteration = 0 To (chk_UnitWise.Items.Count - 1)
                chk_UnitWise.SetSelected(Iteration, True)
                chk_UnitWise.SetItemChecked(Iteration, True)
            Next

        Else

            For Iteration = 0 To (chk_UnitWise.Items.Count - 1)
                chk_UnitWise.SetSelected(Iteration, False)
                chk_UnitWise.SetItemChecked(Iteration, False)
            Next

        End If
    End Sub

    Private Sub txt_Tomcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tomcode.TextChanged

    End Sub


    Private Sub RDOCOMBINEDYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.CheckedChanged
        Rnd_Summary.Visible = False
        Rnd_Details.Visible = False
        Rnd_summardet.Visible = True
    End Sub

    Private Sub RDOCOMBINEDNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.CheckedChanged
        Rnd_Summary.Visible = True
        Rnd_Details.Visible = True
        Rnd_summardet.Visible = False
    End Sub

    Private Sub GETSUMMARY_PRINT()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
                MNTH2 = Year(gFinancialYearEnd) Mod 4
                month1 = 2
                If MNTH2 = 0 Then
                    noofdays = 29
                    bildt = "29-feb-" & Year(gFinancialYearEnd)
                Else
                    noofdays = 28
                    bildt = "28-feb-" & Year(gFinancialYearEnd)
                End If
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            Dim Viewer As New ReportViwer
            If Rnd_Details.Checked = True Then
                Dim r As New Cry_billdetails_new
                If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                    sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND MEMBERTYPECODE NOT IN ('NM') AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell ORDER BY M.MCODE "
                    ssql = " select SNO,BILLNO,DESCRIPTION,KOTDATE,MCODE,MNAME,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,POSCODE,UPPER(POSDESC) AS POSDESC "
                    ssql = ssql & " From VIEW_GNC_BILLDETAILS WHERE LTRIM(RTRIM(MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & month1 & " "
                    ssql = ssql & " group by SNO,BILLNO,KOTDATE,MCODE,MNAME,DESCRIPTION,POSCODE,UPPER(POSDESC) "
                    ssql = ssql & " ORDER BY SNO"
                    sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                    sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "

                Else
                    membertype = ""
                    If chk_Filter_Field.CheckedItems.Count > 0 Then
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                            membertype = membertype & "'" & TYPE(0) & "', "
                        Next
                        membertype = Mid(membertype, 1, Len(membertype) - 2)
                    Else
                        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") "
                    sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS IN ('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell ORDER BY M.MCODE"
                    ssql = " select A.SNO,A.BILLNO,A.DESCRIPTION,A.KOTDATE,A.MCODE,A.MNAME,SUM(A.DRAMOUNT) AS DRAMOUNT,SUM(A.CRAMOUNT) AS CRAMOUNT,A.POSCODE,UPPER(A.POSDESC) AS POSDESC From VIEW_GNC_BILLDETAILS  A, MEMBERMASTER B "
                    ssql = ssql & " WHERE Month(A.KOTDATE) = " & month1
                    ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.MCODE=B.MCODE   "
                    ssql = ssql & " group by SNO,BILLNO,KOTDATE,A.MCODE,A.MNAME,DESCRIPTION,POSCODE,UPPER(POSDESC) "
                    ssql = ssql & " ORDER BY A.SNO,A.KOTDATE "
                    sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                    sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "

                End If

                Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
                Call Viewer.GetDetails1(ssql, "VIEW_GNC_BILLDETAILS", r)
                Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
                Dim txtobj1 As TextObject
                Dim txtobj As TextObject
                Dim txtobj2 As TextObject
                Dim txtobj18 As TextObject
                Dim txtobj19 As TextObject
                Dim txtobj20 As TextObject
                txtobj19 = r.ReportDefinition.ReportObjects("Text19")
                txtobj18 = r.ReportDefinition.ReportObjects("Text18")
                txtobj20 = r.ReportDefinition.ReportObjects("Text15")
                txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                txtobj20.Text = " You are requested to pay the due amount on or before :" & Format(DTPduedate.Value, "dd/MM/yyyy")
                Viewer.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Xml()

        Dim XMLSTR, tempstr, tempstr1, tempstr2 As String
        Randomize()
        AppPath = Application.StartupPath
        Dim cmdText As String
        Dim I As Integer
        Dim dr, dr1, dr2, dr4 As DataRow
        Dim duedate, membertype, TYPE(0), month2 As String


        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "04" : month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "05" : month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "06" : month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "07" : month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "08" : month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "09" : month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "10" : month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "11" : month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "12" : month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "01" : month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "02" : month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
        'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
        '    MNTH2 = Year(gFinancialYearEnd) Mod 4
        '    month1 = 2
        '    If MNTH2 = 0 Then
        '        noofdays = 29
        '        bildt = "29-feb-" & Year(gFinancialYearEnd)
        '    Else
        '        noofdays = 28
        '        bildt = "28-feb-" & Year(gFinancialYearEnd)
        '    End If
        '    month2 = "02"
        'End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "03" : month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)

        VFilePath = AppPath & "\Reports\" & vOutfile & ".Xml"

        If File.Exists(VFilePath) = True Then
            File.Delete(VFilePath)
        End If

        'for new one

        membertype = ""

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
                TYPE = Split(chk_Filter_Field.CheckedItems(I), ".")
                membertype = membertype & "'" & TYPE(0) & "', "
            Next
            membertype = Mid(membertype, 1, Len(membertype) - 2)
        Else
            MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chk_Filter_Field.Focus()
            Exit Sub
        End If

        'If chk_UnitWise.CheckedItems.Count > 0 Then
        '    Dim j As Object
        '    For j = 0 To chk_UnitWise.CheckedItems.Count - 1
        '        unit = Split(chk_UnitWise.CheckedItems(j), "")
        '        unitno = unitno & "'" & unit(0) & "', "
        '    Next j
        '    unitno = Mid(unitno, 1, Len(unitno) - 2)
        'End If

        'If Chk_ranklist.CheckedItems.Count > 0 Then
        '    Dim j As Object
        '    For j = 0 To Chk_ranklist.CheckedItems.Count - 1
        '        unit = Split(Chk_ranklist.CheckedItems(j), "")
        '        ranklist = ranklist & "'" & unit(0) & "', "
        '    Next j
        '    ranklist = Mid(ranklist, 1, Len(ranklist) - 2)
        'End If

        If Trim(txt_mcode.Text) <> "" Then
            'left outer joIn memberbill mb on m.mcode=mb.mcode

            sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CADD1,'') AS CONTADD1,ISNULL(M.CADD2,'') AS CONTADD2,ISNULL(M.CADD3,'') AS CONTADD3,ISNULL(M.CCITY,'')+' '+ISNULL(M.CSTATE,'') AS CONTCITY,ISNULL(M.CPIN,'') AS CONTPIN,ISNULL(M.ccell,'') AS contcell,ISNULL(M.membertype,'') AS membertype, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O LEFT OUTER JOIN MEMBERMASTER M  ON M.MCODE = O.SLCODE WHERE M.MCODE = '" & txt_mcode.Text & "'  AND O.BILLDATE < '" & bildt & "' AND  M.CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CADD1,M.CADD2,M.CADD3,M.CCITY,M.CSTATE,M.CPIN,m.ccell,M.membertype,M.unitno ORDER BY M.MCODE "
            sqlstring1 = "select slcode as mcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,isnull(Instrumentno ,'')as instrumentno,ISNULL(InstrumentDate,'')as instrumentdate,ISNULL(InstrumentType,'')as instrumenttype,ISNULL(BankName,'')as bankname "
            sqlstring1 = sqlstring1 & " FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) = '" & txt_mcode.Text & "'  AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc,ISNULL(Instrumentno,''),ISNULL(InstrumentDate,''),ISNULL(InstrumentType,''),ISNULL(BankName,'') "
            ssql2 = " SELECT SLCODE as mcode,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE = '" & txt_mcode.Text & "'  GROUP BY SLCODE,HEADDESC "
            sqlstring2 = " select slcode as mcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
            sqlstring2 = sqlstring2 & " FROM View_drcr_Det WHERE LTRIM(RTRIM(SLCODE)) = '" & txt_mcode.Text & "'  AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "

        Else
            ssql = "drop table tmp_memberlist"
            gconnection.getDataSet(ssql, "MEMBER")
            'ssql = "select slcode into tmp_memberlist from [view_monthbillsummarydet]  group by slcode having SUM(prev_due)>0 or SUM(prev_due)<0 or SUM(billamount)>0 or sum(rcpt)>0 or sum(rcpt)<0"
            ssql = "select slcode into tmp_memberlist from [view_monthbillsummarydet]"
            gconnection.getDataSet(ssql, "MEMBER")

            ssql = ""

            'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CADD1,'') AS CONTADD1,ISNULL(M.CADD2,'') AS CONTADD2,ISNULL(M.CADD3,'') AS CONTADD3,ISNULL(M.CCITY,'')+' '+ISNULL(M.CSTATE,'') AS CONTCITY,ISNULL(M.CPIN,'') AS CONTPIN,ISNULL(M.membertype,'') AS membertype,ISNULL(M.unitno,'') AS unitno,ISNULL(M.ccell,'') AS contcell, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O LEFT OUTER JOIN MEMBERMASTER M ON SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  WHERE LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")"
            'If unitno <> "" Then
            '    sqlstring = sqlstring & " AND LTRIM(RTRIM(m.unitno)) IN(" & unitno & ") "
            'End If
            'If ranklist <> "" Then
            '    sqlstring = sqlstring & " AND LTRIM(RTRIM(m.rankname)) IN(" & ranklist & ") "
            'End If

            'sqlstring = sqlstring & " and m.mcode in (select slcode from tmp_memberlist)"

            'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  M.CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y'  GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CADD1,M.CADD2,M.CADD3,M.CCITY,M.CSTATE,M.CPIN,m.ccell,M.membertype,M.unitno ORDER BY M.MCODE"
            sqlstring = "SELECT ISNULL(S.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M,SUBSPOSTING S WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
            sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  M.CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' AND S.SUBSCODE IN ('MUC','OMU') AND M.MCODE=S.MCODE AND MONTH(S.BILLDATE)=" & month1 & " GROUP BY M.MCODE,S.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"

            ssql = " SELECT A.BILLNO,A.SLCODE AS MCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
            ssql = ssql & " WHERE Month(BILLDATE) = " & month1
            ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "

            'If unitno <> "" Then
            '    ssql = ssql & " AND LTRIM(RTRIM(m.unitno)) IN(" & unitno & ") "
            'End If
            'If ranklist <> "" Then
            '    ssql = ssql & " AND LTRIM(RTRIM(m.rankname)) IN(" & ranklist & ") "
            'End If

            ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO"

            sqlstring1 = " select a.SLCODE AS MCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,isnull(Instrumentno ,'')as instrumentno,ISNULL(InstrumentDate,'')as instrumentdate,ISNULL(InstrumentType,'')as instrumenttype,ISNULL(BankName,'')as bankname "
            sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  "
            'If unitno <> "" Then
            '    sqlstring1 = sqlstring1 & " AND LTRIM(RTRIM(b.unitno)) IN(" & unitno & ") "
            'End If
            'If ranklist <> "" Then
            '    sqlstring1 = sqlstring1 & " AND LTRIM(RTRIM(b.rankname)) IN(" & ranklist & ") "
            'End If

            sqlstring1 = sqlstring1 & "Group by  a.SLCODE,ISNULL(Instrumentno,''),ISNULL(InstrumentDate,''),ISNULL(InstrumentType,''),ISNULL(BankName,'')"

            ssql2 = " SELECT a.SLCODE AS MCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, mm_MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") "
            'If unitno <> "" Then
            '    ssql2 = ssql2 & " AND LTRIM(RTRIM(b.unitno)) IN(" & unitno & ") "
            'End If
            'If ranklist <> "" Then
            '    ssql2 = ssql2 & " AND LTRIM(RTRIM(b.rankname)) IN(" & ranklist & ") "
            'End If

            ssql2 = ssql2 & "Group by  a.SLcode,a.HEADDESC "

            sqlstring2 = " select a.SLCODE AS MCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
            sqlstring2 = sqlstring2 & "  From View_drcr_Det a, mm_MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")"

            'If unitno <> "" Then
            '    sqlstring2 = sqlstring2 & " AND LTRIM(RTRIM(b.unitno)) IN(" & unitno & ") "
            'End If
            'If ranklist <> "" Then
            '    sqlstring2 = sqlstring2 & " AND LTRIM(RTRIM(b.rankname)) IN(" & ranklist & ") "
            'End If
            sqlstring2 = sqlstring2 & " Group by  a.SLCODE"
        End If

        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath

        'new one
        'begin

        ssql2 = "drop table tmp_View_Pos_Summary"
        gconnection.getDataSet(ssql2, "tmp_View_Pos_Summary")

        ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT into tmp_View_Pos_Summary FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,HEADDESC ORDER BY SLCODE "
        gconnection.getDataSet(ssql2, "View_Pos_Summary")


        sqlstring1 = "drop table tmp_View_Rec_Det"
        gconnection.getDataSet(sqlstring1, "tmp_View_Rec_Det")

        sqlstring1 = "select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
        sqlstring1 = sqlstring1 & "into tmp_View_Rec_Det FROM View_Rec_Det WHERE  MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc ORDER BY SLCODE"
        gconnection.getDataSet(sqlstring1, "tmp_View_Rec_Det")


        sqlstring1 = "drop table tmp_View_drcr_Det"
        gconnection.getDataSet(sqlstring1, "tmp_View_DrCr_Det")

        sqlstring1 = "select slcode,'OTHERS' AS locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
        sqlstring1 = sqlstring1 & "into tmp_View_drcr_Det FROM View_drcr_Det WHERE  MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE ORDER BY SLCODE"
        gconnection.getDataSet(sqlstring1, "tmp_View_DrCr_Det")

        'end


        gconnection.getDataSet(sqlstring, "MEMBERMASTER")

        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
            XMLSTR = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?>" + Environment.NewLine

            XMLSTR = XMLSTR & " <bill>" + Environment.NewLine
            XMLSTR = XMLSTR & " <clubname>" & Replace(MyCompanyName, "&", " AND ") & "</clubname>" + Environment.NewLine
            XMLSTR = XMLSTR & " <address>" & Replace(Address1, "&", " AND ") & "</address>" + Environment.NewLine
            If Address2 <> "" Then
                XMLSTR = XMLSTR & " <city>" & Replace(Address2, "&", " AND ") & "</city>" + Environment.NewLine
            Else '
                XMLSTR = XMLSTR & " <city>NIL</city>" + Environment.NewLine
            End If
            tempstr = "BILL AND STATEMENT  OF ACCOUNT FOR THE   MONTH " & CbxMonth.Text & " - " & Year(bildt)
            'XMLSTR = XMLSTR & " <title>" & tempstr & "</title>" + Environment.NewLine

            Dim NetPayable As Double
            For Each dr In gdataset.Tables("MEMBERMASTER").Rows
                XMLSTR = XMLSTR & " <member>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membernumber>" & Trim(Mid(dr("MCODE"), 1, 8)) & "</membernumber>" + Environment.NewLine
                '                        tempstr = dr("MCODE") & "/" & Format(CDate(bildt), "MMM") & "/" & Format(CDate(bildt), "yyyy")

                'tempstr = Format(dr("BILLNUMBER"), "0")

                'XMLSTR = XMLSTR & " <billnumber>Bill No. : " & tempstr & "</billnumber>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membername>" & Replace(Trim(Mid(dr("MNAME"), 1, 30)), "&", " AND ") & "</membername>" + Environment.NewLine
                XMLSTR = XMLSTR & " <billdate>Run date : " & Format(Now, "dd/MM/yyyy") & "</billdate>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress1>" & Replace(Trim(Mid(dr("CONTADD1"), 1, 50)), "&", " AND ") & "</memberaddress1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress2>" & Replace(Trim(Mid(dr("CONTADD2"), 1, 50)), "&", " AND ") & "</memberaddress2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress3>" & Replace(Trim(Mid(dr("CONTADD3"), 1, 50)), "&", " AND ") & "</memberaddress3>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membercity>" & Replace(Trim(Mid(dr("CONTCITY"), 1, 50)), "&", " AND ") & "</membercity>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberpostalcode>" & Replace(Trim(Mid(dr("CONTPIN"), 1, 50)), "&", " AND ") & "</memberpostalcode>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberphonenumber>" & Replace(Trim(Mid(dr("CONTcell"), 1, 50)), "&", " AND ") & "</memberphonenumber>" + Environment.NewLine
                XMLSTR = XMLSTR & " <preface>STATEMENT OF ACCOUNTS AND BILL FOR THE MONTH OF " & CbxMonth.Text & " - " & Year(bildt) & "</preface>" + Environment.NewLine

                tempstr1 = "01/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                If gUserCategory = "S" Then
                    tempstr = DateAdd(DateInterval.Month, 1, CDate(bildt))
                    tempstr2 = noofdays & "/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                Else
                    tempstr = DateAdd(DateInterval.Month, 1, CDate(bildt))
                    tempstr2 = noofdays & "/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                End If

                Dim Debittotal, Credittotal, Tax As Double


                XMLSTR = XMLSTR & " <columnh1>Particulars</columnh1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh2>Debit</columnh2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh3>Receivables</columnh3>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh4>Credit</columnh4>" + Environment.NewLine

                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                If dr("CREDITLIMIT") >= 0 Then
                    XMLSTR = XMLSTR & " <particular1>Opening Balance</particular1>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr("CREDITLIMIT"), "0.00")) & "</amount1>" + Environment.NewLine
                    Debittotal = Debittotal + dr("CREDITLIMIT")
                Else
                    XMLSTR = XMLSTR & " <particular2>Opening Balance</particular2>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr("CREDITLIMIT"), "0.00")) & "</amount2>" + Environment.NewLine
                    Credittotal = Credittotal + dr("CREDITLIMIT")
                End If

                NetPayable = dr("CREDITLIMIT")
                XMLSTR = XMLSTR & " </line>" + Environment.NewLine

                ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM tmp_View_Pos_Summary WHERE slcode='" & dr("mcode") & "' GROUP BY SLCODE,HEADDESC ORDER BY SLCODE "
                gconnection.getDataSet(ssql2, "View_Pos_Summary")
                Dim cc As Integer
                cc = 0
                If gdataset.Tables("View_Pos_Summary").Rows.Count > 0 Then
                    For Each dr1 In gdataset.Tables("View_Pos_Summary").Rows
                        cc = cc + 1
                        If dr1("DRAMOUNT") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr1("HEADDESC")) <> "" Then
                                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr1("HEADDESC")), "&", "AND") & "</particular1>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr1("DRAMOUNT"), "0.00")) & "</amount1>" + Environment.NewLine

                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If

                        If dr1("CRAMOUNT") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr1("HEADDESC")) <> "" Then
                                XMLSTR = XMLSTR & " <particular2>" & Replace(Trim(dr1("HEADDESC")), "&", "AND") & "</particular2>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular2>On Account</particular2>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr1("CRAMOUNT"), "0.00")) & "</amount2>" + Environment.NewLine
                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If

                        NetPayable = NetPayable + dr1("DRAMOUNT") - dr1("CRAMOUNT")
                        Debittotal = Debittotal + dr1("DRAMOUNT")
                        Credittotal = Credittotal + dr1("CRAMOUNT")
                        'Tax = dr1("TAX") + dr1("VAT") + dr1("TIPS")

                    Next
                End If

                sqlstring1 = "select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                sqlstring1 = sqlstring1 & "FROM tmp_View_Rec_Det WHERE slcode='" & dr("mcode") & "' GROUP BY SLCODE,locdesc ORDER BY SLCODE"
                gconnection.getDataSet(sqlstring1, "View_Rec_Det")
                cc = 0
                If gdataset.Tables("View_Rec_Det").Rows.Count > 0 Then
                    For Each dr4 In gdataset.Tables("View_Rec_Det").Rows
                        cc = cc + 1
                        'locdesc,sum(dramount) as dramount,sum(cramount) as cramount 
                        If dr4("cramount") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr4("locdesc")) <> "" Then
                                XMLSTR = XMLSTR & " <particular2>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular2>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular2>On Account</particular2>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr4("cramount"), "0.00")) & "</amount2>" + Environment.NewLine
                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If


                        If dr4("Dramount") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr4("locdesc")) <> "" Then
                                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular1>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr4("Dramount"), "0.00")) & "</amount1>" + Environment.NewLine
                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If

                        Credittotal = Credittotal + dr4("CRAMOUNT")
                        Debittotal = Debittotal + dr4("DRAMOUNT")
                        NetPayable = NetPayable + dr4("DRAMOUNT") - dr4("CRAMOUNT")

                    Next
                End If

                'MAHINDER

                'sqlstring1 = "select slcode,'OTHERS' AS locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                'sqlstring1 = sqlstring1 & "FROM tmp_View_drcr_Det WHERE slcode='" & dr("mcode") & "' GROUP BY SLCODE ORDER BY SLCODE"
                'gconnection.getDataSet(sqlstring1, "View_drcr_Det")
                'cc = 0
                'If gdataset.Tables("View_drcr_Det").Rows.Count > 0 Then
                '    For Each dr4 In gdataset.Tables("View_drcr_Det").Rows
                '        cc = cc + 1
                '        'locdesc,sum(dramount) as dramount,sum(cramount) as cramount 
                '        If dr4("cramount") <> 0 Then
                '            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                '            If Trim(dr4("locdesc")) <> "" Then
                '                XMLSTR = XMLSTR & " <particular2>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular2>" + Environment.NewLine
                '            Else
                '                XMLSTR = XMLSTR & " <particular2>On Account</particular2>" + Environment.NewLine
                '            End If
                '            XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr4("cramount"), "0.00")) & "</amount2>" + Environment.NewLine
                '            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                '        End If


                '        If dr4("Dramount") <> 0 Then
                '            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                '            If Trim(dr4("locdesc")) <> "" Then
                '                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular1>" + Environment.NewLine
                '            Else
                '                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                '            End If
                '            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr4("Dramount"), "0.00")) & "</amount1>" + Environment.NewLine
                '            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                '        End If

                '        Credittotal = Credittotal + dr4("CRAMOUNT")
                '        Debittotal = Debittotal + dr4("DRAMOUNT")
                '        NetPayable = NetPayable + dr4("DRAMOUNT") - dr4("CRAMOUNT")

                '    Next
                'End If


                ' XMLSTR = XMLSTR & " <tax>" & Trim(Format(dr1("TAX"), "0.00")) & "</tax>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <vat>" & Trim(Format(dr1("VAT"), "0.00")) & "</vat>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <tips>" & Trim(Format(dr1("TIPS"), "0.00")) & "</tips>" + Environment.NewLine

                'XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <particular1>Tax </particular1>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <amount1>" & Trim(Format(Tax, "0.00")) & "</amount1>" + Environment.NewLine
                'XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                XMLSTR = XMLSTR & " <particular1>Total Debit</particular1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <amount1>" & Trim(Format(Debittotal, "0.00")) & "</amount1>" + Environment.NewLine

                XMLSTR = XMLSTR & " <particular2>Total Credit</particular2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <amount2>" & Trim(Format(Credittotal, "0.00")) & "</amount2>" + Environment.NewLine

                XMLSTR = XMLSTR & " </line>" + Environment.NewLine

                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                If NetPayable >= 0 Then
                    XMLSTR = XMLSTR & " <particular1>Amount to be Received</particular1>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount1>" & Trim(Format(Math.Round(NetPayable, 1), "0.00")) & "</amount1>" + Environment.NewLine
                Else
                    XMLSTR = XMLSTR & " <particular2>Excess paid Amount</particular2>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount2>" & Trim(Format(Math.Round(NetPayable, 1), "0.00")) & "</amount2>" + Environment.NewLine
                End If
                NetPayable = 0
                Debittotal = 0
                Credittotal = 0
                Tax = 0
                XMLSTR = XMLSTR & " </line>" + Environment.NewLine

                XMLSTR = XMLSTR & "  <note>Hereafter no reminders will be sent for payment of monthly/Arrears bills.</note>" + Environment.NewLine
                XMLSTR = XMLSTR & "  </member>" + Environment.NewLine
                Filewrite.WriteLine(XMLSTR)
                XMLSTR = ""
            Next
            XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
            Filewrite.WriteLine(XMLSTR)
        End If
        '                Filewrite.WriteLine("over")
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFileXML(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If
        Exit Sub


    End Sub
    Private Sub GETSUMMARY_PRINT1()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0), month2 As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : month2 = "APRIL " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : month2 = "MAY " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : month2 = "JUNE " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : month2 = "JULY " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : month2 = "AUGUST " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : month2 = "SEPTEMBER " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : month2 = "OCTOBER " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : month2 = "NOVEMBER " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : month2 = "DECEMBER " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "JANAUARY " & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "FEBRUARY " & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "MARCH " & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.DTPduedate.Text, 1, 2) = "01" Then duedate = "01st"
            If Mid(Me.DTPduedate.Text, 1, 2) = "02" Then duedate = "02nd"
            If Mid(Me.DTPduedate.Text, 1, 2) = "03" Then duedate = "03rd"
            If Mid(Me.DTPduedate.Text, 1, 2) = "04" Then duedate = "04th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "05" Then duedate = "05th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "06" Then duedate = "06th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "07" Then duedate = "07th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "08" Then duedate = "08th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "09" Then duedate = "09th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "10" Then duedate = "10th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "11" Then duedate = "11th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "12" Then duedate = "12th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "13" Then duedate = "13th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "14" Then duedate = "14th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "15" Then duedate = "15th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "16" Then duedate = "16th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "17" Then duedate = "17th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "18" Then duedate = "18th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "19" Then duedate = "19th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "20" Then duedate = "20th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "21" Then duedate = "21st"
            If Mid(Me.DTPduedate.Text, 1, 2) = "22" Then duedate = "22nd"
            If Mid(Me.DTPduedate.Text, 1, 2) = "23" Then duedate = "23rd"
            If Mid(Me.DTPduedate.Text, 1, 2) = "24" Then duedate = "24th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "25" Then duedate = "25th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "26" Then duedate = "26th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "27" Then duedate = "27th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "28" Then duedate = "28th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "29" Then duedate = "29th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "30" Then duedate = "30th"
            If Mid(Me.DTPduedate.Text, 1, 2) = "31" Then duedate = "31st"
            Dim Viewer As New ReportViwer
            'Dim r As New gncmonthbill1
            ' Dim r As New MONTHBILLSUMMARY
            Dim r As New CRY_GOLFMONTHBILLSUMMARY
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,billdate,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode,billdate order by billdate"
                ssql2 = " SELECT SNO,SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC,SNO ORDER BY SNO "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If

                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
                ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                sqlstring1 = " select substring(a.billno,1,2)as billno ,a.billdate,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode,a.billdate"
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                ssql2 = " SELECT a.SLCODE,a.SNO,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SNO,a.SLcode,a.HEADDESC ORDER BY a.SNO "


            End If
            Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)
            Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj21 As TextObject
            Dim txtobj28 As TextObject
            txtobj21 = r.ReportDefinition.ReportObjects("Text38")
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj15 = r.ReportDefinition.ReportObjects("Text15")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text30")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text31")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text32")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj21.Text = Me.DTPduedate.Text
            txtobj28 = r.ReportDefinition.ReportObjects("Text28")
            txtobj28.Text = month2

            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GETSUMMARY_PRINT_OTHERS()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, month2 As String
            Dim opl, i As Integer
            Call Validation()
            sqlstrinG = "select ISNULL(subscode,'') as groupcode from subsposting where ISNULL(subscode,'')<>'' group by subscode having SUM(amount)>0"
            sqlstrinG = sqlstrinG & " union all"
            sqlstrinG = sqlstrinG & "select ISNULL(taxcode,'') as groupcode from subsposting where ISNULL(taxcode,'')<>'' group by taxcode having SUM(taxamount)>0"
            sqlstrinG = sqlstrinG & " union all"
            sqlstrinG = sqlstrinG & " select ISNULL(taxaccountcode,'') as groupcode from kot_det where ISNULL(taxaccountcode,'')<>'' group by TAXACCOUNTCODE having SUM(taxamount)>0 "
            sqlstrinG = sqlstrinG & " union all"
            sqlstrinG = sqlstrinG & " select ISNULL(packaccountcode,'') as groupcode from kot_det where ISNULL(PACKACCOUNTCODE,'')<>'' group by PACKACCOUNTCODE having SUM(packamount)>0 "
            sqlstrinG = sqlstrinG & " union(all)"
            sqlstrinG = sqlstrinG & " select ISNULL(GROUPCODE,'') as groupcode from kot_det where ISNULL(GROUPCODE,'')<>'' group by GROUPCODE having SUM(amount)>0 "
            'sqlstring = "ALTER VIEW opbalhga as select slcode,SUM(opbalance) as openingbalance from MM_VIEW_DEBITCREDIT WHERE BILLDATE< '" & bildt & "'GROUP BY SLCODE"
            'gconnection.dataOperation(3, sqlstring, "opbalhga1")
            'sqlstring = "ALTER view credhga as Select B.SLCODE,B.OPENINGBALANCE,SUM(isnull(a.DEBITAMOUNT,0))AS DEBITAMOUNT,SUM(isnull(a.CREDIT,0))AS CREDIT,A.mname,A.CONTCELL  from  opbalhga b left outer join MM_VIEW_DEBITCREDIT_DET a on a.slcode=b.SLcode and MONTH(a.BILLDATE)='" & month1 & "' group by b.SLCODE,b.OPENINGBALANCE,A.MNAME,A.CONTCELL"
            'gconnection.dataOperation(4, sqlstring, "credhga2")
            'sqlstring1 = "ALTER view credhga1 as select a.slcode,b.mname,b.CONTCELL,a.openingbalance,a.credit,a.debitamount from credhga a inner join membermaster b on a.slcode=b.MCODE"
            'gconnection.dataOperation(6, sqlstring1, "credhga4")
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : month2 = "04"
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : month2 = "05"
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : month2 = "06"
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : month2 = "07"
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : month2 = "08"
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : month2 = "09"
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : month2 = "10"
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : month2 = "11"
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : month2 = "12"
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "01"
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "02"
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
                MNTH2 = Year(gFinancialYearEnd) Mod 4
                month1 = 2
                month = "FEB"
                If MNTH2 = 0 Then
                    noofdays = 29
                    bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
                Else
                    noofdays = 28
                    bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
                End If
                month2 = "02"
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "03"
            Dim Viewer As New ReportViwer
            Dim r As New MONTH_BILL1
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                'ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "

            End If
            Call Viewer.GetDetails1(sqlstrinG, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(ssql2, "month_bill", r)
            Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            txtobj19 = r.ReportDefinition.ReportObjects("Text13")
            txtobj20 = r.ReportDefinition.ReportObjects("Text8")
            txtobj15 = r.ReportDefinition.ReportObjects("Text7")
            txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            'txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            'txtobj1.Text = UCase(gCompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text30")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text31")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text32")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text34")
            'txtobj1.Text = UCase(txt_msg.Text)
            txtobj19.Text = "CREDIT BILL FOR THE MONTH OF " & month & " " & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj15.Text = "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4)) & month2
            txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj20.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))

            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RDOCOMBINEDNO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.Click
        Rnd_Summary.Visible = True
        Rnd_Details.Visible = True
        Rnd_summardet.Visible = False
    End Sub

    Private Sub RDOCOMBINEDYES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.Click
        Rnd_Summary.Visible = False
        Rnd_Details.Visible = False
        Rnd_summardet.Visible = True
    End Sub

    Private Sub GETSUMMARYANDDETAILS()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
                MNTH2 = Year(gFinancialYearEnd) Mod 4
                month1 = 2
                If MNTH2 = 0 Then
                    noofdays = 29
                    bildt = "29-feb-" & Year(gFinancialYearEnd)
                Else
                    noofdays = 28
                    bildt = "28-feb-" & Year(gFinancialYearEnd)
                End If
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            Dim Viewer As New ReportViwer
            'Dim r As New CRY_MONTHBILLSUMMARY
            Dim r As New CRY_MONTHBILLANDSUMMARY
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode"
                ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If

                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
                ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                sqlstring1 = " select substring(a.billno,1,2)as billno ,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode"
                ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "


            End If
            Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)
            Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj15 = r.ReportDefinition.ReportObjects("Text15")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text30")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text31")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text32")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub billSummarydetails()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Debitcredit
            If chk_Filter_Field.CheckedItems.Count > 0 Then
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                    membertype = membertype & "'" & TYPE(0) & "', "
                Next
                membertype = Mid(membertype, 1, Len(membertype) - 2)

            Else
                MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_Filter_Field.Focus()
                Exit Sub
            End If
            Dim Cmd As New SqlCommand
            Dim con As SqlConnection

            'sqlstring = "DROP VIEW opbalhga"

            'gconnection.dataOperation(2, sqlstring, "opbalhga")
            'sqlstring1 = "DROP VIEW credhga"
            'gconnection.dataOperation(3, sqlstring1, "credhga")

            sqlstring = "ALTER VIEW opbalhga as select slcode,SUM(opbalance) as openingbalance from MM_VIEW_DEBITCREDIT WHERE BILLDATE< '" & bildt & "'GROUP BY SLCODE"
            gconnection.dataOperation(3, sqlstring, "opbalhga1")
            sqlstring = "ALTER view credhga as Select B.SLCODE,B.OPENINGBALANCE,SUM(isnull(a.DEBITAMOUNT,0))AS DEBITAMOUNT,SUM(isnull(a.CREDIT,0))AS CREDIT,A.mname,A.CONTCELL  from  opbalhga b left outer join MM_VIEW_DEBITCREDIT_DET a on a.slcode=b.SLcode and MONTH(a.BILLDATE)='" & month1 & "' group by b.SLCODE,b.OPENINGBALANCE,A.MNAME,A.CONTCELL"
            gconnection.dataOperation(4, sqlstring, "credhga2")
            sqlstring1 = "ALTER view credhga1 as select a.slcode,b.mname,b.CONTCELL,a.openingbalance,a.credit,a.debitamount from credhga a inner join membermaster b on a.slcode=b.MCODE"
            gconnection.dataOperation(6, sqlstring1, "credhga4")






            'If Trim(txt_mcode.Text) <> "" Then
            '    'sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,mm_MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") "
            '    'sqlstring1 = sqlstring1 & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.membertype ORDER BY M.MCODE"
            '    ''sqlstring = "select a.slcode,b.mname,b.membertypecode,SUM(balance) as prev_due,SUM(billamount) as billamount,case when SUM(balance)+SUM(billamount)>=0 then SUM(balance)+SUM(billamount) else 0 end as totaldue,case when SUM(balance)+SUM(billamount)<0 then SUM(balance)+SUM(billamount) else 0 end as totalcredit from view_monthbillsummary a inner join membermaster b  on a.slcode=b.MCODE  AND  b.MCODE = '" & txt_mcode.Text & "'  group by a.slcode,b.mname,b.membertypecode"
            '    'sqlstring = "Select a.slcode,b.mname,a.OPBALANCE,a.DEBITAMOUNT,a.CREDIT from MM_VIEW_DEBITCREDIT a inner join membermaster b where month(a.BILLDATE)='" & month1 & "' AND  b.MCODE = '" & txt_mcode.Text & "'"
            'Else
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode"
                ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
            Else
                ''ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = "select sum(Cramount)as Cramount,SUM(Dramount)as Dramount,slcode"
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE"
                ''sqlstring1 = " select substring(a.billno,1,2)as billno ,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                ''sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode"
                'ssql2 = " SELECT a.SLCODE,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode "

                'sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,'" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MM_MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")"
                'sqlstring1 = sqlstring1 & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.membertype ORDER BY M.MCODE"
                ''sqlstring = "select a.slcode,b.mname,b.membertypecode,SUM(balance) as prev_due,SUM(billamount) as billamount,case when SUM(balance)+SUM(billamount)>=0 then SUM(balance)+SUM(billamount) else 0 end as totaldue,case when SUM(balance)+SUM(billamount)<0 then SUM(balance)+SUM(billamount) else 0 end as totalcredit,sum(rcpt) as rcpt from view_monthbillsummary a inner join membermaster b  on a.slcode=b.MCODE AND B.membertypecode IN(" & membertype & ") "
                ''sqlstring = sqlstring & "group by a.slcode,b.mname,b.membertypecode having  SUM(billamount)>0 "
                'sqlstring = "Select a.slcode,b.mname,SUM(a.OPBALANCE),SUM(a.DEBITAMOUNT),SUM(a.CREDIT) from MM_VIEW_DEBITCREDIT a,membermaster b where a.slcode=b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME "
                'sqlstring = "Select a.slcode,b.mname,b.Membertype,SUM(a.OPBALANCE)AS OPBALANCE,SUM(a.DEBITAMOUNT)AS DEBITAMOUNT,SUM(a.CREDIT)AS CREDIT,sum(a.TAX)as TAX from MM_VIEW_DEBITCREDIT_DET a,membermaster b where a.slcode = b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME,b.Membertype "
                'sqlstring = "Select a.slcode,b.mname,b.Membertype,SUM(a.OPBALANCE)AS OPBALANCE,SUM(a.DEBITAMOUNT)AS DEBITAMOUNT,SUM(a.CREDIT)AS CREDIT from MM_VIEW_DEBITCREDIT_DET a,membermaster b where a.slcode = b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME,b.Membertype "
                sqlstring = "select slcode,mname,CONTCELL,openingbalance,credit,debitamount from credhga1 order by slcode"

            End If

            'Call Viewer.GetDetails1(sqlstring1, "MM_MEMBERMASTER", r)
            Call Viewer.GetDetails1(sqlstring, "credhga1", r)
            'Call Viewer.GetDetails1(sqlstring1, "MEMBERMASTER", r)
            'Call Viewer.GetDetails1(sqlstring1, "VIEW_REC_DET", r)
            'Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)

            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject

            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        Dim cmdText, note As String
        cmdText = "Select * From VW_UNITWISE_MEMBER"
        Dim duedate, membertype, TYPE(0) As String
        Dim opl, i As Integer
        Dim unit(0) As String
        Dim unitno As String
        Dim ranklist As String
        Dim dr, dr1, dr2, dr4 As DataRow
        Call Validation()
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
        Dim ssql As String
        If Rnd_subscription.Checked = True Then
            Try
                Dim _export As New EXPORT
                Dim SQLSTR As String
                SQLSTR = "SELECT * FROM MM_VIEW_SUBSPOSTING WHERE month(BILLDATE)=month('" & Format(CDate(bildt), "dd/MMM/yyyy") & "')"
                _export.TABLENAME = "MM_VIEW_SUBSPOSTING"
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf Rnd_Posdetails.Checked = True Then

            Try
                Dim _export As New EXPORT

                Dim SQLSTR As String
                SQLSTR = "SELECT * FROM MM_VIEW_POS_SDETAILS WHERE MONTH(KOTDATE) =month('" & Format(CDate(bildt), "dd/MMM/yyyy") & "')"
                _export.TABLENAME = "MM_VIEW_POS_SDETAILS "
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    Public Sub bill_Summary_details()
        Try
            Dim bildt, bildt1 As Date
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/jan/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "28/feb/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
                MNTH2 = Year(gFinancialYearEnd) Mod 4
                month1 = 2
                If MNTH2 = 0 Then
                    noofdays = 29
                    bildt = "29-feb-" & Year(gFinancialYearEnd)
                Else
                    noofdays = 28
                    bildt = "28-feb-" & Year(gFinancialYearEnd)
                End If
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/mar/" & Mid(gFinancialyearStart, 7, 4)
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Debitcredit
            'If chk_Filter_Field.CheckedItems.Count > 0 Then
            '    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
            '        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
            '        membertype = membertype & "'" & TYPE(0) & "', "
            '    Next
            '    membertype = Mid(membertype, 1, Len(membertype) - 2)

            'Else
            '    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    chk_Filter_Field.Focus()
            '    Exit Sub
            'End If
            Dim Cmd As New SqlCommand
            Dim con As SqlConnection
            sqlstring1 = "EXEC cp_monthsummary  '" & Format(bildt, "dd/MMM/yyyy") & "','" & Format(bildt1, "dd/MMM/yyyy") & "'"
            gconnection.ExcuteStoreProcedure(sqlstring1)
            If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "select slcode,mname,CONTCELL,openingbalance,credit,debitamount from credhga1 where slcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' order by slcode"
            Else
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()

                    Exit Sub
                End If
                sqlstring = "select h.slcode,h.mname,h.CONTCELL,h.openingbalance,h.credit,h.debitamount,m.membertypecode from credhga1 h,membermaster m  where h.slcode=m.mcode and  LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")"
            End If

            Call Viewer.GetDetails1(sqlstring, "credhga1", r)

            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject

            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RND_billforward_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RND_billforward.CheckedChanged

    End Sub

    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub Rnd_Details_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_Details.CheckedChanged

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Grp_sms.Visible = False
        cmd_ver.Enabled = True
        Btn_Excel.Enabled = True
        Btn_close.Enabled = True
        cmd_view.Enabled = True
        cmd_Clear.Enabled = True
    End Sub
    Private Sub Validation1()

        boolchk = False
        Dim message, mcode, mname, mblno As String
        Dim I, J As Integer


        If rdb_plain.Checked = True Then
            message = txt_msg.Text
            If message = "" Then
                MessageBox.Show("Message Format Should'nt be blank ", gCompanyname)
                Exit Sub
            End If
            If message.Length > 160 Then
                MessageBox.Show("Message Length Should not exceed 160 Characters ", gCompanyname)
                Exit Sub
            End If
        End If

        With ssgrid_sms
            For I = 0 To ssgrid_sms.DataRowCnt - 1
                .Row = I + 1
                .Col = 4
                mblno = .Text
                .Col = 5
                If Val(.Text) = 1 Then
                    J = J + 1
                    If mblno = "" Then
                        MessageBox.Show("Mobile no. can't be blank", gCompanyname)
                        Exit Sub
                    End If
                    If IsNumeric(mblno) = False Then
                        MessageBox.Show("Invalid mobile no.", gCompanyname)
                        Exit Sub
                    End If
                    If Len(mblno) > 10 And Len(mblno) = 12 Then
                        If mblno.Substring(0, 2) = "91" Then
                        Else
                            MessageBox.Show("Mobile No. can't be exceed 10 nos.", gCompanyname)
                            Exit Sub
                        End If
                    End If
                    If Len(mblno) > 10 And Len(mblno) <> 12 Then
                        MessageBox.Show("Mobile No. can't be exceed 10 nos.", gCompanyname)
                    End If
                    'Call SMS(mcode, mname, mblno, Message)
                Else
                    J = J + 0
                End If

            Next
        End With
        'If txt_mcode.Text = "" Then
        '    MessageBox.Show(" From MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_mcode.Focus()
        '    Exit Sub
        'End If
        'If txt_Tomcode.Text = "" Then
        '    MessageBox.Show(" To MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_Tomcode.Focus()
        '    Exit Sub
        'End If
        boolchk = True
    End Sub

    Private Sub cmd_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ver.Click
        Grp_sms.Visible = True
        cmd_ver.Enabled = False
        Btn_Excel.Enabled = False
        Btn_close.Enabled = False
        cmd_view.Enabled = False
        cmd_Clear.Enabled = False
        Txt_msg1.Visible = False
        Label4.Visible = False
        rdb_mem.Checked = True

        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Member Type Items")
            Exit Sub
        End If

        Dim cmdText, contcell As String
        Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, month2, bildt1 As String
        Dim opl, i As Integer
        Call Validation()

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : month2 = "04" : bildt1 = "01/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : month2 = "05" : bildt1 = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : month2 = "06" : bildt1 = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : month2 = "07" : bildt1 = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : month2 = "08" : bildt1 = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : month2 = "09" : bildt1 = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : month2 = "10" : bildt1 = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : month2 = "11" : bildt1 = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/Dec/" & Mid(gFinancialyearStart, 7, 4) : month2 = "12" : bildt1 = "01/Jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/Jan/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "01" : bildt1 = "01/Feb/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/Feb/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "02" : bildt1 = "01/Mar/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : month2 = "03" : bildt1 = "01/Apr/" & Mid(gFinancialYearEnd, 7, 4)
        If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
            sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt1 & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "

        Else

            If chk_Filter_Field.CheckedItems.Count > 0 Then
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                    membertype = membertype & "'" & TYPE(0) & "', "
                Next
                membertype = Mid(membertype, 1, Len(membertype) - 2)

            Else
                MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_Filter_Field.Focus()
                Exit Sub
            End If
            sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt1 & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "

        End If
        gconnection.getDataSet(sqlstrinG, "MM_MEMBERMASTER")

        If gdataset.Tables("MM_MEMBERMASTER").Rows.Count > 0 Then

            With ssgrid_sms
                For i = 0 To gdataset.Tables("MM_MEMBERMASTER").Rows.Count - 1
                    .Row = i + 1
                    .Col = 1
                    .Text = gdataset.Tables("MM_MEMBERMASTER").Rows(i).Item("MCODE")
                    .Row = i + 1
                    .Col = 2
                    .Text = gdataset.Tables("MM_MEMBERMASTER").Rows(i).Item("MNAME")
                    .Row = i + 1
                    .Col = 3
                    .Text = gdataset.Tables("MM_MEMBERMASTER").Rows(i).Item("CREDITLIMIT")
                    .Row = i + 1
                    .Col = 4
                    contcell = gdataset.Tables("MM_MEMBERMASTER").Rows(i).Item("CONTCELL")
                    .Text = contcell.Replace(" ", "")
                Next
            End With
        End If
        'txt_msg.Text = MESSAGE
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        Txt_msg1.Text = ""
        ssgrid_sms.ClearRange(1, 1, -1, -1, True)
    End Sub
    Private Sub cmd_sms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_sms.Click
        Dim message, mcode, mname, mblno As String
        Dim I, J As Integer
        Dim outstanding As Double
        Call Validation1()
        If boolchk = False Then Exit Sub
        message = txt_msg.Text
        With ssgrid_sms
            For I = 0 To ssgrid_sms.DataRowCnt - 1
                .Row = I + 1
                .Col = 4
                mblno = .Text
                .Col = 3
                outstanding = Val(.Text)
                .Col = 5
                If Val(.Text) = 1 Then
                    J = J + 1
                    If rdb_plain.Checked = True Then
                        Call SMS(mcode, mname, mblno, message)
                    Else
                        Call SMS1(mcode, mname, mblno, outstanding)
                    End If

                Else
                    J = J + 0
                End If

            Next
        End With
        If J >= 1 Then
            MessageBox.Show("Message Sended Successfully", gCompanyname)
        End If
        If J = 0 Then
            MessageBox.Show("Select any mcode", gCompanyname)
            Exit Sub
        End If
    End Sub
    Public Sub SMS(ByVal MCODE, ByVal GUEST, ByVal MBLNO, ByVal MESSAGE)

        Dim xmlobj
        Dim strPostData As String
        Dim SQLSTRING As String
        'Dim USERID, SID, PWD, APPID, SUBAPPID As String
        Dim i As Integer
        Dim gconnection As New GlobalClass


        'SQLSTRING = "SELECT * FROM SM_SMSDETAILS"
        'gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
        'If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
        '    USERID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("USERNAME"))
        '    APPID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("APPID"))
        '    SUBAPPID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SUBAPPID"))
        '    PWD = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("PASSWORD"))

        Try

            xmlobj = CreateObject("msxml2.XMLHTTP")
            strPostData = ""
            'strPostData = "http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=oclubalt&pass=oclubalt&appid=oclubalt&subappid=oclubalt &msgtype=1&contenttype=1&selfid=true&to=9962137618&from=56767&dlrreq=true&text=Welcome to Outram club sms services&alert=1"
            'strPostData = "http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=oclubalt&pass=oclubalt&appid=oclubalt&subappid=oclubalt&msgtype=1&contenttype=1&selfid=true&to=9962137618&from=56767&dlrreq=true&text=Welcome+to+Outram+club+sms+services&alert=1"

            'strPostData = "http://push3.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=" & USERID & "&pass=" & PWD & "&appid=" & APPID & "&subappid=" & SUBAPPID & "&msgtype=1&contenttype=1&selfid=true&to=" & MBLNO & "&from=56767&dlrreq=true&text=" & MESSAGE & "&alert=1"
            'xmlobj.open()

            ''strPostData = " http://5.189.187.82/sendsms/sendsms.php?username=" & USERID & "&password=" & PWD & "&type=TEXT&sender=OUTRAM&mobile=" & MBLNO & "&message=" & MESSAGE & ""
            strPostData = "http://5.189.187.82/sendsms/bulk.php?username=" & USERID & "&password=" & PWD & "&type=TEXT&sender=OUTRAM&mobile=" & MBLNO & "&message=" & MESSAGE & "&entityId=1701160225621096193&templateId=1707161727872467402"

            xmlobj.open("POST", strPostData, True)
            xmlobj.send()
            'xmlobj = DropObject("msxml2.XMLHTTP")


            xmlobj = Nothing

        Catch
            MsgBox("Please Check Your Internet Connection")
        End Try
        'End If
    End Sub
    Public Sub SMS1(ByVal MCODE, ByVal GUEST, ByVal MBLNO, ByVal OUTSTANDING)

        Dim xmlobj
        Dim strPostData As String
        Dim SQLSTRING, MESSAGE As String
        Dim OUTSTAND As String
        Dim billdate As Date
        'Dim USERID, SID, PWD, APPID, SUBAPPID As String
        Dim i As Integer
        Dim gconnection As New GlobalClass
        If OUTSTANDING > 0 Then
            OUTSTAND = OUTSTANDING & " Dr"
        Else
            OUTSTAND = OUTSTANDING * -1 & " Cr"
        End If
        duedt = Format(DTPduedate.Value, "dd/MM/yyyy")

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : bildt = "30/04/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : bildt = "31/05/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : bildt = "30/06/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : bildt = "31/07/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : bildt = "31/08/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : bildt = "30/09/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : bildt = "31/10/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : bildt = "30/11/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : bildt = "31/12/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : bildt = "31/01/" & Mid(gFinancialYearEnd, 7, 4)
        'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : bildt = "28/02/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
            MNTH2 = Year(gFinancialYearEnd) Mod 4
            month1 = 2
            If MNTH2 = 0 Then
                noofdays = 29
                bildt = "29/02/" & Year(gFinancialYearEnd)
            Else
                noofdays = 28
                bildt = "28/02/" & Year(gFinancialYearEnd)
            End If
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : bildt = "31/03/" & Mid(gFinancialYearEnd, 7, 4)
        ' MESSAGE = "YOUR OUTRAM CLUB BILL FOR " & bildt & " OF RS. " & OUTSTANDING & "/- HAS BEEN POSTED.PL.PAY FULL WITHIN (" & duedt & ") FOR UNINTERRUPTED SERVICES. PL. CO-OPERATE"
        MESSAGE = "YOUR OUTRAM CLUB BILL FOR " & bildt & " OF RS. " & OUTSTANDING & "- PLEASE PAY WITHIN DUE DATE (" & duedt & ") WE SEEK YOUR CO-OPERATION."
        ' MESSAGE = "YOUR OUTRAM CLUB BILL FOR "
        'MESSAGE = "Dear Member your current outstanding is " & OUTSTAND
        'MessageBox.Show(MESSAGE)
        'SQLSTRING = "SELECT * FROM SM_SMSDETAILS"
        'gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
        'If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
        '    USERID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("USERNAME"))
        '    APPID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("APPID"))
        '    SUBAPPID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SUBAPPID"))
        '    PWD = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("PASSWORD"))

        Try

            xmlobj = CreateObject("msxml2.XMLHTTP")
            strPostData = ""
            'strPostData = "http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=oclubalt&pass=oclubalt&appid=oclubalt&subappid=oclubalt &msgtype=1&contenttype=1&selfid=true&to=9962137618&from=56767&dlrreq=true&text=Welcome to Outram club sms services&alert=1"
            'strPostData = "http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=oclubalt&pass=oclubalt&appid=oclubalt&subappid=oclubalt&msgtype=1&contenttype=1&selfid=true&to=9962137618&from=56767&dlrreq=true&text=Welcome+to+Outram+club+sms+services&alert=1"
            'strPostData = "http://push3.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=" & USERID & "&pass=" & PWD & "&appid=" & APPID & "&subappid=" & SUBAPPID & "&msgtype=1&contenttype=1&selfid=true&to=" & MBLNO & "&from=56767&dlrreq=true&text=" & MESSAGE & "&alert=1"
            'strPostData = "http://smsbusiness.in/api.php?username=" & USERID & "&password=" & PWD & "&sender=OUTRAM&sendto=" & MBLNO & "&message=" & MESSAGE & ""
            'strPostData = "http://smsbusiness.in/api.php?username=OutramClub&password=931069&sender=OUTRAM&sendto=9051535256&message=YOUR OUTRAM CLUB BILL FOR 31/03/2016 OF RS. 1650.43- PLEASE PAY WITHIN DUE DATE (04/04/2016) WE SEEK YOUR CO-OPERATION."

            ''strPostData = " http://5.189.187.82/sendsms/sendsms.php?username=" & USERID & "&password=" & PWD & "&type=TEXT&sender=OUTRAM&mobile=" & MBLNO & "&message=" & MESSAGE & ""
            strPostData = "http://5.189.187.82/sendsms/bulk.php?username=" & USERID & "&password=" & PWD & "&type=TEXT&sender=OUTRAM&mobile=" & MBLNO & "&message=" & MESSAGE & "&entityId=1701160225621096193&templateId=1707161727872467402"

            'xmlobj.open()
            xmlobj.open("POST", strPostData, True)
            xmlobj.send()
            'MsgBox(xmlobj.responseText)
            'xmlobj = DropObject("msxml2.XMLHTTP")

            xmlobj = Nothing

        Catch
            MsgBox("Please Check Your Internet Connection")
        End Try
        'End If
    End Sub

    Private Sub rdb_plain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_plain.CheckedChanged
        If rdb_plain.Checked = True Then
            Txt_msg1.Visible = True
            Label4.Visible = True
        Else
            Txt_msg1.Visible = False
            Label4.Visible = False
        End If
    End Sub

    Private Sub rdb_mem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_mem.CheckedChanged
        If rdb_mem.Checked = True Then
            Txt_msg1.Visible = False
            Label4.Visible = False
        Else
            Txt_msg1.Visible = True
            Label4.Visible = True
        End If
    End Sub
End Class
