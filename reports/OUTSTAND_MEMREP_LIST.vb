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
Public Class OUTSTAND_MEMREP_LIST
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J As Integer
    Dim STR_STATUS, STR_TYPE, STR_OPCTION As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHK_MEMBERCATEGORY As System.Windows.Forms.CheckBox
    Friend WithEvents ChKLIST_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
    Friend WithEvents CHKLIST_SELECT As System.Windows.Forms.CheckedListBox
    Friend WithEvents LAB_OPCTION As System.Windows.Forms.Label
    Friend WithEvents RDB_CREDIT_STOP_LIST As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_OUTSNDING_LIST As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_defaulter_list As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents DTPBILLDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_RECDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Rdo_arriarslist As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtSelection As System.Windows.Forms.TextBox
    Public WithEvents lblSelection As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents optMCode As System.Windows.Forms.RadioButton
    Public WithEvents optAccName As System.Windows.Forms.RadioButton
    Public WithEvents OptOthers As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OUTSTAND_MEMREP_LIST))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Rdo_arriarslist = New System.Windows.Forms.RadioButton
        Me.RDB_OUTSNDING_LIST = New System.Windows.Forms.RadioButton
        Me.RDB_CREDIT_STOP_LIST = New System.Windows.Forms.RadioButton
        Me.RDB_defaulter_list = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.CHK_MEMBERCATEGORY = New System.Windows.Forms.CheckBox
        Me.ChKLIST_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.CHK_STATUS = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LAB_OPCTION = New System.Windows.Forms.Label
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox
        Me.CHKLIST_SELECT = New System.Windows.Forms.CheckedListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TXT_AMOUNT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP_RECDATE = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.DTPBILLDATE = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.optMCode = New System.Windows.Forms.RadioButton
        Me.optAccName = New System.Windows.Forms.RadioButton
        Me.OptOthers = New System.Windows.Forms.RadioButton
        Me.lblSelection = New System.Windows.Forms.Label
        Me.txtSelection = New System.Windows.Forms.TextBox
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rdo_arriarslist)
        Me.GroupBox1.Controls.Add(Me.RDB_OUTSNDING_LIST)
        Me.GroupBox1.Controls.Add(Me.RDB_CREDIT_STOP_LIST)
        Me.GroupBox1.Controls.Add(Me.RDB_defaulter_list)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Rdo_arriarslist
        '
        Me.Rdo_arriarslist.AllowDrop = True
        Me.Rdo_arriarslist.BackColor = System.Drawing.Color.Transparent
        Me.Rdo_arriarslist.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdo_arriarslist.Location = New System.Drawing.Point(8, 112)
        Me.Rdo_arriarslist.Name = "Rdo_arriarslist"
        Me.Rdo_arriarslist.Size = New System.Drawing.Size(176, 24)
        Me.Rdo_arriarslist.TabIndex = 2
        Me.Rdo_arriarslist.Text = "ARREAR LIST"
        '
        'RDB_OUTSNDING_LIST
        '
        Me.RDB_OUTSNDING_LIST.AllowDrop = True
        Me.RDB_OUTSNDING_LIST.BackColor = System.Drawing.Color.Transparent
        Me.RDB_OUTSNDING_LIST.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_OUTSNDING_LIST.Location = New System.Drawing.Point(8, 16)
        Me.RDB_OUTSNDING_LIST.Name = "RDB_OUTSNDING_LIST"
        Me.RDB_OUTSNDING_LIST.Size = New System.Drawing.Size(224, 24)
        Me.RDB_OUTSNDING_LIST.TabIndex = 1
        Me.RDB_OUTSNDING_LIST.Text = "OUTSTANDING LIST"
        '
        'RDB_CREDIT_STOP_LIST
        '
        Me.RDB_CREDIT_STOP_LIST.AllowDrop = True
        Me.RDB_CREDIT_STOP_LIST.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_CREDIT_STOP_LIST.Location = New System.Drawing.Point(8, 48)
        Me.RDB_CREDIT_STOP_LIST.Name = "RDB_CREDIT_STOP_LIST"
        Me.RDB_CREDIT_STOP_LIST.Size = New System.Drawing.Size(224, 24)
        Me.RDB_CREDIT_STOP_LIST.TabIndex = 0
        Me.RDB_CREDIT_STOP_LIST.Text = "CREDIT STOP LIST"
        '
        'RDB_defaulter_list
        '
        Me.RDB_defaulter_list.AllowDrop = True
        Me.RDB_defaulter_list.BackColor = System.Drawing.Color.Transparent
        Me.RDB_defaulter_list.Checked = True
        Me.RDB_defaulter_list.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_defaulter_list.Location = New System.Drawing.Point(8, 80)
        Me.RDB_defaulter_list.Name = "RDB_defaulter_list"
        Me.RDB_defaulter_list.Size = New System.Drawing.Size(208, 24)
        Me.RDB_defaulter_list.TabIndex = 0
        Me.RDB_defaulter_list.TabStop = True
        Me.RDB_defaulter_list.Text = "DEFAULTER LIST"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(504, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 24)
        Me.Label4.TabIndex = 424
        Me.Label4.Text = "MEMBER TYPE"
        '
        'CHK_MEMBERCATEGORY
        '
        Me.CHK_MEMBERCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MEMBERCATEGORY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MEMBERCATEGORY.Location = New System.Drawing.Point(488, 40)
        Me.CHK_MEMBERCATEGORY.Name = "CHK_MEMBERCATEGORY"
        Me.CHK_MEMBERCATEGORY.Size = New System.Drawing.Size(141, 24)
        Me.CHK_MEMBERCATEGORY.TabIndex = 423
        Me.CHK_MEMBERCATEGORY.Text = "SELECT ALL"
        '
        'ChKLIST_Memberstatus
        '
        Me.ChKLIST_Memberstatus.BackColor = System.Drawing.Color.White
        Me.ChKLIST_Memberstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKLIST_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED", "8.ACTIVE", "9.POSTED"})
        Me.ChKLIST_Memberstatus.Location = New System.Drawing.Point(760, 240)
        Me.ChKLIST_Memberstatus.Name = "ChKLIST_Memberstatus"
        Me.ChKLIST_Memberstatus.Size = New System.Drawing.Size(216, 225)
        Me.ChKLIST_Memberstatus.Sorted = True
        Me.ChKLIST_Memberstatus.TabIndex = 425
        '
        'CHK_STATUS
        '
        Me.CHK_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CHK_STATUS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_STATUS.Location = New System.Drawing.Point(744, 41)
        Me.CHK_STATUS.Name = "CHK_STATUS"
        Me.CHK_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.CHK_STATUS.TabIndex = 426
        Me.CHK_STATUS.Text = "SELECT ALL"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(760, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 427
        Me.Label1.Text = "MEMBER STATUS"
        '
        'LAB_OPCTION
        '
        Me.LAB_OPCTION.BackColor = System.Drawing.Color.Maroon
        Me.LAB_OPCTION.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_OPCTION.ForeColor = System.Drawing.Color.White
        Me.LAB_OPCTION.Location = New System.Drawing.Point(240, 96)
        Me.LAB_OPCTION.Name = "LAB_OPCTION"
        Me.LAB_OPCTION.Size = New System.Drawing.Size(240, 24)
        Me.LAB_OPCTION.TabIndex = 431
        Me.LAB_OPCTION.Text = "MEMBER LIST"
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SELECT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(240, 40)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(112, 24)
        Me.CHK_SELECT.TabIndex = 430
        Me.CHK_SELECT.Text = "SELECT ALL"
        '
        'CHKLIST_SELECT
        '
        Me.CHKLIST_SELECT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKLIST_SELECT.Location = New System.Drawing.Point(256, 240)
        Me.CHKLIST_SELECT.Name = "CHKLIST_SELECT"
        Me.CHKLIST_SELECT.Size = New System.Drawing.Size(239, 225)
        Me.CHKLIST_SELECT.TabIndex = 429
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TXT_AMOUNT)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DTP_RECDATE)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DTPBILLDATE)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 499)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(984, 40)
        Me.GroupBox2.TabIndex = 432
        Me.GroupBox2.TabStop = False
        '
        'TXT_AMOUNT
        '
        Me.TXT_AMOUNT.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TXT_AMOUNT.Location = New System.Drawing.Point(320, 10)
        Me.TXT_AMOUNT.Name = "TXT_AMOUNT"
        Me.TXT_AMOUNT.Size = New System.Drawing.Size(88, 24)
        Me.TXT_AMOUNT.TabIndex = 443
        Me.TXT_AMOUNT.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 442
        Me.Label3.Text = "AMOUNT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(720, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 441
        Me.Label2.Text = "RECEIPT  DATE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DTP_RECDATE
        '
        Me.DTP_RECDATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTP_RECDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_RECDATE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_RECDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_RECDATE.Location = New System.Drawing.Point(848, 9)
        Me.DTP_RECDATE.Name = "DTP_RECDATE"
        Me.DTP_RECDATE.Size = New System.Drawing.Size(112, 26)
        Me.DTP_RECDATE.TabIndex = 440
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 439
        Me.Label10.Text = "BILL DATE :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DTPBILLDATE
        '
        Me.DTPBILLDATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTPBILLDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTPBILLDATE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPBILLDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBILLDATE.Location = New System.Drawing.Point(576, 9)
        Me.DTPBILLDATE.Name = "DTPBILLDATE"
        Me.DTPBILLDATE.Size = New System.Drawing.Size(112, 26)
        Me.DTPBILLDATE.TabIndex = 438
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.cmd_view)
        Me.GroupBox3.Controls.Add(Me.Btn_close)
        Me.GroupBox3.Controls.Add(Me.cmd_Clear)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 568)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(984, 48)
        Me.GroupBox3.TabIndex = 439
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(472, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 440
        Me.Button1.Text = "Export"
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.Location = New System.Drawing.Point(360, 10)
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
        Me.Btn_close.Image = CType(resources.GetObject("Btn_close.Image"), System.Drawing.Image)
        Me.Btn_close.Location = New System.Drawing.Point(584, 10)
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
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(248, 10)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.LAB_OPCTION)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.CHK_SELECT)
        Me.GroupBox4.Controls.Add(Me.CHK_MEMBERCATEGORY)
        Me.GroupBox4.Controls.Add(Me.CHK_STATUS)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(984, 432)
        Me.GroupBox4.TabIndex = 440
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PRESS (F2) S(D)ELECT ALL"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 16)
        Me.Label8.TabIndex = 442
        Me.Label8.Text = "PRESS (F2) S(D)ELECT ALL"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(744, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 441
        Me.Label7.Text = "PRESS (F2) S(D)ELECT ALL"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.Frame1.BackgroundImage = CType(resources.GetObject("Frame1.BackgroundImage"), System.Drawing.Image)
        Me.Frame1.Controls.Add(Me.optMCode)
        Me.Frame1.Controls.Add(Me.optAccName)
        Me.Frame1.Controls.Add(Me.OptOthers)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(360, 80)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(304, 35)
        Me.Frame1.TabIndex = 443
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'optMCode
        '
        Me.optMCode.BackColor = System.Drawing.Color.Transparent
        Me.optMCode.Checked = True
        Me.optMCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMCode.Location = New System.Drawing.Point(4, 12)
        Me.optMCode.Name = "optMCode"
        Me.optMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMCode.Size = New System.Drawing.Size(88, 15)
        Me.optMCode.TabIndex = 8
        Me.optMCode.TabStop = True
        Me.optMCode.Text = "CODE"
        '
        'optAccName
        '
        Me.optAccName.BackColor = System.Drawing.Color.Transparent
        Me.optAccName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAccName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAccName.Location = New System.Drawing.Point(107, 12)
        Me.optAccName.Name = "optAccName"
        Me.optAccName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAccName.Size = New System.Drawing.Size(88, 15)
        Me.optAccName.TabIndex = 7
        Me.optAccName.TabStop = True
        Me.optAccName.Text = "NAME"
        '
        'OptOthers
        '
        Me.OptOthers.BackColor = System.Drawing.Color.Transparent
        Me.OptOthers.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOthers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOthers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOthers.Location = New System.Drawing.Point(208, 12)
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOthers.Size = New System.Drawing.Size(88, 15)
        Me.OptOthers.TabIndex = 444
        Me.OptOthers.TabStop = True
        Me.OptOthers.Text = "OTHERS"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblSelection.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(104, 96)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelection.Size = New System.Drawing.Size(70, 18)
        Me.lblSelection.TabIndex = 442
        Me.lblSelection.Text = "SEARCH :"
        Me.lblSelection.Visible = False
        '
        'txtSelection
        '
        Me.txtSelection.AcceptsReturn = True
        Me.txtSelection.AutoSize = False
        Me.txtSelection.BackColor = System.Drawing.Color.Wheat
        Me.txtSelection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSelection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelection.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSelection.Location = New System.Drawing.Point(184, 88)
        Me.txtSelection.MaxLength = 25
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSelection.Size = New System.Drawing.Size(168, 24)
        Me.txtSelection.TabIndex = 441
        Me.txtSelection.Text = ""
        Me.txtSelection.Visible = False
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklist_Membername.Location = New System.Drawing.Point(504, 240)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(248, 225)
        Me.chklist_Membername.TabIndex = 422
        '
        'OUTSTAND_MEMREP_LIST
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1022, 692)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CHKLIST_SELECT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChKLIST_Memberstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.Frame1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "OUTSTAND_MEMREP_LIST"
        Me.Text = "OUTSTAND_MEMREP_LIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Private Sub OUTSTAND_MEMREP_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SYS_DATE_TIME()
            DTP_RECDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            MemberType_Load()
            Member_Master_Load()
            Call GETLIST()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub CHK_MEMBERCATEGORY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_MEMBERCATEGORY.CheckedChanged
        Try
            If CHK_MEMBERCATEGORY.Checked = True Then
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetSelected(Iteration, True)
                    chklist_Membername.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetItemChecked(Iteration, False)
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
    Private Sub MemberType_Load()
        Try
            Dim DT As New DataTable
            chklist_Membername.Items.Clear()
            ssql = " select isnull(subtypecode,'') as subtypecode,isnull(subtypedesc,'') as subtypedesc from subcategorymaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Membername.Items.Add(DT.Rows(Iteration).Item("subtypedesc") & Space(70) & "." & DT.Rows(Iteration).Item("subtypecode"))
                Next
            Else
                chklist_Membername.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Member_Master_Load()
        
    End Sub
    Private Sub cmdGExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
    Private Function MeValidate() As Boolean
        Try
            MeValidate = True
            Dim MTYPECODE(0) As String

            If chklist_Membername.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Membername.CheckedItems.Count - 1
                    MTYPECODE = Split(chklist_Membername.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
                'STR_TYPE = STR_TYPE & ")"
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
                For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
                    MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), ".")
                    STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            Else
                MsgBox("Please Select The Member Status Name", vbInformation)
                MeValidate = False
                Exit Function
            End If
   
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub CHK_SELECT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SELECT.CheckedChanged

        Try
            'If e.KeyCode = Keys.F9 Then
            If CHK_SELECT.Checked = True Then
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetSelected(Iteration, True)
                    CHKLIST_SELECT.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetItemChecked(Iteration, False)
                Next
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                sysdate = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            TXT_AMOUNT.Text = ""
            CHK_MEMBERCATEGORY.Checked = False
            CHK_STATUS.Checked = False
            CHK_SELECT.Checked = False
            DTP_RECDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            Call CHK_MEMBERCATEGORY_CheckedChanged(sender, e)
            Call CHK_STATUS_CheckedChanged(sender, e)
            TXT_AMOUNT.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Dim sqlstring, sqlstring1, HEADING As String
            Dim BILLDATE, RECPTDATE, ASON, BILL, DATES As String
            Dim DATES1 As DateTime
            Dim Viewer As New ReportViwer
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            Dim txtobj6 As TextObject
            Dim txtobj7 As TextObject
            Dim txtobj8 As TextObject
            Dim txtobj9 As TextObject
            Dim txtobj10 As TextObject
            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            DATES1 = DateAdd(DateInterval.Day, -45, DTPBILLDATE.Value)

            If MeValidate() = False Then Exit Sub
            If RDB_CREDIT_STOP_LIST.Checked = True Or RDB_OUTSNDING_LIST.Checked = True Then
                sqlstring1 = "EXEC cp_creditlimit_REP  '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "'"
            ElseIf RDB_defaulter_list.Checked = True Then
                sqlstring1 = "EXEC cp_creditlimit_REP  '" & Format(DATES1, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
            Else
                sqlstring1 = "EXEC cp_creditlimit_REP  '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
            End If
            gconnection.ExcuteStoreProcedure(sqlstring1)
            BILLDATE = Format(DTPBILLDATE.Value, "dd/MMM/yyyy")
            RECPTDATE = Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            If RDB_CREDIT_STOP_LIST.Checked = True Or RDB_OUTSNDING_LIST.Checked = True Or Rdo_arriarslist.Checked = True Or RDB_defaulter_list.Checked = True Then
                Dim r As New Cry_creditstop
                sqlstring = " SELECT MCODE,MNAME,MEM_NAME,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE,ISNULL(CONTACTNO,'') AS CONTACTNO,ISNULL(EMAIL,'') AS EMAIL FROM VIEW_MEM_CREDIT_DEFAULTER "
                sqlstring = sqlstring & " WHERE MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ")"

                If RDB_OUTSNDING_LIST.Checked = True Then
                    HEADING = "OUTSTANDING LIST"
                    ASON = "AS ON DATE :"
                    BILL = ""
                    DATES = ""
                ElseIf RDB_CREDIT_STOP_LIST.Checked = True Then
                    sqlstring = sqlstring & "  AND FLAG='C' "
                    HEADING = "CREDIT STOP  LIST"
                    ASON = "AS ON DATE :"
                    BILL = ""
                    DATES = ""
                ElseIf RDB_defaulter_list.Checked = True Then
                    sqlstring = sqlstring & "  AND ISNULL(USAGE,0) >=250"
                    HEADING = "DEFAULTER  LIST"
                    ASON = "BILL DATE"
                    BILL = "RECDATE :"
                    DATES = RECPTDATE
                Else
                    'sqlstring = sqlstring & "  AND ISNULL(USAGE,0) >=250"
                    HEADING = "ARREAR  LIST"
                    ASON = "BILL DATE"
                    BILL = "RECDATE :"
                    DATES = RECPTDATE
                End If

                If TXT_AMOUNT.Text <> "" Then
                    sqlstring = sqlstring & " AND ISNULL(USAGE,0)>=" & Val(TXT_AMOUNT.Text)
                End If

                ' sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno "
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj8 = r.ReportDefinition.ReportObjects("Text14")
                txtobj9 = r.ReportDefinition.ReportObjects("Text19")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                txtobj6 = r.ReportDefinition.ReportObjects("Text20")
                txtobj7 = r.ReportDefinition.ReportObjects("Text21")
                txtobj8 = r.ReportDefinition.ReportObjects("Text22")
                txtobj9 = r.ReportDefinition.ReportObjects("Text23")
                Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_CREDIT_DEFAULTER", r)
            ElseIf RDB_defaulter_list.Checked = True Then
                Dim r As New Cry_Defaulter
                sqlstring = " SELECT MCODE,MNAME,MEM_NAME,MEMBERTYPE,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE,"
                sqlstring = sqlstring & "ISNULL(DEBITDATE,'') AS DEBITDATE,ISNULL(CREDITDATE,'') AS CREDITDATE,isnull(PDR,0) AS PDR,ISNULL(PCR,0) AS PCR,"
                sqlstring = sqlstring & "ISNULL(CONTACTNO,'') AS CONTACTNO,ISNULL(EMAIL,'') AS EMAIL FROM VIEW_MEM_CREDIT_DEFAULTER"
                sqlstring = sqlstring & " WHERE  FLAG='D' AND MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "

                If TXT_AMOUNT.Text <> "" Then
                    sqlstring = sqlstring & "  AND ISNULL(CDR,0)-ISNULL(CCR,0)>=" & Val(TXT_AMOUNT.Text)
                End If
                BILLDATE = Format(DTPBILLDATE.Value, "dd/MMM/yyyy")
                RECPTDATE = Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MCODE "
                HEADING = "DEFAULTER  LIST"
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj8 = r.ReportDefinition.ReportObjects("Text13")
                txtobj9 = r.ReportDefinition.ReportObjects("Text14")
                ' txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                txtobj6 = r.ReportDefinition.ReportObjects("Text19")
                txtobj7 = r.ReportDefinition.ReportObjects("Text20")
                Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_CREDIT_DEFAULTER", r)
            End If
            txtobj1.Text = UCase(gCompanyname)
            txtobj8.Text = UCase(gCompanyAddress(1))
            txtobj9.Text = UCase(gCompanyAddress(2))
            txtobj3.Text = Mid(gFinancialyearStart, 7, 4) & " - " & Mid(gFinancialYearEnd, 7, 4)
            txtobj4.Text = UCase(gUsername)
            txtobj5.Text = UCase(HEADING)
            txtobj6.Text = BILLDATE
            txtobj7.Text = DATES
            txtobj8.Text = ASON
            txtobj9.Text = BILL

            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Hide()
    End Sub
    Private Sub OUTSTAND_MEMREP_LIST_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
                If CHK_SELECT.Checked = True Then
                    CHK_SELECT.Checked = False
                Else
                    CHK_SELECT.Checked = True
                End If
                'If CHK_MEMBERCATEGORY.Checked = False Then
                '    CHK_MEMBERCATEGORY.Checked = False
                'Else
                '    CHK_MEMBERCATEGORY.Checked = True
                'End If
                'CATEGORY SELECT
                If CHK_MEMBERCATEGORY.Checked = True Then
                    CHK_MEMBERCATEGORY.Checked = False
                Else
                    CHK_MEMBERCATEGORY.Checked = True
                End If
                'STATUS SELECT
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
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_AMOUNT.TextChanged

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_AMOUNT.KeyPress
        getNumeric(e)
    End Sub

    Private Sub CHKLIST_SELECT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKLIST_SELECT.SelectedIndexChanged

    End Sub
    Private Sub CHKLIST_SELECT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CHKLIST_SELECT.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                Dim search As New frmListSearch
                search.listbox = CHKLIST_SELECT
                search.Text = "Member Search"
                search.ShowDialog(Me)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chklist_Membername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_Membername.SelectedIndexChanged

    End Sub
    Private Sub chklist_Membername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chklist_Membername.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                Dim search As New frmListSearch
                search.listbox = chklist_Membername
                search.Text = "Type Search"
                search.ShowDialog(Me)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChKLIST_Memberstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChKLIST_Memberstatus.SelectedIndexChanged

    End Sub
    Private Sub ChKLIST_Memberstatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChKLIST_Memberstatus.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                Dim search As New frmListSearch
                search.listbox = ChKLIST_Memberstatus
                search.Text = "Status Search"
                search.ShowDialog(Me)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sqlstring, HEADING As String
            Dim _export As New EXPORT
            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            If MeValidate() = False Then Exit Sub
            gconnection.ExcuteStoreProcedure("EXEC cp_creditlimit_REP  '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'")
            If RDB_CREDIT_STOP_LIST.Checked = True Or RDB_OUTSNDING_LIST.Checked = True Or Rdo_arriarslist.Checked = True Then
                Dim r As New Cry_creditstop
                sqlstring = " SELECT MCODE,MNAME,MEM_NAME,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE FROM VIEW_MEM_CREDIT_DEFAULTER "
                sqlstring = sqlstring & " WHERE MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "

                If RDB_OUTSNDING_LIST.Checked = True Then
                    HEADING = "OUTSTANDING LIST"
                ElseIf RDB_CREDIT_STOP_LIST.Checked = True Then
                    sqlstring = sqlstring & "  AND FLAG='C' "
                    HEADING = "CREDIT STOP  LIST"
                Else
                    HEADING = "ARREAR LIST"
                End If

                If TXT_AMOUNT.Text <> "" Then
                    sqlstring = sqlstring & " AND ISNULL(USAGE,0)>=" & Val(TXT_AMOUNT.Text)
                End If
                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MCODE "

                _export.TABLENAME = "VIEW_MEM_CREDIT_DEFAULTER"
                Call _export.export_excel(sqlstring)
                _export.Show()
                Exit Sub
            ElseIf RDB_defaulter_list.Checked = True Then
                Dim r As New Cry_Defaulter
                sqlstring = " SELECT MCODE,MNAME,MEM_NAME,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE FROM VIEW_MEM_CREDIT_DEFAULTER "
                sqlstring = sqlstring & " WHERE  FLAG='D' AND MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
                If TXT_AMOUNT.Text <> "" Then
                    sqlstring = sqlstring & "  AND ISNULL(CDR,0)-ISNULL(CCR,0)>=" & Val(TXT_AMOUNT.Text)
                End If
                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MCODE "
                HEADING = "DEFAULTER  LIST"
                _export.TABLENAME = "VIEW_MEM_CREDIT_DEFAULTER"
                Call _export.export_excel(sqlstring)
                _export.Show()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RDB_OUTSNDING_LIST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_OUTSNDING_LIST.CheckedChanged
        If RDB_OUTSNDING_LIST.Checked = True Then
            Label10.Text = "AS ON DATE"
            DTP_RECDATE.Enabled = False
        Else
            Label10.Text = "BILL DATE"
            DTP_RECDATE.Enabled = True
        End If
    End Sub

    Private Sub Rdo_arriarslist_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdo_arriarslist.CheckedChanged
        If Rdo_arriarslist.Checked = True Then
            Label10.Text = "BILL DATE"
            DTP_RECDATE.Enabled = True
        Else
            Label10.Text = "AS ON DATE"
            DTP_RECDATE.Enabled = True
        End If
    End Sub

    Private Sub DTPBILLDATE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPBILLDATE.ValueChanged
        'DTP_RECDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
        'If Rdo_arriarslist.Checked = True Then
        '    If Month(DTPBILLDATE.Text) = "4" Then
        '        DTP_RECDATE.Text = "31/05/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "5" Then
        '        DTP_RECDATE.Text = "30/06/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "6" Then
        '        DTP_RECDATE.Text = "31/07/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "7" Then
        '        DTP_RECDATE.Text = "31/08/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "8" Then
        '        DTP_RECDATE.Text = "30/09/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "9" Then
        '        DTP_RECDATE.Text = "31/10/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "10" Then
        '        DTP_RECDATE.Text = "30/11/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "11" Then
        '        DTP_RECDATE.Text = "31/12/" & Mid(gFinancialyearStart, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "12" Then
        '        DTP_RECDATE.Text = "31/01/" & Mid(gFinancialYearEnd, 7, 4)
        '    End If
        '    If (Year(gFinancialYearEnd) Mod 4) = "0" Then
        '        If Month(DTPBILLDATE.Text) = "1" Then
        '            DTP_RECDATE.Text = "29/02/" & Mid(gFinancialYearEnd, 7, 4)
        '        End If
        '    Else
        '        If Month(DTPBILLDATE.Text) = "1" Then
        '            DTP_RECDATE.Text = "28/02/" & Mid(gFinancialYearEnd, 7, 4)
        '        End If
        '    End If
        '    If Month(DTPBILLDATE.Text) = "2" Then
        '        DTP_RECDATE.Text = "31/03/" & Mid(gFinancialYearEnd, 7, 4)
        '    End If
        '    If Month(DTPBILLDATE.Text) = "3" Then
        '        DTP_RECDATE.Text = "30/04/" & Mid(gFinancialYearEnd, 7, 4)
        '    End If
        'End If
        'Dim DateAdd As String
        'DateAdd = DTPBILLDATE.Value
        'DTP_RECDATE.Value = DateAdd

    End Sub

    Private Sub DTPBILLDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPBILLDATE.KeyPress
        Dim dt As DateTime
        'Dim yesterday As DateTime = DateTime.Today.AddDays(-1)
        'dt = DateTime.Today.AddDays(30)
        'DTP_RECDATE.Value = Format(dt, "dd/MM/yyyy")
    End Sub

    Private Sub DTP_RECDATE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_RECDATE.ValueChanged

    End Sub

    Private Sub DTPBILLDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPBILLDATE.Leave


    End Sub

    Private Sub DTPBILLDATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTPBILLDATE.KeyDown

    End Sub

    Private Sub DTPBILLDATE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPBILLDATE.Validated

    End Sub

    Private Sub DTP_RECDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTP_RECDATE.KeyPress

    End Sub

    Private Sub DTP_RECDATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTP_RECDATE.KeyDown

    End Sub

    Private Sub DTP_RECDATE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTP_RECDATE.Validated

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub optMCode_CheckedChanged(ByVal eventSender As System.Object, ByVal e As System.EventArgs) Handles optMCode.CheckedChanged
        If eventSender.Checked Then
            'cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub txtSelection_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.TextChanged
        If Trim(txtSelection.Text) <> "" Then
            Call txtSelection_Leave(eventSender, eventArgs)
        End If
    End Sub

    Private Sub txtSelection_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSelection.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            CHKLIST_SELECT.Focus()
        End If
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            'Unload(SideLedgerList)
            SideLedgerList = Nothing
        End If
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtSelection_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSelection.Leave
        Try
            Dim vFormatstring As String
            If OptOthers.Checked Then
                Call GETLIST()
            Else
                vFormatstring = "MEMBER NAME                                                    | MEMBER CODE "
                'GETLIST.ClearRange(1, 1, -1, -1, True)
                Call GETLIST()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub GETLIST()
        Try
            Dim DT As New DataTable
            CHKLIST_SELECT.Items.Clear()
            ssql = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster order by mcode,mname asc"
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
                Next
            Else
                CHKLIST_SELECT.Items.Clear()
            End If
            'LIST SEARCH

            'Dim loopindex As Integer
            'If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            '    If CHKLIST_SELECT.DataRowCnt < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
            '        CHKLIST_SELECT.MaxRows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            '    End If
            '    For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
            '        grdSelectionList.Col = 1
            '        grdSelectionList.Row = loopindex + 1
            '        grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("Subcode"))
            '        grdSelectionList.Col = 2
            '        grdSelectionList.Row = loopindex + 1
            '        grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName"))
            '    Next
            'Else
            '    'lblAmount.Text = ""
            '    MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            '    txtSelection.Text = ""
            '    FormUnload = True
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frame1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame1.Enter

    End Sub

    Private Sub lblSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSelection.Click

    End Sub


    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub RDB_CREDIT_STOP_LIST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_CREDIT_STOP_LIST.CheckedChanged
        If RDB_CREDIT_STOP_LIST.Checked = True Then
            Label10.Text = "AS ON DATE"
            DTP_RECDATE.Enabled = False
        Else
            Label10.Text = "BILL DATE"
            DTP_RECDATE.Enabled = True
        End If
    End Sub

    Private Sub RDB_defaulter_list_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_defaulter_list.CheckedChanged
        If RDB_defaulter_list.Checked = True Then
            Label10.Text = "BILL DATE"
            DTP_RECDATE.Enabled = True
        Else
            Label10.Text = "AS ON DATE"
            DTP_RECDATE.Enabled = True
        End If
    End Sub
End Class
