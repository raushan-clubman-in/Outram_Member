Imports System.IO
Public Class MemberMaster
    Inherits System.Windows.Forms.Form
    Dim ppath, spath As String
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label216 As System.Windows.Forms.Label
    Public WithEvents Label217 As System.Windows.Forms.Label
    Friend WithEvents Label231 As System.Windows.Forms.Label
    Public WithEvents Label232 As System.Windows.Forms.Label
    Public WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Public WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Public WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents sc As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents chk_Married As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_placeofbirth As System.Windows.Forms.Label
    Friend WithEvents chk_corporate As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Billhead As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_dateofbirth As System.Windows.Forms.Label
    Friend WithEvents lbl_nationalityatbirth As System.Windows.Forms.Label
    Friend WithEvents lbl_MiddleName As System.Windows.Forms.Label
    Friend WithEvents lbl_surname As System.Windows.Forms.Label
    Friend WithEvents lbl_FirstName As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents opt_Female As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Male As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents lbl_Fax As System.Windows.Forms.Label
    Friend WithEvents lbl_Address1 As System.Windows.Forms.Label
    Friend WithEvents lbl_address2 As System.Windows.Forms.Label
    Friend WithEvents lbl_address3 As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_pincode As System.Windows.Forms.Label
    Friend WithEvents lbl_state As System.Windows.Forms.Label
    Friend WithEvents lbl_phoneno As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_mobile As System.Windows.Forms.Label
    Friend WithEvents lbl_country As System.Windows.Forms.Label
    Friend WithEvents lbl_GDRlocker As System.Windows.Forms.Label
    Friend WithEvents lbl_LDRlocker As System.Windows.Forms.Label
    Friend WithEvents lbl_HPlocker As System.Windows.Forms.Label
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents lbl_currentstatus As System.Windows.Forms.Label
    Friend WithEvents txt_ApplicationNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_ReasonApplication As System.Windows.Forms.TextBox
    Friend WithEvents txt_NoOfTimesProposed As System.Windows.Forms.TextBox
    Friend WithEvents chk_PreviouslyPr As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Memberofclub As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Specialinfo As System.Windows.Forms.Label
    Friend WithEvents cmd_SeconderCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_ProposerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_Specialinfo As System.Windows.Forms.TextBox
    Friend WithEvents chk_AppliedMembership As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Childrendetail As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Relativesdetails As System.Windows.Forms.CheckBox
    Friend WithEvents chk_MemberQulification As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Sports As System.Windows.Forms.CheckBox
    Friend WithEvents txt_PositionHeld As System.Windows.Forms.TextBox
    Friend WithEvents txt_SeconderName As System.Windows.Forms.TextBox
    Friend WithEvents txt_ProposedName As System.Windows.Forms.TextBox
    Friend WithEvents txt_SeconderCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_ProposerCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Clients As System.Windows.Forms.TextBox
    Friend WithEvents txt_TurnOver As System.Windows.Forms.TextBox
    Friend WithEvents txt_Bankers As System.Windows.Forms.TextBox
    Friend WithEvents txt_NoOfEmployee As System.Windows.Forms.TextBox
    Friend WithEvents txt_Agents As System.Windows.Forms.TextBox
    Friend WithEvents txt_Products As System.Windows.Forms.TextBox
    Friend WithEvents txt_Bussinessinfo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Professonalinfo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Designation As System.Windows.Forms.TextBox
    Friend WithEvents txt_CompanyName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents dtp_DateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_CountryOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txt_PlaceOfBirth As System.Windows.Forms.TextBox
    Friend WithEvents txt_NationalityAtBirth As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nationality As System.Windows.Forms.TextBox
    Friend WithEvents txt_Surname As System.Windows.Forms.TextBox
    Friend WithEvents txt_MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Title As System.Windows.Forms.ComboBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents chk_RA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents txt_RA_PhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Country As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents cmd_CategoryHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_CorporateCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_CorporateCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Fax As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Mobile As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_EMail As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Pin As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Country As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_CA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_LDRLocker As System.Windows.Forms.TextBox
    Friend WithEvents txt_HPLocker As System.Windows.Forms.TextBox
    Friend WithEvents txt_GDRLocker As System.Windows.Forms.TextBox
    Friend WithEvents cbo_CurrentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents chk_BA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents txt_BA_PhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Country As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents chk_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents txt_PA_Phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Country As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents chk_Elected As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Month As System.Windows.Forms.TextBox
    Friend WithEvents txt_PeriodOfStay As System.Windows.Forms.TextBox
    Friend WithEvents txt_DevelopmentFee As System.Windows.Forms.TextBox
    Friend WithEvents txt_EntranceFee As System.Windows.Forms.TextBox
    Friend WithEvents txt_SecurityDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txt_CreditNumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_LastArrivalInCalcutta As System.Windows.Forms.DateTimePicker
    Public WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents grp_ChildrenDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Grp_MemQualification As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Qualification As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cmd_ChildrenCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_ChildrenOk As System.Windows.Forms.Button
    Friend WithEvents Cmd_MemberQuliCancel As System.Windows.Forms.Button
    Friend WithEvents Cmd_MemberQuliOk As System.Windows.Forms.Button
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents cmd_RelativeCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_RelativesOk As System.Windows.Forms.Button
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Relatives As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents cmd_SportsCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_SportsOk As System.Windows.Forms.Button
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents grp_MemberClub As System.Windows.Forms.GroupBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents cmd_ClubCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_ClubOk As System.Windows.Forms.Button
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents grp_Relativedetails As System.Windows.Forms.GroupBox
    Friend WithEvents grp_SportsIntrested As System.Windows.Forms.GroupBox
    Friend WithEvents SSgrid_Sports As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents SSgrid_MemberClub As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Lst_BillHead As System.Windows.Forms.ListBox
    Friend WithEvents ssgrid As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents chk_Referencedetails As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Referencedetails As System.Windows.Forms.Label
    Friend WithEvents cmd_ReferencedetailsCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_ReferencedetailsOk As System.Windows.Forms.Button
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents ssgrid_Referencedetails As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents grp_Referencedetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ESTDdate As System.Windows.Forms.Label
    Friend WithEvents lbl_NoOfEmployee As System.Windows.Forms.Label
    Friend WithEvents tip_Specialinfo As System.Windows.Forms.ToolTip
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Label85 As System.Windows.Forms.Label
    Public WithEvents Label88 As System.Windows.Forms.Label
    Public WithEvents Label89 As System.Windows.Forms.Label
    Public WithEvents Label90 As System.Windows.Forms.Label
    Public WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents btn_ClearEstdDT As System.Windows.Forms.Button
    Friend WithEvents combo_HideDateESTD As System.Windows.Forms.ComboBox
    Friend WithEvents chk_EntranceFee As System.Windows.Forms.CheckBox
    Friend WithEvents grp_Entrancefeedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Public WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents cmd_EntrancefeeCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_EntrancefeeOK As System.Windows.Forms.Button
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Entrancefee As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Appdt_c As System.Windows.Forms.Button
    Friend WithEvents Btn_DateOf_c As System.Windows.Forms.Button
    Friend WithEvents Btn_LastArr_c As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_LastArr_c As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_DateOf_c As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Appdt_c As System.Windows.Forms.ComboBox
    Friend WithEvents Chk_BA_RA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_PA_RA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_PA_BA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_RA_BA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_BA_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_RA_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents txt_Spouse As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Spouse As System.Windows.Forms.Label
    Friend WithEvents txt_spouse_dob As System.Windows.Forms.TextBox
    Friend WithEvents SIGNATURE As System.Windows.Forms.CheckBox
    Friend WithEvents PHOTO As System.Windows.Forms.CheckBox
    Friend WithEvents membersignature As System.Windows.Forms.PictureBox
    Friend WithEvents memberphoto As System.Windows.Forms.PictureBox
    Friend WithEvents grp_currentstatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Public WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents cmd_currentstatus_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_currentstatus_ok As System.Windows.Forms.Button
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents ssgrid_currentstatus As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents chk_pa_ca_copy As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ba_ca_copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_RA_CA_copy As System.Windows.Forms.CheckBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents dtp_MembershipFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_MembershipTo_c As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_MembershipTo_c As System.Windows.Forms.Button
    Friend WithEvents TXT_SPOUSE_MOBILE As System.Windows.Forms.TextBox
    Friend WithEvents LBL_SPOUSE_MOBILE As System.Windows.Forms.Label
    Friend WithEvents TXT_TITLE As System.Windows.Forms.TextBox
    Friend WithEvents Btn_BIRTH1 As System.Windows.Forms.Button
    Friend WithEvents CMB_BRITH As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Membershipfrom_c As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Membershipfrom_c As System.Windows.Forms.Button
    Friend WithEvents Btn_spousedob_c As System.Windows.Forms.Button
    Friend WithEvents cmb_spouse_dob As System.Windows.Forms.ComboBox
    Friend WithEvents btn_details As System.Windows.Forms.Button
    Friend WithEvents dtp_ESTDdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DateApplication As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DateProposal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Lbl_BloodGroup As System.Windows.Forms.Label
    Friend WithEvents Lbl_PANNo As System.Windows.Forms.Label
    Friend WithEvents Txt_BloodGroup As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PANNo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CreditLimit As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CreditLimit As System.Windows.Forms.Label
    Friend WithEvents grp_proposaldetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Proposal As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Chk_Prop As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_ProposerCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_ProposerOK As System.Windows.Forms.Button
    Friend WithEvents grp_Seconderdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Public WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents cmd_SeconderCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_SeconderOK As System.Windows.Forms.Button
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Seconder As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Chk_Sec As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_MembershipTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LStatus As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents txt_fmcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Nationality As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberMaster))
        Me.dtp_DateOfBirth = New System.Windows.Forms.DateTimePicker
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.chk_Married = New System.Windows.Forms.CheckBox
        Me.txt_CountryOfBirth = New System.Windows.Forms.TextBox
        Me.txt_PlaceOfBirth = New System.Windows.Forms.TextBox
        Me.lbl_placeofbirth = New System.Windows.Forms.Label
        Me.chk_corporate = New System.Windows.Forms.CheckBox
        Me.chk_Billhead = New System.Windows.Forms.CheckBox
        Me.txt_NationalityAtBirth = New System.Windows.Forms.TextBox
        Me.txt_Nationality = New System.Windows.Forms.TextBox
        Me.lbl_dateofbirth = New System.Windows.Forms.Label
        Me.lbl_nationalityatbirth = New System.Windows.Forms.Label
        Me.txt_Surname = New System.Windows.Forms.TextBox
        Me.txt_MiddleName = New System.Windows.Forms.TextBox
        Me.txt_FirstName = New System.Windows.Forms.TextBox
        Me.cbo_Title = New System.Windows.Forms.ComboBox
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_MiddleName = New System.Windows.Forms.Label
        Me.lbl_surname = New System.Windows.Forms.Label
        Me.lbl_FirstName = New System.Windows.Forms.Label
        Me.lbl_Title = New System.Windows.Forms.Label
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.chk_RA_Copy = New System.Windows.Forms.CheckBox
        Me.txt_RA_PhoneNo = New System.Windows.Forms.TextBox
        Me.txt_RA_PinCode = New System.Windows.Forms.TextBox
        Me.txt_RA_Country = New System.Windows.Forms.TextBox
        Me.txt_RA_State = New System.Windows.Forms.TextBox
        Me.txt_RA_City = New System.Windows.Forms.TextBox
        Me.txt_RA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_RA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_RA_Address1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txt_Category = New System.Windows.Forms.TextBox
        Me.cmd_CategoryHelp = New System.Windows.Forms.Button
        Me.cmd_CorporateCodeHelp = New System.Windows.Forms.Button
        Me.opt_Female = New System.Windows.Forms.RadioButton
        Me.opt_Male = New System.Windows.Forms.RadioButton
        Me.lbl_CorporateCode = New System.Windows.Forms.Label
        Me.txt_CorporateCode = New System.Windows.Forms.TextBox
        Me.Label216 = New System.Windows.Forms.Label
        Me.Label217 = New System.Windows.Forms.Label
        Me.Label231 = New System.Windows.Forms.Label
        Me.Label232 = New System.Windows.Forms.Label
        Me.txt_CA_Fax = New System.Windows.Forms.TextBox
        Me.txt_CA_Mobile = New System.Windows.Forms.TextBox
        Me.txt_CA_Phone = New System.Windows.Forms.TextBox
        Me.txt_CA_EMail = New System.Windows.Forms.TextBox
        Me.txt_CA_Pin = New System.Windows.Forms.TextBox
        Me.txt_CA_Country = New System.Windows.Forms.TextBox
        Me.txt_CA_State = New System.Windows.Forms.TextBox
        Me.txt_CA_City = New System.Windows.Forms.TextBox
        Me.txt_CA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_CA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_CA_Address1 = New System.Windows.Forms.TextBox
        Me.lbl_Fax = New System.Windows.Forms.Label
        Me.lbl_Address1 = New System.Windows.Forms.Label
        Me.lbl_address2 = New System.Windows.Forms.Label
        Me.lbl_address3 = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.lbl_pincode = New System.Windows.Forms.Label
        Me.lbl_state = New System.Windows.Forms.Label
        Me.lbl_phoneno = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_mobile = New System.Windows.Forms.Label
        Me.lbl_country = New System.Windows.Forms.Label
        Me.txt_LDRLocker = New System.Windows.Forms.TextBox
        Me.txt_HPLocker = New System.Windows.Forms.TextBox
        Me.txt_GDRLocker = New System.Windows.Forms.TextBox
        Me.lbl_GDRlocker = New System.Windows.Forms.Label
        Me.lbl_LDRlocker = New System.Windows.Forms.Label
        Me.lbl_HPlocker = New System.Windows.Forms.Label
        Me.cbo_CurrentStatus = New System.Windows.Forms.ComboBox
        Me.lbl_category = New System.Windows.Forms.Label
        Me.lbl_currentstatus = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.chk_BA_Copy = New System.Windows.Forms.CheckBox
        Me.txt_BA_PhoneNo = New System.Windows.Forms.TextBox
        Me.txt_BA_PinCode = New System.Windows.Forms.TextBox
        Me.txt_BA_Country = New System.Windows.Forms.TextBox
        Me.txt_BA_State = New System.Windows.Forms.TextBox
        Me.txt_BA_City = New System.Windows.Forms.TextBox
        Me.txt_BA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_BA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_BA_Address1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chk_PA_Copy = New System.Windows.Forms.CheckBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.txt_PA_Phone = New System.Windows.Forms.TextBox
        Me.txt_PA_PinCode = New System.Windows.Forms.TextBox
        Me.txt_PA_Country = New System.Windows.Forms.TextBox
        Me.txt_PA_State = New System.Windows.Forms.TextBox
        Me.txt_PA_City = New System.Windows.Forms.TextBox
        Me.txt_PA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_PA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_PA_Address1 = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Chk_RA_PA_Copy = New System.Windows.Forms.CheckBox
        Me.Chk_BA_PA_Copy = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.dtp_LastArrivalInCalcutta = New System.Windows.Forms.DateTimePicker
        Me.txt_ApplicationNo = New System.Windows.Forms.TextBox
        Me.txt_ReasonApplication = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txt_NoOfTimesProposed = New System.Windows.Forms.TextBox
        Me.chk_Elected = New System.Windows.Forms.CheckBox
        Me.chk_PreviouslyPr = New System.Windows.Forms.CheckBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.txt_Month = New System.Windows.Forms.TextBox
        Me.txt_PeriodOfStay = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.txt_DevelopmentFee = New System.Windows.Forms.TextBox
        Me.txt_EntranceFee = New System.Windows.Forms.TextBox
        Me.txt_SecurityDeposit = New System.Windows.Forms.TextBox
        Me.txt_CreditNumber = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dtp_DateApplication = New System.Windows.Forms.DateTimePicker
        Me.cmb_Appdt_c = New System.Windows.Forms.ComboBox
        Me.btn_Appdt_c = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dtp_DateProposal = New System.Windows.Forms.DateTimePicker
        Me.cmb_DateOf_c = New System.Windows.Forms.ComboBox
        Me.Btn_DateOf_c = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Txt_CreditLimit = New System.Windows.Forms.TextBox
        Me.Lbl_CreditLimit = New System.Windows.Forms.Label
        Me.Txt_PANNo = New System.Windows.Forms.TextBox
        Me.Lbl_PANNo = New System.Windows.Forms.Label
        Me.Btn_LastArr_c = New System.Windows.Forms.Button
        Me.cmb_LastArr_c = New System.Windows.Forms.ComboBox
        Me.Lbl_BloodGroup = New System.Windows.Forms.Label
        Me.Txt_BloodGroup = New System.Windows.Forms.TextBox
        Me.chk_EntranceFee = New System.Windows.Forms.CheckBox
        Me.chk_Memberofclub = New System.Windows.Forms.CheckBox
        Me.lbl_Specialinfo = New System.Windows.Forms.Label
        Me.cmd_SeconderCodeHelp = New System.Windows.Forms.Button
        Me.cmd_ProposerCodeHelp = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_Specialinfo = New System.Windows.Forms.TextBox
        Me.chk_AppliedMembership = New System.Windows.Forms.CheckBox
        Me.chk_Childrendetail = New System.Windows.Forms.CheckBox
        Me.chk_Relativesdetails = New System.Windows.Forms.CheckBox
        Me.chk_MemberQulification = New System.Windows.Forms.CheckBox
        Me.chk_Sports = New System.Windows.Forms.CheckBox
        Me.txt_PositionHeld = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_SeconderName = New System.Windows.Forms.TextBox
        Me.txt_ProposedName = New System.Windows.Forms.TextBox
        Me.txt_SeconderCode = New System.Windows.Forms.TextBox
        Me.txt_ProposerCode = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.sc = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_Clients = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_TurnOver = New System.Windows.Forms.TextBox
        Me.txt_Bankers = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_NoOfEmployee = New System.Windows.Forms.TextBox
        Me.txt_Agents = New System.Windows.Forms.TextBox
        Me.txt_Products = New System.Windows.Forms.TextBox
        Me.txt_Bussinessinfo = New System.Windows.Forms.TextBox
        Me.txt_Professonalinfo = New System.Windows.Forms.TextBox
        Me.txt_Designation = New System.Windows.Forms.TextBox
        Me.txt_CompanyName = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lbl_ESTDdate = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.lbl_NoOfEmployee = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Chk_Sec = New System.Windows.Forms.CheckBox
        Me.Chk_Prop = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_ESTDdate = New System.Windows.Forms.DateTimePicker
        Me.combo_HideDateESTD = New System.Windows.Forms.ComboBox
        Me.btn_ClearEstdDT = New System.Windows.Forms.Button
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.chk_pa_ca_copy = New System.Windows.Forms.CheckBox
        Me.chk_ba_ca_copy = New System.Windows.Forms.CheckBox
        Me.Chk_RA_CA_copy = New System.Windows.Forms.CheckBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.btn_details = New System.Windows.Forms.Button
        Me.txt_fmcode = New System.Windows.Forms.TextBox
        Me.Label109 = New System.Windows.Forms.Label
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.dtp_MembershipTo = New System.Windows.Forms.DateTimePicker
        Me.txt_spouse_dob = New System.Windows.Forms.TextBox
        Me.cmb_spouse_dob = New System.Windows.Forms.ComboBox
        Me.Btn_spousedob_c = New System.Windows.Forms.Button
        Me.Btn_Membershipfrom_c = New System.Windows.Forms.Button
        Me.Btn_BIRTH1 = New System.Windows.Forms.Button
        Me.CMB_BRITH = New System.Windows.Forms.ComboBox
        Me.TXT_SPOUSE_MOBILE = New System.Windows.Forms.TextBox
        Me.LBL_SPOUSE_MOBILE = New System.Windows.Forms.Label
        Me.Btn_MembershipTo_c = New System.Windows.Forms.Button
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.dtp_MembershipFrom = New System.Windows.Forms.DateTimePicker
        Me.Label96 = New System.Windows.Forms.Label
        Me.txt_Spouse = New System.Windows.Forms.TextBox
        Me.lbl_Spouse = New System.Windows.Forms.Label
        Me.cmb_Membershipfrom_c = New System.Windows.Forms.ComboBox
        Me.cmb_MembershipTo_c = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.grp_ChildrenDetails = New System.Windows.Forms.GroupBox
        Me.ssgrid = New AxFPUSpreadADO.AxfpSpread
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.cmd_ChildrenCancel = New System.Windows.Forms.Button
        Me.cmd_ChildrenOk = New System.Windows.Forms.Button
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.LStatus = New System.Windows.Forms.Label
        Me.Grp_MemQualification = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Cmd_MemberQuliCancel = New System.Windows.Forms.Button
        Me.Cmd_MemberQuliOk = New System.Windows.Forms.Button
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.SSgrid_Qualification = New AxFPUSpreadADO.AxfpSpread
        Me.grp_Relativedetails = New System.Windows.Forms.GroupBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.cmd_RelativeCancel = New System.Windows.Forms.Button
        Me.cmd_RelativesOk = New System.Windows.Forms.Button
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.SSgrid_Relatives = New AxFPUSpreadADO.AxfpSpread
        Me.grp_SportsIntrested = New System.Windows.Forms.GroupBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.cmd_SportsCancel = New System.Windows.Forms.Button
        Me.cmd_SportsOk = New System.Windows.Forms.Button
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.SSgrid_Sports = New AxFPUSpreadADO.AxfpSpread
        Me.grp_MemberClub = New System.Windows.Forms.GroupBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.cmd_ClubCancel = New System.Windows.Forms.Button
        Me.cmd_ClubOk = New System.Windows.Forms.Button
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.SSgrid_MemberClub = New AxFPUSpreadADO.AxfpSpread
        Me.Lst_BillHead = New System.Windows.Forms.ListBox
        Me.chk_Referencedetails = New System.Windows.Forms.CheckBox
        Me.grp_Referencedetails = New System.Windows.Forms.GroupBox
        Me.lbl_Referencedetails = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.cmd_ReferencedetailsCancel = New System.Windows.Forms.Button
        Me.cmd_ReferencedetailsOk = New System.Windows.Forms.Button
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.ssgrid_Referencedetails = New AxFPUSpreadADO.AxfpSpread
        Me.tip_Specialinfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.grp_Entrancefeedetails = New System.Windows.Forms.GroupBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.cmd_EntrancefeeCancel = New System.Windows.Forms.Button
        Me.cmd_EntrancefeeOK = New System.Windows.Forms.Button
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.SSgrid_Entrancefee = New AxFPUSpreadADO.AxfpSpread
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Chk_BA_RA_Copy = New System.Windows.Forms.CheckBox
        Me.Chk_PA_RA_Copy = New System.Windows.Forms.CheckBox
        Me.Chk_PA_BA_Copy = New System.Windows.Forms.CheckBox
        Me.Chk_RA_BA_Copy = New System.Windows.Forms.CheckBox
        Me.SIGNATURE = New System.Windows.Forms.CheckBox
        Me.PHOTO = New System.Windows.Forms.CheckBox
        Me.membersignature = New System.Windows.Forms.PictureBox
        Me.memberphoto = New System.Windows.Forms.PictureBox
        Me.grp_currentstatus = New System.Windows.Forms.GroupBox
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.cmd_currentstatus_cancel = New System.Windows.Forms.Button
        Me.cmd_currentstatus_ok = New System.Windows.Forms.Button
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.ssgrid_currentstatus = New AxFPUSpreadADO.AxfpSpread
        Me.TXT_TITLE = New System.Windows.Forms.TextBox
        Me.Label101 = New System.Windows.Forms.Label
        Me.grp_proposaldetails = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.cmd_ProposerCancel = New System.Windows.Forms.Button
        Me.cmd_ProposerOK = New System.Windows.Forms.Button
        Me.Label103 = New System.Windows.Forms.Label
        Me.Label104 = New System.Windows.Forms.Label
        Me.SSgrid_Proposal = New AxFPUSpreadADO.AxfpSpread
        Me.grp_Seconderdetails = New System.Windows.Forms.GroupBox
        Me.Label105 = New System.Windows.Forms.Label
        Me.Label106 = New System.Windows.Forms.Label
        Me.cmd_SeconderCancel = New System.Windows.Forms.Button
        Me.cmd_SeconderOK = New System.Windows.Forms.Button
        Me.Label107 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.SSgrid_Seconder = New AxFPUSpreadADO.AxfpSpread
        Me.lbl_Nationality = New System.Windows.Forms.Label
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.grp_ChildrenDetails.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.Grp_MemQualification.SuspendLayout()
        CType(Me.SSgrid_Qualification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Relativedetails.SuspendLayout()
        CType(Me.SSgrid_Relatives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_SportsIntrested.SuspendLayout()
        CType(Me.SSgrid_Sports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_MemberClub.SuspendLayout()
        CType(Me.SSgrid_MemberClub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Referencedetails.SuspendLayout()
        CType(Me.ssgrid_Referencedetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Entrancefeedetails.SuspendLayout()
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_currentstatus.SuspendLayout()
        CType(Me.ssgrid_currentstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_proposaldetails.SuspendLayout()
        CType(Me.SSgrid_Proposal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Seconderdetails.SuspendLayout()
        CType(Me.SSgrid_Seconder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_DateOfBirth
        '
        Me.dtp_DateOfBirth.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite
        Me.dtp_DateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtp_DateOfBirth.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_DateOfBirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtp_DateOfBirth.Location = New System.Drawing.Point(232, 192)
        Me.dtp_DateOfBirth.Name = "dtp_DateOfBirth"
        Me.dtp_DateOfBirth.Size = New System.Drawing.Size(152, 22)
        Me.dtp_DateOfBirth.TabIndex = 7
        Me.dtp_DateOfBirth.Value = New Date(2008, 7, 31, 0, 0, 0, 0)
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(368, 88)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'chk_Married
        '
        Me.chk_Married.BackColor = System.Drawing.Color.Transparent
        Me.chk_Married.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Married.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Married.Location = New System.Drawing.Point(720, 176)
        Me.chk_Married.Name = "chk_Married"
        Me.chk_Married.Size = New System.Drawing.Size(128, 24)
        Me.chk_Married.TabIndex = 605
        Me.chk_Married.Text = "Married"
        '
        'txt_CountryOfBirth
        '
        Me.txt_CountryOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CountryOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CountryOfBirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CountryOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CountryOfBirth.Location = New System.Drawing.Point(528, 192)
        Me.txt_CountryOfBirth.MaxLength = 30
        Me.txt_CountryOfBirth.Name = "txt_CountryOfBirth"
        Me.txt_CountryOfBirth.Size = New System.Drawing.Size(168, 22)
        Me.txt_CountryOfBirth.TabIndex = 14
        Me.txt_CountryOfBirth.Text = ""
        '
        'txt_PlaceOfBirth
        '
        Me.txt_PlaceOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PlaceOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_PlaceOfBirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PlaceOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_PlaceOfBirth.Location = New System.Drawing.Point(528, 168)
        Me.txt_PlaceOfBirth.MaxLength = 30
        Me.txt_PlaceOfBirth.Name = "txt_PlaceOfBirth"
        Me.txt_PlaceOfBirth.Size = New System.Drawing.Size(168, 22)
        Me.txt_PlaceOfBirth.TabIndex = 13
        Me.txt_PlaceOfBirth.Text = ""
        '
        'lbl_placeofbirth
        '
        Me.lbl_placeofbirth.AutoSize = True
        Me.lbl_placeofbirth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_placeofbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_placeofbirth.Location = New System.Drawing.Point(424, 172)
        Me.lbl_placeofbirth.Name = "lbl_placeofbirth"
        Me.lbl_placeofbirth.Size = New System.Drawing.Size(99, 18)
        Me.lbl_placeofbirth.TabIndex = 121
        Me.lbl_placeofbirth.Text = "Place of Birth :"
        '
        'chk_corporate
        '
        Me.chk_corporate.BackColor = System.Drawing.Color.Transparent
        Me.chk_corporate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_corporate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_corporate.Location = New System.Drawing.Point(720, 216)
        Me.chk_corporate.Name = "chk_corporate"
        Me.chk_corporate.Size = New System.Drawing.Size(128, 24)
        Me.chk_corporate.TabIndex = 606
        Me.chk_corporate.Text = "Corporate "
        '
        'chk_Billhead
        '
        Me.chk_Billhead.BackColor = System.Drawing.SystemColors.Control
        Me.chk_Billhead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Billhead.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Billhead.Location = New System.Drawing.Point(720, 176)
        Me.chk_Billhead.Name = "chk_Billhead"
        Me.chk_Billhead.Size = New System.Drawing.Size(128, 24)
        Me.chk_Billhead.TabIndex = 11
        Me.chk_Billhead.Text = "Bill Head [y/n]"
        Me.chk_Billhead.Visible = False
        '
        'txt_NationalityAtBirth
        '
        Me.txt_NationalityAtBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NationalityAtBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_NationalityAtBirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NationalityAtBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_NationalityAtBirth.Location = New System.Drawing.Point(232, 224)
        Me.txt_NationalityAtBirth.MaxLength = 50
        Me.txt_NationalityAtBirth.Name = "txt_NationalityAtBirth"
        Me.txt_NationalityAtBirth.Size = New System.Drawing.Size(168, 22)
        Me.txt_NationalityAtBirth.TabIndex = 9
        Me.txt_NationalityAtBirth.Text = ""
        '
        'txt_Nationality
        '
        Me.txt_Nationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nationality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Nationality.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nationality.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Nationality.Location = New System.Drawing.Point(232, 168)
        Me.txt_Nationality.MaxLength = 50
        Me.txt_Nationality.Name = "txt_Nationality"
        Me.txt_Nationality.Size = New System.Drawing.Size(168, 22)
        Me.txt_Nationality.TabIndex = 6
        Me.txt_Nationality.Text = ""
        '
        'lbl_dateofbirth
        '
        Me.lbl_dateofbirth.AutoSize = True
        Me.lbl_dateofbirth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dateofbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dateofbirth.Location = New System.Drawing.Point(104, 193)
        Me.lbl_dateofbirth.Name = "lbl_dateofbirth"
        Me.lbl_dateofbirth.Size = New System.Drawing.Size(108, 18)
        Me.lbl_dateofbirth.TabIndex = 119
        Me.lbl_dateofbirth.Text = "Date Of Birth*   :"
        '
        'lbl_nationalityatbirth
        '
        Me.lbl_nationalityatbirth.AutoSize = True
        Me.lbl_nationalityatbirth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nationalityatbirth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nationalityatbirth.Location = New System.Drawing.Point(96, 224)
        Me.lbl_nationalityatbirth.Name = "lbl_nationalityatbirth"
        Me.lbl_nationalityatbirth.Size = New System.Drawing.Size(134, 18)
        Me.lbl_nationalityatbirth.TabIndex = 120
        Me.lbl_nationalityatbirth.Text = "Nationality At Birth :"
        '
        'txt_Surname
        '
        Me.txt_Surname.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Surname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Surname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Surname.Location = New System.Drawing.Point(520, 128)
        Me.txt_Surname.MaxLength = 35
        Me.txt_Surname.Name = "txt_Surname"
        Me.txt_Surname.Size = New System.Drawing.Size(144, 22)
        Me.txt_Surname.TabIndex = 5
        Me.txt_Surname.Text = ""
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.BackColor = System.Drawing.Color.White
        Me.txt_MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MiddleName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MiddleName.Location = New System.Drawing.Point(360, 128)
        Me.txt_MiddleName.MaxLength = 35
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(144, 22)
        Me.txt_MiddleName.TabIndex = 4
        Me.txt_MiddleName.Text = ""
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_FirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_FirstName.Location = New System.Drawing.Point(208, 128)
        Me.txt_FirstName.MaxLength = 35
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(136, 22)
        Me.txt_FirstName.TabIndex = 3
        Me.txt_FirstName.Text = ""
        '
        'cbo_Title
        '
        Me.cbo_Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cbo_Title.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_Title.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbo_Title.ItemHeight = 13
        Me.cbo_Title.Items.AddRange(New Object() {"Mr.", "Ms.", "Miss.", "Master."})
        Me.cbo_Title.Location = New System.Drawing.Point(104, 128)
        Me.cbo_Title.MaxDropDownItems = 100
        Me.cbo_Title.Name = "cbo_Title"
        Me.cbo_Title.Size = New System.Drawing.Size(88, 21)
        Me.cbo_Title.TabIndex = 2
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MemberCode.Location = New System.Drawing.Point(200, 85)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 26)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MiddleName
        '
        Me.lbl_MiddleName.AutoSize = True
        Me.lbl_MiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MiddleName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MiddleName.Location = New System.Drawing.Point(360, 112)
        Me.lbl_MiddleName.Name = "lbl_MiddleName"
        Me.lbl_MiddleName.Size = New System.Drawing.Size(96, 18)
        Me.lbl_MiddleName.TabIndex = 115
        Me.lbl_MiddleName.Text = "Middle Name :"
        '
        'lbl_surname
        '
        Me.lbl_surname.AutoSize = True
        Me.lbl_surname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_surname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_surname.Location = New System.Drawing.Point(520, 112)
        Me.lbl_surname.Name = "lbl_surname"
        Me.lbl_surname.Size = New System.Drawing.Size(76, 18)
        Me.lbl_surname.TabIndex = 116
        Me.lbl_surname.Text = "Surname* :"
        '
        'lbl_FirstName
        '
        Me.lbl_FirstName.AutoSize = True
        Me.lbl_FirstName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FirstName.Location = New System.Drawing.Point(208, 112)
        Me.lbl_FirstName.Name = "lbl_FirstName"
        Me.lbl_FirstName.Size = New System.Drawing.Size(87, 18)
        Me.lbl_FirstName.TabIndex = 114
        Me.lbl_FirstName.Text = "First Name* :"
        '
        'lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title.Location = New System.Drawing.Point(96, 112)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(41, 18)
        Me.lbl_Title.TabIndex = 113
        Me.lbl_Title.Text = "Title :"
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(96, 88)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(110, 18)
        Me.lbl_MemberCode.TabIndex = 112
        Me.lbl_MemberCode.Text = "Member Code*  :"
        '
        'chk_RA_Copy
        '
        Me.chk_RA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.chk_RA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_RA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_RA_Copy.Location = New System.Drawing.Point(648, 616)
        Me.chk_RA_Copy.Name = "chk_RA_Copy"
        Me.chk_RA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.chk_RA_Copy.TabIndex = 669
        Me.chk_RA_Copy.Text = "Copy Contact Address"
        '
        'txt_RA_PhoneNo
        '
        Me.txt_RA_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_PhoneNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_PhoneNo.Location = New System.Drawing.Point(464, 703)
        Me.txt_RA_PhoneNo.MaxLength = 20
        Me.txt_RA_PhoneNo.Name = "txt_RA_PhoneNo"
        Me.txt_RA_PhoneNo.Size = New System.Drawing.Size(176, 22)
        Me.txt_RA_PhoneNo.TabIndex = 47
        Me.txt_RA_PhoneNo.Text = ""
        '
        'txt_RA_PinCode
        '
        Me.txt_RA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_PinCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_PinCode.Location = New System.Drawing.Point(464, 674)
        Me.txt_RA_PinCode.MaxLength = 10
        Me.txt_RA_PinCode.Name = "txt_RA_PinCode"
        Me.txt_RA_PinCode.Size = New System.Drawing.Size(176, 22)
        Me.txt_RA_PinCode.TabIndex = 46
        Me.txt_RA_PinCode.Text = ""
        '
        'txt_RA_Country
        '
        Me.txt_RA_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Country.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Country.Location = New System.Drawing.Point(464, 645)
        Me.txt_RA_Country.MaxLength = 25
        Me.txt_RA_Country.Name = "txt_RA_Country"
        Me.txt_RA_Country.Size = New System.Drawing.Size(176, 22)
        Me.txt_RA_Country.TabIndex = 45
        Me.txt_RA_Country.Text = ""
        '
        'txt_RA_State
        '
        Me.txt_RA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_State.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_State.Location = New System.Drawing.Point(464, 616)
        Me.txt_RA_State.MaxLength = 25
        Me.txt_RA_State.Name = "txt_RA_State"
        Me.txt_RA_State.Size = New System.Drawing.Size(176, 22)
        Me.txt_RA_State.TabIndex = 44
        Me.txt_RA_State.Text = ""
        '
        'txt_RA_City
        '
        Me.txt_RA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_City.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_City.Location = New System.Drawing.Point(192, 703)
        Me.txt_RA_City.MaxLength = 25
        Me.txt_RA_City.Name = "txt_RA_City"
        Me.txt_RA_City.Size = New System.Drawing.Size(192, 22)
        Me.txt_RA_City.TabIndex = 43
        Me.txt_RA_City.Text = ""
        '
        'txt_RA_Address3
        '
        Me.txt_RA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address3.Location = New System.Drawing.Point(192, 674)
        Me.txt_RA_Address3.MaxLength = 50
        Me.txt_RA_Address3.Name = "txt_RA_Address3"
        Me.txt_RA_Address3.Size = New System.Drawing.Size(192, 22)
        Me.txt_RA_Address3.TabIndex = 42
        Me.txt_RA_Address3.Text = ""
        '
        'txt_RA_Address2
        '
        Me.txt_RA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address2.Location = New System.Drawing.Point(192, 645)
        Me.txt_RA_Address2.MaxLength = 50
        Me.txt_RA_Address2.Name = "txt_RA_Address2"
        Me.txt_RA_Address2.Size = New System.Drawing.Size(192, 22)
        Me.txt_RA_Address2.TabIndex = 41
        Me.txt_RA_Address2.Text = ""
        '
        'txt_RA_Address1
        '
        Me.txt_RA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address1.Location = New System.Drawing.Point(192, 616)
        Me.txt_RA_Address1.MaxLength = 50
        Me.txt_RA_Address1.Name = "txt_RA_Address1"
        Me.txt_RA_Address1.Size = New System.Drawing.Size(192, 22)
        Me.txt_RA_Address1.TabIndex = 40
        Me.txt_RA_Address1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 616)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Address 1 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(96, 645)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Address 2 :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 674)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 18)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Address Line 3 :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(96, 704)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 18)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "City :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(392, 674)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 18)
        Me.Label13.TabIndex = 152
        Me.Label13.Text = "Pin Code :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(392, 616)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 18)
        Me.Label14.TabIndex = 150
        Me.Label14.Text = "State :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(392, 704)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 18)
        Me.Label15.TabIndex = 153
        Me.Label15.Text = "Phone No :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(392, 645)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 18)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Country :"
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
        Me.txt_Category.Location = New System.Drawing.Point(512, 336)
        Me.txt_Category.MaxLength = 15
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(168, 22)
        Me.txt_Category.TabIndex = 26
        Me.txt_Category.Text = ""
        '
        'cmd_CategoryHelp
        '
        Me.cmd_CategoryHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_CategoryHelp.Image = CType(resources.GetObject("cmd_CategoryHelp.Image"), System.Drawing.Image)
        Me.cmd_CategoryHelp.Location = New System.Drawing.Point(680, 336)
        Me.cmd_CategoryHelp.Name = "cmd_CategoryHelp"
        Me.cmd_CategoryHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_CategoryHelp.TabIndex = 27
        '
        'cmd_CorporateCodeHelp
        '
        Me.cmd_CorporateCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_CorporateCodeHelp.Image = CType(resources.GetObject("cmd_CorporateCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CorporateCodeHelp.Location = New System.Drawing.Point(680, 304)
        Me.cmd_CorporateCodeHelp.Name = "cmd_CorporateCodeHelp"
        Me.cmd_CorporateCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_CorporateCodeHelp.TabIndex = 25
        '
        'opt_Female
        '
        Me.opt_Female.BackColor = System.Drawing.Color.Transparent
        Me.opt_Female.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opt_Female.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Female.Location = New System.Drawing.Point(736, 327)
        Me.opt_Female.Name = "opt_Female"
        Me.opt_Female.Size = New System.Drawing.Size(112, 24)
        Me.opt_Female.TabIndex = 30
        Me.opt_Female.Text = "Female"
        '
        'opt_Male
        '
        Me.opt_Male.BackColor = System.Drawing.Color.Transparent
        Me.opt_Male.Checked = True
        Me.opt_Male.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.opt_Male.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Male.Location = New System.Drawing.Point(736, 304)
        Me.opt_Male.Name = "opt_Male"
        Me.opt_Male.Size = New System.Drawing.Size(112, 24)
        Me.opt_Male.TabIndex = 29
        Me.opt_Male.TabStop = True
        Me.opt_Male.Text = "Male"
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(392, 304)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(119, 18)
        Me.lbl_CorporateCode.TabIndex = 127
        Me.lbl_CorporateCode.Text = "Corporate Code* :"
        '
        'txt_CorporateCode
        '
        Me.txt_CorporateCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CorporateCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CorporateCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_CorporateCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CorporateCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_CorporateCode.Location = New System.Drawing.Point(512, 304)
        Me.txt_CorporateCode.MaxLength = 10
        Me.txt_CorporateCode.Name = "txt_CorporateCode"
        Me.txt_CorporateCode.Size = New System.Drawing.Size(168, 22)
        Me.txt_CorporateCode.TabIndex = 24
        Me.txt_CorporateCode.Text = ""
        '
        'Label216
        '
        Me.Label216.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label216.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label216.ForeColor = System.Drawing.Color.White
        Me.Label216.Location = New System.Drawing.Point(95, 580)
        Me.Label216.Name = "Label216"
        Me.Label216.Size = New System.Drawing.Size(265, 16)
        Me.Label216.TabIndex = 144
        Me.Label216.Text = "R E S I D E N C E   A D D R E S S .  . ."
        '
        'Label217
        '
        Me.Label217.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label217.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label217.Location = New System.Drawing.Point(88, 576)
        Me.Label217.Name = "Label217"
        Me.Label217.Size = New System.Drawing.Size(768, 24)
        Me.Label217.TabIndex = 407
        '
        'Label231
        '
        Me.Label231.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label231.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label231.ForeColor = System.Drawing.Color.White
        Me.Label231.Location = New System.Drawing.Point(96, 416)
        Me.Label231.Name = "Label231"
        Me.Label231.Size = New System.Drawing.Size(176, 19)
        Me.Label231.TabIndex = 131
        Me.Label231.Text = "CONTACT ADDRESS"
        '
        'Label232
        '
        Me.Label232.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label232.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label232.Location = New System.Drawing.Point(88, 416)
        Me.Label232.Name = "Label232"
        Me.Label232.Size = New System.Drawing.Size(768, 24)
        Me.Label232.TabIndex = 405
        '
        'txt_CA_Fax
        '
        Me.txt_CA_Fax.BackColor = System.Drawing.Color.White
        Me.txt_CA_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Fax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Fax.Location = New System.Drawing.Point(704, 496)
        Me.txt_CA_Fax.MaxLength = 15
        Me.txt_CA_Fax.Name = "txt_CA_Fax"
        Me.txt_CA_Fax.Size = New System.Drawing.Size(144, 22)
        Me.txt_CA_Fax.TabIndex = 39
        Me.txt_CA_Fax.Text = ""
        '
        'txt_CA_Mobile
        '
        Me.txt_CA_Mobile.BackColor = System.Drawing.Color.White
        Me.txt_CA_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Mobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Mobile.Location = New System.Drawing.Point(704, 472)
        Me.txt_CA_Mobile.MaxLength = 15
        Me.txt_CA_Mobile.Name = "txt_CA_Mobile"
        Me.txt_CA_Mobile.Size = New System.Drawing.Size(144, 22)
        Me.txt_CA_Mobile.TabIndex = 38
        Me.txt_CA_Mobile.Text = ""
        '
        'txt_CA_Phone
        '
        Me.txt_CA_Phone.BackColor = System.Drawing.Color.White
        Me.txt_CA_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Phone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Phone.Location = New System.Drawing.Point(704, 448)
        Me.txt_CA_Phone.MaxLength = 20
        Me.txt_CA_Phone.Name = "txt_CA_Phone"
        Me.txt_CA_Phone.Size = New System.Drawing.Size(144, 22)
        Me.txt_CA_Phone.TabIndex = 37
        Me.txt_CA_Phone.Text = ""
        '
        'txt_CA_EMail
        '
        Me.txt_CA_EMail.BackColor = System.Drawing.Color.White
        Me.txt_CA_EMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_EMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_CA_EMail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_EMail.Location = New System.Drawing.Point(448, 544)
        Me.txt_CA_EMail.MaxLength = 35
        Me.txt_CA_EMail.Name = "txt_CA_EMail"
        Me.txt_CA_EMail.Size = New System.Drawing.Size(176, 22)
        Me.txt_CA_EMail.TabIndex = 36
        Me.txt_CA_EMail.Text = ""
        '
        'txt_CA_Pin
        '
        Me.txt_CA_Pin.BackColor = System.Drawing.Color.White
        Me.txt_CA_Pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Pin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Pin.Location = New System.Drawing.Point(448, 512)
        Me.txt_CA_Pin.MaxLength = 10
        Me.txt_CA_Pin.Name = "txt_CA_Pin"
        Me.txt_CA_Pin.Size = New System.Drawing.Size(176, 22)
        Me.txt_CA_Pin.TabIndex = 35
        Me.txt_CA_Pin.Text = ""
        '
        'txt_CA_Country
        '
        Me.txt_CA_Country.BackColor = System.Drawing.Color.White
        Me.txt_CA_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Country.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Country.Location = New System.Drawing.Point(448, 480)
        Me.txt_CA_Country.MaxLength = 25
        Me.txt_CA_Country.Name = "txt_CA_Country"
        Me.txt_CA_Country.Size = New System.Drawing.Size(176, 22)
        Me.txt_CA_Country.TabIndex = 34
        Me.txt_CA_Country.Text = ""
        '
        'txt_CA_State
        '
        Me.txt_CA_State.BackColor = System.Drawing.Color.White
        Me.txt_CA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_State.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_State.Location = New System.Drawing.Point(448, 448)
        Me.txt_CA_State.MaxLength = 25
        Me.txt_CA_State.Name = "txt_CA_State"
        Me.txt_CA_State.Size = New System.Drawing.Size(176, 22)
        Me.txt_CA_State.TabIndex = 33
        Me.txt_CA_State.Text = ""
        '
        'txt_CA_City
        '
        Me.txt_CA_City.BackColor = System.Drawing.Color.White
        Me.txt_CA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_City.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_City.Location = New System.Drawing.Point(176, 544)
        Me.txt_CA_City.MaxLength = 25
        Me.txt_CA_City.Name = "txt_CA_City"
        Me.txt_CA_City.Size = New System.Drawing.Size(184, 22)
        Me.txt_CA_City.TabIndex = 32
        Me.txt_CA_City.Text = ""
        '
        'txt_CA_Address3
        '
        Me.txt_CA_Address3.BackColor = System.Drawing.Color.White
        Me.txt_CA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Address3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Address3.Location = New System.Drawing.Point(176, 512)
        Me.txt_CA_Address3.MaxLength = 50
        Me.txt_CA_Address3.Name = "txt_CA_Address3"
        Me.txt_CA_Address3.Size = New System.Drawing.Size(184, 22)
        Me.txt_CA_Address3.TabIndex = 31
        Me.txt_CA_Address3.Text = ""
        '
        'txt_CA_Address2
        '
        Me.txt_CA_Address2.BackColor = System.Drawing.Color.White
        Me.txt_CA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Address2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Address2.Location = New System.Drawing.Point(176, 480)
        Me.txt_CA_Address2.MaxLength = 50
        Me.txt_CA_Address2.Name = "txt_CA_Address2"
        Me.txt_CA_Address2.Size = New System.Drawing.Size(184, 22)
        Me.txt_CA_Address2.TabIndex = 30
        Me.txt_CA_Address2.Text = ""
        '
        'txt_CA_Address1
        '
        Me.txt_CA_Address1.BackColor = System.Drawing.Color.White
        Me.txt_CA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CA_Address1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CA_Address1.Location = New System.Drawing.Point(176, 448)
        Me.txt_CA_Address1.MaxLength = 50
        Me.txt_CA_Address1.Name = "txt_CA_Address1"
        Me.txt_CA_Address1.Size = New System.Drawing.Size(184, 22)
        Me.txt_CA_Address1.TabIndex = 29
        Me.txt_CA_Address1.Text = ""
        '
        'lbl_Fax
        '
        Me.lbl_Fax.AutoSize = True
        Me.lbl_Fax.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fax.Location = New System.Drawing.Point(632, 496)
        Me.lbl_Fax.Name = "lbl_Fax"
        Me.lbl_Fax.Size = New System.Drawing.Size(36, 18)
        Me.lbl_Fax.TabIndex = 143
        Me.lbl_Fax.Text = "Fax :"
        '
        'lbl_Address1
        '
        Me.lbl_Address1.AutoSize = True
        Me.lbl_Address1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Address1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Address1.Location = New System.Drawing.Point(96, 448)
        Me.lbl_Address1.Name = "lbl_Address1"
        Me.lbl_Address1.Size = New System.Drawing.Size(81, 18)
        Me.lbl_Address1.TabIndex = 133
        Me.lbl_Address1.Text = "Address  1 :"
        '
        'lbl_address2
        '
        Me.lbl_address2.AutoSize = True
        Me.lbl_address2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address2.Location = New System.Drawing.Point(96, 480)
        Me.lbl_address2.Name = "lbl_address2"
        Me.lbl_address2.Size = New System.Drawing.Size(81, 18)
        Me.lbl_address2.TabIndex = 134
        Me.lbl_address2.Text = "Address  2 :"
        '
        'lbl_address3
        '
        Me.lbl_address3.AutoSize = True
        Me.lbl_address3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address3.Location = New System.Drawing.Point(96, 512)
        Me.lbl_address3.Name = "lbl_address3"
        Me.lbl_address3.Size = New System.Drawing.Size(81, 18)
        Me.lbl_address3.TabIndex = 135
        Me.lbl_address3.Text = "Address  3 :"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.BackColor = System.Drawing.Color.Transparent
        Me.lbl_city.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.Location = New System.Drawing.Point(96, 544)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(38, 18)
        Me.lbl_city.TabIndex = 136
        Me.lbl_city.Text = "City :"
        '
        'lbl_pincode
        '
        Me.lbl_pincode.AutoSize = True
        Me.lbl_pincode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pincode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pincode.Location = New System.Drawing.Point(376, 512)
        Me.lbl_pincode.Name = "lbl_pincode"
        Me.lbl_pincode.Size = New System.Drawing.Size(71, 18)
        Me.lbl_pincode.TabIndex = 139
        Me.lbl_pincode.Text = "Pin Code :"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.BackColor = System.Drawing.Color.Transparent
        Me.lbl_state.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_state.Location = New System.Drawing.Point(376, 448)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(46, 18)
        Me.lbl_state.TabIndex = 137
        Me.lbl_state.Text = "State :"
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phoneno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phoneno.Location = New System.Drawing.Point(632, 448)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(76, 18)
        Me.lbl_phoneno.TabIndex = 141
        Me.lbl_phoneno.Text = "Phone No :"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(376, 544)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(52, 18)
        Me.lbl_email.TabIndex = 140
        Me.lbl_email.Text = "E Mail :"
        '
        'lbl_mobile
        '
        Me.lbl_mobile.AutoSize = True
        Me.lbl_mobile.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mobile.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mobile.Location = New System.Drawing.Point(632, 472)
        Me.lbl_mobile.Name = "lbl_mobile"
        Me.lbl_mobile.Size = New System.Drawing.Size(55, 18)
        Me.lbl_mobile.TabIndex = 142
        Me.lbl_mobile.Text = "Mobile :"
        '
        'lbl_country
        '
        Me.lbl_country.AutoSize = True
        Me.lbl_country.BackColor = System.Drawing.Color.Transparent
        Me.lbl_country.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_country.Location = New System.Drawing.Point(376, 480)
        Me.lbl_country.Name = "lbl_country"
        Me.lbl_country.Size = New System.Drawing.Size(64, 18)
        Me.lbl_country.TabIndex = 138
        Me.lbl_country.Text = "Country :"
        '
        'txt_LDRLocker
        '
        Me.txt_LDRLocker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_LDRLocker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LDRLocker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_LDRLocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LDRLocker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_LDRLocker.Location = New System.Drawing.Point(208, 368)
        Me.txt_LDRLocker.MaxLength = 100
        Me.txt_LDRLocker.Name = "txt_LDRLocker"
        Me.txt_LDRLocker.Size = New System.Drawing.Size(160, 22)
        Me.txt_LDRLocker.TabIndex = 22
        Me.txt_LDRLocker.Text = ""
        '
        'txt_HPLocker
        '
        Me.txt_HPLocker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_HPLocker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_HPLocker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_HPLocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HPLocker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_HPLocker.Location = New System.Drawing.Point(200, 392)
        Me.txt_HPLocker.MaxLength = 10
        Me.txt_HPLocker.Name = "txt_HPLocker"
        Me.txt_HPLocker.Size = New System.Drawing.Size(184, 22)
        Me.txt_HPLocker.TabIndex = 23
        Me.txt_HPLocker.Text = ""
        Me.txt_HPLocker.Visible = False
        '
        'txt_GDRLocker
        '
        Me.txt_GDRLocker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_GDRLocker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GDRLocker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_GDRLocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GDRLocker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_GDRLocker.Location = New System.Drawing.Point(120, 48)
        Me.txt_GDRLocker.MaxLength = 100
        Me.txt_GDRLocker.Name = "txt_GDRLocker"
        Me.txt_GDRLocker.Size = New System.Drawing.Size(160, 22)
        Me.txt_GDRLocker.TabIndex = 21
        Me.txt_GDRLocker.Text = ""
        '
        'lbl_GDRlocker
        '
        Me.lbl_GDRlocker.AutoSize = True
        Me.lbl_GDRlocker.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GDRlocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GDRlocker.Location = New System.Drawing.Point(8, 48)
        Me.lbl_GDRlocker.Name = "lbl_GDRlocker"
        Me.lbl_GDRlocker.Size = New System.Drawing.Size(98, 18)
        Me.lbl_GDRlocker.TabIndex = 124
        Me.lbl_GDRlocker.Text = "Father Name  :"
        '
        'lbl_LDRlocker
        '
        Me.lbl_LDRlocker.AutoSize = True
        Me.lbl_LDRlocker.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LDRlocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LDRlocker.Location = New System.Drawing.Point(120, 368)
        Me.lbl_LDRlocker.Name = "lbl_LDRlocker"
        Me.lbl_LDRlocker.Size = New System.Drawing.Size(73, 18)
        Me.lbl_LDRlocker.TabIndex = 125
        Me.lbl_LDRlocker.Text = "Nominee  :"
        '
        'lbl_HPlocker
        '
        Me.lbl_HPlocker.AutoSize = True
        Me.lbl_HPlocker.BackColor = System.Drawing.Color.Transparent
        Me.lbl_HPlocker.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HPlocker.Location = New System.Drawing.Point(112, 392)
        Me.lbl_HPlocker.Name = "lbl_HPlocker"
        Me.lbl_HPlocker.Size = New System.Drawing.Size(79, 18)
        Me.lbl_HPlocker.TabIndex = 126
        Me.lbl_HPlocker.Text = "HP Locker :"
        Me.lbl_HPlocker.Visible = False
        '
        'cbo_CurrentStatus
        '
        Me.cbo_CurrentStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_CurrentStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_CurrentStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_CurrentStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_CurrentStatus.ItemHeight = 16
        Me.cbo_CurrentStatus.Items.AddRange(New Object() {"ABSENTEE", "DELETED", "EXPIRED", "INACTIVE", "LIVE", "RESIGNED", "SURRENDERED", "REVIEW", "DEAD"})
        Me.cbo_CurrentStatus.Location = New System.Drawing.Point(512, 368)
        Me.cbo_CurrentStatus.Name = "cbo_CurrentStatus"
        Me.cbo_CurrentStatus.Size = New System.Drawing.Size(168, 24)
        Me.cbo_CurrentStatus.TabIndex = 28
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(392, 336)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(113, 18)
        Me.lbl_category.TabIndex = 128
        Me.lbl_category.Text = "Category Code* :"
        '
        'lbl_currentstatus
        '
        Me.lbl_currentstatus.AutoSize = True
        Me.lbl_currentstatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_currentstatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentstatus.Location = New System.Drawing.Point(400, 368)
        Me.lbl_currentstatus.Name = "lbl_currentstatus"
        Me.lbl_currentstatus.Size = New System.Drawing.Size(110, 18)
        Me.lbl_currentstatus.TabIndex = 129
        Me.lbl_currentstatus.Text = "Current status* :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.SystemColors.Menu
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(392, 288)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(0, 19)
        Me.Label43.TabIndex = 409
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Location = New System.Drawing.Point(88, 592)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(768, 136)
        Me.GroupBox9.TabIndex = 145
        Me.GroupBox9.TabStop = False
        '
        'chk_BA_Copy
        '
        Me.chk_BA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.chk_BA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_BA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BA_Copy.Location = New System.Drawing.Point(648, 768)
        Me.chk_BA_Copy.Name = "chk_BA_Copy"
        Me.chk_BA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.chk_BA_Copy.TabIndex = 703
        Me.chk_BA_Copy.Text = "Copy Contact Address"
        '
        'txt_BA_PhoneNo
        '
        Me.txt_BA_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_PhoneNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_PhoneNo.Location = New System.Drawing.Point(464, 855)
        Me.txt_BA_PhoneNo.MaxLength = 20
        Me.txt_BA_PhoneNo.Name = "txt_BA_PhoneNo"
        Me.txt_BA_PhoneNo.Size = New System.Drawing.Size(176, 22)
        Me.txt_BA_PhoneNo.TabIndex = 55
        Me.txt_BA_PhoneNo.Text = ""
        '
        'txt_BA_PinCode
        '
        Me.txt_BA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_PinCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_PinCode.Location = New System.Drawing.Point(464, 826)
        Me.txt_BA_PinCode.MaxLength = 10
        Me.txt_BA_PinCode.Name = "txt_BA_PinCode"
        Me.txt_BA_PinCode.Size = New System.Drawing.Size(176, 22)
        Me.txt_BA_PinCode.TabIndex = 54
        Me.txt_BA_PinCode.Text = ""
        '
        'txt_BA_Country
        '
        Me.txt_BA_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Country.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Country.Location = New System.Drawing.Point(464, 797)
        Me.txt_BA_Country.MaxLength = 25
        Me.txt_BA_Country.Name = "txt_BA_Country"
        Me.txt_BA_Country.Size = New System.Drawing.Size(176, 22)
        Me.txt_BA_Country.TabIndex = 53
        Me.txt_BA_Country.Text = ""
        '
        'txt_BA_State
        '
        Me.txt_BA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_State.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_State.Location = New System.Drawing.Point(464, 768)
        Me.txt_BA_State.MaxLength = 25
        Me.txt_BA_State.Name = "txt_BA_State"
        Me.txt_BA_State.Size = New System.Drawing.Size(176, 22)
        Me.txt_BA_State.TabIndex = 52
        Me.txt_BA_State.Text = ""
        '
        'txt_BA_City
        '
        Me.txt_BA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_City.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_City.Location = New System.Drawing.Point(192, 856)
        Me.txt_BA_City.MaxLength = 25
        Me.txt_BA_City.Name = "txt_BA_City"
        Me.txt_BA_City.Size = New System.Drawing.Size(192, 22)
        Me.txt_BA_City.TabIndex = 51
        Me.txt_BA_City.Text = ""
        '
        'txt_BA_Address3
        '
        Me.txt_BA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address3.Location = New System.Drawing.Point(192, 826)
        Me.txt_BA_Address3.MaxLength = 50
        Me.txt_BA_Address3.Name = "txt_BA_Address3"
        Me.txt_BA_Address3.Size = New System.Drawing.Size(192, 22)
        Me.txt_BA_Address3.TabIndex = 50
        Me.txt_BA_Address3.Text = ""
        '
        'txt_BA_Address2
        '
        Me.txt_BA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address2.Location = New System.Drawing.Point(192, 797)
        Me.txt_BA_Address2.MaxLength = 50
        Me.txt_BA_Address2.Name = "txt_BA_Address2"
        Me.txt_BA_Address2.Size = New System.Drawing.Size(192, 22)
        Me.txt_BA_Address2.TabIndex = 49
        Me.txt_BA_Address2.Text = ""
        '
        'txt_BA_Address1
        '
        Me.txt_BA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address1.Location = New System.Drawing.Point(192, 768)
        Me.txt_BA_Address1.MaxLength = 50
        Me.txt_BA_Address1.Name = "txt_BA_Address1"
        Me.txt_BA_Address1.Size = New System.Drawing.Size(192, 22)
        Me.txt_BA_Address1.TabIndex = 48
        Me.txt_BA_Address1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 768)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Address 1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 800)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Address 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 832)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Address 3 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 856)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 18)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "City :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 826)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Pin Code :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 768)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "State :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(392, 856)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 18)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Phone No :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 797)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Country :"
        '
        'chk_PA_Copy
        '
        Me.chk_PA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.chk_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PA_Copy.Location = New System.Drawing.Point(648, 920)
        Me.chk_PA_Copy.Name = "chk_PA_Copy"
        Me.chk_PA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.chk_PA_Copy.TabIndex = 709
        Me.chk_PA_Copy.Text = "Copy Contact Address"
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label60.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(96, 888)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(272, 16)
        Me.Label60.TabIndex = 164
        Me.Label60.Text = "P E R M A N E N T   A D D R E S S .  . ."
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label61.Location = New System.Drawing.Point(88, 888)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(768, 24)
        Me.Label61.TabIndex = 455
        '
        'txt_PA_Phone
        '
        Me.txt_PA_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Phone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Phone.Location = New System.Drawing.Point(464, 1016)
        Me.txt_PA_Phone.MaxLength = 20
        Me.txt_PA_Phone.Name = "txt_PA_Phone"
        Me.txt_PA_Phone.Size = New System.Drawing.Size(176, 22)
        Me.txt_PA_Phone.TabIndex = 63
        Me.txt_PA_Phone.Text = ""
        '
        'txt_PA_PinCode
        '
        Me.txt_PA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_PinCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_PinCode.Location = New System.Drawing.Point(464, 984)
        Me.txt_PA_PinCode.MaxLength = 10
        Me.txt_PA_PinCode.Name = "txt_PA_PinCode"
        Me.txt_PA_PinCode.Size = New System.Drawing.Size(176, 22)
        Me.txt_PA_PinCode.TabIndex = 62
        Me.txt_PA_PinCode.Text = ""
        '
        'txt_PA_Country
        '
        Me.txt_PA_Country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Country.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Country.Location = New System.Drawing.Point(464, 952)
        Me.txt_PA_Country.MaxLength = 25
        Me.txt_PA_Country.Name = "txt_PA_Country"
        Me.txt_PA_Country.Size = New System.Drawing.Size(176, 22)
        Me.txt_PA_Country.TabIndex = 61
        Me.txt_PA_Country.Text = ""
        '
        'txt_PA_State
        '
        Me.txt_PA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_State.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_State.Location = New System.Drawing.Point(464, 920)
        Me.txt_PA_State.MaxLength = 25
        Me.txt_PA_State.Name = "txt_PA_State"
        Me.txt_PA_State.Size = New System.Drawing.Size(176, 22)
        Me.txt_PA_State.TabIndex = 60
        Me.txt_PA_State.Text = ""
        '
        'txt_PA_City
        '
        Me.txt_PA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_City.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_City.Location = New System.Drawing.Point(192, 1016)
        Me.txt_PA_City.MaxLength = 25
        Me.txt_PA_City.Name = "txt_PA_City"
        Me.txt_PA_City.Size = New System.Drawing.Size(192, 22)
        Me.txt_PA_City.TabIndex = 59
        Me.txt_PA_City.Text = ""
        '
        'txt_PA_Address3
        '
        Me.txt_PA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address3.Location = New System.Drawing.Point(192, 984)
        Me.txt_PA_Address3.MaxLength = 50
        Me.txt_PA_Address3.Name = "txt_PA_Address3"
        Me.txt_PA_Address3.Size = New System.Drawing.Size(192, 22)
        Me.txt_PA_Address3.TabIndex = 58
        Me.txt_PA_Address3.Text = ""
        '
        'txt_PA_Address2
        '
        Me.txt_PA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address2.Location = New System.Drawing.Point(192, 952)
        Me.txt_PA_Address2.MaxLength = 50
        Me.txt_PA_Address2.Name = "txt_PA_Address2"
        Me.txt_PA_Address2.Size = New System.Drawing.Size(192, 22)
        Me.txt_PA_Address2.TabIndex = 57
        Me.txt_PA_Address2.Text = ""
        '
        'txt_PA_Address1
        '
        Me.txt_PA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address1.Location = New System.Drawing.Point(192, 920)
        Me.txt_PA_Address1.MaxLength = 50
        Me.txt_PA_Address1.Name = "txt_PA_Address1"
        Me.txt_PA_Address1.Size = New System.Drawing.Size(192, 22)
        Me.txt_PA_Address1.TabIndex = 56
        Me.txt_PA_Address1.Text = ""
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(96, 920)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(78, 18)
        Me.Label63.TabIndex = 166
        Me.Label63.Text = "Address 1 :"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(96, 952)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(78, 18)
        Me.Label64.TabIndex = 167
        Me.Label64.Text = "Address 2 :"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(96, 984)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(78, 18)
        Me.Label65.TabIndex = 168
        Me.Label65.Text = "Address 3 :"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(96, 1016)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(38, 18)
        Me.Label66.TabIndex = 169
        Me.Label66.Text = "City :"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(392, 984)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(71, 18)
        Me.Label67.TabIndex = 172
        Me.Label67.Text = "Pin Code :"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(392, 920)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(46, 18)
        Me.Label68.TabIndex = 170
        Me.Label68.Text = "State :"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(392, 1016)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(76, 18)
        Me.Label69.TabIndex = 173
        Me.Label69.Text = "Phone No :"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(392, 952)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(64, 18)
        Me.Label72.TabIndex = 171
        Me.Label72.Text = "Country :"
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label55.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(91, 739)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(256, 19)
        Me.Label55.TabIndex = 154
        Me.Label55.Text = "B U S I N E S S    A D D R E S S .  . ."
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label77.Location = New System.Drawing.Point(88, 736)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(768, 24)
        Me.Label77.TabIndex = 445
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Chk_RA_PA_Copy)
        Me.GroupBox7.Controls.Add(Me.Chk_BA_PA_Copy)
        Me.GroupBox7.Location = New System.Drawing.Point(88, 904)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(768, 136)
        Me.GroupBox7.TabIndex = 165
        Me.GroupBox7.TabStop = False
        '
        'Chk_RA_PA_Copy
        '
        Me.Chk_RA_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_RA_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_RA_PA_Copy.Location = New System.Drawing.Point(560, 96)
        Me.Chk_RA_PA_Copy.Name = "Chk_RA_PA_Copy"
        Me.Chk_RA_PA_Copy.Size = New System.Drawing.Size(192, 24)
        Me.Chk_RA_PA_Copy.TabIndex = 595
        Me.Chk_RA_PA_Copy.Text = "Copy Residence Address"
        '
        'Chk_BA_PA_Copy
        '
        Me.Chk_BA_PA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_BA_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_BA_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_BA_PA_Copy.Location = New System.Drawing.Point(560, 56)
        Me.Chk_BA_PA_Copy.Name = "Chk_BA_PA_Copy"
        Me.Chk_BA_PA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.Chk_BA_PA_Copy.TabIndex = 780
        Me.Chk_BA_PA_Copy.Text = "Copy Business Address"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Location = New System.Drawing.Point(88, 752)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(768, 128)
        Me.GroupBox8.TabIndex = 50
        Me.GroupBox8.TabStop = False
        '
        'dtp_LastArrivalInCalcutta
        '
        Me.dtp_LastArrivalInCalcutta.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_LastArrivalInCalcutta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_LastArrivalInCalcutta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_LastArrivalInCalcutta.Location = New System.Drawing.Point(520, 42)
        Me.dtp_LastArrivalInCalcutta.Name = "dtp_LastArrivalInCalcutta"
        Me.dtp_LastArrivalInCalcutta.TabIndex = 68
        '
        'txt_ApplicationNo
        '
        Me.txt_ApplicationNo.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_ApplicationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ApplicationNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ApplicationNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ApplicationNo.Location = New System.Drawing.Point(240, 1360)
        Me.txt_ApplicationNo.MaxLength = 10
        Me.txt_ApplicationNo.Name = "txt_ApplicationNo"
        Me.txt_ApplicationNo.Size = New System.Drawing.Size(160, 22)
        Me.txt_ApplicationNo.TabIndex = 76
        Me.txt_ApplicationNo.Text = ""
        '
        'txt_ReasonApplication
        '
        Me.txt_ReasonApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ReasonApplication.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ReasonApplication.Location = New System.Drawing.Point(256, 1328)
        Me.txt_ReasonApplication.MaxLength = 99
        Me.txt_ReasonApplication.Name = "txt_ReasonApplication"
        Me.txt_ReasonApplication.Size = New System.Drawing.Size(456, 22)
        Me.txt_ReasonApplication.TabIndex = 75
        Me.txt_ReasonApplication.Text = "To Join Club"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(104, 1328)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(152, 18)
        Me.Label39.TabIndex = 189
        Me.Label39.Text = "Reason of application :"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(104, 1360)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(145, 18)
        Me.Label40.TabIndex = 190
        Me.Label40.Text = "Application Number* :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(412, 1361)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(119, 18)
        Me.Label41.TabIndex = 191
        Me.Label41.Text = "Application Date :"
        '
        'txt_NoOfTimesProposed
        '
        Me.txt_NoOfTimesProposed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NoOfTimesProposed.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NoOfTimesProposed.Location = New System.Drawing.Point(472, 1240)
        Me.txt_NoOfTimesProposed.MaxLength = 5
        Me.txt_NoOfTimesProposed.Name = "txt_NoOfTimesProposed"
        Me.txt_NoOfTimesProposed.Size = New System.Drawing.Size(224, 22)
        Me.txt_NoOfTimesProposed.TabIndex = 72
        Me.txt_NoOfTimesProposed.Text = ""
        '
        'chk_Elected
        '
        Me.chk_Elected.BackColor = System.Drawing.Color.Transparent
        Me.chk_Elected.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Elected.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Elected.Location = New System.Drawing.Point(104, 1265)
        Me.chk_Elected.Name = "chk_Elected"
        Me.chk_Elected.Size = New System.Drawing.Size(192, 24)
        Me.chk_Elected.TabIndex = 451
        Me.chk_Elected.Text = "Elected(YES)"
        '
        'chk_PreviouslyPr
        '
        Me.chk_PreviouslyPr.BackColor = System.Drawing.Color.Transparent
        Me.chk_PreviouslyPr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_PreviouslyPr.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PreviouslyPr.Location = New System.Drawing.Point(104, 1233)
        Me.chk_PreviouslyPr.Name = "chk_PreviouslyPr"
        Me.chk_PreviouslyPr.Size = New System.Drawing.Size(192, 24)
        Me.chk_PreviouslyPr.TabIndex = 450
        Me.chk_PreviouslyPr.Text = "Previously Proposed"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(312, 1240)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(151, 18)
        Me.Label47.TabIndex = 186
        Me.Label47.Text = "No of times Proposed :"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(312, 1272)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(125, 18)
        Me.Label48.TabIndex = 187
        Me.Label48.Text = "Date Of Proposal  :"
        '
        'txt_Month
        '
        Me.txt_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Month.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Month.Location = New System.Drawing.Point(608, 1143)
        Me.txt_Month.MaxLength = 8
        Me.txt_Month.Name = "txt_Month"
        Me.txt_Month.Size = New System.Drawing.Size(200, 22)
        Me.txt_Month.TabIndex = 71
        Me.txt_Month.Text = ""
        '
        'txt_PeriodOfStay
        '
        Me.txt_PeriodOfStay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PeriodOfStay.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PeriodOfStay.Location = New System.Drawing.Point(608, 1114)
        Me.txt_PeriodOfStay.MaxLength = 8
        Me.txt_PeriodOfStay.Name = "txt_PeriodOfStay"
        Me.txt_PeriodOfStay.Size = New System.Drawing.Size(200, 22)
        Me.txt_PeriodOfStay.TabIndex = 70
        Me.txt_PeriodOfStay.Text = ""
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(456, 1087)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(143, 18)
        Me.Label62.TabIndex = 181
        Me.Label62.Text = "Last Arrival Chennai :"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(456, 1114)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(160, 18)
        Me.Label70.TabIndex = 182
        Me.Label70.Text = "Period Of Stay In years :"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(456, 1143)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(53, 18)
        Me.Label71.TabIndex = 183
        Me.Label71.Text = "Month :"
        '
        'txt_DevelopmentFee
        '
        Me.txt_DevelopmentFee.BackColor = System.Drawing.Color.White
        Me.txt_DevelopmentFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_DevelopmentFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DevelopmentFee.Location = New System.Drawing.Point(224, 1144)
        Me.txt_DevelopmentFee.MaxLength = 8
        Me.txt_DevelopmentFee.Name = "txt_DevelopmentFee"
        Me.txt_DevelopmentFee.Size = New System.Drawing.Size(208, 22)
        Me.txt_DevelopmentFee.TabIndex = 66
        Me.txt_DevelopmentFee.Text = ""
        '
        'txt_EntranceFee
        '
        Me.txt_EntranceFee.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_EntranceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EntranceFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EntranceFee.Location = New System.Drawing.Point(224, 1176)
        Me.txt_EntranceFee.MaxLength = 8
        Me.txt_EntranceFee.Name = "txt_EntranceFee"
        Me.txt_EntranceFee.Size = New System.Drawing.Size(208, 22)
        Me.txt_EntranceFee.TabIndex = 67
        Me.txt_EntranceFee.Text = ""
        '
        'txt_SecurityDeposit
        '
        Me.txt_SecurityDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SecurityDeposit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SecurityDeposit.Location = New System.Drawing.Point(224, 1116)
        Me.txt_SecurityDeposit.MaxLength = 8
        Me.txt_SecurityDeposit.Name = "txt_SecurityDeposit"
        Me.txt_SecurityDeposit.Size = New System.Drawing.Size(208, 22)
        Me.txt_SecurityDeposit.TabIndex = 65
        Me.txt_SecurityDeposit.Text = ""
        '
        'txt_CreditNumber
        '
        Me.txt_CreditNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CreditNumber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CreditNumber.Location = New System.Drawing.Point(224, 1086)
        Me.txt_CreditNumber.MaxLength = 10
        Me.txt_CreditNumber.Name = "txt_CreditNumber"
        Me.txt_CreditNumber.Size = New System.Drawing.Size(208, 22)
        Me.txt_CreditNumber.TabIndex = 64
        Me.txt_CreditNumber.Text = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(104, 1086)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(106, 18)
        Me.Label49.TabIndex = 176
        Me.Label49.Text = "Credit Number :"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(104, 1116)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(119, 18)
        Me.Label50.TabIndex = 177
        Me.Label50.Text = "Security Deposit :"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(104, 1176)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(102, 18)
        Me.Label51.TabIndex = 178
        Me.Label51.Text = "Entrance Fee* :"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(104, 1146)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(124, 18)
        Me.Label52.TabIndex = 179
        Me.Label52.Text = "Development Fee :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dtp_DateApplication)
        Me.GroupBox4.Controls.Add(Me.cmb_Appdt_c)
        Me.GroupBox4.Controls.Add(Me.btn_Appdt_c)
        Me.GroupBox4.Location = New System.Drawing.Point(88, 1304)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 96)
        Me.GroupBox4.TabIndex = 188
        Me.GroupBox4.TabStop = False
        '
        'dtp_DateApplication
        '
        Me.dtp_DateApplication.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_DateApplication.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateApplication.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DateApplication.Location = New System.Drawing.Point(456, 56)
        Me.dtp_DateApplication.Name = "dtp_DateApplication"
        Me.dtp_DateApplication.Size = New System.Drawing.Size(144, 22)
        Me.dtp_DateApplication.TabIndex = 80
        '
        'cmb_Appdt_c
        '
        Me.cmb_Appdt_c.Enabled = False
        Me.cmb_Appdt_c.Location = New System.Drawing.Point(456, 56)
        Me.cmb_Appdt_c.Name = "cmb_Appdt_c"
        Me.cmb_Appdt_c.Size = New System.Drawing.Size(144, 21)
        Me.cmb_Appdt_c.TabIndex = 8
        Me.cmb_Appdt_c.Visible = False
        '
        'btn_Appdt_c
        '
        Me.btn_Appdt_c.Location = New System.Drawing.Point(610, 56)
        Me.btn_Appdt_c.Name = "btn_Appdt_c"
        Me.btn_Appdt_c.Size = New System.Drawing.Size(16, 20)
        Me.btn_Appdt_c.TabIndex = 78
        Me.btn_Appdt_c.Text = "C"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.dtp_DateProposal)
        Me.GroupBox5.Controls.Add(Me.cmb_DateOf_c)
        Me.GroupBox5.Controls.Add(Me.Btn_DateOf_c)
        Me.GroupBox5.Location = New System.Drawing.Point(88, 1224)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(768, 80)
        Me.GroupBox5.TabIndex = 184
        Me.GroupBox5.TabStop = False
        '
        'dtp_DateProposal
        '
        Me.dtp_DateProposal.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_DateProposal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateProposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DateProposal.Location = New System.Drawing.Point(384, 48)
        Me.dtp_DateProposal.Name = "dtp_DateProposal"
        Me.dtp_DateProposal.Size = New System.Drawing.Size(224, 22)
        Me.dtp_DateProposal.TabIndex = 75
        '
        'cmb_DateOf_c
        '
        Me.cmb_DateOf_c.Enabled = False
        Me.cmb_DateOf_c.Location = New System.Drawing.Point(384, 48)
        Me.cmb_DateOf_c.Name = "cmb_DateOf_c"
        Me.cmb_DateOf_c.Size = New System.Drawing.Size(224, 21)
        Me.cmb_DateOf_c.TabIndex = 7
        Me.cmb_DateOf_c.Visible = False
        '
        'Btn_DateOf_c
        '
        Me.Btn_DateOf_c.Location = New System.Drawing.Point(610, 48)
        Me.Btn_DateOf_c.Name = "Btn_DateOf_c"
        Me.Btn_DateOf_c.Size = New System.Drawing.Size(16, 20)
        Me.Btn_DateOf_c.TabIndex = 74
        Me.Btn_DateOf_c.Text = "C"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Txt_CreditLimit)
        Me.GroupBox6.Controls.Add(Me.Lbl_CreditLimit)
        Me.GroupBox6.Controls.Add(Me.Txt_PANNo)
        Me.GroupBox6.Controls.Add(Me.Lbl_PANNo)
        Me.GroupBox6.Controls.Add(Me.Btn_LastArr_c)
        Me.GroupBox6.Controls.Add(Me.dtp_LastArrivalInCalcutta)
        Me.GroupBox6.Controls.Add(Me.cmb_LastArr_c)
        Me.GroupBox6.Controls.Add(Me.Lbl_BloodGroup)
        Me.GroupBox6.Controls.Add(Me.Txt_BloodGroup)
        Me.GroupBox6.Controls.Add(Me.chk_EntranceFee)
        Me.GroupBox6.Location = New System.Drawing.Point(88, 1040)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(768, 184)
        Me.GroupBox6.TabIndex = 174
        Me.GroupBox6.TabStop = False
        '
        'Txt_CreditLimit
        '
        Me.Txt_CreditLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CreditLimit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CreditLimit.Location = New System.Drawing.Point(520, 136)
        Me.Txt_CreditLimit.MaxLength = 8
        Me.Txt_CreditLimit.Name = "Txt_CreditLimit"
        Me.Txt_CreditLimit.Size = New System.Drawing.Size(200, 22)
        Me.Txt_CreditLimit.TabIndex = 805
        Me.Txt_CreditLimit.Text = ""
        '
        'Lbl_CreditLimit
        '
        Me.Lbl_CreditLimit.AutoSize = True
        Me.Lbl_CreditLimit.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CreditLimit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CreditLimit.Location = New System.Drawing.Point(372, 136)
        Me.Lbl_CreditLimit.Name = "Lbl_CreditLimit"
        Me.Lbl_CreditLimit.Size = New System.Drawing.Size(87, 18)
        Me.Lbl_CreditLimit.TabIndex = 806
        Me.Lbl_CreditLimit.Text = "Credit Limit :"
        '
        'Txt_PANNo
        '
        Me.Txt_PANNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PANNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PANNo.Location = New System.Drawing.Point(520, 16)
        Me.Txt_PANNo.MaxLength = 10
        Me.Txt_PANNo.Name = "Txt_PANNo"
        Me.Txt_PANNo.Size = New System.Drawing.Size(200, 22)
        Me.Txt_PANNo.TabIndex = 804
        Me.Txt_PANNo.Text = ""
        '
        'Lbl_PANNo
        '
        Me.Lbl_PANNo.AutoSize = True
        Me.Lbl_PANNo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PANNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PANNo.Location = New System.Drawing.Point(368, 16)
        Me.Lbl_PANNo.Name = "Lbl_PANNo"
        Me.Lbl_PANNo.Size = New System.Drawing.Size(67, 18)
        Me.Lbl_PANNo.TabIndex = 803
        Me.Lbl_PANNo.Text = "PAN No. :"
        Me.Lbl_PANNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_LastArr_c
        '
        Me.Btn_LastArr_c.Location = New System.Drawing.Point(722, 50)
        Me.Btn_LastArr_c.Name = "Btn_LastArr_c"
        Me.Btn_LastArr_c.Size = New System.Drawing.Size(16, 20)
        Me.Btn_LastArr_c.TabIndex = 69
        Me.Btn_LastArr_c.Text = "C"
        '
        'cmb_LastArr_c
        '
        Me.cmb_LastArr_c.Enabled = False
        Me.cmb_LastArr_c.Location = New System.Drawing.Point(520, 45)
        Me.cmb_LastArr_c.Name = "cmb_LastArr_c"
        Me.cmb_LastArr_c.Size = New System.Drawing.Size(200, 21)
        Me.cmb_LastArr_c.TabIndex = 6
        Me.cmb_LastArr_c.Visible = False
        '
        'Lbl_BloodGroup
        '
        Me.Lbl_BloodGroup.AutoSize = True
        Me.Lbl_BloodGroup.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_BloodGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BloodGroup.Location = New System.Drawing.Point(16, 16)
        Me.Lbl_BloodGroup.Name = "Lbl_BloodGroup"
        Me.Lbl_BloodGroup.Size = New System.Drawing.Size(95, 18)
        Me.Lbl_BloodGroup.TabIndex = 802
        Me.Lbl_BloodGroup.Text = "Blood Group :"
        '
        'Txt_BloodGroup
        '
        Me.Txt_BloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_BloodGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BloodGroup.Location = New System.Drawing.Point(136, 16)
        Me.Txt_BloodGroup.MaxLength = 10
        Me.Txt_BloodGroup.Name = "Txt_BloodGroup"
        Me.Txt_BloodGroup.Size = New System.Drawing.Size(208, 22)
        Me.Txt_BloodGroup.TabIndex = 802
        Me.Txt_BloodGroup.Text = ""
        '
        'chk_EntranceFee
        '
        Me.chk_EntranceFee.BackColor = System.Drawing.Color.Transparent
        Me.chk_EntranceFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_EntranceFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EntranceFee.Location = New System.Drawing.Point(16, 160)
        Me.chk_EntranceFee.Name = "chk_EntranceFee"
        Me.chk_EntranceFee.Size = New System.Drawing.Size(200, 16)
        Me.chk_EntranceFee.TabIndex = 800
        Me.chk_EntranceFee.Text = "Entrance Fee Details"
        '
        'chk_Memberofclub
        '
        Me.chk_Memberofclub.BackColor = System.Drawing.Color.Transparent
        Me.chk_Memberofclub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Memberofclub.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Memberofclub.Location = New System.Drawing.Point(96, 1896)
        Me.chk_Memberofclub.Name = "chk_Memberofclub"
        Me.chk_Memberofclub.Size = New System.Drawing.Size(176, 24)
        Me.chk_Memberofclub.TabIndex = 101
        Me.chk_Memberofclub.Text = "Member Of Other Club"
        '
        'lbl_Specialinfo
        '
        Me.lbl_Specialinfo.AutoSize = True
        Me.lbl_Specialinfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Specialinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Specialinfo.Location = New System.Drawing.Point(528, 1800)
        Me.lbl_Specialinfo.Name = "lbl_Specialinfo"
        Me.lbl_Specialinfo.Size = New System.Drawing.Size(165, 18)
        Me.lbl_Specialinfo.TabIndex = 212
        Me.lbl_Specialinfo.Text = "SPECIAL INFORMATION:"
        '
        'cmd_SeconderCodeHelp
        '
        Me.cmd_SeconderCodeHelp.Image = CType(resources.GetObject("cmd_SeconderCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_SeconderCodeHelp.Location = New System.Drawing.Point(440, 1712)
        Me.cmd_SeconderCodeHelp.Name = "cmd_SeconderCodeHelp"
        Me.cmd_SeconderCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_SeconderCodeHelp.TabIndex = 94
        '
        'cmd_ProposerCodeHelp
        '
        Me.cmd_ProposerCodeHelp.Image = CType(resources.GetObject("cmd_ProposerCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_ProposerCodeHelp.Location = New System.Drawing.Point(440, 1672)
        Me.cmd_ProposerCodeHelp.Name = "cmd_ProposerCodeHelp"
        Me.cmd_ProposerCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_ProposerCodeHelp.TabIndex = 92
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(104, 1744)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(176, 18)
        Me.Label17.TabIndex = 209
        Me.Label17.Text = "Position Held In Chamber :"
        '
        'txt_Specialinfo
        '
        Me.txt_Specialinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Specialinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Specialinfo.Location = New System.Drawing.Point(520, 1832)
        Me.txt_Specialinfo.MaxLength = 999
        Me.txt_Specialinfo.Multiline = True
        Me.txt_Specialinfo.Name = "txt_Specialinfo"
        Me.txt_Specialinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Specialinfo.Size = New System.Drawing.Size(344, 96)
        Me.txt_Specialinfo.TabIndex = 105
        Me.txt_Specialinfo.Text = ""
        '
        'chk_AppliedMembership
        '
        Me.chk_AppliedMembership.BackColor = System.Drawing.Color.Transparent
        Me.chk_AppliedMembership.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_AppliedMembership.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AppliedMembership.Location = New System.Drawing.Point(96, 1792)
        Me.chk_AppliedMembership.Name = "chk_AppliedMembership"
        Me.chk_AppliedMembership.Size = New System.Drawing.Size(416, 24)
        Me.chk_AppliedMembership.TabIndex = 98
        Me.chk_AppliedMembership.Text = "Applied But Membership Not Granted In Any Other Clubs"
        '
        'chk_Childrendetail
        '
        Me.chk_Childrendetail.BackColor = System.Drawing.Color.Transparent
        Me.chk_Childrendetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Childrendetail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Childrendetail.Location = New System.Drawing.Point(96, 1832)
        Me.chk_Childrendetail.Name = "chk_Childrendetail"
        Me.chk_Childrendetail.Size = New System.Drawing.Size(176, 24)
        Me.chk_Childrendetail.TabIndex = 99
        Me.chk_Childrendetail.Text = "Children Details [y/n]"
        '
        'chk_Relativesdetails
        '
        Me.chk_Relativesdetails.BackColor = System.Drawing.Color.Transparent
        Me.chk_Relativesdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Relativesdetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Relativesdetails.Location = New System.Drawing.Point(96, 1864)
        Me.chk_Relativesdetails.Name = "chk_Relativesdetails"
        Me.chk_Relativesdetails.Size = New System.Drawing.Size(176, 24)
        Me.chk_Relativesdetails.TabIndex = 100
        Me.chk_Relativesdetails.Text = "Relatives Details [y/n]"
        '
        'chk_MemberQulification
        '
        Me.chk_MemberQulification.BackColor = System.Drawing.Color.Transparent
        Me.chk_MemberQulification.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_MemberQulification.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_MemberQulification.Location = New System.Drawing.Point(280, 1832)
        Me.chk_MemberQulification.Name = "chk_MemberQulification"
        Me.chk_MemberQulification.Size = New System.Drawing.Size(224, 24)
        Me.chk_MemberQulification.TabIndex = 102
        Me.chk_MemberQulification.Text = "Member Qualifiacation[y/n]"
        '
        'chk_Sports
        '
        Me.chk_Sports.BackColor = System.Drawing.Color.Transparent
        Me.chk_Sports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Sports.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Sports.Location = New System.Drawing.Point(280, 1864)
        Me.chk_Sports.Name = "chk_Sports"
        Me.chk_Sports.Size = New System.Drawing.Size(224, 24)
        Me.chk_Sports.TabIndex = 103
        Me.chk_Sports.Text = "Sports Of Intrest"
        '
        'txt_PositionHeld
        '
        Me.txt_PositionHeld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PositionHeld.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PositionHeld.Location = New System.Drawing.Point(280, 1744)
        Me.txt_PositionHeld.MaxLength = 50
        Me.txt_PositionHeld.Name = "txt_PositionHeld"
        Me.txt_PositionHeld.Size = New System.Drawing.Size(512, 22)
        Me.txt_PositionHeld.TabIndex = 97
        Me.txt_PositionHeld.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(104, 1792)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 16)
        Me.Label19.TabIndex = 548
        Me.Label19.Text = "Position held in Chamber"
        '
        'txt_SeconderName
        '
        Me.txt_SeconderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SeconderName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeconderName.ForeColor = System.Drawing.Color.Black
        Me.txt_SeconderName.Location = New System.Drawing.Point(616, 1712)
        Me.txt_SeconderName.MaxLength = 35
        Me.txt_SeconderName.Name = "txt_SeconderName"
        Me.txt_SeconderName.ReadOnly = True
        Me.txt_SeconderName.Size = New System.Drawing.Size(176, 22)
        Me.txt_SeconderName.TabIndex = 96
        Me.txt_SeconderName.Text = ""
        '
        'txt_ProposedName
        '
        Me.txt_ProposedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ProposedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProposedName.ForeColor = System.Drawing.Color.Black
        Me.txt_ProposedName.Location = New System.Drawing.Point(616, 1672)
        Me.txt_ProposedName.MaxLength = 35
        Me.txt_ProposedName.Name = "txt_ProposedName"
        Me.txt_ProposedName.ReadOnly = True
        Me.txt_ProposedName.Size = New System.Drawing.Size(176, 22)
        Me.txt_ProposedName.TabIndex = 95
        Me.txt_ProposedName.Text = ""
        '
        'txt_SeconderCode
        '
        Me.txt_SeconderCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_SeconderCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SeconderCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeconderCode.Location = New System.Drawing.Point(272, 1712)
        Me.txt_SeconderCode.MaxLength = 50
        Me.txt_SeconderCode.Name = "txt_SeconderCode"
        Me.txt_SeconderCode.Size = New System.Drawing.Size(168, 22)
        Me.txt_SeconderCode.TabIndex = 93
        Me.txt_SeconderCode.Text = ""
        '
        'txt_ProposerCode
        '
        Me.txt_ProposerCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_ProposerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ProposerCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProposerCode.Location = New System.Drawing.Point(272, 1672)
        Me.txt_ProposerCode.MaxLength = 50
        Me.txt_ProposerCode.Name = "txt_ProposerCode"
        Me.txt_ProposerCode.Size = New System.Drawing.Size(168, 22)
        Me.txt_ProposerCode.TabIndex = 91
        Me.txt_ProposerCode.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(104, 1672)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 18)
        Me.Label20.TabIndex = 207
        Me.Label20.Text = "Proposer Code* :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(497, 1672)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 18)
        Me.Label21.TabIndex = 210
        Me.Label21.Text = "Proposer Name :"
        '
        'sc
        '
        Me.sc.AutoSize = True
        Me.sc.BackColor = System.Drawing.Color.Transparent
        Me.sc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc.Location = New System.Drawing.Point(104, 1712)
        Me.sc.Name = "sc"
        Me.sc.Size = New System.Drawing.Size(116, 18)
        Me.sc.TabIndex = 208
        Me.sc.Text = "Seconder Code* :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(496, 1712)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 18)
        Me.Label22.TabIndex = 211
        Me.Label22.Text = "Seconder Name :"
        '
        'txt_Clients
        '
        Me.txt_Clients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Clients.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Clients.Location = New System.Drawing.Point(256, 1608)
        Me.txt_Clients.MaxLength = 35
        Me.txt_Clients.Name = "txt_Clients"
        Me.txt_Clients.Size = New System.Drawing.Size(176, 22)
        Me.txt_Clients.TabIndex = 84
        Me.txt_Clients.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(104, 1608)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 18)
        Me.Label24.TabIndex = 200
        Me.Label24.Text = "Clients :"
        '
        'txt_TurnOver
        '
        Me.txt_TurnOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TurnOver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TurnOver.Location = New System.Drawing.Point(616, 1576)
        Me.txt_TurnOver.MaxLength = 8
        Me.txt_TurnOver.Name = "txt_TurnOver"
        Me.txt_TurnOver.Size = New System.Drawing.Size(176, 22)
        Me.txt_TurnOver.TabIndex = 90
        Me.txt_TurnOver.Text = ""
        '
        'txt_Bankers
        '
        Me.txt_Bankers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Bankers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Bankers.Location = New System.Drawing.Point(256, 1576)
        Me.txt_Bankers.MaxLength = 50
        Me.txt_Bankers.Name = "txt_Bankers"
        Me.txt_Bankers.Size = New System.Drawing.Size(176, 22)
        Me.txt_Bankers.TabIndex = 83
        Me.txt_Bankers.Text = ""
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(104, 1576)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(58, 18)
        Me.Label75.TabIndex = 199
        Me.Label75.Text = "Banker :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(480, 1576)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 205
        Me.Label25.Text = "Turn Over :"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(101, 1419)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(171, 16)
        Me.Label26.TabIndex = 192
        Me.Label26.Text = "COMPANY DETAILS"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(88, 1416)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(768, 24)
        Me.Label28.TabIndex = 193
        '
        'txt_NoOfEmployee
        '
        Me.txt_NoOfEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NoOfEmployee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NoOfEmployee.Location = New System.Drawing.Point(616, 1544)
        Me.txt_NoOfEmployee.MaxLength = 5
        Me.txt_NoOfEmployee.Name = "txt_NoOfEmployee"
        Me.txt_NoOfEmployee.Size = New System.Drawing.Size(176, 22)
        Me.txt_NoOfEmployee.TabIndex = 89
        Me.txt_NoOfEmployee.Text = ""
        '
        'txt_Agents
        '
        Me.txt_Agents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Agents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Agents.Location = New System.Drawing.Point(616, 1480)
        Me.txt_Agents.MaxLength = 35
        Me.txt_Agents.Name = "txt_Agents"
        Me.txt_Agents.Size = New System.Drawing.Size(176, 22)
        Me.txt_Agents.TabIndex = 86
        Me.txt_Agents.Text = ""
        '
        'txt_Products
        '
        Me.txt_Products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Products.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Products.Location = New System.Drawing.Point(616, 1448)
        Me.txt_Products.MaxLength = 35
        Me.txt_Products.Name = "txt_Products"
        Me.txt_Products.Size = New System.Drawing.Size(176, 22)
        Me.txt_Products.TabIndex = 85
        Me.txt_Products.Text = ""
        '
        'txt_Bussinessinfo
        '
        Me.txt_Bussinessinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Bussinessinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Bussinessinfo.Location = New System.Drawing.Point(256, 1544)
        Me.txt_Bussinessinfo.MaxLength = 35
        Me.txt_Bussinessinfo.Name = "txt_Bussinessinfo"
        Me.txt_Bussinessinfo.Size = New System.Drawing.Size(176, 22)
        Me.txt_Bussinessinfo.TabIndex = 82
        Me.txt_Bussinessinfo.Text = ""
        '
        'txt_Professonalinfo
        '
        Me.txt_Professonalinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Professonalinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Professonalinfo.Location = New System.Drawing.Point(256, 1512)
        Me.txt_Professonalinfo.MaxLength = 35
        Me.txt_Professonalinfo.Name = "txt_Professonalinfo"
        Me.txt_Professonalinfo.Size = New System.Drawing.Size(176, 22)
        Me.txt_Professonalinfo.TabIndex = 81
        Me.txt_Professonalinfo.Text = ""
        '
        'txt_Designation
        '
        Me.txt_Designation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Designation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Designation.Location = New System.Drawing.Point(256, 1480)
        Me.txt_Designation.MaxLength = 15
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.Size = New System.Drawing.Size(176, 22)
        Me.txt_Designation.TabIndex = 80
        Me.txt_Designation.Text = ""
        '
        'txt_CompanyName
        '
        Me.txt_CompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CompanyName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CompanyName.Location = New System.Drawing.Point(256, 1448)
        Me.txt_CompanyName.MaxLength = 35
        Me.txt_CompanyName.Name = "txt_CompanyName"
        Me.txt_CompanyName.Size = New System.Drawing.Size(176, 22)
        Me.txt_CompanyName.TabIndex = 79
        Me.txt_CompanyName.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(104, 1448)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 18)
        Me.Label30.TabIndex = 195
        Me.Label30.Text = "Company Name :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(104, 1480)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(90, 18)
        Me.Label31.TabIndex = 196
        Me.Label31.Text = "Designation :"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(104, 1512)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(125, 18)
        Me.Label32.TabIndex = 197
        Me.Label32.Text = "Professional Info. :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(104, 1544)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(150, 18)
        Me.Label33.TabIndex = 198
        Me.Label33.Text = "Business Information :"
        '
        'lbl_ESTDdate
        '
        Me.lbl_ESTDdate.AutoSize = True
        Me.lbl_ESTDdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ESTDdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ESTDdate.Location = New System.Drawing.Point(480, 1512)
        Me.lbl_ESTDdate.Name = "lbl_ESTDdate"
        Me.lbl_ESTDdate.Size = New System.Drawing.Size(85, 18)
        Me.lbl_ESTDdate.TabIndex = 203
        Me.lbl_ESTDdate.Text = "ESTD. Date :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(480, 1448)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(71, 18)
        Me.Label35.TabIndex = 201
        Me.Label35.Text = "Products :"
        '
        'lbl_NoOfEmployee
        '
        Me.lbl_NoOfEmployee.AutoSize = True
        Me.lbl_NoOfEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NoOfEmployee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NoOfEmployee.Location = New System.Drawing.Point(480, 1544)
        Me.lbl_NoOfEmployee.Name = "lbl_NoOfEmployee"
        Me.lbl_NoOfEmployee.Size = New System.Drawing.Size(124, 18)
        Me.lbl_NoOfEmployee.TabIndex = 204
        Me.lbl_NoOfEmployee.Text = "No Of Employees :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(480, 1480)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(114, 18)
        Me.Label37.TabIndex = 202
        Me.Label37.Text = "Agents/Dealers  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Chk_Sec)
        Me.GroupBox1.Controls.Add(Me.Chk_Prop)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 1648)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 136)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        '
        'Chk_Sec
        '
        Me.Chk_Sec.Location = New System.Drawing.Point(708, 62)
        Me.Chk_Sec.Name = "Chk_Sec"
        Me.Chk_Sec.Size = New System.Drawing.Size(56, 24)
        Me.Chk_Sec.TabIndex = 1
        Me.Chk_Sec.Text = "More"
        Me.Chk_Sec.Visible = False
        '
        'Chk_Prop
        '
        Me.Chk_Prop.Location = New System.Drawing.Point(707, 22)
        Me.Chk_Prop.Name = "Chk_Prop"
        Me.Chk_Prop.Size = New System.Drawing.Size(56, 24)
        Me.Chk_Prop.TabIndex = 0
        Me.Chk_Prop.Text = "More"
        Me.Chk_Prop.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(88, 1784)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 144)
        Me.GroupBox2.TabIndex = 213
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_ESTDdate)
        Me.GroupBox3.Controls.Add(Me.combo_HideDateESTD)
        Me.GroupBox3.Controls.Add(Me.btn_ClearEstdDT)
        Me.GroupBox3.Location = New System.Drawing.Point(88, 1432)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 208)
        Me.GroupBox3.TabIndex = 194
        Me.GroupBox3.TabStop = False
        '
        'dtp_ESTDdate
        '
        Me.dtp_ESTDdate.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_ESTDdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_ESTDdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_ESTDdate.Location = New System.Drawing.Point(528, 80)
        Me.dtp_ESTDdate.Name = "dtp_ESTDdate"
        Me.dtp_ESTDdate.Size = New System.Drawing.Size(176, 22)
        Me.dtp_ESTDdate.TabIndex = 89
        '
        'combo_HideDateESTD
        '
        Me.combo_HideDateESTD.Enabled = False
        Me.combo_HideDateESTD.Location = New System.Drawing.Point(528, 80)
        Me.combo_HideDateESTD.Name = "combo_HideDateESTD"
        Me.combo_HideDateESTD.Size = New System.Drawing.Size(176, 21)
        Me.combo_HideDateESTD.TabIndex = 1
        Me.combo_HideDateESTD.Visible = False
        '
        'btn_ClearEstdDT
        '
        Me.btn_ClearEstdDT.Location = New System.Drawing.Point(706, 80)
        Me.btn_ClearEstdDT.Name = "btn_ClearEstdDT"
        Me.btn_ClearEstdDT.Size = New System.Drawing.Size(16, 20)
        Me.btn_ClearEstdDT.TabIndex = 88
        Me.btn_ClearEstdDT.Text = "C"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.chk_pa_ca_copy)
        Me.GroupBox10.Controls.Add(Me.chk_ba_ca_copy)
        Me.GroupBox10.Controls.Add(Me.Chk_RA_CA_copy)
        Me.GroupBox10.Location = New System.Drawing.Point(88, 432)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(768, 144)
        Me.GroupBox10.TabIndex = 132
        Me.GroupBox10.TabStop = False
        '
        'chk_pa_ca_copy
        '
        Me.chk_pa_ca_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_pa_ca_copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pa_ca_copy.Location = New System.Drawing.Point(552, 122)
        Me.chk_pa_ca_copy.Name = "chk_pa_ca_copy"
        Me.chk_pa_ca_copy.Size = New System.Drawing.Size(192, 24)
        Me.chk_pa_ca_copy.TabIndex = 668
        Me.chk_pa_ca_copy.Text = "Copy Permanent Address"
        '
        'chk_ba_ca_copy
        '
        Me.chk_ba_ca_copy.BackColor = System.Drawing.Color.Transparent
        Me.chk_ba_ca_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_ba_ca_copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ba_ca_copy.Location = New System.Drawing.Point(552, 104)
        Me.chk_ba_ca_copy.Name = "chk_ba_ca_copy"
        Me.chk_ba_ca_copy.Size = New System.Drawing.Size(200, 24)
        Me.chk_ba_ca_copy.TabIndex = 667
        Me.chk_ba_ca_copy.Text = "Copy Business Address"
        '
        'Chk_RA_CA_copy
        '
        Me.Chk_RA_CA_copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_RA_CA_copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_RA_CA_copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_RA_CA_copy.Location = New System.Drawing.Point(552, 80)
        Me.Chk_RA_CA_copy.Name = "Chk_RA_CA_copy"
        Me.Chk_RA_CA_copy.Size = New System.Drawing.Size(200, 24)
        Me.Chk_RA_CA_copy.TabIndex = 666
        Me.Chk_RA_CA_copy.Text = "Copy Residence Address"
        '
        'GroupBox11
        '
        Me.GroupBox11.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox11.Controls.Add(Me.btn_details)
        Me.GroupBox11.Controls.Add(Me.txt_fmcode)
        Me.GroupBox11.Controls.Add(Me.Label109)
        Me.GroupBox11.Controls.Add(Me.txt_GDRLocker)
        Me.GroupBox11.Controls.Add(Me.lbl_GDRlocker)
        Me.GroupBox11.Location = New System.Drawing.Point(88, 288)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(640, 128)
        Me.GroupBox11.TabIndex = 25
        Me.GroupBox11.TabStop = False
        '
        'btn_details
        '
        Me.btn_details.Location = New System.Drawing.Point(592, 80)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(16, 20)
        Me.btn_details.TabIndex = 21
        Me.btn_details.Text = "C"
        '
        'txt_fmcode
        '
        Me.txt_fmcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fmcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fmcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_fmcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fmcode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_fmcode.Location = New System.Drawing.Point(120, 16)
        Me.txt_fmcode.MaxLength = 100
        Me.txt_fmcode.Name = "txt_fmcode"
        Me.txt_fmcode.Size = New System.Drawing.Size(160, 22)
        Me.txt_fmcode.TabIndex = 804
        Me.txt_fmcode.Text = ""
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.BackColor = System.Drawing.Color.Transparent
        Me.Label109.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(8, 16)
        Me.Label109.Name = "Label109"
        Me.Label109.TabIndex = 805
        Me.Label109.Text = "Father Mcode :"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox12.Controls.Add(Me.dtp_MembershipTo)
        Me.GroupBox12.Controls.Add(Me.txt_spouse_dob)
        Me.GroupBox12.Controls.Add(Me.cmb_spouse_dob)
        Me.GroupBox12.Controls.Add(Me.Btn_spousedob_c)
        Me.GroupBox12.Controls.Add(Me.Btn_Membershipfrom_c)
        Me.GroupBox12.Controls.Add(Me.Btn_BIRTH1)
        Me.GroupBox12.Controls.Add(Me.CMB_BRITH)
        Me.GroupBox12.Controls.Add(Me.TXT_SPOUSE_MOBILE)
        Me.GroupBox12.Controls.Add(Me.LBL_SPOUSE_MOBILE)
        Me.GroupBox12.Controls.Add(Me.Btn_MembershipTo_c)
        Me.GroupBox12.Controls.Add(Me.Label76)
        Me.GroupBox12.Controls.Add(Me.Label74)
        Me.GroupBox12.Controls.Add(Me.dtp_MembershipFrom)
        Me.GroupBox12.Controls.Add(Me.Label96)
        Me.GroupBox12.Controls.Add(Me.txt_Spouse)
        Me.GroupBox12.Controls.Add(Me.lbl_Spouse)
        Me.GroupBox12.Controls.Add(Me.cmb_Membershipfrom_c)
        Me.GroupBox12.Controls.Add(Me.cmb_MembershipTo_c)
        Me.GroupBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox12.Location = New System.Drawing.Point(88, 160)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(768, 136)
        Me.GroupBox12.TabIndex = 117
        Me.GroupBox12.TabStop = False
        '
        'dtp_MembershipTo
        '
        Me.dtp_MembershipTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_MembershipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipTo.Location = New System.Drawing.Point(440, 113)
        Me.dtp_MembershipTo.Name = "dtp_MembershipTo"
        Me.dtp_MembershipTo.Size = New System.Drawing.Size(168, 20)
        Me.dtp_MembershipTo.TabIndex = 596
        Me.dtp_MembershipTo.Value = New Date(2009, 3, 20, 8, 34, 57, 836)
        '
        'txt_spouse_dob
        '
        Me.txt_spouse_dob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_spouse_dob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_spouse_dob.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_spouse_dob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_spouse_dob.Location = New System.Drawing.Point(440, 88)
        Me.txt_spouse_dob.MaxLength = 15
        Me.txt_spouse_dob.Name = "txt_spouse_dob"
        Me.txt_spouse_dob.Size = New System.Drawing.Size(112, 22)
        Me.txt_spouse_dob.TabIndex = 16
        Me.txt_spouse_dob.Text = ""
        '
        'cmb_spouse_dob
        '
        Me.cmb_spouse_dob.Enabled = False
        Me.cmb_spouse_dob.Location = New System.Drawing.Point(440, 88)
        Me.cmb_spouse_dob.Name = "cmb_spouse_dob"
        Me.cmb_spouse_dob.Size = New System.Drawing.Size(112, 21)
        Me.cmb_spouse_dob.TabIndex = 608
        Me.cmb_spouse_dob.Visible = False
        '
        'Btn_spousedob_c
        '
        Me.Btn_spousedob_c.Location = New System.Drawing.Point(552, 88)
        Me.Btn_spousedob_c.Name = "Btn_spousedob_c"
        Me.Btn_spousedob_c.Size = New System.Drawing.Size(16, 20)
        Me.Btn_spousedob_c.TabIndex = 17
        Me.Btn_spousedob_c.Text = "C"
        '
        'Btn_Membershipfrom_c
        '
        Me.Btn_Membershipfrom_c.Location = New System.Drawing.Point(304, 112)
        Me.Btn_Membershipfrom_c.Name = "Btn_Membershipfrom_c"
        Me.Btn_Membershipfrom_c.Size = New System.Drawing.Size(16, 20)
        Me.Btn_Membershipfrom_c.TabIndex = 12
        Me.Btn_Membershipfrom_c.Text = "C"
        '
        'Btn_BIRTH1
        '
        Me.Btn_BIRTH1.Location = New System.Drawing.Point(296, 32)
        Me.Btn_BIRTH1.Name = "Btn_BIRTH1"
        Me.Btn_BIRTH1.Size = New System.Drawing.Size(16, 20)
        Me.Btn_BIRTH1.TabIndex = 8
        Me.Btn_BIRTH1.Text = "C"
        '
        'CMB_BRITH
        '
        Me.CMB_BRITH.Enabled = False
        Me.CMB_BRITH.Location = New System.Drawing.Point(144, 33)
        Me.CMB_BRITH.Name = "CMB_BRITH"
        Me.CMB_BRITH.Size = New System.Drawing.Size(152, 21)
        Me.CMB_BRITH.TabIndex = 603
        Me.CMB_BRITH.Visible = False
        '
        'TXT_SPOUSE_MOBILE
        '
        Me.TXT_SPOUSE_MOBILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SPOUSE_MOBILE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_SPOUSE_MOBILE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SPOUSE_MOBILE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_SPOUSE_MOBILE.Location = New System.Drawing.Point(632, 87)
        Me.TXT_SPOUSE_MOBILE.MaxLength = 15
        Me.TXT_SPOUSE_MOBILE.Name = "TXT_SPOUSE_MOBILE"
        Me.TXT_SPOUSE_MOBILE.Size = New System.Drawing.Size(120, 22)
        Me.TXT_SPOUSE_MOBILE.TabIndex = 18
        Me.TXT_SPOUSE_MOBILE.Text = ""
        '
        'LBL_SPOUSE_MOBILE
        '
        Me.LBL_SPOUSE_MOBILE.AutoSize = True
        Me.LBL_SPOUSE_MOBILE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SPOUSE_MOBILE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SPOUSE_MOBILE.Location = New System.Drawing.Point(584, 88)
        Me.LBL_SPOUSE_MOBILE.Name = "LBL_SPOUSE_MOBILE"
        Me.LBL_SPOUSE_MOBILE.Size = New System.Drawing.Size(47, 18)
        Me.LBL_SPOUSE_MOBILE.TabIndex = 601
        Me.LBL_SPOUSE_MOBILE.Text = "Mobile"
        '
        'Btn_MembershipTo_c
        '
        Me.Btn_MembershipTo_c.Location = New System.Drawing.Point(608, 112)
        Me.Btn_MembershipTo_c.Name = "Btn_MembershipTo_c"
        Me.Btn_MembershipTo_c.Size = New System.Drawing.Size(16, 20)
        Me.Btn_MembershipTo_c.TabIndex = 20
        Me.Btn_MembershipTo_c.Text = "C"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(328, 112)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(112, 18)
        Me.Label76.TabIndex = 598
        Me.Label76.Text = "Membership To :"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(16, 112)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(129, 18)
        Me.Label74.TabIndex = 597
        Me.Label74.Text = "Membership From :"
        '
        'dtp_MembershipFrom
        '
        Me.dtp_MembershipFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_MembershipFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_MembershipFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_MembershipFrom.Location = New System.Drawing.Point(144, 112)
        Me.dtp_MembershipFrom.Name = "dtp_MembershipFrom"
        Me.dtp_MembershipFrom.Size = New System.Drawing.Size(160, 22)
        Me.dtp_MembershipFrom.TabIndex = 11
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(344, 88)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(87, 18)
        Me.Label96.TabIndex = 593
        Me.Label96.Text = "Spouse DOB"
        '
        'txt_Spouse
        '
        Me.txt_Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Spouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Spouse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Spouse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Spouse.Location = New System.Drawing.Point(144, 88)
        Me.txt_Spouse.MaxLength = 50
        Me.txt_Spouse.Name = "txt_Spouse"
        Me.txt_Spouse.Size = New System.Drawing.Size(168, 22)
        Me.txt_Spouse.TabIndex = 10
        Me.txt_Spouse.Text = ""
        '
        'lbl_Spouse
        '
        Me.lbl_Spouse.AutoSize = True
        Me.lbl_Spouse.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Spouse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Spouse.Location = New System.Drawing.Point(16, 88)
        Me.lbl_Spouse.Name = "lbl_Spouse"
        Me.lbl_Spouse.Size = New System.Drawing.Size(93, 18)
        Me.lbl_Spouse.TabIndex = 592
        Me.lbl_Spouse.Text = "Spouse Name"
        '
        'cmb_Membershipfrom_c
        '
        Me.cmb_Membershipfrom_c.Enabled = False
        Me.cmb_Membershipfrom_c.Location = New System.Drawing.Point(144, 112)
        Me.cmb_Membershipfrom_c.Name = "cmb_Membershipfrom_c"
        Me.cmb_Membershipfrom_c.Size = New System.Drawing.Size(160, 21)
        Me.cmb_Membershipfrom_c.TabIndex = 605
        Me.cmb_Membershipfrom_c.Visible = False
        '
        'cmb_MembershipTo_c
        '
        Me.cmb_MembershipTo_c.Enabled = False
        Me.cmb_MembershipTo_c.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_MembershipTo_c.Location = New System.Drawing.Point(440, 112)
        Me.cmb_MembershipTo_c.Name = "cmb_MembershipTo_c"
        Me.cmb_MembershipTo_c.Size = New System.Drawing.Size(168, 24)
        Me.cmb_MembershipTo_c.TabIndex = 19
        Me.cmb_MembershipTo_c.Visible = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(408, 193)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(118, 18)
        Me.Label58.TabIndex = 122
        Me.Label58.Text = "Country Of Birth :"
        '
        'GroupBox13
        '
        Me.GroupBox13.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox13.Location = New System.Drawing.Point(88, 72)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(584, 88)
        Me.GroupBox13.TabIndex = 560
        Me.GroupBox13.TabStop = False
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(360, 13)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(266, 35)
        Me.lbl_Caption.TabIndex = 110
        Me.lbl_Caption.Text = "MEMBER  MASTER"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox14
        '
        Me.GroupBox14.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox14.Location = New System.Drawing.Point(88, 1960)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(776, 64)
        Me.GroupBox14.TabIndex = 214
        Me.GroupBox14.TabStop = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.Location = New System.Drawing.Point(584, 1976)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 110
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Location = New System.Drawing.Point(448, 1976)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 109
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.Location = New System.Drawing.Point(72, 1976)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 107
        Me.cmd_ListView.Text = "View [F8]"
        Me.cmd_ListView.Visible = False
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.Location = New System.Drawing.Point(312, 1976)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 108
        Me.cmd_Delete.Text = "Freeze[F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.Location = New System.Drawing.Point(184, 1976)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 106
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(312, 1984)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 30)
        Me.Label23.TabIndex = 568
        Me.Label23.Text = "Label23"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(184, 1984)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(108, 30)
        Me.Label27.TabIndex = 570
        Me.Label27.Text = "Label27"
        Me.Label27.Visible = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(64, 1984)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(108, 30)
        Me.Label29.TabIndex = 569
        Me.Label29.Text = "Label29"
        Me.Label29.Visible = False
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(440, 1984)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(108, 30)
        Me.Label38.TabIndex = 571
        Me.Label38.Text = "Label38"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(576, 1984)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(108, 30)
        Me.Label42.TabIndex = 574
        Me.Label42.Text = "Label42"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Location = New System.Drawing.Point(88, 56)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(584, 24)
        Me.Label36.TabIndex = 575
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label44.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(96, 59)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(256, 19)
        Me.Label44.TabIndex = 111
        Me.Label44.Text = "MEMBER INFORMATION"
        '
        'lbl_Frez
        '
        Me.lbl_Frez.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(432, 1936)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Frez.TabIndex = 216
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'grp_ChildrenDetails
        '
        Me.grp_ChildrenDetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_ChildrenDetails.Controls.Add(Me.ssgrid)
        Me.grp_ChildrenDetails.Controls.Add(Me.Label53)
        Me.grp_ChildrenDetails.Controls.Add(Me.Label34)
        Me.grp_ChildrenDetails.Controls.Add(Me.cmd_ChildrenCancel)
        Me.grp_ChildrenDetails.Controls.Add(Me.cmd_ChildrenOk)
        Me.grp_ChildrenDetails.Controls.Add(Me.Label45)
        Me.grp_ChildrenDetails.Controls.Add(Me.Label46)
        Me.grp_ChildrenDetails.Location = New System.Drawing.Point(32, 272)
        Me.grp_ChildrenDetails.Name = "grp_ChildrenDetails"
        Me.grp_ChildrenDetails.Size = New System.Drawing.Size(776, 288)
        Me.grp_ChildrenDetails.TabIndex = 1
        Me.grp_ChildrenDetails.TabStop = False
        Me.grp_ChildrenDetails.Visible = False
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 64)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(760, 136)
        Me.ssgrid.TabIndex = 0
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label53.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(8, 9)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(166, 22)
        Me.Label53.TabIndex = 3
        Me.Label53.Text = "CHILDREN DETAILS"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(0, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(768, 24)
        Me.Label34.TabIndex = 575
        '
        'cmd_ChildrenCancel
        '
        Me.cmd_ChildrenCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ChildrenCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ChildrenCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ChildrenCancel.Location = New System.Drawing.Point(328, 208)
        Me.cmd_ChildrenCancel.Name = "cmd_ChildrenCancel"
        Me.cmd_ChildrenCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ChildrenCancel.TabIndex = 2
        Me.cmd_ChildrenCancel.Text = "&Cancel"
        '
        'cmd_ChildrenOk
        '
        Me.cmd_ChildrenOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ChildrenOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ChildrenOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ChildrenOk.Location = New System.Drawing.Point(184, 208)
        Me.cmd_ChildrenOk.Name = "cmd_ChildrenOk"
        Me.cmd_ChildrenOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ChildrenOk.TabIndex = 1
        Me.cmd_ChildrenOk.Text = "O&K "
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(176, 216)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(108, 30)
        Me.Label45.TabIndex = 572
        Me.Label45.Text = "Label45"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label46.Location = New System.Drawing.Point(320, 216)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(108, 30)
        Me.Label46.TabIndex = 573
        Me.Label46.Text = "Label46"
        '
        'GroupBox16
        '
        Me.GroupBox16.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox16.Controls.Add(Me.LStatus)
        Me.GroupBox16.Location = New System.Drawing.Point(728, 280)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(128, 136)
        Me.GroupBox16.TabIndex = 130
        Me.GroupBox16.TabStop = False
        '
        'LStatus
        '
        Me.LStatus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LStatus.ForeColor = System.Drawing.Color.Red
        Me.LStatus.Location = New System.Drawing.Point(8, 96)
        Me.LStatus.Name = "LStatus"
        Me.LStatus.Size = New System.Drawing.Size(112, 24)
        Me.LStatus.TabIndex = 0
        '
        'Grp_MemQualification
        '
        Me.Grp_MemQualification.BackColor = System.Drawing.SystemColors.Menu
        Me.Grp_MemQualification.Controls.Add(Me.Label54)
        Me.Grp_MemQualification.Controls.Add(Me.Label89)
        Me.Grp_MemQualification.Controls.Add(Me.Cmd_MemberQuliCancel)
        Me.Grp_MemQualification.Controls.Add(Me.Cmd_MemberQuliOk)
        Me.Grp_MemQualification.Controls.Add(Me.Label56)
        Me.Grp_MemQualification.Controls.Add(Me.Label57)
        Me.Grp_MemQualification.Controls.Add(Me.SSgrid_Qualification)
        Me.Grp_MemQualification.Location = New System.Drawing.Point(32, 912)
        Me.Grp_MemQualification.Name = "Grp_MemQualification"
        Me.Grp_MemQualification.Size = New System.Drawing.Size(784, 248)
        Me.Grp_MemQualification.TabIndex = 4
        Me.Grp_MemQualification.TabStop = False
        Me.Grp_MemQualification.Visible = False
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label54.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(8, 9)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(213, 22)
        Me.Label54.TabIndex = 574
        Me.Label54.Text = "MEMBER QUALIFICATION"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label89.Location = New System.Drawing.Point(0, 8)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(776, 24)
        Me.Label89.TabIndex = 578
        '
        'Cmd_MemberQuliCancel
        '
        Me.Cmd_MemberQuliCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_MemberQuliCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_MemberQuliCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemberQuliCancel.Location = New System.Drawing.Point(376, 200)
        Me.Cmd_MemberQuliCancel.Name = "Cmd_MemberQuliCancel"
        Me.Cmd_MemberQuliCancel.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_MemberQuliCancel.TabIndex = 2
        Me.Cmd_MemberQuliCancel.Text = "Cancel"
        '
        'Cmd_MemberQuliOk
        '
        Me.Cmd_MemberQuliOk.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_MemberQuliOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_MemberQuliOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemberQuliOk.Location = New System.Drawing.Point(232, 200)
        Me.Cmd_MemberQuliOk.Name = "Cmd_MemberQuliOk"
        Me.Cmd_MemberQuliOk.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_MemberQuliOk.TabIndex = 1
        Me.Cmd_MemberQuliOk.Text = "Ok"
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(224, 208)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(108, 30)
        Me.Label56.TabIndex = 572
        Me.Label56.Text = "Label45"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(368, 208)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(108, 30)
        Me.Label57.TabIndex = 573
        Me.Label57.Text = "Label46"
        '
        'SSgrid_Qualification
        '
        Me.SSgrid_Qualification.ContainingControl = Me
        Me.SSgrid_Qualification.DataSource = Nothing
        Me.SSgrid_Qualification.Location = New System.Drawing.Point(8, 40)
        Me.SSgrid_Qualification.Name = "SSgrid_Qualification"
        Me.SSgrid_Qualification.OcxState = CType(resources.GetObject("SSgrid_Qualification.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Qualification.Size = New System.Drawing.Size(768, 150)
        Me.SSgrid_Qualification.TabIndex = 0
        '
        'grp_Relativedetails
        '
        Me.grp_Relativedetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_Relativedetails.Controls.Add(Me.Label59)
        Me.grp_Relativedetails.Controls.Add(Me.Label85)
        Me.grp_Relativedetails.Controls.Add(Me.cmd_RelativeCancel)
        Me.grp_Relativedetails.Controls.Add(Me.cmd_RelativesOk)
        Me.grp_Relativedetails.Controls.Add(Me.Label73)
        Me.grp_Relativedetails.Controls.Add(Me.Label78)
        Me.grp_Relativedetails.Controls.Add(Me.SSgrid_Relatives)
        Me.grp_Relativedetails.Location = New System.Drawing.Point(32, 680)
        Me.grp_Relativedetails.Name = "grp_Relativedetails"
        Me.grp_Relativedetails.Size = New System.Drawing.Size(784, 232)
        Me.grp_Relativedetails.TabIndex = 3
        Me.grp_Relativedetails.TabStop = False
        Me.grp_Relativedetails.Visible = False
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label59.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(8, 10)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(162, 22)
        Me.Label59.TabIndex = 574
        Me.Label59.Text = "RELATIVE DETAILS"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label85.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(0, 8)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(784, 24)
        Me.Label85.TabIndex = 576
        '
        'cmd_RelativeCancel
        '
        Me.cmd_RelativeCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_RelativeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_RelativeCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_RelativeCancel.Location = New System.Drawing.Point(384, 183)
        Me.cmd_RelativeCancel.Name = "cmd_RelativeCancel"
        Me.cmd_RelativeCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_RelativeCancel.TabIndex = 2
        Me.cmd_RelativeCancel.Text = "Cancel"
        '
        'cmd_RelativesOk
        '
        Me.cmd_RelativesOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_RelativesOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_RelativesOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_RelativesOk.Location = New System.Drawing.Point(240, 183)
        Me.cmd_RelativesOk.Name = "cmd_RelativesOk"
        Me.cmd_RelativesOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_RelativesOk.TabIndex = 1
        Me.cmd_RelativesOk.Text = "Ok"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(232, 191)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(108, 30)
        Me.Label73.TabIndex = 572
        Me.Label73.Text = "Label45"
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label78.Location = New System.Drawing.Point(376, 191)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(108, 30)
        Me.Label78.TabIndex = 573
        Me.Label78.Text = "Label46"
        '
        'SSgrid_Relatives
        '
        Me.SSgrid_Relatives.ContainingControl = Me
        Me.SSgrid_Relatives.DataSource = Nothing
        Me.SSgrid_Relatives.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_Relatives.Name = "SSgrid_Relatives"
        Me.SSgrid_Relatives.OcxState = CType(resources.GetObject("SSgrid_Relatives.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Relatives.Size = New System.Drawing.Size(768, 126)
        Me.SSgrid_Relatives.TabIndex = 0
        '
        'grp_SportsIntrested
        '
        Me.grp_SportsIntrested.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_SportsIntrested.Controls.Add(Me.Label79)
        Me.grp_SportsIntrested.Controls.Add(Me.Label88)
        Me.grp_SportsIntrested.Controls.Add(Me.cmd_SportsCancel)
        Me.grp_SportsIntrested.Controls.Add(Me.cmd_SportsOk)
        Me.grp_SportsIntrested.Controls.Add(Me.Label80)
        Me.grp_SportsIntrested.Controls.Add(Me.Label81)
        Me.grp_SportsIntrested.Controls.Add(Me.SSgrid_Sports)
        Me.grp_SportsIntrested.Location = New System.Drawing.Point(32, 456)
        Me.grp_SportsIntrested.Name = "grp_SportsIntrested"
        Me.grp_SportsIntrested.Size = New System.Drawing.Size(776, 240)
        Me.grp_SportsIntrested.TabIndex = 2
        Me.grp_SportsIntrested.TabStop = False
        Me.grp_SportsIntrested.Visible = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label79.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.White
        Me.Label79.Location = New System.Drawing.Point(8, 9)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(183, 22)
        Me.Label79.TabIndex = 574
        Me.Label79.Text = "SPORTS INTERESTED"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label88.Location = New System.Drawing.Point(0, 8)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(768, 24)
        Me.Label88.TabIndex = 577
        '
        'cmd_SportsCancel
        '
        Me.cmd_SportsCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SportsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SportsCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SportsCancel.Location = New System.Drawing.Point(312, 191)
        Me.cmd_SportsCancel.Name = "cmd_SportsCancel"
        Me.cmd_SportsCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SportsCancel.TabIndex = 2
        Me.cmd_SportsCancel.Text = "Cancel"
        '
        'cmd_SportsOk
        '
        Me.cmd_SportsOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SportsOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SportsOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SportsOk.Location = New System.Drawing.Point(168, 191)
        Me.cmd_SportsOk.Name = "cmd_SportsOk"
        Me.cmd_SportsOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SportsOk.TabIndex = 1
        Me.cmd_SportsOk.Text = "Ok"
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label80.Location = New System.Drawing.Point(160, 199)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(108, 30)
        Me.Label80.TabIndex = 572
        Me.Label80.Text = "Label45"
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label81.Location = New System.Drawing.Point(304, 199)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(108, 30)
        Me.Label81.TabIndex = 573
        Me.Label81.Text = "Label46"
        '
        'SSgrid_Sports
        '
        Me.SSgrid_Sports.ContainingControl = Me
        Me.SSgrid_Sports.DataSource = Nothing
        Me.SSgrid_Sports.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_Sports.Name = "SSgrid_Sports"
        Me.SSgrid_Sports.OcxState = CType(resources.GetObject("SSgrid_Sports.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Sports.Size = New System.Drawing.Size(760, 134)
        Me.SSgrid_Sports.TabIndex = 0
        '
        'grp_MemberClub
        '
        Me.grp_MemberClub.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_MemberClub.Controls.Add(Me.Label82)
        Me.grp_MemberClub.Controls.Add(Me.Label90)
        Me.grp_MemberClub.Controls.Add(Me.cmd_ClubCancel)
        Me.grp_MemberClub.Controls.Add(Me.cmd_ClubOk)
        Me.grp_MemberClub.Controls.Add(Me.Label83)
        Me.grp_MemberClub.Controls.Add(Me.Label84)
        Me.grp_MemberClub.Controls.Add(Me.SSgrid_MemberClub)
        Me.grp_MemberClub.Location = New System.Drawing.Point(32, 1112)
        Me.grp_MemberClub.Name = "grp_MemberClub"
        Me.grp_MemberClub.Size = New System.Drawing.Size(784, 232)
        Me.grp_MemberClub.TabIndex = 5
        Me.grp_MemberClub.TabStop = False
        Me.grp_MemberClub.Visible = False
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label82.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.White
        Me.Label82.Location = New System.Drawing.Point(8, 8)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(140, 22)
        Me.Label82.TabIndex = 574
        Me.Label82.Text = "MEMBER CLUBS"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label90.Location = New System.Drawing.Point(0, 8)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(776, 24)
        Me.Label90.TabIndex = 579
        '
        'cmd_ClubCancel
        '
        Me.cmd_ClubCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ClubCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ClubCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ClubCancel.Location = New System.Drawing.Point(384, 184)
        Me.cmd_ClubCancel.Name = "cmd_ClubCancel"
        Me.cmd_ClubCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ClubCancel.TabIndex = 2
        Me.cmd_ClubCancel.Text = "Cancel"
        '
        'cmd_ClubOk
        '
        Me.cmd_ClubOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ClubOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ClubOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ClubOk.Location = New System.Drawing.Point(240, 184)
        Me.cmd_ClubOk.Name = "cmd_ClubOk"
        Me.cmd_ClubOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ClubOk.TabIndex = 1
        Me.cmd_ClubOk.Text = "Ok"
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label83.Location = New System.Drawing.Point(232, 192)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(108, 30)
        Me.Label83.TabIndex = 572
        Me.Label83.Text = "Label45"
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label84.Location = New System.Drawing.Point(376, 192)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(108, 30)
        Me.Label84.TabIndex = 573
        Me.Label84.Text = "Label46"
        '
        'SSgrid_MemberClub
        '
        Me.SSgrid_MemberClub.ContainingControl = Me
        Me.SSgrid_MemberClub.DataSource = Nothing
        Me.SSgrid_MemberClub.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_MemberClub.Name = "SSgrid_MemberClub"
        Me.SSgrid_MemberClub.OcxState = CType(resources.GetObject("SSgrid_MemberClub.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_MemberClub.Size = New System.Drawing.Size(768, 126)
        Me.SSgrid_MemberClub.TabIndex = 0
        '
        'Lst_BillHead
        '
        Me.Lst_BillHead.AllowDrop = True
        Me.Lst_BillHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_BillHead.ItemHeight = 15
        Me.Lst_BillHead.Location = New System.Drawing.Point(8, 416)
        Me.Lst_BillHead.Name = "Lst_BillHead"
        Me.Lst_BillHead.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Lst_BillHead.Size = New System.Drawing.Size(8, 19)
        Me.Lst_BillHead.Sorted = True
        Me.Lst_BillHead.TabIndex = 584
        Me.Lst_BillHead.Visible = False
        '
        'chk_Referencedetails
        '
        Me.chk_Referencedetails.BackColor = System.Drawing.Color.Transparent
        Me.chk_Referencedetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Referencedetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Referencedetails.Location = New System.Drawing.Point(280, 1896)
        Me.chk_Referencedetails.Name = "chk_Referencedetails"
        Me.chk_Referencedetails.Size = New System.Drawing.Size(224, 24)
        Me.chk_Referencedetails.TabIndex = 104
        Me.chk_Referencedetails.Text = "Reference Details"
        '
        'grp_Referencedetails
        '
        Me.grp_Referencedetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_Referencedetails.Controls.Add(Me.lbl_Referencedetails)
        Me.grp_Referencedetails.Controls.Add(Me.Label91)
        Me.grp_Referencedetails.Controls.Add(Me.cmd_ReferencedetailsCancel)
        Me.grp_Referencedetails.Controls.Add(Me.cmd_ReferencedetailsOk)
        Me.grp_Referencedetails.Controls.Add(Me.Label86)
        Me.grp_Referencedetails.Controls.Add(Me.Label87)
        Me.grp_Referencedetails.Controls.Add(Me.ssgrid_Referencedetails)
        Me.grp_Referencedetails.Location = New System.Drawing.Point(32, 1344)
        Me.grp_Referencedetails.Name = "grp_Referencedetails"
        Me.grp_Referencedetails.Size = New System.Drawing.Size(784, 232)
        Me.grp_Referencedetails.TabIndex = 6
        Me.grp_Referencedetails.TabStop = False
        Me.grp_Referencedetails.Visible = False
        '
        'lbl_Referencedetails
        '
        Me.lbl_Referencedetails.AutoSize = True
        Me.lbl_Referencedetails.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbl_Referencedetails.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Referencedetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Referencedetails.Location = New System.Drawing.Point(8, 10)
        Me.lbl_Referencedetails.Name = "lbl_Referencedetails"
        Me.lbl_Referencedetails.Size = New System.Drawing.Size(183, 22)
        Me.lbl_Referencedetails.TabIndex = 574
        Me.lbl_Referencedetails.Text = "REFERENCE DETAILS"
        Me.lbl_Referencedetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label91.Location = New System.Drawing.Point(0, 8)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(776, 24)
        Me.Label91.TabIndex = 580
        '
        'cmd_ReferencedetailsCancel
        '
        Me.cmd_ReferencedetailsCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ReferencedetailsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ReferencedetailsCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ReferencedetailsCancel.Location = New System.Drawing.Point(384, 184)
        Me.cmd_ReferencedetailsCancel.Name = "cmd_ReferencedetailsCancel"
        Me.cmd_ReferencedetailsCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ReferencedetailsCancel.TabIndex = 2
        Me.cmd_ReferencedetailsCancel.Text = "Cancel"
        '
        'cmd_ReferencedetailsOk
        '
        Me.cmd_ReferencedetailsOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ReferencedetailsOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ReferencedetailsOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ReferencedetailsOk.Location = New System.Drawing.Point(240, 184)
        Me.cmd_ReferencedetailsOk.Name = "cmd_ReferencedetailsOk"
        Me.cmd_ReferencedetailsOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ReferencedetailsOk.TabIndex = 1
        Me.cmd_ReferencedetailsOk.Text = "Ok"
        '
        'Label86
        '
        Me.Label86.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label86.Location = New System.Drawing.Point(232, 192)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(108, 30)
        Me.Label86.TabIndex = 572
        Me.Label86.Text = "Label45"
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label87.Location = New System.Drawing.Point(376, 192)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(108, 30)
        Me.Label87.TabIndex = 573
        Me.Label87.Text = "Label46"
        '
        'ssgrid_Referencedetails
        '
        Me.ssgrid_Referencedetails.ContainingControl = Me
        Me.ssgrid_Referencedetails.DataSource = Nothing
        Me.ssgrid_Referencedetails.Location = New System.Drawing.Point(8, 50)
        Me.ssgrid_Referencedetails.Name = "ssgrid_Referencedetails"
        Me.ssgrid_Referencedetails.OcxState = CType(resources.GetObject("ssgrid_Referencedetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_Referencedetails.Size = New System.Drawing.Size(768, 126)
        Me.ssgrid_Referencedetails.TabIndex = 0
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
        Me.grp_Entrancefeedetails.Location = New System.Drawing.Point(32, 1576)
        Me.grp_Entrancefeedetails.Name = "grp_Entrancefeedetails"
        Me.grp_Entrancefeedetails.Size = New System.Drawing.Size(784, 216)
        Me.grp_Entrancefeedetails.TabIndex = 7
        Me.grp_Entrancefeedetails.TabStop = False
        Me.grp_Entrancefeedetails.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label92.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.White
        Me.Label92.Location = New System.Drawing.Point(8, 9)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(209, 22)
        Me.Label92.TabIndex = 574
        Me.Label92.Text = "ENTRANCE FEE DETAILS"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label93.Location = New System.Drawing.Point(0, 8)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(776, 24)
        Me.Label93.TabIndex = 576
        '
        'cmd_EntrancefeeCancel
        '
        Me.cmd_EntrancefeeCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeCancel.Location = New System.Drawing.Point(280, 168)
        Me.cmd_EntrancefeeCancel.Name = "cmd_EntrancefeeCancel"
        Me.cmd_EntrancefeeCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeCancel.TabIndex = 2
        Me.cmd_EntrancefeeCancel.Text = "Cancel"
        '
        'cmd_EntrancefeeOK
        '
        Me.cmd_EntrancefeeOK.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeOK.Location = New System.Drawing.Point(136, 168)
        Me.cmd_EntrancefeeOK.Name = "cmd_EntrancefeeOK"
        Me.cmd_EntrancefeeOK.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeOK.TabIndex = 1
        Me.cmd_EntrancefeeOK.Text = "Ok"
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label94.Location = New System.Drawing.Point(128, 176)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(108, 30)
        Me.Label94.TabIndex = 572
        Me.Label94.Text = "Label45"
        '
        'Label95
        '
        Me.Label95.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label95.Location = New System.Drawing.Point(272, 176)
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
        Me.SSgrid_Entrancefee.Size = New System.Drawing.Size(768, 110)
        Me.SSgrid_Entrancefee.TabIndex = 0
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(424, 223)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(102, 18)
        Me.lbl_BillingBasis.TabIndex = 590
        Me.lbl_BillingBasis.Text = "Billing Basis*  :"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"YEARLY", "HALF YEARLY", "QUARTERLY", "MONTHLY", "NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(528, 222)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(168, 24)
        Me.cbo_BillingBasis.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(384, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Chk_BA_RA_Copy
        '
        Me.Chk_BA_RA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_BA_RA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_BA_RA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_BA_RA_Copy.Location = New System.Drawing.Point(648, 648)
        Me.Chk_BA_RA_Copy.Name = "Chk_BA_RA_Copy"
        Me.Chk_BA_RA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.Chk_BA_RA_Copy.TabIndex = 700
        Me.Chk_BA_RA_Copy.Text = "Copy Business Address"
        '
        'Chk_PA_RA_Copy
        '
        Me.Chk_PA_RA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PA_RA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_PA_RA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PA_RA_Copy.Location = New System.Drawing.Point(648, 688)
        Me.Chk_PA_RA_Copy.Name = "Chk_PA_RA_Copy"
        Me.Chk_PA_RA_Copy.Size = New System.Drawing.Size(192, 24)
        Me.Chk_PA_RA_Copy.TabIndex = 701
        Me.Chk_PA_RA_Copy.Text = "Copy Permanent Address"
        '
        'Chk_PA_BA_Copy
        '
        Me.Chk_PA_BA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PA_BA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_PA_BA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PA_BA_Copy.Location = New System.Drawing.Point(648, 840)
        Me.Chk_PA_BA_Copy.Name = "Chk_PA_BA_Copy"
        Me.Chk_PA_BA_Copy.Size = New System.Drawing.Size(192, 24)
        Me.Chk_PA_BA_Copy.TabIndex = 706
        Me.Chk_PA_BA_Copy.Text = "Copy Permanent Address"
        '
        'Chk_RA_BA_Copy
        '
        Me.Chk_RA_BA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_RA_BA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_RA_BA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_RA_BA_Copy.Location = New System.Drawing.Point(648, 808)
        Me.Chk_RA_BA_Copy.Name = "Chk_RA_BA_Copy"
        Me.Chk_RA_BA_Copy.Size = New System.Drawing.Size(192, 24)
        Me.Chk_RA_BA_Copy.TabIndex = 705
        Me.Chk_RA_BA_Copy.Text = "Copy Residence Address"
        '
        'SIGNATURE
        '
        Me.SIGNATURE.BackColor = System.Drawing.Color.Transparent
        Me.SIGNATURE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIGNATURE.Location = New System.Drawing.Point(864, 216)
        Me.SIGNATURE.Name = "SIGNATURE"
        Me.SIGNATURE.Size = New System.Drawing.Size(112, 16)
        Me.SIGNATURE.TabIndex = 603
        Me.SIGNATURE.Text = "SIGNATURE"
        Me.SIGNATURE.Visible = False
        '
        'PHOTO
        '
        Me.PHOTO.BackColor = System.Drawing.Color.Transparent
        Me.PHOTO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHOTO.Location = New System.Drawing.Point(864, 192)
        Me.PHOTO.Name = "PHOTO"
        Me.PHOTO.Size = New System.Drawing.Size(78, 18)
        Me.PHOTO.TabIndex = 602
        Me.PHOTO.Text = "PHOTO"
        Me.PHOTO.Visible = False
        '
        'membersignature
        '
        Me.membersignature.BackColor = System.Drawing.Color.Transparent
        Me.membersignature.Location = New System.Drawing.Point(792, 136)
        Me.membersignature.Name = "membersignature"
        Me.membersignature.Size = New System.Drawing.Size(128, 48)
        Me.membersignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.membersignature.TabIndex = 601
        Me.membersignature.TabStop = False
        '
        'memberphoto
        '
        Me.memberphoto.BackColor = System.Drawing.Color.Transparent
        Me.memberphoto.Location = New System.Drawing.Point(792, 8)
        Me.memberphoto.Name = "memberphoto"
        Me.memberphoto.Size = New System.Drawing.Size(128, 128)
        Me.memberphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberphoto.TabIndex = 600
        Me.memberphoto.TabStop = False
        '
        'grp_currentstatus
        '
        Me.grp_currentstatus.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_currentstatus.Controls.Add(Me.Label97)
        Me.grp_currentstatus.Controls.Add(Me.Label98)
        Me.grp_currentstatus.Controls.Add(Me.cmd_currentstatus_cancel)
        Me.grp_currentstatus.Controls.Add(Me.cmd_currentstatus_ok)
        Me.grp_currentstatus.Controls.Add(Me.Label99)
        Me.grp_currentstatus.Controls.Add(Me.Label100)
        Me.grp_currentstatus.Controls.Add(Me.ssgrid_currentstatus)
        Me.grp_currentstatus.Location = New System.Drawing.Point(32, 128)
        Me.grp_currentstatus.Name = "grp_currentstatus"
        Me.grp_currentstatus.Size = New System.Drawing.Size(776, 220)
        Me.grp_currentstatus.TabIndex = 604
        Me.grp_currentstatus.TabStop = False
        Me.grp_currentstatus.Visible = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label97.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.White
        Me.Label97.Location = New System.Drawing.Point(8, 8)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(157, 22)
        Me.Label97.TabIndex = 3
        Me.Label97.Text = "CURRENT STATUS"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label98
        '
        Me.Label98.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label98.Location = New System.Drawing.Point(0, 8)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(768, 24)
        Me.Label98.TabIndex = 575
        '
        'cmd_currentstatus_cancel
        '
        Me.cmd_currentstatus_cancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_currentstatus_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_currentstatus_cancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_currentstatus_cancel.Location = New System.Drawing.Point(328, 176)
        Me.cmd_currentstatus_cancel.Name = "cmd_currentstatus_cancel"
        Me.cmd_currentstatus_cancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_currentstatus_cancel.TabIndex = 2
        Me.cmd_currentstatus_cancel.Text = "&Cancel"
        '
        'cmd_currentstatus_ok
        '
        Me.cmd_currentstatus_ok.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_currentstatus_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_currentstatus_ok.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_currentstatus_ok.Location = New System.Drawing.Point(184, 176)
        Me.cmd_currentstatus_ok.Name = "cmd_currentstatus_ok"
        Me.cmd_currentstatus_ok.Size = New System.Drawing.Size(104, 32)
        Me.cmd_currentstatus_ok.TabIndex = 1
        Me.cmd_currentstatus_ok.Text = "O&K "
        '
        'Label99
        '
        Me.Label99.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label99.Location = New System.Drawing.Point(168, 184)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(108, 30)
        Me.Label99.TabIndex = 572
        Me.Label99.Text = "Label45"
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label100.Location = New System.Drawing.Point(320, 184)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(108, 30)
        Me.Label100.TabIndex = 573
        Me.Label100.Text = "Label46"
        '
        'ssgrid_currentstatus
        '
        Me.ssgrid_currentstatus.ContainingControl = Me
        Me.ssgrid_currentstatus.DataSource = Nothing
        Me.ssgrid_currentstatus.Location = New System.Drawing.Point(8, 56)
        Me.ssgrid_currentstatus.Name = "ssgrid_currentstatus"
        Me.ssgrid_currentstatus.OcxState = CType(resources.GetObject("ssgrid_currentstatus.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_currentstatus.Size = New System.Drawing.Size(760, 112)
        Me.ssgrid_currentstatus.TabIndex = 0
        '
        'TXT_TITLE
        '
        Me.TXT_TITLE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TITLE.Location = New System.Drawing.Point(104, 128)
        Me.TXT_TITLE.Name = "TXT_TITLE"
        Me.TXT_TITLE.Size = New System.Drawing.Size(88, 22)
        Me.TXT_TITLE.TabIndex = 2
        Me.TXT_TITLE.Text = ""
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label101.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.Red
        Me.Label101.Location = New System.Drawing.Point(80, 1936)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(360, 25)
        Me.Label101.TabIndex = 801
        Me.Label101.Text = "Single Quote (') is not allowed anywhere in the form."
        Me.Label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_proposaldetails
        '
        Me.grp_proposaldetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_proposaldetails.Controls.Add(Me.Label18)
        Me.grp_proposaldetails.Controls.Add(Me.Label102)
        Me.grp_proposaldetails.Controls.Add(Me.cmd_ProposerCancel)
        Me.grp_proposaldetails.Controls.Add(Me.cmd_ProposerOK)
        Me.grp_proposaldetails.Controls.Add(Me.Label103)
        Me.grp_proposaldetails.Controls.Add(Me.Label104)
        Me.grp_proposaldetails.Controls.Add(Me.SSgrid_Proposal)
        Me.grp_proposaldetails.Location = New System.Drawing.Point(32, 1712)
        Me.grp_proposaldetails.Name = "grp_proposaldetails"
        Me.grp_proposaldetails.Size = New System.Drawing.Size(784, 216)
        Me.grp_proposaldetails.TabIndex = 802
        Me.grp_proposaldetails.TabStop = False
        Me.grp_proposaldetails.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(8, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(174, 22)
        Me.Label18.TabIndex = 574
        Me.Label18.Text = "PROPOSER DETAILS"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label102.Location = New System.Drawing.Point(0, 8)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(776, 24)
        Me.Label102.TabIndex = 576
        '
        'cmd_ProposerCancel
        '
        Me.cmd_ProposerCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ProposerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ProposerCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ProposerCancel.Location = New System.Drawing.Point(280, 168)
        Me.cmd_ProposerCancel.Name = "cmd_ProposerCancel"
        Me.cmd_ProposerCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ProposerCancel.TabIndex = 2
        Me.cmd_ProposerCancel.Text = "Cancel"
        '
        'cmd_ProposerOK
        '
        Me.cmd_ProposerOK.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ProposerOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ProposerOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ProposerOK.Location = New System.Drawing.Point(136, 168)
        Me.cmd_ProposerOK.Name = "cmd_ProposerOK"
        Me.cmd_ProposerOK.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ProposerOK.TabIndex = 1
        Me.cmd_ProposerOK.Text = "Ok"
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label103.Location = New System.Drawing.Point(128, 176)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(108, 30)
        Me.Label103.TabIndex = 572
        Me.Label103.Text = "Label45"
        '
        'Label104
        '
        Me.Label104.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label104.Location = New System.Drawing.Point(272, 176)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(108, 30)
        Me.Label104.TabIndex = 573
        Me.Label104.Text = "Label46"
        '
        'SSgrid_Proposal
        '
        Me.SSgrid_Proposal.ContainingControl = Me
        Me.SSgrid_Proposal.DataSource = Nothing
        Me.SSgrid_Proposal.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_Proposal.Name = "SSgrid_Proposal"
        Me.SSgrid_Proposal.OcxState = CType(resources.GetObject("SSgrid_Proposal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Proposal.Size = New System.Drawing.Size(768, 110)
        Me.SSgrid_Proposal.TabIndex = 0
        '
        'grp_Seconderdetails
        '
        Me.grp_Seconderdetails.BackColor = System.Drawing.SystemColors.Menu
        Me.grp_Seconderdetails.Controls.Add(Me.Label105)
        Me.grp_Seconderdetails.Controls.Add(Me.Label106)
        Me.grp_Seconderdetails.Controls.Add(Me.cmd_SeconderCancel)
        Me.grp_Seconderdetails.Controls.Add(Me.cmd_SeconderOK)
        Me.grp_Seconderdetails.Controls.Add(Me.Label107)
        Me.grp_Seconderdetails.Controls.Add(Me.Label108)
        Me.grp_Seconderdetails.Controls.Add(Me.SSgrid_Seconder)
        Me.grp_Seconderdetails.Location = New System.Drawing.Point(64, 1744)
        Me.grp_Seconderdetails.Name = "grp_Seconderdetails"
        Me.grp_Seconderdetails.Size = New System.Drawing.Size(784, 216)
        Me.grp_Seconderdetails.TabIndex = 803
        Me.grp_Seconderdetails.TabStop = False
        Me.grp_Seconderdetails.Visible = False
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label105.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.Color.White
        Me.Label105.Location = New System.Drawing.Point(8, 9)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(179, 22)
        Me.Label105.TabIndex = 574
        Me.Label105.Text = "SECONDER  DETAILS"
        Me.Label105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label106
        '
        Me.Label106.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label106.Location = New System.Drawing.Point(0, 8)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(776, 24)
        Me.Label106.TabIndex = 576
        '
        'cmd_SeconderCancel
        '
        Me.cmd_SeconderCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SeconderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SeconderCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SeconderCancel.Location = New System.Drawing.Point(280, 168)
        Me.cmd_SeconderCancel.Name = "cmd_SeconderCancel"
        Me.cmd_SeconderCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SeconderCancel.TabIndex = 2
        Me.cmd_SeconderCancel.Text = "Cancel"
        '
        'cmd_SeconderOK
        '
        Me.cmd_SeconderOK.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SeconderOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SeconderOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SeconderOK.Location = New System.Drawing.Point(136, 168)
        Me.cmd_SeconderOK.Name = "cmd_SeconderOK"
        Me.cmd_SeconderOK.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SeconderOK.TabIndex = 1
        Me.cmd_SeconderOK.Text = "Ok"
        '
        'Label107
        '
        Me.Label107.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label107.Location = New System.Drawing.Point(128, 176)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(108, 30)
        Me.Label107.TabIndex = 572
        Me.Label107.Text = "Label45"
        '
        'Label108
        '
        Me.Label108.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label108.Location = New System.Drawing.Point(272, 176)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(108, 30)
        Me.Label108.TabIndex = 573
        Me.Label108.Text = "Label46"
        '
        'SSgrid_Seconder
        '
        Me.SSgrid_Seconder.ContainingControl = Me
        Me.SSgrid_Seconder.DataSource = Nothing
        Me.SSgrid_Seconder.Location = New System.Drawing.Point(8, 50)
        Me.SSgrid_Seconder.Name = "SSgrid_Seconder"
        Me.SSgrid_Seconder.OcxState = CType(resources.GetObject("SSgrid_Seconder.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Seconder.Size = New System.Drawing.Size(768, 110)
        Me.SSgrid_Seconder.TabIndex = 0
        '
        'lbl_Nationality
        '
        Me.lbl_Nationality.AutoSize = True
        Me.lbl_Nationality.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Nationality.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nationality.Location = New System.Drawing.Point(128, 168)
        Me.lbl_Nationality.Name = "lbl_Nationality"
        Me.lbl_Nationality.Size = New System.Drawing.Size(81, 18)
        Me.lbl_Nationality.TabIndex = 118
        Me.lbl_Nationality.Text = "Nationality :"
        '
        'MemberMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(817, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_TITLE)
        Me.Controls.Add(Me.lbl_BillingBasis)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.lbl_Specialinfo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_Specialinfo)
        Me.Controls.Add(Me.txt_PositionHeld)
        Me.Controls.Add(Me.txt_SeconderName)
        Me.Controls.Add(Me.txt_ProposedName)
        Me.Controls.Add(Me.txt_SeconderCode)
        Me.Controls.Add(Me.txt_ProposerCode)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.sc)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txt_Clients)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_TurnOver)
        Me.Controls.Add(Me.txt_Bankers)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_NoOfEmployee)
        Me.Controls.Add(Me.txt_Agents)
        Me.Controls.Add(Me.txt_Products)
        Me.Controls.Add(Me.txt_Bussinessinfo)
        Me.Controls.Add(Me.txt_Professonalinfo)
        Me.Controls.Add(Me.txt_Designation)
        Me.Controls.Add(Me.txt_CompanyName)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lbl_ESTDdate)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.lbl_NoOfEmployee)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txt_ApplicationNo)
        Me.Controls.Add(Me.txt_ReasonApplication)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txt_NoOfTimesProposed)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.txt_Month)
        Me.Controls.Add(Me.txt_PeriodOfStay)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.txt_DevelopmentFee)
        Me.Controls.Add(Me.txt_EntranceFee)
        Me.Controls.Add(Me.txt_SecurityDeposit)
        Me.Controls.Add(Me.txt_CreditNumber)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.txt_BA_PhoneNo)
        Me.Controls.Add(Me.txt_BA_PinCode)
        Me.Controls.Add(Me.txt_BA_Country)
        Me.Controls.Add(Me.txt_BA_State)
        Me.Controls.Add(Me.txt_BA_City)
        Me.Controls.Add(Me.txt_BA_Address3)
        Me.Controls.Add(Me.txt_BA_Address2)
        Me.Controls.Add(Me.txt_BA_Address1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_PA_Phone)
        Me.Controls.Add(Me.txt_PA_PinCode)
        Me.Controls.Add(Me.txt_PA_Country)
        Me.Controls.Add(Me.txt_PA_State)
        Me.Controls.Add(Me.txt_PA_City)
        Me.Controls.Add(Me.txt_PA_Address3)
        Me.Controls.Add(Me.txt_PA_Address2)
        Me.Controls.Add(Me.txt_PA_Address1)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.txt_RA_PhoneNo)
        Me.Controls.Add(Me.txt_RA_PinCode)
        Me.Controls.Add(Me.txt_RA_Country)
        Me.Controls.Add(Me.txt_RA_State)
        Me.Controls.Add(Me.txt_RA_City)
        Me.Controls.Add(Me.txt_RA_Address3)
        Me.Controls.Add(Me.txt_RA_Address2)
        Me.Controls.Add(Me.txt_RA_Address1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.txt_CorporateCode)
        Me.Controls.Add(Me.txt_CA_Fax)
        Me.Controls.Add(Me.txt_CA_Mobile)
        Me.Controls.Add(Me.txt_CA_Phone)
        Me.Controls.Add(Me.txt_CA_EMail)
        Me.Controls.Add(Me.txt_CA_Pin)
        Me.Controls.Add(Me.txt_CA_Country)
        Me.Controls.Add(Me.txt_CA_State)
        Me.Controls.Add(Me.txt_CA_City)
        Me.Controls.Add(Me.txt_CA_Address3)
        Me.Controls.Add(Me.txt_CA_Address2)
        Me.Controls.Add(Me.txt_CA_Address1)
        Me.Controls.Add(Me.lbl_Fax)
        Me.Controls.Add(Me.lbl_Address1)
        Me.Controls.Add(Me.lbl_address2)
        Me.Controls.Add(Me.lbl_address3)
        Me.Controls.Add(Me.lbl_city)
        Me.Controls.Add(Me.lbl_pincode)
        Me.Controls.Add(Me.lbl_state)
        Me.Controls.Add(Me.lbl_phoneno)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_mobile)
        Me.Controls.Add(Me.lbl_country)
        Me.Controls.Add(Me.txt_LDRLocker)
        Me.Controls.Add(Me.txt_HPLocker)
        Me.Controls.Add(Me.lbl_LDRlocker)
        Me.Controls.Add(Me.lbl_HPlocker)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.lbl_currentstatus)
        Me.Controls.Add(Me.txt_CountryOfBirth)
        Me.Controls.Add(Me.txt_PlaceOfBirth)
        Me.Controls.Add(Me.lbl_placeofbirth)
        Me.Controls.Add(Me.txt_NationalityAtBirth)
        Me.Controls.Add(Me.txt_Nationality)
        Me.Controls.Add(Me.lbl_dateofbirth)
        Me.Controls.Add(Me.lbl_nationalityatbirth)
        Me.Controls.Add(Me.lbl_Nationality)
        Me.Controls.Add(Me.txt_Surname)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_MiddleName)
        Me.Controls.Add(Me.lbl_surname)
        Me.Controls.Add(Me.lbl_FirstName)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.txt_Category)
        Me.Controls.Add(Me.opt_Male)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.SIGNATURE)
        Me.Controls.Add(Me.PHOTO)
        Me.Controls.Add(Me.membersignature)
        Me.Controls.Add(Me.memberphoto)
        Me.Controls.Add(Me.Chk_RA_BA_Copy)
        Me.Controls.Add(Me.Chk_PA_BA_Copy)
        Me.Controls.Add(Me.Chk_PA_RA_Copy)
        Me.Controls.Add(Me.Chk_BA_RA_Copy)
        Me.Controls.Add(Me.cbo_BillingBasis)
        Me.Controls.Add(Me.chk_Referencedetails)
        Me.Controls.Add(Me.Lst_BillHead)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.chk_Memberofclub)
        Me.Controls.Add(Me.cmd_SeconderCodeHelp)
        Me.Controls.Add(Me.cmd_ProposerCodeHelp)
        Me.Controls.Add(Me.chk_AppliedMembership)
        Me.Controls.Add(Me.chk_Childrendetail)
        Me.Controls.Add(Me.chk_Relativesdetails)
        Me.Controls.Add(Me.chk_MemberQulification)
        Me.Controls.Add(Me.chk_Sports)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chk_Elected)
        Me.Controls.Add(Me.chk_PreviouslyPr)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.chk_BA_Copy)
        Me.Controls.Add(Me.chk_PA_Copy)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.chk_RA_Copy)
        Me.Controls.Add(Me.cmd_CategoryHelp)
        Me.Controls.Add(Me.cmd_CorporateCodeHelp)
        Me.Controls.Add(Me.Label216)
        Me.Controls.Add(Me.Label217)
        Me.Controls.Add(Me.Label231)
        Me.Controls.Add(Me.Label232)
        Me.Controls.Add(Me.cbo_CurrentStatus)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.dtp_DateOfBirth)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.chk_Married)
        Me.Controls.Add(Me.chk_corporate)
        Me.Controls.Add(Me.chk_Billhead)
        Me.Controls.Add(Me.cbo_Title)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.opt_Female)
        Me.Controls.Add(Me.GroupBox16)
        Me.Controls.Add(Me.grp_Relativedetails)
        Me.Controls.Add(Me.Grp_MemQualification)
        Me.Controls.Add(Me.grp_SportsIntrested)
        Me.Controls.Add(Me.grp_ChildrenDetails)
        Me.Controls.Add(Me.grp_Entrancefeedetails)
        Me.Controls.Add(Me.grp_Referencedetails)
        Me.Controls.Add(Me.grp_MemberClub)
        Me.Controls.Add(Me.grp_Seconderdetails)
        Me.Controls.Add(Me.grp_proposaldetails)
        Me.Controls.Add(Me.grp_currentstatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MemberMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBER MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.grp_ChildrenDetails.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.Grp_MemQualification.ResumeLayout(False)
        CType(Me.SSgrid_Qualification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Relativedetails.ResumeLayout(False)
        CType(Me.SSgrid_Relatives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_SportsIntrested.ResumeLayout(False)
        CType(Me.SSgrid_Sports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_MemberClub.ResumeLayout(False)
        CType(Me.SSgrid_MemberClub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Referencedetails.ResumeLayout(False)
        CType(Me.ssgrid_Referencedetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Entrancefeedetails.ResumeLayout(False)
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_currentstatus.ResumeLayout(False)
        CType(Me.ssgrid_currentstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_proposaldetails.ResumeLayout(False)
        CType(Me.SSgrid_Proposal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Seconderdetails.ResumeLayout(False)
        CType(Me.SSgrid_Seconder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Dim boolchk As Boolean
    Dim PreviouslyProposedst, fullname, electedst, marriedst, sexst, AppliedButmembershipst, emailst, entrancefeest As String
    Dim billheadst, corporatest, childrendetailst, memberqulist, relativedetailst, memberclubst, sportintrestst, refedetailst As String
    Dim stmembercode, stcategorycode, stcorporatecode, stproposer, stseconder As String
    Dim RAcopyst, BAcopyst, PAcopyst, Corp_code_val, Cat_Code_val As String
    Dim gconnection As New globalClass
    Dim ClearEstdDt_val, MembershipTo_VAL, Membershipfrom_VAL, LastArr_c_VAL, DateOf_c_VAL, Appdt_c_VAL, DateOf_birth As String
    Dim codeTable As New DataTable
    Dim memdet As New DataTable
    Dim tsubscd As String
    Dim subscd As Integer
    Dim Cur As Integer
    Dim OLDNEW As String
    Private Sub MemberMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'memberphoto.Image = New Bitmap(gPhotoPath & "\Photos\Image.Jpg")
        'membersignature.Image = New Bitmap(AppPath & "\Photos\Image1.Jpg")
        'MAXMEMBER = 1
        memberphoto.Image = Nothing
        membersignature.Image = Nothing
        Me.grp_ChildrenDetails.Visible = False
        Me.grp_MemberClub.Visible = False
        Me.Grp_MemQualification.Visible = False
        Me.grp_Relativedetails.Visible = False
        Me.grp_SportsIntrested.Visible = False
        Me.grp_Entrancefeedetails.Visible = False
        Me.grp_Referencedetails.Visible = False
        Me.grp_currentstatus.Visible = False

        ' Me.txt_CorporateCode.Enabled = False
        Me.Lst_BillHead.Visible = False
        tip_Specialinfo.AutoPopDelay = 5000
        tip_Specialinfo.InitialDelay = 100
        tip_Specialinfo.ReshowDelay = 50
        ''''********************************** Force the ToolTip text to be displayed whether or not the form is active.
        tip_Specialinfo.ShowAlways = True
        ''''********************************** Set up the ToolTip text for the Button and Checkbox.
        tip_Specialinfo.SetToolTip(txt_Specialinfo, "Plz use CTRL+ENTER to Move To next Line")
        tip_Specialinfo.SetToolTip(txt_Category, "Enter a valid Category Code or else use F4")
        tip_Specialinfo.SetToolTip(txt_CorporateCode, "Enter a valid Corporate Code or else use F4")
        tip_Specialinfo.SetToolTip(dtp_DateOfBirth, "Member Date of Birth Should not be less then 18yrs")
        '''*********************************** All Zoom should be placed back initially during MEMBERMASTER load
        grp_ChildrenDetails.SendToBack()
        Grp_MemQualification.SendToBack()
        grp_MemberClub.SendToBack()
        grp_SportsIntrested.SendToBack()
        grp_Relativedetails.SendToBack()
        grp_Referencedetails.SendToBack()
        grp_Entrancefeedetails.SendToBack()
        grp_currentstatus.SendToBack()
        'Me.lbl_bill.Visible = False
        '''************************************** Set tab keys to ssgrid_childrendetails ****************************
        ssgrid.ProcessTab = True
        SSgrid_Qualification.ProcessTab = True
        ssgrid_Referencedetails.ProcessTab = True
        SSgrid_Entrancefee.ProcessTab = True
        SSgrid_Relatives.ProcessTab = True
        SSgrid_MemberClub.ProcessTab = True
        SSgrid_Sports.ProcessTab = True
        ssgrid_currentstatus.ProcessTab = True
        LStatus.Text = ""
        masterbool = True
        stmembercode = "T"
        stcategorycode = "T"
        stcorporatecode = "T"
        stproposer = "T"
        stseconder = "T"
        Me.FillBillinghead()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmd_Clear_Click(sender, e)

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

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        getAlphanumeric(e)
        stmembercode = "T"
        If Asc(e.KeyChar) = 13 Then
            If txt_MemberCode.Text <> "" Then
                TXT_TITLE.Focus()
                'txt_FirstName.Focus()
            End If
        End If
    End Sub
    Private Sub txt_Title_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TITLE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_FirstName.Focus()
        End If
    End Sub
    Private Sub txt_FirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FirstName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MiddleName.Focus()
        End If
    End Sub
    Private Sub txt_MiddleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MiddleName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Surname.Focus()
        End If
    End Sub
    Private Sub txt_Surname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Surname.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Nationality.Focus()
        End If
    End Sub
    Private Sub txt_Nationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Nationality.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            If dtp_DateOfBirth.Visible = False Then
                txt_NationalityAtBirth.Focus()
            Else
                dtp_DateOfBirth.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_DateOfBirth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_DateOfBirth.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_NationalityAtBirth.Focus()
        End If
    End Sub

    Private Sub txt_NationalityAtBirth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NationalityAtBirth.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PlaceOfBirth.Focus()
        End If
    End Sub
    Private Sub txt_PlaceOfBirth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PlaceOfBirth.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CountryOfBirth.Focus()
        End If
    End Sub

    Private Sub txt_CountryOfBirth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CountryOfBirth.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub chk_Billhead_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Billhead.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    chk_Married.Focus()
        'End If
    End Sub

    Private Sub chk_Married_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Married.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_corporate.Focus()
        End If
    End Sub

    Private Sub chk_corporate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_corporate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_GDRLocker.Focus()
        End If
    End Sub
    Private Sub txt_GDRLocker_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GDRLocker.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_LDRLocker.Focus()
        End If
        
    End Sub
    Private Sub txt_LDRLocker_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LDRLocker.KeyPress
        '''getAlphanumeric(e)
        '''If Asc(e.KeyChar) = 13 Then
        '''    txt_HPLocker.Focus()
        '''End If
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If chk_corporate.Checked = True Then
                txt_CorporateCode.Focus()
            Else
                txt_Category.Focus()
            End If
        End If
    End Sub

    Private Sub txt_HPLocker_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_HPLocker.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If chk_corporate.Checked = True Then
                txt_CorporateCode.Focus()
            Else
                txt_Category.Focus()
            End If

        End If
    End Sub

    Private Sub txt_CorporateCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CorporateCode.KeyPress
        getAlphanumeric(e)
        stcorporatecode = "T"
        If Asc(e.KeyChar) = 13 Then
            txt_Category.Focus()
        End If
    End Sub
    Private Sub txt_Category_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Category.KeyPress
        getAlphanumeric(e)
        stcategorycode = "T"
        If Asc(e.KeyChar) = 13 Then
            txt_Category_Validated_fun()
            cbo_CurrentStatus.Focus()
        End If
    End Sub

    Private Sub cbo_CurrentStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_CurrentStatus.KeyPress
        BLANK(e)
        If Asc(e.KeyChar) = 13 Then
            opt_Male.Focus()
        End If
    End Sub

    Private Sub opt_Male_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles opt_Male.KeyPress
        If Asc(e.KeyChar) = 13 Then
            opt_Female.Focus()
        End If
    End Sub

    Private Sub opt_Female_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles opt_Female.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Address1.Focus()
        End If
    End Sub

    Private Sub txt_CA_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Address1.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Address2.Focus()
        End If
    End Sub
    Private Sub txt_CA_Address2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Address2.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_CA_Address3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Address3.KeyPress
        ' getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_City.Focus()
        End If
    End Sub

    Private Sub txt_CA_City_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_City.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_State.Focus()
        End If
    End Sub

    Private Sub txt_CA_State_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_State.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Country.Focus()
        End If
    End Sub

    Private Sub txt_CA_Country_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Country.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Pin.Focus()
        End If
    End Sub

    Private Sub txt_CA_Pin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Pin.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_EMail.Focus()
        End If
    End Sub


    Private Sub txt_CA_EMail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_EMail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Phone.Focus()
        End If
    End Sub

    Private Sub txt_CA_Phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Phone.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Mobile.Focus()
        End If
    End Sub

    Private Sub txt_CA_Mobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Mobile.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_CA_Fax.Focus()
        End If
    End Sub

    Private Sub txt_CA_Fax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CA_Fax.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_Address1.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_Address1.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_Address2.Focus()
        End If
    End Sub


    Private Sub txt_RA_Address2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_Address2.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_Address3.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_City.Focus()
        End If
    End Sub

    Private Sub txt_RA_City_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_City.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_State.Focus()
        End If
    End Sub

    Private Sub txt_RA_State_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_State.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_Country.Focus()
        End If
    End Sub

    Private Sub txt_RA_Country_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_Country.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_RA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_PinCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_RA_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_RA_PhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_PhoneNo.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            chk_RA_Copy.Focus()
        End If
    End Sub

    Private Sub chk_RA_Copy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_RA_Copy.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_BA_Address1.Focus()
        End If
    End Sub
    Private Sub txt_BA_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_Address1.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_Address2.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_Address3.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_City.Focus()
        End If
    End Sub

    Private Sub txt_BA_City_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_City.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_State.Focus()
        End If
    End Sub

    Private Sub txt_BA_State_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_State.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_Country.Focus()
        End If
    End Sub

    Private Sub txt_BA_Country_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_Country.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_BA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_PinCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_BA_PhoneNo.Focus()
        End If
    End Sub
    Private Sub txt_BA_PhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_PhoneNo.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            chk_BA_Copy.Focus()
        End If
    End Sub

    Private Sub chk_BA_Copy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_BA_Copy.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PA_Address1.Focus()
        End If
    End Sub
    Private Sub txt_PA_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Address1.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_PA_Address2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Address2.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_PA_Address3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Address3.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_City.Focus()
        End If
    End Sub

    Private Sub txt_PA_City_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_City.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_State.Focus()
        End If
    End Sub

    Private Sub txt_PA_State_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_State.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_Country.Focus()
        End If
    End Sub

    Private Sub txt_PA_Country_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Country.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_PA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_PinCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PA_Phone.Focus()
        End If
    End Sub

    Private Sub txt_PA_Phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Phone.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_BloodGroup.Focus()
        End If
    End Sub

    Private Sub chk_PA_Copy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_PA_Copy.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_MembershipFrom.Focus()
        End If
    End Sub
    Private Sub dtp_MembershipFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_CreditNumber.Focus()
        End If
    End Sub
    Private Sub txt_CreditNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CreditNumber.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SecurityDeposit.Focus()
        End If
    End Sub
    Private Sub txt_SecurityDeposit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SecurityDeposit.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_DevelopmentFee.Focus()
        End If
    End Sub

    Private Sub txt_EntranceFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_EntranceFee.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_CreditLimit.Focus()
        End If
    End Sub

    Private Sub txt_DevelopmentFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DevelopmentFee.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_EntranceFee.Focus()
        End If
    End Sub

    Private Sub dtp_MembershipTo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            dtp_LastArrivalInCalcutta.Focus()
        End If
    End Sub

    Private Sub dtp_LastArrivalInCalcutta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_LastArrivalInCalcutta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PeriodOfStay.Focus()
        End If
    End Sub

    Private Sub txt_PeriodOfStay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PeriodOfStay.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Month.Focus()
        End If
    End Sub

    Private Sub txt_Month_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Month.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            chk_PreviouslyPr.Focus()
        End If
    End Sub


    Private Sub chk_PreviouslyPr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_PreviouslyPr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Elected.Focus()
        End If
    End Sub

    Private Sub chk_Elected_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Elected.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_NoOfTimesProposed.Focus()
        End If
    End Sub

    Private Sub txt_NoOfTimesProposed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NoOfTimesProposed.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If dtp_DateProposal.Visible = False Then
                txt_ReasonApplication.Focus()
            Else
                dtp_DateProposal.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_DateProposal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_ReasonApplication.Focus()
        End If
    End Sub

    Private Sub txt_ReasonApplication_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ReasonApplication.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_ApplicationNo.Focus()
        End If
    End Sub

    Private Sub txt_ApplicationNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ApplicationNo.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If dtp_DateApplication.Visible = False Then
                txt_CompanyName.Focus()
            Else
                dtp_DateApplication.Focus()
            End If

        End If
    End Sub

    Private Sub dtp_DateApplication_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_CompanyName.Focus()
        End If
    End Sub

    Private Sub txt_CompanyName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CompanyName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Designation.Focus()
        End If
    End Sub

    Private Sub txt_Designation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Designation.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Professonalinfo.Focus()
        End If
    End Sub

    Private Sub txt_Professonalinfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Professonalinfo.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Bussinessinfo.Focus()
        End If
    End Sub

    Private Sub txt_Bussinessinfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Bussinessinfo.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Bankers.Focus()
        End If
    End Sub

    Private Sub txt_Bankers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Bankers.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Clients.Focus()
        End If
    End Sub

    Private Sub txt_Clients_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Clients.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Products.Focus()
        End If
    End Sub

    Private Sub txt_Products_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Products.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Agents.Focus()
        End If
    End Sub

    Private Sub txt_Agents_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Agents.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            If dtp_ESTDdate.Visible = False Then
                txt_NoOfEmployee.Focus()
            Else
                dtp_ESTDdate.Focus()
            End If
        End If
    End Sub
    Private Sub txt_NoOfEmployee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NoOfEmployee.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_TurnOver.Focus()
        End If
    End Sub

    Private Sub txt_TurnOver_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TurnOver.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_ProposerCode.Focus()
        End If
    End Sub

    Private Sub txt_ProposerCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ProposerCode.KeyPress
        getAlphanumeric(e)
        stproposer = "T"
        If Asc(e.KeyChar) = 13 Then
            txt_SeconderCode.Focus()
        End If
    End Sub
    Private Sub txt_SeconderCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SeconderCode.KeyPress
        getAlphanumeric(e)
        stseconder = "T"
        If Asc(e.KeyChar) = 13 Then
            ' txt_SeconderName.Focus()
            txt_PositionHeld.Focus()
        End If
    End Sub
    Private Sub txt_PositionHeld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PositionHeld.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            chk_AppliedMembership.Focus()
        End If
    End Sub
    Private Sub txt_ProposedName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ProposedName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SeconderCode.Focus()
        End If
    End Sub

    Private Sub txt_SeconderName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SeconderName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PositionHeld.Focus()

        End If
    End Sub

    Private Sub chk_AppliedMembership_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_AppliedMembership.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Childrendetail.Focus()
        End If
    End Sub

    Private Sub chk_Childrendetail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Childrendetail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Relativesdetails.Focus()
        End If
    End Sub

    Private Sub chk_Relativesdetails_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Relativesdetails.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Memberofclub.Focus()
        End If
    End Sub

    Private Sub chk_Memberofclub_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Memberofclub.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_MemberQulification.Focus()
        End If
    End Sub

    Private Sub chk_MemberQulification_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_MemberQulification.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Sports.Focus()
        End If
    End Sub
    Private Sub chk_Sports_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Sports.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Referencedetails.Focus()
        End If
    End Sub
    Private Sub txt_Specialinfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Specialinfo.KeyPress
        'getAlphanumeric(e)
        Block_Singlequote(e)
        If Asc(e.KeyChar) = 13 Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Private Sub chk_BA_Copy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_BA_Copy.GotFocus
        chk_BA_Copy.BackColor = Color.Cyan
    End Sub
    Private Sub chk_BA_Copy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_BA_Copy.LostFocus
        If chk_BA_Copy.Checked = False Then
            chk_BA_Copy.BackColor = Color.Silver
        End If
    End Sub
    Private Sub chk_Billhead_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Billhead.GotFocus
        chk_Billhead.BackColor = Color.Cyan
    End Sub
    Private Sub chk_Billhead_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Billhead.LostFocus
        If chk_Billhead.Checked = False Then
            chk_Billhead.BackColor = Color.Silver
        End If
    End Sub
    Private Sub chk_Childrendetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Childrendetail.GotFocus
        chk_Childrendetail.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Childrendetail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Childrendetail.LostFocus
        If chk_Childrendetail.Checked = False Then
            chk_Childrendetail.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_corporate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_corporate.GotFocus
        chk_corporate.BackColor = Color.Cyan
    End Sub

    Private Sub chk_corporate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_corporate.LostFocus
        If chk_corporate.Checked = False Then
            chk_corporate.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_Elected_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Elected.GotFocus
        chk_Elected.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Elected_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Elected.LostFocus
        If chk_Elected.Checked = False Then
            chk_Elected.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_Married_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Married.GotFocus
        chk_Married.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Married_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Married.LostFocus
        If chk_Married.Checked = False Then
            chk_Married.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_Memberofclub_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Memberofclub.GotFocus
        chk_Memberofclub.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Memberofclub_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Memberofclub.LostFocus
        If chk_Memberofclub.Checked = False Then
            chk_Memberofclub.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_MemberQulification_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_MemberQulification.GotFocus
        chk_MemberQulification.BackColor = Color.Cyan
    End Sub

    Private Sub chk_MemberQulification_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_MemberQulification.LostFocus
        If chk_MemberQulification.Checked = False Then
            chk_MemberQulification.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_PA_Copy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_PA_Copy.GotFocus
        chk_PA_Copy.BackColor = Color.Cyan
    End Sub

    Private Sub chk_PA_Copy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_PA_Copy.LostFocus
        If chk_PA_Copy.Checked = False Then
            chk_PA_Copy.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_PreviouslyPr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_PreviouslyPr.GotFocus
        chk_PreviouslyPr.BackColor = Color.Cyan
    End Sub

    Private Sub chk_PreviouslyPr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_PreviouslyPr.LostFocus
        If chk_PreviouslyPr.Checked = False Then
            chk_PreviouslyPr.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_RA_Copy_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_RA_Copy.LostFocus
        If chk_RA_Copy.Checked = False Then
            chk_RA_Copy.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_Relativesdetails_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Relativesdetails.LostFocus
        If chk_Relativesdetails.Checked = False Then
            chk_Relativesdetails.BackColor = Color.Silver
        End If
    End Sub

    Private Sub chk_RA_Copy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_RA_Copy.GotFocus
        chk_RA_Copy.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Relativesdetails_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Relativesdetails.GotFocus
        chk_Relativesdetails.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Sports_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Sports.GotFocus
        chk_Sports.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Sports_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Sports.LostFocus
        If chk_Sports.Checked = False Then
            chk_Sports.BackColor = Color.Silver
        End If
    End Sub

    Private Sub opt_Male_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_Male.GotFocus
        opt_Male.BackColor = Color.Cyan
    End Sub

    Private Sub opt_Male_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_Male.LostFocus
        opt_Male.BackColor = Color.Silver
    End Sub

    Private Sub opt_Female_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_Female.GotFocus
        opt_Female.BackColor = Color.Cyan
    End Sub

    Private Sub opt_Female_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles opt_Female.LostFocus
        If opt_Female.Checked = False Then
            opt_Female.BackColor = Color.Silver
        End If
    End Sub


    Private Sub chk_AppliedMembership_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_AppliedMembership.GotFocus
        chk_AppliedMembership.BackColor = Color.Cyan
    End Sub

    Private Sub chk_AppliedMembership_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_AppliedMembership.LostFocus
        If chk_AppliedMembership.Checked = False Then
            chk_AppliedMembership.BackColor = Color.Silver
        End If
    End Sub

    Private Sub MemberMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
        ElseIf e.KeyCode = Keys.F11 Then
            Me.Close()
            Exit Sub
        End If
    End Sub
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Dim SqlString, SQLstr As String
        Dim SatusString As String
        Dim Insert(0) As String
        Dim SqlArray(), Sql(500) As String
        Dim subscd As Integer
        Dim dt As New DataTable
        Dim i, j As Long
        Dim ssql As String
        Try
            If cmd_AddNew.Text = "Add New[F5]" Then
                Call checkValidation() '''--->Check Validation
                If opt_Male.Checked = True Then
                    sexst = "M"
                ElseIf opt_Female.Checked = True Then
                    sexst = "F"
                End If
                If boolchk = False Then Exit Sub
                Call Checkdaterangevalidate(dtp_MembershipFrom.Value, dtp_MembershipTo.Value)
                If boolchk = False Then Exit Sub
                SqlString = "select isnull(max(cast(subcd as numeric)),0)+1 as subcd from membermaster"
                dt = gconnection.GetValues(SqlString)
                subscd = 0
                If dt.Rows.Count > 0 Then
                    subscd = dt.Rows(0).Item(0)
                End If
                SqlString = "INSERT INTO MemberMaster (" & _
                 "SPOUSE,WIFEDOB,BG,PANO,CREDITLIMIT,MCODE,MNAME,Prefix,FirstName,MiddleName,Surname,Nationality,DOB,NationalityAtbirth, " & _
                 "PlaceOfBirth,CountryOfBirth,BillHead,MARITALSTATUS,Corporatest,F_Mcode,FATHERNAME,NOMINEE,HPLocker," & _
                 "CorporateCode,MEMBERTYPECODE,CurentStatus,SEX,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTCOUNTRY,CONTPIN,CONTEMAIL,CONTPHONE1,CONTCELL,CONTFAX," & _
                 "RAcopyst,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,BAcopyst,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1," & _
                 "PAcopyst,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1," & _
                 "DOJ,MembershipTo,CriditNumber,SecurityDeposit,EntranceFee,DevelopmentFee,LastArrivalInCal,PeriodOfStay_year,PeriodOfStay_Month," & _
                 "PreviouslyProposed,Elected,NoOfTimesProposed,DateOfProposal,REASON,ApplNo,ApplDate," & _
                 "Company,Designation,ProfessionInfo,BuisnessInfo,BANKER,Client,Products,AgentsDealers,ESTDdate,NoOfEmp,Turnover," & _
                 "PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,PositionInChamber,AppliedBut,Childstatus,Relativestatus,Clubstatus,Qulificationstatus,sportstatus,adduser,StatusDateFrom,statusDateTo,adddate,freeze,referentialst,entrancefeest,Billbasis,spousemobile,subcd"
                If Me.chk_Childrendetail.Checked = True Then
                    SqlString = SqlString & ",ChildName1,ChildDob1,ChildSex1,ChildName2,ChildDob2," & _
                    "ChildSex2,ChildName3,ChildDob3,ChildSex3"
                End If
                If Me.chk_MemberQulification.Checked = True Then
                    SqlString = SqlString & ",Qualification1,Details1,YearOfPassing1,Institute1," & _
                    "Division1,Qualification2,Details2,YearOfPassing2,Institute2,Division2,Qualification3,Details3," & _
                    "YearOfPassing3,Institute3,Division3"
                End If
                If Me.chk_Relativesdetails.Checked = True Then
                    SqlString = SqlString & ",RelativeName1,Relation1,dateofbirth1,Relativeage1," & _
                    "RelativeSex1,Relativeaddress1,RelativeName2,Relation2,dateofbirth2,Relativeage2,RelativeSex2,Relativeaddress2," & _
                    "RelativeName3,Relation3,dateofbirth3,Relativeage3,RelativeSex3,Relativeaddress3"
                End If
                If Me.chk_Sports.Checked = True Then
                    SqlString = SqlString & ",GameType1,NameOfGame1,Description1,GameType2,NameofGame2," & _
                    "Description2,GameType3,NameOfGame3,Description3"
                End If
                If Me.chk_Memberofclub.Checked = True Then
                    SqlString = SqlString & ",OtherClubName1,OCAddress1,OtherClubName2," & _
                    "OCAddress2,OtherClubname3,OCAddress3"
                End If
                'If Me.Chk_Prop.Checked = True Then
                '    SqlString = SqlString & ",Proposer,Proposername" 
                'End If
                If Me.chk_Referencedetails.Checked = True Then
                    SqlString = SqlString & ",mem_code1,mem_name1,refmem_date1,deleted1," & _
                    "mem_code2,mem_name2,refmem_date2,deleted2,mem_code3,mem_name3,refmem_date3,deleted3 "
                End If
                If Me.chk_EntranceFee.Checked = True Then
                    SqlString = SqlString & ",receiptno1,startdate1,amount1," & _
                    "receiptno2,startdate2,amount2,receiptno3,startdate3,amount3 "
                End If

                SqlString = SqlString & " )VALUES ('" & _
                 Trim(txt_Spouse.Text) & "','" & _
                 Trim(txt_spouse_dob.Text) & "','" & _
                 Trim(Txt_BloodGroup.Text) & "','" & _
                 Trim(Txt_PANNo.Text) & "','" & _
                 Val(Txt_CreditLimit.Text) & "','" & _
                 Trim(txt_MemberCode.Text) & "','" & _
                 fullname & "','" & _
                 TXT_TITLE.Text & "','" & _
                 Trim(txt_FirstName.Text) & "','" & _
                 Trim(txt_MiddleName.Text) & "','" & _
                 Trim(txt_Surname.Text) & "','" & _
                 Trim(txt_Nationality.Text) & "','" & _
                 Format(dtp_DateOfBirth.Value, "dd-MMM-yyyy") & "','" & _
                 Trim(txt_NationalityAtBirth.Text) & "','" & _
                 Trim(txt_PlaceOfBirth.Text) & "','" & _
                 Trim(txt_CountryOfBirth.Text) & "','" & _
                 billheadst & "','" & _
                 marriedst & "','" & _
                 corporatest & "' ,'" & _
                 Trim(txt_fmcode.Text) & "','" & _
                 Trim(txt_GDRLocker.Text) & "','" & _
                 Trim(txt_LDRLocker.Text) & "','" & _
                 Trim(txt_HPLocker.Text) & "','" & _
                 Trim(Corp_code_val) & "','" & _
                 Trim(Cat_Code_val) & "','" & _
                 cbo_CurrentStatus.Text & "','" & _
                 sexst & "','" & _
                 Trim(txt_CA_Address1.Text) & "','" & _
                 Trim(txt_CA_Address2.Text) & "','" & _
                 Trim(txt_CA_Address3.Text) & "','" & _
                 Trim(txt_CA_City.Text) & "','" & _
                 Trim(txt_CA_State.Text) & "','" & _
                 Trim(txt_CA_Country.Text) & "','" & _
                 Trim(txt_CA_Pin.Text) & "','" & _
                 Trim(txt_CA_EMail.Text) & "','" & _
                 Trim(txt_CA_Phone.Text) & "','" & _
                 Trim(txt_CA_Mobile.Text) & "','" & _
                 Trim(txt_CA_Fax.Text) & "','" & _
                 RAcopyst & "','" & _
                 Trim(txt_RA_Address1.Text) & "','" & _
                 Trim(txt_RA_Address2.Text) & "','" & _
                 Trim(txt_RA_Address3.Text) & "','" & _
                 Trim(txt_RA_City.Text) & "','" & _
                 Trim(txt_RA_State.Text) & "','" & _
                 Trim(txt_RA_Country.Text) & "','" & _
                 Trim(txt_RA_PinCode.Text) & "','" & _
                 Trim(txt_RA_PhoneNo.Text) & "','" & _
                 BAcopyst & "','" & _
                 Trim(txt_BA_Address1.Text) & "','" & _
                 Trim(txt_BA_Address2.Text) & "','" & _
                 Trim(txt_BA_Address3.Text) & "','" & _
                 Trim(txt_BA_City.Text) & "','" & _
                 Trim(txt_BA_State.Text) & "','" & _
                 Trim(txt_BA_Country.Text) & "','" & _
                 Trim(txt_BA_PinCode.Text) & "','" & _
                 Trim(txt_BA_PhoneNo.Text) & "','" & _
                 PAcopyst & "','" & _
                 Trim(txt_PA_Address1.Text) & "','" & _
                 Trim(txt_PA_Address2.Text) & "','" & _
                 Trim(txt_PA_Address3.Text) & "','" & _
                 Trim(txt_PA_City.Text) & "','" & _
                 Trim(txt_PA_State.Text) & "','" & _
                 Trim(txt_PA_Country.Text) & "','" & _
                 Trim(txt_PA_PinCode.Text) & "','" & _
                 Trim(txt_PA_Phone.Text) & "','" & _
                 Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy") & "','" & _
                 Format(dtp_MembershipTo.Value, "dd-MMM-yyyy") & "','" & _
                 Trim(txt_CreditNumber.Text) & "'," & _
                 Val(txt_SecurityDeposit.Text) & ", " & _
                 Val(txt_EntranceFee.Text) & "," & _
                 Val(txt_DevelopmentFee.Text) & ",'" & _
                 Format(dtp_LastArrivalInCalcutta.Value, "dd-MMM-yyyy") & "'," & _
                 Val(txt_PeriodOfStay.Text) & "," & _
                 Val(txt_Month.Text) & ",'" & _
                 PreviouslyProposedst & "','" & _
                 electedst & "'," & _
                 Val(txt_NoOfTimesProposed.Text) & ",'" & _
                 DateOf_c_VAL & "','" & _
                 Trim(txt_ReasonApplication.Text) & "','" & _
                 Trim(txt_ApplicationNo.Text) & "','" & _
                 Format(dtp_DateApplication.Value, "dd-MMM-yyyy") & "','" & _
                 Trim(txt_CompanyName.Text) & "','" & _
                 Trim(txt_Designation.Text) & "','" & _
                 Trim(txt_Professonalinfo.Text) & "','" & _
                 Trim(txt_Bussinessinfo.Text) & "','" & _
                 Trim(txt_Bankers.Text) & "','" & _
                 Trim(txt_Clients.Text) & "','" & _
                 Trim(txt_Products.Text) & "','" & _
                 Trim(txt_Agents.Text) & "','" & _
                 Format(dtp_ESTDdate.Value, "dd/MMM/yyyy") & "'," & _
                 Val(txt_NoOfEmployee.Text) & "," & _
                 Val(txt_TurnOver.Text) & ",'" & _
                 Trim(txt_ProposerCode.Text) & "','" & _
                 Trim(txt_ProposedName.Text) & "','" & _
                 Trim(txt_SeconderCode.Text) & "','" & _
                 Trim(txt_SeconderName.Text) & "','" & _
                 Trim(txt_PositionHeld.Text) & "','" & _
                 AppliedButmembershipst & "','" & _
                 childrendetailst & "','" & _
                 relativedetailst & "','" & _
                 memberclubst & "','" & _
                 memberqulist & "','" & _
                 sportintrestst & "','" & _
                 gUsername & "','" & _
                 Format(dtp_MembershipFrom.Value, "dd/MMM/yyyy") & "','','" & _
                 Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & refedetailst & "','" & entrancefeest & "','" & cbo_BillingBasis.Text & "','" & Trim(TXT_SPOUSE_MOBILE.Text) & "','" & Format(subscd, "0000") & "'"

                If Me.chk_Childrendetail.Checked = True Then
                    'ssql = InsertZoomTable("ChildrenDetails")
                    'If ssql = "" Then
                    '    SqlString = SqlString & ",'','','','','','','','','','','',''"
                    'Else
                    '    SqlString = SqlString & "," & ssql
                    'End If
                    With ssgrid
                        For i = 1 To 3
                            .Row = i
                            For j = 1 To 3
                                .Col = j
                                SqlString = SqlString & ",'" & .Text & "'"
                            Next
                        Next
                    End With
                End If
                If Me.chk_MemberQulification.Checked = True Then
                    'ssql = InsertZoomTable("MemberQualification")
                    'If ssql = "" Then
                    '    SqlString = SqlString & ",'','','','',0,'','','','',0,'','','','',0"
                    'Else
                    '    SqlString = SqlString & "," & ssql
                    'End If
                    With SSgrid_Qualification
                        For i = 1 To 3
                            .Row = i
                            For j = 1 To 5
                                .Col = j
                                SqlString = SqlString & ",'" & .Text & "'"
                            Next
                        Next
                    End With
                End If
                If Me.chk_Relativesdetails.Checked = True Then
                    ssql = InsertZoomTable("Relativesdetails")
                    If ssql = "" Then
                        SqlString = SqlString & ",'','','',0,'','','','','',0,'','','','','',0,'',''"
                    Else
                        SqlString = SqlString & "," & ssql
                    End If
                    'With SSgrid_Relatives
                    '    For i = 1 To 3
                    '        .Row = i
                    '        For j = 1 To 6
                    '            .Col = j
                    '            SqlString = SqlString & ",'" & .Text & "'"
                    '        Next
                    '    Next
                    'End With
                End If
                If Me.chk_Sports.Checked = True Then
                    'ssql = InsertZoomTable("Sports")
                    'If ssql = "" Then
                    '    SqlString = SqlString & ",'','','','','','','','',''"
                    'Else
                    '    SqlString = SqlString & "," & ssql
                    'End If
                    With SSgrid_Sports
                        For i = 1 To 3
                            .Row = i
                            For j = 1 To 3
                                .Col = j
                                SqlString = SqlString & ",'" & .Text & "'"
                            Next
                        Next
                    End With
                End If
                If Me.chk_Memberofclub.Checked = True Then
                    'ssql = InsertZoomTable("Memberofclub")
                    'If ssql = "" Then
                    '    SqlString = SqlString & ",'','','','','','','','',''"
                    'Else
                    '    SqlString = SqlString & "," & ssql
                    'End If
                    With SSgrid_MemberClub
                        For i = 1 To 3
                            .Row = i
                            For j = 1 To 2
                                .Col = j
                                SqlString = SqlString & ",'" & .Text & "'"
                            Next
                        Next
                    End With
                End If
                'If Me.Chk_Prop.Checked = True Then
                '    'ssql = InsertZoomTable("Memberofclub")
                '    'If ssql = "" Then
                '    '    SqlString = SqlString & ",'','','','','','','','',''"
                '    'Else
                '    '    SqlString = SqlString & "," & ssql
                '    'End If
                '    With SSgrid_Proposal
                '        For i = 1 To 1
                '            .Row = i
                '            For j = 1 To 2
                '                .Col = j
                '                SqlString = SqlString & ",'" & .Text & "'"
                '            Next
                '        Next
                '    End With
                'End If
                If Me.chk_Referencedetails.Checked = True Then
                    'ssql = InsertZoomTable("referencedetails")
                    'If ssql = "" Then
                    '    SqlString = SqlString & ",'','','','','','','','','','','',''"
                    'Else
                    '    SqlString = SqlString & "," & ssql
                    'End If
                    With ssgrid_Referencedetails
                        For i = 1 To 3
                            .Row = i
                            For j = 1 To 4
                                .Col = j
                                SqlString = SqlString & ",'" & .Text & "'"
                            Next
                        Next
                    End With
                End If
                If Me.chk_EntranceFee.Checked = True Then
                    ssql = InsertZoomTable("entrancefee")
                    If ssql = "" Then
                        SqlString = SqlString & ",'','',0,'','',0,'','',0"
                    Else
                        SqlString = SqlString & "," & ssql
                    End If
                    'With SSgrid_Entrancefee
                    '    For i = 1 To 3
                    '        .Row = i
                    '        For j = 1 To 3
                    '            .Col = j
                    '            SqlString = SqlString & ",'" & .Text & "'"
                    '        Next
                    '    Next
                    'End With
                End If

                SqlString = SqlString & ")"

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = SqlString

                '----------------------------------
                '01/08/2008
                'cureent status
                If ssgrid_currentstatus.DataRowCnt > 0 Then
                    For i = 0 To ssgrid_currentstatus.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(cbo_CurrentStatus.Text, 1, 1) & "',"
                        With ssgrid_currentstatus
                            .Row = i + 1
                            .Col = 1
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i + 1
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i + 1
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With

                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                '----------
                If ssgrid.DataRowCnt > 0 Then
                    For i = 0 To ssgrid.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,CHILD_NM,CHILD_DOB,SEX,REMARKS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','CHLD',"
                        With ssgrid
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i + 1
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Relatives.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Relatives.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,NAME,RELATION,CHILD_DOB,REMARKS,SEX,ADDRESS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','RELA',"
                        With SSgrid_Relatives
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 3
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If

                            .Row = i + 1
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 5
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 6
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_MemberClub.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_MemberClub.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,NAME,ADDRESS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','Club',"
                        With SSgrid_MemberClub
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With

                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Proposal.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Proposal.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,pcode,pname)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','Prop',"
                        With SSgrid_Proposal
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Seconder.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Seconder.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,pcode,pname)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','Seco',"
                        With SSgrid_Seconder
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If ssgrid_Referencedetails.DataRowCnt > 0 Then
                    For i = 0 To ssgrid_Referencedetails.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,REFMEM_NO,NAME,REFMEM_DT,DELETED)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','REFR',"
                        With ssgrid_Referencedetails
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"

                            .Row = i + 1
                            .Col = 3
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i + 1
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")                        
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Entrancefee.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Entrancefee.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','ENTR',"
                        With SSgrid_Entrancefee
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If

                            .Row = i + 1
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With

                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Sports.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Sports.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,aqua_game,NAME,REMARKS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','SPRT',"
                        With SSgrid_Sports
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Mid(Trim(.Text), 1, 1) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With

                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                If SSgrid_Qualification.DataRowCnt > 0 Then
                    For i = 0 To SSgrid_Qualification.DataRowCnt - 1
                        Sql(i) = "insert into memdet(MEM_CODE,type0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','QUAL',"
                        With SSgrid_Qualification
                            .Row = i + 1
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i + 1
                            .Col = 5
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                        'gconnection.dataOperation(1, ssql, "specialmaster")
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If

                '----------------------------------                
                SatusString = "insert into Memberledger (MCODE,NEWSTATUS,PRESENTSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,USERID,ADDDATE) "
                SatusString = SatusString & "values('" & txt_MemberCode.Text & "','" & cbo_CurrentStatus.Text & "','NEW MEMBER','WELCOME TO " & gCompanyAddress(0) & "','" & Format(dtp_MembershipFrom.Value, "dd/MMM/yyyy") & "',"
                SatusString = SatusString & "NULL,'DBS','" & Format(Date.Now, "dd/MMM/yyyy") & "')"

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = SatusString

                'If Format(dtp_DateApplication.Value, "dd-MMM-yyyy") = Format(Now.Today, "dd-MMM-yyyy") Then
                '    If MessageBox.Show("Plz Enter a validate date for applicationdate ", "Club ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        dtp_DateApplication.Focus()
                '    Else
                SQLstr = " INSERT INTO specialmaster(MemberCode,Specialinfo) VALUES ('" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_Specialinfo.Text) & "')"

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = SQLstr

                Dim SQLSTR1, Fz As String
                Fz = ""
                If cbo_CurrentStatus.Text = "LIVE" Or cbo_CurrentStatus.Text = "ABSENTEE" Then
                    Fz = "N"
                Else
                    Fz = "Y"
                End If
                SQLSTR1 = " INSERT INTO ACCOUNTSSUBLEDGERMASTER(ACCODE,ACDESC,SLTYPE,SLCODE,SLNAME,SLDESC,CONTACTPERSON,ADDRESS1,ADDRESS2,ADDRESS3,CITY,STATE,PIN,PHONENO,CELLNO,chq_flag) "
                SQLSTR1 = SQLSTR1 & "VALUES ('SDRS','SUNDRY DEBTORS','MEMBER','" & Trim(txt_MemberCode.Text) & "','" & fullname & "','" & fullname & "','" & fullname & "','" & Trim(txt_CA_Address1.Text) & "','" & Trim(txt_CA_Address2.Text) & "','" & Trim(txt_CA_Address3.Text) & "','" & Trim(txt_CA_City.Text) & "','" & Trim(txt_CA_State.Text) & "','" & Trim(txt_CA_Pin.Text) & "','" & Trim(txt_CA_Phone.Text) & "','" & Trim(txt_CA_Mobile.Text) & "','N')" ','" & Fz & "')"

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = SQLSTR1
                gconnection.MoreTrans1(Insert)
                MessageBox.Show("Record Saved ", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then

                Call checkValidation() '''--->Check Validation
                If Mid(Me.cmd_AddNew.Text, 1, 1) = "U" Then
                    If Me.lbl_Frez.Visible = True Then
                        MessageBox.Show(" The Frezzed Record Can Not Be Update", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                SqlString = " UPDATE  Membermaster SET BG = '" & Trim(Txt_BloodGroup.Text) & "', PANO = '" & Trim(Txt_PANNo.Text) & "', CREDITLIMIT = '" & Trim(Txt_CreditLimit.Text) & "', subcd='" & Trim(tsubscd) & "',MNAME= '" & fullname & "',Prefix='" & TXT_TITLE.Text & "' ,FirstName='" & Trim(txt_FirstName.Text) & "' ,MiddleName= '" & Trim(txt_MiddleName.Text) & "',Surname= '" & Trim(txt_Surname.Text) & "',Nationality= '" & Trim(txt_Nationality.Text) & "',"
                SqlString = SqlString & " DOB= '" & Format(dtp_DateOfBirth.Value, "dd-MMM-yyyy") & "',NationalityAtbirth = '" & Trim(txt_NationalityAtBirth.Text) & "' ,PlaceOfBirth=' " & Trim(txt_PlaceOfBirth.Text) & "' ,CountryOfBirth ='" & Trim(txt_CountryOfBirth.Text) & "'  ,BillHead ='" & billheadst & "',"
                SqlString = SqlString & " MARITALSTATUS= '" & marriedst & "',Corporatest='" & corporatest & "' ,F_Mcode='" & Trim(txt_fmcode.Text) & "' ,FATHERNAME='" & Trim(txt_GDRLocker.Text) & "' ,NOMINEE='" & Trim(txt_LDRLocker.Text) & "' ,HPLocker='" & Trim(txt_HPLocker.Text) & "',"
                SqlString = SqlString & " CorporateCode ='" & Trim(Corp_code_val) & "',MEMBERTYPECODE ='" & Trim(Cat_Code_val) & "',CurentStatus ='" & cbo_CurrentStatus.Text & "' ,SEX ='" & sexst & "' ,"
                SqlString = SqlString & "CONTADD1='" & Trim(txt_CA_Address1.Text) & "' ,CONTADD2='" & Trim(txt_CA_Address2.Text) & "',CONTADD3= '" & Trim(txt_CA_Address3.Text) & "' ,CONTCITY= '" & Trim(txt_CA_City.Text) & "',CONTSTATE='" & Trim(txt_CA_State.Text) & "',CONTCOUNTRY='" & Trim(txt_CA_Country.Text) & "',"
                SqlString = SqlString & "CONTPIN='" & Trim(txt_CA_Pin.Text) & "',CONTEMAIL= '" & Trim(txt_CA_EMail.Text) & "',CONTPHONE1=' " & Trim(txt_CA_Phone.Text) & "',CONTCELL='" & Trim(txt_CA_Mobile.Text) & "',CONTFAX='" & Trim(txt_CA_Fax.Text) & "',RAcopyst='" & RAcopyst & "',CADD1='" & Trim(txt_RA_Address1.Text) & "',CADD2='" & Trim(txt_RA_Address2.Text) & "' ,CADD3='" & Trim(txt_RA_Address3.Text) & "',"
                SqlString = SqlString & "CCITY='" & Trim(txt_RA_City.Text) & "' ,CSTATE='" & Trim(txt_RA_State.Text) & "',CCOUNTRY='" & Trim(txt_RA_Country.Text) & "',CPIN='" & Trim(txt_RA_PinCode.Text) & "',CPHONE1='" & Trim(txt_RA_PhoneNo.Text) & "' ,BAcopyst='" & BAcopyst & "' ,OADD1='" & Trim(txt_BA_Address1.Text) & "' ,OADD2='" & Trim(txt_BA_Address2.Text) & "' ,OADD3='" & Trim(txt_BA_Address3.Text) & "' ,"
                SqlString = SqlString & "OCITY='" & Trim(txt_BA_City.Text) & "' ,OSTATE='" & Trim(txt_BA_State.Text) & "' ,OCOUNTRY='" & Trim(txt_BA_Country.Text) & "',OPIN='" & Trim(txt_BA_PinCode.Text) & "' ,OPHONE1='" & Trim(txt_BA_PhoneNo.Text) & "',PAcopyst='" & PAcopyst & "' ,PADD1='" & Trim(txt_PA_Address1.Text) & "',PADD2='" & Trim(txt_PA_Address2.Text) & "' ,PADD3='" & Trim(txt_PA_Address3.Text) & "',"
                SqlString = SqlString & "PCITY='" & Trim(txt_PA_City.Text) & "' ,PSTATE='" & Trim(txt_PA_State.Text) & "' ,PCOUNTRY='" & Trim(txt_PA_Country.Text) & "' ,PPIN='" & Trim(txt_PA_PinCode.Text) & "' ,PPHONE1='" & Trim(txt_PA_Phone.Text) & "' ,DOJ='" & Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy") & "' ,MembershipTo='" & Format(dtp_MembershipTo.Value, "dd-MMM-yyyy") & "' ,"
                SqlString = SqlString & "CriditNumber='" & Trim(txt_CreditNumber.Text) & "',SecurityDeposit =" & Val(txt_SecurityDeposit.Text) & " ,EntranceFee =" & Val(txt_EntranceFee.Text) & " ,DevelopmentFee = " & Val(txt_DevelopmentFee.Text) & " ,"
                SqlString = SqlString & "LastArrivalInCal='" & Format(dtp_LastArrivalInCalcutta.Value, "dd-MMM-yyyy") & "' ,PeriodOfStay_year=" & Val(txt_PeriodOfStay.Text) & " ,PeriodOfStay_Month=" & Val(txt_Month.Text) & ","
                SqlString = SqlString & "PreviouslyProposed = '" & PreviouslyProposedst & "',Elected ='" & electedst & "' ,NoOfTimesProposed =" & Val(txt_NoOfTimesProposed.Text) & " ,DateOfProposal = '" & Format(dtp_DateProposal.Value, "dd-MMM-yyyy") & "',REASON ='" & Trim(txt_ReasonApplication.Text) & "',"
                SqlString = SqlString & "ApplNo ='" & Trim(txt_ApplicationNo.Text) & "' ,ApplDate ='" & Format(dtp_DateApplication.Value, "dd-MMM-yyyy") & "',Company='" & Trim(txt_CompanyName.Text) & "',Designation ='" & Trim(txt_Designation.Text) & "' ,ProfessionInfo = '" & Trim(txt_Professonalinfo.Text) & "',BuisnessInfo ='" & Trim(txt_Bussinessinfo.Text) & "',"
                SqlString = SqlString & "BANKER ='" & Trim(txt_Bankers.Text) & "' ,Client ='" & Trim(txt_Clients.Text) & "' ,Products ='" & Trim(txt_Products.Text) & "',AgentsDealers='" & Trim(txt_Agents.Text) & "' ,ESTDdate='" & Format(dtp_ESTDdate.Value, "dd/MMM/yyyy") & "' ,NoOfEmp =" & Val(txt_NoOfEmployee.Text) & ", Turnover =" & Val(txt_TurnOver.Text) & ","
                SqlString = SqlString & "PROPOSER ='" & Trim(txt_ProposerCode.Text) & "',PROPOSERNAME='" & Trim(txt_ProposedName.Text) & "',SECONDER ='" & Trim(txt_SeconderCode.Text) & "',SECONDERNAME='" & Trim(txt_SeconderName.Text) & "',PositionInChamber ='" & Trim(txt_PositionHeld.Text) & "' ,AppliedBut='" & AppliedButmembershipst & "' ,Childstatus ='" & childrendetailst & "' ,Relativestatus ='" & relativedetailst & "' ,"
                SqlString = SqlString & "Clubstatus ='" & memberclubst & "',SPOUSEMOBILE ='" & Trim(TXT_SPOUSE_MOBILE.Text) & "',Qulificationstatus ='" & memberqulist & "' ,sportstatus ='" & sportintrestst & "' ,adduser ='" & gUsername & "' ,adddate ='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "' ,freeze ='N',referentialst='" & refedetailst & "',entrancefeest='" & entrancefeest & "',Billbasis='" & Trim(cbo_BillingBasis.Text) & "',SPOUSE='" & Trim(txt_Spouse.Text) & "',WIFEDOB ='"
                If Len(Trim(txt_spouse_dob.Text)) > 0 Then
                    SqlString = SqlString & Format(CDate(txt_spouse_dob.Text), "dd-MMM-yyyy")
                Else
                    SqlString = SqlString & ""
                End If
                SqlString = SqlString & "' WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"

                'ROLL BACK CHANGES
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = SqlString
                gconnection.MoreTrans1(Insert)

                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='STAT' and type1='" & Mid(cbo_CurrentStatus.Text, 1, 1) & "'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If ssgrid_currentstatus.DataRowCnt > 0 Then
                    For i = 1 To ssgrid_currentstatus.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(cbo_CurrentStatus.Text, 1, 1) & "',"
                        With ssgrid_currentstatus
                            .Row = i
                            .Col = 1
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                '----------------------
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='CHLD'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If ssgrid.DataRowCnt > 0 Then
                    For i = 1 To ssgrid.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,CHILD_NM,CHILD_DOB,SEX,REMARKS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','CHLD',"
                        With ssgrid
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                'ssql = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='RELA'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='RELA'"
                If SSgrid_Relatives.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Relatives.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,NAME,RELATION,CHILD_DOB,REMARKS,SEX,ADDRESS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','RELA',"
                        With SSgrid_Relatives
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 3
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 5
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 6
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='club'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_MemberClub.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_MemberClub.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,NAME,ADDRESS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','club',"
                        With SSgrid_MemberClub
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='refr'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If ssgrid_Referencedetails.DataRowCnt > 0 Then
                    For i = 1 To ssgrid_Referencedetails.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,REFMEM_NO,NAME,REFMEM_DT,DELETED)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','refr',"
                        With ssgrid_Referencedetails
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 3
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='entr'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_Entrancefee.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Entrancefee.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','ENTR',"
                        With SSgrid_Entrancefee
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            If Len(Trim(.Text)) > 7 Then
                                Sql(i) = Sql(i) & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                            Else
                                Sql(i) = Sql(i) & "'',"
                            End If
                            .Row = i
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='SPRT'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_Sports.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Sports.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,aqua_game,NAME,REMARKS)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','SPRT',"
                        With SSgrid_Sports
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Mid(Trim(.Text), 1, 1) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='qual'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_Qualification.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Qualification.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','qual',"
                        With SSgrid_Qualification
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 3
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 4
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 5
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    'ROLL BACK CHANGES
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='Prop'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_Proposal.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Proposal.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,pcode,pname)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','Prop',"
                        With SSgrid_Proposal
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                Sql.Clear(Sql, 1, 500)
                Sql(0) = "delete from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='Seco'"
                'gconnection.dataOperation(1, ssql, "specialmaster")
                If SSgrid_Seconder.DataRowCnt > 0 Then
                    For i = 1 To SSgrid_Seconder.DataRowCnt
                        Sql(i) = "insert into memdet(MEM_CODE,type0,pcode,pname)"
                        Sql(i) = Sql(i) & "values('" & txt_MemberCode.Text & "','Seco',"
                        With SSgrid_Seconder
                            .Row = i
                            .Col = 1
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "',"
                            .Row = i
                            .Col = 2
                            Sql(i) = Sql(i) & "'" & Trim(.Text) & "')"
                        End With
                    Next i
                    ReDim SqlArray(Sql.Length)
                    SqlArray.Copy(Sql, SqlArray, Sql.Length)
                    gconnection.MoreTrans1(SqlArray)
                End If
                SQLstr = "DELETE FROM SPECIALMASTER WHERE MEMBERCODE = '" & Trim(txt_MemberCode.Text) & "' "
                gconnection.dataOperation(6, SQLstr, "specialmaster")
                SQLstr = " INSERT INTO  specialmaster (MEMBERCODE,Specialinfo) VALUES( '" & Trim(txt_MemberCode.Text) & "' , '" & Trim(txt_Specialinfo.Text) & "' ) "
                gconnection.dataOperation(2, SQLstr, "specialmaster")

                Dim SQLSTR1 As String

                SQLSTR1 = " UPDATE ACCOUNTSSUBLEDGERMASTER SET SLNAME = '" & fullname & "',SLDESC = ' " & fullname & "',ADDRESS1 ='" & Trim(txt_CA_Address1.Text) & "',ADDRESS2 ='" & Trim(txt_CA_Address2.Text) & "',ADDRESS3 = '" & Trim(txt_CA_Address3.Text) & "',CITY = '" & Trim(txt_CA_City.Text) & "',STATE = '" & Trim(txt_CA_State.Text) & "',PIN = '" & Trim(txt_CA_Pin.Text) & "',PHONENO ='" & Trim(txt_CA_Phone.Text) & "',CELLNO = '" & Trim(txt_CA_Mobile.Text) & "'WHERE SLCODE = '" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(2, SqlSTR1, "ACCOUNTSSUBLEDGERMASTER")
                MessageBox.Show("Record Updated ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmd_AddNew.Text = "Add New[F5]"
            End If
            If PHOTO.Checked = True Then
                If Dir(gPhotoPath & "\Photos\P" & txt_MemberCode.Text & ".jpg") <> "" Then
                    'memberphoto.Image = New Bitmap(gPhotoPath & "\Photos\Image.Jpg")
                    'Kill(AppPath & "\Photos\P" & txt_MemberCode.Text & ".jpg")
                    ' FileCopy(ppath, AppPath & "\Photos\P" & txt_MemberCode.Text & ".jpg")
                Else
                    FileCopy(ppath, gPhotoPath & "\Photos\P" & txt_MemberCode.Text & ".jpg")
                End If
            Else
                memberphoto.Image = New Bitmap(gPhotoPath & "\photos\Image.Jpg")
                If Dir(gPhotoPath & "\Photos\p" & txt_MemberCode.Text & ".jpg") <> "" Then
                    Kill(gPhotoPath & "\Photos\P" & txt_MemberCode.Text & ".jpg")
                End If
            End If
            '''''If SIGNATURE.Checked = True Then
            '''''    If Dir(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg") <> "" Then
            '''''        'membersignature.Image = New Bitmap(AppPath & "\photos\Image.Jpg")
            '''''        'Kill(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
            '''''        'FileCopy(spath, AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
            '''''    Else
            '''''        FileCopy(spath, AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
            '''''    End If
            '''''Else
            '''''    '                PBoxspouse.Image = New Bitmap(apppath & "\photos\Image.Jpg")
            '''''    If Dir(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg") <> "" Then
            '''''        Kill(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
            '''''    End If
            '''''End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        Me.cmd_Clear_Click(sender, e)
    End Sub

    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Dim vAns As Double

        vAns = MsgBox("Yes--> Check List, No--> Report Designer", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "CLUB MAN")
        If vAns = MsgBoxResult.Yes Then
            vAns = MsgBox("Yes--> View, No--> Print", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "CLUB MAN")
            If vAns = MsgBoxResult.Yes Then
                gPrint = False
                Call Check_List_View_MemberMaster()
            Else
                gPrint = True
                Call Check_List_View_MemberMaster()
            End If
        Else
            Dim FrReport As New ReportDesigner
            tables = " FROM MEMBERMASTER"
            Gheader = "MEMBER MASTER "
            FrReport.SsGridReport.SetText(2, 1, "MCODE")
            FrReport.SsGridReport.SetText(3, 1, 10)
            FrReport.SsGridReport.SetText(2, 2, "MNAME")
            FrReport.SsGridReport.SetText(3, 2, 20)
            FrReport.SsGridReport.SetText(2, 3, "Nationality")
            FrReport.SsGridReport.SetText(3, 3, 15)
            FrReport.SsGridReport.SetText(2, 4, "DOB")
            FrReport.SsGridReport.SetText(3, 4, 8)
            FrReport.SsGridReport.SetText(2, 5, "NationalityAtbirth	")
            FrReport.SsGridReport.SetText(3, 5, 20)
            FrReport.SsGridReport.SetText(2, 6, "PlaceOfBirth")
            FrReport.SsGridReport.SetText(3, 6, 20)
            FrReport.SsGridReport.SetText(2, 7, "CountryOfBirth")
            FrReport.SsGridReport.SetText(3, 7, 20)
            FrReport.SsGridReport.SetText(2, 8, "BillHead")
            FrReport.SsGridReport.SetText(3, 8, 20)
            FrReport.SsGridReport.SetText(2, 9, "MARITALSTATUS")
            FrReport.SsGridReport.SetText(3, 9, 10)
            FrReport.SsGridReport.SetText(2, 10, "GDRLocker")
            FrReport.SsGridReport.SetText(3, 10, 10)
            FrReport.SsGridReport.SetText(2, 11, "LDRLocker")
            FrReport.SsGridReport.SetText(3, 11, 10)
            FrReport.SsGridReport.SetText(2, 12, "HPLocker")
            FrReport.SsGridReport.SetText(3, 12, 10)
            FrReport.SsGridReport.SetText(2, 13, "CorporateCode")
            FrReport.SsGridReport.SetText(3, 13, 10)
            FrReport.SsGridReport.SetText(2, 14, "MEMBERTYPECODE")
            FrReport.SsGridReport.SetText(3, 14, 10)
            FrReport.SsGridReport.SetText(2, 15, "CurentStatus")
            FrReport.SsGridReport.SetText(3, 15, 10)
            FrReport.SsGridReport.SetText(2, 16, "SEX")
            FrReport.SsGridReport.SetText(3, 16, 5)
            FrReport.SsGridReport.SetText(2, 17, "CONTADD1")
            FrReport.SsGridReport.SetText(3, 17, 20)
            FrReport.SsGridReport.SetText(2, 18, "CONTADD2")
            FrReport.SsGridReport.SetText(3, 18, 20)
            FrReport.SsGridReport.SetText(2, 19, "CONTADD3")
            FrReport.SsGridReport.SetText(3, 19, 20)
            FrReport.SsGridReport.SetText(2, 20, "CONTCITY")
            FrReport.SsGridReport.SetText(3, 20, 10)
            FrReport.SsGridReport.SetText(2, 21, "CONTSTATE")
            FrReport.SsGridReport.SetText(3, 21, 10)
            FrReport.SsGridReport.SetText(2, 22, "CONTCOUNTRY")
            FrReport.SsGridReport.SetText(3, 22, 10)
            FrReport.SsGridReport.SetText(2, 23, "CONTPIN")
            FrReport.SsGridReport.SetText(3, 23, 10)
            FrReport.SsGridReport.SetText(2, 24, "CONTEMAIL")
            FrReport.SsGridReport.SetText(3, 24, 30)
            FrReport.SsGridReport.SetText(2, 25, "CONTPHONE1")
            FrReport.SsGridReport.SetText(3, 25, 10)
            FrReport.SsGridReport.SetText(2, 26, "CONTCELL")
            FrReport.SsGridReport.SetText(3, 26, 10)
            FrReport.SsGridReport.SetText(2, 27, "DOJ")
            FrReport.SsGridReport.SetText(3, 27, 8)
            FrReport.SsGridReport.SetText(2, 28, "MembershipTo")
            FrReport.SsGridReport.SetText(3, 28, 8)
            FrReport.SsGridReport.SetText(2, 29, "CrIditNumber")
            FrReport.SsGridReport.SetText(3, 29, 10)
            FrReport.SsGridReport.SetText(2, 30, "SecurityDeposit")
            FrReport.SsGridReport.SetText(3, 30, 8)
            FrReport.SsGridReport.SetText(2, 31, "EntranceFee")
            FrReport.SsGridReport.SetText(3, 31, 8)
            FrReport.SsGridReport.SetText(2, 32, "DevelopmentFee")
            FrReport.SsGridReport.SetText(3, 32, 8)
            FrReport.SsGridReport.SetText(2, 33, "LastArrivalInCal")
            FrReport.SsGridReport.SetText(3, 33, 8)
            FrReport.SsGridReport.SetText(2, 34, "PeriodOfStay_year")
            FrReport.SsGridReport.SetText(3, 34, 8)
            FrReport.SsGridReport.SetText(2, 35, "ApplNo")
            FrReport.SsGridReport.SetText(3, 35, 10)
            FrReport.SsGridReport.SetText(2, 36, "ApplDate")
            FrReport.SsGridReport.SetText(3, 36, 8)
            FrReport.SsGridReport.SetText(2, 37, "CompName")
            FrReport.SsGridReport.SetText(3, 37, 15)
            FrReport.SsGridReport.SetText(2, 38, "Designation")
            FrReport.SsGridReport.SetText(3, 38, 15)
            FrReport.SsGridReport.SetText(2, 39, "ProfessionInfo")
            FrReport.SsGridReport.SetText(3, 39, 15)
            FrReport.SsGridReport.SetText(2, 40, "BuiSnessinfo")
            FrReport.SsGridReport.SetText(3, 40, 15)
            FrReport.SsGridReport.SetText(2, 41, "BBanker")
            FrReport.SsGridReport.SetText(3, 41, 15)
            FrReport.SsGridReport.SetText(2, 42, "Client")
            FrReport.SsGridReport.SetText(3, 42, 15)
            FrReport.SsGridReport.SetText(2, 43, "Products")
            FrReport.SsGridReport.SetText(3, 43, 30)
            FrReport.SsGridReport.SetText(2, 44, "AgentsDealers")
            FrReport.SsGridReport.SetText(3, 44, 20)
            FrReport.SsGridReport.SetText(2, 45, "ESTDNo")
            FrReport.SsGridReport.SetText(3, 45, 8)
            FrReport.SsGridReport.SetText(2, 46, "NoOfEmp")
            FrReport.SsGridReport.SetText(3, 46, 8)
            FrReport.SsGridReport.SetText(2, 47, "Turnover")
            FrReport.SsGridReport.SetText(3, 47, 8)
            FrReport.SsGridReport.SetText(2, 48, "PROPOSER")
            FrReport.SsGridReport.SetText(3, 48, 15)
            FrReport.SsGridReport.SetText(2, 49, "SECONDER")
            FrReport.SsGridReport.SetText(3, 49, 15)
            FrReport.SsGridReport.SetText(2, 50, "PositionInChamber")
            FrReport.SsGridReport.SetText(3, 50, 30)
            FrReport.SsGridReport.SetText(2, 51, "Childstatus")
            FrReport.SsGridReport.SetText(3, 51, 10)
            FrReport.SsGridReport.SetText(2, 52, "Relativestatus")
            FrReport.SsGridReport.SetText(3, 52, 10)
            FrReport.SsGridReport.SetText(2, 53, "Clubstatus")
            FrReport.SsGridReport.SetText(3, 53, 10)
            FrReport.SsGridReport.SetText(2, 54, "Qulificationstatus")
            FrReport.SsGridReport.SetText(3, 54, 10)
            FrReport.SsGridReport.SetText(2, 55, "sportstatus")
            FrReport.SsGridReport.SetText(3, 55, 10)
            FrReport.SsGridReport.SetText(2, 56, "freeze")
            FrReport.SsGridReport.SetText(3, 56, 2)
            FrReport.Show()
        End If
    End Sub

    Function Check_List_View_MemberMaster()
        If Me.txt_MemberCode.Text = "" Then
            MsgBox("Member Code Column Can't be Blank", MsgBoxStyle.Information)
            Exit Function
        End If
        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim j, intPageLength As Int16
        Dim SSQL As String
        vOutfile = Mid("MEM" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0
        Dim rate, vat, ltotal, gtotal, temp As Double
        Dim lqty, gqty As Double
        Dim vcaption1 As String
        vcaption1 = ""

        I = 0
        ReportTitle = " CHECK LIST FOR MEMBER MASTER "
        PRINTREP = True
        Call PageHeader(80, PAGENO)
        ROWCOUNT = 7
        Filewrite.Write(Chr(15) & Chr(27) & "E")
        SSQL = "MEMBER ID: " & Mid(Trim(txt_MemberCode.Text & " => " & txt_FirstName.Text & " " & txt_MiddleName.Text & " " & txt_Surname.Text), 1, 70) & Space(70 - Len(Mid(Trim(Trim(Trim(txt_MemberCode.Text) & "--->" & txt_FirstName.Text & " " & txt_MiddleName.Text & " " & txt_Surname.Text)), 1, 70)))
        SSQL = SSQL & Space(10)
        SSQL = SSQL & "DATE : " & Mid(Trim(Now.Date), 1, 11) & Space(11 - Len(Mid(Trim(Now.Date), 1, 11)))
        Filewrite.WriteLine(SSQL)
        Filewrite.Write(Chr(27) & "F")
        ROWCOUNT = ROWCOUNT + 2

        Filewrite.WriteLine(StrDup(140, "-"))
        Filewrite.WriteLine("DATE OF BIRTH    : " & Mid(Trim(CStr(dtp_DateOfBirth.Text)), 1, 12) & Space(34 - Len(Mid(Trim(CStr(dtp_DateOfBirth.Text)), 1, 12))) & Space(6) & "DOJ            " & Space(7) & ": " & Mid(Trim(CStr(dtp_MembershipFrom.Text)), 1, 20) & Space(20 - Len(Mid(Trim(CStr(dtp_MembershipFrom.Text)), 1, 20))))
        If chk_Married.Checked = True Then
            If opt_Male.Checked = True Then
                Filewrite.WriteLine("MARRIED / SINGLE : " & Mid(Trim("MARRIED"), 1, 11) & Space(34 - Len(Mid(Trim("MARRIED"), 1, 11))) & Space(6) & "GENDER              : MALE")
            Else
                Filewrite.WriteLine("MARRIED / SINGLE : " & Mid(Trim("MARRIED"), 1, 11) & Space(34 - Len(Mid(Trim("MARRIED"), 1, 11))) & Space(6) & "GENDER              : FEMALE")
            End If
        Else
            If opt_Male.Checked = True Then
                Filewrite.WriteLine("MARRIED / SINGLE : " & Mid(Trim("SINGLE"), 1, 11) & Space(34 - Len(Mid(Trim("SINGLE"), 1, 11))) & Space(6) & "GENDER                : MALE")
            Else
                Filewrite.WriteLine("MARRIED / SINGLE : " & Mid(Trim("SINGLE"), 1, 11) & Space(34 - Len(Mid(Trim("SINGLE"), 1, 11))) & Space(6) & "GENDER                : FEMALE")
            End If
        End If
        Filewrite.WriteLine("CORPORATE CODE   : " & Mid(Trim(CStr(txt_CorporateCode.Text)), 1, 10) & Space(32 - Len(Mid(Trim(CStr(txt_CorporateCode.Text)), 1, 10))) & Space(8) & "CATEGORY CODE     " & Space(4) & ": " & Mid(Trim(CStr(txt_Category.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_Category.Text)), 1, 30))))
        Filewrite.WriteLine("BILLING BASIS    : " & Mid(Trim(CStr(cbo_BillingBasis.Text)), 1, 10) & Space(32 - Len(Mid(Trim(CStr(cbo_BillingBasis.Text)), 1, 10))) & Space(8) & "CURRENT STATUS    " & Space(4) & ": " & Mid(Trim(CStr(cbo_CurrentStatus.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(cbo_CurrentStatus.Text)), 1, 30))))
        Filewrite.WriteLine("PAN NO           : " & Mid(Trim(CStr(Txt_PANNo.Text)), 1, 10) & Space(32 - Len(Mid(Trim(CStr(Txt_PANNo.Text)), 1, 10))) & Space(8) & "BLOOD GROUP       " & Space(4) & ": " & Mid(Trim(CStr(Txt_BloodGroup.Text)), 1, 20) & Space(20 - Len(Mid(Trim(CStr(Txt_BloodGroup.Text)), 1, 20))))
        'If txt_CA_Address1.Text <> "" Or txt_CA_Address2.Text <> "" Or txt_CA_Address3.Text <> "" Or txt_CA_City.Text <> "" Or txt_CA_State.Text <> "" Or txt_CA_Country.Text <> "" Or txt_CA_Pin.Text <> "" Or txt_CA_Phone.Text <> "" Or txt_CA_Fax.Text <> "" Or txt_CA_Mobile.Text <> "" Then
        'Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("CONTACT ADDRESS DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("ADDRESS 1        : " & Mid(Trim(CStr(txt_CA_Address1.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_Address1.Text)), 1, 25))) & Space(8) & "ADDRESS 2  " & Space(4) & ": " & Mid(Trim(CStr(txt_CA_Address2.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_CA_Address2.Text)), 1, 30))))
        Filewrite.WriteLine("ADDRESS 3        : " & Mid(Trim(CStr(txt_CA_Address3.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_Address3.Text)), 1, 25))) & Space(8) & "CITY       " & Space(4) & ": " & Mid(Trim(CStr(txt_CA_City.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_CA_City.Text)), 1, 30))))
        Filewrite.WriteLine("STATE            : " & Mid(Trim(CStr(txt_CA_State.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_State.Text)), 1, 25))) & Space(8) & "COUNTRY    " & Space(4) & ": " & Mid(Trim(CStr(txt_CA_Country.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_CA_Country.Text)), 1, 30))))
        Filewrite.WriteLine("PIN CODE         : " & Mid(Trim(CStr(txt_CA_Pin.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_Pin.Text)), 1, 25))) & Space(8) & "E-MAIL     " & Space(4) & ": " & Mid(Trim(CStr(txt_CA_EMail.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_CA_EMail.Text)), 1, 30))))
        Filewrite.WriteLine("PHONE NO         : " & Mid(Trim(CStr(txt_CA_Phone.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_Phone.Text)), 1, 25))) & Space(8) & "MOBILE NO  " & Space(4) & ": " & Mid(Trim(CStr(txt_CA_Mobile.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_CA_Mobile.Text)), 1, 30))))
        Filewrite.WriteLine("FAX NO           : " & Mid(Trim(CStr(txt_CA_Fax.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_CA_Fax.Text)), 1, 25))))
        'End If
        'If txt_RA_Address1.Text <> "" Or txt_RA_Address2.Text <> "" Or txt_RA_Address3.Text <> "" Or txt_RA_City.Text <> "" Or txt_RA_State.Text <> "" Or txt_RA_Country.Text <> "" Or txt_RA_PinCode.Text <> "" Or txt_RA_PhoneNo.Text <> "" Then
        'Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("RESIDENT ADDRESS DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("ADDRESS 1        : " & Mid(Trim(CStr(txt_RA_Address1.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_RA_Address1.Text)), 1, 25))) & Space(8) & "ADDRESS 2  " & Space(4) & ": " & Mid(Trim(CStr(txt_RA_Address2.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_RA_Address2.Text)), 1, 30))))
        Filewrite.WriteLine("ADDRESS 3        : " & Mid(Trim(CStr(txt_RA_Address3.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_RA_Address3.Text)), 1, 25))) & Space(8) & "CITY       " & Space(4) & ": " & Mid(Trim(CStr(txt_RA_City.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_RA_City.Text)), 1, 30))))
        Filewrite.WriteLine("STATE            : " & Mid(Trim(CStr(txt_RA_State.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_RA_State.Text)), 1, 25))) & Space(8) & "COUNTRY    " & Space(4) & ": " & Mid(Trim(CStr(txt_RA_Country.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_RA_Country.Text)), 1, 30))))
        Filewrite.WriteLine("PIN CODE         : " & Mid(Trim(CStr(txt_RA_PinCode.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_RA_PinCode.Text)), 1, 25))) & Space(8) & "PHONE NO   " & Space(4) & ": " & Mid(Trim(CStr(txt_RA_PhoneNo.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_RA_PhoneNo.Text)), 1, 30))))
        'End If
        'If txt_BA_Address1.Text <> "" Or txt_BA_Address2.Text <> "" Or txt_BA_Address3.Text <> "" Or txt_BA_City.Text <> "" Or txt_BA_State.Text <> "" Or txt_BA_Country.Text <> "" Or txt_BA_PinCode.Text <> "" Or txt_BA_PhoneNo.Text <> "" Then
        Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("BUSINESS ADDRESS DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("ADDRESS 1        : " & Mid(Trim(CStr(txt_BA_Address1.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_BA_Address1.Text)), 1, 25))) & Space(8) & "ADDRESS 2  " & Space(4) & ": " & Mid(Trim(CStr(txt_BA_Address2.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_BA_Address2.Text)), 1, 30))))
        Filewrite.WriteLine("ADDRESS 3        : " & Mid(Trim(CStr(txt_BA_Address3.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_BA_Address3.Text)), 1, 25))) & Space(8) & "CITY       " & Space(4) & ": " & Mid(Trim(CStr(txt_BA_City.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_BA_City.Text)), 1, 30))))
        Filewrite.WriteLine("STATE            : " & Mid(Trim(CStr(txt_BA_State.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_BA_State.Text)), 1, 25))) & Space(8) & "COUNTRY    " & Space(4) & ": " & Mid(Trim(CStr(txt_BA_Country.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_BA_Country.Text)), 1, 30))))
        Filewrite.WriteLine("PIN CODE         : " & Mid(Trim(CStr(txt_BA_PinCode.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_BA_PinCode.Text)), 1, 25))) & Space(8) & "PHONE NO   " & Space(4) & ": " & Mid(Trim(CStr(txt_BA_PhoneNo.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_BA_PhoneNo.Text)), 1, 30))))
        'End If
        'If txt_PA_Address1.Text <> "" Or txt_PA_Address2.Text <> "" Or txt_PA_Address3.Text <> "" Or txt_PA_City.Text <> "" Or txt_PA_State.Text <> "" Or txt_PA_Country.Text <> "" Or txt_PA_PinCode.Text <> "" Or txt_PA_Phone.Text <> "" Then
        'Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("PERMANENT ADDRESS DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("ADDRESS 1        : " & Mid(Trim(CStr(txt_PA_Address1.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_PA_Address1.Text)), 1, 25))) & Space(8) & "ADDRESS 2  " & Space(4) & ": " & Mid(Trim(CStr(txt_PA_Address2.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_PA_Address2.Text)), 1, 30))))
        Filewrite.WriteLine("ADDRESS 3        : " & Mid(Trim(CStr(txt_PA_Address3.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_PA_Address3.Text)), 1, 25))) & Space(8) & "CITY       " & Space(4) & ": " & Mid(Trim(CStr(txt_PA_City.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_PA_City.Text)), 1, 30))))
        Filewrite.WriteLine("STATE            : " & Mid(Trim(CStr(txt_PA_State.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_PA_State.Text)), 1, 25))) & Space(8) & "COUNTRY    " & Space(4) & ": " & Mid(Trim(CStr(txt_PA_Country.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_PA_Country.Text)), 1, 30))))
        Filewrite.WriteLine("PIN CODE         : " & Mid(Trim(CStr(txt_PA_PinCode.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_PA_PinCode.Text)), 1, 25))) & Space(8) & "PHONE NO   " & Space(4) & ": " & Mid(Trim(CStr(txt_PA_Phone.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_PA_Phone.Text)), 1, 30))))
        'End If

        'Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("OTHER DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("APPLICATION NO.  : " & Mid(Trim(CStr(txt_ApplicationNo.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_ApplicationNo.Text)), 1, 25))) & Space(8) & "APPLICATION DATE " & Space(1) & ": " & Mid(Trim(CStr(dtp_DateApplication.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(dtp_DateApplication.Text)), 1, 30))))
        'Filewrite.WriteLine("PROPOSER CODE    : " & Mid(Trim(CStr(txt_ProposerCode.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_ProposerCode.Text)), 1, 25))) & Space(8) & "SECONDER CODE " & Space(4) & ": " & Mid(Trim(CStr(txt_SeconderCode.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_SeconderCode.Text)), 1, 30))))
        If SSgrid_Qualification.DataRowCnt > 0 Then
            Dim Qualification, Qual_Year As String
            With SSgrid_Qualification
                For I = 0 To SSgrid_Qualification.DataRowCnt - 1
                    .Row = I + 1
                    .Col = 1
                    Qualification = Trim(.Text)
                    .Col = 3
                    Qual_Year = Trim(.Text)
                    Filewrite.WriteLine("QUALIFICATION    : " & Mid(Trim(CStr(Qualification)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(Qualification)), 1, 25))) & Space(8) & "YEAR          " & Space(4) & ": " & Mid(Trim(CStr(Qual_Year)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(Qual_Year)), 1, 30))))
                Next
            End With
        End If
        'Filewrite.WriteLine()
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("DEPENDENT DETAILS")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("SPOUSE NAME      : " & Mid(Trim(CStr(txt_Spouse.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_Spouse.Text)), 1, 25))) & Space(8) & "SPOUSE DOB    " & Space(4) & ": " & Mid(Trim(CStr(txt_spouse_dob.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_spouse_dob.Text)), 1, 30))))
        If ssgrid.DataRowCnt > 0 Then
            Dim Child_Name, Child_Gender As String
            Dim Child_DOB As String
            With ssgrid
                For I = 0 To ssgrid.DataRowCnt - 1
                    .Row = I + 1
                    .Col = 1
                    Child_Name = Trim(.Text)
                    .Col = 2
                    Child_DOB = Trim(.Text)
                    .Col = 3
                    Child_Gender = Trim(.Text)
                    Filewrite.WriteLine("CHILDREN NAME    : " & Mid(Trim(CStr(Child_Name)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(Child_Name)), 1, 25))) & Space(8) & "CHILDREN DOB  " & Space(4) & ": " & Mid(Trim(CStr(Child_DOB)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(Child_DOB)), 1, 30))))
                Next
            End With
        End If

        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("SPORTS DETAILS")
        Filewrite.Write(Chr(27) & "F")
        If ssgrid.DataRowCnt > 0 Then
            Dim Sport_Interest, Sport_Name As String
            With SSgrid_Sports
                For I = 0 To SSgrid_Sports.DataRowCnt - 1
                    .Row = I + 1
                    .Col = 1
                    Sport_Interest = Trim(.Text)
                    .Col = 2
                    Sport_Name = Trim(.Text)
                    Filewrite.WriteLine("SPORTS INTEREST  : " & Mid(Trim(CStr(Sport_Interest)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(Sport_Interest)), 1, 25))) & Space(8) & "SPORTS NAME   " & Space(4) & ": " & Mid(Trim(CStr(Sport_Name)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(Sport_Name)), 1, 30))))
                Next
            End With
        End If
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("PROPOSER DETAILS")
        Filewrite.Write(Chr(27) & "F")
        'Filewrite.WriteLine("SPOUSE NAME      : " & Mid(Trim(CStr(txt_Spouse.Text)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(txt_Spouse.Text)), 1, 25))) & Space(8) & "SPOUSE DOB    " & Space(4) & ": " & Mid(Trim(CStr(txt_spouse_dob.Text)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(txt_spouse_dob.Text)), 1, 30))))
        If SSgrid_Proposal.DataRowCnt > 0 Then
            Dim Pro_Code, Pro_Name As String
            'Dim Child_DOB As String
            With SSgrid_Proposal
                For I = 0 To SSgrid_Proposal.DataRowCnt - 1
                    .Row = I + 1
                    .Col = 1
                    Pro_Code = Trim(.Text)
                    .Col = 2
                    Pro_Name = Trim(.Text)
                    Filewrite.WriteLine("PROPOSER CODE    : " & Mid(Trim(CStr(Pro_Code)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(Pro_Code)), 1, 25))) & Space(8) & "PROPOSER NAME  " & Space(4) & ": " & Mid(Trim(CStr(Pro_Name)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(Pro_Name)), 1, 30))))
                Next
            End With
        End If
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("SECONDER DETAILS")
        Filewrite.Write(Chr(27) & "F")
        If SSgrid_Seconder.DataRowCnt > 0 Then
            Dim Sec_Code, Sec_Name As String
            With SSgrid_Seconder
                For I = 0 To SSgrid_Seconder.DataRowCnt - 1
                    .Row = I + 1
                    .Col = 1
                    Sec_Code = Trim(.Text)
                    .Col = 2
                    Sec_Name = Trim(.Text)
                    Filewrite.WriteLine("SECONDER CODE    : " & Mid(Trim(CStr(Sec_Code)), 1, 25) & Space(32 - Len(Mid(Trim(CStr(Sec_Code)), 1, 25))) & Space(8) & "SECONDER NAME  " & Space(4) & ": " & Mid(Trim(CStr(Sec_Name)), 1, 30) & Space(30 - Len(Mid(Trim(CStr(Sec_Name)), 1, 30))))
                Next
            End With
        End If

        PRINTREP = True
        Call PageFoter(80)
        Filewrite.Write(Chr(18))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(vOutfile)
        End If
    End Function
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Dim SqlString As String
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Delete.Text, 1, 1) = "F" Then
            If MsgBox("DO YOU WANT TO FREEZE THE MEMBER.......", MsgBoxStyle.OKCancel + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton2, "KOT") = MsgBoxResult.OK Then
                SqlString = "UPDATE  membermaster "
                SqlString = SqlString & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                SqlString = SqlString & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
                gconnection.dataOperation(3, SqlString, "membermaster")
                SqlString = "UPDATE ACCOUNTSSUBLEDGERMASTER SET FREEZEFLAG = 'Y' WHERE SLCODE = '" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(3, SqlString, "ACCOUNTSSUBLEDGERMASTER")
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        Else
            If MsgBox("DO YOU WANT TO UNFREEZE THE MEMBER.......", MsgBoxStyle.OKCancel + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1, "KOT") = MsgBoxResult.OK Then
                SqlString = "UPDATE  membermaster "
                SqlString = SqlString & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                SqlString = SqlString & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
                gconnection.dataOperation(4, SqlString, "membermaster")
                SqlString = "UPDATE ACCOUNTSSUBLEDGERMASTER SET FREEZEFLAG = 'N' WHERE SLCODE = '" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(4, SqlString, "ACCOUNTSSUBLEDGERMASTER")
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        End If
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Call MEMBERSTATUS()
        clearform(Me)
        Me.cmd_CategoryHelp.Visible = True ' venugopal for SVS club-30-mar-2010
        Me.Lst_BillHead.Visible = False
        Me.opt_Female.Checked = False
        Me.opt_Male.Checked = False
        Me.grp_ChildrenDetails.Visible = False
        Me.Grp_MemQualification.Visible = False
        chk_AppliedMembership.Checked = False
        chk_AppliedMembership.BackColor = Color.Silver
        chk_Billhead.Checked = False
        chk_Billhead.BackColor = Color.Silver
        chk_Married.Checked = False
        chk_Married.BackColor = Color.Silver
        chk_corporate.Checked = False
        LStatus.Text = ""
        TXT_SPOUSE_MOBILE.Text = ""
        Txt_PANNo.Text = ""
        Txt_BloodGroup.Text = ""
        Txt_CreditLimit.Text = ""
        txt_Spouse.Text = ""
        txt_spouse_dob.Text = ""
        dtp_LastArrivalInCalcutta.Text = "01/Jan/1900"
        Btn_LastArr_c_FUN()
        chk_corporate.BackColor = Color.Silver
        chk_RA_Copy.Checked = False
        chk_RA_Copy.BackColor = Color.Silver
        chk_BA_Copy.Checked = False
        chk_BA_Copy.BackColor = Color.Silver
        chk_PA_Copy.Checked = False
        chk_PA_Copy.BackColor = Color.Silver
        chk_PreviouslyPr.Checked = False
        chk_PreviouslyPr.BackColor = Color.Silver
        chk_Elected.Checked = False
        chk_Elected.BackColor = Color.Silver
        chk_Childrendetail.Checked = False
        chk_Childrendetail.BackColor = Color.Silver
        chk_Relativesdetails.Checked = False
        chk_Relativesdetails.BackColor = Color.Silver
        chk_Memberofclub.Checked = False
        chk_Memberofclub.BackColor = Color.Silver
        chk_MemberQulification.Checked = False
        chk_MemberQulification.BackColor = Color.Silver
        chk_Sports.Checked = False
        chk_Sports.BackColor = Color.Silver
        chk_EntranceFee.Checked = False
        chk_EntranceFee.BackColor = Color.Silver
        chk_Referencedetails.Checked = False
        chk_Referencedetails.BackColor = Color.Silver
        Chk_Prop.Checked = False
        Chk_Prop.BackColor = Color.Silver
        Chk_Sec.Checked = False
        Chk_Sec.BackColor = Color.Silver
        PHOTO.Checked = False
        SIGNATURE.Checked = False
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.txt_MemberCode.ReadOnly = False
        Me.txt_MemberCode.Focus()
        Me.cmd_AddNew.Text = "Add New[F5]"
        Me.cmd_Delete.Text = "Freeze[F7]"
        ssgrid.ClearRange(0, 0, -1, -1, True)
        SSgrid_Entrancefee.ClearRange(0, 0, -1, -1, True)
        SSgrid_MemberClub.ClearRange(0, 0, -1, -1, True)
        SSgrid_Qualification.ClearRange(0, 0, -1, -1, True)
        ssgrid_Referencedetails.ClearRange(0, 0, -1, -1, True)
        SSgrid_Relatives.ClearRange(0, 0, -1, -1, True)
        SSgrid_Sports.ClearRange(0, 0, -1, -1, True)
        ssgrid_currentstatus.ClearRange(0, 0, -1, -1, True)
        SSgrid_Proposal.ClearRange(0, 0, -1, -1, True)
        SSgrid_Seconder.ClearRange(0, 0, -1, -1, True)
        Btn_BIRTH1.Text = "E"
        Btn_Membershipfrom_c.Text = "E"
        Btn_MembershipTo_c.Text = "E"
        Btn_spousedob_c.Text = "E"
        Btn_LastArr_c.Text = "E"
        Btn_DateOf_c.Text = "E"
        btn_ClearEstdDT.Text = "E"
        btn_Appdt_c.Text = "E"
        CMB_BRITH.Visible = True
        txt_GDRLocker.Text = ""
        txt_fmcode.Text = ""
        cmb_Membershipfrom_c.Visible = True
        cmb_MembershipTo_c.Visible = True
        cmb_spouse_dob.Visible = True
        cmb_LastArr_c.Visible = True
        cmb_DateOf_c.Visible = True
        cmb_Appdt_c.Visible = True
        combo_HideDateESTD.Visible = True
        cmb_DateOf_c.Visible = True
        dtp_MembershipFrom.Visible = False
        dtp_MembershipTo.Visible = False
        dtp_LastArrivalInCalcutta.Visible = False
        dtp_DateApplication.Visible = False
        dtp_ESTDdate.Visible = False
        dtp_DateProposal.Visible = False
        txt_spouse_dob.Visible = False
        dtp_DateOfBirth.Visible = False

        ssgrid.SetActiveCell(1, 1)
        ssgrid_currentstatus.SetActiveCell(1, 1)
        SSgrid_Entrancefee.SetActiveCell(1, 1)
        SSgrid_MemberClub.SetActiveCell(1, 1)
        SSgrid_Proposal.SetActiveCell(1, 1)
        SSgrid_Qualification.SetActiveCell(1, 1)
        SSgrid_Relatives.SetActiveCell(1, 1)
        SSgrid_Seconder.SetActiveCell(1, 1)
        SSgrid_Sports.SetActiveCell(1, 1)

        txt_spouse_dob.Text = "01/JAN/1900"
        dtp_DateOfBirth.Value = "01/JAN/1900"
        dtp_MembershipFrom.Value = "01/JAN/1900"
        dtp_MembershipTo.Value = "01/JAN/1900"

        dtp_LastArrivalInCalcutta.Value = "01/JAN/1900"
        dtp_DateApplication.Value = "01/JAN/1900"
        dtp_ESTDdate.Value = "01/JAN/1900"
        dtp_DateProposal.Value = "01/JAN/1900"
        Txt_CreditLimit.Text = Format(Val(Txt_CreditLimit.Text), "1.00")
        'memberphoto.Image = New Bitmap(gPhotoPath & "\Photos\Image.Jpg")
        memberphoto.Image = Nothing
        membersignature.Image = Nothing
        'membersignature.Image = New Bitmap(AppPath & "\Photos\Image1.Jpg")
    End Sub
    Public Sub MEMBERSTATUS()
        Return
        Dim SQLSTRING As String
        SQLSTRING = " EXEC MEMBERSTATUS_CHECKING "
        gconnection.ExcuteStoreProcedure(SQLSTRING)
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Call MEMBERSTATUS()
        Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False
        fullname = Trim(txt_FirstName.Text) & " " & txt_MiddleName.Text & " " & Trim(txt_Surname.Text)

        'If Trim(txt_Surname.Text) <> "" And Trim(txt_FirstName.Text) <> "" And Trim(txt_MiddleName.Text) <> "" Then
        '    fullname = Trim(txt_Surname.Text) & " " & txt_FirstName.Text & " " & Trim(txt_MiddleName.Text)
        'ElseIf Trim(txt_Surname.Text) = "" And Trim(txt_FirstName.Text) <> "" And Trim(txt_MiddleName.Text) <> "" Then
        '    fullname = txt_FirstName.Text & " " & Trim(txt_MiddleName.Text)
        'ElseIf Trim(txt_Surname.Text) <> "" And Trim(txt_FirstName.Text) <> "" And Trim(txt_MiddleName.Text) = "" Then
        '    fullname = Trim(txt_Surname.Text) & " " & txt_FirstName.Text
        'ElseIf Trim(txt_Surname.Text) <> "" And Trim(txt_FirstName.Text) = "" And Trim(txt_MiddleName.Text) <> "" Then
        '    fullname = Trim(txt_Surname.Text) & " " & Trim(txt_MiddleName.Text)
        'ElseIf Trim(txt_Surname.Text) = "" And Trim(txt_FirstName.Text) <> "" And Trim(txt_MiddleName.Text) = "" Then
        '    fullname = Trim(txt_FirstName.Text)
        'ElseIf Trim(txt_Surname.Text) <> "" And Trim(txt_FirstName.Text) = "" And Trim(txt_MiddleName.Text) = "" Then
        '    fullname = Trim(txt_Surname.Text)
        'ElseIf Trim(txt_Surname.Text) = "" And Trim(txt_FirstName.Text) = "" And Trim(txt_MiddleName.Text) <> "" Then
        '    fullname = Trim(txt_MiddleName.Text)
        'Else
        '    fullname = Trim(txt_Surname.Text) & " " & txt_FirstName.Text & " " & Trim(txt_MiddleName.Text)
        'End If


        If chk_PreviouslyPr.Checked = True Then
            PreviouslyProposedst = "Y"
        ElseIf chk_PreviouslyPr.Checked = False Then
            PreviouslyProposedst = "N"
        End If
        If chk_Elected.Checked = True Then
            electedst = "Y"
        ElseIf chk_Elected.Checked = False Then
            electedst = "N"
        End If
        If chk_Married.Checked = True Then
            marriedst = "Y"
        ElseIf chk_Married.Checked = False Then
            marriedst = "N"
        End If
        If opt_Male.Checked = True Then
            sexst = "M"
        ElseIf opt_Female.Checked = True Then
            sexst = "F"
        End If
        If chk_AppliedMembership.Checked = True Then
            AppliedButmembershipst = "Y"
        ElseIf chk_AppliedMembership.Checked = False Then
            AppliedButmembershipst = "N"
        End If
        If chk_Billhead.Checked = True Then
            billheadst = "Y"
        ElseIf chk_Billhead.Checked = False Then
            billheadst = "N"
        End If
        If chk_corporate.Checked = True Then
            corporatest = "Y"
        ElseIf chk_corporate.Checked = False Then
            corporatest = "N"
        End If
        If chk_Childrendetail.Checked = True Then
            childrendetailst = "Y"
        ElseIf chk_Childrendetail.Checked = False Then
            childrendetailst = "N"
        End If
        If chk_Memberofclub.Checked = True Then
            memberclubst = "Y"
        ElseIf chk_Memberofclub.Checked = False Then
            memberclubst = "N"
        End If
        If chk_MemberQulification.Checked = True Then
            memberqulist = "Y"
        ElseIf chk_MemberQulification.Checked = False Then
            memberqulist = "N"
        End If
        If chk_Relativesdetails.Checked = True Then
            relativedetailst = "Y"
        ElseIf chk_Relativesdetails.Checked = False Then
            relativedetailst = "N"
        End If
        If chk_Sports.Checked = True Then
            sportintrestst = "Y"
        ElseIf chk_Sports.Checked = False Then
            sportintrestst = "N"
        End If
        If chk_Referencedetails.Checked = True Then
            refedetailst = "Y"
        ElseIf chk_Referencedetails.Checked = False Then
            refedetailst = "N"
        End If
        If chk_EntranceFee.Checked = True Then
            entrancefeest = "Y"
        ElseIf chk_EntranceFee.Checked = False Then
            entrancefeest = "N"
        End If

        '''********** Check MemberCode Code is blank
        If txt_MemberCode.Text = "" Then
            MessageBox.Show(" Member Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''********** Check First Name is blank
        If txt_FirstName.Text = "" Then
            MessageBox.Show(" First Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_FirstName.Focus()
            Exit Sub
        End If
        '''********** Check Surname Name is blank
        'If txt_Surname.Text = "" Then
        '    MessageBox.Show(" Surname field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_Surname.Focus()
        '    Exit Sub
        'End If
        '''********** Check CurrentStatus Name is blank
        If cbo_CurrentStatus.Text = "" Then
            MessageBox.Show(" CurrentStatus field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_CurrentStatus.Focus()
            Exit Sub
        End If
        '''********** Check EntranceFee Name is blank
        If Val(txt_EntranceFee.Text) = 0 Then
            'MessageBox.Show(" EntranceFee field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'txt_EntranceFee.Focus()
            'Exit Sub
        End If
        '''********** Check DevelopmentFee Name is blank
        'If Val(txt_DevelopmentFee.Text) = 0 Then
        '    MessageBox.Show(" DevelopmentFee field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_DevelopmentFee.Focus()
        '    Exit Sub
        'End If
        '''********** Check ApplicationNo Name is blank
        'If txt_ApplicationNo.Text = "" Then
        '    MessageBox.Show(" ApplicationNo field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_ApplicationNo.Focus()
        '    Exit Sub
        'End If
        '''********** Check ProposerCode Name is blank
        'If txt_ProposerCode.Text = "" Then
        '    MessageBox.Show(" ProposerCode field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_ProposerCode.Focus()
        '    Exit Sub
        'End If
        '''********** Check SeconderCode Name is blank
        'If txt_SeconderCode.Text = "" Then
        '    MessageBox.Show(" SeconderCode field can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_SeconderCode.Focus()
        '    Exit Sub
        'End If
        ''*********** Check Email Id is blank
        If txt_CA_EMail.Text <> "" Then
            emailst = getEmail(txt_CA_EMail)
            If emailst <> "T" Then
                Exit Sub
            End If
        End If
        '''************************ Date of Birth Can't be equal to today's date
        'If Date.Compare(dtp_DateOfBirth.Value, Date.Today) = 1 Then
        '    MessageBox.Show("Select a valid date for DateOfBirth", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    dtp_DateOfBirth.Focus()
        '    Exit Sub
        'End If
        '''************************ Date of birth can't less then 18year
        'If DateDiff(DateInterval.Year, Date.Today, dtp_DateOfBirth.Value) >= -18 Then
        '    MessageBox.Show("Select a valid date for DateOfBirth ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    dtp_DateOfBirth.Focus()
        '    Exit Sub
        'End If

        '''**************************** CorporateCode can't be blank
        'If chk_corporate.Checked = True Then
        '    If txt_CorporateCode.Text = "" Then
        '        MessageBox.Show("Corporate code can't be blank ", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        txt_CorporateCode.Focus()
        '        Exit Sub
        '    End If
        'End If
        '''***************************** CategoryCode can't be blank
        If Trim(txt_Category.Text) = "" Then
            MessageBox.Show("Category Code can't be blank ", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_Category.Focus()
            Exit Sub
        End If
        '''****************************** Billing basis can't be blank
        If Trim(cbo_BillingBasis.Text) = "" Then
            MessageBox.Show("Billing basis can't be blank ", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbo_BillingBasis.Focus()
            Exit Sub
        End If
        '''******************************** Contact address can't be blank
        'If txt_CA_Address1.Text = "" Then
        '    MessageBox.Show("Address1 field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Address1.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_Address2.Text = "" Then
        '    MessageBox.Show("Address2 field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Address2.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_Address3.Text = "" Then
        '    MessageBox.Show("Address3 field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Address3.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_City.Text = "" Then
        '    MessageBox.Show("City field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_City.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_State.Text = "" Then
        '    MessageBox.Show("State field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_State.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_Country.Text = "" Then
        '    MessageBox.Show("Country field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Country.Focus()
        '    Exit Sub
        'End If
        'If Val(txt_CA_Pin.Text) = 0 Then
        '    MessageBox.Show("Pincode field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Pin.Focus()
        '    Exit Sub
        'End If
        'If txt_CA_EMail.Text = "" Then
        '    MessageBox.Show("Email field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_EMail.Focus()
        '    Exit Sub
        'End If
        'If Val(txt_CA_Phone.Text) = 0 Then
        '    MessageBox.Show("Phone field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Phone.Focus()
        '    Exit Sub
        'End If
        'If Val(txt_CA_Mobile.Text) = 0 Then
        '    MessageBox.Show("Mobile field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Mobile.Focus()
        '    Exit Sub
        'End If
        'If Val(txt_CA_Fax.Text) = 0 Then
        '    MessageBox.Show("Fax field can't be blank ", "Club ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_CA_Fax.Focus()
        '    Exit Sub
        'End If
        '''************ 
        boolchk = True
    End Sub

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        Try
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_MemberCode.Select()
                txt_MemberCode_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
            cmd_AddNew.Text = "Update[F5]"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cmd_CorporateCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CorporateCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(CMCorporateCode,'') AS CMCorporateCode,ISNULL(CMCorporateName,'') AS CMCorporateName FROM CorporateMaster"
        M_WhereCondition = " "
        vform.Field = "CMCorporateCode,CMCorporateName"
        vform.vFormatstring = "  Corporate Code  | Corporate Name                           "
        vform.vCaption = "Corporate Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_CorporateCode.Text = Trim(vform.keyfield & "")
            txt_CorporateCode.Select()
            'txt_CorporateCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_CategoryHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CategoryHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(Membertype,'') AS Membertype,ISNULL(TypeDesc,'') AS TypeDesc FROM membertype"
        M_WhereCondition = " "
        vform.Field = "Membertype,TypeDesc"
        vform.vFormatstring = "  Category Code  | Category Name                           "
        vform.vCaption = "Category Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Category.Text = Trim(vform.keyfield & "")
            txt_Category.Select()
            'Call txt_Category_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_ProposerCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ProposerCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Proposer Code  | Proposer Name                           "
        vform.vCaption = "Proposer Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ProposerCode.Text = Trim(vform.keyfield & "")
            txt_ProposedName.Text = Trim(vform.keyfield1)
            txt_SeconderCode.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_SeconderCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SeconderCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Seconder Code  | Seconder Name                           "
        vform.vCaption = "Seconder Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SeconderCode.Text = Trim(vform.keyfield & "")
            txt_SeconderName.Text = Trim(vform.keyfield1)
            txt_PositionHeld.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_TurnOver_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TurnOver.LostFocus
        txt_TurnOver.Text = Format(Val(txt_TurnOver.Text), "0.00")
    End Sub

    Private Sub txt_DevelopmentFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DevelopmentFee.LostFocus
        txt_DevelopmentFee.Text = Format(Val(txt_DevelopmentFee.Text), "0.00")
    End Sub

    Private Sub txt_EntranceFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_EntranceFee.LostFocus
        txt_EntranceFee.Text = Format(Val(txt_EntranceFee.Text), "0.00")
    End Sub

    Private Sub txt_SecurityDeposit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SecurityDeposit.LostFocus
        txt_SecurityDeposit.Text = Format(Val(txt_SecurityDeposit.Text), "0.00")
    End Sub

    Private Sub chk_RA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_RA_Copy.CheckedChanged
        If chk_RA_Copy.Checked = True Then
            txt_RA_Address1.Text = txt_CA_Address1.Text
            txt_RA_Address2.Text = txt_CA_Address2.Text
            txt_RA_Address3.Text = txt_CA_Address3.Text
            txt_RA_City.Text = txt_CA_City.Text
            txt_RA_State.Text = txt_CA_State.Text
            txt_RA_Country.Text = txt_CA_Country.Text
            txt_RA_PinCode.Text = txt_CA_Pin.Text
            txt_RA_PhoneNo.Text = txt_CA_Phone.Text
            'chk_RA_Copy.Checked = FALSE
            Chk_BA_RA_Copy.Checked = False
            Chk_PA_RA_Copy.Checked = False

        Else
            txt_RA_Address1.Text = ""
            txt_RA_Address2.Text = ""
            txt_RA_Address3.Text = ""
            txt_RA_City.Text = ""
            txt_RA_State.Text = ""
            txt_RA_Country.Text = ""
            txt_RA_PinCode.Text = ""
            txt_RA_PhoneNo.Text = ""
            txt_RA_Address1.Focus()
        End If

    End Sub

    Private Sub chk_BA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_BA_Copy.CheckedChanged
        If chk_BA_Copy.Checked = True Then
            txt_BA_Address1.Text = txt_CA_Address1.Text
            txt_BA_Address2.Text = txt_CA_Address2.Text
            txt_BA_Address3.Text = txt_CA_Address3.Text
            txt_BA_City.Text = txt_CA_City.Text
            txt_BA_State.Text = txt_CA_State.Text
            txt_BA_Country.Text = txt_CA_Country.Text
            txt_BA_PinCode.Text = txt_CA_Pin.Text
            txt_BA_PhoneNo.Text = txt_CA_Phone.Text
            'chk_BA_Copy.Checked = False
            Chk_RA_BA_Copy.Checked = False
            Chk_PA_BA_Copy.Checked = False
        Else
            txt_BA_Address1.Text = ""
            txt_BA_Address2.Text = ""
            txt_BA_Address3.Text = ""
            txt_BA_City.Text = ""
            txt_BA_State.Text = ""
            txt_BA_Country.Text = ""
            txt_BA_PinCode.Text = ""
            txt_BA_PhoneNo.Text = ""
            txt_BA_Address1.Focus()
        End If

    End Sub

    Private Sub chk_PA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PA_Copy.CheckedChanged
        If chk_PA_Copy.Checked = True Then
            txt_PA_Address1.Text = txt_CA_Address1.Text
            txt_PA_Address2.Text = txt_CA_Address2.Text
            txt_PA_Address3.Text = txt_CA_Address3.Text
            txt_PA_City.Text = txt_CA_City.Text
            txt_PA_State.Text = txt_CA_State.Text
            txt_PA_Country.Text = txt_CA_Country.Text
            txt_PA_PinCode.Text = txt_CA_Pin.Text
            txt_PA_Phone.Text = txt_CA_Phone.Text
            'chk_PA_Copy.Checked = False
            Chk_BA_PA_Copy.Checked = False
            Chk_RA_PA_Copy.Checked = False
        Else
            txt_PA_Address1.Text = ""
            txt_PA_Address2.Text = ""
            txt_PA_Address3.Text = ""
            txt_PA_City.Text = ""
            txt_PA_State.Text = ""
            txt_PA_Country.Text = ""
            txt_PA_PinCode.Text = ""
            txt_PA_Phone.Text = ""
            txt_PA_Address1.Focus()
        End If
    End Sub
    Private Sub chk_Childrendetail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Childrendetail.CheckedChanged

        If Me.chk_Childrendetail.Checked = True Then
            Me.grp_ChildrenDetails.BringToFront()
            Me.grp_ChildrenDetails.Visible = True
            Me.grp_ChildrenDetails.Top = 72
            Me.grp_ChildrenDetails.Left = 50
            ssgrid.Focus()
        Else
            Me.grp_ChildrenDetails.Visible = False
            Me.grp_ChildrenDetails.SendToBack()
        End If
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
    Private Sub cmd_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ChildrenOk.Click
        grp_ChildrenDetails.Visible = False
        Me.chk_Childrendetail.Checked = True
        If Me.ssgrid.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical, gCompanyAddress(0))
            Me.chk_Childrendetail.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(ssgrid, "ChildrenDetails")
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
                        sql = sql & ",''"
                    Else
                        sql = sql & ",'" & dr.Item(j) & "'"
                    End If
                End If
            Next j
        Next i
        Return sql
    End Function

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ChildrenCancel.Click
        Me.chk_Childrendetail.Checked = False
        Me.grp_ChildrenDetails.Visible = False
        If gdataset.Tables.Contains("ChildrenDetails") Then
            gdataset.Tables.Remove("ChildrenDetails")
        End If
        chk_Childrendetail.Focus()
    End Sub
    Private Sub Cmd_Mq_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_MemberQuliOk.Click '
        Grp_MemQualification.Visible = False
        Me.chk_MemberQulification.Checked = True
        If Me.SSgrid_Qualification.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_MemberQulification.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Qualification, "MemberQualification")
        End If
    End Sub
    Private Sub Cmd_Can_Mq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_MemberQuliCancel.Click
        Me.chk_MemberQulification.Checked = False
        Me.Grp_MemQualification.Visible = False
        If gdataset.Tables.Contains("MemberQualification") Then
            gdataset.Tables.Remove("MemberQualification")
        End If
        chk_MemberQulification.Focus()
    End Sub
    Private Sub chk_MemberQulification_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_MemberQulification.CheckedChanged
        If chk_MemberQulification.Checked = True Then
            Me.Grp_MemQualification.BringToFront()
            Me.Grp_MemQualification.Visible = True
            Me.Grp_MemQualification.Top = 72
            Me.Grp_MemQualification.Left = 50
            SSgrid_Qualification.Focus()
        Else
            Me.Grp_MemQualification.Visible = False
            Me.Grp_MemQualification.SendToBack()
        End If
    End Sub
    Public Sub FillBillinghead()
        gconnection.getDataSet("Select subsdesc From SubscriptionMast Where Isnull(SubscriptionYN,'')<> 'Y'", "SubscriptionMAst")
        Dim i As Integer
        For i = 0 To gdataset.Tables("SubscriptionMAst").Rows.Count - 1
            Me.Lst_BillHead.Items.Add(gdataset.Tables("SubscriptionMast").Rows(i).Item(0))
        Next i
    End Sub

    Private Sub chk_Billhead_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Billhead.CheckedChanged
        If Me.chk_Billhead.Checked = True Then
            ' Me.Lst_BillHead.Visible = True
            'Me.lbl_bill.Visible = True
        Else
            'Me.Lst_BillHead.Visible = False
            'Me.lbl_bill.Visible = False
        End If
    End Sub

    Private Sub chk_corporate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_corporate.CheckedChanged
        If chk_corporate.Checked = True Then
            txt_CorporateCode.BackColor = Color.AntiqueWhite
            txt_CorporateCode.Enabled = True
        ElseIf chk_corporate.Checked = False Then
            txt_CorporateCode.BackColor = Color.White
            txt_CorporateCode.Enabled = False
        End If
    End Sub
    Public Function txt_Category_Validated_fun()
        Dim Cattable As New DataTable
        Dim strSQL As String
        strSQL = " SELECT ISNULL(MemberType,'') AS MemberType,ISNULL(TypeDesc,'') AS TypeDesc FROM MemberType WHERE MemberType='" & Me.txt_Category.Text & "'"
        Cattable = gconnection.GetValues(strSQL)
        If Cattable.Rows.Count > 0 Then
            Me.txt_Category.Text = Cattable.Rows(0).Item(0) & " - " & Cattable.Rows(0).Item(1)
            Cat_Code_val = Cattable.Rows(0).Item(0)
        Else
            'MessageBox.Show("Plz enter a valid Category code ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_Category.Text = ""
            'txt_Category.Focus()
        End If
    End Function
    Private Sub txt_Category_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Category.Validated
        txt_Category_Validated_fun()
    End Sub
    Public Function txt_CorporateCode_Validated()
        Dim Coptable As New DataTable
        Dim strSQL As String
        strSQL = " SELECT ISNULL(CMcorporateCode,'') AS CMcorporateCode,ISNULL(CMcorporatename,'') AS CMcorporatename FROM CorporateMaster WHERE CMCorporateCode='" & Me.txt_CorporateCode.Text & "'"
        Coptable = gconnection.GetValues(strSQL)
        If Coptable.Rows.Count > 0 Then
            Me.txt_CorporateCode.Text = Coptable.Rows(0).Item(0) & " - " & Coptable.Rows(0).Item(1)
            Corp_code_val = Coptable.Rows(0).Item(0)
        Else
            ''MessageBox.Show("Plz enter a valid Corporate code ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_CorporateCode.Text = ""
            Corp_code_val = ""
            ' txt_CorporateCode.Focus()
        End If
    End Function
    Private Sub txt_CorporateCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CorporateCode.Validated
        txt_CorporateCode_Validated()

    End Sub

    Private Sub cmd_ClubCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ClubCancel.Click
        Me.chk_Memberofclub.Checked = False
        Me.grp_MemberClub.Visible = False
        If gdataset.Tables.Contains("memberofclub") Then
            gdataset.Tables.Remove("memberofclub")
        End If
        chk_Memberofclub.Focus()
    End Sub

    Private Sub cmd_ClubOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ClubOk.Click
        grp_MemberClub.Visible = False
        Me.chk_Memberofclub.Checked = True
        If Me.SSgrid_MemberClub.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_Memberofclub.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_MemberClub, "memberofclub")
        End If
    End Sub

    Private Sub cmd_SportsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SportsCancel.Click
        Me.chk_Sports.Checked = False
        Me.grp_SportsIntrested.Visible = False
        If gdataset.Tables.Contains("sports") Then
            gdataset.Tables.Remove("sports")
        End If
        chk_Sports.Focus()
    End Sub

    Private Sub cmd_SportsOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SportsOk.Click
        grp_SportsIntrested.Visible = False
        Me.chk_Sports.Checked = True
        If Me.SSgrid_Sports.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_Sports.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Sports, "sports")
        End If
    End Sub

    Private Sub cmd_RelativeCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_RelativeCancel.Click
        Me.chk_Relativesdetails.Checked = False
        Me.grp_Relativedetails.Visible = False
        If gdataset.Tables.Contains("Relativesdetails") Then
            gdataset.Tables.Remove("Relativesdetails")
        End If
        chk_Relativesdetails.Focus()
    End Sub

    Private Sub cmd_RelativesOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_RelativesOk.Click
        grp_Relativedetails.Visible = False
        Me.chk_Relativesdetails.Checked = True
        If Me.SSgrid_Relatives.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_Relativesdetails.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Relatives, "Relativesdetails")
        End If
    End Sub

    Private Sub chk_Memberofclub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Memberofclub.CheckedChanged
        If chk_Memberofclub.Checked = True Then
            Me.grp_MemberClub.BringToFront()
            Me.grp_MemberClub.Visible = True
            Me.grp_MemberClub.Top = 72
            Me.grp_MemberClub.Left = 50
            SSgrid_MemberClub.Focus()
        ElseIf chk_Memberofclub.Checked = False Then
            Me.grp_MemberClub.Visible = False
            Me.grp_MemberClub.SendToBack()
        End If
    End Sub

    Private Sub chk_Sports_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Sports.CheckedChanged
        If chk_Sports.Checked = True Then
            Me.grp_SportsIntrested.BringToFront()
            Me.grp_SportsIntrested.Visible = True
            Me.grp_SportsIntrested.Top = 72
            Me.grp_SportsIntrested.Left = 50
            SSgrid_Sports.Focus()
        ElseIf chk_Sports.Checked = False Then
            Me.grp_SportsIntrested.Visible = False
            Me.grp_SportsIntrested.SendToBack()
        End If
    End Sub

    Private Sub chk_Relativesdetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Relativesdetails.CheckedChanged
        If chk_Relativesdetails.Checked = True Then
            Me.grp_Relativedetails.BringToFront()
            Me.grp_Relativedetails.Visible = True
            Me.grp_Relativedetails.Top = 72
            Me.grp_Relativedetails.Left = 50
            SSgrid_Relatives.Focus()
        ElseIf chk_Relativesdetails.Checked = False Then
            Me.grp_Relativedetails.Visible = False
            Me.grp_Relativedetails.SendToBack()
        End If
    End Sub
    Public Sub getphoto()
        '''''If File.Exists("\\" & gserver & "\Photos\Members\" & Trim(txt_MemberCode.Text) & ".Jpg") Then
        '''''    memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Members\" & Trim(txt_MemberCode.Text) & ".Jpg")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\Members\" & Trim(txt_MemberCode.Text) & ".GIF") Then
        '''''    memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Members\" & Trim(txt_MemberCode.Text) & ".GIF")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
        '''''    memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpeg") Then
        '''''    memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpeg")
        '''''End If

        '''''If File.Exists("\\" & gserver & "\Photos\\signatures\" & Trim(txt_MemberCode.Text) & ".Jpg") Then
        '''''    membersignature.Image = New Bitmap("\\" & gserver & "\photos\signatures\" & Trim(txt_MemberCode.Text) & ".Jpg")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\signatures\" & Trim(txt_MemberCode.Text) & ".GIF") Then
        '''''    membersignature.Image = New Bitmap("\\" & gserver & "\Photos\signatures\" & Trim(txt_MemberCode.Text) & ".GIF")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\Image1.Jpg") Then
        '''''    membersignature.Image = New Bitmap("\\" & gserver & "\Photos\Image1.Jpg")
        '''''ElseIf File.Exists("\\" & gserver & "\Photos\Image1.Jpeg") Then
        '''''    membersignature.Image = New Bitmap("\\" & gserver & "\Photos\Image1.Jpeg")
        '''''End If
        memberphoto.Image = New Bitmap(AppPath & "\Photos\Image.Jpg")
        membersignature.Image = New Bitmap(AppPath & "\Photos\Image1.Jpg")

    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim StrSQL As String
        Try
            If txt_MemberCode.Text <> "" Then

                Call getphoto()
                'dtp_MembershipFrom.Visible = True
                'dtp_MembershipTo.Visible = True
                'dtp_LastArrivalInCalcutta.Visible = True
                'dtp_DateApplication.Visible = True
                'dtp_ESTDdate.Visible = True
                'dtp_DateProposal.Visible = True
                'txt_spouse_dob.Visible = True
                'dtp_DateOfBirth.Visible = True
                '-----
                'StrSQL = " SELECT *,ISNULL(spousemobile,'') AS SMOBILE,ISNULL(OLD,'NEW') AS OLDNEW FROM Membermaster WHERE mcode='" & Me.txt_MemberCode.Text & "'"
                'codeTable = gconnection.GetValues(StrSQL)
                ' cbo_CurrentStatus.Enabled = True
                '-------
                StrSQL = " SELECT isnull(reason,'') as reason,isnull(bg,'') as bg, isnull(pano,'') as pano, isnull(CREDITLIMIT,0) as CREDITLIMIT, isnull(subcd,'') as subcd,ISNULL(OLD,'NEW') AS OLDNEW,isnull(CriditNumber,'') as CriditNumber,isnull(Billbasis,'') as Billbasis,isnull(prefix,'') as prefix,isnull(firstname,'') as firstname, isnull(middlename,'') as middlename,isnull(surname,'') as surname, isnull(nationality,'') as nationality,isnull(dob,'') as dob, isnull(nationalityatbirth,'') as nationalityatbirth,isnull(spousemobile,'') as SMOBILE, "
                StrSQL = StrSQL & " isnull(placeofbirth,'') as placeofbirth, isnull(countryofbirth,'') as countryofbirth,isnull(billhead,'') as billhead,isnull(maritalstatus,'') as maritalstatus,isnull(corporatecode,'') as corporatecode,isnull(F_mcode,'') as F_Mcode,isnull(FATHERNAME,'') as FATHERNAME,"
                StrSQL = StrSQL & " isnull(NOMINEE,'') as NOMINEE, isnull(hplocker,'') as hplocker,isnull(corporatecode,'') as corporatecode,isnull(membertypecode,'') as membertypecode,isnull(curentstatus,'') as curentstatus,"
                StrSQL = StrSQL & " isnull(sex,'') as sex,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity,isnull(mid,'') as mid,"
                StrSQL = StrSQL & " isnull(contstate,'') as contstate,isnull(creditcardno,'') as creditcardno,isnull(contcountry,'') as contcountry,isnull(contpin,'') as contpin,isnull(contemail,'') as contemail,isnull(contphone1,'') as contphone1,isnull(contcell,'') as contcell,isnull(contfax,'') as contfax,isnull(cadd1,'') as cadd1,isnull(cadd2,'') as cadd2,"
                StrSQL = StrSQL & "isnull(cadd3,'') as cadd3,isnull(ccity,'') as ccity,isnull(cstate,'') as cstate,isnull(ccountry,'') as ccountry,isnull(cpin,'') as cpin,isnull(cphone1,'') as cphone1,isnull(Spouse,'') as Spouse,isnull(wifedob,'') as wifedob,isnull(racopyst,'') as racopyst,isnull(oadd1,'') as oadd1,isnull(oadd2,'') as oadd2,isnull(oadd3,'') as oadd3,isnull(ocity,'') as ocity,isnull(ostate,'') as ostate,isnull(ocountry,'') as ocountry,isnull(opin,'') as opin,isnull(ophone1,'') as ophone1,isnull(bacopyst,'') as bacopyst,"
                StrSQL = StrSQL & " isnull(padd1,'') as padd1,isnull(padd2,'') as padd2,isnull(padd3,'') as padd3,isnull(pcity,'') as pcity,isnull(pstate,'') as pstate,isnull(pcountry,'') as pcountry,isnull(ppin,'') as ppin,isnull(pphone1,'') as pphone1,isnull(pacopyst,'') as pacopyst,isnull(doj,'') as doj,isnull(membershipto,'') as membershipto,"
                StrSQL = StrSQL & " isnull(criditnumber,'') as criditnumber,isnull(lastarrivalincal,'') as lastarrivalincal,isnull(securitydeposit,0) as securitydeposit,isnull(entrancefee,0) as entrancefee,isnull(developmentfee,'') as developmentfee,isnull(periodofstay_year,0) as periodofstay_year,isnull(periodofstay_month,0) as periodofstay_month,isnull(previouslyproposed,'') as previouslyproposed,"
                StrSQL = StrSQL & " isnull(nooftimesproposed ,0) as nooftimesproposed,isnull(applno,'') as applno,isnull(appldate,'') as appldate,"
                StrSQL = StrSQL & " isnull(compname,'') as compname,isnull(company,'') as company, isnull(designation,'') as designation,isnull(professioninfo,'') as professioninfo,isnull(buisnessinfo,'') as buisnessinfo,isnull(banker,'') as banker,isnull(client,'') as client,isnull(products,'') as products,isnull(agentsdealers,'') as agentsdealers,isnull(ESTDdate,'') as ESTDdate,"
                StrSQL = StrSQL & " isnull(noofemp,0) as noofemp,isnull(turnover,'') as turnover,isnull(PROPOSER,'') as PROPOSER,isnull(PROPOSERNAME,'') as PROPOSERNAME,isnull(SECONDER,'') as SECONDER,isnull(SECONDERNAME,'') as SECONDERNAME,isnull(positioninchamber,'') as positioninchamber,isnull(appliedbut,'') as appliedbut,isnull(childstatus,'') as childstatus,"
                StrSQL = StrSQL & " isnull(referentialst,'') as referentialst,isnull(Freeze,'') as Freeze,isnull(AddDate,'') as AddDate, "
                StrSQL = StrSQL & " isnull(elected,'') as elected,isnull(nooftimesproposed,0) as nooftimesproposed,isnull(dateofproposal,'') as dateofproposal, "
                StrSQL = StrSQL & " isnull(qulificationstatus,'') as qulificationstatus,isnull(sportstatus,'') as sportstatus,isnull(clubstatus,'') as clubstatus,isnull(relativestatus,'') as relativestatus,isnull(entrancefeest,'') as entrancefeest "
                StrSQL = StrSQL & " FROM Membermaster WHERE mcode='" & Me.txt_MemberCode.Text & "'"
                codeTable = gconnection.GetValues(StrSQL)
                If codeTable.Rows.Count > 0 Then
                    ' cbo_CurrentStatus.Enabled = False
                    Me.txt_MemberCode.ReadOnly = True
                    OLDNEW = (codeTable.Rows(0).Item("OLDNEW"))
                    Me.cbo_BillingBasis.Text = codeTable.Rows(0).Item("Billbasis")
                    Me.TXT_TITLE.Text = codeTable.Rows(0).Item("prefix")
                    'Me.TXT_TITLE.Text = codeTable.Rows(0).Item("mid")
                    Me.txt_FirstName.Text = codeTable.Rows(0).Item("firstname")
                    Me.txt_MiddleName.Text = codeTable.Rows(0).Item("middlename")
                    Me.txt_Surname.Text = codeTable.Rows(0).Item("surname")
                    Me.txt_Nationality.Text = codeTable.Rows(0).Item("nationality")
                    subscd = Val(codeTable.Rows(0).Item("subcd"))
                    tsubscd = Format(Val(codeTable.Rows(0).Item("subcd")), "0000")
                    If Format(codeTable.Rows(0).Item("lastarrivalincal"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        Me.dtp_LastArrivalInCalcutta.Value = Format(codeTable.Rows(0).Item("lastarrivalincal"), "dd-MMM-yyyy")
                        Btn_LastArr_c.Text = "C"
                        Btn_LastArr_c_FUN()
                    Else
                        Me.dtp_LastArrivalInCalcutta.Value = Format(codeTable.Rows(0).Item("lastarrivalincal"), "dd-MMM-yyyy")
                        dtp_LastArrivalInCalcutta.Visible = True
                    End If

                    txt_CreditNumber.Text = codeTable.Rows(0).Item("CriditNumber")

                    If Format(codeTable.Rows(0).Item("dob"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        Btn_BIRTH1.Text = "C"
                        Btn_BIRTH1_FUN()
                    Else
                        Me.dtp_DateOfBirth.Value = Format(codeTable.Rows(0).Item("dob"), "dd-MMM-yyyy")
                        dtp_DateOfBirth.Visible = True
                    End If

                    If Format(codeTable.Rows(0).Item("doj"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        Btn_Membershipfrom_c.Text = "C"
                        Btn_Membershipfrom_c_FUN()
                    Else
                        Me.dtp_MembershipFrom.Value = Format(codeTable.Rows(0).Item("doj"), "dd-MMM-yyyy")
                        dtp_MembershipFrom.Visible = True
                    End If
                    '18/08/2008
                    'Me.dtp_MembershipFrom.Value = Format(codeTable.Rows(0).Item("doj"), "dd-MMM-yyyy")
                    'Me.dtp_MembershipTo.Value = Format(codeTable.Rows(0).Item("membershipto"), "dd-MMM-yyyy")
                    Me.txt_NationalityAtBirth.Text = codeTable.Rows(0).Item("nationalityatbirth")
                    Me.txt_PlaceOfBirth.Text = codeTable.Rows(0).Item("placeofbirth")
                    Me.txt_CountryOfBirth.Text = codeTable.Rows(0).Item("countryofbirth")
                    If codeTable.Rows(0).Item("billhead") = "Y" Then
                        chk_Billhead.Checked = True
                    Else
                        chk_Billhead.Checked = False
                    End If
                    If codeTable.Rows(0).Item("maritalstatus") = "Y" Then
                        chk_Married.Checked = True
                    Else
                        chk_Married.Checked = False
                    End If
                    If codeTable.Rows(0).Item("corporatecode") = "Y" Then
                        chk_corporate.Checked = True
                    Else
                        chk_corporate.Checked = False
                    End If
                    Me.txt_fmcode.Text = codeTable.Rows(0).Item("F_MCODE")
                    Me.txt_GDRLocker.Text = codeTable.Rows(0).Item("FATHERNAME")

                    Me.txt_LDRLocker.Text = codeTable.Rows(0).Item("NOMINEE")
                    Me.txt_HPLocker.Text = codeTable.Rows(0).Item("hplocker")
                    Me.txt_CorporateCode.Text = codeTable.Rows(0).Item("corporatecode")
                    'modified by srinivas
                    txt_CorporateCode_Validated()
                    Me.txt_Category.Text = codeTable.Rows(0).Item("membertypecode")
                    Me.txt_Category.ReadOnly = False
                    'Me.cmd_CategoryHelp().Hide() 'venugopal-SVS club/30-mar-2010
                    'modified by srinivas
                    txt_Category_Validated_fun()
                    Me.cbo_CurrentStatus.Text = codeTable.Rows(0).Item("curentstatus")
                    If codeTable.Rows(0).Item("curentstatus") = "LIVE" Then
                        LStatus.Text = "LIVE"
                    ElseIf codeTable.Rows(0).Item("curentstatus") = "EXPIRED" Then
                        LStatus.Text = "EXPIRED"
                    ElseIf codeTable.Rows(0).Item("curentstatus") = "INACTIVE" Then
                        LStatus.Text = "INACTIVE"
                    Else
                        LStatus.Text = ""
                    End If

                    If codeTable.Rows(0).Item("sex") = "M" Then
                        opt_Male.Checked = True
                    Else
                        opt_Female.Checked = True
                    End If

                    Me.Txt_BloodGroup.Text = codeTable.Rows(0).Item("BG")
                    Me.Txt_PANNo.Text = codeTable.Rows(0).Item("PANO")
                    Me.Txt_CreditLimit.Text = Format(Val(codeTable.Rows(0).Item("CREDITLIMIT")), "0.00")

                    Me.txt_CA_Address1.Text = codeTable.Rows(0).Item("contadd1")
                    Me.txt_CA_Address2.Text = codeTable.Rows(0).Item("contadd2")
                    Me.txt_CA_Address3.Text = codeTable.Rows(0).Item("contadd3")
                    Me.txt_CA_City.Text = codeTable.Rows(0).Item("contcity")
                    Me.txt_CA_State.Text = codeTable.Rows(0).Item("contstate")
                    Me.txt_CA_Country.Text = codeTable.Rows(0).Item("contcountry")
                    Me.txt_CA_Pin.Text = codeTable.Rows(0).Item("contpin")
                    Me.txt_CA_EMail.Text = codeTable.Rows(0).Item("contemail")
                    Me.txt_CA_Phone.Text = codeTable.Rows(0).Item("contphone1")
                    Me.txt_CA_Mobile.Text = codeTable.Rows(0).Item("contcell")
                    Me.txt_CA_Fax.Text = codeTable.Rows(0).Item("contfax")
                    Me.txt_RA_Address1.Text = codeTable.Rows(0).Item("cadd1")
                    Me.txt_RA_Address2.Text = codeTable.Rows(0).Item("cadd2")
                    Me.txt_RA_Address3.Text = codeTable.Rows(0).Item("cadd3")
                    Me.txt_RA_City.Text = codeTable.Rows(0).Item("ccity")
                    Me.txt_RA_State.Text = codeTable.Rows(0).Item("cstate")
                    Me.txt_RA_Country.Text = codeTable.Rows(0).Item("ccountry")
                    Me.txt_RA_PinCode.Text = codeTable.Rows(0).Item("cpin")
                    Me.txt_RA_PhoneNo.Text = codeTable.Rows(0).Item("cphone1")
                    Me.txt_Spouse.Text = codeTable.Rows(0).Item("Spouse")
                    '01/08/2008
                    Me.TXT_SPOUSE_MOBILE.Text = codeTable.Rows(0).Item("SMOBILE")
                    If codeTable.Rows(0).Item("racopyst") = "Y" Then
                        chk_RA_Copy.Checked = True
                    Else
                        chk_RA_Copy.Checked = False
                    End If
                    Me.txt_BA_Address1.Text = codeTable.Rows(0).Item("oadd1")
                    Me.txt_BA_Address2.Text = codeTable.Rows(0).Item("oadd2")
                    Me.txt_BA_Address3.Text = codeTable.Rows(0).Item("oadd3")
                    Me.txt_BA_City.Text = codeTable.Rows(0).Item("ocity")
                    Me.txt_BA_State.Text = codeTable.Rows(0).Item("ostate")
                    Me.txt_BA_Country.Text = codeTable.Rows(0).Item("ocountry")
                    Me.txt_BA_PinCode.Text = codeTable.Rows(0).Item("opin")
                    Me.txt_BA_PhoneNo.Text = codeTable.Rows(0).Item("ophone1")

                    If codeTable.Rows(0).Item("bacopyst") = "Y" Then
                        chk_BA_Copy.Checked = True
                    Else
                        chk_BA_Copy.Checked = False
                    End If
                    Me.txt_PA_Address1.Text = codeTable.Rows(0).Item("padd1")
                    Me.txt_PA_Address2.Text = codeTable.Rows(0).Item("padd2")
                    Me.txt_PA_Address3.Text = codeTable.Rows(0).Item("padd3")
                    Me.txt_PA_City.Text = codeTable.Rows(0).Item("pcity")
                    Me.txt_PA_State.Text = codeTable.Rows(0).Item("pstate")
                    Me.txt_PA_Country.Text = codeTable.Rows(0).Item("pcountry")
                    Me.txt_PA_PinCode.Text = codeTable.Rows(0).Item("ppin")
                    Me.txt_PA_Phone.Text = codeTable.Rows(0).Item("pphone1")

                    If codeTable.Rows(0).Item("pacopyst") = "Y" Then
                        chk_PA_Copy.Checked = True
                    Else
                        chk_PA_Copy.Checked = False
                    End If
                    Me.dtp_MembershipTo.Value = Format(codeTable.Rows(0).Item("membershipto"), "dd-MMM-yyyy")
                    If Format(codeTable.Rows(0).Item("membershipto"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        Btn_MembershipTo_c.Text = "C"
                        Btn_MembershipTo_c_FUN()
                    Else
                        Me.dtp_MembershipTo.Value = Format(codeTable.Rows(0).Item("membershipto"), "dd-MMM-yyyy")
                        dtp_MembershipTo.Visible = True
                        dtp_MembershipTo.BringToFront()
                    End If
                    If codeTable.Rows(0).Item("wifedob") = "01-Jan-1900" Or codeTable.Rows(0).Item("wifedob") = "01/Jan/1900" Then
                        txt_spouse_dob.Text = "01-Jan-1900"
                        Btn_spousedob_c.Text = "C"
                        txt_spouse_dob_fun()
                    Else
                        Me.txt_spouse_dob.Text = codeTable.Rows(0).Item("wifedob")
                        txt_spouse_dob.Visible = True
                    End If
                    Me.txt_SecurityDeposit.Text = Format(Val(codeTable.Rows(0).Item("securitydeposit")), "0.00")
                    Me.txt_EntranceFee.Text = Format(Val(codeTable.Rows(0).Item("entrancefee")), "0.00")
                    Me.txt_DevelopmentFee.Text = Format(Val(codeTable.Rows(0).Item("developmentfee")), "0.00")
                    Me.txt_PeriodOfStay.Text = codeTable.Rows(0).Item("periodofstay_year")
                    Me.txt_Month.Text = codeTable.Rows(0).Item("periodofstay_month")
                    If codeTable.Rows(0).Item("previouslyproposed") = "Y" Then
                        chk_PreviouslyPr.Checked = True
                    Else
                        chk_PreviouslyPr.Checked = False
                    End If
                    If codeTable.Rows(0).Item("elected") = "Y" Then
                        chk_Elected.Checked = True
                    Else
                        chk_Elected.Checked = False
                    End If
                    Me.txt_NoOfTimesProposed.Text = codeTable.Rows(0).Item("nooftimesproposed")
                    If Format(codeTable.Rows(0).Item("dateofproposal"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        Btn_DateOf_c.Text = "C"
                        Btn_DateOf_c_FUN()
                    Else
                        Me.dtp_DateProposal.Value = Format(codeTable.Rows(0).Item("dateofproposal"), "dd-MMM-yyyy")
                        dtp_DateProposal.Visible = True
                    End If
                    'Me.dtp_DateProposal.Value = Format(codeTable.Rows(0).Item("dateofproposal"), "dd-MMM-yyyy")
                    Me.txt_ReasonApplication.Text = codeTable.Rows(0).Item("reason")
                    Me.txt_ApplicationNo.Text = codeTable.Rows(0).Item("applno")
                    If Format(codeTable.Rows(0).Item("appldate"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        btn_Appdt_c.Text = "C"
                        btn_Appdt_c_FUN()
                    Else
                        Me.dtp_DateApplication.Value = Format(codeTable.Rows(0).Item("appldate"), "dd-MMM-yyyy")
                        dtp_DateApplication.Visible = True
                    End If
                    'Me.dtp_DateApplication.Value = Format(codeTable.Rows(0).Item("appldate"), "dd-MMM-yyyy")
                    'Me.txt_CompanyName.Text = codeTable.Rows(0).Item("compname")
                    Me.txt_CompanyName.Text = codeTable.Rows(0).Item("company")
                    Me.txt_Designation.Text = codeTable.Rows(0).Item("designation")
                    Me.txt_Professonalinfo.Text = codeTable.Rows(0).Item("professioninfo")
                    Me.txt_Bussinessinfo.Text = codeTable.Rows(0).Item("buisnessinfo")
                    Me.txt_Bankers.Text = codeTable.Rows(0).Item("banker")
                    Me.txt_Clients.Text = codeTable.Rows(0).Item("client")
                    Me.txt_Products.Text = codeTable.Rows(0).Item("products")
                    Me.txt_Agents.Text = codeTable.Rows(0).Item("agentsdealers")
                    If Format(codeTable.Rows(0).Item("ESTDdate"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                        btn_ClearEstdDT.Text = "C"
                        btn_ClearEstdDT_FUN()
                    Else
                        Me.dtp_ESTDdate.Value = Format(codeTable.Rows(0).Item("ESTDdate"), "dd-MMM-yyyy")
                        dtp_ESTDdate.Visible = True
                        dtp_ESTDdate.BringToFront()

                    End If
                    'Me.dtp_ESTDdate.Value = Format(codeTable.Rows(0).Item("ESTDdate"), "dd-MMM-yyyy")
                    Me.txt_NoOfEmployee.Text = codeTable.Rows(0).Item("noofemp")
                    Me.txt_TurnOver.Text = codeTable.Rows(0).Item("turnover")

                    Me.txt_ProposerCode.Text = Trim(codeTable.Rows(0).Item("PROPOSER"))
                    Me.txt_ProposedName.Text = Trim(codeTable.Rows(0).Item("PROPOSERNAME"))
                    Me.txt_SeconderCode.Text = Trim(codeTable.Rows(0).Item("SECONDER"))
                    Me.txt_SeconderName.Text = Trim(codeTable.Rows(0).Item("SECONDERNAME"))

                    Me.txt_PositionHeld.Text = codeTable.Rows(0).Item("positioninchamber")
                    '''****************** Applied Membership ******************************'''
                    If codeTable.Rows(0).Item("appliedbut") = "Y" Then
                        chk_AppliedMembership.Checked = True
                        chk_AppliedMembership.BackColor = Color.Cyan
                    Else
                        chk_AppliedMembership.Checked = False
                        chk_AppliedMembership.BackColor = Color.Silver
                    End If
                    '''****************** First Zoom Childrendetails ******************************'''

                    If codeTable.Rows(0).Item("childstatus") = "Y" Then

                        chk_Childrendetail.Checked = True
                        chk_Childrendetail.BackColor = Color.Cyan
                        grp_ChildrenDetails.Visible = False
                    Else
                        chk_Childrendetail.Checked = False
                        chk_Childrendetail.BackColor = Color.Silver
                    End If
                    '''****************** Second Zoom Member Qulification ******************************'''
                    If Trim(codeTable.Rows(0).Item("qulificationstatus")) = "Y" Then
                        chk_MemberQulification.Checked = True
                        chk_MemberQulification.BackColor = Color.Cyan
                        Grp_MemQualification.Visible = False
                    Else
                        chk_MemberQulification.Checked = False
                        chk_MemberQulification.BackColor = Color.Silver
                    End If
                    '''****************** Third Zoom Sportdetails ******************************'''
                    If Trim(codeTable.Rows(0).Item("sportstatus")) = "Y" Then
                        chk_Sports.Checked = True
                        chk_Sports.BackColor = Color.Cyan
                        grp_SportsIntrested.Visible = False
                    Else
                        chk_Sports.Checked = False
                        chk_Sports.BackColor = Color.Silver
                    End If
                    '''****************** Fourth Zoom Member Club ******************************'''
                    If Trim(codeTable.Rows(0).Item("clubstatus")) = "Y" Then
                        chk_Memberofclub.Checked = True
                        chk_Memberofclub.BackColor = Color.Cyan
                        grp_MemberClub.Visible = False

                    Else
                        chk_Memberofclub.Checked = False
                        chk_Memberofclub.BackColor = Color.Silver
                    End If
                    '''****************** Fifth Zoom Relativesdetails ******************************'''
                    If Trim(codeTable.Rows(0).Item("relativestatus")) = "Y" Then

                        chk_Relativesdetails.Checked = True
                        chk_Relativesdetails.BackColor = Color.Cyan
                        grp_Relativedetails.Visible = False
                    Else
                        chk_Relativesdetails.Checked = False
                        chk_Relativesdetails.BackColor = Color.Silver
                    End If
                    '''****************** Sixth Zoom Entrancefeedetails ******************************'''
                    If Trim(codeTable.Rows(0).Item("entrancefeest")) = "Y" Then

                        chk_EntranceFee.Checked = True
                        chk_EntranceFee.BackColor = Color.Cyan
                        grp_Entrancefeedetails.Visible = False
                    Else
                        chk_EntranceFee.Checked = False
                        chk_EntranceFee.BackColor = Color.Silver
                    End If
                    '''****************** Seventh Zoom Referentialdetails  ******************************'''
                    If Trim(codeTable.Rows(0).Item("referentialst")) = "Y" Then
                        chk_Referencedetails.Checked = True
                        chk_Referencedetails.BackColor = Color.Cyan
                        grp_Referencedetails.Visible = False
                    Else
                        chk_Referencedetails.Checked = False
                        chk_Referencedetails.BackColor = Color.Silver
                    End If
                    '''****************** If Member Is freezed then it will show the status ******************************'''
                    If Trim(codeTable.Rows(0).Item("Freeze")) = "Y" Then
                        Me.lbl_Frez.Visible = True
                        Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(codeTable.Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                        Me.cmd_Delete.Text = "UnFreeze[F7]"
                    Else
                        Me.lbl_Frez.Visible = False
                        Me.lbl_Frez.Text = "Record Freezed  On "
                        Me.cmd_Delete.Text = "Freeze[F7]"
                    End If
                    Me.cmd_AddNew.Text = "Update[F5]"
                Else
                    Me.txt_MemberCode.ReadOnly = False
                    Me.txt_FirstName.Text = ""
                    Me.lbl_Frez.Visible = False
                    Me.lbl_Frez.Text = "Record Freezed  On "
                    Me.cmd_AddNew.Text = "Add New[F5]"
                End If

                Dim Cur As Integer
                Dim ssql As String
                Dim i As Long
                ssql = "select isnull(MEMBERCODE,'') as membercode,isnull(SPECIALINFO,'') as SPECIALINFO from specialmaster where membercode='" & txt_MemberCode.Text & "'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    txt_Specialinfo.Text = Trim(memdet.Rows(0).Item("specialinfo"))
                Else
                    txt_Specialinfo.Text = ""
                End If
                '01/08/2008
                'current status
                ssql = "select ISNULL(START_DT,'') AS START_DT,ISNULL(END_DT,'') AS END_DT,ISNULL(REMARKS,'') AS REMARKS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='STAT' and type1='" & Mid(cbo_CurrentStatus.Text, 1, 1) & "'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With ssgrid_currentstatus
                            .Row = i + 1
                            .Col = 1
                            If Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy") <> "01/01/1900" Then
                                .Text = Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy")
                            Else
                                .Text = ""
                            End If
                            .Row = i + 1
                            .Col = 2
                            If Format(memdet.Rows(i).Item("end_dt"), "dd/MM/yyyy") = "01/01/1900" Then
                                .Text = ""
                            Else
                                .Text = Format(memdet.Rows(i).Item("end_dt"), "dd/MM/yyyy")
                            End If
                            .Row = i + 1
                            .Col = 3
                            .Text = Trim(memdet.Rows(i).Item("remarks"))
                        End With
                    Next i
                    ssgrid_currentstatus.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(CHILD_NM,'') AS CHILD_NM,ISNULL(CHILD_DOB,'') AS CHILD_DOB,ISNULL(SEX,'') AS SEX,ISNULL(END_DT,'') AS END_DT,ISNULL(REMARKS,'') AS REMARKS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='chld'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With ssgrid
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("child_nm"))
                            .Row = i + 1
                            .Col = 2
                            If Format(memdet.Rows(i).Item("child_dob"), "dd/MM/yyyy") = "01/01/1900" Then
                                .Text = ""
                            Else
                                .Text = Format(memdet.Rows(i).Item("child_dob"), "dd/MM/yyyy")
                            End If
                            .Row = i + 1
                            .Col = 3
                            .Text = Trim(memdet.Rows(i).Item("sex"))
                            .Row = i + 1
                            .Col = 4
                            .Text = Format(memdet.Rows(i).Item("REMARKS"), "")
                        End With
                    Next i
                    ssgrid.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(NAME,'') AS NAME,ISNULL(RELATION,'') AS RELATION,ISNULL(CHILD_DOB,'') AS CHILD_DOB,ISNULL(REMARKS,'') AS REMARKS,ISNULL(SEX,'') AS SEX,ISNULL(ADDRESS,'') AS ADDRESS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='rela'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Relatives
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("name"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("relation"))
                            .Row = i + 1
                            .Col = 3
                            If Format(memdet.Rows(i).Item("child_dob"), "dd/MM/yyyy") = "01/01/1900" Then
                                .Text = ""
                            Else
                                .Text = Format(memdet.Rows(i).Item("child_dob"), "dd/MM/yyyy")
                            End If
                            .Row = i + 1
                            .Col = 4
                            .Text = Trim(memdet.Rows(i).Item("remarks"))
                            .Row = i + 1
                            .Col = 5
                            .Text = Trim(memdet.Rows(i).Item("sex"))
                            .Row = i + 1
                            .Col = 6
                            .Text = Trim(memdet.Rows(i).Item("address"))
                        End With
                    Next i
                    SSgrid_Relatives.SetActiveCell(1, 1)
                End If
                ssql = " select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(NAME,'') AS NAME,ISNULL(ADDRESS,'') AS ADDRESS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='club'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_MemberClub
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("name"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("address"))
                        End With
                    Next i
                    SSgrid_MemberClub.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(REFMEM_NO,'') AS REFMEM_NO,ISNULL(NAME,'') AS NAME,ISNULL(REFMEM_DT,'') AS REFMEM_DT,ISNULL(DELETED,'') AS DELETED from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='refr'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With ssgrid_Referencedetails
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("REFMEM_NO"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("name"))
                            .Row = i + 1
                            .Col = 3
                            If Format(memdet.Rows(i).Item("refmem_dt"), "dd/MM/yyyy") = "01/01/1900" Then
                                .Text = ""
                            Else
                                .Text = Format(memdet.Rows(i).Item("refmem_dt"), "dd/MM/yyyy")
                            End If
                            .Row = i + 1
                            .Col = 4
                            .Text = Trim(memdet.Rows(i).Item("deleted"))
                        End With
                    Next i
                    ssgrid_Referencedetails.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(RCT_NO,'') AS RCT_NO,ISNULL(START_DT,'') AS START_DT,ISNULL(AMOUNT,0) AS AMOUNT from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='entr'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Entrancefee
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("rct_no"))
                            .Row = i + 1
                            .Col = 2
                            If Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy") = "01/01/1900" Then
                                .Text = ""
                            Else
                                .Text = Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy")
                            End If
                            .Row = i + 1
                            .Col = 3
                            .Text = Trim(memdet.Rows(i).Item("amount"))
                        End With
                    Next i
                    SSgrid_Entrancefee.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(aqua_game,'') AS aqua_game,ISNULL(NAME,'') AS NAME,ISNULL(REMARKS,'') AS REMARKS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='sprt'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Sports
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("aqua_game"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("name"))
                            .Row = i + 1
                            .Col = 3
                            .Text = Trim(memdet.Rows(i).Item("remarks"))
                        End With
                    Next i
                    SSgrid_Sports.SetActiveCell(1, 1)
                End If
                ssql = "select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(QUAL_DET,'') AS QUAL_DET,ISNULL(REMARKS,'') AS REMARKS,ISNULL(YEAR_PASS,'') AS YEAR_PASS,ISNULL(INSTITUTE,'') AS INSTITUTE,ISNULL(DIVISION,'') AS DIVISION from memdet where mem_code='" & txt_MemberCode.Text & "' AND TYPE0 ='QUAL'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Qualification
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("qual_det"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("remarks"))
                            .Row = i + 1
                            .Col = 3
                            .Text = Trim(memdet.Rows(i).Item("year_pass"))
                            .Row = i + 1
                            .Col = 4
                            .Text = Trim(memdet.Rows(i).Item("INSTITUTE"))
                            .Row = i + 1
                            .Col = 5
                            .Text = Trim(memdet.Rows(i).Item("division"))
                        End With
                    Next i
                End If
                ssql = " select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(PCODE,'') AS PCODE,ISNULL(PNAME,'') AS PNAME from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='Prop'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    Me.Chk_Prop.Checked = True
                    grp_proposaldetails.Visible = False
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Proposal
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("pcode"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("pname"))
                        End With
                    Next i
                    SSgrid_Proposal.SetActiveCell(1, 1)
                Else
                    Me.Chk_Prop.Checked = False
                    grp_proposaldetails.Visible = False
                End If
                ssql = " select ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(PCODE,'') AS PCODE,ISNULL(PNAME,'') AS PNAME from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='Seco'"
                memdet = gconnection.GetValues(ssql)
                If memdet.Rows.Count > 0 Then
                    Me.Chk_Sec.Checked = True
                    grp_Seconderdetails.Visible = False
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Seconder
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("pcode"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("pname"))
                        End With
                    Next i
                    SSgrid_Seconder.SetActiveCell(1, 1)
                Else
                    Me.Chk_Sec.Checked = False
                    grp_Seconderdetails.Visible = False
                End If
                'If SIGNATURE.Checked = True Then
                ''''If Dir(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg") <> "" Then
                ''''    membersignature.Image = New Bitmap(AppPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
                ''''    SIGNATURE.Checked = True
                ''''Else
                ''''    membersignature.Image = New Bitmap(AppPath & "\Photos\Image.Jpg")
                ''''    SIGNATURE.Checked = False
                ''''End If
                'If photo.checked = True Then
                ''''If Dir(AppPath & "\Photos\P" & txt_MemberCode.Text & ".jpg") <> "" Then
                ''''    memberphoto.Image = New Bitmap(AppPath & "\Photos\P" & txt_MemberCode.Text & ".jpg")
                ''''    PHOTO.Checked = True
                ''''Else
                ''''    memberphoto.Image = New Bitmap(AppPath & "\Photos\Image.Jpg")
                ''''    PHOTO.Checked = False
                ''''End If
                grp_ChildrenDetails.Visible = False
                grp_SportsIntrested.Visible = False
                grp_Relativedetails.Visible = False
                Grp_MemQualification.Visible = False
                grp_MemberClub.Visible = False
                grp_Referencedetails.Visible = False
                grp_Entrancefeedetails.Visible = False
                grp_currentstatus.Visible = False

                'If PHOTO.Checked = True Then
                If Dir(gPhotoPath & "\Photos\" & txt_MemberCode.Text & "-00.jpg") <> "" Then
                    memberphoto.Image = New Bitmap(gPhotoPath & "\Photos\" & txt_MemberCode.Text & "-00.jpg")
                    PHOTO.Checked = True
                Else
                    memberphoto.Image = Nothing
                    'memberphoto.Image = New Bitmap(gPhotoPath & "\Photos\Image.Jpg")
                    'PHOTO.Checked = False
                End If
                If Dir(gPhotoPath & "\Photos\S" & txt_MemberCode.Text & ".jpg") <> "" Then
                    membersignature.Image = New Bitmap(gPhotoPath & "\Photos\S" & txt_MemberCode.Text & ".jpg")
                    SIGNATURE.Checked = True
                Else
                    membersignature.Image = Nothing
                    'membersignature.Image = New Bitmap(AppPath & "\Photos\Image.Jpg")
                    'SIGNATURE.Checked = False
                End If


                'End If
            End If
            ssgrid.SetActiveCell(1, 1)
            ssgrid_currentstatus.SetActiveCell(1, 1)
            SSgrid_Entrancefee.SetActiveCell(1, 1)
            SSgrid_MemberClub.SetActiveCell(1, 1)
            SSgrid_Proposal.SetActiveCell(1, 1)
            SSgrid_Qualification.SetActiveCell(1, 1)
            SSgrid_Relatives.SetActiveCell(1, 1)
            SSgrid_Seconder.SetActiveCell(1, 1)
            SSgrid_Sports.SetActiveCell(1, 1)

            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox("error......" + Err.Number + Err.Description, MsgBoxStyle.OKOnly, "Validation Error")
        End Try
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid.InsertRows(ssgrid.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If ssgrid.ActiveRow = 3 And ssgrid.ActiveCol = 4 Then
                '01/08/2008
                '                cmd_ChildrenOk.Focus()
            End If
        End If
    End Sub
    Private Sub chk_Referencedetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Referencedetails.CheckedChanged
        If chk_Referencedetails.Checked = True Then
            Me.grp_Referencedetails.BringToFront()
            Me.grp_Referencedetails.Visible = True
            Me.grp_Referencedetails.Top = 72
            Me.grp_Referencedetails.Left = 50
            ssgrid_Referencedetails.Focus()
        ElseIf chk_Referencedetails.Checked = False Then
            Me.grp_Referencedetails.Visible = False
            Me.grp_Referencedetails.SendToBack()
        End If
    End Sub

    Private Sub cmd_ReferencedetailsOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ReferencedetailsOk.Click
        grp_Referencedetails.Visible = False
        Me.chk_Referencedetails.Checked = True
        If Me.ssgrid_Referencedetails.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_Referencedetails.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(ssgrid_Referencedetails, "referencedetails")
        End If
    End Sub

    Private Sub cmd_currentstatus_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_currentstatus_ok.Click
        grp_currentstatus.Visible = False
        'If Me.ssgrid_currentstatus.DataRowCnt <= 0 Then
        '    MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
        '    Exit Sub
        'End If
    End Sub
    Private Sub cmd_ReferencedetailsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ReferencedetailsCancel.Click
        Me.chk_Referencedetails.Checked = False
        Me.grp_Referencedetails.Visible = False
        If gdataset.Tables.Contains("referencedetails") Then
            gdataset.Tables.Remove("referencedetails")
        End If
        chk_Referencedetails.Focus()
    End Sub
    Private Sub cmd_currentstatus_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_currentstatus_cancel.Click
        Me.grp_currentstatus.Visible = False
        If gdataset.Tables.Contains("currentstatus") Then
            gdataset.Tables.Remove("currentstatus")
        End If
    End Sub
    Private Sub dtp_ESTDdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_NoOfEmployee.Focus()
        End If
    End Sub
    Private Sub chk_Referencedetails_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Referencedetails.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Specialinfo.Focus()
        End If
    End Sub
    Private Sub chk_Referencedetails_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Referencedetails.GotFocus
        chk_Referencedetails.BackColor = Color.Cyan
    End Sub

    Private Sub chk_Referencedetails_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Referencedetails.LostFocus
        If chk_Referencedetails.Checked = False Then
            chk_Referencedetails.BackColor = Color.Silver
        End If
    End Sub

    Private Sub MemberMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        masterbool = False
    End Sub

    Private Sub txt_Category_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Category.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_CategoryHelp_Click(sender, e)
        End If
        ' Venugopal for SVS club - 30-mar-2010
    End Sub

    Private Sub txt_ProposerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ProposerCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_ProposerCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub txt_SeconderCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SeconderCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_SeconderCodeHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub txt_CorporateCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CorporateCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_CorporateCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub txt_Specialinfo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Specialinfo.GotFocus
        'tip_Specialinfo.SetToolTip(txt_Specialinfo, "Plz use CTRL+ENTER to Move To next Line")
    End Sub
    Private Sub txt_Category_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Category.GotFocus
        'tip_Specialinfo.SetToolTip(txt_Category, "Enter a valid Category Code or else use F4")
    End Sub
    Public Function btn_ClearEstdDT_FUN()
        If btn_ClearEstdDT.Text = "C" Then
            combo_HideDateESTD.Visible = True
            dtp_ESTDdate.Value = "01/JAN/1900"
            dtp_ESTDdate.Visible = False
            btn_ClearEstdDT.Text = "E"
            ClearEstdDt_val = ""
        ElseIf btn_ClearEstdDT.Text = "E" Then
            ClearEstdDt_val = ""
            combo_HideDateESTD.Visible = False
            dtp_ESTDdate.Visible = True
            dtp_ESTDdate.BringToFront()
            btn_ClearEstdDT.Text = "C"
            dtp_ESTDdate.BringToFront()
            dtp_ESTDdate.Value = Format(Now(), "dd/MMM/yyyy")
            ClearEstdDt_val = Format(dtp_ESTDdate.Value, "dd-MMM-yyyy")
        End If
    End Function
    Private Sub btn_ClearEstdDT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearEstdDT.Click
        btn_ClearEstdDT_FUN()
    End Sub
    Private Sub cmd_EntrancefeeOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EntrancefeeOK.Click
        grp_Entrancefeedetails.Visible = False
        Me.chk_EntranceFee.Checked = True
        If Me.SSgrid_Entrancefee.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
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

    Private Sub chk_EntranceFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_EntranceFee.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_MembershipTo.Focus()
        End If
    End Sub

    Private Sub chk_EntranceFee_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_EntranceFee.GotFocus
        chk_EntranceFee.BackColor = Color.Cyan
    End Sub

    Private Sub chk_EntranceFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_EntranceFee.LostFocus
        If chk_EntranceFee.Checked = False Then
            chk_EntranceFee.BackColor = Color.Silver
        End If
    End Sub
    Private Sub chk_EntranceFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EntranceFee.CheckedChanged
        If chk_EntranceFee.Checked = True Then
            Me.grp_Entrancefeedetails.BringToFront()
            Me.grp_Entrancefeedetails.Visible = True
            Me.grp_Entrancefeedetails.Top = 72
            Me.grp_Entrancefeedetails.Left = 50
            SSgrid_Entrancefee.Focus()
            SSgrid_Entrancefee.SetActiveCell(1, 1)
        ElseIf chk_EntranceFee.Checked = False Then
            Me.grp_Entrancefeedetails.Visible = False
            Me.grp_Entrancefeedetails.SendToBack()
        End If
    End Sub

    Private Sub cbo_BillingBasis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BillingBasis.KeyPress
        BLANK(e)
        If Asc(e.KeyChar) = 13 Then
            'chk_Married.Focus()
            txt_Spouse.Focus()
        End If
    End Sub
    Private Sub SSgrid_Entrancefee_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Entrancefee.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_Entrancefee.InsertRows(SSgrid_Entrancefee.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_Entrancefee.DeleteRows(SSgrid_Entrancefee.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If SSgrid_Entrancefee.ActiveRow = 3 And SSgrid_Entrancefee.ActiveCol = 3 Then
                '01/08/2008
                '                cmd_EntrancefeeOK.Focus()
            End If
        End If
    End Sub
    Private Sub SSgrid_MemberClub_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_MemberClub.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_MemberClub.InsertRows(SSgrid_MemberClub.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_MemberClub.DeleteRows(SSgrid_MemberClub.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If SSgrid_MemberClub.ActiveRow = 3 And SSgrid_MemberClub.ActiveCol = 2 Then
            End If
        End If
    End Sub
    Private Sub SSgrid_Qualification_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Qualification.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_Qualification.InsertRows(SSgrid_Qualification.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_Qualification.DeleteRows(SSgrid_Qualification.ActiveRow, 1)
        End If

        If e.keyCode = Keys.Enter Then
            If SSgrid_Qualification.ActiveRow = 3 And SSgrid_Qualification.ActiveCol = 5 Then
                '01/08/2008
                '                Cmd_MemberQuliOk.Focus()
            End If
        End If
    End Sub
    Private Sub ssgrid_Referencedetails_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_Referencedetails.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid_Referencedetails.InsertRows(ssgrid_Referencedetails.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid_Referencedetails.DeleteRows(ssgrid_Referencedetails.ActiveRow, 1)
        End If


        If e.keyCode = Keys.Enter Then
            If ssgrid_Referencedetails.ActiveRow = 3 And ssgrid_Referencedetails.ActiveCol = 4 Then
                '01/08/2008
                '                cmd_ReferencedetailsOk.Focus()
            End If
        End If
    End Sub
    Private Sub SSgrid_Relatives_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Relatives.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_Relatives.InsertRows(SSgrid_Relatives.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_Relatives.DeleteRows(SSgrid_Relatives.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If SSgrid_Relatives.ActiveRow = 3 And SSgrid_Relatives.ActiveCol = 6 Then
                '01/08/2008
                '                cmd_RelativesOk.Focus()
            End If
        End If
    End Sub
    Private Sub SSgrid_Sports_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Sports.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_Sports.InsertRows(SSgrid_Sports.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_Sports.DeleteRows(SSgrid_Sports.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            If SSgrid_Sports.ActiveRow = 3 And SSgrid_Sports.ActiveCol = 3 Then
                '01/08/2008
                '                cmd_SportsOk.Focus()
            End If
        End If
    End Sub
    Public Function Btn_MembershipTo_c_FUN()
        If Btn_MembershipTo_c.Text = "C" Then
            cmb_MembershipTo_c.Visible = True
            dtp_MembershipTo.Value = "01-JAN-1900"
            dtp_MembershipTo.Visible = False
            Btn_MembershipTo_c.Text = "E"
            MembershipTo_VAL = ""
        ElseIf Btn_MembershipTo_c.Text = "E" Then
            MembershipTo_VAL = ""
            dtp_MembershipTo.Value = Format(Now(), "dd/MMM/yyyy")
            cmb_MembershipTo_c.Visible = False
            dtp_MembershipTo.Visible = True
            dtp_MembershipTo.BringToFront()
            Btn_MembershipTo_c.Text = "C"
            MembershipTo_VAL = Format(dtp_MembershipTo.Value, "dd-MMM-yyyy")
        End If
    End Function
    Private Sub Btn_MembershipTo_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Btn_MembershipTo_c_FUN()
    End Sub
    Public Function btn_Appdt_c_FUN()
        If btn_Appdt_c.Text = "C" Then
            cmb_Appdt_c.Visible = True
            dtp_DateApplication.Value = "01-JAN-1900"
            dtp_DateApplication.Visible = False
            btn_Appdt_c.Text = "E"
            Appdt_c_VAL = ""
        ElseIf btn_Appdt_c.Text = "E" Then
            Appdt_c_VAL = ""
            cmb_Appdt_c.Visible = False
            dtp_DateApplication.Visible = True
            dtp_DateApplication.BringToFront()
            btn_Appdt_c.Text = "C"
            dtp_DateApplication.Value = Format(Now(), "dd/MMM/yyyy")
            Appdt_c_VAL = Format(dtp_DateApplication.Value, "dd-MMM-yyyy")
        End If
    End Function
    Private Sub btn_Appdt_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Appdt_c.Click
        btn_Appdt_c_FUN()
    End Sub
    Public Function Btn_DateOf_c_FUN()
        If Btn_DateOf_c.Text = "C" Then
            cmb_DateOf_c.Visible = True
            dtp_DateProposal.Value = "01/JAN/1900"
            dtp_DateProposal.Visible = False
            Btn_DateOf_c.Text = "E"
            DateOf_c_VAL = ""
        ElseIf Btn_DateOf_c.Text = "E" Then
            ClearEstdDt_val = ""
            cmb_DateOf_c.Visible = False
            dtp_DateProposal.Visible = True
            dtp_DateProposal.BringToFront()
            Btn_DateOf_c.Text = "C"
            dtp_DateProposal.Value = Format(Now(), "dd/MMM/yyyy")
            DateOf_c_VAL = Format(dtp_ESTDdate.Value, "dd-MMM-yyyy")
        End If
    End Function
    Public Function Btn_BIRTH1_FUN()
        If Btn_BIRTH1.Text = "C" Then
            CMB_BRITH.Visible = True
            dtp_DateOfBirth.Value = "01-JAN-1900"
            dtp_DateOfBirth.Visible = False
            Btn_BIRTH1.Text = "E"
            DateOf_birth = ""
        ElseIf Btn_BIRTH1.Text = "E" Then
            CMB_BRITH.Visible = False
            dtp_DateOfBirth.Visible = True
            Btn_BIRTH1.Text = "C"
            dtp_DateOfBirth.Value = Format(Now(), "dd/MMM/yyyy")
            DateOf_birth = Format(dtp_DateOfBirth.Value, "dd-MMM-yyyy")
        End If
    End Function
    Private Sub Btn_DateOf_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_DateOf_c.Click
        Btn_DateOf_c_FUN()

    End Sub
    Public Function Btn_LastArr_c_FUN()
        If Btn_LastArr_c.Text = "C" Then
            cmb_LastArr_c.Visible = True
            dtp_LastArrivalInCalcutta.Value = "01-JAN-1900"
            dtp_LastArrivalInCalcutta.Visible = False
            Btn_LastArr_c.Text = "E"
            LastArr_c_VAL = ""
        ElseIf Btn_LastArr_c.Text = "E" Then
            ClearEstdDt_val = ""
            cmb_LastArr_c.Visible = False
            dtp_LastArrivalInCalcutta.Value = Format(Now(), "dd/MMM/yyyy")
            dtp_LastArrivalInCalcutta.Visible = True
            Btn_LastArr_c.Text = "C"
            LastArr_c_VAL = Format(dtp_LastArrivalInCalcutta.Value, "dd-MMM-yyyy")
        End If

    End Function
    Private Sub Btn_LastArr_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_LastArr_c.Click
        Btn_LastArr_c_FUN()
    End Sub



    Private Sub dtp_MembershipTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dtp_MembershipTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Btn_MembershipTo_c.Text = "C"
            Btn_MembershipTo_c_FUN()
        End If
    End Sub

    Private Sub txt_CorporateCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CorporateCode.TextChanged

    End Sub

    Private Sub dtp_LastArrivalInCalcutta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_LastArrivalInCalcutta.ValueChanged

    End Sub

    Private Sub dtp_LastArrivalInCalcutta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_LastArrivalInCalcutta.KeyDown
        If e.KeyCode = Keys.Delete Then
            Btn_LastArr_c.Text = "C"
            Btn_LastArr_c_FUN()
        End If
    End Sub

    Private Sub dtp_DateProposal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtp_DateProposal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            Btn_DateOf_c.Text = "C"
            Btn_DateOf_c_FUN()
        End If
    End Sub

    Private Sub dtp_DateApplication_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtp_DateApplication_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            btn_Appdt_c.Text = "C"
            btn_Appdt_c_FUN()
        End If
    End Sub

    Private Sub dtp_ESTDdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dtp_ESTDdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Delete Then
        '    btn_ClearEstdDT.Text = "C"
        '    btn_ClearEstdDT_FUN()
        'End If
    End Sub

    Private Sub cmb_MembershipTo_c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmb_MembershipTo_c_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Insert Then
            Btn_MembershipTo_c.Text = "E"
            Btn_MembershipTo_c_FUN()
        End If
    End Sub

    Private Sub cmb_LastArr_c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_LastArr_c.SelectedIndexChanged

    End Sub

    Private Sub cmb_LastArr_c_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_LastArr_c.KeyDown
        If e.KeyCode = Keys.Insert Then
            Btn_LastArr_c.Text = "E"
            Btn_LastArr_c_FUN()
        End If
    End Sub

    Private Sub cmb_DateOf_c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DateOf_c.SelectedIndexChanged

    End Sub

    Private Sub cmb_DateOf_c_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_DateOf_c.KeyDown
        If e.KeyCode = Keys.Insert Then
            Btn_MembershipTo_c.Text = "E"
            Btn_DateOf_c_FUN()
        End If
    End Sub

    Private Sub cmb_Appdt_c_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Appdt_c.SelectedIndexChanged

    End Sub

    Private Sub cmb_Appdt_c_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Appdt_c.KeyDown
        If e.KeyCode = Keys.Insert Then
            btn_Appdt_c.Text = "E"
            btn_Appdt_c_FUN()
        End If
    End Sub

    Private Sub combo_HideDateESTD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_HideDateESTD.SelectedIndexChanged

    End Sub

    Private Sub combo_HideDateESTD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles combo_HideDateESTD.KeyDown
        If e.KeyCode = Keys.Insert Then
            btn_ClearEstdDT.Text = "E"
            btn_ClearEstdDT_FUN()
        End If
    End Sub
    Private Sub Chk_BA_RA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_BA_RA_Copy.CheckedChanged
        If Chk_BA_RA_Copy.Checked = True Then
            txt_RA_Address1.Text = txt_BA_Address1.Text
            txt_RA_Address2.Text = txt_BA_Address2.Text
            txt_RA_Address3.Text = txt_BA_Address3.Text
            txt_RA_City.Text = txt_BA_City.Text
            txt_RA_State.Text = txt_BA_State.Text
            txt_RA_Country.Text = txt_BA_Country.Text
            txt_RA_PinCode.Text = txt_BA_PinCode.Text
            txt_RA_PhoneNo.Text = txt_BA_PhoneNo.Text
            chk_RA_Copy.Checked = False
            'Chk_BA_RA_Copy.Checked = False
            Chk_PA_RA_Copy.Checked = False
        Else
            txt_RA_Address1.Text = ""
            txt_RA_Address2.Text = ""
            txt_RA_Address3.Text = ""
            txt_RA_City.Text = ""
            txt_RA_State.Text = ""
            txt_RA_Country.Text = ""
            txt_RA_PinCode.Text = ""
            txt_RA_PhoneNo.Text = ""
            txt_RA_Address1.Focus()
        End If
    End Sub

    Private Sub Chk_PA_RA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PA_RA_Copy.CheckedChanged
        If Chk_PA_RA_Copy.Checked = True Then
            txt_RA_Address1.Text = txt_PA_Address1.Text
            txt_RA_Address2.Text = txt_PA_Address2.Text
            txt_RA_Address3.Text = txt_PA_Address3.Text
            txt_RA_City.Text = txt_PA_City.Text
            txt_RA_State.Text = txt_PA_State.Text
            txt_RA_Country.Text = txt_PA_Country.Text
            txt_RA_PinCode.Text = txt_PA_PinCode.Text
            txt_RA_PhoneNo.Text = txt_PA_Phone.Text
            chk_RA_Copy.Checked = False
            Chk_BA_RA_Copy.Checked = False
            'Chk_PA_RA_Copy.Checked = False

        Else
            txt_RA_Address1.Text = ""
            txt_RA_Address2.Text = ""
            txt_RA_Address3.Text = ""
            txt_RA_City.Text = ""
            txt_RA_State.Text = ""
            txt_RA_Country.Text = ""
            txt_RA_PinCode.Text = ""
            txt_RA_PhoneNo.Text = ""
            txt_RA_Address1.Focus()
        End If
    End Sub


    Private Sub Chk_RA_BA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_RA_BA_Copy.CheckedChanged
        If Chk_RA_BA_Copy.Checked = True Then
            txt_BA_Address1.Text = txt_RA_Address1.Text
            txt_BA_Address2.Text = txt_RA_Address2.Text
            txt_BA_Address3.Text = txt_RA_Address3.Text
            txt_BA_City.Text = txt_RA_City.Text
            txt_BA_State.Text = txt_RA_State.Text
            txt_BA_Country.Text = txt_RA_Country.Text
            txt_BA_PinCode.Text = txt_RA_PinCode.Text
            txt_BA_PhoneNo.Text = txt_RA_PhoneNo.Text
            chk_BA_Copy.Checked = False
            'Chk_RA_BA_Copy.Checked = False
            Chk_PA_BA_Copy.Checked = False

        Else
            txt_BA_Address1.Text = ""
            txt_BA_Address2.Text = ""
            txt_BA_Address3.Text = ""
            txt_BA_City.Text = ""
            txt_BA_State.Text = ""
            txt_BA_Country.Text = ""
            txt_BA_PinCode.Text = ""
            txt_BA_PhoneNo.Text = ""
            txt_BA_Address1.Focus()
        End If
    End Sub

    Private Sub Chk_PA_BA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PA_BA_Copy.CheckedChanged
        If Chk_PA_BA_Copy.Checked = True Then
            txt_BA_Address1.Text = txt_PA_Address1.Text
            txt_BA_Address2.Text = txt_PA_Address2.Text
            txt_BA_Address3.Text = txt_PA_Address3.Text
            txt_BA_City.Text = txt_PA_City.Text
            txt_BA_State.Text = txt_PA_State.Text
            txt_BA_Country.Text = txt_PA_Country.Text
            txt_BA_PinCode.Text = txt_PA_PinCode.Text
            txt_BA_PhoneNo.Text = txt_PA_Phone.Text
            chk_BA_Copy.Checked = False
            Chk_RA_BA_Copy.Checked = False
            'Chk_PA_BA_Copy.Checked = False

        Else
            txt_BA_Address1.Text = ""
            txt_BA_Address2.Text = ""
            txt_BA_Address3.Text = ""
            txt_BA_City.Text = ""
            txt_BA_State.Text = ""
            txt_BA_Country.Text = ""
            txt_BA_PinCode.Text = ""
            txt_BA_PhoneNo.Text = ""
            txt_BA_Address1.Focus()
        End If
    End Sub
    Private Sub Chk_BA_PA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_BA_PA_Copy.CheckedChanged
        If Chk_BA_PA_Copy.Checked = True Then
            txt_PA_Address1.Text = txt_BA_Address1.Text
            txt_PA_Address2.Text = txt_BA_Address2.Text
            txt_PA_Address3.Text = txt_BA_Address3.Text
            txt_PA_City.Text = txt_BA_City.Text
            txt_PA_State.Text = txt_BA_State.Text
            txt_PA_Country.Text = txt_BA_Country.Text
            txt_PA_PinCode.Text = txt_BA_PinCode.Text
            txt_PA_Phone.Text = txt_BA_PhoneNo.Text
            chk_PA_Copy.Checked = False
            'Chk_BA_PA_Copy.Checked = False
            Chk_RA_PA_Copy.Checked = False

        Else
            txt_PA_Address1.Text = ""
            txt_PA_Address2.Text = ""
            txt_PA_Address3.Text = ""
            txt_PA_City.Text = ""
            txt_PA_State.Text = ""
            txt_PA_Country.Text = ""
            txt_PA_PinCode.Text = ""
            txt_PA_Phone.Text = ""
            txt_PA_Address1.Focus()
        End If
    End Sub

    Private Sub Chk_RA_PA_Copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_RA_PA_Copy.CheckedChanged
        If Chk_RA_PA_Copy.Checked = True Then
            txt_PA_Address1.Text = txt_RA_Address1.Text
            txt_PA_Address2.Text = txt_RA_Address2.Text
            txt_PA_Address3.Text = txt_RA_Address3.Text
            txt_PA_City.Text = txt_RA_City.Text
            txt_PA_State.Text = txt_RA_State.Text
            txt_PA_Country.Text = txt_RA_Country.Text
            txt_PA_PinCode.Text = txt_RA_PinCode.Text
            txt_PA_Phone.Text = txt_RA_PhoneNo.Text
            chk_PA_Copy.Checked = False
            Chk_BA_PA_Copy.Checked = False
            'Chk_RA_PA_Copy.Checked = False

        Else
            txt_PA_Address1.Text = ""
            txt_PA_Address2.Text = ""
            txt_PA_Address3.Text = ""
            txt_PA_City.Text = ""
            txt_PA_State.Text = ""
            txt_PA_Country.Text = ""
            txt_PA_PinCode.Text = ""
            txt_PA_Phone.Text = ""
            txt_PA_Address1.Focus()
        End If
    End Sub
    Private Sub txt_Spouse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Spouse.KeyPress
        'getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            If txt_spouse_dob.Visible = False Then
                ' Btn_spousedob_c.Focus()
                TXT_SPOUSE_MOBILE.Focus()
            Else
                txt_spouse_dob.Focus()
            End If
        End If
    End Sub
    Private Sub txt_spouse_dob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_spouse_dob.KeyPress
        '        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            TXT_SPOUSE_MOBILE.Focus()
        End If
    End Sub
    Private Sub PHOTO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PHOTO.Click
        Dim file As New OpenFileDialog
        file.Filter = " Jpg(*.Jpg) | *.jpg"
        If PHOTO.Checked = True Then
            'file.ShowDialog()
            If file.ShowDialog = DialogResult.OK Then
                memberphoto.Image = New Bitmap(file.FileName)
                ppath = file.FileName
                PHOTO.Checked = True
            Else
                memberphoto.Image = New Bitmap(AppPath & "\photos\Image.Jpg")
                PHOTO.Checked = False
            End If
        Else
            memberphoto.Image = New Bitmap(AppPath & "\photos\Image.Jpg")
            PHOTO.Checked = False
        End If
    End Sub
    Private Sub SIGNATURE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SIGNATURE.Click
        Dim file As New OpenFileDialog
        file.Filter = " Jpg(*.Jpg) | *.jpg"
        If SIGNATURE.Checked = True Then
            'file.ShowDialog()
            If file.ShowDialog = DialogResult.OK Then
                membersignature.Image = New Bitmap(file.FileName)
                spath = file.FileName
                SIGNATURE.Checked = True
            Else
                membersignature.Image = New Bitmap(AppPath & "\photos\Image.Jpg")
                SIGNATURE.Checked = False
            End If
        Else
            membersignature.Image = New Bitmap(AppPath & "\photos\Image.Jpg")
            SIGNATURE.Checked = False
        End If
    End Sub
    Private Sub Chk_RA_CA_copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_RA_CA_copy.CheckedChanged
        If Chk_RA_CA_copy.Checked = True Then
            txt_CA_Address1.Text = txt_RA_Address1.Text
            txt_CA_Address2.Text = txt_RA_Address2.Text
            txt_CA_Address3.Text = txt_RA_Address3.Text
            txt_CA_City.Text = txt_RA_City.Text
            txt_CA_State.Text = txt_RA_State.Text
            txt_CA_Country.Text = txt_RA_Country.Text
            txt_CA_Pin.Text = txt_RA_PinCode.Text
            txt_CA_Phone.Text = txt_RA_PhoneNo.Text
            chk_ba_ca_copy.Checked = False
            chk_pa_ca_copy.Checked = False
        Else
            txt_CA_Address1.Text = ""
            txt_CA_Address2.Text = ""
            txt_CA_Address3.Text = ""
            txt_CA_City.Text = ""
            txt_CA_State.Text = ""
            txt_CA_Country.Text = ""
            txt_CA_Pin.Text = ""
            txt_CA_Phone.Text = ""
            txt_CA_Address1.Focus()
        End If
    End Sub
    Private Sub chk_ba_ca_copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ba_ca_copy.CheckedChanged
        If chk_ba_ca_copy.Checked = True Then
            txt_CA_Address1.Text = txt_BA_Address1.Text
            txt_CA_Address2.Text = txt_BA_Address2.Text
            txt_CA_Address3.Text = txt_BA_Address3.Text
            txt_CA_City.Text = txt_BA_City.Text
            txt_CA_State.Text = txt_BA_State.Text
            txt_CA_Country.Text = txt_BA_Country.Text
            txt_CA_Pin.Text = txt_BA_PinCode.Text
            txt_CA_Phone.Text = txt_BA_PhoneNo.Text
            Chk_RA_CA_copy.Checked = False
            chk_pa_ca_copy.Checked = False
        Else
            txt_CA_Address1.Text = ""
            txt_CA_Address2.Text = ""
            txt_CA_Address3.Text = ""
            txt_CA_City.Text = ""
            txt_CA_State.Text = ""
            txt_CA_Country.Text = ""
            txt_CA_Pin.Text = ""
            txt_CA_Phone.Text = ""
            txt_CA_Address1.Focus()
        End If
    End Sub
    Private Sub chk_pa_ca_copy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_pa_ca_copy.CheckedChanged
        If chk_pa_ca_copy.Checked = True Then
            txt_CA_Address1.Text = txt_PA_Address1.Text
            txt_CA_Address2.Text = txt_PA_Address2.Text
            txt_CA_Address3.Text = txt_PA_Address3.Text
            txt_CA_City.Text = txt_PA_City.Text
            txt_CA_State.Text = txt_PA_State.Text
            txt_CA_Country.Text = txt_PA_Country.Text
            txt_CA_Pin.Text = txt_PA_PinCode.Text
            txt_CA_Phone.Text = txt_PA_Phone.Text
            Chk_RA_CA_copy.Checked = False
            chk_ba_ca_copy.Checked = False
        Else
            txt_CA_Address1.Text = ""
            txt_CA_Address2.Text = ""
            txt_CA_Address3.Text = ""
            txt_CA_City.Text = ""
            txt_CA_State.Text = ""
            txt_CA_Country.Text = ""
            txt_CA_Pin.Text = ""
            txt_CA_Phone.Text = ""
            txt_CA_Address1.Focus()
        End If
    End Sub
    Private Sub TXT_SPOUSE_MOBILE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_SPOUSE_MOBILE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If dtp_MembershipFrom.Visible = True Then
                dtp_MembershipFrom.Focus()
            Else
                txt_fmcode.Focus()
                ' txt_GDRLocker.Focus()
            End If
        End If
    End Sub
    Private Sub dtp_MembershipTo_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_MembershipTo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_GDRLocker.Focus()
        End If
    End Sub
    Private Sub cbo_CurrentStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_CurrentStatus.Click
    End Sub
    Private Sub Btn_BIRTH1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BIRTH1.Click
        Btn_BIRTH1_FUN()
    End Sub
    Private Sub Btn_MembershipTo_c_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_MembershipTo_c.Click
        Btn_MembershipTo_c_FUN()
    End Sub
    Public Function Btn_Membershipfrom_c_FUN()
        If Btn_Membershipfrom_c.Text = "C" Then
            cmb_Membershipfrom_c.Visible = True
            dtp_MembershipFrom.Value = "01/JAN/1900"
            dtp_MembershipFrom.Visible = False
            Btn_Membershipfrom_c.Text = "E"
            Membershipfrom_VAL = ""
        ElseIf Btn_Membershipfrom_c.Text = "E" Then
            Membershipfrom_VAL = ""
            cmb_Membershipfrom_c.Visible = False
            dtp_MembershipFrom.Visible = True
            dtp_MembershipFrom.Value = Format(Now(), "dd/MMM/yyyy")
            Btn_Membershipfrom_c.Text = "C"
            Membershipfrom_VAL = Format(dtp_MembershipFrom.Value, "dd-MMM-yyyy")
        End If
    End Function
    Private Sub Btn_Membershipfrom_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Membershipfrom_c.Click
        Btn_Membershipfrom_c_FUN()
    End Sub
    Private Sub cbo_CurrentStatus_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_CurrentStatus.DoubleClick
        Dim ssql As String
        Dim i
        ssgrid_currentstatus.ClearRange(0, 0, -1, -1, True)
        ssql = "select ISNULL(START_DT,'') AS START_DT,ISNULL(END_DT,'') AS END_DT,ISNULL(REMARKS,'') AS REMARKS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='STAT' and type1='" & Mid(cbo_CurrentStatus.Text, 1, 1) & "'"
        memdet = gconnection.GetValues(ssql)
        If memdet.Rows.Count > 0 Then
            For i = 0 To memdet.Rows.Count - 1
                With ssgrid_currentstatus
                    .Row = i + 1
                    .Col = 1
                    .Text = Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy")
                    .Row = i + 1
                    .Col = 2
                    .Text = Format(memdet.Rows(i).Item("end_dt"), "dd/MM/yyyy")
                    .Row = i + 1
                    .Col = 3
                    .Text = Trim(memdet.Rows(i).Item("remarks"))
                End With
            Next i
        End If
        If cbo_CurrentStatus.Focus = True Then
            Me.grp_currentstatus.BringToFront()
            Me.grp_currentstatus.Visible = True
            Me.grp_currentstatus.Top = 300
            Me.grp_currentstatus.Left = 50
            ssgrid_currentstatus.Focus()
        ElseIf cbo_CurrentStatus.Focus = False Then
            Me.grp_currentstatus.Visible = False
            Me.grp_currentstatus.SendToBack()
        End If
    End Sub
    Private Sub dtp_ESTDdate_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btn_ClearEstdDT_FUN()
    End Sub
    Public Function txt_spouse_dob_fun()
        If Btn_spousedob_c.Text = "C" Then
            cmb_spouse_dob.Visible = True
            cmb_spouse_dob.Visible = True
            txt_spouse_dob.Text = "01-JAN-1900"
            txt_spouse_dob.Visible = False
            Btn_spousedob_c.Text = "E"
            Membershipfrom_VAL = ""
        ElseIf Btn_spousedob_c.Text = "E" Then

            cmb_spouse_dob.Visible = False
            txt_spouse_dob.Visible = True
            txt_spouse_dob.Text = Format(Now(), "dd/MMM/yyyy")
            Btn_spousedob_c.Text = "C"
        End If
    End Function
    Private Sub Btn_spousedob_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_spousedob_c.Click
        Call txt_spouse_dob_fun()
    End Sub
    Private Sub txt_ProposerCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ProposerCode.LostFocus
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster where mcode='" & txt_ProposerCode.Text & "'"
        memdet = gconnection.GetValues(gSQLString)
        If memdet.Rows.Count > 0 Then
            txt_ProposedName.Text = ""
            txt_ProposedName.Text = Trim(memdet.Rows(0).Item("mname"))
        End If
    End Sub
    Private Sub txt_SeconderCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SeconderCode.LostFocus
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster where mcode='" & txt_SeconderCode.Text & "'"
        memdet = gconnection.GetValues(gSQLString)
        If memdet.Rows.Count > 0 Then
            txt_SeconderName.Text = ""
            txt_SeconderName.Text = Trim(memdet.Rows(0).Item("mname"))
        End If
    End Sub
    Private Sub btn_details_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_details.Click
        Dim ssql As String
        Dim i
        ssgrid_currentstatus.ClearRange(0, 0, -1, -1, True)
        ssql = "select ISNULL(START_DT,'') AS START_DT,ISNULL(END_DT,'') AS END_DT,ISNULL(REMARKS,'') AS REMARKS from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='STAT' and type1='" & Mid(cbo_CurrentStatus.Text, 1, 1) & "'"
        memdet = gconnection.GetValues(ssql)
        If memdet.Rows.Count > 0 Then
            For i = 0 To memdet.Rows.Count - 1
                With ssgrid_currentstatus
                    .Row = i + 1
                    .Col = 1
                    If Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy") <> "01/01/1900" Then
                        .Text = Format(memdet.Rows(i).Item("start_dt"), "dd/MM/yyyy")
                    Else
                        .Text = ""
                    End If
                    .Row = i + 1
                    .Col = 2
                    If Format(memdet.Rows(i).Item("end_dt"), "dd/MM/yyyy") <> "01/01/1900" Then
                        .Text = Format(memdet.Rows(i).Item("end_dt"), "dd/MM/yyyy")
                    Else
                        .Text = ""
                    End If
                    .Row = i + 1
                    .Col = 3
                    .Text = Trim(memdet.Rows(i).Item("remarks"))
                End With
            Next i
        End If
        If cbo_CurrentStatus.Focus = True Then
            Me.grp_currentstatus.BringToFront()
            Me.grp_currentstatus.Visible = True
            Me.grp_currentstatus.Top = 300
            Me.grp_currentstatus.Left = 50
            ssgrid_currentstatus.SetActiveCell(1, 1)
            ssgrid_currentstatus.Focus()
        ElseIf cbo_CurrentStatus.Focus = False Then
            Me.grp_currentstatus.Visible = False
            Me.grp_currentstatus.SendToBack()
        End If
    End Sub
    Private Sub ssgrid_currentstatus_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_currentstatus.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid_currentstatus.InsertRows(ssgrid_currentstatus.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid_currentstatus.DeleteRows(ssgrid_currentstatus.ActiveRow, 1)
        End If
    End Sub
    'Private Sub txt_CorporateCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CorporateCode.LostFocus
    '    Dim Coptable As New DataTable
    '    Dim strSQL As String
    '    Corp_code_val = ""
    '    strSQL = " SELECT ISNULL(CMcorporateCode,'') AS CMcorporateCode,ISNULL(CMcorporatename,'') AS CMcorporatename FROM CorporateMaster WHERE CMCorporateCode='" & Me.txt_CorporateCode.Text & "'"
    '    Coptable = gconnection.GetValues(strSQL)
    '    If Coptable.Rows.Count > 0 Then
    '        Me.txt_CorporateCode.Text = Coptable.Rows(0).Item(0) & " - " & Coptable.Rows(0).Item(1)
    '        Corp_code_val = Coptable.Rows(0).Item(0)
    '        txt_CorporateCode.Focus()
    '    Else
    '        ''MessageBox.Show("Plz enter a valid Corporate code ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '        txt_CorporateCode.Text = ""
    '        txt_CorporateCode.Focus()
    '    End If
    'End Sub

    Private Sub Txt_CreditLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CreditLimit.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_NoOfTimesProposed.Focus()
        End If
    End Sub

    Private Sub Txt_CreditLimit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_CreditLimit.LostFocus
        If Format(Val(Txt_CreditLimit.Text), "0.00") = "0.00" Then
            Txt_CreditLimit.Text = Format(Val(Txt_CreditLimit.Text), "1.00")
        Else
            Txt_CreditLimit.Text = Format(Val(Txt_CreditLimit.Text), "0.00")
        End If
    End Sub

    Private Sub grp_currentstatus_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_currentstatus.Enter

    End Sub

    Private Sub txt_CA_Phone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CA_Phone.TextChanged

    End Sub

    Private Sub txt_CA_Mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CA_Mobile.TextChanged

    End Sub

    Private Sub txt_CA_Fax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CA_Fax.TextChanged

    End Sub

    Private Sub txt_RA_PhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_PhoneNo.TextChanged

    End Sub

    Private Sub txt_PA_Phone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Phone.TextChanged

    End Sub

    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub

    Private Sub txt_ApplicationNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ApplicationNo.TextChanged

    End Sub

    Private Sub TXT_TITLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TITLE.TextChanged

    End Sub

    Private Sub txt_FirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FirstName.TextChanged

    End Sub

    Private Sub txt_MiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MiddleName.TextChanged

    End Sub

    Private Sub txt_Surname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Surname.TextChanged

    End Sub

    Private Sub txt_Nationality_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Nationality.TextChanged

    End Sub

    Private Sub Btn_BIRTH1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Btn_BIRTH1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_DateOfBirth.Focus()
        End If
    End Sub

    Private Sub dtp_DateOfBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DateOfBirth.ValueChanged

    End Sub

    Private Sub txt_NationalityAtBirth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NationalityAtBirth.TextChanged

    End Sub

    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged

    End Sub

    Private Sub txt_Spouse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Spouse.TextChanged

    End Sub

    Private Sub Btn_spousedob_c_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Btn_spousedob_c.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_spouse_dob.Focus()
        End If
    End Sub

    Private Sub txt_spouse_dob_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_spouse_dob.TextChanged

    End Sub

    Private Sub TXT_SPOUSE_MOBILE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SPOUSE_MOBILE.TextChanged

    End Sub

    Private Sub txt_GDRLocker_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_GDRLocker.TextChanged

    End Sub

    Private Sub txt_Category_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Category.TextChanged

    End Sub

    Private Sub Btn_BIRTH1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Btn_BIRTH1.KeyDown

    End Sub

    Private Sub txt_CA_Address1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CA_Address1.TextChanged

    End Sub

    Private Sub Txt_BloodGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_BloodGroup.TextChanged

    End Sub

    Private Sub Txt_BloodGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_BloodGroup.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_CreditNumber.Focus()
        End If
    End Sub

    Private Sub txt_CreditNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CreditNumber.TextChanged

    End Sub

    Private Sub Txt_PANNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_PANNo.TextChanged

    End Sub

    Private Sub Txt_PANNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PANNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PeriodOfStay.Focus()
        End If
    End Sub

    Private Sub txt_NoOfTimesProposed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NoOfTimesProposed.TextChanged

    End Sub

    Private Sub txt_Agents_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Agents.TextChanged

    End Sub

    Private Sub txt_ReasonApplication_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ReasonApplication.TextChanged

    End Sub

    Private Sub Chk_Prop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Prop.CheckedChanged
        If Chk_Prop.Checked = True Then
            txt_ProposerCode.Enabled = False
            txt_ProposedName.Enabled = False
            Me.grp_proposaldetails.BringToFront()
            Me.grp_proposaldetails.Visible = True
            Me.grp_proposaldetails.Top = 72
            Me.grp_proposaldetails.Left = 50
            SSgrid_Proposal.Focus()
        Else
            txt_ProposerCode.Enabled = True
            txt_ProposedName.Enabled = True
            Me.grp_proposaldetails.Visible = False
            Me.grp_proposaldetails.SendToBack()
        End If
    End Sub

    Private Sub grp_Entrancefeedetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_Entrancefeedetails.Enter

    End Sub

    Private Sub grp_proposaldetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_proposaldetails.Enter

    End Sub

    Private Sub cmd_ProposerOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ProposerOK.Click
        grp_proposaldetails.Visible = False
        Me.Chk_Prop.Checked = True
        If Me.SSgrid_Proposal.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.Chk_Prop.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Proposal, "Proposer")
            With SSgrid_Proposal
                .Col = 1
                .Row = 1
                txt_ProposerCode.Text = .Text
                .Col = 2
                txt_ProposedName.Text = .Text
            End With
        End If
    End Sub

    Private Sub cmd_ProposerCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ProposerCancel.Click
        Me.Chk_Prop.Checked = False
        Me.grp_proposaldetails.Visible = False
        If gdataset.Tables.Contains("Proposer") Then
            gdataset.Tables.Remove("Proposer")
        End If
        Chk_Prop.Focus()
    End Sub
    Public Sub Proposer()
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Proposer Code  | Proposer Name                           "
        vform.vCaption = "Proposer Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            SSgrid_Proposal.Col = 1
            SSgrid_Proposal.Row = SSgrid_Proposal.ActiveRow
            SSgrid_Proposal.Text = Trim(vform.keyfield & "")
            SSgrid_Proposal.Col = 2
            SSgrid_Proposal.Row = SSgrid_Proposal.ActiveRow
            SSgrid_Proposal.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Public Sub Seconder()
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Seconder Code  | Seconder Name                           "
        vform.vCaption = "Seconder Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            SSgrid_Seconder.Col = 1
            SSgrid_Seconder.Row = SSgrid_Seconder.ActiveRow
            SSgrid_Seconder.Text = Trim(vform.keyfield & "")
            SSgrid_Seconder.Col = 2
            SSgrid_Seconder.Row = SSgrid_Seconder.ActiveRow
            SSgrid_Seconder.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub SSgrid_Proposal_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Proposal.KeyDownEvent
        Dim mcode As String
        Dim i As Integer
        With SSgrid_Proposal
            i = .ActiveRow
            .Col = 1
            .Row = i
            If e.keyCode = Keys.Enter Then
                If .ActiveCol = 1 Then
                    If Trim(.Text) = "" Then
                        Call Proposer()
                    Else
                        mcode = Trim(.Text)
                        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster where mcode = '" & mcode & "'"
                        gconnection.getDataSet(gSQLString, "mPro")
                        If gdataset.Tables("mPro").Rows.Count > 0 Then
                            .Col = 1
                            .Row = i
                            .Text = gdataset.Tables("mPro").Rows(0).Item("mcode")
                            .Col = 2
                            .Row = i
                            .Text = gdataset.Tables("mPro").Rows(0).Item("mname")
                        End If
                    End If
                ElseIf .ActiveCol = 2 Then
                    .SetActiveCell(0, i + 1)
                End If
            End If
            If e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
            End If
        End With
    End Sub

    Private Sub Chk_Sec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Sec.CheckedChanged
        If Chk_Sec.Checked = True Then
            txt_SeconderCode.Enabled = False
            txt_SeconderName.Enabled = False
            Me.grp_Seconderdetails.BringToFront()
            Me.grp_Seconderdetails.Visible = True
            Me.grp_Seconderdetails.Top = 72
            Me.grp_Seconderdetails.Left = 50
            SSgrid_Seconder.Focus()
        Else
            txt_SeconderCode.Enabled = True
            txt_SeconderName.Enabled = True
            Me.grp_Seconderdetails.Visible = False
            Me.grp_Seconderdetails.SendToBack()
        End If
    End Sub

    Private Sub cmd_SeconderOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SeconderOK.Click
        grp_Seconderdetails.Visible = False
        Me.Chk_Sec.Checked = True
        If Me.SSgrid_Seconder.DataRowCnt <= 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.Chk_Sec.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Seconder, "Seconder")
            With SSgrid_Seconder
                .Col = 1
                .Row = 1
                txt_SeconderCode.Text = .Text
                .Col = 2
                txt_SeconderName.Text = .Text
            End With
        End If
    End Sub

    Private Sub cmd_SeconderCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SeconderCancel.Click
        Me.Chk_Sec.Checked = False
        Me.grp_Seconderdetails.Visible = False
        If gdataset.Tables.Contains("Seconder") Then
            gdataset.Tables.Remove("Seconder")
        End If
        Chk_Prop.Focus()
    End Sub

    Private Sub SSgrid_Seconder_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Seconder.KeyDownEvent
        Dim mcode As String
        Dim i As Integer
        With SSgrid_Seconder
            i = .ActiveRow
            .Col = 1
            .Row = i
            If e.keyCode = Keys.Enter Then
                If .ActiveCol = 1 Then
                    If Trim(.Text) = "" Then
                        Call Seconder()
                    Else
                        mcode = Trim(.Text)
                        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster where mcode = '" & mcode & "'"
                        gconnection.getDataSet(gSQLString, "mSec")
                        If gdataset.Tables("mSec").Rows.Count > 0 Then
                            .Col = 1
                            .Row = i
                            .Text = gdataset.Tables("mSec").Rows(0).Item("mcode")
                            .Col = 2
                            .Row = i
                            .Text = gdataset.Tables("mSec").Rows(0).Item("mname")
                        End If
                    End If
                ElseIf .ActiveCol = 2 Then
                    .SetActiveCell(0, i + 1)
                End If
            End If
            If e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
            End If
        End With
    End Sub


    Private Sub SIGNATURE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGNATURE.CheckedChanged

    End Sub

    Private Sub txt_BA_PhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_PhoneNo.TextChanged

    End Sub

    Private Sub GroupBox11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox11.Enter

    End Sub
    Private Sub txt_MemberCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.LostFocus
        If Trim(txt_MemberCode.Text) <> "" Then
            ssgrid_currentstatus.SetActiveCell(1, 1)
        End If
    End Sub

    Private Sub txt_fmcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fmcode.TextChanged

    End Sub

    Private Sub GroupBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GroupBox11.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If dtp_MembershipFrom.Visible = True Then
                dtp_MembershipFrom.Focus()
            Else
                txt_GDRLocker.Focus()
            End If
        End If
    End Sub

    Private Sub txt_HPLocker_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_HPLocker.TextChanged

    End Sub

    Private Sub txt_LDRLocker_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LDRLocker.TextChanged

    End Sub

    Private Sub txt_fmcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fmcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If dtp_MembershipFrom.Visible = True Then
                dtp_MembershipFrom.Focus()
            Else
                txt_GDRLocker.Focus()
            End If
        End If
    End Sub
End Class