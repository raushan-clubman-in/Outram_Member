Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
Public Class ReportScreen
    Inherits System.Windows.Forms.Form
    Dim dAdapter As New SqlDataAdapter
    Dim da As New SqlDataAdapter
    Dim dSet, ds As New DataSet
    Dim gconnection As New GlobalClass
    Public sqlStringFinal, DispString As String
    Dim sqlString, billtype As String
    Dim count, mmcode As String
    Dim iNumber As Integer
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype As String
    Dim chk_month As String
    Dim subsbill, subsbil, posting, madrs, accounts As New DataTable
    Dim addFltrStr, FltrStr, FltrStrr, addFltrStrr As String
    Public TempString(2) As String
    Dim pageno, lineno As Integer
    Public selectNo As Integer
    Dim Processed_Chk(4) As Integer
    Dim totalamt, totaltax As Double
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Print As System.Windows.Forms.Button
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents ChkList_month As System.Windows.Forms.CheckedListBox
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_year = New System.Windows.Forms.DateTimePicker
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Btn_cancel = New System.Windows.Forms.Button
        Me.btn_Print = New System.Windows.Forms.Button
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.GBox2 = New System.Windows.Forms.GroupBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.ChkList_month = New System.Windows.Forms.CheckedListBox
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(360, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 29)
        Me.Label2.TabIndex = 365
        Me.Label2.Text = "SUBSCRIPTION  BILL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 464)
        Me.GroupBox1.TabIndex = 366
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtp_year)
        Me.Panel2.Controls.Add(Me.chk_PrintAll)
        Me.Panel2.Controls.Add(Me.Cmb_add_filter)
        Me.Panel2.Controls.Add(Me.chk_Filter_Field)
        Me.Panel2.Controls.Add(Me.cmb_Filter_By)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmd_MCodefromHelp)
        Me.Panel2.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Panel2.Controls.Add(Me.tbx_Filter_From)
        Me.Panel2.Controls.Add(Me.tbx_filter_To)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Location = New System.Drawing.Point(64, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 384)
        Me.Panel2.TabIndex = 374
        Me.Panel2.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(128, 8)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox2.TabIndex = 419
        Me.CheckBox2.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 418
        Me.Label3.Text = "DUE DATE"
        '
        'dtp_year
        '
        Me.dtp_year.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_year.CustomFormat = "yyyy"
        Me.dtp_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_year.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_year.Location = New System.Drawing.Point(360, 8)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(104, 24)
        Me.dtp_year.TabIndex = 417
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(56, 96)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(168, 16)
        Me.chk_PrintAll.TabIndex = 381
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(286, 62)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(168, 26)
        Me.Cmb_add_filter.TabIndex = 373
        Me.Cmb_add_filter.Text = "[select your filter]"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.White
        Me.chk_Filter_Field.Location = New System.Drawing.Point(64, 120)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(392, 213)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 375
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(54, 62)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 26)
        Me.cmb_Filter_By.TabIndex = 372
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 20)
        Me.Label9.TabIndex = 368
        Me.Label9.Text = "CATEGORY  FILITER"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 371
        Me.Label10.Text = "ADDRESS  FILTER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(106, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 413
        Me.Label7.Text = "From"
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(217, 350)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 414
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(355, 351)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 415
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(154, 350)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 24)
        Me.tbx_Filter_From.TabIndex = 410
        Me.tbx_Filter_From.Text = ""
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(290, 350)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 24)
        Me.tbx_filter_To.TabIndex = 411
        Me.tbx_filter_To.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(258, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 412
        Me.Label8.Text = "To"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(16, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox1.TabIndex = 416
        Me.CheckBox1.Text = "Summary"
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackgroundImage = CType(resources.GetObject("Btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_cancel.Location = New System.Drawing.Point(344, 16)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_cancel.TabIndex = 368
        Me.Btn_cancel.Text = "Cancel [F6]"
        '
        'btn_Print
        '
        Me.btn_Print.BackgroundImage = CType(resources.GetObject("btn_Print.BackgroundImage"), System.Drawing.Image)
        Me.btn_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.Color.White
        Me.btn_Print.Location = New System.Drawing.Point(224, 16)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(104, 32)
        Me.btn_Print.TabIndex = 367
        Me.btn_Print.Text = "Print [F7]"
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.Transparent
        Me.GBox1.Controls.Add(Me.Btn_cancel)
        Me.GBox1.Controls.Add(Me.btn_Print)
        Me.GBox1.Location = New System.Drawing.Point(168, 554)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(664, 56)
        Me.GBox1.TabIndex = 367
        Me.GBox1.TabStop = False
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.Color.Transparent
        Me.GBox2.Controls.Add(Me.cmdPrint)
        Me.GBox2.Controls.Add(Me.btn_close)
        Me.GBox2.Controls.Add(Me.CmdView)
        Me.GBox2.Location = New System.Drawing.Point(168, 616)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(664, 56)
        Me.GBox2.TabIndex = 369
        Me.GBox2.TabStop = False
        Me.GBox2.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(264, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 9
        Me.cmdPrint.Text = "Print[F12]"
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(432, 16)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 32)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(120, 18)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 8
        Me.CmdView.Text = "Display[F9]"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbl_BillingBasis)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbo_BillingBasis)
        Me.Panel1.Controls.Add(Me.ChkList_month)
        Me.Panel1.Controls.Add(Me.Lst_status1)
        Me.Panel1.Controls.Add(Me.Lst_status)
        Me.Panel1.Location = New System.Drawing.Point(192, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 400)
        Me.Panel1.TabIndex = 377
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(120, 80)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(96, 20)
        Me.lbl_BillingBasis.TabIndex = 591
        Me.lbl_BillingBasis.Text = "Billing Basis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, -35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Type of Posting"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"NONE", "ALL"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(232, 81)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(176, 26)
        Me.cbo_BillingBasis.TabIndex = 364
        '
        'ChkList_month
        '
        Me.ChkList_month.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ChkList_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_month.Location = New System.Drawing.Point(104, 125)
        Me.ChkList_month.Name = "ChkList_month"
        Me.ChkList_month.Size = New System.Drawing.Size(312, 232)
        Me.ChkList_month.TabIndex = 365
        '
        'Lst_status1
        '
        Me.Lst_status1.ItemHeight = 18
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.LIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(488, 224)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(48, 94)
        Me.Lst_status1.TabIndex = 371
        Me.Lst_status1.Visible = False
        '
        'Lst_status
        '
        Me.Lst_status.ItemHeight = 18
        Me.Lst_status.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.Lst_status.Location = New System.Drawing.Point(488, 96)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status.TabIndex = 370
        Me.Lst_status.Visible = False
        '
        'ReportScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ReportScreen"
        Me.Text = "ReportScreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GBox1.ResumeLayout(False)
        Me.GBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public Function Print(ByVal SQLSTRING As String, ByVal Con As String)
        ' by srinivas **************************************************************************
        Dim FilePath, Apath As String
        Dim OFile As System.IO.File
        Dim OWrite As System.IO.StreamWriter
        Dim DispVar(10) As String
        Dim LoopCur As Integer
        Try
            dAdapter = New SqlDataAdapter(SQLSTRING, Con)
            dAdapter.Fill(dSet, "master1")
            Apath = Application.StartupPath
            FilePath = Apath & "\Reports\SummaryRep.txt"
            OWrite = OFile.CreateText(FilePath)
            OWrite.WriteLine("{0,-15}{1,-30}{2,-30}{3,-15}{4,-25}{5,-20}{6,15}{7,-15}", "MEMBER CODE", "MEMBER NAME", _
            "MEMBER CATEGORY", "STATUS", "QUATEREDATE", "VOUCHAR NUMBER", "AMOUNT  ", "DUE DATE")
            OWrite.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------")
            For LoopCur = 0 To dSet.Tables("Master1").Rows.Count - 1
                DispVar(1) = dSet.Tables("master1").Rows(LoopCur).Item("mcode")
                DispVar(2) = dSet.Tables("master1").Rows(LoopCur).Item("mname")
                DispVar(3) = dSet.Tables("master1").Rows(LoopCur).Item("TYPEDESC")
                DispVar(4) = dSet.Tables("master1").Rows(LoopCur).Item("CURENTSTATUS")
                DispVar(5) = dSet.Tables("master1").Rows(LoopCur).Item("QUTERDATE")
                DispVar(6) = dSet.Tables("master1").Rows(LoopCur).Item("VRNO")
                DispVar(7) = dSet.Tables("master1").Rows(LoopCur).Item("TOTAL") & ".00 "
                DispVar(8) = dSet.Tables("master1").Rows(LoopCur).Item("DUEDATE")
                OWrite.WriteLine("{0,-15}{1,-30}{2,-30}{3,-15}{4,-25}{5,-20}{6,15}{7,-15}", DispVar(1), DispVar(2), DispVar(3), DispVar(4), _
                DispVar(5), DispVar(6), DispVar(7), DispVar(8))
            Next
            OWrite.Close()
            Shell(Apath & "\wordpad.exe " & FilePath, AppWinStyle.MaximizedFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print.Click
        If ChkList_month.CheckedItems.Count = 0 Then
            MsgBox("Please Select Any Subscription Type", MsgBoxStyle.Critical)
            ChkList_month.Focus()
            Exit Sub
        End If
        GBox1.Visible = False
        Panel1.Visible = False
        GBox2.Visible = True
        GBox2.Top = 554
        Panel2.Visible = True
        Cmb_add_filter.SelectedIndex = 1
        cmb_Filter_By.SelectedIndex = 1
        Call chkmonth()
        cmb_Filter_By.Focus()
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call fillpostingtype()
    End Sub
    Private Sub fillpostingtype()
        ChkList_month.Items.Clear()
        Dim i As Long
        posting = Nothing
        Try
            Dim BILLINGSTATUS
            If Me.cbo_BillingBasis.Text = "ALL" Then
                BILLINGSTATUS = "QUARTERLY"
            Else
                BILLINGSTATUS = Me.cbo_BillingBasis.Text
            End If
            sqlString = "select isnull(postingsno,0) as postingsno, isnull(POSTINGCODE,'') AS POSTINGTYPE,ISNULL(POSTINGDESC,'') as postingdesc,isnull(postingsno,0) as postingsno "
            sqlString = sqlString & " from postingmast where  isnull(postingcode,'')='" & BILLINGSTATUS & "'"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    ChkList_month.Items.Add(posting.Rows(i).Item("POSTINGSNO") & "." & posting.Rows(i).Item("POSTINGDESC"))
                Next
            Else
                ChkList_month.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
    Private Sub ReportScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Long
        posting = Nothing
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Try
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gconnection.closeConnection()
        cbo_BillingBasis.SelectedIndex = 0
        cbo_BillingBasis.Focus()
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
        Me.btn_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                    Me.btn_Print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdPrint.Enabled = True
                    Me.btn_Print.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub Btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancel.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        Cmb_add_filter.Enabled = True
        Try
            chk_Filter_Field.Items.Clear()
            If cmb_Filter_By.Text = "Member Category" Then
                selectNo = 0
                FltrStrr = "MemberType in ('"
                FltrStr = "MemberTypeCode in ('"
                Fill_Chk_str = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                Next
            ElseIf cmb_Filter_By.Text = "Member Status" Then
                selectNo = 1
                FltrStrr = "a.CurentStatus in('"
                FltrStr = "a.CurentStatus in('"
                chk_Filter_Field.Items.Clear()
                chk_Filter_Field.Items.AddRange(Lst_status.Items())
            End If
        Catch ex As Exception
            MsgBox("An invalided input…Please close the report filter and reopen it.")
            Exit Sub
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
    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(subcd,'') as subcd,isnull(mcode,'') as mcode,isnull(mname,'')as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(subcd,'') as subcd,isnull(mcode,'') as mcode,isnull(mname,'')as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(contpin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'')as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(subcd,'') as subcd,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(subcd,'') as subcd,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        End If
    End Sub
    'LIN
    Public Function disp_Print()
        If chk_Filter_Field.CheckedItems.Count <> 0 And Trim(tbx_Filter_From.Text) <> "" And Trim(tbx_filter_To.Text) <> "" Then
            MsgBox("Kindly Select Member Category Or Give Member Code")
            Exit Function
        End If
        If chk_Filter_Field.CheckedItems.Count = 0 Then
            If Trim(tbx_Filter_From.Text) = "" And Trim(tbx_filter_To.Text) <> "" Then
                MsgBox("Enter From Member Code")
                tbx_Filter_From.Focus()
                Exit Function
            ElseIf Trim(tbx_Filter_From.Text) <> "" And Trim(tbx_filter_To.Text) = "" Then
                MsgBox("Enter To Member Code")
                tbx_Filter_From.Focus()
                Exit Function
            End If
            If Trim(tbx_Filter_From.Text) = "" And Trim(tbx_filter_To.Text) = "" Then
                MsgBox("Select any 'Member Category' Or Enter 'From' and 'To' Member Code")
                chk_Filter_Field.Focus()
                Exit Function
            End If
        End If
        Try
            Dim sqlstring, sqlstring1 As String
            Dim CHK As Boolean
            Dim NEWMCODE, adddet(5), PRESENTMCODE As String
            Dim Hedd1 As String
            Dim addFilterStr2 As String
            chkfilterfield()
            addFltrStrr = addFltrStrr & ")"
            addFltrStr = addFltrStr & ")"
            If Trim(tbx_Filter_From.Text) <> "" And Trim(tbx_filter_To.Text) <> "" Then
                sqlstring = "select isnull(a.mcode,'') as mcode "
                'sqlstring = sqlstring & " from subsposting a where " & addFltrStrr & " and a.mcode between '" & Trim(tbx_Filter_From.Text) & "' and '" & Trim(tbx_filter_To.Text) & "'"
                sqlstring = sqlstring & " from subsposting a where a.mcode between '" & Trim(tbx_Filter_From.Text) & "' and '" & Trim(tbx_filter_To.Text) & "'"
                sqlstring = sqlstring & " group by a.mcode,a.membertype order by a.mcode"
            Else
                sqlstring = "select isnull(a.mcode,'') as mcode "
                sqlstring = sqlstring & " from subsposting a where " & addFltrStrr
                sqlstring = sqlstring & " group by a.mcode,a.membertype order by a.mcode"
            End If
            subsbil = gconnection.GetValues(sqlstring)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Randomize()
            vOutfile = Mid("subbil" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            totalamt = 0 : totaltax = 0
            Dim count, i, count1, locker
            Dim RowCnt, R As Integer
            If subsbil.Rows.Count > 0 Then
                Dim row, row1 As Long
                For row = 0 To subsbil.Rows.Count - 1
                    'If RowCnt > 35 Then
                    '    If ((row Mod 2) = 0) Then
                    '        'For R = 0 To 66 - RowCnt
                    '        'Filewrite.WriteLine("")
                    '        'Next
                    '        'RowCnt = 0
                    '    Else
                    '        For R = 0 To 66 - RowCnt
                    '            Filewrite.WriteLine("")
                    '        Next
                    '        RowCnt = 0
                    '    End If
                    'Else
                    '    RowCnt = 0
                    'End If

                    If chk_Filter_Field.CheckedItems.Count <> 0 Then
                        sqlstring = " select isnull(a.subcd,'') as subcd,isnull(a.mcode,'') as mcode,isnull(d.mname,'') as mname,"
                        sqlstring = sqlstring & "isnull(a.membertype,'') as membertype,isnull(d.CurentStatus,'') as CurentStatus,isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,"
                        sqlstring = sqlstring & "isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,isnull(a.taxcode,'') as taxcode, "
                        sqlstring = sqlstring & "isnull(a.billingbasis,'') as billingbasis,isnull(a.amount,0) as amount,isnull(a.taxamount,0) as taxamount,isnull(a.period,'') as period,isnull(gdrlocker,'') as gdrlocker,isnull(ldrlocker,'') as ldrlocker,isnull(hplocker,'') as hplocker "
                        sqlstring = sqlstring & "from subsposting a,membertype b,subscriptionmast c,membermaster d "
                        sqlstring = sqlstring & "where a.mcode=d.mcode and a.membertype=b.membertype and "
                        If Trim(cbo_BillingBasis.Text) = "ALL" Then
                            sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' and " & addFltrStr
                        Else
                            sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' and " & addFltrStr
                        End If
                        sqlstring = sqlstring & " order by mcode,membertype,subscode"
                    ElseIf chk_Filter_Field.CheckedItems.Count = 0 Then
                        sqlstring = " select isnull(a.subcd,'') as subcd,isnull(a.mcode,'') as mcode,isnull(d.mname,'') as mname,"
                        sqlstring = sqlstring & "isnull(a.membertype,'') as membertype,isnull(d.CurentStatus,'') as CurentStatus,isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,"
                        sqlstring = sqlstring & "isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,isnull(a.taxcode,'') as taxcode, "
                        sqlstring = sqlstring & "isnull(a.billingbasis,'') as billingbasis,isnull(a.amount,0) as amount,isnull(a.taxamount,0) as taxamount,isnull(a.period,'') as period,isnull(gdrlocker,'') as gdrlocker,isnull(ldrlocker,'') as ldrlocker,isnull(hplocker,'') as hplocker "
                        sqlstring = sqlstring & "from subsposting a,membertype b,subscriptionmast c,membermaster d "
                        sqlstring = sqlstring & "where a.mcode=d.mcode and a.membertype=b.membertype and "
                        If Trim(cbo_BillingBasis.Text) = "ALL" Then
                            sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' "
                            ' and " & addFltrStr
                        Else
                            sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and a.mcode='" & subsbil.Rows(row).Item("mcode") & "'"
                            ' and " & addFltrStr
                        End If
                        sqlstring = sqlstring & " order by mcode,membertype,subscode"
                    End If

                    subsbill = gconnection.GetValues(sqlstring)
                    sqlstring = sqlStringFinal & "mcode='" & subsbil.Rows(row).Item("mcode") & "'"
                    madrs = gconnection.GetValues(sqlstring)
                    Dim tmcode As String
                    tmcode = Trim(UCase(madrs.Rows(0).Item("MCODE")))
                    If madrs.Rows.Count > 0 And subsbill.Rows.Count > 0 Then
                        Dim bill As String
                        Filewrite.WriteLine(Space(31) & Chr(27) & "E" & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))) & Chr(27) & "F")
                        Filewrite.WriteLine(Space(35) & Chr(27) & "E" & Mid("1 Strand Road", 1, 50) & Space(50 - Len(Mid("1 Strand Road", 1, 50))) & Chr(27) & "F")
                        Filewrite.WriteLine(Space(33) & Chr(27) & "E" & Mid("Kolkata-700 001.", 1, 50) & Space(50 - Len(Mid("Calcutta, 700 001.", 1, 50))) & Chr(27) & "F")
                        Filewrite.WriteLine()
                        Filewrite.WriteLine(Space(35) & Chr(14) & Chr(15) & "SUBSCRIPTION BILL" & Chr(18))
                        '5
                        bill = "Bill No   : SBIL/" & Mid(Year(dtp_year.Value), 3, 2) & Format(Month(dtp_year.Value), "00") & "/" & Trim(madrs.Rows(0).Item("subcd"))
                        Filewrite.WriteLine("Name  : " & Mid(Trim(UCase(madrs.Rows(0).Item("Prefix") & ":" & Chr(27) & "E" & madrs.Rows(0).Item("mname") & Chr(27) & "F")), 1, 50) & Space(50 - Len(Mid(Trim(UCase(madrs.Rows(0).Item("Prefix") & ":" & Chr(27) & "E" & madrs.Rows(0).Item("mname") & Chr(27) & "F")), 1, 50))) & Space(1) & bill)
                        bill = "Due Date  : " & Mid(Format(dtp_year.Value, "dd/MM/yyyy"), 1, 11)
                        Filewrite.WriteLine(Space(8) & Mid(Trim(UCase(madrs.Rows(0).Item("add1"))), 1, 46) & Space(46 - Len(Mid(Trim(UCase(madrs.Rows(0).Item("add1"))), 1, 46))) & Space(1) & bill)
                        bill = "Number    : " & Chr(27) & "E" & Trim(UCase(madrs.Rows(0).Item("MCODE")) & Chr(27) & "F")
                        Filewrite.WriteLine(Space(8) & Mid(Trim(UCase(madrs.Rows(0).Item("add2"))), 1, 46) & Space(46 - Len(Mid(Trim(UCase(madrs.Rows(0).Item("add2"))), 1, 46))) & Space(1) & bill)
                        bill = "Type      : " & Trim(UCase(subsbill.Rows(0).Item("typedesc")))
                        Filewrite.WriteLine(Space(8) & Mid(Trim(UCase(madrs.Rows(0).Item("add3"))), 1, 46) & Space(46 - Len(Mid(Trim(UCase(madrs.Rows(0).Item("add3"))), 1, 46))) & Space(1) & bill)
                        If Trim(madrs.Rows(0).Item("city")) <> "" Then
                            Filewrite.WriteLine(Space(8) & Trim(UCase(madrs.Rows(0).Item("city"))) & "-" & Trim(UCase(madrs.Rows(0).Item("Pincode"))))
                        Else
                            Filewrite.WriteLine()
                        End If
                        If Trim(madrs.Rows(0).Item("state")) <> "" Then
                            Filewrite.WriteLine(Space(8) & Trim(UCase(madrs.Rows(0).Item("state"))))
                        Else
                            Filewrite.WriteLine()
                        End If
                        If Trim(madrs.Rows(0).Item("country")) <> "" Then
                            Filewrite.WriteLine(Space(8) & Trim(UCase(madrs.Rows(0).Item("country"))))
                        Else
                            Filewrite.WriteLine()
                        End If
                        RowCnt = RowCnt + 12
                        '12
                    End If

                    If subsbill.Rows.Count > 0 Then
                        Filewrite.WriteLine()
                        Filewrite.WriteLine(Space(1) & "Billing Period From : " & subsbill.Rows(0).Item("period") & Space(9) & " Amount (Rs.)")
                        Filewrite.WriteLine(Space(58) & "--------------")
                        '15
                        RowCnt = RowCnt + 3
                        count = 0
                        For row1 = 0 To subsbill.Rows.Count - 1
                            If Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 10) = "GDR LOCKER" Or Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 10) = "LDR LOCKER" Or Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 9) = "HP LOCKER" Then
                                If Trim(subsbill.Rows(row1).Item("gdrlocker")) <> "" Then
                                    locker = Mid(Trim(subsbill.Rows(row1).Item("gdrlocker")), 1, 3)
                                ElseIf Trim(subsbill.Rows(row1).Item("ldrlocker")) <> "" Then
                                    locker = Mid(Trim(subsbill.Rows(row1).Item("ldrlocker")), 1, 3)
                                Else
                                    locker = Mid(Trim(subsbill.Rows(row1).Item("hplocker")), 1, 3)
                                End If
                            Else
                                locker = ""
                            End If
                            If Trim(locker) <> "" Then
                                Filewrite.Write(Space(11) & Mid(subsbill.Rows(row1).Item("subsdesc") & " <NO. " & locker & ">", 1, 50) & Space(50 - Len(Mid(subsbill.Rows(row1).Item("subsdesc") & " <NO. " & locker & ">", 1, 50))))
                            Else
                                Filewrite.Write(Space(11) & Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 50) & Space(50 - Len(Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 50))))
                            End If
                            Filewrite.WriteLine(Space(10 - Len(Format(subsbill.Rows(row1).Item("amount"), "0.00"))) & Format(subsbill.Rows(row1).Item("amount"), "0.00"))
                            totalamt = totalamt + Val(subsbill.Rows(row1).Item("amount"))
                            totaltax = totaltax + Val(subsbill.Rows(row1).Item("taxamount"))
                            count = count + 1
                            RowCnt = RowCnt + 2
                        Next row1
                        '23
                        Dim damt, camt, adjamt, total As Double
                        Filewrite.WriteLine(Space(11) & "SERVICE TAX  " & Space(37) & Space(10 - Len(Format(Val(totaltax), "0.00"))) & Format(Val(totaltax), "0.00"))
                        Filewrite.WriteLine(Space(58) & "--------------")
                        total = totaltax + totalamt
                        Filewrite.WriteLine(Space(11) & "Bill Total   " & Space(37) & Space(10 - Len(Format(Val(total), "0.00"))) & Format(Val(total), "0.00"))
                        RowCnt = RowCnt + 3
                        Dim CRBALANCE, DBBALANCE As Double
                        sqlstring = "select isnull(SUM(isnull(amount,0) - isnull(adjusted,0)),0) as RealAmount from Outstanding where  Creditdebit = 'DEBIT' AND ISNULL(VOID,'') <> 'Y' And Accountcode= 'SDRS' "
                        sqlstring = sqlstring & " and Slcode ='" & subsbil.Rows(row).Item("mcode") & "'  and (isnull(amount,0) - isnull(adjusted,0)) > 0 AND ISNULL(VOUCHERNO,'') LIKE 'SBIL%'"
                        accounts = gconnection.GetValues(sqlstring)
                        If accounts.Rows.Count > 0 Then
                            DBBALANCE = accounts.Rows(0).Item("RealAmount")
                        Else
                            DBBALANCE = 0
                        End If
                        '--- Less On Account Adjusted
                        ''==========================================================
                        ''CHANGE  BY ALOKESH 02.11.2008
                        ''-----------------------------BEGIN
                        ''''''''''''sqlstring = "select 	isnull(SUM(isnull(amount,0) - isnull(adjusted,0)),0) as RealAmount from Outstanding where  Creditdebit = 'CREDIT' AND ISNULL(VOID,'') <> 'Y' "
                        ''''''''''''sqlstring = sqlstring & " and Accountcode= 'SDRS' and isnull(Slcode,'') = '" & subsbil.Rows(row).Item("mcode") & "'  and (isnull(amount,0) - isnull(adjusted,0)) > 0 "
                        ''''''''''''accounts = gconnection.GetValues(sqlstring)
                        ''''''''''''If accounts.Rows.Count > 0 Then
                        ''''''''''''    CRBALANCE = accounts.Rows(0).Item("RealAmount")
                        ''''''''''''Else
                        ''''''''''''    CRBALANCE = 0
                        ''''''''''''End If
                        ''-----------------------------END

                        sqlstring = "SELECT ISNULL(SUM(ISNULL(M.ADJUSTEDAMOUNT,0)),0) AS RealAmount"
                        sqlstring = sqlstring & " FROM OUTSTANDING O,MATCHING M "
                        sqlstring = sqlstring & " WHERE ((M.VOUCHERNO=O.VOUCHERNO AND M.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND M.AVOUCHERNO LIKE 'SBIL%' AND M.AVOUCHERDATE='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "') OR "
                        sqlstring = sqlstring & " (O.VOUCHERNO=M.AVOUCHERNO AND M.AVOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND M.VOUCHERNO LIKE 'SBIL%' AND M.VOUCHERDATE='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "')) AND "
                        sqlstring = sqlstring & " O.CREDITDEBIT='CREDIT' AND O.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "'"
                        sqlstring = sqlstring & " AND O.SLCODE='" & tmcode & "'"
                        gconnection.getDataSet(sqlstring, "LessOnAccountPart")
                        If gdataset.Tables("LessOnAccountPart").Rows.Count > 0 Then
                            CRBALANCE = Format(gdataset.Tables("LessOnAccountPart").Rows(0).Item("RealAmount"), "0.00")
                        Else
                            CRBALANCE = 0
                        End If

                        sqlstring = "SELECT (ISNULL(SUM(ISNULL(AMOUNT,0)),0) -ISNULL(SUM(ISNULL(ADJUSTED,0)),0)) AS RealAmount"
                        sqlstring = sqlstring & " FROM OUTSTANDING O  WHERE "
                        sqlstring = sqlstring & " O.CREDITDEBIT='CREDIT' AND O.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND AMOUNT - ADJUSTED >0"
                        sqlstring = sqlstring & " AND O.SLCODE='" & Trim(tmcode) & "' AND ISNULL(VOID,'')<>'Y'"
                        sqlstring = sqlstring & " AND O.VOUCHERNO NOT IN (SELECT VOUCHERNO "
                        sqlstring = sqlstring & " FROM MATCHING WHERE (AVOUCHERNO LIKE 'SBIL%' "
                        sqlstring = sqlstring & " AND VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "') OR (VOUCHERNO LIKE 'SBIL%' AND AVOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "'))"
                        gconnection.getDataSet(sqlstring, "LessOnAccount")
                        If gdataset.Tables("LessOnAccount").Rows.Count > 0 Then
                            CRBALANCE = CRBALANCE + Val(Format(gdataset.Tables("LessOnAccount").Rows(0).Item("RealAmount"), "0.00"))
                        End If

                        'Remark on today 03.08.2008 Alokesh
                        '============================
                        'If CRBALANCE > 0 Then
                        '    If CRBALANCE >= total Then
                        '        CRBALANCE = total
                        '    End If
                        '    Filewrite.WriteLine(Space(11) & "** Add Arrear Amount     " & Space(25) & Space(10 - Len(Format(Val(CRBALANCE), "0.00"))) & Format(Val(CRBALANCE), "0.00"))
                        '    total = total - CRBALANCE
                        '    count = count + 1
                        'End If
                        'If DBBALANCE > 0 Then
                        '    Filewrite.WriteLine(Space(11) & "** Less On A/c Adjusted " & Space(25) & Space(10 - Len(Format(Val(DBBALANCE), "0.00"))) & Format(Val(DBBALANCE), "0.00"))
                        '    total = total + DBBALANCE
                        '    count = count + 1
                        'End If
                        '=============================

                        Dim TCrBalance As Double
                        Dim VSQL As String
                        Dim z, OUT1, OUT2, OUT3 As Int16
                        OUT1 = 0 : OUT2 = 0 : OUT3 = 0

                        ''=================================================

                        sqlstring = "SELECT  ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(AMOUNT,0) AS AMOUNT, ISNULL(ADJUSTED,0) AS ADJUSTED, ISNULL(SUM(ISNULL(AMOUNT,0)-ISNULL(ADJUSTED,0)),0) AS REALAMOUNT FROM OUTSTANDING WHERE VOUCHERNO LIKE 'SBIL%' AND CREDITDEBIT = 'DEBIT'  AND SLCODE = '" & Trim(tmcode) & "' AND ISNULL(VOUCHERDATE,'') < '" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' and isnull(isnull(amount,0) - isnull(adjusted,0),0) > 0 GROUP BY VOUCHERNO, voucherdate,AMOUNT,ADJUSTED"
                        gconnection.getDataSet(sqlstring, "OUTSTANDING")

                        If gdataset.Tables("OUTSTANDING").Rows.Count > 0 Then
                            OUT1 = 1
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Space(20) & "** Add Arrear")
                            Filewrite.WriteLine(StrDup(70, "-"))
                            Filewrite.WriteLine("Voucher No           Date             Amount      Adjusted    Balance")
                            Filewrite.WriteLine(StrDup(70, "-"))
                            RowCnt = RowCnt + 5
                            DBBALANCE = 0
                            For z = 0 To gdataset.Tables("OUTSTANDING").Rows.Count - 1
                                sqlstring = Mid(Trim(gdataset.Tables("OUTSTANDING").Rows(z).Item("VOUCHERNO")), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("OUTSTANDING").Rows(z).Item("VOUCHERno")), 1, 20)))
                                sqlstring = sqlstring & Space(1) & Mid(Format(DateValue(gdataset.Tables("OUTSTANDING").Rows(z).Item("VOUCHERDATE")), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(gdataset.Tables("OUTSTANDING").Rows(z).Item("VOUCHERDATE"), 1, 11)))
                                sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("AMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("AMOUNT")), "0.00"), 1, 11)
                                sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11)
                                sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11)
                                Filewrite.WriteLine(sqlstring)
                                RowCnt = RowCnt + 1
                                DBBALANCE = DBBALANCE + Val(gdataset.Tables("OUTSTANDING").Rows(z).Item("REALAMOUNT"))
                            Next z
                            total = total + DBBALANCE
                            Filewrite.WriteLine(StrDup(80, "-"))
                            Filewrite.WriteLine(Space(45) & "** Total Arrear Amount" & Space(11 - Len(Mid(Format(Val(DBBALANCE), "0.00"), 1, 11))) & Mid(Format(Val(DBBALANCE), "0.00"), 1, 11))
                            Filewrite.WriteLine(StrDup(80, "-"))
                            RowCnt = RowCnt + 3
                        End If
                        ''LESS ON ACCOUNT ADJUSTMENT =================================================
                        If CRBALANCE < 0 Then
                            CRBALANCE = CRBALANCE * -1
                        End If
                        If tmcode = "D0911" Then
                            Filewrite.WriteLine()
                            RowCnt = RowCnt + 1
                        End If
                        If CRBALANCE > 0 Then
                            TCrBalance = CRBALANCE
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Space(2) & "** Less On A/C Adjusted")
                            RowCnt = RowCnt + 2
                            VSQL = "SELECT M.VOUCHERNO AS VOUCHERNO,m.voucherdate,M.AMOUNT AS AMOUNT,M.ADJUSTEDAMOUNT AS ADJUSTED,(M.AMOUNT - M.ADJUSTEDAMOUNT) AS REALAMOUNT "
                            VSQL = VSQL & " FROM OUTSTANDING O,MATCHING M "
                            VSQL = VSQL & " WHERE ((M.VOUCHERNO=O.VOUCHERNO AND M.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND M.AVOUCHERNO LIKE 'SBIL%' AND M.AVOUCHERDATE='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "') OR "
                            VSQL = VSQL & " (O.VOUCHERNO=M.AVOUCHERNO AND M.AVOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND M.VOUCHERNO LIKE 'SBIL%' AND M.VOUCHERDATE='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "')) AND "
                            VSQL = VSQL & " O.CREDITDEBIT='CREDIT' AND O.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "'"
                            VSQL = VSQL & " AND O.SLCODE='" & Trim(tmcode) & "'"
                            gconnection.getDataSet(VSQL, "OUTSTANDING1")
                            Dim FLG As Int16
                            FLG = 0
                            If gdataset.Tables("OUTSTANDING1").Rows.Count > 0 Then
                                OUT2 = 1
                                FLG = 1
                                Filewrite.WriteLine(StrDup(70, "-"))
                                Filewrite.WriteLine("Voucher No           Date             Amount      Adjusted    Balance")
                                Filewrite.WriteLine(StrDup(70, "-"))
                                RowCnt = RowCnt + 3
                                If gdataset.Tables("OUTSTANDING1").Rows.Count > 0 Then
                                    For z = 0 To gdataset.Tables("OUTSTANDING1").Rows.Count - 1
                                        sqlstring = Mid(Trim(gdataset.Tables("OUTSTANDING1").Rows(z).Item("VOUCHERNO")), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("OUTSTANDING1").Rows(z).Item("VOUCHERNO")), 1, 20)))
                                        sqlstring = sqlstring & Space(1) & Mid(Format(DateValue(gdataset.Tables("OUTSTANDING1").Rows(z).Item("VOUCHERDATE")), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(gdataset.Tables("OUTSTANDING1").Rows(z).Item("VOUCHERDATE"), 1, 11)))
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("AMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("AMOUNT")), "0.00"), 1, 11)
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11)
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING1").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11)
                                        Filewrite.WriteLine(sqlstring)
                                        RowCnt = RowCnt + 1
                                    Next z
                                End If
                            End If
                            VSQL = "SELECT VOUCHERNO AS VOUCHERNO,VOUCHERDATE,AMOUNT AS AMOUNT,ISNULL(ADJUSTED,0) AS ADJUSTED,(ISNULL(AMOUNT,0) - ISNULL(ADJUSTED,0)) AS REALAMOUNT"
                            VSQL = VSQL & " FROM OUTSTANDING O  WHERE "
                            VSQL = VSQL & " O.CREDITDEBIT='CREDIT' AND ACCOUNTCODE='SDRS' AND O.VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "' AND ISNULL(AMOUNT,0) - ISNULL(ADJUSTED,0) >0"
                            VSQL = VSQL & " AND O.SLCODE='" & Trim(tmcode) & "'"
                            VSQL = VSQL & " AND O.VOUCHERNO NOT IN (SELECT VOUCHERNO "
                            VSQL = VSQL & " FROM MATCHING WHERE (AVOUCHERNO LIKE 'SBIL%' "
                            VSQL = VSQL & " AND VOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "') OR (VOUCHERNO LIKE 'SBIL%' AND AVOUCHERDATE<='" & Format(DateValue(dtp_year.Value), "dd/MMM/yyyy") & "'))"
                            gconnection.getDataSet(VSQL, "OUTSTANDING2")
                            If gdataset.Tables("OUTSTANDING2").Rows.Count > 0 Then
                                OUT3 = 1
                                If FLG <> 1 Then
                                    Filewrite.WriteLine(StrDup(70, "-"))
                                    Filewrite.WriteLine("Voucher No           Date             Amount      Adjusted    Balance")
                                    Filewrite.WriteLine(StrDup(70, "-"))
                                    RowCnt = RowCnt + 3
                                End If
                                If gdataset.Tables("OUTSTANDING2").Rows.Count > 0 Then
                                    For z = 0 To gdataset.Tables("OUTSTANDING2").Rows.Count - 1
                                        sqlstring = Mid(Trim(gdataset.Tables("OUTSTANDING2").Rows(z).Item("VOUCHERNO")), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("OUTSTANDING2").Rows(z).Item("VOUCHERNO")), 1, 20)))
                                        sqlstring = sqlstring & Space(1) & Mid(Format(DateValue(gdataset.Tables("OUTSTANDING2").Rows(z).Item("VOUCHERDATE")), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(gdataset.Tables("OUTSTANDING2").Rows(z).Item("VOUCHERDATE"), 1, 11)))
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("AMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("AMOUNT")), "0.00"), 1, 11)
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("ADJUSTED")), "0.00"), 1, 11)
                                        sqlstring = sqlstring & Space(1) & Space(11 - Len(Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11))) & Mid(Format(Val(gdataset.Tables("OUTSTANDING2").Rows(z).Item("REALAMOUNT")), "0.00"), 1, 11)
                                        Filewrite.WriteLine(sqlstring)
                                        RowCnt = RowCnt + 1
                                    Next z
                                End If
                            End If
                            Filewrite.WriteLine(StrDup(80, "-"))
                            RowCnt = RowCnt + 1
                            If TCrBalance > total Then
                                Filewrite.WriteLine(Space(39) & "** Total Less On A/C Adjusted" & Space(11 - Len(Mid(Format(Val(total), "0.00"), 1, 11))) & Mid(Format(Val(total), "0.00"), 1, 11))
                                Filewrite.WriteLine(StrDup(80, "-"))
                                total = 0
                                RowCnt = RowCnt + 2
                            Else
                                Filewrite.WriteLine(Space(39) & "** Total Less On A/C Adjusted" & Space(11 - Len(Mid(Format(Val(TCrBalance), "0.00"), 1, 11))) & Mid(Format(Val(TCrBalance), "0.00"), 1, 11))
                                Filewrite.WriteLine(StrDup(80, "-"))
                                total = total - TCrBalance
                                RowCnt = RowCnt + 2
                            End If
                        End If
                        ''=========================================================
                        Filewrite.WriteLine(Space(58) & "--------------")
                        Filewrite.WriteLine(Space(11) & "Net Due Amount" & Space(36) & Space(10 - Len(Format(Val(total), "0.00"))) & Chr(27) & "E" & Format(Val(total), "0.00") & Chr(27) & "F")
                        Filewrite.WriteLine(Space(58) & "==============")
                        RowCnt = RowCnt + 3
                        Dim rupeesword As String
                        rupeesword = ConvertRupees(Format(Val(total), "0.00"))
                        '30
                        Filewrite.WriteLine(Mid(Trim(Chr(27) & "E" & "RUPEES " & rupeesword & " ONLY."), 1, 69) & Chr(27) & "F" & Space(69 - Len(Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))))
                        Filewrite.WriteLine(Space(60) & Chr(27) & "E" & Mid("Secretary", 1, 20) & Space(20 - Len(Mid("Secretary", 1, 20))) & Chr(27) & "F")
                        Filewrite.WriteLine("All cheques must be drawn in favour of " & Chr(27) & "E" & "The Club" & Chr(27) & "F")
                        Filewrite.WriteLine("A/C Payee only .Rs. 100/- is to be added to outstation cheques as Bank Commition.")
                        Filewrite.WriteLine(Chr(27) & "E" & "Bill No, Member No and Member Name " & Chr(27) & "F" & Chr(18) & "should be written on reverse side of the Cheque")
                        RowCnt = RowCnt + 5
                        If count1 = 1 Then
                            Filewrite.WriteLine(Chr(27) & "E" & " ** Please ignore the arrear amount, if already Paid" & Chr(27) & "F" & Chr(18))
                            RowCnt = RowCnt + 1
                        Else
                            count = count - 1
                        End If

                        'For i = count To 7
                        '    Filewrite.WriteLine()
                        '    RowCnt = RowCnt + 1
                        'Next

                        'If RowCnt > 28 And RowCnt < 34 Then
                        '    Filewrite.WriteLine()                        
                        'End If

                        'If OUT1 = 1 Or OUT2 = 1 Or OUT3 = 1 Then
                        '    Filewrite.WriteLine(Chr(12))
                        'Else
                        '    For i = count To 7
                        '        Filewrite.WriteLine()
                        '        RowCnt = RowCnt + 1
                        '    Next
                        'End If
                        Filewrite.WriteLine(Chr(12))
                        totalamt = 0
                        totaltax = 0
                    End If
                Next row
            Else
                MsgBox("There is no Transaction,Pls Check", MsgBoxStyle.Information)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function disp_Printregister()
        If chk_Filter_Field.CheckedItems.Count = 0 Then
            chk_Filter_Field.Focus()
            Exit Function
        End If
        Try
            Dim sqlstring, sqlstring1 As String
            Dim CHK As Boolean
            Dim NEWMCODE, adddet(5), PRESENTMCODE As String
            Dim Hedd1 As String
            Dim addFilterStr2 As String
            chkfilterfield()
            addFltrStrr = addFltrStrr & ")"
            addFltrStr = addFltrStr & ")"

            If Trim(tbx_Filter_From.Text) <> "" And Trim(tbx_filter_To.Text) <> "" Then
                sqlstring = "select isnull(a.mcode,'') as mcode,isnull(a.typedesc,'') as typedesc,isnull(a.period,'') as period "
                sqlstring = sqlstring & " from subsposting a where " & addFltrStrr & " and a.mcode between '" & Trim(tbx_Filter_From.Text) & "' and '" & Trim(tbx_filter_To.Text) & "'"
                sqlstring = sqlstring & " group by a.mcode,a.membertype,a.typedesc,a.period order by a.mcode"
                subsbil = gconnection.GetValues(sqlstring)
            Else
                sqlstring = "select isnull(a.mcode,'') as mcode,isnull(a.typedesc,'') as typedesc,isnull(a.period,'') as period "
                sqlstring = sqlstring & " from subsposting a where " & addFltrStrr
                sqlstring = sqlstring & " group by a.mcode,a.membertype,a.typedesc,a.period order by a.mcode"
                subsbil = gconnection.GetValues(sqlstring)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Randomize()
            vOutfile = Mid("subreg" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            totalamt = 0 : totaltax = 0
            Dim count, i, count1
            pageno = 0
            lineno = 61
            If subsbil.Rows.Count > 0 Then
                If lineno > 60 Then
                    If pageno <> 0 Then
                        Filewrite.WriteLine(Chr(12))
                    End If
                    pageno = pageno + 1
                    Filewrite.WriteLine(Space(31) & Chr(27) & "E" & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))) & Chr(27) & "F")
                    Filewrite.WriteLine(Space(35) & Chr(27) & "E" & Mid("1 Strand Road", 1, 50) & Space(50 - Len(Mid("1 Strand Road", 1, 50))) & Chr(27) & "F")
                    Filewrite.WriteLine(Space(33) & Chr(27) & "E" & Mid("Calcutta, 700 001.", 1, 50) & Space(50 - Len(Mid("Calcutta, 700 001.", 1, 50))) & Chr(27) & "F")
                    Filewrite.WriteLine()
                    Filewrite.WriteLine("MEMBER TYPE : " & Chr(14) & Chr(15) & Trim(UCase(subsbil.Rows(0).Item("typedesc"))) & Chr(18))
                    Filewrite.WriteLine("Subscription Billing Register  Period From : " & subsbil.Rows(0).Item("period"))
                    Filewrite.WriteLine("Printing Date       : " & Format(Date.Now, "dd/MM/yyyy hh:mm:ss") & Space(20) & "Page Number : " & Format(pageno, "0000"))
                    Filewrite.WriteLine(StrDup(186, "-"))
                    Filewrite.WriteLine("MEMNO. MEMBER NAME                     C/B VOUCHER NO.  DATE        CHQ.NO       PAID AMT                  BILL NO         BILL DATE   DESCRIPTION                         AMT    BILL AMT")
                    Filewrite.WriteLine(StrDup(186, "-"))
                    lineno = 8
                End If
                Dim row, row1 As Long
                For row = 0 To subsbil.Rows.Count - 1
                    sqlstring = " select isnull(a.subcd,'') as subcd,isnull(a.mcode,'') as mcode,isnull(d.mname,'') as mname,"
                    sqlstring = sqlstring & "isnull(a.membertype,'') as membertype,isnull(d.CurentStatus,'') as CurentStatus,isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,"
                    sqlstring = sqlstring & "isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,isnull(a.taxcode,'') as taxcode, "
                    sqlstring = sqlstring & "isnull(a.billingbasis,'') as billingbasis,isnull(a.amount,0) as amount,isnull(a.taxamount,0) as taxamount,isnull(a.period,'') as period "
                    sqlstring = sqlstring & "from subsposting a,membertype b,subscriptionmast c,membermaster d "
                    sqlstring = sqlstring & "where a.mcode=d.mcode and a.membertype=b.membertype and "
                    'SHAN
                    'sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' and " & addFltrStr
                    If Trim(cbo_BillingBasis.Text) = "ALL" Then
                        sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' and " & addFltrStr
                    Else
                        sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and a.mcode='" & subsbil.Rows(row).Item("mcode") & "' and " & addFltrStr
                    End If

                    sqlstring = sqlstring & " order by mcode,membertype,subscode"
                    subsbill = gconnection.GetValues(sqlstring)
                    sqlstring = sqlStringFinal & "mcode='" & subsbil.Rows(row).Item("mcode") & "'"
                    madrs = gconnection.GetValues(sqlstring)
                    If madrs.Rows.Count > 0 And subsbill.Rows.Count > 0 Then
                        Dim bill As String
                        bill = Mid(Trim(UCase(madrs.Rows(0).Item("MCODE"))), 1, 6) & Space(6 - Len(Mid(Trim(UCase(madrs.Rows(0).Item("MCODE"))), 1, 6))) & Space(1)
                        Filewrite.Write(bill & Mid(Trim(madrs.Rows(0).Item("mname")), 1, 50) & Space(50 - Len(Mid(Trim(madrs.Rows(0).Item("mname")), 1, 50))) & Space(50) & "SBIL/" & Mid(Year(dtp_year.Value), 3, 2) & Format(Month(dtp_year.Value), "00") & "/" & Trim(madrs.Rows(0).Item("subcd")) & Space(2) & Mid(Format(dtp_year.Value, "dd/MM/yyyy"), 1, 11))
                    End If
                    If subsbill.Rows.Count > 0 Then
                        For row1 = 0 To subsbill.Rows.Count - 1
                            totalamt = totalamt + Val(subsbill.Rows(row1).Item("amount"))
                            totaltax = totaltax + Val(subsbill.Rows(row1).Item("taxamount"))
                            If row1 = 0 Then
                                Filewrite.Write(Space(2) & Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30) & Space(30 - Len(Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30))))
                                Filewrite.WriteLine(Space(10 - Len(Format(subsbill.Rows(row1).Item("amount"), "0.00"))) & Format(subsbill.Rows(row1).Item("amount"), "0.00"))
                            ElseIf row1 = subsbill.Rows.Count - 1 Then
                                Filewrite.WriteLine(Space(135) & Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30) & Space(30 - Len(Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30))) & Space(10 - Len(Format(subsbill.Rows(row1).Item("amount"), "0.00"))) & Format(subsbill.Rows(row1).Item("amount"), "0.00") & Space(10 - Len(Format(totalamt + totaltax, "0.00"))) & Format(totalamt + totaltax, "0.00"))
                            Else
                                Filewrite.WriteLine(Space(135) & Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30) & Space(30 - Len(Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 30))) & Space(10 - Len(Format(subsbill.Rows(row1).Item("amount"), "0.00"))) & Format(subsbill.Rows(row1).Item("amount"), "0.00"))
                            End If
                            lineno = lineno + 1
                            If lineno > 60 Then
                                If pageno <> 0 Then
                                    Filewrite.WriteLine(Chr(12))
                                End If
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(31) & Chr(27) & "E" & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))) & Chr(27) & "F")
                                Filewrite.WriteLine(Space(35) & Chr(27) & "E" & Mid("1 Strand Road", 1, 50) & Space(50 - Len(Mid("1 Strand Road", 1, 50))) & Chr(27) & "F")
                                Filewrite.WriteLine(Space(33) & Chr(27) & "E" & Mid("Calcutta, 700 001.", 1, 50) & Space(50 - Len(Mid("Calcutta, 700 001.", 1, 50))) & Chr(27) & "F")
                                Filewrite.WriteLine()
                                Filewrite.WriteLine("MEMBER TYPE : " & Chr(14) & Chr(15) & Trim(UCase(subsbil.Rows(0).Item("typedesc"))) & Chr(18))
                                Filewrite.WriteLine("Subscription Billing Register  Period From : " & subsbil.Rows(0).Item("period"))
                                Filewrite.WriteLine("Printing Date       : " & Format(Date.Now, "dd/MM/yyyy hh:mm:ss") & Space(20) & "Page Number : " & Format(pageno, "0000"))
                                Filewrite.WriteLine(StrDup(186, "-"))
                                Filewrite.WriteLine("MEMNO. MEMBER NAME                     C/B VOUCHER NO.  DATE        CHQ.NO       PAID AMT                  BILL NO         BILL DATE   DESCRIPTION                         AMT    BILL AMT")
                                Filewrite.WriteLine(StrDup(186, "-"))
                                lineno = 8
                            End If
                        Next row1
                        totalamt = 0
                        totaltax = 0
                    End If
                Next row
            Else
                MsgBox("There is no Transaction,Pls Check", MsgBoxStyle.Information)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Function pophead()
        If lineno > 60 Then
            If pageno <> 0 Then
                Filewrite.WriteLine(Chr(12))
            End If
            pageno = pageno + 1
            Filewrite.WriteLine(Space(31) & Chr(27) & "E" & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))) & Chr(27) & "F")
            Filewrite.WriteLine(Space(35) & Chr(27) & "E" & Mid("1 Strand Road", 1, 50) & Space(50 - Len(Mid("1 Strand Road", 1, 50))) & Chr(27) & "F")
            Filewrite.WriteLine(Space(33) & Chr(27) & "E" & Mid("Calcutta, 700 001.", 1, 50) & Space(50 - Len(Mid("Calcutta, 700 001.", 1, 50))) & Chr(27) & "F")
            Filewrite.WriteLine()
            Filewrite.WriteLine("MEMBER TYPE : " & Chr(14) & Chr(15) & Trim(UCase(subsbill.Rows(0).Item("typedesc"))) & Chr(18))
            Filewrite.WriteLine("Subscription Billing Register  Period From : " & subsbill.Rows(0).Item("period"))
            Filewrite.WriteLine("Printing Date       : " & Format(Date.Now, "dd/MM/yyyy hh:mm:ss") & Space(20) & "Page Number : " & Format(pageno, "0000"))
            Filewrite.WriteLine(StrDup(100, "-"))
            Filewrite.WriteLine("MEMB.NO.   MEMBER NAME   C/B VOUCHER NO.  DATE    CHQ.NO   PAID AMT       BILL NO    BILL DATE        DESCRIPTION             AMT   BILL AMT")
            Filewrite.WriteLine(StrDup(100, "-"))
            lineno = 8
        End If
    End Function
    Public Function disp_Printsummary()
        If chk_Filter_Field.CheckedItems.Count = 0 Then
            chk_Filter_Field.Focus()
            Exit Function
        End If
        Try
            Dim sqlstring, sqlstring1 As String
            Dim CHK As Boolean
            Dim NEWMCODE, adddet(5), PRESENTMCODE As String
            Dim Hedd1 As String
            Dim addFilterStr2 As String
            chkfilterfield()
            addFltrStrr = addFltrStrr & ")"
            addFltrStr = addFltrStr & ")"
            If Trim(tbx_Filter_From.Text) <> "" And Trim(tbx_filter_To.Text) <> "" Then
                sqlstring = "select isnull(a.mcode,'') as mcode "
                sqlstring = sqlstring & " from subsposting  where " & addFltrStrr & " and a.mcode between '" & Trim(tbx_Filter_From.Text) & "' and '" & Trim(tbx_filter_To.Text) & "'"
                sqlstring = sqlstring & " group by a.mcode,a.membertype order by a.mcode"
                subsbil = gconnection.GetValues(sqlstring)
            Else
                sqlstring = "select isnull(a.mcode,'') as mcode "
                sqlstring = sqlstring & " from subsposting a where " & addFltrStrr
                sqlstring = sqlstring & " group by a.mcode,a.membertype order by a.mcode"
                subsbil = gconnection.GetValues(sqlstring)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Randomize()
            vOutfile = Mid("subsum" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            totalamt = 0 : totaltax = 0
            If subsbil.Rows.Count > 0 Then
                Dim row, row1 As Long
                sqlstring = " select isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,sum(isnull(a.amount,0)) as amount,sum(isnull(a.taxamount,0)) as taxamount,isnull(a.period,'') as period "
                sqlstring = sqlstring & "from subsposting a,membertype b,subscriptionmast c,membermaster d "
                sqlstring = sqlstring & "where a.mcode=d.mcode and a.membertype=b.membertype and "
                If Trim(cbo_BillingBasis.Text) = "ALL" Then
                    sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & addFltrStr
                Else
                    sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and " & addFltrStr
                End If
                sqlstring = sqlstring & " group by b.typedesc,a.subscode,c.subsdesc,a.subsacctin,a.amount,a.taxamount,a.period "
                subsbill = gconnection.GetValues(sqlstring)
                Filewrite.WriteLine(Space(31) & Chr(27) & "E" & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))) & Chr(27) & "F")
                Filewrite.WriteLine(Space(35) & Chr(27) & "E" & Mid("1 Strand Road", 1, 50) & Space(50 - Len(Mid("1 Strand Road", 1, 50))) & Chr(27) & "F")
                Filewrite.WriteLine(Space(33) & Chr(27) & "E" & Mid("Calcutta, 700 001.", 1, 50) & Space(50 - Len(Mid("Calcutta, 700 001.", 1, 50))) & Chr(27) & "F")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(8) & Trim(UCase(subsbill.Rows(0).Item("typedesc"))) & " MEMEBERS")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(1) & "Billing Period Form:" & subsbill.Rows(0).Item("period") & Space(17) & " Amount  ")
                Filewrite.WriteLine(Space(35) & Chr(14) & Chr(15) & "SUBSCRIPTION BILL" & Chr(18))
                Filewrite.WriteLine()
                If subsbill.Rows.Count > 0 Then
                    For row1 = 0 To subsbill.Rows.Count - 1
                        Filewrite.Write(Space(11) & Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 50) & Space(50 - Len(Mid(subsbill.Rows(row1).Item("subsdesc"), 1, 50))))
                        Filewrite.WriteLine(Space(10 - Len(Format(subsbill.Rows(row1).Item("amount"), "0.00"))) & Format(subsbill.Rows(row1).Item("amount"), "0.00"))

                        totalamt = totalamt + Val(subsbill.Rows(row1).Item("amount"))
                        totaltax = totaltax + Val(subsbill.Rows(row1).Item("taxamount"))
                    Next row1
                End If
                Dim damt, camt, adjamt, total As Double
                Filewrite.WriteLine(Space(11) & "Service Tax  " & Space(37) & Space(10 - Len(Format(Val(totaltax), "0.00"))) & Format(Val(totaltax), "0.00"))
                Filewrite.WriteLine("------------------------------------------------------------------------------------")
                total = totaltax + totalamt
                Filewrite.WriteLine(Space(11) & "Grand Total  " & Space(37) & Space(10 - Len(Format(Val(total), "0.00"))) & Format(Val(total), "0.00"))
                Dim rupeesword As String
                rupeesword = ConvertRupees(Format(Val(total), "0.00"))
                Filewrite.WriteLine(Space(10) & Space(69 - Len(Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))) & Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                Filewrite.WriteLine(Chr(12))
                totalamt = 0
                totaltax = 0
            Else
                MsgBox("There is no Transaction,Pls Check", MsgBoxStyle.Information)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function ConvertRupees(ByVal Value As Double) As String
        Dim strText, TempString, TxtArray(5) As String
        Dim locNumber, AbsValue, DecimalValue, NumArray(5), Remain, Loopindex As Double
        NumArray(0) = 7
        NumArray(1) = 5
        NumArray(2) = 3
        NumArray(3) = 2
        TxtArray(0) = " CRORE"
        TxtArray(1) = " LAKH(S)"
        TxtArray(2) = " THOUSAND"
        TxtArray(3) = " HUNDRED"
        AbsValue = Value
        For Loopindex = 0 To 3
            locNumber = (AbsValue - (AbsValue Mod (10 ^ NumArray(Loopindex)))) / (10 ^ NumArray(Loopindex))
            If locNumber > 99 Then
                strText = strText & ConvertRupees(locNumber) & TxtArray(Loopindex)
                AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
            Else
                If locNumber <> 0 Then
                    If locNumber > 19 Then
                        strText = strText & NumValString(((locNumber - (locNumber Mod 10)) / 10) * 10) & NumValString(locNumber Mod 10) & TxtArray(Loopindex)
                    Else
                        strText = strText & NumValString(locNumber) & TxtArray(Loopindex)
                    End If
                    AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
                End If
            End If
        Next Loopindex
        If AbsValue <> 0 Then
            If AbsValue > 19 Then
                strText = strText & NumValString(((AbsValue - (AbsValue Mod 10)) / 10) * 10) & NumValString(AbsValue Mod 10) & TxtArray(Loopindex)
            Else
                strText = strText & NumValString(AbsValue)
            End If
        End If
        ConvertRupees = strText
    End Function
    Private Function NumValString(ByVal Value As Double)
        Select Case Value
            Case 1
                NumValString = " ONE"
            Case 2
                NumValString = " TWO"
            Case 3
                NumValString = " THREE"
            Case 4
                NumValString = " FOUR"
            Case 5
                NumValString = " FIVE"
            Case 6
                NumValString = " SIX"
            Case 7
                NumValString = " SEVEN"
            Case 8
                NumValString = " EIGHT"
            Case 9
                NumValString = " NINE"
            Case 10
                NumValString = " TEN"
            Case 11
                NumValString = " ELEVEN"
            Case 12
                NumValString = " TWELVE"
            Case 13
                NumValString = " THIRTEEN"
            Case 14
                NumValString = " FOURTEEN"
            Case 15
                NumValString = " FIFTEEN"
            Case 16
                NumValString = " SIXTEEN"
            Case 17
                NumValString = " SEVENTEEN"
            Case 18
                NumValString = " EIGHTEEN"
            Case 19
                NumValString = " NINETEEN"
            Case 20
                NumValString = " TWENTY"
            Case 30
                NumValString = " THIRTY"
            Case 40
                NumValString = " FOURTY"
            Case 50
                NumValString = " FIFTY"
            Case 60
                NumValString = " SIXTY"
            Case 70
                NumValString = " SEVENTY"
            Case 80
                NumValString = " EIGHTY"
            Case 90
                NumValString = " NINETY"
            Case Else
                NumValString = ""
        End Select
    End Function

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        If CheckBox1.Checked = True Then
            Call disp_Printsummary()
        ElseIf CheckBox2.Checked = True Then
            Call disp_Printregister()
        Else
            Call disp_Print()
        End If
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = TempString(1)
                    addFltrStr = FltrStr & Trim(TempString(selectNo)) & "'"
                    addFltrStrr = FltrStrr & Trim(TempString(selectNo)) & "'"
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = DispString & ", " & TempString(1)
                    addFltrStr = addFltrStr & " , '" & Trim(TempString(selectNo)) & "'"
                    addFltrStrr = addFltrStrr & " , '" & Trim(TempString(selectNo)) & "'"
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chkmonth()
        Dim i As Long
        Try
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If i = 0 Then
                    'TempString = Split((ChkList_month.Text), ".")
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = TempString(1)
                    If cbo_BillingBasis.Text = "YEARNONSUB" Then
                        chk_month = " a.billingbasis = 'YEARLY' AND a.postingcode = 'yearnonsub' " '& "'" & cbo_BillingBasis.Text & "'"
                    Else
                        chk_month = " a.billingbasis=" & "'" & cbo_BillingBasis.Text & "'"
                    End If
                    chk_month = chk_month & " and a.postingsno in(" & Trim(TempString(0))
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = DispString & ", " & TempString(1)
                    chk_month = chk_month & " , '" & Trim(TempString(0)) & "'"
                End If
            Next i
            chk_month = chk_month & ")"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Filter_By.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Cmb_add_filter.Focus()
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_add_filter.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BillingBasis.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkList_month.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        If CheckBox1.Checked = True Then
            Call disp_Printsummary()
        ElseIf CheckBox2.Checked = True Then
            Call disp_Printregister()
        Else
            Call disp_Print()
        End If
    End Sub
    Private Sub ReportScreen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call cmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call btn_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call Btn_cancel_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call btn_close_Click(sender, e)
            Exit Sub
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
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MCodefromHelp_Click(sender, e)
        End If
    End Sub
    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MCodeToHelp_Click(sender, e)
        End If
    End Sub
End Class
