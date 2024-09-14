Public Class frmMemberCorporate
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
    Friend WithEvents lbl_Address2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Address1 As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_MembershipTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_MembershipFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_CorporateCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_CorporateCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NumberOfMembers As System.Windows.Forms.Label
    Friend WithEvents cbo_CurrentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents lbl_CorporateName As System.Windows.Forms.Label
    Public WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents lbl_CurrentStatus As System.Windows.Forms.Label
    Friend WithEvents lbl_MembershipTo As System.Windows.Forms.Label
    Public WithEvents lbl_MembershipFrom As System.Windows.Forms.Label
    Friend WithEvents txt_NumberOfMembers As System.Windows.Forms.TextBox
    Friend WithEvents txt_CorporateName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents lbl_Address3 As System.Windows.Forms.Label
    Friend WithEvents txt_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DevelopmentFee As System.Windows.Forms.Label
    Public WithEvents lbl_EntranceFee As System.Windows.Forms.Label
    Friend WithEvents lbl_Class As System.Windows.Forms.Label
    Friend WithEvents lbl_Email As System.Windows.Forms.Label
    Friend WithEvents lbl_Pager As System.Windows.Forms.Label
    Friend WithEvents lbl_Fax As System.Windows.Forms.Label
    Friend WithEvents lbl_PhoneNo As System.Windows.Forms.Label
    Public WithEvents lbl_PinCode As System.Windows.Forms.Label
    Friend WithEvents lbl_State As System.Windows.Forms.Label
    Friend WithEvents lbl_City As System.Windows.Forms.Label
    Public WithEvents lbl_Country As System.Windows.Forms.Label
    Friend WithEvents txt_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_EntrenceFee As System.Windows.Forms.TextBox
    Friend WithEvents txt_Class As System.Windows.Forms.TextBox
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_Pager As System.Windows.Forms.TextBox
    Friend WithEvents txt_Fax As System.Windows.Forms.TextBox
    Friend WithEvents txt_PhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_DevelopmentFee As System.Windows.Forms.TextBox
    Friend WithEvents txt_Country As System.Windows.Forms.TextBox
    Friend WithEvents txt_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_MembershipTo_c As System.Windows.Forms.Button
    Friend WithEvents cmb_MembershipTo_c As System.Windows.Forms.ComboBox
    Friend WithEvents chk_EntranceFee As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Entrancefeedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Public WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents cmd_EntrancefeeCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_EntrancefeeOK As System.Windows.Forms.Button
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Entrancefee As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents cmdnominishow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents Cmdcancel As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label98 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMemberCorporate))
        Me.lbl_Address2 = New System.Windows.Forms.Label
        Me.lbl_Address3 = New System.Windows.Forms.Label
        Me.txt_Address3 = New System.Windows.Forms.TextBox
        Me.txt_Address2 = New System.Windows.Forms.TextBox
        Me.lbl_DevelopmentFee = New System.Windows.Forms.Label
        Me.lbl_EntranceFee = New System.Windows.Forms.Label
        Me.lbl_Class = New System.Windows.Forms.Label
        Me.lbl_Email = New System.Windows.Forms.Label
        Me.lbl_Pager = New System.Windows.Forms.Label
        Me.lbl_Fax = New System.Windows.Forms.Label
        Me.lbl_PhoneNo = New System.Windows.Forms.Label
        Me.lbl_PinCode = New System.Windows.Forms.Label
        Me.lbl_State = New System.Windows.Forms.Label
        Me.lbl_City = New System.Windows.Forms.Label
        Me.lbl_Country = New System.Windows.Forms.Label
        Me.lbl_Address1 = New System.Windows.Forms.Label
        Me.txt_State = New System.Windows.Forms.TextBox
        Me.txt_EntrenceFee = New System.Windows.Forms.TextBox
        Me.txt_Class = New System.Windows.Forms.TextBox
        Me.txt_Email = New System.Windows.Forms.TextBox
        Me.txt_Pager = New System.Windows.Forms.TextBox
        Me.txt_Fax = New System.Windows.Forms.TextBox
        Me.txt_PhoneNo = New System.Windows.Forms.TextBox
        Me.txt_PinCode = New System.Windows.Forms.TextBox
        Me.txt_DevelopmentFee = New System.Windows.Forms.TextBox
        Me.txt_Country = New System.Windows.Forms.TextBox
        Me.txt_City = New System.Windows.Forms.TextBox
        Me.txt_Address1 = New System.Windows.Forms.TextBox
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.dtp_MembershipTo = New System.Windows.Forms.DateTimePicker
        Me.dtp_MembershipFrom = New System.Windows.Forms.DateTimePicker
        Me.cmd_CorporateCodeHelp = New System.Windows.Forms.Button
        Me.txt_CorporateCode = New System.Windows.Forms.TextBox
        Me.lbl_NumberOfMembers = New System.Windows.Forms.Label
        Me.cbo_CurrentStatus = New System.Windows.Forms.ComboBox
        Me.lbl_CorporateCode = New System.Windows.Forms.Label
        Me.lbl_CorporateName = New System.Windows.Forms.Label
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.lbl_CurrentStatus = New System.Windows.Forms.Label
        Me.lbl_MembershipTo = New System.Windows.Forms.Label
        Me.lbl_MembershipFrom = New System.Windows.Forms.Label
        Me.txt_NumberOfMembers = New System.Windows.Forms.TextBox
        Me.txt_CorporateName = New System.Windows.Forms.TextBox
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Btn_MembershipTo_c = New System.Windows.Forms.Button
        Me.cmb_MembershipTo_c = New System.Windows.Forms.ComboBox
        Me.chk_EntranceFee = New System.Windows.Forms.CheckBox
        Me.grp_Entrancefeedetails = New System.Windows.Forms.GroupBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.cmd_EntrancefeeCancel = New System.Windows.Forms.Button
        Me.cmd_EntrancefeeOK = New System.Windows.Forms.Button
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.SSgrid_Entrancefee = New AxFPUSpreadADO.AxfpSpread
        Me.cmdnominishow = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ssgrid = New AxFPUSpreadADO.AxfpSpread
        Me.Cmdcancel = New System.Windows.Forms.Button
        Me.cmdok = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_remarks = New System.Windows.Forms.TextBox
        Me.Label98 = New System.Windows.Forms.Label
        Me.grp_Entrancefeedetails.SuspendLayout()
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Address2
        '
        Me.lbl_Address2.AutoSize = True
        Me.lbl_Address2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address2.Location = New System.Drawing.Point(56, 272)
        Me.lbl_Address2.Name = "lbl_Address2"
        Me.lbl_Address2.Size = New System.Drawing.Size(90, 21)
        Me.lbl_Address2.TabIndex = 38
        Me.lbl_Address2.Text = "Address 2 :"
        '
        'lbl_Address3
        '
        Me.lbl_Address3.AutoSize = True
        Me.lbl_Address3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address3.Location = New System.Drawing.Point(56, 304)
        Me.lbl_Address3.Name = "lbl_Address3"
        Me.lbl_Address3.Size = New System.Drawing.Size(90, 21)
        Me.lbl_Address3.TabIndex = 39
        Me.lbl_Address3.Text = "Address 3 :"
        '
        'txt_Address3
        '
        Me.txt_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Address3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Address3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address3.Location = New System.Drawing.Point(216, 306)
        Me.txt_Address3.MaxLength = 35
        Me.txt_Address3.Name = "txt_Address3"
        Me.txt_Address3.Size = New System.Drawing.Size(248, 25)
        Me.txt_Address3.TabIndex = 9
        Me.txt_Address3.Text = ""
        '
        'txt_Address2
        '
        Me.txt_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Address2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Address2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address2.Location = New System.Drawing.Point(216, 273)
        Me.txt_Address2.MaxLength = 35
        Me.txt_Address2.Name = "txt_Address2"
        Me.txt_Address2.Size = New System.Drawing.Size(248, 25)
        Me.txt_Address2.TabIndex = 8
        Me.txt_Address2.Text = ""
        '
        'lbl_DevelopmentFee
        '
        Me.lbl_DevelopmentFee.AutoSize = True
        Me.lbl_DevelopmentFee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DevelopmentFee.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DevelopmentFee.Location = New System.Drawing.Point(56, 520)
        Me.lbl_DevelopmentFee.Name = "lbl_DevelopmentFee"
        Me.lbl_DevelopmentFee.Size = New System.Drawing.Size(143, 21)
        Me.lbl_DevelopmentFee.TabIndex = 52
        Me.lbl_DevelopmentFee.Text = "Development Fee :"
        Me.lbl_DevelopmentFee.Visible = False
        '
        'lbl_EntranceFee
        '
        Me.lbl_EntranceFee.AutoSize = True
        Me.lbl_EntranceFee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EntranceFee.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EntranceFee.Location = New System.Drawing.Point(56, 488)
        Me.lbl_EntranceFee.Name = "lbl_EntranceFee"
        Me.lbl_EntranceFee.Size = New System.Drawing.Size(112, 21)
        Me.lbl_EntranceFee.TabIndex = 51
        Me.lbl_EntranceFee.Text = "Entrance Fee :"
        Me.lbl_EntranceFee.Visible = False
        '
        'lbl_Class
        '
        Me.lbl_Class.AutoSize = True
        Me.lbl_Class.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Class.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Class.Location = New System.Drawing.Point(536, 408)
        Me.lbl_Class.Name = "lbl_Class"
        Me.lbl_Class.Size = New System.Drawing.Size(129, 21)
        Me.lbl_Class.TabIndex = 50
        Me.lbl_Class.Text = "Contact Person :"
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Email.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.Location = New System.Drawing.Point(536, 376)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(74, 21)
        Me.lbl_Email.TabIndex = 47
        Me.lbl_Email.Text = "Email Id :"
        '
        'lbl_Pager
        '
        Me.lbl_Pager.AutoSize = True
        Me.lbl_Pager.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Pager.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pager.Location = New System.Drawing.Point(536, 344)
        Me.lbl_Pager.Name = "lbl_Pager"
        Me.lbl_Pager.Size = New System.Drawing.Size(60, 21)
        Me.lbl_Pager.TabIndex = 46
        Me.lbl_Pager.Text = "Mobile:"
        '
        'lbl_Fax
        '
        Me.lbl_Fax.AutoSize = True
        Me.lbl_Fax.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fax.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fax.Location = New System.Drawing.Point(536, 312)
        Me.lbl_Fax.Name = "lbl_Fax"
        Me.lbl_Fax.Size = New System.Drawing.Size(42, 21)
        Me.lbl_Fax.TabIndex = 45
        Me.lbl_Fax.Text = "Fax :"
        '
        'lbl_PhoneNo
        '
        Me.lbl_PhoneNo.AutoSize = True
        Me.lbl_PhoneNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PhoneNo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PhoneNo.Location = New System.Drawing.Point(536, 272)
        Me.lbl_PhoneNo.Name = "lbl_PhoneNo"
        Me.lbl_PhoneNo.Size = New System.Drawing.Size(87, 21)
        Me.lbl_PhoneNo.TabIndex = 44
        Me.lbl_PhoneNo.Text = "Phone No :"
        '
        'lbl_PinCode
        '
        Me.lbl_PinCode.AutoSize = True
        Me.lbl_PinCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PinCode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PinCode.Location = New System.Drawing.Point(536, 240)
        Me.lbl_PinCode.Name = "lbl_PinCode"
        Me.lbl_PinCode.Size = New System.Drawing.Size(82, 21)
        Me.lbl_PinCode.TabIndex = 43
        Me.lbl_PinCode.Text = "Pin Code :"
        '
        'lbl_State
        '
        Me.lbl_State.AutoSize = True
        Me.lbl_State.BackColor = System.Drawing.Color.Transparent
        Me.lbl_State.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_State.Location = New System.Drawing.Point(56, 376)
        Me.lbl_State.Name = "lbl_State"
        Me.lbl_State.Size = New System.Drawing.Size(53, 21)
        Me.lbl_State.TabIndex = 41
        Me.lbl_State.Text = "State :"
        '
        'lbl_City
        '
        Me.lbl_City.AutoSize = True
        Me.lbl_City.BackColor = System.Drawing.Color.Transparent
        Me.lbl_City.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_City.Location = New System.Drawing.Point(56, 344)
        Me.lbl_City.Name = "lbl_City"
        Me.lbl_City.Size = New System.Drawing.Size(44, 21)
        Me.lbl_City.TabIndex = 40
        Me.lbl_City.Text = "City :"
        '
        'lbl_Country
        '
        Me.lbl_Country.AutoSize = True
        Me.lbl_Country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Country.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Country.Location = New System.Drawing.Point(56, 408)
        Me.lbl_Country.Name = "lbl_Country"
        Me.lbl_Country.Size = New System.Drawing.Size(74, 21)
        Me.lbl_Country.TabIndex = 42
        Me.lbl_Country.Text = "Country :"
        '
        'lbl_Address1
        '
        Me.lbl_Address1.AutoSize = True
        Me.lbl_Address1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address1.Location = New System.Drawing.Point(56, 240)
        Me.lbl_Address1.Name = "lbl_Address1"
        Me.lbl_Address1.Size = New System.Drawing.Size(90, 21)
        Me.lbl_Address1.TabIndex = 37
        Me.lbl_Address1.Text = "Address 1 :"
        '
        'txt_State
        '
        Me.txt_State.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_State.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_State.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_State.Location = New System.Drawing.Point(216, 372)
        Me.txt_State.MaxLength = 35
        Me.txt_State.Name = "txt_State"
        Me.txt_State.Size = New System.Drawing.Size(160, 25)
        Me.txt_State.TabIndex = 11
        Me.txt_State.Text = ""
        '
        'txt_EntrenceFee
        '
        Me.txt_EntrenceFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_EntrenceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EntrenceFee.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EntrenceFee.Location = New System.Drawing.Point(216, 488)
        Me.txt_EntrenceFee.MaxLength = 9
        Me.txt_EntrenceFee.Name = "txt_EntrenceFee"
        Me.txt_EntrenceFee.Size = New System.Drawing.Size(160, 25)
        Me.txt_EntrenceFee.TabIndex = 19
        Me.txt_EntrenceFee.Text = ""
        Me.txt_EntrenceFee.Visible = False
        '
        'txt_Class
        '
        Me.txt_Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Class.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Class.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Class.Location = New System.Drawing.Point(712, 408)
        Me.txt_Class.MaxLength = 50
        Me.txt_Class.Name = "txt_Class"
        Me.txt_Class.Size = New System.Drawing.Size(248, 25)
        Me.txt_Class.TabIndex = 18
        Me.txt_Class.Text = ""
        '
        'txt_Email
        '
        Me.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Email.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(712, 376)
        Me.txt_Email.MaxLength = 35
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(248, 25)
        Me.txt_Email.TabIndex = 17
        Me.txt_Email.Text = ""
        '
        'txt_Pager
        '
        Me.txt_Pager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pager.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pager.Location = New System.Drawing.Point(712, 342)
        Me.txt_Pager.MaxLength = 15
        Me.txt_Pager.Name = "txt_Pager"
        Me.txt_Pager.Size = New System.Drawing.Size(160, 25)
        Me.txt_Pager.TabIndex = 16
        Me.txt_Pager.Text = ""
        '
        'txt_Fax
        '
        Me.txt_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Fax.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fax.Location = New System.Drawing.Point(712, 308)
        Me.txt_Fax.MaxLength = 15
        Me.txt_Fax.Name = "txt_Fax"
        Me.txt_Fax.Size = New System.Drawing.Size(160, 25)
        Me.txt_Fax.TabIndex = 15
        Me.txt_Fax.Text = ""
        '
        'txt_PhoneNo
        '
        Me.txt_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PhoneNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PhoneNo.Location = New System.Drawing.Point(712, 274)
        Me.txt_PhoneNo.MaxLength = 15
        Me.txt_PhoneNo.Name = "txt_PhoneNo"
        Me.txt_PhoneNo.Size = New System.Drawing.Size(160, 25)
        Me.txt_PhoneNo.TabIndex = 14
        Me.txt_PhoneNo.Text = ""
        '
        'txt_PinCode
        '
        Me.txt_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PinCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PinCode.Location = New System.Drawing.Point(712, 240)
        Me.txt_PinCode.MaxLength = 10
        Me.txt_PinCode.Name = "txt_PinCode"
        Me.txt_PinCode.Size = New System.Drawing.Size(160, 25)
        Me.txt_PinCode.TabIndex = 13
        Me.txt_PinCode.Text = ""
        '
        'txt_DevelopmentFee
        '
        Me.txt_DevelopmentFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_DevelopmentFee.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DevelopmentFee.Location = New System.Drawing.Point(216, 520)
        Me.txt_DevelopmentFee.MaxLength = 9
        Me.txt_DevelopmentFee.Name = "txt_DevelopmentFee"
        Me.txt_DevelopmentFee.Size = New System.Drawing.Size(160, 25)
        Me.txt_DevelopmentFee.TabIndex = 20
        Me.txt_DevelopmentFee.Text = ""
        Me.txt_DevelopmentFee.Visible = False
        '
        'txt_Country
        '
        Me.txt_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Country.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Country.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Country.Location = New System.Drawing.Point(216, 405)
        Me.txt_Country.MaxLength = 35
        Me.txt_Country.Name = "txt_Country"
        Me.txt_Country.Size = New System.Drawing.Size(160, 25)
        Me.txt_Country.TabIndex = 12
        Me.txt_Country.Text = ""
        '
        'txt_City
        '
        Me.txt_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_City.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_City.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_City.Location = New System.Drawing.Point(216, 339)
        Me.txt_City.MaxLength = 35
        Me.txt_City.Name = "txt_City"
        Me.txt_City.Size = New System.Drawing.Size(160, 25)
        Me.txt_City.TabIndex = 10
        Me.txt_City.Text = ""
        '
        'txt_Address1
        '
        Me.txt_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Address1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Address1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address1.Location = New System.Drawing.Point(216, 240)
        Me.txt_Address1.MaxLength = 35
        Me.txt_Address1.Name = "txt_Address1"
        Me.txt_Address1.Size = New System.Drawing.Size(248, 25)
        Me.txt_Address1.TabIndex = 7
        Me.txt_Address1.Text = ""
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"YEARLY", "HALF YEARLY", "QUARTERLY", "MONTHLY", "NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(216, 144)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(184, 25)
        Me.cbo_BillingBasis.TabIndex = 2
        '
        'dtp_MembershipTo
        '
        Me.dtp_MembershipTo.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_MembershipTo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipTo.Location = New System.Drawing.Point(712, 113)
        Me.dtp_MembershipTo.Name = "dtp_MembershipTo"
        Me.dtp_MembershipTo.Size = New System.Drawing.Size(160, 25)
        Me.dtp_MembershipTo.TabIndex = 4
        '
        'dtp_MembershipFrom
        '
        Me.dtp_MembershipFrom.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_MembershipFrom.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipFrom.Location = New System.Drawing.Point(712, 80)
        Me.dtp_MembershipFrom.Name = "dtp_MembershipFrom"
        Me.dtp_MembershipFrom.Size = New System.Drawing.Size(160, 25)
        Me.dtp_MembershipFrom.TabIndex = 3
        '
        'cmd_CorporateCodeHelp
        '
        Me.cmd_CorporateCodeHelp.Image = CType(resources.GetObject("cmd_CorporateCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CorporateCodeHelp.Location = New System.Drawing.Point(400, 80)
        Me.cmd_CorporateCodeHelp.Name = "cmd_CorporateCodeHelp"
        Me.cmd_CorporateCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_CorporateCodeHelp.TabIndex = 28
        '
        'txt_CorporateCode
        '
        Me.txt_CorporateCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_CorporateCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CorporateCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CorporateCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CorporateCode.Location = New System.Drawing.Point(216, 80)
        Me.txt_CorporateCode.MaxLength = 10
        Me.txt_CorporateCode.Name = "txt_CorporateCode"
        Me.txt_CorporateCode.Size = New System.Drawing.Size(184, 25)
        Me.txt_CorporateCode.TabIndex = 0
        Me.txt_CorporateCode.Text = ""
        '
        'lbl_NumberOfMembers
        '
        Me.lbl_NumberOfMembers.AutoSize = True
        Me.lbl_NumberOfMembers.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NumberOfMembers.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NumberOfMembers.Location = New System.Drawing.Point(536, 176)
        Me.lbl_NumberOfMembers.Name = "lbl_NumberOfMembers"
        Me.lbl_NumberOfMembers.Size = New System.Drawing.Size(167, 21)
        Me.lbl_NumberOfMembers.TabIndex = 35
        Me.lbl_NumberOfMembers.Text = "Number Of Members :"
        '
        'cbo_CurrentStatus
        '
        Me.cbo_CurrentStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_CurrentStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_CurrentStatus.Items.AddRange(New Object() {"LIVE", "INACTIVE", "ABSENTEE", "EXPIRED", "RESINGNED", "DELETED"})
        Me.cbo_CurrentStatus.Location = New System.Drawing.Point(712, 144)
        Me.cbo_CurrentStatus.Name = "cbo_CurrentStatus"
        Me.cbo_CurrentStatus.Size = New System.Drawing.Size(160, 25)
        Me.cbo_CurrentStatus.TabIndex = 5
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(56, 80)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(132, 21)
        Me.lbl_CorporateCode.TabIndex = 27
        Me.lbl_CorporateCode.Text = "Corporate Code :"
        '
        'lbl_CorporateName
        '
        Me.lbl_CorporateName.AutoSize = True
        Me.lbl_CorporateName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateName.Location = New System.Drawing.Point(56, 112)
        Me.lbl_CorporateName.Name = "lbl_CorporateName"
        Me.lbl_CorporateName.Size = New System.Drawing.Size(139, 21)
        Me.lbl_CorporateName.TabIndex = 29
        Me.lbl_CorporateName.Text = "Corporate Name  :"
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(56, 144)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(108, 21)
        Me.lbl_BillingBasis.TabIndex = 30
        Me.lbl_BillingBasis.Text = "Billing Basis :"
        '
        'lbl_CurrentStatus
        '
        Me.lbl_CurrentStatus.AutoSize = True
        Me.lbl_CurrentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CurrentStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CurrentStatus.Location = New System.Drawing.Point(536, 144)
        Me.lbl_CurrentStatus.Name = "lbl_CurrentStatus"
        Me.lbl_CurrentStatus.Size = New System.Drawing.Size(122, 21)
        Me.lbl_CurrentStatus.TabIndex = 34
        Me.lbl_CurrentStatus.Text = "Current Status :"
        '
        'lbl_MembershipTo
        '
        Me.lbl_MembershipTo.AutoSize = True
        Me.lbl_MembershipTo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MembershipTo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MembershipTo.Location = New System.Drawing.Point(536, 112)
        Me.lbl_MembershipTo.Name = "lbl_MembershipTo"
        Me.lbl_MembershipTo.Size = New System.Drawing.Size(129, 21)
        Me.lbl_MembershipTo.TabIndex = 33
        Me.lbl_MembershipTo.Text = "Membership To :"
        '
        'lbl_MembershipFrom
        '
        Me.lbl_MembershipFrom.AutoSize = True
        Me.lbl_MembershipFrom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MembershipFrom.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MembershipFrom.Location = New System.Drawing.Point(536, 80)
        Me.lbl_MembershipFrom.Name = "lbl_MembershipFrom"
        Me.lbl_MembershipFrom.Size = New System.Drawing.Size(149, 21)
        Me.lbl_MembershipFrom.TabIndex = 32
        Me.lbl_MembershipFrom.Text = "Membership From :"
        '
        'txt_NumberOfMembers
        '
        Me.txt_NumberOfMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NumberOfMembers.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NumberOfMembers.Location = New System.Drawing.Point(712, 176)
        Me.txt_NumberOfMembers.MaxLength = 9
        Me.txt_NumberOfMembers.Name = "txt_NumberOfMembers"
        Me.txt_NumberOfMembers.Size = New System.Drawing.Size(160, 25)
        Me.txt_NumberOfMembers.TabIndex = 6
        Me.txt_NumberOfMembers.Text = ""
        '
        'txt_CorporateName
        '
        Me.txt_CorporateName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_CorporateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CorporateName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CorporateName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CorporateName.Location = New System.Drawing.Point(216, 112)
        Me.txt_CorporateName.MaxLength = 35
        Me.txt_CorporateName.Name = "txt_CorporateName"
        Me.txt_CorporateName.Size = New System.Drawing.Size(184, 25)
        Me.txt_CorporateName.TabIndex = 1
        Me.txt_CorporateName.Text = ""
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(584, 608)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 25
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.Color.Transparent
        Me.cmd_ListView.BackgroundImage = CType(resources.GetObject("cmd_ListView.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Image = CType(resources.GetObject("cmd_ListView.Image"), System.Drawing.Image)
        Me.cmd_ListView.Location = New System.Drawing.Point(312, 608)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 23
        Me.cmd_ListView.Text = "List View[F8]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Delete.BackgroundImage = CType(resources.GetObject("cmd_Delete.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(448, 608)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 24
        Me.cmd_Delete.Text = "Freeze[F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.Color.Transparent
        Me.cmd_AddNew.BackgroundImage = CType(resources.GetObject("cmd_AddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Image = CType(resources.GetObject("cmd_AddNew.Image"), System.Drawing.Image)
        Me.cmd_AddNew.Location = New System.Drawing.Point(168, 608)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 22
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.ForeColor = System.Drawing.Color.Red
        Me.lbl_Caption.Location = New System.Drawing.Point(376, 16)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(275, 30)
        Me.lbl_Caption.TabIndex = 25
        Me.lbl_Caption.Text = " CORPORATE  MASTER"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Frez
        '
        Me.lbl_Frez.AutoSize = True
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(376, 560)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Frez.TabIndex = 57
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.BackgroundImage = CType(resources.GetObject("cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(720, 608)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 58
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(40, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 18)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Press [F4] For Help"
        '
        'Btn_MembershipTo_c
        '
        Me.Btn_MembershipTo_c.BackColor = System.Drawing.Color.Lime
        Me.Btn_MembershipTo_c.Location = New System.Drawing.Point(872, 112)
        Me.Btn_MembershipTo_c.Name = "Btn_MembershipTo_c"
        Me.Btn_MembershipTo_c.Size = New System.Drawing.Size(24, 24)
        Me.Btn_MembershipTo_c.TabIndex = 61
        Me.Btn_MembershipTo_c.Text = "C"
        '
        'cmb_MembershipTo_c
        '
        Me.cmb_MembershipTo_c.Location = New System.Drawing.Point(712, 112)
        Me.cmb_MembershipTo_c.Name = "cmb_MembershipTo_c"
        Me.cmb_MembershipTo_c.Size = New System.Drawing.Size(160, 26)
        Me.cmb_MembershipTo_c.TabIndex = 62
        '
        'chk_EntranceFee
        '
        Me.chk_EntranceFee.BackColor = System.Drawing.Color.Transparent
        Me.chk_EntranceFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_EntranceFee.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EntranceFee.Location = New System.Drawing.Point(376, 488)
        Me.chk_EntranceFee.Name = "chk_EntranceFee"
        Me.chk_EntranceFee.Size = New System.Drawing.Size(176, 24)
        Me.chk_EntranceFee.TabIndex = 68
        Me.chk_EntranceFee.Text = "Entrance Fee Details"
        Me.chk_EntranceFee.Visible = False
        '
        'grp_Entrancefeedetails
        '
        Me.grp_Entrancefeedetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label92)
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label93)
        Me.grp_Entrancefeedetails.Controls.Add(Me.cmd_EntrancefeeCancel)
        Me.grp_Entrancefeedetails.Controls.Add(Me.cmd_EntrancefeeOK)
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label94)
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label95)
        Me.grp_Entrancefeedetails.Controls.Add(Me.SSgrid_Entrancefee)
        Me.grp_Entrancefeedetails.Location = New System.Drawing.Point(239, 225)
        Me.grp_Entrancefeedetails.Name = "grp_Entrancefeedetails"
        Me.grp_Entrancefeedetails.Size = New System.Drawing.Size(496, 216)
        Me.grp_Entrancefeedetails.TabIndex = 69
        Me.grp_Entrancefeedetails.TabStop = False
        Me.grp_Entrancefeedetails.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Maroon
        Me.Label92.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.White
        Me.Label92.Location = New System.Drawing.Point(120, 8)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(230, 22)
        Me.Label92.TabIndex = 574
        Me.Label92.Text = "E n t r a n c e e F e e  D e t a i l s"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.Maroon
        Me.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label93.Location = New System.Drawing.Point(0, 8)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(496, 24)
        Me.Label93.TabIndex = 576
        '
        'cmd_EntrancefeeCancel
        '
        Me.cmd_EntrancefeeCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeCancel.Location = New System.Drawing.Point(280, 160)
        Me.cmd_EntrancefeeCancel.Name = "cmd_EntrancefeeCancel"
        Me.cmd_EntrancefeeCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeCancel.TabIndex = 2
        Me.cmd_EntrancefeeCancel.Text = "Cancel"
        '
        'cmd_EntrancefeeOK
        '
        Me.cmd_EntrancefeeOK.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeOK.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeOK.Location = New System.Drawing.Point(136, 160)
        Me.cmd_EntrancefeeOK.Name = "cmd_EntrancefeeOK"
        Me.cmd_EntrancefeeOK.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeOK.TabIndex = 1
        Me.cmd_EntrancefeeOK.Text = "Ok"
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label94.Location = New System.Drawing.Point(128, 168)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(108, 30)
        Me.Label94.TabIndex = 572
        Me.Label94.Text = "Label45"
        '
        'Label95
        '
        Me.Label95.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label95.Location = New System.Drawing.Point(272, 168)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(108, 30)
        Me.Label95.TabIndex = 573
        Me.Label95.Text = "Label46"
        '
        'SSgrid_Entrancefee
        '
        Me.SSgrid_Entrancefee.ContainingControl = Me
        Me.SSgrid_Entrancefee.DataSource = Nothing
        Me.SSgrid_Entrancefee.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_Entrancefee.Name = "SSgrid_Entrancefee"
        Me.SSgrid_Entrancefee.OcxState = CType(resources.GetObject("SSgrid_Entrancefee.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Entrancefee.Size = New System.Drawing.Size(480, 94)
        Me.SSgrid_Entrancefee.TabIndex = 0
        '
        'cmdnominishow
        '
        Me.cmdnominishow.BackColor = System.Drawing.Color.LimeGreen
        Me.cmdnominishow.Location = New System.Drawing.Point(872, 176)
        Me.cmdnominishow.Name = "cmdnominishow"
        Me.cmdnominishow.Size = New System.Drawing.Size(24, 23)
        Me.cmdnominishow.TabIndex = 75
        Me.cmdnominishow.Text = "see"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ssgrid)
        Me.GroupBox1.Controls.Add(Me.Cmdcancel)
        Me.GroupBox1.Controls.Add(Me.cmdok)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 256)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOMINEE LIST"
        Me.GroupBox1.Visible = False
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(16, 24)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(728, 192)
        Me.ssgrid.TabIndex = 1
        '
        'Cmdcancel
        '
        Me.Cmdcancel.BackColor = System.Drawing.Color.Blue
        Me.Cmdcancel.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdcancel.Location = New System.Drawing.Point(408, 224)
        Me.Cmdcancel.Name = "Cmdcancel"
        Me.Cmdcancel.TabIndex = 3
        Me.Cmdcancel.Text = "Cancel"
        '
        'cmdok
        '
        Me.cmdok.BackColor = System.Drawing.Color.Blue
        Me.cmdok.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdok.Location = New System.Drawing.Point(320, 224)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.TabIndex = 2
        Me.cmdok.Text = "OK"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(576, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Remarks  :"
        '
        'txt_remarks
        '
        Me.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_remarks.Location = New System.Drawing.Point(576, 456)
        Me.txt_remarks.MaxLength = 500
        Me.txt_remarks.Multiline = True
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(392, 96)
        Me.txt_remarks.TabIndex = 77
        Me.txt_remarks.Text = ""
        '
        'Label98
        '
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(48, 224)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(920, 216)
        Me.Label98.TabIndex = 36
        '
        'frmMemberCorporate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdnominishow)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_CorporateCode)
        Me.Controls.Add(Me.lbl_NumberOfMembers)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.lbl_CorporateName)
        Me.Controls.Add(Me.lbl_BillingBasis)
        Me.Controls.Add(Me.lbl_CurrentStatus)
        Me.Controls.Add(Me.lbl_MembershipTo)
        Me.Controls.Add(Me.lbl_MembershipFrom)
        Me.Controls.Add(Me.txt_NumberOfMembers)
        Me.Controls.Add(Me.txt_CorporateName)
        Me.Controls.Add(Me.lbl_Address2)
        Me.Controls.Add(Me.lbl_Address3)
        Me.Controls.Add(Me.txt_Address3)
        Me.Controls.Add(Me.txt_Address2)
        Me.Controls.Add(Me.lbl_DevelopmentFee)
        Me.Controls.Add(Me.lbl_EntranceFee)
        Me.Controls.Add(Me.lbl_Class)
        Me.Controls.Add(Me.lbl_Email)
        Me.Controls.Add(Me.lbl_Pager)
        Me.Controls.Add(Me.lbl_Fax)
        Me.Controls.Add(Me.lbl_PhoneNo)
        Me.Controls.Add(Me.lbl_PinCode)
        Me.Controls.Add(Me.lbl_State)
        Me.Controls.Add(Me.lbl_City)
        Me.Controls.Add(Me.lbl_Country)
        Me.Controls.Add(Me.lbl_Address1)
        Me.Controls.Add(Me.txt_State)
        Me.Controls.Add(Me.txt_EntrenceFee)
        Me.Controls.Add(Me.txt_Class)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.txt_Pager)
        Me.Controls.Add(Me.txt_Fax)
        Me.Controls.Add(Me.txt_PhoneNo)
        Me.Controls.Add(Me.txt_PinCode)
        Me.Controls.Add(Me.txt_DevelopmentFee)
        Me.Controls.Add(Me.txt_Country)
        Me.Controls.Add(Me.txt_City)
        Me.Controls.Add(Me.txt_Address1)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.txt_remarks)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.chk_EntranceFee)
        Me.Controls.Add(Me.Btn_MembershipTo_c)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.cbo_BillingBasis)
        Me.Controls.Add(Me.dtp_MembershipTo)
        Me.Controls.Add(Me.dtp_MembershipFrom)
        Me.Controls.Add(Me.cmd_CorporateCodeHelp)
        Me.Controls.Add(Me.cbo_CurrentStatus)
        Me.Controls.Add(Me.cmb_MembershipTo_c)
        Me.Controls.Add(Me.Label98)
        Me.Controls.Add(Me.grp_Entrancefeedetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmMemberCorporate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMemberCorporate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_Entrancefeedetails.ResumeLayout(False)
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim SqlString, emailst As String
    Dim boolchk As Boolean
    Dim gconnection As New GlobalClass
    Dim MembershipTo_VAL As String
    Dim ssql As String
    Dim CUR As Integer
    Private Sub frmMemberCorporate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        corporatebool = True
        cbo_CurrentStatus.Enabled = True
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

    Private Sub txt_CorporateCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CorporateCode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_CorporateName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CorporateName.KeyPress
        '    getAlphanumeric(e)
    End Sub

    Private Sub txt_NumberOfMembers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NumberOfMembers.KeyPress, txt_EntrenceFee.KeyPress, txt_DevelopmentFee.KeyPress
        getNumeric(e)
    End Sub
    Private Sub txt_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Address1.KeyPress, txt_Address2.KeyPress, txt_Address3.KeyPress
        'getAlphanumeric(e)
    End Sub

    Private Sub txt_City_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_City.KeyPress, txt_State.KeyPress, txt_Country.KeyPress
        getCharater(e)
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.txt_CorporateCode.Enabled = True
        Me.txt_CorporateCode.Focus()
        Me.cmd_AddNew.Text = "Add New[F5]"
        Me.cmd_Delete.Text = "Freeze[F7]"
        grp_Entrancefeedetails.Visible = True
        SSgrid_Entrancefee.ClearRange(1, 1, -1, -1, True)
        grp_Entrancefeedetails.Visible = False
        SSgrid_Entrancefee.Col = 1
        SSgrid_Entrancefee.Row = 1
        chk_EntranceFee.Checked = False
        Dim i As Integer
        For i = 1 To ssgrid.DataRowCnt
            With ssgrid
                .Row = i
                .Col = 1
                .Text = ""
                .Row = i
                .Col = 2
                .Text = ""
                .Row = i
                .Col = 3
                .Text = ""
                .Row = i
                .Col = 4
                .Text = ""
            End With
        Next i
    End Sub
    Private Sub txt_CorporateCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CorporateCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_CorporateCode.Text <> "" Then
                Call txt_CorporateCode_Validated(sender, e)
            Else
                Call cmd_CorporateCodeHelp_Click(sender, e)

            End If

        End If
        txt_CorporateName.Focus()
    End Sub
    Private Sub txt_CorporateName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CorporateName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_MembershipFrom.Focus()
        End If
    End Sub
    Private Sub dtp_MembershipFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_MembershipFrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_MembershipTo.Focus()
        End If
    End Sub
    Private Sub dtp_MembershipTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_MembershipTo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_CurrentStatus.Focus()
        End If
        If e.KeyCode = Keys.Delete Then
            Btn_MembershipTo_c.Text = "C"
            Btn_MembershipTo_c_FUN()
        End If
    End Sub
    Private Sub cbo_CurrentStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_CurrentStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_NumberOfMembers.Focus()
        End If
    End Sub
    Private Sub txt_NumberOfMembers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_NumberOfMembers.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Address1.Focus()
        End If
    End Sub
    Private Sub txt_Address1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Address1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Address2.Focus()
        End If
    End Sub
    Private Sub txt_Address2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Address3.Focus()
        End If
    End Sub
    Private Sub txt_Address3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_City.Focus()
        End If
    End Sub
    Private Sub txt_City_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_City.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_State.Focus()
        End If
    End Sub
    Private Sub txt_State_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_State.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Country.Focus()
        End If
    End Sub
    Private Sub txt_Country_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Country.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_PinCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_PhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Fax.Focus()
        End If
    End Sub

    Private Sub txt_Fax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Fax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Pager.Focus()
        End If
    End Sub

    Private Sub txt_Pager_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Pager.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Email.Focus()
        End If
    End Sub

    Private Sub txt_Email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Class.Focus()
        End If
    End Sub

    Private Sub txt_Class_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Class.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_EntrenceFee.Focus()
        End If
    End Sub

    Private Sub txt_EntrenceFee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_EntrenceFee.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_DevelopmentFee.Focus()
        End If
    End Sub

    Private Sub txt_DevelopmentFee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_DevelopmentFee.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Mid(cmd_AddNew.Text, 1, 1) = "A" Then
                cmd_AddNew.Focus()
            ElseIf Mid(cmd_AddNew.Text, 1, 1) = "U" Then
                cmd_AddNew.Focus()
            End If
        End If
    End Sub

    Private Sub frmMemberCorporate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F4 Then
            Call cmd_CorporateCodeHelp_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Function InsertZoomTable(ByVal tabname As String) As String
        Dim i As Integer
        Dim j As Integer
        Dim dr As DataRow
        Dim sql As String
        Dim cnt As Integer
        cnt = gdataset.Tables(tabname).Rows.Count
        If cnt > 3 Then
            cnt = 2
        Else
            cnt = gdataset.Tables(tabname).Rows.Count
            cnt = cnt - 1
        End If
        For i = 0 To cnt
            dr = gdataset.Tables(tabname).NewRow
            dr = gdataset.Tables(tabname).Rows(i)
            For j = 0 To gdataset.Tables(tabname).Columns.Count - 1
                If Trim(sql) = "" Then
                    If Trim(Convert.ToString(dr.Item(j))) = "" Then
                        sql = "''"
                    Else
                        sql = "'" & dr.Item(j) & "'"
                    End If
                Else
                    If Trim(Convert.ToString(dr.Item(j))) = "" Then
                        sql = "''"
                    Else
                        sql = sql & ",'" & dr.Item(j) & "'"
                    End If
                End If
            Next j
        Next i
        Return sql
    End Function
    Private Function InsertZoomTable1(ByVal tabname As String) As String
        Dim i, amt As Integer
        Dim j As Integer
        Dim dr As DataRow
        Dim sql, Startdt As String
        Dim cnt As Integer
        If cmd_AddNew.Text = "Add New[F5]" Then
            'cnt = gdataset.Tables(tabname).Rows.Count
            'If cnt > 3 Then
            '    cnt = 2
            'Else
            '    cnt = gdataset.Tables(tabname).Rows.Count
            '    cnt = cnt - 1
            'End If
            'For i = 0 To cnt
            '    dr = gdataset.Tables(tabname).NewRow
            '    dr = gdataset.Tables(tabname).Rows(i)
            '    For j = 0 To gdataset.Tables(tabname).Columns.Count - 1
            '        If Trim(sql) = "" Then
            '            If Trim(Convert.ToString(dr.Item(j))) = "" Then
            '                If j = 2 Then
            '                    sql = "0"
            '                Else
            '                    If j = 3 Then
            '                        Startdt = dr.Item(j)
            '                        sql = sql & "startdate1='" & Format(CDate(Startdt), "dd-mmm-yyyy") & "',"
            '                    Else
            '                        sql = sql & ",'" & dr.Item(j) & "'"
            '                    End If
            '                End If
            '            Else
            '                If j = 2 Then
            '                    sql = "" & dr.Item(j) & ""
            '                Else
            '                    If j = 1 Then
            '                        Startdt = dr.Item(j)
            '                        sql = sql & "startdate1='" & Format(CDate(Startdt), "dd-mmm-yyyy") & "',"
            '                    Else
            '                        sql = sql & ",'" & dr.Item(j) & "'"
            '                    End If
            '                End If
            '            End If
            '        Else
            '            If Trim(Convert.ToString(dr.Item(j))) = "" Then
            '                If j = 2 Then
            '                    sql = sql & ",0"
            '                Else
            '                    If j = 1 Then
            '                        Startdt = dr.Item(j)
            '                        sql = sql & "startdate1='" & Format(CDate(Startdt), "dd-mmm-yyyy") & "',"
            '                    Else
            '                        sql = sql & ",'" & dr.Item(j) & "'"
            '                    End If
            '                End If
            '            Else
            '                If j = 2 Then
            '                    sql = sql & "," & dr.Item(j) & ""
            '                Else
            '                    If j = 3 Then
            '                        Startdt = dr.Item(1)
            '                        sql = sql & "startdate1='" & Format(CDate(Startdt), "dd-mmm-yyyy") & "',"
            '                    Else
            '                        sql = sql & ",'" & dr.Item(j) & "'"
            '                    End If
            '                End If
            '            End If
            '        End If
            '    Next j
            'Next i
            '----------------
            '            Dim strSQL As String
            'With SSgrid_Entrancefee
            '    .Row = 1
            '    .Col = 1
            '    IIf(.Text = "", "'',", "'" & .Text & "',")
            '    .Row = 1
            '    .Col = 2
            '    IIf(.Text = "", "'',", "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',")
            '    .Row = 1
            '    .Col = 3
            '    IIf(.Text = "", "0,", .Text & ",")
            'End With

            dr = gdataset.Tables(tabname).NewRow
            dr = gdataset.Tables(tabname).Rows(0)
            sql = ""
            sql = sql & " '" & dr.Item(0) & "',"
            sql = sql & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If Trim(CStr(dr.Item(2))) = "" Then
                sql = sql & "0.00,"
                Format(dr.Item("CMEntranceFee"), "0.00")
            Else
                sql = sql & dr.Item(2) & ","
            End If
            dr = gdataset.Tables(tabname).Rows(1)
            sql = sql & "'" & dr.Item(0) & "',"
            sql = sql & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If dr.Item(2) = "" Then
                sql = sql & "0.00,"
            Else
                sql = sql & dr.Item(2) & ","
            End If

            dr = gdataset.Tables(tabname).Rows(2)
            sql = sql & "'" & dr.Item(0) & "',"
            Startdt = dr.Item(1)
            sql = sql & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If dr.Item(2) = "" Then
                sql = sql & "0.00"
            Else
                sql = sql & dr.Item(2)
            End If
            '----------------
        Else
            dr = gdataset.Tables(tabname).NewRow
            dr = gdataset.Tables(tabname).Rows(0)
            sql = ""
            sql = sql & "receiptno1='" & dr.Item(0) & "',"
            sql = sql & "startdate1=" & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If dr.Item(2) = "" Then
                sql = sql & "amount1=0.00,"
            Else
                sql = sql & "amount1=" & dr.Item(2) & ","
            End If
            dr = gdataset.Tables(tabname).Rows(1)
            sql = sql & "receiptno2='" & dr.Item(0) & "',"
            Startdt = dr.Item(1)
            sql = sql & "startdate2=" & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If dr.Item(2) = "" Then
                sql = sql & "amount2=0.00,"
            Else
                sql = sql & "amount2=" & dr.Item(2) & ","
            End If
            dr = gdataset.Tables(tabname).Rows(2)
            sql = sql & "receiptno3='" & dr.Item(0) & "',"
            Startdt = dr.Item(1)
            sql = sql & "startdate3=" & IIf(dr.Item(1) = "", "''", "'" & Format(CDate(dr.Item(1)), "dd/MMM/yyyy") & "'") & ","
            If dr.Item(2) = "" Then
                sql = sql & "amount3=0.00"
            Else
                sql = sql & "amount3=" & dr.Item(2) & ""
            End If
        End If
        Return sql
    End Function
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        ' MODIFIDE FOR SUBCD
        Dim Sreader As New DataTable
        Dim ssql, insert(0) As String
        Dim MAXSUBCD As Integer

        ssql = " Select MAX(isnull(SUBCD ,0))+1 AS MAXSUBCD From membermaster"
        gconnection.getDataSet(ssql, "max")
        If gdataset.Tables("max").Rows.Count > 0 Then
            MAXSUBCD = gdataset.Tables("max").Rows(0).Item("MAXSUBCD")
        End If
        '************************************************
        Dim strSQL As String
        If cmd_AddNew.Text = "Add New[F5]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Me.chk_EntranceFee.Checked = True Then
                strSQL = strSQL & ",receiptno1,startdate1,amount1," & _
                "receiptno2,startdate2,amount2,receiptno3,startdate3,amount3 "
            End If
            strSQL = "INSERT INTO CorporateMaster(SUBCD,CMCorporateCode,CMCorporateName,CMBilling,REMARKS,MemberShipFrom,MemberShipTo," & _
            "CurrentStatus,CMNomembers,CMAddress1,CMAddress2,CMAddress3,CMCity,CMState,CMCountry,CMPin,CMPhone,CMFax,CMPager," & _
            "CMEmail,CMClass,CMEntranceFee,CMDevelopmentFund,AddUser,AddDate,freeze,entrancefeest"
            If Me.chk_EntranceFee.Checked = True Then
                strSQL = strSQL & ",receiptno1,startdate1,amount1," & _
                "receiptno2,startdate2,amount2,receiptno3,startdate3,amount3 "
            End If
            strSQL = strSQL & ")"
            strSQL = strSQL & "VALUES ( '" & MAXSUBCD & "','" & Trim(txt_CorporateCode.Text) & " '," & _
            "'" & Trim(txt_CorporateName.Text) & "','" & Trim(cbo_BillingBasis.Text) & "','" & txt_remarks.Text & "','" & Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy") & "'," & _
            "'" & Format(dtp_MembershipTo.Value, "dd-MMM-yyyy") & "','" & cbo_CurrentStatus.Text & "'," & Val(txt_NumberOfMembers.Text) & "," & _
            "'" & Trim(txt_Address1.Text) & "','" & Trim(txt_Address2.Text) & "','" & Trim(txt_Address3.Text) & "','" & Trim(txt_City.Text) & "'," & _
            "'" & Trim(txt_State.Text) & "','" & Trim(txt_Country.Text) & "','" & Trim(txt_PinCode.Text) & "','" & Trim(txt_PhoneNo.Text) & "','" & Trim(txt_Fax.Text) & "'," & _
            "'" & Trim(txt_Pager.Text) & "','" & (txt_Email.Text) & "','" & Trim(txt_Class.Text) & "'," & Val(txt_EntrenceFee.Text) & "," & Val(txt_DevelopmentFee.Text) & "," & _
            "'" & Trim(gUsername) & "','" & Format(Now.Today(), "dd-MMM-yyyy hh:mm") & "','N'"
            If Me.chk_EntranceFee.Checked = True Then
                strSQL = strSQL & ",'Y'"
                For CUR = 1 To 3
                    With SSgrid_Entrancefee
                        .Col = 1
                        .Row = CUR
                        strSQL = strSQL & "," & IIf(Len(Trim(.Text)) = 0, "''", "'" & .Text & "'")
                        .Col = 2
                        .Row = CUR
                        If Len(Trim(.Text)) = 0 Then
                            strSQL = strSQL & ",''"
                        Else
                            strSQL = strSQL & "," & IIf(.Text = "", "''", "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "'")
                        End If
                        .Col = 3
                        .Row = CUR
                        strSQL = strSQL & "," & IIf(Len(Trim(.Text)) = 0, "''", "'" & .Text & "'")
                    End With
                Next
            Else
                strSQL = strSQL & ",'N'"
            End If
            strSQL = strSQL & ")"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = strSQL
            strSQL = "INSERT INTO ACCOUNTSSUBLEDGERMASTER(ACCODE,ACDESC,SLTYPE,SLCODE,SLNAME,SLDESC,CONTACTPERSON,ADDRESS1,ADDRESS2,ADDRESS3,CITY,STATE,PIN,PHONENO) "
            strSQL = strSQL & "VALUES ('SDRS','SUNDRY DEBTORS','MEMBER','" & Trim(Me.txt_CorporateCode.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_Address1.Text) & "','" & Trim(txt_Address2.Text) & "','" & Trim(txt_Address3.Text) & "','" & Trim(Me.txt_City.Text) & "','" & Trim(txt_State.Text) & "','" & Trim(txt_PinCode.Text) & "','" & Trim(Me.txt_PhoneNo.Text) & "')" ','" & Fz & "')"
            ReDim Preserve Insert(Insert.Length)
            insert(insert.Length - 1) = strSQL
            strSQL = "INSERT INTO membermaster(SUBCD,MCODE,MNAME,CONTADD1,CONTADD2,contadd3,CONTCITY,CONTSTATE,CONTPIN,Billbasis) "
            strSQL = strSQL & "VALUES ('" & MAXSUBCD & "','" & Trim(Me.txt_CorporateCode.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_Address1.Text) & "','" & Trim(txt_Address2.Text) & "','" & Trim(txt_Address3.Text) & "','" & Trim(Me.txt_City.Text) & "','" & Trim(txt_State.Text) & "','" & Trim(txt_PinCode.Text) & "','NONE')" ','" & Fz & "')"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = strSQL

            gconnection.MoreTrans(insert)
            'MessageBox.Show("Record Saved ", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MessageBox.Show("Record Added Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If chk_EntranceFee.Checked = True Then
                grp_Entrancefeedetails.Visible = True
                SSgrid_Entrancefee.ClearRange(1, 1, -1, -1, True)
                grp_Entrancefeedetails.Visible = False
                SSgrid_Entrancefee.Col = 1
                SSgrid_Entrancefee.Row = 1
                chk_EntranceFee.Checked = False
            End If
            Me.cmd_Clear_Click(sender, e)
        ElseIf cmd_AddNew.Text = "Update[F5]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.cmd_AddNew.Text, 1, 1) = "U" Then
                If Me.lbl_Frez.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub
            SqlString = "UPDATE  CorporateMaster"
            SqlString = SqlString & " SET CMCorporateName='" & Trim(txt_CorporateName.Text) & "',CMBilling='" & Trim(cbo_BillingBasis.Text) & "',MemberShipFrom= '" & Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy") & "'," & _
            "MemberShipTo='" & Format(dtp_MembershipTo.Value, "dd-MMM-yyyy") & "',remarks='" & txt_remarks.Text & "',CurrentStatus='" & cbo_CurrentStatus.Text & "',CMNomembers='" & Trim(txt_NumberOfMembers.Text) & "',CMAddress1='" & Trim(txt_Address1.Text) & "'," & _
            "CMAddress2='" & Trim(txt_Address2.Text) & "',CMAddress3='" & Trim(txt_Address3.Text) & "',CMCity='" & Trim(txt_City.Text) & "',CMState='" & Trim(txt_State.Text) & "',CMCountry='" & Trim(txt_Country.Text) & "',CMPin='" & Trim(txt_PinCode.Text) & "'," & _
            "CMPhone='" & Trim(txt_PhoneNo.Text) & "',CMFax='" & Trim(txt_Fax.Text) & "',CMPager='" & Trim(txt_Pager.Text) & "'," & _
            "CMEmail='" & Trim(txt_Email.Text) & "',CMClass='" & Trim(txt_Class.Text) & "',CMEntranceFee=" & Val(txt_EntrenceFee.Text) & ",CMDevelopmentFund=" & Val(txt_DevelopmentFee.Text) & ",AddUser='" & Trim(gUsername) & "',AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            If Me.chk_EntranceFee.Checked = True Then
                For CUR = 1 To 3
                    With SSgrid_Entrancefee
                        .Col = 1
                        .Row = CUR
                        SqlString = SqlString & ", receiptno" & CUR & " =" & IIf(Len(Trim(.Text)) = 0, "''", "'" & .Text & "'")
                        .Col = 2
                        .Row = CUR
                        If Len(Trim(.Text)) = 0 Then
                            SqlString = SqlString & ", startdate" & CUR & "=''"
                        Else
                            SqlString = SqlString & ", startdate" & CUR & "=" & IIf(.Text = "", "''", "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "'")
                        End If
                        .Col = 3
                        .Row = CUR
                        SqlString = SqlString & ", amount" & CUR & "=" & IIf(Len(Trim(.Text)) = 0, "''", "'" & .Text & "'")
                    End With
                Next
                SqlString = SqlString & ", entrancefeest= 'Y'"
            End If
            SqlString = SqlString & " WHERE CMCorporateCode = '" & Trim(txt_CorporateCode.Text) & "'"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = SqlString
           
          
            ssql = "select * from accountssubledgermaster where accode='sdrs' and slcode='" & Trim(Me.txt_CorporateCode.Text) & "'"
            gconnection.getDataSet(ssql, "acc")
            If gdataset.Tables("acc").Rows.Count > 0 Then
                strSQL = "update ACCOUNTSSUBLEDGERMASTER set SLNAME='" & Me.txt_CorporateName.Text & "',SLDESC='" & Me.txt_CorporateName.Text & "',CONTACTPERSON='" & Me.txt_CorporateName.Text & "',ADDRESS1='" & Me.txt_Address1.Text & "',ADDRESS2='" & Me.txt_Address2.Text & "',ADDRESS3='" & Me.txt_Address3.Text & "',CITY='" & Me.txt_City.Text & "',STATE='" & Me.txt_State.Text & "',PIN='" & Me.txt_PinCode.Text & "',PHONENO='" & Me.txt_PhoneNo.Text & "' where accode='SDRS' and slcode='" & Me.txt_CorporateCode.Text & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = strSQL
            Else
                strSQL = "INSERT INTO ACCOUNTSSUBLEDGERMASTER(ACCODE,ACDESC,SLTYPE,SLCODE,SLNAME,SLDESC,CONTACTPERSON,ADDRESS1,ADDRESS2,ADDRESS3,CITY,STATE,PIN,PHONENO) "
                strSQL = strSQL & "VALUES ('SDRS','SUNDRY DEBTORS','MEMBER','" & Trim(Me.txt_CorporateCode.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_Address1.Text) & "','" & Trim(txt_Address2.Text) & "','" & Trim(txt_Address3.Text) & "','" & Trim(Me.txt_City.Text) & "','" & Trim(txt_State.Text) & "','" & Trim(txt_PinCode.Text) & "','" & Trim(Me.txt_PhoneNo.Text) & "')" ','" & Fz & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = strSQL
            End If
            ssql = "select * from membermaster where  mcode='" & Trim(Me.txt_CorporateCode.Text) & "'"
            gconnection.getDataSet(ssql, "mem")
            If gdataset.Tables("acc").Rows.Count > 0 Then
                strSQL = "update membermaster MNAME='" & Me.txt_CorporateName.Text & "',CONTADD1='" & Me.txt_Address1.Text & "',CONTADD2='" & Me.txt_Address2.Text & "',contadd3='" & Me.txt_Address3.Text & "',CONTCITY='" & Me.txt_City.Text & "',CONTSTATE='" & Me.txt_State.Text & "' where MCODE='" & Me.txt_CorporateCode.Text & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = strSQL
            Else
                strSQL = "INSERT INTO membermaster(SUBCD,MCODE,MNAME,CONTADD1,CONTADD2,contadd3,CONTCITY,CONTSTATE,CONTPIN,Billbasis) "
                strSQL = strSQL & "VALUES ('" & MAXSUBCD & "','" & Trim(Me.txt_CorporateCode.Text) & "','" & Trim(Me.txt_CorporateName.Text) & "','" & Trim(Me.txt_Address1.Text) & "','" & Trim(txt_Address2.Text) & "','" & Trim(txt_Address3.Text) & "','" & Trim(Me.txt_City.Text) & "','" & Trim(txt_State.Text) & "','" & Trim(txt_PinCode.Text) & "','NONE')" ','" & Fz & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = strSQL
            End If
            gconnection.MoreTrans(insert)
            'MessageBox.Show("Record Updated ", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("Record Updated Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If chk_EntranceFee.Checked = True Then
                grp_Entrancefeedetails.Visible = True
                SSgrid_Entrancefee.ClearRange(1, 1, -1, -1, True)
                grp_Entrancefeedetails.Visible = False
                SSgrid_Entrancefee.Col = 1
                SSgrid_Entrancefee.Row = 1
                chk_EntranceFee.Checked = False
            End If
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
            End If
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Delete.Text, 1, 1) = "F" Then
            SqlString = "UPDATE  CorporateMaster "
            SqlString = SqlString & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE CMCorporateCode = '" & txt_CorporateCode.Text & " '"
            gconnection.dataOperation(3, SqlString, "CorporateMaster")
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        Else
            SqlString = "UPDATE  CorporateMaster "
            SqlString = SqlString & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE CMCorporateCode = '" & txt_CorporateCode.Text & " '"
            gconnection.dataOperation(4, SqlString, "CorporateMaster")
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        End If
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM CorporateMaster"
        Gheader = "CORPORATE MASTER"
        FrReport.SsGridReport.SetText(2, 1, "CMCorporateCode")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "CMCorporateName")
        FrReport.SsGridReport.SetText(3, 2, 30)
        'FrReport.SsGridReport.SetText(2, 3, "CMBilling")
        'FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 3, "MemberShipFrom")
        FrReport.SsGridReport.SetText(3, 3, 12)
        FrReport.SsGridReport.SetText(2, 4, "MemberShipTo")
        FrReport.SsGridReport.SetText(3, 4, 12)
        FrReport.SsGridReport.SetText(2, 5, "CurrentStatus")
        FrReport.SsGridReport.SetText(3, 5, 8)
        FrReport.SsGridReport.SetText(2, 6, "CMNomembers")
        FrReport.SsGridReport.SetText(3, 6, 15)
        FrReport.SsGridReport.SetText(2, 7, "CMAddress1")
        FrReport.SsGridReport.SetText(3, 7, 20)
        FrReport.SsGridReport.SetText(2, 8, "CMAddress2")
        FrReport.SsGridReport.SetText(3, 8, 20)
        FrReport.SsGridReport.SetText(2, 9, "CMAddress3")
        FrReport.SsGridReport.SetText(3, 9, 20)
        FrReport.SsGridReport.SetText(2, 10, "CMCountry")
        FrReport.SsGridReport.SetText(3, 10, 15)
        FrReport.SsGridReport.SetText(2, 11, "CMCity")
        FrReport.SsGridReport.SetText(3, 11, 15)
        FrReport.SsGridReport.SetText(2, 12, "CMState")
        FrReport.SsGridReport.SetText(3, 12, 15)
        FrReport.SsGridReport.SetText(2, 13, "CMPin")
        FrReport.SsGridReport.SetText(3, 13, 10)
        'FrReport.SsGridReport.SetText(2, 15, "CMPhone")
        'FrReport.SsGridReport.SetText(3, 15, 12)
        'FrReport.SsGridReport.SetText(2, 16, "CMFax")
        'FrReport.SsGridReport.SetText(3, 16, 10)
        'FrReport.SsGridReport.SetText(2, 17, "CMPager")
        'FrReport.SsGridReport.SetText(3, 17, 10)
        'FrReport.SsGridReport.SetText(2, 18, "CMEmail")
        'FrReport.SsGridReport.SetText(3, 18, 30)
        'FrReport.SsGridReport.SetText(2, 19, "CMClass")
        'FrReport.SsGridReport.SetText(3, 19, 15)
        'FrReport.SsGridReport.SetText(2, 20, "CMEntranceFee")
        'FrReport.SsGridReport.SetText(3, 20, 10)
        'FrReport.SsGridReport.SetText(2, 21, "CMDevelopmentFund")
        'FrReport.SsGridReport.SetText(3, 21, 10)
        'FrReport.SsGridReport.SetText(2, 22, "freeze")
        'FrReport.SsGridReport.SetText(3, 22, 2)
        FrReport.Show()
    End Sub
    Private Sub cmd_CorporateCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CorporateCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select CMCorporateCode,CMCorporateName from CorporateMaster"
        M_WhereCondition = " "
        vform.Field = "CMCorporateCode,CMCorporateName"
        vform.vFormatstring = "  Corporate Code  | Corporate Name                           "
        vform.vCaption = "Corporate Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_CorporateCode.Text = Trim(vform.keyfield & "")
            txt_CorporateName.Select()
            txt_CorporateCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_AddNew.Text = "Update[F5]"

    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Corporate Code is blank
        If txt_CorporateCode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CorporateCode.Focus()
            Exit Sub
        End If
        '''********** Check Corporate Name is blank
        If txt_CorporateName.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_CorporateName.Focus()
            Exit Sub
        End If
        '''********** Check Corporate Name is blank
        If txt_State.Text = "" Then
            MessageBox.Show(" State field can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_State.Focus()
            Exit Sub
        End If
        '''********** Check Corporate Name is blank
        'If Val(txt_EntrenceFee.Text) = 0 Then
        '    MessageBox.Show(" EntrenceFee field can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_EntrenceFee.Focus()
        '    Exit Sub
        'End If
        ''*********** Check Email Id is blank
        If txt_Email.Text <> "" Then
            emailst = getEmail(txt_Email)
            If emailst <> "T" Then
                Exit Sub
            End If
        End If
        '''************* Check Billing Basis
        If cbo_BillingBasis.Text = "" Then
            MessageBox.Show(" Billing Basis field can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_BillingBasis.Focus()
            Exit Sub
        End If
        '''**************** Check Current Status
        If cbo_CurrentStatus.Text = "" Then
            MessageBox.Show(" Current Status field can't be blank ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_CurrentStatus.Focus()
            Exit Sub
        End If
        '''**************** Check From Date 
        'If Format(dtp_MembershipTo.Value, "dd-MMM-yyyy") <= Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy") Then
        '    MessageBox.Show(" Membershipfrom Date field can't More then Membershipto Date ", "Calculate Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    dtp_MembershipFrom.Focus()
        '    Exit Sub
        'End If
        boolchk = True
    End Sub

    Private Sub cbo_BillingBasis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BillingBasis.KeyPress
        BLANK(e)
    End Sub

    Private Sub cbo_CurrentStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_CurrentStatus.KeyPress
        BLANK(e)
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            txt_CorporateCode.Focus()
        End If
    End Sub
    Private Sub txt_CorporateCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CorporateCode.Validated
        Dim Sreader As New DataTable
        Dim ssql As String
        ssql = " Select isnull(remarks,'')as rem,* From CorporateMaster Where CMCorporateCode='" & Me.txt_CorporateCode.Text & "'"
        Sreader = gconnection.GetValues(ssql)
        If Sreader.Rows.Count > 0 Then
            Me.txt_CorporateCode.Enabled = False
            Me.cbo_CurrentStatus.Enabled = False
            Me.txt_CorporateName.Text = Sreader.Rows(0).Item("CMCorporateName")
            Me.cbo_BillingBasis.Text = Sreader.Rows(0).Item("CMBilling")
            Me.dtp_MembershipFrom.Value = Format(Sreader.Rows(0).Item("MemberShipFrom"), "dd/MM/yyyy")
            Me.txt_remarks.Text = Sreader.Rows(0).Item("rem")
            'Me.dtp_MembershipTo.Value = Format(Sreader.Rows(0).Item("MemberShipTo"), "dd/MM/yyyy")
            If Format(Sreader.Rows(0).Item("membershipto"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                Btn_MembershipTo_c.Text = "C"
                Btn_MembershipTo_c_FUN()
            Else
                Me.dtp_MembershipTo.Value = Format(Sreader.Rows(0).Item("membershipto"), "dd-MMM-yyyy")
            End If
            Me.cbo_CurrentStatus.Text = Sreader.Rows(0).Item("CurrentStatus")
            Me.txt_NumberOfMembers.Text = Sreader.Rows(0).Item("CMNomembers")
            Me.txt_Address1.Text = Sreader.Rows(0).Item("CMAddress1")
            Me.txt_Address2.Text = Sreader.Rows(0).Item("CMAddress2")
            Me.txt_Address3.Text = Sreader.Rows(0).Item("CMAddress3")
            Me.txt_City.Text = Sreader.Rows(0).Item("CMCity")
            Me.txt_State.Text = Sreader.Rows(0).Item("CMState")
            Me.txt_Country.Text = Sreader.Rows(0).Item("CMCountry")
            Me.txt_PinCode.Text = Sreader.Rows(0).Item("CMPin")
            Me.txt_PhoneNo.Text = Sreader.Rows(0).Item("CMPhone")
            Me.txt_Fax.Text = Sreader.Rows(0).Item("CMFax")
            Me.txt_Pager.Text = Sreader.Rows(0).Item("CMPager")
            Me.txt_Email.Text = Sreader.Rows(0).Item("CMEmail")
            Me.txt_Class.Text = Sreader.Rows(0).Item("CMClass")
            Me.txt_EntrenceFee.Text = Format(Sreader.Rows(0).Item("CMEntranceFee"), "0.00")
            Me.txt_DevelopmentFee.Text = Format(Sreader.Rows(0).Item("CMDevelopmentFund"), "0.00")
            ''MODIFIED BY SRINIVAS N >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Try
                If Trim(Sreader.Rows(0).Item("entrancefeest")) = "Y" Then
                    chk_EntranceFee.Checked = True
                    grp_Entrancefeedetails.Visible = False
                    With SSgrid_Entrancefee()
                        For CUR = 1 To 3
                            .Row = CUR
                            .Col = 1
                            .Text = Trim(Sreader.Rows(0).Item("receiptno" & CUR))
                            .Col = 2
                            .Text = Format(DateValue(Trim(Sreader.Rows(0).Item("startdate" & CUR))), "dd/MM/yy")
                            .Col = 3
                            .Text = Trim(Sreader.Rows(0).Item("amount" & CUR))
                        Next
                    End With
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ''>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If Sreader.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(Sreader.Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                Me.cmd_Delete.Text = "UnFreeze[F7]"
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Freezed  On "
                Me.cmd_Delete.Text = "Freeze[F7]"
            End If
            Me.cmd_AddNew.Text = "Update[F5]"
        Else
            Me.txt_CorporateCode.Enabled = True
            Me.txt_CorporateName.Text = ""
            Me.lbl_Frez.Visible = False
            Me.lbl_Frez.Text = "Record Freezed  On "
            Me.cmd_AddNew.Text = "Add New[F5]"
        End If
    End Sub
    Private Sub txt_Fax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Fax.KeyPress, txt_PinCode.KeyPress, txt_Pager.KeyPress, txt_PhoneNo.KeyPress
        getNumeric(e)
    End Sub
    Private Sub txt_EntrenceFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EntrenceFee.LostFocus
        txt_EntrenceFee.Text = Format(Val(txt_EntrenceFee.Text), "0.00")
    End Sub
    Private Sub txt_DevelopmentFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DevelopmentFee.LostFocus
        txt_DevelopmentFee.Text = Format(Val(txt_DevelopmentFee.Text), "0.00")
    End Sub
    Private Sub frmMemberCorporate_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        corporatebool = False
    End Sub


    Private Sub txt_Address1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Address1.TextChanged

    End Sub

    Private Sub txt_Address2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Address2.TextChanged

    End Sub

    Private Sub txt_Address3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Address3.TextChanged

    End Sub

    Private Sub txt_CorporateName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CorporateName.TextChanged

    End Sub
    Public Function Btn_MembershipTo_c_FUN()
        If Btn_MembershipTo_c.Text = "C" Then
            cmb_MembershipTo_c.Visible = True
            dtp_MembershipTo.Visible = False
            Btn_MembershipTo_c.Text = "E"
            MembershipTo_VAL = ""
        ElseIf Btn_MembershipTo_c.Text = "E" Then
            MembershipTo_VAL = ""
            cmb_MembershipTo_c.Visible = False
            dtp_MembershipTo.Visible = True
            Btn_MembershipTo_c.Text = "C"
            MembershipTo_VAL = Format(dtp_MembershipTo.Value, "dd-MMM-yy")
        End If

    End Function
    Private Sub Btn_MembershipTo_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_MembershipTo_c.Click
        Btn_MembershipTo_c_FUN()
    End Sub

    Private Sub dtp_MembershipTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_MembershipTo.ValueChanged

    End Sub

    Private Sub cmb_MembershipTo_c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MembershipTo_c.SelectedIndexChanged

    End Sub
    Private Sub cmb_MembershipTo_c_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_MembershipTo_c.KeyDown
        If e.KeyCode = Keys.Insert Then
            Btn_MembershipTo_c.Text = "E"
            Btn_MembershipTo_c_FUN()
        End If
    End Sub
    Private Sub chk_EntranceFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EntranceFee.CheckedChanged
        Dim Obj_MemberMasrer As New MemberMaster
        Try
            If chk_EntranceFee.Checked = True Then
                Me.grp_Entrancefeedetails.BringToFront()
                Me.grp_Entrancefeedetails.Visible = True
                Me.grp_Entrancefeedetails.Top = 170
                Me.grp_Entrancefeedetails.Left = 250
                Me.SSgrid_Entrancefee.Focus()
            ElseIf chk_EntranceFee.Checked = False Then
                Me.grp_Entrancefeedetails.Visible = False
                Me.grp_Entrancefeedetails.SendToBack()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FillZoomTable(ByVal ssgrid As AxFPUSpreadADO.AxfpSpread, ByVal tabname As String)
        Dim dt As New DataTable
        Dim cl As New DataColumn
        Dim sql As String
        dt.TableName = tabname
        Dim dr As DataRow
        Dim i, k As Integer
        Dim j As Integer
        Dim GetVal As String
        For j = 1 To ssgrid.DataColCnt
            cl = New DataColumn
            dt.Columns.Add(cl)
        Next
        For i = 1 To 3
            dr = dt.NewRow
            For j = 1 To ssgrid.DataColCnt
                ssgrid.Col = j
                ssgrid.Row = i
                GetVal = ssgrid.Text
                dr(j - 1) = GetVal
            Next j
            dt.Rows.Add(dr)
        Next i
        If gdataset.Tables.Contains(tabname) = True Then
            gdataset.Tables.Remove(tabname)
        End If
        gdataset.Tables.Add(dt)
    End Sub
    Private Sub cmd_EntrancefeeOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EntrancefeeOK.Click
        grp_Entrancefeedetails.Visible = False
        Me.chk_EntranceFee.Checked = True
        If Me.SSgrid_Entrancefee.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
            Me.chk_EntranceFee.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Entrancefee, "entrancefee")
        End If
    End Sub
    Private Sub cmd_EntrancefeeCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EntrancefeeCancel.Click
        Me.chk_EntranceFee.Checked = False
        Me.grp_Entrancefeedetails.Visible = False
        If gdataset.Tables.Contains("entrancefee") Then
            gdataset.Tables.Remove("entrancefee")
        End If
        chk_EntranceFee.Focus()
    End Sub
    Private Sub txt_CorporateCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CorporateCode.TextChanged

    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        'Dim SqlArray(), Sql(500) As String
        'Dim i As Integer
        GroupBox1.Visible = False
        'Sql.Clear(Sql, 1, 500)
        'Sql(0) = "delete from corporatenomini where cmcode='" & txt_CorporateCode.Text & "' "
        ''gconnection.dataOperation(1, ssql, "specialmaster")
        'If ssgrid.DataRowCnt > 0 Then
        '    For i = 1 To ssgrid.DataRowCnt
        '        Sql(i) = "insert into corporatenomini(cmcode,nomininame,currentstatus,remarks)"
        '        Sql(i) = Sql(i) & "values('" & txt_CorporateCode.Text & "',"
        '        With ssgrid
        '            .Row = i
        '            .Col = 2
        '            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
        '            .Row = i
        '            .Col = 3
        '            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"

        '            .Row = i
        '            .Col = 4
        '            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
        '            '.Row = i
        '            '.Col = 5
        '            'Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
        '        End With
        '    Next i
        '    'ROLL BACK CHANGES
        '    ReDim SqlArray(Sql.Length)
        '    SqlArray.Copy(Sql, SqlArray, Sql.Length)
        '    gconnection.MoreTrans1(SqlArray)
        'End If
    End Sub

    Private Sub Cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdcancel.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub cmdnominishow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnominishow.Click
        Dim i As Integer
        Dim memdet As New DataTable
        ssql = "select ISNULL(mcode,'') AS cmcode,ISNULL(mname,'') AS nomininame,ISNULL(curentstatus,'') AS currentstatus,ISNULL(corporatecode,'') AS REMARKS from membermaster where isnull(corporatecode,'')='" & txt_CorporateCode.Text & "'order by mcode"
        memdet = gconnection.GetValues(ssql)
        If memdet.Rows.Count > 0 Then
            For i = 0 To memdet.Rows.Count - 1
                With ssgrid
                    .Row = i + 1
                    .Col = 1
                    .Text = Trim(memdet.Rows(i).Item("cmcode"))
                    .Row = i + 1
                    .Col = 2
                    .Text = Trim(memdet.Rows(i).Item("nomininame"))
                    .Row = i + 1
                    .Col = 3
                    .Text = Trim(memdet.Rows(i).Item("currentstatus"))
                    .Row = i + 1
                    .Col = 4
                    .Text = Format(memdet.Rows(i).Item("REMARKS"), "")
                End With
            Next i
            ssgrid.SetActiveCell(1, 1)
        End If
        GroupBox1.Visible = True
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid.InsertRows(ssgrid.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If ssgrid.ActiveRow = 3 And ssgrid.ActiveCol = 4 Then
                
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_Class_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Class.TextChanged

    End Sub

    Private Sub txt_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Email.TextChanged

    End Sub
End Class
