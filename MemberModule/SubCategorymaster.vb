Imports CrystalDecisions.CrystalReports.Engine
Public Class SubCategorymaster
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
    'Friend WithEvents reason As System.Windows.Forms.TextBox
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtminmnth As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents Txt_subcategorycode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_SubCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Validity As System.Windows.Forms.TextBox
    Friend WithEvents lblvalidity As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Chk_PermanentNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Permanentyes As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Chk_VotingNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Votingyes As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Chk_subsNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_subsyes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Cbo_ClubAccount As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_SubCategoryCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Chk_corporateno As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_corportateyes As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Chk_tenuresNo As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Tenuresyes As System.Windows.Forms.CheckBox
    Friend WithEvents lblmonth As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Select_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents REASON As System.Windows.Forms.TextBox
    Friend WithEvents chk_RDOYES As System.Windows.Forms.CheckBox
    Friend WithEvents chk_RDONO As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_creditlimityes As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_creditlimitno As System.Windows.Forms.CheckBox


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubCategorymaster))
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtminamt = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Chk_creditlimitno = New System.Windows.Forms.CheckBox
        Me.Chk_creditlimityes = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
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
        Me.REASON = New System.Windows.Forms.TextBox
        Me.Grp_Print = New System.Windows.Forms.GroupBox
        Me.Chk_freeze = New System.Windows.Forms.CheckBox
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMD_WINDOWS = New System.Windows.Forms.Button
        Me.CMD_DOS = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txt_subcategorycode = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_SubCategoryName = New System.Windows.Forms.TextBox
        Me.Txt_Validity = New System.Windows.Forms.TextBox
        Me.lblvalidity = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Chk_PermanentNo = New System.Windows.Forms.CheckBox
        Me.Chk_Permanentyes = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Chk_VotingNo = New System.Windows.Forms.CheckBox
        Me.Chk_Votingyes = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Chk_subsNo = New System.Windows.Forms.CheckBox
        Me.Chk_subsyes = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Cbo_ClubAccount = New System.Windows.Forms.ComboBox
        Me.cmd_SubCategoryCodeHelp = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Chk_corporateno = New System.Windows.Forms.CheckBox
        Me.Chk_corportateyes = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Chk_tenuresNo = New System.Windows.Forms.CheckBox
        Me.Chk_Tenuresyes = New System.Windows.Forms.CheckBox
        Me.lblmonth = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Select_Category = New System.Windows.Forms.CheckedListBox
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
        Me.cmd_Clear.Location = New System.Drawing.Point(576, 608)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 7
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_CategoryCodeHelp
        '
        Me.cmd_CategoryCodeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CategoryCodeHelp.Image = CType(resources.GetObject("cmd_CategoryCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CategoryCodeHelp.Location = New System.Drawing.Point(328, 128)
        Me.cmd_CategoryCodeHelp.Name = "cmd_CategoryCodeHelp"
        Me.cmd_CategoryCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_CategoryCodeHelp.TabIndex = 1
        Me.cmd_CategoryCodeHelp.Visible = False
        '
        'txt_CategoryCode
        '
        Me.txt_CategoryCode.BackColor = System.Drawing.Color.White
        Me.txt_CategoryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CategoryCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CategoryCode.Enabled = False
        Me.txt_CategoryCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CategoryCode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_CategoryCode.Location = New System.Drawing.Point(208, 128)
        Me.txt_CategoryCode.MaxLength = 10
        Me.txt_CategoryCode.Name = "txt_CategoryCode"
        Me.txt_CategoryCode.Size = New System.Drawing.Size(120, 21)
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
        Me.cmd_ListView.Location = New System.Drawing.Point(328, 608)
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
        Me.cmd_Delete.Location = New System.Drawing.Point(456, 608)
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
        Me.cmd_AddNew.Location = New System.Drawing.Point(200, 608)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 4
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'lbl_CategoryName
        '
        Me.lbl_CategoryName.AutoSize = True
        Me.lbl_CategoryName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CategoryName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoryName.Location = New System.Drawing.Point(368, 128)
        Me.lbl_CategoryName.Name = "lbl_CategoryName"
        Me.lbl_CategoryName.Size = New System.Drawing.Size(113, 21)
        Me.lbl_CategoryName.TabIndex = 0
        Me.lbl_CategoryName.Text = "Category Name "
        '
        'lbl_CategoryCode
        '
        Me.lbl_CategoryCode.AutoSize = True
        Me.lbl_CategoryCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CategoryCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CategoryCode.Location = New System.Drawing.Point(56, 128)
        Me.lbl_CategoryCode.Name = "lbl_CategoryCode"
        Me.lbl_CategoryCode.Size = New System.Drawing.Size(108, 21)
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
        Me.txt_CategoryName.BackColor = System.Drawing.Color.White
        Me.txt_CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CategoryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CategoryName.Enabled = False
        Me.txt_CategoryName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CategoryName.Location = New System.Drawing.Point(512, 128)
        Me.txt_CategoryName.MaxLength = 35
        Me.txt_CategoryName.Name = "txt_CategoryName"
        Me.txt_CategoryName.Size = New System.Drawing.Size(176, 21)
        Me.txt_CategoryName.TabIndex = 2
        Me.txt_CategoryName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(200, 608)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 30)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(464, 608)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 30)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(328, 608)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 30)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(576, 608)
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
        Me.lbl_Frez.Location = New System.Drawing.Point(296, 560)
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
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Press [F4] For Help"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(696, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit[F11]"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(704, 608)
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
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 192)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'ssgrid1
        '
        Me.ssgrid1.ContainingControl = Me
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(24, 40)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(480, 136)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(360, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Press [F3] For Delete Row"
        '
        'txtminamt
        '
        Me.txtminamt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtminamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtminamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtminamt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtminamt.Location = New System.Drawing.Point(1016, 232)
        Me.txtminamt.MaxLength = 35
        Me.txtminamt.Name = "txtminamt"
        Me.txtminamt.Size = New System.Drawing.Size(64, 21)
        Me.txtminamt.TabIndex = 6
        Me.txtminamt.Text = ""
        Me.txtminamt.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(328, 608)
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
        Me.Button3.Location = New System.Drawing.Point(456, 608)
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
        Me.Button4.Location = New System.Drawing.Point(200, 608)
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
        Me.Button5.Location = New System.Drawing.Point(576, 608)
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
        Me.Label10.Location = New System.Drawing.Point(200, 512)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "CREDITLIMIT "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Chk_creditlimitno)
        Me.GroupBox3.Controls.Add(Me.Chk_creditlimityes)
        Me.GroupBox3.Controls.Add(Me.Label21)
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
        Me.GroupBox3.Location = New System.Drawing.Point(112, 504)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(544, 32)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'Chk_creditlimitno
        '
        Me.Chk_creditlimitno.BackColor = System.Drawing.Color.Transparent
        Me.Chk_creditlimitno.Location = New System.Drawing.Point(256, 4)
        Me.Chk_creditlimitno.Name = "Chk_creditlimitno"
        Me.Chk_creditlimitno.Size = New System.Drawing.Size(44, 24)
        Me.Chk_creditlimitno.TabIndex = 689
        Me.Chk_creditlimitno.Text = "No"
        '
        'Chk_creditlimityes
        '
        Me.Chk_creditlimityes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_creditlimityes.Location = New System.Drawing.Point(200, 4)
        Me.Chk_creditlimityes.Name = "Chk_creditlimityes"
        Me.Chk_creditlimityes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_creditlimityes.TabIndex = 688
        Me.Chk_creditlimityes.Text = "Yes"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(-216, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 23)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "REMARK"
        Me.Label21.UseMnemonic = False
        Me.Label21.Visible = False
        '
        'LBL_BAR
        '
        Me.LBL_BAR.AutoSize = True
        Me.LBL_BAR.BackColor = System.Drawing.Color.Transparent
        Me.LBL_BAR.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BAR.Location = New System.Drawing.Point(240, 49)
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
        Me.txt_BARAMT.Location = New System.Drawing.Point(312, 48)
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
        Me.LBL_CATERING.Location = New System.Drawing.Point(392, 49)
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
        Me.TXT_CATERING.Location = New System.Drawing.Point(472, 48)
        Me.TXT_CATERING.MaxLength = 15
        Me.TXT_CATERING.Name = "TXT_CATERING"
        Me.TXT_CATERING.Size = New System.Drawing.Size(64, 21)
        Me.TXT_CATERING.TabIndex = 33
        Me.TXT_CATERING.Text = ""
        Me.TXT_CATERING.Visible = False
        '
        'RDOCOMBINEDYES
        '
        Me.RDOCOMBINEDYES.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDYES.Location = New System.Drawing.Point(112, 46)
        Me.RDOCOMBINEDYES.Name = "RDOCOMBINEDYES"
        Me.RDOCOMBINEDYES.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDYES.TabIndex = 32
        Me.RDOCOMBINEDYES.Text = "YES"
        Me.RDOCOMBINEDYES.Visible = False
        '
        'RDOCOMBINEDNO
        '
        Me.RDOCOMBINEDNO.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDNO.Location = New System.Drawing.Point(168, 46)
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
        Me.LBL_AMT.Location = New System.Drawing.Point(320, 8)
        Me.LBL_AMT.Name = "LBL_AMT"
        Me.LBL_AMT.Size = New System.Drawing.Size(66, 18)
        Me.LBL_AMT.TabIndex = 39
        Me.LBL_AMT.Text = "AMOUNT"
        '
        'TXT_AMOUNT
        '
        Me.TXT_AMOUNT.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_AMOUNT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_AMOUNT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AMOUNT.Location = New System.Drawing.Point(400, 8)
        Me.TXT_AMOUNT.MaxLength = 15
        Me.TXT_AMOUNT.Name = "TXT_AMOUNT"
        Me.TXT_AMOUNT.Size = New System.Drawing.Size(72, 21)
        Me.TXT_AMOUNT.TabIndex = 38
        Me.TXT_AMOUNT.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(112, 48)
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
        'REASON
        '
        Me.REASON.Location = New System.Drawing.Point(112, 544)
        Me.REASON.Name = "REASON"
        Me.REASON.Size = New System.Drawing.Size(72, 20)
        Me.REASON.TabIndex = 40
        Me.REASON.Text = ""
        Me.REASON.Visible = False
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Chk_freeze)
        Me.Grp_Print.Controls.Add(Me.CMDEXIT)
        Me.Grp_Print.Controls.Add(Me.CMD_WINDOWS)
        Me.Grp_Print.Controls.Add(Me.CMD_DOS)
        Me.Grp_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Print.Location = New System.Drawing.Point(288, 536)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(440, 64)
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
        Me.Label12.Location = New System.Drawing.Point(56, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 21)
        Me.Label12.TabIndex = 663
        Me.Label12.Text = "SubCategory Code "
        '
        'Txt_subcategorycode
        '
        Me.Txt_subcategorycode.BackColor = System.Drawing.Color.White
        Me.Txt_subcategorycode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_subcategorycode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_subcategorycode.Enabled = False
        Me.Txt_subcategorycode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_subcategorycode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_subcategorycode.Location = New System.Drawing.Point(208, 80)
        Me.Txt_subcategorycode.MaxLength = 10
        Me.Txt_subcategorycode.Name = "Txt_subcategorycode"
        Me.Txt_subcategorycode.Size = New System.Drawing.Size(120, 21)
        Me.Txt_subcategorycode.TabIndex = 662
        Me.Txt_subcategorycode.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 21)
        Me.Label13.TabIndex = 660
        Me.Label13.Text = "SubCategory Name "
        '
        'txt_SubCategoryName
        '
        Me.txt_SubCategoryName.BackColor = System.Drawing.Color.White
        Me.txt_SubCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SubCategoryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubCategoryName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubCategoryName.Location = New System.Drawing.Point(512, 80)
        Me.txt_SubCategoryName.MaxLength = 35
        Me.txt_SubCategoryName.Name = "txt_SubCategoryName"
        Me.txt_SubCategoryName.Size = New System.Drawing.Size(176, 21)
        Me.txt_SubCategoryName.TabIndex = 661
        Me.txt_SubCategoryName.Text = ""
        '
        'Txt_Validity
        '
        Me.Txt_Validity.BackColor = System.Drawing.Color.White
        Me.Txt_Validity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Validity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Validity.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Validity.Location = New System.Drawing.Point(712, 168)
        Me.Txt_Validity.MaxLength = 2
        Me.Txt_Validity.Name = "Txt_Validity"
        Me.Txt_Validity.Size = New System.Drawing.Size(40, 21)
        Me.Txt_Validity.TabIndex = 683
        Me.Txt_Validity.Text = ""
        Me.Txt_Validity.Visible = False
        '
        'lblvalidity
        '
        Me.lblvalidity.AutoSize = True
        Me.lblvalidity.BackColor = System.Drawing.Color.Transparent
        Me.lblvalidity.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalidity.Location = New System.Drawing.Point(656, 168)
        Me.lblvalidity.Name = "lblvalidity"
        Me.lblvalidity.Size = New System.Drawing.Size(55, 21)
        Me.lblvalidity.TabIndex = 682
        Me.lblvalidity.Text = "Valitity"
        Me.lblvalidity.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(56, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(180, 21)
        Me.Label14.TabIndex = 681
        Me.Label14.Text = "Permanent Member [Y/N]"
        '
        'Chk_PermanentNo
        '
        Me.Chk_PermanentNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PermanentNo.Location = New System.Drawing.Point(304, 168)
        Me.Chk_PermanentNo.Name = "Chk_PermanentNo"
        Me.Chk_PermanentNo.Size = New System.Drawing.Size(48, 24)
        Me.Chk_PermanentNo.TabIndex = 685
        Me.Chk_PermanentNo.Text = "No"
        '
        'Chk_Permanentyes
        '
        Me.Chk_Permanentyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Permanentyes.Location = New System.Drawing.Point(248, 168)
        Me.Chk_Permanentyes.Name = "Chk_Permanentyes"
        Me.Chk_Permanentyes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_Permanentyes.TabIndex = 684
        Me.Chk_Permanentyes.Text = "Yes"
        Me.Chk_Permanentyes.ThreeState = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(56, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 21)
        Me.Label15.TabIndex = 686
        Me.Label15.Text = "Voting Rights[Y/N]"
        '
        'Chk_VotingNo
        '
        Me.Chk_VotingNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_VotingNo.Location = New System.Drawing.Point(304, 208)
        Me.Chk_VotingNo.Name = "Chk_VotingNo"
        Me.Chk_VotingNo.Size = New System.Drawing.Size(48, 24)
        Me.Chk_VotingNo.TabIndex = 688
        Me.Chk_VotingNo.Text = "No"
        '
        'Chk_Votingyes
        '
        Me.Chk_Votingyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Votingyes.Location = New System.Drawing.Point(248, 208)
        Me.Chk_Votingyes.Name = "Chk_Votingyes"
        Me.Chk_Votingyes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_Votingyes.TabIndex = 687
        Me.Chk_Votingyes.Text = "Yes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, -8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 21)
        Me.Label16.TabIndex = 689
        Me.Label16.Text = "Subscription Required[Y/N]"
        Me.Label16.Visible = False
        '
        'Chk_subsNo
        '
        Me.Chk_subsNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_subsNo.Location = New System.Drawing.Point(936, -8)
        Me.Chk_subsNo.Name = "Chk_subsNo"
        Me.Chk_subsNo.Size = New System.Drawing.Size(48, 24)
        Me.Chk_subsNo.TabIndex = 691
        Me.Chk_subsNo.Text = "No"
        Me.Chk_subsNo.Visible = False
        '
        'Chk_subsyes
        '
        Me.Chk_subsyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_subsyes.Location = New System.Drawing.Point(888, -8)
        Me.Chk_subsyes.Name = "Chk_subsyes"
        Me.Chk_subsyes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_subsyes.TabIndex = 690
        Me.Chk_subsyes.Text = "Yes"
        Me.Chk_subsyes.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(192, 592)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 56)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(368, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 21)
        Me.Label17.TabIndex = 692
        Me.Label17.Text = "Club Account [Y/N]"
        '
        'Cbo_ClubAccount
        '
        Me.Cbo_ClubAccount.BackColor = System.Drawing.Color.White
        Me.Cbo_ClubAccount.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_ClubAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_ClubAccount.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_ClubAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_ClubAccount.ItemHeight = 16
        Me.Cbo_ClubAccount.Items.AddRange(New Object() {"Yes", "No"})
        Me.Cbo_ClubAccount.Location = New System.Drawing.Point(512, 208)
        Me.Cbo_ClubAccount.Name = "Cbo_ClubAccount"
        Me.Cbo_ClubAccount.Size = New System.Drawing.Size(80, 24)
        Me.Cbo_ClubAccount.TabIndex = 812
        '
        'cmd_SubCategoryCodeHelp
        '
        Me.cmd_SubCategoryCodeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SubCategoryCodeHelp.Image = CType(resources.GetObject("cmd_SubCategoryCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_SubCategoryCodeHelp.Location = New System.Drawing.Point(328, 80)
        Me.cmd_SubCategoryCodeHelp.Name = "cmd_SubCategoryCodeHelp"
        Me.cmd_SubCategoryCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_SubCategoryCodeHelp.TabIndex = 813
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
        Me.Label4.TabIndex = 814
        Me.Label4.Text = "Subscription Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(600, 208)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(171, 21)
        Me.Label18.TabIndex = 815
        Me.Label18.Text = "Corporate Member[Y/N]"
        '
        'Chk_corporateno
        '
        Me.Chk_corporateno.BackColor = System.Drawing.Color.Transparent
        Me.Chk_corporateno.Location = New System.Drawing.Point(832, 208)
        Me.Chk_corporateno.Name = "Chk_corporateno"
        Me.Chk_corporateno.Size = New System.Drawing.Size(48, 24)
        Me.Chk_corporateno.TabIndex = 817
        Me.Chk_corporateno.Text = "No"
        '
        'Chk_corportateyes
        '
        Me.Chk_corportateyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_corportateyes.Location = New System.Drawing.Point(776, 208)
        Me.Chk_corportateyes.Name = "Chk_corportateyes"
        Me.Chk_corportateyes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_corportateyes.TabIndex = 816
        Me.Chk_corportateyes.Text = "Yes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(368, 168)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(162, 21)
        Me.Label19.TabIndex = 818
        Me.Label19.Text = "Tenures Required[Y/N]"
        '
        'Chk_tenuresNo
        '
        Me.Chk_tenuresNo.BackColor = System.Drawing.Color.Transparent
        Me.Chk_tenuresNo.Location = New System.Drawing.Point(600, 168)
        Me.Chk_tenuresNo.Name = "Chk_tenuresNo"
        Me.Chk_tenuresNo.Size = New System.Drawing.Size(48, 24)
        Me.Chk_tenuresNo.TabIndex = 820
        Me.Chk_tenuresNo.Text = "No"
        '
        'Chk_Tenuresyes
        '
        Me.Chk_Tenuresyes.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Tenuresyes.Location = New System.Drawing.Point(544, 168)
        Me.Chk_Tenuresyes.Name = "Chk_Tenuresyes"
        Me.Chk_Tenuresyes.Size = New System.Drawing.Size(44, 24)
        Me.Chk_Tenuresyes.TabIndex = 819
        Me.Chk_Tenuresyes.Text = "Yes"
        '
        'lblmonth
        '
        Me.lblmonth.AutoSize = True
        Me.lblmonth.BackColor = System.Drawing.Color.Transparent
        Me.lblmonth.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonth.Location = New System.Drawing.Point(752, 176)
        Me.lblmonth.Name = "lblmonth"
        Me.lblmonth.Size = New System.Drawing.Size(60, 18)
        Me.lblmonth.TabIndex = 821
        Me.lblmonth.Text = "In Month"
        Me.lblmonth.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(680, 280)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(262, 25)
        Me.Label20.TabIndex = 823
        Me.Label20.Text = "Category Can be Converted to"
        '
        'Select_Category
        '
        Me.Select_Category.BackColor = System.Drawing.Color.White
        Me.Select_Category.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Category.Location = New System.Drawing.Point(680, 312)
        Me.Select_Category.Name = "Select_Category"
        Me.Select_Category.Size = New System.Drawing.Size(248, 193)
        Me.Select_Category.Sorted = True
        Me.Select_Category.TabIndex = 824
        '
        'SubCategorymaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 670)
        Me.Controls.Add(Me.Select_Category)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblmonth)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Txt_Validity)
        Me.Controls.Add(Me.lblvalidity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_subcategorycode)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_SubCategoryName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_CategoryCode)
        Me.Controls.Add(Me.lbl_CategoryName)
        Me.Controls.Add(Me.lbl_CategoryCode)
        Me.Controls.Add(Me.txt_CategoryName)
        Me.Controls.Add(Me.txtminamt)
        Me.Controls.Add(Me.REASON)
        Me.Controls.Add(Me.Chk_tenuresNo)
        Me.Controls.Add(Me.Chk_Tenuresyes)
        Me.Controls.Add(Me.Chk_corporateno)
        Me.Controls.Add(Me.Chk_corportateyes)
        Me.Controls.Add(Me.cmd_SubCategoryCodeHelp)
        Me.Controls.Add(Me.Cbo_ClubAccount)
        Me.Controls.Add(Me.Chk_subsNo)
        Me.Controls.Add(Me.Chk_subsyes)
        Me.Controls.Add(Me.Chk_VotingNo)
        Me.Controls.Add(Me.Chk_Votingyes)
        Me.Controls.Add(Me.Chk_PermanentNo)
        Me.Controls.Add(Me.Chk_Permanentyes)
        Me.Controls.Add(Me.Grp_Print)
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
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubCategorymaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATEGORY MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Dim STR_TYPE As String
    Dim Iteration, I, J As Integer
    Dim MTYPECODE, MEMBERTYPE As String

    Dim ds As New DataSet
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Dim subcode, subdesc As String
     
        Try
            If cmd_AddNew.Text = "Add New[F5]" Then
                Call checkValidation()
              
                If boolchk = False Then Exit Sub
                'If MeValidate() = False Then Exit Sub
                'insert Category
                ''SqlString = "INSERT INTO MEMBERTYPE"
                ''SqlString = SqlString & "(Membertype,TypeDesc,subtypeCode,Subtypedesc,AddUserId, AddDatetime,Freeze,creditlimit,barlimit,catlimit,) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                ''SqlString = SqlString & txt_CategoryName.Text & "','" & Txt_subcategorycode.Text & "','" & Trim(txt_SubCategoryName.Text) & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & Trim(TXT_AMOUNT.Text) & "','" & Trim(txt_BARAMT.Text) & "','" & Trim(TXT_CATERING.Text) & "')"
                ''gconnection.closeConnection()
                'insert subcategorymaster
                'gconnection.dataOperation(1, SqlString, "MemberType")
                SqlString = "INSERT INTO SubCategorymaster"
                SqlString = SqlString & "(typeCode,subtypeCode,Subtypedesc,ADDUSERID,AddDatetime,Freeze,barlimit,catlimit,ClubAccount,validity) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                SqlString = SqlString & Txt_subcategorycode.Text & "','" & Trim(txt_SubCategoryName.Text) & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & Val(txt_BARAMT.Text) & "','" & Val(TXT_CATERING.Text) & "','" & Cbo_ClubAccount.Text & "','" & Val(Txt_Validity.Text) & "')"
                gconnection.closeConnection()
                gconnection.dataOperation(1, SqlString, "MemberType")

                If Chk_Permanentyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_Votingyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_creditlimityes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET CREDITLIMITYN = 'Y',CREDITLIMIT='" & Val(TXT_AMOUNT.Text) & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_creditlimitno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET CREDITLIMITYN = 'N',CREDITLIMIT=0 WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_Tenuresyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_corportateyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_PermanentNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_VotingNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_tenuresNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_corporateno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If

                For loopindex = 1 To ssgrid1.DataRowCnt
                    subcode = Nothing
                    subdesc = Nothing
                    ssgrid1.GetText(1, loopindex, subcode)
                    ssgrid1.GetText(2, loopindex, subdesc)

                    SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(Txt_subcategorycode.Text & "") & "',"
                    SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                    gconnection.dataOperation(1, SqlString, "MemberType")
                Next loopindex

                If Select_Category.CheckedItems.Count > 0 Then
                    For I = 0 To Select_Category.CheckedItems.Count - 1
                        MTYPECODE = Select_Category.CheckedItems(I)
                        SqlString = "INSERT INTO MemberCategoryConversion"
                        SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                        SqlString = SqlString & Txt_subcategorycode.Text & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                    Next
                End If
                'If Select_Category.CheckedItems.Count > 0 Then
                '    For I = 0 To Select_Category.CheckedItems.Count - 1
                '        MTYPECODE = Select_Category.CheckedItems(I)
                '        SqlString = "SELECT DISTINCT SUBTYPECODE FROM SUBCATEGORYMASTER WHERE SUBTYPEDESC='" & MTYPECODE & "' AND ISNULL(FREEZE,'')<>'Y'"
                '        gconnection.getDataSet(SqlString, "SUB")

                '        If gdataset.Tables("SUB").Rows.Count > 0 Then
                '            MEMBERTYPE = gdataset.Tables("SUB").Rows(0).Item("SUBTYPECODE")
                '            SqlString = "INSERT INTO MemberCategoryConversion"
                '            SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                '            SqlString = SqlString & MEMBERTYPE & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                '            gconnection.dataOperation(1, SqlString, "MemberType")
                '        End If

                '    Next
                'End If



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

                'Update category
                ''SqlString = "UPDATE  MemberType SET TYPEDESC = '"
                ''SqlString = SqlString & txt_CategoryName.Text & "'"
                ''SqlString = SqlString & ",SUBSCRIPTIONREQUIRED = '" & strSubscription
                ''SqlString = SqlString & "',ADDUSERID ='" & gUsername
                ''SqlString = SqlString & "',subtypeCode ='" & Txt_subcategorycode.Text
                ''SqlString = SqlString & "',Subtypedesc ='" & txt_SubCategoryName.Text
                ''SqlString = SqlString & "',creditlimit ='" & TXT_AMOUNT.Text
                ''SqlString = SqlString & "',barlimit ='" & txt_BARAMT.Text
                ''SqlString = SqlString & "',catlimit ='" & TXT_CATERING.Text
                ''SqlString = SqlString & "',ClubAccount ='" & Cbo_ClubAccount.Text
                ''SqlString = SqlString & "',nomon ='" & txtminmnth.Text
                ''SqlString = SqlString & "',ADDDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',FREEZE = 'N'"
                ''SqlString = SqlString & " WHERE MEMBERTYPE = '" & txt_CategoryCode.Text & "'"
                ''gconnection.dataOperation(2, SqlString, "membertype")
                ''gconnection.closeConnection()

                SqlString = "Delete from MemberTypeDtl where MemberType ='" & Trim(Txt_subcategorycode.Text & "") & "'"
                gconnection.dataOperation(1, SqlString, "MemberType")
                gconnection.closeConnection()

                'Update Subcategory

                SqlString = "UPDATE  SubCategorymaster SET Subtypedesc = '"
                SqlString = SqlString & txt_SubCategoryName.Text & "'"
                SqlString = SqlString & ",typeCode = '" & txt_CategoryCode.Text
                SqlString = SqlString & "',Validity = '" & Txt_Validity.Text
                SqlString = SqlString & "',ADDUSERID ='" & gUsername
                SqlString = SqlString & "',barlimit ='" & txt_BARAMT.Text
                SqlString = SqlString & "',catlimit ='" & TXT_CATERING.Text
                'SqlString = SqlString & "',REMARK ='" & REASON.Text
                SqlString = SqlString & "',ClubAccount ='" & Cbo_ClubAccount.Text
                'SqlString = SqlString & "',REASON ='" & TextBox1.Text
                SqlString = SqlString & "',ADDDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',FREEZE = 'N'"
                SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                gconnection.dataOperation(2, SqlString, "membertype")
                gconnection.closeConnection()

                If Chk_Permanentyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_Votingyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_creditlimityes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET CREDITLIMITYN = 'Y',CREDITLIMIT='" & Val(TXT_AMOUNT.Text) & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                    SqlString = "UPDATE MEMBERMASTER SET CATLIMIT=" & Val(TXT_AMOUNT.Text) & ",MEMLIMIT=" & Val(TXT_AMOUNT.Text) & " WHERE MEMBERTYPECODE='" & Txt_subcategorycode.Text & "' AND ISNULL(CATLIMIT,0) =ISNULL(MEMLIMIT,0)"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                    SqlString = "UPDATE MEMBERMASTER SET CATLIMIT=" & Val(TXT_AMOUNT.Text) & " WHERE MEMBERTYPECODE='" & Txt_subcategorycode.Text & "' AND ISNULL(CATLIMIT,0) <>ISNULL(MEMLIMIT,0)"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_creditlimitno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET CREDITLIMITYN = 'N',CREDITLIMIT=0 WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                    SqlString = "UPDATE MEMBERMASTER SET CATLIMIT=0,MEMLIMIT=0 WHERE MEMBERTYPECODE='" & Txt_subcategorycode.Text & "' AND ISNULL(CATLIMIT,0) =ISNULL(MEMLIMIT,0) "
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                    SqlString = "UPDATE MEMBERMASTER SET CATLIMIT=0 WHERE MEMBERTYPECODE='" & Txt_subcategorycode.Text & "' AND ISNULL(CATLIMIT,0)<>ISNULL(MEMLIMIT,0)"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_Tenuresyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_corportateyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_PermanentNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_VotingNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_tenuresNo.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If Chk_corporateno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If

                ssgrid1.SetActiveCell(1, 1)
                For loopindex = 1 To ssgrid1.DataRowCnt
                    subcode = Nothing
                    subdesc = Nothing
                    ssgrid1.GetText(1, loopindex, subcode)
                    ssgrid1.GetText(2, loopindex, subdesc)
                    SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(Txt_subcategorycode.Text & "") & "',"
                    SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                    gconnection.dataOperation(1, SqlString, "MemberType")
                    gconnection.closeConnection()
                Next loopindex
                gconnection.closeConnection()
                SqlString = "Delete from MemberCategoryConversion where Membertypecode='" & txt_CategoryCode.Text & "'and Membersubtypecode='" & Txt_subcategorycode.Text & "'"
                gconnection.dataOperation(1, SqlString, "MemberType")
                If Select_Category.CheckedItems.Count > 0 Then
                    For I = 0 To Select_Category.CheckedItems.Count - 1
                        MTYPECODE = Select_Category.CheckedItems(I)
                        SqlString = "INSERT INTO MemberCategoryConversion"
                        SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                        SqlString = SqlString & Txt_subcategorycode.Text & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                    Next
                End If
                'If Select_Category.CheckedItems.Count > 0 Then
                '    For I = 0 To Select_Category.CheckedItems.Count - 1
                '        MTYPECODE = Select_Category.CheckedItems(I)
                '        SqlString = "SELECT DISTINCT SUBTYPECODE FROM SUBCATEGORYMASTER WHERE SUBTYPEDESC='" & MTYPECODE & "' AND ISNULL(FREEZE,'')<>'Y'"
                '        gconnection.getDataSet(SqlString, "SUB")

                '        If gdataset.Tables("SUB").Rows.Count > 0 Then
                '            MEMBERTYPE = gdataset.Tables("SUB").Rows(0).Item("SUBTYPECODE")
                '            SqlString = "INSERT INTO MemberCategoryConversion"
                '            SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                '            SqlString = SqlString & MEMBERTYPE & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N')"
                '            gconnection.dataOperation(1, SqlString, "MemberType")
                '        End If

                '    Next
                'End If


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
            'Me.cmd_Clear_Click(sender, e)
        End Try
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Grp_Print.Visible = True
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Delete.Text, 1, 1) = "F" Then
            SqlString = "UPDATE  SubCategorymaster "
            SqlString = SqlString & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',REASON='" & REASON.Text & "'"
            SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & " '"
            gconnection.dataOperation(3, SqlString, "MemberType")

            SqlString = "UPDATE  MemberTypedtl "
            SqlString = SqlString & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, SqlString, "MemberType")
            gconnection.closeConnection()
            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        Else
            SqlString = "UPDATE  SubCategorymaster "
            SqlString = SqlString & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & " '"
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
        cmd_CategoryCodeHelp.Visible = True
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        txt_CategoryCode.Text = ""
        txt_CategoryName.Text = ""
        chk_SubscriptionRequired.Checked = False
        Chk_PermanentNo.Checked = False
        Chk_Permanentyes.Checked = False
        Chk_Votingyes.Checked = False
        Chk_VotingNo.Checked = False
        Chk_subsNo.Checked = False
        Chk_subsyes.Checked = False
        Chk_tenuresNo.Checked = False
        Chk_Tenuresyes.Checked = False
        Chk_corporateno.Checked = False
        Chk_corportateyes.Checked = False
        Chk_creditlimityes.Checked = False
        Chk_creditlimitno.Checked = False
        Txt_Validity.Visible = False
        lblmonth.Visible = False
        lblvalidity.Visible = False
        Txt_Validity.Text = ""
        Cbo_ClubAccount.SelectedIndex = -1
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Me.cmd_AddNew.Text = "Add New[F5]"
        Me.cmd_Delete.Text = "Freeze[F7]"
        txtminamt.Text = ""
        txtminmnth.Text = ""
        TXT_AMOUNT.Text = ""
        txt_BARAMT.Text = ""
        TXT_CATERING.Text = ""
        Me.txt_CategoryCode.Enabled = False
        Me.Txt_subcategorycode.Enabled = True
        Me.Txt_subcategorycode.Focus()

        For Iteration = 0 To (Select_Category.Items.Count - 1)
            Select_Category.SetSelected(Iteration, False)
            Select_Category.SetItemChecked(Iteration, False)
        Next
        Chk_Votingyes.Checked = False
        Chk_VotingNo.Checked = False
    End Sub
    Private Sub txt_CategoryCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CategoryCode.KeyPress
        getAlphanumeric(e)
        cmd_CategoryCodeHelp.Focus()

    End Sub
    Private Sub txt_CategoryCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CategoryCode.KeyDown
        ''cmd_AddNew.Text = "Update[F5]"
        'If e.KeyCode = Keys.Enter Then
        '    If txt_CategoryCode.Text = "" Then
        '        Call cmd_CategoryCodeHelp_Click(sender, e)
        '    Else
        '        txt_CategoryName.Focus()
        '    End If
        'End If
        'If e.KeyCode = Keys.F4 Then
        '    Call cmd_CategoryCodeHelp_Click(sender, e)
        'End If
        cmd_CategoryCodeHelp.Focus()

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
    Private Sub SubCategorymaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try

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
            txt_CategoryName.Text = Trim(vform.keyfield1 & "")
            txt_CategoryCode.Select()
            Me.txt_CategoryCode_Validated(sender, e)
            Chk_Permanentyes.Focus()
        End If
        vform.Close()
        vform = Nothing
        'cmd_AddNew.Text = "Update[F5]"
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********* Checked the status for votingright and also SubscriptionRequired
        '''********** Check Category Code is blank
        If txt_CategoryCode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Txt_subcategorycode.Focus()
            boolchk = False
            Exit Sub
        End If
        '''********** Check Category Name is blank

        If Chk_corportateyes.Checked = False And Chk_corporateno.Checked = False Then
            MessageBox.Show("Corporate Member(Y/N) Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If





        If txt_CategoryName.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If

        If Chk_Permanentyes.Checked = False And Chk_PermanentNo.Checked = False Then
            MessageBox.Show("Membership Permanent Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If Chk_Votingyes.Checked = False And Chk_VotingNo.Checked = False Then
            MessageBox.Show("Membership Votingrights Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If Chk_Tenuresyes.Checked = True And Txt_Validity.Text = "" Then
            MessageBox.Show("Validity Period Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If

        If Cbo_ClubAccount.Text = "" Then
            MessageBox.Show("Club Account can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If Chk_corportateyes.Checked = False And Chk_corporateno.Checked = False Then
            MessageBox.Show("Corporate Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub txt_CategoryCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CategoryCode.Validated
        'Dim MEMBERTYPE As New DataTable
        'Dim SUBCATEGORY As New DataTable
        'Dim subsmast As New DataTable
        'Dim CATEGORYDETAILS As New DataTable
        'Dim SUBSCRIPTIONMASTER As New DataTable
        'Dim C1 As New DataTable
        'Dim ssql, SQL, SQL1 As String
        'Dim I As Integer = 0
        'Dim J As Integer = 0
        'SQL1 = "SELECT * FROM CATEGORYDETAILS"
        'C1 = gconnection.GetValues(SQL1)
        'ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc,isnull(subtypeCode,'')as subtypeCode ,isnull(Subtypedesc,'')as Subtypedesc,isnull(minacctin,'') as minacct,isnull(acctdesc,'') as acdesc,isnull(minusage,0) as minamount,isnull(nomon,0) as noofmonth,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Freeze,'') as Freeze,isnull(votingright,'') as votingright,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit From MemberType Where MemberType='" & Me.txt_CategoryCode.Text & "'"
        'MEMBERTYPE = gconnection.GetValues(ssql)

        'ssql = "select membertype,typedesc from membertype where membertype='" & accode & "'"
        'MEMBERTYPE = gconnection.GetValues(ssql)
        'If MEMBERTYPE.Rows.Count > 0 Then
        '    Me.txt_CategoryCode.Text = MEMBERTYPE.Rows(0).Item("membertype")
        '    Me.txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("TypeDesc")
        '    '    Me.txt_CategoryName.Enabled = False
        '    Me.Txt_subcategorycode.Focus()
        'End If

        ''ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,typeCode,subtypeCode,Subtypedesc,Status,Validity,Permanent,VotingRight,SubscriptionRequired,barlimit,catlimit,Creditlimit,Freeze From SubCategorymaster Where typeCode='" & Me.txt_CategoryCode.Text & "'"
        ''SUBCATEGORY = gconnection.GetValues(ssql)
        ''If SUBCATEGORY.Rows.Count > 0 Then
        ''    Me.Txt_subcategorycode.Text = SUBCATEGORY.Rows(0).Item("subtypeCode")
        ''    Me.txt_SubCategoryName.Text = SUBCATEGORY.Rows(0).Item("Subtypedesc")
        ''Else
        ''    Me.txt_SubCategoryName.Text = ""
        ''End If

        ''If MEMBERTYPE.Rows.Count > 0 Then
        ''    accode = MEMBERTYPE.Rows(0).Item("minacct")
        ''    txtminamt.Text = MEMBERTYPE.Rows(0).Item("minamount")
        ''    txtminmnth.Text = MEMBERTYPE.Rows(0).Item("noofmonth")
        ''    TXT_AMOUNT.Text = MEMBERTYPE.Rows(0).Item("Creditlimit")
        ''    txt_BARAMT.Text = MEMBERTYPE.Rows(0).Item("barlimit")
        ''    TXT_CATERING.Text = MEMBERTYPE.Rows(0).Item("catlimit")
        ''    'Me.Txt_subcategorycode.Text = MEMBERTYPE.Rows(0).Item("subtypeCode")
        ''    'Me.txt_SubCategoryName.Text = MEMBERTYPE.Rows(0).Item("Subtypedesc")

        ''    Me.txt_CategoryCode.Enabled = False
        ''    Me.txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("TypeDesc")
        ''    If MEMBERTYPE.Rows(0).Item("SubscriptionRequired") = "Y" Then
        ''        Me.chk_SubscriptionRequired.Checked = True
        ''        Me.chk_SubscriptionRequired.BackColor = Color.Cyan
        ''    Else
        ''        Me.chk_SubscriptionRequired.Checked = False
        ''        Me.chk_SubscriptionRequired.BackColor = Color.Silver
        ''    End If
        ''    If MEMBERTYPE.Rows(0).Item("Freeze") = "Y" Then
        ''        Me.lbl_Frez.Visible = True
        ''        Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(MEMBERTYPE.Rows(0).Item("AddDateTime"), "dd-MMM-yyyy")
        ''        Me.cmd_Delete.Text = "UnFreeze[F7]"
        ''    Else
        ''        Me.lbl_Frez.Visible = False
        ''        Me.lbl_Frez.Text = "Record Freezed  On "
        ''        Me.cmd_Delete.Text = "Freeze[F7]"
        ''    End If
        ''    Me.cmd_AddNew.Text = "Update[F5]"
        ''Else
        ''    Me.txt_CategoryCode.Enabled = True
        ''    Me.txt_CategoryName.Text = ""
        ''    Me.chk_SubscriptionRequired.Checked = False
        ''    Me.lbl_Frez.Visible = False
        ''    Me.lbl_Frez.Text = "Record Freezed  On "
        ''    Me.cmd_AddNew.Text = "Add New[F5]"
        ''End If
        ''gconnection.closeConnection()
        ''ssql = "Select MembertypeDtl.SubsCode,Subsdesc from MembertypeDtl inner join SubscriptionMast on SubscriptionMast.subscode=MembertypeDtl.subscode where membertype = '" & Trim(Me.txt_CategoryCode.Text & "") & "' and isnull(SubscriptionMast.Freeze,'') <> 'Y'"
        ''subsmast = gconnection.GetValues(ssql)
        ''If subsmast.Rows.Count > 0 Then
        ''    ssgrid1.ClearRange(1, 1, -1, -1, True)
        ''    With ssgrid1
        ''        .Col = 1
        ''        .Row = 1
        ''        .SetActiveCell(1, 1)
        ''    End With
        ''    For I = 0 To subsmast.Rows.Count - 1
        ''        With ssgrid1
        ''            .SetText(1, (I + 1), subsmast.Rows(I).Item("subscode"))
        ''            .SetText(2, (I + 1), subsmast.Rows(I).Item("subsdesc"))
        ''        End With
        ''    Next I
        ''End If
        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
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
    Private Sub SubCategorymaster_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 163 Then
            e.Handled = True
        End If
    End Sub
    Private Sub chk_SubscriptionRequired_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_SubscriptionRequired.CheckedChanged
        If chk_SubscriptionRequired.Checked = True Then
        ElseIf chk_SubscriptionRequired.Checked = False Then
        End If
    End Sub
    Private Sub SubCategorymaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        categorybool = True
        Call autogenerate()
        Call FillTypeMst()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmd_CategoryCodeHelp.Visible = True
        Me.txt_CategoryCode.Enabled = False
        txt_CategoryName.Enabled = False
        Txt_subcategorycode.Enabled = True
        Txt_subcategorycode.Focus()
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

    Private Sub SubCategorymaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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
            'ssgrid1.GetText(1, .ActiveRow, Search)
            With ssgrid1
                .SetText(1, .ActiveRow, Trim(vform.keyfield & ""))
                .SetText(2, .ActiveRow, Trim(vform.keyfield1 & ""))
                SUBSCRIPTION_VALID()
                With ssgrid1
                    .Col = 1
                    .Row = .ActiveRow
                    If (.Text) = "" Then
                        .SetActiveCell(1, ssgrid1.ActiveRow)
                    Else
                        .SetActiveCell(1, ssgrid1.ActiveRow + 1)

                    End If
                End With

            End With

            'ssgrid1.SetText(1, ssgrid1.ActiveRow, Trim(vform.keyfield & ""))
            'ssgrid1.SetText(2, ssgrid1.ActiveRow, Trim(vform.keyfield1 & ""))
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub SUBSCRIPTION_VALID()
        Dim scode, sname, ssql, subscode As String
        Dim i As Integer
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
                        With ssgrid1
                            For i = 0 To ssgrid1.DataRowCnt
                                .Col = 1
                                .Row = i + 1
                                subscode = .Text
                                If subscode = gdataset.Tables("SUB").Rows(0).Item("SubsCode") Then
                                    With ssgrid1
                                        .Col = 1
                                        .Row = .ActiveRow
                                        .Text = ""
                                        .Col = 2
                                        .Row = .ActiveRow
                                        .Text = ""
                                        Exit Sub
                                    End With
                                   

                                End If
                            Next



                        End With
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
                        SUBSCRIPTION_VALID()
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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub RDOYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Chk_creditlimityes.Checked = True Then
            ' LBL_AMT.Visible = True
            TXT_AMOUNT.Visible = True
            ' RDONO.Checked = False
        Else
            Chk_creditlimitno.Checked = True
            'LBL_AMT.Visible = False
            TXT_AMOUNT.Visible = False

        End If
    End Sub

    Private Sub RDONO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Chk_creditlimityes.Checked = True Then
            '    LBL_AMT.Visible = False
            '    TXT_AMOUNT.Visible = False
            Chk_creditlimitno.Checked = False
        Else
            '    LBL_AMT.Visible = True
            '    TXT_AMOUNT.Visible = True

        End If
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


    Private Sub RDOYES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'LBL_AMT.Visible = True
        'TXT_AMOUNT.Visible = True
        LBL_COMBINED.Visible = True
        RDOCOMBINEDYES.Visible = True
        RDOCOMBINEDNO.Visible = True
    End Sub

    Private Sub RDONO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_DOS.Click
        Dim FrReport As New ReportDesignerCategory
        If Chk_freeze.Checked = True Then
            tables = " FROM MM_SUB WHERE FREEZE='Y'"
        Else
            tables = " FROM MM_SUB WHERE FREEZE='N'"
        End If

        Gheader = "MEMBER SUBCATEGORY MASTER"
        FrReport.SsGridReport.SetText(2, 1, "Categorycode")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "Categoryname")
        FrReport.SsGridReport.SetText(3, 2, 25)
        FrReport.SsGridReport.SetText(2, 3, "Subcategorycode")
        FrReport.SsGridReport.SetText(3, 3, 15)
        FrReport.SsGridReport.SetText(2, 4, "Subcategoryname")
        FrReport.SsGridReport.SetText(3, 4, 25)
        FrReport.SsGridReport.SetText(2, 5, "Creditlimit")
        FrReport.SsGridReport.SetText(3, 5, 12)
        'FrReport.SsGridReport.SetText(2, 4, "SubscriptionRequired")
        'FrReport.SsGridReport.SetText(3, 4, 20)
        'FrReport.SsGridReport.SetText(2, 3, "MinUsage")
        'FrReport.SsGridReport.SetText(3, 3, 8)
        FrReport.SsGridReport.SetText(2, 6, "Freeze")
        FrReport.SsGridReport.SetText(3, 6, 6)
        FrReport.Show()
    End Sub

    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New ReportViwer
        Dim r As New Cry_Subcategorymaster
        If Chk_freeze.Checked = True Then
            SqlString = "select ISNULL(A.TYPECODE,'') AS TYPECODE,ISNULL(A.SUBTYPEDESC,'') AS SUBTYPEDESC,ISNULL(A.SUBTYPECODE,'') AS SUBTYPECODE,ISNULL(B.TYPEDESC,'') AS ADDUSERID,ISNULL(A.CREDITLIMITYN,'') AS VOTINGRIGHT,ISNULL(B.FREEZE,'') AS FREEZE from MM_SUBCATEGORYMASTER A INNER JOIN MEMBERTYPE B ON A.TYPECODE=B.MEMBERTYPE where A.freeze='Y'"
        Else
            SqlString = "select ISNULL(A.TYPECODE,'') AS TYPECODE,ISNULL(A.SUBTYPEDESC,'') AS SUBTYPEDESC,ISNULL(A.SUBTYPECODE,'') AS SUBTYPECODE,ISNULL(B.TYPEDESC,'') AS ADDUSERID,ISNULL(A.CREDITLIMITYN,'') AS VOTINGRIGHT,ISNULL(B.FREEZE,'') AS FREEZE from MM_SUBCATEGORYMASTER A INNER JOIN MEMBERTYPE B ON A.TYPECODE=B.MEMBERTYPE where A.freeze='N'"
        End If
        Call Viewer.GetDetails1(SqlString, "MM_SUBCATEGORYMASTER", r)
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
    Private Sub autogenerate()
        'Dim doc As Integer
        'gconnection.getDataSet("Select ISNULL(MAX(ISNULL(SubtypeCode,'') AS SubtypeCode),0) + 1  AS  SubtypeCode  from SubCategorymaster ", "Maxvalues")
        'If gdataset.Tables("Maxvalues").Rows.Count > 0 Then
        '    Txt_subcategorycode.Text = gdataset.Tables("Maxvalues").Rows(0).Item("SubtypeCode")
        '    txt_SubCategoryName.Focus()
        'End If
    End Sub

    Private Sub Txt_subcategorycode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_subcategorycode.TextChanged

    End Sub

    Private Sub Txt_subcategorycode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_subcategorycode.Validated
        Dim MEMBERTYPE As New DataTable
        Dim SUBCATEGORY As New DataTable
        Dim subsmast As New DataTable
        Dim CATEGORYDETAILS As New DataTable
        Dim SUBSCRIPTIONMASTER As New DataTable
        Dim C1 As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        SQL1 = "SELECT * FROM CATEGORYDETAILS"
        C1 = gconnection.GetValues(SQL1)
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember,ISNULL(CREDITLIMITYN,'') AS CREDIT From SubCategorymaster Where subtypeCode='" & Me.Txt_subcategorycode.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            txt_CategoryCode.Enabled = False
            txt_CategoryName.Enabled = False
            cmd_CategoryCodeHelp.Visible = False
            accode = SUBCATEGORY.Rows(0).Item("typecode")
            TXT_AMOUNT.Text = SUBCATEGORY.Rows(0).Item("Creditlimit")
            txt_BARAMT.Text = SUBCATEGORY.Rows(0).Item("barlimit")
            TXT_CATERING.Text = SUBCATEGORY.Rows(0).Item("catlimit")
            Me.Txt_subcategorycode.Text = SUBCATEGORY.Rows(0).Item("subtypeCode")
            Me.Txt_Validity.Text = SUBCATEGORY.Rows(0).Item("Validity")
            Me.txt_SubCategoryName.Text = SUBCATEGORY.Rows(0).Item("Subtypedesc")
            Me.Cbo_ClubAccount.Text = SUBCATEGORY.Rows(0).Item("ClubAccount")
            Me.Txt_subcategorycode.Enabled = False
            If SUBCATEGORY.Rows(0).Item("SubscriptionRequired") = "Y" Then
                Me.Chk_subsyes.Checked = True
                Me.Chk_subsyes.BackColor = Color.Cyan
            ElseIf SUBCATEGORY.Rows(0).Item("SubscriptionRequired") = "N" Then
                Me.Chk_subsNo.Checked = True
            End If

            If SUBCATEGORY.Rows(0).Item("Permanent") = "Y" Then
                Me.Chk_Permanentyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("Permanent") = "N" Then
                Me.Chk_PermanentNo.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("votingright") = "Y" Then
                Me.Chk_Votingyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("votingright") = "N" Then
                Me.Chk_VotingNo.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(SUBCATEGORY.Rows(0).Item("AddDateTime"), "dd-MMM-yyyy")
                Me.cmd_Delete.Text = "UnFreeze[F7]"
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Freezed  On "
                Me.cmd_Delete.Text = "Freeze[F7]"
            End If
            If SUBCATEGORY.Rows(0).Item("CREDIT") = "Y" Then
                Me.Chk_creditlimityes.Checked = True
                Me.Chk_creditlimitno.Checked = False
                Me.LBL_AMT.Visible = True
                Me.TXT_AMOUNT.Visible = True
                Me.TXT_AMOUNT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
            Else
                Me.Chk_creditlimityes.Checked = False
                Me.Chk_creditlimitno.Checked = True
                Me.LBL_AMT.Visible = False
                Me.TXT_AMOUNT.Visible = False
                Me.TXT_AMOUNT.Text = 0
            End If
            If SUBCATEGORY.Rows(0).Item("Tenures") = "Y" Then
                Me.Chk_Tenuresyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("Tenures") = "N" Then
                Me.Chk_tenuresNo.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("Corporatemember") = "Y" Then
                Me.Chk_corportateyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("Corporatemember") = "N" Then
                Me.Chk_corporateno.Checked = True
            End If
            Me.cmd_AddNew.Text = "Update[F5]"
        Else
            Me.Txt_subcategorycode.Enabled = True
            'Me.txt_SubCategoryName.Text = ""
            Me.txt_CategoryCode.Enabled = False
            'Me.txt_CategoryName.Text = ""
            Me.accode = ""
            Me.chk_SubscriptionRequired.Checked = False
            Me.lbl_Frez.Visible = False
            Me.lbl_Frez.Text = "Record Freezed  On "
            Me.cmd_AddNew.Text = "Add New[F5]"
        End If
        ssql = "select membertype,typedesc from membertype where membertype='" & accode & "'"
        MEMBERTYPE = gconnection.GetValues(ssql)
        If MEMBERTYPE.Rows.Count > 0 Then
            Me.txt_CategoryCode.Text = MEMBERTYPE.Rows(0).Item("membertype")
            Me.txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("TypeDesc")
            Me.txt_CategoryName.Enabled = False
        End If

        gconnection.closeConnection()
        ssql = "Select MembertypeDtl.SubsCode,Subsdesc from MembertypeDtl inner join SubscriptionMast on SubscriptionMast.subscode=MembertypeDtl.subscode where Membertype = '" & Trim(Me.Txt_subcategorycode.Text & "") & "' and isnull(SubscriptionMast.Freeze,'') <> 'Y'"
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
        Call FillTypeMst()
        'Call FillTypeMst1()
    End Sub

    Private Sub Chk_Permanentyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Permanentyes.CheckedChanged

    End Sub

    Private Sub Chk_PermanentNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PermanentNo.CheckedChanged

    End Sub

    Private Sub Chk_PermanentNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_PermanentNo.Click
        If Chk_PermanentNo.Checked = True Then
            Chk_Permanentyes.Checked = False
            Chk_Tenuresyes.Checked = True
            lblvalidity.Visible = True
            Txt_Validity.Visible = True
            lblmonth.Visible = True
        Else
            Chk_Permanentyes.Checked = True
            Chk_Tenuresyes.Checked = False
            lblvalidity.Visible = False
            Txt_Validity.Visible = False
            lblmonth.Visible = False

        End If

    End Sub

    Private Sub Chk_Permanentyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Permanentyes.Click

        If Chk_Permanentyes.Checked = True Then
            Chk_PermanentNo.Checked = False
            Chk_Tenuresyes.Checked = False
            Chk_tenuresNo.Checked = True
            Chk_corportateyes.Checked = False
            Chk_corporateno.Checked = True
            lblvalidity.Visible = False
            Txt_Validity.Visible = False
            lblmonth.Visible = False
        Else
            Chk_PermanentNo.Checked = True
            Chk_Tenuresyes.Checked = True
            Chk_tenuresNo.Checked = False
            Chk_corportateyes.Checked = True
            Chk_corporateno.Checked = False
            Txt_Validity.Text = ""
        End If
    End Sub

    Private Sub cmd_SubCategoryCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SubCategoryCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select  subtypecode,subtypedesc  from subcategorymaster"
        M_WhereCondition = " "
        vform.Field = "subtypecode,subtypedesc "
        vform.vFormatstring = "  SubCategory Code  | SubCategory Name                            "
        vform.vCaption = "Category Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_subcategorycode.Text = Trim(vform.keyfield & "")
            Txt_subcategorycode.Select()
            Me.Txt_subcategorycode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_AddNew.Text = "Update[F5]"
    End Sub

    Private Sub Txt_subcategorycode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_subcategorycode.KeyDown
        'cmd_AddNew.Text = "Update[F5]"
        If e.KeyCode = Keys.Enter Then
            If Txt_subcategorycode.Text = "" Then
                Call cmd_SubCategoryCodeHelp_Click(sender, e)
            Else
                txt_SubCategoryName.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_CategoryCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_subcategorycode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_subcategorycode.KeyPress
        'getAlphanumeric(e)
    End Sub

    Private Sub Chk_Votingyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Votingyes.CheckedChanged
        'Chk_VotingNo.Checked = False

    End Sub

    Private Sub Chk_VotingNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_VotingNo.CheckedChanged
        'Chk_Votingyes.Checked = False

    End Sub

    Private Sub Chk_subsyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_subsyes.CheckedChanged
        Chk_subsNo.Checked = False
    End Sub

    Private Sub Chk_subsNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_subsNo.CheckedChanged
        Chk_subsyes.Checked = False
    End Sub

    Private Sub Chk_tenuresNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_tenuresNo.CheckedChanged

    End Sub

    Private Sub Chk_Tenuresyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Tenuresyes.CheckedChanged
        If Chk_Tenuresyes.Checked = True Then
            lblvalidity.Visible = True
            Txt_Validity.Visible = True
            lblmonth.Visible = True
            Chk_tenuresNo.Checked = False
        End If
    End Sub

    Private Sub Chk_Tenuresyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Tenuresyes.Click
        If Chk_Tenuresyes.Checked = True Then
            lblvalidity.Visible = True
            Txt_Validity.Visible = True
            lblmonth.Visible = True
            Chk_tenuresNo.Checked = False
        Else
            lblvalidity.Visible = False
            Txt_Validity.Visible = False
            lblmonth.Visible = False
            Chk_Tenuresyes.Checked = False
            Chk_tenuresNo.Checked = True
            Txt_Validity.Text = ""
        End If

    End Sub

    Private Sub Chk_tenuresNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_tenuresNo.Click

        If Chk_tenuresNo.Checked = True Then
            lblvalidity.Visible = False
            Txt_Validity.Visible = False
            lblmonth.Visible = False
            Chk_Tenuresyes.Checked = False
            Txt_Validity.Text = ""
        Else
            lblvalidity.Visible = True
            Txt_Validity.Visible = True
            lblmonth.Visible = True
            Chk_tenuresNo.Checked = False
            Chk_Tenuresyes.Checked = True
        End If

    End Sub

    Public Sub FillTypeMst()
        'Dim i As Integer
        'Dim SSQL As String
        'Dim dt, MEMBERTYPE As DataTable
        'Select_Category.Items.Clear()
        'SqlString = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' and subtypecode<>'" & Trim(Txt_subcategorycode.Text) & "'"
        'dt = gconnection.GetValues(SqlString)
        'Dim Itration
        'For Itration = 0 To (dt.Rows.Count - 1)
        '    Select_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        'Next
        'SSQL = "SELECT Membertypecode,Membersubtypecode,Membertype FROM MemberCategoryConversion WHERE Membertypecode='" & Trim(Me.Txt_subcategorycode.Text & "") & "' AND ISNULL(FREEZE,'') <> 'Y'"
        'MEMBERTYPE = gconnection.GetValues(ssql)
        'If MEMBERTYPE.Rows.Count > 0 Then
        '    For i = 0 To (MEMBERTYPE.Rows.Count - 1)
        '        For J = 0 To Select_Category.Items.Count - 1
        '            If Trim(MEMBERTYPE.Rows(i).Item("Membertype")) = Select_Category.GetItemText(Select_Category.Items(J)) Then
        '                Select_Category.SetItemChecked(J, True)
        '            End If
        '            'Select_Category.Items.Add(MEMBERTYPE.Rows(I).Item("Membersubtypecode") & "." & MEMBERTYPE.Rows(I).Item("Membertype"))
        '        Next
        '    Next
        'Else
        '    'MessageBox.Show("Current Category Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
        '    'Exit Sub
        'End If
        Dim i As Integer
        Dim SSQL As String
        Dim dt, MEMBERTYPE As DataTable
        Select_Category.Items.Clear()
        SqlString = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' and subtypecode<>'" & Trim(Txt_subcategorycode.Text) & "'"
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Select_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        Next
        SSQL = "SELECT Membertypecode,Membersubtypecode,Membertype FROM MemberCategoryConversion WHERE Membersubtypecode='" & Trim(Me.Txt_subcategorycode.Text & "") & "' AND ISNULL(FREEZE,'') <> 'Y'"
        MEMBERTYPE = gconnection.GetValues(SSQL)
        If MEMBERTYPE.Rows.Count > 0 Then
            For i = 0 To (MEMBERTYPE.Rows.Count - 1)
                For J = 0 To Select_Category.Items.Count - 1
                    If Trim(MEMBERTYPE.Rows(i).Item("Membertype")) = Select_Category.GetItemText(Select_Category.Items(J)) Then
                        Select_Category.SetItemChecked(J, True)
                    End If
                    'Select_Category.Items.Add(MEMBERTYPE.Rows(I).Item("Membersubtypecode") & "." & MEMBERTYPE.Rows(I).Item("Membertype"))
                Next
            Next
        Else
            'MessageBox.Show("Current Category Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
            'Exit Sub
        End If
    End Sub
    'Public Sub FillTypeMst1()
    '    Dim i As Integer
    '    Dim dt, dt1 As DataTable
    '    Dim SUBTYPE, SQLSTRING1 As String

    '    Select_Category.Items.Clear()
    '    SqlString = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' and subtypecode<>'" & Trim(Txt_subcategorycode.Text) & "'"
    '    dt = gconnection.GetValues(SqlString)
    '    Dim Itration
    '    For Itration = 0 To (dt.Rows.Count - 1)

    '        Select_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
    '        SUBTYPE = dt.Rows(Itration).Item("SubTYPEDESC")
    '        SQLSTRING1 = "SELECT DISTINCT MEMBERSUBTYPECODE FROM MemberCategoryConversion where freeze<>'Y' and MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "'"
    '        dt1 = gconnection.GetValues(SQLSTRING1)
    '        Dim Iteration1
    '        If dt1.Rows.Count > 0 Then


    '            'For Iteration1 = 0 To (Select_Category.Items.Count - 1)
    '            For Iteration1 = 0 To (dt1.Rows.Count - 1)
    '                'Select_Category.SetSelected(Iteration1, True)
    '                Select_Category.SetItemChecked(Itration, True)
    '            Next
    '        End If

    '    Next

    'End Sub
    Private Function MeValidate() As Boolean

        'Try
        '    MeValidate = True
        '    Dim MTYPECODE As String
        '    If Select_Category.CheckedItems.Count > 0 Then
        '        For I = 0 To Select_Category.CheckedItems.Count - 1
        '            MTYPECODE = Select_Category.CheckedItems(I)
        '            STR_TYPE = STR_TYPE & " '" & MTYPECODE & "', "
        '        Next
        '    Else
        '        MsgBox("Please Select The Member Status Name", vbInformation)
        '        MeValidate = False
        '        Exit Function
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Function


    Private Sub Chk_corportateyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_corportateyes.Click
        Chk_corporateno.Checked = False
        If Chk_corportateyes.Checked = True Then
            Chk_corporateno.Checked = False
            'Chk_Tenuresyes.Checked = False
            'Chk_tenuresNo.Checked = True
            'Chk_corportateyes.Checked = False
            'Chk_corporateno.Checked = True
            'lblvalidity.Visible = False
            'Txt_Validity.Visible = False
            'lblmonth.Visible = False
        Else
            Chk_corporateno.Checked = True
            'Chk_Tenuresyes.Checked = True
            'Chk_tenuresNo.Checked = False
            'Chk_corportateyes.Checked = True
            'Chk_corporateno.Checked = False
            'Txt_Validity.Text = ""
        End If
    End Sub


    Private Sub Chk_corporateno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_corporateno.Click
        ' Chk_corportateyes.Checked = False
        'Chk_corporateno.Checked = False
        If Chk_corporateno.Checked = True Then
            Chk_corportateyes.Checked = False
            'Chk_Tenuresyes.Checked = False
            'Chk_tenuresNo.Checked = True
            'Chk_corportateyes.Checked = False
            'Chk_corporateno.Checked = True
            'lblvalidity.Visible = False
            'Txt_Validity.Visible = False
            'lblmonth.Visible = False
        Else
            Chk_corportateyes.Checked = True
            'Chk_Tenuresyes.Checked = True
            'Chk_tenuresNo.Checked = False
            'Chk_corportateyes.Checked = True
            'Chk_corporateno.Checked = False
            'Txt_Validity.Text = ""
        End If
    End Sub

    Private Sub Chk_corporateno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_corporateno.CheckedChanged

    End Sub

    Private Sub Txt_subcategorycode_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_subcategorycode.Enter

    End Sub

    Private Sub txt_SubCategoryName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_SubCategoryName.TextChanged

    End Sub

    Private Sub txt_SubCategoryName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SubCategoryName.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Txt_subcategorycode.Text = "" Then
                MessageBox.Show("Subcategory code can't be blank", gCompanyname)
                Txt_subcategorycode.Focus()
                Exit Sub
            End If
            If txt_SubCategoryName.Text <> "" Then
                'MessageBox.Show("Subcategory code can't be blank", gCompanyname)
                Call cmd_CategoryCodeHelp_Click(sender, e)
            Else
                txt_SubCategoryName.Focus()
            End If
            'txt_SubCategoryName.Focus()
        End If
        'End If
        '' cmd_CategoryCodeHelp.Focus()
        'If e.KeyCode = Keys.Enter Then
        '    If Txt_subcategorycode.Text = "" Then
        '        Call cmd_SubCategoryCodeHelp_Click(sender, e)
        '    Else
        '        txt_SubCategoryName.Focus()
        '    End If

    End Sub

    Private Sub txt_SubCategoryName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubCategoryName.KeyPress
        ' cmd_CategoryCodeHelp.Focus()

    End Sub

    Private Sub txt_SubCategoryName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubCategoryName.Click

    End Sub

    Private Sub Chk_Permanentyes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_Permanentyes.KeyPress

    End Sub

    Private Sub Chk_Permanentyes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_Permanentyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_Permanentyes.Checked = False And Chk_PermanentNo.Checked = False Then
                MessageBox.Show("Please check Permanent Yes/No", gCompanyname)
                Chk_Permanentyes.Focus()

            End If
            Chk_Votingyes.Focus()
        End If
    End Sub

    Private Sub Chk_PermanentNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_PermanentNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_Permanentyes.Checked = False And Chk_PermanentNo.Checked = False Then
                MessageBox.Show("Please check Permanent Yes/No", gCompanyname)
                Chk_PermanentNo.Focus()

            End If
            Chk_Votingyes.Focus()
        End If
    End Sub

    Private Sub Chk_Votingyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Votingyes.Click
        If Chk_Votingyes.Checked = True Then
            Chk_VotingNo.Checked = False
            'Chk_Tenuresyes.Checked = False
            'Chk_tenuresNo.Checked = True
            'Chk_corportateyes.Checked = False
            'Chk_corporateno.Checked = True
            'lblvalidity.Visible = False
            'Txt_Validity.Visible = False
            'lblmonth.Visible = False
        Else
            Chk_VotingNo.Checked = True
            'Chk_Tenuresyes.Checked = True
            'Chk_tenuresNo.Checked = False
            'Chk_corportateyes.Checked = True
            'Chk_corporateno.Checked = False
            'Txt_Validity.Text = ""
        End If
    End Sub

    Private Sub Chk_Votingyes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_Votingyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_Votingyes.Checked = False And Chk_VotingNo.Checked = False Then
                MessageBox.Show("Please check Voting rights Yes/No", gCompanyname)
                Chk_Votingyes.Focus()

            End If
            Cbo_ClubAccount.Focus()
        End If
    End Sub

    Private Sub Chk_VotingNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_VotingNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_Votingyes.Checked = False And Chk_VotingNo.Checked = False Then
                MessageBox.Show("Please check Voting rights Yes/No", gCompanyname)
                Chk_Votingyes.Focus()

            End If
            Cbo_ClubAccount.Focus()
        End If
    End Sub

    Private Sub Cbo_ClubAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_ClubAccount.SelectedIndexChanged

    End Sub

    Private Sub Cbo_ClubAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_ClubAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Cbo_ClubAccount.Text = "" Then
                MessageBox.Show("Please select clubaccount rights Yes/No", gCompanyname)
                Cbo_ClubAccount.Focus()

            End If
            Chk_corportateyes.Focus()
        End If
    End Sub

    Private Sub Chk_corportateyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_corportateyes.CheckedChanged

    End Sub

    Private Sub Chk_corporateno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_corporateno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_corporateno.Checked = True And Chk_corportateyes.Checked = True Then
                MessageBox.Show("Please check corporate Yes/No", gCompanyname)
                Cbo_ClubAccount.Focus()

            End If
            ssgrid1.Focus()
            'With ssgrid1
            '    .ActiveRow = 1
            'End With
        End If
    End Sub

    Private Sub Chk_corportateyes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_corportateyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Chk_corporateno.Checked = True And Chk_corportateyes.Checked = True Then
                MessageBox.Show("Please check corporate Yes/No", gCompanyname)
                Cbo_ClubAccount.Focus()

            End If
            ssgrid1.Focus()
            'With ssgrid1
            '    .ActiveRow = 1
            'End With
        End If
    End Sub

    Private Sub Chk_VotingNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_VotingNo.Click
        If Chk_VotingNo.Checked = True Then
            Chk_Votingyes.Checked = False

        Else
            Chk_Votingyes.Checked = True

        End If
    End Sub

    Private Sub Select_Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_Category.SelectedIndexChanged

    End Sub

    Private Sub LBL_AMT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_AMT.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label10_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.Validated

    End Sub

    Private Sub Label10_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Label10.Validating

    End Sub

    Private Sub Label10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseEnter

    End Sub

    Private Sub Label10_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label10.MouseDown

    End Sub

    Private Sub GroupBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GroupBox3.KeyDown

    End Sub

    Private Sub Label10_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.Enter

    End Sub

    Private Sub GroupBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GroupBox3.KeyPress

    End Sub

    Private Sub Chk_creditlimityes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_creditlimityes.CheckedChanged

    End Sub

    Private Sub Chk_creditlimityes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_creditlimityes.Click
        'If Chk_creditlimityes = True Then
        'Chk_creditlimitno = False
        If Chk_creditlimityes.Checked = True Then
            Chk_creditlimitno.Checked = False
            TXT_AMOUNT.Visible = True
            Me.LBL_AMT.Visible = True


        Else
            Chk_creditlimitno.Checked = True
            Chk_creditlimityes.Checked = False
            TXT_AMOUNT.Visible = False
            Me.LBL_AMT.Visible = False

        End If
        'If Chk_creditlimitno.Checked = True Then
        '    Chk_creditlimitno.Checked = False
        ' End If
    End Sub

    Private Sub Txt_Validity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Validity.TextChanged

    End Sub

    Private Sub Chk_creditlimitno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_creditlimitno.CheckedChanged

    End Sub

    Private Sub Chk_creditlimitno_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_creditlimitno.Click
        If Chk_creditlimitno.Checked = True Then
            Chk_creditlimityes.Checked = False
            TXT_AMOUNT.Visible = False
            Me.LBL_AMT.Visible = False

        Else
            Chk_creditlimityes.Checked = True
            Chk_creditlimitno.Checked = False
            TXT_AMOUNT.Visible = True
            Me.LBL_AMT.Visible = True


        End If
    End Sub
End Class

