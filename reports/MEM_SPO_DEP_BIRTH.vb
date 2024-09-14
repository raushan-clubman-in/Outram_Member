Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
'Imports CrystalDecisions.reportsource
'Imports CrystalDecisions.shared
'Imports CrystalDecisions.web
Imports CrystalDecisions.CrystalReports.Engine
Public Class MEM_SPO_DEP_BIRTH
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5 As String
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim dr, dr1, dr2, dr4 As DataRow
    Dim txtobj1 As TextObject
    Public TempString(2), catecode As String

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Public WithEvents LBL_AGETO As System.Windows.Forms.Label
    Friend WithEvents TXT_AGETO As System.Windows.Forms.TextBox
    Public WithEvents LBL_AGEFROM As System.Windows.Forms.Label
    Friend WithEvents TXT_AGEFROM As System.Windows.Forms.TextBox
    Public WithEvents LBL_FROMDATE As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents DTP_FROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_TODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RAD_SPO As System.Windows.Forms.RadioButton
    Friend WithEvents RAD_DEp As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RAD_PRNDEP As System.Windows.Forms.RadioButton
    Friend WithEvents RAD_PRNCLUB As System.Windows.Forms.RadioButton
    Friend WithEvents RAD_PRNSPOUSE As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_FILTER_FIELD As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents RNDDOB As System.Windows.Forms.RadioButton
    Friend WithEvents RNDWEDDING As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_TO As System.Windows.Forms.Label
    Friend WithEvents DTP_DOWFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_DOWTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Opt_Age25_30 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Age30_40 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Age50_60 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Age40_50 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Age60_70 As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Age70_above As System.Windows.Forms.RadioButton
    Friend WithEvents DTP_MONTH As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_send As System.Windows.Forms.Button
    Friend WithEvents txt_msg As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MEM_SPO_DEP_BIRTH))
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_print = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_send = New System.Windows.Forms.Button
        Me.Opt_Age70_above = New System.Windows.Forms.RadioButton
        Me.Opt_Age60_70 = New System.Windows.Forms.RadioButton
        Me.Opt_Age40_50 = New System.Windows.Forms.RadioButton
        Me.Opt_Age50_60 = New System.Windows.Forms.RadioButton
        Me.Opt_Age30_40 = New System.Windows.Forms.RadioButton
        Me.Opt_Age25_30 = New System.Windows.Forms.RadioButton
        Me.Chk_FILTER_FIELD = New System.Windows.Forms.CheckedListBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DTP_DATE = New System.Windows.Forms.DateTimePicker
        Me.DTP_MONTH = New System.Windows.Forms.DateTimePicker
        Me.LBL_FROMDATE = New System.Windows.Forms.Label
        Me.LBL_TO = New System.Windows.Forms.Label
        Me.RNDWEDDING = New System.Windows.Forms.RadioButton
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.LBL_AGETO = New System.Windows.Forms.Label
        Me.TXT_AGETO = New System.Windows.Forms.TextBox
        Me.LBL_AGEFROM = New System.Windows.Forms.Label
        Me.TXT_AGEFROM = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Tomcode = New System.Windows.Forms.TextBox
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RAD_SPO = New System.Windows.Forms.RadioButton
        Me.RAD_DEp = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RNDDOB = New System.Windows.Forms.RadioButton
        Me.CmdClear = New System.Windows.Forms.Button
        Me.txt_Tomname = New System.Windows.Forms.TextBox
        Me.DTP_DOWFROM = New System.Windows.Forms.DateTimePicker
        Me.DTP_DOWTO = New System.Windows.Forms.DateTimePicker
        Me.DTP_TODATE = New System.Windows.Forms.DateTimePicker
        Me.DTP_FROMDATE = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RAD_PRNDEP = New System.Windows.Forms.RadioButton
        Me.RAD_PRNCLUB = New System.Windows.Forms.RadioButton
        Me.RAD_PRNSPOUSE = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_msg = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ssgrid = New AxFPUSpreadADO.AxfpSpread
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 25)
        Me.Label2.TabIndex = 436
        Me.Label2.Text = "MEMBER  DATE OF BIRTH AND WEDDING "
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.Location = New System.Drawing.Point(112, 408)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 570
        Me.cmd_view.Text = "View [F8]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(448, 408)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 575
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.ForeColor = System.Drawing.Color.White
        Me.cmd_print.Image = CType(resources.GetObject("cmd_print.Image"), System.Drawing.Image)
        Me.cmd_print.Location = New System.Drawing.Point(224, 408)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_print.TabIndex = 587
        Me.cmd_print.Text = "Print [F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btn_send)
        Me.GroupBox1.Controls.Add(Me.Opt_Age70_above)
        Me.GroupBox1.Controls.Add(Me.Opt_Age60_70)
        Me.GroupBox1.Controls.Add(Me.Opt_Age40_50)
        Me.GroupBox1.Controls.Add(Me.Opt_Age50_60)
        Me.GroupBox1.Controls.Add(Me.Opt_Age30_40)
        Me.GroupBox1.Controls.Add(Me.Opt_Age25_30)
        Me.GroupBox1.Controls.Add(Me.Chk_FILTER_FIELD)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.RNDWEDDING)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.GroupBox1.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox1.Controls.Add(Me.LBL_AGETO)
        Me.GroupBox1.Controls.Add(Me.TXT_AGETO)
        Me.GroupBox1.Controls.Add(Me.LBL_AGEFROM)
        Me.GroupBox1.Controls.Add(Me.TXT_AGEFROM)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Tomcode)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.txt_mcode)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RNDDOB)
        Me.GroupBox1.Controls.Add(Me.cmd_view)
        Me.GroupBox1.Controls.Add(Me.cmd_Exit)
        Me.GroupBox1.Controls.Add(Me.cmd_print)
        Me.GroupBox1.Controls.Add(Me.CmdClear)
        Me.GroupBox1.Controls.Add(Me.txt_Tomname)
        Me.GroupBox1.Controls.Add(Me.DTP_DOWFROM)
        Me.GroupBox1.Controls.Add(Me.DTP_DOWTO)
        Me.GroupBox1.Controls.Add(Me.DTP_TODATE)
        Me.GroupBox1.Controls.Add(Me.DTP_FROMDATE)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 448)
        Me.GroupBox1.TabIndex = 588
        Me.GroupBox1.TabStop = False
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.SystemColors.Menu
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_send.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.White
        Me.btn_send.Image = CType(resources.GetObject("btn_send.Image"), System.Drawing.Image)
        Me.btn_send.Location = New System.Drawing.Point(560, 408)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(88, 32)
        Me.btn_send.TabIndex = 636
        Me.btn_send.Text = "FILL SMS"
        '
        'Opt_Age70_above
        '
        Me.Opt_Age70_above.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age70_above.Location = New System.Drawing.Point(448, 200)
        Me.Opt_Age70_above.Name = "Opt_Age70_above"
        Me.Opt_Age70_above.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age70_above.TabIndex = 634
        Me.Opt_Age70_above.Text = "AGE 70 ABOVE"
        '
        'Opt_Age60_70
        '
        Me.Opt_Age60_70.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age60_70.Location = New System.Drawing.Point(448, 168)
        Me.Opt_Age60_70.Name = "Opt_Age60_70"
        Me.Opt_Age60_70.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age60_70.TabIndex = 633
        Me.Opt_Age60_70.Text = "AGE 60 TO 70"
        '
        'Opt_Age40_50
        '
        Me.Opt_Age40_50.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age40_50.Location = New System.Drawing.Point(448, 104)
        Me.Opt_Age40_50.Name = "Opt_Age40_50"
        Me.Opt_Age40_50.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age40_50.TabIndex = 632
        Me.Opt_Age40_50.Text = "AGE 40 TO 50"
        '
        'Opt_Age50_60
        '
        Me.Opt_Age50_60.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age50_60.Location = New System.Drawing.Point(448, 136)
        Me.Opt_Age50_60.Name = "Opt_Age50_60"
        Me.Opt_Age50_60.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age50_60.TabIndex = 631
        Me.Opt_Age50_60.Text = "AGE 50 TO 60"
        '
        'Opt_Age30_40
        '
        Me.Opt_Age30_40.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age30_40.Location = New System.Drawing.Point(448, 72)
        Me.Opt_Age30_40.Name = "Opt_Age30_40"
        Me.Opt_Age30_40.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age30_40.TabIndex = 630
        Me.Opt_Age30_40.Text = "AGE 30 TO 40"
        '
        'Opt_Age25_30
        '
        Me.Opt_Age25_30.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Age25_30.Location = New System.Drawing.Point(448, 40)
        Me.Opt_Age25_30.Name = "Opt_Age25_30"
        Me.Opt_Age25_30.Size = New System.Drawing.Size(184, 15)
        Me.Opt_Age25_30.TabIndex = 629
        Me.Opt_Age25_30.Text = "AGE 25 TO 30"
        '
        'Chk_FILTER_FIELD
        '
        Me.Chk_FILTER_FIELD.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_FILTER_FIELD.Location = New System.Drawing.Point(112, 32)
        Me.Chk_FILTER_FIELD.Name = "Chk_FILTER_FIELD"
        Me.Chk_FILTER_FIELD.Size = New System.Drawing.Size(328, 225)
        Me.Chk_FILTER_FIELD.TabIndex = 612
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DTP_DATE)
        Me.GroupBox4.Controls.Add(Me.DTP_MONTH)
        Me.GroupBox4.Controls.Add(Me.LBL_FROMDATE)
        Me.GroupBox4.Controls.Add(Me.LBL_TO)
        Me.GroupBox4.Location = New System.Drawing.Point(112, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 56)
        Me.GroupBox4.TabIndex = 628
        Me.GroupBox4.TabStop = False
        '
        'DTP_DATE
        '
        Me.DTP_DATE.CustomFormat = "dd"
        Me.DTP_DATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DATE.Location = New System.Drawing.Point(232, 16)
        Me.DTP_DATE.Name = "DTP_DATE"
        Me.DTP_DATE.Size = New System.Drawing.Size(64, 21)
        Me.DTP_DATE.TabIndex = 620
        '
        'DTP_MONTH
        '
        Me.DTP_MONTH.CustomFormat = "MMM"
        Me.DTP_MONTH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_MONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_MONTH.Location = New System.Drawing.Point(80, 16)
        Me.DTP_MONTH.Name = "DTP_MONTH"
        Me.DTP_MONTH.Size = New System.Drawing.Size(64, 21)
        Me.DTP_MONTH.TabIndex = 619
        '
        'LBL_FROMDATE
        '
        Me.LBL_FROMDATE.AutoSize = True
        Me.LBL_FROMDATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_FROMDATE.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBL_FROMDATE.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FROMDATE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_FROMDATE.Location = New System.Drawing.Point(8, 16)
        Me.LBL_FROMDATE.Name = "LBL_FROMDATE"
        Me.LBL_FROMDATE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_FROMDATE.Size = New System.Drawing.Size(69, 18)
        Me.LBL_FROMDATE.TabIndex = 616
        Me.LBL_FROMDATE.Text = "MONTH : "
        '
        'LBL_TO
        '
        Me.LBL_TO.AutoSize = True
        Me.LBL_TO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TO.ForeColor = System.Drawing.Color.Black
        Me.LBL_TO.Location = New System.Drawing.Point(168, 16)
        Me.LBL_TO.Name = "LBL_TO"
        Me.LBL_TO.Size = New System.Drawing.Size(61, 18)
        Me.LBL_TO.TabIndex = 617
        Me.LBL_TO.Text = "DATE : "
        '
        'RNDWEDDING
        '
        Me.RNDWEDDING.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RNDWEDDING.Location = New System.Drawing.Point(304, 272)
        Me.RNDWEDDING.Name = "RNDWEDDING"
        Me.RNDWEDDING.Size = New System.Drawing.Size(184, 15)
        Me.RNDWEDDING.TabIndex = 627
        Me.RNDWEDDING.Text = "DATE OF WEDDING"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(112, 232)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(336, 21)
        Me.txtCategory.TabIndex = 626
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(112, 8)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(168, 16)
        Me.chk_PrintAll.TabIndex = 625
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp1.Image = CType(resources.GetObject("cmd_MemberCodeHelp1.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(1008, 190)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberCodeHelp1.TabIndex = 624
        Me.cmd_MemberCodeHelp1.Visible = False
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(1008, 248)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 623
        Me.cmd_MemberCodeHelp.Visible = False
        '
        'LBL_AGETO
        '
        Me.LBL_AGETO.AutoSize = True
        Me.LBL_AGETO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_AGETO.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBL_AGETO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AGETO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_AGETO.Location = New System.Drawing.Point(528, 8)
        Me.LBL_AGETO.Name = "LBL_AGETO"
        Me.LBL_AGETO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_AGETO.Size = New System.Drawing.Size(61, 18)
        Me.LBL_AGETO.TabIndex = 622
        Me.LBL_AGETO.Text = "AGE TO "
        '
        'TXT_AGETO
        '
        Me.TXT_AGETO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_AGETO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AGETO.Location = New System.Drawing.Point(960, 56)
        Me.TXT_AGETO.Name = "TXT_AGETO"
        Me.TXT_AGETO.Size = New System.Drawing.Size(72, 22)
        Me.TXT_AGETO.TabIndex = 621
        Me.TXT_AGETO.Text = ""
        Me.TXT_AGETO.Visible = False
        '
        'LBL_AGEFROM
        '
        Me.LBL_AGEFROM.AutoSize = True
        Me.LBL_AGEFROM.BackColor = System.Drawing.Color.Transparent
        Me.LBL_AGEFROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBL_AGEFROM.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AGEFROM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_AGEFROM.Location = New System.Drawing.Point(448, 8)
        Me.LBL_AGEFROM.Name = "LBL_AGEFROM"
        Me.LBL_AGEFROM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBL_AGEFROM.Size = New System.Drawing.Size(77, 18)
        Me.LBL_AGEFROM.TabIndex = 620
        Me.LBL_AGEFROM.Text = "AGE FROM "
        '
        'TXT_AGEFROM
        '
        Me.TXT_AGEFROM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_AGEFROM.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AGEFROM.Location = New System.Drawing.Point(960, 80)
        Me.TXT_AGEFROM.Name = "TXT_AGEFROM"
        Me.TXT_AGEFROM.Size = New System.Drawing.Size(72, 22)
        Me.TXT_AGEFROM.TabIndex = 619
        Me.TXT_AGEFROM.Text = ""
        Me.TXT_AGEFROM.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 18)
        Me.Label9.TabIndex = 611
        Me.Label9.Text = "CATEGORY "
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(864, 192)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(168, 22)
        Me.txt_Tomcode.TabIndex = 607
        Me.txt_Tomcode.Text = ""
        Me.txt_Tomcode.Visible = False
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(920, 232)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(112, 22)
        Me.txt_mname.TabIndex = 606
        Me.txt_mname.Text = ""
        Me.txt_mname.Visible = False
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(864, 144)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(168, 22)
        Me.txt_mcode.TabIndex = 604
        Me.txt_mcode.Text = ""
        Me.txt_mcode.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RAD_SPO)
        Me.GroupBox2.Controls.Add(Me.RAD_DEp)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(728, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 40)
        Me.GroupBox2.TabIndex = 614
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order By"
        Me.GroupBox2.Visible = False
        '
        'RAD_SPO
        '
        Me.RAD_SPO.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_SPO.Location = New System.Drawing.Point(16, 17)
        Me.RAD_SPO.Name = "RAD_SPO"
        Me.RAD_SPO.Size = New System.Drawing.Size(104, 15)
        Me.RAD_SPO.TabIndex = 0
        Me.RAD_SPO.Text = "SPOUSE"
        Me.RAD_SPO.Visible = False
        '
        'RAD_DEp
        '
        Me.RAD_DEp.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_DEp.Location = New System.Drawing.Point(136, 16)
        Me.RAD_DEp.Name = "RAD_DEp"
        Me.RAD_DEp.Size = New System.Drawing.Size(112, 15)
        Me.RAD_DEp.TabIndex = 0
        Me.RAD_DEp.Text = "DEPENDENT"
        Me.RAD_DEp.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(912, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 609
        Me.Label5.Text = "To"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(912, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 608
        Me.Label4.Text = "From"
        Me.Label4.Visible = False
        '
        'RNDDOB
        '
        Me.RNDDOB.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RNDDOB.Location = New System.Drawing.Point(120, 272)
        Me.RNDDOB.Name = "RNDDOB"
        Me.RNDDOB.Size = New System.Drawing.Size(184, 15)
        Me.RNDDOB.TabIndex = 2
        Me.RNDDOB.Text = "DATE OF BIRTHDAY"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(336, 408)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 591
        Me.CmdClear.Text = "Clear[F6]"
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(848, 224)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(168, 22)
        Me.txt_Tomname.TabIndex = 610
        Me.txt_Tomname.Text = ""
        Me.txt_Tomname.Visible = False
        '
        'DTP_DOWFROM
        '
        Me.DTP_DOWFROM.CustomFormat = "dd/MM/yyyy"
        Me.DTP_DOWFROM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DOWFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DOWFROM.Location = New System.Drawing.Point(-24, 368)
        Me.DTP_DOWFROM.Name = "DTP_DOWFROM"
        Me.DTP_DOWFROM.Size = New System.Drawing.Size(104, 21)
        Me.DTP_DOWFROM.TabIndex = 620
        Me.DTP_DOWFROM.Visible = False
        '
        'DTP_DOWTO
        '
        Me.DTP_DOWTO.CustomFormat = "dd/MM/yyyy"
        Me.DTP_DOWTO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DOWTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DOWTO.Location = New System.Drawing.Point(-16, 408)
        Me.DTP_DOWTO.Name = "DTP_DOWTO"
        Me.DTP_DOWTO.Size = New System.Drawing.Size(96, 21)
        Me.DTP_DOWTO.TabIndex = 619
        Me.DTP_DOWTO.Visible = False
        '
        'DTP_TODATE
        '
        Me.DTP_TODATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_TODATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_TODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_TODATE.Location = New System.Drawing.Point(-8, 304)
        Me.DTP_TODATE.Name = "DTP_TODATE"
        Me.DTP_TODATE.Size = New System.Drawing.Size(96, 21)
        Me.DTP_TODATE.TabIndex = 615
        Me.DTP_TODATE.Visible = False
        '
        'DTP_FROMDATE
        '
        Me.DTP_FROMDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_FROMDATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FROMDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FROMDATE.Location = New System.Drawing.Point(-24, 328)
        Me.DTP_FROMDATE.Name = "DTP_FROMDATE"
        Me.DTP_FROMDATE.Size = New System.Drawing.Size(104, 21)
        Me.DTP_FROMDATE.TabIndex = 618
        Me.DTP_FROMDATE.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RAD_PRNDEP)
        Me.GroupBox3.Controls.Add(Me.RAD_PRNCLUB)
        Me.GroupBox3.Controls.Add(Me.RAD_PRNSPOUSE)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(792, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 40)
        Me.GroupBox3.TabIndex = 613
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report On"
        Me.GroupBox3.Visible = False
        '
        'RAD_PRNDEP
        '
        Me.RAD_PRNDEP.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_PRNDEP.Location = New System.Drawing.Point(240, 16)
        Me.RAD_PRNDEP.Name = "RAD_PRNDEP"
        Me.RAD_PRNDEP.Size = New System.Drawing.Size(104, 15)
        Me.RAD_PRNDEP.TabIndex = 1
        Me.RAD_PRNDEP.Text = "DEPENDENT"
        Me.RAD_PRNDEP.Visible = False
        '
        'RAD_PRNCLUB
        '
        Me.RAD_PRNCLUB.Checked = True
        Me.RAD_PRNCLUB.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_PRNCLUB.Location = New System.Drawing.Point(16, 17)
        Me.RAD_PRNCLUB.Name = "RAD_PRNCLUB"
        Me.RAD_PRNCLUB.Size = New System.Drawing.Size(104, 15)
        Me.RAD_PRNCLUB.TabIndex = 0
        Me.RAD_PRNCLUB.TabStop = True
        Me.RAD_PRNCLUB.Text = "CLUB MSNO"
        '
        'RAD_PRNSPOUSE
        '
        Me.RAD_PRNSPOUSE.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_PRNSPOUSE.Location = New System.Drawing.Point(128, 16)
        Me.RAD_PRNSPOUSE.Name = "RAD_PRNSPOUSE"
        Me.RAD_PRNSPOUSE.Size = New System.Drawing.Size(96, 15)
        Me.RAD_PRNSPOUSE.TabIndex = 0
        Me.RAD_PRNSPOUSE.Text = "SPOUSE"
        Me.RAD_PRNSPOUSE.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.txt_msg)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.ssgrid)
        Me.GroupBox5.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(704, 368)
        Me.GroupBox5.TabIndex = 614
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 641
        Me.Label1.Text = "Message Format"
        '
        'txt_msg
        '
        Me.txt_msg.Location = New System.Drawing.Point(176, 288)
        Me.txt_msg.Multiline = True
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(440, 32)
        Me.txt_msg.TabIndex = 640
        Me.txt_msg.Text = ""
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Menu
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(448, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 32)
        Me.Button4.TabIndex = 639
        Me.Button4.Text = "Exit"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Menu
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(312, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 32)
        Me.Button3.TabIndex = 638
        Me.Button3.Text = "Clear"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Menu
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(176, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 637
        Me.Button2.Text = "SEND SMS"
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(48, 24)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(600, 248)
        Me.ssgrid.TabIndex = 636
        '
        'MEM_SPO_DEP_BIRTH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 590)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.KeyPreview = True
        Me.Name = "MEM_SPO_DEP_BIRTH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEM_SPO_DEP_BIRTH"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FillMEMBERTYPE()
        Dim i As Integer
        Chk_FILTER_FIELD.Items.Clear()
        sqlstring = "SELECT ISNULL(SUBTYPECODE,'') AS MEMBERTYPE,ISNULL(SUBTYPEDESC,'') AS TYPEDESC FROM SUBCATEGORYMASTER"
        gconnection.getDataSet(sqlstring, "MEMBERTYPE")
        If gdataset.Tables("MEMBERTYPE").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
                With gdataset.Tables("MEMBERTYPE").Rows(i)
                    'chk_Filter_Field.Items.Add(Trim(.Item("MEMBERTYPE")) & "==>" & .Item("TYPEDESC"))
                    Chk_FILTER_FIELD.Items.Add(Trim(.Item("TYPEDESC")))
                End With
            Next i
        End If
        Chk_FILTER_FIELD.Sorted = True
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        If (Chk_FILTER_FIELD.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Member Type Items")
            Exit Sub
        End If
        gPrint = False
        If Opt_Age25_30.Checked = True Or Opt_Age30_40.Checked = True Or Opt_Age40_50.Checked = True Or Opt_Age50_60.Checked = True Or Opt_Age60_70.Checked = True Or Opt_Age70_above.Checked = True Then
            Call Reportdetails_agelimit()
        Else
            Call Reportdetails_summary1()
        End If
    End Sub
    Public Function Reportdetails_summary()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim PHEADING As String
        Dim MCODE As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim TAMOUNT As Double
        Dim MEMBERTYPE() As String
        pageno = 1
        PHEADING = "MEMBER DATE OF BIRTH REPORT"

        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.Write(Chr(15))
            If RAD_PRNDEP.Checked = True Then
                sqlstring = "SELECT ISNULL(A.MCODE,'') AS MCODE,ISNULL(A.MNAME,'') AS MNAME,ISNULL(A.SPOUSE,'') AS SPOUSE,ISNULL(B.CHILD_NM,'') AS CHILD_NM,ISNULL(B.CHILD_DOB,'') AS DOB,isnull(A.CONTPHONE1,'') AS CONTPHONE FROM MEMBERMASTER A LEFT OUTER JOIN MEMDET B ON A.MCODE = B.MEM_CODE AND B.TYPE0='CHLD' WHERE MONTH(B.CHILD_DOB) BETWEEN " & Month(DTP_FROMDATE.Value) & " AND " & Month(DTP_TODATE.Value) & " AND DAY(B.CHILD_DOB) BETWEEN " & Format(DTP_FROMDATE.Value, "dd") & " AND " & Format(DTP_TODATE.Value, "dd") & " AND ISNULL(B.CHILD_DOB,'')<>'' "
            ElseIf RAD_PRNSPOUSE.Checked = True Then
                sqlstring = "SELECT ISNULL(A.MCODE,'') AS MCODE,ISNULL(A.MNAME,'') AS MNAME,ISNULL(A.SPOUSE,'') AS SPOUSE,ISNULL(A.WIFEDOB,'') AS DOB,isnull(A.CONTPHONE1,'') AS CONTPHONE FROM MEMBERMASTER A WHERE MONTH(A.WIFEDOB) BETWEEN " & Month(DTP_FROMDATE.Value) & " AND " & Month(DTP_TODATE.Value) & " AND DAY(WIFEDOB) BETWEEN " & Format(DTP_FROMDATE.Value, "dd") & " AND " & Format(DTP_TODATE.Value, "dd")
            Else
                sqlstring = "SELECT ISNULL(A.MCODE,'') AS MCODE,ISNULL(A.MNAME,'') AS MNAME,ISNULL(A.SPOUSE,'') AS SPOUSE,ISNULL(A.DOB,'') AS DOB,isnull(A.CONTPHONE1,'') AS CONTPHONE FROM MEMBERMASTER A WHERE MONTH(DOB) BETWEEN " & Month(DTP_FROMDATE.Value) & " AND " & Month(DTP_TODATE.Value) & " AND DAY(DOB) BETWEEN " & Format(DTP_FROMDATE.Value, "dd") & " AND " & Format(DTP_TODATE.Value, "dd")
            End If

            If (Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "") Or Chk_FILTER_FIELD.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND "
            End If

            If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = sqlstring & " A.MCODE BETWEEN '" & Trim(txt_mcode.Text) & "' AND '" & Trim(txt_Tomcode.Text) & "'"
            End If
            If (Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "") And Chk_FILTER_FIELD.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND "
            End If

            If Chk_FILTER_FIELD.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " A.MEMBERTYPECODE IN ("
                For I = 0 To Chk_FILTER_FIELD.CheckedItems.Count - 1
                    MEMBERTYPE = Split(Chk_FILTER_FIELD.CheckedItems(I), "==>")
                    sqlstring = sqlstring & "'" & MEMBERTYPE(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            End If

            If RAD_SPO.Checked = True Then
                sqlstring = sqlstring & " ORDER BY A.SPOUSE "
            ElseIf RAD_DEp.Checked = True Then
                sqlstring = sqlstring & " ORDER BY B.CHILD_NM "
            Else
                'sqlstring = sqlstring & " ORDER BY A.MCODE "
                sqlstring = sqlstring & " ORDER BY A.prefixmcode,A.msorderno,A.mcode asc "
            End If
            gconnection.getDataSet(sqlstring, "MEMBER")
            Dim C As Integer
            C = 0
            MCODE = ""
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                Call PrintHeader(PHEADING, Format(DTP_FROMDATE.Value, "dd/MM/yyyy"), Format(DTP_TODATE.Value, "dd/MM/yyyy"), Val(TXT_AGEFROM.Text), Val(TXT_AGETO.Text))
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    If pagesize > 58 Then
                        If RAD_PRNSPOUSE.Checked = True Then
                            Filewrite.WriteLine(StrDup(106, "="))
                        ElseIf RAD_PRNDEP.Checked = True Then
                            Filewrite.WriteLine(StrDup(106, "="))
                        Else
                            Filewrite.WriteLine(StrDup(147, "="))
                        End If
                        Filewrite.Write(Chr(12))
                        '                        Call PrintHeader(PHEADING)
                        Call PrintHeader(PHEADING, Format(DTP_FROMDATE.Value, "dd/MM/yyyy"), Format(DTP_TODATE.Value, "dd/MM/yyyy"), Val(TXT_AGEFROM.Text), Val(TXT_AGETO.Text))

                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    C = C + 1
                    If MCODE <> dr2("MCODE") Then
                        SQLSTR = Space(4 - Len(Mid(Trim(Format(Val(C), "0")), 1, 4))) & Mid(Trim(Format(Val(C), "0")), 1, 4) & ". "
                        SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("MCODE")), 1, 10)) & Space(10 - Len(Trim(Mid(CStr(dr2("MCODE")), 1, 10)))) & Space(1)
                        SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("MNAME")), 1, 40)) & Space(40 - Len(Trim(Mid(CStr(dr2("MNAME")), 1, 40)))) & Space(1)
                    Else
                        SQLSTR = Space(58)
                    End If

                    If RAD_PRNSPOUSE.Checked = True Then
                        If MCODE <> dr2("MCODE") Then
                            SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SPOUSE")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("SPOUSE")), 1, 25)))) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)) & Space(15 - Len(Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)))) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)) & Space(40 - Len(Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)))) & Space(1)

                        Else
                            SQLSTR = SQLSTR & Space(41)
                        End If
                    ElseIf RAD_PRNDEP.Checked = True Then
                        If MCODE <> dr2("MCODE") Then
                            SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("CHILD_NM")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("CHILD_NM")), 1, 25)))) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)) & Space(15 - Len(Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)))) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)) & Space(40 - Len(Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)))) & Space(1)

                        Else
                            SQLSTR = SQLSTR & Space(52)
                        End If
                    Else
                        If MCODE <> dr2("MCODE") Then
                            SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SPOUSE")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("SPOUSE")), 1, 25)))) & Space(1)
                        Else
                            SQLSTR = SQLSTR & Space(41)
                        End If
                        'SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("CHILD_NM")), 1, 40)) & Space(40 - Len(Trim(Mid(CStr(dr2("CHILD_NM")), 1, 40))))
                        SQLSTR = SQLSTR & Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)) & Space(15 - Len(Trim(Mid(Format(CDate(dr2("DOB")), "dd/MM/yyyy"), 1, 15)))) & Space(1)
                        SQLSTR = SQLSTR & Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)) & Space(40 - Len(Trim(Mid(Format(CStr(dr2("CONTPHONE")), ""), 1, 40)))) & Space(1)

                    End If

                    MCODE = dr2("MCODE")
                    If Len(Trim(SQLSTR)) > 0 Then
                        Filewrite.WriteLine(SQLSTR)
                        pagesize = pagesize + 1
                    End If
                Next dr2


                If RAD_PRNSPOUSE.Checked = True Then
                    Filewrite.WriteLine(StrDup(109, "="))
                ElseIf RAD_PRNDEP.Checked = True Then
                    Filewrite.WriteLine(StrDup(109, "="))
                Else
                    Filewrite.WriteLine(StrDup(109, "="))
                End If
                pagesize = pagesize + 3
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal Heading As String, ByVal FROMDATE As Date, ByVal TODATE As Date, ByVal AGEFROM As Integer, ByVal AGETO As Integer)
        Dim I As Integer
        pagesize = 0
        Try
            Dim Finstring As String
            Finstring = Format(CDate(gFinancalyearStart), "dd/MM/yyyy") & " TO " & Format(CDate(gFinancialYearEnd), "dd/MM/yyyy")
            '            If pageno <= 1 Then
            Filewrite.WriteLine("{0,50}{1,15}{2,30}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,55}{2,20}", Mid(MyCompanyName, 1, 40), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1

            Filewrite.WriteLine("{0,-10}{1,-16}{2,-20}{3,-25}{4,-30}", Mid(Address1, 1, 30), " ", " ", " ", Mid(Finstring, 1, 30))

            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-50}{1,10}", Heading, " PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            'Filewrite.WriteLine("DOB FROM " & Format(FROMDATE, "dd/MM/yyyy") & " TO " & Format(TODATE, "dd/MM/yyyy") & Space(10) & " AGE FROM " & Format(AGEFROM, "0") & " TO " & Format(AGETO, "0"))
            If RAD_PRNSPOUSE.Checked = True Then
                Filewrite.WriteLine(Chr(15) & StrDup(137, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("   #  MSNO       MEMBER NAME                              SPOUSE                    DOB         PHONE")
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(137, "-"))
            ElseIf RAD_PRNDEP.Checked = True Then
                Filewrite.WriteLine(Chr(15) & StrDup(109, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("   #  MSNO       MEMBER NAME                              DEPENDENT NAME            DOB         PHONE")
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(137, "-"))
            Else
                Filewrite.WriteLine(Chr(15) & StrDup(137, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("   #  MSNO       MEMBER NAME                              SPOUSE                    DOB          PHONE ")
                'Filewrite.WriteLine("   #  MSNO       MEMBER NAME                           SPOUSE                                    DEPENDENT NAME                           DOB")
                pagesize = pagesize + 1
                Filewrite.WriteLine(Chr(15) & StrDup(137, "-"))
            End If

            pagesize = pagesize + 1
            pageno = pageno + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function


    Private Sub txt_mcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    txt_Tomcode.Focus()
                    'cmd_view.Focus()
                    'Else
                    '    txt_mcode.Text = ""
                    '    txt_mcode.Focus()
                End If
                'Else
                '    txt_mcode.Text = ""
                '    txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MEM_SPO_DEP_BIRTH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMEMBERTYPE()
        '        txt_mcode.Focus()
        '       Show()
        Chk_FILTER_FIELD.Focus()
        RNDDOB.Checked = True
        Show()
    End Sub
    Private Sub txt_mcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub txt_Tomcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp1_Click(sender, e)
            Else
                txt_Tomcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub Validation()

        boolchk = False
        Dim message, mcode, mname, mblno As String
        Dim I, J As Integer

        message = txt_msg.Text
        If message = "" Then
            MessageBox.Show("Message Format Should'nt be blank ", gCompanyname)
            Exit Sub
        End If
        If message.Length > 160 Then
            MessageBox.Show("Message Length Should not exceed 160 Characters ", gCompanyname)
            Exit Sub
        End If

        With ssgrid
            For I = 0 To ssgrid.DataRowCnt - 1
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

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        gPrint = True
        Call Reportdetails_summary1()
    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Tomcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_AGEFROM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_AGEFROM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
    End Sub

    Private Sub TXT_AGETO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TXT_AGETO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
    End Sub

    Private Sub MEM_SPO_DEP_BIRTH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F8 Then
            Call cmd_view_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call cmd_print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            If CmdClear.Enabled = True Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub



    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (Chk_FILTER_FIELD.Items.Count - 1)
                    Chk_FILTER_FIELD.SetSelected(Iteration, True)
                    Chk_FILTER_FIELD.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_FILTER_FIELD.Items.Count - 1)
                    Chk_FILTER_FIELD.SetSelected(Iteration, False)
                    Chk_FILTER_FIELD.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
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

    Private Sub cmd_MemberCodeHelp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp1.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
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

    Public Sub Reportdetails_summary1()
        Try
            Dim HEADING, HEADING1 As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_MEMBERDOB
            If RNDDOB.Checked = True Then
                cmdText = "select mcode,mname,dob,membertype,contcell,contemail from mm_membermaster"
            Else
                cmdText = "select mcode,mname,doW AS DOB,membertype,contcell,contemail from mm_membermaster"
            End If

            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txt_mcode.Text <> "") And (txt_Tomcode.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            End If
            If RNDDOB.Checked = True Then
                cmdText = cmdText & " and DATEPART(MONTH, dob)='" & Format(DTP_MONTH.Value, "MM") & "' and DATEPART(DAY, dob)='" & Format(DTP_DATE.Value, "dd") & "'"
            Else
                cmdText = cmdText & " and DATEPART(MONTH, doW)='" & Format(DTP_MONTH.Value, "MM") & "' and DATEPART(DAY, doW)='" & Format(DTP_DATE.Value, "dd") & "'"

            End If
            If RNDDOB.Checked = True Then

                'cmdText = cmdText & "  and DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & DTP_FROMDATE.Text & "',103)), dob) BETWEEN convert(datetime,'" & DTP_FROMDATE.Text & "',103) AND convert(datetime,'" & DTP_TODATE.Text & "',103) "
                'cmdText = cmdText & "   OR DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & DTP_TODATE.Text & "',103)), dob) BETWEEN convert(datetime,'" & DTP_FROMDATE.Text & "',103) AND convert(datetime,'" & DTP_TODATE.Text & "',103) "
                'cmdText = cmdText & " ORDER BY CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR,  dob,convert(datetime,'" & DTP_FROMDATE.Text & "',103)), dob) BETWEEN convert(datetime,'" & DTP_FROMDATE.Text & "',103)  AND convert(datetime,'" & DTP_TODATE.Text & "',103) "
                'cmdText = cmdText & " THEN 1 ELSE 2 END,DATEPART(MONTH, dob), DATEPART(DAY, dob)"
                dateofbirthfrom = DTP_FROMDATE.Text
                dateofbirthto = DTP_TODATE.Text
                HEADING = "  MEMBER DATE OF BIRTH"
                HEADING1 = "DATE OF BIRTH"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)



            ElseIf RNDWEDDING.Checked = True Then

                'cmdText = cmdText & " and day(WEDDING_DATE) between day(convert(datetime,'" & DTP_DOWFROM.Text & "',103)) and day(convert(datetime,'" & DTP_DOWTO.Text & "',103))"
                'cmdText = cmdText & " and month(WEDDING_DATE) between month(convert(datetime,'" & DTP_DOWFROM.Text & "',103)) and month(convert(datetime,'" & DTP_DOWTO.Text & "',103))"
                'cmdText = cmdText & " order by month(WEDDING_DATE),day(WEDDING_DATE) asc"
                dateofweddingfrom = DTP_DOWFROM.Text
                dateofweddingto = DTP_DOWTO.Text
                HEADING = "MEMBER DATE OF WEDDING"
                HEADING1 = "DATE OF WEDDING"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofweddingfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofweddingto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)

            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gUsername)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(HEADING)
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = HEADING1
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "mm_membermaster"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Reportdetails_agelimit()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_MEMBER_AGE_DOB
            cmdText = "select * from MM_View_Agelimit"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txt_mcode.Text <> "") And (txt_Tomcode.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            End If

            If Opt_Age25_30.Checked = True Then
                dateofbirthfrom = DTP_FROMDATE.Text
                dateofbirthto = DTP_TODATE.Text
                cmdText = cmdText & "  and datediff(month,dob,getdate())-300>0  and datediff(month,dob,getdate())-360<0 "
                HEADING = "AGE 25 to 30"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            ElseIf Opt_Age30_40.Checked = True Then
                dateofbirthfrom = DTP_FROMDATE.Text
                dateofbirthto = DTP_TODATE.Text
                cmdText = cmdText & "  and datediff(month,dob,getdate())-360>0  and datediff(month,dob,getdate())-480<0 "
                HEADING = "AGE 30 to 40"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            ElseIf Opt_Age40_50.Checked = True Then
                cmdText = cmdText & "  and datediff(month,dob,getdate())-480>0  and datediff(month,dob,getdate())-600<0 "
                HEADING = "AGE 40 to 50"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            ElseIf Opt_Age50_60.Checked = True Then
                cmdText = cmdText & "  and datediff(month,dob,getdate())-600>0  and datediff(month,dob,getdate())-720<0 "
                HEADING = "AGE 50 to 60"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            ElseIf Opt_Age60_70.Checked = True Then
                cmdText = cmdText & "  and datediff(month,dob,getdate())-720>0  and datediff(month,dob,getdate())-840<0 "
                HEADING = "AGE 60 to 70"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            ElseIf Opt_Age70_above.Checked = True Then
                cmdText = cmdText & "  and datediff(month,dob,getdate())-840>0 "
                HEADING = "AGE 70 ABOVE"
                txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                txtobj1.Text = dateofbirthfrom
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = dateofbirthto
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "MM_View_Agelimit"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txt_mcode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub txt_mcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'If txt_mcode.Text = "" Then
                cmd_MemberCodeHelp_Click(sender, e)
                'Else
                'cbo_Title.Focus()
                'cmbRankNo.Focus()
                'End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_Tomcode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tomcode.TextChanged

    End Sub

    Private Sub txt_Tomcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Tomcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Trim(txt_Tomcode.Text) = "" Then
                    Call cmd_MemberCodeHelp2_Click(sender, e)
                Else
                    txt_Tomcode_Validated(sender, e)
                End If
            End If
            '        'If txt_mcode.Text = "" Then
            '        cmd_MemberCodeHelp_Click(sender, e)
            '        'Else
            '        'cbo_Title.Focus()
            '        'cmbRankNo.Focus()
            '        'End If
            '    ElseIf e.KeyCode = Keys.F4 Then
            '        cmd_MemberCodeHelp_Click(sender, e)
            '    End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
        'If Asc(e.KeyChar) = 13 Then
        '    If Trim(txt_mcode.Text) = "" Then
        '        Call cmd_MemberCodeHelp1_Click(sender, e)
        '    Else
        '        txt_Tomcode_Validated(sender, e)
        '    End If
        'End If
    End Sub
    Private Sub txt_Tomcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tomcode.Validated
        Try
            If Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_Tomcode.Text) & "'"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        txt_Tomcode.Text = ""
        txt_mcode.Text = ""
        txt_mname.Text = ""
        txt_Tomname.Text = ""
        DTP_FROMDATE.Text = ""
        DTP_TODATE.Text = ""
        chk_PrintAll.Checked = False
        RNDDOB.Checked = True
        RNDWEDDING.Checked = False

    End Sub
    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
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

    Private Sub txt_mcode_Validated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated

    End Sub

    Private Sub RNDDOB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNDDOB.CheckedChanged

    End Sub

    Private Sub RNDDOB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RNDDOB.Click
        'If RNDDOB.Checked = True Then
        '    LBL_FROMDATE.Text = "DOB FROM :"
        '    LBL_TO.Text = "DOB TO :"
        '    DTP_DOWFROM.Visible = False
        '    DTP_DOWTO.Visible = False
        '    DTP_FROMDATE.Visible = True
        '    DTP_TODATE.Visible = True
        'End If
    End Sub

    Private Sub RNDWEDDING_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RNDWEDDING.CheckedChanged

    End Sub

    Private Sub RNDWEDDING_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RNDWEDDING.Click
        If RNDWEDDING.Checked = True Then
            'LBL_FROMDATE.Text = "DOW FROM :"
            'LBL_TO.Text = "DOW TO :"
            'DTP_FROMDATE.Visible = False
            'DTP_TODATE.Visible = False
            'DTP_DOWFROM.Visible = True
            'DTP_DOWTO.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Opt_Age25_30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age25_30.CheckedChanged

    End Sub

    Private Sub Opt_Age25_30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_Age25_30.Click
        Opt_Age25_30.Checked = True
        Opt_Age30_40.Checked = False
        Opt_Age40_50.Checked = False
        Opt_Age50_60.Checked = False
        Opt_Age60_70.Checked = False
        Opt_Age70_above.Checked = False
    End Sub

    Private Sub Opt_Age30_40_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age30_40.CheckedChanged

    End Sub

    Private Sub Opt_Age30_40_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_Age30_40.Click
        Opt_Age25_30.Checked = False
        Opt_Age30_40.Checked = True
        Opt_Age40_50.Checked = False
        Opt_Age50_60.Checked = False
        Opt_Age60_70.Checked = False
        Opt_Age70_above.Checked = False
    End Sub

    Private Sub Opt_Age40_50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age40_50.CheckedChanged

    End Sub

    Private Sub Opt_Age40_50_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_Age40_50.Click
        Opt_Age25_30.Checked = False
        Opt_Age30_40.Checked = False
        Opt_Age40_50.Checked = True
        Opt_Age50_60.Checked = False
        Opt_Age60_70.Checked = False
        Opt_Age70_above.Checked = False
    End Sub

    Private Sub Opt_Age50_60_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age50_60.CheckedChanged

    End Sub

    Private Sub Opt_Age50_60_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_Age50_60.Click
        Opt_Age25_30.Checked = False
        Opt_Age30_40.Checked = False
        Opt_Age40_50.Checked = False
        Opt_Age50_60.Checked = True
        Opt_Age60_70.Checked = False
        Opt_Age70_above.Checked = False
    End Sub

    Private Sub Opt_Age60_70_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age60_70.CheckedChanged

    End Sub

    Private Sub Opt_Age60_70_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Opt_Age60_70.Click
        Opt_Age25_30.Checked = False
        Opt_Age30_40.Checked = False
        Opt_Age40_50.Checked = False
        Opt_Age50_60.Checked = False
        Opt_Age60_70.Checked = True
        Opt_Age70_above.Checked = False
    End Sub

    Private Sub Opt_Age70_above_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Opt_Age70_above.CheckedChanged
        Opt_Age25_30.Checked = False
        Opt_Age30_40.Checked = False
        Opt_Age40_50.Checked = False
        Opt_Age50_60.Checked = False
        Opt_Age60_70.Checked = False
        Opt_Age70_above.Checked = True
    End Sub

    Private Sub DTP_MONTH_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_MONTH.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_send.Click
        If (Chk_FILTER_FIELD.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Member Type Items")
            Exit Sub
        End If
        Dim CMDTEXT, contcell As String
        Dim I As Integer


        If RNDDOB.Checked = True Then
            CMDTEXT = "select mcode,mname,dob,membertype,contcell,contemail from mm_membermaster"
        Else
            CMDTEXT = "select mcode,mname,doW AS DOB,membertype,contcell,contemail from mm_membermaster"
        End If

        txtCategory.Text = ""
        Dim o As Object
        For Each o In Chk_FILTER_FIELD.CheckedItems
            txtCategory.Text += "'" & o.ToString() & "',"
        Next o
        CMDTEXT = CMDTEXT & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
        If (txt_mcode.Text <> "") And (txt_Tomcode.Text <> "") Then
            CMDTEXT = CMDTEXT & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
        End If
        If RNDDOB.Checked = True Then
            CMDTEXT = CMDTEXT & " and DATEPART(MONTH, dob)='" & Format(DTP_MONTH.Value, "MM") & "' and DATEPART(DAY, dob)='" & Format(DTP_DATE.Value, "dd") & "'"
        Else
            CMDTEXT = CMDTEXT & " and DATEPART(MONTH, doW)='" & Format(DTP_MONTH.Value, "MM") & "' and DATEPART(DAY, doW)='" & Format(DTP_DATE.Value, "dd") & "'"

        End If
        gconnection.getDataSet(CMDTEXT, "MM_MEMBERMASTER")
        If gdataset.Tables("MM_MEMBERMASTER").Rows.Count > 0 Then
            ssgrid.Visible = True
            btn_send.Enabled = False
            GroupBox5.Visible = True
            With ssgrid
                For I = 0 To gdataset.Tables("MM_MEMBERMASTER").Rows.Count - 1
                    .Row = I + 1
                    .Col = 1
                    .Text = gdataset.Tables("MM_MEMBERMASTER").Rows(I).Item("MCODE")
                    .Row = I + 1
                    .Col = 2
                    .Text = gdataset.Tables("MM_MEMBERMASTER").Rows(I).Item("MNAME")
                    .Row = I + 1
                    .Col = 3
                    .Text = Format(CDate(gdataset.Tables("MM_MEMBERMASTER").Rows(I).Item("DOB")), "dd/MM/yyyy")
                    .Row = I + 1
                    .Col = 4
                    contcell = gdataset.Tables("MM_MEMBERMASTER").Rows(I).Item("CONTCELL")
                    .Text = contcell.Replace(" ", "")
                Next
            End With
        End If
        txt_msg.Text = MESSAGE
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox5.Visible = False
        btn_send.Enabled = True
        txt_msg.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt_msg.Text = ""
        ssgrid.ClearRange(1, 1, -1, -1, True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim message, mcode, mname, mblno As String
        Dim I, J As Integer
        Call Validation()
        If boolchk = False Then Exit Sub
        message = txt_msg.Text
        With ssgrid
            For I = 0 To ssgrid.DataRowCnt - 1
                .Row = I + 1
                .Col = 4
                mblno = .Text
                .Col = 5
                If Val(.Text) = 1 Then
                    J = J + 1
                    Call SMS(mcode, mname, mblno, message)
                Else
                    J = J + 0
                End If

            Next
        End With
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

            strPostData = "http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=" & USERID & "&pass=" & PWD & "&appid=" & APPID & "&subappid=" & SUBAPPID & "&msgtype=1&contenttype=1&selfid=true&to=" & MBLNO & "&from=56767&dlrreq=true&text=" & MESSAGE & "&alert=1"
            'xmlobj.open()

            xmlobj.open("POST", strPostData, True)
            xmlobj.send()
            'xmlobj = DropObject("msxml2.XMLHTTP")


            xmlobj = Nothing

        Catch
            MsgBox("Please Check Your Internet Connection")
        End Try
        'End If
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
End Class
