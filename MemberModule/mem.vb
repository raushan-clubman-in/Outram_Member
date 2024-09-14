Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Public Class mem
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J, PERIOD As Integer
    Dim expt, dob, doj, sdob, dow As DateTime
    Dim dt As DataTable
    Dim STR_STATUS, STR_TYPE, STR_OPCTION, membertype, posting As String
    Dim Sqlstr, Sqlstr1, sqlstring, Insert(0) As String
    Dim marital, spouse, VALIDITY As String
    Dim Childdob, depdow As Date
    Dim CorporateYN, validation As Boolean
    Dim strPhotoFilePath, strPhotoFilePath_SIG, strPhotoFilePath_Spouse, strPhotoFilePath_SpouseImg, emailst As String
    'Dim emailst As Boolean

    Dim dates As String = "1900/JAN/01"
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;pwd=" & SQL_Password & ";Initial Catalog=  " & gDatabase & ";"
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
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txt_Surname As System.Windows.Forms.TextBox
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_category As System.Windows.Forms.Label
    Friend WithEvents Cmd_MemAddress As System.Windows.Forms.Button
    Friend WithEvents Cmd_MemDep As System.Windows.Forms.Button
    Friend WithEvents Cmd_Education As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents TXT_TITLE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_CurrentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Category As System.Windows.Forms.ComboBox
    Friend WithEvents Img_Signature As System.Windows.Forms.PictureBox
    Friend WithEvents Img_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents Grp_Address As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_RA_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_BA_PA_Copy As System.Windows.Forms.CheckBox
    Friend WithEvents txt_RA_PhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_State As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_BA_PhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_State As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_BA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txt_PA_City As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txt_PA_State As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txt_PA_Phone As System.Windows.Forms.TextBox
    Friend WithEvents grp_ChildrenDetails As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid As AxFPUSpreadADO.AxfpSpread
    'Friend WithEvents SSgrid_Qual As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    'Friend WithEvents SSgrid_Entrancefee As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents cmd_RSIDetails As System.Windows.Forms.Button
    Friend WithEvents grbRSI As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpDFCommission As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmbUnitNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNFDependencies As System.Windows.Forms.TextBox
    Friend WithEvents txtWO As System.Windows.Forms.TextBox
    Friend WithEvents txtRIDCARDNO As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtArmService As System.Windows.Forms.TextBox
    Friend WithEvents txtNBYMEMBERNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtRBYMEMBERNO As System.Windows.Forms.TextBox
    Friend WithEvents dtpDFRelease As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDFCreation As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbRankNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Entrancefee As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_BA_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_MobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_BA_PhoneNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Phone2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_MobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_PhoneNo2 As System.Windows.Forms.TextBox
    Friend WithEvents chk_ContactAddress1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ContactAddress2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ContactAddress3 As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DOJ As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_EXPDT As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DOW As System.Windows.Forms.DateTimePicker
    Friend WithEvents SSgrid_Qual As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRBYMEMBERNO2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNBYMEMBERNAME2 As System.Windows.Forms.TextBox
    Friend WithEvents chk_female As System.Windows.Forms.CheckBox
    Friend WithEvents chk_male As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCode1 As System.Windows.Forms.Button
    Friend WithEvents btn_AccountsDetails As System.Windows.Forms.Button
    Friend WithEvents Grp_AccountsDetails As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Public WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberNo1 As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents dt_sdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Cbo_servives As System.Windows.Forms.ComboBox
    Friend WithEvents txt_PA_PinCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_PA_Mobile As System.Windows.Forms.TextBox
    Protected WithEvents cmd_MemberCode2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblspouse As System.Windows.Forms.Label
    Friend WithEvents txtICNO As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Last As System.Windows.Forms.Label
    Friend WithEvents btn_Entancefee As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Protected WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Grp_Entrancefee As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SeconderName As System.Windows.Forms.TextBox
    Friend WithEvents txt_ProposedName As System.Windows.Forms.TextBox
    Friend WithEvents txt_SeconderCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_ProposerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents sc As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmd_SeconderCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_ProposerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_Newmember As System.Windows.Forms.TextBox
    Friend WithEvents Txt_AppNo As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_Appdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Txt_pancarno As System.Windows.Forms.TextBox
    Friend WithEvents grp_Entrancefeedetails As System.Windows.Forms.GroupBox
    Friend WithEvents SSgrid_Entfee As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Public WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents cmd_EntrancefeeCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_EntrancefeeOK As System.Windows.Forms.Button
    Friend WithEvents chk_EntranceFee As System.Windows.Forms.CheckBox
    Friend WithEvents Rnd_Entrancefeeyes As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Rnd_EntranceNo As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Specialinfo As System.Windows.Forms.Label
    Friend WithEvents txt_Specialinfo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_BloodGroup As System.Windows.Forms.Label
    Friend WithEvents Txt_BloodGroup As System.Windows.Forms.TextBox
    Friend WithEvents txt_CreditNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents chk_Sports As System.Windows.Forms.CheckBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Public WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents cmd_SportsCancel As System.Windows.Forms.Button
    Friend WithEvents cmd_SportsOk As System.Windows.Forms.Button
    Friend WithEvents SSgrid_Sports As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents grp_SportsIntrested As System.Windows.Forms.GroupBox
    Friend WithEvents AxfpSpread1 As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Grp_MemQualification As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Public WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents SSgrid_Qual_det As AxFPUSpreadADO.AxfpSpread
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Cbo_title As System.Windows.Forms.ComboBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Cbo_MaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_designation As System.Windows.Forms.ComboBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Cbo_PState As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PCity As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_BCity As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_BState As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_CCity As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_CState As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_CCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_BCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Protected WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Gpr_Company As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Company As System.Windows.Forms.Button
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Txt_noofEmpolyee As System.Windows.Forms.TextBox
    Friend WithEvents Txt_turnover As System.Windows.Forms.TextBox
    Friend WithEvents Txt_products As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Bussinessinfo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Designation As System.Windows.Forms.TextBox
    Friend WithEvents Txt_companyName As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Professionalinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Txt_AgenttInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents lbl_newmember As System.Windows.Forms.Label
    Public WithEvents Label53 As System.Windows.Forms.Label
    Public WithEvents Label98 As System.Windows.Forms.Label
    Public WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents txt_Spouse As System.Windows.Forms.TextBox
    Friend WithEvents CHK_DOB As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_DOJ As System.Windows.Forms.CheckBox
    Friend WithEvents chk_EXPDT As System.Windows.Forms.CheckBox
    Friend WithEvents ChK_SDOB As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_WDT As System.Windows.Forms.CheckBox
    Friend WithEvents Cbo_Spousesalutation As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_Spousedob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbo_professional As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Maxchar As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Txt_CorporateCode As System.Windows.Forms.TextBox
    Friend WithEvents Img_Spousephoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Chk_spouseFreeze As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Gpx_Spouse As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_CorporateCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Img_Spouse As System.Windows.Forms.PictureBox
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Cbo_relation As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents TXT_CATLIMIT As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MEMLIMIT As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Replacement As System.Windows.Forms.Button
    Friend WithEvents Txt_Replacement As System.Windows.Forms.TextBox
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Txt_Rno As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents IMG_SPOUSESIGN As System.Windows.Forms.PictureBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Txt_GstinNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(mem))
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Img_Signature = New System.Windows.Forms.PictureBox
        Me.Img_Photo = New System.Windows.Forms.PictureBox
        Me.btn_AccountsDetails = New System.Windows.Forms.Button
        Me.cmd_RSIDetails = New System.Windows.Forms.Button
        Me.CmdExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.Cmd_Education = New System.Windows.Forms.Button
        Me.Cmd_MemAddress = New System.Windows.Forms.Button
        Me.Cmd_MemDep = New System.Windows.Forms.Button
        Me.cmd_MemberNo1 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.chk_female = New System.Windows.Forms.CheckBox
        Me.chk_male = New System.Windows.Forms.CheckBox
        Me.lblspouse = New System.Windows.Forms.Label
        Me.dtp_DOW = New System.Windows.Forms.DateTimePicker
        Me.dtp_EXPDT = New System.Windows.Forms.DateTimePicker
        Me.dtp_DOJ = New System.Windows.Forms.DateTimePicker
        Me.dtp_DOB = New System.Windows.Forms.DateTimePicker
        Me.cmbRankNo = New System.Windows.Forms.ComboBox
        Me.Cmb_Category = New System.Windows.Forms.ComboBox
        Me.lbl_category = New System.Windows.Forms.Label
        Me.txt_Surname = New System.Windows.Forms.TextBox
        Me.cbo_CurrentStatus = New System.Windows.Forms.ComboBox
        Me.TXT_TITLE = New System.Windows.Forms.TextBox
        Me.Label112 = New System.Windows.Forms.Label
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.txt_FirstName = New System.Windows.Forms.TextBox
        Me.txt_MiddleName = New System.Windows.Forms.TextBox
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Grp_Address = New System.Windows.Forms.GroupBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Cbo_CCountry = New System.Windows.Forms.ComboBox
        Me.Cbo_BCountry = New System.Windows.Forms.ComboBox
        Me.Cbo_PCountry = New System.Windows.Forms.ComboBox
        Me.Cbo_CCity = New System.Windows.Forms.ComboBox
        Me.Cbo_CState = New System.Windows.Forms.ComboBox
        Me.Cbo_BCity = New System.Windows.Forms.ComboBox
        Me.Cbo_BState = New System.Windows.Forms.ComboBox
        Me.Cbo_PCity = New System.Windows.Forms.ComboBox
        Me.Cbo_PState = New System.Windows.Forms.ComboBox
        Me.chk_ContactAddress3 = New System.Windows.Forms.CheckBox
        Me.chk_ContactAddress2 = New System.Windows.Forms.CheckBox
        Me.chk_ContactAddress1 = New System.Windows.Forms.CheckBox
        Me.txt_RA_Email = New System.Windows.Forms.TextBox
        Me.txt_RA_MobileNo = New System.Windows.Forms.TextBox
        Me.txt_RA_PhoneNo2 = New System.Windows.Forms.TextBox
        Me.txt_BA_Email = New System.Windows.Forms.TextBox
        Me.txt_BA_MobileNo = New System.Windows.Forms.TextBox
        Me.txt_BA_PhoneNo2 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_PA_Email = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_PA_Mobile = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_PA_Phone2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Chk_RA_PA_Copy = New System.Windows.Forms.CheckBox
        Me.chk_PA_Copy = New System.Windows.Forms.CheckBox
        Me.Chk_BA_PA_Copy = New System.Windows.Forms.CheckBox
        Me.txt_RA_PhoneNo = New System.Windows.Forms.TextBox
        Me.txt_RA_PinCode = New System.Windows.Forms.TextBox
        Me.txt_RA_State = New System.Windows.Forms.TextBox
        Me.txt_RA_City = New System.Windows.Forms.TextBox
        Me.txt_RA_Address1 = New System.Windows.Forms.TextBox
        Me.txt_BA_PhoneNo = New System.Windows.Forms.TextBox
        Me.txt_BA_PinCode = New System.Windows.Forms.TextBox
        Me.txt_BA_State = New System.Windows.Forms.TextBox
        Me.txt_BA_City = New System.Windows.Forms.TextBox
        Me.txt_BA_Address1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.txt_PA_State = New System.Windows.Forms.TextBox
        Me.txt_PA_PinCode = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.txt_PA_City = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.txt_PA_Address1 = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.txt_PA_Phone = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.txt_RA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_RA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_BA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_BA_Address2 = New System.Windows.Forms.TextBox
        Me.txt_PA_Address3 = New System.Windows.Forms.TextBox
        Me.txt_PA_Address2 = New System.Windows.Forms.TextBox
        Me.grp_ChildrenDetails = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ssgrid = New AxFPUSpreadADO.AxfpSpread
        Me.grbRSI = New System.Windows.Forms.GroupBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label100 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Cbo_servives = New System.Windows.Forms.ComboBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.cmd_MemberCode2 = New System.Windows.Forms.Button
        Me.cmd_MemberCode1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNBYMEMBERNAME2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRBYMEMBERNO2 = New System.Windows.Forms.TextBox
        Me.cmbUnitNo = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dtpDFCreation = New System.Windows.Forms.DateTimePicker
        Me.dtpDFRelease = New System.Windows.Forms.DateTimePicker
        Me.dtpDFCommission = New System.Windows.Forms.DateTimePicker
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtRBYMEMBERNO = New System.Windows.Forms.TextBox
        Me.txtNFDependencies = New System.Windows.Forms.TextBox
        Me.txtWO = New System.Windows.Forms.TextBox
        Me.txtRIDCARDNO = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtArmService = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNBYMEMBERNAME = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMemberDescription = New System.Windows.Forms.TextBox
        Me.txt_SeconderName = New System.Windows.Forms.TextBox
        Me.txt_ProposedName = New System.Windows.Forms.TextBox
        Me.txt_SeconderCode = New System.Windows.Forms.TextBox
        Me.txt_ProposerCode = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.sc = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.cmd_SeconderCodeHelp = New System.Windows.Forms.Button
        Me.cmd_ProposerCodeHelp = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtICNO = New System.Windows.Forms.TextBox
        Me.SSgrid_Entrancefee = New AxFPUSpreadADO.AxfpSpread
        Me.SSgrid_Qual = New AxFPUSpreadADO.AxfpSpread
        Me.Grp_AccountsDetails = New System.Windows.Forms.GroupBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label32 = New System.Windows.Forms.Label
        Me.dt_sdob = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Lbl_Last = New System.Windows.Forms.Label
        Me.btn_Entancefee = New System.Windows.Forms.Button
        Me.Grp_Entrancefee = New System.Windows.Forms.GroupBox
        Me.Label97 = New System.Windows.Forms.Label
        Me.chk_Sports = New System.Windows.Forms.CheckBox
        Me.txt_CreditNumber = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.Lbl_BloodGroup = New System.Windows.Forms.Label
        Me.Txt_BloodGroup = New System.Windows.Forms.TextBox
        Me.txt_Specialinfo = New System.Windows.Forms.TextBox
        Me.lbl_Specialinfo = New System.Windows.Forms.Label
        Me.Rnd_EntranceNo = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Rnd_Entrancefeeyes = New System.Windows.Forms.RadioButton
        Me.Txt_pancarno = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label40 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Txt_AppNo = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Dtp_Appdate = New System.Windows.Forms.DateTimePicker
        Me.Txt_Newmember = New System.Windows.Forms.TextBox
        Me.lbl_newmember = New System.Windows.Forms.Label
        Me.grp_Entrancefeedetails = New System.Windows.Forms.GroupBox
        Me.SSgrid_Entfee = New AxFPUSpreadADO.AxfpSpread
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.cmd_EntrancefeeCancel = New System.Windows.Forms.Button
        Me.cmd_EntrancefeeOK = New System.Windows.Forms.Button
        Me.chk_EntranceFee = New System.Windows.Forms.CheckBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.cmd_SportsCancel = New System.Windows.Forms.Button
        Me.cmd_SportsOk = New System.Windows.Forms.Button
        Me.SSgrid_Sports = New AxFPUSpreadADO.AxfpSpread
        Me.grp_SportsIntrested = New System.Windows.Forms.GroupBox
        Me.AxfpSpread1 = New AxFPUSpreadADO.AxfpSpread
        Me.Grp_MemQualification = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.SSgrid_Qual_det = New AxFPUSpreadADO.AxfpSpread
        Me.Label56 = New System.Windows.Forms.Label
        Me.Cbo_title = New System.Windows.Forms.ComboBox
        Me.Cbo_MaritalStatus = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Cbo_designation = New System.Windows.Forms.ComboBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Btn_Company = New System.Windows.Forms.Button
        Me.Gpr_Company = New System.Windows.Forms.GroupBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Txt_Professionalinfo = New System.Windows.Forms.TextBox
        Me.Txt_noofEmpolyee = New System.Windows.Forms.TextBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.Txt_AgenttInfo = New System.Windows.Forms.TextBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Txt_turnover = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.Txt_products = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Txt_Bussinessinfo = New System.Windows.Forms.TextBox
        Me.Txt_Designation = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label75 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker
        Me.Label82 = New System.Windows.Forms.Label
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.Label83 = New System.Windows.Forms.Label
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.TextBox26 = New System.Windows.Forms.TextBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Txt_companyName = New System.Windows.Forms.TextBox
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.Cbo_professional = New System.Windows.Forms.ComboBox
        Me.Label95 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Txt_Replacement = New System.Windows.Forms.TextBox
        Me.txt_Spouse = New System.Windows.Forms.TextBox
        Me.Cbo_Spousesalutation = New System.Windows.Forms.ComboBox
        Me.Label99 = New System.Windows.Forms.Label
        Me.Dtp_Spousedob = New System.Windows.Forms.DateTimePicker
        Me.CHK_DOB = New System.Windows.Forms.CheckBox
        Me.CHK_DOJ = New System.Windows.Forms.CheckBox
        Me.chk_EXPDT = New System.Windows.Forms.CheckBox
        Me.ChK_SDOB = New System.Windows.Forms.CheckBox
        Me.CHK_WDT = New System.Windows.Forms.CheckBox
        Me.Label_Maxchar = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Txt_CorporateCode = New System.Windows.Forms.TextBox
        Me.Img_Spousephoto = New System.Windows.Forms.PictureBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.Chk_spouseFreeze = New System.Windows.Forms.CheckBox
        Me.Gpx_Spouse = New System.Windows.Forms.GroupBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.cmd_CorporateCodeHelp = New System.Windows.Forms.Button
        Me.Img_Spouse = New System.Windows.Forms.PictureBox
        Me.Label102 = New System.Windows.Forms.Label
        Me.Cbo_relation = New System.Windows.Forms.ComboBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.TXT_CATLIMIT = New System.Windows.Forms.TextBox
        Me.TXT_MEMLIMIT = New System.Windows.Forms.TextBox
        Me.Label103 = New System.Windows.Forms.Label
        Me.Cmd_Replacement = New System.Windows.Forms.Button
        Me.Label104 = New System.Windows.Forms.Label
        Me.Txt_Rno = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.IMG_SPOUSESIGN = New System.Windows.Forms.PictureBox
        Me.Label105 = New System.Windows.Forms.Label
        Me.Txt_GstinNo = New System.Windows.Forms.TextBox
        Me.Grp_Address.SuspendLayout()
        Me.grp_ChildrenDetails.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRSI.SuspendLayout()
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSgrid_Qual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_AccountsDetails.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Entrancefee.SuspendLayout()
        Me.grp_Entrancefeedetails.SuspendLayout()
        CType(Me.SSgrid_Entfee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSgrid_Sports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_SportsIntrested.SuspendLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_MemQualification.SuspendLayout()
        CType(Me.SSgrid_Qual_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpr_Company.SuspendLayout()
        Me.Gpx_Spouse.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(848, 152)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(144, 18)
        Me.Label30.TabIndex = 662
        Me.Label30.Text = "Member Signature "
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(856, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 18)
        Me.Label29.TabIndex = 661
        Me.Label29.Text = "Member Photo"
        '
        'Img_Signature
        '
        Me.Img_Signature.BackColor = System.Drawing.Color.Transparent
        Me.Img_Signature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Signature.Location = New System.Drawing.Point(840, 176)
        Me.Img_Signature.Name = "Img_Signature"
        Me.Img_Signature.Size = New System.Drawing.Size(152, 32)
        Me.Img_Signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Signature.TabIndex = 600
        Me.Img_Signature.TabStop = False
        '
        'Img_Photo
        '
        Me.Img_Photo.BackColor = System.Drawing.Color.Transparent
        Me.Img_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Photo.Location = New System.Drawing.Point(856, 40)
        Me.Img_Photo.Name = "Img_Photo"
        Me.Img_Photo.Size = New System.Drawing.Size(104, 104)
        Me.Img_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Photo.TabIndex = 601
        Me.Img_Photo.TabStop = False
        '
        'btn_AccountsDetails
        '
        Me.btn_AccountsDetails.BackColor = System.Drawing.Color.White
        Me.btn_AccountsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AccountsDetails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AccountsDetails.ForeColor = System.Drawing.Color.White
        Me.btn_AccountsDetails.Image = CType(resources.GetObject("btn_AccountsDetails.Image"), System.Drawing.Image)
        Me.btn_AccountsDetails.Location = New System.Drawing.Point(856, 728)
        Me.btn_AccountsDetails.Name = "btn_AccountsDetails"
        Me.btn_AccountsDetails.Size = New System.Drawing.Size(112, 32)
        Me.btn_AccountsDetails.TabIndex = 27
        Me.btn_AccountsDetails.Text = "Accounts Details"
        Me.btn_AccountsDetails.Visible = False
        '
        'cmd_RSIDetails
        '
        Me.cmd_RSIDetails.BackColor = System.Drawing.Color.Transparent
        Me.cmd_RSIDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_RSIDetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_RSIDetails.ForeColor = System.Drawing.Color.White
        Me.cmd_RSIDetails.Image = CType(resources.GetObject("cmd_RSIDetails.Image"), System.Drawing.Image)
        Me.cmd_RSIDetails.Location = New System.Drawing.Point(848, 624)
        Me.cmd_RSIDetails.Name = "cmd_RSIDetails"
        Me.cmd_RSIDetails.Size = New System.Drawing.Size(136, 40)
        Me.cmd_RSIDetails.TabIndex = 26
        Me.cmd_RSIDetails.Text = "Proposer/Seconder"
        '
        'CmdExport
        '
        Me.CmdExport.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExport.ForeColor = System.Drawing.Color.White
        Me.CmdExport.Image = CType(resources.GetObject("CmdExport.Image"), System.Drawing.Image)
        Me.CmdExport.Location = New System.Drawing.Point(448, 696)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(136, 32)
        Me.CmdExport.TabIndex = 31
        Me.CmdExport.Text = "Export[F12]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.White
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(848, 384)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(136, 40)
        Me.CmdClear.TabIndex = 29
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.White
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(848, 424)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(136, 40)
        Me.CmdAdd.TabIndex = 28
        Me.CmdAdd.Text = "Add [F7]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.White
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(560, 728)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(136, 28)
        Me.CmdView.TabIndex = 30
        Me.CmdView.Text = " View[F9]"
        Me.CmdView.Visible = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(848, 664)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(136, 32)
        Me.cmdexit.TabIndex = 32
        Me.cmdexit.Text = "Exit[F11]"
        '
        'Cmd_Education
        '
        Me.Cmd_Education.BackColor = System.Drawing.Color.White
        Me.Cmd_Education.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Education.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Education.ForeColor = System.Drawing.Color.White
        Me.Cmd_Education.Image = CType(resources.GetObject("Cmd_Education.Image"), System.Drawing.Image)
        Me.Cmd_Education.Location = New System.Drawing.Point(312, 696)
        Me.Cmd_Education.Name = "Cmd_Education"
        Me.Cmd_Education.Size = New System.Drawing.Size(112, 32)
        Me.Cmd_Education.TabIndex = 25
        Me.Cmd_Education.Text = "Member Education"
        Me.Cmd_Education.Visible = False
        '
        'Cmd_MemAddress
        '
        Me.Cmd_MemAddress.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_MemAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_MemAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemAddress.ForeColor = System.Drawing.Color.White
        Me.Cmd_MemAddress.Image = CType(resources.GetObject("Cmd_MemAddress.Image"), System.Drawing.Image)
        Me.Cmd_MemAddress.Location = New System.Drawing.Point(848, 544)
        Me.Cmd_MemAddress.Name = "Cmd_MemAddress"
        Me.Cmd_MemAddress.Size = New System.Drawing.Size(136, 40)
        Me.Cmd_MemAddress.TabIndex = 24
        Me.Cmd_MemAddress.Text = "Member Address"
        '
        'Cmd_MemDep
        '
        Me.Cmd_MemDep.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_MemDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_MemDep.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemDep.ForeColor = System.Drawing.Color.White
        Me.Cmd_MemDep.Image = CType(resources.GetObject("Cmd_MemDep.Image"), System.Drawing.Image)
        Me.Cmd_MemDep.Location = New System.Drawing.Point(848, 584)
        Me.Cmd_MemDep.Name = "Cmd_MemDep"
        Me.Cmd_MemDep.Size = New System.Drawing.Size(136, 40)
        Me.Cmd_MemDep.TabIndex = 25
        Me.Cmd_MemDep.Text = "Dependent Details"
        '
        'cmd_MemberNo1
        '
        Me.cmd_MemberNo1.Image = CType(resources.GetObject("cmd_MemberNo1.Image"), System.Drawing.Image)
        Me.cmd_MemberNo1.Location = New System.Drawing.Point(280, 48)
        Me.cmd_MemberNo1.Name = "cmd_MemberNo1"
        Me.cmd_MemberNo1.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberNo1.TabIndex = 666
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(848, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 18)
        Me.Label13.TabIndex = 665
        Me.Label13.Text = "Spouse Photo"
        Me.Label13.Visible = False
        '
        'chk_female
        '
        Me.chk_female.BackColor = System.Drawing.Color.Transparent
        Me.chk_female.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_female.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_female.Location = New System.Drawing.Point(240, 272)
        Me.chk_female.Name = "chk_female"
        Me.chk_female.Size = New System.Drawing.Size(88, 20)
        Me.chk_female.TabIndex = 20
        Me.chk_female.Text = "Female"
        '
        'chk_male
        '
        Me.chk_male.BackColor = System.Drawing.Color.Transparent
        Me.chk_male.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_male.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_male.Location = New System.Drawing.Point(176, 272)
        Me.chk_male.Name = "chk_male"
        Me.chk_male.Size = New System.Drawing.Size(64, 20)
        Me.chk_male.TabIndex = 19
        Me.chk_male.Text = "Male"
        '
        'lblspouse
        '
        Me.lblspouse.BackColor = System.Drawing.Color.Transparent
        Me.lblspouse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspouse.Location = New System.Drawing.Point(0, 40)
        Me.lblspouse.Name = "lblspouse"
        Me.lblspouse.Size = New System.Drawing.Size(136, 24)
        Me.lblspouse.TabIndex = 660
        Me.lblspouse.Text = "Spouse Name"
        '
        'dtp_DOW
        '
        Me.dtp_DOW.CustomFormat = "dd/MM/yyyy"
        Me.dtp_DOW.Enabled = False
        Me.dtp_DOW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOW.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DOW.Location = New System.Drawing.Point(472, 40)
        Me.dtp_DOW.Name = "dtp_DOW"
        Me.dtp_DOW.Size = New System.Drawing.Size(96, 21)
        Me.dtp_DOW.TabIndex = 18
        '
        'dtp_EXPDT
        '
        Me.dtp_EXPDT.CustomFormat = "dd/MM/yyyy"
        Me.dtp_EXPDT.Enabled = False
        Me.dtp_EXPDT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_EXPDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_EXPDT.Location = New System.Drawing.Point(504, 208)
        Me.dtp_EXPDT.Name = "dtp_EXPDT"
        Me.dtp_EXPDT.Size = New System.Drawing.Size(96, 21)
        Me.dtp_EXPDT.TabIndex = 15
        '
        'dtp_DOJ
        '
        Me.dtp_DOJ.CustomFormat = "dd/MM/yyyy"
        Me.dtp_DOJ.Enabled = False
        Me.dtp_DOJ.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DOJ.Location = New System.Drawing.Point(504, 176)
        Me.dtp_DOJ.Name = "dtp_DOJ"
        Me.dtp_DOJ.Size = New System.Drawing.Size(96, 21)
        Me.dtp_DOJ.TabIndex = 13
        '
        'dtp_DOB
        '
        Me.dtp_DOB.CustomFormat = "dd/MM/yyyy"
        Me.dtp_DOB.Enabled = False
        Me.dtp_DOB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_DOB.Location = New System.Drawing.Point(504, 144)
        Me.dtp_DOB.Name = "dtp_DOB"
        Me.dtp_DOB.Size = New System.Drawing.Size(96, 21)
        Me.dtp_DOB.TabIndex = 8
        '
        'cmbRankNo
        '
        Me.cmbRankNo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRankNo.Location = New System.Drawing.Point(1024, 192)
        Me.cmbRankNo.Name = "cmbRankNo"
        Me.cmbRankNo.Size = New System.Drawing.Size(96, 24)
        Me.cmbRankNo.TabIndex = 2
        Me.cmbRankNo.Visible = False
        '
        'Cmb_Category
        '
        Me.Cmb_Category.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cmb_Category.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Category.Enabled = False
        Me.Cmb_Category.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Category.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cmb_Category.ItemHeight = 16
        Me.Cmb_Category.Location = New System.Drawing.Point(504, 48)
        Me.Cmb_Category.Name = "Cmb_Category"
        Me.Cmb_Category.Size = New System.Drawing.Size(336, 24)
        Me.Cmb_Category.TabIndex = 9
        '
        'lbl_category
        '
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(342, 48)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_category.Size = New System.Drawing.Size(136, 22)
        Me.lbl_category.TabIndex = 128
        Me.lbl_category.Text = "Sub Category"
        '
        'txt_Surname
        '
        Me.txt_Surname.BackColor = System.Drawing.Color.White
        Me.txt_Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Surname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Surname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Surname.Location = New System.Drawing.Point(176, 240)
        Me.txt_Surname.MaxLength = 35
        Me.txt_Surname.Name = "txt_Surname"
        Me.txt_Surname.Size = New System.Drawing.Size(176, 22)
        Me.txt_Surname.TabIndex = 6
        Me.txt_Surname.Text = ""
        '
        'cbo_CurrentStatus
        '
        Me.cbo_CurrentStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_CurrentStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_CurrentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_CurrentStatus.Enabled = False
        Me.cbo_CurrentStatus.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_CurrentStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_CurrentStatus.ItemHeight = 16
        Me.cbo_CurrentStatus.Location = New System.Drawing.Point(504, 80)
        Me.cbo_CurrentStatus.Name = "cbo_CurrentStatus"
        Me.cbo_CurrentStatus.Size = New System.Drawing.Size(96, 24)
        Me.cbo_CurrentStatus.TabIndex = 10
        '
        'TXT_TITLE
        '
        Me.TXT_TITLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TITLE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_TITLE.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TITLE.Location = New System.Drawing.Point(304, 128)
        Me.TXT_TITLE.Name = "TXT_TITLE"
        Me.TXT_TITLE.Size = New System.Drawing.Size(48, 22)
        Me.TXT_TITLE.TabIndex = 3
        Me.TXT_TITLE.Text = ""
        '
        'Label112
        '
        Me.Label112.BackColor = System.Drawing.Color.Transparent
        Me.Label112.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(256, 128)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(56, 22)
        Me.Label112.TabIndex = 619
        Me.Label112.Text = "Initial"
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.SystemColors.Control
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MemberCode.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MemberCode.Location = New System.Drawing.Point(176, 48)
        Me.txt_MemberCode.MaxLength = 10
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(102, 22)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'txt_FirstName
        '
        Me.txt_FirstName.BackColor = System.Drawing.Color.White
        Me.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_FirstName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_FirstName.Location = New System.Drawing.Point(176, 168)
        Me.txt_FirstName.MaxLength = 35
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(176, 22)
        Me.txt_FirstName.TabIndex = 4
        Me.txt_FirstName.Text = ""
        '
        'txt_MiddleName
        '
        Me.txt_MiddleName.BackColor = System.Drawing.Color.White
        Me.txt_MiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MiddleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MiddleName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MiddleName.Location = New System.Drawing.Point(176, 208)
        Me.txt_MiddleName.MaxLength = 35
        Me.txt_MiddleName.Name = "txt_MiddleName"
        Me.txt_MiddleName.Size = New System.Drawing.Size(176, 22)
        Me.txt_MiddleName.TabIndex = 5
        Me.txt_MiddleName.Text = ""
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cbo_BillingBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_BillingBasis.Enabled = False
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"YEARLY", "HALF YEARLY", "QUARTERLY", "MONTHLY", "NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(504, 112)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(96, 24)
        Me.cbo_BillingBasis.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 623
        Me.Label3.Text = "Subscription Type"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(342, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 625
        Me.Label4.Text = "Current Status"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 616
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(32, 48)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(136, 16)
        Me.lbl_MemberCode.TabIndex = 112
        Me.lbl_MemberCode.Text = "Membership No"
        Me.lbl_MemberCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.White
        Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCategory.Location = New System.Drawing.Point(1288, 24)
        Me.txtCategory.MaxLength = 35
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(114, 21)
        Me.txtCategory.TabIndex = 667
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'Grp_Address
        '
        Me.Grp_Address.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Address.Controls.Add(Me.Label60)
        Me.Grp_Address.Controls.Add(Me.Cbo_CCountry)
        Me.Grp_Address.Controls.Add(Me.Cbo_BCountry)
        Me.Grp_Address.Controls.Add(Me.Cbo_PCountry)
        Me.Grp_Address.Controls.Add(Me.Cbo_CCity)
        Me.Grp_Address.Controls.Add(Me.Cbo_CState)
        Me.Grp_Address.Controls.Add(Me.Cbo_BCity)
        Me.Grp_Address.Controls.Add(Me.Cbo_BState)
        Me.Grp_Address.Controls.Add(Me.Cbo_PCity)
        Me.Grp_Address.Controls.Add(Me.Cbo_PState)
        Me.Grp_Address.Controls.Add(Me.chk_ContactAddress3)
        Me.Grp_Address.Controls.Add(Me.chk_ContactAddress2)
        Me.Grp_Address.Controls.Add(Me.chk_ContactAddress1)
        Me.Grp_Address.Controls.Add(Me.txt_RA_Email)
        Me.Grp_Address.Controls.Add(Me.txt_RA_MobileNo)
        Me.Grp_Address.Controls.Add(Me.txt_RA_PhoneNo2)
        Me.Grp_Address.Controls.Add(Me.txt_BA_Email)
        Me.Grp_Address.Controls.Add(Me.txt_BA_MobileNo)
        Me.Grp_Address.Controls.Add(Me.txt_BA_PhoneNo2)
        Me.Grp_Address.Controls.Add(Me.Label28)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Email)
        Me.Grp_Address.Controls.Add(Me.Label27)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Mobile)
        Me.Grp_Address.Controls.Add(Me.Label24)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Phone2)
        Me.Grp_Address.Controls.Add(Me.Label6)
        Me.Grp_Address.Controls.Add(Me.Label11)
        Me.Grp_Address.Controls.Add(Me.CheckBox2)
        Me.Grp_Address.Controls.Add(Me.Chk_RA_PA_Copy)
        Me.Grp_Address.Controls.Add(Me.chk_PA_Copy)
        Me.Grp_Address.Controls.Add(Me.Chk_BA_PA_Copy)
        Me.Grp_Address.Controls.Add(Me.txt_RA_PhoneNo)
        Me.Grp_Address.Controls.Add(Me.txt_RA_PinCode)
        Me.Grp_Address.Controls.Add(Me.txt_RA_State)
        Me.Grp_Address.Controls.Add(Me.txt_RA_City)
        Me.Grp_Address.Controls.Add(Me.txt_RA_Address1)
        Me.Grp_Address.Controls.Add(Me.txt_BA_PhoneNo)
        Me.Grp_Address.Controls.Add(Me.txt_BA_PinCode)
        Me.Grp_Address.Controls.Add(Me.txt_BA_State)
        Me.Grp_Address.Controls.Add(Me.txt_BA_City)
        Me.Grp_Address.Controls.Add(Me.txt_BA_Address1)
        Me.Grp_Address.Controls.Add(Me.Label1)
        Me.Grp_Address.Controls.Add(Me.Label64)
        Me.Grp_Address.Controls.Add(Me.Label65)
        Me.Grp_Address.Controls.Add(Me.Label69)
        Me.Grp_Address.Controls.Add(Me.Label66)
        Me.Grp_Address.Controls.Add(Me.txt_PA_State)
        Me.Grp_Address.Controls.Add(Me.txt_PA_PinCode)
        Me.Grp_Address.Controls.Add(Me.Label67)
        Me.Grp_Address.Controls.Add(Me.txt_PA_City)
        Me.Grp_Address.Controls.Add(Me.Label68)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Address1)
        Me.Grp_Address.Controls.Add(Me.Label63)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Phone)
        Me.Grp_Address.Controls.Add(Me.TextBox1)
        Me.Grp_Address.Controls.Add(Me.TextBox3)
        Me.Grp_Address.Controls.Add(Me.TextBox4)
        Me.Grp_Address.Controls.Add(Me.TextBox5)
        Me.Grp_Address.Controls.Add(Me.TextBox6)
        Me.Grp_Address.Controls.Add(Me.txt_RA_Address3)
        Me.Grp_Address.Controls.Add(Me.txt_RA_Address2)
        Me.Grp_Address.Controls.Add(Me.txt_BA_Address3)
        Me.Grp_Address.Controls.Add(Me.txt_BA_Address2)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Address3)
        Me.Grp_Address.Controls.Add(Me.txt_PA_Address2)
        Me.Grp_Address.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Address.Location = New System.Drawing.Point(48, 368)
        Me.Grp_Address.Name = "Grp_Address"
        Me.Grp_Address.Size = New System.Drawing.Size(776, 320)
        Me.Grp_Address.TabIndex = 28
        Me.Grp_Address.TabStop = False
        Me.Grp_Address.Visible = False
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(16, 152)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 17)
        Me.Label60.TabIndex = 825
        Me.Label60.Text = "Country"
        '
        'Cbo_CCountry
        '
        Me.Cbo_CCountry.BackColor = System.Drawing.Color.White
        Me.Cbo_CCountry.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_CCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_CCountry.Enabled = False
        Me.Cbo_CCountry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_CCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_CCountry.ItemHeight = 15
        Me.Cbo_CCountry.Location = New System.Drawing.Point(552, 148)
        Me.Cbo_CCountry.Name = "Cbo_CCountry"
        Me.Cbo_CCountry.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_CCountry.TabIndex = 824
        '
        'Cbo_BCountry
        '
        Me.Cbo_BCountry.BackColor = System.Drawing.Color.White
        Me.Cbo_BCountry.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_BCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_BCountry.Enabled = False
        Me.Cbo_BCountry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_BCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_BCountry.ItemHeight = 15
        Me.Cbo_BCountry.Location = New System.Drawing.Point(320, 148)
        Me.Cbo_BCountry.Name = "Cbo_BCountry"
        Me.Cbo_BCountry.Size = New System.Drawing.Size(224, 23)
        Me.Cbo_BCountry.TabIndex = 823
        '
        'Cbo_PCountry
        '
        Me.Cbo_PCountry.BackColor = System.Drawing.Color.White
        Me.Cbo_PCountry.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCountry.Enabled = False
        Me.Cbo_PCountry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PCountry.ItemHeight = 15
        Me.Cbo_PCountry.Location = New System.Drawing.Point(96, 144)
        Me.Cbo_PCountry.Name = "Cbo_PCountry"
        Me.Cbo_PCountry.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_PCountry.TabIndex = 822
        '
        'Cbo_CCity
        '
        Me.Cbo_CCity.BackColor = System.Drawing.Color.White
        Me.Cbo_CCity.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_CCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_CCity.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_CCity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_CCity.ItemHeight = 15
        Me.Cbo_CCity.Location = New System.Drawing.Point(552, 96)
        Me.Cbo_CCity.Name = "Cbo_CCity"
        Me.Cbo_CCity.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_CCity.TabIndex = 821
        '
        'Cbo_CState
        '
        Me.Cbo_CState.BackColor = System.Drawing.Color.White
        Me.Cbo_CState.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_CState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_CState.Enabled = False
        Me.Cbo_CState.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_CState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_CState.ItemHeight = 15
        Me.Cbo_CState.Location = New System.Drawing.Point(552, 120)
        Me.Cbo_CState.Name = "Cbo_CState"
        Me.Cbo_CState.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_CState.TabIndex = 820
        '
        'Cbo_BCity
        '
        Me.Cbo_BCity.BackColor = System.Drawing.Color.White
        Me.Cbo_BCity.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_BCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_BCity.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_BCity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_BCity.ItemHeight = 15
        Me.Cbo_BCity.Location = New System.Drawing.Point(320, 96)
        Me.Cbo_BCity.Name = "Cbo_BCity"
        Me.Cbo_BCity.Size = New System.Drawing.Size(224, 23)
        Me.Cbo_BCity.TabIndex = 819
        '
        'Cbo_BState
        '
        Me.Cbo_BState.BackColor = System.Drawing.Color.White
        Me.Cbo_BState.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_BState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_BState.Enabled = False
        Me.Cbo_BState.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_BState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_BState.ItemHeight = 15
        Me.Cbo_BState.Location = New System.Drawing.Point(320, 120)
        Me.Cbo_BState.Name = "Cbo_BState"
        Me.Cbo_BState.Size = New System.Drawing.Size(224, 23)
        Me.Cbo_BState.TabIndex = 818
        '
        'Cbo_PCity
        '
        Me.Cbo_PCity.BackColor = System.Drawing.Color.White
        Me.Cbo_PCity.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCity.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PCity.ItemHeight = 15
        Me.Cbo_PCity.Location = New System.Drawing.Point(96, 96)
        Me.Cbo_PCity.Name = "Cbo_PCity"
        Me.Cbo_PCity.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_PCity.TabIndex = 817
        '
        'Cbo_PState
        '
        Me.Cbo_PState.BackColor = System.Drawing.Color.White
        Me.Cbo_PState.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PState.Enabled = False
        Me.Cbo_PState.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PState.ItemHeight = 15
        Me.Cbo_PState.Location = New System.Drawing.Point(96, 120)
        Me.Cbo_PState.Name = "Cbo_PState"
        Me.Cbo_PState.Size = New System.Drawing.Size(216, 23)
        Me.Cbo_PState.TabIndex = 816
        '
        'chk_ContactAddress3
        '
        Me.chk_ContactAddress3.BackColor = System.Drawing.Color.Transparent
        Me.chk_ContactAddress3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_ContactAddress3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ContactAddress3.Location = New System.Drawing.Point(520, 296)
        Me.chk_ContactAddress3.Name = "chk_ContactAddress3"
        Me.chk_ContactAddress3.Size = New System.Drawing.Size(160, 24)
        Me.chk_ContactAddress3.TabIndex = 809
        Me.chk_ContactAddress3.Text = "Contact Address"
        '
        'chk_ContactAddress2
        '
        Me.chk_ContactAddress2.BackColor = System.Drawing.Color.Transparent
        Me.chk_ContactAddress2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_ContactAddress2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ContactAddress2.Location = New System.Drawing.Point(304, 296)
        Me.chk_ContactAddress2.Name = "chk_ContactAddress2"
        Me.chk_ContactAddress2.Size = New System.Drawing.Size(160, 24)
        Me.chk_ContactAddress2.TabIndex = 808
        Me.chk_ContactAddress2.Text = "Contact Address"
        '
        'chk_ContactAddress1
        '
        Me.chk_ContactAddress1.BackColor = System.Drawing.Color.Transparent
        Me.chk_ContactAddress1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_ContactAddress1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ContactAddress1.Location = New System.Drawing.Point(16, 296)
        Me.chk_ContactAddress1.Name = "chk_ContactAddress1"
        Me.chk_ContactAddress1.Size = New System.Drawing.Size(160, 24)
        Me.chk_ContactAddress1.TabIndex = 807
        Me.chk_ContactAddress1.Text = "Contact Address"
        '
        'txt_RA_Email
        '
        Me.txt_RA_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Email.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Email.Location = New System.Drawing.Point(552, 272)
        Me.txt_RA_Email.MaxLength = 200
        Me.txt_RA_Email.Name = "txt_RA_Email"
        Me.txt_RA_Email.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_Email.TabIndex = 59
        Me.txt_RA_Email.Text = ""
        '
        'txt_RA_MobileNo
        '
        Me.txt_RA_MobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_MobileNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_MobileNo.Location = New System.Drawing.Point(552, 248)
        Me.txt_RA_MobileNo.MaxLength = 12
        Me.txt_RA_MobileNo.Name = "txt_RA_MobileNo"
        Me.txt_RA_MobileNo.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_MobileNo.TabIndex = 58
        Me.txt_RA_MobileNo.Text = ""
        '
        'txt_RA_PhoneNo2
        '
        Me.txt_RA_PhoneNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_PhoneNo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_PhoneNo2.Location = New System.Drawing.Point(552, 224)
        Me.txt_RA_PhoneNo2.MaxLength = 20
        Me.txt_RA_PhoneNo2.Name = "txt_RA_PhoneNo2"
        Me.txt_RA_PhoneNo2.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_PhoneNo2.TabIndex = 57
        Me.txt_RA_PhoneNo2.Text = ""
        '
        'txt_BA_Email
        '
        Me.txt_BA_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Email.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Email.Location = New System.Drawing.Point(320, 272)
        Me.txt_BA_Email.MaxLength = 200
        Me.txt_BA_Email.Name = "txt_BA_Email"
        Me.txt_BA_Email.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_Email.TabIndex = 49
        Me.txt_BA_Email.Text = ""
        '
        'txt_BA_MobileNo
        '
        Me.txt_BA_MobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_MobileNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_MobileNo.Location = New System.Drawing.Point(320, 248)
        Me.txt_BA_MobileNo.MaxLength = 12
        Me.txt_BA_MobileNo.Name = "txt_BA_MobileNo"
        Me.txt_BA_MobileNo.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_MobileNo.TabIndex = 48
        Me.txt_BA_MobileNo.Text = ""
        '
        'txt_BA_PhoneNo2
        '
        Me.txt_BA_PhoneNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_PhoneNo2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_PhoneNo2.Location = New System.Drawing.Point(320, 224)
        Me.txt_BA_PhoneNo2.MaxLength = 20
        Me.txt_BA_PhoneNo2.Name = "txt_BA_PhoneNo2"
        Me.txt_BA_PhoneNo2.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_PhoneNo2.TabIndex = 47
        Me.txt_BA_PhoneNo2.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 272)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 17)
        Me.Label28.TabIndex = 798
        Me.Label28.Text = "Email"
        '
        'txt_PA_Email
        '
        Me.txt_PA_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Email.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Email.Location = New System.Drawing.Point(96, 272)
        Me.txt_PA_Email.MaxLength = 200
        Me.txt_PA_Email.Name = "txt_PA_Email"
        Me.txt_PA_Email.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Email.TabIndex = 39
        Me.txt_PA_Email.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 248)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 17)
        Me.Label27.TabIndex = 796
        Me.Label27.Text = "Mobile No "
        '
        'txt_PA_Mobile
        '
        Me.txt_PA_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Mobile.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Mobile.Location = New System.Drawing.Point(96, 248)
        Me.txt_PA_Mobile.MaxLength = 12
        Me.txt_PA_Mobile.Name = "txt_PA_Mobile"
        Me.txt_PA_Mobile.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Mobile.TabIndex = 38
        Me.txt_PA_Mobile.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 224)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 17)
        Me.Label24.TabIndex = 794
        Me.Label24.Text = "Phone No2 "
        '
        'txt_PA_Phone2
        '
        Me.txt_PA_Phone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Phone2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Phone2.Location = New System.Drawing.Point(96, 224)
        Me.txt_PA_Phone2.MaxLength = 20
        Me.txt_PA_Phone2.Name = "txt_PA_Phone2"
        Me.txt_PA_Phone2.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Phone2.TabIndex = 37
        Me.txt_PA_Phone2.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 20)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "BUSINESS ADDRESS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DarkGray
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label11.Location = New System.Drawing.Point(552, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 20)
        Me.Label11.TabIndex = 178
        Me.Label11.Text = "RESIDENCE  ADDRESS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(768, 1360)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(200, 24)
        Me.CheckBox2.TabIndex = 785
        Me.CheckBox2.Text = "Copy Contact Address"
        '
        'Chk_RA_PA_Copy
        '
        Me.Chk_RA_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_RA_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_RA_PA_Copy.Location = New System.Drawing.Point(312, -116)
        Me.Chk_RA_PA_Copy.Name = "Chk_RA_PA_Copy"
        Me.Chk_RA_PA_Copy.Size = New System.Drawing.Size(192, 116)
        Me.Chk_RA_PA_Copy.TabIndex = 781
        Me.Chk_RA_PA_Copy.Text = "Copy Residence Address"
        '
        'chk_PA_Copy
        '
        Me.chk_PA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.chk_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PA_Copy.Location = New System.Drawing.Point(400, 708)
        Me.chk_PA_Copy.Name = "chk_PA_Copy"
        Me.chk_PA_Copy.Size = New System.Drawing.Size(200, 24)
        Me.chk_PA_Copy.TabIndex = 782
        Me.chk_PA_Copy.Text = "Copy Contact Address"
        '
        'Chk_BA_PA_Copy
        '
        Me.Chk_BA_PA_Copy.BackColor = System.Drawing.Color.Transparent
        Me.Chk_BA_PA_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_BA_PA_Copy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_BA_PA_Copy.Location = New System.Drawing.Point(312, -156)
        Me.Chk_BA_PA_Copy.Name = "Chk_BA_PA_Copy"
        Me.Chk_BA_PA_Copy.Size = New System.Drawing.Size(200, 156)
        Me.Chk_BA_PA_Copy.TabIndex = 783
        Me.Chk_BA_PA_Copy.Text = "Copy Business Address"
        '
        'txt_RA_PhoneNo
        '
        Me.txt_RA_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_PhoneNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_PhoneNo.Location = New System.Drawing.Point(552, 200)
        Me.txt_RA_PhoneNo.MaxLength = 20
        Me.txt_RA_PhoneNo.Name = "txt_RA_PhoneNo"
        Me.txt_RA_PhoneNo.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_PhoneNo.TabIndex = 56
        Me.txt_RA_PhoneNo.Text = ""
        '
        'txt_RA_PinCode
        '
        Me.txt_RA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_PinCode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_PinCode.Location = New System.Drawing.Point(552, 176)
        Me.txt_RA_PinCode.MaxLength = 10
        Me.txt_RA_PinCode.Name = "txt_RA_PinCode"
        Me.txt_RA_PinCode.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_PinCode.TabIndex = 55
        Me.txt_RA_PinCode.Text = ""
        '
        'txt_RA_State
        '
        Me.txt_RA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_State.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_State.Location = New System.Drawing.Point(712, 120)
        Me.txt_RA_State.MaxLength = 25
        Me.txt_RA_State.Name = "txt_RA_State"
        Me.txt_RA_State.Size = New System.Drawing.Size(56, 21)
        Me.txt_RA_State.TabIndex = 54
        Me.txt_RA_State.Text = ""
        '
        'txt_RA_City
        '
        Me.txt_RA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_City.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_City.Location = New System.Drawing.Point(712, 96)
        Me.txt_RA_City.MaxLength = 25
        Me.txt_RA_City.Name = "txt_RA_City"
        Me.txt_RA_City.Size = New System.Drawing.Size(56, 21)
        Me.txt_RA_City.TabIndex = 53
        Me.txt_RA_City.Text = ""
        '
        'txt_RA_Address1
        '
        Me.txt_RA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address1.Location = New System.Drawing.Point(552, 24)
        Me.txt_RA_Address1.MaxLength = 200
        Me.txt_RA_Address1.Name = "txt_RA_Address1"
        Me.txt_RA_Address1.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_Address1.TabIndex = 50
        Me.txt_RA_Address1.Text = ""
        '
        'txt_BA_PhoneNo
        '
        Me.txt_BA_PhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_PhoneNo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_PhoneNo.Location = New System.Drawing.Point(320, 200)
        Me.txt_BA_PhoneNo.MaxLength = 20
        Me.txt_BA_PhoneNo.Name = "txt_BA_PhoneNo"
        Me.txt_BA_PhoneNo.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_PhoneNo.TabIndex = 46
        Me.txt_BA_PhoneNo.Text = ""
        '
        'txt_BA_PinCode
        '
        Me.txt_BA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_PinCode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_PinCode.Location = New System.Drawing.Point(320, 176)
        Me.txt_BA_PinCode.MaxLength = 10
        Me.txt_BA_PinCode.Name = "txt_BA_PinCode"
        Me.txt_BA_PinCode.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_PinCode.TabIndex = 45
        Me.txt_BA_PinCode.Text = ""
        '
        'txt_BA_State
        '
        Me.txt_BA_State.BackColor = System.Drawing.Color.White
        Me.txt_BA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_State.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_State.Location = New System.Drawing.Point(480, 120)
        Me.txt_BA_State.MaxLength = 25
        Me.txt_BA_State.Name = "txt_BA_State"
        Me.txt_BA_State.Size = New System.Drawing.Size(64, 21)
        Me.txt_BA_State.TabIndex = 44
        Me.txt_BA_State.Text = ""
        '
        'txt_BA_City
        '
        Me.txt_BA_City.BackColor = System.Drawing.Color.White
        Me.txt_BA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_City.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_City.Location = New System.Drawing.Point(480, 96)
        Me.txt_BA_City.MaxLength = 25
        Me.txt_BA_City.Name = "txt_BA_City"
        Me.txt_BA_City.Size = New System.Drawing.Size(64, 21)
        Me.txt_BA_City.TabIndex = 43
        Me.txt_BA_City.Text = ""
        '
        'txt_BA_Address1
        '
        Me.txt_BA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address1.Location = New System.Drawing.Point(320, 24)
        Me.txt_BA_Address1.MaxLength = 200
        Me.txt_BA_Address1.Name = "txt_BA_Address1"
        Me.txt_BA_Address1.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_Address1.TabIndex = 40
        Me.txt_BA_Address1.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 20)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "PERMANENT  ADDRESS "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(16, 48)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(79, 17)
        Me.Label64.TabIndex = 790
        Me.Label64.Text = "Address 2 "
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(16, 72)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(79, 17)
        Me.Label65.TabIndex = 791
        Me.Label65.Text = "Address 3 "
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(16, 200)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(79, 17)
        Me.Label69.TabIndex = 792
        Me.Label69.Text = "Phone No1 "
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(16, 104)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(42, 17)
        Me.Label66.TabIndex = 792
        Me.Label66.Text = "City "
        '
        'txt_PA_State
        '
        Me.txt_PA_State.BackColor = System.Drawing.Color.White
        Me.txt_PA_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_State.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_State.Location = New System.Drawing.Point(248, 120)
        Me.txt_PA_State.MaxLength = 25
        Me.txt_PA_State.Name = "txt_PA_State"
        Me.txt_PA_State.Size = New System.Drawing.Size(64, 21)
        Me.txt_PA_State.TabIndex = 34
        Me.txt_PA_State.Text = ""
        '
        'txt_PA_PinCode
        '
        Me.txt_PA_PinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_PinCode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_PinCode.Location = New System.Drawing.Point(96, 176)
        Me.txt_PA_PinCode.MaxLength = 10
        Me.txt_PA_PinCode.Name = "txt_PA_PinCode"
        Me.txt_PA_PinCode.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_PinCode.TabIndex = 35
        Me.txt_PA_PinCode.Text = ""
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(16, 176)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(71, 17)
        Me.Label67.TabIndex = 791
        Me.Label67.Text = "Pin Code "
        '
        'txt_PA_City
        '
        Me.txt_PA_City.BackColor = System.Drawing.Color.White
        Me.txt_PA_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_City.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_City.Location = New System.Drawing.Point(248, 96)
        Me.txt_PA_City.MaxLength = 25
        Me.txt_PA_City.Name = "txt_PA_City"
        Me.txt_PA_City.Size = New System.Drawing.Size(64, 21)
        Me.txt_PA_City.TabIndex = 33
        Me.txt_PA_City.Text = ""
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(16, 128)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(49, 17)
        Me.Label68.TabIndex = 789
        Me.Label68.Text = "State "
        '
        'txt_PA_Address1
        '
        Me.txt_PA_Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address1.Location = New System.Drawing.Point(96, 24)
        Me.txt_PA_Address1.MaxLength = 200
        Me.txt_PA_Address1.Name = "txt_PA_Address1"
        Me.txt_PA_Address1.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Address1.TabIndex = 30
        Me.txt_PA_Address1.Text = ""
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(16, 24)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(71, 17)
        Me.Label63.TabIndex = 789
        Me.Label63.Text = "Address 1"
        '
        'txt_PA_Phone
        '
        Me.txt_PA_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Phone.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Phone.Location = New System.Drawing.Point(96, 200)
        Me.txt_PA_Phone.MaxLength = 20
        Me.txt_PA_Phone.Name = "txt_PA_Phone"
        Me.txt_PA_Phone.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Phone.TabIndex = 36
        Me.txt_PA_Phone.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 248)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 21)
        Me.TextBox1.TabIndex = 795
        Me.TextBox1.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(96, 224)
        Me.TextBox3.MaxLength = 20
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 21)
        Me.TextBox3.TabIndex = 793
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(96, 176)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(208, 21)
        Me.TextBox4.TabIndex = 29
        Me.TextBox4.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(96, 200)
        Me.TextBox5.MaxLength = 20
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(208, 21)
        Me.TextBox5.TabIndex = 30
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(96, 272)
        Me.TextBox6.MaxLength = 20
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(208, 21)
        Me.TextBox6.TabIndex = 797
        Me.TextBox6.Text = ""
        '
        'txt_RA_Address3
        '
        Me.txt_RA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address3.Location = New System.Drawing.Point(552, 72)
        Me.txt_RA_Address3.MaxLength = 50
        Me.txt_RA_Address3.Name = "txt_RA_Address3"
        Me.txt_RA_Address3.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_Address3.TabIndex = 52
        Me.txt_RA_Address3.Text = ""
        '
        'txt_RA_Address2
        '
        Me.txt_RA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_RA_Address2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Address2.Location = New System.Drawing.Point(552, 48)
        Me.txt_RA_Address2.MaxLength = 50
        Me.txt_RA_Address2.Name = "txt_RA_Address2"
        Me.txt_RA_Address2.Size = New System.Drawing.Size(216, 21)
        Me.txt_RA_Address2.TabIndex = 51
        Me.txt_RA_Address2.Text = ""
        '
        'txt_BA_Address3
        '
        Me.txt_BA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address3.Location = New System.Drawing.Point(320, 72)
        Me.txt_BA_Address3.MaxLength = 50
        Me.txt_BA_Address3.Name = "txt_BA_Address3"
        Me.txt_BA_Address3.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_Address3.TabIndex = 42
        Me.txt_BA_Address3.Text = ""
        '
        'txt_BA_Address2
        '
        Me.txt_BA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BA_Address2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BA_Address2.Location = New System.Drawing.Point(320, 48)
        Me.txt_BA_Address2.MaxLength = 50
        Me.txt_BA_Address2.Name = "txt_BA_Address2"
        Me.txt_BA_Address2.Size = New System.Drawing.Size(224, 21)
        Me.txt_BA_Address2.TabIndex = 41
        Me.txt_BA_Address2.Text = ""
        '
        'txt_PA_Address3
        '
        Me.txt_PA_Address3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address3.Location = New System.Drawing.Point(96, 72)
        Me.txt_PA_Address3.MaxLength = 50
        Me.txt_PA_Address3.Name = "txt_PA_Address3"
        Me.txt_PA_Address3.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Address3.TabIndex = 32
        Me.txt_PA_Address3.Text = ""
        '
        'txt_PA_Address2
        '
        Me.txt_PA_Address2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PA_Address2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PA_Address2.Location = New System.Drawing.Point(96, 48)
        Me.txt_PA_Address2.MaxLength = 50
        Me.txt_PA_Address2.Name = "txt_PA_Address2"
        Me.txt_PA_Address2.Size = New System.Drawing.Size(216, 21)
        Me.txt_PA_Address2.TabIndex = 31
        Me.txt_PA_Address2.Text = ""
        '
        'grp_ChildrenDetails
        '
        Me.grp_ChildrenDetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_ChildrenDetails.Controls.Add(Me.Label5)
        Me.grp_ChildrenDetails.Controls.Add(Me.ssgrid)
        Me.grp_ChildrenDetails.Location = New System.Drawing.Point(32, 376)
        Me.grp_ChildrenDetails.Name = "grp_ChildrenDetails"
        Me.grp_ChildrenDetails.Size = New System.Drawing.Size(808, 296)
        Me.grp_ChildrenDetails.TabIndex = 679
        Me.grp_ChildrenDetails.TabStop = False
        Me.grp_ChildrenDetails.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(792, 24)
        Me.Label5.TabIndex = 577
        Me.Label5.Text = "DEPENDENT DETAILS"
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 48)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(792, 240)
        Me.ssgrid.TabIndex = 0
        '
        'grbRSI
        '
        Me.grbRSI.BackColor = System.Drawing.Color.Transparent
        Me.grbRSI.Controls.Add(Me.TextBox14)
        Me.grbRSI.Controls.Add(Me.TextBox16)
        Me.grbRSI.Controls.Add(Me.Label100)
        Me.grbRSI.Controls.Add(Me.Label101)
        Me.grbRSI.Controls.Add(Me.Button3)
        Me.grbRSI.Controls.Add(Me.Label98)
        Me.grbRSI.Controls.Add(Me.Label18)
        Me.grbRSI.Controls.Add(Me.Cbo_servives)
        Me.grbRSI.Controls.Add(Me.Label33)
        Me.grbRSI.Controls.Add(Me.cmd_MemberCode2)
        Me.grbRSI.Controls.Add(Me.cmd_MemberCode1)
        Me.grbRSI.Controls.Add(Me.Label9)
        Me.grbRSI.Controls.Add(Me.txtNBYMEMBERNAME2)
        Me.grbRSI.Controls.Add(Me.Label7)
        Me.grbRSI.Controls.Add(Me.txtRBYMEMBERNO2)
        Me.grbRSI.Controls.Add(Me.cmbUnitNo)
        Me.grbRSI.Controls.Add(Me.Label26)
        Me.grbRSI.Controls.Add(Me.Label25)
        Me.grbRSI.Controls.Add(Me.dtpDFCreation)
        Me.grbRSI.Controls.Add(Me.dtpDFRelease)
        Me.grbRSI.Controls.Add(Me.dtpDFCommission)
        Me.grbRSI.Controls.Add(Me.Label23)
        Me.grbRSI.Controls.Add(Me.txtRBYMEMBERNO)
        Me.grbRSI.Controls.Add(Me.txtNFDependencies)
        Me.grbRSI.Controls.Add(Me.txtWO)
        Me.grbRSI.Controls.Add(Me.txtRIDCARDNO)
        Me.grbRSI.Controls.Add(Me.Label8)
        Me.grbRSI.Controls.Add(Me.txtArmService)
        Me.grbRSI.Controls.Add(Me.Label14)
        Me.grbRSI.Controls.Add(Me.Label15)
        Me.grbRSI.Controls.Add(Me.Label16)
        Me.grbRSI.Controls.Add(Me.txtNBYMEMBERNAME)
        Me.grbRSI.Controls.Add(Me.Label22)
        Me.grbRSI.Controls.Add(Me.Label20)
        Me.grbRSI.Controls.Add(Me.Label10)
        Me.grbRSI.Controls.Add(Me.txtMemberDescription)
        Me.grbRSI.Controls.Add(Me.txt_SeconderName)
        Me.grbRSI.Controls.Add(Me.txt_ProposedName)
        Me.grbRSI.Controls.Add(Me.txt_SeconderCode)
        Me.grbRSI.Controls.Add(Me.txt_ProposerCode)
        Me.grbRSI.Controls.Add(Me.Label50)
        Me.grbRSI.Controls.Add(Me.Label51)
        Me.grbRSI.Controls.Add(Me.sc)
        Me.grbRSI.Controls.Add(Me.Label52)
        Me.grbRSI.Controls.Add(Me.cmd_SeconderCodeHelp)
        Me.grbRSI.Controls.Add(Me.cmd_ProposerCodeHelp)
        Me.grbRSI.Location = New System.Drawing.Point(96, 408)
        Me.grbRSI.Name = "grbRSI"
        Me.grbRSI.Size = New System.Drawing.Size(696, 176)
        Me.grbRSI.TabIndex = 682
        Me.grbRSI.TabStop = False
        Me.grbRSI.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Enabled = False
        Me.TextBox14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.Black
        Me.TextBox14.Location = New System.Drawing.Point(480, 128)
        Me.TextBox14.MaxLength = 35
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(176, 22)
        Me.TextBox14.TabIndex = 713
        Me.TextBox14.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.White
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.Enabled = False
        Me.TextBox16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(176, 128)
        Me.TextBox16.MaxLength = 50
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(104, 22)
        Me.TextBox16.TabIndex = 711
        Me.TextBox16.Text = ""
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.Transparent
        Me.Label100.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(56, 128)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(112, 21)
        Me.Label100.TabIndex = 714
        Me.Label100.Text = "Seconder1 Code"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(352, 128)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(117, 21)
        Me.Label101.TabIndex = 715
        Me.Label101.Text = "Seconder1 Name"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(280, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 20)
        Me.Button3.TabIndex = 712
        Me.Button3.Visible = False
        '
        'Label98
        '
        Me.Label98.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label98.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label98.Image = CType(resources.GetObject("Label98.Image"), System.Drawing.Image)
        Me.Label98.Location = New System.Drawing.Point(0, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(704, 24)
        Me.Label98.TabIndex = 710
        Me.Label98.Text = "PROPOSER/SECONDER DETAILS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1016, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 17)
        Me.Label18.TabIndex = 185
        Me.Label18.Text = "CLUB NAME :"
        Me.Label18.Visible = False
        '
        'Cbo_servives
        '
        Me.Cbo_servives.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_servives.Items.AddRange(New Object() {"ARMY", "Air force", "Navy", "CGOs"})
        Me.Cbo_servives.Location = New System.Drawing.Point(1056, 48)
        Me.Cbo_servives.Name = "Cbo_servives"
        Me.Cbo_servives.Size = New System.Drawing.Size(8, 21)
        Me.Cbo_servives.TabIndex = 184
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(1016, 56)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 17)
        Me.Label33.TabIndex = 183
        Me.Label33.Text = "Belongs TO :"
        Me.Label33.Visible = False
        '
        'cmd_MemberCode2
        '
        Me.cmd_MemberCode2.Image = CType(resources.GetObject("cmd_MemberCode2.Image"), System.Drawing.Image)
        Me.cmd_MemberCode2.Location = New System.Drawing.Point(720, 48)
        Me.cmd_MemberCode2.Name = "cmd_MemberCode2"
        Me.cmd_MemberCode2.Size = New System.Drawing.Size(8, 24)
        Me.cmd_MemberCode2.TabIndex = 182
        '
        'cmd_MemberCode1
        '
        Me.cmd_MemberCode1.Image = CType(resources.GetObject("cmd_MemberCode1.Image"), System.Drawing.Image)
        Me.cmd_MemberCode1.Location = New System.Drawing.Point(720, 16)
        Me.cmd_MemberCode1.Name = "cmd_MemberCode1"
        Me.cmd_MemberCode1.Size = New System.Drawing.Size(8, 24)
        Me.cmd_MemberCode1.TabIndex = 181
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(936, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 17)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "R.BY.MEM.NAME2"
        '
        'txtNBYMEMBERNAME2
        '
        Me.txtNBYMEMBERNAME2.BackColor = System.Drawing.Color.White
        Me.txtNBYMEMBERNAME2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNBYMEMBERNAME2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNBYMEMBERNAME2.Location = New System.Drawing.Point(1048, 128)
        Me.txtNBYMEMBERNAME2.MaxLength = 25
        Me.txtNBYMEMBERNAME2.Name = "txtNBYMEMBERNAME2"
        Me.txtNBYMEMBERNAME2.Size = New System.Drawing.Size(8, 21)
        Me.txtNBYMEMBERNAME2.TabIndex = 179
        Me.txtNBYMEMBERNAME2.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1016, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "R.BY.MEM. NO2"
        Me.Label7.Visible = False
        '
        'txtRBYMEMBERNO2
        '
        Me.txtRBYMEMBERNO2.BackColor = System.Drawing.Color.White
        Me.txtRBYMEMBERNO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRBYMEMBERNO2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtRBYMEMBERNO2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRBYMEMBERNO2.Location = New System.Drawing.Point(1048, 48)
        Me.txtRBYMEMBERNO2.MaxLength = 55
        Me.txtRBYMEMBERNO2.Name = "txtRBYMEMBERNO2"
        Me.txtRBYMEMBERNO2.Size = New System.Drawing.Size(8, 21)
        Me.txtRBYMEMBERNO2.TabIndex = 177
        Me.txtRBYMEMBERNO2.Text = ""
        '
        'cmbUnitNo
        '
        Me.cmbUnitNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitNo.Location = New System.Drawing.Point(952, 136)
        Me.cmbUnitNo.Name = "cmbUnitNo"
        Me.cmbUnitNo.Size = New System.Drawing.Size(400, 21)
        Me.cmbUnitNo.TabIndex = 174
        Me.cmbUnitNo.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(1016, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(108, 17)
        Me.Label26.TabIndex = 173
        Me.Label26.Text = "R.BY.MEM.NAME1"
        Me.Label26.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1032, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 17)
        Me.Label25.TabIndex = 172
        Me.Label25.Text = "R.BY.MEM. NO1"
        Me.Label25.Visible = False
        '
        'dtpDFCreation
        '
        Me.dtpDFCreation.CustomFormat = "dd/MM/yyyy"
        Me.dtpDFCreation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDFCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDFCreation.Location = New System.Drawing.Point(1056, 128)
        Me.dtpDFCreation.Name = "dtpDFCreation"
        Me.dtpDFCreation.Size = New System.Drawing.Size(32, 21)
        Me.dtpDFCreation.TabIndex = 170
        '
        'dtpDFRelease
        '
        Me.dtpDFRelease.CustomFormat = "dd/MM/yyyy"
        Me.dtpDFRelease.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDFRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDFRelease.Location = New System.Drawing.Point(1056, 88)
        Me.dtpDFRelease.Name = "dtpDFRelease"
        Me.dtpDFRelease.Size = New System.Drawing.Size(32, 21)
        Me.dtpDFRelease.TabIndex = 169
        '
        'dtpDFCommission
        '
        Me.dtpDFCommission.CustomFormat = "dd/MM/yyyy"
        Me.dtpDFCommission.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDFCommission.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDFCommission.Location = New System.Drawing.Point(1056, 48)
        Me.dtpDFCommission.Name = "dtpDFCommission"
        Me.dtpDFCommission.Size = New System.Drawing.Size(32, 21)
        Me.dtpDFCommission.TabIndex = 168
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(904, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(138, 17)
        Me.Label23.TabIndex = 167
        Me.Label23.Text = "No.of Dependencies"
        '
        'txtRBYMEMBERNO
        '
        Me.txtRBYMEMBERNO.BackColor = System.Drawing.Color.White
        Me.txtRBYMEMBERNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRBYMEMBERNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtRBYMEMBERNO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRBYMEMBERNO.Location = New System.Drawing.Point(1048, 16)
        Me.txtRBYMEMBERNO.MaxLength = 55
        Me.txtRBYMEMBERNO.Name = "txtRBYMEMBERNO"
        Me.txtRBYMEMBERNO.Size = New System.Drawing.Size(8, 21)
        Me.txtRBYMEMBERNO.TabIndex = 166
        Me.txtRBYMEMBERNO.Text = ""
        '
        'txtNFDependencies
        '
        Me.txtNFDependencies.BackColor = System.Drawing.Color.White
        Me.txtNFDependencies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNFDependencies.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNFDependencies.Location = New System.Drawing.Point(1048, 168)
        Me.txtNFDependencies.MaxLength = 15
        Me.txtNFDependencies.Name = "txtNFDependencies"
        Me.txtNFDependencies.Size = New System.Drawing.Size(8, 21)
        Me.txtNFDependencies.TabIndex = 162
        Me.txtNFDependencies.Text = ""
        '
        'txtWO
        '
        Me.txtWO.BackColor = System.Drawing.Color.White
        Me.txtWO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWO.Location = New System.Drawing.Point(648, 176)
        Me.txtWO.MaxLength = 15
        Me.txtWO.Name = "txtWO"
        Me.txtWO.Size = New System.Drawing.Size(8, 21)
        Me.txtWO.TabIndex = 161
        Me.txtWO.Text = ""
        '
        'txtRIDCARDNO
        '
        Me.txtRIDCARDNO.BackColor = System.Drawing.Color.White
        Me.txtRIDCARDNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRIDCARDNO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRIDCARDNO.Location = New System.Drawing.Point(1056, 80)
        Me.txtRIDCARDNO.MaxLength = 20
        Me.txtRIDCARDNO.Name = "txtRIDCARDNO"
        Me.txtRIDCARDNO.Size = New System.Drawing.Size(8, 21)
        Me.txtRIDCARDNO.TabIndex = 160
        Me.txtRIDCARDNO.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(960, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Arm/Service"
        '
        'txtArmService
        '
        Me.txtArmService.BackColor = System.Drawing.Color.White
        Me.txtArmService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArmService.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArmService.Location = New System.Drawing.Point(1056, 144)
        Me.txtArmService.MaxLength = 25
        Me.txtArmService.Name = "txtArmService"
        Me.txtArmService.Size = New System.Drawing.Size(8, 21)
        Me.txtArmService.TabIndex = 156
        Me.txtArmService.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1016, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 17)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Date of  Release"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(616, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 17)
        Me.Label15.TabIndex = 155
        Me.Label15.Text = "W/O"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(912, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 17)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Date of  Creation "
        '
        'txtNBYMEMBERNAME
        '
        Me.txtNBYMEMBERNAME.BackColor = System.Drawing.Color.White
        Me.txtNBYMEMBERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNBYMEMBERNAME.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNBYMEMBERNAME.Location = New System.Drawing.Point(1048, 88)
        Me.txtNBYMEMBERNAME.MaxLength = 25
        Me.txtNBYMEMBERNAME.Name = "txtNBYMEMBERNAME"
        Me.txtNBYMEMBERNAME.Size = New System.Drawing.Size(8, 21)
        Me.txtNBYMEMBERNAME.TabIndex = 151
        Me.txtNBYMEMBERNAME.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1000, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(138, 17)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "Date of Commission"
        Me.Label22.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1024, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 17)
        Me.Label20.TabIndex = 164
        Me.Label20.Text = "R.IDCARD NO"
        Me.Label20.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(992, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 163
        Me.Label10.Text = "M.Description"
        Me.Label10.Visible = False
        '
        'txtMemberDescription
        '
        Me.txtMemberDescription.BackColor = System.Drawing.Color.White
        Me.txtMemberDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemberDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberDescription.Location = New System.Drawing.Point(1064, 48)
        Me.txtMemberDescription.MaxLength = 10
        Me.txtMemberDescription.Name = "txtMemberDescription"
        Me.txtMemberDescription.Size = New System.Drawing.Size(8, 21)
        Me.txtMemberDescription.TabIndex = 158
        Me.txtMemberDescription.Text = ""
        Me.txtMemberDescription.Visible = False
        '
        'txt_SeconderName
        '
        Me.txt_SeconderName.BackColor = System.Drawing.Color.White
        Me.txt_SeconderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SeconderName.Enabled = False
        Me.txt_SeconderName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeconderName.ForeColor = System.Drawing.Color.Black
        Me.txt_SeconderName.Location = New System.Drawing.Point(480, 96)
        Me.txt_SeconderName.MaxLength = 35
        Me.txt_SeconderName.Name = "txt_SeconderName"
        Me.txt_SeconderName.ReadOnly = True
        Me.txt_SeconderName.Size = New System.Drawing.Size(176, 22)
        Me.txt_SeconderName.TabIndex = 26
        Me.txt_SeconderName.Text = ""
        '
        'txt_ProposedName
        '
        Me.txt_ProposedName.BackColor = System.Drawing.Color.White
        Me.txt_ProposedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ProposedName.Enabled = False
        Me.txt_ProposedName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProposedName.ForeColor = System.Drawing.Color.Black
        Me.txt_ProposedName.Location = New System.Drawing.Point(480, 64)
        Me.txt_ProposedName.MaxLength = 35
        Me.txt_ProposedName.Name = "txt_ProposedName"
        Me.txt_ProposedName.ReadOnly = True
        Me.txt_ProposedName.Size = New System.Drawing.Size(176, 22)
        Me.txt_ProposedName.TabIndex = 23
        Me.txt_ProposedName.Text = ""
        '
        'txt_SeconderCode
        '
        Me.txt_SeconderCode.BackColor = System.Drawing.Color.White
        Me.txt_SeconderCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_SeconderCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SeconderCode.Location = New System.Drawing.Point(176, 96)
        Me.txt_SeconderCode.MaxLength = 50
        Me.txt_SeconderCode.Name = "txt_SeconderCode"
        Me.txt_SeconderCode.Size = New System.Drawing.Size(104, 22)
        Me.txt_SeconderCode.TabIndex = 24
        Me.txt_SeconderCode.Text = ""
        '
        'txt_ProposerCode
        '
        Me.txt_ProposerCode.BackColor = System.Drawing.Color.White
        Me.txt_ProposerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ProposerCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ProposerCode.Location = New System.Drawing.Point(176, 64)
        Me.txt_ProposerCode.MaxLength = 50
        Me.txt_ProposerCode.Name = "txt_ProposerCode"
        Me.txt_ProposerCode.Size = New System.Drawing.Size(104, 22)
        Me.txt_ProposerCode.TabIndex = 21
        Me.txt_ProposerCode.Text = ""
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(56, 64)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(104, 21)
        Me.Label50.TabIndex = 706
        Me.Label50.Text = "Proposer Code"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(352, 64)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(112, 21)
        Me.Label51.TabIndex = 708
        Me.Label51.Text = "Proposer Name "
        '
        'sc
        '
        Me.sc.AutoSize = True
        Me.sc.BackColor = System.Drawing.Color.Transparent
        Me.sc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc.Location = New System.Drawing.Point(56, 96)
        Me.sc.Name = "sc"
        Me.sc.Size = New System.Drawing.Size(105, 21)
        Me.sc.TabIndex = 707
        Me.sc.Text = "Seconder Code"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(352, 96)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(109, 21)
        Me.Label52.TabIndex = 709
        Me.Label52.Text = "Seconder Name"
        '
        'cmd_SeconderCodeHelp
        '
        Me.cmd_SeconderCodeHelp.Image = CType(resources.GetObject("cmd_SeconderCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_SeconderCodeHelp.Location = New System.Drawing.Point(280, 96)
        Me.cmd_SeconderCodeHelp.Name = "cmd_SeconderCodeHelp"
        Me.cmd_SeconderCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_SeconderCodeHelp.TabIndex = 25
        '
        'cmd_ProposerCodeHelp
        '
        Me.cmd_ProposerCodeHelp.Image = CType(resources.GetObject("cmd_ProposerCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_ProposerCodeHelp.Location = New System.Drawing.Point(280, 64)
        Me.cmd_ProposerCodeHelp.Name = "cmd_ProposerCodeHelp"
        Me.cmd_ProposerCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_ProposerCodeHelp.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1304, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 18)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "Club ID"
        Me.Label19.Visible = False
        '
        'txtICNO
        '
        Me.txtICNO.BackColor = System.Drawing.Color.White
        Me.txtICNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtICNO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICNO.Location = New System.Drawing.Point(1432, 8)
        Me.txtICNO.MaxLength = 50
        Me.txtICNO.Name = "txtICNO"
        Me.txtICNO.Size = New System.Drawing.Size(176, 21)
        Me.txtICNO.TabIndex = 144
        Me.txtICNO.Text = ""
        Me.txtICNO.Visible = False
        '
        'SSgrid_Entrancefee
        '
        Me.SSgrid_Entrancefee.ContainingControl = Me
        Me.SSgrid_Entrancefee.DataSource = Nothing
        Me.SSgrid_Entrancefee.Location = New System.Drawing.Point(0, 104)
        Me.SSgrid_Entrancefee.Name = "SSgrid_Entrancefee"
        Me.SSgrid_Entrancefee.OcxState = CType(resources.GetObject("SSgrid_Entrancefee.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Entrancefee.Size = New System.Drawing.Size(744, 168)
        Me.SSgrid_Entrancefee.TabIndex = 809
        '
        'SSgrid_Qual
        '
        Me.SSgrid_Qual.ContainingControl = Me
        Me.SSgrid_Qual.DataSource = Nothing
        Me.SSgrid_Qual.Location = New System.Drawing.Point(16, 40)
        Me.SSgrid_Qual.Name = "SSgrid_Qual"
        Me.SSgrid_Qual.OcxState = CType(resources.GetObject("SSgrid_Qual.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Qual.Size = New System.Drawing.Size(744, 224)
        Me.SSgrid_Qual.TabIndex = 579
        '
        'Grp_AccountsDetails
        '
        Me.Grp_AccountsDetails.BackColor = System.Drawing.Color.Transparent
        Me.Grp_AccountsDetails.Controls.Add(Me.Label31)
        Me.Grp_AccountsDetails.Controls.Add(Me.DataGrid1)
        Me.Grp_AccountsDetails.Location = New System.Drawing.Point(64, 424)
        Me.Grp_AccountsDetails.Name = "Grp_AccountsDetails"
        Me.Grp_AccountsDetails.Size = New System.Drawing.Size(728, 200)
        Me.Grp_AccountsDetails.TabIndex = 686
        Me.Grp_AccountsDetails.TabStop = False
        Me.Grp_AccountsDetails.Visible = False
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(0, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(728, 20)
        Me.Label31.TabIndex = 576
        Me.Label31.Text = "ACCOUNT DETAILS"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 24)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(728, 160)
        Me.DataGrid1.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(32, 271)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 22)
        Me.Label32.TabIndex = 687
        Me.Label32.Text = "Gender"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dt_sdob
        '
        Me.dt_sdob.CustomFormat = "dd/MM/yyyy"
        Me.dt_sdob.Enabled = False
        Me.dt_sdob.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_sdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_sdob.Location = New System.Drawing.Point(1056, 200)
        Me.dt_sdob.Name = "dt_sdob"
        Me.dt_sdob.Size = New System.Drawing.Size(100, 21)
        Me.dt_sdob.TabIndex = 22
        Me.dt_sdob.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 22)
        Me.Label12.TabIndex = 688
        Me.Label12.Text = "Middle Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(32, 240)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(136, 22)
        Me.Label35.TabIndex = 689
        Me.Label35.Text = "Sur Name"
        '
        'Lbl_Last
        '
        Me.Lbl_Last.AutoSize = True
        Me.Lbl_Last.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Last.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Last.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Last.Location = New System.Drawing.Point(56, -40)
        Me.Lbl_Last.Name = "Lbl_Last"
        Me.Lbl_Last.Size = New System.Drawing.Size(93, 25)
        Me.Lbl_Last.TabIndex = 690
        Me.Lbl_Last.Text = "Last No Is"
        Me.Lbl_Last.Visible = False
        '
        'btn_Entancefee
        '
        Me.btn_Entancefee.BackColor = System.Drawing.Color.White
        Me.btn_Entancefee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Entancefee.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Entancefee.ForeColor = System.Drawing.Color.White
        Me.btn_Entancefee.Image = CType(resources.GetObject("btn_Entancefee.Image"), System.Drawing.Image)
        Me.btn_Entancefee.Location = New System.Drawing.Point(852, 504)
        Me.btn_Entancefee.Name = "btn_Entancefee"
        Me.btn_Entancefee.Size = New System.Drawing.Size(128, 40)
        Me.btn_Entancefee.TabIndex = 691
        Me.btn_Entancefee.Text = "Application Details"
        '
        'Grp_Entrancefee
        '
        Me.Grp_Entrancefee.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Entrancefee.Controls.Add(Me.Label97)
        Me.Grp_Entrancefee.Controls.Add(Me.chk_Sports)
        Me.Grp_Entrancefee.Controls.Add(Me.txt_CreditNumber)
        Me.Grp_Entrancefee.Controls.Add(Me.Label55)
        Me.Grp_Entrancefee.Controls.Add(Me.Lbl_BloodGroup)
        Me.Grp_Entrancefee.Controls.Add(Me.Txt_BloodGroup)
        Me.Grp_Entrancefee.Controls.Add(Me.txt_Specialinfo)
        Me.Grp_Entrancefee.Controls.Add(Me.lbl_Specialinfo)
        Me.Grp_Entrancefee.Controls.Add(Me.Rnd_EntranceNo)
        Me.Grp_Entrancefee.Controls.Add(Me.Label17)
        Me.Grp_Entrancefee.Controls.Add(Me.Rnd_Entrancefeeyes)
        Me.Grp_Entrancefee.Controls.Add(Me.Txt_pancarno)
        Me.Grp_Entrancefee.Controls.Add(Me.Label21)
        Me.Grp_Entrancefee.Controls.Add(Me.Label49)
        Me.Grp_Entrancefee.Controls.Add(Me.ComboBox1)
        Me.Grp_Entrancefee.Controls.Add(Me.Label34)
        Me.Grp_Entrancefee.Controls.Add(Me.Button1)
        Me.Grp_Entrancefee.Controls.Add(Me.Button2)
        Me.Grp_Entrancefee.Controls.Add(Me.Label36)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox2)
        Me.Grp_Entrancefee.Controls.Add(Me.Label37)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox7)
        Me.Grp_Entrancefee.Controls.Add(Me.Label38)
        Me.Grp_Entrancefee.Controls.Add(Me.Label39)
        Me.Grp_Entrancefee.Controls.Add(Me.DateTimePicker1)
        Me.Grp_Entrancefee.Controls.Add(Me.DateTimePicker2)
        Me.Grp_Entrancefee.Controls.Add(Me.DateTimePicker3)
        Me.Grp_Entrancefee.Controls.Add(Me.Label40)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox8)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox9)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox10)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox11)
        Me.Grp_Entrancefee.Controls.Add(Me.Label41)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox12)
        Me.Grp_Entrancefee.Controls.Add(Me.Label42)
        Me.Grp_Entrancefee.Controls.Add(Me.Label43)
        Me.Grp_Entrancefee.Controls.Add(Me.Label44)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox13)
        Me.Grp_Entrancefee.Controls.Add(Me.Label45)
        Me.Grp_Entrancefee.Controls.Add(Me.Label46)
        Me.Grp_Entrancefee.Controls.Add(Me.Txt_AppNo)
        Me.Grp_Entrancefee.Controls.Add(Me.Label47)
        Me.Grp_Entrancefee.Controls.Add(Me.Label48)
        Me.Grp_Entrancefee.Controls.Add(Me.TextBox15)
        Me.Grp_Entrancefee.Controls.Add(Me.Dtp_Appdate)
        Me.Grp_Entrancefee.Location = New System.Drawing.Point(32, 368)
        Me.Grp_Entrancefee.Name = "Grp_Entrancefee"
        Me.Grp_Entrancefee.Size = New System.Drawing.Size(776, 224)
        Me.Grp_Entrancefee.TabIndex = 692
        Me.Grp_Entrancefee.TabStop = False
        Me.Grp_Entrancefee.Visible = False
        '
        'Label97
        '
        Me.Label97.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label97.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label97.Image = CType(resources.GetObject("Label97.Image"), System.Drawing.Image)
        Me.Label97.Location = New System.Drawing.Point(0, 8)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(776, 24)
        Me.Label97.TabIndex = 809
        Me.Label97.Text = "APPLICATION DETAILS"
        '
        'chk_Sports
        '
        Me.chk_Sports.BackColor = System.Drawing.Color.Transparent
        Me.chk_Sports.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Sports.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Sports.Location = New System.Drawing.Point(280, 88)
        Me.chk_Sports.Name = "chk_Sports"
        Me.chk_Sports.Size = New System.Drawing.Size(224, 24)
        Me.chk_Sports.TabIndex = 807
        Me.chk_Sports.Text = "Sports Of Intrest"
        '
        'txt_CreditNumber
        '
        Me.txt_CreditNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CreditNumber.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CreditNumber.Location = New System.Drawing.Point(160, 152)
        Me.txt_CreditNumber.MaxLength = 16
        Me.txt_CreditNumber.Name = "txt_CreditNumber"
        Me.txt_CreditNumber.Size = New System.Drawing.Size(208, 22)
        Me.txt_CreditNumber.TabIndex = 805
        Me.txt_CreditNumber.Text = ""
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(8, 152)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(154, 21)
        Me.Label55.TabIndex = 806
        Me.Label55.Text = "Credit Card Number :"
        '
        'Lbl_BloodGroup
        '
        Me.Lbl_BloodGroup.AutoSize = True
        Me.Lbl_BloodGroup.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_BloodGroup.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BloodGroup.Location = New System.Drawing.Point(8, 120)
        Me.Lbl_BloodGroup.Name = "Lbl_BloodGroup"
        Me.Lbl_BloodGroup.Size = New System.Drawing.Size(101, 21)
        Me.Lbl_BloodGroup.TabIndex = 804
        Me.Lbl_BloodGroup.Text = "Blood Group :"
        '
        'Txt_BloodGroup
        '
        Me.Txt_BloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_BloodGroup.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BloodGroup.Location = New System.Drawing.Point(160, 120)
        Me.Txt_BloodGroup.MaxLength = 10
        Me.Txt_BloodGroup.Name = "Txt_BloodGroup"
        Me.Txt_BloodGroup.Size = New System.Drawing.Size(208, 22)
        Me.Txt_BloodGroup.TabIndex = 803
        Me.Txt_BloodGroup.Text = ""
        '
        'txt_Specialinfo
        '
        Me.txt_Specialinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Specialinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Specialinfo.Location = New System.Drawing.Point(536, 80)
        Me.txt_Specialinfo.MaxLength = 999
        Me.txt_Specialinfo.Multiline = True
        Me.txt_Specialinfo.Name = "txt_Specialinfo"
        Me.txt_Specialinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Specialinfo.Size = New System.Drawing.Size(232, 96)
        Me.txt_Specialinfo.TabIndex = 700
        Me.txt_Specialinfo.Text = ""
        '
        'lbl_Specialinfo
        '
        Me.lbl_Specialinfo.AutoSize = True
        Me.lbl_Specialinfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Specialinfo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Specialinfo.Location = New System.Drawing.Point(536, 56)
        Me.lbl_Specialinfo.Name = "lbl_Specialinfo"
        Me.lbl_Specialinfo.Size = New System.Drawing.Size(196, 21)
        Me.lbl_Specialinfo.TabIndex = 699
        Me.lbl_Specialinfo.Text = "SPECIAL INFORMATION:"
        '
        'Rnd_EntranceNo
        '
        Me.Rnd_EntranceNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_EntranceNo.Location = New System.Drawing.Point(208, 192)
        Me.Rnd_EntranceNo.Name = "Rnd_EntranceNo"
        Me.Rnd_EntranceNo.Size = New System.Drawing.Size(72, 24)
        Me.Rnd_EntranceNo.TabIndex = 698
        Me.Rnd_EntranceNo.Text = "No"
        Me.Rnd_EntranceNo.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(8, 192)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 21)
        Me.Label17.TabIndex = 697
        Me.Label17.Text = "Entrance Fee :"
        Me.Label17.Visible = False
        '
        'Rnd_Entrancefeeyes
        '
        Me.Rnd_Entrancefeeyes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Entrancefeeyes.Location = New System.Drawing.Point(136, 192)
        Me.Rnd_Entrancefeeyes.Name = "Rnd_Entrancefeeyes"
        Me.Rnd_Entrancefeeyes.Size = New System.Drawing.Size(72, 24)
        Me.Rnd_Entrancefeeyes.TabIndex = 696
        Me.Rnd_Entrancefeeyes.Text = "Yes"
        Me.Rnd_Entrancefeeyes.Visible = False
        '
        'Txt_pancarno
        '
        Me.Txt_pancarno.BackColor = System.Drawing.Color.White
        Me.Txt_pancarno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_pancarno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pancarno.Location = New System.Drawing.Point(160, 88)
        Me.Txt_pancarno.MaxLength = 20
        Me.Txt_pancarno.Name = "Txt_pancarno"
        Me.Txt_pancarno.Size = New System.Drawing.Size(112, 21)
        Me.Txt_pancarno.TabIndex = 695
        Me.Txt_pancarno.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 21)
        Me.Label21.TabIndex = 694
        Me.Label21.Text = "PanCard No:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(280, 56)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(126, 21)
        Me.Label49.TabIndex = 187
        Me.Label49.Text = "Application Date :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"ARMY", "Air force", "Navy", "CGOs"})
        Me.ComboBox1.Location = New System.Drawing.Point(1192, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(8, 21)
        Me.ComboBox1.TabIndex = 184
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(1152, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(94, 17)
        Me.Label34.TabIndex = 183
        Me.Label34.Text = "Belongs TO :"
        Me.Label34.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(784, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 24)
        Me.Button1.TabIndex = 182
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(832, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 24)
        Me.Button2.TabIndex = 181
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(1072, 128)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(108, 17)
        Me.Label36.TabIndex = 180
        Me.Label36.Text = "R.BY.MEM.NAME2"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1184, 128)
        Me.TextBox2.MaxLength = 25
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(8, 21)
        Me.TextBox2.TabIndex = 179
        Me.TextBox2.Text = ""
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(1152, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(101, 17)
        Me.Label37.TabIndex = 178
        Me.Label37.Text = "R.BY.MEM. NO2"
        Me.Label37.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1184, 48)
        Me.TextBox7.MaxLength = 55
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(8, 21)
        Me.TextBox7.TabIndex = 177
        Me.TextBox7.Text = ""
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(1152, 88)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(108, 17)
        Me.Label38.TabIndex = 173
        Me.Label38.Text = "R.BY.MEM.NAME1"
        Me.Label38.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(1168, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(101, 17)
        Me.Label39.TabIndex = 172
        Me.Label39.Text = "R.BY.MEM. NO1"
        Me.Label39.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1192, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker1.TabIndex = 170
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(1192, 88)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker2.TabIndex = 169
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(1192, 48)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker3.TabIndex = 168
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(1040, 168)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(138, 17)
        Me.Label40.TabIndex = 167
        Me.Label40.Text = "No.of Dependencies"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1184, 16)
        Me.TextBox8.MaxLength = 55
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(8, 21)
        Me.TextBox8.TabIndex = 166
        Me.TextBox8.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(1184, 168)
        Me.TextBox9.MaxLength = 15
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(8, 21)
        Me.TextBox9.TabIndex = 162
        Me.TextBox9.Text = ""
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(1192, 176)
        Me.TextBox10.MaxLength = 15
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(8, 21)
        Me.TextBox10.TabIndex = 161
        Me.TextBox10.Text = ""
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(1192, 80)
        Me.TextBox11.MaxLength = 20
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(8, 21)
        Me.TextBox11.TabIndex = 160
        Me.TextBox11.Text = ""
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(1096, 144)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(86, 17)
        Me.Label41.TabIndex = 165
        Me.Label41.Text = "Arm/Service"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(1192, 144)
        Me.TextBox12.MaxLength = 25
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(8, 21)
        Me.TextBox12.TabIndex = 156
        Me.TextBox12.Text = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(1152, 88)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(123, 17)
        Me.Label42.TabIndex = 152
        Me.Label42.Text = "Date of  Release"
        Me.Label42.Visible = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(1160, 176)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(27, 17)
        Me.Label43.TabIndex = 155
        Me.Label43.Text = "W/O"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(1048, 128)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(138, 17)
        Me.Label44.TabIndex = 153
        Me.Label44.Text = "Date of  Creation "
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.White
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(1184, 88)
        Me.TextBox13.MaxLength = 25
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(8, 21)
        Me.TextBox13.TabIndex = 151
        Me.TextBox13.Text = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(8, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(114, 21)
        Me.Label45.TabIndex = 146
        Me.Label45.Text = "Application No :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(1136, 48)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(138, 17)
        Me.Label46.TabIndex = 148
        Me.Label46.Text = "Date of Commission"
        Me.Label46.Visible = False
        '
        'Txt_AppNo
        '
        Me.Txt_AppNo.BackColor = System.Drawing.Color.White
        Me.Txt_AppNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_AppNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AppNo.Location = New System.Drawing.Point(160, 56)
        Me.Txt_AppNo.MaxLength = 50
        Me.Txt_AppNo.Name = "Txt_AppNo"
        Me.Txt_AppNo.Size = New System.Drawing.Size(112, 21)
        Me.Txt_AppNo.TabIndex = 144
        Me.Txt_AppNo.Text = ""
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(1160, 80)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(86, 17)
        Me.Label47.TabIndex = 164
        Me.Label47.Text = "R.IDCARD NO"
        Me.Label47.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(1128, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(101, 17)
        Me.Label48.TabIndex = 163
        Me.Label48.Text = "M.Description"
        Me.Label48.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.White
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(1200, 48)
        Me.TextBox15.MaxLength = 10
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(8, 21)
        Me.TextBox15.TabIndex = 158
        Me.TextBox15.Text = ""
        Me.TextBox15.Visible = False
        '
        'Dtp_Appdate
        '
        Me.Dtp_Appdate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_Appdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Appdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Appdate.Location = New System.Drawing.Point(416, 56)
        Me.Dtp_Appdate.Name = "Dtp_Appdate"
        Me.Dtp_Appdate.Size = New System.Drawing.Size(104, 21)
        Me.Dtp_Appdate.TabIndex = 693
        '
        'Txt_Newmember
        '
        Me.Txt_Newmember.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_Newmember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Newmember.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Newmember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Newmember.Enabled = False
        Me.Txt_Newmember.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Newmember.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_Newmember.Location = New System.Drawing.Point(176, -40)
        Me.Txt_Newmember.MaxLength = 10
        Me.Txt_Newmember.Name = "Txt_Newmember"
        Me.Txt_Newmember.Size = New System.Drawing.Size(104, 22)
        Me.Txt_Newmember.TabIndex = 2
        Me.Txt_Newmember.Text = ""
        Me.Txt_Newmember.Visible = False
        '
        'lbl_newmember
        '
        Me.lbl_newmember.BackColor = System.Drawing.Color.Transparent
        Me.lbl_newmember.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newmember.Location = New System.Drawing.Point(48, -40)
        Me.lbl_newmember.Name = "lbl_newmember"
        Me.lbl_newmember.Size = New System.Drawing.Size(128, 40)
        Me.lbl_newmember.TabIndex = 712
        Me.lbl_newmember.Text = "New Member No"
        Me.lbl_newmember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_newmember.Visible = False
        '
        'grp_Entrancefeedetails
        '
        Me.grp_Entrancefeedetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_Entrancefeedetails.Controls.Add(Me.SSgrid_Entfee)
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label92)
        Me.grp_Entrancefeedetails.Controls.Add(Me.Label93)
        Me.grp_Entrancefeedetails.Controls.Add(Me.cmd_EntrancefeeCancel)
        Me.grp_Entrancefeedetails.Controls.Add(Me.cmd_EntrancefeeOK)
        Me.grp_Entrancefeedetails.Controls.Add(Me.chk_EntranceFee)
        Me.grp_Entrancefeedetails.Location = New System.Drawing.Point(120, 384)
        Me.grp_Entrancefeedetails.Name = "grp_Entrancefeedetails"
        Me.grp_Entrancefeedetails.Size = New System.Drawing.Size(648, 216)
        Me.grp_Entrancefeedetails.TabIndex = 714
        Me.grp_Entrancefeedetails.TabStop = False
        Me.grp_Entrancefeedetails.Visible = False
        '
        'SSgrid_Entfee
        '
        Me.SSgrid_Entfee.ContainingControl = Me
        Me.SSgrid_Entfee.DataSource = Nothing
        Me.SSgrid_Entfee.Location = New System.Drawing.Point(8, 53)
        Me.SSgrid_Entfee.Name = "SSgrid_Entfee"
        Me.SSgrid_Entfee.OcxState = CType(resources.GetObject("SSgrid_Entfee.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Entfee.Size = New System.Drawing.Size(616, 110)
        Me.SSgrid_Entfee.TabIndex = 802
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label92.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.Black
        Me.Label92.Location = New System.Drawing.Point(16, 32)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(211, 22)
        Me.Label92.TabIndex = 574
        Me.Label92.Text = "ENTRANCE FEE DETAILS"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label93.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label93.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label93.Location = New System.Drawing.Point(8, 24)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(616, 32)
        Me.Label93.TabIndex = 576
        '
        'cmd_EntrancefeeCancel
        '
        Me.cmd_EntrancefeeCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeCancel.ForeColor = System.Drawing.Color.White
        Me.cmd_EntrancefeeCancel.Image = CType(resources.GetObject("cmd_EntrancefeeCancel.Image"), System.Drawing.Image)
        Me.cmd_EntrancefeeCancel.Location = New System.Drawing.Point(376, 168)
        Me.cmd_EntrancefeeCancel.Name = "cmd_EntrancefeeCancel"
        Me.cmd_EntrancefeeCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeCancel.TabIndex = 2
        Me.cmd_EntrancefeeCancel.Text = "Cancel"
        Me.cmd_EntrancefeeCancel.Visible = False
        '
        'cmd_EntrancefeeOK
        '
        Me.cmd_EntrancefeeOK.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_EntrancefeeOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_EntrancefeeOK.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_EntrancefeeOK.ForeColor = System.Drawing.Color.White
        Me.cmd_EntrancefeeOK.Image = CType(resources.GetObject("cmd_EntrancefeeOK.Image"), System.Drawing.Image)
        Me.cmd_EntrancefeeOK.Location = New System.Drawing.Point(264, 168)
        Me.cmd_EntrancefeeOK.Name = "cmd_EntrancefeeOK"
        Me.cmd_EntrancefeeOK.Size = New System.Drawing.Size(104, 32)
        Me.cmd_EntrancefeeOK.TabIndex = 1
        Me.cmd_EntrancefeeOK.Text = "Ok"
        '
        'chk_EntranceFee
        '
        Me.chk_EntranceFee.BackColor = System.Drawing.Color.Transparent
        Me.chk_EntranceFee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_EntranceFee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EntranceFee.Location = New System.Drawing.Point(456, 184)
        Me.chk_EntranceFee.Name = "chk_EntranceFee"
        Me.chk_EntranceFee.Size = New System.Drawing.Size(200, 16)
        Me.chk_EntranceFee.TabIndex = 801
        Me.chk_EntranceFee.Text = "Entrance Fee Details"
        Me.chk_EntranceFee.Visible = False
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Silver
        Me.Label79.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(48, 24)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(171, 21)
        Me.Label79.TabIndex = 574
        Me.Label79.Text = "SPORTS INTERESTED"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Silver
        Me.Label88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label88.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Black
        Me.Label88.Location = New System.Drawing.Point(32, 16)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(720, 32)
        Me.Label88.TabIndex = 577
        '
        'cmd_SportsCancel
        '
        Me.cmd_SportsCancel.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SportsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SportsCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SportsCancel.ForeColor = System.Drawing.Color.Black
        Me.cmd_SportsCancel.Location = New System.Drawing.Point(616, 192)
        Me.cmd_SportsCancel.Name = "cmd_SportsCancel"
        Me.cmd_SportsCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SportsCancel.TabIndex = 2
        Me.cmd_SportsCancel.Text = "Cancel"
        Me.cmd_SportsCancel.Visible = False
        '
        'cmd_SportsOk
        '
        Me.cmd_SportsOk.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_SportsOk.BackgroundImage = CType(resources.GetObject("cmd_SportsOk.BackgroundImage"), System.Drawing.Image)
        Me.cmd_SportsOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_SportsOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SportsOk.ForeColor = System.Drawing.Color.White
        Me.cmd_SportsOk.Location = New System.Drawing.Point(352, 191)
        Me.cmd_SportsOk.Name = "cmd_SportsOk"
        Me.cmd_SportsOk.Size = New System.Drawing.Size(104, 32)
        Me.cmd_SportsOk.TabIndex = 1
        Me.cmd_SportsOk.Text = "Ok"
        '
        'SSgrid_Sports
        '
        Me.SSgrid_Sports.ContainingControl = Me
        Me.SSgrid_Sports.DataSource = Nothing
        Me.SSgrid_Sports.Location = New System.Drawing.Point(32, 50)
        Me.SSgrid_Sports.Name = "SSgrid_Sports"
        Me.SSgrid_Sports.OcxState = CType(resources.GetObject("SSgrid_Sports.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Sports.Size = New System.Drawing.Size(720, 134)
        Me.SSgrid_Sports.TabIndex = 0
        '
        'grp_SportsIntrested
        '
        Me.grp_SportsIntrested.BackColor = System.Drawing.Color.Transparent
        Me.grp_SportsIntrested.Controls.Add(Me.AxfpSpread1)
        Me.grp_SportsIntrested.Controls.Add(Me.Label79)
        Me.grp_SportsIntrested.Controls.Add(Me.Label88)
        Me.grp_SportsIntrested.Controls.Add(Me.cmd_SportsCancel)
        Me.grp_SportsIntrested.Controls.Add(Me.cmd_SportsOk)
        Me.grp_SportsIntrested.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_SportsIntrested.ForeColor = System.Drawing.Color.Black
        Me.grp_SportsIntrested.Location = New System.Drawing.Point(56, 368)
        Me.grp_SportsIntrested.Name = "grp_SportsIntrested"
        Me.grp_SportsIntrested.Size = New System.Drawing.Size(760, 232)
        Me.grp_SportsIntrested.TabIndex = 808
        Me.grp_SportsIntrested.TabStop = False
        Me.grp_SportsIntrested.Visible = False
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.ContainingControl = Me
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(32, 49)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.OcxState = CType(resources.GetObject("AxfpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxfpSpread1.Size = New System.Drawing.Size(720, 134)
        Me.AxfpSpread1.TabIndex = 578
        '
        'Grp_MemQualification
        '
        Me.Grp_MemQualification.BackColor = System.Drawing.Color.Transparent
        Me.Grp_MemQualification.Controls.Add(Me.Label54)
        Me.Grp_MemQualification.Controls.Add(Me.Label89)
        Me.Grp_MemQualification.Controls.Add(Me.SSgrid_Qual_det)
        Me.Grp_MemQualification.Location = New System.Drawing.Point(48, 392)
        Me.Grp_MemQualification.Name = "Grp_MemQualification"
        Me.Grp_MemQualification.Size = New System.Drawing.Size(776, 272)
        Me.Grp_MemQualification.TabIndex = 809
        Me.Grp_MemQualification.TabStop = False
        Me.Grp_MemQualification.Visible = False
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label54.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label54.Image = CType(resources.GetObject("Label54.Image"), System.Drawing.Image)
        Me.Label54.Location = New System.Drawing.Point(24, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(173, 18)
        Me.Label54.TabIndex = 574
        Me.Label54.Text = "MEMBER QUALIFICATION"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label89.Image = CType(resources.GetObject("Label89.Image"), System.Drawing.Image)
        Me.Label89.Location = New System.Drawing.Point(16, 8)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(744, 32)
        Me.Label89.TabIndex = 578
        '
        'SSgrid_Qual_det
        '
        Me.SSgrid_Qual_det.ContainingControl = Me
        Me.SSgrid_Qual_det.DataSource = Nothing
        Me.SSgrid_Qual_det.Location = New System.Drawing.Point(16, 40)
        Me.SSgrid_Qual_det.Name = "SSgrid_Qual_det"
        Me.SSgrid_Qual_det.OcxState = CType(resources.GetObject("SSgrid_Qual_det.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Qual_det.Size = New System.Drawing.Size(744, 224)
        Me.SSgrid_Qual_det.TabIndex = 579
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(32, 128)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(136, 22)
        Me.Label56.TabIndex = 810
        Me.Label56.Text = "Salutation"
        '
        'Cbo_title
        '
        Me.Cbo_title.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_title.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_title.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_title.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_title.ItemHeight = 16
        Me.Cbo_title.Location = New System.Drawing.Point(176, 128)
        Me.Cbo_title.Name = "Cbo_title"
        Me.Cbo_title.Size = New System.Drawing.Size(80, 24)
        Me.Cbo_title.TabIndex = 811
        '
        'Cbo_MaritalStatus
        '
        Me.Cbo_MaritalStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_MaritalStatus.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_MaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_MaritalStatus.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_MaritalStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_MaritalStatus.ItemHeight = 16
        Me.Cbo_MaritalStatus.Location = New System.Drawing.Point(704, 120)
        Me.Cbo_MaritalStatus.Name = "Cbo_MaritalStatus"
        Me.Cbo_MaritalStatus.Size = New System.Drawing.Size(136, 24)
        Me.Cbo_MaritalStatus.TabIndex = 815
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(600, 120)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(104, 22)
        Me.Label58.TabIndex = 814
        Me.Label58.Text = "MaritalStatus"
        '
        'Cbo_designation
        '
        Me.Cbo_designation.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_designation.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_designation.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_designation.ItemHeight = 16
        Me.Cbo_designation.Location = New System.Drawing.Point(504, 239)
        Me.Cbo_designation.Name = "Cbo_designation"
        Me.Cbo_designation.Size = New System.Drawing.Size(272, 24)
        Me.Cbo_designation.TabIndex = 817
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(389, 240)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(89, 22)
        Me.Label59.TabIndex = 816
        Me.Label59.Text = "Designation"
        '
        'Btn_Company
        '
        Me.Btn_Company.BackColor = System.Drawing.Color.Black
        Me.Btn_Company.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Company.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Company.ForeColor = System.Drawing.Color.White
        Me.Btn_Company.Image = CType(resources.GetObject("Btn_Company.Image"), System.Drawing.Image)
        Me.Btn_Company.Location = New System.Drawing.Point(160, 696)
        Me.Btn_Company.Name = "Btn_Company"
        Me.Btn_Company.Size = New System.Drawing.Size(112, 32)
        Me.Btn_Company.TabIndex = 818
        Me.Btn_Company.Text = "Company Details"
        Me.Btn_Company.Visible = False
        '
        'Gpr_Company
        '
        Me.Gpr_Company.BackColor = System.Drawing.Color.Transparent
        Me.Gpr_Company.Controls.Add(Me.Label53)
        Me.Gpr_Company.Controls.Add(Me.Txt_Professionalinfo)
        Me.Gpr_Company.Controls.Add(Me.Txt_noofEmpolyee)
        Me.Gpr_Company.Controls.Add(Me.Label73)
        Me.Gpr_Company.Controls.Add(Me.Txt_AgenttInfo)
        Me.Gpr_Company.Controls.Add(Me.Label71)
        Me.Gpr_Company.Controls.Add(Me.Txt_turnover)
        Me.Gpr_Company.Controls.Add(Me.Label70)
        Me.Gpr_Company.Controls.Add(Me.Txt_products)
        Me.Gpr_Company.Controls.Add(Me.Label61)
        Me.Gpr_Company.Controls.Add(Me.Label62)
        Me.Gpr_Company.Controls.Add(Me.Txt_Bussinessinfo)
        Me.Gpr_Company.Controls.Add(Me.Txt_Designation)
        Me.Gpr_Company.Controls.Add(Me.Label72)
        Me.Gpr_Company.Controls.Add(Me.ComboBox2)
        Me.Gpr_Company.Controls.Add(Me.Label74)
        Me.Gpr_Company.Controls.Add(Me.Button4)
        Me.Gpr_Company.Controls.Add(Me.Button5)
        Me.Gpr_Company.Controls.Add(Me.Label75)
        Me.Gpr_Company.Controls.Add(Me.TextBox19)
        Me.Gpr_Company.Controls.Add(Me.Label76)
        Me.Gpr_Company.Controls.Add(Me.TextBox20)
        Me.Gpr_Company.Controls.Add(Me.Label77)
        Me.Gpr_Company.Controls.Add(Me.Label78)
        Me.Gpr_Company.Controls.Add(Me.DateTimePicker4)
        Me.Gpr_Company.Controls.Add(Me.DateTimePicker5)
        Me.Gpr_Company.Controls.Add(Me.DateTimePicker6)
        Me.Gpr_Company.Controls.Add(Me.Label82)
        Me.Gpr_Company.Controls.Add(Me.TextBox21)
        Me.Gpr_Company.Controls.Add(Me.TextBox22)
        Me.Gpr_Company.Controls.Add(Me.TextBox23)
        Me.Gpr_Company.Controls.Add(Me.TextBox24)
        Me.Gpr_Company.Controls.Add(Me.Label83)
        Me.Gpr_Company.Controls.Add(Me.TextBox25)
        Me.Gpr_Company.Controls.Add(Me.Label84)
        Me.Gpr_Company.Controls.Add(Me.Label85)
        Me.Gpr_Company.Controls.Add(Me.Label86)
        Me.Gpr_Company.Controls.Add(Me.TextBox26)
        Me.Gpr_Company.Controls.Add(Me.Label87)
        Me.Gpr_Company.Controls.Add(Me.Label90)
        Me.Gpr_Company.Controls.Add(Me.Txt_companyName)
        Me.Gpr_Company.Controls.Add(Me.Label91)
        Me.Gpr_Company.Controls.Add(Me.Label94)
        Me.Gpr_Company.Controls.Add(Me.TextBox28)
        Me.Gpr_Company.Location = New System.Drawing.Point(16, 360)
        Me.Gpr_Company.Name = "Gpr_Company"
        Me.Gpr_Company.Size = New System.Drawing.Size(832, 248)
        Me.Gpr_Company.TabIndex = 819
        Me.Gpr_Company.TabStop = False
        Me.Gpr_Company.Visible = False
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(128, Byte))
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label53.Image = CType(resources.GetObject("Label53.Image"), System.Drawing.Image)
        Me.Label53.Location = New System.Drawing.Point(0, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(832, 24)
        Me.Label53.TabIndex = 815
        Me.Label53.Text = "COMPANY DETAILS"
        '
        'Txt_Professionalinfo
        '
        Me.Txt_Professionalinfo.BackColor = System.Drawing.Color.White
        Me.Txt_Professionalinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Professionalinfo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Professionalinfo.Location = New System.Drawing.Point(584, 144)
        Me.Txt_Professionalinfo.MaxLength = 50
        Me.Txt_Professionalinfo.Name = "Txt_Professionalinfo"
        Me.Txt_Professionalinfo.Size = New System.Drawing.Size(208, 21)
        Me.Txt_Professionalinfo.TabIndex = 814
        Me.Txt_Professionalinfo.Text = ""
        Me.Txt_Professionalinfo.Visible = False
        '
        'Txt_noofEmpolyee
        '
        Me.Txt_noofEmpolyee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_noofEmpolyee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_noofEmpolyee.Location = New System.Drawing.Point(584, 112)
        Me.Txt_noofEmpolyee.MaxLength = 10
        Me.Txt_noofEmpolyee.Name = "Txt_noofEmpolyee"
        Me.Txt_noofEmpolyee.Size = New System.Drawing.Size(72, 22)
        Me.Txt_noofEmpolyee.TabIndex = 811
        Me.Txt_noofEmpolyee.Text = ""
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(448, 112)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(110, 21)
        Me.Label73.TabIndex = 812
        Me.Label73.Text = "No of Employee"
        '
        'Txt_AgenttInfo
        '
        Me.Txt_AgenttInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_AgenttInfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AgenttInfo.Location = New System.Drawing.Point(584, 80)
        Me.Txt_AgenttInfo.MaxLength = 50
        Me.Txt_AgenttInfo.Name = "Txt_AgenttInfo"
        Me.Txt_AgenttInfo.Size = New System.Drawing.Size(208, 22)
        Me.Txt_AgenttInfo.TabIndex = 809
        Me.Txt_AgenttInfo.Text = ""
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(445, 80)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(76, 21)
        Me.Label71.TabIndex = 810
        Me.Label71.Text = "Agent Info"
        '
        'Txt_turnover
        '
        Me.Txt_turnover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_turnover.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_turnover.Location = New System.Drawing.Point(584, 48)
        Me.Txt_turnover.MaxLength = 10
        Me.Txt_turnover.Name = "Txt_turnover"
        Me.Txt_turnover.Size = New System.Drawing.Size(208, 22)
        Me.Txt_turnover.TabIndex = 807
        Me.Txt_turnover.Text = ""
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(448, 48)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(73, 21)
        Me.Label70.TabIndex = 808
        Me.Label70.Text = "Turn over"
        '
        'Txt_products
        '
        Me.Txt_products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_products.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_products.Location = New System.Drawing.Point(160, 112)
        Me.Txt_products.MaxLength = 100
        Me.Txt_products.Name = "Txt_products"
        Me.Txt_products.Size = New System.Drawing.Size(208, 22)
        Me.Txt_products.TabIndex = 805
        Me.Txt_products.Text = ""
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(24, 112)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(65, 21)
        Me.Label61.TabIndex = 806
        Me.Label61.Text = "Products"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(24, 80)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(92, 21)
        Me.Label62.TabIndex = 804
        Me.Label62.Text = "Business info"
        '
        'Txt_Bussinessinfo
        '
        Me.Txt_Bussinessinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Bussinessinfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Bussinessinfo.Location = New System.Drawing.Point(160, 80)
        Me.Txt_Bussinessinfo.MaxLength = 50
        Me.Txt_Bussinessinfo.Name = "Txt_Bussinessinfo"
        Me.Txt_Bussinessinfo.Size = New System.Drawing.Size(208, 22)
        Me.Txt_Bussinessinfo.TabIndex = 803
        Me.Txt_Bussinessinfo.Text = ""
        '
        'Txt_Designation
        '
        Me.Txt_Designation.BackColor = System.Drawing.Color.White
        Me.Txt_Designation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Designation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Designation.Location = New System.Drawing.Point(584, 176)
        Me.Txt_Designation.MaxLength = 50
        Me.Txt_Designation.Name = "Txt_Designation"
        Me.Txt_Designation.Size = New System.Drawing.Size(208, 21)
        Me.Txt_Designation.TabIndex = 695
        Me.Txt_Designation.Text = ""
        Me.Txt_Designation.Visible = False
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(448, 176)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(82, 21)
        Me.Label72.TabIndex = 694
        Me.Label72.Text = "Occupation"
        Me.Label72.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Items.AddRange(New Object() {"ARMY", "Air force", "Navy", "CGOs"})
        Me.ComboBox2.Location = New System.Drawing.Point(1192, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(8, 21)
        Me.ComboBox2.TabIndex = 184
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(1152, 56)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(94, 17)
        Me.Label74.TabIndex = 183
        Me.Label74.Text = "Belongs TO :"
        Me.Label74.Visible = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(904, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(8, 24)
        Me.Button4.TabIndex = 182
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(832, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(8, 24)
        Me.Button5.TabIndex = 181
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(1072, 128)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(108, 17)
        Me.Label75.TabIndex = 180
        Me.Label75.Text = "R.BY.MEM.NAME2"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.White
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(1184, 128)
        Me.TextBox19.MaxLength = 25
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(8, 21)
        Me.TextBox19.TabIndex = 179
        Me.TextBox19.Text = ""
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(1152, 56)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(101, 17)
        Me.Label76.TabIndex = 178
        Me.Label76.Text = "R.BY.MEM. NO2"
        Me.Label76.Visible = False
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.White
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox20.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(1184, 48)
        Me.TextBox20.MaxLength = 55
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(8, 21)
        Me.TextBox20.TabIndex = 177
        Me.TextBox20.Text = ""
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(1152, 88)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(108, 17)
        Me.Label77.TabIndex = 173
        Me.Label77.Text = "R.BY.MEM.NAME1"
        Me.Label77.Visible = False
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(1168, 16)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(101, 17)
        Me.Label78.TabIndex = 172
        Me.Label78.Text = "R.BY.MEM. NO1"
        Me.Label78.Visible = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(1192, 128)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker4.TabIndex = 170
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(1192, 88)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker5.TabIndex = 169
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker6.Location = New System.Drawing.Point(1192, 48)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(32, 21)
        Me.DateTimePicker6.TabIndex = 168
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(1040, 168)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(138, 17)
        Me.Label82.TabIndex = 167
        Me.Label82.Text = "No.of Dependencies"
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.White
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(1184, 16)
        Me.TextBox21.MaxLength = 55
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(8, 21)
        Me.TextBox21.TabIndex = 166
        Me.TextBox21.Text = ""
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.Color.White
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(1184, 168)
        Me.TextBox22.MaxLength = 15
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(8, 21)
        Me.TextBox22.TabIndex = 162
        Me.TextBox22.Text = ""
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.Color.White
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(1192, 176)
        Me.TextBox23.MaxLength = 15
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(8, 21)
        Me.TextBox23.TabIndex = 161
        Me.TextBox23.Text = ""
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.Color.White
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(1192, 80)
        Me.TextBox24.MaxLength = 20
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(8, 21)
        Me.TextBox24.TabIndex = 160
        Me.TextBox24.Text = ""
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(1096, 144)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(86, 17)
        Me.Label83.TabIndex = 165
        Me.Label83.Text = "Arm/Service"
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.Color.White
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(1192, 144)
        Me.TextBox25.MaxLength = 25
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(8, 21)
        Me.TextBox25.TabIndex = 156
        Me.TextBox25.Text = ""
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(1152, 88)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(123, 17)
        Me.Label84.TabIndex = 152
        Me.Label84.Text = "Date of  Release"
        Me.Label84.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(1160, 176)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(27, 17)
        Me.Label85.TabIndex = 155
        Me.Label85.Text = "W/O"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(1048, 128)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(138, 17)
        Me.Label86.TabIndex = 153
        Me.Label86.Text = "Date of  Creation "
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.Color.White
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(1184, 88)
        Me.TextBox26.MaxLength = 25
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(8, 21)
        Me.TextBox26.TabIndex = 151
        Me.TextBox26.Text = ""
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Black
        Me.Label87.Location = New System.Drawing.Point(24, 48)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(112, 21)
        Me.Label87.TabIndex = 146
        Me.Label87.Text = "Company Name"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(1136, 48)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(138, 17)
        Me.Label90.TabIndex = 148
        Me.Label90.Text = "Date of Commission"
        Me.Label90.Visible = False
        '
        'Txt_companyName
        '
        Me.Txt_companyName.BackColor = System.Drawing.Color.White
        Me.Txt_companyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_companyName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_companyName.Location = New System.Drawing.Point(160, 48)
        Me.Txt_companyName.MaxLength = 200
        Me.Txt_companyName.Name = "Txt_companyName"
        Me.Txt_companyName.Size = New System.Drawing.Size(272, 21)
        Me.Txt_companyName.TabIndex = 144
        Me.Txt_companyName.Text = ""
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(1160, 80)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(86, 17)
        Me.Label91.TabIndex = 164
        Me.Label91.Text = "R.IDCARD NO"
        Me.Label91.Visible = False
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(1128, 48)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(101, 17)
        Me.Label94.TabIndex = 163
        Me.Label94.Text = "M.Description"
        Me.Label94.Visible = False
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.Color.White
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(1200, 48)
        Me.TextBox28.MaxLength = 10
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(8, 21)
        Me.TextBox28.TabIndex = 158
        Me.TextBox28.Text = ""
        Me.TextBox28.Visible = False
        '
        'Cbo_professional
        '
        Me.Cbo_professional.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_professional.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_professional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_professional.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_professional.ItemHeight = 16
        Me.Cbo_professional.Location = New System.Drawing.Point(504, 270)
        Me.Cbo_professional.Name = "Cbo_professional"
        Me.Cbo_professional.Size = New System.Drawing.Size(272, 24)
        Me.Cbo_professional.TabIndex = 818
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.Black
        Me.Label95.Location = New System.Drawing.Point(400, 272)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(74, 21)
        Me.Label95.TabIndex = 813
        Me.Label95.Text = "Profession"
        '
        'Label96
        '
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(32, 8)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(136, 24)
        Me.Label96.TabIndex = 821
        Me.Label96.Text = "Replacement For"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label96.Visible = False
        '
        'Txt_Replacement
        '
        Me.Txt_Replacement.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_Replacement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Replacement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Replacement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Replacement.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Replacement.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_Replacement.Location = New System.Drawing.Point(176, 8)
        Me.Txt_Replacement.MaxLength = 10
        Me.Txt_Replacement.Name = "Txt_Replacement"
        Me.Txt_Replacement.Size = New System.Drawing.Size(72, 22)
        Me.Txt_Replacement.TabIndex = 820
        Me.Txt_Replacement.Text = ""
        Me.Txt_Replacement.Visible = False
        '
        'txt_Spouse
        '
        Me.txt_Spouse.BackColor = System.Drawing.Color.White
        Me.txt_Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Spouse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Spouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Spouse.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Spouse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Spouse.Location = New System.Drawing.Point(144, 40)
        Me.txt_Spouse.MaxLength = 35
        Me.txt_Spouse.Name = "txt_Spouse"
        Me.txt_Spouse.Size = New System.Drawing.Size(176, 22)
        Me.txt_Spouse.TabIndex = 10
        Me.txt_Spouse.Text = ""
        '
        'Cbo_Spousesalutation
        '
        Me.Cbo_Spousesalutation.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_Spousesalutation.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_Spousesalutation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Spousesalutation.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Spousesalutation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_Spousesalutation.ItemHeight = 16
        Me.Cbo_Spousesalutation.Location = New System.Drawing.Point(144, 16)
        Me.Cbo_Spousesalutation.Name = "Cbo_Spousesalutation"
        Me.Cbo_Spousesalutation.Size = New System.Drawing.Size(80, 24)
        Me.Cbo_Spousesalutation.TabIndex = 825
        '
        'Label99
        '
        Me.Label99.BackColor = System.Drawing.Color.Transparent
        Me.Label99.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(0, 16)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(136, 24)
        Me.Label99.TabIndex = 824
        Me.Label99.Text = "Spouse Salutation"
        '
        'Dtp_Spousedob
        '
        Me.Dtp_Spousedob.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_Spousedob.Enabled = False
        Me.Dtp_Spousedob.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Spousedob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Spousedob.Location = New System.Drawing.Point(472, 16)
        Me.Dtp_Spousedob.Name = "Dtp_Spousedob"
        Me.Dtp_Spousedob.Size = New System.Drawing.Size(96, 21)
        Me.Dtp_Spousedob.TabIndex = 827
        '
        'CHK_DOB
        '
        Me.CHK_DOB.BackColor = System.Drawing.Color.Transparent
        Me.CHK_DOB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CHK_DOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_DOB.Location = New System.Drawing.Point(344, 144)
        Me.CHK_DOB.Name = "CHK_DOB"
        Me.CHK_DOB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHK_DOB.Size = New System.Drawing.Size(144, 20)
        Me.CHK_DOB.TabIndex = 828
        Me.CHK_DOB.Text = "Date of Birth"
        '
        'CHK_DOJ
        '
        Me.CHK_DOJ.BackColor = System.Drawing.Color.Transparent
        Me.CHK_DOJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CHK_DOJ.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_DOJ.Location = New System.Drawing.Point(344, 176)
        Me.CHK_DOJ.Name = "CHK_DOJ"
        Me.CHK_DOJ.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHK_DOJ.Size = New System.Drawing.Size(144, 20)
        Me.CHK_DOJ.TabIndex = 829
        Me.CHK_DOJ.Text = "Date of Join"
        '
        'chk_EXPDT
        '
        Me.chk_EXPDT.BackColor = System.Drawing.Color.Transparent
        Me.chk_EXPDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_EXPDT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_EXPDT.Location = New System.Drawing.Point(360, 208)
        Me.chk_EXPDT.Name = "chk_EXPDT"
        Me.chk_EXPDT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_EXPDT.Size = New System.Drawing.Size(128, 20)
        Me.chk_EXPDT.TabIndex = 830
        Me.chk_EXPDT.Text = "Exp.Date"
        '
        'ChK_SDOB
        '
        Me.ChK_SDOB.BackColor = System.Drawing.Color.Transparent
        Me.ChK_SDOB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChK_SDOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK_SDOB.Location = New System.Drawing.Point(320, 16)
        Me.ChK_SDOB.Name = "ChK_SDOB"
        Me.ChK_SDOB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChK_SDOB.Size = New System.Drawing.Size(144, 20)
        Me.ChK_SDOB.TabIndex = 831
        Me.ChK_SDOB.Text = "Spouse Dob"
        '
        'CHK_WDT
        '
        Me.CHK_WDT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_WDT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CHK_WDT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_WDT.Location = New System.Drawing.Point(320, 40)
        Me.CHK_WDT.Name = "CHK_WDT"
        Me.CHK_WDT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHK_WDT.Size = New System.Drawing.Size(144, 20)
        Me.CHK_WDT.TabIndex = 832
        Me.CHK_WDT.Text = "Date of Wedding"
        '
        'Label_Maxchar
        '
        Me.Label_Maxchar.AutoSize = True
        Me.Label_Maxchar.BackColor = System.Drawing.Color.Transparent
        Me.Label_Maxchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Maxchar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Maxchar.ForeColor = System.Drawing.Color.Red
        Me.Label_Maxchar.Location = New System.Drawing.Point(304, 48)
        Me.Label_Maxchar.Name = "Label_Maxchar"
        Me.Label_Maxchar.Size = New System.Drawing.Size(76, 17)
        Me.Label_Maxchar.TabIndex = 652
        Me.Label_Maxchar.Text = "Max 10 Char"
        Me.Label_Maxchar.Visible = False
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(32, 88)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(120, 22)
        Me.Label80.TabIndex = 833
        Me.Label80.Text = "Corporate Code"
        '
        'Txt_CorporateCode
        '
        Me.Txt_CorporateCode.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_CorporateCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CorporateCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_CorporateCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_CorporateCode.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CorporateCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_CorporateCode.Location = New System.Drawing.Point(176, 88)
        Me.Txt_CorporateCode.MaxLength = 10
        Me.Txt_CorporateCode.Name = "Txt_CorporateCode"
        Me.Txt_CorporateCode.Size = New System.Drawing.Size(102, 22)
        Me.Txt_CorporateCode.TabIndex = 834
        Me.Txt_CorporateCode.Text = ""
        '
        'Img_Spousephoto
        '
        Me.Img_Spousephoto.BackColor = System.Drawing.Color.Transparent
        Me.Img_Spousephoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Spousephoto.Location = New System.Drawing.Point(856, 232)
        Me.Img_Spousephoto.Name = "Img_Spousephoto"
        Me.Img_Spousephoto.Size = New System.Drawing.Size(104, 96)
        Me.Img_Spousephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Spousephoto.TabIndex = 835
        Me.Img_Spousephoto.TabStop = False
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(856, 208)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(104, 18)
        Me.Label81.TabIndex = 836
        Me.Label81.Text = "Spouse Photo"
        '
        'Chk_spouseFreeze
        '
        Me.Chk_spouseFreeze.BackColor = System.Drawing.Color.Transparent
        Me.Chk_spouseFreeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Chk_spouseFreeze.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_spouseFreeze.Location = New System.Drawing.Point(848, 368)
        Me.Chk_spouseFreeze.Name = "Chk_spouseFreeze"
        Me.Chk_spouseFreeze.Size = New System.Drawing.Size(128, 20)
        Me.Chk_spouseFreeze.TabIndex = 837
        Me.Chk_spouseFreeze.Text = "Spouse Freeze"
        Me.Chk_spouseFreeze.Visible = False
        '
        'Gpx_Spouse
        '
        Me.Gpx_Spouse.BackColor = System.Drawing.Color.Transparent
        Me.Gpx_Spouse.Controls.Add(Me.CheckBox5)
        Me.Gpx_Spouse.Controls.Add(Me.CheckBox6)
        Me.Gpx_Spouse.Controls.Add(Me.CheckBox7)
        Me.Gpx_Spouse.Controls.Add(Me.CheckBox8)
        Me.Gpx_Spouse.Controls.Add(Me.lblspouse)
        Me.Gpx_Spouse.Controls.Add(Me.txt_Spouse)
        Me.Gpx_Spouse.Controls.Add(Me.Cbo_Spousesalutation)
        Me.Gpx_Spouse.Controls.Add(Me.Label99)
        Me.Gpx_Spouse.Controls.Add(Me.Dtp_Spousedob)
        Me.Gpx_Spouse.Controls.Add(Me.ChK_SDOB)
        Me.Gpx_Spouse.Controls.Add(Me.dtp_DOW)
        Me.Gpx_Spouse.Controls.Add(Me.CHK_WDT)
        Me.Gpx_Spouse.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gpx_Spouse.Location = New System.Drawing.Point(32, 296)
        Me.Gpx_Spouse.Name = "Gpx_Spouse"
        Me.Gpx_Spouse.Size = New System.Drawing.Size(744, 64)
        Me.Gpx_Spouse.TabIndex = 838
        Me.Gpx_Spouse.TabStop = False
        Me.Gpx_Spouse.Visible = False
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(768, 1360)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(200, 24)
        Me.CheckBox5.TabIndex = 785
        Me.CheckBox5.Text = "Copy Contact Address"
        '
        'CheckBox6
        '
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(312, -116)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(192, 116)
        Me.CheckBox6.TabIndex = 781
        Me.CheckBox6.Text = "Copy Residence Address"
        '
        'CheckBox7
        '
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(400, 708)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(200, 24)
        Me.CheckBox7.TabIndex = 782
        Me.CheckBox7.Text = "Copy Contact Address"
        '
        'CheckBox8
        '
        Me.CheckBox8.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckBox8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(312, -156)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(200, 156)
        Me.CheckBox8.TabIndex = 783
        Me.CheckBox8.Text = "Copy Business Address"
        '
        'cmd_CorporateCodeHelp
        '
        Me.cmd_CorporateCodeHelp.Image = CType(resources.GetObject("cmd_CorporateCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CorporateCodeHelp.Location = New System.Drawing.Point(280, 88)
        Me.cmd_CorporateCodeHelp.Name = "cmd_CorporateCodeHelp"
        Me.cmd_CorporateCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_CorporateCodeHelp.TabIndex = 839
        '
        'Img_Spouse
        '
        Me.Img_Spouse.BackColor = System.Drawing.Color.Silver
        Me.Img_Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Spouse.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Img_Spouse.ForeColor = System.Drawing.Color.Black
        Me.Img_Spouse.Location = New System.Drawing.Point(1056, 272)
        Me.Img_Spouse.Name = "Img_Spouse"
        Me.Img_Spouse.Size = New System.Drawing.Size(104, 16)
        Me.Img_Spouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Spouse.TabIndex = 664
        Me.Img_Spouse.TabStop = False
        Me.Img_Spouse.Visible = False
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.Color.Transparent
        Me.Label102.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(600, 200)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(104, 21)
        Me.Label102.TabIndex = 842
        Me.Label102.Text = "Catholic [Y/N]"
        Me.Label102.Visible = False
        '
        'Cbo_relation
        '
        Me.Cbo_relation.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_relation.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_relation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_relation.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_relation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_relation.ItemHeight = 16
        Me.Cbo_relation.Location = New System.Drawing.Point(704, 200)
        Me.Cbo_relation.Name = "Cbo_relation"
        Me.Cbo_relation.Size = New System.Drawing.Size(136, 24)
        Me.Cbo_relation.TabIndex = 841
        Me.Cbo_relation.Visible = False
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(600, 176)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label57.Size = New System.Drawing.Size(96, 21)
        Me.Label57.TabIndex = 843
        Me.Label57.Text = "Cat. Limit"
        Me.Label57.Visible = False
        '
        'TXT_CATLIMIT
        '
        Me.TXT_CATLIMIT.BackColor = System.Drawing.Color.White
        Me.TXT_CATLIMIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CATLIMIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CATLIMIT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CATLIMIT.Enabled = False
        Me.TXT_CATLIMIT.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATLIMIT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_CATLIMIT.Location = New System.Drawing.Point(704, 174)
        Me.TXT_CATLIMIT.MaxLength = 35
        Me.TXT_CATLIMIT.Name = "TXT_CATLIMIT"
        Me.TXT_CATLIMIT.Size = New System.Drawing.Size(104, 22)
        Me.TXT_CATLIMIT.TabIndex = 844
        Me.TXT_CATLIMIT.Text = ""
        Me.TXT_CATLIMIT.Visible = False
        '
        'TXT_MEMLIMIT
        '
        Me.TXT_MEMLIMIT.BackColor = System.Drawing.Color.White
        Me.TXT_MEMLIMIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_MEMLIMIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_MEMLIMIT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_MEMLIMIT.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MEMLIMIT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_MEMLIMIT.Location = New System.Drawing.Point(704, 88)
        Me.TXT_MEMLIMIT.MaxLength = 35
        Me.TXT_MEMLIMIT.Name = "TXT_MEMLIMIT"
        Me.TXT_MEMLIMIT.Size = New System.Drawing.Size(104, 22)
        Me.TXT_MEMLIMIT.TabIndex = 846
        Me.TXT_MEMLIMIT.Text = ""
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.Color.Transparent
        Me.Label103.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(600, 88)
        Me.Label103.Name = "Label103"
        Me.Label103.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label103.Size = New System.Drawing.Size(96, 21)
        Me.Label103.TabIndex = 845
        Me.Label103.Text = "Credit Limit"
        '
        'Cmd_Replacement
        '
        Me.Cmd_Replacement.Image = CType(resources.GetObject("Cmd_Replacement.Image"), System.Drawing.Image)
        Me.Cmd_Replacement.Location = New System.Drawing.Point(248, 8)
        Me.Cmd_Replacement.Name = "Cmd_Replacement"
        Me.Cmd_Replacement.Size = New System.Drawing.Size(23, 24)
        Me.Cmd_Replacement.TabIndex = 847
        Me.Cmd_Replacement.Visible = False
        '
        'Label104
        '
        Me.Label104.BackColor = System.Drawing.Color.Transparent
        Me.Label104.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(280, 8)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(40, 24)
        Me.Label104.TabIndex = 848
        Me.Label104.Text = "R.no"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label104.Visible = False
        '
        'Txt_Rno
        '
        Me.Txt_Rno.BackColor = System.Drawing.SystemColors.Control
        Me.Txt_Rno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Rno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Rno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Rno.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Rno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_Rno.Location = New System.Drawing.Point(320, 8)
        Me.Txt_Rno.MaxLength = 10
        Me.Txt_Rno.Name = "Txt_Rno"
        Me.Txt_Rno.Size = New System.Drawing.Size(48, 22)
        Me.Txt_Rno.TabIndex = 849
        Me.Txt_Rno.Text = ""
        Me.Txt_Rno.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(848, 464)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(136, 40)
        Me.Button6.TabIndex = 850
        Me.Button6.Text = " View Data Sheet[F10]"
        '
        'IMG_SPOUSESIGN
        '
        Me.IMG_SPOUSESIGN.BackColor = System.Drawing.Color.Transparent
        Me.IMG_SPOUSESIGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMG_SPOUSESIGN.Location = New System.Drawing.Point(840, 336)
        Me.IMG_SPOUSESIGN.Name = "IMG_SPOUSESIGN"
        Me.IMG_SPOUSESIGN.Size = New System.Drawing.Size(152, 32)
        Me.IMG_SPOUSESIGN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_SPOUSESIGN.TabIndex = 851
        Me.IMG_SPOUSESIGN.TabStop = False
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.Color.Transparent
        Me.Label105.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(602, 148)
        Me.Label105.Name = "Label105"
        Me.Label105.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label105.Size = New System.Drawing.Size(86, 21)
        Me.Label105.TabIndex = 852
        Me.Label105.Text = "GSTIN No"
        '
        'Txt_GstinNo
        '
        Me.Txt_GstinNo.BackColor = System.Drawing.Color.White
        Me.Txt_GstinNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_GstinNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_GstinNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_GstinNo.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GstinNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_GstinNo.Location = New System.Drawing.Point(704, 148)
        Me.Txt_GstinNo.MaxLength = 35
        Me.Txt_GstinNo.Name = "Txt_GstinNo"
        Me.Txt_GstinNo.Size = New System.Drawing.Size(136, 22)
        Me.Txt_GstinNo.TabIndex = 853
        Me.Txt_GstinNo.Text = ""
        '
        'mem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1010, 748)
        Me.Controls.Add(Me.Txt_GstinNo)
        Me.Controls.Add(Me.Txt_Rno)
        Me.Controls.Add(Me.TXT_MEMLIMIT)
        Me.Controls.Add(Me.TXT_CATLIMIT)
        Me.Controls.Add(Me.Txt_CorporateCode)
        Me.Controls.Add(Me.Txt_Replacement)
        Me.Controls.Add(Me.Txt_Newmember)
        Me.Controls.Add(Me.Lbl_Last)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.TXT_TITLE)
        Me.Controls.Add(Me.txt_FirstName)
        Me.Controls.Add(Me.txt_MiddleName)
        Me.Controls.Add(Me.txt_Surname)
        Me.Controls.Add(Me.Label_Maxchar)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtICNO)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label105)
        Me.Controls.Add(Me.grp_ChildrenDetails)
        Me.Controls.Add(Me.IMG_SPOUSESIGN)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Grp_Address)
        Me.Controls.Add(Me.Label104)
        Me.Controls.Add(Me.Cmd_Replacement)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label102)
        Me.Controls.Add(Me.Cbo_relation)
        Me.Controls.Add(Me.cmd_CorporateCodeHelp)
        Me.Controls.Add(Me.Gpx_Spouse)
        Me.Controls.Add(Me.Chk_spouseFreeze)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Img_Spousephoto)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.chk_EXPDT)
        Me.Controls.Add(Me.CHK_DOJ)
        Me.Controls.Add(Me.CHK_DOB)
        Me.Controls.Add(Me.Label96)
        Me.Controls.Add(Me.Img_Signature)
        Me.Controls.Add(Me.Btn_Company)
        Me.Controls.Add(Me.Cbo_MaritalStatus)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Cbo_title)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.lbl_newmember)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label112)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btn_Entancefee)
        Me.Controls.Add(Me.btn_AccountsDetails)
        Me.Controls.Add(Me.Cmd_MemAddress)
        Me.Controls.Add(Me.Cmd_MemDep)
        Me.Controls.Add(Me.Cmd_Education)
        Me.Controls.Add(Me.cmd_RSIDetails)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdExport)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.chk_male)
        Me.Controls.Add(Me.chk_female)
        Me.Controls.Add(Me.cmd_MemberNo1)
        Me.Controls.Add(Me.Cmb_Category)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_BillingBasis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_CurrentStatus)
        Me.Controls.Add(Me.dtp_DOB)
        Me.Controls.Add(Me.dtp_DOJ)
        Me.Controls.Add(Me.dtp_EXPDT)
        Me.Controls.Add(Me.Img_Spouse)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Img_Photo)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cmbRankNo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dt_sdob)
        Me.Controls.Add(Me.Cbo_designation)
        Me.Controls.Add(Me.Cbo_professional)
        Me.Controls.Add(Me.Grp_Entrancefee)
        Me.Controls.Add(Me.Grp_AccountsDetails)
        Me.Controls.Add(Me.grbRSI)
        Me.Controls.Add(Me.grp_Entrancefeedetails)
        Me.Controls.Add(Me.Grp_MemQualification)
        Me.Controls.Add(Me.Gpr_Company)
        Me.Controls.Add(Me.grp_SportsIntrested)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grp_Address.ResumeLayout(False)
        Me.grp_ChildrenDetails.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRSI.ResumeLayout(False)
        CType(Me.SSgrid_Entrancefee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSgrid_Qual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_AccountsDetails.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Entrancefee.ResumeLayout(False)
        Me.grp_Entrancefeedetails.ResumeLayout(False)
        CType(Me.SSgrid_Entfee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSgrid_Sports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_SportsIntrested.ResumeLayout(False)
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_MemQualification.ResumeLayout(False)
        CType(Me.SSgrid_Qual_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpr_Company.ResumeLayout(False)
        Me.Gpx_Spouse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub mem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sqlstring = "Exec  member_membertype"
            membertype = gconnection.ExcuteStoreProcedure(sqlstring)
            FillTypeMst()
            Status()
            Relation()
            Title()
            City()
            State()
            Country()
            MaritalStatus()
            Designation()
            Professional()
            'CMD_TRANSFER.Enabled = False
            Call GetLastNo()
            Call loadmembertype(I + 1)
            Call loadSalutation(I + 1)
            'Insert.Clear(Insert, 0, Insert.Length)
            'Sqlstr = " Update  membermaster set  MEMIMAGE =ISNULL(MEMIMAGE,'') , MEMIMAGESIGN =ISNULL(MEMIMAGESIGN,'') , TAG =ISNULL(TAG,'') , MEMBERTYPECODE =ISNULL(MEMBERTYPECODE,'') , COMPANY =ISNULL(COMPANY,'') , SUBCD =ISNULL(SUBCD,'') , MCODE =ISNULL(MCODE,'') , MNAME =ISNULL(MNAME,'') , MID =ISNULL(MID,'') , DOB =ISNULL(DOB,'') , SDOB=ISNULL(SDOB,''),DOJ =ISNULL(DOJ,'') , SEX =ISNULL(SEX,'') , MARITALSTATUS =ISNULL(MARITALSTATUS,'') , SPOUSE =ISNULL(SPOUSE,'') , BG =ISNULL(BG,'') , OCCUPATION =ISNULL(OCCUPATION,'') , BANKER =ISNULL(BANKER,'') , BANKACNO =ISNULL(BANKACNO,'') , HOBBIES =ISNULL(HOBBIES,'') , OTHERINFO =ISNULL(OTHERINFO,'') , RESIDENT =ISNULL(RESIDENT,'') , EQUALIFICATION =ISNULL(EQUALIFICATION,'') , PQUALIFICATION =ISNULL(PQUALIFICATION,'') , PROPOSER =ISNULL(PROPOSER,'') , PROPOSERNAME =ISNULL(PROPOSERNAME,'') , SECONDER =ISNULL(SECONDER,'') , SECONDERNAME =ISNULL(SECONDERNAME,'') , PACOPYST =ISNULL(PACOPYST,'') , PADD1 =ISNULL(PADD1,'') , PADD2 =ISNULL(PADD2,'') , PADD3 =ISNULL(PADD3,'') , PCITY =ISNULL(PCITY,'') , PSTATE =ISNULL(PSTATE,'') , PCOUNTRY =ISNULL(PCOUNTRY,'') , PPIN =ISNULL(PPIN,'') , PPHONE1 =ISNULL(PPHONE1,'') , PPHONE2 =ISNULL(PPHONE2,'') , PCELL =ISNULL(PCELL,'') , PEMAIL =ISNULL(PEMAIL,'') , RACOPYST =ISNULL(RACOPYST,'') , CADD1 =ISNULL(CADD1,'') , CADD2 =ISNULL(CADD2,'') , CADD3 =ISNULL(CADD3,'') , CCITY =ISNULL(CCITY,'') , CSTATE =ISNULL(CSTATE,'') , CCOUNTRY =ISNULL(CCOUNTRY,'') , CPIN =ISNULL(CPIN,'') , CPHONE1 =ISNULL(CPHONE1,'') , CPHONE2 =ISNULL(CPHONE2,'') , CCELL =ISNULL(CCELL,'') , CEMAIL =ISNULL(CEMAIL,'') , CONTADD1 =ISNULL(CONTADD1,'') , CONTADD2 =ISNULL(CONTADD2,'') , CONTADD3 =ISNULL(CONTADD3,'') , CONTCITY =ISNULL(CONTCITY,'') , CONTSTATE =ISNULL(CONTSTATE,'') , CONTCOUNTRY =ISNULL(CONTCOUNTRY,'') , CONTPIN =ISNULL(CONTPIN,'') , CONTPHONE1 =ISNULL(CONTPHONE1,'') , CONTPHONE2 =ISNULL(CONTPHONE2,'') , CONTCELL =ISNULL(CONTCELL,'') , CONTEMAIL =ISNULL(CONTEMAIL,'') , EMPTYPE =ISNULL(EMPTYPE,'') , BUSINESSNAME =ISNULL(BUSINESSNAME,'') , BACOPYST =ISNULL(BACOPYST,'') , OADD1 =ISNULL(OADD1,'') , OADD2 =ISNULL(OADD2,'') , OADD3 =ISNULL(OADD3,'') , OCITY =ISNULL(OCITY,'') , OSTATE =ISNULL(OSTATE,'') , OCOUNTRY =ISNULL(OCOUNTRY,'') , OPIN =ISNULL(OPIN,'') , OPHONE1 =ISNULL(OPHONE1,'') , OPHONE2 =ISNULL(OPHONE2,'') , DOEPROFESSION =ISNULL(DOEPROFESSION,'') , BUSINESSNATURE =ISNULL(BUSINESSNATURE,'') , POSITIONHELD =ISNULL(POSITIONHELD,'') , SERVICENAME =ISNULL(SERVICENAME,'') , SERVICEYEAR =ISNULL(SERVICEYEAR,0) , PANO =ISNULL(PANO,'') , BBANKER =ISNULL(BBANKER,'') , CCNO =ISNULL(CCNO,'') , ANNUALINCOME =ISNULL(ANNUALINCOME,0) , UPDUSERID =ISNULL(UPDUSERID,'') , UPDDATETIME =ISNULL(UPDDATETIME,'') , TERMINATION =ISNULL(TERMINATION,'') , TRN_CON_DATE =ISNULL(TRN_CON_DATE,'') , CON_MCODE =ISNULL(CON_MCODE,'') , PFAX =ISNULL(PFAX,'') , CFAX =ISNULL(CFAX,'') , CONTFAX =ISNULL(CONTFAX,'') , REASON =ISNULL(REASON,'') , PHOTO =ISNULL(PHOTO,'') , CREDITLIMIT =ISNULL(CREDITLIMIT,0) , LIMITAMOUNT =ISNULL(LIMITAMOUNT,0) , WEBSITE =ISNULL(WEBSITE,'') , IMAGEFILE =ISNULL(IMAGEFILE,'') , SIZEFIELD =ISNULL(SIZEFIELD,0) , VDATE =ISNULL(VDATE,'') , VYEAR =ISNULL(VYEAR,0) , VALIDDATE =ISNULL(VALIDDATE,'') , TEMPTERMINATION =ISNULL(TEMPTERMINATION,'') , TEMPTERMDATE =ISNULL(TEMPTERMDATE,'') , TEMPTERMREASON =ISNULL(TEMPTERMREASON,'') , MEMBERID =ISNULL(MEMBERID,'') , ENDINGDATE =ISNULL(ENDINGDATE,'') , TOTALYEARS =ISNULL(TOTALYEARS,0) , CARDNO =ISNULL(CARDNO,'') , CARDEXPDATE =ISNULL(CARDEXPDATE,'') , VALIDITY =ISNULL(VALIDITY,'') , PERIOD =ISNULL(PERIOD,'') , CREDITCARDNO =ISNULL(CREDITCARDNO,'') , CREDITEXPDT =ISNULL(CREDITEXPDT,'') , TYPE =ISNULL(TYPE,'') , STATUSDATEFROM =ISNULL(STATUSDATEFROM,'') , STATUSDATETO =ISNULL(STATUSDATETO,'') , CURENTSTATUS =ISNULL(CURENTSTATUS,'') , FIRSTNAME =ISNULL(FIRSTNAME,'') , MIDDLENAME =ISNULL(MIDDLENAME,'') , SURNAME =ISNULL(SURNAME,'') , ALIAS =ISNULL(ALIAS,'') , PREFIX =ISNULL(PREFIX,'') , BILLTYPE =ISNULL(BILLTYPE,'') , NATIONALITY =ISNULL(NATIONALITY,'') , NATIONALITYATBIRTH =ISNULL(NATIONALITYATBIRTH,'') , BILLBASIS =ISNULL(BILLBASIS,'') , BILLHEAD =ISNULL(BILLHEAD,'') , GDRLOCKER =ISNULL(GDRLOCKER,'') , LDRLOCKER =ISNULL(LDRLOCKER,'') , HPLOCKER =ISNULL(HPLOCKER,'') , MEMBERSHIPTO =ISNULL(MEMBERSHIPTO,'') , SALUT =ISNULL(SALUT,'') , ENTRANCEFEE =ISNULL(ENTRANCEFEE,0) , DEVELOPMENTFEE =ISNULL(DEVELOPMENTFEE,0) , CRIDITNUMBER =ISNULL(CRIDITNUMBER,'') , SECURITYDEPOSIT =ISNULL(SECURITYDEPOSIT,0) , PLACEOFBIRTH =ISNULL(PLACEOFBIRTH,'') , COUNTRYOFBIRTH =ISNULL(COUNTRYOFBIRTH,'') , LASTARRIVALINCAL =ISNULL(LASTARRIVALINCAL,'') , PERIODOFSTAY_YEAR =ISNULL(PERIODOFSTAY_YEAR,0) , PERIODOFSTAY_MONTH =ISNULL(PERIODOFSTAY_MONTH,0) , PREVIOUSLYPROPOSED =ISNULL(PREVIOUSLYPROPOSED,'') , NOOFTIMESPROPOSED =ISNULL(NOOFTIMESPROPOSED,0) , DATEOFPROPOSAL =ISNULL(DATEOFPROPOSAL,'') , RESULTOFPROPOSAL =ISNULL(RESULTOFPROPOSAL,'') , ELECTED =ISNULL(ELECTED,'') , FATHERNAME =ISNULL(FATHERNAME,'') , DOBFATHER =ISNULL(DOBFATHER,'') , WIFEDOB =ISNULL(WIFEDOB,'') , MAIDENNAMEWIFE =ISNULL(MAIDENNAMEWIFE,'') , NATIONALITYWIFE =ISNULL(NATIONALITYWIFE,'') , WIFESFATHERNAME =ISNULL(WIFESFATHERNAME,'') , WIFEFATHERDOB =ISNULL(WIFEFATHERDOB,'') , APPLNO =ISNULL(APPLNO,'') , APPLDATE =ISNULL(APPLDATE,'') , CORPORATEST =ISNULL(CORPORATEST,'') , CORPORATECODE =ISNULL(CORPORATECODE,'') , COMPNAME =ISNULL(COMPNAME,'') , DESIGNATION =ISNULL(DESIGNATION,'') , PROFESSIONINFO =ISNULL(PROFESSIONINFO,'') , BUISNESSINFO =ISNULL(BUISNESSINFO,'') , PRODUCTS =ISNULL(PRODUCTS,'') , AGENTSDEALERS =ISNULL(AGENTSDEALERS,'') , ESTDDATE =ISNULL(ESTDDATE,'') , NOOFEMP =ISNULL(NOOFEMP,0) , TURNOVER =ISNULL(TURNOVER,0) , CLIENT =ISNULL(CLIENT,'') , APPLIEDBUT =ISNULL(APPLIEDBUT,'') , POSITIONINCHAMBER =ISNULL(POSITIONINCHAMBER,'') , QULIFICATIONSTATUS =ISNULL(QULIFICATIONSTATUS,'') , QUALIFICATION1 =ISNULL(QUALIFICATION1,'') , DETAILS1 =ISNULL(DETAILS1,'') , YEAROFPASSING1 =ISNULL(YEAROFPASSING1,'') , INSTITUTE1 =ISNULL(INSTITUTE1,'') , DIVISION1 =ISNULL(DIVISION1,'') , QUALIFICATION2 =ISNULL(QUALIFICATION2,'') , DETAILS2 =ISNULL(DETAILS2,'') , YEAROFPASSING2 =ISNULL(YEAROFPASSING2,'') , INSTITUTE2 =ISNULL(INSTITUTE2,'') , DIVISION2 =ISNULL(DIVISION2,'') , QUALIFICATION3 =ISNULL(QUALIFICATION3,'') , DETAILS3 =ISNULL(DETAILS3,'') , YEAROFPASSING3 =ISNULL(YEAROFPASSING3,'') , INSTITUTE3 =ISNULL(INSTITUTE3,'') , DIVISION3 =ISNULL(DIVISION3,'') , SPORTSTATUS =ISNULL(SPORTSTATUS,'') , GAMETYPE1 =ISNULL(GAMETYPE1,'') , NAMEOFGAME1 =ISNULL(NAMEOFGAME1,'') , DESCRIPTION1 =ISNULL(DESCRIPTION1,'') , GAMETYPE2 =ISNULL(GAMETYPE2,'') , NAMEOFGAME2 =ISNULL(NAMEOFGAME2,'') , DESCRIPTION2 =ISNULL(DESCRIPTION2,'') , GAMETYPE3 =ISNULL(GAMETYPE3,'') , NAMEOFGAME3 =ISNULL(NAMEOFGAME3,'') , DESCRIPTION3 =ISNULL(DESCRIPTION3,'') , CHILDSTATUS =ISNULL(CHILDSTATUS,'') , CHILDNAME1 =ISNULL(CHILDNAME1,'') , CHILDFDOB1 =ISNULL(CHILDFDOB1,'') , CHILDSEX1 =ISNULL(CHILDSEX1,'') , CHILDEXPAIRY1 =ISNULL(CHILDEXPAIRY1,'') , CHILDNAME2 =ISNULL(CHILDNAME2,'') , CHILDDOB2 =ISNULL(CHILDDOB2,'') , CHILDSEX2 =ISNULL(CHILDSEX2,'') , CHILDEXPAIRY2 =ISNULL(CHILDEXPAIRY2,'') , CHILDNAME3 =ISNULL(CHILDNAME3,'') , CHILDDOB3 =ISNULL(CHILDDOB3,'') , CHILDSEX3 =ISNULL(CHILDSEX3,'') , CHILDEXPAIRY3 =ISNULL(CHILDEXPAIRY3,'') , CLUBSTATUS =ISNULL(CLUBSTATUS,'') , OTHERCLUBNAME1 =ISNULL(OTHERCLUBNAME1,'') , OCADDRESS1 =ISNULL(OCADDRESS1,'') , OCSTATUS1 =ISNULL(OCSTATUS1,'') , OTHERCLUBNAME2 =ISNULL(OTHERCLUBNAME2,'') , OCADDRESS2 =ISNULL(OCADDRESS2,'') , OCSTATUS2 =ISNULL(OCSTATUS2,'') , OTHERCLUBNAME3 =ISNULL(OTHERCLUBNAME3,'') , OCADDRESS3 =ISNULL(OCADDRESS3,'') , OCSTATAUS =ISNULL(OCSTATAUS,'') , ADDUSER =ISNULL(ADDUSER,'') , ADDDATE =ISNULL(ADDDATE,'') , FREEZE =ISNULL(FREEZE,'') , RELATIVESTATUS =ISNULL(RELATIVESTATUS,'') , RELATIVENAME1 =ISNULL(RELATIVENAME1,'') , RELATION1 =ISNULL(RELATION1,'') , DATEOFBIRTH1 =ISNULL(DATEOFBIRTH1,'') , RELATIVEAGE1 =ISNULL(RELATIVEAGE1,'') , RELATIVESEX1 =ISNULL(RELATIVESEX1,'') , RELATIVEADDRESS1 =ISNULL(RELATIVEADDRESS1,'') , RELATIVENAME2 =ISNULL(RELATIVENAME2,'') , RELATION2 =ISNULL(RELATION2,'') , DATEOFBIRTH2 =ISNULL(DATEOFBIRTH2,'') , RELATIVEAGE2 =ISNULL(RELATIVEAGE2,'') , RELATIVESEX2 =ISNULL(RELATIVESEX2,'') , RELATIVEADDRESS2 =ISNULL(RELATIVEADDRESS2,'') , RELATIVENAME3 =ISNULL(RELATIVENAME3,'') , RELATION3 =ISNULL(RELATION3,'') , DATEOFBIRTH3 =ISNULL(DATEOFBIRTH3,'') , RELATIVEAGE3 =ISNULL(RELATIVEAGE3,'') , RELATIVESEX3 =ISNULL(RELATIVESEX3,'') , RELATIVEADDRESS3 =ISNULL(RELATIVEADDRESS3,'') , REFERENTIALST =ISNULL(REFERENTIALST,'') , MEM_CODE1 =ISNULL(MEM_CODE1,'') , MEM_NAME1 =ISNULL(MEM_NAME1,'') , REFMEM_DATE1 =ISNULL(REFMEM_DATE1,'') , DELETED1 =ISNULL(DELETED1,'') , MEM_CODE2 =ISNULL(MEM_CODE2,'') , MEM_NAME2 =ISNULL(MEM_NAME2,'') , REFMEM_DATE2 =ISNULL(REFMEM_DATE2,'') , DELETED2 =ISNULL(DELETED2,'') , MEM_CODE3 =ISNULL(MEM_CODE3,'') , MEM_NAME3 =ISNULL(MEM_NAME3,'') , REFMEM_DATE3 =ISNULL(REFMEM_DATE3,'') , DELETED3 =ISNULL(DELETED3,'') , ENTRANCEFEEST =ISNULL(ENTRANCEFEEST,'') , RECEIPTNO1 =ISNULL(RECEIPTNO1,'') , STARTDATE1 =ISNULL(STARTDATE1,'') , AMOUNT1 =ISNULL(AMOUNT1,'') , RECEIPTNO2 =ISNULL(RECEIPTNO2,'') , STARTDATE2 =ISNULL(STARTDATE2,'') , AMOUNT2 =ISNULL(AMOUNT2,'') , RECEIPTNO3 =ISNULL(RECEIPTNO3,'') , STARTDATE3 =ISNULL(STARTDATE3,'') , AMOUNT3 =ISNULL(AMOUNT3,'') , OLD =ISNULL(OLD,'') , CARDAMT =ISNULL(CARDAMT,0) , MINIMUMUSAGE =ISNULL(MINIMUMUSAGE,0) , CREDITNO =ISNULL(CREDITNO,'') , SPOUSEMOBILE =ISNULL(SPOUSEMOBILE,'') , PADD4 =ISNULL(PADD4,'') , CADD4 =ISNULL(CADD4,'') , EMAIL_FLAG =ISNULL(EMAIL_FLAG,'') , EBILL =ISNULL(EBILL,'') , WEDDING_DATE =ISNULL(WEDDING_DATE,'') , TAXFLAG =ISNULL(TAXFLAG,'') , MLEDGERNAME =ISNULL(MLEDGERNAME,'') "
            'Insert(0) = Sqlstr
            'gconnection.MoreTrans1(Insert)
            txt_Spouse.ReadOnly = False
            cbo_CurrentStatus.Enabled = True
            cbo_BillingBasis.Enabled = True
            Call CmdClear_Click(sender, e)
          
            Grp_Address.Visible = True
            grp_ChildrenDetails.Visible = False
            'Btn_update.Text = "U"
            txt_MemberCode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='CMG' AND MODULENAME LIKE '" & Trim(GmoduleName) & "'"
            gconnection.getDataSet(SQLSTRING, "USER")
            If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                    With gdataset.Tables("USER").Rows(i)
                        chstr = abcdMINUS(.Item("RIGHTS"))
                    End With
                Next
            End If
            Me.CmdAdd.Enabled = False
            'Me.cmdprint.Enabled = False
            Me.CmdView.Enabled = False
            Me.CmdExport.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.CmdAdd.Enabled = True
                        Me.CmdView.Enabled = True
                        Me.CmdExport.Enabled = True
                        Exit Sub
                    End If
                    If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                        If Right(x) = "S" Then
                            Me.CmdAdd.Enabled = True
                        End If
                    Else
                        If Right(x) = "U" Then
                            Me.CmdAdd.Enabled = True
                        End If
                    End If
                    If Right(x) = "F" Then
                        'Me.cmd_Delete.Enabled = True
                    End If
                    If Right(x) = "V" Then
                        Me.CmdView.Enabled = True
                        Me.CmdExport.Enabled = True
                    End If
                    If Right(x) = "P" Then
                        ' Me.cmdprint.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Public Sub FillTypeMst()
        Dim i As Integer
        Dim SSQL, CRED As String
        Dim SUBCATEGORY As New DataTable
        sqlstring = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cmb_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        Next
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            CRED = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMITYN"))
            'TXT_MEMLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
        End If
        If CRED = "Y" Then
            CREDITYN = "Y"
        Else
            CREDITYN = "N"
        End If
    End Sub
    Public Sub Relation()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_ReligionMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_relation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Title()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_TitleMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_title.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_Spousesalutation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub City()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_CityMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCity.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BCity.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CCity.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Country()
        Dim i As Integer
        sqlstring = "SELECT distinct(Country)as name FROM Tbl_CityMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCountry.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BCountry.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CCountry.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub State()
        Dim i As Integer
        sqlstring = "SELECT distinct(state) as name FROM Tbl_CityMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PState.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BState.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CState.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub

    Public Sub MaritalStatus()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_MaritalStatusMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_MaritalStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Designation()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_DesignationMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_designation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Professional()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_ProfessionalMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_professional.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Status()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM MemberStatusMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_CurrentStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Dependentagelimit()
        Dim i As Integer
        Dim Itration
        Dim depname As String
        sqlstring = "select CHILD_NM from memdet a left outer join  membermaster b on a.mEm_code =b.mcode where a.mem_code='" & Trim(txt_MemberCode.Text) & "' and relation  in ('SON','DAUGHTER','CHILD') and datediff(month,a.child_dob,getdate())-216>0  "
        gconnection.getDataSet(sqlstring, "DeptMst")
        If gdataset.Tables("DeptMst").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("DeptMst").Rows.Count - 1
                With ssgrid
                    ssgrid.Row = i + 1
                    ssgrid.Col = 2
                    .Text = (gdataset.Tables("DeptMst").Rows(i).Item("CHILD_NM"))
                    depname = .Text
                    MessageBox.Show("Name: " & depname & " Age is Above 18 years old ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With
            Next i
        End If
    End Sub
   
    Private Sub cmd_CorporateCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim vform As New ListOperation
        '    gSQLString = " Select CorporateCode,CorporateName from Mst_Mem_Corp_Mst "
        '    M_WhereCondition = " "
        '    vform.Field = "CorporateCode,CorporateName"
        '    vform.vFormatstring = "  Corporate Code  | Corporate Name                          "
        '    vform.vCaption = "Corporate Master Help"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txt_CorporateCode.Text = Trim(Trim(vform.keyfield & "") & "-" & Trim(vform.keyfield1 & ""))
        '        txt_CorporateCode.Select()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        'End Try
    End Sub

    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If txt_MemberCode.Text = "" Then
                    cmd_MemberCodeHelp_Click(sender, e)
                    Cbo_title.Focus()
                Else
                    'cbo_Title.Focus()
                    'TXT_TITLE.Focus()
                    Cbo_title.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub txt_FirstName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FirstName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_MiddleName.Focus()
        End If
    End Sub
    Private Sub txt_MiddleName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MiddleName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Surname.Focus()
        End If
    End Sub
    Private Sub txt_Surname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Surname.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_Spousesalutation.Focus()
            chk_male.Focus()

        End If
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            CHK_DOB.Focus()
        End If
    End Sub

    Private Sub cbo_CurrentStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_CurrentStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    'Private Sub chk_mshipfrom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_DOJ.CheckedChanged
    '    Try
    '        If CHK_DOJ.Checked = True Then
    '            'txtdoj.Visible = False
    '            'If Format(dtp_MembershipFrom.Value, "dd/MM/yyyy") = "01/01/1900" Then
    '            '    dtp_MembershipFrom.Value = Format(SYSDATE, "dd/MM/yyyy")
    '            'End If
    '            dtp_DOJ.Enabled = True
    '        Else
    '            dtp_DOJ.Enabled = False
    '            'txtdoj.Text = "__/__/___"
    '            'txtdoj.Visible = True
    '            'dtp_MembershipFrom.Value = Format(CDate("01/01/1900"), "dd/MM/yyyy")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
    'End Try
    'End Sub
    'Private Sub chk_mshipfrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CHK_DOJ.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If CHK_DOJ.Checked = True Then
    '            dtp_MembershipFrom.Focus()
    '        Else
    '            chk_EXPDT.Focus()
    '        End If
    '    End If
    'End Sub
    'Private Sub chk_mshipto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_EXPDT.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If chk_EXPDT.Checked = True Then
    '            'dtp_MembershipTo.Focus()
    '        Else
    '            If Grp_Address.Visible = True Then
    '                txt_PA_Address1.Focus()
    '            ElseIf Grp_MemQualification.Visible = True Then
    '                SSgrid_Qual.Focus()
    '            ElseIf grp_ChildrenDetails.Visible = True Then
    '                ssgrid.Focus()
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub dtp_MembershipTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If Grp_Address.Visible = True Then
    '            txt_PA_Address1.Focus()
    '        ElseIf Grp_MemQualification.Visible = True Then
    '            SSgrid_Qual.Focus()
    '        ElseIf grp_ChildrenDetails.Visible = True Then
    '            ssgrid.Focus()
    '            'ElseIf GP_ENTERENCEFEE.Visible = True Then
    '            '    TXT_OPLDEBIT.Select()
    '        End If
    '    End If
    'End Sub
    Private Sub chk_male_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            chk_female.Focus()
        End If
    End Sub
    Private Sub chk_female_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'chk_Married.Focus()
        End If
    End Sub
    Private Sub chk_Married_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If chk_Married.Checked = True Then
        '        CHK_WDT.Focus()
        '    Else

        '    End If
        'End If
    End Sub



    Private Sub CHK_DOB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If CHK_DOB.Checked = True Then
                'txtdob.Visible = False
                'If Format(dtp_DateOfBirth.Value, "dd/MM/yyyy") = "01/01/1900" Then
                '    dtp_DateOfBirth.Value = Format(SYSDATE, "dd/MM/yyyy")
                'End If
                dtp_DOB.Enabled = True
            Else
                'txtdob.Text = "__/__/___"
                'txtdob.Visible = True
                'dtp_DateOfBirth.Value = Format(CDate("01/01/1900"), "dd/MM/yyyy")
                dtp_DOB.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub CHK_DOB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If CHK_DOB.Checked = True Then
                dtp_DOB.Focus()
            Else
                CHK_DOJ.Focus()
            End If
        End If
    End Sub
    'Private Sub dtp_MembershipFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If chk_EXPDT.Checked = True Then
    '            dtp_EXPDT.Focus()
    '        Else
    '            chk_EXPDT.Focus()
    '        End If
    '    End If
    'End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            grbRSI.Visible = False
            Dim i As Integer
            Cmb_Category.Enabled = True
            Cmb_Category.Text = "ASSOCIATE"
            If Cmb_Category.Items.Count > 0 Then
                Cmb_Category.SelectedIndex = 0
            End If
            If cbo_BillingBasis.Items.Count > 0 Then
                cbo_BillingBasis.SelectedIndex = 0
            End If
            If Cbo_servives.Items.Count > 0 Then
                Cbo_servives.SelectedIndex = 0
            End If
            Txt_Rno.Enabled = False
            cbo_CurrentStatus.Enabled = True
            cbo_CurrentStatus.Text = "ACTIVE"

            Txt_GstinNo.Text = ""

            If cbo_CurrentStatus.Items.Count > 0 Then
                cbo_CurrentStatus.SelectedIndex = 0
            End If
            If Cbo_designation.Items.Count > 0 Then
                Cbo_designation.SelectedIndex = 0
            End If
            'If Cbo_MaritalStatus.Items.Count > 0 Then
            '    Cbo_MaritalStatus.SelectedIndex = 0
            'End If
            Cbo_MaritalStatus.SelectedIndex = -1
            Cbo_professional.SelectedIndex = -1
            If Cbo_relation.Items.Count > 0 Then
                Cbo_relation.SelectedIndex = 0
            End If
            TXT_CATLIMIT.Text = ""
            TXT_MEMLIMIT.Text = ""
            txt_MemberCode.Text = ""
            'CMD_TRANSFER.Enabled = False
            Txt_Replacement.Text = ""
            Txt_Rno.Text = ""
            Insert.Clear(Insert, 0, Insert.Length)
            TXT_TITLE.Text = ""
            txt_FirstName.Text = ""
            txt_MiddleName.Text = ""
            Txt_Newmember.Text = ""
            txt_Surname.Text = ""
            Txt_CorporateCode.Text = ""
            Txt_AppNo.Text = ""
            Txt_Newmember.Text = ""
            'Txt_oldmembership.Text = ""
            Cbo_professional.Text = ""
            CHK_DOB.Checked = False
            CHK_DOJ.Checked = False
            chk_EXPDT.Checked = False
            Chk_spouseFreeze.Checked = False
            chk_EXPDT_CheckedChanged(sender, e)
            For i = 1 To ssgrid.DataRowCnt
                With ssgrid
                    .Row = i
                    .Col = 9
                    VFilePath = AppPath & "\Reports\" & Trim(.Text) & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                End With
            Next
            chk_EXPDT.Checked = False
            chk_EXPDT.Enabled = True
            dtp_EXPDT.Enabled = True
            dtp_EXPDT.Value = Now

            'dtp_DOB.Text = ""
            'dtp_DOJ.Text = ""
            dtp_DOW.Text = ""
            dtp_EXPDT.Text = ""
            Dtp_Appdate.Text = ""
            Dtp_Spousedob.Text = ""
            chk_male.Checked = True
            Img_Photo.Image = Nothing
            Img_Signature.Image = Nothing
            Img_Spousephoto.Image = Nothing
            IMG_SPOUSESIGN.Image = Nothing
            strPhotoFilePath = ""
            strPhotoFilePath_SIG = ""
            strPhotoFilePath_Spouse = ""
            strPhotoFilePath_SpouseImg = ""
            CHK_DOB_CheckedChanged(sender, e)
            chk_EXPDT_CheckedChanged(sender, e)
            CHK_DOJ_CheckedChanged(sender, e)
            ChK_SDOB_CheckedChanged(sender, e)
            ChK_SDOB_CheckedChanged_1(sender, e)
            CHK_WDT_CheckedChanged(sender, e)
            ssgrid.DeleteRows(1, ssgrid.DataRowCnt)
            SSgrid_Entfee.ClearRange(1, 1, -1, -1, True)
            ssgrid.ClearRange(1, 1, -1, -1, True)
            SSgrid_Qual_det.ClearRange(1, 1, -1, -1, True)
            'chk_Married.Checked = False
            chk_Married_CheckedChanged(sender, e)
            CHK_WDT.Checked = False
            ChK_SDOB.Checked = False
            chk_male.Checked = False
            chk_female.Checked = False
            dtp_DOB.Enabled = False
            dtp_DOJ.Enabled = False
            dtp_DOW.Enabled = False
            Dtp_Spousedob.Enabled = False
            dtp_EXPDT.Enabled = False
            chk_ContactAddress1.Checked = False
            chk_ContactAddress2.Checked = False
            chk_ContactAddress3.Checked = False
            txt_Spouse.Text = ""
            txt_ProposedName.Text = ""
            txt_ProposerCode.Text = ""
            txt_SeconderCode.Text = ""
            txt_SeconderName.Text = ""
            grp_Entrancefeedetails.Visible = False
            txt_PA_Address1.Text = ""
            txt_PA_Address2.Text = ""
            txt_PA_Address3.Text = ""
            txt_PA_City.Text = ""
            txt_PA_State.Text = ""
            txt_PA_PinCode.Text = ""
            txt_PA_Phone.Text = ""
            txt_PA_Phone2.Text = ""
            txt_PA_Mobile.Text = ""
            txt_PA_Email.Text = ""
            txt_BA_Address1.Text = ""
            txt_BA_Address2.Text = ""
            txt_BA_Address3.Text = ""
            'txt_BA_City.Text = ""
            'txt_BA_State.Text = ""
            'txt_BA_Country.Text = ""

            txt_BA_PinCode.Text = ""
            txt_BA_PhoneNo.Text = ""
            txt_BA_PhoneNo2.Text = ""
            txt_BA_MobileNo.Text = ""
            txt_BA_Email.Text = ""
            txt_RA_Address1.Text = ""
            txt_RA_Address2.Text = ""
            txt_RA_Address3.Text = ""
            txt_RA_City.Text = ""
            txt_RA_State.Text = ""
            'txt_RA_Country.Text = ""
            txt_RA_PinCode.Text = ""
            txt_RA_PhoneNo.Text = ""
            txt_RA_PhoneNo2.Text = ""
            txt_RA_MobileNo.Text = ""
            txt_RA_Email.Text = ""
            cmbRankNo.Text = ""
            txtICNO.Text = ""
            cmbUnitNo.Text = ""
            Txt_pancarno.Text = ""
            dtpDFCommission.Text = ""
            dtpDFCreation.Text = ""
            dtpDFRelease.Text = ""
            txtMemberDescription.Text = ""
            txtRIDCARDNO.Text = ""
            txtArmService.Text = ""
            txtWO.Text = ""
            txtNFDependencies.Text = ""
            txtRBYMEMBERNO.Text = ""
            txtNBYMEMBERNAME.Text = ""
            Cbo_Spousesalutation.SelectedIndex = -1
            Cbo_PCity.SelectedIndex = -1
            Cbo_PState.SelectedIndex = -1
            Cbo_PCountry.SelectedIndex = -1
            Cbo_BCity.SelectedIndex = -1
            Cbo_BState.SelectedIndex = -1
            Cbo_BCountry.SelectedIndex = -1
            Cbo_CCity.SelectedIndex = -1
            Cbo_CState.SelectedIndex = -1
            Cbo_CCountry.SelectedIndex = -1
            Cbo_title.SelectedIndex = -1
            Cbo_relation.SelectedIndex = -1
            Cbo_designation.SelectedIndex = -1
            Cbo_MaritalStatus.SelectedIndex = -1
            Txt_companyName.Text = ""
            Txt_Bussinessinfo.Text = ""
            Txt_Professionalinfo.Text = ""
            Txt_products.Text = ""
            Txt_Designation.Text = ""
            Txt_turnover.Text = ""
            Txt_AgenttInfo.Text = ""
            Txt_noofEmpolyee.Text = ""
            'Btn_update.Text = "U"
            Me.CmdAdd.Text = "Add[F7]"
            Me.CmdAdd.Enabled = True
            Me.txt_Spouse.ReadOnly = False
            Me.txt_MemberCode.ReadOnly = False
            Me.Cmd_MemDep_Click(sender, e)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Call loadmembertype(i + 1)
            Call loadSalutation(i + 1)
            grp_ChildrenDetails.Visible = False
            Grp_Address.Visible = True
            Me.txt_MemberCode.Focus()
            txt_MemberCode.Focus()
            chk_EXPDT.Enabled = True
            cbo_BillingBasis.Enabled = True
            TXT_MEMLIMIT.Text = TXT_CATLIMIT.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub


    Private Sub chk_EXPDT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If chk_EXPDT.Checked = True Then
                ''txtexpdt.Visible = False
                ''If Format(dtp_MembershipTo.Value, "dd/MM/yyyy") = "01/01/1900" Then
                ''    dtp_MembershipTo.Value = Format(SYSDATE, "dd/MM/yyyy")
                ''End If
                dtp_EXPDT.Enabled = True
            Else
                'txtexpdt.Text = "__/__/___"
                'txtexpdt.Visible = True
                'dtp_MembershipTo.Value = Format(CDate("01/01/1900"), "dd/MM/yyyy")
                dtp_EXPDT.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub



    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim vform As New ListOperation
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
                CmdAdd.Text = "Update[F7]"
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub


    Private Sub Cmd_MemAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_MemAddress.Click
        Try
            'Grp_Address.Location = New Point(120, 239)
            'Grp_Address.Size = New Size(744, 273)
            grp_ChildrenDetails.Visible = False
            'GP_ENTERENCEFEE.Visible = False
            Grp_MemQualification.Visible = False
            Grp_Address.Visible = True
            grbRSI.Visible = False
            Grp_Entrancefee.Visible = False
            grp_Entrancefeedetails.Visible = False
            Grp_AccountsDetails.Visible = False
            Gpr_Company.Visible = False
            txt_PA_Address1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Try
            'Dim freezed As Integer
            Dim spouse As String
            Insert.Clear(Insert, 0, Insert.Length)
            Array.Clear(Insert, 0, Insert.Length)
            Dim i, j As Integer
            Dim PRONAME(0), SECNAME(0), MEMTYPE(0), CORPNAME(0)
            If checkValidation1() = False Then Exit Sub
            If CmdAdd.Text = "Add[F7]" Then
                Dim gender, MARITALSTATUS As String
                If chk_female.Checked = True Then
                    gender = "F"
                Else
                    gender = "M"
                End If
                If CorporateYN = True Then
                    If Corporate() = False Then Exit Sub

                End If
                If CHK_DOB.Checked = True Then
                    dob = Format(CDate(dtp_DOB.Text), "dd/MMM/yyyy")
                Else
                    dob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_DOJ.Checked = True Then
                    doj = Format(CDate(dtp_DOJ.Text), "dd/MMM/yyyy")
                Else
                    doj = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If chk_EXPDT.Checked = True Then
                    expt = Format(CDate(dtp_EXPDT.Text), "dd/MMM/yyyy")
                Else
                    expt = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                If CHK_WDT.Checked = True Then
                    dow = Format(CDate(dtp_DOW.Text), "dd/MMM/yyyy")
                Else
                    dow = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If ChK_SDOB.Checked = True Then
                    sdob = Format(CDate(Dtp_Spousedob.Text), "dd/MMM/yyyy")
                Else
                    sdob = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                'if 
                '    chk_ContactAddress3.Checked = False
                'Else

                'If chk_Married.Checked = True Then
                '    MARITALSTATUS = "Y"
                'Else
                '    MARITALSTATUS = "N"
                'End If
                sqlstring = "Exec  member_membertype "
                membertype = gconnection.ExcuteStoreProcedure(sqlstring)

                gconnection.getDataSet("SELECT subtypecode FROM Subcategorymaster WHERE ISNULL(FREEZE,'')<>'Y' and subTYPEDESC='" & Cmb_Category.Text & "'", "TypeMst")
                If gdataset.Tables("TypeMst").Rows.Count > 0 Then
                    txtCategory.Text = CheckDBNull(gdataset.Tables("TypeMst").Rows(0).Item("subtypecode"))
                End If
                Sqlstr = "Insert Into Membermaster(MEMBERTYPECODE,Mcode,MName,FirstName,MiddleName,Surname,salut,Prefix,Sex,MARITALSTATUS,membertype,CurentStatus,DOB,DOJ,wedding_date,Endingdate,SPOUSE,SDOB,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,RByMemberNo,RByName,RBYMEMBERNO2,RBYMEMBERNAME2,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,PROPOSER, PROPOSERNAME, SECONDER, SECONDERNAME,ApplNo,ApplDate,PANO,BG,CriditNumber,MARITAL_STATUS,Billbasis,religion,Company,Designation,BuisnessInfo,ProfessionInfo,Products ,AgentsDealers ,Turnover ,NoOfEmp,newmcode,spouseprefix,CATLIMIT,MEMLIMIT,REPLACEMENT,RNO,Corporatecode"
                Sqlstr = Sqlstr & " )VALUES ('" & _
                Trim(txtCategory.Text.Replace("'", "")) & "','" & _
                Trim(txt_MemberCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "','" & _
                txt_FirstName.Text.Replace("'", "") & "','" & _
                txt_MiddleName.Text.Replace("'", "") & "','" & _
                txt_Surname.Text.Replace("'", "") & "','" & _
                Trim(Cbo_title.Text) & "','" & _
                Trim(TXT_TITLE.Text.Replace("'", "")) & "','" & gender & "','" & MARITALSTATUS & "','" & _
                Cmb_Category.Text.Replace("'", "") & "','" & _
                cbo_CurrentStatus.Text & "',Convert(datetime,'" & (dtp_DOB.Text) & "',103),Convert(datetime,'" & (dtp_DOJ.Text) & "',103),Convert(datetime,'" & (dow) & "',103),Convert(datetime,'" & (expt) & "',103),'" & _
                Trim(txt_Spouse.Text) & "',Convert(datetime,'" & (sdob) & "',103),'" & txtICNO.Text.Replace("'", "") & "','" & _
                cmbUnitNo.Text.Replace("'", "") & "','" & _
                cmbRankNo.Text & "',Convert(datetime,'" & dtpDFCommission.Text & "',103),Convert(datetime,'" & dtpDFRelease.Text & "',103),Convert(datetime,'" & dtpDFCreation.Text & "',103),'" & _
                Cbo_servives.Text.Replace("'", "") & "','" & _
                txtRIDCARDNO.Text.Replace("'", "") & "','" & _
                txtArmService.Text.Replace("'", "") & "','" & _
                txtWO.Text.Replace("'", "") & "','" & _
                txtNFDependencies.Text.Replace("'", "") & "','" & _
                txtRBYMEMBERNO.Text.Replace("'", "") & "','" & _
                txtNBYMEMBERNAME.Text.Replace("'", "") & "','" & _
                txtRBYMEMBERNO2.Text.Replace("'", "'") & "','" & _
                txtNBYMEMBERNAME2.Text.Replace("'", "'") & "','" & _
                Trim(txt_BA_Address1.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Address2.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BState.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BCountry.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PinCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address1.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address2.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_PCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_PState.Text.Replace("'", "'")) & "','" & _
                Trim(Cbo_PCountry.Text.Replace("'", "'")) & "','" & _
                Trim(txt_PA_PinCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Phone.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Phone2.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Mobile.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_RA_Address1.Text.Replace("'", "")) & "','" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "','" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CState.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CCountry.Text.Replace("'", "")) & "','" & _
                Trim(txt_RA_PinCode.Text.Replace("'", "")) & "','" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "','" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "','" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "','" & Trim(txt_RA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_ProposerCode.Text.Replace("'", "")) & "','" & Trim(txt_ProposedName.Text.Replace("'", "")) & "','" & Trim(txt_SeconderCode.Text.Replace("'", "")) & "','" & Trim(txt_SeconderName.Text.Replace("'", "")) & "','" & _
                Trim(Txt_AppNo.Text) & "',Convert(datetime,'" & (Dtp_Appdate.Text) & "',103),'" & Trim(Txt_pancarno.Text) & "', '" & _
                Trim(Txt_BloodGroup.Text) & "','" & _
                Trim(txt_CreditNumber.Text) & "','" & _
                Trim(Cbo_MaritalStatus.Text) & "','" & _
                Trim(cbo_BillingBasis.Text) & "','" & _
                Trim(Cbo_relation.Text) & "','" & _
                Trim(Txt_companyName.Text) & "','" & _
                Trim(Cbo_designation.Text) & "','" & _
                Trim(Txt_Bussinessinfo.Text) & "','" & _
                Trim(Cbo_professional.Text) & "','" & _
                Trim(Txt_products.Text) & "','" & _
                Trim(Txt_AgenttInfo.Text) & "','" & _
                Val(Txt_turnover.Text) & "','" & _
                Val(Txt_noofEmpolyee.Text) & "','" & _
                Trim(txt_MemberCode.Text) & "','" & _
                Trim(Cbo_Spousesalutation.Text) & "'," & _
                Val(TXT_CATLIMIT.Text) & "," & _
                Val(TXT_MEMLIMIT.Text) & ",'" & _
                Trim(Txt_Replacement.Text) & "','" & _
                Trim(Txt_Rno.Text) & "','" & _
                Trim(Txt_CorporateCode.Text) & "'"
                Sqlstr = Sqlstr & ")"
                'gconnection.dataOperation(2, Sqlstr, "Membermaster")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr

                Sqlstr = "UPDATE membermaster SET MEMGSTIN = '" & Trim(Txt_GstinNo.Text) & "' WHERE Mcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr

                '======Spouse Freeze
                If Chk_spouseFreeze.Checked = True Then
                    Sqlstr = " Update membermaster set SpouseFreeze='Y'"
                    'gconnection.dataOperation(2, Sqlstr, "membermaster")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                Else
                    Sqlstr = " Update membermaster set SpouseFreeze='N'"
                    'gconnection.dataOperation(2, Sqlstr, "membermaster")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                End If

                'DEPENTDENT DETAILS
                Sqlstr = " Delete From memdet Where Type0='CHLD' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                'gconnection.dataOperation(1, Sqlstr, "memdet")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        Sqlstr = "Insert Into memdet(mem_code,type0,prefix,child_nm,SpouseName,child_dob,membertype,sex,relation,maritalstatus,dep_bloodgroup,studentmember,dep_Doj,Religion,anniversarydate,occupation,Panno,phone,mobile,emailid)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','CHLD'"
                        ssgrid.Row = i
                        'prefix
                        ssgrid.Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'depName
                        ssgrid.Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'spousename
                        ssgrid.Col = 6
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'dob
                        ssgrid.Col = 3
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'membertype
                        ssgrid.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'gender
                        ssgrid.Col = 4
                        If Mid(UCase(Trim(.Text)), 1, 1) = "F" Or Mid(UCase(Trim(.Text)), 1, 1) = "D" Then
                            Sqlstr = Sqlstr & ",'F'"
                        Else
                            Sqlstr = Sqlstr & ",'M'"
                        End If
                        'relation
                        ssgrid.Col = 5
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        'marital
                        ssgrid.Col = 7
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'BG
                        ssgrid.Col = 13
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'sr.dep
                        ssgrid.Col = 14
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'doj
                        ssgrid.Col = 15
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'Romancatholic
                        ssgrid.Col = 17
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'anniversary date
                        ssgrid.Col = 8
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'occupation
                        ssgrid.Col = 18
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'panno
                        ssgrid.Col = 19
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'phone
                        ssgrid.Col = 20
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'mob
                        ssgrid.Col = 21
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'email
                        ssgrid.Col = 22
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "')"
                        ' gconnection.dataOperation(1, Sqlstr, "memdet")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i

                'UPDATE SPOUSE NAME INTO MEMBERMASTER
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        Sqlstr = "UPDATE membermaster SET SPOUSE = "
                '        .Row = i
                '        .Col = 6
                '        If (.Text) = "Spouse" Or (.Text) = "SPOUSE" Then
                '            .Row = i
                '            .Col = 1
                '            Sqlstr = Sqlstr & "'" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                '        Else
                '            Sqlstr = Sqlstr & " ' ' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "' "
                '        End If
                '        gconnection.dataOperation(1, Sqlstr, "membermaster")
                '    End With
                'Next i




                'Education DETAILS
                Sqlstr = " Delete From memdet Where Type0='QUAL' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To SSgrid_Qual_det.DataRowCnt
                    With SSgrid_Qual_det
                        Sqlstr = "INSERT INTO MEMDET(MEM_CODE,TYPE0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','QUAL'"
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 3
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 4
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 5
                        Sqlstr = Sqlstr & ",'" & .Text & "')"

                        'gconnection.dataOperation(1, Sqlstr, "memdet")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i

                For i = 1 To SSgrid_Qual_det.DataRowCnt
                    With SSgrid_Qual_det
                        Sqlstr = "UPDATE membermaster SET Qualification" & i & "="
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & .Text & "',"
                        .Col = 2
                        Sqlstr = Sqlstr & "Details" & i & "='" & .Text & "',"
                        .Col = 3
                        Sqlstr = Sqlstr & "YearOfPassing" & i & "='" & .Text & "',"
                        .Col = 4
                        Sqlstr = Sqlstr & "Institute" & i & "='" & .Text & "',"
                        .Col = 5
                        Sqlstr = Sqlstr & "Division" & i & "='" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                        'gconnection.dataOperation(1, Sqlstr, "membermaster")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i
                Dim SQLSTR5 As String
                If chk_ContactAddress1.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='Y',BACopyst1='N',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                ElseIf chk_ContactAddress2.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='Y',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                ElseIf chk_ContactAddress3.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='N',RACopyst1='Y' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                Else
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='N',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"

                End If
                'gconnection.dataOperation(1, SQLSTR5, "membermaster")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                'ENTERENCE FEE DETAILS
                Sqlstr = " Delete From memdet Where Type0='ENTR' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 0 To SSgrid_Entfee.DataRowCnt - 1
                    Sqlstr = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT)"
                    Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','ENTR',"
                    With SSgrid_Entfee
                        .Row = i + 1
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "',"
                        .Row = i + 1
                        .Col = 2
                        If Len(Trim(.Text)) > 7 Then
                            Sqlstr = Sqlstr & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                        Else
                            Sqlstr = Sqlstr & "'',"
                        End If

                        .Row = i + 1
                        .Col = 3
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "')"
                    End With
                    'gconnection.dataOperation(1, Sqlstr, "memdet")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                Next i
                Sqlstr = " Insert Into Accountssubledgermaster(accode,acdesc,sltype,slcode,slname,sldesc,address1,address2,address3,city,state,pin,phoneno,cellno,contactperson) "
                Sqlstr = Sqlstr & " values('" & gDebtors & "','" & gDebdesc & "','MEMBER','" & txt_MemberCode.Text & "','" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & "'" & Trim(txt_FirstName.Text) & " " & Trim(txt_MiddleName.Text) & " " & Trim(txt_Surname.Text) & "',"
                If chk_ContactAddress1.Checked = True Then
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                Else
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "'" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                End If
                Sqlstr = Sqlstr & "'" & Trim(txt_FirstName.Text) & " " & Trim(txt_MiddleName.Text) & " " & Trim(txt_Surname.Text) & "')"
                ' gconnection.dataOperation(1, Sqlstr, "Accountssubledgermaster")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                Sqlstr = "Update membermaster Set"
                If chk_ContactAddress1.Checked = True Then

                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N'"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N'"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='Y'"


                End If
                Sqlstr = Sqlstr & " Where Mcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                'gconnection.dataOperation(1, Sqlstr, "MEMBERMSORDERNO")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                gconnection.MoreTrans(Insert)
                Loadimage()

            Else

                If checkValidation() = False Then Exit Sub
                If CorporateYN = True Then
                    If Corporate() = False Then Exit Sub

                End If

                Sqlstr = " Update Accountssubledgermaster Set "
                Sqlstr = Sqlstr & " slname='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                If chk_ContactAddress1.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "'"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "'"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "'"
                Else
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "'"
                End If

                Sqlstr = Sqlstr & " Where Slcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                gconnection.dataOperation(1, Sqlstr, "Accountssubledgermaster")

                sqlstring = "Exec  member_membertype"
                membertype = gconnection.ExcuteStoreProcedure(sqlstring)

                If CHK_DOB.Checked = True Then
                    dob = Format(CDate(dtp_DOB.Text), "dd/MMM/yyyy")
                Else
                    dob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_DOJ.Checked = True Then
                    doj = Format(CDate(dtp_DOJ.Text), "dd/MMM/yyyy")
                Else
                    doj = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If chk_EXPDT.Checked = True Then
                    expt = Format(CDate(dtp_EXPDT.Text), "dd/MMM/yyyy")
                Else
                    expt = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If ChK_SDOB.Checked = True Then
                    sdob = Format(CDate(Dtp_Spousedob.Text), "dd/MMM/yyyy")
                Else
                    sdob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_WDT.Checked = True Then
                    dow = Format(CDate(dtp_DOW.Text), "dd/MMM/yyyy")
                Else
                    dow = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                Sqlstr = " Update Membermaster Set "
                Sqlstr = Sqlstr & " salut='" & Trim(Cbo_title.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Prefix='" & Trim(TXT_TITLE.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " FirstName='" & Trim(txt_FirstName.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " MiddleName='" & Trim(txt_MiddleName.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Surname='" & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Mname='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"

                Dim index As Integer
                gconnection.getDataSet("SELECT MEMBERTYPE FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and TYPEDESC='" & Cmb_Category.Text & "'", "TypeMst")
                Sqlstr = Sqlstr & " MEMBERTYPE ='" & Cmb_Category.Text.Replace("'", "") & "',"
                Sqlstr = Sqlstr & " Billbasis='" & Trim(cbo_BillingBasis.Text) & "',"
                If cbo_CurrentStatus.Text = "ACTIVE" Then
                    Sqlstr = Sqlstr & " CurentStatus='ACTIVE',"
                Else
                    Sqlstr = Sqlstr & " CurentStatus='" & cbo_CurrentStatus.Text & "',"
                End If

                Sqlstr = Sqlstr & " DOB=Convert(datetime,'" & (dob) & "',103),"
                Sqlstr = Sqlstr & " DOJ=Convert(datetime,'" & (doj) & "',103),"
                Sqlstr = Sqlstr & " Endingdate=Convert(datetime,'" & (expt) & "',103),"
                If chk_female.Checked = True Then
                    Sqlstr = Sqlstr & " SEX ='F',"
                Else
                    Sqlstr = Sqlstr & " SEX ='M',"
                End If
                Sqlstr = Sqlstr & " MEMGSTIN ='" & Trim(Txt_GstinNo.Text) & "',"
                Sqlstr = Sqlstr & " spouseprefix='" & Trim(Cbo_Spousesalutation.Text) & "',"
                Sqlstr = Sqlstr & " SPOUSE='" & Trim(txt_Spouse.Text) & "',"
                Sqlstr = Sqlstr & "  adduser ='" & gUsername & "',"
                Sqlstr = Sqlstr & "  adddate =getdate(),"
                Sqlstr = Sqlstr & "  freeze ='N',"
                Sqlstr = Sqlstr & " SDOB= Convert(datetime,'" & (sdob) & "',103),"
                Sqlstr = Sqlstr & " wedding_date= Convert(datetime,'" & (dow) & "',103),"
                Sqlstr = Sqlstr & " PADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " PCITY='" & Trim(Cbo_PCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PSTATE='" & Trim(Cbo_PState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PCOUNTRY='" & Trim(Cbo_PCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " PPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"

                If chk_ContactAddress1.Checked = True Then

                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_PCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_PState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_PCountry.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N',"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_BCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_BState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_BCountry.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N',"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_CCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_CState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_CCountry.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='Y',"
                End If

                Sqlstr = Sqlstr & " CADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCITY='" & Trim(Cbo_CCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CSTATE='" & Trim(Cbo_CState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCOUNTRY='" & Trim(Cbo_CCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " CPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " OADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCITY='" & Trim(Cbo_BCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OSTATE='" & Trim(Cbo_BState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCOUNTRY='" & Trim(Cbo_BCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " OPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " MARITAL_STATUS='" & Trim(Cbo_MaritalStatus.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " religion='" & Trim(Cbo_relation.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Designation='" & Trim(Cbo_designation.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " BG = '" & Trim(Txt_BloodGroup.Text) & "',"
                Sqlstr = Sqlstr & " COMPANY = '" & Trim(Txt_companyName.Text) & "',"
                Sqlstr = Sqlstr & " occupation = '" & Trim(Txt_Designation.Text) & "',"
                Sqlstr = Sqlstr & " BuisnessInfo = '" & Trim(Txt_Bussinessinfo.Text) & "',"
                'Sqlstr = Sqlstr & " ProfessionInfo = '" & Trim(Txt_Professionalinfo.Text) & "',"
                Sqlstr = Sqlstr & " ProfessionInfo = '" & Trim(Cbo_professional.Text) & "',"
                Sqlstr = Sqlstr & " Products = '" & Trim(Txt_products.Text) & "',"
                Sqlstr = Sqlstr & " AgentsDealers = '" & Trim(Txt_AgenttInfo.Text) & "',"
                Sqlstr = Sqlstr & " Turnover = '" & Val(Txt_turnover.Text) & "',"
                Sqlstr = Sqlstr & " NoOfEmp = '" & Val(Txt_noofEmpolyee.Text) & "',"
                'Sqlstr = Sqlstr & " oldmcode = '" & Val(Txt_oldmembership.Text) & "',"
                Sqlstr = Sqlstr & " MEMLIMIT = '" & Val(TXT_MEMLIMIT.Text) & "',"
                Sqlstr = Sqlstr & " CATLIMIT = '" & Val(TXT_CATLIMIT.Text) & "',"
                Sqlstr = Sqlstr & " Corporatecode = '" & Trim(Txt_CorporateCode.Text) & "'"
                Sqlstr = Sqlstr & " Where Mcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                gconnection.dataOperation(2, Sqlstr, "Membermaster")
                '======Spouse Freeze
                If Chk_spouseFreeze.Checked = True Then
                    Sqlstr = " Update membermaster set SpouseFreeze='Y'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                Else
                    Sqlstr = " Update membermaster set SpouseFreeze='N'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                End If

                'ENTERENCE FEE DETAILS
                Sqlstr = " Delete From memdet Where Type0='ENTR' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")

                For i = 0 To SSgrid_Entfee.DataRowCnt - 1
                    Sqlstr = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT)"
                    Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','ENTR',"
                    With SSgrid_Entfee
                        .Row = i + 1
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "',"
                        .Row = i + 1
                        .Col = 2
                        If Len(Trim(.Text)) > 7 Then
                            Sqlstr = Sqlstr & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                        Else
                            Sqlstr = Sqlstr & "'',"
                        End If

                        .Row = i + 1
                        .Col = 3
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "')"
                    End With
                    gconnection.dataOperation(1, Sqlstr, "memdet")
                Next i


                'DEPENTDENT DETAILS
                Sqlstr = " Delete From memdet Where Type0='CHLD' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        Sqlstr = "Insert Into memdet(mem_code,type0,prefix,child_nm,SpouseName,child_dob,membertype,sex,relation,maritalstatus,dep_bloodgroup,studentmember,dep_Doj,Religion,anniversarydate,occupation,Panno,phone,mobile,emailid)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','CHLD'"
                        ssgrid.Row = i
                        'prefix
                        ssgrid.Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'depName
                        ssgrid.Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'spousename
                        ssgrid.Col = 6
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'dob
                        ssgrid.Col = 3
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'membertype
                        ssgrid.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'gender
                        ssgrid.Col = 4
                        If Mid(UCase(Trim(.Text)), 1, 1) = "F" Or Mid(UCase(Trim(.Text)), 1, 1) = "D" Then
                            Sqlstr = Sqlstr & ",'F'"
                        Else
                            Sqlstr = Sqlstr & ",'M'"
                        End If
                        'relation
                        ssgrid.Col = 5
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        'marital
                        ssgrid.Col = 7
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'BG
                        ssgrid.Col = 13
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'sr.dep
                        ssgrid.Col = 14
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'doj
                        ssgrid.Col = 15
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'Romancatholic
                        ssgrid.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'anniversary date
                        ssgrid.Col = 8
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'occupation
                        ssgrid.Col = 18
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'panno
                        ssgrid.Col = 19
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'phone
                        ssgrid.Col = 20
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'mob
                        ssgrid.Col = 21
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'email
                        ssgrid.Col = 22
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "')"
                        gconnection.dataOperation(1, Sqlstr, "memdet")

                    End With
                Next i

                'Freeze Dependents
                Dim mcount As Long
                With ssgrid
                    For i = 0 To ssgrid.DataRowCnt - 1
                        .Row = i + 1
                        .Col = 23
                        If Val(.Text) > 0 Then
                            mcount = mcount + 1
                            .Row = i + 1
                            .Col = 1
                            Sqlstr = "Update memdet set freeze='Y',remarks='Freezed'where Type0='CHLD' And child_nm=('" & Trim(.Text) & "')"
                            gconnection.dataOperation(1, Sqlstr, "memdet")
                        End If
                    Next
                End With

                'Education DETAILS
                Sqlstr = " Delete From memdet Where Type0='QUAL' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To SSgrid_Qual_det.DataRowCnt
                    With SSgrid_Qual_det
                        Sqlstr = "INSERT INTO MEMDET(MEM_CODE,TYPE0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','QUAL'"
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 3
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 4
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 5
                        Sqlstr = Sqlstr & ",'" & .Text & "')"
                        gconnection.dataOperation(1, Sqlstr, "memdet")
                    End With
                Next i
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        Sqlstr = "UPDATE membermaster SET SPOUSE = "
                '        .Row = i
                '        .Col = 3
                '        If (.Text) = "Spouse" Or (.Text) = "SPOUSE" Then
                '            .Row = i
                '            .Col = 1
                '            Sqlstr = Sqlstr & "'" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                '        Else
                '            Sqlstr = Sqlstr & " ' ' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "' "
                '        End If
                '        gconnection.dataOperation(1, Sqlstr, "membermaster")
                '    End With
                'Next i
                For i = 1 To SSgrid_Qual_det.DataRowCnt
                    With SSgrid_Qual_det
                        Sqlstr = "UPDATE membermaster SET Qualification" & i & "="
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & .Text & "',"
                        .Col = 2
                        Sqlstr = Sqlstr & "Details" & i & "='" & .Text & "',"
                        .Col = 3
                        Sqlstr = Sqlstr & "YearOfPassing" & i & "='" & .Text & "',"
                        .Col = 4
                        Sqlstr = Sqlstr & "Institute" & i & "='" & .Text & "',"
                        .Col = 5
                        Sqlstr = Sqlstr & "Division" & i & "='" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                        gconnection.dataOperation(1, Sqlstr, "membermaster")
                    End With
                Next i

                Sqlstr = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set MEMIMAGESIGN=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_SIG, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set SpouseImage=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_Spouse, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set SpouseImageSign=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_SpouseImg, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        .Row = i
                        .Col = 2
                        Sqlstr = " Update memdet set MEMIMAGE=@memimage Where  child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                        .Row = i
                        .Col = 9
                        If (.Text) <> "" Then
                            Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                        End If
                        .Col = 11
                        VFilePath = AppPath & "\Reports\" & Trim(.Text) & ".JPG"
                        If File.Exists(VFilePath) = True Then
                            File.Delete(VFilePath)
                        End If
                    End With
                Next
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        .Row = i
                        .Col = 2
                        Sqlstr = "UPDATE MEMDET SET DEPIMAGESIGN=@memimage where child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                        .Row = i
                        .Col = 10
                        If (.Text) <> "" Then
                            Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                        End If
                    End With
                Next
                If Txt_Replacement.Enabled = True Then
                    Sqlstr = "UPDATE MEMBERMASTER SET REPLACEMENT='" & Txt_Replacement.Text.Replace("'", "") & "',RNO='" & Txt_Rno.Text.Replace("'", "") & "' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                Else
                    Sqlstr = "UPDATE MEMBERMASTER SET REPLACEMENT='',RNO='' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                End If
                Sqlstr = " Update membermaster set ICNO='" & txtICNO.Text.Replace("'", "") & "',UnitNo='" & cmbUnitNo.Text.Replace("'", "") & "',RankNo='" & cmbRankNo.Text & "',DateOfCommission=Convert(datetime,'" & dtpDFCommission.Text & "',103),DateOfRelease=Convert(datetime,'" & dtpDFRelease.Text & "',103),DateOfCreation=Convert(datetime,'" & dtpDFCreation.Text & "',103),MDescription='" & Cbo_servives.Text.Replace("'", "") & "',RIDCardNo='" & txtRIDCARDNO.Text.Replace("'", "") & "',ArmService='" & txtArmService.Text.Replace("'", "") & "',WO='" & txtWO.Text.Replace("'", "") & "',NoOfDependencies='" & txtNFDependencies.Text.Replace("'", "") & "',RByMemberNo='" & txtRBYMEMBERNO.Text.Replace("'", "") & "',RByName='" & txtNBYMEMBERNAME.Text.Replace("'", "") & "',RBYMEMBERNO2='" & txtRBYMEMBERNO2.Text.Replace("'", "'") & "',RBYMEMBERNAME2='" & txtNBYMEMBERNAME2.Text.Replace("'", "'") & "',PROPOSER='" & txt_ProposerCode.Text.Replace("'", "'") & "',PROPOSERNAME='" & txt_ProposedName.Text.Replace("'", "'") & "', SECONDER='" & txt_SeconderCode.Text.Replace("'", "'") & "',SECONDERNAME='" & txt_SeconderName.Text.Replace("'", "'") & "',ApplNo ='" & Trim(Txt_AppNo.Text) & "',ApplDate=Convert(datetime,'" & (Dtp_Appdate.Text) & "',103),PANO='" & Trim(Txt_pancarno.Text) & "' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "' "
                gconnection.dataOperation(2, Sqlstr, "membermaster")
                MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                grbRSI.Visible = False


            End If
            Me.CmdClear_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Public Function checkValidation() As Boolean
        Try

            'Txt_CreditLimit.Text = Format(Val(Txt_CreditLimit.Text), "0.00")
            'TXT_OPLCREDIT.Text = Format(Val(TXT_OPLCREDIT.Text), "0.00")
            'TXT_OPLDEBIT.Text = Format(Val(TXT_OPLDEBIT.Text), "0.00")


            'If PostingDatevalidate(DTP_WEDDINGDATE.Value) = False Then
            '    DTP_WEDDINGDATE.Focus()
            '    Return False
            '    Exit Function
            'End If
            'If PostingDatevalidate(dtp_DateOfBirth.Value) = False Then
            '    dtp_DateOfBirth.Focus()
            '    Return False
            '    Exit Function
            'End If

            'If PostingDatevalidate(dtp_MembershipFrom.Value) = False Then
            '    dtp_MembershipFrom.Focus()
            '    Return False
            '    Exit Function
            'End If
            'If PostingDatevalidate(dtp_MembershipTo.Value) = False Then
            '    dtp_MembershipTo.Focus()
            '    Return False
            '    Exit Function
            'End If



            If txt_MemberCode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_MemberCode.Focus()
                Return False
                Exit Function
            End If


            'If TXT_TITLE.Text = "" Then
            '    MessageBox.Show(" Initial  can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    TXT_TITLE.Focus()
            '    Return False
            '    Exit Function
            'End If



            If txt_FirstName.Text = "" Then
                MessageBox.Show(" FirstName can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_FirstName.Focus()
                Return False
                Exit Function
            End If

            'If Cmb_Category.Text = "" Then
            '    MessageBox.Show(" MemberType can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Cmb_Category.Focus()
            '    Return False
            '    Exit Function
            'End If

            If cbo_BillingBasis.Text = "" Then
                MessageBox.Show(" Subscription Type can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_BillingBasis.Focus()
                Return False
                Exit Function
            End If
            'If cbo_CurrentStatus.Text = "" Then
            '    MessageBox.Show(" Current Status can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    cbo_CurrentStatus.Focus()
            '    Return False
            '    Exit Function
            'End If

            'If cbo_CurrentStatus.Text = "" Then
            '    MessageBox.Show(" Current Status can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    cbo_CurrentStatus.Focus()
            '    Return False
            '    Exit Function
            'End If
            If chk_male.Checked = False And chk_female.Checked = False Then
                MessageBox.Show(" Please Click Gender ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_male.Focus()
                Return False
                Exit Function
            End If

            'If chk_Married.Checked = True Then
            '    If txt_Spouse.Text = "" Then
            '        MessageBox.Show(" Spouse Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        txt_Spouse.Focus()
            '        Return False
            '        Exit Function
            '    End If
            'Else
            '    If txt_Spouse.Text <> "" Then
            '        MessageBox.Show(" Spouse Name Should be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        txt_Spouse.Focus()
            '        Return False
            '        Exit Function
            '    End If
            'End If

            If CHK_DOB.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            If CHK_DOJ.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            If chk_EXPDT.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            'If ChK_SDOB.Checked = True Then
            '    'dt_sdob.Value = ""
            'End If
            If CHK_WDT.Checked = True Then
                'dtp_DOW.Value = ""
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            Return False
        End Try
    End Function


    Public Function Corporate() As Boolean
        boolchk = False
        Dim sql As String
        Dim noofmem As Integer
        Dim totmem As Integer
        Dim totalmem As Integer
        Dim i As Integer
        Try
            sql = "Select CMCorporateCode,CMCorporateName,CMNomembers from CorporateMaster WHERE CMCorporateCode='" & Txt_CorporateCode.Text & "'"
            gconnection.getDataSet(sql, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                noofmem = CheckDBNull(gdataset.Tables("Membermaster").Rows(0).Item("CMNomembers"))
            End If
            sql = "Select Mcode,CorporateCode from MemberMaster WHERE CorporateCode='" & Txt_CorporateCode.Text & "' And CurentStatus IN('ACTIVE','LIVE')"
            gconnection.getDataSet(sql, "Corporatemaster")
            If gdataset.Tables("Corporatemaster").Rows.Count > 0 Then
                totmem = gdataset.Tables("Corporatemaster").Rows.Count
                '  For i = 0 To gdataset.Tables("Corporatemaster").Rows.Count - 1
                'totmem = CheckDBNull(gdataset.Tables("Corporatemaster").Rows(i).Item("CorporateCode"))
                'Next
                totalmem = noofmem - totmem
                If totalmem < 1 Then
                    MessageBox.Show("Corporate Code No." & Txt_CorporateCode.Text & " Has a Maximum Strength")
                    Return False
                    Exit Function
                End If
            End If

            If txt_Spouse.Text <> "" And Cbo_MaritalStatus.Text <> "MARRIED" Then
                MessageBox.Show("Please Check SpouseName and MaritalStatus!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            Return True
            boolchk = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            Return False
        End Try
    End Function
    Public Function checkValidation1() As Boolean
        boolchk = False
        Dim years, DAYS As Long
        Dim noofyears As String

        Try
            If chk_ContactAddress1.Checked = False And chk_ContactAddress2.Checked = False And chk_ContactAddress3.Checked = False Then
                MessageBox.Show("Please Check Contact Address", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Return False
                Exit Function
            End If

          



            If chk_ContactAddress1.Checked = True And txt_PA_Address1.Text = "" Then
                MessageBox.Show("Address Field Can't be Blank", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If

            If chk_ContactAddress2.Checked = True And txt_BA_Address1.Text = "" Then
                MessageBox.Show("Address Field Can't be Blank", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            If chk_ContactAddress3.Checked = True And txt_RA_Address1.Text = "" Then
                MessageBox.Show("Address Field Can't be Blank", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            If txt_RA_Address1.Text = "" Then
                MessageBox.Show("Residence Address Field Can't be Blank", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            If TXT_MEMLIMIT.Text = "" Or TXT_MEMLIMIT.Text = "0" Then
                If CREDITYN = "Y" Then
                    MessageBox.Show("Creditlimit is Applicaple for this member,Please fill CreditLimit field", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    Exit Function
                End If
            End If
            If txt_MemberCode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_MemberCode.Focus()
                Return False
                Exit Function
            End If

            If txt_FirstName.Text = "" Then
                MessageBox.Show(" FirstName can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_FirstName.Focus()
                Return False
                Exit Function
            End If

            If txt_Spouse.Text = "" And Cbo_MaritalStatus.Text = "MARRIED" Then
                MessageBox.Show("SpouseName Can't be blank !", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            If txt_Spouse.Text <> "" And Cbo_MaritalStatus.Text <> "MARRIED" Then
                MessageBox.Show("Please Check SpouseName and MaritalStatus!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            For I = 1 To ssgrid.DataRowCnt Step 1
                With ssgrid
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Row = I
                    ssgrid.Col = 6
                    spouse = ssgrid.Text
                    ssgrid.Row = I
                    ssgrid.Col = 7
                    marital = ssgrid.Text

                    If spouse <> "" And marital <> "MARRIED" Then
                        MessageBox.Show("Not Matching DependentSpouseName and Marital Status Details", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                        Exit Function
                    End If
                End With
            Next I

            If CHK_DOB.Checked = False Then
                MessageBox.Show("Please Check Member Date of Birth ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If

            'If dtp_DOB.Value = Today.Date Then
            '    MsgBox("Date of Birth should be less than today date", MsgBoxStyle.Information, gCompanyname)
            '    Return False
            '    Exit Function
            'End If


            years = DateDiff("yyyy", dtp_DOB.Value, Today.Date)
            If years < "12" Then
                MsgBox("Members Date of Birth should be greater than 12 years  ", MsgBoxStyle.Information, gCompanyname)
                Return False
                Exit Function
            End If
            DAYS = DateDiff(DateInterval.Day, Today.Date, dtp_DOJ.Value)
            If CmdAdd.Text = "Add[F7]" Then
                If DAYS < "0" Or DAYS > "0" Then
                    MsgBox("Date of join Should be today date", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If
            End If

            If Cbo_MaritalStatus.Text = "MARRIED" Then

                If Cbo_Spousesalutation.Text = "" Then
                    MsgBox("Spouse Salutation Can't be blank", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If

                'If Dtp_Spousedob.Value = Today.Date Then
                '    MsgBox("Spouse Date of Birth should be less than today date", MsgBoxStyle.Information, gCompanyname)
                '    Return False
                '    Exit Function
                'End If
                years = DateDiff("yyyy", Dtp_Spousedob.Value, Today.Date)
                If years < "18" Then
                    MsgBox("Spouse Date of Birth should be greater than 18 years ", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If

                If dtp_DOB.Value > dtp_DOW.Value Then
                    MsgBox("Date of Birth Less than the Date of Wedding", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If
                If Dtp_Spousedob.Value > dtp_DOW.Value Then
                    MsgBox("Spouse Date of Birth Less than the Date of Wedding", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If
            End If
            'years = DateDiff("yyyy", dtp_DOW.Value, Today.Date)
            If CHK_WDT.Checked = True Then
                If Today.Date <= dtp_DOW.Value Then
                    MsgBox("Date of Wedding should be Less than today date  ", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If
            End If
            If chk_EXPDT.Checked = True Then
                If dtp_EXPDT.Value <= dtp_DOJ.Value Then
                    MsgBox("Expiry  should not be Less than Date of Join date  ", MsgBoxStyle.Information, gCompanyname)
                    Return False
                    Exit Function
                End If
            End If
            If chk_male.Checked = False And chk_female.Checked = False Then
                MsgBox("Gender Should'nt be blank  ", MsgBoxStyle.Information, gCompanyname)
                Return False
                Exit Function
            End If
            If Cbo_professional.Text = "" Then
                MsgBox("Professional Should'nt be blank  ", MsgBoxStyle.Information, gCompanyname)
                Return False
                Exit Function
            End If
            If Cbo_designation.Text = "" Then
                MsgBox("Designation Should'nt be blank  ", MsgBoxStyle.Information, gCompanyname)
                Return False
                Exit Function
            End If
            For I = 1 To ssgrid.DataRowCnt Step 1
                With ssgrid
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Row = I
                    ssgrid.Col = 3
                    If (ssgrid.Text) <> "" Then
                        Childdob = Format(CDate(ssgrid.Text), "yyyy/MM/dd")
                        If Childdob = Today.Date Then
                            MsgBox("Dependent Date of Birth should be less than today date", MsgBoxStyle.Information, gCompanyname)
                            Return False
                            Exit Function
                        End If
                        years = DateDiff("yyyy", dtp_DOB.Value, Childdob)
                        If years < "18" Then
                            MsgBox("Dependent Date of Birth should be greater than 18 years of Member Date of Birth", MsgBoxStyle.Information, gCompanyname)
                            Return False
                            Exit Function
                        End If
                    End If
                    ssgrid.Col = 8
                    If (ssgrid.Text) <> "" Then
                        depdow = Format(CDate(ssgrid.Text), "yyyy/MM/dd")
                        years = DateDiff("yyyy", Childdob, depdow)
                        If years < "18" Then
                            MsgBox("Dependent Date of wedding should be greater 18 years Dependent Date of Birth", MsgBoxStyle.Information, gCompanyname)
                            Return False
                            Exit Function
                        End If
                    End If
                End With
            Next I

            'If txt_PA_Email.Text <> "" Then
            '    emailst = getEmail(txt_PA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If txt_BA_Email.Text <> "" Then
            '    emailst = getEmail(txt_BA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If txt_RA_Email.Text <> "" Then
            '    emailst = getEmail(txt_RA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If dtp_DOB.Value < Childdob Then
            '    MessageBox.Show("Not Matching DependentSpouseName and Marital Status Details", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            '    Exit Function
            'End If
            Return True
            boolchk = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            Return False
        End Try
    End Function

    'Public Function testForNumeric(ByRef value As String) As Boolean
    '    Dim allowedChars As String = "0123456789"
    '    For i As Integer = value.Length - 1 To 0 Step -1
    '        If allowedChars.IndexOf(value(i)) = -1 Then
    '            Return False
    '        End If
    '    Next
    '    Return True
    'End Function

    Private Sub txt_PA_Address1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Address1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_PA_Address2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Address3.Focus()
        End If
    End Sub


    Private Sub txt_PA_Address3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_PA_City.Focus()
            Cbo_PCity.Focus()
        End If
    End Sub


    Private Sub txt_PA_City_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_City.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_State.Focus()
        End If
    End Sub



    Private Sub txt_PA_State_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_State.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_PinCode.Focus()
        End If
    End Sub


    Private Sub txt_PA_PinCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Phone.Focus()
        End If
    End Sub


    Private Sub txt_PA_Phone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Phone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Phone2.Focus()
        End If
    End Sub


    Private Sub txt_BA_Address2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_Address1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_BA_City.Focus()
            Cbo_BCity.Focus()
        End If
    End Sub

    Private Sub txt_BA_City_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_City.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_State.Focus()
        End If
    End Sub

    Private Sub txt_BA_State_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_State.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_BA_Country.Focus()
        End If
    End Sub

    Private Sub txt_BA_PinCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_BA_PhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_PhoneNo2.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_Address1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_CCity.Focus()
        End If
    End Sub

    Private Sub txt_RA_City_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_City.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_CState.Focus()
        End If
    End Sub

    Private Sub txt_RA_State_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_State.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_CCountry.Focus()
        End If
    End Sub

    Private Sub txt_RA_PinCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_RA_PhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_PhoneNo2.Focus()
        End If
    End Sub
    Private Sub Cmd_MemDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_MemDep.Click
        Try
            'grp_ChildrenDetails.Location = New Point(120, 239)
            'grp_ChildrenDetails.Size = New Size(744, 273)
            Grp_Address.Visible = False
            Grp_MemQualification.Visible = False
            'GP_ENTERENCEFEE.Visible = False
            Grp_Entrancefee.Visible = False
            grp_Entrancefeedetails.Visible = False
            grp_ChildrenDetails.Visible = True
            grbRSI.Visible = False
            Grp_AccountsDetails.Visible = False
            Gpr_Company.Visible = False
            'ssgrid.SetActiveCell(1, 1)
            ssgrid.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub


    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                ssgrid.InsertRows(ssgrid.ActiveRow, 1)
            End If
            If e.keyCode = Keys.F3 Then
                ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            End If
            If e.keyCode = Keys.Enter Then
                If ssgrid.ActiveRow = 3 And ssgrid.ActiveCol = 7 Then
                End If
            End If
            If e.keyCode = Keys.Enter Then
                If ssgrid.ActiveCol = 9 Then
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Col = 9
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            ssgrid.Col = 9
                            ssgrid.Row = ssgrid.ActiveRow
                            ssgrid.TypePictPicture = New Bitmap(file.FileName)
                            ''strPhotoFilePath = file.FileName
                            ssgrid.Col = 11
                            ssgrid.Row = ssgrid.ActiveRow
                            ssgrid.Text = file.FileName
                        End If
                    End If

                End If

                If ssgrid.ActiveCol = 10 Then
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.ActiveCol = 10
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            ssgrid.Col = 10
                            ssgrid.Row = ssgrid.ActiveRow
                            ssgrid.TypePictPicture = New Bitmap(file.FileName)
                            ''strPhotoFilePath = file.FileName
                            
                        End If
                    End If
                End If
                '    End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        'Dim maritalstatus, spouse As String
        'If ssgrid.ActiveCol = 8 Then
        '    ssgrid.Row = ssgrid.ActiveRow
        '    ssgrid.Col = 6
        '    spouse = ssgrid.Text
        '    ssgrid.Col = 8
        '    maritalstatus = ssgrid.Text
        '    ssgrid.Lock = True
        '    ssgrid.Focus()
        '    'If .Text <> "" Then
        '    If spouse <> "" And maritalstatus <> "MARRIED" Then
        '        MessageBox.Show("Not Matching DependentSpouse Details", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        ssgrid.Col = 8
        '        ssgrid.Lock = True
        '        ssgrid.Focus()
        '    End If
        'End If
    End Sub
    Private Sub Cmd_Education_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Education.Click
        Try
            'Grp_MemQualification.Location = New Point(120, 239)
            'Grp_MemQualification.Size = New Size(744, 273)
            Grp_Address.Visible = False
            grp_ChildrenDetails.Visible = False
            'GP_ENTERENCEFEE.Visible = False
            Grp_MemQualification.Visible = True
            Grp_Entrancefee.Visible = False
            grp_Entrancefeedetails.Visible = False
            grbRSI.Visible = False
            Grp_AccountsDetails.Visible = False
            Gpr_Company.Visible = False
            SSgrid_Qual_det.SetActiveCell(1, 1)
            SSgrid_Qual_det.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub SSgrid_Qual_det_Advance(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSgrid_Qual_det.Advance

    End Sub
    Private Sub SSgrid_Qual_det_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Qual_det.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                SSgrid_Qual_det.InsertRows(ssgrid.ActiveRow, 1)
            End If
            If e.keyCode = Keys.F3 Then
                SSgrid_Qual_det.DeleteRows(ssgrid.ActiveRow, 1)
                SSgrid_Qual_det.SetActiveCell(1, ssgrid.ActiveRow)
            End If
            If e.keyCode = Keys.Enter Then
                If SSgrid_Qual_det.ActiveRow = 3 And ssgrid.ActiveCol = 4 Then
                End If
            End If
            'If e.keyCode = Keys.Enter Then
            '    With ssgrid
            '        If ssgrid.ActiveCol = 1 Then
            '            .Row = .ActiveRow
            '            .Col = 1
            '            If (.Text) <> "" Then
            '                .SetActiveCell(2, .ActiveRow)
            '            End If
            '        End If
            '        If ssgrid.ActiveCol = 2 Then
            '            .Row = .ActiveRow
            '            .Col = 2
            '            If (.Text) <> "" Then
            '                .SetActiveCell(3, .ActiveRow)
            '            End If
            '        End If
            '        If ssgrid.ActiveCol = 3 Then
            '            .Row = .ActiveRow
            '            .Col = 3
            '            If (.Text) <> "" Then
            '                .SetActiveCell(4, .ActiveRow)
            '            End If
            '        End If
            '        If ssgrid.ActiveCol = 4 Then
            '            .Row = .ActiveRow
            '            .Col = 4
            '            If (.Text) <> "" Then
            '                .SetActiveCell(5, .ActiveRow)
            '            End If
            '        End If
            '        If ssgrid.ActiveCol = 5 Then
            '            .Row = .ActiveRow
            '            .Col = 5
            '            If (.Text) <> "" Then
            '                .SetActiveCell(1, .ActiveRow + 1)
            '            End If
            '        End If
            '    End With
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            'Insert.Clear(Insert, 0, Insert.Length)
            'Sqlstr = " Update  membermaster set  MEMIMAGE =ISNULL(MEMIMAGE,'') , MEMIMAGESIGN =ISNULL(MEMIMAGESIGN,'') , TAG =ISNULL(TAG,'') , MEMBERTYPECODE =ISNULL(MEMBERTYPECODE,'') , COMPANY =ISNULL(COMPANY,'') , SUBCD =ISNULL(SUBCD,'') , MCODE =ISNULL(MCODE,'') , MNAME =ISNULL(MNAME,'') , MID =ISNULL(MID,'') , DOB =ISNULL(DOB,'') , SDOB =ISNULL(SDOB,''),DOJ =ISNULL(DOJ,'') , SEX =ISNULL(SEX,'') , MARITALSTATUS =ISNULL(MARITALSTATUS,'') , SPOUSE =ISNULL(SPOUSE,'') , BG =ISNULL(BG,'') , OCCUPATION =ISNULL(OCCUPATION,'') , BANKER =ISNULL(BANKER,'') , BANKACNO =ISNULL(BANKACNO,'') , HOBBIES =ISNULL(HOBBIES,'') , OTHERINFO =ISNULL(OTHERINFO,'') , RESIDENT =ISNULL(RESIDENT,'') , EQUALIFICATION =ISNULL(EQUALIFICATION,'') , PQUALIFICATION =ISNULL(PQUALIFICATION,'') , PROPOSER =ISNULL(PROPOSER,'') , PROPOSERNAME =ISNULL(PROPOSERNAME,'') , SECONDER =ISNULL(SECONDER,'') , SECONDERNAME =ISNULL(SECONDERNAME,'') , PAcopyst1 =ISNULL(PAcopyst1,'') , PADD1 =ISNULL(PADD1,'') , PADD2 =ISNULL(PADD2,'') , PADD3 =ISNULL(PADD3,'') , PCITY =ISNULL(PCITY,'') , PSTATE =ISNULL(PSTATE,'') , PCOUNTRY =ISNULL(PCOUNTRY,'') , PPIN =ISNULL(PPIN,'') , PPHONE1 =ISNULL(PPHONE1,'') , PPHONE2 =ISNULL(PPHONE2,'') , PCELL =ISNULL(PCELL,'') , PEMAIL =ISNULL(PEMAIL,'') , RAcopyst1 =ISNULL(RAcopyst1,'') , CADD1 =ISNULL(CADD1,'') , CADD2 =ISNULL(CADD2,'') , CADD3 =ISNULL(CADD3,'') , CCITY =ISNULL(CCITY,'') , CSTATE =ISNULL(CSTATE,'') , CCOUNTRY =ISNULL(CCOUNTRY,'') , CPIN =ISNULL(CPIN,'') , CPHONE1 =ISNULL(CPHONE1,'') , CPHONE2 =ISNULL(CPHONE2,'') , CCELL =ISNULL(CCELL,'') , CEMAIL =ISNULL(CEMAIL,'') , CONTADD1 =ISNULL(CONTADD1,'') , CONTADD2 =ISNULL(CONTADD2,'') , CONTADD3 =ISNULL(CONTADD3,'') , CONTCITY =ISNULL(CONTCITY,'') , CONTSTATE =ISNULL(CONTSTATE,'') , CONTCOUNTRY =ISNULL(CONTCOUNTRY,'') , CONTPIN =ISNULL(CONTPIN,'') , CONTPHONE1 =ISNULL(CONTPHONE1,'') , CONTPHONE2 =ISNULL(CONTPHONE2,'') , CONTCELL =ISNULL(CONTCELL,'') , CONTEMAIL =ISNULL(CONTEMAIL,'') , EMPTYPE =ISNULL(EMPTYPE,'') , BUSINESSNAME =ISNULL(BUSINESSNAME,'') , BAcopyst1 =ISNULL(BAcopyst1,'') , OADD1 =ISNULL(OADD1,'') , OADD2 =ISNULL(OADD2,'') , OADD3 =ISNULL(OADD3,'') , OCITY =ISNULL(OCITY,'') , OSTATE =ISNULL(OSTATE,'') , OCOUNTRY =ISNULL(OCOUNTRY,'') , OPIN =ISNULL(OPIN,'') , OPHONE1 =ISNULL(OPHONE1,'') , OPHONE2 =ISNULL(OPHONE2,'') , DOEPROFESSION =ISNULL(DOEPROFESSION,'') , BUSINESSNATURE =ISNULL(BUSINESSNATURE,'') , POSITIONHELD =ISNULL(POSITIONHELD,'') , SERVICENAME =ISNULL(SERVICENAME,'') , SERVICEYEAR =ISNULL(SERVICEYEAR,0) , PANO =ISNULL(PANO,'') , BBANKER =ISNULL(BBANKER,'') , CCNO =ISNULL(CCNO,'') , ANNUALINCOME =ISNULL(ANNUALINCOME,0) , UPDUSERID =ISNULL(UPDUSERID,'') , UPDDATETIME =ISNULL(UPDDATETIME,'') , TERMINATION =ISNULL(TERMINATION,'') , TRN_CON_DATE =ISNULL(TRN_CON_DATE,'') , CON_MCODE =ISNULL(CON_MCODE,'') , PFAX =ISNULL(PFAX,'') , CFAX =ISNULL(CFAX,'') , CONTFAX =ISNULL(CONTFAX,'') , REASON =ISNULL(REASON,'') , PHOTO =ISNULL(PHOTO,'') , CREDITLIMIT =ISNULL(CREDITLIMIT,0) , LIMITAMOUNT =ISNULL(LIMITAMOUNT,0) , WEBSITE =ISNULL(WEBSITE,'') , IMAGEFILE =ISNULL(IMAGEFILE,'') , SIZEFIELD =ISNULL(SIZEFIELD,0) , VDATE =ISNULL(VDATE,'') , VYEAR =ISNULL(VYEAR,0) , VALIDDATE =ISNULL(VALIDDATE,'') , TEMPTERMINATION =ISNULL(TEMPTERMINATION,'') , TEMPTERMDATE =ISNULL(TEMPTERMDATE,'') , TEMPTERMREASON =ISNULL(TEMPTERMREASON,'') , MEMBERID =ISNULL(MEMBERID,'') , ENDINGDATE =ISNULL(ENDINGDATE,'') , TOTALYEARS =ISNULL(TOTALYEARS,0) , CARDNO =ISNULL(CARDNO,'') , CARDEXPDATE =ISNULL(CARDEXPDATE,'') , VALIDITY =ISNULL(VALIDITY,'') , PERIOD =ISNULL(PERIOD,'') , CREDITCARDNO =ISNULL(CREDITCARDNO,'') , CREDITEXPDT =ISNULL(CREDITEXPDT,'') , TYPE =ISNULL(TYPE,'') , STATUSDATEFROM =ISNULL(STATUSDATEFROM,'') , STATUSDATETO =ISNULL(STATUSDATETO,'') , CURENTSTATUS =ISNULL(CURENTSTATUS,'') , FIRSTNAME =ISNULL(FIRSTNAME,'') , MIDDLENAME =ISNULL(MIDDLENAME,'') , SURNAME =ISNULL(SURNAME,'') , ALIAS =ISNULL(ALIAS,'') , PREFIX =ISNULL(PREFIX,'') , BILLTYPE =ISNULL(BILLTYPE,'') , NATIONALITY =ISNULL(NATIONALITY,'') , NATIONALITYATBIRTH =ISNULL(NATIONALITYATBIRTH,'') , BILLBASIS =ISNULL(BILLBASIS,'') , BILLHEAD =ISNULL(BILLHEAD,'') , GDRLOCKER =ISNULL(GDRLOCKER,'') , LDRLOCKER =ISNULL(LDRLOCKER,'') , HPLOCKER =ISNULL(HPLOCKER,'') , MEMBERSHIPTO =ISNULL(MEMBERSHIPTO,'') , SALUT =ISNULL(SALUT,'') , ENTRANCEFEE =ISNULL(ENTRANCEFEE,0) , DEVELOPMENTFEE =ISNULL(DEVELOPMENTFEE,0) , CRIDITNUMBER =ISNULL(CRIDITNUMBER,'') , SECURITYDEPOSIT =ISNULL(SECURITYDEPOSIT,0) , PLACEOFBIRTH =ISNULL(PLACEOFBIRTH,'') , COUNTRYOFBIRTH =ISNULL(COUNTRYOFBIRTH,'') , LASTARRIVALINCAL =ISNULL(LASTARRIVALINCAL,'') , PERIODOFSTAY_YEAR =ISNULL(PERIODOFSTAY_YEAR,0) , PERIODOFSTAY_MONTH =ISNULL(PERIODOFSTAY_MONTH,0) , PREVIOUSLYPROPOSED =ISNULL(PREVIOUSLYPROPOSED,'') , NOOFTIMESPROPOSED =ISNULL(NOOFTIMESPROPOSED,0) , DATEOFPROPOSAL =ISNULL(DATEOFPROPOSAL,'') , RESULTOFPROPOSAL =ISNULL(RESULTOFPROPOSAL,'') , ELECTED =ISNULL(ELECTED,'') , FATHERNAME =ISNULL(FATHERNAME,'') , DOBFATHER =ISNULL(DOBFATHER,'') , WIFEDOB =ISNULL(WIFEDOB,'') , MAIDENNAMEWIFE =ISNULL(MAIDENNAMEWIFE,'') , NATIONALITYWIFE =ISNULL(NATIONALITYWIFE,'') , WIFESFATHERNAME =ISNULL(WIFESFATHERNAME,'') , WIFEFATHERDOB =ISNULL(WIFEFATHERDOB,'') , APPLNO =ISNULL(APPLNO,'') , APPLDATE =ISNULL(APPLDATE,'') , CORPORATEST =ISNULL(CORPORATEST,'') , CORPORATECODE =ISNULL(CORPORATECODE,'') , COMPNAME =ISNULL(COMPNAME,'') , DESIGNATION =ISNULL(DESIGNATION,'') , PROFESSIONINFO =ISNULL(PROFESSIONINFO,'') , BUISNESSINFO =ISNULL(BUISNESSINFO,'') , PRODUCTS =ISNULL(PRODUCTS,'') , AGENTSDEALERS =ISNULL(AGENTSDEALERS,'') , ESTDDATE =ISNULL(ESTDDATE,'') , NOOFEMP =ISNULL(NOOFEMP,0) , TURNOVER =ISNULL(TURNOVER,0) , CLIENT =ISNULL(CLIENT,'') , APPLIEDBUT =ISNULL(APPLIEDBUT,'') , POSITIONINCHAMBER =ISNULL(POSITIONINCHAMBER,'') , QULIFICATIONSTATUS =ISNULL(QULIFICATIONSTATUS,'') , QUALIFICATION1 =ISNULL(QUALIFICATION1,'') , DETAILS1 =ISNULL(DETAILS1,'') , YEAROFPASSING1 =ISNULL(YEAROFPASSING1,'') , INSTITUTE1 =ISNULL(INSTITUTE1,'') , DIVISION1 =ISNULL(DIVISION1,'') , QUALIFICATION2 =ISNULL(QUALIFICATION2,'') , DETAILS2 =ISNULL(DETAILS2,'') , YEAROFPASSING2 =ISNULL(YEAROFPASSING2,'') , INSTITUTE2 =ISNULL(INSTITUTE2,'') , DIVISION2 =ISNULL(DIVISION2,'') , QUALIFICATION3 =ISNULL(QUALIFICATION3,'') , DETAILS3 =ISNULL(DETAILS3,'') , YEAROFPASSING3 =ISNULL(YEAROFPASSING3,'') , INSTITUTE3 =ISNULL(INSTITUTE3,'') , DIVISION3 =ISNULL(DIVISION3,'') , SPORTSTATUS =ISNULL(SPORTSTATUS,'') , GAMETYPE1 =ISNULL(GAMETYPE1,'') , NAMEOFGAME1 =ISNULL(NAMEOFGAME1,'') , DESCRIPTION1 =ISNULL(DESCRIPTION1,'') , GAMETYPE2 =ISNULL(GAMETYPE2,'') , NAMEOFGAME2 =ISNULL(NAMEOFGAME2,'') , DESCRIPTION2 =ISNULL(DESCRIPTION2,'') , GAMETYPE3 =ISNULL(GAMETYPE3,'') , NAMEOFGAME3 =ISNULL(NAMEOFGAME3,'') , DESCRIPTION3 =ISNULL(DESCRIPTION3,'') , CHILDSTATUS =ISNULL(CHILDSTATUS,'') , CHILDNAME1 =ISNULL(CHILDNAME1,'') , CHILDFDOB1 =ISNULL(CHILDFDOB1,'') , CHILDSEX1 =ISNULL(CHILDSEX1,'') , CHILDEXPAIRY1 =ISNULL(CHILDEXPAIRY1,'') , CHILDNAME2 =ISNULL(CHILDNAME2,'') , CHILDDOB2 =ISNULL(CHILDDOB2,'') , CHILDSEX2 =ISNULL(CHILDSEX2,'') , CHILDEXPAIRY2 =ISNULL(CHILDEXPAIRY2,'') , CHILDNAME3 =ISNULL(CHILDNAME3,'') , CHILDDOB3 =ISNULL(CHILDDOB3,'') , CHILDSEX3 =ISNULL(CHILDSEX3,'') , CHILDEXPAIRY3 =ISNULL(CHILDEXPAIRY3,'') , CLUBSTATUS =ISNULL(CLUBSTATUS,'') , OTHERCLUBNAME1 =ISNULL(OTHERCLUBNAME1,'') , OCADDRESS1 =ISNULL(OCADDRESS1,'') , OCSTATUS1 =ISNULL(OCSTATUS1,'') , OTHERCLUBNAME2 =ISNULL(OTHERCLUBNAME2,'') , OCADDRESS2 =ISNULL(OCADDRESS2,'') , OCSTATUS2 =ISNULL(OCSTATUS2,'') , OTHERCLUBNAME3 =ISNULL(OTHERCLUBNAME3,'') , OCADDRESS3 =ISNULL(OCADDRESS3,'') , OCSTATAUS =ISNULL(OCSTATAUS,'') , ADDUSER =ISNULL(ADDUSER,'') , ADDDATE =ISNULL(ADDDATE,'') , FREEZE =ISNULL(FREEZE,'') , RELATIVESTATUS =ISNULL(RELATIVESTATUS,'') , RELATIVENAME1 =ISNULL(RELATIVENAME1,'') , RELATION1 =ISNULL(RELATION1,'') , DATEOFBIRTH1 =ISNULL(DATEOFBIRTH1,'') , RELATIVEAGE1 =ISNULL(RELATIVEAGE1,'') , RELATIVESEX1 =ISNULL(RELATIVESEX1,'') , RELATIVEADDRESS1 =ISNULL(RELATIVEADDRESS1,'') , RELATIVENAME2 =ISNULL(RELATIVENAME2,'') , RELATION2 =ISNULL(RELATION2,'') , DATEOFBIRTH2 =ISNULL(DATEOFBIRTH2,'') , RELATIVEAGE2 =ISNULL(RELATIVEAGE2,'') , RELATIVESEX2 =ISNULL(RELATIVESEX2,'') , RELATIVEADDRESS2 =ISNULL(RELATIVEADDRESS2,'') , RELATIVENAME3 =ISNULL(RELATIVENAME3,'') , RELATION3 =ISNULL(RELATION3,'') , DATEOFBIRTH3 =ISNULL(DATEOFBIRTH3,'') , RELATIVEAGE3 =ISNULL(RELATIVEAGE3,'') , RELATIVESEX3 =ISNULL(RELATIVESEX3,'') , RELATIVEADDRESS3 =ISNULL(RELATIVEADDRESS3,'') , REFERENTIALST =ISNULL(REFERENTIALST,'') , MEM_CODE1 =ISNULL(MEM_CODE1,'') , MEM_NAME1 =ISNULL(MEM_NAME1,'') , REFMEM_DATE1 =ISNULL(REFMEM_DATE1,'') , DELETED1 =ISNULL(DELETED1,'') , MEM_CODE2 =ISNULL(MEM_CODE2,'') , MEM_NAME2 =ISNULL(MEM_NAME2,'') , REFMEM_DATE2 =ISNULL(REFMEM_DATE2,'') , DELETED2 =ISNULL(DELETED2,'') , MEM_CODE3 =ISNULL(MEM_CODE3,'') , MEM_NAME3 =ISNULL(MEM_NAME3,'') , REFMEM_DATE3 =ISNULL(REFMEM_DATE3,'') , DELETED3 =ISNULL(DELETED3,'') , ENTRANCEFEEST =ISNULL(ENTRANCEFEEST,'') , RECEIPTNO1 =ISNULL(RECEIPTNO1,'') , STARTDATE1 =ISNULL(STARTDATE1,'') , AMOUNT1 =ISNULL(AMOUNT1,'') , RECEIPTNO2 =ISNULL(RECEIPTNO2,'') , STARTDATE2 =ISNULL(STARTDATE2,'') , AMOUNT2 =ISNULL(AMOUNT2,'') , RECEIPTNO3 =ISNULL(RECEIPTNO3,'') , STARTDATE3 =ISNULL(STARTDATE3,'') , AMOUNT3 =ISNULL(AMOUNT3,'') , OLD =ISNULL(OLD,'') , CARDAMT =ISNULL(CARDAMT,0) , MINIMUMUSAGE =ISNULL(MINIMUMUSAGE,0) , CREDITNO =ISNULL(CREDITNO,'') , SPOUSEMOBILE =ISNULL(SPOUSEMOBILE,'') , PADD4 =ISNULL(PADD4,'') , CADD4 =ISNULL(CADD4,'') , EMAIL_FLAG =ISNULL(EMAIL_FLAG,'') , EBILL =ISNULL(EBILL,'') , WEDDING_DATE =ISNULL(WEDDING_DATE,'') , TAXFLAG =ISNULL(TAXFLAG,'') , MLEDGERNAME =ISNULL(MLEDGERNAME,'') "
            'Insert(0) = Sqlstr
            'gconnection.MoreTrans1(Insert)
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
        Me.Hide()
    End Sub
    'Private Sub chk_PA__CA_Copy_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        chk_bA__CA_Copy.Checked = False
    '        chk_PA__CA_Copy.Checked = False
    '        chk_CA_RACopy.Checked = False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
    '    End Try
    'End Sub
    Private Sub Img_Photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img_Photo.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Photo.Image = New Bitmap(file.FileName)
                    strPhotoFilePath = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub Img_Signature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img_Signature.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Signature.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_SIG = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Public Function SaveFoto(ByVal FilePath As String, ByVal Mcode As String, ByVal Qurstr As String)
        Try
            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            'Dim cmd As New SqlCommand("update membermaster set " & fieldname & _
            '" = @memimage where mcode = '" & Mcode & "' ", cn)
            Dim cmd As New SqlCommand(Qurstr, cn)
            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub LoadFoto_chld(ByVal quystr As String, ByVal row As Integer)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                With ssgrid
                    .Col = 9
                    .Row = row
                    ssgrid.TypePictPicture = Image.FromStream(stmMEMimage)
                    vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
                    VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                    Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
                    myBitmap.Save(VFilePath)
                    myBitmap.Dispose()
                    .Col = 9
                    .Row = row
                    .Text = VFilePath
                    .Col = 11
                    .Text = vOutfile
                End With
            Else
                'PIC.Image = Nothing
                'Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadFoto_chld1(ByVal quystr As String, ByVal row As Integer)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("DEPIMAGESIGN")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                With ssgrid
                    .Col = 10
                    .Row = row
                    ssgrid.TypePictPicture = Image.FromStream(stmMEMimage)
                    vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
                    VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                    Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
                    myBitmap.Save(VFilePath)
                    myBitmap.Dispose()
                    .Col = 10
                    .Row = row
                    .Text = VFilePath
                End With
            Else
                'PIC.Image = Nothing
                'Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadFoto_DB(ByVal quystr As String, ByVal PIC As PictureBox)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                PIC.Image = Image.FromStream(stmMEMimage)
            Else
                PIC.Image = Nothing
            End If
        Catch ex As Exception
            '            MsgBox(ex.Message)
        End Try
    End Sub



    Public Function SaveFoto_sign(ByVal FilePath As String, ByVal Cardid As String, ByVal fieldname As String)
        Try


            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            Dim cmd As New SqlCommand("update sm_cardfile_hdr set memimagesign " & _
                " = @memimage where [16_digit_code] = '" & Cardid & "' ", cn)

            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub ssgrid_ClickEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_ClickEvent) Handles ssgrid.ClickEvent
        Try
            With ssgrid
                If ssgrid.ActiveCol = 9 Then
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            .Col = 9
                            .Row = .ActiveRow
                            ssgrid.TypePictPicture = New Bitmap(file.FileName)
                            'strPhotoFilePath = file.FileName
                            .Col = 9
                            .Row = .ActiveRow
                            .Text = file.FileName
                        End If
                    End If
                End If
                If ssgrid.ActiveCol = 10 Then
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            .Col = 10
                            .Row = .ActiveRow
                            ssgrid.TypePictPicture = New Bitmap(file.FileName)
                            'strPhotoFilePath = file.FileName
                            .Col = 10
                            .Row = .ActiveRow
                            .Text = file.FileName
                        End If
                    End If
                End If
                '        If ssgrid.ActiveCol = 2 Then
                '            .Row = .ActiveRow
                '            .Col = 2
                '            If (.Text) <> "" Then
                '                .SetActiveCell(3, .ActiveRow)
                '            End If
                '        End If
                '        If ssgrid.ActiveCol = 3 Then
                '            .Row = .ActiveRow
                '            .Col = 3
                '            If (.Text) <> "" Then
                '                .SetActiveCell(4, .ActiveRow)
                '            End If
                '        End If
                '        If ssgrid.ActiveCol = 4 Then
                '            .Row = .ActiveRow
                '            .Col = 4
                '            If (.Text) <> "" Then
                '                .SetActiveCell(5, .ActiveRow)
                '            End If
                '        End If
                '        If ssgrid.ActiveCol = 5 Then
                '            .Row = .ActiveRow
                '            .Col = 5
                '            If (.Text) <> "" Then
                '                .SetActiveCell(1, .ActiveRow + 1)
                '            End If
                '        End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub CmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExport.Click
        Try
            Dim _export As New EXPORT
            Sqlstr = "Select * From Membermaster"
            _export.TABLENAME = "Membermaster"
            Call _export.export_excel(Sqlstr)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub mem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If CmdAdd.Enabled = True Then
                    Call CmdAdd_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If CmdClear.Enabled = True Then
                    Call CmdClear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If CmdView.Enabled = True Then
                    Call CmdView_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If CmdExport.Enabled = True Then
                    Call CmdExport_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F10 Then
                If CmdExport.Enabled = True Then
                    Call Button6_Click_1(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmdexit.Enabled = True Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            Dim sqlstring, SQLSTR2 As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_MemberMaster_cpc1
            Dim txtobj1 As TextObject
            SQLSTR2 = "EXEC MEM_IMAGE '" & txt_MemberCode.Text & "'"
            gconnection.ExcuteStoreProcedure(SQLSTR2)
            Sqlstr = "select * from MM_membermaster where mcode=   '" & txt_MemberCode.Text & "'"
            Sqlstr1 = "SELECT * FROM MEMDEPIMAGE WHERE MCODE='" & txt_MemberCode.Text & "'"
            Call Viewer.GetDetails1(Sqlstr, "MM_MEMBERMASTER", r)
            Call Viewer.GetDetails1(Sqlstr1, "MEMDEPIMAGE", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text38")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmb_Category_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Category.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub

    Private Sub ssgrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.Leave

    End Sub

    Private Sub ssgrid_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyPressEvent) Handles ssgrid.KeyPressEvent

    End Sub
    Private Sub cmd_enterencefee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Grp_Address.Visible = False
            grp_ChildrenDetails.Visible = False
            Grp_MemQualification.Visible = False
            grbRSI.Visible = False
            SSgrid_Qual_det.SetActiveCell(1, 1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub txt_Designation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SSgrid_Entrancefee.SetActiveCell(1, 1)
            SSgrid_Entrancefee.Focus()
        End If
    End Sub

    Private Sub CHK_WDT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If CHK_WDT.Checked = True Then
                txt_Spouse.Text = ""
                dtp_DOW.Enabled = True
                'chkSpousePhoto.Enabled = True
            Else
                dtp_DOW.Enabled = False
                'chkSpousePhoto.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub CHK_WDT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If CHK_WDT.Checked = True Then
                dtp_DOW.Focus()
            Else
                'txt_ProposerCode.Focus()
            End If
        End If
    End Sub

    Private Sub DTP_WEDDINGDATE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'txt_ProposerCode.Focus()
        End If
    End Sub

    Private Sub txt_MemberCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.GotFocus
        Me.Label_Maxchar.Visible = True
        Me.txt_MemberCode.BackColor = BackColor.Gold
    End Sub
    Private Sub txt_MemberCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.LostFocus
        Me.Label_Maxchar.Visible = False
        Me.txt_MemberCode.BackColor = BackColor.White
    End Sub
    Private Sub TXT_TITLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TITLE.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub cmd_RSIDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_RSIDetails.Click
        'Try

        '    If cmd_RSIDetails.Text = "RSI Details" Then
        '        Sqlstr = " Update membermaster set ICNO='" & txtICNO.Text & "',UnitNo='" & cmbUnitNo.Text & "',RankNo='" & cmbRankNo.Text & "',DateOfCommission=Convert(datetime,'" & dtpDFCommission.Text & "',106),DateOfRelease=Convert(datetime,'" & dtpDFRelease.Text & "',106),DateOfCreation=Convert(datetime,'" & dtpDFCreation.Text & "',106),BTGroup='" & cmbBTGroup.Text & "',RIDCardNo='" & txtRIDCARDNO.Text & "',ArmService='" & txtArmService.Text & "',WO='" & txtWO.Text & "',NoOfDependencies='" & txtNFDependencies.Text & "',RByMemberNo='" & txtRBYMEMBERNO.Text & "',RByName='" & txtNBYMEMBERNAME.Text & "' Where Mcode='" & txt_MemberCode.Text & "' "
        '        gconnection.dataOperation(2, Sqlstr, "membermaster")
        '        MessageBox.Show("RSI Details Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtICNO.Text = ""
        '        cmbUnitNo.Text = "--Select--"
        '        cmbRankNo.Text = "--Select--"
        '        dtpDFCommission.Text = ""
        '        dtpDFCreation.Text = ""
        '        dtpDFRelease.Text = ""
        '        cmbBTGroup.Text = "--Select--"
        '        txtNBYMEMBERNAME.Text = ""
        '        txtMemberDescription.Text = ""
        '        txtNFDependencies.Text = ""
        '        txtRBYMEMBERNO.Text = ""
        '        txtRIDCARDNO.Text = ""
        '        txtWO.Text = ""
        '        txtArmService.Text = ""
        '        grbRSI.Visible = False
        '    Else

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Try
            'grbRSI.Location = New Point(120, 239)
            'grbRSI.Size = New Size(744, 273)
            'GP_ENTERENCEFEE.Visible = False
            If Cmb_Category.Text = "SERVING MESS" Then
                dtpDFRelease.Enabled = False
            End If
            getbelongs()
            Grp_Address.Visible = False
            grp_ChildrenDetails.Visible = False
            Grp_MemQualification.Visible = False
            grbRSI.Visible = True
            Grp_AccountsDetails.Visible = False
            Grp_Entrancefee.Visible = False
            grp_Entrancefeedetails.Visible = False
            Gpr_Company.Visible = False
            SSgrid_Qual_det.SetActiveCell(1, 1)
            'TXT_OPLDEBIT.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try

    End Sub


    Public Sub FillUnitNo()
        If (Cmb_Category.Text = "CLUB NOMINATED MEMBER  LOCAL") Or (Cmb_Category.Text = "CNM OUTSTATION") Or (Cmb_Category.Text = "CNM LOCAL") Then
            cmd_RSIDetails.Visible = True
            Try
                Dim i As Integer
                gconnection.getDataSet("SELECT UnitName FROM Tbl_UnitMaster Where Freeze='N'", "Tbl_UnitMaster")
                If gdataset.Tables("Tbl_UnitMaster").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("Tbl_UnitMaster").Rows.Count - 1
                        Me.cmbUnitNo.Items.Add(Trim(gdataset.Tables("Tbl_UnitMaster").Rows(i).Item(0)))
                    Next i
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            End Try
        End If
    End Sub

    Public Sub FillRankNo()
        Try
            Dim i As Integer
            cmbRankNo.Items.Clear()
            gconnection.getDataSet("SELECT distinct(RankName) FROM Tbl_RankMaster Where Freeze='N'", "Tbl_RankMaster")
            If gdataset.Tables("Tbl_RankMaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("Tbl_RankMaster").Rows.Count - 1
                    Me.cmbRankNo.Items.Add(Trim(gdataset.Tables("Tbl_RankMaster").Rows(i).Item(0)))
                    ' Me.Cbo_servives.Items.Add(Trim(gdataset.Tables("Tbl_RankMaster").Rows(i).Item(0)))
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Public Sub getbelongs()
        ''Try
        ''    Dim i As Integer
        ''    Cbo_servives.Items.Clear()
        ''    'Cbo_servives.Text = "ARMY"
        ''    gconnection.getDataSet("SELECT distinct(BTGroup) FROM Tbl_RankMaster Where Freeze='N'", "Tbl_RankMaster")
        ''    If gdataset.Tables("Tbl_RankMaster").Rows.Count > 0 Then
        ''        For i = 0 To gdataset.Tables("Tbl_RankMaster").Rows.Count - 1
        ''            Me.Cbo_servives.Items.Add(Trim(gdataset.Tables("Tbl_RankMaster").Rows(i).Item(0)))
        ''        Next i
        ''    End If
        ''Catch ex As Exception
        ''    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        ''End Try
    End Sub

    Private Sub btnVRSIEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grbRSI.Visible = True
    End Sub


    Public Function CheckDBNull(ByVal obj As Object, Optional ByVal ObjectType As enumObjectType = enumObjectType.StrType) As Object
        Dim objReturn As Object
        objReturn = obj
        If ObjectType = enumObjectType.StrType And IsDBNull(obj) Then
            objReturn = ""
        ElseIf ObjectType = enumObjectType.IntType And IsDBNull(obj) Then
            objReturn = 0
        ElseIf ObjectType = enumObjectType.DblType And IsDBNull(obj) Then
            objReturn = 0.0
        End If
        Return objReturn
    End Function
    Enum enumObjectType
        StrType = 0
        IntType = 1
        DblType = 2
    End Enum


    Private Sub chk_ContactAddress3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ContactAddress3.CheckedChanged
        chk_ContactAddress1.Checked = False
        chk_ContactAddress2.Checked = False
    End Sub

    Private Sub chk_ContactAddress2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ContactAddress2.CheckedChanged
        chk_ContactAddress1.Checked = False
        chk_ContactAddress3.Checked = False
    End Sub

    Private Sub chk_ContactAddress1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ContactAddress1.CheckedChanged
        chk_ContactAddress3.Checked = False
        chk_ContactAddress2.Checked = False
    End Sub

    Private Sub CHK_DOJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (CHK_DOJ.Checked = True) Then
            dtp_DOJ.Enabled = True
        Else
            dtp_DOJ.Enabled = False
        End If
    End Sub


    Private Sub chk_Married_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''If chk_Married.Checked = True Then
        ''    CHK_WDT.Enabled = True
        ''    'TXT_WEDDINGDATE.ReadOnly = False
        ''    'dtp_DOW.Enabled = True
        ''Else
        ''    CHK_WDT.Enabled = False
        ''    'CHK_WDT.Checked = False
        ''    'TXT_WEDDINGDATE.ReadOnly = True
        ''    'dtp_DOW.Enabled = False
        ''End If
        ''CHK_WDT_CheckedChanged(sender, e)
    End Sub


    Private Sub Img_Spousephoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img_Spousephoto.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Spousephoto.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_Spouse = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_MemberCode1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCode1.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtRBYMEMBERNO.Text = Trim(vform.keyfield & "")
                txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")

            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_MemberCode2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCode2.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtRBYMEMBERNO2.Text = Trim(vform.keyfield & "")
                txtNBYMEMBERNAME2.Text = Trim(vform.keyfield1 & "")

            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub


    Private Sub btn_AccountsDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AccountsDetails.Click
        Try
            Dim dt As New DataTable
            If (txt_MemberCode.Text <> "") Then

                'Grp_AccountsDetails.Location = New Point(120, 239)
                'Grp_AccountsDetails.Size = New Size(744, 180)
                'GP_ENTERENCEFEE.Visible = False
                Grp_Address.Visible = False
                grp_ChildrenDetails.Visible = False
                Grp_MemQualification.Visible = False
                grbRSI.Visible = False
                Grp_AccountsDetails.Visible = True

                Sqlstr = "select s.sltype as 'SLTYPE',a.accode as 'ACCOUNT CODE',s.acdesc as 'ACCOUNT DESCRIPTION',s.slcode as 'MEMBER CODE',s.sldesc as 'SLDESC',a.cldebits as 'DEBIT',a.clcredits as 'CREDIT',(a.cldebits-a.clcredits) as 'BALANCE' from AccountsGlAccountMaster a,accountssubledgermaster s where a.accode=s.accode and a.accode='" & gDebtors & "' and s.slcode='" & txt_MemberCode.Text & "'"
                dt = gconnection.GetValues(Sqlstr)
                DataGrid1.DataSource = dt.DefaultView

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cmd_MemberNo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberNo1.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(OLDMCODE,'')AS OLDMCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(SPOUSE,'')AS SPOUSE,ISNULL(COMPANY,'')AS COMPANY FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,OLDMCODE,MNAME,SPOUSE,COMPANY"
            vform.vFormatstring = "  MEMBERSHIP NO  |   OLDMEMBERSHIP NO   |                   MEMBER NAME               |               SPOUSE               |               COMPANY                         "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")
                Call txt_MemberCode_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Try
            Dim I, J As Integer
            Dim paddress1, oaddress1, raddress1, caddress1 As String
            Dim paddress2, oaddress2, raddress2, caddress2 As String
            Dim paddress3, oaddress3, raddress3, caddress3 As String
            Dim Pcell, Ocell, Rcell, Ccell, sqlstring As String
            If txt_MemberCode.Text <> "" Then
                'Cmb_Category.Enabled = False
                cbo_CurrentStatus.Enabled = False
                Sqlstr = " SELECT Isnull(MEMGSTIN,'') as MEMGSTIN,isnull(religion,'')as religion,isnull(MEMBERTYPECODE,'') as MEMBERTYPECODE,salut,isnull(Prefix,'') as Prefix,isnull(FirstName,'') as FirstName,isnull(MiddleName,'') as MiddleName,isnull(Surname,'') as Surname,isnull(CurentStatus,'') as CurentStatus,isnull(billbasis,'') as billbasis,isnull(SEX,'') as SEX,"
                Sqlstr = Sqlstr & " Convert(varchar(11),isnull(DOB,''),106) as DOB,Convert(varchar(11),isnull(ApplDate,''),106) as ApplDate,isnull(ApplNo,'')as ApplNo,isnull(cardno,'')As cardno,Convert(varchar(11),isnull(SDOB,''),106) as SDOB,wedding_date,Convert(varchar(11),isnull(DOJ,''),106) as DOJ,Convert(varchar(11),isnull(Endingdate,''),106) as Endingdate,isnull(MARITALSTATUS,'') as MARITALSTATUS,isnull(spouse,'') as spouse,isnull(PADD1,'') as PADD1,isnull(PADD2,'') as PADD2,isnull(PADD3,'') as PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,RankNo,ICNO,UnitNo,Convert(varchar(11),isnull(DateOfCommission,''),106) as DateOfCommission,Convert(varchar(11),isnull(DateOfCreation,''),106) as DateOfCreation,Convert(varchar(11),isnull(DateOfRelease,''),106) as DateOfRelease,isnull(MDescription,'') as MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,RByMemberNo,RByName,RBYMEMBERNO2,RBYMEMBERNAME2,MEMBERTYPE,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,isnull(RAcopyst1,'') as RAcopyst1,isnull(PAcopyst1,'')as PAcopyst1,isnull(BAcopyst1,'')as BAcopyst1,isnull(bg,'') as bg, isnull(pano,'') as pano,isnull(criditnumber,'') as criditnumber,marital_status,occupation,COMPANY,Designation,BuisnessInfo,isnull(ProfessionInfo,'')as ProfessionInfo ,Products ,AgentsDealers ,Turnover ,NoOfEmp,oldmcode,isnull(spouseprefix,'') as spouseprefix,Isnull(Corporatecode,'') as Corporatecode,Isnull(SpouseFreeze,'')as SpouseFreeze,isnull(Catlimit,0) as catlimit,isnull(memlimit,0) as memlimit,isnull(replacement,'') as replacement,ISNULL(RNO,'') AS RNO FROM MEMBERMASTER WHERE MCODE='" & txt_MemberCode.Text & "'"
                gconnection.getDataSet(Sqlstr, "MemMst")
                Call loadMaritalstatus(I + 1)
                Call loadmembertype(I + 1)
                If gdataset.Tables("MemMst").Rows.Count > 0 Then
                    txt_MemberCode.ReadOnly = True
                    Call Dependentagelimit()
                    Cmb_Category.Enabled = False
                    'cbo_BillingBasis.Enabled = False
                    Call loadmembertype(I + 1)
                    Call loadSalutation(I + 1)
                    Cbo_relation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("religion"))
                    Cbo_title.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("salut"))
                    TXT_TITLE.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Prefix"))
                    txt_FirstName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("FirstName"))
                    txt_MiddleName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MiddleName"))
                    txt_Surname.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Surname"))
                    Cmb_Category.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPE"))
                    'If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                    '    Txt_Replacement.Enabled = True
                    '    Cmd_Replacement.Enabled = True
                    'Else
                    '    Txt_Replacement.Enabled = False
                    '    Cmd_Replacement.Enabled = False

                    'End If
                    sqlstring = "select isnull(creditlimityn,'') as creditlimityn,isnull(tenures,'') as tenures from subcategorymaster where subtypedesc='" & Cmb_Category.Text & "'"
                    gconnection.getDataSet(sqlstring, "subcategory")
                    If gdataset.Tables("subcategory").Rows.Count > 0 Then
                        CREDITYN = gdataset.Tables("subcategory").Rows(0).Item("CREDITLIMITYN")
                        VALIDITY = gdataset.Tables("subcategory").Rows(0).Item("tenures")

                    End If
                    If VALIDITY = "Y" Then
                        chk_EXPDT.Enabled = False
                        dtp_EXPDT.Enabled = False
                    Else

                    End If
                    Txt_GstinNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MEMGSTIN"))

                    Dim index As Integer
                    gconnection.getDataSet("SELECT isnull(TYPEDESC,'') as TYPEDESC,isnull(MEMBERTYPE,'') as MEMBERTYPE  FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and MEMBERTYPE='" & gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPECODE") & "'", "TypeMst")
                    'If gdataset.Tables("TypeMst").Rows.Count > 0 Then
                    '    Cmb_Category.Text = (gdataset.Tables("TypeMst").Rows(0).Item("TYPEDESC"))
                    'End If
                    cbo_CurrentStatus.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CurentStatus"))
                    '---------subscription Type-----------
                    If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                        If cbo_CurrentStatus.Text = "ACTIVE" Or cbo_CurrentStatus.Text = "LIVE" Then
                            Txt_Replacement.Enabled = True
                            Txt_Rno.Enabled = True
                            Cmd_Replacement.Enabled = True
                        Else
                            Txt_Replacement.Enabled = False
                            Cmd_Replacement.Enabled = False
                            Txt_Rno.Enabled = False

                        End If
                    Else
                        Txt_Replacement.Enabled = False
                        Cmd_Replacement.Enabled = False

                    End If
                    validation = True
                    index = cbo_BillingBasis.FindString((gdataset.Tables("MemMst").Rows(0).Item("billbasis")))
                    If index < 0 Then
                        If Cmb_Category.Items.Count > 0 Then
                            cbo_BillingBasis.SelectedIndex = 0
                        End If
                    Else
                        cbo_BillingBasis.SelectedIndex = index
                    End If
                    If (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "F" Then
                        chk_female.Checked = True
                        chk_male.Checked = False
                    ElseIf (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "M" Then
                        chk_male.Checked = True
                        chk_female.Checked = False
                    Else
                        chk_male.Checked = False
                        chk_female.Checked = False
                    End If

                    If (gdataset.Tables("MemMst").Rows(0).Item("DOB")) = "01 Jan 1900" Then
                        dtp_DOB.Text = ""
                        CHK_DOB.Checked = False
                    Else
                        dtp_DOB.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOB")), "dd/MMM/yyyy")
                        CHK_DOB.Checked = True
                    End If

                    CHK_DOB_CheckedChanged(sender, e)
                    If (gdataset.Tables("MemMst").Rows(0).Item("Endingdate")) = "01 Jan 1900" Then
                        dtp_EXPDT.Text = ""
                        chk_EXPDT.Checked = False
                    Else
                        dtp_EXPDT.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("Endingdate")), "dd/MMM/yyyy")
                        chk_EXPDT.Checked = True
                        chk_EXPDT.Enabled = True
                    End If
                    chk_EXPDT_CheckedChanged(sender, e)

                    If (gdataset.Tables("MemMst").Rows(0).Item("DOJ")) = "01 Jan 1900" Then
                        dtp_DOJ.Text = ""
                        CHK_DOJ.Checked = False
                    Else
                        dtp_DOJ.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOJ")), "dd/MMM/yyyy")
                        CHK_DOJ.Checked = True
                    End If
                    If (gdataset.Tables("MemMst").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                        dtp_DOW.Text = ""
                        CHK_WDT.Checked = False
                    Else
                        dtp_DOW.Text = (gdataset.Tables("MemMst").Rows(0).Item("wedding_date"))
                        CHK_WDT.Checked = True
                    End If

                    If (gdataset.Tables("MemMst").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                        Dtp_Spousedob.Text = ""
                        ChK_SDOB.Checked = False
                    Else
                        Dtp_Spousedob.Text = (gdataset.Tables("MemMst").Rows(0).Item("SDOB"))
                        ChK_SDOB.Checked = True
                    End If

                    txt_Spouse.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Spouse"))
                    txt_PA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD1"))
                    txt_PA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD2"))
                    txt_PA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD3"))

                    Cbo_PCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCITY"))
                    Cbo_PState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PSTATE"))
                    Cbo_PCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCOUNTRY"))

                    txt_PA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPIN"))
                    txt_PA_Phone.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE1"))
                    txt_PA_Phone2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE2"))
                    txt_PA_Mobile.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCELL"))
                    txt_PA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PEMAIL"))

                    txt_RA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD1"))
                    txt_RA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD2"))
                    txt_RA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD3"))

                    txt_RA_City.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCITY"))
                    txt_RA_State.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CSTATE"))

                    Cbo_CCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCITY"))
                    Cbo_CState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CSTATE"))
                    Cbo_CCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCOUNTRY"))

                    txt_RA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPIN"))
                    txt_RA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE1"))
                    txt_RA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE2"))
                    txt_RA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCELL"))
                    txt_RA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CEMAIL"))

                    txt_BA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD1"))
                    txt_BA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD2"))
                    txt_BA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD3"))

                    Cbo_BCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCITY"))
                    Cbo_BState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OSTATE"))
                    Cbo_BCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCOUNTRY"))

                    Txt_Replacement.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("REPLACEMENT"))
                    Txt_Rno.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RNO"))
                    txt_BA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPIN"))
                    txt_BA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE1"))
                    txt_BA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE2"))
                    txt_BA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCELL"))
                    txt_BA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OEMAIL"))

                    Txt_AppNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ApplNo"))
                    Dtp_Appdate.Text = (gdataset.Tables("MemMst").Rows(0).Item("ApplDate"))
                    cmbRankNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RankNo"))
                    txtICNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ICNO"))
                    cmbUnitNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("UnitNo"))
                    dtpDFCommission.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfCommission"))
                    dtpDFCreation.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfCreation"))
                    dtpDFRelease.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfRelease"))
                    Cbo_servives.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MDescription"))
                    txtRIDCARDNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RIDCardNo"))
                    txtArmService.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ArmService"))
                    txtWO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("WO"))
                    txtNFDependencies.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("NoOfDependencies"))
                    txtRBYMEMBERNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByMemberNo"))
                    txtNBYMEMBERNAME.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByName"))
                    txtRBYMEMBERNO2.Text() = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RBYMEMBERNO2"))
                    txtNBYMEMBERNAME2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RBYMEMBERNAME2"))
                    txt_ProposerCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PROPOSER"))
                    txt_ProposedName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PROPOSERNAME"))
                    txt_SeconderCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDER"))
                    txt_SeconderName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDERNAME"))
                    Txt_BloodGroup.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("BG"))
                    Txt_pancarno.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PANO"))
                    txt_CreditNumber.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("criditnumber"))
                    Txt_companyName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("COMPANY"))
                    Txt_Designation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("occupation"))
                    Cbo_MaritalStatus.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("marital_status"))
                    'Txt_Professionalinfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ProfessionInfo"))
                    Cbo_professional.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ProfessionInfo"))
                    Txt_Bussinessinfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("BuisnessInfo"))
                    Txt_products.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Products"))
                    Txt_turnover.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Turnover"))
                    Txt_noofEmpolyee.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("NoOfEmp"))
                    Txt_AgenttInfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("AgentsDealers"))
                    Cbo_designation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Designation"))
                    'Txt_oldmembership.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("oldmcode"))
                    Cbo_Spousesalutation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("spouseprefix"))
                    Txt_CorporateCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Corporatecode"))
                    TXT_CATLIMIT.Text = Val(gdataset.Tables("memmst").Rows(0).Item("catlimit"))
                    TXT_MEMLIMIT.Text = Val(gdataset.Tables("memmst").Rows(0).Item("memlimit"))

                    '----Spouse Freeze------------
                    If CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SpouseFreeze")) = "Y" Then
                        Me.Chk_spouseFreeze.Checked = True
                    ElseIf CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SpouseFreeze")) = "N" Then
                        Me.Chk_spouseFreeze.Checked = False
                    End If
                    'DEPENDENT DETAILS 
                    Sqlstr = " select ISNULL(prefix,'')AS prefix,ISNULL(mem_code,'') AS MCODE,ISNULL(child_nm,'') AS CNAME,ISNULL(child_dob,'') AS CDOB,ISNULL((relation),'') AS RELATION,ISNULL(maritalstatus,'') AS maritalstatus,dep_bloodgroup,isnull(Sex,'') as Sex,isnull(SpouseName,'')as SpouseName,isnull(membertype,'')as membertype,isnull(studentmember,'')as studentmember,isnull(dep_Doj,'')as dep_Doj,isnull(Religion,'') as Religion,isnull(anniversarydate,'') as anniversarydate,isnull(occupation,'')as occupation,isnull(Panno,0) as Panno,isnull(phone,'') as phone,isnull(mobile,'') as mobile,isnull(emailid,'') as emailid from memdet where type0='CHLD' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "DeptMst")
                    If gdataset.Tables("DeptMst").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("DeptMst").Rows.Count - 1
                            With ssgrid
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Row = I + 1
                                ssgrid.Col = 1
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("prefix"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 2
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("CNAME"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 3
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "dd/MM/yyyy")
                                End If

                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 4
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("Sex"))

                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 5
                                If ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "SPOUSE") Then
                                    .Text = "SPOUSE"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "SON") Then
                                    .Text = "SON"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "DAUGHTER") Then
                                    .Text = "DAUGHTER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "FATHER") Then
                                    .Text = "FATHER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "MOTHER") Then
                                    .Text = "MOTHER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "OTHERS") Then
                                    .Text = "OTHERS"
                                End If
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 6
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("SpouseName"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 8
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("anniversarydate")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("anniversarydate")), "dd/MM/yyyy")
                                End If
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 7
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("maritalstatus"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)


                                ssgrid.Col = 9
                                Sqlstr = "SELECT memimage as memimage FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptMst").Rows(I).Item("CNAME") & "'  and type0='chld' "
                                LoadFoto_chld(Sqlstr, I + 1)
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 10
                                Sqlstr = "SELECT depimagesign as depimagesign FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptMst").Rows(I).Item("CNAME") & "'  and type0='chld' "
                                LoadFoto_chld1(Sqlstr, I + 1)
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 13
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("dep_bloodgroup"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 14
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("studentmember"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 15
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("dep_Doj")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("dep_Doj")), "dd/MM/yyyy")
                                End If
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 16
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("membertype"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 17
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("Religion"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)

                                ssgrid.Col = 18
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("occupation"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 19
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("Panno"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 20
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("phone"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 21
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("mobile"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                                ssgrid.Col = 22
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("emailid"))
                                Call loadmembertype(I + 1)
                                Call loadSalutation(I + 1)
                                Call loadMaritalstatus(I + 1)
                            End With
                        Next I
                    End If

                    'Member Education
                    Sqlstr = " SELECT ISNULL(QUAL_DET,'') AS QUAL_DET,ISNULL(REMARKS,'') AS REMARKS,ISNULL(YEAR_PASS,'') AS YEAR_PASS,"
                    Sqlstr = Sqlstr & "ISNULL(INSTITUTE,'') AS INSTITUTE,ISNULL(DIVISION,'') AS DIVISION FROM MEMDET WHERE TYPE0='QUAL' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "QualMst1")
                    'SSgrid_Qual_det.ClearRange(1, 1, -1, -1, True)
                    If gdataset.Tables("QualMst1").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("QualMst1").Rows.Count - 1
                            With SSgrid_Qual_det
                                .Row = I + 1
                                .Col = 1
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("QUAL_DET"))
                                .Col = 2
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("REMARKS"))
                                .Col = 3
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("YEAR_PASS"))
                                .Col = 4
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("INSTITUTE"))
                                .Col = 5
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("DIVISION"))
                            End With
                        Next I
                    End If

                    'Entrance Fee
                    Sqlstr = " SELECT ISNULL(rct_no,'') AS rct_no,ISNULL(start_dt,'') AS start_dt,ISNULL(amount,0) AS amount"
                    Sqlstr = Sqlstr & " FROM MEMDET WHERE TYPE0='ENTR' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "feeMst1")
                    If gdataset.Tables("feeMst1").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("feeMst1").Rows.Count - 1
                            With SSgrid_Entfee
                                .Row = I + 1
                                .Col = 1
                                .Text = (gdataset.Tables("feeMst1").Rows(I).Item("rct_no"))
                                .Col = 2
                                If Format(CDate(gdataset.Tables("feeMst1").Rows(I).Item("start_dt")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("feeMst1").Rows(I).Item("start_dt")), "dd/MM/yyyy")
                                End If
                                .Col = 3
                                .Text = (gdataset.Tables("feeMst1").Rows(I).Item("amount"))
                            End With
                        Next I
                    End If
                    Sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Photo)
                    Sqlstr = "SELECT memimagesign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Signature)
                    Sqlstr = "SELECT SpouseImage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Spousephoto)
                    Sqlstr = "SELECT SpouseImageSign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, IMG_SPOUSESIGN)
                    CmdAdd.Text = "Update[F7]"
                    'paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD1")))
                    'oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD1")))
                    'raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD1")))
                    'caddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD1")))
                    'paddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD2")))
                    'oaddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD2")))
                    'raddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD2")))
                    'caddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD2")))
                    'paddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD3")))
                    'oaddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD3")))
                    'raddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD3")))
                    'caddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD3")))
                    'pcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PCELL")))
                    'ocell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OCELL")))
                    'rcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CCELL")))
                    'ccell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTCELL")))
                    'If paddress1 = caddress1 And paddress2 = caddress2 And paddress3 = caddress3 And Pcell = Ccell Then
                    '    chk_ContactAddress1.Checked = True
                    'ElseIf oaddress1 = caddress1 And oaddress2 = caddress2 And oaddress3 = caddress3 And Ocell = Ccell Then
                    '    chk_ContactAddress2.Checked = True
                    'ElseIf raddress1 = caddress1 And raddress2 = caddress2 And raddress3 = caddress3 And Rcell = Ccell Then
                    '    chk_ContactAddress3.Checked = True
                    'Else
                    '    chk_ContactAddress1.Checked = False
                    '    chk_ContactAddress2.Checked = False
                    '    chk_ContactAddress3.Checked = False
                    'End If
                    paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PAcopyst1")))
                    oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("BAcopyst1")))
                    raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("RAcopyst1")))
                    If paddress1 = "Y" Then
                        chk_ContactAddress1.Checked = True
                    ElseIf oaddress1 = "Y" Then
                        chk_ContactAddress2.Checked = True
                    ElseIf raddress1 = "Y" Then
                        chk_ContactAddress3.Checked = True
                    Else
                        chk_ContactAddress1.Checked = False
                        chk_ContactAddress2.Checked = False
                        chk_ContactAddress3.Checked = False
                    End If
                Else
                    txt_MemberCode.ReadOnly = False
                    Cbo_title.Focus()
                    Call loadmembertype(I + 1)
                    Call loadSalutation(I + 1)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            ' CmdClear_Click(sender, e)
        End Try
    End Sub
    'Private Sub txt_MemberCode_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    '    Try
    '        Dim I, J As Integer
    '        If txt_MemberCode.Text <> "" Then

    '            Sqlstr = " SELECT * FROM MEMBERMASTER WHERE MCODE='" & txt_MemberCode.Text & "'"
    '            gconnection.getDataSet(Sqlstr, "MemMst")

    '            If gdataset.Tables("MemMst").Rows.Count > 0 Then
    '                txt_MemberCode.ReadOnly = True
    '                TXT_TITLE.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Prefix"))
    '                txt_FirstName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("FirstName"))
    '                txt_MiddleName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MiddleName"))
    '                txt_Surname.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Surname"))
    '                'Cmb_Category.Text = gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPECODE")
    '                Dim index As Integer
    '                gconnection.getDataSet("SELECT TYPEDESC,MEMBERTYPE FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and MEMBERTYPE='" & gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPECODE") & "'", "TypeMst")
    '                If gdataset.Tables("TypeMst").Rows.Count > 0 Then
    '                    Cmb_Category.Text = gdataset.Tables("TypeMst").Rows(0).Item("TYPEDESC")
    '                    '    index = Cmb_Category.FindString(gdataset.Tables("TypeMst").Rows(0).Item("TYPEDESC"))
    '                    '    If index < 0 Then
    '                    '        If Cmb_Category.Items.Count > 0 Then
    '                    '            Cmb_Category.SelectedIndex = 0
    '                    '        End If
    '                    '    Else
    '                    '        Cmb_Category.SelectedIndex = index
    '                    '    End If
    '                End If

    '                'Cmb_Category.Enabled = False
    '                'cbo_BillingBasis.Text = gdataset.Tables("MemMst").Rows(0).Item("Billbasis")
    '                'index = cbo_BillingBasis.FindString(gdataset.Tables("MemMst").Rows(0).Item("Billbasis"))
    '                'If index < 0 Then
    '                '    If Cmb_Category.Items.Count > 0 Then
    '                '        cbo_BillingBasis.SelectedIndex = 0
    '                '    End If
    '                'Else
    '                '    cbo_BillingBasis.SelectedIndex = index
    '                'End If

    '                index = cbo_CurrentStatus.FindString(CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CurentStatus")))
    '                If index < 0 Then
    '                    If Cmb_Category.Items.Count > 0 Then
    '                        cbo_CurrentStatus.SelectedIndex = 0
    '                    End If
    '                Else
    '                    cbo_CurrentStatus.SelectedIndex = index
    '                End If
    '                'cbo_CurrentStatus.Enabled = False
    '                'Cmb_Category.Enabled = False




    '                'Txt_CreditLimit.Text = gdataset.Tables("MemMst").Rows(0).Item("CREDITLIMIT")
    '                If Format(gdataset.Tables("MemMst").Rows(0).Item("wedding_date"), "dd/MM/yyyy") = "01/01/1900" Then
    '                    dtp_DOW.Text = gdataset.Tables("MemMst").Rows(0).Item("wedding_date")
    '                    CHK_WDT.Checked = False
    '                Else
    '                    dtp_DOW.Text = gdataset.Tables("MemMst").Rows(0).Item("wedding_date")
    '                    CHK_WDT.Checked = True
    '                End If

    '                'txt_CompanyName.Text = gdataset.Tables("MemMst").Rows(0).Item("Company")
    '                'txt_Designation.Text = gdataset.Tables("MemMst").Rows(0).Item("Designation")
    '                'txt_Professonalinfo.Text = gdataset.Tables("MemMst").Rows(0).Item("ProfessionInfo")

    '                If Format(gdataset.Tables("MemMst").Rows(0).Item("DOB"), "dd/MM/yyyy") = "01/01/1900" Then
    '                    dtp_DOB.Text = gdataset.Tables("MemMst").Rows(0).Item("DOB")
    '                    CHK_DOB.Checked = False
    '                Else
    '                    dtp_DOB.Text = gdataset.Tables("MemMst").Rows(0).Item("DOB")
    '                    CHK_DOB.Checked = True
    '                End If
    '                CHK_DOB_CheckedChanged(sender, e)

    '                If Format(gdataset.Tables("MemMst").Rows(0).Item("DOJ"), "dd/MM/yyyy") = "01/01/1900" Then
    '                    dtp_DOJ.Text = gdataset.Tables("MemMst").Rows(0).Item("DOj")
    '                    CHK_DOJ.Checked = False
    '                Else
    '                    dtp_DOJ.Text = gdataset.Tables("MemMst").Rows(0).Item("DOj")
    '                    CHK_DOJ.Checked = True
    '                End If
    '                'chk_mshipfrom_CheckedChanged(sender, e)

    '                If Format(gdataset.Tables("MemMst").Rows(0).Item("MembershipTo"), "dd/MM/yyyy") = "01/01/1900" Then
    '                    dtp_EXPDT.Text = gdataset.Tables("MemMst").Rows(0).Item("MembershipTo")
    '                    chk_EXPDT.Checked = False
    '                Else
    '                    dtp_EXPDT.Text = gdataset.Tables("MemMst").Rows(0).Item("MembershipTo")
    '                    chk_EXPDT.Checked = True
    '                End If
    '                'chk_EXPDT_CheckedChanged(sender, e)
    '                If gdataset.Tables("MemMst").Rows(0).Item("SEX") = "F" Then
    '                    chk_female.Checked = True
    '                Else
    '                    chk_male.Checked = True
    '                End If
    '                'chk_female_CheckedChanged(sender, e)
    '                'chk_male_CheckedChanged(sender, e)
    '                If gdataset.Tables("MemMst").Rows(0).Item("MARITALSTATUS") = "Y" Then

    '                    chk_Married.Checked = True
    '                    txt_Spouse.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SPOUSE"))
    '                Else
    '                    chk_Married.Checked = False
    '                    txt_Spouse.Text = ""
    '                End If
    '                'txt_Spouse.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SPOUSE"))

    '                'chk_Married_CheckedChanged(sender, e)


    '                'CREDITLIMIT = '" & Trim(Txt_CreditLimit.Text) & "', 
    '                'Sqlstr = Sqlstr & " wedding_date= '" & Format(dtp_DateOfBirth.Value, "dd-MMM-yyyy") & "',"
    '                'Sqlstr = Sqlstr & " CriditNumber='" & Trim(txt_CreditNumber.Text) & "',"
    '                'Sqlstr = Sqlstr & " SecurityDeposit =" & Val(txt_SecurityDeposit.Text) & " ,"
    '                'Sqlstr = Sqlstr & " EntranceFee =" & Val(txt_EntranceFee.Text) & ","
    '                'Sqlstr = Sqlstr & " DevelopmentFee = " & Val(txt_DevelopmentFee.Text) & ","
    '                ' Sqlstr = Sqlstr & " ApplNo ='" & Trim(txt_ApplicationNo.Text) & "',"
    '                ' Sqlstr = Sqlstr & "  ApplDate ='" & Format(dtp_DateApplication.Value, "dd-MMM-yyyy") & "',"
    '                ' Sqlstr = Sqlstr & "  Company='" & Trim(txt_CompanyName.Text) & "',"
    '                ' Sqlstr = Sqlstr & "  Designation ='" & Trim(txt_Designation.Text) & "',"
    '                ' Sqlstr = Sqlstr & " ProfessionInfo = '" & Trim(txt_Professonalinfo.Text) & "',"
    '                ' Sqlstr = Sqlstr & " BuisnessInfo ='" & Trim(txt_Bussinessinfo.Text) & "',"
    '                'SQLSTRING = SQLSTRING & "BANKER ='" & Trim(txt_Bankers.Text) & "' ,Client ='" & Trim(txt_Clients.Text) & "' ,Products ='" & Trim(txt_Products.Text) & "',AgentsDealers='" & Trim(txt_Agents.Text) & "' ,ESTDdate='" & Format(dtp_ESTDdate.Value, "dd/MMM/yyyy") & "' ,NoOfEmp =" & Val(txt_NoOfEmployee.Text) & ", "
    '                'Turnover =" & Val(txt_TurnOver.Text) & ","


    '                'Sqlstr = Sqlstr & " RAcopyst='" & RAcopyst & "',"
    '                txt_RA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD1"))
    '                txt_RA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD2"))
    '                txt_RA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD3"))
    '                txt_RA_City.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCITY"))
    '                txt_RA_State.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CSTATE"))
    '                'txt_RA_Country.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCOUNTRY"))
    '                txt_RA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPIN"))
    '                txt_RA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE1"))
    '                txt_RA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE2"))
    '                txt_RA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCELL"))
    '                txt_RA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CEMAIL"))

    '                ' Sqlstr = Sqlstr & " BAcopyst='" & BAcopyst & "',"
    '                txt_BA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD1"))
    '                txt_BA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD2"))
    '                txt_BA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD3"))
    '                txt_BA_City.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCITY"))
    '                txt_BA_State.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OSTATE"))
    '                'txt_BA_Country.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCOUNTRY"))
    '                txt_BA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPIN"))
    '                txt_BA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE1"))
    '                txt_BA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE2"))
    '                txt_BA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCELL"))
    '                txt_BA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OEMAIL"))

    '                ' Sqlstr = Sqlstr & " PAcopyst='" & PAcopyst & "',"
    '                txt_PA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD1"))
    '                txt_PA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD2"))
    '                txt_PA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD3"))
    '                txt_PA_City.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCITY"))
    '                txt_PA_State.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PSTATE"))
    '                'txt_PA_Country.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCOUNTRY"))
    '                txt_PA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPIN"))
    '                txt_PA_Phone.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE1"))
    '                txt_PA_Phone2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE2"))
    '                txt_PA_Mobile.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCELL"))
    '                txt_PA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PEMAIL"))


    '                cmbRankNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RankNo"))
    '                txtICNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ICNO"))
    '                cmbUnitNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("UnitNo"))
    '                dtpDFCommission.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("DateOfCommission"))
    '                dtpDFCreation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("DateOfCreation"))
    '                dtpDFRelease.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("DateOfRelease"))
    '                'cmbBTGroup.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("BTGroup"))
    '                txtMemberDescription.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MDescription"))
    '                txtRIDCARDNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RIDCardNo"))
    '                txtArmService.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ArmService"))
    '                txtWO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("WO"))
    '                txtNFDependencies.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("NoOfDependencies"))
    '                txtRBYMEMBERNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByMemberNo"))
    '                txtNBYMEMBERNAME.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByName"))





    '                'OPLBALANCE
    '                'Sqlstr = " Select isnull(opdebits,0) as opdebits,isnull(opcredits,0) as opcredits from Accountssubledgermaster "
    '                'Sqlstr = Sqlstr & " Where accode='SDRS' AND SLCODE='" & txt_MemberCode.Text & "'"
    '                'gconnection.getDataSet(Sqlstr, "OPLBAL")
    '                'If gdataset.Tables("OPLBAL").Rows.Count > 0 Then
    '                '    TXT_OPLDEBIT.Text = gdataset.Tables("OPLBAL").Rows(I).Item("opdebits")
    '                '    TXT_OPLCREDIT.Text = gdataset.Tables("OPLBAL").Rows(I).Item("opcredits")
    '                'Else
    '                '    TXT_OPLCREDIT.Text = "0.00"
    '                '    TXT_OPLDEBIT.Text = "0.00"
    '                'End If

    '                'enterence fee
    '                'Sqlstr = "select isnull(remarks,'') as remarks,ISNULL(MEM_CODE,'') AS MEM_CODE,ISNULL(type0,'') AS type0,ISNULL(RCT_NO,'') AS RCT_NO,ISNULL(START_DT,'') AS START_DT,ISNULL(AMOUNT,0) AS AMOUNT from memdet where mem_code='" & txt_MemberCode.Text & "' and type0='entr'"
    '                'gconnection.getDataSet(Sqlstr, "EntMst")
    '                'SSgrid_Entrancefee.ClearRange(1, 1, -1, -1, True)
    '                'If gdataset.Tables("EntMst").Rows.Count > 0 Then
    '                '    For I = 0 To gdataset.Tables("EntMst").Rows.Count - 1
    '                '        With SSgrid_Entrancefee
    '                '            .Row = I + 1
    '                '            .Col = 1
    '                '            .Text = gdataset.Tables("EntMst").Rows(I).Item("RCT_NO")
    '                '            .Row = I + 1
    '                '            .Col = 2
    '                '            If Format(gdataset.Tables("EntMst").Rows(I).Item("START_DT"), "dd/MM/yyyy") = "01/01/1900" Then
    '                '                .Text = ""
    '                '            Else
    '                '                .Text = Format(gdataset.Tables("EntMst").Rows(I).Item("START_DT"), "dd/MM/yyyy")
    '                '            End If
    '                '            .Row = I + 1
    '                '            .Col = 3
    '                '            .Text = gdataset.Tables("EntMst").Rows(I).Item("AMOUNT")
    '                '            .Row = I + 1
    '                '            .Col = 4
    '                '            .Text = gdataset.Tables("EntMst").Rows(I).Item("Remarks")
    '                '        End With
    '                '    Next I
    '                ' End If
    '                'DEPENDENT DETAILS 
    '                Sqlstr = " select ISNULL(mem_code,'') AS MCODE,ISNULL(child_nm,'') AS CNAME,ISNULL(child_dob,'') AS CDOB,ISNULL((relation),'') AS RELATION,ISNULL(remarks,'') AS Remarks from memdet where type0='CHLD' AND MEM_CODE='" & txt_MemberCode.Text & "'"
    '                gconnection.getDataSet(Sqlstr, "DeptMst")
    '                'ssgrid.ClearRange(1, 1, -1, -1, True)
    '                If gdataset.Tables("DeptMst").Rows.Count > 0 Then
    '                    For I = 0 To gdataset.Tables("DeptMst").Rows.Count - 1
    '                        With ssgrid
    '                            ssgrid.Row = I + 1
    '                            ssgrid.Col = 1
    '                            .Text = gdataset.Tables("DeptMst").Rows(I).Item("CNAME")
    '                            ssgrid.Col = 2
    '                            If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "yyyy/MM/dd") = "1900/01/01" Then
    '                                .Text = ""
    '                            Else
    '                                .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "dd/MM/yyyy")
    '                            End If
    '                            ssgrid.Col = 3
    '                            If (gdataset.Tables("DeptMst").Rows(I).Item("RELATION") = "Son") Then
    '                                '.Text = gdataset.Tables("DeptMst").Rows(I).Item("RELATION")
    '                                .Text = "Son"
    '                            Else
    '                                .Text = "Daughter"
    '                            End If


    '                            ssgrid.Col = 4
    '                            .Text = gdataset.Tables("DeptMst").Rows(I).Item("Remarks")
    '                            ssgrid.Col = 5
    '                            Sqlstr = "SELECT memimage as memimage FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptMst").Rows(I).Item("CNAME") & "'  and type0='chld' "
    '                            LoadFoto_chld(Sqlstr, I + 1)
    '                            'saran
    '                            'ssgrid.TypePictPicture = New Bitmap(LoadFoto_chld(Sqlstr, Img_Photo))
    '                            'ssgrid.TypePictPicture = New Bitmap(file.FileName)
    '                            'LoadFoto_DB(Sqlstr, Img_Photo)
    '                        End With
    '                    Next I
    '                End If
    '                'Member Education
    '                Sqlstr = " SELECT ISNULL(QUAL_DET,'') AS QUAL_DET,ISNULL(REMARKS,'') AS REMARKS,ISNULL(YEAR_PASS,'') AS YEAR_PASS,"
    '                Sqlstr = Sqlstr & "ISNULL(INSTITUTE,'') AS INSTITUTE,ISNULL(DIVISION,'') AS DIVISION FROM MEMDET WHERE TYPE0='QUAL' AND MEM_CODE='" & txt_MemberCode.Text & "'"
    '                gconnection.getDataSet(Sqlstr, "QualMst1")
    '                'SSgrid_Qual.ClearRange(1, 1, -1, -1, True)
    '                If gdataset.Tables("QualMst1").Rows.Count > 0 Then
    '                    For I = 0 To gdataset.Tables("QualMst1").Rows.Count - 1
    '                        With SSgrid_Qual
    '                            .Row = I + 1
    '                            .Col = 1
    '                            .Text = gdataset.Tables("QualMst1").Rows(I).Item("QUAL_DET")
    '                            .Col = 2
    '                            .Text = gdataset.Tables("QualMst1").Rows(I).Item("REMARKS")
    '                            .Col = 3
    '                            .Text = gdataset.Tables("QualMst1").Rows(I).Item("YEAR_PASS")
    '                            .Col = 4
    '                            .Text = gdataset.Tables("QualMst1").Rows(I).Item("INSTITUTE")
    '                            .Col = 5
    '                            .Text = gdataset.Tables("QualMst1").Rows(I).Item("DIVISION")
    '                        End With
    '                    Next I
    '                End If
    '                'AND MEMIMAGE IS NULL "
    '                Sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
    '                LoadFoto_DB(Sqlstr, Img_Photo)
    '                Sqlstr = "SELECT memimagesign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
    '                'AND memimagesign IS NULL "
    '                LoadFoto_DB(Sqlstr, Img_Signature)

    '                Sqlstr = "SELECT SpouseImage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
    '                'AND memimagesign IS NULL "
    '                LoadFoto_DB(Sqlstr, Img_Spousephoto)

    '                CmdAdd.Text = "Update[F7]"
    '                'If gUserCategory <> "S" Then
    '                '    Call GetRights()
    '                'End If

    '            Else
    '                txt_MemberCode.ReadOnly = False
    '                'txt_MemberCode.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
    '        ' CmdClear_Click(sender, e)
    '    End Try


    'End Sub


    Private Sub chk_male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_male.CheckedChanged
       
    End Sub

    Private Sub chk_female_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_female.CheckedChanged
      
    End Sub
    'Private Sub CmdAddNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click


    'End Sub

    Private Sub Grp_Details_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txt_Spouse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmdClear_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdClear.Enter

    End Sub

    Private Sub txt_PA_Mobile_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Mobile.LostFocus
        ''If Not IsNumeric(txt_PA_Mobile.Text) And (txt_PA_Mobile.Text <> "") Then
        ''    MsgBox("Please Enter MOBILE NUMBER!", MsgBoxStyle.Information)
        ''    txt_PA_Mobile.Clear()
        ''    txt_PA_Mobile.Focus()
        ''    Exit Sub
        ''End If
    End Sub

    Private Sub txt_PA_Phone2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PA_Phone2.LostFocus
        'If Not IsNumeric(txt_PA_Phone2.Text) And (txt_PA_Phone2.Text <> "") Then
        '    MsgBox("Please Enter PHONE NUMBER!", MsgBoxStyle.Information)
        '    txt_PA_Phone2.Clear()
        '    txt_PA_Phone2.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_PA_Phone_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PA_Phone.LostFocus
        'If Not IsNumeric(txt_PA_Phone.Text) And (txt_PA_Phone.Text <> "") Then
        '    MsgBox("Please Enter PHONENUMBER!", MsgBoxStyle.Information)
        '    txt_PA_Phone.Clear()
        '    txt_PA_Phone.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_PA_PinCode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_PinCode.LostFocus
        'If Not IsNumeric(txt_PA_PinCode.Text) And (txt_PA_PinCode.Text <> "") Then
        '    MsgBox("Please Enter PincodeNumber!", MsgBoxStyle.Information)
        '    txt_PA_PinCode.Clear()
        '    txt_PA_PinCode.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_BA_PhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_PhoneNo.TextChanged

    End Sub

    Private Sub txt_BA_PhoneNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BA_PhoneNo.LostFocus
        'If Not IsNumeric(txt_BA_PhoneNo.Text) And (txt_BA_PhoneNo.Text <> "") Then
        '    MsgBox("Please Enter Phone Number!", MsgBoxStyle.Information)
        '    txt_BA_PhoneNo.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_BA_PinCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BA_PinCode.LostFocus
        'If Not IsNumeric(txt_BA_PinCode.Text) And (txt_BA_PinCode.Text <> "") Then
        '    MsgBox("Please Enter PincodeNumber!", MsgBoxStyle.Information)
        '    'txt_BA_PinCode.Text = ""
        '    txt_BA_PinCode.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_BA_PhoneNo2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BA_PhoneNo2.LostFocus
        'If Not IsNumeric(txt_BA_PhoneNo2.Text) And (txt_BA_PhoneNo2.Text <> "") Then
        '    MsgBox("Please Enter Phone Number!", MsgBoxStyle.Information)
        '    'txt_BA_PhoneNo2.Text = ""
        '    txt_BA_PhoneNo2.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_BA_MobileNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BA_MobileNo.LostFocus
        'If Not IsNumeric(txt_BA_MobileNo.Text) And (txt_BA_MobileNo.Text <> "") Then
        '    MsgBox("Please Enter Phone Number!", MsgBoxStyle.Information)
        '    'txt_BA_MobileNo.Text = ""
        '    txt_BA_MobileNo.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub


    Private Sub txtRBYMEMBERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRBYMEMBERNO.TextChanged

    End Sub

    Private Sub txtRBYMEMBERNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRBYMEMBERNO.KeyDown

        If e.KeyCode = Keys.Enter Then
            '        If txtRBYMEMBERNO.Text = "" Then
            '            cmd_MemberCodeHelp_Click(sender, e)
            '        Else
            '            'cbo_Title.Focus()
            '        End If
            '    ElseIf e.KeyCode = Keys.F4 Then
            '        cmd_MemberCodeHelp_Click(sender, e)
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            'End Try
            Try
                Dim vform As New ListOperation
                gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
                M_WhereCondition = " "
                vform.Field = "MCODE,MNAME"
                vform.vFormatstring = "  Member Code  | Member Name                           "
                vform.vCaption = "Member Master Help"
                vform.KeyPos = 0
                vform.KeyPos1 = 1
                vform.ShowDialog(Me)
                If Trim(vform.keyfield & "") <> "" Then
                    txtRBYMEMBERNO.Text = Trim(vform.keyfield & "")
                    txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")

                End If
                vform.Close()
                vform = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            End Try
        End If
    End Sub

    Private Sub txtRBYMEMBERNO2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRBYMEMBERNO2.TextChanged

    End Sub

    Private Sub txtRBYMEMBERNO2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRBYMEMBERNO2.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                Dim vform As New ListOperation
                gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
                M_WhereCondition = " "
                vform.Field = "MCODE,MNAME"
                vform.vFormatstring = "  Member Code  | Member Name                           "
                vform.vCaption = "Member Master Help"
                vform.KeyPos = 0
                vform.KeyPos1 = 1
                vform.ShowDialog(Me)
                If Trim(vform.keyfield & "") <> "" Then
                    txtRBYMEMBERNO2.Text = Trim(vform.keyfield & "")
                    txtNBYMEMBERNAME2.Text = Trim(vform.keyfield1 & "")
                End If
                vform.Close()
                vform = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
            End Try
        End If

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub dt_sdob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_sdob.ValueChanged

    End Sub

    Private Sub ChK_SDOB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChK_SDOB.Checked = True Then
            dt_sdob.Enabled = True
        Else
            dt_sdob.Enabled = False
        End If
    End Sub

    Private Sub ChK_SDOB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If ChK_SDOB.Checked = True Then
                dt_sdob.Focus()
            Else
                'CHK_DOJ.Focus()
            End If
        End If
    End Sub

    Private Sub cmbRankNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRankNo.SelectedIndexChanged

    End Sub

    Private Sub dt_sdob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dt_sdob.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Address1.Focus()
        End If
    End Sub

    Private Sub cmbRankNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRankNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_TITLE.Focus()
        End If
    End Sub

    Private Sub TXT_TITLE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_TITLE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_FirstName.Focus()
        End If
    End Sub

    Private Sub txt_RA_PhoneNo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_PhoneNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_MobileNo.Focus()
        End If
    End Sub

    Private Sub txt_PA_Mobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Mobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Email.Focus()
        End If
    End Sub

    Private Sub txt_FirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FirstName.TextChanged

    End Sub

    Private Sub dtp_DOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DOB.ValueChanged
        If dtp_DOJ.Value < dtp_DOB.Value Then
            MsgBox("Date of join should be Less then the Date of Birth", MsgBoxStyle.Information, gCompanyname)
            'Call CmdClear_Click(sender, e)

            Exit Sub
        End If
    End Sub

    Private Sub dtp_DOB_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_DOB.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CHK_DOJ.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub chk_female_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_female.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_male.Checked = False And chk_female.Checked = False Then
                MessageBox.Show("Gender can't be blank", gCompanyname)
                chk_male.Focus()

            End If
            Cmb_Category.Focus()
        End If
    End Sub

    Private Sub chk_Married_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CHK_WDT.Checked = True
        dtp_DOW.Checked = True
    End Sub

    Private Sub Cmb_Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Category.SelectedIndexChanged
        Dim SUBCATEGORY As New DataTable
        Dim ssql, SQL, SQL1, CRED As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember From SubCategorymaster where typecode='TE' and subtypedesc='" & Cmb_Category.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        'If SUBCATEGORY.Rows.Count > 0 Then
        '    'If SUBCATEGORY.Rows(0).Item("typecode") = "TE" Then
        '    chk_EXPDT.Enabled = True
        '    'dtp_EXPDT.Enabled = True
        'Else
        '    chk_EXPDT.Enabled = False
        '    dtp_EXPDT.Enabled = False
        'End If
        ssql = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN,ISNULL(VALIDITY,0) AS VALIDITY,ISNULL(TENURES,'') AS TENURES FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            CRED = SUBCATEGORY.Rows(0).Item("CREDITLIMITYN")
            VALIDITY = SUBCATEGORY.Rows(0).Item("TENURES")
            PERIOD = Val(SUBCATEGORY.Rows(0).Item("VALIDITY"))
            TXT_MEMLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
        End If
        If CRED = "Y" Then
            CREDITYN = "Y"
        Else
            CREDITYN = "N"
        End If
        If VALIDITY = "Y" Then
            chk_EXPDT.Checked = True
            dtp_EXPDT.Value = DateAdd(DateInterval.Month, PERIOD, Now)
            chk_EXPDT.Enabled = False
            dtp_EXPDT.Enabled = False
            Cmb_Category.Focus()
        Else
            chk_EXPDT.Checked = False
            chk_EXPDT.Enabled = True
            dtp_EXPDT.Enabled = False
            dtp_EXPDT.Value = Now
            Cmb_Category.Focus()

        End If
        'End If
    End Sub

    Private Sub cbo_CurrentStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_CurrentStatus.SelectedIndexChanged

    End Sub

    Private Sub CHK_DOJ_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            dtp_DOJ.Focus()
        End If
    End Sub

    Private Sub dtp_DOJ_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DOJ.ValueChanged
        If dtp_DOJ.Value <> Now Then
            If validation = True Then
                validation = False
            Else
                MsgBox("Date of join Should be check ", MsgBoxStyle.Information, gCompanyname)
            End If

            'Call CmdClear_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub dtp_DOJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_DOJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VALIDITY = "Y" Then
                Cbo_designation.Focus()
            Else
                chk_EXPDT.Focus()
            End If
            'chk_EXPDT.Focus()
        End If
    End Sub

    Private Sub dtp_EXPDT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_EXPDT.ValueChanged
        'If dtp_EXPDT_Value <> Txt_Validity Then
        '    MsgBox("Date of join Should be check ", MsgBoxStyle.Information, gCompanyname)
        '    'Call CmdClear_Click(sender, e)
        '    Exit Sub
        'End If
    End Sub

    Private Sub dtp_EXPDT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_EXPDT.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_designation.Focus()
        End If
    End Sub

    Private Sub dtp_DOW_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_DOW.ValueChanged

    End Sub

    Private Sub dtp_DOW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_DOW.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Address1.Focus()
        End If
    End Sub

    Private Sub txt_Spouse_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    ChK_SDOB.Focus()
        'End If
    End Sub

    Private Sub grbRSI_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grbRSI.Enter

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub grp_ChildrenDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_ChildrenDetails.Enter

    End Sub

    Private Sub cmbUnitNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnitNo.SelectedIndexChanged

    End Sub

    Private Sub Cbo_servives_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_servives.SelectedIndexChanged

    End Sub
    Private Sub Loadimage()
        Sqlstr = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set MEMIMAGESIGN=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_SIG, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set SpouseImage=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_Spouse, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set SpouseImagesign=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_SpouseImg, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        For I = 1 To ssgrid.DataRowCnt
            With ssgrid
                .Row = I
                .Col = 2
                Sqlstr = " Update memdet set MEMIMAGE=@memimage Where  child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                .Row = I
                .Col = 9
                If (.Text) <> "" Then
                    Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                End If
                .Col = 11
                VFilePath = AppPath & "\Reports\" & Trim(.Text) & ".JPG"
                If File.Exists(VFilePath) = True Then
                    File.Delete(VFilePath)
                End If
            End With
        Next
        For I = 1 To ssgrid.DataRowCnt

            With ssgrid
                .Row = I
                .Col = 2
                Sqlstr = "UPDATE MEMDET SET DEPIMAGESIGN=@memimage where child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                .Row = I
                .Col = 10
                If (.Text) <> "" Then
                    Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                End If
            End With
        Next
        'MessageBox.Show("Record Added Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txt_Surname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Surname.TextChanged

    End Sub

    Private Sub txt_Surname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Surname.LostFocus

    End Sub

    Private Sub chk_male_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_male.HandleDestroyed

    End Sub

    Private Sub chk_male_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_male.KeyPress

    End Sub

    Private Sub chk_male_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_male.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_male.Checked = False And chk_female.Checked = False Then
                MessageBox.Show("Gender can't be blank", gCompanyname)
                chk_male.Focus()

            End If
            Cmb_Category.Focus()
        End If
    End Sub

    Private Sub Grp_MemQualification_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_PA_Phone2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Phone2.TextChanged

    End Sub

    Private Sub txt_PA_Phone2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Phone2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Mobile.Focus()
        End If
    End Sub

    Private Sub txt_PA_Mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Mobile.TextChanged

    End Sub

    Private Sub txt_PA_Address1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Address1.TextChanged

    End Sub

    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged

    End Sub

    Private Sub txt_PA_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Email.TextChanged

    End Sub

    Private Sub txt_PA_Email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_BA_Address1.Focus()
            chk_ContactAddress1.Focus()
        End If
    End Sub

    Private Sub TXT_TITLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TITLE.TextChanged

    End Sub

    Private Sub lbl_MiddleName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_RA_Address1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_Address1.TextChanged

    End Sub

    Private Sub txt_BA_Address1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_Address1.TextChanged

    End Sub

    Private Sub Grp_Address_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_Address.Enter

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label112.Click

    End Sub

    Private Sub lbl_MemberCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_MemberCode.Click

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub

    Private Sub lbl_category_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_category.Click

    End Sub

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_PA_Address1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Address1.KeyPress

    End Sub

    Private Sub txt_PA_Address3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Address3.TextChanged

    End Sub

    Private Sub txt_BA_Address3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_Address3.TextChanged

    End Sub

    Private Sub txt_PA_Address2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Address2.TextChanged

    End Sub

    Private Sub chk_EXPDT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        dtp_EXPDT.Checked = True
    End Sub

    Private Sub chk_Married_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblspouse.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub txtICNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtICNO.TextChanged

    End Sub
    Private Sub GetLastNo()
        Dim SQLSTRING As String
        Dim DR As DataRow
        SQLSTRING = "SELECT Isnull(Max(mcode),0)as mcode FROM membermaster"
        gconnection.getDataSet(SQLSTRING, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            Me.Lbl_Last.Text = "Last No IS : " & " " & gdataset.Tables("membermaster").Rows(0).Item(0)
        Else
            Me.Lbl_Last.Text = "Last No" & " " & 0
        End If

    End Sub

    Private Sub txt_MemberCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_MemberCode.Validating

    End Sub

    Private Sub btn_Entancefee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Entancefee.Click
        Try
            Dim dt As New DataTable
            If (txt_MemberCode.Text <> "") Then
                Grp_Address.Visible = False
                grp_ChildrenDetails.Visible = False
                Grp_MemQualification.Visible = False
                grbRSI.Visible = False
                Grp_Entrancefee.Visible = True
                Gpr_Company.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            'txt_PositionHeld.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub btnclub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillUnitNo()
        cmd_RSIDetails.Visible = True
    End Sub

    Private Sub CMD_TRANSFER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SqlString, SQLstr As String
            Dim SatusString As String
            Dim Insert(0) As String
            Dim SqlArray(), Sql(500) As String
            SQLstr = " UPDATE MEMBERMASTER SET Mcode='" & Txt_Newmember.Text & "' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "' "
            'gconnection.dataOperation(2, SqlSTR, "ACCOUNTSSUBLEDGERMASTER")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr

            SQLstr = " UPDATE ACCOUNTSSUBLEDGERMASTER SET slcode='" & Txt_Newmember.Text & "' WHERE SLCODE = '" & Trim(txt_MemberCode.Text) & "' AND ACCODE='" & gDebtors & "'"
            'gconnection.dataOperation(2, SqlSTR, "ACCOUNTSSUBLEDGERMASTER")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr



            SQLstr = " UPDATE journalentry SET slcode='" & Txt_Newmember.Text & "' WHERE SLCODE = '" & Trim(txt_MemberCode.Text) & "' and accountcode='" & gDebtors & "'"
            'gconnection.dataOperation(2, SqlSTR, "journalentry")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr



            SQLstr = " UPDATE subsposting SET mcode='" & Trim(Txt_Newmember.Text) & "' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "journalentry")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr

            SQLstr = " UPDATE memberledger SET mcode='" & Trim(Txt_Newmember.Text) & "' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "journalentry")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr


            SQLstr = " UPDATE MEMDET SET mEM_code='" & Trim(Txt_Newmember.Text) & "' WHERE mem_code = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "MEMDET")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr


            SQLstr = " UPDATE KOT_DET SET mcode='" & Trim(Txt_Newmember.Text) & "' WHERE mcode = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "KOT_DET")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr


            SQLstr = " UPDATE KOT_HDR SET mcode='" & Trim(Txt_Newmember.Text) & "' WHERE mcode = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "KOT_DET")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr


            SQLstr = " UPDATE BILL_HDR SET mcode='" & Trim(Txt_Newmember.Text) & "' WHERE mcode = '" & Trim(txt_MemberCode.Text) & "'"
            'gconnection.dataOperation(2, SQLSTR, "KOT_DET")
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = SQLstr


            gconnection.MoreTrans1(Insert)
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try

        MessageBox.Show("Record UPDATED ", gCompanyAddress(0), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call CmdClear_Click(sender, e)
    End Sub

    Private Sub Txt_Newmember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Newmember.TextChanged
        Dim SQLSTR As String
        Dim DTT As New DataTable
        SQLSTR = "SELECT * FROM MEMBERMASTER WHERE MCODE='" & Txt_Newmember.Text & "'"
        DTT = gconnection.GetValues(SQLSTR)
        If DTT.Rows.Count > 0 Then
            'CMD_TRANSFER.Enabled = False
        Else
            'CMD_TRANSFER.Enabled = True
        End If
    End Sub

    Private Sub Txt_Newmember_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Newmember.Validated
        grp_Entrancefeedetails.Visible = False
        Me.chk_EntranceFee.Checked = True
        If Me.SSgrid_Entfee.DataRowCnt < 0 Then
            MsgBox(" No Records To Save", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, gCompanyAddress(0))
            Me.chk_EntranceFee.Checked = False
            Exit Sub
        Else
            Call FillZoomTable(SSgrid_Entfee, "entrancefee")
        End If
    End Sub

    Private Sub cmd_EntrancefeeOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EntrancefeeOK.Click
        Me.chk_EntranceFee.Checked = False
        Me.grp_Entrancefeedetails.Visible = False
        If gdataset.Tables.Contains("entrancefee") Then
            gdataset.Tables.Remove("entrancefee")
        End If
        chk_EntranceFee.Focus()
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

    Private Sub Rnd_Entrancefeeyes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_Entrancefeeyes.CheckedChanged

    End Sub

    Private Sub Rnd_Entrancefeeyes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rnd_Entrancefeeyes.Click
        grp_Entrancefeedetails.Visible = True
    End Sub

    Private Sub Rnd_EntranceNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_EntranceNo.CheckedChanged

    End Sub

    Private Sub Rnd_EntranceNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rnd_EntranceNo.Click
        grp_Entrancefeedetails.Visible = False
    End Sub


    Private Sub cmd_MemberCode1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_MemberCode1.Validated

    End Sub




    Private Sub txt_ProposerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ProposerCode.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If txt_ProposerCode.Text = "" Then
                    cmd_ProposerCodeHelp_Click(sender, e)
                Else
                    'cbo_Title.Focus()
                    txt_SeconderCode.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub txt_SeconderCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SeconderCode.KeyDown

        Try

            If e.KeyCode = Keys.Enter Then
                If txt_SeconderCode.Text = "" Then
                    cmd_SeconderCodeHelp_Click(sender, e)
                Else
                    'cbo_Title.Focus()
                    TextBox16.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_SeconderCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try

    End Sub

    Private Sub txt_FirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FirstName.KeyPress
        'getAlphanumeric1(e)
        Block_Singlequote(e)

    End Sub

    Private Sub txt_MiddleName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MiddleName.KeyPress
        'getAlphanumeric1(e)
        Block_Singlequote(e)
    End Sub

    Private Sub txt_Surname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Surname.KeyPress
        'getAlphanumeric1(e)
        Block_Singlequote(e)
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

    Private Sub chk_Sports_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Sports.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'chk_Referencedetails.Focus()
        End If
    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click

    End Sub

    Private Sub Cbo_title_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_title.SelectedIndexChanged

    End Sub

    Private Sub Cbo_title_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_title.KeyDown
        TXT_TITLE.Focus()
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Company.Click
        Gpr_Company.Visible = True
        Grp_Entrancefee.Visible = False
        Grp_Address.Visible = False
        grp_ChildrenDetails.Visible = False
        Grp_MemQualification.Visible = False
        grbRSI.Visible = False
        'Grp_Entrancefee.Visible = True
        Grp_AccountsDetails.Visible = False
        grp_Entrancefeedetails.Visible = False

    End Sub

    Private Sub Gpr_Company_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gpr_Company.Enter

    End Sub

    Private Sub Btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Btn_update.Text = "U" Then
        '    lbl_newmember.Visible = True
        '    Txt_Newmember.Visible = True
        '    Btn_update.Text = "C"
        'End If
    End Sub
    Private Sub loadmembertype(ByVal i As Integer)
        Dim j As Integer
        Dim sqlstring, SSQL As String
        Dim SUBCATEGORY As New DataTable
        ssgrid.TypeComboBoxClear(1, i)
        sqlstring = "SELECT Subtypecode,Subtypedesc FROM subcategorymaster WHERE Subtypecode in('ST','LI') and ISNULL(Freeze,'') <> 'Y' ORDER BY Subtypecode ASC"
        gconnection.getDataSet(sqlstring, "Subtypedesc")
        If gdataset.Tables("Subtypedesc").Rows.Count > 0 Then
            For j = 0 To gdataset.Tables("Subtypedesc").Rows.Count - 1
                ssgrid.Col = 1
                ssgrid.Row = i
                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("Subtypedesc").Rows(j).Item("Subtypedesc"))
                ssgrid.TypeComboBoxIndex = j
            Next j
        End If
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(SSQL)
        If SUBCATEGORY.Rows.Count > 0 Then
            CREDITYN = SUBCATEGORY.Rows(0).Item("CREDITLIMITYN")
            'TXT_CATLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
            'TXT_MEMLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
        End If
        If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
            Txt_Replacement.Enabled = True
            Cmd_Replacement.Enabled = True
        Else
            Txt_Replacement.Enabled = False
            Cmd_Replacement.Enabled = False

        End If
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN,ISNULL(VALIDITY,0) AS VALIDITY,ISNULL(TENURES,'') AS TENURES FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(SSQL)
        If SUBCATEGORY.Rows.Count > 0 Then
            'CRED = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMITYN"))
            VALIDITY = SUBCATEGORY.Rows(0).Item("TENURES")
            PERIOD = Val(SUBCATEGORY.Rows(0).Item("VALIDITY"))
            'TXT_MEMLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
        End If

        If VALIDITY = "Y" Then
            chk_EXPDT.Checked = True
            dtp_EXPDT.Value = DateAdd(DateInterval.Month, PERIOD, Now)
            chk_EXPDT.Enabled = False
            dtp_EXPDT.Enabled = False
            'Cmb_Category.Focus()
        Else
            chk_EXPDT.Checked = False
            chk_EXPDT.Enabled = True
            dtp_EXPDT.Enabled = False
            dtp_EXPDT.Value = Now
            'Cmb_Category.Focus()

        End If
    End Sub

    Private Sub loadSalutation(ByVal i As Integer)
        Dim j, k As Integer
        Dim sqlstring As String
        '
        'ssgrid.TypeComboBoxClear(1, i)

        sqlstring = "select code,Name from tbl_titlemaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY code ASC "
        gconnection.getDataSet(sqlstring, "Salutation")
        If gdataset.Tables("Salutation").Rows.Count > 0 Then
            For k = 0 To 10

                ssgrid.TypeComboBoxClear(1, k + 1)
                For j = 0 To gdataset.Tables("Salutation").Rows.Count - 1
                    ssgrid.Col = 1
                    ssgrid.Row = k + 1
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("Salutation").Rows(j).Item("Name"))
                    'MessageBox.Show(Trim(gdataset.Tables("Salutation").Rows(j).Item("Name")))
                    ssgrid.TypeComboBoxIndex = j

                Next j
            Next k

        End If
    End Sub
    Private Sub loadMaritalstatus(ByVal i As Integer)
        Dim j As Integer
        Dim sqlstring As String
        ssgrid.TypeComboBoxClear(7, i)
        sqlstring = "select code,Name from Tbl_MaritalStatusMaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY code ASC "
        gconnection.getDataSet(sqlstring, "Maritalstatus")
        If gdataset.Tables("Salutation").Rows.Count > 0 Then
            For j = 0 To gdataset.Tables("Maritalstatus").Rows.Count - 1
                ssgrid.Col = 7
                ssgrid.Row = i
                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("Maritalstatus").Rows(j).Item("Name"))
                ssgrid.TypeComboBoxIndex = j
            Next j
        End If
    End Sub
    Private Sub ssgrid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.Validated

    End Sub

    Private Sub Cbo_MaritalStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_MaritalStatus.SelectedIndexChanged

        If Cbo_MaritalStatus.Text = "MARRIED" Then
            Sqlstr = "Select Mcode,Mname,MARITAL_STATUS,spouseprefix,spouse,sdob,Wedding_Date from membermaster where MARITAL_STATUS='MARRIED' and MCODE='" & txt_MemberCode.Text & "'"
            gconnection.getDataSet(Sqlstr, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                Gpx_Spouse.Visible = True
                Cbo_Spousesalutation.Text = gdataset.Tables("Membermaster").Rows(0).Item("spouseprefix")
                txt_Spouse.Text = gdataset.Tables("Membermaster").Rows(0).Item("Spouse")
                If (gdataset.Tables("Membermaster").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                    Dtp_Spousedob.Text = ""
                    ChK_SDOB.Checked = False
                Else
                    Dtp_Spousedob.Text = (gdataset.Tables("Membermaster").Rows(0).Item("SDOB"))
                    ChK_SDOB.Checked = True
                End If

                If (gdataset.Tables("Membermaster").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                    dtp_DOW.Text = ""
                    CHK_WDT.Checked = False
                Else
                    dtp_DOW.Text = (gdataset.Tables("Membermaster").Rows(0).Item("wedding_date"))
                    CHK_WDT.Checked = True
                End If
                'DEPENDENT DETAILS 
                Sqlstr = " select ISNULL(prefix,'')AS prefix,ISNULL(mem_code,'') AS MCODE,ISNULL(child_nm,'') AS CNAME,ISNULL(child_dob,'') AS CDOB,ISNULL((relation),'') AS RELATION,ISNULL(maritalstatus,'') AS maritalstatus,dep_bloodgroup,isnull(Sex,'') as Sex,isnull(SpouseName,'')as SpouseName,isnull(membertype,'')as membertype,isnull(studentmember,'')as studentmember,isnull(dep_Doj,'')as dep_Doj,isnull(Religion,'') as Religion,isnull(anniversarydate,'') as anniversarydate,isnull(occupation,'')as occupation,isnull(Panno,0) as Panno,isnull(phone,'') as phone,isnull(mobile,'') as mobile,isnull(emailid,'') as emailid from memdet where type0='CHLD' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                gconnection.getDataSet(Sqlstr, "DeptDet")
                If gdataset.Tables("DeptDet").Rows.Count > 0 Then
                    For I = 0 To gdataset.Tables("DeptDet").Rows.Count - 1
                        With ssgrid
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Row = I + 1
                            ssgrid.Col = 1
                            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("prefix"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 2
                            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("CNAME"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 3
                            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("CDOB")), "yyyy/MM/dd") = "1900/01/01" Then
                                .Text = ""
                            Else
                                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("CDOB")), "dd/MM/yyyy")
                            End If

                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 4
                            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("Sex"))

                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 5
                            If ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "SPOUSE") Then
                                .Text = "SPOUSE"
                            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "SON") Then
                                .Text = "SON"
                            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "DAUGHTER") Then
                                .Text = "DAUGHTER"
                            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "FATHER") Then
                                .Text = "FATHER"
                            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "MOTHER") Then
                                .Text = "MOTHER"
                            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "OTHERS") Then
                                .Text = "OTHERS"
                            End If
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 6
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("SpouseName"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 7
                            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("anniversarydate")), "yyyy/MM/dd") = "1900/01/01" Then
                                .Text = ""
                            Else
                                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("anniversarydate")), "dd/MM/yyyy")
                            End If
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 8
                            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("maritalstatus"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)


                            ssgrid.Col = 9
                            Sqlstr = "SELECT memimage as memimage FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptDet").Rows(I).Item("CNAME") & "'  and type0='chld' "
                            LoadFoto_chld(Sqlstr, I + 1)
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 12
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("dep_bloodgroup"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 13
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("studentmember"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 14
                            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("dep_Doj")), "yyyy/MM/dd") = "1900/01/01" Then
                                .Text = ""
                            Else
                                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("dep_Doj")), "dd/MM/yyyy")
                            End If
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 15
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("membertype"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 16
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("Religion"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)

                            ssgrid.Col = 17
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("occupation"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 18
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("Panno"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 19
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("phone"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 20
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("mobile"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                            ssgrid.Col = 21
                            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("emailid"))
                            Call loadmembertype(I + 1)
                            Call loadSalutation(I + 1)
                            Call loadMaritalstatus(I + 1)
                        End With
                    Next I
                End If
            Else
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                Gpx_Spouse.Visible = True
            End If
        ElseIf Cbo_MaritalStatus.Text <> "MARRIED" Or Cbo_MaritalStatus.Text <> "" Then
            dtp_DOW.Enabled = False
            ChK_SDOB.Checked = False
            CHK_WDT.Checked = False
            txt_Spouse.Text = ""
            Cbo_Spousesalutation.Enabled = False
            Cbo_Spousesalutation.SelectedIndex = -1
            CHK_WDT.Enabled = False
            txt_Spouse.ReadOnly = False
            Gpx_Spouse.Visible = False
            Cbo_Spousesalutation.Enabled = True
            'Call Cbo_MaritalStatus_LostFocus(sender, e)
        End If
        'Cbo_Spousesalutation.Focus()
    End Sub

    Private Sub CHK_DOB_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_DOB.CheckedChanged
        Try
            If CHK_DOB.Checked = True Then
                'txtdob.Visible = False
                'If Format(dtp_DateOfBirth.Value, "dd/MM/yyyy") = "01/01/1900" Then
                '    dtp_DateOfBirth.Value = Format(SYSDATE, "dd/MM/yyyy")
                'End If
                dtp_DOB.Enabled = True
                dtp_DOB.Focus()
            Else
                'txtdob.Text = "__/__/___"
                'txtdob.Visible = True
                'dtp_DOB.Value = Format(CDate("01/01/1900"), "dd/MM/yyyy")
                dtp_DOB.Enabled = False
                CHK_DOJ.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub CHK_DOJ_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_DOJ.CheckedChanged
        If CHK_DOJ.Checked = True Then
            dtp_DOJ.Enabled = True
            dtp_DOJ.Focus()
        Else
            dtp_DOJ.Enabled = False
            If VALIDITY = "Y" Then
                Cbo_designation.Focus()
            Else
                chk_EXPDT.Focus()
            End If

        End If
    End Sub

    Private Sub chk_EXPDT_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_EXPDT.CheckedChanged
        Try
            If chk_EXPDT.Checked = True Then
                dtp_EXPDT.Enabled = True
                dtp_EXPDT.Focus()

            Else
                dtp_EXPDT.Enabled = False
                Cbo_designation.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub ChK_SDOB_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChK_SDOB.CheckedChanged
        If ChK_SDOB.Checked = True Then
            Dtp_Spousedob.Enabled = True
            Dtp_Spousedob.Focus()
        Else
            Dtp_Spousedob.Enabled = False
            CHK_WDT.Focus()
        End If
    End Sub

    Private Sub CHK_WDT_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_WDT.CheckedChanged
        Try
            If CHK_WDT.Checked = True Then
                dtp_DOW.Enabled = True
                dtp_DOW.Focus()

            Else
                dtp_DOW.Enabled = False
                txt_PA_Address1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Cbo_PCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PCity.SelectedIndexChanged
        Sqlstr = " SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_PCity.Text) & "'"
        gconnection.getDataSet(Sqlstr, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            'Txtcode.ReadOnly = True
            'Cbo_PState.Enabled = False

            Cbo_PState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_PCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub

    Private Sub Cbo_PCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_PState.Focus()
            txt_PA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_PState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PState.SelectedIndexChanged

    End Sub

    Private Sub Cbo_PState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PState.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_PCountry.Focus()
        End If
    End Sub

    Private Sub Cbo_PCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PCountry.SelectedIndexChanged

    End Sub

    Private Sub Cbo_PCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_PA_Phone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_Phone.TextChanged

    End Sub

    Private Sub txt_PA_PinCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PA_PinCode.TextChanged

    End Sub

    Private Sub txt_BA_Address2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_Address2.TextChanged

    End Sub

    Private Sub Cbo_BCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_BCity.SelectedIndexChanged
        Sqlstr = " SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_BCity.Text) & "'"
        gconnection.getDataSet(Sqlstr, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            'Txtcode.ReadOnly = True
            'Cbo_PState.Enabled = False

            Cbo_BState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_BCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub

    Private Sub Cbo_BCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_BCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_BState.Focus()
            txt_BA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_BState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_BState.SelectedIndexChanged

    End Sub

    Private Sub Cbo_BState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_BState.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_BCountry.Focus()
        End If
    End Sub

    Private Sub Cbo_BCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_BCountry.SelectedIndexChanged

    End Sub

    Private Sub Cbo_BCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_BCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_PinCode.Focus()
        End If
    End Sub

    Private Sub txt_BA_PinCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_PinCode.TextChanged

    End Sub

    Private Sub txt_BA_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_Email.TextChanged

    End Sub

    Private Sub txt_BA_Email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then

            chk_ContactAddress2.Focus()
        End If
    End Sub

    Private Sub txt_BA_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_MobileNo.TextChanged

    End Sub

    Private Sub txt_BA_MobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_MobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Email.Focus()
        End If
    End Sub

    Private Sub txt_BA_PhoneNo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BA_PhoneNo2.TextChanged

    End Sub

    Private Sub txt_BA_PhoneNo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BA_PhoneNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_MobileNo.Focus()
        End If
    End Sub

    Private Sub Cbo_CCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_CCountry.SelectedIndexChanged

    End Sub

    Private Sub Cbo_CCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_CCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_CCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_CCity.SelectedIndexChanged
        Sqlstr = " SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_CCity.Text) & "'"
        gconnection.getDataSet(Sqlstr, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            'Txtcode.ReadOnly = True
            'Cbo_PState.Enabled = False

            Cbo_CState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_CCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub

    Private Sub Cbo_CCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_CCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_CState.Focus()
            txt_RA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_CState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_CState.SelectedIndexChanged

    End Sub

    Private Sub Cbo_CState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_CState.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_CCountry.Focus()
        End If
    End Sub

    Private Sub Cbo_CCountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_CCountry.KeyPress

    End Sub

    Private Sub txt_RA_PinCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_PinCode.TextChanged

    End Sub

    Private Sub txt_RA_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_Email.TextChanged

    End Sub

    Private Sub txt_RA_Email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_ContactAddress3.Focus()
        End If
    End Sub

    Private Sub Cbo_Spousesalutation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Spousesalutation.SelectedIndexChanged

    End Sub

    Private Sub Cbo_Spousesalutation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_Spousesalutation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Spouse.Focus()
        End If
    End Sub

    Private Sub txt_Spouse_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Spouse.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChK_SDOB.Focus()
        End If
    End Sub

    Private Sub Dtp_Spousedob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Spousedob.ValueChanged

    End Sub

    Private Sub Dtp_Spousedob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtp_Spousedob.KeyDown
        If e.KeyCode = Keys.Enter Then
            CHK_WDT.Focus()
            'dtp_DOW.Focus()
        End If
    End Sub

    Private Sub Cbo_relation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cbo_relation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cbo_MaritalStatus.Focus()
        End If
    End Sub

    Private Sub Cbo_MaritalStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_MaritalStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Cbo_MaritalStatus.Text = "MARRIED" Then
                Cbo_Spousesalutation.Focus()
            Else
                txt_PA_Address1.Focus()
            End If

        End If
    End Sub

    Private Sub txt_RA_PhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_PhoneNo.TextChanged

    End Sub

    Private Sub txt_RA_PhoneNo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_PhoneNo2.TextChanged

    End Sub

    Private Sub txt_RA_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_MobileNo.TextChanged

    End Sub

    Private Sub txt_RA_MobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_RA_MobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Email.Focus()
        End If
    End Sub

    Private Sub Txt_companyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_companyName.TextChanged

    End Sub

    Private Sub Txt_companyName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_companyName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_designation.Focus()
        End If
    End Sub

    Private Sub Cbo_designation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_designation.SelectedIndexChanged

    End Sub

    Private Sub Cbo_designation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_designation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_professional.Focus()
        End If
    End Sub

    Private Sub Cbo_professional_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_professional.SelectedIndexChanged

    End Sub

    Private Sub Cbo_professional_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_professional.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_MEMLIMIT.Focus()
        End If
    End Sub

    Private Sub Txt_Bussinessinfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Bussinessinfo.TextChanged

    End Sub

    Private Sub Txt_Bussinessinfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Bussinessinfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_products.Focus()
        End If
    End Sub

    Private Sub Txt_products_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_products.TextChanged

    End Sub

    Private Sub Txt_products_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_products.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_turnover.Focus()
        End If
    End Sub

    Private Sub Txt_turnover_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_turnover.TextChanged

    End Sub

    Private Sub Txt_turnover_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_turnover.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_AgenttInfo.Focus()
        End If
    End Sub

    Private Sub Txt_AgenttInfo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_AgenttInfo.TextChanged

    End Sub

    Private Sub Txt_AgenttInfo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_AgenttInfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_noofEmpolyee.Focus()
        End If
    End Sub

    Private Sub Txt_AppNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_AppNo.TextChanged

    End Sub

    Private Sub Txt_AppNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_AppNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_pancarno.Focus()
        End If
    End Sub

    Private Sub cmd_SportsOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SportsOk.Click
        Me.grp_SportsIntrested.Visible = False
    End Sub

    Private Sub cmd_SportsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SportsCancel.Click
        Me.grp_SportsIntrested.Visible = False
    End Sub

    Private Sub cmd_EntrancefeeCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_EntrancefeeCancel.Click

    End Sub

    Private Sub SSgrid_Entfee_Advance(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSgrid_Entfee.Advance

    End Sub

    Private Sub SSgrid_Entfee_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSgrid_Entfee.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            SSgrid_Entfee.InsertRows(SSgrid_Entfee.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            SSgrid_Entfee.DeleteRows(SSgrid_Entfee.ActiveRow, 1)
            SSgrid_Entfee.SetActiveCell(1, SSgrid_Entfee.ActiveRow)
        End If
    End Sub

    Private Sub AxfpSpread1_Advance(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_AdvanceEvent) Handles AxfpSpread1.Advance

    End Sub

    Private Sub AxfpSpread1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyDownEvent) Handles AxfpSpread1.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            AxfpSpread1.InsertRows(AxfpSpread1.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            AxfpSpread1.DeleteRows(AxfpSpread1.ActiveRow, 1)
            AxfpSpread1.SetActiveCell(1, AxfpSpread1.ActiveRow)
        End If
    End Sub

    Private Sub Txt_pancarno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_pancarno.TextChanged

    End Sub

    Private Sub Txt_pancarno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_pancarno.KeyDown

        If e.KeyCode = Keys.Enter Then
            Txt_BloodGroup.Focus()
        End If
    End Sub

    Private Sub Txt_BloodGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_BloodGroup.TextChanged

    End Sub

    Private Sub Txt_BloodGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_BloodGroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CreditNumber.Focus()
        End If
    End Sub

    Private Sub txt_CreditNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CreditNumber.TextChanged

    End Sub

    Private Sub txt_CreditNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CreditNumber.KeyPress

    End Sub

    Private Sub txt_CreditNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CreditNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dtp_Appdate.Focus()
        End If
    End Sub

    Private Sub Dtp_Appdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Appdate.ValueChanged

    End Sub

    Private Sub Dtp_Appdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtp_Appdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Specialinfo.Focus()
        End If
    End Sub

    Private Sub Cbo_Spousesalutation_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_Spousesalutation.SelectedValueChanged

    End Sub

    Private Sub Cbo_title_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Cbo_title.DragDrop

    End Sub

    Private Sub Cbo_title_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_title.Validated

    End Sub

    Private Sub Cbo_title_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_title.VisibleChanged

    End Sub

    Private Sub txt_MiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MiddleName.TextChanged

    End Sub

    Private Sub txt_Spouse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Spouse.KeyPress
        Block_Singlequote(e)
        If Cbo_MaritalStatus.Text = "MARRIED" Then
        Else
            If MsgBox("PleaseCheck MaritalSatus!!", MsgBoxStyle.OKCancel, "ok") = MsgBoxResult.OK Then
                txt_Spouse.Text = ""
                txt_Spouse.Clear()
            Else
                txt_Spouse.Text = ""
                txt_Spouse.Clear()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Cbo_MaritalStatus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_MaritalStatus.Click
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            dtp_DOW.Visible = True
            CHK_WDT.Visible = True
        Else
            dtp_DOW.Enabled = False
            CHK_WDT.Enabled = False
            txt_Spouse.ReadOnly = False
            Cbo_Spousesalutation.Enabled = False
        End If
    End Sub

    Private Sub txt_Spouse_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Spouse.TextChanged

    End Sub

    Private Sub Cbo_MaritalStatus_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_MaritalStatus.LostFocus
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            dtp_DOW.Visible = True
            CHK_WDT.Visible = True
            CHK_WDT.Enabled = True
            Cbo_Spousesalutation.Enabled = True
            Gpx_Spouse.Visible = True
        ElseIf Cbo_MaritalStatus.Text = "DIVORCED" Or Cbo_MaritalStatus.Text = "UNMARRIED" Then
            If MsgBox("Do you Want to Delete Spouse Detail", MsgBoxStyle.OKCancel, gCompanyname) = MsgBoxResult.OK Then
                dtp_DOW.Enabled = False
                ChK_SDOB.Checked = False
                CHK_WDT.Checked = False
                txt_Spouse.Text = ""
                Cbo_Spousesalutation.Enabled = False
                Cbo_Spousesalutation.SelectedIndex = -1
                CHK_WDT.Enabled = False
                txt_Spouse.ReadOnly = False
                Gpx_Spouse.Visible = False
                Cbo_Spousesalutation.Enabled = True
                Exit Sub
            End If
        ElseIf Cbo_MaritalStatus.Text <> "MARRIED" Or Cbo_MaritalStatus.Text <> "DIVORCED" Or Cbo_MaritalStatus.Text <> "" Or Cbo_MaritalStatus.Text <> "UNMARRIED" Then
            If MsgBox("Do you Want to Delete Spouse and Dependent Details ", MsgBoxStyle.OKCancel, gCompanyname) = MsgBoxResult.OK Then
                dtp_DOW.Enabled = False
                ChK_SDOB.Checked = False
                CHK_WDT.Checked = False
                txt_Spouse.Text = ""
                Cbo_Spousesalutation.Enabled = False
                Cbo_Spousesalutation.SelectedIndex = -1
                CHK_WDT.Enabled = False
                txt_Spouse.ReadOnly = False
                Gpx_Spouse.Visible = False
                Cbo_Spousesalutation.Enabled = True
                ssgrid.ClearRange(1, 1, -1, -1, True)
            End If

        End If
        'txt_PA_Address1.Focus()
    End Sub

    Private Sub dtp_DOJ_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_DOJ.Validated
        If dtp_DOJ.Value < dtp_DOB.Value Then
            MsgBox("Date of join Less then the Date of Birth", MsgBoxStyle.Information, gCompanyname)
            'Call CmdClear_Click(sender, e)

            Exit Sub
        End If
    End Sub

    Private Sub cmd_CorporateCodeHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CorporateCodeHelp.Click
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
            Txt_CorporateCode.Text = Trim(vform.keyfield & "")
            'txt_CorporateName.Select()
            'txt_CorporateCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Cbo_MaritalStatus_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_MaritalStatus.Validated
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            Sqlstr = "Select Mcode,Mname,MARITAL_STATUS,spouseprefix,spouse,sdob,Wedding_Date from membermaster where MARITAL_STATUS='MARRIED' and MCODE='" & txt_MemberCode.Text & "'"
            gconnection.getDataSet(Sqlstr, "MemMst")
            If gdataset.Tables("MemMst").Rows.Count > 0 Then
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                Gpx_Spouse.Visible = True
                Cbo_Spousesalutation.Text = gdataset.Tables("MemMst").Rows(0).Item("spouseprefix")
                txt_Spouse.Text = gdataset.Tables("MemMst").Rows(0).Item("Spouse")
                If (gdataset.Tables("MemMst").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                    Dtp_Spousedob.Text = ""
                    ChK_SDOB.Checked = False
                Else
                    Dtp_Spousedob.Text = (gdataset.Tables("MemMst").Rows(0).Item("SDOB"))
                    ChK_SDOB.Checked = True
                End If

                If (gdataset.Tables("MemMst").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                    dtp_DOW.Text = ""
                    CHK_WDT.Checked = False
                Else
                    dtp_DOW.Text = (gdataset.Tables("MemMst").Rows(0).Item("wedding_date"))
                    CHK_WDT.Checked = True
                End If
            Else
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                Gpx_Spouse.Visible = True
            End If
        End If

    End Sub

    Private Sub txt_PA_Email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Email.KeyPress

    End Sub

    Private Sub txt_BA_Email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_Email.KeyPress

    End Sub

    Private Sub txt_RA_Address3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_RA_Address3.TextChanged

    End Sub

    Private Sub txt_PA_Mobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Mobile.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_BA_MobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_MobileNo.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_RA_MobileNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_MobileNo.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_PA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_PinCode.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_BA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_PinCode.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_RA_Email_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_Email.KeyPress

    End Sub

    Private Sub txt_PA_Phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Phone.KeyPress
        getNumeric(e)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txt_BA_PhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_PhoneNo.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_RA_PhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_PhoneNo.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_PA_Phone2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PA_Phone2.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_BA_PhoneNo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BA_PhoneNo2.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_RA_PhoneNo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_PhoneNo2.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_RA_PinCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_RA_PinCode.KeyPress
        getNumeric(e)
    End Sub

    Private Sub Txt_CorporateCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_CorporateCode.TextChanged

    End Sub

    Private Sub Txt_CorporateCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_CorporateCode.Validated

    End Sub

    Private Sub Txt_CorporateCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CorporateCode.KeyPress
        Dim SUBCATEGORY As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember From SubCategorymaster where Corporatemember='Y' and subtypedesc='" & Cmb_Category.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            Txt_CorporateCode.ReadOnly = False
            CorporateYN = True
        Else
            Txt_CorporateCode.ReadOnly = True
            MessageBox.Show("Can't Match Corporate Code and Category", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_CorporateCode.Text = ""
            CorporateYN = False

        End If
    End Sub

    Private Sub txt_ProposerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ProposerCode.Validated
        Dim I, J As Integer

        Sqlstr = " SELECT isnull(mcode,'')as mcode,isnull(mname,'') as Mname FROM membermaster WHERE mcode='" & txt_ProposerCode.Text & "'"
        gconnection.getDataSet(Sqlstr, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            txt_ProposerCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            txt_ProposedName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))
        End If

    End Sub

    Private Sub txt_SeconderCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SeconderCode.Validated
        Dim I, J As Integer

        Sqlstr = " SELECT isnull(mcode,'')as mcode,isnull(mname,'') as Mname FROM membermaster WHERE mcode='" & txt_SeconderCode.Text & "'"
        gconnection.getDataSet(Sqlstr, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            txt_SeconderCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            txt_SeconderName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))
        End If

    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Replacement.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster "
            M_WhereCondition = " where MEMBERTYPECODE IN ('3') and ISNULL(CURENTSTATUS,'') NOT IN('ACTIVE','LIVE') "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  MEMBERSHIP NO     |           MEMBER NAME                  "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Txt_Replacement.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")
                Call Txt_Replacement_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub Txt_Replacement_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SeconderCode.Validated
        Dim I, J As Integer

        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(RNO,'') AS RNO FROM membermaster where MEMBERTYPECODE IN ('3') and ISNULL(CURENTSTATUS,'') NOT IN('ACTIVE','LIVE') AND MCODE='" & Txt_Replacement.Text & "'"
        gconnection.getDataSet(gSQLString, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            Txt_Replacement.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            Txt_Rno.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RNO"))
            'txt_SeconderName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))
        End If

    End Sub

    Private Sub Txt_Replacement_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Replacement.TextChanged

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Try
        '    Dim sqlstring As String
        '    Dim Viewer As New ReportViwer
        '    Dim r As New Cry_MemberMaster_cpc1
        '    Dim txtobj1 As TextObject
        '    Sqlstr = "select * from MM_membermaster where mcode=   '" & txt_MemberCode.Text & "'"
        '    Sqlstr1 = "SELECT * FROM MEMDET WHERE MEM_CODE='" & txt_MemberCode.Text & "'"
        '    Call Viewer.GetDetails1(Sqlstr, "MM_MEMBERMASTER", r)
        '    Call Viewer.GetDetails1(Sqlstr1, "MM_MEMDET", r)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '    txtobj1.Text = UCase(gCompanyname)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text36")
        '    txtobj1.Text = UCase(gCompanyAddress(1))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text38")
        '    txtobj1.Text = UCase(gCompanyAddress(2))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text37")
        '    txtobj1.Text = UCase(gCompanyAddress(3))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text16")
        '    txtobj1.Text = UCase(gUsername)
        '    Viewer.Show()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    Exit Sub
        'End Try
        Try
            Dim sqlstring, SQLSTR2 As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_MemberMaster_cpc1
            Dim txtobj1 As TextObject
            SQLSTR2 = "EXEC MEM_IMAGE '" & txt_MemberCode.Text & "'"
            gconnection.ExcuteStoreProcedure(SQLSTR2)
            Sqlstr = "select * from MM_membermaster where mcode=   '" & txt_MemberCode.Text & "'"
            Sqlstr1 = "SELECT * FROM MEMDEPIMAGE WHERE MCODE='" & txt_MemberCode.Text & "'"
            Call Viewer.GetDetails1(Sqlstr, "MM_MEMBERMASTER", r)
            Call Viewer.GetDetails1(Sqlstr1, "MEMDEPIMAGE", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text38")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub chk_male_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_male.Click
        If chk_male.Checked = True Then
            chk_female.Checked = False
        Else
            chk_female.Checked = True
        End If
    End Sub

    Private Sub chk_female_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_female.Click
        If chk_female.Checked = True Then
            chk_male.Checked = False
        Else
            chk_male.Checked = True
        End If
    End Sub

    Private Sub TXT_MEMLIMIT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_MEMLIMIT.TextChanged

    End Sub

    Private Sub TXT_MEMLIMIT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_MEMLIMIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_MaritalStatus.Focus()
        End If

    End Sub

    Private Sub chk_ContactAddress1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_ContactAddress1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Address1.Focus()
        End If

    End Sub

    Private Sub chk_ContactAddress2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_ContactAddress2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address1.Focus()
        End If

    End Sub

    Private Sub chk_ContactAddress3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_ContactAddress3.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdAdd.Focus()
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMG_SPOUSESIGN.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    IMG_SPOUSESIGN.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_SpouseImg = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub txt_MemberCode_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.MouseEnter

    End Sub

    Private Sub cmd_MemberNo1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmd_MemberNo1.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Cbo_MaritalStatus.Text = "MARRIED" Then
        '        Cbo_Spousesalutation.Focus()
        '    Else
        '        txt_PA_Address1.Focus()
        '    End If

        'End If

        If e.KeyCode = Keys.Enter Then
            Cbo_title.Focus()
        End If

    End Sub

    Private Sub Cmb_Category_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Category.KeyPress

    End Sub
End Class
