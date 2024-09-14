Public Class MemberMDI
    Inherits System.Windows.Forms.Form
    Dim globalclass As New globalclass
    Dim gconnection As New globalclass
    Dim sqlString As String
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents submnu_MemberCorporate As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_MemberSubscription As System.Windows.Forms.MenuItem
    Friend WithEvents menu_Master As System.Windows.Forms.MenuItem
    Friend WithEvents menu_Transaction As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_StatusConversion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents SubMenu_AddressList As System.Windows.Forms.MenuItem
    Friend WithEvents SubMenu_MemberStatusList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_Affiliated As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_Directory As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SubMenu_SubscriptionPosting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuSubscriptionTagging As System.Windows.Forms.MenuItem
    Friend WithEvents MenuBillingSetup As System.Windows.Forms.MenuItem
    Friend WithEvents MenuCategoryConversion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMUCPosting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAddlChargesPosting As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMemberStrengthList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuBirthdayAnniversaryWiseList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMembersStatusHistory As System.Windows.Forms.MenuItem
    Friend WithEvents MenuDependentList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAffiliatedClubList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuSubscriptionList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMUCList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMemberDetailOutStanding As System.Windows.Forms.MenuItem
    Friend WithEvents MenuOutstandingList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMonthlyBill As System.Windows.Forms.MenuItem
    Friend WithEvents MenuBillRegister As System.Windows.Forms.MenuItem
    Friend WithEvents MenuReminderLetter As System.Windows.Forms.MenuItem
    Friend WithEvents MenuMembersReminderHistory As System.Windows.Forms.MenuItem
    Friend WithEvents MenuUnitMaster As System.Windows.Forms.MenuItem
    Friend WithEvents MenuRankMaster As System.Windows.Forms.MenuItem
    Friend WithEvents MenuCellingMaster As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAddlChargesPL As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents UnitWiseBillMenu As System.Windows.Forms.MenuItem
    Friend WithEvents MenuUnitWiseMemberADD As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents submenu_rank As System.Windows.Forms.MenuItem
    Friend WithEvents Submenu_armservice As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents Submenu_facility As System.Windows.Forms.MenuItem
    Friend WithEvents Submenu_remainder As System.Windows.Forms.MenuItem
    Friend WithEvents Sub_menufaacility As System.Windows.Forms.MenuItem
    Friend WithEvents Submenu_ledger As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_receipts As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MNU_accountagging As System.Windows.Forms.MenuItem
    Friend WithEvents MNU_Facilitymaster As System.Windows.Forms.MenuItem
    Friend WithEvents MNU_SUBSCRIPTION As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Public WithEvents submnu_MemberCategory As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberMDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.menu_Master = New System.Windows.Forms.MenuItem
        Me.submnu_MemberCategory = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.submnu_MemberCorporate = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.submnu_MemberSubscription = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuCellingMaster = New System.Windows.Forms.MenuItem
        Me.MenuUnitMaster = New System.Windows.Forms.MenuItem
        Me.MenuRankMaster = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.Mnu_Affiliated = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.Submenu_facility = New System.Windows.Forms.MenuItem
        Me.MenuSubscriptionTagging = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuBillingSetup = New System.Windows.Forms.MenuItem
        Me.MNU_Facilitymaster = New System.Windows.Forms.MenuItem
        Me.menu_Transaction = New System.Windows.Forms.MenuItem
        Me.MenuCategoryConversion = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.submnu_StatusConversion = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.SubMenu_SubscriptionPosting = New System.Windows.Forms.MenuItem
        Me.Submenu_remainder = New System.Windows.Forms.MenuItem
        Me.MenuMUCPosting = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuAddlChargesPosting = New System.Windows.Forms.MenuItem
        Me.mnu_receipts = New System.Windows.Forms.MenuItem
        Me.MNU_accountagging = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.SubMenu_AddressList = New System.Windows.Forms.MenuItem
        Me.Mnu_Directory = New System.Windows.Forms.MenuItem
        Me.SubMenu_MemberStatusList = New System.Windows.Forms.MenuItem
        Me.MenuMemberStrengthList = New System.Windows.Forms.MenuItem
        Me.MenuBirthdayAnniversaryWiseList = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuMembersStatusHistory = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuDependentList = New System.Windows.Forms.MenuItem
        Me.submenu_rank = New System.Windows.Forms.MenuItem
        Me.Submenu_armservice = New System.Windows.Forms.MenuItem
        Me.MenuUnitWiseMemberADD = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Submenu_ledger = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuMonthlyBill = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MNU_SUBSCRIPTION = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuMembersReminderHistory = New System.Windows.Forms.MenuItem
        Me.MenuSubscriptionList = New System.Windows.Forms.MenuItem
        Me.MenuOutstandingList = New System.Windows.Forms.MenuItem
        Me.Sub_menufaacility = New System.Windows.Forms.MenuItem
        Me.MenuAffiliatedClubList = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuMUCList = New System.Windows.Forms.MenuItem
        Me.MenuMemberDetailOutStanding = New System.Windows.Forms.MenuItem
        Me.MenuBillRegister = New System.Windows.Forms.MenuItem
        Me.MenuReminderLetter = New System.Windows.Forms.MenuItem
        Me.MenuAddlChargesPL = New System.Windows.Forms.MenuItem
        Me.UnitWiseBillMenu = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menu_Master, Me.menu_Transaction, Me.MenuItem4, Me.MenuItem12, Me.MenuItem10})
        '
        'menu_Master
        '
        Me.menu_Master.Index = 0
        Me.menu_Master.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_MemberCategory, Me.MenuItem29, Me.submnu_MemberCorporate, Me.MenuItem44, Me.MenuItem6, Me.submnu_MemberSubscription, Me.MenuItem8, Me.MenuItem3, Me.MenuItem38, Me.MenuItem34, Me.MenuItem31, Me.MenuItem20, Me.MenuItem43, Me.MenuItem39, Me.MenuItem21, Me.MenuCellingMaster, Me.MenuUnitMaster, Me.MenuRankMaster, Me.MenuItem9, Me.Mnu_Affiliated, Me.MenuItem41, Me.MenuItem18, Me.Submenu_facility, Me.MenuSubscriptionTagging, Me.MenuItem33, Me.MenuBillingSetup, Me.MNU_Facilitymaster})
        Me.menu_Master.Text = "&Master                                              "
        '
        'submnu_MemberCategory
        '
        Me.submnu_MemberCategory.Index = 0
        Me.submnu_MemberCategory.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem27, Me.MenuItem26, Me.MenuItem28})
        Me.submnu_MemberCategory.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.submnu_MemberCategory.Text = "Member &Category"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Category Master"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "SubCategory Master"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Text = "-"
        '
        'submnu_MemberCorporate
        '
        Me.submnu_MemberCorporate.Index = 2
        Me.submnu_MemberCorporate.Text = "Member &Subscription "
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 3
        Me.MenuItem44.Text = "Subscriptiontype Master"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'submnu_MemberSubscription
        '
        Me.submnu_MemberSubscription.Index = 5
        Me.submnu_MemberSubscription.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.submnu_MemberSubscription.Text = "Member &Master"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 6
        Me.MenuItem8.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Text = "Salutation Master"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 8
        Me.MenuItem38.Text = "Status Master"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 9
        Me.MenuItem34.Text = "MaritalStatus Master"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 10
        Me.MenuItem31.Text = "Religion Master"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 11
        Me.MenuItem20.Text = "Designation Master"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 12
        Me.MenuItem43.Text = "Professional Master"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 13
        Me.MenuItem39.Text = "Reason Master"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 14
        Me.MenuItem21.Text = "-"
        '
        'MenuCellingMaster
        '
        Me.MenuCellingMaster.Index = 15
        Me.MenuCellingMaster.Text = "Country Master"
        '
        'MenuUnitMaster
        '
        Me.MenuUnitMaster.Index = 16
        Me.MenuUnitMaster.Text = "State Master"
        '
        'MenuRankMaster
        '
        Me.MenuRankMaster.Index = 17
        Me.MenuRankMaster.Text = "City Master"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 18
        Me.MenuItem9.Text = "-"
        '
        'Mnu_Affiliated
        '
        Me.Mnu_Affiliated.Index = 19
        Me.Mnu_Affiliated.Text = "Affiliated Club Master"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 20
        Me.MenuItem41.Text = "Corporate Master"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 21
        Me.MenuItem18.Text = "-"
        '
        'Submenu_facility
        '
        Me.Submenu_facility.Index = 22
        Me.Submenu_facility.Text = "Facility Master"
        '
        'MenuSubscriptionTagging
        '
        Me.MenuSubscriptionTagging.Index = 23
        Me.MenuSubscriptionTagging.Text = "Subscription Tagging"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 24
        Me.MenuItem33.Text = "-"
        Me.MenuItem33.Visible = False
        '
        'MenuBillingSetup
        '
        Me.MenuBillingSetup.Index = 25
        Me.MenuBillingSetup.Text = "Billing Setup"
        Me.MenuBillingSetup.Visible = False
        '
        'MNU_Facilitymaster
        '
        Me.MNU_Facilitymaster.Index = 26
        Me.MNU_Facilitymaster.Text = "Facility Master"
        '
        'menu_Transaction
        '
        Me.menu_Transaction.Index = 1
        Me.menu_Transaction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuCategoryConversion, Me.MenuItem19, Me.MenuItem17, Me.submnu_StatusConversion, Me.MenuItem37, Me.MenuItem24, Me.MenuItem36, Me.SubMenu_SubscriptionPosting, Me.Submenu_remainder, Me.MenuMUCPosting, Me.MenuItem7, Me.MenuAddlChargesPosting, Me.mnu_receipts, Me.MNU_accountagging, Me.MenuItem35})
        Me.menu_Transaction.Text = "&Transaction                           "
        '
        'MenuCategoryConversion
        '
        Me.MenuCategoryConversion.Index = 0
        Me.MenuCategoryConversion.Text = "Category Conversion"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Text = "Member Transfer "
        Me.MenuItem17.Visible = False
        '
        'submnu_StatusConversion
        '
        Me.submnu_StatusConversion.Index = 3
        Me.submnu_StatusConversion.Text = "Membership Status Conversion"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 4
        Me.MenuItem37.Text = "Member Activation Conversion "
        Me.MenuItem37.Visible = False
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        Me.MenuItem36.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem36.Text = "Subscription Receipts"
        Me.MenuItem36.Visible = False
        '
        'SubMenu_SubscriptionPosting
        '
        Me.SubMenu_SubscriptionPosting.Index = 7
        Me.SubMenu_SubscriptionPosting.Text = "Subscription Posting"
        '
        'Submenu_remainder
        '
        Me.Submenu_remainder.Index = 8
        Me.Submenu_remainder.Text = "Reminder Letter"
        '
        'MenuMUCPosting
        '
        Me.MenuMUCPosting.Index = 9
        Me.MenuMUCPosting.Text = "MUC Posting"
        Me.MenuMUCPosting.Visible = False
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "-"
        '
        'MenuAddlChargesPosting
        '
        Me.MenuAddlChargesPosting.Index = 11
        Me.MenuAddlChargesPosting.Text = "Addl. Charges Posting "
        Me.MenuAddlChargesPosting.Visible = False
        '
        'mnu_receipts
        '
        Me.mnu_receipts.Index = 12
        Me.mnu_receipts.Text = "Receipts And Payments"
        '
        'MNU_accountagging
        '
        Me.MNU_accountagging.Index = 13
        Me.MNU_accountagging.Text = "Account Tagging"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 14
        Me.MenuItem35.Text = "Month Bill Tagging"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.SubMenu_AddressList, Me.Mnu_Directory, Me.SubMenu_MemberStatusList, Me.MenuMemberStrengthList, Me.MenuBirthdayAnniversaryWiseList, Me.MenuItem32, Me.MenuMembersStatusHistory, Me.MenuItem11, Me.MenuDependentList, Me.submenu_rank, Me.Submenu_armservice, Me.MenuUnitWiseMemberADD, Me.MenuItem1, Me.Submenu_ledger, Me.MenuItem14, Me.MenuMonthlyBill, Me.MenuItem15, Me.MNU_SUBSCRIPTION, Me.MenuItem16, Me.MenuMembersReminderHistory, Me.MenuSubscriptionList, Me.MenuOutstandingList, Me.Sub_menufaacility, Me.MenuAffiliatedClubList, Me.MenuItem25, Me.MenuMUCList, Me.MenuMemberDetailOutStanding, Me.MenuBillRegister, Me.MenuReminderLetter, Me.MenuAddlChargesPL, Me.UnitWiseBillMenu, Me.MenuItem2, Me.MenuItem5})
        Me.MenuItem4.Text = "&Reports                               "
        '
        'SubMenu_AddressList
        '
        Me.SubMenu_AddressList.Index = 0
        Me.SubMenu_AddressList.Text = "Address List Details"
        '
        'Mnu_Directory
        '
        Me.Mnu_Directory.Index = 1
        Me.Mnu_Directory.Text = "Member Directory"
        '
        'SubMenu_MemberStatusList
        '
        Me.SubMenu_MemberStatusList.Index = 2
        Me.SubMenu_MemberStatusList.Text = "Member Status"
        '
        'MenuMemberStrengthList
        '
        Me.MenuMemberStrengthList.Index = 3
        Me.MenuMemberStrengthList.Text = "Member Details"
        Me.MenuMemberStrengthList.Visible = False
        '
        'MenuBirthdayAnniversaryWiseList
        '
        Me.MenuBirthdayAnniversaryWiseList.Index = 4
        Me.MenuBirthdayAnniversaryWiseList.Text = "Birthday List"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 5
        Me.MenuItem32.Text = "Corporate List"
        '
        'MenuMembersStatusHistory
        '
        Me.MenuMembersStatusHistory.Index = 6
        Me.MenuMembersStatusHistory.Text = "Members Status History"
        Me.MenuMembersStatusHistory.Visible = False
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 7
        Me.MenuItem11.Text = "-"
        '
        'MenuDependentList
        '
        Me.MenuDependentList.Index = 8
        Me.MenuDependentList.Text = "Dependent List"
        '
        'submenu_rank
        '
        Me.submenu_rank.Index = 9
        Me.submenu_rank.Text = "Rankwise List"
        Me.submenu_rank.Visible = False
        '
        'Submenu_armservice
        '
        Me.Submenu_armservice.Index = 10
        Me.Submenu_armservice.Text = "ArmServices Report"
        Me.Submenu_armservice.Visible = False
        '
        'MenuUnitWiseMemberADD
        '
        Me.MenuUnitWiseMemberADD.Index = 11
        Me.MenuUnitWiseMemberADD.Text = "Unit Wise Member/Address"
        Me.MenuUnitWiseMemberADD.Visible = False
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 12
        Me.MenuItem1.Text = "-"
        '
        'Submenu_ledger
        '
        Me.Submenu_ledger.Index = 13
        Me.Submenu_ledger.Text = "Member Ledger"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 14
        Me.MenuItem14.Text = "-"
        '
        'MenuMonthlyBill
        '
        Me.MenuMonthlyBill.Index = 15
        Me.MenuMonthlyBill.Text = "Monthly Bill Detail - Summary"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 16
        Me.MenuItem15.Text = "-"
        '
        'MNU_SUBSCRIPTION
        '
        Me.MNU_SUBSCRIPTION.Index = 17
        Me.MNU_SUBSCRIPTION.Text = "Subscription Details List"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 18
        Me.MenuItem16.Text = "-"
        '
        'MenuMembersReminderHistory
        '
        Me.MenuMembersReminderHistory.Index = 19
        Me.MenuMembersReminderHistory.Text = "Members Reminder History"
        Me.MenuMembersReminderHistory.Visible = False
        '
        'MenuSubscriptionList
        '
        Me.MenuSubscriptionList.Index = 20
        Me.MenuSubscriptionList.Text = "Subscription List"
        Me.MenuSubscriptionList.Visible = False
        '
        'MenuOutstandingList
        '
        Me.MenuOutstandingList.Index = 21
        Me.MenuOutstandingList.Text = "Outstanding List"
        Me.MenuOutstandingList.Visible = False
        '
        'Sub_menufaacility
        '
        Me.Sub_menufaacility.Index = 22
        Me.Sub_menufaacility.Text = "Facility Details Report "
        '
        'MenuAffiliatedClubList
        '
        Me.MenuAffiliatedClubList.Index = 23
        Me.MenuAffiliatedClubList.Text = "Affiliated Club List"
        Me.MenuAffiliatedClubList.Visible = False
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 24
        Me.MenuItem25.Text = "-"
        Me.MenuItem25.Visible = False
        '
        'MenuMUCList
        '
        Me.MenuMUCList.Index = 25
        Me.MenuMUCList.Text = "MUC List"
        Me.MenuMUCList.Visible = False
        '
        'MenuMemberDetailOutStanding
        '
        Me.MenuMemberDetailOutStanding.Index = 26
        Me.MenuMemberDetailOutStanding.Text = "Member Detail/Outstanding"
        '
        'MenuBillRegister
        '
        Me.MenuBillRegister.Index = 27
        Me.MenuBillRegister.Text = "Bill Register"
        Me.MenuBillRegister.Visible = False
        '
        'MenuReminderLetter
        '
        Me.MenuReminderLetter.Index = 28
        Me.MenuReminderLetter.Text = "Reminder Letter"
        Me.MenuReminderLetter.Visible = False
        '
        'MenuAddlChargesPL
        '
        Me.MenuAddlChargesPL.Index = 29
        Me.MenuAddlChargesPL.Text = "Addl. Charges posting List"
        Me.MenuAddlChargesPL.Visible = False
        '
        'UnitWiseBillMenu
        '
        Me.UnitWiseBillMenu.Index = 30
        Me.UnitWiseBillMenu.Text = "Unit Wise Bill"
        Me.UnitWiseBillMenu.Visible = False
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 31
        Me.MenuItem2.Text = "Unit Wise Outstanding"
        Me.MenuItem2.Visible = False
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 32
        Me.MenuItem5.Text = "Unit Wise Collection"
        Me.MenuItem5.Visible = False
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem22})
        Me.MenuItem12.Text = "Administrator                         "
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Select Company"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30})
        Me.MenuItem22.Text = "Admin Report"
        Me.MenuItem22.Visible = False
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "Monthly Report"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Text = "&Exit     "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(848, -8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(176, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'MemberMDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 521)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MemberMDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLUB MEMBER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub submnu_MemberCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_MemberCategory.Click
        'GmoduleName = "Member Category"
        'Dim objMemberCategory As New frmMemberCategory
        'If categorybool = False And submnu_MemberCategory.Checked = True Then
        '    objMemberCategory.Show()
        '    objMemberCategory.MdiParent = Me
        '    submnu_MemberCategory.Checked = True
        '    Exit Sub
        'End If
        'If submnu_MemberCategory.Checked = True Then
        '    Exit Sub
        'End If
        'objMemberCategory.Show()
        'objMemberCategory.MdiParent = Me
        'submnu_MemberCategory.Checked = True
    End Sub
    Private Sub submnu_MemberSubscription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_MemberSubscription.Click
        GmoduleName = "MEMBER MASTER"
        Try
            Dim objMemberMaster As New mem
            objMemberMaster.MdiParent = Me
            objMemberMaster.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub submnu_MemberMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Corporate Member"
        Dim objMemberCorporate As New frmMemberCorporate
        If corporatebool = False And submnu_MemberCorporate.Checked = True Then
            objMemberCorporate.Show()
            objMemberCorporate.MdiParent = Me
            submnu_MemberCorporate.Checked = True
            Exit Sub
        End If
        If submnu_MemberCorporate.Checked = True Then
            Exit Sub
        End If
        objMemberCorporate.Show()
        objMemberCorporate.MdiParent = Me
        submnu_MemberCorporate.Checked = True
    End Sub
    Public Sub MEMBERSTATUS()
        Dim SQLSTRING As String
        SQLSTRING = " EXEC MEMBERSTATUS_CHECKING "
        gconnection.ExcuteStoreProcedure(SQLSTRING)
    End Sub
    Private Sub MemberMDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gCompanyname = "STERLING CLUB" Or gCompanyname = "STRC" Or gCompanyname = "RAILWAY OFFICERS CLUB" Then
            mnu_receipts.Visible = True
        Else
            mnu_receipts.Visible = False
        End If
        Me.Text = Trim(gCompanyname) & "[ MEMBER MAINTENANCE MODULE ]" & Trim(CStr(Format(gFinancialyearStart, "dd-MM-yyyy"))) & "-" & Trim(CStr(Format(gFinancialyearEnding, "dd-MM-yyyy"))) & " ] User Name: " & CStr(gUsername)

        AppPath = Application.StartupPath
        Shell("CLEAR.BAT", AppWinStyle.Hide)
        ERPExpiry()
        GetServe()

        Dim ssql, CompanyName As String
        Dim tb As New DataTable
        ssql = "select * from accountsSetUp "
        tb = gconnection.GetValues(ssql)
        If tb.Rows.Count > 0 Then
            gDebtors = tb.Rows(0).Item("SdrsCode")
            gDebdesc = tb.Rows(0).Item("SdrsDesc")
            gCreditors = tb.Rows(0).Item("SCrsCode")
        End If
        ' Try
        Me.Text = Trim(gCompanyname) & "[ MEMBER MAINTENANCE MODULE ]" & Trim(CStr(Format(gFinancialyearStart, "dd-MM-yyyy"))) & "-" & Trim(CStr(Format(gFinancialyearEnding, "dd-MM-yyyy"))) & " ] User Name: " & CStr(gUsername)
        AppPath = Application.StartupPath
        MDIParentobj = Me
        Dim totmenu As Integer
        totmenu = 0
        Call menublock()
        Dim i, j, k, ckhmn, ckhmn1 As Integer
        For i = 0 To MainMenu1.MenuItems.Count - 2
            ckhmn1 = MainMenu1.MenuItems(i).MenuItems.Count()
            If ckhmn1 <> 0 Then
                For j = 0 To MainMenu1.MenuItems(i).MenuItems.Count() - 1
                    ckhmn = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count()
                    If ckhmn <> 0 Then
                        For k = 0 To MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                            totmenu = totmenu + 1
                        Next
                    Else
                        totmenu = totmenu + 1
                    End If
                Next
            Else
                totmenu = totmenu + 1
            End If
        Next
        gconnection.getDataSet("select count(*) from modulemaster Where PackageName='MEMBER'", "chk")
        If gdataset.Tables("chk").Rows.Count <> totmenu Then
            gconnection.ExcuteStoreProcedure("delete from modulemaster Where PackageName='MEMBER'")
            Call checkmenulist()
        End If
        If gUserCategory = "S" Or gUserCategory = "A" Then
            Call menuclear()
        Else
            Call relemenu()
        End If
        ' Call MEMBERSTATUS()
        '   Catch ex As Exception
        ' MsgBox("Error Found While Loading! Bcoz " & ex.Message.ToString, MsgBoxStyle.Critical, "Error!")
        '  End Try
    End Sub

    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = False
            End If
        Next
    End Sub

    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        ds = gconnection.getdata("select * from useradmin where username = '" & Trim(gUsername) & "' and MainGroup='MEMBER'", "user")
        If ds.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To ds.Tables("user").Rows.Count - 1
                With ds.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub

    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = True
            End If
        Next
    End Sub

    Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = MainMenu1.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = MainMenu1.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                If MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Visible = True And MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text <> "-" Then
                                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','MEMBER')"
                                    ReDim Preserve vsql(vsql.Length)
                                End If
                            Next
                        Else
                            If MainMenu1.MenuItems(i).MenuItems(j).Visible = True And MainMenu1.MenuItems(i).MenuItems(j).Text <> "-" Then
                                vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','MEMBER')"
                                ReDim Preserve vsql(vsql.Length)
                            End If
                        End If
                    Next
                Else
                    If MainMenu1.MenuItems(i).Visible = True And MainMenu1.MenuItems(i).Text <> "-" Then
                        vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','MEMBER')"
                        ReDim Preserve vsql(vsql.Length)
                    End If
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans1(vsql)
        End If
    End Sub

    Private Sub menu_Master_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_Master.Select
        If categorybool = False Then
            submnu_MemberCategory.Checked = False
        End If
        If corporatebool = False Then
            submnu_MemberCorporate.Checked = False
        End If
        If supscriptionbool = False Then
            submnu_MemberSubscription.Checked = False
        End If
    End Sub
    Private Sub submnu_PODdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "POD details"
        Dim objPODdetails As New PODdetails
        objPODdetails.MdiParent = Me
        objPODdetails.Show()

    End Sub
    Private Sub submnu_PhotoIddetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Photo Id details"
        Dim objPhotoIDdetails As New PhotoIDdetails
        objPhotoIDdetails.Show()
        objPhotoIDdetails.MdiParent = Me
        submnu_MemberCategory.Checked = True
        Exit Sub
    End Sub
    Private Sub menu_Transaction_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_Transaction.Select
        If statusconversionbool = False Then
            submnu_StatusConversion.Checked = False
        End If
    End Sub
    Private Sub submnu_SubscriptionTagging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Subscription Tagging"
        Dim objSubscriptionTagging As New SubscriptionTagging
        If subscriptiontaggingbool = False Then
            objSubscriptionTagging.Show()
            objSubscriptionTagging.MdiParent = Me
            Exit Sub
        End If
        objSubscriptionTagging.Show()
        objSubscriptionTagging.MdiParent = Me
    End Sub
    Private Sub submnu_StatusConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_StatusConversion.Click
        GmoduleName = "Member Status Conversion"
        Dim objStatusconversion As New Statusconversion1
        'If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
        '    objStatusconversion.Show()
        '    objStatusconversion.MdiParent = Me
        '    submnu_StatusConversion.Checked = True
        '    Exit Sub
        'End If
        'If submnu_StatusConversion.Checked = True Then
        '    Exit Sub
        'End If
        objStatusconversion.Show()
        objStatusconversion.MdiParent = Me
        submnu_StatusConversion.Checked = True
    End Sub
    Private Sub SubsubmenuFirstReminderLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSubsRepFilter As New SubsRepFilter
        Dim ReportFilterObj As New ReportFilter
        RepSqlStr = "First Reminder Letter"
        ReportTitle = "First Reminder Letter"
        ReportFilterObj.DLabel.Text = "First Reminder Letter"
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objSubsRepFilter.Show()
            objSubsRepFilter.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        objSubsRepFilter.MdiParent = Me
        submnu_StatusConversion.Checked = True
        ''objSubsRepFilter.Show()
        'Try
        '    Dim ReportFilterObj As New ReportFilter
        '    RepSqlStr = "First Reminder Letter"
        '    ReportFilterObj.MdiParent = Me
        '    ReportFilterObj.DLabel.Text = "First Reminder Letter"
        '    ReportFilterObj.Text = RepSqlStr
        '    ReportFilterObj.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Dim sqlstring As String = "SELECT dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.MemberMaster.MNAME, dbo.MemberMaster.CONTADD1, dbo.MemberMaster.CONTADD2, "
        'sqlstring = sqlstring & " dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, dbo.MemberMaster.CONTSTATE, "
        'sqlstring = sqlstring & " dbo.SubscriptinSummery.QUTERDATE, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.ARREAR, dbo.SubscriptinSummery.DUEDATE"
        'sqlstring = sqlstring & " ISNULL((SELECT SUM(REALVALUE-ADJUSTED) FROM OUTSTANDING WHERE  SLCODE=SUBSCRIPTION_SUMMARY_VIEW.MCODE),0) AS Arrear"
        'sqlstring = sqlstring & " FROM         dbo.SubscriptinSummery INNER JOIN"
        'sqlstring = sqlstring & " dbo.MemberMaster ON dbo.SubscriptinSummery.SUBCD = dbo.MemberMaster.MCODE INNER JOIN"
        'sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype"
        'sqlstring = sqlstring & " WHERE(dbo.SubscriptinSummery.ARREAR <> 0)"

        'MODIFIED BY SRINIVAS N**************************************************************************************
        ''''Dim sqlstring As String = "SELECT     dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME, dbo.MemberMaster.CONTADD1, "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.CONTADD2, dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.CONTSTATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.QUTERDATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO,"
        ''''sqlstring = sqlstring & " (SELECT     SUM(REALVALUE - ISNULL(ADJUSTED, 0))"
        ''''sqlstring = sqlstring & " FROM OUTSTANDING"
        ''''sqlstring = sqlstring & " WHERE      SLCODE = SUBSCRIPTION_SUMMARY_VIEW.MCODE) AS ARREAR,"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.DUEDATE"
        ''''sqlstring = sqlstring & " FROM         dbo.MemberMaster INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.outstanding ON dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO = dbo.outstanding.VoucherNo ON "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.MCODE = dbo.SUBSCRIPTION_SUMMARY_VIEW.MCODE"
        ''''sqlstring = sqlstring & " ORDER BY"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME"
        '''''**************************************************************************************************************************
        ''''Dim letter As String = "FIRST REMINDER LETTER"
        ''''Dim ReminderLetterObj As New ReminderLetter
        ''''ReminderLetterObj.begin()
        ''''ReminderLetterObj.buttonclick(globalclass.sqlconnection, sqlstring, letter)
    End Sub

    Private Sub SubsubmenuSecondReminderLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSubsRepFilter As New SubsRepFilter
        Dim ReportFilterObj As New ReportFilter
        RepSqlStr = "Second Reminder Letter"
        ReportTitle = "Second Reminder Letter"
        ReportFilterObj.DLabel.Text = "Second Reminder Letter"
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objSubsRepFilter.Show()
            objSubsRepFilter.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        'objSubsRepFilter.Show()
        objSubsRepFilter.MdiParent = Me
        submnu_StatusConversion.Checked = True
        '''Dim reminderletter As New ReminderLetter
        ''''Dim sqlstring As String = "SELECT dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.MemberMaster.MNAME, dbo.MemberMaster.CONTADD1, dbo.MemberMaster.CONTADD2, "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, dbo.MemberMaster.CONTSTATE, "
        ''''sqlstring = sqlstring & " dbo.SubscriptinSummery.QUTERDATE, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.ARREAR, dbo.SubscriptinSummery.DUEDATE"
        ''''sqlstring = sqlstring & " FROM         dbo.SubscriptinSummery INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.MemberMaster ON dbo.SubscriptinSummery.SUBCD = dbo.MemberMaster.MCODE INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype"
        ''''sqlstring = sqlstring & " WHERE(dbo.SubscriptinSummery.ARREAR <> 0)"
        '''' MODIFIED BY SRINIVAS N******************************************************************************************
        '''Dim sqlstring As String = "SELECT     dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME, dbo.MemberMaster.CONTADD1, "
        '''sqlstring = sqlstring & " dbo.MemberMaster.CONTADD2, dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, "
        '''sqlstring = sqlstring & " dbo.MemberMaster.CONTSTATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.QUTERDATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO,"
        '''sqlstring = sqlstring & " (SELECT     SUM(REALVALUE - ISNULL(ADJUSTED, 0))"
        '''sqlstring = sqlstring & " FROM OUTSTANDING"
        '''sqlstring = sqlstring & " WHERE      SLCODE = SUBSCRIPTION_SUMMARY_VIEW.MCODE) AS ARREAR,"
        '''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.DUEDATE"
        '''sqlstring = sqlstring & " FROM         dbo.MemberMaster INNER JOIN"
        '''sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype INNER JOIN"
        '''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW INNER JOIN"
        '''sqlstring = sqlstring & " dbo.outstanding ON dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO = dbo.outstanding.VoucherNo ON "
        '''sqlstring = sqlstring & " dbo.MemberMaster.MCODE = dbo.SUBSCRIPTION_SUMMARY_VIEW.MCODE"
        '''sqlstring = sqlstring & " ORDER BY"
        '''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME"
        ''''*************************************************************************************************
        '''Dim letter As String = "SECOND REMINDER LETTER"
        '''reminderletter.begin()
        '''reminderletter.buttonclick(globalclass.sqlconnection, sqlstring, letter)
    End Sub
    Private Sub Subsubmenu_FirstReminderList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSubsRepFilter As New SubsRepFilter
        Dim ReportFilterObj As New ReportFilter
        RepSqlStr = "First Reminder List"
        ReportTitle = "First Reminder List"
        ReportFilterObj.DLabel.Text = "First Reminder List"
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objSubsRepFilter.Show()
            objSubsRepFilter.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        objSubsRepFilter.MdiParent = Me
        submnu_StatusConversion.Checked = True
        'objSubsRepFilter.Show()
        ''''Dim sqlstring As String = "SELECT     TOP 100 PERCENT dbo.MemberType.TypeDesc, dbo.SubscriptinSummery.QUTERDATE, dbo.MemberMaster.MCODE AS MEMCODE, "
        ''''sqlstring = sqlstring & "  dbo.MemberMaster.Prefix, dbo.MemberMaster.MNAME, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.DUEDATE, "
        ''''sqlstring = sqlstring & "  dbo.SubscriptinSummery.ARREAR"
        ''''sqlstring = sqlstring & "  FROM         dbo.SubscriptinSummery INNER JOIN "
        ''''sqlstring = sqlstring & "  dbo.MemberMaster ON dbo.SubscriptinSummery.SUBCD = dbo.MemberMaster.MCODE INNER JOIN "
        ''''sqlstring = sqlstring & "  dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype "
        ''''sqlstring = sqlstring & "  GROUP BY dbo.MemberType.TypeDesc, dbo.SubscriptinSummery.QUTERDATE, dbo.MemberMaster.MCODE, dbo.MemberMaster.Prefix, "
        ''''sqlstring = sqlstring & "  dbo.MemberMaster.MNAME, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.DUEDATE, dbo.SubscriptinSummery.ARREAR, "
        ''''sqlstring = sqlstring & "  dbo.MemberType.Membertype "
        ''''sqlstring = sqlstring & "  HAVING      (dbo.SubscriptinSummery.ARREAR <> 0) "
        ''''sqlstring = sqlstring & "  ORDER BY dbo.MemberType.Membertype, dbo.MemberMaster.MCODE "
        ''''Dim ReminderList As New ReminderList
        ''''Dim arraystring() As String = {"", " FIRST REMINDER LIST ", "", ""}
        ''''Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
        ''''ReminderList.begin()
        ''''ReminderList.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
    End Sub
    Private Sub Subsubmenu_SecondReminderList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim ReportFilterObj As New ReportFilter
            RepSqlStr = "Second Reminder List"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.DLabel.Text = "Second Reminder List"
            ReportFilterObj.Text = RepSqlStr
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Submenu_SubscriptionBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Monthbill"
        Dim objSubsRepFilter As New Month_Bill
        objSubsRepFilter.Show()
        objSubsRepFilter.MdiParent = Me
    End Sub

    Private Sub SubMenu_CorporateList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Corporate List"
        Try
            ReportTitle = "Corporate Member List"
            Dim ReportFilterObj As New McodeFilter
            RepSqlStr = "Corporate Member List"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubMenu_AddressList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenu_AddressList.Click
        GmoduleName = "Address List"
        Try
            Dim ReportFilterObj As New addresslist
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub SubMenu_SpecialAbsenteeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Special Absentee List"
        Try
            Dim ReportFilterObj As New Specialabsentee
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubMenu_SurnamewiseList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Surname Wise List"
        Try
            Dim ReportFilterObj As New surnamereport
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubMenu_LockerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        menustatus = "L"
        GmoduleName = "Locker Number List"
        Try
            Dim ReportFilterObj As New lockerreport
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubMenu_CreditAcList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        menustatus = "C"
        GmoduleName = "Credit AC Number"
        Try
            Dim ReportFilterObj As New creditreport
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubMenu_MemberStatusList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenu_MemberStatusList.Click
        GmoduleName = "Member Status List"
        Try
            Dim ReportFilterObj As New Memberstatus
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SubMenu_AddressStickerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Address Sticker List"
        Try
            Dim ReportFilterObj As New Stickerlist
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubMenu_SubscriptionPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubMenu_SubscriptionPosting.Click
        GmoduleName = "Subscription Posting"
        Dim objPosting As New SubscriptionPosting
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objPosting.Show()
            objPosting.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        objPosting.Show()
        objPosting.MdiParent = Me
        'Try
        '    sqlString = "select * from posting_validation where yearof =" & Date.Now.Year
        '    gconnection.getDataSet(sqlString, "posting_validation")
        '    Dim i
        '    For i = 0 To gdataset.Tables("posting_validation").Rows.Count()
        '        objPosting.ChkList_month.SetItemChecked(gdataset.Tables("posting_validation").Rows(i).Item("quarter"), True)
        '    Next
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub submnu_MemberCorporate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_MemberCorporate.Click
        GmoduleName = "Member Subscription"
        Dim objMemberSubscription As New frmMemberSubscription
        If supscriptionbool = False And submnu_MemberSubscription.Checked = True Then
            objMemberSubscription.Show()
            objMemberSubscription.MdiParent = Me
            submnu_MemberSubscription.Checked = True
            Exit Sub
        End If
        If submnu_MemberSubscription.Checked = True Then
            Exit Sub
        End If
        objMemberSubscription.Show()
        objMemberSubscription.MdiParent = Me
        submnu_MemberSubscription.Checked = True
    End Sub
    Private Sub SubmenuSummaryRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Summary Report"
        Dim summary As New subscriptionsummry
        summary.Show()
        summary.MdiParent = Me
    End Sub
    Private Sub SubMenu_AbsenteeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Absentee List"
        Try
            Dim ReportFilterObj As New Absenteereport
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubMenu_PostRemLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objSubsRepFilter As New SubsRepFilter
        Dim ReportFilterObj As New ReportFilter
        RepSqlStr = "Posting Reminder Letter"
        ReportTitle = "Posting Reminder Letter"
        ReportFilterObj.DLabel.Text = "Posting Reminder Letter"
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objSubsRepFilter.Show()
            objSubsRepFilter.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        '        objSubsRepFilter.Show()
        objSubsRepFilter.MdiParent = Me
        submnu_StatusConversion.Checked = True

        ''''Dim reminderletter As New ReminderLetter
        '''''Dim sqlstring As String = "SELECT dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.MemberMaster.MNAME, dbo.MemberMaster.CONTADD1, dbo.MemberMaster.CONTADD2, "
        '''''sqlstring = sqlstring & " dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, dbo.MemberMaster.CONTSTATE, "
        '''''sqlstring = sqlstring & " dbo.SubscriptinSummery.QUTERDATE, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.ARREAR, dbo.SubscriptinSummery.DUEDATE"
        '''''sqlstring = sqlstring & " ISNULL((SELECT SUM(REALVALUE-ADJUSTED) FROM OUTSTANDING WHERE  SLCODE=SUBSCRIPTION_SUMMARY_VIEW.MCODE),0) AS Arrear"
        '''''sqlstring = sqlstring & " FROM         dbo.SubscriptinSummery INNER JOIN"
        '''''sqlstring = sqlstring & " dbo.MemberMaster ON dbo.SubscriptinSummery.SUBCD = dbo.MemberMaster.MCODE INNER JOIN"
        '''''sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype"
        '''''sqlstring = sqlstring & " WHERE(dbo.SubscriptinSummery.ARREAR <> 0)"

        '''''MODIFIED BY SRINIVAS N**************************************************************************************
        ''''Dim sqlstring As String = "SELECT     dbo.MemberType.TypeDesc, dbo.MemberMaster.Prefix, dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME, dbo.MemberMaster.CONTADD1, "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.CONTADD2, dbo.MemberMaster.CONTADD3, dbo.MemberMaster.CONTCITY, dbo.MemberMaster.CONTPIN, "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.CONTSTATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.QUTERDATE, dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO,"
        ''''sqlstring = sqlstring & " (SELECT     SUM(REALVALUE - ISNULL(ADJUSTED, 0))"
        ''''sqlstring = sqlstring & " FROM OUTSTANDING"
        ''''sqlstring = sqlstring & " WHERE      SLCODE = SUBSCRIPTION_SUMMARY_VIEW.MCODE) AS ARREAR,"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.DUEDATE"
        ''''sqlstring = sqlstring & " FROM         dbo.MemberMaster INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW INNER JOIN"
        ''''sqlstring = sqlstring & " dbo.outstanding ON dbo.SUBSCRIPTION_SUMMARY_VIEW.VRNO = dbo.outstanding.VoucherNo ON "
        ''''sqlstring = sqlstring & " dbo.MemberMaster.MCODE = dbo.SUBSCRIPTION_SUMMARY_VIEW.MCODE"
        ''''sqlstring = sqlstring & " ORDER BY"
        ''''sqlstring = sqlstring & " dbo.SUBSCRIPTION_SUMMARY_VIEW.MNAME"

        '''''**************************************************************************************************************************

        ''''Dim letter As String = "Posting Of Reminder Leter"
        ''''reminderletter.begin()
        ''''reminderletter.buttonclick(globalclass.sqlconnection, sqlstring, letter)
    End Sub

    Private Sub SubMenuPostRemList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim ReportFilterObj As New ReportFilter
            RepSqlStr = "Posting Reminder List"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.DLabel.Text = "Posting Reminder List"
            ReportFilterObj.Text = RepSqlStr
            'ReportFilterObj.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '''Dim sqlstring As String = "SELECT     TOP 100 PERCENT dbo.MemberType.TypeDesc, dbo.SubscriptinSummery.QUTERDATE, dbo.MemberMaster.MCODE AS MEMCODE, "
        '''sqlstring = sqlstring & "  dbo.MemberMaster.Prefix, dbo.MemberMaster.MNAME, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.DUEDATE, "
        '''sqlstring = sqlstring & " SUM(dbo.SubscriptinSummery.ARREAR+100) AS ARREAR"
        '''sqlstring = sqlstring & "  FROM         dbo.SubscriptinSummery INNER JOIN "
        '''sqlstring = sqlstring & "  dbo.MemberMaster ON dbo.SubscriptinSummery.SUBCD = dbo.MemberMaster.MCODE INNER JOIN "
        '''sqlstring = sqlstring & "  dbo.MemberType ON dbo.MemberMaster.MEMBERTYPECODE = dbo.MemberType.Membertype "
        '''sqlstring = sqlstring & "  GROUP BY dbo.MemberType.TypeDesc, dbo.SubscriptinSummery.QUTERDATE, dbo.MemberMaster.MCODE, dbo.MemberMaster.Prefix, "
        '''sqlstring = sqlstring & "  dbo.MemberMaster.MNAME, dbo.SubscriptinSummery.VRNO, dbo.SubscriptinSummery.DUEDATE, dbo.SubscriptinSummery.ARREAR, "
        '''sqlstring = sqlstring & "  dbo.MemberType.Membertype "
        '''sqlstring = sqlstring & "  HAVING      (dbo.SubscriptinSummery.ARREAR <> 0) "
        '''sqlstring = sqlstring & "  ORDER BY dbo.MemberType.Membertype, dbo.MemberMaster.MCODE "
        '''Dim ReminderList As New ReminderList
        '''Dim arraystring() As String = {"", " SECOND REMINDER LIST ", "", ""}
        '''Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
        '''ReminderList.begin()
        '''ReminderList.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim C1 As DataTable
        Dim i As Integer
        Dim S As String
        Dim SA(4) As String
        Dim STR As String
        Dim code As String
        C1 = gconnection.GetValues("SELECT * FROM MEMBERMASTER")
        Try
            For i = 0 To (C1.Rows.Count - 1)
                SA(0) = " "
                SA(1) = " "
                SA(2) = " "
                S = ""
                S = (C1.Rows(i).Item("MNAME")) & "  "
                code = Trim(C1.Rows(i).Item("Mcode"))
                SA = Split(S, " ")
                If i = 2839 Then
                    MsgBox(code)
                End If
                If SA(2) = "" Then
                    STR = "update membermaster set firstname = '" & SA(0) & "',middlename = " & "''" & ",surname = '" & SA(1) & "' where Mcode = '" & code & "'"
                Else
                    STR = "update membermaster set firstname = '" & SA(0) & "',middlename = '" & SA(1) & "',surname = '" & SA(2) & "' where Mcode = '" & code & "'"
                End If
                gconnection.dataOperation(2, STR, "membermaster")
            Next
            MsgBox("Spliting is over")
        Catch ex As Exception
            MsgBox(i)
            MsgBox(ex.Message)
        End Try
        'gconnection.dataOperation(2, sqlString, "membertype")
    End Sub
    Private Sub MemberMDI_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Shell("CLEAR.BAT", AppWinStyle.Hide)
        End
    End Sub
    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Shell("CLEAR.BAT", AppWinStyle.Hide)
        End
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Corporate Posting"
        'Dim objPosting As New CorpSubscriptionPosting
        Dim objPosting As New SpecialSubscriptionPosting
        If statusconversionbool = False And submnu_StatusConversion.Checked = True Then
            objPosting.Show()
            objPosting.MdiParent = Me
            submnu_StatusConversion.Checked = True
            Exit Sub
        End If
        If submnu_StatusConversion.Checked = True Then
            Exit Sub
        End If
        objPosting.Show()
        objPosting.MdiParent = Me
        Try
            sqlString = "select * from posting_validation where yearof =" & Date.Now.Year
            gconnection.getDataSet(sqlString, "posting_validation")
            Dim i
            For i = 0 To gdataset.Tables("posting_validation").Rows.Count()
                objPosting.ChkList_month.SetItemChecked(gdataset.Tables("posting_validation").Rows(i).Item("quarter"), True)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Corp Subscription Bill"
        Try
            ReportTitle = "Corporate_Report"
            Dim ReportFilterObj As New CorpReportScreen
            RepSqlStr = "Corporation_Report"
            ReportFilterObj.MdiParent = Me
            'ReportFilterObj.DLabel.Text = " Enter Member Code"
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MemberMDI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim memberhelp As New Memberhelp1
            memberhelp.Show()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim AdvancedSubscription As New Advance_Subscription
            AdvancedSubscription.Show()
        End If
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim reminder As New reminder
        'reminder.Show()
        'reminder.MdiParent = Me
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Reminder"
        Try
            ReportTitle = "Reminder_Letter"
            Dim ReportFilterObj As New rem1
            RepSqlStr = "Reminder_Letter"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Reminder Letter"
        Try
            'ReportTitle = "addchg_Posting"
            ReportTitle = "reminder"

            Dim ReportFilterObj As New reminder
            'Dim ReportFilterObj As New addchg_Posting
            RepSqlStr = "Reminder_Letter"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub submnu_MemberTypeConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member Category Conversion"
        Try
            ReportTitle = "Reminder_Letter"
            Dim ReportFilterObj As New memberconversion
            RepSqlStr = "Reminder_Letter"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_MembersList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Members List"
        Try
            ReportTitle = "Members_List"
            Dim ReportFilterObj As New MembersList
            RepSqlStr = "Members_List"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_ID_Card_Printout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "ID Card Printout"
        Try
            ReportTitle = "ID_Card_Printout"
            Dim ReportFilterObj As New ID_Card_Print
            RepSqlStr = "Members_List"
            ReportFilterObj.MdiParent = Me
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_Member_Ledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GmoduleName = "Member Ledger"
        'Try
        '    Dim Rpt_MemberLedger As New Memberhelp1
        '    Rpt_MemberLedger.MdiParent = Me
        '    Rpt_MemberLedger.Text = RepSqlStr
        '    Rpt_MemberLedger.Show()
        '    Rpt_MemberLedger.MdiParent = Me
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub Mnu_Outstanding_Summary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Outstanding Summary"
        Try
            Dim Rpt_Outstanding_Summary As New FRMOUTSTANDINGRPT
            Rpt_Outstanding_Summary.MdiParent = Me
            Rpt_Outstanding_Summary.Text = RepSqlStr
            Rpt_Outstanding_Summary.Show()
            Rpt_Outstanding_Summary.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_Affiliated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Affiliated.Click
        GmoduleName = "Affiliated Club Master"
        Try
            Dim Affiliated_Master As New AffiliatedClubDetails
            Affiliated_Master.Show()
            Affiliated_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_DependentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Dependent List"
        Try
            Dim Dependent_List As New dependentListRegister
            Dependent_List.MdiParent = Me
            Dependent_List.Text = RepSqlStr
            Dependent_List.Show()
            Dependent_List.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mnu_Directory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Directory.Click
        GmoduleName = "Member Directory"
        Try
            Dim ReportFilterObj As New MemberDirectory
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member History"
        Try
            Dim MstMemHistory As New MemberHistory
            MstMemHistory.Show()
            MstMemHistory.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member."
        Try
            Dim Rpt_Outstanding_Summary As New FRMOUTSTANDINGRPT
            Rpt_Outstanding_Summary.MdiParent = Me
            Rpt_Outstanding_Summary.Text = RepSqlStr
            Rpt_Outstanding_Summary.Show()
            Rpt_Outstanding_Summary.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Party."
        Try
            Dim Rpt_Outstanding_Summary As New FRMOUTSTANDINGRPT_PARTY
            Rpt_Outstanding_Summary.MdiParent = Me
            Rpt_Outstanding_Summary.Text = RepSqlStr
            Rpt_Outstanding_Summary.Show()
            Rpt_Outstanding_Summary.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Room."
        Try
            Dim Rpt_Outstanding_Summary As New FRMOUTSTANDINGRPT_ROOM_Room
            Rpt_Outstanding_Summary.MdiParent = Me
            Rpt_Outstanding_Summary.Text = RepSqlStr
            Rpt_Outstanding_Summary.Show()
            Rpt_Outstanding_Summary.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Month Bill - Member"
        Dim objSubsRepFilter As New MBILL
        objSubsRepFilter.Show()
        objSubsRepFilter.MdiParent = Me
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Party Bill  -Member"
        Dim objSubsRepFilter As New PartyBill
        objSubsRepFilter.Show()
        objSubsRepFilter.MdiParent = Me
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member"
        Try
            Dim Rpt_MemberLedger As New Memberhelp1
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Text = RepSqlStr
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Party"
        Try
            Dim Rpt_MemberLedger As New Memberhelp_party
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Text = RepSqlStr
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Room"
        Try
            Dim Rpt_MemberLedger As New Memberhelp_Room
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Text = RepSqlStr
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Bill"
        Try
            Dim Rpt_MemberLedger As New MBILL
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Text = RepSqlStr
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Facility Master"
        Try
            Dim Rpt_MemberLedger As New Facility
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Text = RepSqlStr
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GmoduleName = "Test"
        'Try
        '    Dim Rpt_MemberLedger As New Test
        '    Rpt_MemberLedger.MdiParent = Me
        '    Rpt_MemberLedger.Text = RepSqlStr
        '    Rpt_MemberLedger.Show()
        '    Rpt_MemberLedger.MdiParent = Me
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member Balance View"
        Try
            Dim Rpt_MemberLedger As New MEMEBRVIEW
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member Revoke Status"
        Try
            Dim Rpt_MemberLedger As New RevokeStatus
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Member Category And Status"
        Try
            Dim Rpt_MemberLedger As New CategoryStatusList
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "DOB LIST"
        Try
            Dim Rpt_MemberLedger As New doblist
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            Rpt_MemberLedger.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "MEMBER DETAILS"
        Try
            Dim Rpt_MemberLedger As New Member_details
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            'Rpt_MemberLedger.MaximizeBox = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEM_DOB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "MEMBER DOB"
        Try
            Dim Rpt_MemberLedger As New MEM_SPO_DEP_BIRTH
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            'Rpt_MemberLedger.MaximizeBox = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mbill_setup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "MEMBER MONTH BILL SETUP"
        Try
            Dim Rpt_MemberLedger As New POSFUNDMASTER
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            'Rpt_MemberLedger.MaximizeBox = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mbill_post_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "MEMBER MONTH BILL POSTING"
        Try
            Dim Rpt_MemberLedger As New MJV_JournalRegister
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            'Rpt_MemberLedger.MaximizeBox = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mbill_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "MEMBER MONTHBILL"
        Try
            Dim Rpt_MemberLedger As New MBILL_HBC
            Rpt_MemberLedger.MdiParent = Me
            Rpt_MemberLedger.Show()
            'Rpt_MemberLedger.MaximizeBox = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub







    Private Sub MenuSubscriptionTagging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSubscriptionTagging.Click
        GmoduleName = "Subscription Tagging"
        Try
            Dim SubscriptionTagging_Master As New SubscriptionTagging
            SubscriptionTagging_Master.MdiParent = Me
            SubscriptionTagging_Master.Text = RepSqlStr
            SubscriptionTagging_Master.Show()
            SubscriptionTagging_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub MenuCategoryConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCategoryConversion.Click
        GmoduleName = "Category Conversion"
        Try
            Dim CategoryConversion_Master As New memberconversion
            'CategoryConversion_Master.MdiParent = Me
            'CategoryConversion_Master.Text = RepSqlStr
            CategoryConversion_Master.Show()
            'CategoryConversion_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuAddlChargesPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAddlChargesPosting.Click
        GmoduleName = "Addl. Charges Posting"
        Try
            Dim AdditionalCharge_Transaction As New addchg_Posting
            'AdditionalCharge_Transaction.MdiParent = Me
            'AdditionalCharge_Transaction.Text = RepSqlStr
            AdditionalCharge_Transaction.Show()
            'AdditionalCharge_Transaction.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuMembersReminderHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMembersReminderHistory.Click
        GmoduleName = "Members Reminder History"
        Try
            Dim MemberList_Report As New MembersList
            'MemberList_Report.MdiParent = Me
            'MemberList_Report.Text = RepSqlStr
            MemberList_Report.Show()
            'MemberList_Report.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuReminderLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReminderLetter.Click
        GmoduleName = "Reminder Letter"
        Try
            Dim ReminderLetter_Master As New reminder
            'ReminderLetter_Master.MdiParent = Me
            'ReminderLetter_Master.Text = RepSqlStr
            ReminderLetter_Master.Show()
            'ReminderLetter_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuMemberDetailOutStanding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMemberDetailOutStanding.Click
        GmoduleName = "Member Detail/Outstanding"
        Try
            'Dim OutstandingList As New FRMOUTSTANDINGRPT
            Dim OutstandingList As New OUTSTAND_MEMREP_LIST
            OutstandingList.Show()
            OutstandingList.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuOutstandingList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuOutstandingList.Click
        GmoduleName = "OutstandingList"
        Try
            Dim Outstanding As New Outstandinglist
            Outstanding.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuUnitMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnitMaster.Click

        GmoduleName = "State Master"
        Try
            Dim Unit_Master As New State_Master
            Unit_Master.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuRankMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRankMaster.Click
        GmoduleName = "Rank Master"
        Try
            Dim Rank_Master As New Citymaster
            Rank_Master.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuCellingMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCellingMaster.Click
        GmoduleName = "Country Master"
        Try
            Dim Celling_Master As New Country_Master
            Celling_Master.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuBillingSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBillingSetup.Click
        GmoduleName = "Billing Setup"
        Try
            Dim PosFund_Master As New POSFUNDMASTER
            'PosFund_Master.MdiParent = Me
            'PosFund_Master.Text = RepSqlStr
            PosFund_Master.Show()
            'PosFund_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuMUCPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMUCPosting.Click
        GmoduleName = "MUC Posting"
        Try
            Dim MUCPosting_Transaction As New MUCPosting
            'MUCPosting_Transaction.MdiParent = Me
            'MUCPosting_Transaction.Text = RepSqlStr
            MUCPosting_Transaction.Show()
            MUCPosting_Transaction.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuMemberStrengthList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMemberStrengthList.Click
        GmoduleName = "Member Details"
        Try
            Dim MemberDetails As New MembersDetails
            MemberDetails.Show()
            MemberDetails.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuBirthdayAnniversaryWiseList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBirthdayAnniversaryWiseList.Click
        GmoduleName = "Birthday List"
        Try
            Dim MemberBirthdayList As New MEM_SPO_DEP_BIRTH
            MemberBirthdayList.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuMembersStatusHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMembersStatusHistory.Click
        GmoduleName = "Member Status History"
        Try
            Dim MemberStatusHistory As New Memberstatus
            MemberStatusHistory.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuDependentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDependentList.Click
        GmoduleName = "Dependent List"
        Try
            Dim dependentlist As New dependentListRegister
            dependentlist.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuAffiliatedClubList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAffiliatedClubList.Click
        GmoduleName = "Affiliated Club List"
        Try
            Dim AffiliatedClubList_Report As New AffiliatedClubList
            AffiliatedClubList_Report.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuSubscriptionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSubscriptionList.Click
        GmoduleName = "Subscription List"
        Try
            Dim SubscriptionList_Report As New SubscriptionListDetails
            SubscriptionList_Report.Show()
            SubscriptionList_Report.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub MenuMonthlyBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuMonthlyBill.Click
        GmoduleName = "Monthly Bill (Detail - Summary)"
        Try
            ''Dim MonthBill_Master As New Month_Bill
            Dim MonthBill_Master As New MonthBilling
            MonthBill_Master.Show()
            MonthBill_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuBillRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuBillRegister.Click

    End Sub


    Private Sub MenuAddlChargesPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAddlChargesPL.Click

    End Sub


    Private Sub UnitWiseBillMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitWiseBillMenu.Click
        'GmoduleName = "Unit Wise Bill"
        'Try
        '    Dim UnitWiseBill_Report As New UnitWiseBill
        '    'UnitWiseBill_Report.MdiParent = Me
        '    'UnitWiseBill_Report.Text = RepSqlStr
        '    UnitWiseBill_Report.Show()
        '    'UnitWiseBill_Report.MdiParent = Me
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


    Private Sub MenuUnitWiseMemberADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUnitWiseMemberADD.Click
        GmoduleName = "Unit Wise Bill"
        Try
            Dim UnitWiseMEMAddress_Report As New UnitWiseMEMAddress
            'UnitWiseMEMAddress_Report.MdiParent = Me
            'UnitWiseMEMAddress_Report.Text = RepSqlStr
            UnitWiseMEMAddress_Report.Show()
            'UnitWiseMEMAddress_Report.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub submenu_rank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submenu_rank.Click
        GmoduleName = "Rank List"
        Try
            Dim ReportFilterObj As New RANKWISELIST
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Submenu_armservice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submenu_armservice.Click
        GmoduleName = "Armservices List"
        Try
            Dim ReportFilterObj As New ArmServicesList
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Submenu_facility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submenu_facility.Click
        GmoduleName = "Facility Master"
        Try
            Dim ReportFilterObj As New Facility_NONRSI
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Submenu_remainder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submenu_remainder.Click
        GmoduleName = "Reminder Letter"
        Try
            Dim ReportFilterObj As New Remaindereportlist
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sub_menufaacility.Click
        GmoduleName = "Facility List "
        Try
            Dim Facilityreport As New Facility_Report
            Facilityreport.Show()
            Facilityreport.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Submenu_ledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submenu_ledger.Click
        GmoduleName = "Member Ledger"
        Try
            Dim memberledgerdetails As New Memberhelp1
            memberledgerdetails.Show()
            memberledgerdetails.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click

    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try
            Dim selectcompany As New CompanyList1
            selectcompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnu_receipts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_receipts.Click
        GmoduleName = "MembersReceipts"
        Dim CompanyName As String
        CompanyName = Trim(gCompanyname)
        Try
            Dim RECEIPTS As New MembersReceipts
            RECEIPTS.MdiParent = Me
            RECEIPTS.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click

    End Sub

    Private Sub mnu_receipts_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnu_receipts.Popup

    End Sub

    Private Sub MNU_accountagging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_accountagging.Click
        GmoduleName = "Accounttagging"
        Try
            Dim accounttagging As New ACCOUNTSITEMTAGGING
            accounttagging.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub MNU_Facilitymaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_Facilitymaster.Click
        'GmoduleName = "Facility Master "
        'Try
        '    Dim Facility_Mahalakshmi As New Facility_Mahalakshmi
        '    Facility_Mahalakshmi.Show()
        '    Facility_Mahalakshmi.MdiParent = Me
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub MNU_SUBSCRIPTION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNU_SUBSCRIPTION.Click
        GmoduleName = "Subscription Details List"
        Try
            Dim Subscription_Report As New MEMREP_SUBSCRIPTION_DET
            Subscription_Report.Show()
            Subscription_Report.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub menu_Transaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_Transaction.Click

    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        GmoduleName = "Member Transfer"
        Try
            Dim MemberTransfer As New MemberTransfer
            MemberTransfer.Show()
            MemberTransfer.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        GmoduleName = "Category Master"
        Dim objMemberCategory As New frmMemberCategory
        If categorybool = False And submnu_MemberCategory.Checked = True Then
            objMemberCategory.Show()
            objMemberCategory.MdiParent = Me
            submnu_MemberCategory.Checked = True
            Exit Sub
        End If
        If submnu_MemberCategory.Checked = True Then
            Exit Sub
        End If
        objMemberCategory.Show()
        objMemberCategory.MdiParent = Me
        'submnu_MemberCategory.Checked = True
    End Sub

    Private Sub MenuItem26_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        GmoduleName = "SubCategory Master"
        Try
            Dim MemberCategory As New SubCategorymaster
            MemberCategory.Show()
            MemberCategory.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        GmoduleName = "Designation Master"
        Try
            Dim Designation As New Designation_Master
            Designation.Show()
            Designation.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        GmoduleName = "Salutation Master"
        Try
            Dim Salutation As New Title_Master
            Salutation.Show()
            Salutation.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        GmoduleName = "Religion Master"
        Try
            Dim ReligionMaster As New Religion_Master
            ReligionMaster.Show()
            ReligionMaster.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        GmoduleName = "MaritalStatus Master"
        Try
            Dim MaritalStatusMaster As New MaritalStatus_Master
            MaritalStatusMaster.Show()
            MaritalStatusMaster.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem36_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        GmoduleName = "Subscription Receipts"
        Try
            Dim AdvancedSubscription As New Advance_Subscription
            AdvancedSubscription.Show()
            AdvancedSubscription.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem37_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        GmoduleName = "Member Deactivation Conversion"
        Try
            Dim ActiveConversion As New NewStatusconversion
            ActiveConversion.Show()
            ActiveConversion.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GmoduleName = "Status Master"
        Try
            Dim Status_Master As New StatusMaster
            Status_Master.Show()
            Status_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem39_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        GmoduleName = "Reason Master"
        Try
            Dim Reason_Master As New ReasonMaster
            Reason_Master.Show()
            Reason_Master.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        GmoduleName = "Corporate Master"
        Try
            Dim MemberCorporate As New frmMemberCorporate
            MemberCorporate.Show()
            MemberCorporate.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Subscription Details"
        Try
            Dim Subscription As New MemberwiseSubscriptionDetails
            Subscription.Show()
            Subscription.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        GmoduleName = "Professional Master"
        Try
            Dim Professional As New ProfessionalMaster
            Professional.Show()
            Professional.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MemberMDI_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub MemberMDI_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick

    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        GmoduleName = "SubscriptionType Master"
        Try
            Dim SubscriptionTypeMaster As New SubscriptionType_Master
            SubscriptionTypeMaster.Show()
            SubscriptionTypeMaster.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        GmoduleName = "Monthly Report"
        Try
            Dim SubscriptionTypeMaster As New MonthBilling1
            SubscriptionTypeMaster.Show()
            SubscriptionTypeMaster.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        GmoduleName = "Corporate List"
        Try
            Dim ReportFilterObj As New Corpstatus
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem35_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        GmoduleName = "Month Bill Tagging"
        Try
            Dim ReportFilterObj As New ACCOUNTSITEMTAGGING1
            ReportFilterObj.Show()
            ReportFilterObj.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class