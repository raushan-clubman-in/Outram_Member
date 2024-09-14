'''********* CREATED BY VENUGOPAL FOR SVS CLUB ON 08-04-2010 **********'''
'''********* PURPOSE: TO CREATE COMBINED REPORT IN SINGLE FORM *************'''
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class Member_details
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MEM_JOIN_DATE As System.Windows.Forms.CheckBox
    Friend WithEvents To_Mem_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents From_Mem_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MEM_DETAILS As System.Windows.Forms.CheckBox
    Friend WithEvents DepToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Dependent_det As System.Windows.Forms.CheckBox
    Friend WithEvents Slt_Cat_All As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Chklist_Mem_Status As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Slt_Mem_All As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Mem_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents REMAINDER_LETTER As System.Windows.Forms.CheckBox
    Friend WithEvents DepFromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents MEM_DOJ As System.Windows.Forms.CheckBox
    Friend WithEvents ADDRESS_STICKER As System.Windows.Forms.CheckBox
    Friend WithEvents ADDRESS_LIST As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_MM_LST As System.Windows.Forms.CheckBox
    Friend WithEvents MEMPHLIST_CHK As System.Windows.Forms.CheckBox
    Friend WithEvents GRP1 As System.Windows.Forms.GroupBox
    Public WithEvents GRP_EXIT As System.Windows.Forms.Button
    Public WithEvents EXCLEXPORT As System.Windows.Forms.Button
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents LaserChk As System.Windows.Forms.CheckBox
    Friend WithEvents CHKDOB As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Member_details))
        Me.Label14 = New System.Windows.Forms.Label
        Me.MEM_JOIN_DATE = New System.Windows.Forms.CheckBox
        Me.To_Mem_Date = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.From_Mem_date = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.MEM_DETAILS = New System.Windows.Forms.CheckBox
        Me.DepToDate = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.MEM_DOJ = New System.Windows.Forms.CheckBox
        Me.Dependent_det = New System.Windows.Forms.CheckBox
        Me.Slt_Cat_All = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Chklist_Mem_Status = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Slt_Mem_All = New System.Windows.Forms.CheckBox
        Me.Chklist_Mem_Category = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.REMAINDER_LETTER = New System.Windows.Forms.CheckBox
        Me.ADDRESS_STICKER = New System.Windows.Forms.CheckBox
        Me.DepFromdate = New System.Windows.Forms.DateTimePicker
        Me.ADDRESS_LIST = New System.Windows.Forms.CheckBox
        Me.CHK_MM_LST = New System.Windows.Forms.CheckBox
        Me.MEMPHLIST_CHK = New System.Windows.Forms.CheckBox
        Me.GRP1 = New System.Windows.Forms.GroupBox
        Me.GRP_EXIT = New System.Windows.Forms.Button
        Me.EXCLEXPORT = New System.Windows.Forms.Button
        Me.AxfpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.LaserChk = New System.Windows.Forms.CheckBox
        Me.CHKDOB = New System.Windows.Forms.CheckBox
        Me.GRP1.SuspendLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(336, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 25)
        Me.Label14.TabIndex = 561
        Me.Label14.Text = "MEMBER DETAILS"
        '
        'MEM_JOIN_DATE
        '
        Me.MEM_JOIN_DATE.BackColor = System.Drawing.Color.Transparent
        Me.MEM_JOIN_DATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEM_JOIN_DATE.Location = New System.Drawing.Point(400, 384)
        Me.MEM_JOIN_DATE.Name = "MEM_JOIN_DATE"
        Me.MEM_JOIN_DATE.Size = New System.Drawing.Size(96, 24)
        Me.MEM_JOIN_DATE.TabIndex = 559
        Me.MEM_JOIN_DATE.Text = "BY DOJ"
        Me.MEM_JOIN_DATE.Visible = False
        '
        'To_Mem_Date
        '
        Me.To_Mem_Date.CustomFormat = "dd-MM-yyyy"
        Me.To_Mem_Date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.To_Mem_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.To_Mem_Date.Location = New System.Drawing.Point(712, 384)
        Me.To_Mem_Date.MaxDate = New Date(2200, 8, 14, 0, 0, 0, 0)
        Me.To_Mem_Date.MinDate = New Date(1900, 8, 14, 0, 0, 0, 0)
        Me.To_Mem_Date.Name = "To_Mem_Date"
        Me.To_Mem_Date.Size = New System.Drawing.Size(109, 26)
        Me.To_Mem_Date.TabIndex = 557
        Me.To_Mem_Date.Value = New Date(2010, 4, 30, 0, 0, 0, 0)
        Me.To_Mem_Date.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(680, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 22)
        Me.Label11.TabIndex = 556
        Me.Label11.Text = "TO"
        Me.Label11.Visible = False
        '
        'From_Mem_date
        '
        Me.From_Mem_date.CustomFormat = "dd-MM-yyyy"
        Me.From_Mem_date.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From_Mem_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.From_Mem_date.Location = New System.Drawing.Point(568, 384)
        Me.From_Mem_date.MaxDate = New Date(2200, 8, 14, 0, 0, 0, 0)
        Me.From_Mem_date.MinDate = New Date(1900, 8, 14, 0, 0, 0, 0)
        Me.From_Mem_date.Name = "From_Mem_date"
        Me.From_Mem_date.Size = New System.Drawing.Size(109, 26)
        Me.From_Mem_date.TabIndex = 555
        Me.From_Mem_date.Value = New Date(2010, 4, 30, 0, 0, 0, 0)
        Me.From_Mem_date.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(504, 384)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 22)
        Me.Label12.TabIndex = 554
        Me.Label12.Text = "FROM"
        Me.Label12.Visible = False
        '
        'MEM_DETAILS
        '
        Me.MEM_DETAILS.BackColor = System.Drawing.Color.Transparent
        Me.MEM_DETAILS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEM_DETAILS.Location = New System.Drawing.Point(160, 384)
        Me.MEM_DETAILS.Name = "MEM_DETAILS"
        Me.MEM_DETAILS.Size = New System.Drawing.Size(232, 24)
        Me.MEM_DETAILS.TabIndex = 548
        Me.MEM_DETAILS.Text = "MEMBER FULL ADDRESS"
        '
        'DepToDate
        '
        Me.DepToDate.CustomFormat = "dd-MM-yyyy"
        Me.DepToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DepToDate.Location = New System.Drawing.Point(336, 648)
        Me.DepToDate.MaxDate = New Date(2200, 8, 14, 0, 0, 0, 0)
        Me.DepToDate.MinDate = New Date(1900, 8, 14, 0, 0, 0, 0)
        Me.DepToDate.Name = "DepToDate"
        Me.DepToDate.Size = New System.Drawing.Size(109, 26)
        Me.DepToDate.TabIndex = 547
        Me.DepToDate.Value = New Date(2010, 4, 30, 0, 0, 0, 0)
        Me.DepToDate.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 648)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 22)
        Me.Label8.TabIndex = 546
        Me.Label8.Text = "TO"
        Me.Label8.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 648)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
        Me.Label10.TabIndex = 544
        Me.Label10.Text = "FROM"
        Me.Label10.Visible = False
        '
        'MEM_DOJ
        '
        Me.MEM_DOJ.BackColor = System.Drawing.Color.Transparent
        Me.MEM_DOJ.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEM_DOJ.Location = New System.Drawing.Point(264, 616)
        Me.MEM_DOJ.Name = "MEM_DOJ"
        Me.MEM_DOJ.Size = New System.Drawing.Size(144, 24)
        Me.MEM_DOJ.TabIndex = 539
        Me.MEM_DOJ.Text = "BY MEM DOJ"
        Me.MEM_DOJ.Visible = False
        '
        'Dependent_det
        '
        Me.Dependent_det.BackColor = System.Drawing.Color.Transparent
        Me.Dependent_det.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dependent_det.Location = New System.Drawing.Point(64, 616)
        Me.Dependent_det.Name = "Dependent_det"
        Me.Dependent_det.Size = New System.Drawing.Size(208, 24)
        Me.Dependent_det.TabIndex = 536
        Me.Dependent_det.Text = "DEPENDENT DETAILS"
        Me.Dependent_det.Visible = False
        '
        'Slt_Cat_All
        '
        Me.Slt_Cat_All.BackColor = System.Drawing.Color.Transparent
        Me.Slt_Cat_All.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Slt_Cat_All.Location = New System.Drawing.Point(504, 112)
        Me.Slt_Cat_All.Name = "Slt_Cat_All"
        Me.Slt_Cat_All.Size = New System.Drawing.Size(128, 24)
        Me.Slt_Cat_All.TabIndex = 535
        Me.Slt_Cat_All.Text = "SELECT ALL "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 534
        Me.Label6.Text = "MEMBER STATUS"
        '
        'Chklist_Mem_Status
        '
        Me.Chklist_Mem_Status.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Mem_Status.Location = New System.Drawing.Point(504, 136)
        Me.Chklist_Mem_Status.Name = "Chklist_Mem_Status"
        Me.Chklist_Mem_Status.Size = New System.Drawing.Size(232, 172)
        Me.Chklist_Mem_Status.TabIndex = 533
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 25)
        Me.Label1.TabIndex = 532
        Me.Label1.Text = "MEMBER CATEGORY"
        '
        'Slt_Mem_All
        '
        Me.Slt_Mem_All.BackColor = System.Drawing.Color.Transparent
        Me.Slt_Mem_All.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Slt_Mem_All.Location = New System.Drawing.Point(160, 112)
        Me.Slt_Mem_All.Name = "Slt_Mem_All"
        Me.Slt_Mem_All.Size = New System.Drawing.Size(128, 24)
        Me.Slt_Mem_All.TabIndex = 531
        Me.Slt_Mem_All.Text = "SELECT ALL "
        '
        'Chklist_Mem_Category
        '
        Me.Chklist_Mem_Category.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Mem_Category.Location = New System.Drawing.Point(160, 136)
        Me.Chklist_Mem_Category.Name = "Chklist_Mem_Category"
        Me.Chklist_Mem_Category.Size = New System.Drawing.Size(304, 172)
        Me.Chklist_Mem_Category.TabIndex = 530
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, -176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 25)
        Me.Label3.TabIndex = 527
        Me.Label3.Text = "VOUCHER SALE REPORT"
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(216, -136)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(128, 68)
        Me.Chk_SelectAllPos.TabIndex = 526
        Me.Chk_SelectAllPos.Text = "SELECT ALL "
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(152, 512)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 524
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(472, 512)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 522
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(640, 512)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 523
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(312, 512)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 521
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(112, 488)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox4.TabIndex = 525
        Me.GroupBox4.TabStop = False
        '
        'REMAINDER_LETTER
        '
        Me.REMAINDER_LETTER.BackColor = System.Drawing.Color.Transparent
        Me.REMAINDER_LETTER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REMAINDER_LETTER.Location = New System.Drawing.Point(512, 664)
        Me.REMAINDER_LETTER.Name = "REMAINDER_LETTER"
        Me.REMAINDER_LETTER.Size = New System.Drawing.Size(248, 24)
        Me.REMAINDER_LETTER.TabIndex = 562
        Me.REMAINDER_LETTER.Text = "REMAINDER LETTER"
        Me.REMAINDER_LETTER.Visible = False
        '
        'ADDRESS_STICKER
        '
        Me.ADDRESS_STICKER.BackColor = System.Drawing.Color.Transparent
        Me.ADDRESS_STICKER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS_STICKER.Location = New System.Drawing.Point(160, 352)
        Me.ADDRESS_STICKER.Name = "ADDRESS_STICKER"
        Me.ADDRESS_STICKER.Size = New System.Drawing.Size(248, 24)
        Me.ADDRESS_STICKER.TabIndex = 563
        Me.ADDRESS_STICKER.Text = "ADDRESS STICKER LIST"
        '
        'DepFromdate
        '
        Me.DepFromdate.CustomFormat = "dd-MM-yyyy"
        Me.DepFromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DepFromdate.Location = New System.Drawing.Point(192, 648)
        Me.DepFromdate.MaxDate = New Date(2200, 8, 14, 0, 0, 0, 0)
        Me.DepFromdate.MinDate = New Date(1900, 5, 1, 0, 0, 0, 0)
        Me.DepFromdate.Name = "DepFromdate"
        Me.DepFromdate.Size = New System.Drawing.Size(109, 26)
        Me.DepFromdate.TabIndex = 545
        Me.DepFromdate.Value = New Date(2010, 4, 30, 0, 0, 0, 0)
        Me.DepFromdate.Visible = False
        '
        'ADDRESS_LIST
        '
        Me.ADDRESS_LIST.BackColor = System.Drawing.Color.Transparent
        Me.ADDRESS_LIST.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS_LIST.Location = New System.Drawing.Point(160, 320)
        Me.ADDRESS_LIST.Name = "ADDRESS_LIST"
        Me.ADDRESS_LIST.Size = New System.Drawing.Size(160, 24)
        Me.ADDRESS_LIST.TabIndex = 564
        Me.ADDRESS_LIST.Text = "ADDRESS LIST"
        '
        'CHK_MM_LST
        '
        Me.CHK_MM_LST.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MM_LST.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MM_LST.Location = New System.Drawing.Point(160, 456)
        Me.CHK_MM_LST.Name = "CHK_MM_LST"
        Me.CHK_MM_LST.Size = New System.Drawing.Size(232, 24)
        Me.CHK_MM_LST.TabIndex = 565
        Me.CHK_MM_LST.Text = "MEMBER LIST"
        '
        'MEMPHLIST_CHK
        '
        Me.MEMPHLIST_CHK.BackColor = System.Drawing.Color.Transparent
        Me.MEMPHLIST_CHK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMPHLIST_CHK.Location = New System.Drawing.Point(160, 416)
        Me.MEMPHLIST_CHK.Name = "MEMPHLIST_CHK"
        Me.MEMPHLIST_CHK.Size = New System.Drawing.Size(232, 24)
        Me.MEMPHLIST_CHK.TabIndex = 566
        Me.MEMPHLIST_CHK.Text = "MEMBER PHONE LIST"
        '
        'GRP1
        '
        Me.GRP1.BackColor = System.Drawing.Color.Transparent
        Me.GRP1.Controls.Add(Me.GRP_EXIT)
        Me.GRP1.Controls.Add(Me.EXCLEXPORT)
        Me.GRP1.Controls.Add(Me.AxfpSpread1)
        Me.GRP1.Location = New System.Drawing.Point(8, 16)
        Me.GRP1.Name = "GRP1"
        Me.GRP1.Size = New System.Drawing.Size(824, 680)
        Me.GRP1.TabIndex = 617
        Me.GRP1.TabStop = False
        '
        'GRP_EXIT
        '
        Me.GRP_EXIT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.GRP_EXIT.Cursor = System.Windows.Forms.Cursors.Default
        Me.GRP_EXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_EXIT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_EXIT.Location = New System.Drawing.Point(176, 632)
        Me.GRP_EXIT.Name = "GRP_EXIT"
        Me.GRP_EXIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GRP_EXIT.Size = New System.Drawing.Size(144, 40)
        Me.GRP_EXIT.TabIndex = 618
        Me.GRP_EXIT.Text = "EXIT"
        '
        'EXCLEXPORT
        '
        Me.EXCLEXPORT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.EXCLEXPORT.Cursor = System.Windows.Forms.Cursors.Default
        Me.EXCLEXPORT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXCLEXPORT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EXCLEXPORT.Location = New System.Drawing.Point(440, 632)
        Me.EXCLEXPORT.Name = "EXCLEXPORT"
        Me.EXCLEXPORT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EXCLEXPORT.Size = New System.Drawing.Size(144, 40)
        Me.EXCLEXPORT.TabIndex = 617
        Me.EXCLEXPORT.Text = "EXCEL EXPORT"
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.ContainingControl = Me
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(8, 16)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.OcxState = CType(resources.GetObject("AxfpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxfpSpread1.Size = New System.Drawing.Size(808, 608)
        Me.AxfpSpread1.TabIndex = 616
        '
        'LaserChk
        '
        Me.LaserChk.BackColor = System.Drawing.Color.Transparent
        Me.LaserChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaserChk.Location = New System.Drawing.Point(696, 584)
        Me.LaserChk.Name = "LaserChk"
        Me.LaserChk.Size = New System.Drawing.Size(112, 24)
        Me.LaserChk.TabIndex = 618
        Me.LaserChk.Text = "Laser"
        '
        'CHKDOB
        '
        Me.CHKDOB.BackColor = System.Drawing.Color.Transparent
        Me.CHKDOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDOB.Location = New System.Drawing.Point(504, 328)
        Me.CHKDOB.Name = "CHKDOB"
        Me.CHKDOB.Size = New System.Drawing.Size(160, 24)
        Me.CHKDOB.TabIndex = 619
        Me.CHKDOB.Text = "DATE OF BIRTH LIST"
        '
        'Member_details
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(848, 702)
        Me.Controls.Add(Me.GRP1)
        Me.Controls.Add(Me.MEMPHLIST_CHK)
        Me.Controls.Add(Me.CHK_MM_LST)
        Me.Controls.Add(Me.ADDRESS_LIST)
        Me.Controls.Add(Me.ADDRESS_STICKER)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.REMAINDER_LETTER)
        Me.Controls.Add(Me.MEM_JOIN_DATE)
        Me.Controls.Add(Me.To_Mem_Date)
        Me.Controls.Add(Me.From_Mem_date)
        Me.Controls.Add(Me.MEM_DETAILS)
        Me.Controls.Add(Me.DepToDate)
        Me.Controls.Add(Me.DepFromdate)
        Me.Controls.Add(Me.MEM_DOJ)
        Me.Controls.Add(Me.Dependent_det)
        Me.Controls.Add(Me.Slt_Cat_All)
        Me.Controls.Add(Me.Chklist_Mem_Status)
        Me.Controls.Add(Me.Slt_Mem_All)
        Me.Controls.Add(Me.Chklist_Mem_Category)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.LaserChk)
        Me.Controls.Add(Me.CHKDOB)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Member_details"
        Me.Text = "Member_details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GRP1.ResumeLayout(False)
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Public Myconn As New SqlConnection
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass
    Dim Viewer As New ReportViwer
    Dim r As New MEM_DET
    Dim SQL As String
    Dim CATEGORY() As String
    Dim i As Integer
    Dim gconnection As New GlobalClass




    Private Sub FillMemCat()
        '''***************************** To fill MEMBER CATEGORY FROM MEMBERTYPE  *****************'''
        Try
        Chklist_Mem_Category.Items.Clear()
        Dim i As Integer
            ssql = "SELECT DISTINCT membertype,typedesc FROM membertype "
        vconn.getDataSet(ssql, "memcat")
        If gdataset.Tables("memcat").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("memcat").Rows.Count - 1
                With gdataset.Tables("memcat").Rows(i)
                    'LstPOS.Items.Add(Trim(.Item("POSdesc")))
                    Chklist_Mem_Category.Items.Add(Trim(.Item("membertype") & "-->" & .Item("typedesc")))
                End With
            Next i
        End If
            Chklist_Mem_Category.Sorted = True
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub FillMemstat()
        '''***************************** To fill MEMBER CATEGORY FROM MEMBERTYPE  *****************'''
        Try
            Chklist_Mem_Status.Items.Clear()
            Dim i As Integer
            ssql = "select distinct curentstatus from membermaster "
            vconn.getDataSet(ssql, "memstat")
            If gdataset.Tables("memstat").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("memstat").Rows.Count - 1
                    With gdataset.Tables("memstat").Rows(i)
                        'LstPOS.Items.Add(Trim(.Item("POSdesc")))
                        Chklist_Mem_Status.Items.Add(Trim(.Item("curentstatus")))
                    End With
                Next i
            End If
            Chklist_Mem_Status.Sorted = True
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        vconn.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdView.Enabled = False
        Me.CmdPrint.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.CmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    Me.CmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Member_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GRP1.Visible = False
        AxfpSpread1.Visible = False
        FillMemCat()
        FillMemstat()
        ADDRESS_STICKER.Checked = False
        ADDRESS_LIST.Checked = False
        REMAINDER_LETTER.Checked = False
    End Sub

    Private Sub Slt_Mem_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slt_Mem_All.CheckedChanged
        Dim i As Integer
        If Slt_Mem_All.Checked = True Then
            For i = 0 To Chklist_Mem_Category.Items.Count - 1
                Chklist_Mem_Category.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_Mem_Category.Items.Count - 1
                Chklist_Mem_Category.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Slt_Cat_All_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slt_Cat_All.CheckedChanged
        Dim i As Integer
        If Slt_Cat_All.Checked = True Then
            For i = 0 To Chklist_Mem_Status.Items.Count - 1
                Chklist_Mem_Status.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_Mem_Status.Items.Count - 1
                Chklist_Mem_Status.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Dependent_det_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dependent_det.CheckedChanged
        If Dependent_det.Checked = True Then
            'DEP_MEM_REL.Visible = True
            'DEP_AGE.Visible = True
            MEM_DOJ.Visible = True
        Else
            MEM_DOJ.Checked = False
            'DEP_MEM_REL.Visible = False
            'DEP_AGE.Visible = False
            MEM_DOJ.Visible = False
            Label10.Visible = False
            DepFromdate.Visible = False
            Label8.Visible = False
            DepToDate.Visible = False
            ''Lbl_from_age.Visible = False
            'From_Age.Visible = False
            'Lbl_dep_to_age.Visible = False
            'TO_AGE.Visible = False
        End If
    End Sub

    Private Sub DEP_AGE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If DEP_AGE.Checked = True Then
        '    Lbl_from_age.Visible = True
        '    From_Age.Visible = True
        '    Lbl_dep_to_age.Visible = True
        '    TO_AGE.Visible = True
        'Else
        '    Lbl_from_age.Visible = False
        '    From_Age.Visible = False
        '    Lbl_dep_to_age.Visible = False
        '    TO_AGE.Visible = False
        'End If
    End Sub

    Private Sub DEP_BIRTH_DATE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM_DOJ.CheckedChanged
        If MEM_DOJ.Checked = True Then
            Label10.Visible = True
            DepFromdate.Visible = True
            Label8.Visible = True
            DepToDate.Visible = True
        Else
            Label10.Visible = False
            DepFromdate.Visible = False
            Label8.Visible = False
            DepToDate.Visible = False
        End If
    End Sub

    Private Sub MEM_DETAILS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM_DETAILS.CheckedChanged
        If MEM_DETAILS.Checked = True Then
            'MEMBER_AGE.Visible = True
            MEM_JOIN_DATE.Visible = True
            'REMAINDER_LETTER.Visible = True
        Else
            'MEMBER_AGE.Visible = False
            MEM_JOIN_DATE.Visible = False
            MEM_JOIN_DATE.Checked = False
            'MEM_OUTSTAND_AMT.Visible = False
            REMAINDER_LETTER.Checked = False
            'LBL_MEM_AGE.Visible = False
            'From_Mem_Age.Visible = False
            ''Lbl_To_Age.Visible = False
            'To_Mem_Age.Visible = False
            Label12.Visible = False
            From_Mem_date.Visible = False
            Label11.Visible = False
            To_Mem_Date.Visible = False

        End If
    End Sub

    Private Sub MEMBER_AGE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MEMBER_AGE.Checked = True Then
        '    MEMBER_AGE.Visible = True
        '    MEM_JOIN_DATE.Visible = True
        '    MEM_OUTSTAND_AMT.Visible = True
        '    LBL_MEM_AGE.Visible = True
        '    From_Mem_Age.Visible = True
        '    Lbl_To_Age.Visible = True
        '    To_Mem_Age.Visible = True
        'Else
        '    Label12.Visible = False
        '    From_Mem_date.Visible = False
        '    Label11.Visible = False
        '    To_Mem_Date.Visible = False
        '    LBL_MEM_AGE.Visible = False
        '    From_Mem_Age.Visible = False
        '    Lbl_To_Age.Visible = False
        '    To_Mem_Age.Visible = False
        'End If
    End Sub

    Private Sub MEM_JOIN_DATE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM_JOIN_DATE.CheckedChanged
        If MEM_JOIN_DATE.Checked = True Then
            Label12.Visible = True
            From_Mem_date.Visible = True
            Label11.Visible = True
            To_Mem_Date.Visible = True
        Else
            Label12.Visible = False
            From_Mem_date.Visible = False
            Label11.Visible = False
            To_Mem_Date.Visible = False
        End If
    End Sub

    'Private Sub MEM_ADDR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEM_ADDR.CheckedChanged
    '    If MEM_ADDR.Checked = True Then
    '        COMMUNICATION_ADDR.Visible = True
    '        RESIDENCE_ADDR.Visible = True
    '        PERMANENT_ADDR.Visible = True
    '        OFFICE_ADDR.Visible = True
    '    Else
    '        COMMUNICATION_ADDR.Visible = False
    '        RESIDENCE_ADDR.Visible = False
    '        PERMANENT_ADDR.Visible = False
    '        OFFICE_ADDR.Visible = False
    '    End If
    'End Sub

    Private Sub CmdClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        GRP1.Visible = False
        AxfpSpread1.Visible = False
        AxfpSpread1.ClearRange(1, 1, -1, -1, True)
        Slt_Mem_All.Checked = False
        Slt_Cat_All.Checked = False
        Chklist_Mem_Category.ClearSelected()
        Chklist_Mem_Status.ClearSelected()
        Dependent_det.Checked = False
        'DEP_MEM_REL.Checked = False
        MEM_DETAILS.Checked = False
        REMAINDER_LETTER.Checked = False
        ' MEM_ADDR.Checked = False
        'MEM_PHONE_EMAIL.Checked = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Chklist_Mem_Category.Items.Clear()
        Chklist_Mem_Status.Items.Clear()
        Call FillMemCat()
        Call FillMemstat()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click

        Call validation()

    End Sub
    Private Sub validation()
        Try
            Dim SQL As String
            Dim SQL_ADDR As String
            Dim CATEGORY() As String
            Dim i As Integer
            Dim Viewer As New ReportViwer
            Dim r As New DEP_DET
            Dim RPT As New MEM_FULL_ADDR
            Dim RPT1 As New MEM_LIST
            Dim RPT2 As New MEM_PH_LIST
            Dim RPT3 As New MEM_DOB_LIST
            'SQL = "SELECT isnull(M.MCODE,'') as MCODE,isnull(M.MNAME,'') as MNAME, ISNULL(M.DOB,'') AS DOB,ISNULL(M.DOJ,'') AS DOJ,ISNULL(M.CURENTSTATUS,'') AS CURENTSTATUS,ISNULL(M.MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(M.MEM_CODE,''), ISNULL(M.NAME,'') AS NAME,ISNULL(M.RELATION,'') AS RELATION,ISNULL(M.CONTCELL,'') AS CONTCELL FROM VIEW_MEM_RPR M "
            'SQL = " SELECT isnull(MCODE,'') AS MCODE,isnull(MNAME,'') AS MNAME,ISNULL(DOB,'') AS DOB,ISNULL(DOJ,'') AS DOJ,ISNULL(CURENTSTATUS,'') AS CURENTSTATUS FROM VIEW_MEMBER_DETAILS "
            If Dependent_det.Checked = True Then
                SQL = "SELECT * FROM VIEW_DEP_RPT M"
            End If
            If MEM_DETAILS.Checked = True Then
                SQL = "SELECT * FROM VIEW_MEM_ADDR M"
            End If
            If CHK_MM_LST.Checked = True Then
                If LaserChk.Checked = True Then
                    SQL = "SELECT * FROM VIEW_MEM_ADDR M"
                Else
                    GRP1.Visible = True
                    AxfpSpread1.Visible = True
                    AxfpSpread1.ClearRange(1, 1, -1, -1, True)
                    Call MEMBERLISTEXCEL()
                    Exit Sub
                End If
            End If
            If MEMPHLIST_CHK.Checked = True Then
                If LaserChk.Checked = True Then
                    SQL = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(PHONE1,'') AS PHONE1 FROM VIEW_MEM_PHLIST M"
                Else
                    GRP1.Visible = True
                    AxfpSpread1.Visible = True
                    AxfpSpread1.ClearRange(1, 1, -1, -1, True)
                    Call MEMBERPHLISTEXCEL()
                    Exit Sub
                End If

            End If
            If CHKDOB.Checked = True Then
                If LaserChk.Checked = True Then
                    SQL = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(PHONE1,'') AS PHONE1,ISNULL(DOB,'') AS DOB FROM VIEW_MEM_PHLIST M"
                Else
                    GRP1.Visible = True
                    AxfpSpread1.Visible = True
                    AxfpSpread1.ClearRange(1, 1, -1, -1, True)
                    Call MEMBERDOBLISTEXCEL()
                    Exit Sub
                End If

            End If

            '******* MEMBER CATEGORY DETAILS **************'
            If Chklist_Mem_Category.CheckedItems.Count = 0 Then
                MessageBox.Show("PLZ SELECT CATEGORY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                SQL = SQL & " WHERE M.MEMBERTYPECODE IN ("
                For i = 0 To Chklist_Mem_Category.CheckedItems.Count - 1
                    CATEGORY = Split(Chklist_Mem_Category.CheckedItems(i), "-->")
                    SQL = SQL & " '" & Trim(CATEGORY(0)) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"
            End If

            '******* MEMBER STATUS DETAILS **************'
            If Chklist_Mem_Status.CheckedItems.Count = 0 Then
                MessageBox.Show("PLZ SELECT STATUS", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                SQL = SQL & "AND M.CURENTSTATUS IN ("
                For i = 0 To Chklist_Mem_Status.CheckedItems.Count - 1
                    SQL = SQL & " '" & Trim(Chklist_Mem_Status.CheckedItems(i)) & "', "
                Next
                SQL = Mid(SQL, 1, Len(SQL) - 2)
                SQL = SQL & ")"

            End If

            '******* DEPENDENT DOB DETAILS **************'
            'If DEP_BIRTH_DATE.Checked = True Then

            'End If

            '******* MEMBER DOJ DETAILS **************'
            If MEM_JOIN_DATE.Checked = True Then
                SQL = SQL & " AND DOJ >= '" & Format(From_Mem_date.Value, "dd-MMM-yyyy") & "'"
                SQL = SQL & " AND DOJ <=' " & Format(To_Mem_Date.Value, "dd-MMM-yyyy") & "'"
            End If

            If MEM_DOJ.Checked = True Then
                SQL = SQL & " AND DOJ >= '" & Format(DepFromdate.Value, "dd-MMM-yyyy") & "'"
                SQL = SQL & " AND DOJ <=' " & Format(DepToDate.Value, "dd-MMM-yyyy") & "'"
            End If
            If CHK_MM_LST.Checked = True Then
                SQL = SQL & " ORDER BY  M.MEMBERTYPECODE,M.MCODE"
            Else
                SQL = SQL & " ORDER BY M.MCODE"
            End If

            'SQL_ADDR = SQL_ADDR & "ORDER BY MCODE"

            If Dependent_det.Checked = True Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Dim txtobj As TextObject
                txtobj = r.ReportDefinition.ReportObjects("Text13")
                txtobj.Text = gCompanyname
                Viewer.TableName = "VIEW_DEP_RPT"
                Viewer.Show()
            End If
            If MEM_DETAILS.Checked = True Then
                Viewer.ssql = SQL
                Viewer.Report = RPT
                Dim txtobj As TextObject
                txtobj = RPT.ReportDefinition.ReportObjects("Text13")
                txtobj.Text = gCompanyname
                Viewer.TableName = "VIEW_MEM_ADDR"
                Viewer.Show()
            End If

            If CHK_MM_LST.Checked = True Then
                Viewer.ssql = SQL
                Viewer.Report = RPT1
                Dim txtobj As TextObject
                txtobj = RPT.ReportDefinition.ReportObjects("Text13")
                txtobj.Text = gCompanyname
                Viewer.TableName = "VIEW_MEM_ADDR"
                Viewer.Show()
            End If
            If MEMPHLIST_CHK.Checked = True Then
                Viewer.ssql = SQL
                Viewer.Report = RPT2
                Dim txtobj As TextObject
                txtobj = RPT.ReportDefinition.ReportObjects("Text13")
                txtobj.Text = gCompanyname
                Viewer.TableName = "VIEW_MEM_PHLIST"
                Viewer.Show()
            End If
            If CHKDOB.Checked = True Then
                Viewer.ssql = SQL
                Viewer.Report = RPT3
                Dim txtobj As TextObject
                txtobj = RPT.ReportDefinition.ReportObjects("Text13")
                txtobj.Text = gCompanyname
                Viewer.TableName = "VIEW_MEM_PHLIST"
                Viewer.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub
    Public Sub MEMBERPHLISTEXCEL()
        Dim J As Integer
        SQL = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(PHONE1,'') AS PHONE1 FROM VIEW_MEM_PHLIST M"
        '******* MEMBER CATEGORY DETAILS **************'
        If Chklist_Mem_Category.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT CATEGORY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & " WHERE M.MEMBERTYPECODE IN ("
            For i = 0 To Chklist_Mem_Category.CheckedItems.Count - 1
                CATEGORY = Split(Chklist_Mem_Category.CheckedItems(i), "-->")
                SQL = SQL & " '" & Trim(CATEGORY(0)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"
        End If

        '******* MEMBER STATUS DETAILS **************'
        If Chklist_Mem_Status.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT STATUS", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & "AND M.CURENTSTATUS IN ("
            For i = 0 To Chklist_Mem_Status.CheckedItems.Count - 1
                SQL = SQL & " '" & Trim(Chklist_Mem_Status.CheckedItems(i)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"

        End If
        SQL = SQL & "   ORDER BY MCODE"
        gconnection.getDataSet(SQL, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            AxfpSpread1.Row = 0
            AxfpSpread1.Col = 4
            AxfpSpread1.Text = "CONTACT NO"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                AxfpSpread1.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mcode")) & "")
                AxfpSpread1.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mname")) & "")
                AxfpSpread1.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("membertypecode")) & "")
                AxfpSpread1.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("PHONE1")) & "")
                J = J + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub

    Public Sub MEMBERDOBLISTEXCEL()
        Dim J As Integer
        SQL = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(PHONE1,'') AS PHONE1,ISNULL(DOB,'') AS DOB FROM VIEW_MEM_PHLIST M"
        '******* MEMBER CATEGORY DETAILS **************'
        If Chklist_Mem_Category.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT CATEGORY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & " WHERE M.MEMBERTYPECODE IN ("
            For i = 0 To Chklist_Mem_Category.CheckedItems.Count - 1
                CATEGORY = Split(Chklist_Mem_Category.CheckedItems(i), "-->")
                SQL = SQL & " '" & Trim(CATEGORY(0)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"
        End If

        '******* MEMBER STATUS DETAILS **************'
        If Chklist_Mem_Status.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT STATUS", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & "AND M.CURENTSTATUS IN ("
            For i = 0 To Chklist_Mem_Status.CheckedItems.Count - 1
                SQL = SQL & " '" & Trim(Chklist_Mem_Status.CheckedItems(i)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"

        End If
        SQL = SQL & "   ORDER BY MCODE"
        gconnection.getDataSet(SQL, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            AxfpSpread1.Row = 0
            AxfpSpread1.Col = 4
            AxfpSpread1.Text = "Date of birth"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                AxfpSpread1.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mcode")) & "")
                AxfpSpread1.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mname")) & "")
                AxfpSpread1.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("membertypecode")) & "")

                If Format(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("DOB"), "dd/MM/yyyy") = "01/01/1900" Then
                    AxfpSpread1.SetText(4, i, "")
                Else
                    AxfpSpread1.SetText(4, i, CStr(Format(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("DOB"), "dd/MM/yyyy")) & "")

                End If
                J = J + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub
    Public Sub MEMBERLISTEXCEL()
        Dim J As Integer
        SQL = "SELECT * FROM VIEW_MEM_ADDR M"
        '******* MEMBER CATEGORY DETAILS **************'
        If Chklist_Mem_Category.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT CATEGORY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & " WHERE M.MEMBERTYPECODE IN ("
            For i = 0 To Chklist_Mem_Category.CheckedItems.Count - 1
                CATEGORY = Split(Chklist_Mem_Category.CheckedItems(i), "-->")
                SQL = SQL & " '" & Trim(CATEGORY(0)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"
        End If

        '******* MEMBER STATUS DETAILS **************'
        If Chklist_Mem_Status.CheckedItems.Count = 0 Then
            MessageBox.Show("PLZ SELECT STATUS", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            SQL = SQL & "AND M.CURENTSTATUS IN ("
            For i = 0 To Chklist_Mem_Status.CheckedItems.Count - 1
                SQL = SQL & " '" & Trim(Chklist_Mem_Status.CheckedItems(i)) & "', "
            Next
            SQL = Mid(SQL, 1, Len(SQL) - 2)
            SQL = SQL & ")"

        End If
        SQL = SQL & "   ORDER BY MCODE"
        gconnection.getDataSet(SQL, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                AxfpSpread1.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mcode")) & "")
                AxfpSpread1.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("mname")) & "")
                AxfpSpread1.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("membertypecode")) & "")
                AxfpSpread1.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(J).Item("curentstatus")) & "")
                J = J + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub



    Private Sub Chklist_Mem_Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_Mem_Category.SelectedIndexChanged

    End Sub

    Private Sub MEM_PHONE_EMAIL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MEM_OUTSTAND_AMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REMAINDER_LETTER.CheckedChanged
        If REMAINDER_LETTER.Checked = True Then
            Try
                'ReportTitle = "Reminder_Letter"
                Dim ReportFilterObj As New reminder
                RepSqlStr = "Reminder_Letter"
                'ReportFilterObj.MdiParent = Me
                ReportFilterObj.Text = RepSqlStr
                ReportFilterObj.Show()
                'ReportFilterObj.MdiParent = Me
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub ADDRESS_STICKER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDRESS_STICKER.CheckedChanged
        If ADDRESS_STICKER.Checked = True Then
            Try
                Dim ReportFilterObj As New Stickerlist
                ReportFilterObj.Show()
                'ReportFilterObj.MdiParent = Me
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ADDRESS_LIST_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDRESS_LIST.CheckedChanged
        If ADDRESS_LIST.Checked = True Then
            Try
                Dim ReportFilterObj As New addresslist
                ReportFilterObj.Show()
                'ReportFilterObj.MdiParent = Me
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub





    Private Sub GRP_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRP_EXIT.Click
        GRP1.Visible = False
        AxfpSpread1.Visible = False
        AxfpSpread1.ClearRange(1, 1, -1, -1, True)
    End Sub

    Private Sub EXCLEXPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXCLEXPORT.Click
        Try
            If AxfpSpread1.Visible = True Then
                Call ExportTo(AxfpSpread1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Member_details_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click_1(sender, e)
        End If
        If e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
        End If
    End Sub
End Class



