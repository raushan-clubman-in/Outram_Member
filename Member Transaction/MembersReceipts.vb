Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports ADODB
Public Class MembersReceipts
    Inherits System.Windows.Forms.Form
    Public gclsConnection As New GlobalClass
    Public gFinancialEnd As String
    Public chkdatevalidate As Boolean
    Public MatchTable As DataTable
    Public GCroAmt As Double
    Public PageNo As Integer
    Dim gconnection As New GlobalClass
    Dim Index As Long
    Dim VCONN As New GlobalClass
    Dim VSEARCH, CreditsDebits, SDCSql, gvoucherprefix, gBudget, GcroUser As String
    Dim Glindex, GbatchNo As Integer
    Dim Cindex As Integer
    Dim GcroDate As Date
    Dim total As Double = 0
    Dim Updateyes As Boolean
    'Dim gMatch, gMatchAccountcode As New DataSet
    'Refer
    'Added on 25 May'07
    'Begin
    Dim strPostingTo, strPostingAgainst As String
    Dim CreDeb As String
    Dim CreAmt, DebAmt As Double
    'End
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dtp_VoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_MICRNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Naration As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PaidTo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_VoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_VoucherType As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_InstNo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_BankPlace As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_InstDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_InstType As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_CashBank As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_VoucherPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Grp_Instrument As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cmb_GlCode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_UserName As System.Windows.Forms.Label
    Friend WithEvents Dtp_Transdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_Transdate As System.Windows.Forms.Label
    Friend WithEvents Lbl_LastVoucher As System.Windows.Forms.Label
    Friend WithEvents lbl_void As System.Windows.Forms.Label
    Friend WithEvents Cmd_VoucherNoHelp As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chk_chkprinting As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_DrawebankName As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_BankHelp As System.Windows.Forms.Button
    Friend WithEvents cc As System.Windows.Forms.Button
    Friend WithEvents CmdAdd1 As System.Windows.Forms.Button
    Friend WithEvents CmdDelete1 As System.Windows.Forms.Button
    Friend WithEvents CmdView1 As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdexit1 As System.Windows.Forms.Button
    Friend WithEvents cmdPrint1 As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Txt_bankCode As System.Windows.Forms.TextBox
    Friend WithEvents SSGrid_ReceiptsPayments As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MembersReceipts))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Dtp_VoucherDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_InstNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txt_BankPlace = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txt_MICRNo = New System.Windows.Forms.TextBox
        Me.Cmb_CashBank = New System.Windows.Forms.ComboBox
        Me.Dtp_InstDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Txt_bankCode = New System.Windows.Forms.TextBox
        Me.Dtp_Transdate = New System.Windows.Forms.DateTimePicker
        Me.Lbl_Transdate = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Lbl_UserName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Cmb_GlCode = New System.Windows.Forms.ComboBox
        Me.Cmd_BankHelp = New System.Windows.Forms.Button
        Me.Txt_DrawebankName = New System.Windows.Forms.TextBox
        Me.Cmd_VoucherNoHelp = New System.Windows.Forms.Button
        Me.Txt_VoucherPrefix = New System.Windows.Forms.TextBox
        Me.Cmb_VoucherType = New System.Windows.Forms.ComboBox
        Me.Txt_VoucherNo = New System.Windows.Forms.TextBox
        Me.Txt_PaidTo = New System.Windows.Forms.TextBox
        Me.Txt_Naration = New System.Windows.Forms.TextBox
        Me.Grp_Instrument = New System.Windows.Forms.GroupBox
        Me.chk_chkprinting = New System.Windows.Forms.CheckBox
        Me.Cmb_InstType = New System.Windows.Forms.ComboBox
        Me.Txt_Total = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cc = New System.Windows.Forms.Button
        Me.CmdAdd1 = New System.Windows.Forms.Button
        Me.CmdDelete1 = New System.Windows.Forms.Button
        Me.CmdView1 = New System.Windows.Forms.Button
        Me.cmdexit1 = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.cmdPrint1 = New System.Windows.Forms.Button
        Me.Lbl_LastVoucher = New System.Windows.Forms.Label
        Me.lbl_void = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.SSGrid_ReceiptsPayments = New AxFPSpreadADO.AxfpSpread
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Instrument.SuspendLayout()
        Me.frmbut.SuspendLayout()
        CType(Me.SSGrid_ReceiptsPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(520, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "DOC  NO  :"
        '
        'Dtp_VoucherDate
        '
        Me.Dtp_VoucherDate.CustomFormat = "dd-MMM-yyyy"
        Me.Dtp_VoucherDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_VoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_VoucherDate.Location = New System.Drawing.Point(208, 160)
        Me.Dtp_VoucherDate.Name = "Dtp_VoucherDate"
        Me.Dtp_VoucherDate.Size = New System.Drawing.Size(112, 22)
        Me.Dtp_VoucherDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "DOC DATE   :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 22)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = " BANK CODE  :"
        '
        'Txt_InstNo
        '
        Me.Txt_InstNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_InstNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_InstNo.Location = New System.Drawing.Point(224, 472)
        Me.Txt_InstNo.Name = "Txt_InstNo"
        Me.Txt_InstNo.Size = New System.Drawing.Size(152, 22)
        Me.Txt_InstNo.TabIndex = 6
        Me.Txt_InstNo.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 22)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "INSTRUMENT NO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 22)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "INSTRUMENT DATE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 22)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "INSTRUMENT TYPE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1040, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "MICR NO :"
        Me.Label5.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(560, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 18)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "DRAWEE BANK  :"
        '
        'Txt_BankPlace
        '
        Me.Txt_BankPlace.Location = New System.Drawing.Point(616, 120)
        Me.Txt_BankPlace.Name = "Txt_BankPlace"
        Me.Txt_BankPlace.Size = New System.Drawing.Size(192, 20)
        Me.Txt_BankPlace.TabIndex = 4
        Me.Txt_BankPlace.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(560, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "PLACE :"
        '
        'Txt_MICRNo
        '
        Me.Txt_MICRNo.Location = New System.Drawing.Point(888, 744)
        Me.Txt_MICRNo.Name = "Txt_MICRNo"
        Me.Txt_MICRNo.Size = New System.Drawing.Size(88, 20)
        Me.Txt_MICRNo.TabIndex = 5
        Me.Txt_MICRNo.Text = ""
        Me.Txt_MICRNo.Visible = False
        Me.Txt_MICRNo.WordWrap = False
        '
        'Cmb_CashBank
        '
        Me.Cmb_CashBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_CashBank.Location = New System.Drawing.Point(960, 128)
        Me.Cmb_CashBank.Name = "Cmb_CashBank"
        Me.Cmb_CashBank.Size = New System.Drawing.Size(224, 21)
        Me.Cmb_CashBank.TabIndex = 3
        '
        'Dtp_InstDate
        '
        Me.Dtp_InstDate.CustomFormat = "dd-MMM-yyyy"
        Me.Dtp_InstDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_InstDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_InstDate.Location = New System.Drawing.Point(224, 504)
        Me.Dtp_InstDate.Name = "Dtp_InstDate"
        Me.Dtp_InstDate.Size = New System.Drawing.Size(128, 22)
        Me.Dtp_InstDate.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txt_bankCode)
        Me.GroupBox1.Controls.Add(Me.Dtp_Transdate)
        Me.GroupBox1.Controls.Add(Me.Lbl_Transdate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Cmb_CashBank)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Lbl_UserName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(-104, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Txt_bankCode
        '
        Me.Txt_bankCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bankCode.Location = New System.Drawing.Point(-72, 88)
        Me.Txt_bankCode.Name = "Txt_bankCode"
        Me.Txt_bankCode.Size = New System.Drawing.Size(72, 26)
        Me.Txt_bankCode.TabIndex = 137
        Me.Txt_bankCode.Text = ""
        Me.Txt_bankCode.Visible = False
        '
        'Dtp_Transdate
        '
        Me.Dtp_Transdate.CustomFormat = "dd-MMM-yyyy"
        Me.Dtp_Transdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Transdate.Location = New System.Drawing.Point(656, 192)
        Me.Dtp_Transdate.Name = "Dtp_Transdate"
        Me.Dtp_Transdate.Size = New System.Drawing.Size(144, 20)
        Me.Dtp_Transdate.TabIndex = 130
        Me.Dtp_Transdate.Visible = False
        '
        'Lbl_Transdate
        '
        Me.Lbl_Transdate.AutoSize = True
        Me.Lbl_Transdate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Transdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Transdate.Location = New System.Drawing.Point(960, 145)
        Me.Lbl_Transdate.Name = "Lbl_Transdate"
        Me.Lbl_Transdate.Size = New System.Drawing.Size(83, 18)
        Me.Lbl_Transdate.TabIndex = 131
        Me.Lbl_Transdate.Text = "CRO DATE :"
        Me.Lbl_Transdate.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(808, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "ACCOUNT HEAD"
        Me.Label11.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(48, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 22)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "TRAN TYPE  :"
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.Location = New System.Drawing.Point(40, 112)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(120, 40)
        Me.Lbl_UserName.TabIndex = 79
        Me.Lbl_UserName.Text = "PAID TO / REC FROM    :"
        Me.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(608, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 22)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "NARRATION :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(968, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 16)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "[F2]"
        Me.Label13.Visible = False
        '
        'Cmb_GlCode
        '
        Me.Cmb_GlCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_GlCode.Enabled = False
        Me.Cmb_GlCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_GlCode.Location = New System.Drawing.Point(208, 200)
        Me.Cmb_GlCode.Name = "Cmb_GlCode"
        Me.Cmb_GlCode.Size = New System.Drawing.Size(144, 24)
        Me.Cmb_GlCode.TabIndex = 2
        '
        'Cmd_BankHelp
        '
        Me.Cmd_BankHelp.BackColor = System.Drawing.Color.White
        Me.Cmd_BankHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_BankHelp.ForeColor = System.Drawing.Color.White
        Me.Cmd_BankHelp.Image = CType(resources.GetObject("Cmd_BankHelp.Image"), System.Drawing.Image)
        Me.Cmd_BankHelp.Location = New System.Drawing.Point(688, 192)
        Me.Cmd_BankHelp.Name = "Cmd_BankHelp"
        Me.Cmd_BankHelp.Size = New System.Drawing.Size(40, 24)
        Me.Cmd_BankHelp.TabIndex = 136
        Me.Cmd_BankHelp.Visible = False
        '
        'Txt_DrawebankName
        '
        Me.Txt_DrawebankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DrawebankName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DrawebankName.Location = New System.Drawing.Point(672, 16)
        Me.Txt_DrawebankName.Name = "Txt_DrawebankName"
        Me.Txt_DrawebankName.Size = New System.Drawing.Size(104, 22)
        Me.Txt_DrawebankName.TabIndex = 2
        Me.Txt_DrawebankName.Text = ""
        Me.Txt_DrawebankName.Visible = False
        '
        'Cmd_VoucherNoHelp
        '
        Me.Cmd_VoucherNoHelp.BackColor = System.Drawing.Color.White
        Me.Cmd_VoucherNoHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_VoucherNoHelp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_VoucherNoHelp.ForeColor = System.Drawing.Color.White
        Me.Cmd_VoucherNoHelp.Image = CType(resources.GetObject("Cmd_VoucherNoHelp.Image"), System.Drawing.Image)
        Me.Cmd_VoucherNoHelp.Location = New System.Drawing.Point(672, 120)
        Me.Cmd_VoucherNoHelp.Name = "Cmd_VoucherNoHelp"
        Me.Cmd_VoucherNoHelp.Size = New System.Drawing.Size(32, 24)
        Me.Cmd_VoucherNoHelp.TabIndex = 132
        '
        'Txt_VoucherPrefix
        '
        Me.Txt_VoucherPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_VoucherPrefix.Enabled = False
        Me.Txt_VoucherPrefix.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VoucherPrefix.Location = New System.Drawing.Point(360, 120)
        Me.Txt_VoucherPrefix.Name = "Txt_VoucherPrefix"
        Me.Txt_VoucherPrefix.Size = New System.Drawing.Size(64, 22)
        Me.Txt_VoucherPrefix.TabIndex = 127
        Me.Txt_VoucherPrefix.Text = ""
        '
        'Cmb_VoucherType
        '
        Me.Cmb_VoucherType.DisplayMember = "0"
        Me.Cmb_VoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_VoucherType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_VoucherType.Items.AddRange(New Object() {"BANK RECEPITS", "CASH RECEPITS", "CREDITCARD RECEPITS"})
        Me.Cmb_VoucherType.Location = New System.Drawing.Point(208, 120)
        Me.Cmb_VoucherType.Name = "Cmb_VoucherType"
        Me.Cmb_VoucherType.Size = New System.Drawing.Size(152, 24)
        Me.Cmb_VoucherType.TabIndex = 0
        '
        'Txt_VoucherNo
        '
        Me.Txt_VoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_VoucherNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VoucherNo.Location = New System.Drawing.Point(512, 120)
        Me.Txt_VoucherNo.Name = "Txt_VoucherNo"
        Me.Txt_VoucherNo.Size = New System.Drawing.Size(160, 22)
        Me.Txt_VoucherNo.TabIndex = 1
        Me.Txt_VoucherNo.Text = ""
        '
        'Txt_PaidTo
        '
        Me.Txt_PaidTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PaidTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PaidTo.Location = New System.Drawing.Point(208, 240)
        Me.Txt_PaidTo.Name = "Txt_PaidTo"
        Me.Txt_PaidTo.Size = New System.Drawing.Size(272, 22)
        Me.Txt_PaidTo.TabIndex = 4
        Me.Txt_PaidTo.Text = ""
        '
        'Txt_Naration
        '
        Me.Txt_Naration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Naration.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Naration.Location = New System.Drawing.Point(448, 192)
        Me.Txt_Naration.MaxLength = 137
        Me.Txt_Naration.Name = "Txt_Naration"
        Me.Txt_Naration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Naration.Size = New System.Drawing.Size(240, 22)
        Me.Txt_Naration.TabIndex = 3
        Me.Txt_Naration.Text = ""
        '
        'Grp_Instrument
        '
        Me.Grp_Instrument.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Instrument.Controls.Add(Me.chk_chkprinting)
        Me.Grp_Instrument.Controls.Add(Me.Label6)
        Me.Grp_Instrument.Controls.Add(Me.Label1)
        Me.Grp_Instrument.Controls.Add(Me.Label12)
        Me.Grp_Instrument.Controls.Add(Me.Label9)
        Me.Grp_Instrument.Controls.Add(Me.Txt_BankPlace)
        Me.Grp_Instrument.Controls.Add(Me.Label8)
        Me.Grp_Instrument.Location = New System.Drawing.Point(1008, 416)
        Me.Grp_Instrument.Name = "Grp_Instrument"
        Me.Grp_Instrument.Size = New System.Drawing.Size(32, 128)
        Me.Grp_Instrument.TabIndex = 3
        Me.Grp_Instrument.TabStop = False
        Me.Grp_Instrument.Visible = False
        '
        'chk_chkprinting
        '
        Me.chk_chkprinting.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_chkprinting.Location = New System.Drawing.Point(344, 88)
        Me.chk_chkprinting.Name = "chk_chkprinting"
        Me.chk_chkprinting.Size = New System.Drawing.Size(152, 24)
        Me.chk_chkprinting.TabIndex = 135
        Me.chk_chkprinting.Text = "Cheque Printing"
        Me.chk_chkprinting.Visible = False
        '
        'Cmb_InstType
        '
        Me.Cmb_InstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_InstType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_InstType.Items.AddRange(New Object() {"CHEQUE", "DD", "PO", "CREDITCARD"})
        Me.Cmb_InstType.Location = New System.Drawing.Point(224, 440)
        Me.Cmb_InstType.Name = "Cmb_InstType"
        Me.Cmb_InstType.Size = New System.Drawing.Size(160, 24)
        Me.Cmb_InstType.TabIndex = 5
        '
        'Txt_Total
        '
        Me.Txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Total.Enabled = False
        Me.Txt_Total.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.Location = New System.Drawing.Point(552, 408)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(120, 22)
        Me.Txt_Total.TabIndex = 84
        Me.Txt_Total.Text = ""
        Me.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1040, 344)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 18)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "TOTAL :"
        Me.Label15.Visible = False
        '
        'cc
        '
        Me.cc.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cc.Location = New System.Drawing.Point(16, 16)
        Me.cc.Name = "cc"
        Me.cc.Size = New System.Drawing.Size(74, 32)
        Me.cc.TabIndex = 1
        Me.cc.Text = "Clear [F6]"
        '
        'CmdAdd1
        '
        Me.CmdAdd1.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdAdd1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdAdd1.Location = New System.Drawing.Point(104, 16)
        Me.CmdAdd1.Name = "CmdAdd1"
        Me.CmdAdd1.Size = New System.Drawing.Size(79, 32)
        Me.CmdAdd1.TabIndex = 0
        Me.CmdAdd1.Text = "Add [F7]"
        '
        'CmdDelete1
        '
        Me.CmdDelete1.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdDelete1.Enabled = False
        Me.CmdDelete1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdDelete1.Location = New System.Drawing.Point(200, 16)
        Me.CmdDelete1.Name = "CmdDelete1"
        Me.CmdDelete1.Size = New System.Drawing.Size(77, 32)
        Me.CmdDelete1.TabIndex = 2
        Me.CmdDelete1.Text = "Delete[F8]"
        '
        'CmdView1
        '
        Me.CmdView1.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdView1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdView1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdView1.Location = New System.Drawing.Point(296, 16)
        Me.CmdView1.Name = "CmdView1"
        Me.CmdView1.Size = New System.Drawing.Size(79, 32)
        Me.CmdView1.TabIndex = 3
        Me.CmdView1.Text = "View[F9]"
        '
        'cmdexit1
        '
        Me.cmdexit1.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmdexit1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdexit1.Location = New System.Drawing.Point(496, 16)
        Me.cmdexit1.Name = "cmdexit1"
        Me.cmdexit1.Size = New System.Drawing.Size(78, 32)
        Me.cmdexit1.TabIndex = 4
        Me.cmdexit1.Text = "Exit [F11]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CmdAdd1)
        Me.frmbut.Controls.Add(Me.CmdDelete1)
        Me.frmbut.Controls.Add(Me.CmdView1)
        Me.frmbut.Controls.Add(Me.cmdexit1)
        Me.frmbut.Controls.Add(Me.cc)
        Me.frmbut.Controls.Add(Me.cmdPrint1)
        Me.frmbut.Location = New System.Drawing.Point(-632, 568)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(632, 64)
        Me.frmbut.TabIndex = 4
        Me.frmbut.TabStop = False
        Me.frmbut.Visible = False
        '
        'cmdPrint1
        '
        Me.cmdPrint1.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmdPrint1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdPrint1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdPrint1.Location = New System.Drawing.Point(392, 16)
        Me.cmdPrint1.Name = "cmdPrint1"
        Me.cmdPrint1.Size = New System.Drawing.Size(79, 32)
        Me.cmdPrint1.TabIndex = 3
        Me.cmdPrint1.Text = "Print [F12]"
        '
        'Lbl_LastVoucher
        '
        Me.Lbl_LastVoucher.AutoSize = True
        Me.Lbl_LastVoucher.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LastVoucher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LastVoucher.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lbl_LastVoucher.Location = New System.Drawing.Point(504, 240)
        Me.Lbl_LastVoucher.Name = "Lbl_LastVoucher"
        Me.Lbl_LastVoucher.Size = New System.Drawing.Size(102, 22)
        Me.Lbl_LastVoucher.TabIndex = 85
        Me.Lbl_LastVoucher.Text = "Last Doc No"
        '
        'lbl_void
        '
        Me.lbl_void.AutoSize = True
        Me.lbl_void.BackColor = System.Drawing.Color.Transparent
        Me.lbl_void.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_void.ForeColor = System.Drawing.Color.Red
        Me.lbl_void.Location = New System.Drawing.Point(528, 440)
        Me.lbl_void.Name = "lbl_void"
        Me.lbl_void.Size = New System.Drawing.Size(151, 22)
        Me.lbl_void.TabIndex = 86
        Me.lbl_void.Text = "Deleted Document"
        Me.lbl_void.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(88, 408)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(225, 21)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "[F3 TO DELETE A GRID ROW]"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(1032, 544)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(190, 16)
        Me.Label21.TabIndex = 151
        Me.Label21.Text = "[F10 TO GO MATCHING DETAILS]"
        Me.Label21.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(-176, 392)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(182, 21)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "[F5 CHEQUE PRINTING]"
        Me.Label17.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(1000, 656)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 56)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.White
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(504, 552)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 32)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.White
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(416, 552)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(80, 32)
        Me.CmdView.TabIndex = 10
        Me.CmdView.Text = " View[F9]"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.White
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.White
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.Location = New System.Drawing.Point(152, 552)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 32)
        Me.cmdClear.TabIndex = 13
        Me.cmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(592, 552)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(80, 32)
        Me.cmdexit.TabIndex = 12
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.White
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(240, 552)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(80, 32)
        Me.CmdAdd.TabIndex = 8
        Me.CmdAdd.Text = "Add [F7]"
        '
        'CmdDelete
        '
        Me.CmdDelete.BackColor = System.Drawing.Color.White
        Me.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete.ForeColor = System.Drawing.Color.White
        Me.CmdDelete.Image = CType(resources.GetObject("CmdDelete.Image"), System.Drawing.Image)
        Me.CmdDelete.Location = New System.Drawing.Point(328, 552)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(80, 32)
        Me.CmdDelete.TabIndex = 9
        Me.CmdDelete.Text = "Delete[F8]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Location = New System.Drawing.Point(1024, 424)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(64, 128)
        Me.GroupBox3.TabIndex = 154
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'SSGrid_ReceiptsPayments
        '
        Me.SSGrid_ReceiptsPayments.DataSource = Nothing
        Me.SSGrid_ReceiptsPayments.Location = New System.Drawing.Point(88, 264)
        Me.SSGrid_ReceiptsPayments.Name = "SSGrid_ReceiptsPayments"
        Me.SSGrid_ReceiptsPayments.OcxState = CType(resources.GetObject("SSGrid_ReceiptsPayments.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGrid_ReceiptsPayments.Size = New System.Drawing.Size(584, 144)
        Me.SSGrid_ReceiptsPayments.TabIndex = 155
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Tran Type"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(88, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.TabIndex = 157
        Me.Label18.Text = "Doc.Date"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(88, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.TabIndex = 158
        Me.Label19.Text = "Bank Code"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(88, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 23)
        Me.Label20.TabIndex = 159
        Me.Label20.Text = "Paid/to Rec.From"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(448, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 23)
        Me.Label22.TabIndex = 160
        Me.Label22.Text = "Doc No."
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(448, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.TabIndex = 161
        Me.Label23.Text = "Narration"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(88, 440)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 23)
        Me.Label24.TabIndex = 162
        Me.Label24.Text = "Instrument Type"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(88, 472)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 23)
        Me.Label25.TabIndex = 163
        Me.Label25.Text = "Instrument No."
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(88, 504)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 23)
        Me.Label26.TabIndex = 164
        Me.Label26.Text = "Instrument Date."
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(328, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(320, 23)
        Me.Label27.TabIndex = 165
        Me.Label27.Text = "RECEIPTS AND PAYMENTS"
        '
        'MembersReceipts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SSGrid_ReceiptsPayments)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Txt_Total)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_MICRNo)
        Me.Controls.Add(Me.Lbl_LastVoucher)
        Me.Controls.Add(Me.lbl_void)
        Me.Controls.Add(Me.Txt_InstNo)
        Me.Controls.Add(Me.Txt_PaidTo)
        Me.Controls.Add(Me.Txt_DrawebankName)
        Me.Controls.Add(Me.Txt_Naration)
        Me.Controls.Add(Me.Txt_VoucherPrefix)
        Me.Controls.Add(Me.Txt_VoucherNo)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.Grp_Instrument)
        Me.Controls.Add(Me.Cmb_InstType)
        Me.Controls.Add(Me.Dtp_InstDate)
        Me.Controls.Add(Me.Cmd_BankHelp)
        Me.Controls.Add(Me.Dtp_VoucherDate)
        Me.Controls.Add(Me.Cmb_VoucherType)
        Me.Controls.Add(Me.Cmd_VoucherNoHelp)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.CmdDelete)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.Cmb_GlCode)
        Me.KeyPreview = True
        Me.Name = "MembersReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION[MEMBERS RECEIPTS]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Instrument.ResumeLayout(False)
        Me.frmbut.ResumeLayout(False)
        CType(Me.SSGrid_ReceiptsPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Updateyes = False
        gMatch.Tables.Clear()
        gMatch.Dispose()
        gMatchAccountcode.Tables.Clear()
        gMatchAccountcode.Dispose()
        Me.Close()
    End Sub
    Private Sub FillCashBank()
        Dim SQLSTRING As String
        Dim DR As DataRow
        Me.Cmb_CashBank.Items.Clear()
        ''SQLSTRING = "SELECT CASHBANK FROM ACCOUNTSDOCTYPEMASTER WHERE PREFIX='" & Me.Txt_VoucherPrefix.Text & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
        ''VCONN.getDataSet(SQLSTRING, "ACCOUNTSDOCTYPEMASTER")
        '' If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows.Count > 0 Then
        If (Txt_VoucherPrefix.Text = "BP" Or Txt_VoucherPrefix.Text = "BR") Or (Cmb_VoucherType.Text = "BANK RECEPITS" Or Cmb_VoucherType.Text = "CREDITCARD RECEPITS") Then

            ' Me.Cmb_CashBank.Items.Add("BANK")
            Me.Cmb_CashBank.Text = "BANK"
        Else
            '  If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(0) = "CASH" Then
            'Me.Cmb_CashBank.Items.Add("CASH")
            Me.Cmb_CashBank.Text = "CASH"
            'End If
            'If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(0) = "BANK" Then
            '   Me.Cmb_CashBank.Items.Add("BANK")
            ' End If
            ' If Cmb_CashBank.Items.Count >= Cindex And Cindex <= 0 Then
            '  Me.Cmb_CashBank.SelectedIndex = Cindex
            '  Else
            '  Me.Cmb_CashBank.SelectedIndex = 0
            ' End If
            ' End If
        End If
        Call FillaccountHead()
    End Sub
    Private Sub GetLastVoucherNo(ByVal vouchertype As String)
        Dim SQLSTRING As String
        Dim DR As DataRow
        SQLSTRING = "SELECT Isnull(Max(VoucherNo),0)as VoucherNo FROM JournalEntry WHERE VoucherType='" & vouchertype & "'"
        VCONN.getDataSet(SQLSTRING, "JournalEntry")
        If gdataset.Tables("JournalEntry").Rows.Count > 0 Then
            Me.Lbl_LastVoucher.Text = "Last Doc No" & " " & gdataset.Tables("JournalEntry").Rows(0).Item(0)
        Else
            Me.Lbl_LastVoucher.Text = "Last Doc No" & " " & 0
        End If
    End Sub
    Private Sub FillaccountHead()
        Dim SQLSTRING As String
        Dim i As Integer
        Me.Cmb_GlCode.Items.Clear()
        'SQLSTRING = "SELECT ACCODE+'--'+acdesc AS ACCDESC FROM accountsglaccountmaster WHERE actype='" & Me.Cmb_CashBank.Text & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
        SQLSTRING = "SELECT ACCODE+'--'+acdesc AS ACCDESC FROM accountsglaccountmaster WHERE budgetflag='" & gBudget & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' "

        VCONN.getDataSet(SQLSTRING, "accountsglaccountmaster")
        If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("accountsglaccountmaster").Rows.Count - 1
                Me.Cmb_GlCode.Items.Add(gdataset.Tables("accountsglaccountmaster").Rows(i).Item(0))
            Next i
            If Me.Cmb_CashBank.Items.Count >= Glindex And Glindex <= 0 Then
                Me.Cmb_GlCode.SelectedIndex = Glindex
            Else
                Me.Cmb_GlCode.SelectedIndex = 0
            End If
        Else
            MsgBox("Budget Flag is not filled.. A for Cash/B for Bank and C for CreditCard")
            Exit Sub
        End If
    End Sub
    Private Sub CroShow()
        Dim SQLSTRING As String
        If Me.Txt_VoucherPrefix.Text = "MCR" Then
            Me.Lbl_Transdate.Visible = True
            Me.Dtp_Transdate.Visible = True
            ' Me.Lbl_UserName.Text = "RECEIVED FROM :"
        Else
            Me.Lbl_Transdate.Visible = False
            Me.Dtp_Transdate.Visible = False
            'Me.Lbl_UserName.Text = "PAID TO :"
        End If
    End Sub
    Private Sub FillDrCrFlag()
        Dim SQLSTRING As String
        Dim DR As DataRow
        Dim i As Integer
        With SSGrid_ReceiptsPayments
            For i = 1 To 500
                .TypeComboBoxClear(1, i)
            Next i
        End With
        ''''SQLSTRING = "SELECT DrCrbFlag, Isnull(PostingFlag,'') as PostingFlag FROM ACCOUNTSDOCTYPEMASTER WHERE PREFIX='" & Me.Txt_VoucherPrefix.Text & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
        ''''VCONN.getDataSet(SQLSTRING, "ACCOUNTSDOCTYPEMASTER")
        ''''If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows.Count > 0 Then
        ''''    With SSGrid_ReceiptsPayments
        ''''        .TypeComboBoxIndex = -1
        ''''    End With
        ''''    If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(0) = "B" Then
        ''''        CreditsDebits = "BOTH"
        ''''        strPostingTo = Trim(gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(1))
        ''''        If (Trim(strPostingTo) <> "") Then
        ''''            strPostingAgainst = ""
        ''''            If (strPostingTo = "CREDIT") Then
        ''''                strPostingAgainst = "DEBIT"
        ''''            End If
        ''''            If (strPostingTo = "DEBIT") Then
        ''''                strPostingAgainst = "CREDIT"
        ''''            End If
        ''''        End If
        ''''        With SSGrid_ReceiptsPayments
        ''''            .Col = 1
        ''''            .Row = 1
        ''''            .TypeComboBoxClear(.Col, .Row)
        ''''            .TypeComboBoxString = "CREDIT"
        ''''            .TypeComboBoxString = "DEBIT"
        ''''        End With
        ''''    End If
        'If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(0) = "C" Then
        If Txt_VoucherPrefix.Text = "BR" Or Txt_VoucherPrefix.Text = "CR" Then
            CreditsDebits = ""
            strPostingAgainst = ""
            strPostingTo = ""
            With SSGrid_ReceiptsPayments
                .Col = 1
                .Row = 1
                .TypeComboBoxString = "CREDIT"
                .TypeComboBoxString = "CREDIT"
            End With
        End If
        ' If gdataset.Tables("ACCOUNTSDOCTYPEMASTER").Rows(0).Item(0) = "D" Then
        If Txt_VoucherPrefix.Text = "BP" Or Txt_VoucherPrefix.Text = "CP" Then
            CreditsDebits = ""
            strPostingAgainst = ""
            strPostingTo = ""
            With SSGrid_ReceiptsPayments
                .Col = 1
                .Row = 1
                .TypeComboBoxString = "DEBIT"
                .TypeComboBoxString = "DEBIT"
            End With
        End If
        'With SSGrid_ReceiptsPayments
        '    .Col = 1
        '    .Row = 1
        '    'Refer
        '    'Added as on 26 Jun'07
        '    'Begin
        '    If (CreditsDebits <> "BOTH") Then
        '        .TypeComboBoxCurSel = 0
        '    Else
        '        If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
        '            .Col = 1
        '            .Row = 1
        '            .Lock = True
        '            If (strPostingAgainst = "CREDIT") Then
        '                .TypeComboBoxCurSel = 0
        '            End If
        '            If (strPostingAgainst = "DEBIT") Then
        '                .TypeComboBoxCurSel = 1
        '            End If
        '        Else
        '            MsgBox("Please, Select Posting Flag in DocumentType Master for " & Cmb_VoucherType.Text & "....")
        '            Me.CmdAdd.Enabled = False
        '            Exit Sub
        '        End If
        '        'End
        '    End If
        ''End With
        ' End If
    End Sub
    Private Sub Cmb_VoucherType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_VoucherType.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Dtp_VoucherDate.Focus()
            Call FillCashBank()
            Call FillDrCrFlag()
        End If
    End Sub
    Private Sub Txt_VoucherNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_VoucherNo.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Txt_VoucherNo.Text = "" Then
                Dtp_VoucherDate.Focus()
            Else
                Txt_VoucherNo_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub Txt_VoucherNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_VoucherNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cmd_VoucherNoHelp_Click(sender, e)
        End If
    End Sub
    Private Sub Dtp_VoucherDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dtp_VoucherDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Cmb_GlCode.Enabled = True Then
                Cmb_GlCode.Focus()
            Else
                Txt_PaidTo.Focus()
            End If
        End If
    End Sub
    Private Sub Cmb_CashBank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_CashBank.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Cmb_GlCode.Focus()
            Call FillaccountHead()
        End If
    End Sub

    Private Sub Txt_PaidTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PaidTo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt_Naration.Focus()
        End If
    End Sub

    Private Sub Txt_Naration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Naration.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.Dtp_Transdate.Visible = True Then
                Dtp_Transdate.Focus()
            Else
                With SSGrid_ReceiptsPayments
                    .Focus()
                    .Row = 1
                    .Col = 1
                    .SetActiveCell(1, 1)
                End With
            End If
        End If
    End Sub

    Private Sub Cmb_InstType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_InstType.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt_InstNo.Focus()
        End If
    End Sub

    Private Sub Txt_InstNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_InstNo.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Dtp_InstDate.Focus()
        End If
    End Sub

    Private Sub Dtp_InstDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dtp_InstDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub Txt_DrawebankName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(Me.Txt_DrawebankName.Text) <> "" Then
                Txt_DrawebankName_Validated(sender, e)
            Else

            End If
        End If
    End Sub

    Private Sub Txt_BankPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_BankPlace.KeyPress
        'getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_MICRNo.Focus()
        End If
    End Sub

    Private Sub Txt_MICRNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_MICRNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdAdd.Focus()
        End If
    End Sub
    Private Sub MembersReceipts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SQLSTRING As String
        Dim DR As DataRow
        Dim ROW, COL As Integer

        CreditsDebits = ""
        strPostingAgainst = ""
        strPostingTo = ""
        CreAmt = 0
        DebAmt = 0
        GbatchNo = 0
        gvoucherprefix = Nothing

        If Cmb_VoucherType.Text = "BANK RECEPITS" Then
            gvoucherprefix = "BR"
            Txt_VoucherPrefix.Text = "BR"
        ElseIf Cmb_VoucherType.Text = "CASH RECEPITS" Then
            gvoucherprefix = "CR"
            Txt_VoucherPrefix.Text = "CR"
        ElseIf Cmb_VoucherType.Text = "CREDITCARD RECEPITS" Then
            gvoucherprefix = "CC"
            Txt_VoucherPrefix.Text = "CC"
        ElseIf Cmb_VoucherType.Text = "BANK PAYMENT" Then
            gvoucherprefix = "BP"
            Txt_VoucherPrefix.Text = "BP"
        ElseIf Cmb_VoucherType.Text = "CASH PAYMENT" Then
            gvoucherprefix = "CP"
            Txt_VoucherPrefix.Text = "CP"
        Else
        End If
        Updateyes = False
        SSGrid_ReceiptsPayments.Row = 1
        SSGrid_ReceiptsPayments.Col = 1
        SSGrid_ReceiptsPayments.Text = "CREDIT"
        With SSGrid_ReceiptsPayments
            .Col = 5
            .Row = .ActiveRow
            .Text = "0.00"
            For ROW = 1 To 500
                For COL = 1 To 4
                    .Row = ROW
                    .Col = COL
                    .Lock = True
                Next
            Next
            .Row = 1
            For COL = 1 To 4
                .Col = COL
                .Lock = False
            Next
        End With
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Me.Show()
        Cmb_VoucherType.Focus()
    End Sub
    Private Function vouchernoautogenerate() As String
        Dim sqlstring, financalyear As String
        Dim splitvouchernostr(5) As String
        Dim docprefixreader As SqlDataReader
        gcommand = New SqlCommand
        Dim voucherno As String
        financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialEnd, 3, 4)

        Txt_VoucherPrefix.Text = "MR"

        If Len(Me.Txt_VoucherPrefix.Text) = 2 Then
            sqlstring = "SELECT MAX(SUBSTRING(VOUCHERNO,4,6)) FROM journalentry where vouchertype = '" & Me.Txt_VoucherPrefix.Text & "'"
        End If
        If Len(Me.Txt_VoucherPrefix.Text) = 3 Then
            sqlstring = "SELECT MAX(SUBSTRING(VOUCHERNO,5,6)) FROM journalentry where vouchertype = '" & Me.Txt_VoucherPrefix.Text & "'"
        End If
        If Len(Me.Txt_VoucherPrefix.Text) = 4 Then
            sqlstring = "SELECT MAX(SUBSTRING(VOUCHERNO,6,6)) FROM journalentry where vouchertype = '" & Me.Txt_VoucherPrefix.Text & "'"
        End If
        gconnection.openConnection()
        gcommand.CommandText = sqlstring
        gcommand.CommandType = CommandType.Text
        gcommand.Connection = gconnection.Myconn
        docprefixreader = gcommand.ExecuteReader
        If docprefixreader.Read Then
            If docprefixreader(0) Is System.DBNull.Value Then
                voucherno = Trim(Txt_VoucherPrefix.Text) & "/" & "000001" & "/" & financalyear
                docprefixreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                splitvouchernostr = CStr(docprefixreader(0)).Split("/")
                voucherno = Trim(Txt_VoucherPrefix.Text) & "/" & Format(Val(docprefixreader(0)) + 1, "000000") & "/" & financalyear
                docprefixreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Else
            voucherno = Trim(Txt_VoucherPrefix.Text) & "/" & "000001" & "/" & financalyear
            docprefixreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End If
        vouchernoautogenerate = voucherno
    End Function

    Private Sub Cmb_VoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_VoucherType.SelectedIndexChanged
        Dim SQLSTRING As String
        Dim DR As DataRow
        If Cmb_VoucherType.Text = "BANK RECEPITS" Then
            gvoucherprefix = "BR"
            Txt_VoucherPrefix.Text = "BR"

            'FOR MEMBER RECEIPT MR
            gvoucherprefix = "MR"
            Txt_VoucherPrefix.Text = "MR"
            gBudget = "B"

            Cmb_InstType.Enabled = True
            Txt_InstNo.Enabled = True
            Dtp_InstDate.Enabled = True
            '  Cmb_GlCode.Enabled = True
            Me.Cmd_BankHelp.Enabled = True


        ElseIf Cmb_VoucherType.Text = "CREDITCARD RECEPITS" Then

            gvoucherprefix = "BR"
            Txt_VoucherPrefix.Text = "BR"

            'FOR MEMBER RECEIPT MR
            gvoucherprefix = "MR"
            Txt_VoucherPrefix.Text = "MR"
            gBudget = "C"

            Cmb_InstType.Enabled = True
            Txt_InstNo.Enabled = True
            Dtp_InstDate.Enabled = True

            '  Cmb_GlCode.Enabled = True
            Me.Cmd_BankHelp.Enabled = True


        ElseIf Cmb_VoucherType.Text = "CASH RECEPITS" Then
            gvoucherprefix = "CR"
            Txt_VoucherPrefix.Text = "CR"

            'FOR MEMBER RECEIPT MR

            gvoucherprefix = "MR"
            Txt_VoucherPrefix.Text = "MR"
            gBudget = "A"

            'For Vaildation 30-12-2010
            Cmb_InstType.Enabled = False
            Txt_InstNo.Enabled = False
            Dtp_InstDate.Enabled = False
            Txt_DrawebankName.Enabled = False
            Cmb_GlCode.Enabled = False
            Me.Cmd_BankHelp.Enabled = False

            'For Vaildation 30-12-2010
        ElseIf Cmb_VoucherType.Text = "BANK PAYMENT" Then
            gvoucherprefix = "BP"
            Txt_VoucherPrefix.Text = "BP"
            Cmb_InstType.Enabled = True
            Txt_InstNo.Enabled = True
            Dtp_InstDate.Enabled = True
            Txt_DrawebankName.Enabled = True
            Cmb_GlCode.Enabled = True
            Me.Cmd_BankHelp.Enabled = True
        ElseIf Cmb_VoucherType.Text = "CASH PAYMENT" Then
            gvoucherprefix = "CP"
            Txt_VoucherPrefix.Text = "CP"
            Cmb_InstType.Enabled = False
            Txt_InstNo.Enabled = False
            Dtp_InstDate.Enabled = False
            Txt_DrawebankName.Enabled = False
            Me.Cmd_BankHelp.Enabled = True
            Cmb_GlCode.Enabled = False
        Else
        End If

        'If Trim(gvoucherprefix).Substring(0, 2).ToUpper = "BP" Then
        '    Txt_DrawebankName.Enabled = True
        '    Txt_BankPlace.Enabled = False
        '    Txt_MICRNo.Enabled = False
        'Else
        'End If

        Call vouchernoautogenerate()
        Call FillCashBank()
        Call FillDrCrFlag()
        Call CroShow()
        Call GetLastVoucherNo(Txt_VoucherPrefix.Text)
    End Sub
    Private Sub SSGrid_ReceiptsPayments_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGrid_ReceiptsPayments.KeyDownEvent
        Dim ACHEAD, SUBLEDGER, COSTCENTER, ACHEAD1 As String
        Dim GLCODE(), SLCODE(), COSTCODE() As String
        Dim DCSTATUS As String
        Dim SUBLED As Boolean
        Dim GR As String
        Dim TOT As String
        Dim SQLSTRING As String
        Dim ACHEADARRAY(5) As String
        Dim SUBHEADARRAY(5) As String
        Dim ROW, COL As Integer
        With SSGrid_ReceiptsPayments
            If e.keyCode = Keys.Enter Then
                boolMonthClose = gclsConnection.chkMonthClose(Dtp_VoucherDate, 0)
                If boolMonthClose = False Then
                    Exit Sub
                End If
                If .ActiveCol = 1 Then
                    .SetActiveCell(3, .ActiveRow)
                    .Col = 2
                    .Row = 1
                    .Lock = False
                    .Col = 5
                    .Row = .ActiveRow
                    If .Text = "0.00" Or .Text = "" Then
                        .Text = "0.00"
                    End If
                    If (CreditsDebits = "BOTH") Then
                        .Col = 1
                        .Row = 1
                        .Lock = True

                        If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                            If (strPostingAgainst = "CREDIT") Then
                                .TypeComboBoxCurSel = 0
                            End If
                            If (strPostingAgainst = "DEBIT") Then
                                .TypeComboBoxCurSel = 1
                            End If
                        Else
                            MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                            Me.CmdAdd.Enabled = False
                            Exit Sub
                        End If
                    End If
                ElseIf .ActiveCol = 3 Then
                    .Row = .ActiveRow
                    .Col = 2
                    .Text = "SDRS-->>SUNDRY DEBTORS"
                    If .Text = "" Then
                        .SetActiveCell(2, .ActiveRow)
                        .SetText(3, .ActiveRow, "")
                        .SetText(4, .ActiveRow, "")
                        .SetText(5, .ActiveRow, "0.00")
                    End If
                    SUBLEDGER = Nothing
                    .GetText(3, .ActiveRow, SUBLEDGER)
                    If SUBLEDGER = "" Then
                        .SetActiveCell(3, .ActiveRow)
                        'HERE GIVE THE HELP POPUP INCASE IT IS BLANK
                        '-------------------------------SHUVENDU STARTS-----------------------------------------
                        Call SubLedHelp()
                        '-------------------------------SHUVENDU   ENDS-----------------------------------------
                        Exit Sub
                    Else
                        .GetText(2, .ActiveRow, ACHEAD)
                        ACHEADARRAY = ACHEAD.Split("-->>")
                        'MsgBox(ACHEADARRAY(0))
                        SUBHEADARRAY = Nothing
                        'IF EXISTS EARLIER
                        SUBHEADARRAY = SUBLEDGER.Split("-->>")
                        If SUBHEADARRAY Is Nothing = False Then
                            SUBLEDGER = SUBHEADARRAY(0)
                        End If
                        'IF EXISTS EARLIER ENDS
                        SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLCODE = '" & SUBLEDGER & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        VCONN.getDataSet(SQLSTRING, "MASTER1")

                        If gdataset.Tables("MASTER1").Rows.Count = 0 Then
                            SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLDESC = '" & SUBLEDGER & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                            VCONN.getDataSet(SQLSTRING, "MASTER1")
                        End If

                        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                            .Col = 3
                            .Row = .ActiveRow
                            .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLCODE")) '& "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLDESC"))
                            gdataset.Tables("MASTER1").Dispose()


                            'Added on 29 Oct 07 for Cost Center
                            'Begin
                            'Mk Kannan
                            Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                            If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                                'The Following Four Lines are Removed
                                'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                                'CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                                'If GR <> Nothing Then
                                '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                                SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                                'End

                                VCONN.getDataSet(SQLSTRING, "MASTER1")
                                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                                    .Col = 4
                                    .Col2 = 4
                                    .Row = .ActiveRow
                                    .Row2 = .ActiveRow
                                    .Lock = False
                                    .SetActiveCell(4, .ActiveRow)
                                    'Added on 30 Oct 07 for Cost Center
                                    'Mk Kannan
                                    'Begin
                                    '.SetText(4, .ActiveRow, "")
                                    '.SetText(5, .ActiveRow, "0.00")
                                    'End                                        
                                    gdataset.Tables("MASTER1").Dispose()
                                Else
                                    .Col = 4
                                    .Row = .ActiveRow

                                    .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLDESC"))
                                    '  .Lock = True
                                    .SetActiveCell(5, .ActiveRow)
                                    ' .SetText(4, .ActiveRow, "")
                                    .SetText(5, .ActiveRow, "0.00")
                                    gdataset.Tables("MASTER1").Dispose()
                                End If
                            Else
                                .Row = .ActiveRow
                                .Col = 4
                                ' .Lock = True
                                .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLDESC"))
                                .SetActiveCell(5, .ActiveRow)
                                ' .SetText(4, .ActiveRow, "")
                                .Row = .ActiveRow
                                .Col = 5
                                If Val(.Text) > 0 Then
                                Else
                                    .SetText(5, .ActiveRow, "0.00")
                                End If
                            End If
                        Else
                            '--------------------------------------SHUVENDU STARTS------------------------------------------
                            ''.SetActiveCell(3, .ActiveRow)
                            ''.SetText(3, .ActiveRow, "")
                            ''.SetText(4, .ActiveRow, "")
                            ''.SetText(5, .ActiveRow, "0.00")
                            Call SubLedHelp()
                            '----------------------------------------SHUVENDU ENDS-------------------------------------------
                        End If
                    End If
                    '  End If

                    '''''''''IF COL = 4 AND LOCK STATUS IS FALSE
                ElseIf .ActiveCol = 4 Then
                    .Row = .ActiveRow
                    If .Lock = True Then
                        'MsgBox("IT LOCK")
                        Exit Sub
                    Else
                        .Row = .ActiveRow
                        .Col = 2
                        If .Text = "" Then
                            .SetActiveCell(2, .ActiveRow)
                            .SetText(3, .ActiveRow, "")
                            .SetText(4, .ActiveRow, "")
                            .SetText(5, .ActiveRow, "0.00")
                            Exit Sub
                        End If
                        ACHEAD = Nothing
                        COSTCENTER = Nothing
                        .GetText(2, .ActiveRow, ACHEAD)
                        .GetText(4, .ActiveRow, COSTCENTER)
                        ACHEADARRAY = ACHEAD.Split("-->>")

                        'Added on 29 Oct 07 for Cost Center
                        'Begin
                        'Mk Kannan

                        Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                        'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                        'CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                        'If GR <> Nothing Then
                        'SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        'SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        'End
                        'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                        ''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                        If Trim(COSTCENTER) = "" Then
                            Call CostCenterHelp(GR)
                        End If
                        .Col = 4
                        .Row = .ActiveRow
                        COSTCENTER = Trim(Split(.Text, "-->")(0))

                        If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                            'SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND COSTCENTERCODE = '" & COSTCENTER & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                            SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE COSTCENTERCODE = '" & COSTCENTER & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                            'End
                            VCONN.getDataSet(SQLSTRING, "MASTER1")
                            If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                                .Col = 4
                                .Row = .ActiveRow
                                .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERDESC"))
                                .SetActiveCell(5, .ActiveRow)
                                gdataset.Tables("MASTER1").Dispose()
                            Else
                                .SetActiveCell(4, .ActiveRow)
                                .SetText(4, .ActiveRow, "")
                                Call CostCenterHelp(GR)
                                .SetText(5, .ActiveRow, "0.00")
                            End If
                        Else
                            .SetActiveCell(4, .ActiveRow)
                            .SetText(4, .ActiveRow, "")
                            .SetText(5, .ActiveRow, "0.00")

                        End If
                    End If
                ElseIf .ActiveCol = 5 Then
                    TOT = Nothing
                    .Col = 5
                    .Row = .ActiveRow
                    TOT = .Text
                    If Trim(TOT) = "0.00" Then
                        .GetText(2, .ActiveRow, ACHEAD)
                        If ACHEAD <> "" Then
                            .SetActiveCell(3, .ActiveRow)
                            ' Exit Sub
                        Else
                            Exit Sub
                        End If
                    Else
                        total = 0
                        'Refer
                        'Added as on 26 Jun'07
                        'Begin
                        CreAmt = 0
                        DebAmt = 0
                        If (CreditsDebits = "BOTH") Then
                            For ROW = 1 To .DataRowCnt
                                TOT = Nothing
                                .Col = 1
                                .Row = ROW
                                CreDeb = Trim(.Text)
                                .Col = 5
                                TOT = Trim(.Text)
                                If TOT Is Nothing = True Then
                                    TOT = 0
                                ElseIf Val(TOT) = 0 Then
                                    TOT = 0
                                End If
                                If (CreDeb = "CREDIT") And Val(.Text) > 0 Then
                                    CreAmt = CreAmt + CDbl(TOT)
                                End If
                                If (CreDeb = "DEBIT") And Val(.Text) > 0 Then
                                    DebAmt = DebAmt + CDbl(TOT)
                                End If
                            Next
                            total = Math.Abs(CreAmt - DebAmt)
                            CreAmt = 0
                            DebAmt = 0
                            'End
                        Else
                            For ROW = 1 To .DataRowCnt
                                TOT = Nothing
                                .Row = ROW
                                .Col = 5
                                TOT = Trim(.Text)
                                If TOT Is Nothing = True Then
                                    TOT = 0
                                ElseIf Val(TOT) = 0 Then
                                    TOT = 0
                                End If
                                total = total + CDbl(TOT)
                            Next
                        End If
                        Txt_Total.Text = Format(total, "0.00")
                        'Refer
                        'Modified as on 23 Jun'07
                        'Begin
                        '.SetActiveCell(2, .ActiveRow + 1)
                        If (CreditsDebits = "BOTH") Then
                            .SetActiveCell(1, .ActiveRow + 1)
                        Else
                            .SetActiveCell(2, .ActiveRow + 1)
                        End If
                        'End
                        .Col = 1
                        .Row = .ActiveRow
                        .GetText(1, 1, DCSTATUS)
                        If Val(.ActiveRow) <> 1 Then
                            'Refer
                            ' The Following Two Lines Are Not Required, Bcoz Already Defined.
                            'Begin
                            '.Col = 1
                            '.Row = .ActiveRow
                            'End
                            'Modified as on 23 Jun'07
                            'Begin
                            If (CreditsDebits = "BOTH") Then
                                .TypeComboBoxClear(.Col, .Row)
                                .TypeComboBoxString = "CREDIT"
                                .TypeComboBoxString = "DEBIT"
                            Else
                                .TypeComboBoxList = DCSTATUS
                                .TypeComboBoxCurSel = 0
                            End If
                            'End

                            'Modified as on 23 Jun'07
                            'Begin
                            '.Lock = True
                            If (CreditsDebits = "BOTH") Then
                                .Lock = False
                            Else
                                .Lock = True
                            End If
                            'End
                        End If
                        '.Col = 5
                        '.Row = .ActiveRow
                        '.Text = "0.00"

                        .Row = .ActiveRow
                        .Col = 2
                        .Lock = False

                        .Row = .ActiveRow + 1
                        .Col = 5
                        .Lock = False
                    End If
                    .Row = .ActiveRow
                    .Col = 2
                    .Text = "SDRS-->>SUNDRY DEBTORS"
                    .SetActiveCell(3, .ActiveRow)

                End If

            ElseIf e.keyCode = Keys.F4 Then
                '''''''If .ActiveCol = 2 Then
                '''''''    Search = Nothing
                '''''''    .GetText(2, .ActiveRow, Search)
                '''''''    Dim vform As New ListOperattion1
                '''''''    gSQLString = "SELECT ACCODE AS GLCODE,ACDESC AS GLDESCRIPTION  FROM ACCOUNTSGLACCOUNTMASTER"
                '''''''    M_WhereCondition = " WHERE  ISNULL(FreezeFlag,'N') <> 'Y' and Actype Not In('CASH','BANK')"
                '''''''    vform.Field = "ACDESC,ACCODE"
                '''''''    'vform.keyfield = "ACDESC"
                '''''''    vform.vFormatstring = "  GL CODE             |                GL DESCRIPTION           "
                '''''''    vform.vCaption = "GENERAL LEDGER HEAD HELP"
                '''''''    vform.KeyPos = 0
                '''''''    vform.KeyPos1 = 1
                '''''''    vform.ShowDialog(Me)
                '''''''    If Trim(vform.keyfield & "") <> "" Then
                '''''''        .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & "") & "-->>" & Trim(vform.keyfield1 & ""))
                '''''''        ACHEAD = Trim(vform.keyfield & "")
                '''''''        ''''''''' CHECKING WEATHER ACHEAD IS HAVING SUBLEDGER OR NOT 
                '''''''        SQLSTRING = "SELECT SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEAD) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''        VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''''''        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''''''            .SetText(3, .ActiveRow, "")
                '''''''            .SetText(4, .ActiveRow, "")
                '''''''            .SetText(5, .ActiveRow, "0.00")
                '''''''            .SetActiveCell(3, .ActiveRow)
                '''''''            .Row = .ActiveRow
                '''''''            .Col = 3
                '''''''            .Lock = False
                '''''''            gdataset.Tables("MASTER1").Dispose()
                '''''''        Else
                '''''''            .SetActiveCell(3, .ActiveRow)
                '''''''            .SetText(3, .ActiveRow, "")
                '''''''            .SetText(4, .ActiveRow, "")
                '''''''            .SetText(5, .ActiveRow, "0.00")
                '''''''            .Row = .ActiveRow
                '''''''            .Col = 3
                '''''''            .Lock = True
                '''''''            gdataset.Tables("MASTER1").Dispose()


                '''''''            'Added on 29 Oct 07 for Cost Center
                '''''''            'Begin
                '''''''            'Mk Kannan

                '''''''            Call VCONN.getAccountsCostCenter(ACHEAD)
                '''''''            If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                '''''''                'GR = COSTCENTERVALIDATE(GR, ACHEAD)
                '''''''                '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                '''''''                'If GR <> Nothing Then
                '''''''                'SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND  ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''                SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''                'End
                '''''''                VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''''''                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''''''                    .SetActiveCell(4, .ActiveRow)

                '''''''                    'Added on 30 Oct 07 for Cost Center
                '''''''                    'Mk Kannan
                '''''''                    'Begin
                '''''''                    '.SetText(4, .ActiveRow, "")
                '''''''                    '.SetText(5, .ActiveRow, "0.00")
                '''''''                    'End

                '''''''                    .Row = .ActiveRow
                '''''''                    .Col = 4
                '''''''                    .Lock = False
                '''''''                    gdataset.Tables("MASTER1").Dispose()
                '''''''                Else
                '''''''                    .SetActiveCell(5, .ActiveRow)
                '''''''                    .SetText(4, .ActiveRow, "")
                '''''''                    .SetText(5, .ActiveRow, "0.00")
                '''''''                    .Row = .ActiveRow
                '''''''                    .Col = 4
                '''''''                    .Lock = True
                '''''''                    gdataset.Tables("MASTER1").Dispose()
                '''''''                End If
                '''''''            Else
                '''''''                .SetActiveCell(5, .ActiveRow)
                '''''''                .SetText(5, .ActiveRow, "0.00")
                '''''''                .Row = .ActiveRow
                '''''''                .Col = 4
                '''''''                .Lock = True
                '''''''            End If

                '''''''        End If
                '''''''    Else
                '''''''        .SetActiveCell(.ActiveCol, .ActiveRow)
                '''''''        .SetText(.ActiveCol, .ActiveRow, "")
                '''''''    End If
                '''''''    vform.Close()
                '''''''    vform = Nothing
                '''''''    '  ElseIf .ActiveCol = 3 And .Lock = False Then
                '''''''ElseIf .ActiveCol = 3 Then
                '''''''    .Col = 3
                '''''''    .Row = .ActiveRow
                '''''''    If .Lock = True Then
                '''''''        ' MsgBox("IT LOCK")
                '''''''        Exit Sub
                '''''''    Else

                '''''''        .GetText(2, .ActiveRow, ACHEAD)
                '''''''        ACHEADARRAY = ACHEAD.Split("-->>")
                '''''''        'MsgBox(ACHEADARRAY(0))
                '''''''        'SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLCODE = '" & SUBLEDGER & "'"
                '''''''        Dim vform As New ListOperattion1
                '''''''        gSQLString = "SELECT SLCODE,SLDESC FROM accountssubledgermaster"
                '''''''        M_WhereCondition = " WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''        vform.Field = "SLCODE,SLDESC"
                '''''''        'vform.Field = "SLDESC"
                '''''''        vform.vFormatstring = "           SL CODE          |                SL DESCRIPTION              "
                '''''''        vform.vCaption = "SUB LEDGER CODE HELP"
                '''''''        vform.KeyPos = 0
                '''''''        VFORM.KeyPos1 = 1
                '''''''        vform.ShowDialog(Me)
                '''''''        If Trim(vform.keyfield & "") <> "" Then
                '''''''            .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & "") & "-->>" & Trim(vform.keyfield1 & ""))

                '''''''            'Added on 29 Oct 07 for Cost Center
                '''''''            'Begin
                '''''''            'Mk Kannan

                '''''''            Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                '''''''            If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                '''''''                'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                '''''''                '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                '''''''                'If GR <> Nothing Then
                '''''''                '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ")  AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''                SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''                'End
                '''''''                VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''''''                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''''''                    .Row = .ActiveRow
                '''''''                    .Col = 4
                '''''''                    .Lock = False
                '''''''                    .SetActiveCell(4, .ActiveRow)
                '''''''                    .SetText(4, .ActiveRow, "")
                '''''''                    .SetText(5, .ActiveRow, "0.00")
                '''''''                    gdataset.Tables("MASTER1").Dispose()
                '''''''                Else
                '''''''                    .Row = .ActiveRow
                '''''''                    .Col = 4
                '''''''                    .Lock = True
                '''''''                    .SetActiveCell(5, .ActiveRow)
                '''''''                    .SetText(4, .ActiveRow, "")
                '''''''                    .SetText(5, .ActiveRow, "0.00")
                '''''''                    gdataset.Tables("MASTER1").Dispose()
                '''''''                End If
                '''''''            Else
                '''''''                .Row = .ActiveRow
                '''''''                .Col = 4
                '''''''                .Lock = True
                '''''''                .SetActiveCell(5, .ActiveRow)
                '''''''                .SetText(5, .ActiveRow, "0.00")
                '''''''            End If
                '''''''        End If
                '''''''        vform.Close()
                '''''''        vform = Nothing
                '''''''    End If

                '''''''ElseIf .ActiveCol = 4 Then
                '''''''    .Col = 4
                '''''''    .Row = .ActiveRow
                '''''''    If .Lock = True Then
                '''''''        ' MsgBox("IT LOCK")
                '''''''        Exit Sub
                '''''''    Else
                '''''''        ACHEAD = Nothing
                '''''''        COSTCENTER = Nothing
                '''''''        .GetText(2, .ActiveRow, ACHEAD)
                '''''''        .GetText(4, .ActiveRow, COSTCENTER)
                '''''''        ACHEADARRAY = ACHEAD.Split("-->>")

                '''''''        'Added on 29 Oct 07 for Cost Center
                '''''''        'Begin
                '''''''        'Mk Kannan

                '''''''        Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                '''''''        If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                '''''''            'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                '''''''            '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                '''''''            'If GR <> Nothing Then
                '''''''            SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''''''            'End

                '''''''            'SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND COSTCENTERCODE = '" & COSTCENTER & "'"
                '''''''            'VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''''''            Dim vform As New ListOperattion1
                '''''''            gSQLString = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER"

                '''''''            'Modified on 29 Oct 07
                '''''''            'Begin
                '''''''            'Mk Kannan
                '''''''            'M_WhereCondition = " WHERE PRIMARYGROUPCODE IN (" & GR & ")AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
                '''''''            M_WhereCondition = " WHERE ISNULL(FREEZEFLAG,'N') <> 'Y' "
                '''''''            'End
                '''''''            vform.Field = "COSTCENTERCODE"
                '''''''            vform.vFormatstring = "  COSTCENTER   CODE |COSTCENTER   DESC    "
                '''''''            vform.vCaption = "COST CENTER HELP"
                '''''''            vform.KeyPos = 0
                '''''''            VFORM.KeyPos1 = 1
                '''''''            vform.ShowDialog(Me)
                '''''''            If Trim(vform.keyfield & "") <> "" Then
                '''''''                .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & "") & "-->>" & Trim(vform.keyfield1 & ""))
                '''''''                .SetActiveCell(5, .ActiveRow)
                '''''''            Else
                '''''''                .SetActiveCell(4, .ActiveRow)
                '''''''                .SetText(4, .ActiveRow, "")
                '''''''                .SetText(5, .ActiveRow, "0.00")
                '''''''            End If
                '''''''        Else
                '''''''            .SetActiveCell(4, .ActiveRow)
                '''''''            .SetText(4, .ActiveRow, "")
                '''''''            .SetText(5, .ActiveRow, "0.00")
                '''''''        End If
                '''''''    End If
                '''''''End If
            ElseIf e.keyCode = Keys.F3 Then
                'Added on 09 Oct'07 for Month Close
                'Mk Kannan
                'Begin
                boolMonthClose = gclsConnection.chkMonthClose(Dtp_VoucherDate, 1)
                If boolMonthClose = False Then
                    Exit Sub
                End If
                'End
                .GetText(2, .ActiveRow, ACHEAD)
                .GetText(3, .ActiveRow, SUBLEDGER)
                .GetText(4, .ActiveRow, COSTCENTER)
                .GetText(1, 1, DCSTATUS)
                If ACHEAD <> "" Or SUBLEDGER <> "" Or COSTCENTER <> "" Then
                    .Col = 1
                    .Row = .ActiveRow
                    DCSTATUS = .Text
                    .DeleteRows(.ActiveRow, 1)
                    .Col = 1
                    .Row = .ActiveRow
                    If .Row = 1 Then
                        Call FillDrCrFlag()
                        'Refer
                        'Added as on 26 Jun'07
                        'Begin
                        If (CreditsDebits <> "BOTH") Then
                            'End
                            If UCase(DCSTATUS) = "CREDIT" Then
                                .Col = 1
                                .Row = 1
                                .TypeComboBoxCurSel = 0
                            Else
                                .Col = 1
                                .Row = 1
                                .TypeComboBoxCurSel = 1
                            End If
                        Else
                            .Col = 1
                            .Row = 1
                            .Lock = True
                            If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                                If (strPostingAgainst = "CREDIT") Then
                                    .TypeComboBoxCurSel = 0
                                End If
                                If (strPostingAgainst = "DEBIT") Then
                                    .TypeComboBoxCurSel = 1
                                End If
                            Else
                                MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                                Me.CmdAdd.Enabled = False
                                Exit Sub
                            End If
                        End If
                        'End
                    Else
                        'Refer
                        'Added as on 26 Jun'07
                        'Begin
                        If (CreditsDebits <> "BOTH") Then
                            'End
                            .TypeComboBoxString = DCSTATUS
                            .TypeComboBoxCurSel = 0
                        End If
                    End If
                    .SetActiveCell(2, .ActiveRow)
                    .Col = 2
                    .Row = .ActiveRow
                    .Text = "SDRS-->>SUNDRY DEBTORS"
                    .SetActiveCell(3, .ActiveRow)

                    .Lock = False

                    'Delete The Record From Match Dataset i.e Gmatch
                    ''Dim TableName As String
                    ''TableName = Trim(Split(ACHEAD, "-->>")(0)) & "*" & Trim(Split(SUBLEDGER, "-->>")(0)) & "*" & .ActiveRow
                    ''If gMatch.Tables.Contains(TableName) = True Then
                    ''    gMatch.Tables.Remove(TableName)
                    ''End If
                    'Delete Of The Match Ends Here
                    Call GridTotal()
                    .Col = 1
                    .Row = 1
                    .Lock = False
                    'Refer
                    'Added as on 27 Jun'07
                    'Begin
                    If (CreditsDebits = "BOTH") Then
                        .Col = 1
                        .Row = 1
                        .Lock = True

                        If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                            If (strPostingAgainst = "CREDIT") Then
                                .TypeComboBoxCurSel = 0
                            End If
                            If (strPostingAgainst = "DEBIT") Then
                                .TypeComboBoxCurSel = 1
                            End If
                        Else
                            MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                            Me.CmdAdd.Enabled = False
                            Exit Sub
                        End If
                    End If
                    'End
                End If
            ElseIf e.keyCode = Keys.F10 Then
                '''.Col = 1
                '''.Row = .ActiveRow
                '''gCreditDebit = .Text
                '''.Col = 2
                '''.Row = .ActiveRow
                '''gAccountHead = .Text
                '''.Col = 3
                '''.Row = .ActiveRow
                '''gSlCode = .Text
                '''.Col = 5
                '''.Row = .ActiveRow
                '''gAmt = Val(.Text)
                '''gVoucherno = Trim(Me.Txt_VoucherNo.Text)
                '''gVoucherType = Trim(Me.Txt_VoucherPrefix.Text)
                '''ACHEADARRAY = gAccountHead.Split("-->>")
                '''gAccountHead = ACHEADARRAY(0)
                '''ACHEADARRAY = gSlCode.Split("-->>")
                '''gSlCode = ACHEADARRAY(0)
                '''gRowNo = SSGrid_ReceiptsPayments.ActiveRow
                '''If gAccountHead = gDebitors Or gAccountHead = gCreditors Then
                '''    If Trim(gCreditDebit) <> "" And Trim(gSlCode) <> "" And Val(gAmt) > 0 Then
                '''        Dim match As New Matching
                '''        match.ShowDialog()
                '''    End If
                '''End If
            End If
        End With
    End Sub
    Private Sub Cmb_CashBank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_CashBank.SelectedIndexChanged
        If Cmb_CashBank.Text = "CASH" Then
            Me.Cmb_InstType.SelectedIndex = -1
            Grp_Instrument.Enabled = False
        Else
            Me.Cmb_InstType.SelectedIndex = 0
            Grp_Instrument.Enabled = True
        End If
        Call FillaccountHead()
    End Sub
    Private Sub Cmb_GlCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_GlCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Txt_PaidTo.Focus()
        End If
    End Sub
    Private Sub SSGrid_ReceiptsPayments_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles SSGrid_ReceiptsPayments.LeaveCell
        Dim ACHEAD, SUBLEDGER, COSTCENTER As String
        Dim DCSTATUS As String
        Dim GR As String
        Dim TOT As String
        Dim amt As String
        Dim SQLSTRING As String
        Dim ACHEADARRAY(5), SUBLEDGERARRAY(5), COSTCENTERARRAY(5) As String
        Dim ROW, COL As Integer

        'Added on 09 Oct'07
        'Mk Kannan
        'Begin
        boolMonthClose = gclsConnection.chkMonthClose(Dtp_VoucherDate, 0)
        If boolMonthClose = False Then
            Exit Sub
        End If
        'End

        With SSGrid_ReceiptsPayments
            .Row = 1
            .Col = 1
            .Lock = False
            'Refer
            'Added as on 27 Jun'07
            'Begin
            If (CreditsDebits = "BOTH") Then
                .Col = 1
                .Row = 1
                .Lock = True
                If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                    If (strPostingAgainst = "CREDIT") Then
                        .TypeComboBoxCurSel = 0
                    End If
                    If (strPostingAgainst = "DEBIT") Then
                        .TypeComboBoxCurSel = 1
                    End If
                Else
                    MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                    Me.CmdAdd.Enabled = False
                    Exit Sub
                End If
            End If
            'End

            If .ActiveCol = 1 Then
                .SetActiveCell(3, .ActiveRow)
                Exit Sub
                ''''''' IF COL = 2
            ElseIf .ActiveCol = 2 Then
                '''.GetText(2, .ActiveRow, ACHEAD)
                '''ACHEADARRAY = ACHEAD.Split("-->>")
                '''.GetText(3, .ActiveRow, SUBLEDGER)
                '''SUBLEDGERARRAY = SUBLEDGER.Split("-->>")
                '''.GetText(4, .ActiveRow, COSTCENTER)
                '''COSTCENTERARRAY = COSTCENTER.Split("-->>")
                '''If ACHEAD = "" Then
                '''    If SUBLEDGER <> "" Or COSTCENTER <> "" Then
                '''        .SetActiveCell(2, .ActiveRow)
                '''        Exit Sub
                '''    Else
                '''        Exit Sub
                '''    End If
                '''End If
                '''' SQLSTRING = "SELECT ACCODE,ACDESC FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'  and Actype In('CASH (ASSETS)','BANK (ASSETS & LIBALITY)')"
                '''SQLSTRING = "SELECT ACCODE,ACDESC FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' and  Actype not In('CASH','BANK')"
                '''VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''If gdataset.Tables("MASTER1").Rows.Count = 0 Then
                '''    SQLSTRING = "SELECT ACCODE,ACDESC FROM ACCOUNTSGLACCOUNTMASTER WHERE ACDESC = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' and Actype not In('CASH','BANK')"
                '''    VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''End If
                '''If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''    ''''''''''''If ACHEAD = Trim(gdataset.Tables("MASTER1").Rows(0).Item("ACCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("ACDESC")) Then
                '''    ''''''''''''    Exit Sub
                '''    ''''''''''''End If
                '''    .Col = 2
                '''    .Row = .ActiveRow
                '''    .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("ACCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("ACDESC"))
                '''    gdataset.Tables("MASTER1").Dispose()

                '''    ''''''''' CHECKING WEATHER ACHEAD IS HAVING SUBLEDGER OR NOT 
                '''    SQLSTRING = "SELECT SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''    VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''    If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''        SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLCODE = '" & SUBLEDGERARRAY(0) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''        VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''            .Row = .ActiveRow
                '''            .Col = 3
                '''            .Lock = False
                '''            .Col = 5
                '''            .Row = .ActiveRow
                '''            amt = .Text
                '''            If Val(amt) = 0 Then
                '''                .SetText(5, .ActiveRow, "0.00")
                '''                .SetActiveCell(5, .ActiveRow)
                '''                .Col = 5
                '''                .Row = .ActiveRow
                '''                .Lock = False
                '''            End If
                '''        Else
                '''            .SetText(3, .ActiveRow, "")
                '''            .SetText(4, .ActiveRow, "")
                '''            .SetText(5, .ActiveRow, "0.00")
                '''            .SetActiveCell(3, .ActiveRow)
                '''            .Row = .ActiveRow
                '''            .Col = 3
                '''            .Lock = False
                '''            gdataset.Tables("MASTER1").Dispose()
                '''        End If

                '''    Else
                '''        .SetText(3, .ActiveRow, "")

                '''        'Added on 30 Oct 07 for Cost Center
                '''        'Mk Kannan
                '''        'Begin
                '''        '.SetText(4, .ActiveRow, "")
                '''        'End

                '''        'amt = Nothing
                '''        .Col = 5
                '''        .Row = .ActiveRow
                '''        amt = .Text
                '''        If Val(amt) = 0 Then
                '''            .SetText(5, .ActiveRow, "0.00")
                '''            .SetActiveCell(5, .ActiveRow)
                '''            .Col = 5
                '''            .Row = .ActiveRow
                '''            .Lock = False
                '''        End If
                '''        .Row = .ActiveRow
                '''        .Col = 3
                '''        .Lock = True
                '''        gdataset.Tables("MASTER1").Dispose()

                '''        'Added on 29 Oct 07 for Cost Center
                '''        'Begin
                '''        'Mk Kannan

                '''        Call VCONN.getAccountsCostCenter(ACHEAD)
                '''        If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                '''            'GR = COSTCENTERVALIDATE(GR, ACHEAD)
                '''            '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                '''            'If GR <> Nothing Then
                '''            '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''            SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                '''            'End

                '''            VCONN.getDataSet(SQLSTRING, "MASTER1")
                '''            If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                '''                .SetActiveCell(4, .ActiveRow)
                '''                'Added on 30 Oct 07 for Cost Center
                '''                'Mk Kannan
                '''                'Begin
                '''                '.SetText(4, .ActiveRow, "")
                '''                '.SetText(5, .ActiveRow, "0.00")
                '''                'End
                '''                .Row = .ActiveRow
                '''                .Col = 4
                '''                .Lock = False
                '''                gdataset.Tables("MASTER1").Dispose()
                '''            Else
                '''                .SetActiveCell(5, .ActiveRow)
                '''                .SetText(4, .ActiveRow, "")
                '''                .Col = 5
                '''                .Row = .ActiveRow
                '''                amt = .Text
                '''                If Val(amt) = 0 Then
                '''                    .SetText(5, .ActiveRow, "0.00")
                '''                    .SetActiveCell(5, .ActiveRow)
                '''                    .Col = 5
                '''                    .Row = .ActiveRow
                '''                    .Lock = False
                '''                    Exit Sub
                '''                End If
                '''                .Row = .ActiveRow
                '''                .Col = 4
                '''                .Lock = True
                '''                gdataset.Tables("MASTER1").Dispose()
                '''            End If
                '''        Else
                '''            .SetActiveCell(5, .ActiveRow)
                '''            .Col = 5
                '''            .Row = .ActiveRow
                '''            amt = .Text
                '''            If Val(amt) = 0 Then
                '''                .SetText(5, .ActiveRow, "0.00")
                '''                .SetActiveCell(5, .ActiveRow)
                '''                .Col = 5
                '''                .Row = .ActiveRow
                '''                .Lock = False
                '''                Exit Sub
                '''            End If
                '''            .Row = .ActiveRow
                '''            .Col = 4
                '''            .Lock = True
                '''            .Col = 1
                '''            .Row = .ActiveRow
                '''            .GetText(1, 1, DCSTATUS)
                '''            If Val(.ActiveRow) <> 1 Then
                '''                'Refer
                '''                ' The Following Two Lines Are Not Required, Bcoz Already Defined.
                '''                'Begin
                '''                '.Col = 1
                '''                '.Row = .ActiveRow
                '''                'End
                '''                'Modified as on 23 Jun'07
                '''                'Begin
                '''                If (CreditsDebits = "BOTH") Then
                '''                    .TypeComboBoxClear(.Col, .Row)
                '''                    .TypeComboBoxString = "CREDIT"
                '''                    .TypeComboBoxString = "DEBIT"
                '''                Else
                '''                    .TypeComboBoxList = DCSTATUS
                '''                    .TypeComboBoxCurSel = 0
                '''                End If
                '''                'End

                '''                'Modified as on 23 Jun'07
                '''                'Begin
                '''                '.Lock = True
                '''                If (CreditsDebits = "BOTH") Then
                '''                    .Lock = False
                '''                Else
                '''                    .Lock = True
                '''                End If
                '''                'End
                '''            End If
                '''        End If
                '''    End If
                '''Else
                '''    .SetActiveCell(2, .ActiveRow)
                '''    .SetText(2, .ActiveRow, "")
                '''    .SetText(3, .ActiveRow, "")
                '''    .SetText(4, .ActiveRow, "")
                '''    .SetText(5, .ActiveRow, "0.00")

                '''End If

                '''''''''IF COL = 3 AND LOCK STATUS IS FALSE
            ElseIf .ActiveCol = 3 Then
                .Col = 3
                .Row = .ActiveRow
                If .Lock = True Then
                    Exit Sub
                Else
                    .Row = .ActiveRow
                    .Col = 2
                    .Text = "SDRS-->>SUNDRY DEBTORS"

                    .GetText(2, .ActiveRow, ACHEAD)
                    ACHEADARRAY = ACHEAD.Split("-->>")
                    .GetText(3, .ActiveRow, SUBLEDGER)
                    SUBLEDGERARRAY = SUBLEDGER.Split("-->>")
                    .GetText(4, .ActiveRow, COSTCENTER)
                    COSTCENTERARRAY = COSTCENTER.Split("-->>")
                    If SUBLEDGER = "" And .Lock = False And .Row = .ActiveRow Then
                        If ACHEAD <> "" Or COSTCENTER <> "" Then
                            .SetActiveCell(3, .ActiveRow)
                            Exit Sub
                        Else
                            Exit Sub
                        End If
                    End If

                    '.GetText(2, .ActiveRow, ACHEAD)
                    'ACHEADARRAY = ACHEAD.Split("-->>")
                    '.GetText(3, .ActiveRow, SUBLEDGER)
                    'SUBLEDGERARRAY = SUBLEDGER.Split("-->>")
                    'MsgBox(ACHEADARRAY(0))
                    SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLCODE = '" & SUBLEDGERARRAY(0) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                    VCONN.getDataSet(SQLSTRING, "MASTER1")
                    If gdataset.Tables("MASTER1").Rows.Count = 0 Then
                        SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLDESC = '" & SUBLEDGERARRAY(0) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        VCONN.getDataSet(SQLSTRING, "MASTER1")
                    End If
                    If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                        If SUBLEDGER = Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLDESC")) Then
                            Exit Sub
                        End If
                        .Col = 3
                        .Row = .ActiveRow
                        .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("SLDESC"))
                        gdataset.Tables("MASTER1").Dispose()


                        'Added on 29 Oct 07 for Cost Center
                        'Begin
                        'Mk Kannan

                        Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                        If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                            'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                            '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                            'If GR <> Nothing Then
                            '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                            SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                            'End                            
                            VCONN.getDataSet(SQLSTRING, "MASTER1")
                            If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                                .Row = .ActiveRow
                                .Col = 4
                                .Lock = False
                                .SetActiveCell(4, .ActiveRow)

                                'Added on 30 Oct 07 for Cost Center
                                'Mk Kannan
                                'Begin
                                '.SetText(4, .ActiveRow, "")
                                '.SetText(5, .ActiveRow, "0.00")
                                'End
                                gdataset.Tables("MASTER1").Dispose()
                            Else
                                .Row = .ActiveRow
                                .Col = 4
                                .Lock = True
                                .SetActiveCell(5, .ActiveRow)
                                .SetText(4, .ActiveRow, "")
                                .SetText(5, .ActiveRow, "0.00")
                                gdataset.Tables("MASTER1").Dispose()
                            End If
                        Else
                            .Row = .ActiveRow
                            .Col = 4
                            .Lock = True
                            .SetActiveCell(5, .ActiveRow)
                            .Col = 5
                            .Row = .ActiveRow
                            amt = .Text
                            If Val(amt) = 0 Then
                                .SetText(5, .ActiveRow, "0.00")
                                .SetActiveCell(5, .ActiveRow)
                                .Col = 5
                                .Row = .ActiveRow
                                .Lock = False
                                Exit Sub
                            End If
                        End If
                    Else
                        .SetActiveCell(3, .ActiveRow)
                        .SetText(3, .ActiveRow, "")
                        .SetText(4, .ActiveRow, "")
                        .SetText(5, .ActiveRow, "0.00")
                    End If
                End If

                '''''''''IF COL = 4 AND LOCK STATUS IS FALSE
            ElseIf .ActiveCol = 4 Then
                .Col = 4
                .Row = .ActiveRow
                If .Lock = True Then
                    'MsgBox("IT LOCK")
                    Exit Sub
                Else
                    .GetText(2, .ActiveRow, ACHEAD)
                    ACHEADARRAY = ACHEAD.Split("-->>")
                    .GetText(3, .ActiveRow, SUBLEDGER)
                    SUBLEDGERARRAY = SUBLEDGER.Split("-->>")
                    .GetText(4, .ActiveRow, COSTCENTER)
                    COSTCENTERARRAY = COSTCENTER.Split("-->>")
                    If Trim(COSTCENTER) = "" And .Lock = False And .Row = .ActiveRow Then
                        If ACHEAD <> "" Or SUBLEDGER <> "" Then
                            .SetActiveCell(4, .ActiveRow)
                            Exit Sub
                        Else
                            Exit Sub
                        End If
                    End If

                    'ACHEAD = Nothing
                    'COSTCENTER = Nothing
                    '.GetText(2, .ActiveRow, ACHEAD)
                    'ACHEADARRAY = ACHEAD.Split("-->>")
                    '.GetText(4, .ActiveRow, COSTCENTER)
                    'COSTCENTERARRAY = COSTCENTER.Split("-->>")

                    'Added on 29 Oct 07 for Cost Center
                    'Begin
                    'Mk Kannan

                    Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))

                    If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                        'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                        '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                        'If GR <> Nothing Then
                        '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND COSTCENTERCODE = '" & COSTCENTERARRAY(0) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        'End                            
                        VCONN.getDataSet(SQLSTRING, "MASTER1")
                        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                            If COSTCENTER = Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERDESC")) Then
                                Exit Sub
                            End If
                            .Col = 4
                            .Row = .ActiveRow
                            .Text = Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERCODE")) & "-->>" & Trim(gdataset.Tables("MASTER1").Rows(0).Item("COSTCENTERDESC"))
                            .SetActiveCell(5, .ActiveRow)
                            gdataset.Tables("MASTER1").Dispose()
                        Else
                            .SetActiveCell(4, .ActiveRow)
                            .SetText(4, .ActiveRow, "")
                            .SetText(5, .ActiveRow, "0.00")
                        End If
                    Else
                        '.SetActiveCell(4, .ActiveRow)
                        '.SetText(4, .ActiveRow, "")
                    End If
                End If

                '''''''''IF COL = 5
            ElseIf .ActiveCol = 5 And .Row = .ActiveRow Then
                TOT = Nothing
                .Col = 5
                .Row = .ActiveRow
                TOT = .Text
                If Trim(TOT) = "0.00" Then
                    .GetText(2, .ActiveRow, ACHEAD)
                    If ACHEAD <> "" Then
                        .SetActiveCell(5, .ActiveRow)
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                Else
                    total = 0
                    CreAmt = 0
                    DebAmt = 0
                    If (CreditsDebits = "BOTH") Then
                        For ROW = 1 To .DataRowCnt
                            TOT = Nothing
                            .Col = 1
                            .Row = ROW
                            CreDeb = Trim(.Text)
                            .Col = 5
                            TOT = Trim(.Text)
                            If TOT Is Nothing = True Then
                                TOT = 0
                            ElseIf Val(TOT) = 0 Then
                                TOT = 0
                            End If
                            If (CreDeb = "CREDIT") And Val(.Text) > 0 Then
                                CreAmt = CreAmt + CDbl(TOT)
                            End If
                            If (CreDeb = "DEBIT") And Val(.Text) > 0 Then
                                DebAmt = DebAmt + CDbl(TOT)
                            End If
                        Next
                        total = Math.Abs(CreAmt - DebAmt)
                        CreAmt = 0
                        DebAmt = 0
                        'End
                    Else
                        For ROW = 1 To .DataRowCnt
                            TOT = Nothing
                            .Col = 5
                            .Row = ROW
                            TOT = .Text
                            total = total + CInt(TOT)
                        Next
                    End If
                    Txt_Total.Text = Format(total, "0.00")
                    ' .SetActiveCell(2, .ActiveRow + 1)
                    .Col = 1
                    .Row = 1
                    DCSTATUS = .Text
                    If Val(.ActiveRow) <> 1 Then
                        .Col = 1
                        .Row = .ActiveRow
                        'Refer
                        'Modified as on 23 Jun'07
                        'Begin
                        If (CreditsDebits = "BOTH") Then
                            .TypeComboBoxClear(.Col, .Row)
                            .TypeComboBoxString = "CREDIT"
                            .TypeComboBoxString = "DEBIT"
                        Else
                            .TypeComboBoxList = DCSTATUS
                            .TypeComboBoxCurSel = 0
                        End If
                        'End

                        'Modified as on 23 Jun'07
                        'Begin
                        '.Lock = True
                        If (CreditsDebits = "BOTH") Then
                            .Col = 1
                            .Row = 1
                            .Lock = True
                            If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                                If (strPostingAgainst = "CREDIT") Then
                                    .TypeComboBoxCurSel = 0
                                End If
                                If (strPostingAgainst = "DEBIT") Then
                                    .TypeComboBoxCurSel = 1
                                End If
                            Else
                                MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                                Me.CmdAdd.Enabled = False
                                Exit Sub
                            End If
                        Else
                            .Lock = True
                        End If
                        'End
                    End If
                    '.Col = 5
                    '.Row = .ActiveRow
                    '.Text = "0.00"
                    .Row = .ActiveRow
                    .Col = 2
                    .Lock = False
                    .Row = .ActiveRow + 1
                    .Col = 5
                    .Lock = False
                End If
            End If
            Call GridTotal()
        End With
    End Sub
    Private Sub GridTotal()
        Dim i As Integer
        Dim Amt As Double

        With SSGrid_ReceiptsPayments
            Me.Txt_Total.Text = "0.00"
            CreAmt = 0
            DebAmt = 0
            'Refer
            'Added as on 27 Jun'07
            'Begin
            If (CreditsDebits = "BOTH") Then
                For i = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                    .Col = 1
                    .Row = i
                    CreDeb = Trim(.Text)
                    .Col = 5
                    If (CreDeb = "CREDIT") And Val(.Text) > 0 Then
                        CreAmt = CreAmt + Val(.Text)
                    End If
                    If (CreDeb = "DEBIT") And Val(.Text) > 0 Then
                        DebAmt = DebAmt + Val(.Text)
                    End If
                Next
                Me.Txt_Total.Text = Math.Abs(Val(CreAmt) - Val(DebAmt))
                'End
            Else
                For i = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                    .Col = 5
                    .Row = i
                    If Val(.Text) > 0 Then
                        Amt = Amt + Val(.Text)
                    End If
                Next
                Me.Txt_Total.Text = Val(Me.Txt_Total.Text) + Val(Amt)
            End If
            Me.Txt_Total.Text = Format(Val(Me.Txt_Total.Text), "0.00")
        End With
    End Sub
    Private Sub CostCenterHelp(ByVal Gr As String)
        Dim vform As New ListOperation
        gSQLString = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER"
        M_WhereCondition = " WHERE ISNULL(FREEZEFLAG,'N') <> 'Y' "
        vform.Field = "COSTCENTERCODE"
        vform.vFormatstring = "  COSTCENTER CODE |COSTCENTER DESC                                       "
        vform.vCaption = "COST CENTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        With SSGrid_ReceiptsPayments
            If Trim(vform.keyfield & "") <> "" Then
                .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & "") & "-->>" & Trim(vform.keyfield1 & ""))
                .SetActiveCell(5, .ActiveRow)
            Else
                .SetActiveCell(4, .ActiveRow)
                .SetText(4, .ActiveRow, "")
                .SetText(5, .ActiveRow, "0.00")
            End If
        End With

    End Sub
    Private Sub SSGrid_ReceiptsPayments_ComboSelChange(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ComboSelChangeEvent) Handles SSGrid_ReceiptsPayments.ComboSelChange
        Dim DCSTATUS As String
        Dim ROW, COL As Integer
        With SSGrid_ReceiptsPayments
            .GetText(1, 1, DCSTATUS)
            For ROW = 2 To .DataRowCnt
                .Col = 1
                .Row = ROW
                'Refer
                'Added as on 26 Jun'07
                'Begin
                If (CreditsDebits <> "BOTH") Then
                    'End
                    .TypeComboBoxList = DCSTATUS
                    .TypeComboBoxCurSel = 0
                End If
            Next
        End With
    End Sub
    Private Sub Dtp_Transdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Dtp_Transdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GcroUser = Trim(Me.Txt_PaidTo.Text)
            GcroDate = Format(Me.Dtp_Transdate.Value, "dd-MMM-yyyy")
            '  Dim Cro As New CroVouchers
            '' Cro.ShowDialog()
            With SSGrid_ReceiptsPayments
                .Focus()
                .Row = 1
                .Col = 1
                If (CreditsDebits <> "BOTH") Then
                    .Text = "CREDIT"
                End If
                .SetActiveCell(1, 1)
            End With
        End If
    End Sub
    Private Sub SaveOperation()
        Dim sql(Me.SSGrid_ReceiptsPayments.DataRowCnt + 20) As String
        Dim sqlArray() As String
        Dim Cro(1) As String
        Dim i, j As Integer
        Dim VoucherType As String
        Dim vamt As String
        Dim Voucherno, GcroVoucherNo As String
        Dim AcCode, SLCODE1 As String
        Dim achead() As String
        Dim slcode() As String
        Dim costcenter() As String
        Dim TotalAdjustmentAmt As Double
        Dim TableIndex As Integer
        Dim oppaccountcode, sql1 As String
        Dim batchno As Long
        Dim PrevAmt, CurAmt As Double
        Dim TableName As String
        Dim VsubCode, VAccCode As String
        Dim k As Integer
        Dim Index As Integer
        Dim CreditDebit1, CreditDebit2, CreDebFlag As String
        Index = Me.Cmb_VoucherType.SelectedIndex
        Glindex = Me.Cmb_GlCode.SelectedIndex
        Cindex = Me.Cmb_CashBank.SelectedIndex
        Try
            If Updateyes = True Then
                Voucherno = Trim(Me.Txt_VoucherNo.Text)
                batchno = GbatchNo
                sql1 = "Insert Into JournalEntry_DEL(VoucherNo,VoucherDate,VoucherType,VoucherCategory,CreditDebit,Amount,Accountcode,AccountCodeDesc,SlCode,Sldesc,CostCenterCode,CostCenterDesc,InstrumentDate,InstrumentType,BankName,BankPlace,PartyName,ReceivedFrom,ReceivedDate,Micr,InstrumentNo,OppAccountCode,Description,BatchNo,adddatetime,adduserid,void,CashBank)( "
                sql1 = sql1 & " SELECT VoucherNo,VoucherDate,VoucherType,VoucherCategory,CreditDebit,Amount,Accountcode,AccountCodeDesc,SlCode,Sldesc,CostCenterCode,CostCenterDesc,InstrumentDate,InstrumentType,BankName,BankPlace,PartyName,ReceivedFrom,ReceivedDate,Micr,InstrumentNo,OppAccountCode,Description,BatchNo,adddatetime,adduserid,void,CashBank FROM JOURNALENTRY WHERE "
                sql1 = sql1 & " VOUCHERNO = '" & Trim(Me.Txt_VoucherNo.Text) & "')"
                VCONN.dataOperation(6, sql1)
            Else
                Voucherno = vouchernoautogenerate()
                batchno = VCONN.getvalue("Select ISNULL(max(Batchno),0) + 1 From JournalEntry")
            End If
            VoucherType = Me.Txt_VoucherPrefix.Text

            If Trim(Me.Txt_VoucherPrefix.Text) = "MCR" Then
                Cro(0) = "Update Receipt_Details Set Mr_Flag='Y',Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "',VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' Where CroNo In(" & GcroVoucherNo & ")"
            Else
                Cro(0) = Nothing
            End If

            Me.SSGrid_ReceiptsPayments.GetText(1, 1, CreditDebit1)
            '  If UCase(CreditDebit1) = "CREDIT" Then
            If Txt_VoucherPrefix.Text = "BR" Or Txt_VoucherPrefix.Text = "CR" Then

                CreditDebit2 = "DEBIT"
                CreditDebit1 = "CREDIT"
            Else
                CreditDebit2 = "CREDIT"
                CreditDebit1 = "DEBIT"
            End If
            achead = Me.Cmb_GlCode.Text.Split("--")
            oppaccountcode = achead(0)
            sql(0) = "Insert Into JournalEntry(VoucherNo,VoucherDate,VoucherType,VoucherCategory,CreditDebit,Amount,Accountcode,AccountCodeDesc,SlCode,Sldesc,CostCenterCode,CostCenterDesc,InstrumentDate,InstrumentType,BankName,BankPlace,PartyName,ReceivedFrom,ReceivedDate,Micr,InstrumentNo,OppAccountCode,Description,BatchNo,adddatetime,adduserid,void,CashBank) Values("
            sql(0) = sql(0) & "'" & Voucherno & "',"
            sql(0) = sql(0) & "'" & Format(Me.Dtp_VoucherDate.Value, "dd-MMM-yyyy") & "',"
            sql(0) = sql(0) & "'" & VoucherType & "',"
            sql(0) = sql(0) & "'" & VoucherType & "',"
            sql(0) = sql(0) & "'" & CreditDebit2 & "',"
            sql(0) = sql(0) & Format(Val(Me.Txt_Total.Text), "0.00") & ","
            sql(0) = sql(0) & "'" & achead(0) & "',"
            sql(0) = sql(0) & "'" & achead(2) & "',"
            sql(0) = sql(0) & "'',"
            sql(0) = sql(0) & "'',"
            sql(0) = sql(0) & "'',"
            sql(0) = sql(0) & "'',"
            sql(0) = sql(0) & "'" & Me.Dtp_InstDate.Text & "',"
            sql(0) = sql(0) & "'" & Me.Cmb_InstType.Text & "',"
            sql(0) = sql(0) & "'" & Me.Txt_DrawebankName.Text & "',"
            sql(0) = sql(0) & "'" & Me.Txt_BankPlace.Text & "',"
            sql(0) = sql(0) & "'" & Me.Txt_PaidTo.Text & "',"
            If Trim(Me.Txt_VoucherPrefix.Text) = "MCR" Then
                sql(0) = sql(0) & "'" & Me.Txt_PaidTo.Text & "',"
                sql(0) = sql(0) & "'" & Me.Dtp_Transdate.Text & "',"
            Else
                sql(0) = sql(0) & "'',"
                sql(0) = sql(0) & "'',"
            End If
            sql(0) = sql(0) & "'" & Me.Txt_MICRNo.Text & "',"
            sql(0) = sql(0) & "'" & Me.Txt_InstNo.Text & "',"
            sql(0) = sql(0) & "'',"                              'opposite account code
            sql(0) = sql(0) & "'" & Trim(Me.Txt_Naration.Text) & "',"
            sql(0) = sql(0) & batchno & ","
            sql(0) = sql(0) & "'" & Format(Now, "dd-MMM-yyyy") & "',"
            sql(0) = sql(0) & "'" & gUsername & "','N',"
            sql(0) = sql(0) & "'" & Me.Cmb_CashBank.Text & "')"

            With SSGrid_ReceiptsPayments
                For i = 1 To .DataRowCnt
                    AcCode = Nothing
                    .Col = 2
                    .Row = i
                    AcCode = .Text
                    .Col = 3
                    .Row = i
                    SLCODE1 = .Text
                    If Trim(AcCode) <> "" And Trim(SLCODE1) <> "" Then
                        sql(i) = "Insert Into JournalEntry(VoucherNo,VoucherDate,VoucherType,VoucherCategory,CreditDebit,Amount,Accountcode,AccountCodeDesc,SlCode,Sldesc,CostCenterCode,CostCenterDesc,InstrumentDate,InstrumentType,BankName,BankPlace,PartyName,ReceivedFrom,ReceivedDate,Micr,InstrumentNo,OppAccountCode,Description,BatchNo,adddatetime,adduserid,Void,CashBank) Values("
                        sql(i) = sql(i) & "'" & Voucherno & "',"
                        sql(i) = sql(i) & "'" & Me.Dtp_VoucherDate.Text & "',"
                        sql(i) = sql(i) & "'" & VoucherType & "',"
                        sql(i) = sql(i) & "'" & VoucherType & "',"
                        If (CreditsDebits = "BOTH") Then
                            .Col = 1
                            CreDebFlag = .Text
                            sql(i) = sql(i) & "'" & Trim(CreDebFlag) & "',"
                        Else
                            sql(i) = sql(i) & "'" & CreditDebit1 & "',"
                        End If
                        vamt = Nothing
                        .Col = 5
                        .Row = i
                        vamt = .Text
                        sql(i) = sql(i) & Format(Val(vamt), "0.00") & ","
                        .Col = 2
                        .Row = i
                        achead = Nothing
                        If (.Text) <> "" Then
                            achead = Split(Trim(.Text), "-->>")
                            sql(i) = sql(i) & "'" & Trim(achead(0)) & "',"
                            sql(i) = sql(i) & "'" & Trim(achead(1)) & "',"
                        Else
                            sql(i) = sql(i) & "'',"
                            sql(i) = sql(i) & "'',"
                        End If
                        .Col = 3
                        .Row = i
                        slcode = Nothing
                        If (.Text) <> "" Then
                            slcode = Split(Trim(.Text), "-->>")
                            sql(i) = sql(i) & "'" & Trim(slcode(0)) & "',"
                            'sql(i) = sql(i) & "'" & Trim(slcode(1)) & "',"
                        Else
                            sql(i) = sql(i) & "'',"
                            '  sql(i) = sql(i) & "'',"
                        End If
                        .Col = 4
                        .Row = i
                        costcenter = Nothing
                        If (.Text) <> "" Then
                            costcenter = Split(Trim(.Text), "-->>")
                            sql(i) = sql(i) & "'" & Trim(costcenter(0)) & "',"
                            '    sql(i) = sql(i) & "'" & Trim(costcenter(1)) & "',"
                        Else
                            sql(i) = sql(i) & "'',"
                            ' sql(i) = sql(i) & "'',"
                        End If
                        sql(i) = sql(i) & "'',"
                        sql(i) = sql(i) & "'',"

                        sql(i) = sql(i) & "'" & Me.Dtp_InstDate.Text & "',"
                        sql(i) = sql(i) & "'" & Me.Cmb_InstType.Text & "',"
                        sql(i) = sql(i) & "'" & Me.Txt_DrawebankName.Text & "',"
                        sql(i) = sql(i) & "'" & Me.Txt_BankPlace.Text & "',"
                        sql(i) = sql(i) & "'" & Me.Txt_PaidTo.Text & "',"
                        If Trim(Me.Txt_VoucherPrefix.Text) = "MCR" Then
                            sql(i) = sql(i) & "'" & Me.Txt_PaidTo.Text & "',"
                            sql(i) = sql(i) & "'" & Me.Dtp_Transdate.Text & "',"
                        Else
                            sql(i) = sql(i) & "'',"
                            sql(i) = sql(i) & "'',"
                        End If
                        sql(i) = sql(i) & "'" & Me.Txt_MICRNo.Text & "',"
                        sql(i) = sql(i) & "'" & Me.Txt_InstNo.Text & "',"
                        sql(i) = sql(i) & "'" & oppaccountcode & "',"
                        sql(i) = sql(i) & "'" & Me.Txt_Naration.Text & "',"
                        sql(i) = sql(i) & batchno & ","
                        sql(i) = sql(i) & "'" & Format(Now, "dd-MMM-yyyy") & "',"
                        sql(i) = sql(i) & "'" & gUsername & "','N',"
                        sql(i) = sql(i) & "'" & Me.Cmb_CashBank.Text & "')"
                    End If
                Next
            End With
            'Matching Table Entry
            If gMatch.Tables.Count > 0 Then
                For k = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                    With SSGrid_ReceiptsPayments
                        TableName = ""
                        .Row = k
                        .Col = 3
                        slcode = Split(Trim(.Text), "-->>")
                        .Col = 2
                        achead = Split(Trim(.Text), "-->>")
                        TableName = Trim(achead(0)) & Trim("*") & Trim(slcode(0)) & Trim("*") & Trim(k)
                    End With
                    For i = 0 To gMatch.Tables.Count - 1
                        PrevAmt = 0
                        CurAmt = 0
                        VsubCode = ""
                        VAccCode = ""
                        TotalAdjustmentAmt = 0
                        If gMatch.Tables.Contains(TableName) = True Then
                            TableIndex = gMatch.Tables.IndexOf(TableName)
                            For j = 0 To gMatch.Tables(TableIndex).Rows.Count - 1
                                Dim str(3) As String
                                With gMatch.Tables(TableIndex).Rows(j)
                                    str = VCONN.AddBillMatching(.Item(1), .Item(2), .Item(2), .Item(8), .Item(4), Split(Trim(.Item(0)), "*")(1), Val(.Item(5)), Voucherno, Me.Dtp_VoucherDate.Text, VoucherType, .Item(3), VoucherType, .Item(6), Val(.Item(9)), Val(.Item(11)), Trim(.Item(12)), .Item(13), Val(.Item(14)), Val(batchno), Val(.Item(15)))
                                    VsubCode = Split(Trim(.Item(0)), "*")(1)
                                    VAccCode = Trim(.Item(4))
                                    TotalAdjustmentAmt = TotalAdjustmentAmt + Val(.Item(3))
                                    ReDim Preserve sql(sql.Length + 5)
                                    sql(sql.Length - 5) = str(0)
                                    sql(sql.Length - 4) = str(1)
                                End With
                            Next j
                            If Trim(VAccCode) <> "" And Trim(VsubCode) <> "" Then
                                sql(sql.Length - 3) = "Update Outstanding Set Adjusted= IsNull(Adjusted,0) + " & TotalAdjustmentAmt & " where slcode='" & Trim(VsubCode) & "' And AccountCode='" & Trim(VAccCode) & "' and VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' And VoucherNo='" & Trim(Voucherno) & "' And VoucherCategory='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
                            End If
                            TotalAdjustmentAmt = 0
                            gMatch.Tables.Remove(TableName)
                        End If
                    Next i
                Next k
            End If
            If gMatchAccountcode.Tables.Count > 0 Then
                ReDim Preserve sql(sql.Length + 1)
                sql(sql.Length - 1) = " Delete From MatchingAccountCode Where AvoucherNo='" & Voucherno & "' and AvoucherType='" & VoucherType & "'"
                For i = 0 To gMatchAccountcode.Tables.Count - 1
                    For k = 0 To gMatchAccountcode.Tables(i).Rows.Count - 1
                        With gMatchAccountcode.Tables(i).Rows(k)
                            ReDim Preserve sql(sql.Length + 1)
                            sql(sql.Length - 1) = VCONN.GetAccountMatching(.Item(1), .Item(2), .Item(3), .Item(4), .Item(5), .Item(6), .Item(7), .Item(8), Voucherno, VoucherType, .Item(9))
                        End With
                    Next
                Next
            End If
            'Matching Entry End
            If Updateyes = True Then
                Index = UpdateOperation.Length
                ReDim sqlArray(Index)
                sqlArray.Copy(UpdateOperation, sqlArray, Index)
                ReDim Preserve sqlArray(sqlArray.Length + sql.Length)
                sqlArray.Copy(sql, 0, sqlArray, Index, sql.Length)
                If Cro(0) Is Nothing = False Then
                    ReDim Preserve sqlArray(sqlArray.Length + Cro.Length)
                    sqlArray.Copy(Cro, 0, sqlArray, sqlArray.Length - 1, Cro.Length)
                End If
            Else
                ReDim sqlArray(sql.Length)
                sqlArray.Copy(sql, sqlArray, sql.Length)
                If Cro(0) Is Nothing = False Then
                    ReDim Preserve sqlArray(sqlArray.Length + Cro.Length)
                    sqlArray.Copy(Cro, 0, sqlArray, sqlArray.Length - 1, Cro.Length)
                End If
            End If
            If VCONN.MoreTrans(sqlArray) = True Then
                Me.Lbl_LastVoucher.Text = "Last Doc No" & " " & Voucherno
                MsgBox("Transaction completed suessfully", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, Application.ProductName)

                If MsgBox("Do You Want To Print The Voucher", MsgBoxStyle.YesNo, "Clubman Sliver") = MsgBoxResult.Yes Then
                    gPrint = True
                    Me.Txt_VoucherNo.Text = Voucherno

                    If strCompany_ID.ToUpper = "ASCA" Then
                        If Mid(Txt_VoucherPrefix.Text, 1, 2) = "BR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CC" Then
                            Call MemberReceiptASCA()
                        Else
                            If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
                                Call MemberReceipt()
                            Else
                                Call PreprintVoucher1()
                            End If
                        End If
                    Else
                        If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
                            Call MemberReceipt()
                        Else
                            Call PreprintVoucher1()
                        End If
                    End If
                Else
                    gPrint = False
                End If
                Me.cleroperation()
            End If
        Catch ex As Exception
            MsgBox("Error In Saving")
            Call cleroperation()
        End Try
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        If Me.Validations = False Then
            Exit Sub
        End If
        SaveOperation()
    End Sub
    Private Sub cleroperation()
        CreditsDebits = ""
        strPostingAgainst = ""
        strPostingTo = ""
        Me.Txt_MICRNo.Clear()
        Me.Txt_InstNo.Clear()
        Me.Txt_Naration.Clear()
        Me.Txt_BankPlace.Clear()
        Me.Txt_DrawebankName.Clear()
        Me.Cmb_InstType.SelectedIndex = 0
        Me.Dtp_InstDate.Value = Now
        Me.Dtp_Transdate.Value = Now
        Me.Dtp_Transdate.Value = Now
        Me.Txt_VoucherNo.Clear()
        Me.Txt_VoucherNo.ReadOnly = True
        '    Me.Cmb_VoucherType.SelectedIndex = 0
        Me.Cmb_VoucherType.Focus()
        SSGrid_ReceiptsPayments.ClearRange(1, 1, -1, -1, True)
        SSGrid_ReceiptsPayments.Lock = False

        Me.CmdAdd.Enabled = True
        Me.CmdDelete.Enabled = False

        SSGrid_ReceiptsPayments.SetActiveCell(1, 1)
        Me.Txt_PaidTo.Clear()
        Me.lbl_void.Visible = False
        Me.Cmb_VoucherType.Enabled = True
        Call FillDrCrFlag()
        Updateyes = False
        ' GCroAmt = 0
        GcroUser = ""
        ' GcroVoucherNo = ""
        gMatch.Tables.Clear()
        gMatchAccountcode.Tables.Clear()
        Me.Cmd_VoucherNoHelp.Enabled = True
        Me.Txt_VoucherNo.Enabled = True
        Me.Txt_VoucherNo.ReadOnly = False

        If Index > 0 Then
            Me.Cmb_VoucherType.SelectedIndex = Index
        End If
        ' GcroVoucherNo = ""
        Me.Txt_VoucherNo.Focus()
        gMatch.Dispose()
        GbatchNo = 0
        Me.CmdAdd.Text = "Add [F7]"
        Updateyes = False
        gMatch.Tables.Clear()
        gMatch.Dispose()
        Me.Txt_Total.Text = "0.00"
        With SSGrid_ReceiptsPayments
            .Row = 1
            .Lock = False
        End With
        If Me.Cmb_CashBank.Text = "CASH" Then
            Me.Cmb_InstType.SelectedIndex = -1
        Else
            Me.Cmb_InstType.SelectedIndex = 0
        End If
        Me.Cmb_VoucherType.Focus()
        Glindex = Me.Cmb_GlCode.SelectedIndex
        Cindex = Me.Cmb_CashBank.SelectedIndex
        ' gVoucherno = ""
        gvoucherprefix = ""
        GetRights()

        ''Begin
        'Dim i, j As Int16
        'With SSGrid_ReceiptsPayments
        '    For i = 1 To 500
        '        For j = 1 To 4
        '            .Row = i
        '            .Col = j
        '            .Lock = True
        '        Next
        '    Next
        'End With
        ''End

        'Added on 09 Oct'07
        'Mk Kannan
        'Set as Type Mode
        'Begin
        boolMonthClose = gclsConnection.chkMonthClose(Dtp_VoucherDate, 0)
        If boolMonthClose = False Then
            gclsConnection.farPoint = SSGrid_ReceiptsPayments
            gclsConnection.setAsTypeMode()
        End If
        'End
        Cmb_InstType.Enabled = True
        Txt_InstNo.Enabled = True
        Dtp_InstDate.Enabled = True
    End Sub
    Private Sub SSGrid_ReceiptsPayments_LeaveRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveRowEvent) Handles SSGrid_ReceiptsPayments.LeaveRow
        Dim ACHEAD, SUBLEDGER, COSTCENTER As String
        With SSGrid_ReceiptsPayments
            .GetText(2, .ActiveRow, ACHEAD)
            .GetText(3, .ActiveRow, SUBLEDGER)
            .GetText(4, .ActiveRow, COSTCENTER)
            If ACHEAD = "" Then
                .Col = 5
                .Row = .ActiveRow
                .Text = ""
            End If
        End With
    End Sub
    Private Sub SSGrid_ReceiptsPayments_EnterRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_EnterRowEvent) Handles SSGrid_ReceiptsPayments.EnterRow
        With SSGrid_ReceiptsPayments
            .Col = 5
            .Row = .ActiveRow
            .Text = "0.00"
        End With
    End Sub
    Private Function Validations() As Boolean
        Validations = True
        Dim i As Integer
        Dim achead, sdcAcc() As String
        Dim amount As Double
        Dim gl As Boolean
        Dim Fstart As String
        Dim Fend As String
        Dim Dr As String
        gl = False
        Fstart = "01-APR-" & Trim(gFinancalyearStart)
        Fend = "31-MAR-" & Trim(gFinancialEnd)

        'Added on 10 Dec'07 for Avoiding Nil Data Rows
        'Mk Kannan
        'Begin
        ''With SSGrid_ReceiptsPayments
        ''    For i = 1 To .DataRowCnt
        ''        achead = Nothing
        ''        amount = 0
        ''        .GetText(2, i, achead)
        ''        .GetText(5, i, amount)

        ''        If (Trim(achead) = "" Or Val(amount) = 0) Then
        ''            .DeleteRows(i, 1)
        ''        End If
        ''    Next
        ''End With
        ''amount = 0
        ''End

        If IsDate(Me.Dtp_VoucherDate.Value) = False Then
            Me.Dtp_VoucherDate.Focus()
            MsgBox("Invalid Voucher Date")
            Validations = False
            Exit Function
        End If
        If (Format(Me.Dtp_VoucherDate.Value, "dd-MMM-yyyy") > Format(Fstart, "dd-MMM-yyyy")) And (Format(Me.Dtp_VoucherDate.Value, "dd-MMM-yyyy") < Format(Fend, "dd-MMM-yyyy")) Then
            Me.Dtp_VoucherDate.Focus()
            MsgBox("Voucher Date Should Be Within The Financial Year")
            Validations = False
            Exit Function
        End If
        If GreateDateCheck(DateValue(Me.Dtp_VoucherDate.Text)) = False Then
            MsgBox("The Voucher Date Should Be Less Than System Date")
            Me.Dtp_VoucherDate.Focus()
            Validations = False
            Exit Function
        End If
        If Me.Grp_Instrument.Enabled = True Then
            If IsDate(Me.Dtp_InstDate.Value) = False Then
                Me.Dtp_InstDate.Focus()
                MsgBox("Invalid Instrument Date")
                Validations = False
                Exit Function
            End If
        Else
            Me.Dtp_InstDate.Value = Now
        End If

        If Me.Dtp_Transdate.Visible = True Then
            If IsDate(Me.Dtp_Transdate.Value) Then
                Me.Dtp_Transdate.Focus()
                MsgBox("Invalid Transaction Date")
                Validations = False
                Exit Function
            End If
            If (DateValue(Me.Dtp_Transdate.Value) > DateValue(Fstart)) And (DateValue(Me.Dtp_Transdate.Value) < DateValue(Fend)) Then
                Me.Dtp_Transdate.Focus()
                MsgBox("Transaction  Date Should Be Within The Financial Year")
                Validations = False
                Exit Function
            End If
        End If
        If Trim(Me.Txt_VoucherPrefix.Text) = "MCR" Then
            If Val(Me.Txt_Total) <> Val(GCroAmt) Then
                MsgBox("The Total Amount Is Not Matching With The Cro Received Amount")
                Validations = False
                Exit Function
            End If
        End If
        If Trim(Me.Txt_VoucherPrefix.Text) = "BR" Or Trim(Me.Txt_VoucherPrefix.Text) = "BR" Then
            If Trim(Me.Cmb_InstType.Text) = "" Then
                MsgBox("Instrument Type Can Not Be Blank")
                Me.Cmb_InstType.Focus()
                Validations = False
                Exit Function
            End If
            If Trim(Me.Txt_InstNo.Text) = "" Then
                Me.Txt_InstNo.Focus()
                Me.Txt_InstNo.ReadOnly = False
                MsgBox("Instrument Number Can Not Be Blank")
                Validations = False
                Exit Function
            End If

            If UCase(Trim(Dr)) = "CREDIT" Then
                If Trim(Me.Txt_DrawebankName.Text) = "" Then
                    MsgBox("Bank Name Can Not Be Blank")
                    Me.Txt_DrawebankName.Focus()
                    Me.Txt_DrawebankName.ReadOnly = False
                    Validations = False
                    Exit Function
                End If
            End If
        End If
        If Val(Me.Txt_Total.Text) <= 0 Then
            MsgBox("Amount Cant Be Zero !")
            Validations = False
            Exit Function
        End If
        Validations = gclsConnection.chkMonthClose(Dtp_VoucherDate, 1)
    End Function
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Call cleroperation()
    End Sub
    Private Function UpdateOperation() As String()
        Dim DelSql(5) As String
        Dim Usql() As String
        Dim Usql1() As String
        Dim Voucherno As String
        Dim VoucherType As String
        Dim TotAdjustMentAmt As Double
        Dim i As Integer
        Dim ssql As String
        Dim Accode, SlCode As String
        DelSql(0) = "Delete From Journalentry Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        ''DelSql(1) = "Delete From Outstanding Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        ''DelSql(2) = "Delete From Matching Where AVoucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And AVoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        DelSql(1) = "Delete From Outstanding Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        ssql = " Select VoucherNo,VoucherType,AdjustedAmount,Accountcode,Slcode From Matching Where  AVoucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And AVoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' Order By AccountCode,Slcode"
        VCONN.getDataSet(ssql, "Matching")

        If gdataset.Tables("Matching").Rows.Count > 0 Then

            ReDim Usql(gdataset.Tables("Matching").Rows.Count)
            ReDim Usql1(gdataset.Tables("Matching").Rows.Count)

            Accode = gdataset.Tables("Matching").Rows(i).Item("Accountcode")
            SlCode = gdataset.Tables("Matching").Rows(i).Item("Slcode")

            For i = 0 To gdataset.Tables("Matching").Rows.Count - 1
                If Accode <> gdataset.Tables("Matching").Rows(i).Item("Accountcode") Or SlCode <> gdataset.Tables("Matching").Rows(i).Item("Slcode") Then
                    Usql1(i) = "Update Outstanding Set Adjusted= Isnull(Adjusted,0) - " & TotAdjustMentAmt & " Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(SlCode) & "'"
                    Accode = gdataset.Tables("Matching").Rows(i).Item("Accountcode")
                    SlCode = gdataset.Tables("Matching").Rows(i).Item("Slcode")
                    TotAdjustMentAmt = 0
                End If
                Usql(i) = " Update Outstanding set Adjusted= Isnull(Adjusted,0) - " & Val(gdataset.Tables("Matching").Rows(i).Item("AdjustedAmount")) & " Where Voucherno='" & Trim(gdataset.Tables("Matching").Rows(i).Item("VoucherNo")) & "' And VoucherType='" & Trim(gdataset.Tables("Matching").Rows(i).Item("VoucherType")) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(SlCode) & "'"
                TotAdjustMentAmt = TotAdjustMentAmt + Val(gdataset.Tables("Matching").Rows(i).Item("AdjustedAmount"))
            Next
            Usql1(i) = "Update Outstanding Set Adjusted= Isnull(Adjusted,0) - " & TotAdjustMentAmt & " Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(SlCode) & "'"
        End If

        DelSql(3) = "Update Outstanding Set Avoucherno='' , AvoucherType='' , GridRowNo=NULL Where AVoucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And AVoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        DelSql(2) = "Delete From Matching Where Batchno = " & GbatchNo
        DelSql(4) = "Update Receipt_Details Set Mr_Flag='N',VoucherNo='',VoucherType='' Where VoucherNo='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"

        If Usql Is Nothing = False Then
            i = i + 1
            ReDim Preserve DelSql(DelSql.Length + i)
            DelSql.Copy(Usql, 0, DelSql, 4, i)
            ReDim Preserve DelSql(DelSql.Length + i)
            DelSql.Copy(Usql1, 0, DelSql, DelSql.Length - i, i)
        End If

        Return DelSql
    End Function
    Private Function VOUCHERNOVALIDATE()
        Dim VOUCHERNO As String
        Dim sqlstring, financalyear As String
        If Txt_VoucherNo.Text.Substring(0, 1) <> "C" Then
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialEnd, 3, 4)
            VOUCHERNO = Trim(Txt_VoucherPrefix.Text) & "/" & Format(Val(Txt_VoucherNo.Text), "000000") & "/" & financalyear
            gvoucherprefix = Txt_VoucherPrefix.Text
            VOUCHERNOVALIDATE = VOUCHERNO
        Else
            VOUCHERNO = Trim(Txt_VoucherNo.Text)
            VOUCHERNOVALIDATE = VOUCHERNO
        End If

    End Function
    Private Sub Txt_VoucherNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_VoucherNo.Validated
        Dim sqlstring, financalyear As String
        Dim voucherno As String
        Dim CreditDebit As String
        Dim i, j As Integer
        Dim amount As Double
        Dim accounthead, slhead, costhead As String
        If Trim(Me.Txt_VoucherNo.Text) <> "" Then
            'voucherno = VOUCHERNOVALIDATE()
            'sqlstring = "Select * From JournalEntry Where VoucherNo='" & voucherno & "' and VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' Order By OppAccountCode,CreditDebit"
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialEnd, 3, 4)
            If Val(Me.Txt_VoucherNo.Text) > 0 Then
                Me.Txt_VoucherNo.Text = Me.Txt_VoucherPrefix.Text & "/" & Format(Val(Me.Txt_VoucherNo.Text), "000000") & "/" & financalyear
            End If
            Call VoucherNoValidations(Me.Txt_VoucherNo.Text, Me.Txt_VoucherPrefix.Text)
            GetRights()
        End If
    End Sub
    Public Sub VoucherNoValidations(ByVal VoucherNo As String, ByVal VoucherType As String)
        Dim sqlstring, financalyear As String
        Dim CreditDebit, tblCreDeb As String
        Dim i, j As Integer
        Dim amount As Double
        Dim accounthead, slhead, costhead As String
        Me.Txt_VoucherPrefix.Text = VoucherType

        '''sqlstring = "SELECT TYPEOFDOC FROM ACCOUNTSDOCTYPEMASTER WHERE PreFix = '" & VoucherType & "'"
        '''VCONN.getDataSet(sqlstring, "ACCOUNTSDOCTYPEMASTERPREFIX")
        '''If gdataset.Tables("ACCOUNTSDOCTYPEMASTERPREFIX").Rows.Count > 0 Then
        '''    Me.Cmb_VoucherType.SelectedIndex = Me.Cmb_VoucherType.Items.IndexOf(gdataset.Tables("ACCOUNTSDOCTYPEMASTERPREFIX").Rows(0).Item(0))
        '''    gvoucherprefix = Txt_VoucherPrefix.Text
        '''End If
        '''gdataset.Tables("ACCOUNTSDOCTYPEMASTERPREFIX").Dispose()
        'rowid Elimination in order by for cms
        sqlstring = "Select * From JournalEntry Where VoucherNo='" & Trim(VoucherNo) & "' and VoucherType='" & Trim(VoucherType) & "' Order By rowid,OppAccountCode,CreditDebit"
        VCONN.getDataSet(sqlstring, "JournalEntry")
        If Me.Txt_VoucherNo.ReadOnly = True Then
            Exit Sub
        End If
        If Me.Txt_VoucherNo.Enabled = False Then
            Exit Sub
        End If
        Call FillDrCrFlag()
        If gdataset.Tables("JournalEntry").Rows.Count > 0 Then
            With gdataset.Tables("JournalEntry").Rows(0)
                Me.Txt_VoucherNo.Text = VoucherNo
                Updateyes = True
                GbatchNo = .Item("Batchno")
                Me.Txt_VoucherNo.Enabled = False
                Me.CmdAdd.Text = "Update[F7]"
                Me.Cmb_VoucherType.Enabled = False
                Me.Cmd_VoucherNoHelp.Enabled = False
                Me.Cmb_CashBank.SelectedIndex = Me.Cmb_CashBank.Items.IndexOf(.Item("CashBank"))
                CreditDebit = .Item("CreditDebit")
                accounthead = Trim(Trim(.Item("AccountCode"))) & "--" & Trim(Trim(.Item("Accountcodedesc")))
                Me.Cmb_GlCode.SelectedIndex = Me.Cmb_GlCode.Items.IndexOf(Trim(accounthead))
                Me.Dtp_VoucherDate.Value = DateValue(.Item("VoucherDate"))
                Me.Txt_PaidTo.Text = .Item("PartyName")
                Me.Txt_Naration.Text = .Item("Description")
                If UCase(Format(.Item("ReceivedDate"), "dd-MMM-yyyy")) <> "01-JAN-1900" Then
                    Me.Lbl_UserName.Text = "RECEIVED FROM :"
                    Me.Txt_PaidTo.Text = .Item("ReceivedFrom")
                    Me.Lbl_Transdate.Visible = True
                    Me.Dtp_Transdate.Visible = True
                    Me.Dtp_Transdate.Value = DateValue(.Item("ReceivedDate"))
                End If
                Me.Txt_BankPlace.Text = .Item("BankPlace")
                Me.Txt_DrawebankName.Text = .Item("BankName")
                Me.Txt_InstNo.Text = .Item("InstrumentNo")
                Me.Txt_MICRNo.Text = .Item("Micr")
                Me.Cmb_InstType.SelectedIndex = Me.Cmb_InstType.Items.IndexOf(.Item("InstrumentType"))
                Me.Dtp_InstDate.Value = DateValue(.Item("InstrumentDate"))

                'Refer Amount
                Me.Txt_Total.Text = Format(.Item("amount"), "0.00")

                If Trim(.Item("Void")) = "Y" Then
                    Me.lbl_void.Visible = True
                    Me.CmdDelete.Enabled = False
                Else
                    Me.lbl_void.Visible = False
                End If
            End With

            If UCase(CreditDebit) = "CREDIT" Then
                CreditDebit = "DEBIT"
            Else
                CreditDebit = "CREDIT"
            End If

            For i = 1 To gdataset.Tables("Journalentry").Rows.Count - 1
                With gdataset.Tables("JournalEntry").Rows(i)
                    accounthead = Trim(Trim(.Item("AccountCode"))) & "-->>" & Trim(Trim(.Item("Accountcodedesc")))
                    ' slhead = Trim(Trim(.Item("SlCode"))) & "-->>" & Trim(Trim(.Item("SlDesc")))
                    slhead = Trim(.Item("slcode"))
                    'costhead = Trim(Trim(.Item("CostCenterCode"))) & "-->>" & Trim(Trim(.Item("CostCenterDesc")))
                    costhead = Trim(.Item("SlDesc"))
                    amount = .Item("Amount")
                    tblCreDeb = Trim(.Item("CreditDebit"))
                    VCONN.GetMatchingDetails(Trim(Me.Txt_VoucherNo.Text), Trim(Me.Txt_VoucherPrefix.Text), i, Trim(.Item("Accountcode")), Trim(.Item("Slcode")))
                    With SSGrid_ReceiptsPayments
                        .Col = 1
                        .Row = i
                        If i = 1 Then
                            'Refer
                            'Added as on 27 Jun'07
                            'Begin
                            If (CreditsDebits = "BOTH") Then
                                .TypeComboBoxClear(.Col, .Row)
                                .TypeComboBoxString = "CREDIT"
                                .TypeComboBoxString = "DEBIT"
                                If UCase(tblCreDeb) = "CREDIT" Then
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 0
                                Else
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 1
                                End If
                            Else
                                'End
                                If UCase(CreditDebit) = "CREDIT" Then
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 0
                                Else
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 1
                                End If
                            End If
                        Else
                            'Refer
                            'Added as on 27 Jun'07
                            'Begin
                            If (CreditsDebits = "BOTH") Then
                                .TypeComboBoxClear(.Col, .Row)
                                .TypeComboBoxString = "CREDIT"
                                .TypeComboBoxString = "DEBIT"
                                If UCase(tblCreDeb) = "CREDIT" Then
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 0
                                Else
                                    .Col = 1
                                    .Row = i
                                    .TypeComboBoxCurSel = 1
                                End If
                            Else
                                'End
                                .Col = 1
                                .Row = i
                                .TypeComboBoxString = CreditDebit
                                .TypeComboBoxCurSel = 0
                                '.Text = CreditDebit
                            End If
                        End If
                        .Col = 2
                        .Row = i
                        .Text = accounthead
                        If Trim(slhead) <> "-->>" Then
                            .Col = 3
                            .Row = i
                            .Text = slhead
                        End If
                        If Trim(costhead) <> "-->>" Then
                            .Col = 4
                            .Row = i
                            .Text = costhead
                        End If
                        .Col = 5
                        .Row = i
                        .Text = Format(amount, "0.00")
                    End With
                End With
            Next
            GridLockValidations(i - 1)
            Me.Grp_Instrument.Enabled = False

            With SSGrid_ReceiptsPayments
                For i = 1 To 500
                    For j = 1 To 4
                        .Row = i
                        .Col = j
                        .Lock = True
                    Next
                Next
                .Row = 1
                .Col = 1
                .Lock = False

                'Added on 09 Oct'07 for Month Control
                'Mk Kannan
                'Make it Readable
                'Begin
                boolMonthClose = gclsConnection.chkMonthClose(Dtp_VoucherDate, 1)
                If boolMonthClose = False Then
                    gclsConnection.farPoint = SSGrid_ReceiptsPayments
                    gclsConnection.setAsReadable()
                End If
                'End

                'Refer
                'Added as on 27 Jun'07
                'Begin
                If (CreditsDebits = "BOTH") Then
                    .Col = 1
                    .Row = 1
                    .Lock = True
                    If (strPostingAgainst = "CREDIT") Or (strPostingAgainst = "DEBIT") Then
                        If (strPostingAgainst = "CREDIT") Then
                            .TypeComboBoxCurSel = 0
                        End If
                        If (strPostingAgainst = "DEBIT") Then
                            .TypeComboBoxCurSel = 1
                        End If
                    Else
                        MsgBox("Please, Select Posting Flag in DocumentType Master for this Voucher Type....")
                        Me.CmdAdd.Enabled = False
                        Exit Sub
                    End If
                End If
                'End
            End With

            MatchTable = VCONN.GetMatching(Trim(Txt_VoucherNo.Text), Trim(Me.Txt_VoucherPrefix.Text))
            If MatchTable.Rows.Count = 0 Then
                Me.CmdAdd.Enabled = True
                Me.CmdDelete.Enabled = True
                If Me.lbl_void.Visible = True Then
                    Me.CmdAdd.Enabled = False
                    Me.CmdDelete.Enabled = False
                End If
            Else
                'AvoucherNo,AVoucherDate,AvoucherType,AdjustedAmount
                Me.CmdAdd.Enabled = False
                Me.CmdDelete.Enabled = False
                ' Dim MDet As New MatchingDetails
                If MDIParentobj.ActiveMdiChild.Name Is "MatchingDetails" Then
                Else
                    '' MDet.MdiParent = MdiParentObj
                    '' MDet.Show()
                End If
            End If
        Else
            Txt_VoucherNo.Clear()
            Dtp_VoucherDate.Focus()
        End If
    End Sub
    Private Sub GridLockValidations(ByVal RowCount As Integer)
        Dim i, j As Integer
        With SSGrid_ReceiptsPayments
            For i = 1 To 500
                For j = 2 To 5
                    .Col = j
                    .Row = i
                    .Lock = False
                Next
            Next

            For i = 1 To RowCount
                For j = 2 To 5
                    .Col = j
                    .Row = i
                    If Trim(.Text) = "" Then
                        .Lock = True
                    Else
                        .Lock = False
                    End If
                Next
            Next
        End With
    End Sub
    Private Sub DeleteOperation()
        Dim sql(5) As String
        Dim ssql As String
        Dim Usql() As String
        Dim USql1() As String
        Dim Accode As String
        Dim Slcode As String
        Dim TotAdjustMentAmt As Double
        Dim i As Integer
        If Me.Txt_VoucherNo.Enabled = True Then
            MsgBox("Invalid Voucher No")
            Exit Sub
        End If
        Try
            ssql = " Select VoucherNo,VoucherType,AdjustedAmount,Accountcode,Slcode From Matching Where  AVoucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And AVoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' Order By AccountCode,Slcode"
            VCONN.getDataSet(ssql, "Matching")

            If gdataset.Tables("Matching").Rows.Count > 0 Then

                ReDim Usql(gdataset.Tables("Matching").Rows.Count)
                ReDim USql1(gdataset.Tables("Matching").Rows.Count)

                Accode = gdataset.Tables("Matching").Rows(i).Item("Accountcode")
                Slcode = gdataset.Tables("Matching").Rows(i).Item("Slcode")

                For i = 0 To gdataset.Tables("Matching").Rows.Count - 1
                    If Accode <> gdataset.Tables("Matching").Rows(i).Item("Accountcode") Or Slcode <> gdataset.Tables("Matching").Rows(i).Item("Slcode") Then
                        USql1(i) = "Update Outstanding Set Adjusted= Isnull(Adjusted,0) - " & TotAdjustMentAmt & " Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(Slcode) & "'"
                        Accode = gdataset.Tables("Matching").Rows(i).Item("Accountcode")
                        Slcode = gdataset.Tables("Matching").Rows(i).Item("Slcode")
                        TotAdjustMentAmt = 0
                    End If
                    Usql(i) = " Update Outstanding set Adjusted= Isnull(Adjusted,0) - " & Val(gdataset.Tables("Matching").Rows(i).Item("AdjustedAmount")) & " Where Voucherno='" & Trim(gdataset.Tables("Matching").Rows(i).Item("VoucherNo")) & "' And VoucherType='" & Trim(gdataset.Tables("Matching").Rows(i).Item("VoucherType")) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(Slcode) & "'"
                    TotAdjustMentAmt = TotAdjustMentAmt + Val(gdataset.Tables("Matching").Rows(i).Item("AdjustedAmount"))
                Next
                USql1(i) = "Update Outstanding Set Adjusted= Isnull(Adjusted,0) - " & TotAdjustMentAmt & " Where Voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' And Accountcode='" & Trim(Accode) & "' And Slcode='" & Trim(Slcode) & "'"
            End If

            sql(0) = "Update JournalEntry Set Void='Y' where Voucherno='" & Me.Txt_VoucherNo.Text & "' And VoucherType='" & Me.Txt_VoucherPrefix.Text & "'"
            sql(1) = "Update OutStanding Set Void='Y' where Voucherno='" & Me.Txt_VoucherNo.Text & "' And VoucherType='" & Me.Txt_VoucherPrefix.Text & "'"
            sql(2) = "Delete From Matching where Voucherno='" & Me.Txt_VoucherNo.Text & "' And VoucherType='" & Me.Txt_VoucherPrefix.Text & "'"
            sql(3) = "Delete From Matching where AVoucherno='" & Me.Txt_VoucherNo.Text & "' And AVoucherType='" & Me.Txt_VoucherPrefix.Text & "'"
            sql(4) = "Update Receipt_Details Set Mr_Flag='N',VoucherNo='',VoucherType='' Where VoucherNo='" & Trim(Me.Txt_VoucherNo.Text) & "' And VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"

            If Usql Is Nothing = False Then
                i = i + 1
                ReDim Preserve sql(sql.Length + i)
                sql.Copy(Usql, 0, sql, 4, i)
                ReDim Preserve sql(sql.Length + i)
                sql.Copy(USql1, 0, sql, sql.Length - i, i)
            End If
            If VCONN.MoreTrans(sql) = True Then
                Me.lbl_void.Visible = True
                MsgBox("Record Deleted Successfully")
                Me.cleroperation()
            End If
        Catch ex As Exception
            MsgBox("Error in Delete Operations")
            Exit Sub
        End Try
    End Sub
    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If MessageBox.Show("Are You Sure To Delete!", Application.ProductName, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Call DeleteOperation()
        Else
            MsgBox("Deletion is Cancelled!", MsgBoxStyle.OKOnly, gCompanyname)
        End If

    End Sub
    Private Sub MembersReceipts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            If Me.CmdAdd.Enabled = False Then
                Exit Sub
            Else
                Me.CmdAdd_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F6 Then
            Me.CmdClear_Click(sender, e)
        End If
        If e.KeyCode = Keys.F11 Then
            Me.cmdexit_Click(sender, e)
        End If
        If e.KeyCode = Keys.F8 Then

            If Me.CmdDelete.Enabled = True Then
                Me.CmdDelete_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            gPrint = False
            Me.CmdView_Click(sender, e)
        End If
        If e.KeyCode = Keys.F12 Then
            gPrint = True
            Call cmdPrint_Click(sender, e)
        End If
        If e.KeyCode = Keys.F2 Then
            Me.Txt_VoucherNo.Focus()
        End If
        If e.KeyCode = Keys.F5 Then
            ''Dim Viewer As New ReportViwer
            ''Dim r As New Payment_Print
            ''Dim txtobj1 As TextObject
            ''Dim ssql12 As String
            ''ssql12 = " select * from journalentry where voucherno='" & Trim(Txt_VoucherNo.Text) & "' and isnull(void,'') <> 'Y' AND ISNULL(OPPACCOUNTCODE,'')= '' AND  creditdebit = 'CREDIT'"
            ''txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            ''txtobj1.Text = RupeesToWordASCA(Val(Txt_Total.Text))
            ''Call Viewer.GetDetails(ssql12, "journalentry", r)
            ''Viewer.Show()
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        ' If strCompany_ID.ToUpper = "ASCA" Then
        If Mid(Txt_VoucherPrefix.Text, 1, 2) = "BR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CC" Then
            Call MemberReceiptASCA()
        Else
            If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
                Call MemberReceipt()
            Else
                Call PreprintVoucher1()
            End If
        End If
        'Else
        If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
            Call MemberReceipt()
        Else
            Call MemberReceipt()
        End If
        'End If
        'End
    End Sub
    Private Sub MemberReceiptASCA()
        Randomize()
        Dim vRowcount, I As Integer
        Dim VpageNumber, ROWCOUNT As Integer
        Dim vBRRS As New ADODB.Recordset
        Dim vOutputfile As String
        Dim vCaption As String
        Dim vSlName As String
        Dim vGLName As String
        Dim vNarrtion1 As String
        Dim vDrAmt As Double
        Dim vSpace As Integer
        Dim vAmtDesc As String
        Dim vou As String
        Dim vAddRs As New ADODB.Recordset
        Dim RVoucherno, RVoucherDate, RVoucherType, RAmount, RvoucherCategory
        Dim vRow As Integer
        Dim vFlag
        Dim vtag, VSQL, SSQL, GlAccount As String
        Dim VGLCODE, VGLDESC, VCRDR
        Dim VGL() As String
        vOutputfile = Mid("Cash" + CStr(Int(Rnd() * 5000)), 1, 7)
        vRowcount = 0
        'vBRRS = New ADODB.Recordset
        VSQL = "Select void,voucherno,Voucherdate,Vouchertype,Accountcode,accountcodedesc,slcode,creditdebit,amount As Amount ,description,isnull(InstrumentDate,'') as InstrumentDate,isnull(Instrumentno,'') as InstrumentNo,Receivedfrom"
        VSQL = VSQL & " from JournalEntry where Vouchertype='" & Trim(Txt_VoucherPrefix.Text) & "' and voucherno='" & Trim(Txt_VoucherNo.Text) & "' and CreditDebit='Credit' "
        VCONN.getDataSet(VSQL, "CASHVOUCHERPRINT")
        If gdataset.Tables("CASHVOUCHERPRINT").Rows.Count > 0 Then
            VpageNumber = 1
            vOutfile = Mid("CP" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath

            PageNo = 1 : ROWCOUNT = 0
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 1
            vtag = SSGrid_ReceiptsPayments.Text
            vCaption = ""
            If Mid(Trim(Cmb_CashBank.Text), 1, 4) = "CASH" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID  RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID  PAYMENT VOUCHER"
                    End If
                Else
                    'If UCase(Mid(vtag, 1, 2)) = "CR" Then
                    '    vCaption = "  RECEIPT VOUCHER"
                    'Else
                    '    vCaption = "  PAYMENT VOUCHER"
                    'End If
                End If
            ElseIf Mid(Trim(Cmb_CashBank.Text), 1, 4) = "BANK" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID  RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID  PAYMENT VOUCHER"
                    End If
                Else
                    'If UCase(Mid(vtag, 1, 2)) = "CR" Then
                    '    vCaption = " RECEIPT VOUCHER"
                    'Else
                    '    vCaption = " PAYMENT VOUCHER"
                    'End If
                End If
            End If
            'VCONN.printheader(80, vCaption)
            'Filewrite.WriteLine()

            'vRowcount = vRowcount + 5
            'Filewrite.WriteLine(Space(80 - Len(vCaption)) / 2 & Chr(15) & Chr(14) & vCaption & Chr(18))
            'Filewrite.WriteLine(StrDup(80, "-"))

            'Filewrite.Write("Voucher  No.  :")            
            'Filewrite.Write(Trim(Txt_VoucherNo.Text))

            'Filewrite.Write(Space(23) & "Voucher  Date. :")
            Filewrite.Write(Chr(27) & Chr(106) & Chr(200))
            For I = 0 To 3
                Filewrite.WriteLine("")
            Next
            Filewrite.WriteLine(Space(7) & Chr(15) & Chr(14) & Trim(Txt_VoucherNo.Text) & Space(22) & Format(Dtp_VoucherDate.Value), "dd-MMM-yyyy")
            Filewrite.WriteLine("")
            GlAccount = ""

            Dim boolOut As Boolean
            boolOut = False
            If SSGrid_ReceiptsPayments.DataRowCnt > 1 Then
                For I = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                    With SSGrid_ReceiptsPayments
                        .Row = I
                        .Col = 2
                        If Trim(.Text) <> "" Then
                            VGL = Split(.Text, "-->>")
                            VGLCODE = VGL(0)
                            VGLCODE = Trim(Mid(VGLCODE, 1, 8))
                            If (VGLCODE = gDebitors) Then
                                boolOut = True
                                Exit For
                            End If
                        End If
                    End With
                Next
            End If
            If SSGrid_ReceiptsPayments.DataRowCnt > 1 And boolOut = False Then
                For I = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                    With SSGrid_ReceiptsPayments
                        .Row = I
                        .Col = 2
                        If Trim(.Text) <> "" Then
                            VGL = Split(.Text, "-->>")
                            VGLCODE = VGL(0)
                            VGLCODE = Mid(VGLCODE, 1, 8)
                            VGLDESC = Mid(VGL(1), 1, 30)
                            'Filewrite.Write(Mid(VGLCODE, 1, 8) & Space(8 - Len(Mid(VGLCODE, 1, 8))))
                            'Filewrite.Write(Mid(VGLDESC, 1, 50) & Space(50 - Len(Mid(VGLDESC, 1, 50))))
                            '.Col = 5
                            'Filewrite.Write(Format(Val(Mid(.Text, 1, 12)), "0.00") & Space(12 - Len(Mid(.Text, 1, 12))))
                            '.Col = 1
                            'Filewrite.WriteLine(LCase(Mid(.Text, 1, 6)) & Space(6 - Len(Mid(.Text, 1, 6))))

                            ''''11/09/2007 saran
                            'statring
                            'GlAccount = Trim(GlAccount) & " " & Trim(VGLCODE)
                            ' ending

                            GlAccount = Trim(GlAccount) & " " & Trim(VGLDESC)
                            VGLCODE = ""
                            VGLDESC = ""
                        End If
                    End With
                    vRowcount = vRowcount + I
                Next
            Else
                With SSGrid_ReceiptsPayments
                    .Row = 1
                    .Col = 3
                    VGL = Split(.Text, "-->>")
                    If Trim(VGL(0)) <> "" Then
                        VGLCODE = VGL(0)
                        VGLCODE = Mid(VGLCODE, 1, 8)
                        VGLDESC = Mid(VGL(1), 1, 30)
                    Else
                        VGLCODE = ""
                        VGLDESC = ""
                    End If
                End With
            End If
            If VGLCODE <> "" Then
                Filewrite.WriteLine(Space(46) & Chr(15) & Chr(14) & UCase(Trim(VGLDESC)) & Chr(18))
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Space(27) & VGLCODE)
                Filewrite.WriteLine("")
                Filewrite.WriteLine("")
                Filewrite.WriteLine("")
            Else
                If Trim(Me.Txt_PaidTo.Text) <> "" Then
                    Filewrite.WriteLine(Space(46) & Chr(15) & Chr(14) & UCase(Trim(Txt_PaidTo.Text)) & Chr(18))
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                Else
                    Filewrite.WriteLine("---->  Nil <----")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                End If
                'With SSGrid_ReceiptsPayments
                '    .Row = 1
                '    .Col = 2
                '    VGL = Split(.Text, "-->>")
                'End With
                'If Trim(VGL(0)) <> "" Then
                '    VGLCODE = VGL(0)
                '    VGLCODE = Mid(VGLCODE, 1, 8)
                '    VGLDESC = Mid(VGL(1), 1, 30)
                '    Filewrite.WriteLine("Account Code :" & VGLCODE & "-->" & VGLDESC)
                'End If
            End If
            'Modified as on 28 Aug 07
            'Filewrite.WriteLine()
            'Filewrite.WriteLine(Space(60) & "Rs." & Format(Val(Me.Txt_Total.Text), "0.00"))
            If UCase(vtag) = "CREDIT" Then
                'Filewrite.Write("Received With Thanks From   :")
                'If Trim(Me.Txt_PaidTo.Text) <> "" Then
                '    Filewrite.WriteLine(UCase(Trim(Txt_PaidTo.Text)))
                'Else
                '    Filewrite.WriteLine(UCase(Trim(VGLDESC)))
                'End If
            Else
                'Filewrite.Write("Paid To   :")
                'If Trim(Me.Txt_PaidTo.Text) <> "" Then
                '    Filewrite.WriteLine(UCase(Trim(Txt_PaidTo.Text)))
                'Else
                '    Filewrite.WriteLine(UCase(Trim(VGLDESC)))
                'End If
            End If
            Filewrite.WriteLine("")
            'Filewrite.WriteLine("THE SUM OF RUPEES " & RupeesToWord(Val(Txt_Total.Text)))
            If (Len(RupeesToWordASCA(Val(Txt_Total.Text))) <= 54) Then
                Filewrite.WriteLine(Space(18) & RupeesToWordASCA(Val(Txt_Total.Text)))
                Filewrite.WriteLine("")
                Filewrite.WriteLine("")
            Else
                Filewrite.WriteLine(Space(18) & Mid(RupeesToWordASCA(Val(Txt_Total.Text)), 1, 54) & "-")
                Filewrite.WriteLine(Space(5) & Mid(RupeesToWordASCA(Val(Txt_Total.Text)), 55, Len(RupeesToWordASCA(Val(Txt_Total.Text)))))
                Filewrite.WriteLine("")
            End If
            If Len(Me.Txt_Naration.Text) <= 52 Then
                'Filewrite.WriteLine("On Account Of " & Mid(Txt_Naration.Text, 1, 52))
                'Filewrite.WriteLine("")
                'vRowcount = vRowcount + 2
            Else
                'Filewrite.WriteLine("On Account Of " & Mid(Txt_Naration.Text, 1, 65))
                'Filewrite.WriteLine("           " & Mid(Txt_Naration.Text, 66, 137))
                'Filewrite.WriteLine("")
                'vRowcount = vRowcount + 3
            End If
            Filewrite.WriteLine("")
            If UCase(Trim(Me.Cmb_CashBank.Text)) = "CASH" Then
                Filewrite.WriteLine(Space(20) & "BY CASH")
            Else
                'Refer Cheque No
                'Filewrite.Write("Cheque No" & Me.Txt_InstNo.Text)
                Filewrite.Write(Space(22) & Me.Txt_InstNo.Text)
                If UCase(vtag) = "CREDIT" Then
                    Filewrite.Write(" Dt " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy"))
                Else
                    Filewrite.WriteLine(" Dt " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy"))
                End If
                If UCase(vtag) = "CREDIT" Then
                    Filewrite.WriteLine(" Drawn On " & Trim(Me.Txt_DrawebankName.Text))
                End If
            End If
            Filewrite.WriteLine("")
            If (Trim(Txt_Naration.Text) <> "") Then
                If (Len(Trim(Txt_Naration.Text)) <= 60) Then
                    Filewrite.WriteLine(Space(10) & Trim(Txt_Naration.Text))
                    Filewrite.WriteLine("")
                Else
                    Filewrite.WriteLine(Space(10) & Mid(Trim(Txt_Naration.Text), 1, 60))
                    Filewrite.WriteLine(Space(10) & Trim(Mid(Trim(Txt_Naration.Text), 61, 120)))
                End If
            Else
                If (Trim(GlAccount) <> "") Then
                    Filewrite.WriteLine(Space(10) & Chr(15) & Trim(GlAccount) & Chr(18))
                    Filewrite.WriteLine("")
                Else
                    Filewrite.WriteLine(Space(10) & "MEMBER DUES OUTSTANDING")
                    Filewrite.WriteLine("")
                End If
            End If
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            If (Trim(vCaption) <> "") Then
                Filewrite.WriteLine(Space(7) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Format(Val(Me.Txt_Total.Text), "0.00") & Chr(20) & Chr(27) & Chr(72))
            Else
                Filewrite.WriteLine(Space(7) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Format(Val(Me.Txt_Total.Text), "0.00") & Space(10) & Trim(vCaption) & Chr(20) & Chr(27) & Chr(72))
            End If
            'Filewrite.WriteLine("Manager (Accounts)                                                  Cashier")
            'Filewrite.WriteLine(StrDup(80, "-"))
            'vRowcount = vRowcount + 5
            'vRowcount = vRowcount + 9
            For I = 1 To 15
                Filewrite.WriteLine("")
            Next
        End If
        'Filewrite.Write(Chr(27) & Chr(106) & Chr(200))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
        End If
        '''If Mid(Trim(vVoucherType), 1, 2) = "CR" Then
        '''    Print #1, "Prepared By " & Space(48) & "Cheif Cashier"
        '''Else
        '''    Print #1, "Prepared By " & Space(15) & "Financial controller" & Space(7) & "Deputy Managing Member"
        '''End If
        '''Print #1,
        '''Print #1, "(" & Trim(gUserName) & ")"
        '''vRowcount = vRowcount + 3
        '''If Val(vRowcount) < 40 Then
        '''    GoSub PrSpace
        '''End If
        'Print #1, Chr(12)
    End Sub
    Private Sub MemberReceipt()
        Randomize()
        Dim vRowcount, I As Integer
        Dim VpageNumber, ROWCOUNT As Integer
        Dim vBRRS As New ADODB.Recordset
        Dim vOutputfile As String
        Dim vCaption As String
        Dim vSlName As String
        Dim vGLName As String
        Dim vNarrtion1 As String
        Dim vDrAmt As Double
        Dim vSpace As Integer
        Dim vAmtDesc As String
        Dim vou As String
        Dim vAddRs As New ADODB.Recordset
        Dim RVoucherno, RVoucherDate, RVoucherType, RAmount, RvoucherCategory
        Dim vRow As Integer
        Dim vFlag
        Dim vtag, VSQL, SSQL As String
        Dim VGLCODE, VGLDESC, VCRDR
        Dim VGL(), strDebtors As String
        vOutputfile = Mid("Cash" + CStr(Int(Rnd() * 5000)), 1, 7)
        vRowcount = 0

        'vBRRS = New ADODB.Recordset
        VSQL = "Select void,voucherno,Voucherdate,Vouchertype,Accountcode,accountcodedesc,slcode,creditdebit,amount As Amount ,description,isnull(InstrumentDate,'') as InstrumentDate,isnull(Instrumentno,'') as InstrumentNo,Receivedfrom"
        VSQL = VSQL & " from JournalEntry where Vouchertype='" & Trim(Txt_VoucherPrefix.Text) & "' and voucherno='" & Trim(Txt_VoucherNo.Text) & "' and CreditDebit='Credit' "
        VCONN.getDataSet(VSQL, "CASHVOUCHERPRINT")
        If gdataset.Tables("CASHVOUCHERPRINT").Rows.Count > 0 Then
            VpageNumber = 1
            vOutfile = Mid("CP" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            PageNo = 1 : ROWCOUNT = 0
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 1
            vtag = SSGrid_ReceiptsPayments.Text
            If Mid(Trim(Cmb_CashBank.Text), 1, 4) = "CASH" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID  RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID  PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "  RECEIPT VOUCHER"
                    Else
                        vCaption = "  PAYMENT VOUCHER"
                    End If
                End If
            ElseIf Mid(Trim(Cmb_CashBank.Text), 1, 4) = "BANK" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID  RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID  PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = " RECEIPT VOUCHER"
                    Else
                        vCaption = " PAYMENT VOUCHER"
                    End If
                End If
            End If
            VCONN.printheader(80, vCaption)
            Filewrite.WriteLine()
            vRowcount = vRowcount + 5
            'Filewrite.WriteLine(Space(80 - Len(vCaption)) / 2 & Chr(15) & Chr(14) & vCaption & Chr(18))
            Filewrite.WriteLine(StrDup(80, "-"))

            Filewrite.Write("Voucher  No.  :")
            Filewrite.Write(Trim(Txt_VoucherNo.Text))

            Filewrite.Write(Space(23) & "Voucher  Date. :")
            Filewrite.WriteLine(Format(Dtp_VoucherDate.Value), "dd-MMM-yyyy")
            Filewrite.WriteLine()
            vRowcount = vRowcount + 4

            'Added on 10 Dec'07
            'Mk Kannan
            'Begin
            With SSGrid_ReceiptsPayments
                .Row = 1
                .Col = 2
                VGL = Split(.Text, "-->>")
            End With
            If Trim(VGL(0)) <> "" Then
                strDebtors = Trim(VGL(0))
            Else
                strDebtors = ""
            End If
            VGL = Nothing
            'End

            With SSGrid_ReceiptsPayments
                .Row = 1
                .Col = 3
                VGL = Split(.Text, "-->>")
                If Trim(VGL(0)) <> "" Then
                    VGLCODE = VGL(0)
                    VGLCODE = Mid(VGLCODE, 1, 8)
                    'VGLDESC = Mid(VGL(1), 1, 30)
                    .Row = 1
                    .Col = 4
                    VGLDESC = Mid(.Text, 1, 30)
                Else
                    VGLCODE = ""
                    VGLDESC = ""
                End If
            End With
            'Modified on 10 Dec'07
            'Mk Kannan
            'Begin
            If VGLCODE <> "" Then
                If strDebtors = gDebitors Then
                    Filewrite.WriteLine("Membership No. :" & VGLCODE)
                Else
                    VGLCODE = ""
                    VGLDESC = ""
                End If
            End If
            If Trim(VGLCODE) = "" Then
                'End
                With SSGrid_ReceiptsPayments
                    .Row = 1
                    .Col = 2
                    VGL = Split(.Text, "-->>")
                End With
                If Trim(VGL(0)) <> "" Then
                    VGLCODE = VGL(0)
                    VGLCODE = Mid(VGLCODE, 1, 8)
                    VGLDESC = Mid(VGL(1), 1, 30)
                    Filewrite.WriteLine("Account Code :" & VGLCODE & "-->" & VGLDESC)
                End If
            End If
            Filewrite.WriteLine()
            Filewrite.WriteLine(Space(60) & "Rs." & Format(Val(Me.Txt_Total.Text), "0.00"))
            vRowcount = vRowcount + 4
            If UCase(vtag) = "CREDIT" Then
                Filewrite.Write("Received With Thanks From   :")
                If Trim(Me.Txt_PaidTo.Text) <> "" Then
                    Filewrite.WriteLine(UCase(Trim(Txt_PaidTo.Text)))
                Else
                    Filewrite.WriteLine(UCase(Trim(VGLDESC)))
                End If
            Else
                Filewrite.Write("Paid To   :")
                If Trim(Me.Txt_PaidTo.Text) <> "" Then
                    Filewrite.WriteLine(UCase(Trim(Txt_PaidTo.Text)))
                Else
                    Filewrite.WriteLine(UCase(Trim(VGLDESC)))
                End If
            End If
            Filewrite.WriteLine()
            Filewrite.WriteLine("THE SUM OF RUPEES " & RupeesToWord(Val(Txt_Total.Text)))
            Filewrite.WriteLine("")
            vRowcount = vRowcount + 4
            If Len(Me.Txt_Naration.Text) <= 52 Then
                Filewrite.WriteLine("On Account Of " & Mid(Txt_Naration.Text, 1, 52))
                Filewrite.WriteLine("")
                vRowcount = vRowcount + 2
            Else
                Filewrite.WriteLine("On Account Of " & Mid(Txt_Naration.Text, 1, 65))
                Filewrite.WriteLine("           " & Mid(Txt_Naration.Text, 66, 137))
                Filewrite.WriteLine("")
                vRowcount = vRowcount + 3
            End If

            If UCase(Trim(Me.Cmb_CashBank.Text)) = "CASH" Then
                Filewrite.WriteLine("By Cash")
                vRowcount = vRowcount + 1
            Else
                'Refer Cheque No
                Filewrite.Write("Cheque No" & Me.Txt_InstNo.Text)
                Filewrite.Write(" Dt" & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy"))
                vRowcount = vRowcount + 2
                If UCase(vtag) = "CREDIT" Then
                    Filewrite.Write(" Drawn On  " & Me.Txt_DrawebankName.Text)
                    vRowcount = vRowcount + 1
                End If
            End If
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("Manager (Accounts)                                                  Cashier")
            Filewrite.WriteLine(StrDup(80, "-"))
            vRowcount = vRowcount + 5
            'vRowcount = vRowcount + 9
            If vRowcount <= 38 Then
                For I = 1 To 38 - vRowcount
                    Filewrite.WriteLine("")
                Next
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Else
            MsgBox("Data table Not Found......", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
            cmdexit.Focus()
        End If
        '''If Mid(Trim(vVoucherType), 1, 2) = "CR" Then
        '''    Print #1, "Prepared By " & Space(48) & "Cheif Cashier"
        '''Else
        '''    Print #1, "Prepared By " & Space(15) & "Financial controller" & Space(7) & "Deputy Managing Member"
        '''End If
        '''Print #1,
        '''Print #1, "(" & Trim(gUserName) & ")"
        '''vRowcount = vRowcount + 3
        '''If Val(vRowcount) < 40 Then
        '''    GoSub PrSpace
        '''End If
        'Print #1, Chr(12)
    End Sub
    Private Sub PreprintVoucher1()
        Randomize()
        Dim vRowcount, I As Integer
        Dim VpageNumber, ROWCOUNT As Integer
        Dim vBRRS As New ADODB.Recordset
        Dim vOutputfile As String
        Dim vCaption As String
        Dim vSlName As String
        Dim vGLName As String
        Dim vNarrtion1 As String
        Dim vDrAmt As Double
        Dim vSpace As Integer
        Dim vAmtDesc As String
        Dim vou As String
        Dim vAddRs As New ADODB.Recordset
        Dim RVoucherno, RVoucherDate, RVoucherType, RAmount, RvoucherCategory
        Dim vRow As Integer
        Dim vFlag
        Dim vtag, VSQL, SSQL As String
        Dim VGLCODE, VGLDESC, VCRDR
        Dim VGL() As String
        vOutputfile = Mid("Cash" + CStr(Int(Rnd() * 5000)), 1, 7)
        vRowcount = 0

        'vBRRS = New ADODB.Recordset
        VSQL = "Select void,voucherno,Voucherdate,Vouchertype,Accountcode,slcode,creditdebit,amount As Amount ,description,Isnull(InstrumentDate,'') as InstrumentDate,IsNull(Instrumentno,'') AS IstrumentNo,Receivedfrom"
        VSQL = VSQL & " from JournalEntry where Vouchertype='" & Trim(Txt_VoucherPrefix.Text) & "' and voucherno='" & Trim(Txt_VoucherNo.Text) & "' and CreditDebit='Credit' "
        VCONN.getDataSet(VSQL, "CASHVOUCHERPRINT")
        If gdataset.Tables("CASHVOUCHERPRINT").Rows.Count > 0 Then
            VpageNumber = 1
            vOutfile = Mid("CP" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            PageNo = 1 : ROWCOUNT = 0
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 1
            vtag = SSGrid_ReceiptsPayments.Text
            If Mid(Trim(Cmb_CashBank.Text), 1, 4) = "CASH" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID CASH RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID CASH PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = " CASH RECEIPT VOUCHER"
                    Else
                        vCaption = " CASH PAYMENT VOUCHER"
                    End If
                End If
            ElseIf Mid(Trim(Cmb_CashBank.Text), 1, 4) = "BANK" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID BANK RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID BANK PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = " BANK RECEIPT VOUCHER"
                        If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
                            Call print_fillsdrs()
                            Exit Sub
                        End If
                    Else
                        vCaption = " BANK PAYMENT VOUCHER"
                    End If
                End If
            End If
            'Filewrite.WriteLine(gMAINCompanyname)
            VCONN.printheader(80, vCaption)

            Filewrite.Write(Space(49) & "Voucher  No.  :")
            Filewrite.WriteLine(Trim(Txt_VoucherNo.Text))
            Filewrite.Write(Space(49) & "Voucher  Date. :")
            Filewrite.WriteLine(Format(Dtp_VoucherDate.Value), "dd-MMM-yyyy")
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.Write("Amount   :")
            Filewrite.WriteLine(RupeesToWord(Val(Txt_Total.Text)))
            If UCase(vtag) = "CREDIT" Then
                Filewrite.Write("Received With Thanks From   :")
                If Trim(Me.Txt_PaidTo.Text) <> "" Then
                    Filewrite.WriteLine(Trim(Txt_PaidTo.Text))
                Else
                    With SSGrid_ReceiptsPayments
                        .Row = 1
                        .Col = 3
                        If Trim(.Text) <> "" Then
                            VGL = Split(.Text, "-->>")
                            VGLCODE = VGL(0)
                            VGLCODE = Mid(VGLCODE, 1, 8)
                            .Row = 1
                            .Col = 4
                            VGLDESC = Mid(.Text, 1, 30)
                            Filewrite.WriteLine(Trim(VGLDESC))
                        End If
                    End With
                End If
            Else
                Filewrite.Write("Paid To   :")
                If Trim(Me.Txt_PaidTo.Text) <> "" Then
                    Filewrite.WriteLine(Trim(Txt_PaidTo.Text))
                Else
                    With SSGrid_ReceiptsPayments
                        .Row = 1
                        .Col = 3
                        If Trim(.Text) <> "" Then
                            VGL = Split(.Text, "-->>")
                            VGLCODE = VGL(0)
                            VGLCODE = Mid(VGLCODE, 1, 8)
                            ' VGLDESC = Mid(VGL(1), 1, 30)
                            .Row = 1
                            .Col = 4
                            VGLDESC = Mid(.Text, 1, 30)
                            Filewrite.WriteLine(Trim(VGLDESC))
                        End If
                    End With
                End If
            End If
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.WriteLine("GL Code Account Description                               Amount       Dr/Cr ")
            Filewrite.WriteLine(StrDup(80, "-"))
            vRowcount = 10
            For I = 1 To SSGrid_ReceiptsPayments.DataRowCnt
                With SSGrid_ReceiptsPayments
                    .Row = I
                    .Col = 2
                    If Trim(.Text) <> "" Then
                        VGL = Split(.Text, "-->>")
                        VGLCODE = VGL(0)
                        VGLCODE = Mid(VGLCODE, 1, 8)
                        ' VGLDESC = Mid(VGL(1), 1, 30)
                        .Row = 1
                        .Col = 4
                        VGLDESC = Mid(.Text, 1, 30)

                        Filewrite.Write(Mid(VGLCODE, 1, 8) & Space(8 - Len(Mid(VGLCODE, 1, 8))))
                        Filewrite.Write(Mid(VGLDESC, 1, 50) & Space(50 - Len(Mid(VGLDESC, 1, 50))))
                        .Col = 5
                        Filewrite.Write(Format(Val(Mid(.Text, 1, 12)), "0.00") & Space(12 - Len(Mid(.Text, 1, 12))))
                        .Col = 1
                        Filewrite.WriteLine(LCase(Mid(.Text, 1, 6)) & Space(6 - Len(Mid(.Text, 1, 6))))
                    End If
                End With
                vRowcount = vRowcount + I
            Next

            VGL = Split(Cmb_GlCode.Text, "--")
            VGLCODE = VGL(0)
            VGLCODE = Mid(VGLCODE, 1, 8)
            'VGLDESC = Mid(VGL(1), 1, 30)
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 4
            VGLDESC = Mid(SSGrid_ReceiptsPayments.Text, 1, 30)
            Filewrite.Write(Mid(VGLCODE, 1, 8) & Space(8 - Len(Mid(VGLCODE, 1, 8))))
            Filewrite.Write(Mid(VGLDESC, 1, 50) & Space(50 - Len(Mid(VGLDESC, 1, 50))))
            Filewrite.Write(Format(Val(Mid(Txt_Total.Text, 1, 12)), "0.00") & Space(12 - Len(Mid(Txt_Total.Text, 1, 12))))
            If UCase(Mid(vtag, 1, 2)) = "CR" Then
                Filewrite.WriteLine("Debit")
            Else
                Filewrite.WriteLine("Credit")
            End If
            vRowcount = vRowcount + 1
        End If
        Filewrite.WriteLine("")
        Filewrite.WriteLine(StrDup(80, "-"))
        Filewrite.Write(Space(58) & Format(Val(Mid(Txt_Total.Text, 1, 12)), "0.00") & Space(12 - Len(Mid(Txt_Total.Text, 1, 12))))
        Filewrite.WriteLine("")
        If Len(Me.Txt_Naration.Text) <= 68 Then
            Filewrite.WriteLine("Narration :" & Mid(Txt_Naration.Text, 1, 68))
            'Modified as on 29 Jun'07
            'Begin
            'Filewrite.WriteLine("")
            If (CreditsDebits = "BOTH") Then
                If UCase(Trim(Me.Cmb_CashBank.Text)) = "CASH" Then
                    Filewrite.WriteLine("By Cash")
                Else
                    'Refer Cheque No                
                    If UCase(vtag) = "CREDIT" Then
                        Filewrite.Write("Cheque No : " & Me.Txt_InstNo.Text & "   Dt : " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy") & "  Drawn On : " & Me.Txt_DrawebankName.Text)
                    Else
                        If (Trim(Me.Txt_InstNo.Text) <> "") Then
                            Filewrite.Write("Cheque No : " & Me.Txt_InstNo.Text & "   Dt : " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy"))
                        End If
                    End If
                End If
                vRowcount = vRowcount + 1
            Else
                Filewrite.WriteLine("")
            End If
            Filewrite.WriteLine("")
            'End
        Else
            Filewrite.WriteLine("Narration :" & Mid(Txt_Naration.Text, 1, 68))
            Filewrite.WriteLine("           " & Mid(Txt_Naration.Text, 69, 137))
            'Modified as on 29 Jun'07
            'Begin
            'Filewrite.WriteLine("")
            If (CreditsDebits = "BOTH") Then
                If UCase(Trim(Me.Cmb_CashBank.Text)) = "CASH" Then
                    Filewrite.WriteLine("By Cash")
                Else
                    'Refer Cheque No                
                    If UCase(vtag) = "CREDIT" Then
                        Filewrite.Write("Cheque No : " & Me.Txt_InstNo.Text & "   Dt : " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy") & "  Drawn On : " & Me.Txt_DrawebankName.Text)
                    Else
                        If (Trim(Me.Txt_InstNo.Text) <> "") Then
                            Filewrite.Write("Cheque No : " & Me.Txt_InstNo.Text & "   Dt : " & Format(Me.Dtp_InstDate.Value, "dd-MMM-yyyy"))
                        End If
                    End If
                End If
                vRowcount = vRowcount + 1
            Else
                Filewrite.WriteLine("")
            End If
            Filewrite.WriteLine("")
            'End
        End If

        Filewrite.WriteLine("Prepared By                                                        Accounts Manager")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        VCONN.printFOOTER()
        vRowcount = vRowcount + 9
        If vRowcount < 49 Then
            For I = 1 To 49 - vRowcount
                Filewrite.WriteLine("")
            Next
        End If
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
        End If

        '''If Mid(Trim(vVoucherType), 1, 2) = "CR" Then
        '''    Print #1, "Prepared By " & Space(48) & "Cheif Cashier"
        '''Else
        '''    Print #1, "Prepared By " & Space(15) & "Financial controller" & Space(7) & "Deputy Managing Member"
        '''End If
        '''Print #1,
        '''Print #1, "(" & Trim(gUserName) & ")"
        '''vRowcount = vRowcount + 3
        '''If Val(vRowcount) < 40 Then
        '''    GoSub PrSpace
        '''End If
        'Print #1, Chr(12)

    End Sub
    Private Sub print_fillsdrs()
        Randomize()
        Dim vRowcount, I As Integer
        Dim VpageNumber, ROWCOUNT As Integer
        Dim vBRRS As New ADODB.Recordset
        Dim vOutputfile As String
        Dim vCaption As String
        Dim vSlName As String
        Dim vGLName As String
        Dim vNarrtion1 As String
        Dim vDrAmt As Double
        Dim vSpace As Integer
        Dim vAmtDesc As String
        Dim vou As String
        Dim vAddRs As New ADODB.Recordset
        Dim RVoucherno, RVoucherDate, RVoucherType, RAmount, RvoucherCategory
        Dim vRow As Integer
        Dim vFlag
        Dim vtag, VSQL, SSQL As String
        Dim VGLCODE, VGLDESC, VCRDR
        Dim VGL() As String
        vOutputfile = Mid("Cash" + CStr(Int(Rnd() * 5000)), 1, 7)
        vRowcount = 0

        'vBRRS = New ADODB.Recordset
        VSQL = "Select void,voucherno,Voucherdate,Vouchertype,Accountcode,slcode,creditdebit,amount As Amount ,description,InstrumentDate,Instrumentno,Receivedfrom"
        VSQL = VSQL & " from JournalEntry where Vouchertype='" & Trim(Txt_VoucherPrefix.Text) & "' and voucherno='" & Trim(Txt_VoucherNo.Text) & "' and CreditDebit='Credit' "
        VCONN.getDataSet(VSQL, "CASHVOUCHERPRINT")
        If gdataset.Tables("CASHVOUCHERPRINT").Rows.Count > 0 Then
            VpageNumber = 1
            vOutfile = Mid("CP" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            PageNo = 1 : ROWCOUNT = 0
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 1
            vtag = SSGrid_ReceiptsPayments.Text
            If Mid(Trim(Cmb_CashBank.Text), 1, 4) = "CASH" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID CASH RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID CASH PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = " CASH RECEIPT VOUCHER"
                    Else
                        vCaption = " CASH PAYMENT VOUCHER"
                    End If
                End If
            ElseIf Mid(Trim(Cmb_CashBank.Text), 1, 4) = "BANK" Then
                If gdataset.Tables("CASHVOUCHERPRINT").Rows(0).Item("void") = "Y" Then
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = "VOID BANK RECEIPT VOUCHER"
                    Else
                        vCaption = "VOID BANK PAYMENT VOUCHER"
                    End If
                Else
                    If UCase(Mid(vtag, 1, 2)) = "CR" Then
                        vCaption = " BANK RECEIPT VOUCHER"
                    Else
                        vCaption = " BANK PAYMENT VOUCHER"
                    End If
                End If
            End If
            Dim vslcode, vsldesc, vadd1, vadd2, vadd3 As String
            Filewrite.WriteLine(gMAINCompanyname)
            Filewrite.WriteLine("")
            Filewrite.WriteLine(vCaption)
            Filewrite.WriteLine("Received From :")
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 3
            If SSGrid_ReceiptsPayments.Text <> "" Then
                VGL = Split(SSGrid_ReceiptsPayments.Text, "-->>")
                vslcode = VGL(0)
                vsldesc = VGL(1)
            End If
            Filewrite.WriteLine(vsldesc)
            SSGrid_ReceiptsPayments.Row = 1
            SSGrid_ReceiptsPayments.Col = 2
            VGL = Split(SSGrid_ReceiptsPayments.Text, "-->>")
            VGLCODE = VGL(0)
            VGLDESC = VGL(1)

            SSQL = "select * from accountssubledgermaster where slcode='" & vslcode & "' and accode='" & VGLCODE & "' "
            VCONN.getDataSet(SSQL, "accountssubledgermaster")
            If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
                vadd1 = gdataset.Tables("accountssubledgermaster").Rows(0).Item("address1")
                vadd2 = gdataset.Tables("accountssubledgermaster").Rows(0).Item("address2")
                vadd3 = gdataset.Tables("accountssubledgermaster").Rows(0).Item("address3")
            End If
            Filewrite.WriteLine(vadd1)
            Filewrite.WriteLine(vadd2)
            Filewrite.WriteLine(vadd3)
            Filewrite.Write(Space(30) & "Doc.  No  :")
            Filewrite.WriteLine(Trim(Txt_VoucherNo.Text))
            Filewrite.Write(Space(30) & "Doc.  Date  :")
            Filewrite.WriteLine(Format(Dtp_VoucherDate.Value), "dd-MMM-yyyy")
            Filewrite.WriteLine("")
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.WriteLine("Account :" & VGLCODE & Space(5) & VGLDESC)
            Filewrite.Write("Amount   :")
            Filewrite.WriteLine(Format(Val(Txt_Total.Text), "0.00"))
            Filewrite.WriteLine(RupeesToWord(Val(Txt_Total.Text)))
            Filewrite.WriteLine(StrDup(80, "-"))
            'Refer Cheque No
            Filewrite.Write("Cheque No :  " & Trim(Txt_InstNo.Text) & Space(20))
            Filewrite.WriteLine("Cheque Date :" & Format(Dtp_InstDate.Value), "dd-MMM-yyyy")
            Filewrite.Write("Bank Name:" & Mid(Trim(Txt_DrawebankName.Text), 1, 30) & Space(19))
            Filewrite.WriteLine("Branch Name:" & Trim(Txt_BankPlace.Text))
            Filewrite.WriteLine("Particulars :" & Mid(Trim(Txt_Naration.Text), 1, 40))
            Filewrite.WriteLine(Space(11) & Mid(Trim(Txt_Naration.Text), 41, 80))
            Filewrite.WriteLine("")
            Filewrite.WriteLine(StrDup(80, "-"))

            Filewrite.WriteLine("Prepared By       Financial Controller       Chief Exucutive & Managing Member")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            vRowcount = 22
            If vRowcount < 49 Then
                For I = 1 To 49 - vRowcount
                    Filewrite.WriteLine("")
                Next
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        End If
    End Sub
    Private Sub Cmd_VoucherNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_VoucherNoHelp.Click
        Dim vform As New ListOperation
        If Me.Txt_VoucherNo.Text <> "" Then
            Search = Trim(Me.Txt_VoucherNo.Text)
        End If
        gSQLString = "Select DISTINCT VOUCHERNO,VOUCHERDATE, AMOUNT From JournalEntry "
        M_WhereCondition = "Where VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "'"
        vform.Field = "VOUCHERNO,AMOUNT"
        vform.vFormatstring = "  DOC NO                          |            DOC DATE        |  DOC AMOUNT                            "
        vform.vCaption = "RECEIPTS AND PAYMENTS  HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_VoucherNo.Text = Trim(vform.keyfield & "")
            Txt_VoucherNo_Validated(sender, e)
        Else
            Me.Txt_VoucherNo.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub Txt_DrawebankName_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sqlstring As String
        sqlstring = "select BANKNAME from accountsbankmaster where bankname = '" & Trim(Txt_DrawebankName.Text) & "'"
        VCONN.getDataSet(sqlstring, "accountsbankmaster")
        If gdataset.Tables("accountsbankmaster").Rows.Count > 0 Then
            Txt_DrawebankName.Text = Trim(UCase(gdataset.Tables("accountsbankmaster").Rows(0).Item("bankname")))
        End If
    End Sub

    Private Sub Txt_DrawebankName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    End Sub

    Private Sub GlGridHelp()
        Dim ACHEAD, SUBLEDGER, COSTCENTER, SQLSTRING, GR As String
        With SSGrid_ReceiptsPayments
            Search = Nothing
            .GetText(2, .ActiveRow, Search)
            Dim vform As New ListOperation
            gSQLString = "SELECT ACCODE AS GLCODE,ACDESC AS GLDESCRIPTION  FROM ACCOUNTSGLACCOUNTMASTER"
            M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y' and Actype Not In('CASH','BANK')"
            vform.Field = "ACDESC,ACCODE"
            ' vform.keyfield = "ACDESC"
            vform.vFormatstring = "  GL CODE             |                GL DESCRIPTION           "
            vform.vCaption = "GENERAL LEDGER HEAD HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & "") & "-->>" & Trim(vform.keyfield1 & ""))
                ACHEAD = Trim(vform.keyfield & "")
                ''''''''' CHECKING WEATHER ACHEAD IS HAVING SUBLEDGER OR NOT -----------------------------
                SQLSTRING = "SELECT SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEAD) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                VCONN.getDataSet(SQLSTRING, "MASTER1")
                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                    .SetText(3, .ActiveRow, "")
                    .SetText(4, .ActiveRow, "")
                    .SetText(5, .ActiveRow, "0.00")
                    .SetActiveCell(3, .ActiveRow)
                    .Row = .ActiveRow
                    .Col = 3
                    .Lock = False
                    gdataset.Tables("MASTER1").Dispose()
                Else
                    .SetActiveCell(3, .ActiveRow)
                    .SetText(3, .ActiveRow, "")
                    .SetText(4, .ActiveRow, "")
                    .SetText(5, .ActiveRow, "0.00")
                    .Row = .ActiveRow
                    .Col = 3
                    .Lock = True
                    gdataset.Tables("MASTER1").Dispose()

                    'Added on 29 Oct 07 for Cost Center
                    'Begin
                    'Mk Kannan

                    Call VCONN.getAccountsCostCenter(ACHEAD)
                    If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                        'GR = COSTCENTERVALIDATE(GR, ACHEAD)
                        '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                        'If GR <> Nothing Then
                        '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ") AND  ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                        'End
                        VCONN.getDataSet(SQLSTRING, "MASTER1")
                        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                            .SetActiveCell(4, .ActiveRow)
                            'Added on 30 Oct 07 for Cost Center
                            'Mk Kannan
                            'Begin
                            '.SetText(4, .ActiveRow, "")
                            '.SetText(5, .ActiveRow, "0.00")
                            'End                                                        
                            .Row = .ActiveRow
                            .Col = 4
                            .Lock = False
                            gdataset.Tables("MASTER1").Dispose()
                        Else
                            .SetActiveCell(5, .ActiveRow)
                            .SetText(4, .ActiveRow, "")
                            .SetText(5, .ActiveRow, "0.00")
                            .Row = .ActiveRow
                            .Col = 4
                            .Lock = True
                            gdataset.Tables("MASTER1").Dispose()
                        End If
                    Else
                        .SetActiveCell(5, .ActiveRow)
                        .SetText(5, .ActiveRow, "0.00")
                        .Row = .ActiveRow
                        .Col = 4
                        .Lock = True
                    End If
                End If
            Else
                .SetActiveCell(.ActiveCol, .ActiveRow)
                .SetText(.ActiveCol, .ActiveRow, "")
            End If
            vform.Close()
            vform = Nothing
        End With
    End Sub
    Private Sub SubLedHelp()
        Dim ACHEADARRAY() As String
        Dim ACHEAD As String
        Dim GR As String
        Dim SQLSTRING As String
        With SSGrid_ReceiptsPayments
            .Col = 3
            .Row = .ActiveRow
            'If .Lock = True Then
            ' Exit Sub
            ' Else
            Search = Nothing
            .GetText(3, .ActiveRow, Search)
            .GetText(2, .ActiveRow, ACHEAD)
            ACHEADARRAY = ACHEAD.Split("-->>")
            'MsgBox(ACHEADARRAY(0))
            'SQLSTRING = "SELECT SLCODE,SLDESC FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND SLCODE = '" & SUBLEDGER & "'"
            Dim vform As New ListOperation
            gSQLString = "SELECT SLCODE,SLDESC FROM accountssubledgermaster"
            M_WhereCondition = " WHERE ACCODE = '" & Trim(ACHEADARRAY(0)) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
            vform.Field = "SLDESC,SLCODE"
            'vform.Field = "SLDESC"
            vform.vFormatstring = "           MEMBER CODE          |                MEMBER NAME                                                               "
            vform.vCaption = "MEMBER CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                'changes 30122010
                .SetText(.ActiveCol, .ActiveRow, Trim(vform.keyfield & ""))  '& "-->>" & Trim(vform.keyfield1 & ""))
                'changes 30122010
                .Row = .ActiveRow
                .Col = 4
                .Text = Trim(vform.keyfield1)
                Call VCONN.getAccountsCostCenter(ACHEADARRAY(0))
                If Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "E" Or Trim(gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows(0).Item("CATEGORY")) = "I" Then
                    'GR = COSTCENTERVALIDATE(GR, ACHEADARRAY(0))
                    '''''''' CHECKING WEATHER ACHEAD IS HAVING COSTCENTER CODE OR NOT
                    'If GR <> Nothing Then
                    '    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE PRIMARYGROUPCODE IN (" & GR & ")  AND ISNULL(FREEZEFLAG,'N') <> 'Y'"
                    SQLSTRING = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER WHERE ISNULL(FREEZEFLAG,'N') <> 'Y'"
                    'End

                    VCONN.getDataSet(SQLSTRING, "MASTER1")
                    If gdataset.Tables("MASTER1").Rows.Count > 0 Then
                        .Row = .ActiveRow
                        .Col = 4
                        .Lock = False
                        .SetActiveCell(4, .ActiveRow)

                        gdataset.Tables("MASTER1").Dispose()
                    Else
                        .Row = .ActiveRow
                        .Col = 4
                        .Lock = True
                        .SetActiveCell(5, .ActiveRow)
                        .SetText(4, .ActiveRow, "")
                        .SetText(5, .ActiveRow, "0.00")
                        gdataset.Tables("MASTER1").Dispose()
                    End If
                Else
                    .Row = .ActiveRow
                    .Col = 4
                    .Lock = True
                    .SetActiveCell(5, .ActiveRow)
                    .SetText(5, .ActiveRow, "0.00")
                    .Col = 5
                    .Row = .ActiveRow
                    .Lock = False
                End If
            End If
            vform.Close()
            vform = Nothing
            '   End If
        End With
    End Sub
    Private Sub Txt_Naration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Naration.KeyDown
        ''Dim SSQL As String
        ''SSQL = "SELECT DESCRIPTIONNAME FROM ACCOUNTSDESCRIPTIONMASTER WHERE SHORTCUTKEY = '" & e.KeyCode.ToString & "'  AND ISNULL(FREEZE,'') <> 'Y'"
        ''VCONN.getDataSet(SSQL, "DESCRIPTION")
        ''If gdataset.Tables("DESCRIPTION").Rows.Count <> 0 Then
        ''    Txt_Naration.Text = gdataset.Tables("DESCRIPTION").Rows(0).Item("DESCRIPTIONNAME")
        ''End If
    End Sub
    Private Sub Viewoperation()
        If Me.Txt_VoucherNo.Text = "" Then
            MsgBox("Please give voucher no", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.SSGrid_ReceiptsPayments.DataRowCnt = 0 Then
            MsgBox("No details to print", MsgBoxStyle.Information)
            Exit Sub
        End If
        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim SSQL, voucherno As String
        Dim TOTAL As Double = 0
        Dim ADJUSTEDAGAINST, SLCODE As String
        Dim VSQL As String
        vOutfile = Mid("CON" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0

        Dim ADJUSTEDAMT As Double = 0
        Dim TOTALDEBIT As Double = 0
        Dim TOTALCREDIT As Double = 0
        Dim NARRATION As String

        Dim VACCODE(), ACCODE As String
        Dim VSLCODE() As String
        ACCODE = "" : SLCODE = ""

        With SSGrid_ReceiptsPayments
            For I = 1 To .DataRowCnt
                .Row = I
                .Col = 2
                VACCODE = Split(.Text, "-->>")
                If UBound(VACCODE) > 0 Then
                    If Trim(ACCODE) <> "" Then
                        ACCODE = ACCODE & ",'" & VACCODE(0) & "'"
                        'ACCODE = ACCODE & "," & VACCODE(0)
                    Else
                        ACCODE = "'" & VACCODE(0) & "'"
                        'ACCODE = VACCODE(0)
                    End If
                End If
                .Col = 3
                VSLCODE = Split(.Text, "-->>")
                If UBound(VSLCODE) > 0 Then
                    If Trim(SLCODE) <> "" Then
                        SLCODE = SLCODE & ",'" & VSLCODE(0) & "'"
                        'SLCODE = SLCODE & "," & VSLCODE(0)
                    Else
                        SLCODE = " '" & VSLCODE(0) & "'"
                        'SLCODE = VSLCODE(0)
                    End If
                End If
            Next
        End With

        SSQL = "Select j.VOUCHERNO,j.voucherdate,j.VOUCHERTYPE,j.VOUCHERCATEGORY,CASHBANK,j.ACCOUNTCODE,ACCOUNTCODEDESC,ISNULL(j.SLCODE,'') SLCODE,j.SLDESC,RTRIM(DESCRIPTION)DESCRIPTION,ISNULL(INSTRUMENTNO,'') INSTRUMENTNO,INSTRUMENTDATE,INSTRUMENTTYPE,j.AMOUNT,j.CREDITDEBIT,COSTCENTERDESC,BANKNAME,m.vOUCHERNO as adjustedvoucher,aDJUSTEDAMOUNT, "
        SSQL = SSQL & "  sum(Case creditdebit When 'CREDIT' Then j.amount End) As credit,sum(Case creditdebit When 'debit' Then j.amount End) As debit "
        SSQL = SSQL & " from journalentry J Full join Matching M On J.Voucherno=m.Avoucherno and J.Accountcode=M.Accountcode and J.Slcode=M.Slcode "
        SSQL = SSQL & " where isnull(void,'')<>'Y'   AND ISNULL(CASHBANK,'') <> ''  "
        SSQL = SSQL & " AND J.VOUCHERNO = '" & Trim(Txt_VoucherNo.Text) & "'  "
        SSQL = SSQL & " AND J.ACCOUNTCODE IN (" & ACCODE & ") "
        SSQL = SSQL & " AND J.SLCODE IN (" & SLCODE & ")"
        SSQL = SSQL & " group by j.VOUCHERNO,j.voucherdate,j.VOUCHERTYPE,j.VOUCHERCATEGORY,j.CASHBANK,j.ACCOUNTCODE,j.ACCOUNTCODEDESC,j.SLCODE,j.SLDESC,j.DESCRIPTION,INSTRUMENTNO,INSTRUMENTDATE,INSTRUMENTTYPE,j.AMOUNT,j.CREDITDEBIT,j.COSTCENTERDESC,j.BANKNAME,m.vOUCHERNO,aDJUSTEDAMOUNT "
        SSQL = SSQL & " ORDER BY j.VOUCHERNO,J.Accountcode,J.Slcode"
        Dim vcaption1 As String
        vcaption1 = ""

        VCONN.getDataSet(SSQL, "CASHVOUCHERPRINT")
        If gdataset.Tables("CASHVOUCHERPRINT").Rows.Count > 0 Then
            I = 0
            Call VCONN.printheader(135, vcaption1)
            Filewrite.WriteLine(Chr(15) & Chr(14) & Space(30) & "RECEIPT PAYMENT VOUCHER")
            Filewrite.WriteLine()
            If Txt_DrawebankName.Text <> "" Then
                Filewrite.WriteLine(Txt_DrawebankName.Text & "(" & Txt_BankPlace.Text & ")")
                ROWCOUNT = ROWCOUNT + 1
            End If
            Filewrite.WriteLine(Chr(15) & StrDup(135, "-"))
            voucherno = gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("voucherno")
            SSQL = "VOUCHER  NO    : " & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("VOUCHERNO"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("VOUCHERNO"), 1, 20))) & Space(30) & "VOUCHER DATE : " & Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("VOUCHERDATE"), "dd/MMM/yyyy"), 1, 20) & Space(15) & " DATE : " & Format(Now, "dd/MMM/yyyy")
            Filewrite.WriteLine(SSQL)
            Filewrite.WriteLine(StrDup(135, "-"))

            Filewrite.WriteLine("|         Account Head         |    Cheque No   |      Adjusted      |  Adjusted  |Cost Center |   Amount   |    Debit   |   Credit   |")
            ' Filewrite.WriteLine("{0,-30}{1,-16}{2,-20}{3,-12}{4,-12}{5,-12},{6,-12}{7,-12}{8,-12}{9,1}", "|ACCOUNT HEAD", "|Cheque No", "|Adjusted", "|Adjusted", "|Cost Center", "|Amount", "|Debit", "|Credit", "|")

            Filewrite.WriteLine("|                              |       Date     |       Against      |   Amount   |            |            |            |            |")
            Filewrite.WriteLine(StrDup(135, "-"))
            If Txt_DrawebankName.Text <> "" Then
                ROWCOUNT = 12
            Else
                ROWCOUNT = 11
            End If

            For I = 0 To gdataset.Tables("CASHVOUCHERPRINT").Rows.Count - 1
                With gdataset.Tables("CASHVOUCHERPRINT").Rows(I)

                    SSQL = "|" & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ACCOUNTCODEDESC"), 1, 30)
                    SSQL = SSQL & Space(30 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ACCOUNTCODEDESC"), 1, 30))) & "|"
                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("Instrumentno") = False Then
                        SSQL = SSQL & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("Instrumentno"), 1, 16)
                        SSQL = SSQL & Space(16 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("Instrumentno"), 1, 16))) & "|"
                    Else
                        SSQL = SSQL & Space(16) & "|"
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("adjustedvoucher") = False Then
                        SSQL = SSQL & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("adjustedvoucher"), 1, 16)
                        SSQL = SSQL & Space(20 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("adjustedvoucher"), 1, 20))) & "|"
                    Else
                        SSQL = SSQL & Space(20) & "|"
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("ADJUSTEDAMOUNT") = False Then
                        SSQL = SSQL & Space(12 - Len(Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ADJUSTEDAMOUNT"), "0.00"), 1, 12))) & Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ADJUSTEDAMOUNT"), "0.00"), 1, 12) & "|"
                    Else
                        SSQL = SSQL & Space(12) & "|"
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("COSTCENTERDESC") = False Then
                        SSQL = SSQL & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("COSTCENTERDESC"), 1, 12)
                        SSQL = SSQL & Space(12 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("COSTCENTERDESC"), 1, 12))) & "|"
                    Else
                        SSQL = SSQL & Space(12) & "|"
                    End If

                    SSQL = SSQL & Space(12) & "|"

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("DEBIT") = False Then
                        SSQL = SSQL & Space(12 - Len(Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("AMOUNT"), "0.00"), 1, 12))) & Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("AMOUNT"), "0.00"), 1, 12) & "|"
                        SSQL = SSQL & Space(12) & "|"
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("CREDIT") = False Then
                        SSQL = SSQL & Space(12) & "|"
                        SSQL = SSQL & Space(12 - Len(Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("AMOUNT"), "0.00"), 1, 12))) & Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("AMOUNT"), "0.00"), 1, 12) & "|"
                    End If
                    Filewrite.WriteLine(SSQL)         ' 1 ST LINE 

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("SLDESC") = False Then
                        SSQL = "|" & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("SLDESC"), 1, 30)
                        SSQL = SSQL & Space(30 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("SLDESC"), 1, 30))) & "|"
                    Else
                        SSQL = "|" & Space(30) & "|"
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("DESCRIPTION") = False Then
                        NARRATION = gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("DESCRIPTION")
                    Else
                        NARRATION = ""
                    End If

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("INSTRUMENTDATE") = False And gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("Instrumentno") <> "" Then
                        SSQL = SSQL & Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("INSTRUMENTDATE"), "dd/MMM/yyyy"), 1, 16) & Space(16 - Len(Mid(Format(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("INSTRUMENTDATE"), "dd/MMM/yyyy"), 1, 16))) & "|"
                    Else
                        SSQL = SSQL & Space(16) & "|"
                    End If
                    Filewrite.WriteLine(SSQL)           ' 2 ND LINE 

                    If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("CREDITDEBIT") = False Then
                        If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("CREDITDEBIT") = "DEBIT" Then
                            TOTALDEBIT = TOTALDEBIT + Val(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("DEBIT"))
                            If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("ADJUSTEDAMOUNT") = False Then
                                ADJUSTEDAMT = ADJUSTEDAMT + Val(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ADJUSTEDAMOUNT"))
                            End If
                        Else
                            TOTALCREDIT = TOTALCREDIT + Val(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("CREDIT"))
                            If gdataset.Tables("CASHVOUCHERPRINT").Rows(I).IsNull("ADJUSTEDAMOUNT") = False Then
                                ADJUSTEDAMT = ADJUSTEDAMT + Val(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("ADJUSTEDAMOUNT"))
                            End If
                        End If
                    End If
                    voucherno = gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("voucherno")
                    ROWCOUNT = ROWCOUNT + 3
                    TOTAL = Val(TOTAL) + gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("AMOUNT")
                    If ROWCOUNT > 58 Then
                        ROWCOUNT = 0
                        PAGENO = PAGENO + 1
                        Filewrite.WriteLine(Chr(12))
                        Call VCONN.printheader(135, vcaption1)
                        Filewrite.WriteLine(Chr(15) & Chr(14) & Space(30) & "RECEIPT PAYMENT PRINT")
                        SSQL = "VOUCHER  NO    : " & Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("VOUCHERNO"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("CASHVOUCHERPRINT").Rows(I).Item("VOUCHERNO"), 1, 20))) & Space(30) & "DATE : " & Format(Now, "dd/MMM/yyyy")
                        Filewrite.WriteLine(Chr(15) & SSQL)
                        Filewrite.WriteLine(StrDup(135, "-"))
                        Filewrite.WriteLine("|         Account Head         |    Cheque No   |      Adjusted      |  Adjusted  |Cost Center |   Amount   |    Debit   |   Credit   |")
                        Filewrite.WriteLine("|                              |       Date     |       Against      |   Amount   |            |            |            |            |")
                        Filewrite.WriteLine(StrDup(135, "-"))
                        ROWCOUNT = 9
                    End If
                End With
            Next

            Filewrite.WriteLine(Space(20) & "NARRATION : " & Mid(NARRATION, 1, 50) & Space(50 - Len(Mid(NARRATION, 1, 50))))
            If Len(NARRATION) > 51 Then
                Filewrite.WriteLine(Space(20) & Mid(NARRATION, 51, 50) & Space(60 - Len(Mid(NARRATION, 51, 50))))
                If Len(NARRATION) > 100 And Len(NARRATION) < 150 Then
                    Filewrite.WriteLine(Space(20) & Mid(NARRATION, 101, 50) & Space(60 - Len(Mid(NARRATION, 101, 50))))
                End If
                If Len(NARRATION) > 151 And Len(NARRATION) < 200 Then
                    Filewrite.WriteLine(Space(20) & Mid(NARRATION, 151, 50) & Space(60 - Len(Mid(NARRATION, 151, 50))))
                End If
            End If
        Else
            MsgBox("NO RECORD TO VIEW ", MsgBoxStyle.Information)
            Exit Sub
        End If
        Filewrite.WriteLine(StrDup(135, "-"))

        If Val(TOTALCREDIT) > 0 Then
            Filewrite.WriteLine(Mid(RupeesToWord(TOTALCREDIT), 1, 84) & Space(84 - Len(Mid(RupeesToWord(TOTALCREDIT), 1, 84))) & Space(24) & "TOTAL AMOUNT :" & Space(12 - Len(Mid(Format(TOTALCREDIT, "0.00"), 1, 12))) & Mid(Format(TOTALCREDIT, "0.00"), 1, 12))
        Else
            Filewrite.WriteLine(Mid(RupeesToWord(TOTALDEBIT), 1, 84) & Space(84 - Len(Mid(RupeesToWord(TOTALDEBIT), 1, 84))) & Space(11) & "TOTAL AMOUNT :" & Space(12 - Len(Mid(Format(TOTALDEBIT, "0.00"), 1, 12))) & Mid(Format(TOTALDEBIT, "0.00"), 1, 12))
        End If

        Filewrite.WriteLine(StrDup(135, "-"))
        Filewrite.WriteLine(" SECRETARY " & Space(60) & " ACCOUNTANT")
        Filewrite.Write(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gPrint = True
        'If strCompany_ID.ToUpper = "ASCA" Then
        '    If Mid(Txt_VoucherPrefix.Text, 1, 2) = "BR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CR" Or Mid(Txt_VoucherPrefix.Text, 1, 2) = "CC" Then
        '        Call MemberReceiptASCA()
        '    Else
        '        If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
        '            Call MemberReceipt()
        '        Else
        '            Call PreprintVoucher1()
        '        End If
        '    End If
        '    'End
        'Else
        '    If SSGrid_ReceiptsPayments.DataRowCnt = 1 Then
        '        Call MemberReceipt()
        '    Else
        '        Call PreprintVoucher1()
        '    End If
        'End If
        ' Call print_windows()
        'End
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        ' Dim M1 As New MDI
        Dim chstr As String

        VCONN.getDataSet("select * from useradmin where username = '" & Trim(gUsername) & "' and MainGroup='CMS' AND ModuleName LIKE '" & Mid(Trim(GmoduleName), 1, 5) & "%'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    chstr = abcdMINUS(.Item("rights"))
                End With
            Next
        End If
        If UCase(Trim(gUserCategory)) <> "S" Then
            Me.CmdAdd.Enabled = False
            Me.CmdDelete.Enabled = False
            CmdView.Enabled = False
            cmdPrint.Enabled = False
        End If
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.CmdDelete.Enabled = True
                    CmdView.Enabled = True
                    cmdPrint.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If

                If Right(x) = "D" Then
                    Me.CmdDelete.Enabled = True
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

    Private Sub SSGrid_ReceiptsPayments_MouseDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_MouseDownEvent) Handles SSGrid_ReceiptsPayments.MouseDownEvent
        With SSGrid_ReceiptsPayments
            .SetActiveCell(.ActiveCol, .ActiveRow)
        End With
    End Sub

    Private Sub Cmd_BankHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_BankHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select BANKNAME,BANKCODE From ACCOUNTSBANKMASTER"
        M_WhereCondition = ""
        vform.Field = "BANKCODE,BANKNAME"
        vform.vFormatstring = "    BANK    NAME                                                           |       BANK CODE                          "
        vform.vCaption = "BANK NAME HELP"
        vform.KeyPos = 0
        vform.keyfield = 0
        vform.keyfield1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_DrawebankName.Text = Trim(vform.keyfield & "")
            Txt_bankCode.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Txt_DrawebankName_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_DrawebankName.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_BankHelp_Click_1(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub Txt_DrawebankName_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DrawebankName.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If (Trim(Txt_DrawebankName.Text)) <> "" Then
                Txt_DrawebankName_Validated(sender, e)
            Else
                Call Cmd_BankHelp_Click_1(sender, e)
            End If
            Txt_Naration.Focus()
        End If
    End Sub

    Private Sub SSGrid_ReceiptsPayments_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SSGrid_ReceiptsPayments.LostFocus
        Try
            If strCompany_ID.ToUpper <> "CSC" Then
                With SSGrid_ReceiptsPayments
                    .Row = 1
                    If Txt_PaidTo.Text = "" Then
                        .Col = 4
                        Txt_PaidTo.Text = Trim(.Text)
                    End If
                End With
            End If
        Catch ex As Exception
            Txt_PaidTo.Text = ""
        End Try
    End Sub
    'Private Sub print_windows()
    '    Dim str As String
    '    Dim Viewer As New ReportViwer
    '    Dim r As New rpt_receipts_payments

    '    Dim amount1 As String
    '    amount1 = RupeesToWordASCA(gdataset.Tables("journalentry").Rows(0).Item("amount"))

    '    str = "SELECT isnull(voucherno,'') as voucherno,isnull(voucherdate,'') as voucherdate,isnull(accountcode,'') as accountcode,isnull(accountcodedesc,'') as accountcodedesc,isnull(slcode,'') as slcode,isnull(sldesc,'') as sldesc,case isnull(creditdebit,'') "
    '    str = str & "when 'CREDIT' then 'Cr' else 'Dr' end as creditdebit,'" & amount1 & "' as partyname, isnull(amount,0) as amount,isnull(instrumentno,'') as instrumentno,isnull(instrumentdate,'') as instrumentdate,ISNULL(DESCRIPTION,'') AS DESCRIPTION FROM journalentry where ISNULL(VOID,'')<>'Y' AND voucherno='" & Trim(Txt_VoucherNo.Text) & "'AND ROWID NOT IN (SELECT MIN(ROWID) FROM JOURNALENTRY WHERE ISNULL(VOID,'')<>'Y' AND voucherno='" & Trim(Txt_VoucherNo.Text) & "')"

    '    Viewer.ssql = str
    '    Viewer.Report = r
    '    Viewer.TableName = "journalentry"

    '    Dim TXTOBJ As TextObject
    '    TXTOBJ = r.ReportDefinition.ReportObjects("TEXT9")
    '    TXTOBJ.Text = Cmb_VoucherType.Text

    '    Dim TXTOBJ1 As TextObject
    '    TXTOBJ1 = r.ReportDefinition.ReportObjects("TEXT10")
    '    TXTOBJ1.Text = "BANK NAME : " & Cmb_GlCode.Text

    '    Dim TXTOBJ2 As TextObject
    '    TXTOBJ = r.ReportDefinition.ReportObjects("TEXT15")
    '    TXTOBJ.Text = gCompanyname

    '    Dim TXTOBJ3 As TextObject
    '    TXTOBJ1 = r.ReportDefinition.ReportObjects("TEXT14")
    '    TXTOBJ1.Text = gUsername


    '    Dim TXTOBJ8 As TextObject
    '    TXTOBJ8 = r.ReportDefinition.ReportObjects("TEXT23")
    '    TXTOBJ8.Text = Format(Val(Txt_Total.Text), "0.00")

    '    If Trim(Cmb_CashBank.Text) = "CASH" Then
    '        Dim TXTOBJ11 As TextObject
    '        TXTOBJ11 = r.ReportDefinition.ReportObjects("TEXT11")
    '        TXTOBJ11.Text = "BY CASH"
    '    Else
    '        Dim TXTOBJ11 As TextObject
    '        TXTOBJ11 = r.ReportDefinition.ReportObjects("TEXT11")
    '        TXTOBJ11.Text = "BY CHEQUE"
    '    End If
    '    Viewer.Show()
    'End Sub

    Private Sub Cmb_VoucherType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_VoucherType.LostFocus
        Call Cmb_VoucherType_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Cmb_InstType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_InstType.SelectedIndexChanged

    End Sub

End Class