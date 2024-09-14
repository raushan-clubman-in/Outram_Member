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
Public Class addchg_Posting
    Inherits System.Windows.Forms.Form
    Dim sqlstring, FCODE, FNAME, DNAME, DCODE, mtype(0), INSERT(0) As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Dim posting, posting1 As New DataTable
    Dim i, j As Integer
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chk_Membername As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chklist_Membertype As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lab_acdesc As System.Windows.Forms.Label
    Friend WithEvents grp_add As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdaccthelp As System.Windows.Forms.Button
    Friend WithEvents TXT_ACCODE As System.Windows.Forms.TextBox
    Friend WithEvents SSGRID_MEM As AxFPSpreadADO.AxfpSpread
    Friend WithEvents txt_tax_per As System.Windows.Forms.TextBox
    Friend WithEvents txt_taxacct As System.Windows.Forms.TextBox
    Friend WithEvents btn_tax_help As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lab_tax_desc As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_description As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents dtp_Postdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid_det As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents rnd_debit As System.Windows.Forms.RadioButton
    Friend WithEvents rnd_credit As System.Windows.Forms.RadioButton
    Friend WithEvents SSGRID1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents btn_Revert As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(addchg_Posting))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_Membername = New System.Windows.Forms.CheckBox
        Me.chklist_Membertype = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_description = New System.Windows.Forms.TextBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtp_Postdate = New System.Windows.Forms.DateTimePicker
        Me.grp_add = New System.Windows.Forms.GroupBox
        Me.SSGRID1 = New AxFPSpreadADO.AxfpSpread
        Me.Label6 = New System.Windows.Forms.Label
        Me.btn_tax_help = New System.Windows.Forms.Button
        Me.lab_tax_desc = New System.Windows.Forms.Label
        Me.txt_tax_per = New System.Windows.Forms.TextBox
        Me.cmdaccthelp = New System.Windows.Forms.Button
        Me.TXT_ACCODE = New System.Windows.Forms.TextBox
        Me.SSGRID_MEM = New AxFPSpreadADO.AxfpSpread
        Me.lab_acdesc = New System.Windows.Forms.Label
        Me.rnd_debit = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.rnd_credit = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_taxacct = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btn_Revert = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.AxfpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.ssgrid_det = New AxFPSpreadADO.AxfpSpread
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_add.SuspendLayout()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSGRID_MEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssgrid_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(296, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 24)
        Me.Label4.TabIndex = 424
        Me.Label4.Text = "Member List"
        '
        'Chk_Membername
        '
        Me.Chk_Membername.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Membername.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Membername.Location = New System.Drawing.Point(296, 64)
        Me.Chk_Membername.Name = "Chk_Membername"
        Me.Chk_Membername.Size = New System.Drawing.Size(141, 24)
        Me.Chk_Membername.TabIndex = 423
        Me.Chk_Membername.Text = "SELECT ALL"
        '
        'chklist_Membertype
        '
        Me.chklist_Membertype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklist_Membertype.Location = New System.Drawing.Point(296, 112)
        Me.chklist_Membertype.Name = "chklist_Membertype"
        Me.chklist_Membertype.Size = New System.Drawing.Size(272, 361)
        Me.chklist_Membertype.TabIndex = 422
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(408, 29)
        Me.Label3.TabIndex = 425
        Me.Label3.Text = "ADDITIONAL CHARGE POSTINGS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DESCRIPTION"
        '
        'txt_description
        '
        Me.txt_description.BackColor = System.Drawing.Color.Wheat
        Me.txt_description.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.ForeColor = System.Drawing.Color.Blue
        Me.txt_description.Location = New System.Drawing.Point(0, 312)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(424, 27)
        Me.txt_description.TabIndex = 9
        Me.txt_description.Text = ""
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(432, 48)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.Size = New System.Drawing.Size(448, 416)
        Me.ssGrid.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "POSTING DATE"
        '
        'dtp_Postdate
        '
        Me.dtp_Postdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Postdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Postdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Postdate.Location = New System.Drawing.Point(448, 24)
        Me.dtp_Postdate.Name = "dtp_Postdate"
        Me.dtp_Postdate.Size = New System.Drawing.Size(100, 21)
        Me.dtp_Postdate.TabIndex = 1
        Me.dtp_Postdate.Value = New Date(2010, 8, 7, 11, 36, 40, 125)
        '
        'grp_add
        '
        Me.grp_add.BackColor = System.Drawing.Color.Transparent
        Me.grp_add.Controls.Add(Me.SSGRID1)
        Me.grp_add.Controls.Add(Me.Label6)
        Me.grp_add.Controls.Add(Me.btn_tax_help)
        Me.grp_add.Controls.Add(Me.lab_tax_desc)
        Me.grp_add.Controls.Add(Me.txt_tax_per)
        Me.grp_add.Controls.Add(Me.cmdaccthelp)
        Me.grp_add.Controls.Add(Me.TXT_ACCODE)
        Me.grp_add.Controls.Add(Me.SSGRID_MEM)
        Me.grp_add.Controls.Add(Me.lab_acdesc)
        Me.grp_add.Controls.Add(Me.rnd_debit)
        Me.grp_add.Controls.Add(Me.Label2)
        Me.grp_add.Controls.Add(Me.Label1)
        Me.grp_add.Controls.Add(Me.txt_description)
        Me.grp_add.Controls.Add(Me.Label7)
        Me.grp_add.Controls.Add(Me.dtp_Postdate)
        Me.grp_add.Controls.Add(Me.rnd_credit)
        Me.grp_add.Controls.Add(Me.GroupBox2)
        Me.grp_add.Controls.Add(Me.Label5)
        Me.grp_add.Controls.Add(Me.txt_taxacct)
        Me.grp_add.Controls.Add(Me.Label8)
        Me.grp_add.Controls.Add(Me.Label9)
        Me.grp_add.Controls.Add(Me.txt_amount)
        Me.grp_add.Controls.Add(Me.Label10)
        Me.grp_add.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grp_add.Location = New System.Drawing.Point(40, 48)
        Me.grp_add.Name = "grp_add"
        Me.grp_add.Size = New System.Drawing.Size(856, 496)
        Me.grp_add.TabIndex = 427
        Me.grp_add.TabStop = False
        Me.grp_add.Visible = False
        '
        'SSGRID1
        '
        Me.SSGRID1.ContainingControl = Me
        Me.SSGRID1.DataSource = Nothing
        Me.SSGRID1.Location = New System.Drawing.Point(0, 64)
        Me.SSGRID1.Name = "SSGRID1"
        Me.SSGRID1.OcxState = CType(resources.GetObject("SSGRID1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID1.Size = New System.Drawing.Size(424, 228)
        Me.SSGRID1.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Service.Tax %"
        '
        'btn_tax_help
        '
        Me.btn_tax_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tax_help.Image = CType(resources.GetObject("btn_tax_help.Image"), System.Drawing.Image)
        Me.btn_tax_help.Location = New System.Drawing.Point(176, 448)
        Me.btn_tax_help.Name = "btn_tax_help"
        Me.btn_tax_help.Size = New System.Drawing.Size(23, 24)
        Me.btn_tax_help.TabIndex = 64
        '
        'lab_tax_desc
        '
        Me.lab_tax_desc.AutoSize = True
        Me.lab_tax_desc.BackColor = System.Drawing.Color.Transparent
        Me.lab_tax_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_tax_desc.ForeColor = System.Drawing.Color.Blue
        Me.lab_tax_desc.Location = New System.Drawing.Point(208, 448)
        Me.lab_tax_desc.Name = "lab_tax_desc"
        Me.lab_tax_desc.Size = New System.Drawing.Size(11, 17)
        Me.lab_tax_desc.TabIndex = 63
        Me.lab_tax_desc.Text = "*"
        '
        'txt_tax_per
        '
        Me.txt_tax_per.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_tax_per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tax_per.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tax_per.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax_per.Location = New System.Drawing.Point(296, 416)
        Me.txt_tax_per.MaxLength = 35
        Me.txt_tax_per.Name = "txt_tax_per"
        Me.txt_tax_per.Size = New System.Drawing.Size(48, 21)
        Me.txt_tax_per.TabIndex = 59
        Me.txt_tax_per.Text = ""
        '
        'cmdaccthelp
        '
        Me.cmdaccthelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaccthelp.Image = CType(resources.GetObject("cmdaccthelp.Image"), System.Drawing.Image)
        Me.cmdaccthelp.Location = New System.Drawing.Point(176, 384)
        Me.cmdaccthelp.Name = "cmdaccthelp"
        Me.cmdaccthelp.Size = New System.Drawing.Size(23, 24)
        Me.cmdaccthelp.TabIndex = 58
        '
        'TXT_ACCODE
        '
        Me.TXT_ACCODE.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_ACCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ACCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_ACCODE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ACCODE.Location = New System.Drawing.Point(128, 385)
        Me.TXT_ACCODE.MaxLength = 35
        Me.TXT_ACCODE.Name = "TXT_ACCODE"
        Me.TXT_ACCODE.Size = New System.Drawing.Size(48, 21)
        Me.TXT_ACCODE.TabIndex = 57
        Me.TXT_ACCODE.Text = ""
        '
        'SSGRID_MEM
        '
        Me.SSGRID_MEM.ContainingControl = Me
        Me.SSGRID_MEM.DataSource = Nothing
        Me.SSGRID_MEM.Location = New System.Drawing.Point(424, 64)
        Me.SSGRID_MEM.Name = "SSGRID_MEM"
        Me.SSGRID_MEM.OcxState = CType(resources.GetObject("SSGRID_MEM.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID_MEM.Size = New System.Drawing.Size(424, 408)
        Me.SSGRID_MEM.TabIndex = 16
        '
        'lab_acdesc
        '
        Me.lab_acdesc.AutoSize = True
        Me.lab_acdesc.BackColor = System.Drawing.Color.Transparent
        Me.lab_acdesc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_acdesc.ForeColor = System.Drawing.Color.Blue
        Me.lab_acdesc.Location = New System.Drawing.Point(208, 384)
        Me.lab_acdesc.Name = "lab_acdesc"
        Me.lab_acdesc.Size = New System.Drawing.Size(11, 17)
        Me.lab_acdesc.TabIndex = 14
        Me.lab_acdesc.Text = "*"
        '
        'rnd_debit
        '
        Me.rnd_debit.Checked = True
        Me.rnd_debit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rnd_debit.Location = New System.Drawing.Point(128, 351)
        Me.rnd_debit.Name = "rnd_debit"
        Me.rnd_debit.Size = New System.Drawing.Size(72, 24)
        Me.rnd_debit.TabIndex = 12
        Me.rnd_debit.TabStop = True
        Me.rnd_debit.Text = "Debit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Apposite Acode:"
        '
        'rnd_credit
        '
        Me.rnd_credit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rnd_credit.Location = New System.Drawing.Point(224, 351)
        Me.rnd_credit.Name = "rnd_credit"
        Me.rnd_credit.Size = New System.Drawing.Size(72, 24)
        Me.rnd_credit.TabIndex = 12
        Me.rnd_credit.Text = "Credit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(121, 344)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 32)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Member A/c "
        '
        'txt_taxacct
        '
        Me.txt_taxacct.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_taxacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_taxacct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_taxacct.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_taxacct.Location = New System.Drawing.Point(128, 448)
        Me.txt_taxacct.MaxLength = 35
        Me.txt_taxacct.Name = "txt_taxacct"
        Me.txt_taxacct.Size = New System.Drawing.Size(48, 21)
        Me.txt_taxacct.TabIndex = 59
        Me.txt_taxacct.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Service Tax A/c."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Amount"
        '
        'txt_amount
        '
        Me.txt_amount.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_amount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(128, 416)
        Me.txt_amount.MaxLength = 35
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(48, 21)
        Me.txt_amount.TabIndex = 59
        Me.txt_amount.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-200, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 22)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Service.Tax %"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_Revert)
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Location = New System.Drawing.Point(232, 608)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 56)
        Me.GroupBox4.TabIndex = 428
        Me.GroupBox4.TabStop = False
        '
        'btn_Revert
        '
        Me.btn_Revert.BackgroundImage = CType(resources.GetObject("btn_Revert.BackgroundImage"), System.Drawing.Image)
        Me.btn_Revert.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Revert.ForeColor = System.Drawing.Color.White
        Me.btn_Revert.Location = New System.Drawing.Point(272, 16)
        Me.btn_Revert.Name = "btn_Revert"
        Me.btn_Revert.Size = New System.Drawing.Size(104, 32)
        Me.btn_Revert.TabIndex = 399
        Me.btn_Revert.Text = "Revert [F8]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(400, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 398
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 397
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(136, 16)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 396
        Me.CmdPrint.Text = "Process [F7]"
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.ContainingControl = Me
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(284, 142)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.Size = New System.Drawing.Size(424, 408)
        Me.AxfpSpread1.TabIndex = 429
        '
        'ssgrid_det
        '
        Me.ssgrid_det.DataSource = Nothing
        Me.ssgrid_det.Location = New System.Drawing.Point(32, 64)
        Me.ssgrid_det.Name = "ssgrid_det"
        Me.ssgrid_det.OcxState = CType(resources.GetObject("ssgrid_det.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_det.Size = New System.Drawing.Size(864, 536)
        Me.ssgrid_det.TabIndex = 429
        Me.ssgrid_det.Visible = False
        '
        'addchg_Posting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(926, 676)
        Me.Controls.Add(Me.ssgrid_det)
        Me.Controls.Add(Me.grp_add)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chk_Membername)
        Me.Controls.Add(Me.chklist_Membertype)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "addchg_Posting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addchg_Posting"
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_add.ResumeLayout(False)
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSGRID_MEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssgrid_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Private Sub FillMemberType()
        Try
            Dim i As Integer
            chklist_Membertype.Items.Clear()
            sqlstring = "SELECT ISNULL(membertype,'') AS MCODE,ISNULL(Typedesc,'') AS MNAME FROM membertype"
            vconn.getDataSet(sqlstring, "SERVERMASTER")
            If gdataset.Tables("SERVERMASTER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("SERVERMASTER").Rows.Count - 1
                    With gdataset.Tables("SERVERMASTER").Rows(i)
                        chklist_Membertype.Items.Add(Trim(.Item("MNAME")) & Space(50) & ":" & Trim(.Item("MCODE")))
                    End With
                Next i
            End If
            chklist_Membertype.Sorted = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub addchg_Posting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillMemberType()

    End Sub
    Private Sub addposting()
        Try
            sqlstring = " Exec additional_posting ''," & IIf(rnd_debit.Checked = True, "'DEBIT'", "'CREDIT'")
            sqlstring = sqlstring & "," & IIf(Val(txt_tax_per.Text) > 0, Val(txt_tax_per.Text), 0)
            sqlstring = sqlstring & "," & IIf(Val(txt_amount.Text) > 0, Val(txt_amount.Text), 0)
            sqlstring = sqlstring & ",'" & txt_description.Text & "','" & TXT_ACCODE.Text & "','" & Format(dtp_Postdate.Value, "dd/MMM/yyyy") & "','P','" & txt_taxacct.Text & "'"
            posting = vconn.ExcuteStoreProcedure(sqlstring)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub adddet()
        Dim _Mcode As String
        Try
            With SSGRID_MEM
                _Mcode = "'"
                For i = 1 To SSGRID_MEM.DataRowCnt
                    .Row = i
                    .Col = 3
                    If Val(.Text) > 0 Then
                        .Row = i
                        .Col = 1
                        sqlstring = " Exec additional_posting '" & Trim(.Text) & "'," & IIf(rnd_debit.Checked = True, "'DEBIT'", "'CREDIT'")
                    sqlstring = sqlstring & "," & IIf(Val(txt_tax_per.Text) > 0, Val(txt_tax_per.Text), 0)
                    sqlstring = sqlstring & "," & IIf(Val(txt_amount.Text) > 0, Val(txt_amount.Text), 0)
                        sqlstring = sqlstring & ",'" & txt_description.Text & "','" & TXT_ACCODE.Text & "','" & Format(dtp_Postdate.Value, "dd/MMM/yyyy") & "','N',''"
                        posting = vconn.ExcuteStoreProcedure(sqlstring)
                    End If
                Next
                sqlstring = "SELECT A.MCODE,B.MNAME,ISNULL(A.SUBSDESC,'') AS DESC1,ISNULL(A.AMOUNT,0) AS AMOUNT,"
                sqlstring = sqlstring & " ISNULL(A.TAXPER,0) AS TAXPER,ISNULL(A.TAXAMOUNT,0) AS TAXAMOUNT "
                sqlstring = sqlstring & " FROM SUBSPOSTING A,MEMBERMASTER B "
                sqlstring = sqlstring & " WHERE A.MCODE=B.MCODE AND SUBSTYPE='A'"
                sqlstring = sqlstring & " AND A.AMOUNT=" & txt_amount.Text
                sqlstring = sqlstring & " AND  BILLDATE='" & Format(dtp_Postdate.Value, "dd/MMM/yyyy") & "'"
                vconn.getDataSet(sqlstring, "ADDDET")
                If gdataset.Tables("ADDDET").Rows.Count > 0 Then
                    ssgrid_det.SetActiveCell(1, 1)
                    ssgrid_det.MaxRows = gdataset.Tables("ADDDET").Rows.Count + 50
                    With ssgrid_det
                        For i = 0 To gdataset.Tables("ADDDET").Rows.Count - 1
                            .FontSize = 10
                            .FontBold = True
                            .Col = 1
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("mcode")
                            .Col = 2
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("mname")
                            .Col = 3
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("AMOUNT")
                            .Col = 4
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("TAXPER")
                            .Col = 5
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("TAXAMOUNT")
                        Next
                    End With
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub memdet()
        Try
            sqlstring = "Select Isnull(Mcode,'') as Mcode,Isnull(Mname,'') as Mname from Membermaster "
            sqlstring = sqlstring & " Where membertypecode in('"
            If chklist_Membertype.CheckedItems.Count > 0 Then
                For i = 0 To chklist_Membertype.CheckedItems.Count - 1
                    mtype = Split(chklist_Membertype.CheckedItems.Item(i), ":")
                    sqlstring = sqlstring & Trim(mtype(1)) & "','"
                Next
            Else
                MessageBox.Show("Please Select Membertype()")
                chklist_Membertype.Focus()
            End If
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ") and Isnull(Curentstatus,'')='LIVE'  Order By Mcode "
            vconn.getDataSet(sqlstring, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 1 Then
                SSGRID_MEM.SetActiveCell(1, 1)
                SSGRID_MEM.MaxRows = gdataset.Tables("Membermaster").Rows.Count + 20
                With SSGRID_MEM
                    For i = 0 To gdataset.Tables("Membermaster").Rows.Count - 1
                        .FontSize = 10
                        .FontBold = True
                        .Col = 1
                        .Row = i + 1
                        .Text = gdataset.Tables("Membermaster").Rows(i).Item("mcode")
                        .Col = 2
                        .Row = i + 1
                        .Text = gdataset.Tables("Membermaster").Rows(i).Item("mname")
                    Next
                End With
            End If
            sqlstring = "SELECT ISNULL(SUBSDESC,'') AS DESC1,ISNULL(AMOUNT,0) AS AMOUNT,BILLDATE"
            sqlstring = sqlstring & " FROM SUBSPOSTING "
            sqlstring = sqlstring & " WHERE SUBSTYPE='A' AND  MONTH(BILLDATE)=" & Month(dtp_Postdate.Value)
            sqlstring = sqlstring & " GROUP BY SUBSDESC,AMOUNT,BILLDATE "
            vconn.getDataSet(sqlstring, "ADDDET")
            SSGRID1.ClearRange(1, 1, -1, -1, True)
            SSGRID1.SetActiveCell(1, 1)
            If gdataset.Tables("ADDDET").Rows.Count > 0 Then
                SSGRID1.MaxRows = gdataset.Tables("ADDDET").Rows.Count + 15
                With SSGRID1
                    For i = 0 To gdataset.Tables("ADDDET").Rows.Count - 1
                        .Col = 1
                        .Row = i + 1
                        .Text = gdataset.Tables("ADDDET").Rows(i).Item("DESC1")
                        .Col = 2
                        .Row = i + 1
                        .Text = CDate(Format(gdataset.Tables("ADDDET").Rows(i).Item("BILLDATE"), "dd/MM/yyyy"))
                    Next
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chk()

    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If grp_add.Visible = False And ssgrid_det.Visible = False Then
                If chklist_Membertype.CheckedItems.Count <= 0 Then
                    MessageBox.Show("Please Select Membertype()")
                    chklist_Membertype.Focus()
                    Exit Sub
                End If
                Call memdet()
                grp_add.Visible = True
                ssgrid_det.Visible = False



            ElseIf grp_add.Visible = True And ssgrid_det.Visible = False Then
                j = 0
                For i = 1 To SSGRID_MEM.DataRowCnt
                    SSGRID_MEM.Row = i
                    SSGRID_MEM.Col = 3
                    If Val(SSGRID_MEM.Text) > 0 Then
                        j = j + 1
                    End If
                Next
                If Val(txt_amount.Text) = 0 Then
                    MessageBox.Show("Please Enter Amount")
                    txt_amount.Focus()
                    Exit Sub
                ElseIf TXT_ACCODE.Text = "" Then
                    MessageBox.Show("Please Enter Accountcode")
                    txt_amount.Focus()
                    Exit Sub
                ElseIf txt_description.Text = "" Then
                    MessageBox.Show("Please Enter Description")
                    txt_amount.Focus()
                    Exit Sub
                ElseIf j = 0 Then
                    MessageBox.Show("Please Select Member List")
                    SSGRID_MEM.Focus()
                    Exit Sub
                End If
                Call adddet()
                grp_add.Visible = False
                ssgrid_det.Visible = True
            ElseIf grp_add.Visible = False And ssgrid_det.Visible = True Then
                Call addposting()
                Call Cmd_Clear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdaccthelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaccthelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ACCODE,ACDESC FROM accountsglaccountmaster"
        M_WhereCondition = " "
        vform.Field = "ACCODE,ACDESC"
        vform.vFormatstring = "     ACCOUNT CODE                |                    ACCOUNT DESCRIPTION                          |"
        vform.vCaption = "GL Account Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_ACCODE.Text = Trim(vform.keyfield & "")
            lab_acdesc.Text = Trim(vform.keyfield1 & "")
            txt_amount.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub TXT_ACCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_ACCODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TXT_ACCODE.Text = "" Then
                cmdaccthelp_Click(sender, e)
            Else
                txt_tax_per.Focus()
            End If
        End If
    End Sub
    Private Sub TXT_ACCODE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_ACCODE.Validated
        Try
            If TXT_ACCODE.Text <> "" Then
                sqlstring = "SELECT ACCODE,ACDESC FROM accountsglaccountmaster WHERE ACCODE='" & TXT_ACCODE.Text & "'"
                vconn.getDataSet(sqlstring, "ACCODE")
                If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                    lab_acdesc.Text = gdataset.Tables("ACCODE").Rows(0).Item("ACDESC")
                    txt_amount.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_taxacct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_taxacct.TextChanged

    End Sub
    Private Sub txt_taxacct_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_taxacct.Validated
        Try
            If TXT_ACCODE.Text <> "" Then
                sqlstring = "SELECT ACCODE,ACDESC FROM accountsglaccountmaster WHERE ACCODE='" & txt_taxacct.Text & "'"
                vconn.getDataSet(sqlstring, "ACCODE")
                If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                    lab_tax_desc.Text = gdataset.Tables("ACCODE").Rows(0).Item("ACDESC")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_tax_per_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tax_per.TextChanged

    End Sub
    Private Sub txt_tax_per_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tax_per.KeyPress
        getNumeric(e)
    End Sub
    Private Sub txt_tax_per_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_tax_per.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_taxacct.Focus()
        End If
    End Sub
    Private Sub txt_taxacct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_taxacct.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_taxacct.Text = "" Then
                btn_tax_help_Click(sender, e)
            Else
                CmdPrint.Focus()
            End If
        End If
    End Sub
    Private Sub btn_tax_help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tax_help.Click
        Dim vform As New ListOperation
        gSQLString = " SELECT ACCODE,ACDESC FROM accountsglaccountmaster "
        M_WhereCondition = " "
        vform.Field = "ACCODE,ACDESC"
        vform.vFormatstring = "     ACCOUNT CODE                |                    ACCOUNT DESCRIPTION                          |"
        vform.vCaption = "GL Account Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_taxacct.Text = Trim(vform.keyfield & "")
            lab_tax_desc.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            TXT_ACCODE.Text = ""
            txt_tax_per.Text = ""
            txt_taxacct.Text = ""
            lab_acdesc.Text = "*"
            txt_description.Text = ""
            lab_tax_desc.Text = "*"
            SSGRID_MEM.ClearRange(1, 1, -1, -1, True)
            SSGRID1.ClearRange(1, 1, -1, -1, True)
            ssgrid_det.ClearRange(1, 1, -1, -1, True)
            txt_tax_per.Text = Format(Val(txt_tax_per.Text), "00.00")
            grp_add.Visible = False
            dtp_Postdate.Focus()
            Chk_Membername.Checked = False
            ssgrid_det.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub dtp_Postdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Postdate.ValueChanged
        'If grp_add.Visible = True Then
        '    Try
        '        sqlstring = "SELECT ISNULL(SUBSDESC,'') AS DESC1,ISNULL(AMOUNT,0) AS AMOUNT,BILLDATE"
        '        sqlstring = sqlstring & " FROM SUBSPOSTING "
        '        sqlstring = sqlstring & " WHERE SUBSTYPE='A' AND  MONTH(BILLDATE)=" & Month(dtp_Postdate.Value)
        '        sqlstring = sqlstring & " GROUP BY SUBSDESC,AMOUNT,BILLDATE "
        '        vconn.getDataSet(sqlstring, "ADDDET")
        '        If gdataset.Tables("ADDDET").Rows.Count > 1 Then
        '            ssgrid_det.MaxRows = gdataset.Tables("ADDDET").Rows.Count + 15
        '            ssgrid_det.ClearRange(1, 1, -1, -1, True)
        '            ssgrid_det.SetActiveCell(1, 1)
        '            With ssgrid_det
        '                For i = 0 To gdataset.Tables("ADDDET").Rows.Count - 1
        '                    .Col = 1
        '                    .Row = i + 1
        '                    .Text = gdataset.Tables("ADDDET").Rows(i).Item("DESC1")
        '                    .Col = 2
        '                    .Row = i + 1
        '                    .Text = CDate(Format(gdataset.Tables("ADDDET").Rows(i).Item("BILLDATE"), "dd/MM/yyyy"))
        '                Next
        '            End With
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        ' End If
    End Sub
    Private Sub dtp_Postdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Postdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_description.Focus()
        End If
    End Sub
    Private Sub Chk_Membername_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Membername.CheckedChanged
        If Chk_Membername.Checked = True Then
            For i = 0 To chklist_Membertype.Items.Count - 1
                chklist_Membertype.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Membertype.Items.Count - 1
                chklist_Membertype.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amount.TextChanged

    End Sub
    Private Sub txt_amount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_amount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_tax_per.Focus()
        End If
    End Sub
    Private Sub txt_amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        getNumeric(e)
    End Sub

    Private Sub TXT_ACCODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_ACCODE.TextChanged

    End Sub

    Private Sub SSGRID_MEM_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRID_MEM.Advance

    End Sub
    Private Sub SSGRID_MEM_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRID_MEM.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                With SSGRID_MEM
                    .SetActiveCell(1, 1)
                    For i = 1 To SSGRID_MEM.DataRowCnt
                        .Col = 3
                        .Row = i
                        .Text = 1
                    Next
                End With
            End If
            If e.keyCode = Keys.F3 Then
                With SSGRID_MEM
                    .SetActiveCell(1, 1)
                    For i = 1 To SSGRID_MEM.DataRowCnt
                        .Col = 3
                        .Row = i
                        .Text = 0
                    Next
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dtp_Postdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Postdate.Click
        'Try
        '    sqlstring = "SELECT ISNULL(SUBSDESC,'') AS DESC1,ISNULL(AMOUNT,0) AS AMOUNT,BILLDATE"
        '    sqlstring = sqlstring & " FROM SUBSPOSTING "
        '    sqlstring = sqlstring & " WHERE SUBSTYPE='A' AND  MONTH(BILLDATE)=" & Month(dtp_Postdate.Value)
        '    sqlstring = sqlstring & " GROUP BY SUBSDESC,AMOUNT,BILLDATE "
        '    vconn.getDataSet(sqlstring, "ADDDET")
        '    If gdataset.Tables("ADDDET").Rows.Count > 1 Then
        '        SSGRID1.MaxRows = gdataset.Tables("ADDDET").Rows.Count + 15
        '        SSGRID1.ClearRange(1, 1, -1, -1, True)
        '        SSGRID1.SetActiveCell(1, 1)
        '        With SSGRID1
        '            For i = 0 To gdataset.Tables("ADDDET").Rows.Count - 1
        '                .Col = 1
        '                .Row = i + 1
        '                .Text = gdataset.Tables("ADDDET").Rows(i).Item("DESC1")
        '                .Col = 2
        '                .Row = i + 1
        '                .Text = CDate(Format(gdataset.Tables("ADDDET").Rows(i).Item("BILLDATE"), "dd/MM/yyyy"))
        '            Next
        '        End With
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub btn_Revert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Revert.Click
        Try
            With SSGRID1
                .SetActiveCell(1, 1)
                For i = 1 To .DataRowCnt
                    .Col = 3
                    .Row = i
                    If Val(.Text) > 0 Then
                        .Col = 1
                        .Row = i
                        sqlstring = "DELETE FROM SUBSPOSTING WHERE SUBSTYPE='A' AND SUBSDESC='" & Trim(.Text) & "' "
                        .Col = 2
                        .Row = i
                        sqlstring = sqlstring & " AND  BILLDATE='" & Format(CDate(.Text), "dd/MMM/yyyy") & "'"
                        ReDim Preserve INSERT(INSERT.Length)
                        INSERT(INSERT.Length - 1) = sqlstring
                        .Col = 1
                        .Row = i
                        sqlstring = "DELETE FROM JOURNALENTRY WHERE VOUCHERTYPE='SBIL' AND VOUCHERCATEGORY='ADD' AND DESCRIPTION='" & Trim(.Text) & "'"
                        .Col = 2
                        .Row = i
                        sqlstring = sqlstring & " AND  VOUCHERDATE='" & Format(CDate(.Text), "dd/MMM/yyyy") & "'"
                        ReDim Preserve INSERT(INSERT.Length)
                        INSERT(INSERT.Length - 1) = sqlstring
                    End If
                Next
                vconn.MoreTrans(INSERT)

                sqlstring = "SELECT ISNULL(SUBSDESC,'') AS DESC1,ISNULL(AMOUNT,0) AS AMOUNT,BILLDATE"
                sqlstring = sqlstring & " FROM SUBSPOSTING "
                sqlstring = sqlstring & " WHERE SUBSTYPE='A' AND  MONTH(BILLDATE)=" & Month(dtp_Postdate.Value)
                sqlstring = sqlstring & " GROUP BY SUBSDESC,AMOUNT,BILLDATE "
                vconn.getDataSet(sqlstring, "ADDDET")
                SSGRID1.ClearRange(1, 1, -1, -1, True)
                SSGRID1.SetActiveCell(1, 1)
                If gdataset.Tables("ADDDET").Rows.Count > 0 Then
                    SSGRID1.MaxRows = gdataset.Tables("ADDDET").Rows.Count + 15
                    With SSGRID1
                        For i = 0 To gdataset.Tables("ADDDET").Rows.Count - 1
                            .Col = 1
                            .Row = i + 1
                            .Text = gdataset.Tables("ADDDET").Rows(i).Item("DESC1")
                            .Col = 2
                            .Row = i + 1
                            .Text = CDate(Format(gdataset.Tables("ADDDET").Rows(i).Item("BILLDATE"), "dd/MM/yyyy"))
                        Next
                    End With
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SSGRID1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRID1.Advance

    End Sub
    Private Sub SSGRID1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRID1.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                With SSGRID1
                    .SetActiveCell(1, 1)
                    For i = 1 To SSGRID1.DataRowCnt
                        .Col = 3
                        .Row = i
                        .Text = 1
                    Next
                End With
            End If
            If e.keyCode = Keys.F3 Then
                With SSGRID1
                    .SetActiveCell(1, 1)
                    For i = 1 To SSGRID1.DataRowCnt
                        .Col = 3
                        .Row = i
                        .Text = 0
                    Next
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
