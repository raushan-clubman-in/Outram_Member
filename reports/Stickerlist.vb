Imports System.Data.SqlClient
Imports System.IO
Public Class Stickerlist
    Inherits System.Windows.Forms.Form
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt, posting As New DataTable
    Dim FltrStr, TempString(2), DispString, status, addFltrStr, order As String
    Dim sqlStringFinal, sqlstring, addFltrStrr, FltrStrr As String
    Dim addlist As DataTable
    Public selectNo As Integer
    Dim AddStr1(10), AddStr2(10) As String
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
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RADWMEMBER As System.Windows.Forms.RadioButton
    Friend WithEvents RADWOUTMEMBER As System.Windows.Forms.RadioButton
    Friend WithEvents CHKPHONENO As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSURNAME As System.Windows.Forms.CheckBox
    Friend WithEvents ChK_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Stickerlist))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ChK_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.CHKSURNAME = New System.Windows.Forms.CheckBox
        Me.CHKPHONENO = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RADWOUTMEMBER = New System.Windows.Forms.RadioButton
        Me.RADWMEMBER = New System.Windows.Forms.RadioButton
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk_STATUS = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(24, 560)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 56)
        Me.GroupBox2.TabIndex = 389
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(368, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 17
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(520, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 18
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(224, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(72, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 16
        Me.CmdView.Text = "View[F9]"
        '
        'Lst_status1
        '
        Me.Lst_status1.ItemHeight = 18
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.LIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(832, 192)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status1.TabIndex = 388
        Me.Lst_status1.Visible = False
        '
        'Lst_status
        '
        Me.Lst_status.ItemHeight = 18
        Me.Lst_status.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.Lst_status.Location = New System.Drawing.Point(832, 304)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status.TabIndex = 387
        Me.Lst_status.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 35)
        Me.Label2.TabIndex = 385
        Me.Label2.Text = "ADDRESS  STICKER  LIST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ssgrid1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_BillingBasis)
        Me.GroupBox1.Controls.Add(Me.cbo_BillingBasis)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.ChK_Memberstatus)
        Me.GroupBox1.Controls.Add(Me.CHKSURNAME)
        Me.GroupBox1.Controls.Add(Me.CHKPHONENO)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.cmb_Filter_By)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Cmb_add_filter)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chk_STATUS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 520)
        Me.GroupBox1.TabIndex = 386
        Me.GroupBox1.TabStop = False
        '
        'ssgrid1
        '
        Me.ssgrid1.ContainingControl = Me
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(488, 152)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(168, 192)
        Me.ssgrid1.TabIndex = 603
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 602
        Me.Label1.Text = "Selected Member"
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(376, 49)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(96, 20)
        Me.lbl_BillingBasis.TabIndex = 593
        Me.lbl_BillingBasis.Text = "Billing Basis"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(480, 48)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(176, 26)
        Me.cbo_BillingBasis.TabIndex = 592
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(512, 376)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 24)
        Me.CheckBox1.TabIndex = 401
        Me.CheckBox1.Text = "Billing"
        Me.CheckBox1.Visible = False
        '
        'ChK_Memberstatus
        '
        Me.ChK_Memberstatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.ChK_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.ChK_Memberstatus.Location = New System.Drawing.Point(256, 152)
        Me.ChK_Memberstatus.Name = "ChK_Memberstatus"
        Me.ChK_Memberstatus.Size = New System.Drawing.Size(216, 194)
        Me.ChK_Memberstatus.Sorted = True
        Me.ChK_Memberstatus.TabIndex = 400
        '
        'CHKSURNAME
        '
        Me.CHKSURNAME.Location = New System.Drawing.Point(304, 376)
        Me.CHKSURNAME.Name = "CHKSURNAME"
        Me.CHKSURNAME.Size = New System.Drawing.Size(96, 24)
        Me.CHKSURNAME.TabIndex = 399
        Me.CHKSURNAME.Text = "SurName"
        '
        'CHKPHONENO
        '
        Me.CHKPHONENO.Location = New System.Drawing.Point(400, 376)
        Me.CHKPHONENO.Name = "CHKPHONENO"
        Me.CHKPHONENO.TabIndex = 398
        Me.CHKPHONENO.Text = "With Ph.No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RADWOUTMEMBER)
        Me.GroupBox3.Controls.Add(Me.RADWMEMBER)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 40)
        Me.GroupBox3.TabIndex = 396
        Me.GroupBox3.TabStop = False
        '
        'RADWOUTMEMBER
        '
        Me.RADWOUTMEMBER.Checked = True
        Me.RADWOUTMEMBER.Location = New System.Drawing.Point(120, 13)
        Me.RADWOUTMEMBER.Name = "RADWOUTMEMBER"
        Me.RADWOUTMEMBER.Size = New System.Drawing.Size(136, 24)
        Me.RADWOUTMEMBER.TabIndex = 1
        Me.RADWOUTMEMBER.TabStop = True
        Me.RADWOUTMEMBER.Text = "With Out Mcode"
        '
        'RADWMEMBER
        '
        Me.RADWMEMBER.Location = New System.Drawing.Point(8, 12)
        Me.RADWMEMBER.Name = "RADWMEMBER"
        Me.RADWMEMBER.Size = New System.Drawing.Size(117, 24)
        Me.RADWMEMBER.TabIndex = 0
        Me.RADWMEMBER.Text = "With Mcode"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(368, 416)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 395
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(224, 416)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 394
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(24, 128)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(164, 23)
        Me.chk_PrintAll.TabIndex = 393
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 392
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Location = New System.Drawing.Point(296, 416)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 24)
        Me.tbx_filter_To.TabIndex = 387
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Location = New System.Drawing.Point(152, 416)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 24)
        Me.tbx_Filter_From.TabIndex = 386
        Me.tbx_Filter_From.Text = ""
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(24, 152)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(224, 213)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 385
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(8, 16)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 26)
        Me.cmb_Filter_By.TabIndex = 384
        Me.cmb_Filter_By.Text = "[select your filter]"
        Me.cmb_Filter_By.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 20)
        Me.Label9.TabIndex = 388
        Me.Label9.Text = "MEMBER CATEGORY "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 389
        Me.Label10.Text = "ADDRESS  FILTER"
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Cmb_add_filter.ItemHeight = 18
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(168, 48)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(172, 26)
        Me.Cmb_add_filter.TabIndex = 390
        Me.Cmb_add_filter.Text = "[select your filter]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'chk_STATUS
        '
        Me.chk_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.chk_STATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_STATUS.Location = New System.Drawing.Point(258, 128)
        Me.chk_STATUS.Name = "chk_STATUS"
        Me.chk_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.chk_STATUS.TabIndex = 393
        Me.chk_STATUS.Text = "Print All Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 388
        Me.Label3.Text = "MEMBER STATUS"
        '
        'Stickerlist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 638)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lst_status1)
        Me.Controls.Add(Me.Lst_status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Stickerlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADDRESS STICKER LIST"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private Sub Stickerlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmb_Filter_By.Focus()
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Dim ssql As String
            Dim MEMBERTYPE As New DataTable
            ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
            MEMBERTYPE = gconnection.GetValues(ssql)
            Dim Itration
            For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
            Next
            Dim i As Long
            posting = Nothing
            sqlstring = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlstring)
            If posting.Rows.Count > 0 Then
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            Else
                cbo_BillingBasis.Items.Add("ALL")
            End If

            gconnection.closeConnection()
            cbo_BillingBasis.SelectedIndex = 0
            cbo_BillingBasis.Focus()

            cmb_Filter_By.SelectedIndex = 1
            Cmb_add_filter.SelectedIndex = 0
            CheckBox1.Checked = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Private Sub Stickerlist_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call cmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
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
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Filter_By.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Dim ssql As String
        cmb_Filter_By.Focus()
        chk_Filter_Field.Items.Clear()
        cmb_Filter_By.SelectedIndex = 1
        tbx_Filter_From.Text = ""
        tbx_filter_To.Text = ""
        CHKPHONENO.Checked = False
        CHKSURNAME.Checked = False
        RADWOUTMEMBER.Checked = True
        chk_PrintAll.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
        chk_STATUS.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            tbx_Filter_From.Focus()
        End If
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
        DispString = ""
        status = ""
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = TempString(0)
                    addFltrStr = FltrStr & Trim(TempString(selectNo)) & "'"
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = DispString & "','" & TempString(0)
                    addFltrStr = addFltrStr & "','" & Trim(TempString(selectNo)) & "'"
                End If
            Next i
            addFltrStr = addFltrStr & ")"
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
    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        chk_Filter_Field.Enabled = True
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(b.typedesc,'') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,(isnull(a.surname,'') +' '+isnull(a.firstname,'')+' '+isnull(a.middlename,'')) as Sname,isnull(a.contadd1,'') as add1,isnull(a.contadd2,'') as add2,isnull(a.contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(a.contcity,'') as city,isnull(a.contstate,'') as state,isnull(a.contcountry,'') as country,isnull(a.contpin,'') as pincode,isnull(a.contphone1,'') as phone1, isnull(a.prefix,'') as prefix From membermaster a,membertype b where "
            If CheckBox1.Checked = False Then
                order = "order by a.mcode"
            Else
                order = "order by a.mcode"
            End If
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(b.typedesc,'') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,(isnull(a.surname,'') +' '+isnull(a.firstname,'')+' '+isnull(a.middlename,'')) as Sname,isnull(a.padd1,'') as add1,isnull(a.padd2,'') as add2,isnull(a.padd3,'') as add3,isnull(a.pcity,'') as city,isnull(a.pstate,'') as state,isnull(a.pcountry,'') as country,isnull(a.ppin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(a.contphone1,'') as phone1,isnull(a.prefix,'') as prefix From membermaster a,membertype b where "
            If CheckBox1.Checked = False Then
                order = " order by ppin"
            Else
                order = "order by a.mcode"
            End If
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(b.typedesc,'') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,(isnull(a.surname,'') +' '+isnull(a.firstname,'')+' '+isnull(a.middlename,'')) as Sname,isnull(a.cadd1,'') as add1,isnull(a.cadd2,'') as add2,isnull(a.cadd3,'') as add3,isnull(a.ccity,'') as city,isnull(a.cstate,'') as state,isnull(a.ccountry,'') as country,isnull(a.cpin,'') as pincode,isnull(a.cphone1,'') as phone1,isnull(a.prefix,'') as prefix  FROM membermaster a,membertype b where "
            If CheckBox1.Checked = False Then
                order = " order by cpin"
            Else
                order = "order by a.mcode"
            End If
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(b.typedesc,'') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,(isnull(a.surname,'') +' '+isnull(a.firstname,'')+' '+isnull(a.middlename,'')) as Sname,isnull(a.oadd1,'') as add1,isnull(a.oadd2,'') as add2,isnull(a.oadd3,'') as add3,isnull(a.ocity,'') as city,isnull(a.ostate,'') as state,isnull(a.ocountry,'') as country,isnull(a.opin,'') as pincode,isnull(a.ophone1,'') as phone1,isnull(a.prefix,'') as prefix  FROM membermaster a,membertype b where "
            If CheckBox1.Checked = False Then
                order = " order by opin"
            Else
                order = "order by a.mcode"
            End If
        End If
    End Sub
    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        Call printdata1()
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        'Call printdata()
        Call printdata1()
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
    Private Sub Cmb_add_filter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_add_filter.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
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
    Private Sub cmb_Filter_By_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Filter_By.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_add_filter.Focus()
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_add_filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Function printdata()
        Dim str()() As String
        Dim i, j, lp, lpNext1, lpNext2, pagesize As Integer
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim STR0 As String
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim STR4 As String
        Dim STR5 As String
        Dim STR6 As String
        Dim STR7 As String
        Dim STR8 As String
        Dim STR9 As String
        Dim vMCode(1) As String
        Dim vMName(1) As String   'For Lable Printing
        Dim vDoj(1) As String
        Dim vspouse(1) As String
        Dim vOrgName(1) As String
        Dim vDesignation(1) As String
        Dim vMCompany(1) As String
        Dim vMAdd1(1) As String
        Dim vMAdd2(1) As String
        Dim vMCity(1) As String
        Dim vMState(1) As String
        Dim vMTel(1) As String
        Dim vMFax(1) As String
        Dim vMCell(1) As String
        Dim vMEmail(1) As String
        Dim vMPinCode(1) As String
        Try
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Function
            End If
            Call chkfilterfield()
            'sqlstring = sqlStringFinal & addFltrStr
            sqlstring = sqlStringFinal & " curentstatus in('" & status & "') and membertypecode=('" & DispString & "')"
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            End If
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            da = New SqlDataAdapter(sqlstring, gconnection.sqlconnection)
            da.Fill(ds, "master1")
            pagesize = 0
            For i = 0 To ds.Tables("Master1").Rows.Count - 2
                dr1 = ds.Tables("Master1").NewRow
                dr2 = ds.Tables("Master1").NewRow
                dr1 = ds.Tables("master1").Rows(i)
                dr2 = ds.Tables("master1").Rows(i + 1)
                lpNext1 = 0
                lpNext2 = 0
                For lp = 0 To 10
                    If Trim(dr1(lp)) <> "" Then
                        AddStr1(lpNext1) = Trim(dr1(lp))
                        lpNext1 = lpNext1 + 1
                    End If

                    If Trim(dr2(lp)) <> "" Then
                        AddStr2(lpNext2) = Trim(dr2(lp))
                        lpNext2 = lpNext2 + 1
                    End If
                Next
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(10) & " " & AddStr1(1) & " [" & AddStr1(0) & "]", AddStr1(10) & " " & AddStr1(1) & " [" & AddStr1(0) & "]")
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(2), AddStr2(2))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(3), AddStr2(3))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(4), AddStr2(4))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(5) & " " & AddStr1(6), AddStr1(5) & " " & AddStr1(6))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(7) & " " & AddStr1(8) & " " & AddStr1(9), AddStr1(7) & " " & AddStr1(8) & " " & AddStr1(9))
                If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "-"))
                If PRINTREP = True Then Filewrite.WriteLine("")
                If PRINTREP = True Then Filewrite.WriteLine("")
            Next i
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
    Private Function printdata1()
        Dim vMCode(2) As String
        Dim vMName(2) As String
        Dim vMAdd1(2) As String
        Dim vMAdd2(2) As String
        Dim vMAdd3(2) As String
        Dim sno As Integer
        Dim vMCity(2) As String
        Dim vMState(2) As String
        Dim vMTel(2) As String
        Dim vOption As Boolean
        Dim vMPinCode(2) As String
        Dim vsplit() As String
        Dim rcount As Integer
        Dim vAns As Double
        Dim str()() As String
        Dim i, j, lp, prn, lpNext1, lpNext2, pagesize As Integer
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim STR0 As String
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim STR4 As String
        Dim STR5 As String
        Dim STR6 As String
        Dim STR7 As String
        Dim STR8 As String
        Dim STR9 As String
        Dim vDoj(2) As String
        Dim vspouse(2) As String
        Dim vOrgName(2) As String
        Dim vDesignation(2) As String
        Dim vMCompany(2) As String
        Dim vMFax(2) As String
        Dim vMCell(2) As String
        Dim vMEmail(2) As String
        Dim tname As String
        Dim SMem As String
        Dim SelMem As String
        Dim loopindex As Integer
        Try
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Function
            End If
            Call chkfilterfield()
            'sqlstring = sqlStringFinal & addFltrStr
            Dim Bill_Basis As String
            If cbo_BillingBasis.Text = "ALL" Then
                Bill_Basis = ""
            Else
                Bill_Basis = " and billbasis = '"
                Bill_Basis = Bill_Basis & cbo_BillingBasis.Text
                Bill_Basis = Bill_Basis & "'"
            End If

            SelMem = SelMem & "MCODE IN ("
            For loopindex = 1 To ssgrid1.DataRowCnt
                SMem = Nothing
                ssgrid1.GetText(1, loopindex, SMem)
                SelMem = SelMem & "'" & SMem & "',"
            Next
            SelMem = Mid(SelMem, 1, Len(SelMem) - 1)
            SelMem = SelMem & ") "

            If ssgrid1.DataRowCnt > 0 Then
                sqlstring = sqlStringFinal & " a.membertypecode=b.membertype  and curentstatus in('" & status & "') " & Bill_Basis & " and " & SelMem & " "
            Else
                sqlstring = sqlStringFinal & " a.membertypecode=b.membertype and curentstatus in('" & status & "') and membertypecode in('" & DispString & "') " & Bill_Basis & " "
            End If
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            End If
            Randomize()
            tname = "master1"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            If CHKSURNAME.Checked = True Then
                If CheckBox1.Checked = False Then
                    sqlstring = sqlstring & " order by surname,firstname"
                    'sqlstring = sqlstring & " order by prefixmcode,msorderno,mcode asc"
                Else
                    'sqlstring = sqlstring & " order by mcode"
                    sqlstring = sqlstring & " order by prefixmcode,msorderno,mcode asc"
                End If
            Else
                If CheckBox1.Checked = False Then
                    sqlstring = sqlstring & " " & order
                Else
                    'sqlstring = sqlstring & " order by mcode"
                    sqlstring = sqlstring & " order by prefixmcode,msorderno,mcode asc"
                End If
            End If
            dt = gconnection.GetValues(sqlstring)
            pagesize = 0
            Dim icount As Integer
            If dt.Rows.Count > 0 Then
                sno = 1
                For i = 0 To dt.Rows.Count - 1
                    prn = 1
                    For j = 0 To 2
                        If i < dt.Rows.Count Then
                            vMCode(j) = Mid(Trim(dt.Rows(i).Item("mcode") & ""), 1, 40)
                            If CHKSURNAME.Checked = True Then
                                vMName(j) = Mid(Trim(dt.Rows(i).Item("Sname") & ""), 1, 40)
                            Else
                                vMName(j) = Mid(Trim(dt.Rows(i).Item("mname") & ""), 1, 40)
                            End If
                            vMAdd1(j) = Mid(Trim(dt.Rows(i).Item("add1") & ""), 1, 40)
                            vMAdd2(j) = Mid(Trim(dt.Rows(i).Item("add2") & ""), 1, 40)
                            vMAdd3(j) = Mid(Trim(dt.Rows(i).Item("add3") & ""), 1, 40)
                            If CheckBox1.Checked = True Then
                                vMCity(j) = Mid(Trim(dt.Rows(i).Item("city")) & IIf(Trim(dt.Rows(i).Item("city")) = "", "", "-") & Trim(dt.Rows(i).Item("PINCODE")), 1, 40)
                            Else
                                vMCity(j) = Mid(Trim(dt.Rows(i).Item("city")) & IIf(Trim(dt.Rows(i).Item("city")) = "", "", "-") & Trim(dt.Rows(i).Item("PINCODE")), 1, 40)
                            End If

                            vMTel(j) = "Tel. " & Trim(dt.Rows(i).Item("phone1"))
                            i = i + 1
                        End If
                        sno = sno + 1
                    Next
                    If RADWMEMBER.Checked = True Then
                        Filewrite.WriteLine(Mid(vMCode(0), 1, 25) & Space(25 - Len(Mid(vMCode(0), 1, 25))) & Space(6) & Mid(vMCode(1), 1, 25) & Space(25 - Len(Mid(vMCode(1), 1, 25))) & Space(6) & Mid(vMCode(2), 1, 25) & Space(25 - Len(Mid(vMCode(2), 1, 25))))
                        prn = prn + 1
                    End If
                    Filewrite.WriteLine(Mid(vMName(0), 1, 25) & Space(25 - Len(Mid(vMName(0), 1, 25))) & Space(6) & Mid(vMName(1), 1, 25) & Space(25 - Len(Mid(vMName(1), 1, 25))) & Space(6) & Mid(vMName(2), 1, 25) & Space(25 - Len(Mid(vMName(2), 1, 25))))
                    Filewrite.WriteLine(Mid(vMAdd1(0), 1, 25) & Space(25 - Len(Mid(vMAdd1(0), 1, 25))) & Space(6) & Mid(vMAdd1(1), 1, 25) & Space(25 - Len(Mid(vMAdd1(1), 1, 25))) & Space(6) & Mid(vMAdd1(2), 1, 25) & Space(25 - Len(Mid(vMAdd1(2), 1, 25))))
                    Filewrite.WriteLine(Mid(vMAdd2(0), 1, 25) & Space(25 - Len(Mid(vMAdd2(0), 1, 25))) & Space(6) & Mid(vMAdd2(1), 1, 25) & Space(25 - Len(Mid(vMAdd2(1), 1, 25))) & Space(6) & Mid(vMAdd2(2), 1, 25) & Space(25 - Len(Mid(vMAdd2(2), 1, 25))))
                    Filewrite.WriteLine(Mid(vMAdd3(0), 1, 25) & Space(25 - Len(Mid(vMAdd3(0), 1, 25))) & Space(6) & Mid(vMAdd3(1), 1, 25) & Space(25 - Len(Mid(vMAdd3(1), 1, 25))) & Space(6) & Mid(vMAdd3(2), 1, 25) & Space(25 - Len(Mid(vMAdd3(2), 1, 25))))
                    Filewrite.WriteLine(Mid(vMCity(0), 1, 25) & Space(25 - Len(Mid(vMCity(0), 1, 25))) & Space(6) & Mid(vMCity(1), 1, 25) & Space(25 - Len(Mid(vMCity(1), 1, 25))) & Space(6) & Mid(vMCity(2), 1, 25) & Space(25 - Len(Mid(vMCity(2), 1, 25))))
                    If CHKPHONENO.Checked = True Then
                        Filewrite.WriteLine(Mid(vMTel(0), 1, 25) & Space(25 - Len(Mid(vMTel(0), 1, 25))) & Space(6) & Mid(vMTel(1), 1, 25) & Space(25 - Len(Mid(vMTel(1), 1, 25))) & Space(6) & Mid(vMTel(2), 1, 25) & Space(25 - Len(Mid(vMTel(2), 1, 25))))
                        prn = prn + 1
                    End If
                    For j = prn To 4
                        Filewrite.WriteLine("")
                    Next
                    For j = 0 To 2
                        vMCode(j) = ""
                        vMName(j) = ""
                        vMAdd1(j) = ""
                        vMAdd2(j) = ""
                        vMAdd3(j) = ""
                        vMCity(j) = ""
                        vMState(j) = ""
                        vMPinCode(j) = ""
                        vMTel(j) = ""
                    Next
                    If i > dt.Rows.Count Then
                        i = dt.Rows.Count
                    Else
                        i = i - 1
                    End If
                Next
            Else
                MsgBox("No Record to View", MsgBoxStyle.Information, MyCompanyName)
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
    Private Sub ChK_Memberstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChK_Memberstatus.SelectedIndexChanged
        Dim Iteration As Integer
        Dim i
        If chk_STATUS.Checked = True Then
            Try
                For i = 0 To (ChK_Memberstatus.Items.Count - 1)
                    'ChK_Memberstatus.SetSelected(i, True)
                    ChK_Memberstatus.SetItemChecked(i, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetItemChecked(i, False)
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

    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid1.InsertRows(ssgrid1.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid1.DeleteRows(ssgrid1.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                .Row = .ActiveRow
                .Col = 1
                If Trim(.Text) <> "" Then
                    ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow + 1)
                End If
            End With
        End If
    End Sub
End Class
