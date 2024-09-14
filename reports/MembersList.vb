Imports System.Data.SqlClient
Imports System.IO
Public Class MembersList
    Inherits System.Windows.Forms.Form
    Dim FltrStr, status, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Dim SNO As Integer = 1
    Public selectNo As Integer
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChK_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Chk_Members_List As System.Windows.Forms.CheckedListBox
    Friend WithEvents SSGRID As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Display As System.Windows.Forms.Button
    Friend WithEvents Chk_SelectAllMember As System.Windows.Forms.CheckBox
    Friend WithEvents Grb_DOJ_Wise As System.Windows.Forms.GroupBox
    Friend WithEvents Opt_Category As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Mname As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Mcode As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btn_Close_DOJ As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_DOJ_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_DOJ_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chk_Options As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Chk_Field_Selection As System.Windows.Forms.CheckedListBox
    Friend WithEvents Cmd_Export As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Chk_DOJ As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Field_Yes As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_All_Category As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_All_Member As System.Windows.Forms.CheckBox
    Friend WithEvents Opt_DOB As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_DOJ As System.Windows.Forms.RadioButton
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkexp As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDB_EXPIRED As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_WITHINJOIN As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_ASONDATE As System.Windows.Forms.RadioButton
    Friend WithEvents LAB_FROMDATE As System.Windows.Forms.Label
    Friend WithEvents LAB_ASONDATE As System.Windows.Forms.Label
    Friend WithEvents LAB_TODATE As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MembersList))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Export = New System.Windows.Forms.Button
        Me.Cmd_Display = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RDB_EXPIRED = New System.Windows.Forms.RadioButton
        Me.RDB_WITHINJOIN = New System.Windows.Forms.RadioButton
        Me.RDB_ASONDATE = New System.Windows.Forms.RadioButton
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.LAB_TODATE = New System.Windows.Forms.Label
        Me.LAB_FROMDATE = New System.Windows.Forms.Label
        Me.Chk_All_Member = New System.Windows.Forms.CheckBox
        Me.Chk_All_Category = New System.Windows.Forms.CheckBox
        Me.Chk_Options = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllMember = New System.Windows.Forms.CheckBox
        Me.Chk_Members_List = New System.Windows.Forms.CheckedListBox
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChK_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.chk_STATUS = New System.Windows.Forms.CheckBox
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.chkexp = New System.Windows.Forms.CheckBox
        Me.LAB_ASONDATE = New System.Windows.Forms.Label
        Me.SSGRID = New AxFPSpreadADO.AxfpSpread
        Me.Grb_DOJ_Wise = New System.Windows.Forms.GroupBox
        Me.Opt_DOJ = New System.Windows.Forms.RadioButton
        Me.Opt_DOB = New System.Windows.Forms.RadioButton
        Me.Chk_Field_Yes = New System.Windows.Forms.CheckBox
        Me.Btn_Close_DOJ = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Chk_Field_Selection = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Opt_Category = New System.Windows.Forms.RadioButton
        Me.Opt_Mname = New System.Windows.Forms.RadioButton
        Me.Opt_Mcode = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cmb_DOJ_To = New System.Windows.Forms.DateTimePicker
        Me.Cmb_DOJ_From = New System.Windows.Forms.DateTimePicker
        Me.Chk_DOJ = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_DOJ_Wise.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Export)
        Me.GroupBox2.Controls.Add(Me.Cmd_Display)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(144, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 56)
        Me.GroupBox2.TabIndex = 406
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Export
        '
        Me.Cmd_Export.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Export.BackgroundImage = CType(resources.GetObject("Cmd_Export.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Export.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Export.ForeColor = System.Drawing.Color.White
        Me.Cmd_Export.Location = New System.Drawing.Point(488, 16)
        Me.Cmd_Export.Name = "Cmd_Export"
        Me.Cmd_Export.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Export.TabIndex = 10
        Me.Cmd_Export.Text = "Export[F10]"
        '
        'Cmd_Display
        '
        Me.Cmd_Display.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Display.BackgroundImage = CType(resources.GetObject("Cmd_Display.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Display.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Display.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Display.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Display.ForeColor = System.Drawing.Color.White
        Me.Cmd_Display.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_Display.Name = "Cmd_Display"
        Me.Cmd_Display.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Display.TabIndex = 9
        Me.Cmd_Display.Text = "Display[F7]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(8, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 7
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
        Me.cmdexit.Location = New System.Drawing.Point(608, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 8
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(368, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print[F9]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.Enabled = False
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(248, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View[F8]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 29)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "MEMBERS LIST"
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(64, 416)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 26)
        Me.tbx_Filter_From.TabIndex = 3
        Me.tbx_Filter_From.Text = ""
        Me.tbx_Filter_From.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 406
        Me.Label7.Text = "From"
        Me.Label7.Visible = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(144, 416)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 409
        Me.cmd_MCodeToHelp.Visible = False
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(32, 400)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 408
        Me.cmd_MCodefromHelp.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 22)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "To"
        Me.Label8.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Dtp_To)
        Me.GroupBox1.Controls.Add(Me.Dtp_From)
        Me.GroupBox1.Controls.Add(Me.LAB_TODATE)
        Me.GroupBox1.Controls.Add(Me.LAB_FROMDATE)
        Me.GroupBox1.Controls.Add(Me.Chk_All_Member)
        Me.GroupBox1.Controls.Add(Me.Chk_All_Category)
        Me.GroupBox1.Controls.Add(Me.Chk_Options)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllMember)
        Me.GroupBox1.Controls.Add(Me.Chk_Members_List)
        Me.GroupBox1.Controls.Add(Me.Cmb_add_filter)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ChK_Memberstatus)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.chk_STATUS)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.chkexp)
        Me.GroupBox1.Controls.Add(Me.LAB_ASONDATE)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(88, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 504)
        Me.GroupBox1.TabIndex = 404
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RDB_EXPIRED)
        Me.GroupBox3.Controls.Add(Me.RDB_WITHINJOIN)
        Me.GroupBox3.Controls.Add(Me.RDB_ASONDATE)
        Me.GroupBox3.Location = New System.Drawing.Point(64, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 64)
        Me.GroupBox3.TabIndex = 614
        Me.GroupBox3.TabStop = False
        '
        'RDB_EXPIRED
        '
        Me.RDB_EXPIRED.BackColor = System.Drawing.Color.Transparent
        Me.RDB_EXPIRED.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_EXPIRED.Location = New System.Drawing.Point(512, 24)
        Me.RDB_EXPIRED.Name = "RDB_EXPIRED"
        Me.RDB_EXPIRED.Size = New System.Drawing.Size(172, 16)
        Me.RDB_EXPIRED.TabIndex = 416
        Me.RDB_EXPIRED.Text = "WITH IN EXPIRED"
        '
        'RDB_WITHINJOIN
        '
        Me.RDB_WITHINJOIN.BackColor = System.Drawing.Color.Transparent
        Me.RDB_WITHINJOIN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_WITHINJOIN.Location = New System.Drawing.Point(296, 27)
        Me.RDB_WITHINJOIN.Name = "RDB_WITHINJOIN"
        Me.RDB_WITHINJOIN.Size = New System.Drawing.Size(128, 16)
        Me.RDB_WITHINJOIN.TabIndex = 415
        Me.RDB_WITHINJOIN.Text = "WITH IN JOIN "
        '
        'RDB_ASONDATE
        '
        Me.RDB_ASONDATE.BackColor = System.Drawing.Color.Transparent
        Me.RDB_ASONDATE.Checked = True
        Me.RDB_ASONDATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_ASONDATE.Location = New System.Drawing.Point(48, 26)
        Me.RDB_ASONDATE.Name = "RDB_ASONDATE"
        Me.RDB_ASONDATE.Size = New System.Drawing.Size(120, 16)
        Me.RDB_ASONDATE.TabIndex = 414
        Me.RDB_ASONDATE.TabStop = True
        Me.RDB_ASONDATE.Text = "AS ON DATE"
        '
        'Dtp_To
        '
        Me.Dtp_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Dtp_To.Location = New System.Drawing.Point(504, 466)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(115, 21)
        Me.Dtp_To.TabIndex = 432
        '
        'Dtp_From
        '
        Me.Dtp_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Dtp_From.Location = New System.Drawing.Point(288, 466)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(111, 21)
        Me.Dtp_From.TabIndex = 431
        '
        'LAB_TODATE
        '
        Me.LAB_TODATE.AutoSize = True
        Me.LAB_TODATE.BackColor = System.Drawing.Color.Transparent
        Me.LAB_TODATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_TODATE.Location = New System.Drawing.Point(408, 466)
        Me.LAB_TODATE.Name = "LAB_TODATE"
        Me.LAB_TODATE.Size = New System.Drawing.Size(55, 17)
        Me.LAB_TODATE.TabIndex = 430
        Me.LAB_TODATE.Text = "TO DATE"
        '
        'LAB_FROMDATE
        '
        Me.LAB_FROMDATE.AutoSize = True
        Me.LAB_FROMDATE.BackColor = System.Drawing.Color.Transparent
        Me.LAB_FROMDATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_FROMDATE.Location = New System.Drawing.Point(176, 469)
        Me.LAB_FROMDATE.Name = "LAB_FROMDATE"
        Me.LAB_FROMDATE.Size = New System.Drawing.Size(72, 17)
        Me.LAB_FROMDATE.TabIndex = 429
        Me.LAB_FROMDATE.Text = "FROM DATE"
        '
        'Chk_All_Member
        '
        Me.Chk_All_Member.BackColor = System.Drawing.Color.Transparent
        Me.Chk_All_Member.Checked = True
        Me.Chk_All_Member.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_All_Member.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_All_Member.Location = New System.Drawing.Point(280, 304)
        Me.Chk_All_Member.Name = "Chk_All_Member"
        Me.Chk_All_Member.Size = New System.Drawing.Size(185, 23)
        Me.Chk_All_Member.TabIndex = 428
        Me.Chk_All_Member.Text = "All Members"
        Me.Chk_All_Member.Visible = False
        '
        'Chk_All_Category
        '
        Me.Chk_All_Category.BackColor = System.Drawing.Color.Transparent
        Me.Chk_All_Category.Checked = True
        Me.Chk_All_Category.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Chk_All_Category.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_All_Category.Location = New System.Drawing.Point(88, 16)
        Me.Chk_All_Category.Name = "Chk_All_Category"
        Me.Chk_All_Category.Size = New System.Drawing.Size(185, 23)
        Me.Chk_All_Category.TabIndex = 427
        Me.Chk_All_Category.Text = "All Category"
        '
        'Chk_Options
        '
        Me.Chk_Options.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Options.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Options.Location = New System.Drawing.Point(667, 382)
        Me.Chk_Options.Name = "Chk_Options"
        Me.Chk_Options.Size = New System.Drawing.Size(125, 23)
        Me.Chk_Options.TabIndex = 426
        Me.Chk_Options.Text = "Options [F5]"
        '
        'Chk_SelectAllMember
        '
        Me.Chk_SelectAllMember.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllMember.Enabled = False
        Me.Chk_SelectAllMember.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllMember.Location = New System.Drawing.Point(280, 328)
        Me.Chk_SelectAllMember.Name = "Chk_SelectAllMember"
        Me.Chk_SelectAllMember.Size = New System.Drawing.Size(192, 23)
        Me.Chk_SelectAllMember.TabIndex = 425
        Me.Chk_SelectAllMember.Text = "Select All Members"
        Me.Chk_SelectAllMember.Visible = False
        '
        'Chk_Members_List
        '
        Me.Chk_Members_List.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Chk_Members_List.Enabled = False
        Me.Chk_Members_List.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Members_List.Location = New System.Drawing.Point(284, 360)
        Me.Chk_Members_List.Name = "Chk_Members_List"
        Me.Chk_Members_List.Size = New System.Drawing.Size(252, 292)
        Me.Chk_Members_List.Sorted = True
        Me.Chk_Members_List.TabIndex = 424
        Me.Chk_Members_List.Visible = False
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Cmb_add_filter.ItemHeight = 13
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(176, 380)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(168, 21)
        Me.Cmb_add_filter.TabIndex = 422
        Me.Cmb_add_filter.Text = "[select your filter]"
        Me.Cmb_add_filter.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 383)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 16)
        Me.Label10.TabIndex = 423
        Me.Label10.Text = "ADDRESS  FILTER"
        Me.Label10.Visible = False
        '
        'ChK_Memberstatus
        '
        Me.ChK_Memberstatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.ChK_Memberstatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.ChK_Memberstatus.Location = New System.Drawing.Point(400, 73)
        Me.ChK_Memberstatus.Name = "ChK_Memberstatus"
        Me.ChK_Memberstatus.Size = New System.Drawing.Size(248, 292)
        Me.ChK_Memberstatus.Sorted = True
        Me.ChK_Memberstatus.TabIndex = 421
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Enabled = False
        Me.chk_PrintAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(88, 41)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(185, 23)
        Me.chk_PrintAll.TabIndex = 419
        Me.chk_PrintAll.Text = "Select All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(80, 73)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(252, 292)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 416
        '
        'chk_STATUS
        '
        Me.chk_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.chk_STATUS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_STATUS.Location = New System.Drawing.Point(408, 41)
        Me.chk_STATUS.Name = "chk_STATUS"
        Me.chk_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.chk_STATUS.TabIndex = 420
        Me.chk_STATUS.Text = "Select All Status"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(112, 400)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 26)
        Me.tbx_filter_To.TabIndex = 4
        Me.tbx_filter_To.Text = ""
        Me.tbx_filter_To.Visible = False
        '
        'chkexp
        '
        Me.chkexp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkexp.Location = New System.Drawing.Point(704, 464)
        Me.chkexp.Name = "chkexp"
        Me.chkexp.Size = New System.Drawing.Size(94, 24)
        Me.chkexp.TabIndex = 614
        Me.chkexp.Text = "EXPIRED"
        Me.chkexp.Visible = False
        '
        'LAB_ASONDATE
        '
        Me.LAB_ASONDATE.AutoSize = True
        Me.LAB_ASONDATE.BackColor = System.Drawing.Color.Transparent
        Me.LAB_ASONDATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_ASONDATE.Location = New System.Drawing.Point(184, 469)
        Me.LAB_ASONDATE.Name = "LAB_ASONDATE"
        Me.LAB_ASONDATE.Size = New System.Drawing.Size(76, 17)
        Me.LAB_ASONDATE.TabIndex = 429
        Me.LAB_ASONDATE.Text = "AS ON DATE"
        Me.LAB_ASONDATE.Visible = False
        '
        'SSGRID
        '
        Me.SSGRID.DataSource = Nothing
        Me.SSGRID.Location = New System.Drawing.Point(24, 51)
        Me.SSGRID.Name = "SSGRID"
        Me.SSGRID.OcxState = CType(resources.GetObject("SSGRID.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID.Size = New System.Drawing.Size(974, 453)
        Me.SSGRID.TabIndex = 612
        Me.SSGRID.Visible = False
        '
        'Grb_DOJ_Wise
        '
        Me.Grb_DOJ_Wise.BackgroundImage = CType(resources.GetObject("Grb_DOJ_Wise.BackgroundImage"), System.Drawing.Image)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Opt_DOJ)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Opt_DOB)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Chk_Field_Yes)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Btn_Close_DOJ)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Label6)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Chk_Field_Selection)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Label5)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Opt_Category)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Opt_Mname)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Opt_Mcode)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Label4)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Label2)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Label3)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Cmb_DOJ_To)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Cmb_DOJ_From)
        Me.Grb_DOJ_Wise.Controls.Add(Me.Chk_DOJ)
        Me.Grb_DOJ_Wise.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grb_DOJ_Wise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb_DOJ_Wise.Location = New System.Drawing.Point(88, 192)
        Me.Grb_DOJ_Wise.Name = "Grb_DOJ_Wise"
        Me.Grb_DOJ_Wise.Size = New System.Drawing.Size(816, 264)
        Me.Grb_DOJ_Wise.TabIndex = 613
        Me.Grb_DOJ_Wise.TabStop = False
        Me.Grb_DOJ_Wise.Visible = False
        '
        'Opt_DOJ
        '
        Me.Opt_DOJ.BackColor = System.Drawing.Color.Transparent
        Me.Opt_DOJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_DOJ.Location = New System.Drawing.Point(553, 216)
        Me.Opt_DOJ.Name = "Opt_DOJ"
        Me.Opt_DOJ.Size = New System.Drawing.Size(88, 16)
        Me.Opt_DOJ.TabIndex = 430
        Me.Opt_DOJ.Text = "DOJ"
        '
        'Opt_DOB
        '
        Me.Opt_DOB.BackColor = System.Drawing.Color.Transparent
        Me.Opt_DOB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_DOB.Location = New System.Drawing.Point(440, 216)
        Me.Opt_DOB.Name = "Opt_DOB"
        Me.Opt_DOB.Size = New System.Drawing.Size(88, 16)
        Me.Opt_DOB.TabIndex = 429
        Me.Opt_DOB.Text = "DOB"
        '
        'Chk_Field_Yes
        '
        Me.Chk_Field_Yes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Field_Yes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Field_Yes.Location = New System.Drawing.Point(176, 16)
        Me.Chk_Field_Yes.Name = "Chk_Field_Yes"
        Me.Chk_Field_Yes.Size = New System.Drawing.Size(64, 23)
        Me.Chk_Field_Yes.TabIndex = 428
        Me.Chk_Field_Yes.Text = "YES"
        '
        'Btn_Close_DOJ
        '
        Me.Btn_Close_DOJ.BackColor = System.Drawing.Color.Red
        Me.Btn_Close_DOJ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Close_DOJ.ForeColor = System.Drawing.Color.White
        Me.Btn_Close_DOJ.Location = New System.Drawing.Point(784, 24)
        Me.Btn_Close_DOJ.Name = "Btn_Close_DOJ"
        Me.Btn_Close_DOJ.Size = New System.Drawing.Size(24, 24)
        Me.Btn_Close_DOJ.TabIndex = 409
        Me.Btn_Close_DOJ.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(720, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 426
        Me.Label6.Text = "Press Esc"
        '
        'Chk_Field_Selection
        '
        Me.Chk_Field_Selection.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Chk_Field_Selection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Field_Selection.Location = New System.Drawing.Point(40, 40)
        Me.Chk_Field_Selection.Name = "Chk_Field_Selection"
        Me.Chk_Field_Selection.Size = New System.Drawing.Size(288, 180)
        Me.Chk_Field_Selection.Sorted = True
        Me.Chk_Field_Selection.TabIndex = 425
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 414
        Me.Label5.Text = "Field Selection"
        '
        'Opt_Category
        '
        Me.Opt_Category.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Category.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Category.Location = New System.Drawing.Point(656, 184)
        Me.Opt_Category.Name = "Opt_Category"
        Me.Opt_Category.Size = New System.Drawing.Size(120, 16)
        Me.Opt_Category.TabIndex = 413
        Me.Opt_Category.Text = "CATEGORY"
        '
        'Opt_Mname
        '
        Me.Opt_Mname.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Mname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Mname.Location = New System.Drawing.Point(552, 184)
        Me.Opt_Mname.Name = "Opt_Mname"
        Me.Opt_Mname.Size = New System.Drawing.Size(72, 16)
        Me.Opt_Mname.TabIndex = 412
        Me.Opt_Mname.Text = "NAME"
        '
        'Opt_Mcode
        '
        Me.Opt_Mcode.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Mcode.Checked = True
        Me.Opt_Mcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Mcode.Location = New System.Drawing.Point(440, 184)
        Me.Opt_Mcode.Name = "Opt_Mcode"
        Me.Opt_Mcode.Size = New System.Drawing.Size(88, 16)
        Me.Opt_Mcode.TabIndex = 411
        Me.Opt_Mcode.TabStop = True
        Me.Opt_Mcode.Text = "MCODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(336, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "Order By"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "DOJ From"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(616, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 407
        Me.Label3.Text = "DOJ To"
        Me.Label3.Visible = False
        '
        'Cmb_DOJ_To
        '
        Me.Cmb_DOJ_To.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_DOJ_To.CustomFormat = "yyyy"
        Me.Cmb_DOJ_To.Enabled = False
        Me.Cmb_DOJ_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_DOJ_To.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Cmb_DOJ_To.Location = New System.Drawing.Point(688, 144)
        Me.Cmb_DOJ_To.Name = "Cmb_DOJ_To"
        Me.Cmb_DOJ_To.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_DOJ_To.TabIndex = 2
        Me.Cmb_DOJ_To.Visible = False
        '
        'Cmb_DOJ_From
        '
        Me.Cmb_DOJ_From.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_DOJ_From.CustomFormat = "yyyy"
        Me.Cmb_DOJ_From.Enabled = False
        Me.Cmb_DOJ_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_DOJ_From.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Cmb_DOJ_From.Location = New System.Drawing.Point(488, 144)
        Me.Cmb_DOJ_From.Name = "Cmb_DOJ_From"
        Me.Cmb_DOJ_From.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_DOJ_From.TabIndex = 1
        Me.Cmb_DOJ_From.Visible = False
        '
        'Chk_DOJ
        '
        Me.Chk_DOJ.BackColor = System.Drawing.Color.Transparent
        Me.Chk_DOJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_DOJ.Location = New System.Drawing.Point(336, 144)
        Me.Chk_DOJ.Name = "Chk_DOJ"
        Me.Chk_DOJ.Size = New System.Drawing.Size(64, 23)
        Me.Chk_DOJ.TabIndex = 427
        Me.Chk_DOJ.Text = "DOJ"
        Me.Chk_DOJ.Visible = False
        '
        'MembersList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 661)
        Me.Controls.Add(Me.Grb_DOJ_Wise)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SSGRID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MembersList"
        Me.Text = "MEMBERS LIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_DOJ_Wise.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub lockerreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call MemberFill()
        Dim ssql As String
        Dim dt As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        dt = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            chk_Filter_Field.Items.Add(dt.Rows(Itration).Item("Membertype") & "==>" & dt.Rows(Itration).Item("TypeDesc"))
        Next
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Cmb_add_filter.SelectedIndex = 1

        If RDB_ASONDATE.Checked = True Then
            LAB_ASONDATE.Visible = True
            LAB_FROMDATE.Visible = False
            LAB_TODATE.Visible = False
            Dtp_To.Visible = False
        Else
            LAB_ASONDATE.Visible = False
            LAB_FROMDATE.Visible = True
            LAB_TODATE.Visible = True
            Dtp_To.Visible = True
        End If
    End Sub

    Private Sub MemberFill()
        Dim ssql As String
        Dim MemberNames As New DataTable
        ssql = " SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME from MEMBERMASTER "
        MemberNames = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MemberNames.Rows.Count - 1)
            Chk_Members_List.Items.Add(MemberNames.Rows(Itration).Item("MCODE") & "." & MemberNames.Rows(Itration).Item("MNAME"))
        Next
    End Sub

    Private Sub FieldFill()
        Dim ssql As String
        Dim MemberNames As New DataTable
        Chk_Field_Selection.Items.Clear()
        Dim Iteration
        Try
            For Iteration = 0 To (Chk_Field_Selection.Items.Count - 1)
                Chk_Field_Selection.SetItemChecked(Iteration, False)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'ssql = " SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'MEMBERMASTER' AND COLUMN_NAME NOT IN ('MCODE','MNAME') ORDER BY COLUMN_NAME "
        ssql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'MEMBERMASTER' AND COLUMN_NAME IN ('Billbasis','BillType','BUSINESSNAME','BUSINESSNATURE','CADD1','CADD2','CADD3','CADD4','CCELL','CCITY','CCNO','CCOUNTRY','CEMAIL','CFAX','COMPANY','CONTADD1','CONTADD2','CONTADD3','CONTCELL','CONTCITY','CONTCOUNTRY','CONTEMAIL','CONTFAX','CONTPHONE1','CONTPHONE2','CONTPIN','CONTSTATE','CountryOfBirth','CPHONE1','CPHONE2','CPIN','CSTATE','CurentStatus','DateOfProposal','DOB','DOBfather','DOJ','FatherName','FirstName','MARITALSTATUS','MembershipTo','MEMBERTYPECODE','MID','MiddleName','OADD1','OADD2','OADD3','OCAddress1','OCAddress2','OCAddress3','OCCUPATION','OCITY','OCOUNTRY','PADD1','PADD2','PADD3','PADD4','PCELL','PCITY','PCOUNTRY','PlaceOfBirth','Prefix','PROPOSERNAME','SEX','SPOUSE') ORDER BY COLUMN_NAME "
        MemberNames = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MemberNames.Rows.Count - 1)
            Chk_Field_Selection.Items.Add(MemberNames.Rows(Itration).Item("COLUMN_NAME")) '& "." & MemberNames.Rows(Itration).Item("TypeDesc"))
        Next
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
    Private Sub lockerreport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F5 Then
            If Chk_Options.Checked = False Then
                Chk_Options.Checked = True
                Exit Sub
            Else
                Chk_Options.Checked = False
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            Call Cmd_Display_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If cmdPrint.Enabled = True Then
                Call cmdPrint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            If SSGRID.Visible = True Then
                Call Cmd_Export_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            If Grb_DOJ_Wise.Visible = True Then
                Grb_DOJ_Wise.Visible = False
                Chk_Options.Checked = False
            End If
            Exit Sub
        End If
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
        Chk_All_Category.Checked = True
        Chk_All_Member.Checked = True
        Chk_Field_Yes.Checked = False
        Cmb_DOJ_From.Enabled = False
        Cmb_DOJ_To.Enabled = False
        CmdView.Enabled = False
        cmdPrint.Enabled = False
        chk_PrintAll.Checked = False
        Chk_SelectAllMember.Checked = False
        chk_STATUS.Checked = False
        Chk_Options.Checked = False
        SSGRID.Visible = False
        Opt_Mcode.Checked = True

        'MEMBER CATEGORY CLEAR
        Dim Iteration
        Try
            For Iteration = 0 To (Chk_Field_Selection.Items.Count - 1)
                Chk_Field_Selection.SetItemChecked(Iteration, False)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'MEMBER STATUS CLEAR
        Try
            For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                ChK_Memberstatus.SetItemChecked(Iteration, False)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    cmd_MCodefromHelp.Focus()
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

    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(contpin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        End If
    End Sub

    Private Sub tbx_filter_To_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        Call Grid_DotMatirx_View()
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        Call Grid_DotMatirx_View()
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
    Private Sub Grid_DotMatirx_View()
        'SSGRID.ExportToTextFile("MEMLIST", 35, 35, 9999, FPSpreadADO.ExportToTextFileConstants.ExportToTextFileCreateNewFile, "TEST")
        'SSGRID.ExportRangeToTextFile(1, 1, 15, 9999, "TESTM", 1, 2, 2, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileAllHeaders, "TEST1")
        'SSGRID.ExportToExcel("MEMEXCEL", "ONE", "LOG1")
        'SSGRID.SaveToFile("MEMSAVE", True)
        Dim i, j As Int16
        Dim vpageno As Int16
        Dim vRowcnt As Integer
        Dim vstr, fields, fieldsgroup(300) As String
        Dim VNETBALANCE As Double
        vpageno = 1
        Randomize()
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        Dim vcaption, Ssql As String
        vcaption = "MEMBERS LIST"
        Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyname & Chr(15))
        Filewrite.WriteLine(Chr(14) & Chr(15) & vcaption & Chr(15))
        Filewrite.WriteLine("Accounting Period :")
        Filewrite.Write("" & gFinancalyearStart & "  -  " & "" & gFinancialYearEnd)
        Filewrite.WriteLine(Space(67) & "Run Date :" & Format(Now, "dd-MMM-yyyy"))
        Filewrite.WriteLine(Space(106) & "Page No :" & Val(vpageno))
        Filewrite.WriteLine(StrDup(138, "="))
        vRowcnt = 6
        'lin
        If Chk_Field_Selection.CheckedItems.Count <> 0 Then
            For i = 0 To Chk_Field_Selection.CheckedItems.Count - 1
                fieldsgroup(i) = Chk_Field_Selection.CheckedItems(i)
            Next
        End If
        If Chk_Field_Yes.Checked = False Then
            Filewrite.WriteLine(" SNO     MCODE               MNAME                            DOJ             DOB         CATEGORY    STATUS       MEMBERSHIPTO")
        Else
            Filewrite.Write("  SNO     MCODE               MNAME                            ")
            Dim FieldSize As Integer
            For j = 0 To i - 1
                Ssql = " SELECT CHARACTER_MAXIMUM_LENGTH FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'MEMBERMASTER' AND COLUMN_NAME = '" & fieldsgroup(j) & "' AND DATA_TYPE IN ('VARCHAR','CHAR') "
                gconnection.getDataSet(Ssql, "MMASTER")
                FieldSize = Val(gdataset.Tables("MMASTER").Rows(0).Item("CHARACTER_MAXIMUM_LENGTH"))
                If FieldSize > 35 Then
                    FieldSize = 35
                End If
                Filewrite.Write(Space(2) & fieldsgroup(j))
                Filewrite.Write(Space(FieldSize - (Val(Len(fieldsgroup(j))))))
            Next
            Filewrite.Write(Chr(13))
        End If
        vRowcnt = vRowcnt + 1
        Filewrite.WriteLine(StrDup(138, "="))
        vRowcnt = vRowcnt + 1
        vRowcnt = 10
        If Chk_Field_Yes.Checked = False Then
            For i = 2 To SSGRID.DataRowCnt
                If vRowcnt > 65 Then
                    Filewrite.WriteLine(StrDup(138, "="))
                    Filewrite.Write(Chr(12))
                    Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyname & Chr(15))
                    Filewrite.WriteLine(Chr(14) & Chr(15) & vcaption & Chr(15))
                    Filewrite.WriteLine("Accounting Period :")
                    Filewrite.Write("" & gFinancalyearStart & "  -  " & "" & gFinancialYearEnd)
                    Filewrite.WriteLine(Space(67) & "Run Date :" & Format(Now, "dd-MMM-yyyy"))
                    Filewrite.WriteLine(Space(106) & "Page No :" & Val(vpageno))
                    Filewrite.WriteLine(StrDup(138, "="))
                    Filewrite.WriteLine(" SNO     MCODE               MNAME                            DOJ             DOB         CATEGORY           STATUS     ")
                    Filewrite.WriteLine(StrDup(138, "="))
                    vRowcnt = 8
                End If
                With SSGRID
                    Filewrite.Write(Format(Val(i - 1), "0000") & Space(1) & "|" & Space(1))
                    .Row = i
                    .Col = 1
                    vstr = .Text
                    'Filewrite.Write(.Text & Space(10 - Len(Mid(.Text, 1, 10))) & "|" & Space(1))
                    .Col = 2
                    'Filewrite.Write(Mid(.Text, 1, 35) & Space(35 - Len(Mid(.Text, 1, 35))) & Space(1) & "|")
                    Filewrite.Write(Space(14 - Len(Mid(.Text, 1, 12))) & Mid(.Text, 1, 12) & Space(1) & "|")
                    .Col = 3
                    'Filewrite.Write(Space(14 - Len(Mid(.Text, 1, 12))) & Mid(.Text, 1, 12) & Space(1) & "|")
                    Filewrite.Write(Mid(.Text, 1, 35) & Space(35 - Len(Mid(.Text, 1, 35))) & Space(1) & "|")
                    .Col = 4
                    Filewrite.Write(Space(14 - Len(Mid(.Text, 1, 12))) & Mid(.Text, 1, 12) & Space(1) & "|")
                    .Col = 5
                    Filewrite.Write(Space(10 - Len(Mid(.Text, 1, 10))) & Mid(.Text, 1, 10) & Space(1) & "|")
                    .Col = 6
                    Filewrite.Write(Space(1) & Mid(.Text, 1, 13) & Space(13 - Len(Mid(.Text, 1, 13))) & "|")
                    .Col = 7
                    Filewrite.Write(Space(1) & Mid(.Text, 1, 12) & Space(12 - Len(Mid(.Text, 1, 12))) & "|")
                    Filewrite.WriteLine("")
                    vRowcnt = vRowcnt + 1
                End With
            Next
        Else ' FOR SELECTED FIELDS 

        End If
        Filewrite.WriteLine(StrDup(138, "-"))
        'Filewrite.WriteLine(Space(72) & "    TOTAL:     " & Space(10 - Len(Mid(TOT_DEBIT, 1, 10))) & Format(Val(Mid(TOT_DEBIT, 1, 10)), "0.00") & " " & Space(10 - Len(Mid(TOT_CREDIT, 1, 10))) & Format(Val(Mid(TOT_CREDIT, 1, 10)), "0.00"))
        'Filewrite.WriteLine(StrDup(138, "-"))
        Filewrite.Write(Chr(12))
        Filewrite.Close()
        If PRINTREP = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(vOutfile)
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
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
    Private Sub tbx_filter_To_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cmb_add_filter.Focus()
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            chk_Filter_Field.Focus()
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

    Private Sub Chk_SelectAllMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllMember.CheckedChanged
        Dim Iteration As Integer
        If Chk_SelectAllMember.Checked = True Then
            Try
                For Iteration = 0 To (Chk_Members_List.Items.Count - 1)
                    Chk_Members_List.SetSelected(Iteration, True)
                    Chk_Members_List.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_Members_List.Items.Count - 1)
                    Chk_Members_List.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Btn_Close_DOJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Grb_DOJ_Wise.Visible = False
    End Sub

    Private Sub Cmb_DOJ_From_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Cmb_DOJ_To.Focus()
        End If
    End Sub

    Private Sub Cmb_DOJ_To_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Btn_Close_DOJ.Focus()
        End If
    End Sub

    Private Sub Cmd_Display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Display.Click
        'SSGRID.Visible = True
        'SSGRID.BringToFront()
        Call GRID_VIEW()
        If SSGRID.DataRowCnt > 0 Then
            SSGRID.BringToFront()
            CmdView.Enabled = True
            cmdPrint.Enabled = True
        End If

    End Sub
    'LIN
    'chkexp
    Function GRID_VIEW()
        Dim Ssql As String
        Dim vsplit() As String
        Dim Total, Debit, Credit, RowNo, I, J As Double
        Dim mtypecode(), mcodes(), mcurrentstatus(), fields, fieldsgroup(300) As String
        Dim whereorand As Boolean = False
        Total = 0
        Debit = 0
        Credit = 0
        'SSGRID.ClearRange(1, 1, -1, -1, True)
        'REPORT FIELDS SELECTION
        If Chk_Field_Yes.Checked = False Then 'BY DEFAULT FIELDS
            Ssql = " SELECT ISNULL(MCODE,'') AS MCODE, ISNULL(MNAME,'') AS MNAME, ISNULL(DOJ,'') AS DOJ, "
            Ssql = Ssql & " ISNULL(DOB,'') AS DOB, ISNULL(TYPEDESC,'') AS MEMBERTYPECODE,  "
            Ssql = Ssql & " ISNULL(CURENTSTATUS,'') AS CURENTSTATUS,ISNULL(MEMBERSHIPTO,'') AS MEMBERSHIPTO FROM MEMBERMASTER INNER JOIN MEMBERTYPE ON MEMBERTYPECODE = MEMBERTYPE.MEMBERTYPE "
        Else ' SELECTED FIELDS
            If Chk_Field_Selection.CheckedItems.Count <> 0 Then
                whereorand = True
                Ssql = Ssql & " SELECT MCODE,MNAME,"
                For I = 0 To Chk_Field_Selection.CheckedItems.Count - 1
                    fields = Chk_Field_Selection.CheckedItems(I)
                    fieldsgroup(I) = Chk_Field_Selection.CheckedItems(I)
                    Ssql = Ssql & " " & fields & ", "
                Next
                Ssql = Mid(Ssql, 1, Len(Ssql) - 2)
                Ssql = Ssql & " ,TYPEDESC FROM MEMBERMASTER INNER JOIN MEMBERTYPE ON MEMBERTYPECODE = MEMBERTYPE.MEMBERTYPE "
            End If
        End If

        'Member(Type Or CATEGORY)
        ''If chk_Filter_Field.CheckedItems.Count <> 0 Then
        ''    whereorand = False
        ''    Ssql = Ssql & " AND TYPEDESC IN ("
        ''    For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
        ''        mtypecode = Split(chk_Filter_Field.CheckedItems(I), "==>")
        ''        Ssql = Ssql & " '" & mtypecode(1) & "', "
        ''    Next
        ''    Ssql = Mid(Ssql, 1, Len(Ssql) - 2)
        ''    Ssql = Ssql & ")"
        ''End If
        If chk_Filter_Field.CheckedItems.Count <> 0 Then
            whereorand = False
            Ssql = Ssql & " AND MEMBERTYPE.membertype IN ("
            For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
                mtypecode = Split(chk_Filter_Field.CheckedItems(I), "==>")
                Ssql = Ssql & " '" & mtypecode(0) & "', "
            Next
            Ssql = Mid(Ssql, 1, Len(Ssql) - 2)
            Ssql = Ssql & ")"
        End If
        'MEMBER CODE
        'If Chk_Members_List.CheckedItems.Count <> 0 Then
        '    If whereorand = True Then
        '        Ssql = Ssql & " AND MCODE IN ("
        '    Else
        '        whereorand = True
        '        Ssql = Ssql & " WHERE MCODE IN ("
        '    End If
        '    For I = 0 To Chk_Members_List.CheckedItems.Count - 1
        '        mcodes = Split(Chk_Members_List.CheckedItems(I), "-->")
        '        Ssql = Ssql & " '" & mcodes(0) & "', "
        '    Next
        '    Ssql = Mid(Ssql, 1, Len(Ssql) - 2)
        '    Ssql = Ssql & ")"
        'End If
        'MEMBER STATUS
        If ChK_Memberstatus.CheckedItems.Count <> 0 Then
            If whereorand = True Then
                Ssql = Ssql & " AND CURENTSTATUS IN ("
            Else
                whereorand = True
                Ssql = Ssql & " WHERE CURENTSTATUS IN ("
            End If

            For I = 0 To ChK_Memberstatus.CheckedItems.Count - 1
                mcurrentstatus = Split(ChK_Memberstatus.CheckedItems(I), ".")
                Ssql = Ssql & " '" & mcurrentstatus(1) & "', "
            Next
            Ssql = Mid(Ssql, 1, Len(Ssql) - 2)
            Ssql = Ssql & ")"
        Else
            MsgBox("Please Select The Status", vbInformation)
            Exit Function
        End If
        'MEMBER DATE OF JOIN BETWEEN
        If Chk_DOJ.Checked = True Then
            If whereorand = True Then
                Ssql = Ssql & " AND ISNULL(DOJ,'') BETWEEN '" & Format(Cmb_DOJ_From.Value, "dd/MMM/yyyy") & "' AND '" & Format(Cmb_DOJ_To.Value, "dd/MMM/yyyy") & "' "
            Else
                whereorand = True
                Ssql = Ssql & " WHERE ISNULL(DOJ,'') BETWEEN '" & Format(Cmb_DOJ_From.Value, "dd/MMM/yyyy") & "' AND '" & Format(Cmb_DOJ_To.Value, "dd/MMM/yyyy") & "' "
            End If
            'ElseIf chkexp.Checked = True Then
        ElseIf RDB_WITHINJOIN.Checked = True Then
            Ssql = Ssql & " AND ISNULL(doj,'') between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' and  '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "' "
        ElseIf RDB_ASONDATE.Checked = True Then
            Ssql = Ssql & " AND ISNULL(Membershipto,'') >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' "
        ElseIf RDB_EXPIRED.Checked = True Then
            Ssql = Ssql & " AND Membershipto between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' and  '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "' "
        End If
        'REPORT ORDER BY
        If Opt_Mcode.Checked = True Then
            'Ssql = Ssql & " ORDER BY MCODE,MNAME "
            Ssql = Ssql & " ORDER BY prefixmcode,msorderno,mcode asc "

        ElseIf Opt_Mname.Checked = True Then
            Ssql = Ssql & " ORDER BY MNAME "
            'Ssql = Ssql & " ORDER BY prefixmcode,msorderno,mcode asc "
        ElseIf Opt_Category.Checked = True Then
            Ssql = Ssql & " ORDER BY MEMBERTYPECODE "

        ElseIf Opt_DOJ.Checked = True Then
            Ssql = Ssql & " ORDER BY DOJ "
        ElseIf Opt_DOB.Checked = True Then
            Ssql = Ssql & " ORDER BY DOB "
        End If
        gconnection.getDataSet(Ssql, "MEMBERMASTER")
        If gdataset.Tables("MEMBERMASTER").Rows.Count = 0 Then
            MsgBox("No Records Available ", vbInformation + vbOKOnly, "MESSAGE")
        Else
            SSGRID.Visible = True
            SSGRID.BringToFront()
            SSGRID.ClearRange(1, 1, -1, -1, True)
            If Chk_Field_Yes.Checked = False Then
                With SSGRID
                    .Row = 1
                    .Col = 1
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "SNO"
                    .Row = 1
                    .Col = 2
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "MCODE"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(1) Then
                        .set_ColWidth(1, J)
                    End If
                    .Col = 3
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "NAME"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(2) Then
                        .set_ColWidth(2, J)
                    End If
                    .Col = 4
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "DOJ"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(3) Then
                        .set_ColWidth(3, J)
                    End If
                    .Col = 5
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "DOB"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(4) Then
                        .set_ColWidth(4, J)
                    End If
                    .Col = 6
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "CATEGORY"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(5) Then
                        .set_ColWidth(5, J)
                    End If
                    .Col = 7
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "STATUS"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(6) Then
                        .set_ColWidth(6, J)
                    End If
                    .Col = 8
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "MEMBERSHIPTO"
                    J = .Text.Length + 2
                    If J > .get_ColWidth(7) Then
                        .set_ColWidth(7, J)
                    End If
                End With
            Else
                With SSGRID
                    .Row = 1
                    .Col = 1
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "SNO"
                    .Row = 1
                    .Col = 2
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "MCODE"
                    .Col = 3
                    .BackColor = Color.MistyRose
                    .FontBold = True
                    .ForeColor = Color.MediumVioletRed
                    .Text = "NAME"
                    If Chk_Field_Selection.CheckedItems.Count <> 0 Then
                        For I = 0 To Chk_Field_Selection.CheckedItems.Count - 1
                            fields = Chk_Field_Selection.CheckedItems(I)
                            .Row = 1
                            .Col = I + 3
                            .BackColor = Color.MistyRose
                            .FontBold = True
                            .ForeColor = Color.MediumVioletRed
                            .Text = Trim(fields)
                        Next
                    End If
                End With
            End If
            If Chk_Field_Yes.Checked = False Then 'FOR DEFAULT FIELDS PRINTING
                For I = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
                    With SSGRID
                        .Row = I + 2
                        .Col = 1
                        .Text = CStr(I + 1)
                        .Col = 2
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MCODE").ToString.Length + 2
                        If J > .get_ColWidth(1) Then
                            .set_ColWidth(1, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MCODE") & "")
                        .Col = 3
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MNAME").ToString.Length + 2
                        If J > .get_ColWidth(2) Then
                            .set_ColWidth(2, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MNAME") & "")
                        .Col = 4
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("DOJ").ToString.Length + 2
                        If J > .get_ColWidth(3) Then
                            .set_ColWidth(3, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("DOJ") & "")
                        .Col = 5
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("DOB").ToString.Length + 2
                        If J > .get_ColWidth(4) Then
                            .set_ColWidth(4, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("DOB") & "")
                        .Col = 6
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MEMBERTYPECODE").ToString.Length + 2
                        If J > .get_ColWidth(5) Then
                            .set_ColWidth(5, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MEMBERTYPECODE") & "")
                        .Col = 7
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("CURENTSTATUS").ToString.Length + 2
                        If J > .get_ColWidth(6) Then
                            .set_ColWidth(6, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("CURENTSTATUS") & "")
                        .Col = 8
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MEMBERSHIPTO").ToString.Length + 2
                        If J > .get_ColWidth(7) Then
                            .set_ColWidth(7, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MEMBERSHIPTO") & "")
                    End With
                    If SSGRID.MaxRows < I + 20 Then
                        SSGRID.MaxRows = SSGRID.MaxRows + 100
                    End If
                Next
            Else 'FOR SELECTED FIELDS PRINTNIG WITH MCODE,MNAME
                For I = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
                    With SSGRID
                        .Row = I + 2
                        .Col = 1
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MCODE").ToString.Length + 2
                        If J > .get_ColWidth(1) Then
                            .set_ColWidth(1, J)
                        End If
                        .Text = CStr(I + 1)
                        .Col = 2
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MCODE") & "")
                        .Col = 3
                        J = gdataset.Tables("MEMBERMASTER").Rows(I).Item("MNAME").ToString.Length + 2
                        If J > .get_ColWidth(2) Then
                            .set_ColWidth(2, J)
                        End If
                        .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(I).Item("MNAME") & "")
                    End With
                Next
                Dim K
                For K = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
                    For I = 0 To Chk_Field_Selection.CheckedItems.Count - 1
                        With SSGRID
                            .Row = K + 2
                            .Col = I + 3
                            Dim tmpstring As String
                            tmpstring = Trim(fieldsgroup(I))
                            J = Trim(gdataset.Tables("MEMBERMASTER").Rows(K).Item(tmpstring) & "").Length + 2
                            If J > .get_ColWidth(I + 3) Then
                                .set_ColWidth(I + 3, J)
                            End If
                            .Text = Trim(gdataset.Tables("MEMBERMASTER").Rows(K).Item(tmpstring) & "")
                        End With
                    Next
                Next
            End If
        End If
        SSGRID.Focus()
        SSGRID.SetActiveCell(1, 1)
    End Function

    Private Sub Chk_Options_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Options.CheckedChanged
        If Me.Chk_Options.Checked = True Then
            Call FieldFill()
            Grb_DOJ_Wise.Visible = True
            Chk_DOJ.Focus()
        Else
            Grb_DOJ_Wise.Visible = False
            Chk_Options.Focus()
        End If
    End Sub

    Private Sub Cmd_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Export.Click
        Try
            If SSGRID.Visible = True Then
                Call ExportTo(SSGRID)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Btn_Close_DOJ_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Close_DOJ.Click
        Grb_DOJ_Wise.Visible = False
    End Sub

    Private Sub Grb_DOJ_Wise_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grb_DOJ_Wise.Enter

    End Sub

    Private Sub Chk_DOJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_DOJ.CheckedChanged
        If Chk_DOJ.Checked = True Then
            Cmb_DOJ_From.Enabled = True
            Cmb_DOJ_To.Enabled = True
            Cmb_DOJ_From.Focus()
        Else
            Cmb_DOJ_From.Enabled = False
            Cmb_DOJ_To.Enabled = False
        End If
    End Sub
    Private Sub chk_Filter_Field_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.DoubleClick
        'Dim ssql, mtypecode() As String
        'Dim i, j As Integer
        'For j = 0 To chk_Filter_Field.Items.Count - 1
        '    If chk_Filter_Field.GetItemChecked(j) = True Then
        '        ssql = " SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME from MEMBERMASTER "
        '        ssql = ssql & " WHERE MEMBERTYPECODE IN ("
        '        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
        '            mtypecode = Split(chk_Filter_Field.CheckedItems(i), "==>")
        '            ssql = ssql & " '" & mtypecode(0) & "', "
        '        Next
        '        ssql = Mid(ssql, 1, Len(ssql) - 2)
        '        ssql = ssql & ")"
        '        gconnection.getDataSet(ssql, "MEMBERVIEW")
        '        If gdataset.Tables("MEMBERVIEW").Rows.Count > 0 Then
        '            Chk_Members_List.Items.Clear()
        '            For i = 0 To gdataset.Tables("MEMBERVIEW").Rows.Count - 1
        '                With gdataset.Tables("MEMBERVIEW").Rows(i)
        '                    Chk_Members_List.Items.Add(Trim(.Item("MCODE") & "-->" & .Item("MNAME")))
        '                End With
        '            Next i
        '        End If
        '        Chk_Members_List.Sorted = True
        '    End If
        'Next
    End Sub
    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged
        Dim ssql, mtypecode() As String
        Dim i, j As Integer
        'For j = 0 To chk_Filter_Field.Items.Count - 1
        '    If chk_Filter_Field.GetItemChecked(j) = True Then
        '        ssql = " SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME from MEMBERMASTER "
        '        ssql = ssql & " WHERE MEMBERTYPECODE IN ("
        '        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
        '            mtypecode = Split(chk_Filter_Field.CheckedItems(i), ".")
        '            ssql = ssql & " '" & mtypecode(0) & "', "
        '        Next
        '        ssql = Mid(ssql, 1, Len(ssql) - 2)
        '        ssql = ssql & ")"
        '        gconnection.getDataSet(ssql, "MEMBERVIEW")
        '        If gdataset.Tables("MEMBERVIEW").Rows.Count > 0 Then
        '            Chk_Members_List.Items.Clear()
        '            For i = 0 To gdataset.Tables("MEMBERVIEW").Rows.Count - 1
        '                With gdataset.Tables("MEMBERVIEW").Rows(i)
        '                    Chk_Members_List.Items.Add(Trim(.Item("MCODE") & "-->" & .Item("MNAME")))
        '                End With
        '            Next i
        '        End If
        '        Chk_Members_List.Sorted = True
        '    End If
        'Next
    End Sub

    Private Sub Chk_All_Category_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_All_Category.CheckedChanged
        If Chk_All_Category.Checked = False Then
            chk_PrintAll.Enabled = True
            chk_Filter_Field.Enabled = True
        Else
            chk_PrintAll.Enabled = False
            chk_Filter_Field.Enabled = False
        End If
    End Sub

    Private Sub Chk_All_Member_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_All_Member.CheckedChanged
        If Chk_All_Member.Checked = False Then
            Chk_SelectAllMember.Enabled = True
            Chk_Members_List.Enabled = True
        Else
            Chk_SelectAllMember.Enabled = False
            Chk_Members_List.Enabled = False
        End If
    End Sub

    Private Sub Chk_Field_Yes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Field_Yes.CheckedChanged

    End Sub
    Private Sub RDB_ASONDATE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_ASONDATE.CheckedChanged
        If RDB_ASONDATE.Checked = True Then
            LAB_ASONDATE.Visible = True
            LAB_FROMDATE.Visible = False
            LAB_TODATE.Visible = False
            Dtp_To.Visible = False
        Else
            LAB_ASONDATE.Visible = False
            LAB_FROMDATE.Visible = True
            LAB_TODATE.Visible = True
            Dtp_To.Visible = True
        End If
    End Sub
    Private Sub RDB_WITHINJOIN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_WITHINJOIN.CheckedChanged
        If RDB_ASONDATE.Checked = True Then
            LAB_ASONDATE.Visible = True
            LAB_FROMDATE.Visible = False
            LAB_TODATE.Visible = False
            Dtp_To.Visible = False
        Else
            LAB_ASONDATE.Visible = False
            LAB_FROMDATE.Visible = True
            LAB_TODATE.Visible = True
            Dtp_To.Visible = True
        End If
    End Sub
    Private Sub RDB_EXPIRED_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_EXPIRED.CheckedChanged
        If RDB_ASONDATE.Checked = True Then
            LAB_ASONDATE.Visible = True
            LAB_FROMDATE.Visible = False
            LAB_TODATE.Visible = False
            Dtp_To.Visible = False
        Else
            LAB_ASONDATE.Visible = False
            LAB_FROMDATE.Visible = True
            LAB_TODATE.Visible = True
            Dtp_To.Visible = True
        End If
    End Sub
End Class