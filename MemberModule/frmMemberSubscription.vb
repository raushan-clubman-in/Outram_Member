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

Public Class frmMemberSubscription
    Inherits System.Windows.Forms.Form
    Dim SqlString, strVotingright, strSubscription As String
    Dim boolchk, checkValid As Boolean
    Dim billingmonth As String
    Dim checked As Integer
    Dim taxcode As Double

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
    Friend WithEvents cmd_BillheadCode As System.Windows.Forms.Button
    Friend WithEvents chkList_BillingMonth As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_BillheadCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_BillingMonth As System.Windows.Forms.Label
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents lbl_Type As System.Windows.Forms.Label
    Friend WithEvents lbl_BillheadName As System.Windows.Forms.Label
    Friend WithEvents lbl_BillheadCode As System.Windows.Forms.Label
    Friend WithEvents cbo_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents txt__BillheadName As System.Windows.Forms.TextBox
    Friend WithEvents chk_Subscrption As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents List_Billing_disp As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_TaxAmt As System.Windows.Forms.TextBox
    Friend WithEvents Btn_tax_help As System.Windows.Forms.Button
    Friend WithEvents txt_TaxAccin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_TaxCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Percentage As System.Windows.Forms.Label
    Friend WithEvents txt_Percentage As System.Windows.Forms.TextBox
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_freeze As System.Windows.Forms.CheckBox
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cbo_Appliedon As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Luxurytax As System.Windows.Forms.Label
    Friend WithEvents Txt_luxuryTax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Typedesc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_to As System.Windows.Forms.TextBox
    Friend WithEvents Txt_from As System.Windows.Forms.TextBox
    Friend WithEvents lbl_toage As System.Windows.Forms.Label
    Friend WithEvents lbl_fromage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cbo_Basedontype As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Ageto As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Agefrom As System.Windows.Forms.TextBox
    Friend WithEvents Label_Maxchar As System.Windows.Forms.Label
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_todate As System.Windows.Forms.Label
    Friend WithEvents lbl_fromdate As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMemberSubscription))
        Me.cmd_BillheadCode = New System.Windows.Forms.Button
        Me.chk_Subscrption = New System.Windows.Forms.CheckBox
        Me.chkList_BillingMonth = New System.Windows.Forms.CheckedListBox
        Me.txt_BillheadCode = New System.Windows.Forms.TextBox
        Me.lbl_BillingMonth = New System.Windows.Forms.Label
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.lbl_BillingBasis = New System.Windows.Forms.Label
        Me.lbl_Type = New System.Windows.Forms.Label
        Me.lbl_BillheadName = New System.Windows.Forms.Label
        Me.lbl_BillheadCode = New System.Windows.Forms.Label
        Me.cbo_Type = New System.Windows.Forms.ComboBox
        Me.txt_Total = New System.Windows.Forms.TextBox
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.txt__BillheadName = New System.Windows.Forms.TextBox
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.List_Billing_disp = New System.Windows.Forms.ListBox
        Me.lbl_Percentage = New System.Windows.Forms.Label
        Me.txt_Percentage = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_TaxAmt = New System.Windows.Forms.TextBox
        Me.Btn_tax_help = New System.Windows.Forms.Button
        Me.txt_TaxAccin = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_TaxCode = New System.Windows.Forms.TextBox
        Me.Grp_Print = New System.Windows.Forms.GroupBox
        Me.Chk_freeze = New System.Windows.Forms.CheckBox
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMD_WINDOWS = New System.Windows.Forms.Button
        Me.CMD_DOS = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cbo_Appliedon = New System.Windows.Forms.ComboBox
        Me.Lbl_Luxurytax = New System.Windows.Forms.Label
        Me.Txt_luxuryTax = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_Typedesc = New System.Windows.Forms.TextBox
        Me.Txt_to = New System.Windows.Forms.TextBox
        Me.Txt_from = New System.Windows.Forms.TextBox
        Me.lbl_toage = New System.Windows.Forms.Label
        Me.lbl_fromage = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cbo_Basedontype = New System.Windows.Forms.ComboBox
        Me.Txt_Ageto = New System.Windows.Forms.TextBox
        Me.Txt_Agefrom = New System.Windows.Forms.TextBox
        Me.Label_Maxchar = New System.Windows.Forms.Label
        Me.lbl_todate = New System.Windows.Forms.Label
        Me.lbl_fromdate = New System.Windows.Forms.Label
        Me.dtp_from = New System.Windows.Forms.DateTimePicker
        Me.dtp_to = New System.Windows.Forms.DateTimePicker
        Me.Grp_Print.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_BillheadCode
        '
        Me.cmd_BillheadCode.Image = CType(resources.GetObject("cmd_BillheadCode.Image"), System.Drawing.Image)
        Me.cmd_BillheadCode.Location = New System.Drawing.Point(336, 72)
        Me.cmd_BillheadCode.Name = "cmd_BillheadCode"
        Me.cmd_BillheadCode.Size = New System.Drawing.Size(23, 24)
        Me.cmd_BillheadCode.TabIndex = 2
        '
        'chk_Subscrption
        '
        Me.chk_Subscrption.BackColor = System.Drawing.Color.Transparent
        Me.chk_Subscrption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chk_Subscrption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Subscrption.Location = New System.Drawing.Point(48, 8)
        Me.chk_Subscrption.Name = "chk_Subscrption"
        Me.chk_Subscrption.Size = New System.Drawing.Size(256, 24)
        Me.chk_Subscrption.TabIndex = 0
        Me.chk_Subscrption.Text = "Subscription (Yes/No)"
        Me.chk_Subscrption.Visible = False
        '
        'chkList_BillingMonth
        '
        Me.chkList_BillingMonth.BackColor = System.Drawing.Color.AntiqueWhite
        Me.chkList_BillingMonth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkList_BillingMonth.Items.AddRange(New Object() {"1.April", "2.May", "3.June", "4.July", "5.August", "6.September", "7.October", "8.November", "9.December", "10.January", "11.February", "12.March"})
        Me.chkList_BillingMonth.Location = New System.Drawing.Point(256, 160)
        Me.chkList_BillingMonth.Name = "chkList_BillingMonth"
        Me.chkList_BillingMonth.Size = New System.Drawing.Size(168, 46)
        Me.chkList_BillingMonth.TabIndex = 6
        '
        'txt_BillheadCode
        '
        Me.txt_BillheadCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_BillheadCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BillheadCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BillheadCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillheadCode.Location = New System.Drawing.Point(256, 72)
        Me.txt_BillheadCode.MaxLength = 4
        Me.txt_BillheadCode.Name = "txt_BillheadCode"
        Me.txt_BillheadCode.Size = New System.Drawing.Size(80, 26)
        Me.txt_BillheadCode.TabIndex = 1
        Me.txt_BillheadCode.Text = ""
        '
        'lbl_BillingMonth
        '
        Me.lbl_BillingMonth.AutoSize = True
        Me.lbl_BillingMonth.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingMonth.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingMonth.Location = New System.Drawing.Point(72, 168)
        Me.lbl_BillingMonth.Name = "lbl_BillingMonth"
        Me.lbl_BillingMonth.Size = New System.Drawing.Size(135, 25)
        Me.lbl_BillingMonth.TabIndex = 24
        Me.lbl_BillingMonth.Text = "Billing Month :"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Total.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(448, 408)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(198, 25)
        Me.lbl_Total.TabIndex = 26
        Me.lbl_Total.Text = "Subscription Amount :"
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(448, 168)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(122, 25)
        Me.lbl_BillingBasis.TabIndex = 22
        Me.lbl_BillingBasis.Text = "Billing Basis :"
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Type.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Type.Location = New System.Drawing.Point(72, 112)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(61, 25)
        Me.lbl_Type.TabIndex = 23
        Me.lbl_Type.Text = "Type :"
        '
        'lbl_BillheadName
        '
        Me.lbl_BillheadName.AutoSize = True
        Me.lbl_BillheadName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillheadName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillheadName.Location = New System.Drawing.Point(448, 72)
        Me.lbl_BillheadName.Name = "lbl_BillheadName"
        Me.lbl_BillheadName.Size = New System.Drawing.Size(183, 25)
        Me.lbl_BillheadName.TabIndex = 19
        Me.lbl_BillheadName.Text = "Subscription  Name :"
        '
        'lbl_BillheadCode
        '
        Me.lbl_BillheadCode.AutoSize = True
        Me.lbl_BillheadCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillheadCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillheadCode.Location = New System.Drawing.Point(72, 72)
        Me.lbl_BillheadCode.Name = "lbl_BillheadCode"
        Me.lbl_BillheadCode.Size = New System.Drawing.Size(173, 25)
        Me.lbl_BillheadCode.TabIndex = 18
        Me.lbl_BillheadCode.Text = "Subscription Code :"
        '
        'cbo_Type
        '
        Me.cbo_Type.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Type.Location = New System.Drawing.Point(256, 112)
        Me.cbo_Type.Name = "cbo_Type"
        Me.cbo_Type.Size = New System.Drawing.Size(168, 27)
        Me.cbo_Type.TabIndex = 4
        '
        'txt_Total
        '
        Me.txt_Total.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Total.Location = New System.Drawing.Point(648, 406)
        Me.txt_Total.MaxLength = 9
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(96, 26)
        Me.txt_Total.TabIndex = 7
        Me.txt_Total.Text = ""
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"YEARLY", "HALF YEARLY", "QUARTERLY", "MONTHLY", "NONE", "PERIOD"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(648, 168)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(184, 27)
        Me.cbo_BillingBasis.TabIndex = 5
        '
        'txt__BillheadName
        '
        Me.txt__BillheadName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt__BillheadName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt__BillheadName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt__BillheadName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt__BillheadName.Location = New System.Drawing.Point(648, 72)
        Me.txt__BillheadName.MaxLength = 35
        Me.txt__BillheadName.Name = "txt__BillheadName"
        Me.txt__BillheadName.Size = New System.Drawing.Size(304, 26)
        Me.txt__BillheadName.TabIndex = 3
        Me.txt__BillheadName.Text = ""
        '
        'lbl_Frez
        '
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(184, 528)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(720, 25)
        Me.lbl_Frez.TabIndex = 357
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(728, 576)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 17
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 632)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 366
        Me.Label1.Text = "Press [F4] For Help"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(600, 576)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 16
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.Color.Transparent
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Image = CType(resources.GetObject("cmd_ListView.Image"), System.Drawing.Image)
        Me.cmd_ListView.Location = New System.Drawing.Point(344, 576)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 14
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(472, 576)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 15
        Me.cmd_Delete.Text = "Freeze[F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.Color.Transparent
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Image = CType(resources.GetObject("cmd_AddNew.Image"), System.Drawing.Image)
        Me.cmd_AddNew.Location = New System.Drawing.Point(216, 576)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 13
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Selected Month:"
        '
        'List_Billing_disp
        '
        Me.List_Billing_disp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Billing_disp.ItemHeight = 19
        Me.List_Billing_disp.Location = New System.Drawing.Point(256, 216)
        Me.List_Billing_disp.Name = "List_Billing_disp"
        Me.List_Billing_disp.Size = New System.Drawing.Size(168, 61)
        Me.List_Billing_disp.TabIndex = 1
        '
        'lbl_Percentage
        '
        Me.lbl_Percentage.AutoSize = True
        Me.lbl_Percentage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Percentage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentage.Location = New System.Drawing.Point(448, 376)
        Me.lbl_Percentage.Name = "lbl_Percentage"
        Me.lbl_Percentage.Size = New System.Drawing.Size(111, 25)
        Me.lbl_Percentage.TabIndex = 379
        Me.lbl_Percentage.Text = "Percentage :"
        '
        'txt_Percentage
        '
        Me.txt_Percentage.BackColor = System.Drawing.Color.White
        Me.txt_Percentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Percentage.Enabled = False
        Me.txt_Percentage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Percentage.Location = New System.Drawing.Point(648, 376)
        Me.txt_Percentage.MaxLength = 5
        Me.txt_Percentage.Name = "txt_Percentage"
        Me.txt_Percentage.Size = New System.Drawing.Size(96, 26)
        Me.txt_Percentage.TabIndex = 378
        Me.txt_Percentage.Text = ""
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(135, 22)
        Me.Label15.TabIndex = 377
        Me.Label15.Text = "Tax Amount"
        '
        'txt_TaxAmt
        '
        Me.txt_TaxAmt.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_TaxAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TaxAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxAmt.Enabled = False
        Me.txt_TaxAmt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxAmt.Location = New System.Drawing.Point(256, 440)
        Me.txt_TaxAmt.MaxLength = 9
        Me.txt_TaxAmt.Name = "txt_TaxAmt"
        Me.txt_TaxAmt.Size = New System.Drawing.Size(88, 26)
        Me.txt_TaxAmt.TabIndex = 376
        Me.txt_TaxAmt.Text = ""
        '
        'Btn_tax_help
        '
        Me.Btn_tax_help.Image = CType(resources.GetObject("Btn_tax_help.Image"), System.Drawing.Image)
        Me.Btn_tax_help.Location = New System.Drawing.Point(416, 376)
        Me.Btn_tax_help.Name = "Btn_tax_help"
        Me.Btn_tax_help.Size = New System.Drawing.Size(23, 24)
        Me.Btn_tax_help.TabIndex = 372
        '
        'txt_TaxAccin
        '
        Me.txt_TaxAccin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TaxAccin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxAccin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxAccin.Location = New System.Drawing.Point(256, 406)
        Me.txt_TaxAccin.MaxLength = 10
        Me.txt_TaxAccin.Name = "txt_TaxAccin"
        Me.txt_TaxAccin.Size = New System.Drawing.Size(88, 26)
        Me.txt_TaxAccin.TabIndex = 373
        Me.txt_TaxAccin.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 375
        Me.Label4.Text = "Tax Accin"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 22)
        Me.Label10.TabIndex = 374
        Me.Label10.Text = "Tax Code"
        '
        'txt_TaxCode
        '
        Me.txt_TaxCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxCode.Location = New System.Drawing.Point(256, 376)
        Me.txt_TaxCode.MaxLength = 10
        Me.txt_TaxCode.Name = "txt_TaxCode"
        Me.txt_TaxCode.Size = New System.Drawing.Size(152, 26)
        Me.txt_TaxCode.TabIndex = 371
        Me.txt_TaxCode.Text = ""
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Chk_freeze)
        Me.Grp_Print.Controls.Add(Me.CMDEXIT)
        Me.Grp_Print.Controls.Add(Me.CMD_WINDOWS)
        Me.Grp_Print.Controls.Add(Me.CMD_DOS)
        Me.Grp_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Print.Location = New System.Drawing.Point(328, 496)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(440, 64)
        Me.Grp_Print.TabIndex = 657
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 658
        Me.Label2.Text = "Applied On :"
        '
        'Cbo_Appliedon
        '
        Me.Cbo_Appliedon.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_Appliedon.CausesValidation = False
        Me.Cbo_Appliedon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Appliedon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Appliedon.Items.AddRange(New Object() {"Member", "Dependent"})
        Me.Cbo_Appliedon.Location = New System.Drawing.Point(256, 288)
        Me.Cbo_Appliedon.Name = "Cbo_Appliedon"
        Me.Cbo_Appliedon.Size = New System.Drawing.Size(168, 27)
        Me.Cbo_Appliedon.TabIndex = 659
        '
        'Lbl_Luxurytax
        '
        Me.Lbl_Luxurytax.AutoSize = True
        Me.Lbl_Luxurytax.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Luxurytax.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Luxurytax.Location = New System.Drawing.Point(448, 440)
        Me.Lbl_Luxurytax.Name = "Lbl_Luxurytax"
        Me.Lbl_Luxurytax.Size = New System.Drawing.Size(92, 25)
        Me.Lbl_Luxurytax.TabIndex = 667
        Me.Lbl_Luxurytax.Text = "Discount :"
        Me.Lbl_Luxurytax.Visible = False
        '
        'Txt_luxuryTax
        '
        Me.Txt_luxuryTax.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Txt_luxuryTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_luxuryTax.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_luxuryTax.Location = New System.Drawing.Point(648, 440)
        Me.Txt_luxuryTax.MaxLength = 9
        Me.Txt_luxuryTax.Name = "Txt_luxuryTax"
        Me.Txt_luxuryTax.Size = New System.Drawing.Size(96, 26)
        Me.Txt_luxuryTax.TabIndex = 666
        Me.Txt_luxuryTax.Text = ""
        Me.Txt_luxuryTax.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(448, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 669
        Me.Label3.Text = "Type Description :"
        '
        'Txt_Typedesc
        '
        Me.Txt_Typedesc.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Txt_Typedesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Typedesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Typedesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Typedesc.Location = New System.Drawing.Point(648, 120)
        Me.Txt_Typedesc.MaxLength = 35
        Me.Txt_Typedesc.Name = "Txt_Typedesc"
        Me.Txt_Typedesc.Size = New System.Drawing.Size(304, 26)
        Me.Txt_Typedesc.TabIndex = 668
        Me.Txt_Typedesc.Text = ""
        '
        'Txt_to
        '
        Me.Txt_to.BackColor = System.Drawing.Color.White
        Me.Txt_to.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_to.Location = New System.Drawing.Point(880, 320)
        Me.Txt_to.MaxLength = 2
        Me.Txt_to.Name = "Txt_to"
        Me.Txt_to.Size = New System.Drawing.Size(72, 29)
        Me.Txt_to.TabIndex = 675
        Me.Txt_to.Text = ""
        Me.Txt_to.Visible = False
        '
        'Txt_from
        '
        Me.Txt_from.BackColor = System.Drawing.Color.White
        Me.Txt_from.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_from.Location = New System.Drawing.Point(648, 320)
        Me.Txt_from.MaxLength = 2
        Me.Txt_from.Name = "Txt_from"
        Me.Txt_from.Size = New System.Drawing.Size(72, 29)
        Me.Txt_from.TabIndex = 674
        Me.Txt_from.Text = ""
        Me.Txt_from.Visible = False
        '
        'lbl_toage
        '
        Me.lbl_toage.AutoSize = True
        Me.lbl_toage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_toage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_toage.Location = New System.Drawing.Point(728, 320)
        Me.lbl_toage.Name = "lbl_toage"
        Me.lbl_toage.Size = New System.Drawing.Size(79, 25)
        Me.lbl_toage.TabIndex = 673
        Me.lbl_toage.Text = "To Age :"
        Me.lbl_toage.Visible = False
        '
        'lbl_fromage
        '
        Me.lbl_fromage.AutoSize = True
        Me.lbl_fromage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fromage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fromage.Location = New System.Drawing.Point(448, 320)
        Me.lbl_fromage.Name = "lbl_fromage"
        Me.lbl_fromage.Size = New System.Drawing.Size(102, 25)
        Me.lbl_fromage.TabIndex = 672
        Me.lbl_fromage.Text = "From Age :"
        Me.lbl_fromage.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 671
        Me.Label6.Text = "Based On :"
        '
        'Cbo_Basedontype
        '
        Me.Cbo_Basedontype.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cbo_Basedontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Basedontype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Basedontype.Items.AddRange(New Object() {"Consumption", "Facility", "Member Category", "Personal Age Based", "Membership Age Based"})
        Me.Cbo_Basedontype.Location = New System.Drawing.Point(648, 288)
        Me.Cbo_Basedontype.Name = "Cbo_Basedontype"
        Me.Cbo_Basedontype.Size = New System.Drawing.Size(184, 27)
        Me.Cbo_Basedontype.TabIndex = 670
        '
        'Txt_Ageto
        '
        Me.Txt_Ageto.BackColor = System.Drawing.Color.White
        Me.Txt_Ageto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Ageto.Location = New System.Drawing.Point(808, 320)
        Me.Txt_Ageto.MaxLength = 2
        Me.Txt_Ageto.Name = "Txt_Ageto"
        Me.Txt_Ageto.Size = New System.Drawing.Size(72, 29)
        Me.Txt_Ageto.TabIndex = 676
        Me.Txt_Ageto.Text = ""
        Me.Txt_Ageto.Visible = False
        '
        'Txt_Agefrom
        '
        Me.Txt_Agefrom.BackColor = System.Drawing.Color.White
        Me.Txt_Agefrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Agefrom.Location = New System.Drawing.Point(648, 320)
        Me.Txt_Agefrom.MaxLength = 2
        Me.Txt_Agefrom.Name = "Txt_Agefrom"
        Me.Txt_Agefrom.Size = New System.Drawing.Size(72, 29)
        Me.Txt_Agefrom.TabIndex = 677
        Me.Txt_Agefrom.Text = ""
        Me.Txt_Agefrom.Visible = False
        '
        'Label_Maxchar
        '
        Me.Label_Maxchar.AutoSize = True
        Me.Label_Maxchar.BackColor = System.Drawing.Color.Transparent
        Me.Label_Maxchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_Maxchar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Maxchar.ForeColor = System.Drawing.Color.Red
        Me.Label_Maxchar.Location = New System.Drawing.Point(360, 80)
        Me.Label_Maxchar.Name = "Label_Maxchar"
        Me.Label_Maxchar.Size = New System.Drawing.Size(69, 17)
        Me.Label_Maxchar.TabIndex = 678
        Me.Label_Maxchar.Text = "Max 4 Char"
        Me.Label_Maxchar.Visible = False
        '
        'lbl_todate
        '
        Me.lbl_todate.AutoSize = True
        Me.lbl_todate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_todate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_todate.Location = New System.Drawing.Point(696, 216)
        Me.lbl_todate.Name = "lbl_todate"
        Me.lbl_todate.Size = New System.Drawing.Size(97, 25)
        Me.lbl_todate.TabIndex = 680
        Me.lbl_todate.Text = "Period To:"
        Me.lbl_todate.Visible = False
        '
        'lbl_fromdate
        '
        Me.lbl_fromdate.AutoSize = True
        Me.lbl_fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fromdate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fromdate.Location = New System.Drawing.Point(448, 216)
        Me.lbl_fromdate.Name = "lbl_fromdate"
        Me.lbl_fromdate.Size = New System.Drawing.Size(125, 25)
        Me.lbl_fromdate.TabIndex = 679
        Me.lbl_fromdate.Text = "Period From :"
        Me.lbl_fromdate.Visible = False
        '
        'dtp_from
        '
        Me.dtp_from.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_from.CustomFormat = "MM/YYYY"
        Me.dtp_from.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_from.Location = New System.Drawing.Point(576, 216)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(112, 26)
        Me.dtp_from.TabIndex = 681
        '
        'dtp_to
        '
        Me.dtp_to.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_to.CustomFormat = "MM/YYYY"
        Me.dtp_to.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_to.Location = New System.Drawing.Point(800, 216)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(112, 26)
        Me.dtp_to.TabIndex = 682
        '
        'frmMemberSubscription
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(9, 22)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 606)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.lbl_todate)
        Me.Controls.Add(Me.lbl_fromdate)
        Me.Controls.Add(Me.Label_Maxchar)
        Me.Controls.Add(Me.Txt_Agefrom)
        Me.Controls.Add(Me.Txt_Ageto)
        Me.Controls.Add(Me.Txt_to)
        Me.Controls.Add(Me.Txt_from)
        Me.Controls.Add(Me.lbl_toage)
        Me.Controls.Add(Me.lbl_fromage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Typedesc)
        Me.Controls.Add(Me.Lbl_Luxurytax)
        Me.Controls.Add(Me.Txt_luxuryTax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_TaxAmt)
        Me.Controls.Add(Me.txt_TaxAccin)
        Me.Controls.Add(Me.txt_TaxCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_BillheadCode)
        Me.Controls.Add(Me.lbl_BillingMonth)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.lbl_BillingBasis)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.lbl_BillheadName)
        Me.Controls.Add(Me.txt_Total)
        Me.Controls.Add(Me.txt__BillheadName)
        Me.Controls.Add(Me.txt_Percentage)
        Me.Controls.Add(Me.lbl_Percentage)
        Me.Controls.Add(Me.lbl_BillheadCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cbo_Basedontype)
        Me.Controls.Add(Me.Cbo_Appliedon)
        Me.Controls.Add(Me.Grp_Print)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Btn_tax_help)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.cmd_BillheadCode)
        Me.Controls.Add(Me.chk_Subscrption)
        Me.Controls.Add(Me.chkList_BillingMonth)
        Me.Controls.Add(Me.cbo_Type)
        Me.Controls.Add(Me.cbo_BillingBasis)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.List_Billing_disp)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMemberSubscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBSCRIPTION MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grp_Print.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i As Integer
    Dim gconnection As New GlobalClass
    Dim subscriptionys As String
    Dim Bmonth As Integer ' variable for billingmonth
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Dim dates As String = "1900/JAN/01"
        Dim fdate, tdate As DateTime
        Dim taxp, total, amount, luxamount As Double
        Try
            Call checkValidation()
            If checkValid = False Then Exit Sub
            If cbo_BillingBasis.Text = "PERIOD" Then
                fdate = Format(CDate(dtp_from.Text), "dd/MMM/yyyy")
            Else
                fdate = Format(CDate(dates), "dd/MMM/yyyy")
            End If
            If cbo_BillingBasis.Text = "PERIOD" Then
                tdate = Format(CDate(dtp_to.Text), "dd/MMM/yyyy")
            Else
                tdate = Format(CDate(dates), "dd/MMM/yyyy")
            End If
            If txt_Percentage.Text = "" Then
                taxp = 0.0
            Else
                taxp = txt_Percentage.Text
            End If
            If txt_Total.Text = "" Then
                total = 0.0
            Else
                total = txt_Total.Text
            End If
            If txt_TaxAmt.Text = "" Then
                amount = 0.0
            Else
                amount = txt_TaxAmt.Text
            End If
            If Txt_luxuryTax.Text = "" Then
                luxamount = 0.0
            Else
                luxamount = Txt_luxuryTax.Text
            End If
            If cmd_AddNew.Text = "Add New[F5]" Then
                SqlString = "INSERT INTO  SubscriptionMast "
                SqlString = SqlString & "(subscode,subsdesc,type,billingbasis,billingmonth,total,percentage,TaxCode,TaxAccin,taxtotal,Luxurytax,AddUserid, AddDate, SubscriptionYN, freeze,Membershipfromage,Membershiptoage,personalfromage,personaltoage,fromdate,todate,FACILITY_FLG,appliedon,basedon)"
                SqlString = SqlString & "VALUES ('" & Trim(txt_BillheadCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt__BillheadName.Text) & "' , '" & Trim(cbo_Type.SelectedItem) & "' , '"
                SqlString = SqlString & Trim(cbo_BillingBasis.SelectedItem) & "' , '" & Trim(billingmonth) & " ' ,'" & Val(total)
                SqlString = SqlString & "','" & Trim(taxp) & "','" & Trim(txt_TaxCode.Text) & "','" & Trim(txt_TaxAccin.Text) & "', " & amount & "," & Val(luxamount)
                SqlString = SqlString & ",'" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & subscriptionys & "','N','" & Trim(Txt_from.Text) & "','" & Trim(Txt_to.Text) & "','" & Trim(Txt_Agefrom.Text) & "','" & Txt_Ageto.Text & "',Convert(datetime,'" & fdate & "',103),Convert(datetime,'" & tdate & "',103), "

                If cbo_Type.Text = "FAC" Then
                    SqlString = SqlString & "'F',"
                ElseIf cbo_Type.Text = "SPE" Then
                    SqlString = SqlString & "'S',"
                ElseIf cbo_Type.Text = "MUC" Then
                    SqlString = SqlString & "'M',"
                ElseIf cbo_Type.Text = "GEN" Then
                    SqlString = SqlString & "'G',"
                Else
                    SqlString = SqlString & "'G',"
                End If
                If Cbo_Appliedon.Text = "Member" Then
                    SqlString = SqlString & "'Member',"
                ElseIf Cbo_Appliedon.Text = "Dependent" Then
                    SqlString = SqlString & "'Dependent',"
                Else
                    SqlString = SqlString & "'',"
                End If

                If Cbo_Basedontype.Text = "Consumption" Then
                    SqlString = SqlString & "'Consumption')"
                ElseIf Cbo_Basedontype.Text = "Facility" Then
                    SqlString = SqlString & "'Facility')"
                ElseIf Cbo_Basedontype.Text = "Member Category" Then
                    SqlString = SqlString & "'MemberCategory')"
                ElseIf Cbo_Basedontype.Text = "Personal Age Based" Then
                    SqlString = SqlString & "'Personal Age Based')"
                ElseIf Cbo_Basedontype.Text = "Membership Age Based" Then
                    SqlString = SqlString & "'Membership Age Based')"
                Else
                    SqlString = SqlString & "'')"
                End If
                gconnection.dataOperation(1, SqlString, "SubscriptionMast")
                MessageBox.Show("Record saved  Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                If Mid(Me.cmd_AddNew.Text, 1, 1) = "U" Then
                    If Me.lbl_Frez.Visible = True Then
                        MsgBox(" The Frezzed Record Can Not Be Update", , "Club")
                        boolchk = False
                    End If
                End If

                SqlString = "UPDATE  SubscriptionMast "
                SqlString = SqlString & " SET subsdesc='" & Trim(txt__BillheadName.Text) & "',type='" & Trim(cbo_Type.Text) & "',billingbasis= '" & Trim(cbo_BillingBasis.SelectedItem) & "',billingmonth='" & Trim(billingmonth) & "', total= '" & Val(txt_Total.Text) & "',TaxCode='" & Trim(txt_TaxCode.Text) & "',TaxAccin='" & Trim(txt_TaxAccin.Text) & "', taxtotal=" & Val(txt_TaxAmt.Text) & ",Luxurytax= '" & Val(Txt_luxuryTax.Text) & "' "
                SqlString = SqlString & ",AddUserid='" & Trim(gUsername) & "',AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',SubscriptionYN= '" & subscriptionys & "',percentage='" & Trim(txt_Percentage.Text) & "', "
                SqlString = SqlString & " Membershipfromage='" & Trim(Txt_from.Text) & "',Membershiptoage='" & Trim(Txt_to.Text) & "' ,personalfromage='" & Trim(Txt_Agefrom.Text) & "' ,personaltoage='" & Trim(Txt_Ageto.Text) & "' ,fromdate=Convert(datetime,'" & fdate & "',103) , todate=Convert(datetime,'" & tdate & "',103) , "

                If cbo_Type.Text = "FAC" Then
                    SqlString = SqlString & " FACILITY_FLG='F', "
                ElseIf cbo_Type.Text = "SPE" Then
                    SqlString = SqlString & " FACILITY_FLG='S',"
                ElseIf cbo_Type.Text = "MUC" Then
                    SqlString = SqlString & " FACILITY_FLG='M', "
                ElseIf cbo_Type.Text = "GEN" Then
                    SqlString = SqlString & " FACILITY_FLG='G', "
                Else
                    SqlString = SqlString & " FACILITY_FLG='G', "
                End If

                If Cbo_Appliedon.Text = "Member" Then
                    SqlString = SqlString & " appliedon='Member',"
                ElseIf Cbo_Appliedon.Text = "Dependent" Then
                    SqlString = SqlString & " appliedon='Dependent',"
                End If

                If Cbo_Basedontype.Text = "Consumption" Then
                    SqlString = SqlString & " basedon='Consumption'"
                ElseIf Cbo_Basedontype.Text = "Facility" Then
                    SqlString = SqlString & " basedon='Facility'"
                ElseIf Cbo_Basedontype.Text = "Member Category" Then
                    SqlString = SqlString & " basedon='Member Category'"
                ElseIf Cbo_Basedontype.Text = "Personal Age Based" Then
                    SqlString = SqlString & " basedon='Personal Age Based'"
                ElseIf Cbo_Basedontype.Text = "Membership Age Based" Then
                    SqlString = SqlString & " basedon='Membership Age Based'"
                Else
                    SqlString = SqlString & " basedon =''"
                End If

                SqlString = SqlString & " WHERE subscode = '" & Trim(txt_BillheadCode.Text) & "'"
                gconnection.dataOperation(2, SqlString, "SubscriptionMast")
                MessageBox.Show("Record Updated Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Club")
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Grp_Print.Visible = True
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        List_Billing_disp.Items.Clear()
        For i = 0 To chkList_BillingMonth.Items.Count - 1
            chkList_BillingMonth.SetItemChecked(i, False)
        Next i
        cbo_Type.SelectedIndex = -1
        cbo_BillingBasis.SelectedIndex = -1
        Cbo_Appliedon.SelectedIndex = -1
        Cbo_Basedontype.SelectedIndex = -1
        chkList_BillingMonth.SelectedIndex = -1
        List_Billing_disp.SelectedIndex = -1
        txt_BillheadCode.Enabled = True
        cbo_Type.Enabled = True
        cbo_BillingBasis.Enabled = True
        txt_BillheadCode.Focus()
        lbl_Frez.Visible = False
        ''chkList_BillingMonth.Enabled = True
        Txt_Agefrom.Text = ""
        Txt_Ageto.Text = ""
        Txt_from.Text = ""
        Txt_to.Text = ""
        cmd_AddNew.Text = "Add New[F5]"

    End Sub
    Private Sub chk_Subscrption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Subscrption.CheckedChanged
        If chk_Subscrption.Checked = True Then
            lbl_BillheadCode.Text = "Subscription Code :"
            lbl_BillheadName.Text = "Subscription Name :"
            cbo_Type.Enabled = True
            cbo_BillingBasis.Enabled = True
            '' chkList_BillingMonth.Enabled = True
            txt_BillheadCode.Focus()
        Else
            lbl_BillheadCode.Text = "BillHead Code :"
            lbl_BillheadName.Text = "BillHead Name :"
            cbo_Type.Enabled = True
            cbo_BillingBasis.Enabled = False
            ''chkList_BillingMonth.Enabled = False
        End If
    End Sub
    Private Sub txt_BillheadCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BillheadCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_BillheadCode.Text = "" Then
                Call cmd_BillheadCode_Click(sender, e)
            End If
        End If
        getAlphanumeric(e)
    End Sub
    Private Sub txt__BillheadName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt__BillheadName.KeyPress
        getCharater(e)
        'getAlphanumeric(e)
    End Sub
    Private Sub txt_Total_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Total.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txt_Total.Text <> "" Then

            End If
        End If
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    txt_BillheadCode.Focus()
        'End If
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Delete.Text, 1, 1) = "F" Then
            SqlString = "UPDATE  SubscriptionMast "
            SqlString = SqlString & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE subscode = '" & txt_BillheadCode.Text & " '"
            gconnection.dataOperation(3, SqlString, "SubscriptionMast")
            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        Else
            SqlString = "UPDATE  SubscriptionMast "
            SqlString = SqlString & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE subscode = '" & txt_BillheadCode.Text & " '"
            gconnection.dataOperation(4, SqlString, "SubscriptionMast")
            MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        End If
    End Sub
    Private Sub cmd_BillheadCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BillheadCode.Click
        '''Clear Chklist_billingMonth
        For i = 0 To chkList_BillingMonth.Items.Count - 1
            chkList_BillingMonth.SetItemChecked(i, False)
        Next i
        Dim vform As New ListOperation
        gSQLString = "Select subscode,subsdesc from SubscriptionMast"
        M_WhereCondition = " "
        vform.Field = "subscode,subsdesc"
        vform.vFormatstring = "  Subscription Code  | Subscription Description                           "
        vform.vCaption = "Subscription Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_BillheadCode.Text = Trim(vform.keyfield & "")
            txt__BillheadName.Select()
            Me.txt_BillheadCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_AddNew.Text = "Update[F5]"
    End Sub
    Private Sub cbo_Type_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Type.KeyPress
        BLANK(e)
    End Sub
    Private Sub cbo_BillingBasis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BillingBasis.KeyPress
        BLANK(e)
        If Asc(e.KeyChar) = 13 Then
            If cbo_BillingBasis.Text <> "" Then
                txt_Total.Focus()
            End If
        End If
    End Sub
    Private Sub txt_BillheadCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillheadCode.Validated
        Dim Sreader As New DataTable
        Dim ssql, str, str1 As String
        Dim i As Integer = 0
        Dim J As Integer = 0
        'ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS PERCENTAGE,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS TAX,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXAMT,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE From SubscriptionMast Where subscode='" & Me.txt_BillheadCode.Text & "'"
        ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(ADDDATE,'') AS ADDDATE,ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS Percentage,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(SIDELEDGERCODE,'') AS SIDELEDGERCODE,ISNULL(SIDELEDGERDESC,'') AS SIDELEDGERDESC,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS taxcode,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXTOTAL,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE,ISNULL(FACILITY_FLG,'') AS FACILITY_FLG ,ISNULL(APPLIEDON,'') AS APPLIEDON,ISNULL(BASEDON,'') AS BASEDON,ISNULL(Membershipfromage,'') AS Membershipfromage,ISNULL(Membershiptoage,'') AS Membershiptoage,ISNULL(personalfromage,'') AS personalfromage,ISNULL(personaltoage,'') AS personaltoage,ISNULL(Luxurytax,0)AS Luxurytax,fromdate,todate From SubscriptionMast Where subscode='" & Me.txt_BillheadCode.Text & "'"
        Sreader = gconnection.GetValues(ssql)
        If Sreader.Rows.Count > 0 Then
            Me.txt_BillheadCode.Enabled = False
            Me.Txt_Typedesc.Enabled = False
            Me.txt__BillheadName.Text = Sreader.Rows(0).Item("subsdesc")

            cbo_Type.Text = Sreader.Rows(0).Item("type")
            Cbo_Appliedon.Text = Sreader.Rows(0).Item("APPLIEDON")
            Cbo_Basedontype.Text = Sreader.Rows(0).Item("BASEDON")
            cbo_BillingBasis.Text = Sreader.Rows(0).Item("BillingBasis")
            txt_Total.Text = Format(Sreader.Rows(0).Item("total"), "0.00")
            Txt_luxuryTax.Text = Format(Sreader.Rows(0).Item("Luxurytax"), "0.00")
            Me.txt_TaxCode.Text = Sreader.Rows(0).Item("TaxCode")
            Me.txt_TaxAccin.Text = Sreader.Rows(0).Item("TAXACCIN")
            Me.txt_TaxAmt.Text = Sreader.Rows(0).Item("TAXTOTAL")
            Me.txt_Percentage.Text = Sreader.Rows(0).Item("Percentage")
            Me.Txt_from.Text = Sreader.Rows(0).Item("Membershipfromage")
            Me.Txt_to.Text = Sreader.Rows(0).Item("Membershiptoage")
            Me.Txt_Agefrom.Text = Sreader.Rows(0).Item("personalfromage")
            Me.Txt_Ageto.Text = Sreader.Rows(0).Item("personaltoage")
            If Sreader.Rows(0).Item("BILLINGBASIS") = "PERIOD" Then
                lbl_fromdate.Visible = True
                lbl_todate.Visible = True
                dtp_from.Visible = True
                dtp_to.Visible = True
                Me.dtp_from.Value = Sreader.Rows(0).Item("fromdate")
                Me.dtp_to.Value = Sreader.Rows(0).Item("todate")
            Else
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False
            End If


            If Sreader.Rows(0).Item("SubscriptionYN") = "Y" Then
                chk_Subscrption.Checked = True
                chk_Subscrption.BackColor = Color.Cyan
            Else
                chk_Subscrption.Checked = False
                chk_Subscrption.BackColor = Color.Silver
            End If
            str = ""
            str1 = ""
            str = Trim(CStr(Sreader.Rows(0).Item("billingmonth")))
            'MODIFIED  by srinivas
            Me.cmd_AddNew.Text = "Update[F5]"
            Dim RetriveMonth() As String
            RetriveMonth = str.Split("|")
            '----------------------------------------------
            chkList_BillingMonth.Enabled = True
            chkList_BillingMonth.ClearSelected()
            List_Billing_disp.Items.Clear()
            For i = 0 To chkList_BillingMonth.Items.Count - 1
                chkList_BillingMonth.SetItemChecked(i, False)
            Next
            Try
                If cbo_BillingBasis.Text = "QUARTERLY" Then
                    'chkList_BillingMonth.SetItemChecked((3), True)
                    'chkList_BillingMonth.SetSelected(0, True)
                    'List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    'chkList_BillingMonth.SetItemChecked((7), True)
                    'chkList_BillingMonth.SetSelected(3, True)
                    'List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    'chkList_BillingMonth.SetItemChecked((10), True)
                    'chkList_BillingMonth.SetSelected(6, True)
                    'List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    'chkList_BillingMonth.SetItemChecked((1), True)
                    'chkList_BillingMonth.SetSelected(9, True)
                    'List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    chkList_BillingMonth.SetItemChecked((0), True)
                    chkList_BillingMonth.SetSelected(0, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    chkList_BillingMonth.SetItemChecked((2), True)
                    chkList_BillingMonth.SetSelected(2, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    chkList_BillingMonth.SetItemChecked((5), True)
                    chkList_BillingMonth.SetSelected(5, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    chkList_BillingMonth.SetItemChecked((8), True)
                    chkList_BillingMonth.SetSelected(8, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)

                ElseIf cbo_BillingBasis.Text = "HALF YEARLY" Then
                    chkList_BillingMonth.SetItemChecked((0), True)
                    chkList_BillingMonth.SetSelected(0, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    chkList_BillingMonth.SetItemChecked((6), True)
                    chkList_BillingMonth.SetSelected(6, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                ElseIf cbo_BillingBasis.Text = "NONE" Then
                    chkList_BillingMonth.ClearSelected()
                    '                chkList_BillingMonth.Enabled = False
                ElseIf cbo_BillingBasis.Text = "MONTHLY" Then
                    For i = 0 To chkList_BillingMonth.Items.Count - 1
                        chkList_BillingMonth.SetItemChecked(i, True)
                        chkList_BillingMonth.SetSelected(i, True)
                        List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                    Next
                Else
                    chkList_BillingMonth.SetItemChecked((0), True)
                    chkList_BillingMonth.SetSelected(0, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                End If
                chkList_BillingMonth.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '------------------------------------------------
            ''If RetriveMonth(0) <> "" And RetriveMonth(0) = "N" Then
            ''    For i = 0 To RetriveMonth.Length - 2
            ''        chkList_BillingMonth.SetItemChecked(CInt(RetriveMonth(i)) - 1, True)
            ''        chkList_BillingMonth.SetSelected(CInt(RetriveMonth(i)) - 1, True)
            ''        chkList_BillingMonth.SetItemChecked((Int32.Parse(RetriveMonth(i)) - 1), True)
            ''        chkList_BillingMonth.SetSelected((Int32.Parse(RetriveMonth(i)) - 1), True)
            ''    Next
            ''    If RetriveMonth.Length = 1 Then
            ''        chkList_BillingMonth.SetItemChecked((Int32.Parse(RetriveMonth(0)) - 1), True)
            ''        chkList_BillingMonth.SetSelected((Int32.Parse(RetriveMonth(0)) - 1), True)
            ''    End If
            ''End If
            SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(cbo_Type.Text) & "'and freeze<>'Y'  "
            gconnection.getDataSet(SqlString, "MemMst")
            If gdataset.Tables("MemMst").Rows.Count > 0 Then
                Txt_Typedesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
            End If


            If Sreader.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(Sreader.Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                Me.cmd_Delete.Text = "UnFreeze[F7]"
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Freezed  On "
                Me.cmd_Delete.Text = "Freeze[F7]"
            End If

        Else
            Me.txt_BillheadCode.Enabled = True
            Me.txt__BillheadName.Text = ""
            Me.lbl_Frez.Visible = False
            Me.lbl_Frez.Text = "Record Freezed  On "
            Me.cmd_AddNew.Text = "Add New[F5]"
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Dim loop1
        'Try
        '    SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(cbo_Type.Text) & "'and freeze<>'Y'  "
        '    gconnection.getDataSet(SqlString, "MemMst")
        '    If gdataset.Tables("MemMst").Rows.Count > 0 Then
        '        Txt_Typedesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub
    Function basis()
        'Dim CHECKED1 As Integer
        'If cbo_BillingBasis.SelectedItem = "MONTHLY" Then
        '    For i = 0 To chkList_BillingMonth.Items.Count - 1
        '        chkList_BillingMonth.SetItemChecked(i, True)
        '    Next
        'ElseIf cbo_BillingBasis.SelectedItem = "YEARLY" Or cbo_BillingBasis.SelectedItem = "QUARTERLY (For Month)" Then
        '    billingmonth = ""
        '    checked = checked + 1
        '    If checked = 10 Or checked = 11 Or checked = 12 Then
        '        billingmonth = checked
        '    Else
        '        billingmonth = "0" & checked
        '    End If
        'ElseIf cbo_BillingBasis.SelectedItem = "HALF YEARLY" Then
        '    billingmonth = ""
        '    checked = checked + 1
        '    If checked = 10 Or checked = 11 Or checked = 12 Then
        '        billingmonth = checked
        '    Else
        '        billingmonth = "0" & checked
        '    End If
        '    checked = checked + 6
        '    If checked > 12 Then
        '        CHECKED1 = checked Mod 12
        '    Else
        '        CHECKED1 = checked
        '    End If
        '    If CHECKED1 = 10 Or CHECKED1 = 11 Or CHECKED1 = 12 Then
        '        billingmonth = billingmonth & "|" & CHECKED1
        '    Else
        '        billingmonth = billingmonth & "|0" & CHECKED1
        '    End If

        'ElseIf cbo_BillingBasis.SelectedItem = "QUARTERLY" Then
        '    billingmonth = ""
        '    checked = checked + 1
        '    If checked = 10 Or checked = 11 Or checked = 12 Then
        '        billingmonth = checked
        '    Else
        '        billingmonth = "0" & checked
        '    End If
        '    For i = 0 To 2
        '        checked = checked + 3
        '        If checked > 12 Then
        '            CHECKED1 = checked Mod 12
        '        Else
        '            CHECKED1 = checked
        '        End If
        '        If CHECKED1 = 10 Or CHECKED1 = 11 Or CHECKED1 = 12 Then
        '            billingmonth = billingmonth & "|" & CHECKED1
        '        Else
        '            billingmonth = billingmonth & "|0" & CHECKED1
        '        End If
        '    Next
        '    billingmonth = billingmonth & "|"
        'Else
        '    billingmonth = "N"
        'End If
        '' MsgBox(billingmonth)
        'modified by srinivas++++++++++++++++++++++++++++++++++++++++++++++++++==========
        'If cbo_BillingBasis.SelectedItem = "YEARLY" Or cbo_BillingBasis.SelectedItem = "QUARTERLY (For Month)" Then
        If cbo_BillingBasis.SelectedItem = "YEARLY" Or cbo_BillingBasis.SelectedItem = "QUARTERLY (For Month)" Then
            Bmonth = 1
            billingmonth = Bmonth
        ElseIf cbo_BillingBasis.SelectedItem = "HALF YEARLY" Then
            Bmonth = 1
            If Bmonth <= 6 Then
                billingmonth = Bmonth & "|" & (Bmonth + 6) & "|"
            Else
                billingmonth = Bmonth & "|" & (Bmonth - 6) & "|"
            End If
        ElseIf cbo_BillingBasis.SelectedItem = "QUARTERLY" Then
            If (Bmonth = 1 Or Bmonth = 4 Or Bmonth = 7 Or Bmonth = 10) Then
                Bmonth = 1
            ElseIf (Bmonth = 2 Or Bmonth = 5 Or Bmonth = 8 Or Bmonth = 11) Then
                Bmonth = 2
            ElseIf (Bmonth = 3 Or Bmonth = 6 Or Bmonth = 9 Or Bmonth = 12) Then
                Bmonth = 3
            End If
            Bmonth = 1
            '  billingmonth = Bmonth & "|" & (Bmonth + 3) & "|" & (Bmonth + 6) & "|" & (Bmonth + 9) & "|"
            'If gCompanyname = "" Then
            billingmonth = "|" & (Bmonth + 3) & "|" & (Bmonth + 5) & "|" & (Bmonth + 8) & "|" & (Bmonth + 11) & "|"

            ElseIf cbo_BillingBasis.SelectedItem = "MONTHLY" Then
            billingmonth = "|" & "1" & "|" & "2" & "|" & "3" & "|" & "4" & "|" & "5" & "|" & "6" & "|" & "7" & "|" & "8" & "|" & "9" & "|" & "10" & "|" & "11" & "|" & "12" & "|"
            Else
                ' billingmonth = "N"
                'MsgBox("Enter Billing Month . . .")
                billingmonth = ""
            End If
    End Function
    Public Sub checkValidation()
        checkValid = True
        boolchk = False
        Call basis() '''-->CHECKING THE BILLING BASIS
        If chk_Subscrption.Checked = True Then
            subscriptionys = "Y"
        Else
            subscriptionys = "N"
        End If
        '''********** Check Billhead Code is blank
        If Trim(txt_BillheadCode.Text) = "" Then
            If chk_Subscrption.Checked = True Then
                MessageBox.Show(" Subscription Code can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(" BillHead Code can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            checkValid = False
            txt_BillheadCode.Focus()
            Exit Sub
        End If
        '''********** Check Billhead Name is blank
        If Trim(txt__BillheadName.Text) = "" Then
            If chk_Subscrption.Checked = True Then
                MessageBox.Show(" Subscription Name can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show(" BillHead Name can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            checkValid = False
            txt__BillheadName.Focus()
            Exit Sub
        End If
        '''********** Check Total Field is blank
        If Val(txt_Total.Text) = 0 Then
            MessageBox.Show(" Total Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Total.Focus()
            checkValid = False
            Exit Sub
        End If
       
        '''********** Check Billing Basis Field is blank
        If chk_Subscrption.Checked = True Then
            If Trim(cbo_BillingBasis.Text) = "" Then
                MessageBox.Show(" Billing Basis Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbo_BillingBasis.Focus()
                checkValid = False
                Exit Sub
            End If
        End If
        '''********** Check Type Feild is blank
        If cbo_Type.Text = "" Then
            MessageBox.Show(" SubscriptionType can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_Type.Focus()
            checkValid = False
            Exit Sub
        End If
        '''*********** Check Billing Month
        'If cbo_BillingBasis.Text <> "NONE" Then
        '    If chkList_BillingMonth.CheckedItems.Count = 0 Then
        '        MessageBox.Show(" BillingMonth Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        chkList_BillingMonth.Focus()
        '        checkValid = False
        '        Exit Sub
        '    End If
        'End If
        '''*********** Check Billing Month
        If Cbo_Appliedon.Text = "" Then
            MessageBox.Show(" Applied on Membership can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cbo_Appliedon.Focus()
            checkValid = False
            Exit Sub
        End If
        If Cbo_Basedontype.Text = "" Then
            MessageBox.Show(" Based on Membership can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_Type.Focus()
            checkValid = False
            Exit Sub
        End If

        'If Cbo_Basedontype.Text = "" Then
        '    MessageBox.Show(" Based on Membership Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Cbo_Appliedon.Focus()
        '    checkValid = False
        '    Exit Sub
        'End If

        If Mid(cmd_AddNew.Text, 1, 1) = "A" Then
            Dim SQLSTRING As String
            SQLSTRING = "SELECT SUBSCODE,SUBSDESC FROM SUBSCRIPTIONMAST"
            gconnection.getDataSet(SQLSTRING, "SUBSCRIPTIONMAST")
            If gdataset.Tables("SUBSCRIPTIONMAST").Rows.Count Then
                For i = 0 To gdataset.Tables("SUBSCRIPTIONMAST").Rows.Count - 1
                    If Trim(txt_BillheadCode.Text) = gdataset.Tables("SUBSCRIPTIONMAST").Rows(i).Item("SUBSCODE") Then
                        MessageBox.Show("Specified SUBSCODE already available in database", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        txt_BillheadCode.Focus()
                        checkValid = False
                        Exit Sub
                    End If
                    If Trim(txt__BillheadName.Text) = gdataset.Tables("SUBSCRIPTIONMAST").Rows(i).Item("SUBSDESC") Then
                        MessageBox.Show("Specified SUBSDESC already available in database", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        txt__BillheadName.Focus()
                        checkValid = False
                        Exit Sub
                    End If
                Next

            End If
        End If
        boolchk = True
    End Sub
    Private Sub txt_BillheadCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BillheadCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt__BillheadName.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_BillheadCode_Click(sender, e)
        End If
    End Sub

    Private Sub txt__BillheadName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt__BillheadName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_Subscrption.Checked = False Then
                txt_Total.Focus()
            Else
                cbo_Type.Focus()
            End If

        End If
    End Sub

    Private Sub cbo_Type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_Type.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
        SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(cbo_Type.Text) & "'and freeze<>'Y'  "
        gconnection.getDataSet(SqlString, "MemMst")
        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            Txt_Typedesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
        End If
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbo_BillingBasis.Text = "NONE" Then
                txt_Total.Focus()
            Else
                chkList_BillingMonth.Focus()
            End If
        End If
    End Sub
    Private Sub chkList_BillingMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chkList_BillingMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Total.Focus()
        End If
    End Sub
    Private Sub txt_Total_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Total.KeyDown
        Dim TAX As Double

        If e.KeyCode = Keys.Enter Then
            If cmd_AddNew.Text = "Add New[F5]" Then
                'txt_TaxAccin.ReadOnly = True
                TAX = Format((Val(txt_Total.Text)), "0.00") * taxcode
                'txt_TaxAmt.ReadOnly = False
                txt_TaxAmt.Text = Format(Val(TAX / 100), "0.00")
                'txt_Percentage.Text = taxcode
                'txt_Percentage.ReadOnly = True
                'txt_TaxAmt.ReadOnly = True
            Else
                TAX = Format((Val(txt_Total.Text)), "0.00") * Format(Val(Trim(txt_Percentage.Text & "")), "0.00")
                txt_TaxAmt.Text = Format(Val(TAX / 100), "0.00")

            End If

        End If
    End Sub

    Private Sub frmMemberSubscription_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub chk_Subscrption_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_Subscrption.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BillheadCode.Focus()
        End If
    End Sub
    Private Sub chk_Subscrption_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Subscrption.GotFocus
        chk_Subscrption.BackColor = Color.Cyan
    End Sub
    Private Sub chk_Subscrption_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Subscrption.LostFocus
        If chk_Subscrption.Checked = False Then
            chk_Subscrption.BackColor = Color.Silver
        End If
    End Sub
    Private Sub chkList_BillingMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkList_BillingMonth.SelectedIndexChanged
        'chkList_BillingMonth.Enabled = False
        'List_Billing_disp.ClearSelected()
        'For i = 0 To chkList_BillingMonth.SelectedItems.Count - 1
        '    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
        'Next
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        chkList_BillingMonth.Enabled = True
        chkList_BillingMonth.ClearSelected()
        List_Billing_disp.Items.Clear()
        For i = 0 To chkList_BillingMonth.Items.Count - 1
            chkList_BillingMonth.SetItemChecked(i, False)
        Next
        Try
            
            If cbo_BillingBasis.Text = "QUARTERLY" Then
                chkList_BillingMonth.SetItemChecked((0), True)
                chkList_BillingMonth.SetSelected(0, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                chkList_BillingMonth.SetItemChecked((2), True)
                chkList_BillingMonth.SetSelected(2, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                chkList_BillingMonth.SetItemChecked((5), True)
                chkList_BillingMonth.SetSelected(5, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                chkList_BillingMonth.SetItemChecked((8), True)
                chkList_BillingMonth.SetSelected(8, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False
            ElseIf cbo_BillingBasis.Text = "HALF YEARLY" Then
                chkList_BillingMonth.SetItemChecked((0), True)
                chkList_BillingMonth.SetSelected(0, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                chkList_BillingMonth.SetItemChecked((6), True)
                chkList_BillingMonth.SetSelected(6, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False

            ElseIf cbo_BillingBasis.Text = "NONE" Then
                chkList_BillingMonth.ClearSelected()
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False
            ElseIf cbo_BillingBasis.Text = "MONTHLY" Then
                For i = 0 To chkList_BillingMonth.Items.Count - 1
                    chkList_BillingMonth.SetItemChecked(i, True)
                    chkList_BillingMonth.SetSelected(i, True)
                    List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
                Next
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False
            ElseIf cbo_BillingBasis.Text = "PERIOD" Then
                lbl_fromdate.Visible = True
                lbl_todate.Visible = True
                dtp_from.Visible = True
                dtp_to.Visible = True
            Else
                lbl_fromdate.Visible = False
                lbl_todate.Visible = False
                dtp_from.Visible = False
                dtp_to.Visible = False
                chkList_BillingMonth.SetItemChecked((0), True)
                chkList_BillingMonth.SetSelected(0, True)
                List_Billing_disp.Items.Add(chkList_BillingMonth.SelectedItem)
            End If
            chkList_BillingMonth.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Total_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Total.LostFocus
        txt_Total.Text = Format(Val(txt_Total.Text), "0.00")
    End Sub


    Private Sub frmMemberSubscription_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call SubscriptionType()
        'cbo_Type.Enabled = False
        cbo_BillingBasis.Enabled = False
        chk_Subscrption.Checked = True
        lbl_fromdate.Visible = False
        lbl_todate.Visible = False
        dtp_from.Visible = False
        dtp_to.Visible = False

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


    Private Sub txt_BillheadCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BillheadCode.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt__BillheadName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt__BillheadName.TextChanged

    End Sub

    Private Sub lbl_BillheadName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_BillheadName.Click

    End Sub

    Private Sub lbl_BillingBasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_BillingBasis.Click

    End Sub

    Private Sub lbl_BillheadCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_BillheadCode.Click

    End Sub

    Private Sub cbo_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Type.SelectedIndexChanged

    End Sub

    Private Sub Btn_tax_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_tax_help.Click
        Dim vform As New ListOperation
        Dim TAX, TPER As Double
        ''gSQLString = "SELECT TAXCODE ,TAXDESC,TAXPERCENTAGE,GLACCOUNTIN FROM ACCOUNTSTAXMASTER"
        gSQLString = " select GROUPCODE AS TAXCODE,GROUPNAME AS TAXDESC,(TAXPERCENTAGE) AS TAXPERCENTAGE,'' AS GLACCOUNTIN from ACCOUNTSTAXGROUPMASTER "
        M_WhereCondition = " "
        ''vform.Field = "TAXCODE,TAXDESC,GLACCOUNTIN "
        vform.Field = "GROUPCODE,GROUPNAME "
        vform.vFormatstring = "      TAXCODE      |          TAXDESC                     |    TAXPERCENTAGE | GLACCOUNTIN |"
        vform.vCaption = "TAX ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_TaxCode.Text = Trim(vform.keyfield & "")
            txt_TaxAccin.ReadOnly = False
            txt_TaxAccin.Text = Trim(vform.keyfield3 & "")
            txt_TaxAccin.ReadOnly = True
            taxcode = Format(Val(Trim(vform.keyfield2 & "")), "0.00")
            TPER = gconnection.getvalue("select SUM(TAXPERCENTAGE) AS TAXPERCENTAGE from ACCOUNTSTAXGROUPMASTER WHERE GROUPCODE = '" & Trim(vform.keyfield & "") & "'")
            ''TAX = Format((Val(txt_Total.Text)), "0.00") * Format(Val(Trim(vform.keyfield2 & "")), "0.00")
            TAX = Format((Val(txt_Total.Text)), "0.00") * Format(Val(TPER), "0.00")
            txt_TaxAmt.ReadOnly = False
            txt_TaxAmt.Text = Format(Val(TAX / 100), "0.00")
            'txt_Percentage.Text = Format(Val(Trim(vform.keyfield2 & "")), "0.00")
            txt_Percentage.Text = Format(Val(TPER), "0.00")
            txt_Percentage.ReadOnly = True
            txt_TaxAmt.ReadOnly = True
            ''    txt__BillheadName.Select()
            ''  Me.txt_BillheadCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_DOS.Click
        Dim FrReport As New ReportDesigner
        Dim bill() As Integer = {}
        tables = " FROM SubscriptionMast"
        Gheader = "SUBSCRIPTION MASTER"
        FrReport.SsGridReport.SetText(2, 1, "subscode")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "subsdesc")
        FrReport.SsGridReport.SetText(3, 2, 20)
        FrReport.SsGridReport.SetText(2, 3, "type")
        FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 4, "billingbasis")
        FrReport.SsGridReport.SetText(3, 4, 10)
        FrReport.SsGridReport.SetText(2, 5, "billingmonth")
        FrReport.SsGridReport.SetText(3, 5, 30)
        FrReport.SsGridReport.SetText(2, 6, "total")
        FrReport.SsGridReport.SetText(3, 6, 10)
        FrReport.SsGridReport.SetText(2, 7, "instalment")
        FrReport.SsGridReport.SetText(3, 7, 6)
        FrReport.SsGridReport.SetText(2, 8, "SubsAcctIn")
        FrReport.SsGridReport.SetText(3, 8, 10)
        FrReport.SsGridReport.SetText(2, 9, "subsacctindesc")
        FrReport.SsGridReport.SetText(3, 9, 20)
        FrReport.SsGridReport.SetText(2, 10, "SubscriptionYN")
        FrReport.SsGridReport.SetText(3, 10, 15)
        FrReport.SsGridReport.SetText(2, 11, "FREEZE")
        FrReport.SsGridReport.SetText(3, 11, 7)
        FrReport.Show()
    End Sub

    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New ReportViwer
        Dim r As New Cry_subscriptionmast
        If Chk_freeze.Checked = True Then
            SqlString = "select * from mm_subscriptionmaster where freeze='Y'"
        Else
            SqlString = "select * from mm_subscriptionmaster where freeze='N'"
        End If
        Call Viewer.GetDetails1(SqlString, "mm_subscriptionmaster", r)
        txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        txtobj1.Text = UCase(gCompanyname)
        txtobj1 = r.ReportDefinition.ReportObjects("Text19")
        txtobj1.Text = UCase(gCompanyAddress(1))
        txtobj1 = r.ReportDefinition.ReportObjects("Text11")
        txtobj1.Text = UCase(gCompanyAddress(2))
        txtobj1 = r.ReportDefinition.ReportObjects("Text10")
        txtobj1.Text = UCase(gCompanyAddress(3))
        txtobj1 = r.ReportDefinition.ReportObjects("Text14")
        txtobj1.Text = UCase(gUsername)
        Viewer.Show()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Grp_Print.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Cbo_Basedontype.Text = "Personal Age Based" Then
        '    lbl_fromage.Text = "From Age"
        '    lbl_fromage.Visible = True
        '    lbl_toage.Text = "To Age"
        '    lbl_toage.Visible = True
        '    Txt_from.Visible = True
        '    Txt_to.Visible = True
        'ElseIf Cbo_Basedontype.Text = "Membership Age Based" Then
        '    lbl_fromage.Text = "Membership From"
        '    lbl_fromage.Visible = True
        '    lbl_toage.Text = "Membership To"
        '    lbl_toage.Visible = True
        '    Txt_from.Visible = True
        '    Txt_to.Visible = True
        'Else
        '    lbl_fromage.Visible = False
        '    lbl_toage.Visible = False
        '    Txt_from.Visible = False
        '    Txt_to.Visible = False
        'End If
    End Sub
    Public Sub SubscriptionType()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_Type.Items.Add(dt.Rows(Itration).Item("Code"))
        Next
    End Sub

    Private Sub Cbo_Basedontype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Basedontype.SelectedIndexChanged
        If Cbo_Basedontype.Text = "Personal Age Based" Then
            lbl_fromage.Text = "From Age"
            lbl_fromage.Visible = True
            lbl_toage.Text = "To Age"
            lbl_toage.Visible = True
            Txt_from.Visible = False
            Txt_to.Visible = False
            Txt_Agefrom.Visible = True
            Txt_Ageto.Visible = True
        ElseIf Cbo_Basedontype.Text = "Membership Age Based" Then
            lbl_fromage.Text = "Membership From"
            lbl_fromage.Visible = True
            lbl_toage.Text = "Membership To"
            lbl_toage.Visible = True
            Txt_from.Visible = True
            Txt_to.Visible = True
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        Else
            lbl_fromage.Visible = False
            lbl_toage.Visible = False
            Txt_from.Visible = False
            Txt_to.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        End If
    End Sub

    Private Sub txt_TaxCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TaxCode.TextChanged

    End Sub

    Private Sub txt_TaxCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TaxCode.Validated
        If txt_TaxCode.Text <> "" Then
            txt_TaxCode.ReadOnly = True
            txt_TaxAccin.ReadOnly = True
        End If

    End Sub

    Private Sub txt_TaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TaxCode.KeyDown

    End Sub

    Private Sub txt_TaxCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TaxCode.KeyPress
        txt_TaxCode_Validated(sender, e)
    End Sub

    Private Sub txt_TaxAccin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TaxAccin.TextChanged

    End Sub

    Private Sub txt_TaxAccin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TaxAccin.KeyDown
        txt_TaxCode_Validated(sender, e)
    End Sub

    Private Sub txt_Total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Total.TextChanged

    End Sub
End Class
