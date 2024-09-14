Public Class MembershipMaster
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
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents TXT_TITLE As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_MembershipTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_spouse_dob As System.Windows.Forms.TextBox
    Friend WithEvents dtp_MembershipFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents dtp_DateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_dateofbirth As System.Windows.Forms.Label
    Friend WithEvents cmd_CategoryHelp As System.Windows.Forms.Button
    Friend WithEvents txt_Spouse As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Spouse As System.Windows.Forms.Label
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MembershipMaster))
        Me.Label101 = New System.Windows.Forms.Label
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.TXT_TITLE = New System.Windows.Forms.TextBox
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.txt_FirstName = New System.Windows.Forms.TextBox
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_FirstName = New System.Windows.Forms.Label
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtp_MembershipTo = New System.Windows.Forms.DateTimePicker
        Me.txt_spouse_dob = New System.Windows.Forms.TextBox
        Me.dtp_MembershipFrom = New System.Windows.Forms.DateTimePicker
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.txt_Category = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.dtp_DateOfBirth = New System.Windows.Forms.DateTimePicker
        Me.lbl_dateofbirth = New System.Windows.Forms.Label
        Me.cmd_CategoryHelp = New System.Windows.Forms.Button
        Me.txt_Spouse = New System.Windows.Forms.TextBox
        Me.lbl_Spouse = New System.Windows.Forms.Label
        Me.lbl_category = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label101.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.Red
        Me.Label101.Location = New System.Drawing.Point(156, 520)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(360, 25)
        Me.Label101.TabIndex = 808
        Me.Label101.Text = "Single Quote (') is not allowed anywhere in the form."
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Frez
        '
        Me.lbl_Frez.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(508, 520)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Frez.TabIndex = 807
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.Location = New System.Drawing.Point(660, 560)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 806
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Location = New System.Drawing.Point(524, 560)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 805
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.Location = New System.Drawing.Point(148, 560)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 803
        Me.cmd_ListView.Text = "View [F8]"
        Me.cmd_ListView.Visible = False
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.Location = New System.Drawing.Point(388, 560)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 804
        Me.cmd_Delete.Text = "Freeze[F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.Location = New System.Drawing.Point(260, 560)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 802
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'TXT_TITLE
        '
        Me.TXT_TITLE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TITLE.Location = New System.Drawing.Point(136, 56)
        Me.TXT_TITLE.Name = "TXT_TITLE"
        Me.TXT_TITLE.Size = New System.Drawing.Size(88, 22)
        Me.TXT_TITLE.TabIndex = 811
        Me.TXT_TITLE.Text = ""
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(472, 8)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(266, 35)
        Me.lbl_Caption.TabIndex = 815
        Me.lbl_Caption.Text = "MEMBER  MASTER"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_FirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_FirstName.Location = New System.Drawing.Point(136, 88)
        Me.txt_FirstName.MaxLength = 35
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(136, 22)
        Me.txt_FirstName.TabIndex = 812
        Me.txt_FirstName.Text = ""
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MemberCode.Location = New System.Drawing.Point(136, 24)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 26)
        Me.txt_MemberCode.TabIndex = 809
        Me.txt_MemberCode.Text = ""
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(16, 96)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(110, 18)
        Me.lbl_FirstName.TabIndex = 818
        Me.lbl_FirstName.Text = "Member Name* :"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(16, 64)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(41, 18)
        Me.lbl_Title.TabIndex = 817
        Me.lbl_Title.Text = "Title :"
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(16, 24)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(110, 18)
        Me.lbl_MemberCode.TabIndex = 816
        Me.lbl_MemberCode.Text = "Member Code*  :"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(312, 24)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 810
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbl_category)
        Me.GroupBox1.Controls.Add(Me.dtp_MembershipTo)
        Me.GroupBox1.Controls.Add(Me.txt_spouse_dob)
        Me.GroupBox1.Controls.Add(Me.dtp_MembershipFrom)
        Me.GroupBox1.Controls.Add(Me.Label96)
        Me.GroupBox1.Controls.Add(Me.Label76)
        Me.GroupBox1.Controls.Add(Me.txt_Category)
        Me.GroupBox1.Controls.Add(Me.Label74)
        Me.GroupBox1.Controls.Add(Me.dtp_DateOfBirth)
        Me.GroupBox1.Controls.Add(Me.lbl_dateofbirth)
        Me.GroupBox1.Controls.Add(Me.cmd_CategoryHelp)
        Me.GroupBox1.Controls.Add(Me.txt_Spouse)
        Me.GroupBox1.Controls.Add(Me.lbl_Spouse)
        Me.GroupBox1.Controls.Add(Me.lbl_MemberCode)
        Me.GroupBox1.Controls.Add(Me.txt_MemberCode)
        Me.GroupBox1.Controls.Add(Me.lbl_Title)
        Me.GroupBox1.Controls.Add(Me.TXT_TITLE)
        Me.GroupBox1.Controls.Add(Me.lbl_FirstName)
        Me.GroupBox1.Controls.Add(Me.txt_FirstName)
        Me.GroupBox1.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 288)
        Me.GroupBox1.TabIndex = 821
        Me.GroupBox1.TabStop = False
        '
        'dtp_MembershipTo
        '
        Me.dtp_MembershipTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_MembershipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipTo.Location = New System.Drawing.Point(432, 200)
        Me.dtp_MembershipTo.Name = "dtp_MembershipTo"
        Me.dtp_MembershipTo.Size = New System.Drawing.Size(168, 20)
        Me.dtp_MembershipTo.TabIndex = 828
        Me.dtp_MembershipTo.Value = New Date(2009, 3, 20, 8, 34, 57, 836)
        '
        'txt_spouse_dob
        '
        Me.txt_spouse_dob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_spouse_dob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_spouse_dob.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_spouse_dob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_spouse_dob.Location = New System.Drawing.Point(480, 104)
        Me.txt_spouse_dob.MaxLength = 15
        Me.txt_spouse_dob.Name = "txt_spouse_dob"
        Me.txt_spouse_dob.Size = New System.Drawing.Size(112, 22)
        Me.txt_spouse_dob.TabIndex = 822
        Me.txt_spouse_dob.Text = ""
        '
        'dtp_MembershipFrom
        '
        Me.dtp_MembershipFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_MembershipFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipFrom.Location = New System.Drawing.Point(432, 168)
        Me.dtp_MembershipFrom.Name = "dtp_MembershipFrom"
        Me.dtp_MembershipFrom.Size = New System.Drawing.Size(160, 22)
        Me.dtp_MembershipFrom.TabIndex = 821
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(368, 104)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(87, 18)
        Me.Label96.TabIndex = 827
        Me.Label96.Text = "Spouse DOB"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(296, 200)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(112, 18)
        Me.Label76.TabIndex = 830
        Me.Label76.Text = "Membership To :"
        '
        'txt_Category
        '
        Me.txt_Category.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Category.CausesValidation = False
        Me.txt_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Category.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Category.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Category.Location = New System.Drawing.Point(728, 208)
        Me.txt_Category.MaxLength = 15
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(168, 22)
        Me.txt_Category.TabIndex = 823
        Me.txt_Category.Text = ""
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(296, 176)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(129, 18)
        Me.Label74.TabIndex = 829
        Me.Label74.Text = "Membership From :"
        '
        'dtp_DateOfBirth
        '
        Me.dtp_DateOfBirth.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite
        Me.dtp_DateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtp_DateOfBirth.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_DateOfBirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_DateOfBirth.Location = New System.Drawing.Point(136, 120)
        Me.dtp_DateOfBirth.Name = "dtp_DateOfBirth"
        Me.dtp_DateOfBirth.Size = New System.Drawing.Size(152, 22)
        Me.dtp_DateOfBirth.TabIndex = 819
        Me.dtp_DateOfBirth.Value = New Date(2008, 7, 31, 0, 0, 0, 0)
        '
        'lbl_dateofbirth
        '
        Me.lbl_dateofbirth.AutoSize = True
        Me.lbl_dateofbirth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dateofbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dateofbirth.Location = New System.Drawing.Point(16, 120)
        Me.lbl_dateofbirth.Name = "lbl_dateofbirth"
        Me.lbl_dateofbirth.Size = New System.Drawing.Size(108, 18)
        Me.lbl_dateofbirth.TabIndex = 825
        Me.lbl_dateofbirth.Text = "Date Of Birth*   :"
        '
        'cmd_CategoryHelp
        '
        Me.cmd_CategoryHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_CategoryHelp.Image = CType(resources.GetObject("cmd_CategoryHelp.Image"), System.Drawing.Image)
        Me.cmd_CategoryHelp.Location = New System.Drawing.Point(952, 264)
        Me.cmd_CategoryHelp.Name = "cmd_CategoryHelp"
        Me.cmd_CategoryHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_CategoryHelp.TabIndex = 824
        '
        'txt_Spouse
        '
        Me.txt_Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Spouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Spouse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Spouse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Spouse.Location = New System.Drawing.Point(432, 136)
        Me.txt_Spouse.MaxLength = 50
        Me.txt_Spouse.Name = "txt_Spouse"
        Me.txt_Spouse.Size = New System.Drawing.Size(168, 22)
        Me.txt_Spouse.TabIndex = 820
        Me.txt_Spouse.Text = ""
        '
        'lbl_Spouse
        '
        Me.lbl_Spouse.AutoSize = True
        Me.lbl_Spouse.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Spouse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Spouse.Location = New System.Drawing.Point(328, 136)
        Me.lbl_Spouse.Name = "lbl_Spouse"
        Me.lbl_Spouse.Size = New System.Drawing.Size(93, 18)
        Me.lbl_Spouse.TabIndex = 826
        Me.lbl_Spouse.Text = "Spouse Name"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(368, 24)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(113, 18)
        Me.lbl_category.TabIndex = 831
        Me.lbl_category.Text = "Category Code* :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(896, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 20)
        Me.Button1.TabIndex = 832
        '
        'MembershipMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 622)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Name = "MembershipMaster"
        Me.Text = "MembershipMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
