Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMemberCategory
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_CategoryCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_CategoryCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents lbl_CategoryName As System.Windows.Forms.Label
    Friend WithEvents lbl_CategoryCode As System.Windows.Forms.Label
    Friend WithEvents chk_SubscriptionRequired As System.Windows.Forms.CheckBox
    Friend WithEvents txt_CategoryName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtminamt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtminmnth As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RDOYES As System.Windows.Forms.RadioButton
    Friend WithEvents RDONO As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDOCOMBINEDNO As System.Windows.Forms.RadioButton
    Friend WithEvents RDOCOMBINEDYES As System.Windows.Forms.RadioButton
    Friend WithEvents txt_BARAMT As System.Windows.Forms.TextBox
    Friend WithEvents LBL_BAR As System.Windows.Forms.Label
    Friend WithEvents LBL_AMT As System.Windows.Forms.Label
    Friend WithEvents TXT_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents LBL_COMBINED As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_freeze As System.Windows.Forms.CheckBox
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents LBL_CATERING As System.Windows.Forms.Label
    Friend WithEvents TXT_CATERING As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Chk_Permanentyes As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_PermanentNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_VotingNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Votingyes As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_subsNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_subsyes As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_Validity As System.Windows.Forms.TextBox
    Friend WithEvents lblvalidity As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMemberCategory))
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_CategoryCodeHelp = New System.Windows.Forms.Button
        Me.txt_CategoryCode = New System.Windows.Forms.TextBox
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.lbl_CategoryName = New System.Windows.Forms.Label
        Me.lbl_CategoryCode = New System.Windows.Forms.Label
        Me.chk_SubscriptionRequired = New System.Windows.Forms.CheckBox
        Me.txt_CategoryName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.txtminmnth = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtminamt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.RDOYES = New System.Windows.Forms.RadioButton
        Me.RDONO = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LBL_BAR = New System.Windows.Forms.Label
        Me.txt_BARAMT = New System.Windows.Forms.TextBox
        Me.LBL_CATERING = New System.Windows.Forms.Label
        Me.TXT_CATERING = New System.Windows.Forms.TextBox
        Me.RDOCOMBINEDYES = New System.Windows.Forms.RadioButton
        Me.RDOCOMBINEDNO = New System.Windows.Forms.RadioButton
        Me.LBL_COMBINED = New System.Windows.Forms.Label
        Me.LBL_AMT = New System.Windows.Forms.Label
        Me.TXT_AMOUNT = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Grp_Print = New System.Windows.Forms.GroupBox
        Me.Chk_freeze = New System.Windows.Forms.CheckBox
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMD_WINDOWS = New System.Windows.Forms.Button
        Me.CMD_DOS = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblvalidity = New System.Windows.Forms.Label
        Me.Txt_Validity = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Chk_Permanentyes = New System.Windows.Forms.CheckBox
        Me.Chk_PermanentNo = New System.Windows.Forms.CheckBox
        Me.Chk_VotingNo = New System.Windows.Forms.CheckBox
        Me.Chk_Votingyes = New System.Windows.Forms.CheckBox
        Me.Chk_subsNo = New System.Windows.Forms.CheckBox
        Me.Chk_subsyes = New System.Windows.Forms.CheckBox
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Grp_Print.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(400, 344)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 7
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_CategoryCodeHelp
        '
        Me.cmd_CategoryCodeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CategoryCodeHelp.Image = CType(resources.GetObject("cmd_CategoryCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CategoryCodeHelp.Location = New System.Drawing.Point(392, 136)
        Me.cmd_CategoryCodeHelp.Name = "cmd_CategoryCodeHelp"
        Me.cmd_CategoryCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_CategoryCodeHelp.TabIndex = 1
        '
        'txt_CategoryCode
        '
        Me.txt_CategoryCode.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txt_CategoryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CategoryCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CategoryCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CategoryCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_CategoryCode.Location = New System.Drawing.Point(288, 136)
        Me.txt_CategoryCode.MaxLength = 10
        Me.txt_CategoryCode.Name = "txt_CategoryCode"
        Me.txt_CategoryCode.Size = New System.Drawing.Size(104, 21)
        Me.txt_CategoryCode.TabIndex = 0
        Me.txt_CategoryCode.Text = ""
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.Color.Transparent
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Image = CType(resources.GetObject("cmd_ListView.Image"), System.Drawing.Image)
        Me.cmd_ListView.Location = New System.Drawing.Point(160, 344)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 9
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(280, 344)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 6
        Me.cmd_Delete.Text = "Freeze[F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.Color.Transparent
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Image = CType(resources.GetObject("cmd_AddNew.Image"), System.Drawing.Image)
        Me.cmd_AddNew.Location = New System.Drawing.Point(40, 344)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 4
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'lbl_CategoryName
        '
        Me.lbl_CategoryName.AutoSize = True
        Me.lbl_CategoryName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CategoryName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoryName.Location = New System.Drawing.Point(168, 168)
        Me.lbl_CategoryName.Name = "lbl_CategoryName"
        Me.lbl_CategoryName.Size = New System.Drawing.Size(120, 22)
        Me.lbl_CategoryName.TabIndex = 0
        Me.lbl_CategoryName.Text = "Category Name "
        '
        'lbl_CategoryCode
        '
        Me.lbl_CategoryCode.AutoSize = True
        Me.lbl_CategoryCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CategoryCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoryCode.Location = New System.Drawing.Point(168, 136)
        Me.lbl_CategoryCode.Name = "lbl_CategoryCode"
        Me.lbl_CategoryCode.Size = New System.Drawing.Size(116, 22)
        Me.lbl_CategoryCode.TabIndex = 11
        Me.lbl_CategoryCode.Text = "Category Code "
        '
        'chk_SubscriptionRequired
        '
        Me.chk_SubscriptionRequired.BackColor = System.Drawing.Color.Transparent
        Me.chk_SubscriptionRequired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_SubscriptionRequired.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_SubscriptionRequired.Location = New System.Drawing.Point(136, 256)
        Me.chk_SubscriptionRequired.Name = "chk_SubscriptionRequired"
        Me.chk_SubscriptionRequired.Size = New System.Drawing.Size(192, 24)
        Me.chk_SubscriptionRequired.TabIndex = 5
        Me.chk_SubscriptionRequired.Text = "Subscription Required"
        Me.chk_SubscriptionRequired.Visible = False
        '
        'txt_CategoryName
        '
        Me.txt_CategoryName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CategoryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CategoryName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CategoryName.Location = New System.Drawing.Point(288, 168)
        Me.txt_CategoryName.MaxLength = 35
        Me.txt_CategoryName.Name = "txt_CategoryName"
        Me.txt_CategoryName.Size = New System.Drawing.Size(256, 21)
        Me.txt_CategoryName.TabIndex = 2
        Me.txt_CategoryName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(40, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 30)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(288, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 30)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(160, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(400, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 30)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Label9"
        '
        'lbl_Frez
        '
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(168, 248)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(376, 25)
        Me.lbl_Frez.TabIndex = 19
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(880, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Press [F4] For Help"
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(520, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit[F11]"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(528, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 30)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Label2"
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(64, 256)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(496, 232)
        Me.ssgrid.TabIndex = 23
        Me.ssgrid.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ssgrid1)
        Me.GroupBox1.Controls.Add(Me.chk_SubscriptionRequired)
        Me.GroupBox1.Controls.Add(Me.txtminmnth)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(1000, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 216)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'ssgrid1
        '
        Me.ssgrid1.ContainingControl = Me
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(8, 24)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(520, 184)
        Me.ssgrid1.TabIndex = 3
        '
        'txtminmnth
        '
        Me.txtminmnth.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtminmnth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtminmnth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtminmnth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtminmnth.Location = New System.Drawing.Point(432, 264)
        Me.txtminmnth.MaxLength = 35
        Me.txtminmnth.Name = "txtminmnth"
        Me.txtminmnth.Size = New System.Drawing.Size(64, 23)
        Me.txtminmnth.TabIndex = 7
        Me.txtminmnth.Text = ""
        Me.txtminmnth.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(328, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "No.of Month"
        Me.Label5.Visible = False
        '
        'txtminamt
        '
        Me.txtminamt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtminamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtminamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtminamt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtminamt.Location = New System.Drawing.Point(1008, 232)
        Me.txtminamt.MaxLength = 35
        Me.txtminamt.Name = "txtminamt"
        Me.txtminamt.Size = New System.Drawing.Size(64, 21)
        Me.txtminamt.TabIndex = 6
        Me.txtminamt.Text = ""
        Me.txtminamt.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(840, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Press [F3] For Delete Row"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(992, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(8, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Minimum Usage Amount"
        Me.Label4.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(160, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "List View [F8]"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(280, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Freeze[F7]"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(40, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 32)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Add New[F5]"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(400, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 32)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Clear[F6]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(968, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "CREDITLIMIT "
        Me.Label10.Visible = False
        '
        'RDOYES
        '
        Me.RDOYES.BackColor = System.Drawing.Color.Transparent
        Me.RDOYES.Location = New System.Drawing.Point(1064, 416)
        Me.RDOYES.Name = "RDOYES"
        Me.RDOYES.Size = New System.Drawing.Size(152, 24)
        Me.RDOYES.TabIndex = 28
        Me.RDOYES.Text = "YES"
        Me.RDOYES.Visible = False
        '
        'RDONO
        '
        Me.RDONO.BackColor = System.Drawing.Color.Transparent
        Me.RDONO.Location = New System.Drawing.Point(1120, 416)
        Me.RDONO.Name = "RDONO"
        Me.RDONO.Size = New System.Drawing.Size(152, 24)
        Me.RDONO.TabIndex = 29
        Me.RDONO.Text = "NO"
        Me.RDONO.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LBL_BAR)
        Me.GroupBox3.Controls.Add(Me.txt_BARAMT)
        Me.GroupBox3.Controls.Add(Me.LBL_CATERING)
        Me.GroupBox3.Controls.Add(Me.TXT_CATERING)
        Me.GroupBox3.Controls.Add(Me.RDOCOMBINEDYES)
        Me.GroupBox3.Controls.Add(Me.RDOCOMBINEDNO)
        Me.GroupBox3.Controls.Add(Me.LBL_COMBINED)
        Me.GroupBox3.Controls.Add(Me.LBL_AMT)
        Me.GroupBox3.Controls.Add(Me.TXT_AMOUNT)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(1032, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 80)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'LBL_BAR
        '
        Me.LBL_BAR.AutoSize = True
        Me.LBL_BAR.BackColor = System.Drawing.Color.Transparent
        Me.LBL_BAR.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BAR.Location = New System.Drawing.Point(208, 49)
        Me.LBL_BAR.Name = "LBL_BAR"
        Me.LBL_BAR.Size = New System.Drawing.Size(33, 18)
        Me.LBL_BAR.TabIndex = 34
        Me.LBL_BAR.Text = "BAR"
        Me.LBL_BAR.Visible = False
        '
        'txt_BARAMT
        '
        Me.txt_BARAMT.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_BARAMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BARAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BARAMT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BARAMT.Location = New System.Drawing.Point(280, 48)
        Me.txt_BARAMT.MaxLength = 15
        Me.txt_BARAMT.Name = "txt_BARAMT"
        Me.txt_BARAMT.Size = New System.Drawing.Size(72, 21)
        Me.txt_BARAMT.TabIndex = 32
        Me.txt_BARAMT.Text = ""
        Me.txt_BARAMT.Visible = False
        '
        'LBL_CATERING
        '
        Me.LBL_CATERING.AutoSize = True
        Me.LBL_CATERING.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CATERING.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CATERING.Location = New System.Drawing.Point(360, 49)
        Me.LBL_CATERING.Name = "LBL_CATERING"
        Me.LBL_CATERING.Size = New System.Drawing.Size(77, 18)
        Me.LBL_CATERING.TabIndex = 35
        Me.LBL_CATERING.Text = "CATERING"
        Me.LBL_CATERING.Visible = False
        '
        'TXT_CATERING
        '
        Me.TXT_CATERING.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_CATERING.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CATERING.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CATERING.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATERING.Location = New System.Drawing.Point(440, 48)
        Me.TXT_CATERING.MaxLength = 15
        Me.TXT_CATERING.Name = "TXT_CATERING"
        Me.TXT_CATERING.Size = New System.Drawing.Size(80, 21)
        Me.TXT_CATERING.TabIndex = 33
        Me.TXT_CATERING.Text = ""
        Me.TXT_CATERING.Visible = False
        '
        'RDOCOMBINEDYES
        '
        Me.RDOCOMBINEDYES.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDYES.Location = New System.Drawing.Point(104, 46)
        Me.RDOCOMBINEDYES.Name = "RDOCOMBINEDYES"
        Me.RDOCOMBINEDYES.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDYES.TabIndex = 32
        Me.RDOCOMBINEDYES.Text = "YES"
        Me.RDOCOMBINEDYES.Visible = False
        '
        'RDOCOMBINEDNO
        '
        Me.RDOCOMBINEDNO.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDNO.Location = New System.Drawing.Point(160, 46)
        Me.RDOCOMBINEDNO.Name = "RDOCOMBINEDNO"
        Me.RDOCOMBINEDNO.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDNO.TabIndex = 33
        Me.RDOCOMBINEDNO.Text = "NO"
        Me.RDOCOMBINEDNO.Visible = False
        '
        'LBL_COMBINED
        '
        Me.LBL_COMBINED.AutoSize = True
        Me.LBL_COMBINED.BackColor = System.Drawing.Color.Transparent
        Me.LBL_COMBINED.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_COMBINED.Location = New System.Drawing.Point(8, 49)
        Me.LBL_COMBINED.Name = "LBL_COMBINED"
        Me.LBL_COMBINED.Size = New System.Drawing.Size(80, 18)
        Me.LBL_COMBINED.TabIndex = 37
        Me.LBL_COMBINED.Text = "COMBINED"
        Me.LBL_COMBINED.Visible = False
        '
        'LBL_AMT
        '
        Me.LBL_AMT.AutoSize = True
        Me.LBL_AMT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_AMT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AMT.Location = New System.Drawing.Point(208, 19)
        Me.LBL_AMT.Name = "LBL_AMT"
        Me.LBL_AMT.Size = New System.Drawing.Size(66, 18)
        Me.LBL_AMT.TabIndex = 39
        Me.LBL_AMT.Text = "AMOUNT"
        Me.LBL_AMT.Visible = False
        '
        'TXT_AMOUNT
        '
        Me.TXT_AMOUNT.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_AMOUNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_AMOUNT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AMOUNT.Location = New System.Drawing.Point(280, 16)
        Me.TXT_AMOUNT.MaxLength = 15
        Me.TXT_AMOUNT.Name = "TXT_AMOUNT"
        Me.TXT_AMOUNT.Size = New System.Drawing.Size(96, 21)
        Me.TXT_AMOUNT.TabIndex = 38
        Me.TXT_AMOUNT.Text = ""
        Me.TXT_AMOUNT.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(104, 48)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 24)
        Me.RadioButton1.TabIndex = 32
        Me.RadioButton1.Text = "YES"
        Me.RadioButton1.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "COMBINED"
        Me.Label11.Visible = False
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Chk_freeze)
        Me.Grp_Print.Controls.Add(Me.CMDEXIT)
        Me.Grp_Print.Controls.Add(Me.CMD_WINDOWS)
        Me.Grp_Print.Controls.Add(Me.CMD_DOS)
        Me.Grp_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Print.Location = New System.Drawing.Point(128, 272)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(432, 64)
        Me.Grp_Print.TabIndex = 656
        Me.Grp_Print.TabStop = False
        Me.Grp_Print.Visible = False
        '
        'Chk_freeze
        '
        Me.Chk_freeze.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_freeze.Location = New System.Drawing.Point(352, 24)
        Me.Chk_freeze.Name = "Chk_freeze"
        Me.Chk_freeze.Size = New System.Drawing.Size(88, 24)
        Me.Chk_freeze.TabIndex = 3
        Me.Chk_freeze.Text = "Freeze"
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.White
        Me.CMDEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDEXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.White
        Me.CMDEXIT.Image = CType(resources.GetObject("CMDEXIT.Image"), System.Drawing.Image)
        Me.CMDEXIT.Location = New System.Drawing.Point(248, 16)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(96, 32)
        Me.CMDEXIT.TabIndex = 2
        Me.CMDEXIT.Text = "EXIT"
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.BackColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.ForeColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.Image = CType(resources.GetObject("CMD_WINDOWS.Image"), System.Drawing.Image)
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(136, 16)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(96, 32)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        '
        'CMD_DOS
        '
        Me.CMD_DOS.BackColor = System.Drawing.Color.White
        Me.CMD_DOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.ForeColor = System.Drawing.Color.White
        Me.CMD_DOS.Image = CType(resources.GetObject("CMD_DOS.Image"), System.Drawing.Image)
        Me.CMD_DOS.Location = New System.Drawing.Point(24, 16)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(96, 32)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-512, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(180, 21)
        Me.Label12.TabIndex = 657
        Me.Label12.Text = "Permanent Member [Y/N]"
        Me.Label12.Visible = False
        '
        'lblvalidity
        '
        Me.lblvalidity.AutoSize = True
        Me.lblvalidity.BackColor = System.Drawing.Color.Transparent
        Me.lblvalidity.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalidity.Location = New System.Drawing.Point(488, -88)
        Me.lblvalidity.Name = "lblvalidity"
        Me.lblvalidity.Size = New System.Drawing.Size(55, 21)
        Me.lblvalidity.TabIndex = 660
        Me.lblvalidity.Text = "Valitity"
        Me.lblvalidity.Visible = False
        '
        'Txt_Validity
        '
        Me.Txt_Validity.BackColor = System.Drawing.Color.White
        Me.Txt_Validity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Validity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Validity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Validity.Location = New System.Drawing.Point(552, -96)
        Me.Txt_Validity.MaxLength = 1
        Me.Txt_Validity.Name = "Txt_Validity"
        Me.Txt_Validity.Size = New System.Drawing.Size(40, 21)
        Me.Txt_Validity.TabIndex = 661
        Me.Txt_Validity.Text = ""
        Me.Txt_Validity.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-512, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 21)
        Me.Label14.TabIndex = 662
        Me.Label14.Text = "Voting Rights[Y/N]"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-416, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(192, 21)
        Me.Label15.TabIndex = 665
        Me.Label15.Text = "Subscription Required[Y/N]"
        Me.Label15.Visible = False
        '
        'Chk_Permanentyes
        '
        Me.Chk_Permanentyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Permanentyes.Location = New System.Drawing.Point(600, -40)
        Me.Chk_Permanentyes.Name = "Chk_Permanentyes"
        Me.Chk_Permanentyes.Size = New System.Drawing.Size(56, 33)
        Me.Chk_Permanentyes.TabIndex = 668
        Me.Chk_Permanentyes.Text = "Yes"
        Me.Chk_Permanentyes.Visible = False
        '
        'Chk_PermanentNo
        '
        Me.Chk_PermanentNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PermanentNo.Location = New System.Drawing.Point(600, -80)
        Me.Chk_PermanentNo.Name = "Chk_PermanentNo"
        Me.Chk_PermanentNo.Size = New System.Drawing.Size(48, 33)
        Me.Chk_PermanentNo.TabIndex = 669
        Me.Chk_PermanentNo.Text = "No"
        Me.Chk_PermanentNo.Visible = False
        '
        'Chk_VotingNo
        '
        Me.Chk_VotingNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_VotingNo.Location = New System.Drawing.Point(-464, 0)
        Me.Chk_VotingNo.Name = "Chk_VotingNo"
        Me.Chk_VotingNo.Size = New System.Drawing.Size(57, 24)
        Me.Chk_VotingNo.TabIndex = 671
        Me.Chk_VotingNo.Text = "No"
        Me.Chk_VotingNo.Visible = False
        '
        'Chk_Votingyes
        '
        Me.Chk_Votingyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Votingyes.Location = New System.Drawing.Point(-528, 0)
        Me.Chk_Votingyes.Name = "Chk_Votingyes"
        Me.Chk_Votingyes.Size = New System.Drawing.Size(65, 24)
        Me.Chk_Votingyes.TabIndex = 670
        Me.Chk_Votingyes.Text = "Yes"
        Me.Chk_Votingyes.Visible = False
        '
        'Chk_subsNo
        '
        Me.Chk_subsNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_subsNo.Location = New System.Drawing.Point(-528, 0)
        Me.Chk_subsNo.Name = "Chk_subsNo"
        Me.Chk_subsNo.Size = New System.Drawing.Size(57, 24)
        Me.Chk_subsNo.TabIndex = 673
        Me.Chk_subsNo.Text = "No"
        Me.Chk_subsNo.Visible = False
        '
        'Chk_subsyes
        '
        Me.Chk_subsyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_subsyes.Location = New System.Drawing.Point(-592, 0)
        Me.Chk_subsyes.Name = "Chk_subsyes"
        Me.Chk_subsyes.Size = New System.Drawing.Size(65, 24)
        Me.Chk_subsyes.TabIndex = 672
        Me.Chk_subsyes.Text = "Yes"
        Me.Chk_subsyes.Visible = False
        '
        'frmMemberCategory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(664, 454)
        Me.Controls.Add(Me.Chk_subsNo)
        Me.Controls.Add(Me.Chk_subsyes)
        Me.Controls.Add(Me.Chk_VotingNo)
        Me.Controls.Add(Me.Chk_Votingyes)
        Me.Controls.Add(Me.Chk_PermanentNo)
        Me.Controls.Add(Me.Chk_Permanentyes)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txt_Validity)
        Me.Controls.Add(Me.lblvalidity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_CategoryCode)
        Me.Controls.Add(Me.lbl_CategoryName)
        Me.Controls.Add(Me.lbl_CategoryCode)
        Me.Controls.Add(Me.txt_CategoryName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtminamt)
        Me.Controls.Add(Me.Grp_Print)
        Me.Controls.Add(Me.RDONO)
        Me.Controls.Add(Me.RDOYES)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_CategoryCodeHelp)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORY MASTER"
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Grp_Print.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim SqlString, strVotingright, strSubscription, boolopt As String
    Dim boolchk As Boolean
    Dim status As String
    Dim gconnection As New GlobalClass
    Dim loopindex As Long
    Dim accode, ACCDESC As String
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Dim subcode, subdesc As String
        'TXT_AMOUNT.Text = 0
        Try
            If cmd_AddNew.Text = "Add New[F5]" Then
                Call checkValidation()
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO MEMBERTYPE"
                SqlString = SqlString & "(Membertype,TypeDesc,Validity,AddUserId,AddDatetime,Freeze,creditlimit,minusage,nomon) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                SqlString = SqlString & txt_CategoryName.Text & "','" & Trim(Txt_Validity.Text) & "'  , '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & Trim(TXT_AMOUNT.Text) & "'," & IIf(txtminamt.Text = "", 0, txtminamt.Text) & "," & IIf(txtminmnth.Text = "", 0, txtminmnth.Text) & ")"
                gconnection.closeConnection()
                gconnection.dataOperation(1, SqlString, "MemberType")
                If Chk_Permanentyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET permanent = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    'gconnection.closeConnection()
                ElseIf Chk_Votingyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET VotingRight = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    'gconnection.closeConnection()
                ElseIf Chk_subsyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET SubscriptionRequired = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    'gconnection.closeConnection()
                ElseIf Chk_PermanentNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET permanent = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    'gconnection.closeConnection()
                ElseIf Chk_VotingNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET VotingRight = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    'gconnection.closeConnection()
                ElseIf Chk_subsNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET SubscriptionRequired = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                'For loopindex = 1 To ssgrid1.DataRowCnt
                '    subcode = Nothing
                '    subdesc = Nothing
                '    ssgrid1.GetText(1, loopindex, subcode)
                '    ssgrid1.GetText(2, loopindex, subdesc)
                '    SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(txt_CategoryCode.Text & "") & "',"
                '    SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                '    gconnection.dataOperation(1, SqlString, "MemberType")
                'Next loopindex
                MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                    Call checkValidation()
                    If Mid(Me.cmd_AddNew.Text, 1, 1) = "U" Then
                        If Me.lbl_Frez.Visible = True Then
                            MsgBox(" The Frezzed Record Can Not Be Update", , gCompanyname)
                            boolchk = False
                        End If
                    End If
                    If boolchk = False Then Exit Sub
                    SqlString = "UPDATE  MemberType SET TYPEDESC = '"
                    SqlString = SqlString & txt_CategoryName.Text & "'"
                    SqlString = SqlString & ",Validity = '" & Txt_Validity.Text
                SqlString = SqlString & "',ADDUSERID ='" & gUsername
                    SqlString = SqlString & "',minusage ='" & txtminamt.Text
                    SqlString = SqlString & "',creditlimit ='" & TXT_AMOUNT.Text
                    SqlString = SqlString & "',nomon ='" & txtminmnth.Text
                    SqlString = SqlString & "',ADDDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',FREEZE = 'N'"
                    SqlString = SqlString & " WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                gconnection.closeConnection()

                If Chk_Permanentyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET permanent = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_Votingyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET VotingRight = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If

                If Chk_subsyes.Checked = True Then
                    SqlString = " UPDATE  MemberType SET SubscriptionRequired = 'Y' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_PermanentNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET permanent = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_VotingNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET VotingRight = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_subsNo.Checked = True Then
                    SqlString = " UPDATE  MemberType SET SubscriptionRequired = 'N' WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                'SqlString = "Delete from MemberTypeDtl where MemberType ='" & Trim(txt_CategoryCode.Text & "") & "'"
                'gconnection.dataOperation(1, SqlString, "MemberType")
                'gconnection.closeConnection()
                'ssgrid1.SetActiveCell(1, 1)
                'For loopindex = 1 To ssgrid1.DataRowCnt
                '    subcode = Nothing
                '    subdesc = Nothing
                '    ssgrid1.GetText(1, loopindex, subcode)
                '    ssgrid1.GetText(2, loopindex, subdesc)
                '    SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(txt_CategoryCode.Text & "") & "',"
                '    SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                '    gconnection.dataOperation(1, SqlString, "MemberType")
                '    gconnection.closeConnection()
                'Next loopindex
                'gconnection.closeConnection()

                MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
                End If
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing records : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'clearform(Me)
            Me.cmd_Clear_Click(sender, e)
        Finally
            'clearform(Me)
            Me.cmd_Clear_Click(sender, e)
        End Try
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Grp_Print.Visible = True
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Delete.Text, 1, 1) = "F" Then
            SqlString = "UPDATE  MemberType "
            SqlString = SqlString & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE membertype = '" & txt_CategoryCode.Text & " '"
            gconnection.dataOperation(3, SqlString, "MemberType")

            SqlString = "UPDATE  MemberTypedtl "
            SqlString = SqlString & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, SqlString, "MemberType")
            gconnection.closeConnection()
            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        Else
            SqlString = "UPDATE  MemberType "
            SqlString = SqlString & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE membertype = '" & txt_CategoryCode.Text & " '"
            gconnection.dataOperation(4, SqlString, "MemberType")

            SqlString = "UPDATE  MemberTypedtl "
            SqlString = SqlString & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, SqlString, "MemberType")
            gconnection.closeConnection()
            MessageBox.Show("Record UNFreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        End If
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        chk_SubscriptionRequired.Checked = False
        Me.txt_CategoryCode.Enabled = True
        Me.txt_CategoryCode.Focus()
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Me.cmd_AddNew.Text = "Add New[F5]"
        Me.cmd_Delete.Text = "Freeze[F7]"
        txtminamt.Text = ""
        txtminmnth.Text = ""
        TXT_AMOUNT.Text = ""

    End Sub
    Private Sub txt_CategoryCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CategoryCode.KeyPress
        getAlphanumeric(e)
    End Sub
    Private Sub txt_CategoryCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CategoryCode.KeyDown
        'cmd_AddNew.Text = "Update[F5]"
        If e.KeyCode = Keys.Enter Then
            If txt_CategoryCode.Text = "" Then
                Call cmd_CategoryCodeHelp_Click(sender, e)
            Else
                txt_CategoryName.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_CategoryCodeHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_CategoryName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CategoryName.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    'chk_VotingRights.Focus()
        '    With ssgrid1
        '        .Focus()
        '        .Row = 1
        '        .Col = 1
        '        .SetActiveCell(1, 1)
        '    End With
        'End If
    End Sub
    Private Sub txt_CategoryName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CategoryName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 33 To 45
                e.Handled = True
            Case 58 To 64
                e.Handled = True
            Case 91 To 96
                e.Handled = True
            Case 123 To 135
                e.Handled = True
        End Select
        If Asc(e.KeyChar) = Keys.Enter Then
            With ssgrid1
                .Focus()
                .Row = 1
                .Col = 1
                .SetActiveCell(1, 1)
            End With
        End If
    End Sub
    Private Sub chk_SubscriptionRequired_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_SubscriptionRequired.GotFocus
        '        chk_SubscriptionRequired.BackColor = Color.Cyan
    End Sub
    Private Sub chk_SubscriptionRequired_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_SubscriptionRequired.LostFocus
        If chk_SubscriptionRequired.Checked = False Then
            chk_SubscriptionRequired.BackColor = Color.Silver
        End If
    End Sub
    Private Sub chk_SubscriptionRequired_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_SubscriptionRequired.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtminamt.Focus()
        End If
    End Sub
    Private Sub frmMemberCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try


            ' if !char.IsLetterOrDigit(e.keychar))&&(e.keychar==(char)Keys.Back)




            If e.KeyCode = Keys.F5 Then
                If cmd_AddNew.Enabled = True Then
                    Call cmd_AddNew_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If cmd_Clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If cmd_ListView.Enabled = True Then
                    Call cmd_ListView_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F7 Then
                If cmd_Delete.Enabled = True Then
                    Call cmd_Delete_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Button1.Enabled = True Then
                    Call Button1_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmd_CategoryCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CategoryCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select Membertype ,TypeDesc  from Membertype"
        M_WhereCondition = " "
        vform.Field = "Membertype,TypeDesc "
        vform.vFormatstring = "  Category Code  | Category Name                            "
        vform.vCaption = "Category Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_CategoryCode.Text = Trim(vform.keyfield & "")
            txt_CategoryCode.Select()
            Me.txt_CategoryCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_AddNew.Text = "Update[F5]"
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********* Checked the status for votingright and also SubscriptionRequired
        '''********** Check Category Code is blank
        If txt_CategoryCode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_CategoryCode.Focus()
            Exit Sub
        End If
        '''********** Check Category Name is blank
        If txt_CategoryName.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_CategoryName.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub txt_CategoryCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CategoryCode.Validated
        Dim MEMBERTYPE As New DataTable
        Dim subsmast As New DataTable
        Dim CATEGORYDETAILS As New DataTable
        Dim SUBSCRIPTIONMASTER As New DataTable
        Dim C1 As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        SQL1 = "SELECT * FROM CATEGORYDETAILS"
        C1 = gconnection.GetValues(SQL1)
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc,isnull(Validity,'')as Validity,isnull(minacctin,'') as minacct,isnull(acctdesc,'') as acdesc,isnull(minusage,0) as minamount,isnull(nomon,0) as noofmonth,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Freeze,'') as Freeze,isnull(votingright,'') as votingright,isnull(Creditlimit,'') as Creditlimit  From MemberType Where MemberType='" & Me.txt_CategoryCode.Text & "'"
        MEMBERTYPE = gconnection.GetValues(ssql)
        If MEMBERTYPE.Rows.Count > 0 Then
            accode = MEMBERTYPE.Rows(0).Item("minacct")
            txtminamt.Text = MEMBERTYPE.Rows(0).Item("minamount")
            txtminmnth.Text = MEMBERTYPE.Rows(0).Item("noofmonth")
            TXT_AMOUNT.Text = MEMBERTYPE.Rows(0).Item("Creditlimit")
            Txt_Validity.Text = MEMBERTYPE.Rows(0).Item("Validity")

            Me.txt_CategoryCode.Enabled = False
            Me.txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("TypeDesc")
            If MEMBERTYPE.Rows(0).Item("SubscriptionRequired") = "Y" Then
                Me.chk_SubscriptionRequired.Checked = True
                Me.chk_SubscriptionRequired.BackColor = Color.Cyan
            Else
                Me.chk_SubscriptionRequired.Checked = False
                Me.chk_SubscriptionRequired.BackColor = Color.Silver
            End If
            If MEMBERTYPE.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(MEMBERTYPE.Rows(0).Item("AddDateTime"), "dd-MMM-yyyy")
                Me.cmd_Delete.Text = "UnFreeze[F7]"
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Freezed  On "
                Me.cmd_Delete.Text = "Freeze[F7]"
            End If
            Me.cmd_AddNew.Text = "Update[F5]"
        Else
            Me.txt_CategoryCode.Enabled = True
            Me.txt_CategoryName.Text = ""
            Me.chk_SubscriptionRequired.Checked = False
            Me.lbl_Frez.Visible = False
            Me.lbl_Frez.Text = "Record Freezed  On "
            Me.cmd_AddNew.Text = "Add New[F5]"
        End If
        gconnection.closeConnection()
        ssql = "Select MembertypeDtl.SubsCode,Subsdesc from MembertypeDtl inner join SubscriptionMast on SubscriptionMast.subscode=MembertypeDtl.subscode where membertype = '" & Trim(Me.txt_CategoryCode.Text & "") & "' and isnull(SubscriptionMast.Freeze,'') <> 'Y'"
        subsmast = gconnection.GetValues(ssql)
        If subsmast.Rows.Count > 0 Then
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            With ssgrid1
                .Col = 1
                .Row = 1
                .SetActiveCell(1, 1)
            End With
            For I = 0 To subsmast.Rows.Count - 1
                With ssgrid1
                    .SetText(1, (I + 1), subsmast.Rows(I).Item("subscode"))
                    .SetText(2, (I + 1), subsmast.Rows(I).Item("subsdesc"))
                End With
            Next I
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim SoundInst As New SoundClass
        'SoundInst.PlaySoundFile("C:\windows\media\ringout.wav")
        ''End Sub
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    txt_CategoryCode.Focus()
        'End If
        ' Me.Close()
        'MdiParent.Menu.MenuItems(0).MenuItems(0).Enabled = True
    End Sub
    Private Sub frmMemberCategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 163 Then
            e.Handled = True
        End If
    End Sub
    Private Sub chk_SubscriptionRequired_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SubscriptionRequired.CheckedChanged
        If chk_SubscriptionRequired.Checked = True Then
        ElseIf chk_SubscriptionRequired.Checked = False Then
        End If
    End Sub
    Private Sub frmMemberCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        categorybool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        lblvalidity.Visible = False
        Txt_Validity.Visible = False

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
        Me.cmd_AddNew.Enabled = False
        Me.cmd_Delete.Enabled = False
        Me.cmd_ListView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_AddNew.Enabled = True
                    Me.cmd_Delete.Enabled = True
                    Me.cmd_ListView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_AddNew.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_ListView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub frmMemberCategory_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        categorybool = False
    End Sub
    Private Sub SubsciptionList()
        Dim vform As New ListOperation
        gSQLString = "Select SubsCode,SubsDesc from SubscriptionMast "
        M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'"
        '        gSQLString = "Select SubsCode,SubsDesc from VW_SUBSCRIPTIONMAST "
        '        M_WhereCondition = ""
        vform.Field = "subscode,subsdesc"
        'vform.Field = "Subscription Code                           |  Subscription Desc                                                           "
        vform.vFormatstring = "  Subs Code                 | Subscription Name                             |"
        vform.vCaption = "Subscription List"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        'vform.KeyPos2 = 2
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .SetText(1, .ActiveRow, Trim(vform.keyfield & ""))
                .SetText(2, .ActiveRow, Trim(vform.keyfield1 & ""))
                .SetActiveCell(1, ssgrid1.ActiveRow + 1)
            End With
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub SUBSCRIPTION_VALID()
        Dim scode, sname, ssql As String
        Try
            With ssgrid1
                '.SetActiveCell(1, 1)
                .Col = 1
                .Row = .ActiveRow
                scode = ""
                scode = Trim(.Text)
                If scode <> "" Then
                    ssql = "Select SubsCode,SubsDesc from SubscriptionMast where subscode='" & scode & "'"
                    gconnection.getDataSet(ssql, "SUB")
                    If gdataset.Tables("SUB").Rows.Count > 0 Then
                        .Col = 1
                        .Row = .ActiveRow
                        .Text = gdataset.Tables("SUB").Rows(0).Item("SubsCode")
                        .Col = 2
                        .Row = .ActiveRow
                        .Text = gdataset.Tables("SUB").Rows(0).Item("SubsDesc")
                        .SetActiveCell(1, .ActiveRow + 1)
                    Else
                        .Col = 1
                        .Row = .ActiveRow
                        .Text = ""
                        .Col = 2
                        .Row = .ActiveRow
                        .Text = ""
                        .SetActiveCell(1, .ActiveRow)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        Try
            If e.keyCode = Keys.F4 Then
                Call SubsciptionList()
            End If
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
                        SUBSCRIPTION_VALID()
                        'ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow + 1)
                    Else
                        Call SubsciptionList()
                    End If

                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ssgrid1_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid1.LeaveCell
        'With ssgrid1
        '    If .ActiveCol.ToString <> "" Then
        '        .Row = .ActiveRow + 1
        '    End If
        'End With
        SUBSCRIPTION_VALID()
    End Sub

    Private Sub txtacctdesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance
    End Sub



    Private Sub txt_CategoryCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CategoryCode.TextChanged

    End Sub
    Private Sub ssgrid1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid1.LostFocus


    End Sub

    Private Sub ssgrid1_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles ssgrid1.KeyPressEvent

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtminamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtminamt.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_CategoryName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CategoryName.TextChanged

    End Sub

    Private Sub lbl_CategoryName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CategoryName.Click

    End Sub

    Private Sub lbl_CategoryCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CategoryCode.Click

    End Sub

    Private Sub lbl_Caption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RDOYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOYES.CheckedChanged

    End Sub

    Private Sub RDONO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDONO.CheckedChanged
        LBL_AMT.Visible = False
        TXT_AMOUNT.Visible = False
    End Sub

    Private Sub cmd_AddNewCBM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim subcode, subdesc As String
        Try
            If cmd_AddNew.Text = "Add New[F5]" Then
                Call checkValidation()
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO MEMBERTYPE"
                SqlString = SqlString & "(MTORDERNO,MINACCTIN,) VALUES ('" & txt_BARAMT.Text & " ' , '"
                SqlString = SqlString & TXT_CATERING.Text & "')"
                gconnection.closeConnection()
                gconnection.dataOperation(1, SqlString, "MemberType")
                MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                Call checkValidation()
                If Mid(Me.cmd_AddNew.Text, 1, 1) = "U" Then
                    If Me.lbl_Frez.Visible = True Then
                        MsgBox(" The Frezzed Record Can Not Be Update", , gCompanyname)
                        boolchk = False
                    End If
                End If
                If boolchk = False Then Exit Sub
                SqlString = "UPDATE  MemberType SET MTORDERNO = '"
                SqlString = SqlString & txt_BARAMT.Text & "'"
                SqlString = SqlString & ",MINACCTIN = '" & TXT_CATERING.Text & "'"
                SqlString = SqlString & " WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                gconnection.dataOperation(2, SqlString, "membertype")
                gconnection.closeConnection()
                MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing records : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmd_Clear_Click(sender, e)
        Finally
            Me.cmd_Clear_Click(sender, e)
        End Try
    End Sub

    Private Sub RDOCOMBINEDNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.CheckedChanged
        'RDOCOMBINEDYES.Checked = False
        'LBL_BAR.Visible = True
        'txt_BARAMT.Visible = True
        'LBL_AMT.Visible = False
        'TXT_AMOUNT.Visible = False
    End Sub

    Private Sub BTNCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.Grp_credit.Visible = False
    End Sub

    Private Sub RDOCOMBINEDYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.CheckedChanged
        LBL_AMT.Visible = True
        TXT_AMOUNT.Visible = True
        ' RDOCOMBINEDYES.Checked = True
    End Sub


    Private Sub RDOYES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOYES.Click
        'LBL_AMT.Visible = True
        'TXT_AMOUNT.Visible = True
        LBL_COMBINED.Visible = True
        RDOCOMBINEDYES.Visible = True
        RDOCOMBINEDNO.Visible = True
    End Sub

    Private Sub RDONO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDONO.Click

    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_DOS.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM MEMBERTYPE"
        Gheader = "MEMBER CATEGORY MASTER"
        FrReport.SsGridReport.SetText(2, 1, "Membertype")
        'FrReport.SsGridReport.SetText(2, 1, "Category")
        FrReport.SsGridReport.SetText(3, 1, 20)
        FrReport.SsGridReport.SetText(2, 2, "TypeDesc")
        'FrReport.SsGridReport.SetText(2, 2, "Category Name")
        FrReport.SsGridReport.SetText(3, 2, 30)
        'FrReport.SsGridReport.SetText(2, 3, "VotingRight")
        'FrReport.SsGridReport.SetText(3, 3, 12)
        'FrReport.SsGridReport.SetText(2, 4, "SubscriptionRequired")
        'FrReport.SsGridReport.SetText(3, 4, 20)
        'FrReport.SsGridReport.SetText(2, 3, "MinUsage")
        'FrReport.SsGridReport.SetText(3, 3, 8)
        FrReport.SsGridReport.SetText(2, 3, "freeze")
        FrReport.SsGridReport.SetText(3, 3, 6)
        FrReport.Show()
    End Sub

    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New ReportViwer
        Dim r As New Cry_categorymaster
        If Chk_freeze.Checked = True Then
            SqlString = "select * from membertype where freeze='Y'"
        Else
            SqlString = "select * from membertype where freeze='N'"
        End If
        Call Viewer.GetDetails1(SqlString, "MM_CATEGORYMASTER", r)
        txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        txtobj1.Text = UCase(gCompanyname)
        txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        txtobj1.Text = UCase(gCompanyAddress(1))
        txtobj1 = r.ReportDefinition.ReportObjects("Text9")
        txtobj1.Text = UCase(gCompanyAddress(2))
        txtobj1 = r.ReportDefinition.ReportObjects("Text8")
        txtobj1.Text = UCase(gCompanyAddress(3))
        txtobj1 = r.ReportDefinition.ReportObjects("Text13")
        txtobj1.Text = UCase(gUsername)
        Viewer.Show()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Grp_Print.Visible = False

        'Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub RDOCOMBINEDYES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.Click
        LBL_BAR.Visible = False
        txt_BARAMT.Visible = False
        LBL_CATERING.Visible = False
        TXT_CATERING.Visible = False
        LBL_AMT.Visible = True
        TXT_AMOUNT.Visible = True
    End Sub

    Private Sub RDOCOMBINEDNO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.Click
        LBL_BAR.Visible = True
        txt_BARAMT.Visible = True
        LBL_CATERING.Visible = True
        TXT_CATERING.Visible = True
        LBL_AMT.Visible = False
        TXT_AMOUNT.Visible = False
    End Sub

    Private Sub lbl_Frez_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Frez.Click

    End Sub

    Private Sub Chk_PermanentNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PermanentNo.CheckedChanged
        lblvalidity.Visible = True
        Txt_Validity.Visible = True
    End Sub

    Private Sub Chk_Permanentyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Permanentyes.CheckedChanged
        lblvalidity.Visible = False
        Txt_Validity.Visible = False
        Txt_Validity.Text = ""

    End Sub

    Private Sub Chk_Votingyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Votingyes.CheckedChanged

    End Sub

    Private Sub frmMemberCategory_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move

    End Sub

    Private Sub frmMemberCategory_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

    End Sub

    Private Sub frmMemberCategory_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged
        Me.Location = New Point(180, 120)
    End Sub
End Class

