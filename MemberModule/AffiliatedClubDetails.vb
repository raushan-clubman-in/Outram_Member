Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class AffiliatedClubDetails
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim sqlstring As String
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
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents lbl_CorporateName As System.Windows.Forms.Label
    Public WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_clubcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_clubname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ClubCode As System.Windows.Forms.Button
    Friend WithEvents txt_add1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_add2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents txt_state As System.Windows.Forms.TextBox
    Friend WithEvents txt_pincode As System.Windows.Forms.TextBox
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_website As System.Windows.Forms.TextBox
    Friend WithEvents txt_contact As System.Windows.Forms.TextBox
    Friend WithEvents chk_yes As System.Windows.Forms.RadioButton
    Friend WithEvents chk_no As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents LIST_FACILITY As System.Windows.Forms.CheckedListBox
    Friend WithEvents TXT_PHONE1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFacilities As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AffiliatedClubDetails))
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.txt_clubcode = New System.Windows.Forms.TextBox
        Me.lbl_CorporateCode = New System.Windows.Forms.Label
        Me.lbl_CorporateName = New System.Windows.Forms.Label
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.txt_clubname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cmd_ClubCode = New System.Windows.Forms.Button
        Me.Label97 = New System.Windows.Forms.Label
        Me.txt_add1 = New System.Windows.Forms.TextBox
        Me.txt_add2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_city = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_state = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_pincode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_phone2 = New System.Windows.Forms.TextBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_website = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_contact = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.chk_yes = New System.Windows.Forms.RadioButton
        Me.chk_no = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.cmd_Freeze = New System.Windows.Forms.Button
        Me.cmd_Add = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.LIST_FACILITY = New System.Windows.Forms.CheckedListBox
        Me.TXT_PHONE1 = New System.Windows.Forms.TextBox
        Me.txtFacilities = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.ForeColor = System.Drawing.Color.Red
        Me.lbl_Caption.Location = New System.Drawing.Point(248, 16)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(331, 30)
        Me.lbl_Caption.TabIndex = 26
        Me.lbl_Caption.Text = "AFFILIATED CLUB DETAILS"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_clubcode
        '
        Me.txt_clubcode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_clubcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clubcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_clubcode.Location = New System.Drawing.Point(208, 80)
        Me.txt_clubcode.MaxLength = 10
        Me.txt_clubcode.Name = "txt_clubcode"
        Me.txt_clubcode.Size = New System.Drawing.Size(184, 20)
        Me.txt_clubcode.TabIndex = 71
        Me.txt_clubcode.Text = ""
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(64, 80)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(92, 21)
        Me.lbl_CorporateCode.TabIndex = 75
        Me.lbl_CorporateCode.Text = "Club Code :"
        '
        'lbl_CorporateName
        '
        Me.lbl_CorporateName.AutoSize = True
        Me.lbl_CorporateName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateName.Location = New System.Drawing.Point(64, 112)
        Me.lbl_CorporateName.Name = "lbl_CorporateName"
        Me.lbl_CorporateName.TabIndex = 77
        Me.lbl_CorporateName.Text = "Club Name  :"
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(64, 144)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(85, 21)
        Me.lbl_BillingBasis.TabIndex = 78
        Me.lbl_BillingBasis.Text = "Address1 :"
        '
        'txt_clubname
        '
        Me.txt_clubname.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_clubname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clubname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_clubname.Location = New System.Drawing.Point(208, 112)
        Me.txt_clubname.MaxLength = 35
        Me.txt_clubname.Name = "txt_clubname"
        Me.txt_clubname.Size = New System.Drawing.Size(184, 20)
        Me.txt_clubname.TabIndex = 72
        Me.txt_clubname.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(448, 8)
        Me.Label3.TabIndex = 79
        '
        'Cmd_ClubCode
        '
        Me.Cmd_ClubCode.Image = CType(resources.GetObject("Cmd_ClubCode.Image"), System.Drawing.Image)
        Me.Cmd_ClubCode.Location = New System.Drawing.Point(392, 80)
        Me.Cmd_ClubCode.Name = "Cmd_ClubCode"
        Me.Cmd_ClubCode.Size = New System.Drawing.Size(23, 20)
        Me.Cmd_ClubCode.TabIndex = 76
        '
        'Label97
        '
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label97.Location = New System.Drawing.Point(16, 64)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(448, 440)
        Me.Label97.TabIndex = 74
        '
        'txt_add1
        '
        Me.txt_add1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_add1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_add1.Location = New System.Drawing.Point(208, 144)
        Me.txt_add1.MaxLength = 35
        Me.txt_add1.Name = "txt_add1"
        Me.txt_add1.Size = New System.Drawing.Size(184, 20)
        Me.txt_add1.TabIndex = 80
        Me.txt_add1.Text = ""
        '
        'txt_add2
        '
        Me.txt_add2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_add2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_add2.Location = New System.Drawing.Point(208, 176)
        Me.txt_add2.MaxLength = 35
        Me.txt_add2.Name = "txt_add2"
        Me.txt_add2.Size = New System.Drawing.Size(184, 20)
        Me.txt_add2.TabIndex = 82
        Me.txt_add2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Address2 :"
        '
        'txt_city
        '
        Me.txt_city.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_city.Location = New System.Drawing.Point(208, 208)
        Me.txt_city.MaxLength = 25
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(184, 20)
        Me.txt_city.TabIndex = 84
        Me.txt_city.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "City :"
        '
        'txt_state
        '
        Me.txt_state.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_state.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_state.Location = New System.Drawing.Point(208, 240)
        Me.txt_state.MaxLength = 25
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(184, 20)
        Me.txt_state.TabIndex = 86
        Me.txt_state.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "State :"
        '
        'txt_pincode
        '
        Me.txt_pincode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_pincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pincode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pincode.Location = New System.Drawing.Point(208, 272)
        Me.txt_pincode.MaxLength = 10
        Me.txt_pincode.Name = "txt_pincode"
        Me.txt_pincode.Size = New System.Drawing.Size(184, 20)
        Me.txt_pincode.TabIndex = 88
        Me.txt_pincode.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "PinCode :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Phone :"
        '
        'txt_fax
        '
        Me.txt_fax.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fax.Location = New System.Drawing.Point(208, 336)
        Me.txt_fax.MaxLength = 15
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(184, 20)
        Me.txt_fax.TabIndex = 92
        Me.txt_fax.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 21)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Fax :"
        '
        'txt_phone2
        '
        Me.txt_phone2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_phone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phone2.Location = New System.Drawing.Point(280, 304)
        Me.txt_phone2.MaxLength = 15
        Me.txt_phone2.Name = "txt_phone2"
        Me.txt_phone2.Size = New System.Drawing.Size(112, 20)
        Me.txt_phone2.TabIndex = 93
        Me.txt_phone2.Text = ""
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_email.Location = New System.Drawing.Point(208, 368)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(184, 20)
        Me.txt_email.TabIndex = 95
        Me.txt_email.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "E.Mail :"
        '
        'txt_website
        '
        Me.txt_website.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_website.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_website.Location = New System.Drawing.Point(208, 400)
        Me.txt_website.MaxLength = 50
        Me.txt_website.Name = "txt_website"
        Me.txt_website.Size = New System.Drawing.Size(184, 20)
        Me.txt_website.TabIndex = 97
        Me.txt_website.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 21)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Website :"
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_contact.Location = New System.Drawing.Point(208, 464)
        Me.txt_contact.MaxLength = 50
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(184, 20)
        Me.txt_contact.TabIndex = 99
        Me.txt_contact.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 21)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Contact Person :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(64, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 21)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Room Available :"
        '
        'chk_yes
        '
        Me.chk_yes.BackColor = System.Drawing.Color.Transparent
        Me.chk_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_yes.Location = New System.Drawing.Point(208, 432)
        Me.chk_yes.Name = "chk_yes"
        Me.chk_yes.Size = New System.Drawing.Size(48, 24)
        Me.chk_yes.TabIndex = 101
        Me.chk_yes.Text = "Yes"
        '
        'chk_no
        '
        Me.chk_no.BackColor = System.Drawing.Color.Transparent
        Me.chk_no.Checked = True
        Me.chk_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_no.Location = New System.Drawing.Point(264, 432)
        Me.chk_no.Name = "chk_no"
        Me.chk_no.Size = New System.Drawing.Size(48, 24)
        Me.chk_no.TabIndex = 102
        Me.chk_no.TabStop = True
        Me.chk_no.Text = "No"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(8, 528)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(824, 8)
        Me.Label12.TabIndex = 114
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(712, 544)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 112
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(704, 552)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 30)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Label13"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(40, 544)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 106
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.White
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(448, 544)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 104
        Me.cmd_View.Text = "View[F9]"
        '
        'cmd_Freeze
        '
        Me.cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.cmd_Freeze.Image = CType(resources.GetObject("cmd_Freeze.Image"), System.Drawing.Image)
        Me.cmd_Freeze.Location = New System.Drawing.Point(312, 544)
        Me.cmd_Freeze.Name = "cmd_Freeze"
        Me.cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Freeze.TabIndex = 105
        Me.cmd_Freeze.Text = "Freeze[F8]"
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.White
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.Location = New System.Drawing.Point(176, 544)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Add.TabIndex = 103
        Me.cmd_Add.Text = "Add[F7]"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(32, 552)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 30)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(304, 552)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 30)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(168, 552)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 30)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(440, 552)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 30)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "Label17"
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label101.Location = New System.Drawing.Point(8, 536)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(824, 56)
        Me.Label101.TabIndex = 108
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(584, 544)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 115
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(576, 552)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 30)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Brown
        Me.Label19.Location = New System.Drawing.Point(592, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(143, 30)
        Me.Label19.TabIndex = 118
        Me.Label19.Text = "FACILITIES"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(464, 496)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 119
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'LIST_FACILITY
        '
        Me.LIST_FACILITY.Location = New System.Drawing.Point(480, 96)
        Me.LIST_FACILITY.Name = "LIST_FACILITY"
        Me.LIST_FACILITY.Size = New System.Drawing.Size(320, 379)
        Me.LIST_FACILITY.TabIndex = 120
        '
        'TXT_PHONE1
        '
        Me.TXT_PHONE1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_PHONE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PHONE1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PHONE1.Location = New System.Drawing.Point(208, 304)
        Me.TXT_PHONE1.MaxLength = 6
        Me.TXT_PHONE1.Name = "TXT_PHONE1"
        Me.TXT_PHONE1.Size = New System.Drawing.Size(64, 20)
        Me.TXT_PHONE1.TabIndex = 121
        Me.TXT_PHONE1.Text = ""
        '
        'txtFacilities
        '
        Me.txtFacilities.Location = New System.Drawing.Point(680, 488)
        Me.txtFacilities.Name = "txtFacilities"
        Me.txtFacilities.TabIndex = 122
        Me.txtFacilities.Text = ""
        Me.txtFacilities.Visible = False
        '
        'AffiliatedClubDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(840, 614)
        Me.Controls.Add(Me.txtFacilities)
        Me.Controls.Add(Me.TXT_PHONE1)
        Me.Controls.Add(Me.LIST_FACILITY)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Freeze)
        Me.Controls.Add(Me.cmd_Add)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.chk_no)
        Me.Controls.Add(Me.chk_yes)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_website)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_phone2)
        Me.Controls.Add(Me.txt_fax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_pincode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_state)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_city)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_add2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_add1)
        Me.Controls.Add(Me.txt_clubcode)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.lbl_CorporateName)
        Me.Controls.Add(Me.lbl_BillingBasis)
        Me.Controls.Add(Me.txt_clubname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cmd_ClubCode)
        Me.Controls.Add(Me.Label97)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "AffiliatedClubDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AffiliatedClubDetails"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Corporate Code is blank
        If txt_clubcode.Text = "" Then
            MessageBox.Show(" Club Code can't be blank ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_clubcode.Focus()
            Exit Sub
        End If
        '''********** Check Corporate Name is blank
        If txt_clubname.Text = "" Then
            MessageBox.Show(" Club Name can't be blank ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_clubname.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub AffiliatedClubDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show()
        txt_clubcode.Focus()
        Call facilities()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        txt_add1.Text = ""
        txt_add2.Text = ""
        txt_city.Text = ""
        txt_clubcode.Text = ""
        txt_clubname.Text = ""
        txt_contact.Text = ""
        txt_email.Text = ""
        txt_fax.Text = ""
        TXT_PHONE1.Text = ""
        txt_phone2.Text = ""
        txt_pincode.Text = ""
        txt_state.Text = ""
        txt_website.Text = ""
        cmd_Add.Text = "Add[F7]"
        cmd_Freeze.Text = "Freeze[F8]"
        lbl_Freeze.Visible = False
        txt_clubcode.ReadOnly = False
        txt_clubcode.Focus()
        LIST_FACILITY.Items.Clear()
        Call facilities()
        txtFacilities.Text = ""
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "select isnull(clubcode,'')as clubcode,isnull(clubname,'')as clubname from AFFILIATEDCLUBDETAILS where clubcode='" & Trim(txt_clubcode.Text) & "'"
            gconnection.getDataSet(sqlstring, "AFFILIATEDCLUBDETAILS")
            If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                sqlstring = "UPDATE  AFFILIATEDCLUBDETAILS "
                sqlstring = sqlstring & " SET Freeze= 'Y',UpdUserid='" & gUsername & " ',Upddatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                sqlstring = sqlstring & " WHERE CLUBCODE = '" & txt_clubcode.Text & " '"
                gconnection.dataOperation(3, sqlstring, "AFFILIATEDCLUBDETAILS")
                MsgBox("Record Freezed", MsgBoxStyle.OKOnly)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add[F7]"
            Else
                MsgBox("Not A Valid CLUB CODE", MsgBoxStyle.Information)
                Me.cmd_Clear_Click(sender, e)
            End If
        ElseIf Mid(Me.cmd_Freeze.Text, 1, 1) = "U" Then
            sqlstring = "UPDATE  AFFILIATEDCLUBDETAILS"
            sqlstring = sqlstring & " SET Freeze= 'N',UpdUserid='" & gUsername & " ', UpdDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE CLUBCODE= '" & txt_clubcode.Text & " '"
            gconnection.dataOperation(4, sqlstring, "AFFILIATEDCLUBDETAILS")
            MsgBox("Record Unfreezed", MsgBoxStyle.OKOnly)
            Me.cmd_Clear_Click(sender, e)
            cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub Cmd_ClubCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ClubCode.Click
        Dim vform As New ListOperation
        gSQLString = "Select ISNULL(CLUBCODE,'')AS CLUBCODE,ISNULL(CLUBNAME,'')AS CLUBNAME from AFFILIATEDCLUBDETAILS"
        M_WhereCondition = " "
        vform.Field = "CLUBCODE,CLUBNAME"
        vform.vFormatstring = "  CLUB CODE  |                   CLUB NAME                    "
        vform.vCaption = "AFFILIATED CLUB MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_clubcode.Text = Trim(vform.keyfield & "")
            txt_clubname.Select()
            txt_clubcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_Add.Text = "Update[F7]"
    End Sub
    Public Function facilities()
        Dim I As Integer
        'sqlstring = "select isnull(poscode,'')as poscode,isnull(posdesc,'')as posdesc from posmaster where storestatus='F'"
        sqlstring = "select isnull(subscode,'')as poscode,isnull(subsdesc,'')as posdesc from subscriptionmast where ISNULL(FACILITY_FLG,'')='F' AND ISNULL(FREEZE,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("POSMASTER").Rows.Count - 1
                With gdataset.Tables("POSMASTER").Rows(I)
                    LIST_FACILITY.Items.Add(Trim(.Item("POSCODE")) & "==>" & Trim(.Item("POSDESC")))
                End With
            Next I
        End If
    End Function
    Private Sub txt_clubcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_clubcode.Validated
        Dim vsplit(), type() As String
        Try
            If Trim(txt_clubcode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(CLUBCODE,'')AS CLUBCODE,ISNULL(CLUBNAME,'')AS CLUBNAME,ISNULL(ADDRESS1,'')AS ADDRESS1,"
                sqlstring = sqlstring & "ISNULL(ADDRESS2,'')AS ADDRESS2,ISNULL(CITY,'')AS CITY,ISNULL(STATE,'')AS STATE,ISNULL(PINCODE,'')AS PINCODE,"
                sqlstring = sqlstring & "ISNULL(PHONE1,'')AS PHONE1,ISNULL(PHONE2,'')AS PHONE2,ISNULL(EMAIL,'')AS EMAIL,ISNULL(FAX,'')AS FAX,ISNULL(WEBSITE,'')AS WEBSITE,ISNULL(CONTACTPERSON,'')AS CONTACTPERSON,"
                sqlstring = sqlstring & "ISNULL(ROOM,'')AS ROOM,ISNULL(FACILITY,'') AS FACILITY,ISNULL(FREEZE,'')AS FREEZE,ISNULL(ADDUSERID,'')AS ADDUSERID,ISNULL(ADDDATETIME,'')AS ADDDATETIME,ISNULL(UPDDATETIME,'')AS UPDATEDATE,ISNULL(UPDUSERID,'')AS UPDATEUSER "
                sqlstring = sqlstring & " FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(txt_clubcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "AFFILIATEDCLUBDETAILS")
                If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                    txt_clubcode.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBCODE"))
                    txt_clubname.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME"))
                    txt_add1.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ADDRESS1"))
                    txt_add2.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ADDRESS2"))
                    txt_city.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CITY"))
                    txt_state.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("STATE"))
                    TXT_PHONE1.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PHONE1"))
                    txt_phone2.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PHONE2"))
                    txt_pincode.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PINCODE"))
                    txt_fax.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("FAX"))
                    txt_email.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("EMAIL"))
                    txt_website.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("WEBSITE"))
                    txt_contact.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CONTACTPERSON"))
                    txtFacilities.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("FACILITY"))
                    If Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ROOM")) = "Y" Then
                        chk_yes.Checked = True
                    Else
                        chk_no.Checked = True
                    End If
                    txt_clubname.Focus()
                    txt_clubcode.ReadOnly = True
                    If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("UPDATEDATE")), "dd/MM/yyyy")
                        Me.cmd_Freeze.Text = "UnFreeze[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.cmd_Freeze.Text = "Freeze[F8]"
                    End If
                    Me.cmd_Add.Text = "Update[F7]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.cmd_Add.Text = "Add[F7]"
                    txt_clubcode.ReadOnly = False
                    txt_clubname.Focus()
                End If
            Else
                txt_clubcode.Text = ""
                txt_clubname.Focus()
            End If
            Dim I As Integer
            Dim loopindex As Long
            If Trim(txtFacilities.Text) <> "" Then
                'Call LstRemoveAll(lstFacilities)
                vsplit = Split(txtFacilities.Text, ",")
                For I = 0 To UBound(vsplit)
                    For loopindex = 0 To LIST_FACILITY.Items.Count - 1
                        type = Split(LIST_FACILITY.Items(loopindex), "==>")
                        If type(0) = vsplit(I) Then
                            LIST_FACILITY.SetItemChecked(loopindex, True)
                            Exit For
                        End If
                    Next
                Next
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txt_clubcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clubcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_clubcode.Text = "" Then
                Call Cmd_ClubCode_Click(sender, e)
            Else
                Call txt_clubcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Add.Click
        Dim SQLSTR As String
        Try
            If cmd_Add.Text = "Add[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                SQLSTR = "Insert into AFFILIATEDCLUBDETAILS (CLUBCODE,CLUBNAME,ADDRESS1,ADDRESS2,CITY,STATE,PINCODE,"
                SQLSTR = SQLSTR & "PHONE1,PHONE2,FAX,EMAIL,ROOM,WEBSITE,FACILITY,Contactperson,freeze,Adduserid,Adddatetime)"
                SQLSTR = SQLSTR & "Values('" & Trim(txt_clubcode.Text) & "','" & Trim(txt_clubname.Text) & "','" & Trim(txt_add1.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_add2.Text) & "','" & Trim(txt_city.Text) & "','" & Trim(txt_state.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_pincode.Text) & "', '" & Trim(TXT_PHONE1.Text) & "','" & Trim(txt_phone2.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_fax.Text) & "','" & Trim(txt_email.Text) & "',"
                If chk_yes.Checked = True Then
                    SQLSTR = SQLSTR & "'Y',"
                Else
                    SQLSTR = SQLSTR & "'N',"
                End If
                SQLSTR = SQLSTR & "'" & Trim(txt_website.Text) & "','" & Trim(txtFacilities.Text) & "','" & Trim(txt_contact.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                gconnection.dataOperation(1, SQLSTR, "AFFILIATEDCLUBDETAILS")
                MsgBox("Record Inserted", MsgBoxStyle.OKOnly)
                Call cmd_Clear_Click(sender, e)
            ElseIf cmd_Add.Text = "Update[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                If Mid(Me.cmd_Add.Text, 1, 1) = "U" Then
                    If Me.lbl_Freeze.Visible = True Then
                        MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                SQLSTR = "Update AFFILIATEDCLUBDETAILS set clubcode = '" & Trim(txt_clubcode.Text) & "',clubname = '" & Trim(txt_clubname.Text) & "',address1 = '" & Trim(txt_add1.Text) & "',"
                SQLSTR = SQLSTR & "address2 = '" & Trim(txt_add2.Text) & "',City = '" & Trim(txt_city.Text) & "',State = '" & Trim(txt_state.Text) & "',Pincode = '" & Trim(txt_pincode.Text) & "',"
                SQLSTR = SQLSTR & "Phone1='" & Trim(TXT_PHONE1.Text) & "',Phone2 = '" & Trim(txt_phone2.Text) & "',Fax = '" & Trim(txt_fax.Text) & "',"
                SQLSTR = SQLSTR & "Email='" & Trim(txt_email.Text) & "',"
                If chk_yes.Checked = True Then
                    SQLSTR = SQLSTR & "Room = 'Y',"
                Else
                    SQLSTR = SQLSTR & "Room = 'N',"
                End If
                SQLSTR = SQLSTR & "Website='" & Trim(txt_website.Text) & "',Facility='" & Trim(txtFacilities.Text) & "',Contactperson='" & Trim(txt_contact.Text) & "',"
                SQLSTR = SQLSTR & "Freeze='N',Upduserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "' Where Clubcode='" & Trim(txt_clubcode.Text) & "'"
                gconnection.dataOperation(2, SQLSTR, "AFFILIATEDCLUBDETAILS")
                MsgBox("Record Updated", MsgBoxStyle.OKOnly)
                Call cmd_Clear_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub txt_clubname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clubname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_add1.Focus()
        End If
    End Sub

    Private Sub txt_add1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_add1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_add2.Focus()
        End If
    End Sub

    Private Sub txt_add2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_add2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_city.Focus()
        End If
    End Sub

    Private Sub txt_city_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_city.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_state.Focus()
        End If
    End Sub

    Private Sub txt_state_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_state.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_pincode.Focus()
        End If
    End Sub

    Private Sub txt_pincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pincode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            TXT_PHONE1.Focus()
        End If
    End Sub

    Private Sub TXT_PHONE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PHONE1.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_phone2.Focus()
        End If
    End Sub

    Private Sub txt_phone2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone2.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_fax.Focus()
        End If
    End Sub

    Private Sub txt_fax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fax.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_email.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_email.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_website.Focus()
        End If
    End Sub

    Private Sub txt_website_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_website.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_yes.Focus()
        End If
    End Sub

    Private Sub chk_yes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yes.CheckedChanged
        txt_contact.Focus()
    End Sub

    Private Sub chk_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_no.CheckedChanged
        txt_contact.Focus()
    End Sub

    Private Sub txt_contact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_contact.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd_Add.Focus()
        End If
    End Sub

    Private Sub AffiliatedClubDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Add_Click(sender, e)
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_Freeze_Click(sender, e)
        ElseIf e.KeyCode = Keys.F9 Then
            Call cmd_View_Click(sender, e)
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(sender, e)
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmd_Exit_Click(sender, e)
        End If
    End Sub

    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM AFFILIATEDCLUBDETAILS"
        Gheader = "AFFILIATEDCLUBDETAILS MASTER"
        FrReport.SsGridReport.SetText(2, 1, "CLUBCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "CLUBNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "ADDRESS1")
        FrReport.SsGridReport.SetText(3, 3, 30)
        FrReport.SsGridReport.SetText(2, 4, "ADDRESS2")
        FrReport.SsGridReport.SetText(3, 4, 30)
        FrReport.SsGridReport.SetText(2, 5, "CITY")
        FrReport.SsGridReport.SetText(3, 5, 15)
        FrReport.SsGridReport.SetText(2, 6, "STATE")
        FrReport.SsGridReport.SetText(3, 6, 15)
        FrReport.SsGridReport.SetText(2, 7, "PINCODE")
        FrReport.SsGridReport.SetText(3, 7, 10)
        FrReport.SsGridReport.SetText(2, 8, "PHONE1")
        FrReport.SsGridReport.SetText(3, 8, 10)
        FrReport.SsGridReport.SetText(2, 9, "PHONE2")
        FrReport.SsGridReport.SetText(3, 9, 10)
        FrReport.SsGridReport.SetText(2, 10, "FAX")
        FrReport.SsGridReport.SetText(3, 10, 15)
        FrReport.SsGridReport.SetText(2, 11, "Contactperson")
        FrReport.SsGridReport.SetText(3, 11, 30)
        FrReport.SsGridReport.SetText(2, 12, "Facility")
        FrReport.SsGridReport.SetText(3, 12, 30)
        FrReport.SsGridReport.SetText(2, 13, "EMAIL")
        FrReport.SsGridReport.SetText(3, 13, 30)
        FrReport.SsGridReport.SetText(2, 14, "WEBSITE")
        FrReport.SsGridReport.SetText(3, 14, 30)
       
        FrReport.Show()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Call cmd_View_Click(sender, e)
    End Sub

    Private Sub txt_add2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_add2.TextChanged

    End Sub

    Private Sub LIST_FACILITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIST_FACILITY.SelectedIndexChanged
        Dim vcount As String
        Dim Loopindex As Long
        Dim vsplit(), str As String
        Dim i As Integer
        txtFacilities.Text = ""
        vcount = ""
        If LIST_FACILITY.CheckedItems.Count <> 0 Then
            For i = 0 To LIST_FACILITY.CheckedItems.Count - 1
                vsplit = Split(LIST_FACILITY.CheckedItems(i), "==>")
                str = str & vsplit(0) & ","
            Next
        End If
        txtFacilities.Text = Trim(str)
    End Sub

    Private Sub txt_clubcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clubcode.TextChanged

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
        Me.cmd_Add.Enabled = False
        Me.cmd_Freeze.Enabled = False
        Me.cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_Add.Enabled = True
                    Me.cmd_Freeze.Enabled = True
                    Me.cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_ClubCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_ClubCode.Validated

    End Sub
End Class
