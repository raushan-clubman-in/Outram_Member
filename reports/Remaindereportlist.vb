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
Public Class Remaindereportlist
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim sqlString, chk_month, vtypedesc As String
    Public sqlStringFinal, DispString, membertype, lettertype, vhead, firstdate As String
    Dim iNumber, row, addamt As Integer
    Dim billno As Long
    Public TempString(2), bill As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype, Vcatefile, sout, rout, MONTH1 As String
    Dim posting, posting1 As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Processed_Chk(4) As Integer
    Dim txtobj1 As TextObject
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents BTNSCREEN As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBLETERNO As System.Windows.Forms.ComboBox
    Friend WithEvents letterno As System.Windows.Forms.Label
    Friend WithEvents CHKCATEGORY As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpASNODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTNPRINT As System.Windows.Forms.Button
    Friend WithEvents RBTREMINDERSUMMARY As System.Windows.Forms.RadioButton
    Friend WithEvents RBTREMINDERLETTER As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTMCODETO As System.Windows.Forms.TextBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dtp_CutOffDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_ReminderType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_CreditLimit As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTMCODEFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTP_FIRST As System.Windows.Forms.Label
    Friend WithEvents Dtp_rem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Remaindereportlist))
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTNSCREEN = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.BTNPRINT = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dtp_rem = New System.Windows.Forms.DateTimePicker
        Me.DTP_FIRST = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXTMCODEFrom = New System.Windows.Forms.TextBox
        Me.Txt_CreditLimit = New System.Windows.Forms.TextBox
        Me.Cmb_ReminderType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Dtp_CutOffDate = New System.Windows.Forms.DateTimePicker
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXTMCODETO = New System.Windows.Forms.TextBox
        Me.RBTREMINDERSUMMARY = New System.Windows.Forms.RadioButton
        Me.RBTREMINDERLETTER = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpASNODATE = New System.Windows.Forms.DateTimePicker
        Me.CMBLETERNO = New System.Windows.Forms.ComboBox
        Me.letterno = New System.Windows.Forms.Label
        Me.CHKCATEGORY = New System.Windows.Forms.CheckedListBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 27)
        Me.Label2.TabIndex = 386
        Me.Label2.Text = "REMINDER LETTER"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BTNSCREEN)
        Me.GroupBox2.Controls.Add(Me.Btn_close)
        Me.GroupBox2.Controls.Add(Me.BTNPRINT)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(64, 496)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 56)
        Me.GroupBox2.TabIndex = 391
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(512, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Excel [F7]"
        '
        'BTNSCREEN
        '
        Me.BTNSCREEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNSCREEN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSCREEN.ForeColor = System.Drawing.Color.White
        Me.BTNSCREEN.Image = CType(resources.GetObject("BTNSCREEN.Image"), System.Drawing.Image)
        Me.BTNSCREEN.Location = New System.Drawing.Point(88, 16)
        Me.BTNSCREEN.Name = "BTNSCREEN"
        Me.BTNSCREEN.Size = New System.Drawing.Size(104, 32)
        Me.BTNSCREEN.TabIndex = 12
        Me.BTNSCREEN.Text = "VIEW [F5]"
        '
        'Btn_close
        '
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Image = CType(resources.GetObject("Btn_close.Image"), System.Drawing.Image)
        Me.Btn_close.Location = New System.Drawing.Point(368, 16)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        '
        'BTNPRINT
        '
        Me.BTNPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNPRINT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRINT.ForeColor = System.Drawing.Color.White
        Me.BTNPRINT.Image = CType(resources.GetObject("BTNPRINT.Image"), System.Drawing.Image)
        Me.BTNPRINT.Location = New System.Drawing.Point(232, 16)
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.Size = New System.Drawing.Size(104, 32)
        Me.BTNPRINT.TabIndex = 13
        Me.BTNPRINT.Text = "PRINT [F6]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 22)
        Me.Label5.TabIndex = 363
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Dtp_rem)
        Me.GroupBox1.Controls.Add(Me.DTP_FIRST)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTMCODEFrom)
        Me.GroupBox1.Controls.Add(Me.Txt_CreditLimit)
        Me.GroupBox1.Controls.Add(Me.Cmb_ReminderType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Dtp_CutOffDate)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTMCODETO)
        Me.GroupBox1.Controls.Add(Me.RBTREMINDERSUMMARY)
        Me.GroupBox1.Controls.Add(Me.RBTREMINDERLETTER)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpASNODATE)
        Me.GroupBox1.Controls.Add(Me.CMBLETERNO)
        Me.GroupBox1.Controls.Add(Me.letterno)
        Me.GroupBox1.Controls.Add(Me.CHKCATEGORY)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(64, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 416)
        Me.GroupBox1.TabIndex = 387
        Me.GroupBox1.TabStop = False
        '
        'Dtp_rem
        '
        Me.Dtp_rem.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_rem.CustomFormat = "yyyy"
        Me.Dtp_rem.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_rem.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Dtp_rem.Location = New System.Drawing.Point(512, 336)
        Me.Dtp_rem.Name = "Dtp_rem"
        Me.Dtp_rem.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_rem.TabIndex = 439
        Me.Dtp_rem.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        Me.Dtp_rem.Visible = False
        '
        'DTP_FIRST
        '
        Me.DTP_FIRST.AutoSize = True
        Me.DTP_FIRST.BackColor = System.Drawing.Color.Transparent
        Me.DTP_FIRST.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FIRST.Location = New System.Drawing.Point(368, 336)
        Me.DTP_FIRST.Name = "DTP_FIRST"
        Me.DTP_FIRST.Size = New System.Drawing.Size(144, 22)
        Me.DTP_FIRST.TabIndex = 438
        Me.DTP_FIRST.Text = "LETTER DATED: "
        Me.DTP_FIRST.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 22)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "AMOUNT :"
        Me.Label6.Visible = False
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(120, 120)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 435
        Me.cmd_MCodefromHelp.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-80, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 22)
        Me.Label3.TabIndex = 436
        Me.Label3.Text = "MCODE FROM : "
        Me.Label3.Visible = False
        '
        'TXTMCODEFrom
        '
        Me.TXTMCODEFrom.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.TXTMCODEFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODEFrom.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODEFrom.Location = New System.Drawing.Point(48, 72)
        Me.TXTMCODEFrom.Name = "TXTMCODEFrom"
        Me.TXTMCODEFrom.Size = New System.Drawing.Size(112, 26)
        Me.TXTMCODEFrom.TabIndex = 434
        Me.TXTMCODEFrom.Text = ""
        Me.TXTMCODEFrom.Visible = False
        '
        'Txt_CreditLimit
        '
        Me.Txt_CreditLimit.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CreditLimit.Location = New System.Drawing.Point(184, 336)
        Me.Txt_CreditLimit.Name = "Txt_CreditLimit"
        Me.Txt_CreditLimit.TabIndex = 433
        Me.Txt_CreditLimit.Text = "1"
        Me.Txt_CreditLimit.Visible = False
        '
        'Cmb_ReminderType
        '
        Me.Cmb_ReminderType.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cmb_ReminderType.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ReminderType.ItemHeight = 18
        Me.Cmb_ReminderType.Items.AddRange(New Object() {"MEMBER"})
        Me.Cmb_ReminderType.Location = New System.Drawing.Point(184, 256)
        Me.Cmb_ReminderType.Name = "Cmb_ReminderType"
        Me.Cmb_ReminderType.Size = New System.Drawing.Size(144, 26)
        Me.Cmb_ReminderType.TabIndex = 431
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 22)
        Me.Label4.TabIndex = 432
        Me.Label4.Text = "REMINDER TYPE : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(336, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 22)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "RECEIPTS  UPTO : "
        '
        'Dtp_CutOffDate
        '
        Me.Dtp_CutOffDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_CutOffDate.CustomFormat = "yyyy"
        Me.Dtp_CutOffDate.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_CutOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Dtp_CutOffDate.Location = New System.Drawing.Point(512, 296)
        Me.Dtp_CutOffDate.Name = "Dtp_CutOffDate"
        Me.Dtp_CutOffDate.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_CutOffDate.TabIndex = 426
        Me.Dtp_CutOffDate.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(184, 16)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(216, 32)
        Me.chk_PrintAll.TabIndex = 424
        Me.chk_PrintAll.Text = "Check all Category"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(632, 88)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 7
        Me.cmd_MCodeToHelp.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 420
        Me.Label8.Text = "MCODE TO : "
        Me.Label8.Visible = False
        '
        'TXTMCODETO
        '
        Me.TXTMCODETO.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.TXTMCODETO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODETO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODETO.Location = New System.Drawing.Point(512, 88)
        Me.TXTMCODETO.Name = "TXTMCODETO"
        Me.TXTMCODETO.Size = New System.Drawing.Size(104, 26)
        Me.TXTMCODETO.TabIndex = 6
        Me.TXTMCODETO.Text = ""
        Me.TXTMCODETO.Visible = False
        '
        'RBTREMINDERSUMMARY
        '
        Me.RBTREMINDERSUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERSUMMARY.Checked = True
        Me.RBTREMINDERSUMMARY.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERSUMMARY.Location = New System.Drawing.Point(312, 384)
        Me.RBTREMINDERSUMMARY.Name = "RBTREMINDERSUMMARY"
        Me.RBTREMINDERSUMMARY.Size = New System.Drawing.Size(183, 22)
        Me.RBTREMINDERSUMMARY.TabIndex = 9
        Me.RBTREMINDERSUMMARY.TabStop = True
        Me.RBTREMINDERSUMMARY.Text = "Reminder Summary"
        '
        'RBTREMINDERLETTER
        '
        Me.RBTREMINDERLETTER.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERLETTER.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERLETTER.Location = New System.Drawing.Point(56, 384)
        Me.RBTREMINDERLETTER.Name = "RBTREMINDERLETTER"
        Me.RBTREMINDERLETTER.Size = New System.Drawing.Size(216, 16)
        Me.RBTREMINDERLETTER.TabIndex = 8
        Me.RBTREMINDERLETTER.Text = "Reminder Letter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 22)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "BILL UPTO : "
        '
        'dtpASNODATE
        '
        Me.dtpASNODATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpASNODATE.CustomFormat = "MMMMM"
        Me.dtpASNODATE.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpASNODATE.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpASNODATE.Location = New System.Drawing.Point(184, 296)
        Me.dtpASNODATE.Name = "dtpASNODATE"
        Me.dtpASNODATE.Size = New System.Drawing.Size(144, 26)
        Me.dtpASNODATE.TabIndex = 3
        Me.dtpASNODATE.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'CMBLETERNO
        '
        Me.CMBLETERNO.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CMBLETERNO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLETERNO.ItemHeight = 18
        Me.CMBLETERNO.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CMBLETERNO.Location = New System.Drawing.Point(512, 256)
        Me.CMBLETERNO.Name = "CMBLETERNO"
        Me.CMBLETERNO.Size = New System.Drawing.Size(136, 26)
        Me.CMBLETERNO.TabIndex = 0
        '
        'letterno
        '
        Me.letterno.AutoSize = True
        Me.letterno.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letterno.Location = New System.Drawing.Point(376, 256)
        Me.letterno.Name = "letterno"
        Me.letterno.Size = New System.Drawing.Size(134, 22)
        Me.letterno.TabIndex = 402
        Me.letterno.Text = "LETTER  NO : "
        '
        'CHKCATEGORY
        '
        Me.CHKCATEGORY.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CHKCATEGORY.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCATEGORY.Location = New System.Drawing.Point(184, 48)
        Me.CHKCATEGORY.Name = "CHKCATEGORY"
        Me.CHKCATEGORY.Size = New System.Drawing.Size(296, 193)
        Me.CHKCATEGORY.Sorted = True
        Me.CHKCATEGORY.TabIndex = 2
        '
        'Remaindereportlist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 614)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.KeyPreview = True
        Me.Name = "Remaindereportlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Letter"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
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
        Me.BTNSCREEN.Enabled = False
        Me.BTNPRINT.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.BTNSCREEN.Enabled = True
                    Me.BTNPRINT.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.BTNSCREEN.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.BTNPRINT.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub BTNSCREEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSCREEN.Click
        gPrint = False

        If CHKCATEGORY.CheckedItems.Count = 0 Then
            MessageBox.Show("Please Select  the Member Category")
            CHKCATEGORY.Focus()
            Exit Sub
        End If
        If CMBLETERNO.Text = "" Then
            MessageBox.Show("Please Select The Letter No ")
            CMBLETERNO.Focus()
            Exit Sub
        End If

        If CMBLETERNO.Text = "1" Or CMBLETERNO.Text = "2" Or CMBLETERNO.Text = "3" Or CMBLETERNO.Text = "4" Then
            If RBTREMINDERLETTER.Checked = True Then
                Call Printoperation2()
            End If
            If RBTREMINDERSUMMARY.Checked = True Then
                Call Summary2()

            End If
        End If
    End Sub
    Private Sub printoutstanding()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try
            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
            vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) > '10000'  AND "
            vSql = vSql & " isnull(membertypecode,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next
            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND CURENTSTATUS = 'LIVE' order by O.MCODE "

            Dim Viewer As New ReportViwer
            Dim r As New OutStandletter2
            Dim r1 As New Reminder2
            Viewer.ssql = vSql
            'If CMBLETERNO.Text = "1" Then
            Viewer.Report = r
            'ElseIf CMBLETERNO.Text = "2" Then
            '  Viewer.Report = r1
            'End If
            'Dim txtobj As TextObject
            'txtobj = r.ReportDefinition.ReportObjects("Text4")
            'txtobj.Text =Format(dtpASNODATE.Value, "dd-MMM-yyyy")

            Viewer.TableName = "VW_REMINDER"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub Partyletter()
        Dim MNTH, vbilldate As String
        Dim noofdays As Double
        Dim I, J, vhead
        Dim vFromDate, vToDate, SSQL As String
        Dim appcode() As String
        Randomize()
        'If Txt_Orderno.Text = "" Then
        '    MsgBox("Please Fill the Order No!!!")
        '    Exit Sub
        'End If
        Dim vpageNo, vtdueamt As Double
        Dim Loopindex, vPhone, Vdate, vTotAmtDue, vCrAmt, Vrowcout, vPrnAmt, vMonth, vletterno
        Dim monthcnt As Integer
        Dim pno, psize As Integer
        Dim vString, vPrefix, vCompany, vMid, vName, vAdd1, vAdd2, vCity, vState, vpin, vadd3, vslcode
        Dim vSql, mdate, gAdd As String
        Dim dbltotop As Double
        Dim vsplit() As String
        Dim Order As String

        SSQL = ""
        'SSQL = "Select Orderno,Orderdate,Mcode from Party_Order where Orderno = '" & Trim(Txt_Orderno.Text) & "'"
        SSQL = "Select Orderno,Orderdate,Mcode from Party_Order"
        gconnection.getDataSet(SSQL, "Party")
        If gdataset.Tables("Party").Rows.Count > 0 Then
            Order = gdataset.Tables("Party").Rows(0).Item(0)
            vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            'vletterno = CMBLETERNO.Text
            pno = 1
            psize = 0

            For I = 0 To gdataset.Tables("Party").Rows.Count - 1
                vSql = "select ISNULL(MID,'') AS MID,ISNULL(COMPANY,'') AS COMPANY,ISNULL(PREFIX,'') AS PREFIX,isnull(mcode,'') as SLCODE,ISNULL                      (MNAME,'') AS SLNAME,ISNULL(PADD1,'') AS ADDRESS1, ISNULL(PADD2,'') AS ADDRESS2,ISNULL(PADD3,'') AS ADDRESS3,ISNULL(PCITY,'')                     AS CITY,ISNULL(PSTATE,'') AS STATE,ISNULL(PPIN,'') AS PIN from MEMBERMASTER where  Mcode ='" & Trim(gdataset.Tables("Party").Rows(I).Item("Mcode")) & "'"
                gconnection.getDataSet(vSql, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    vslcode = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLCODE") & "")
                    vPrefix = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PREFIX") & "")
                    vCompany = Trim(gdataset.Tables("MEMBER").Rows(0).Item("COMPANY") & "")
                    vMid = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MID") & "")
                    vName = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLNAME") & "")
                    vAdd1 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS1") & "")
                    vAdd2 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS2") & "")
                    vadd3 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS3") & "")
                    vCity = Trim(gdataset.Tables("MEMBER").Rows(0).Item("CITY") & "")
                    vState = Trim(gdataset.Tables("MEMBER").Rows(0).Item("STATE") & "")
                    vpin = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PIN") & "")
                End If
                For J = 0 To 2
                    Filewrite.WriteLine()
                Next
                psize = psize + 2
                gAdd = "CHENNAI - 600008"
                Filewrite.WriteLine(Space(15) & Chr(18) & Chr(14) & gCompanyname & Chr(18))
                Filewrite.WriteLine(Space(18) & Chr(18) & Chr(14) & gAdd & Chr(18))
                ' Filewrite.WriteLine(Space(2) & gCompanyAddress(0) & "," & gCompanyAddress(1))
                'Filewrite.WriteLine(Space(2) & gCompanyAddress(1))
                'Filewrite.WriteLine(Space(2) & gCompanyAddress(2))
                psize = psize + 2
                For J = 0 To 2
                    Filewrite.WriteLine()
                Next
                Filewrite.WriteLine(Space(2) & Format(DateTime.Now, "dd/MM/yyyy"))
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "To")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & vPrefix & Space(1) & vMid & Space(1) & vName & Space(2) & "(" & vslcode & ")")
                If vCompany <> "" Then
                    Filewrite.WriteLine(Space(2) & vCompany)
                Else
                    Filewrite.WriteLine(Space(2) & vAdd1)
                    vAdd1 = ""
                End If
                If vAdd1 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd1)
                ElseIf vAdd2 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd2)
                    vAdd2 = ""
                Else
                    Filewrite.WriteLine(Space(2) & vadd3)
                    vadd3 = ""
                End If
                If vAdd2 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd2)
                ElseIf vadd3 <> "" Then
                    Filewrite.WriteLine(Space(2) & vadd3)
                    vadd3 = ""
                Else
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                    vCity = ""
                    vpin = ""
                End If
                If vadd3 <> "" Then
                    Filewrite.WriteLine(Space(2) & vadd3)
                ElseIf vCity <> "" Or vpin <> "" Then
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                    vCity = ""
                    vpin = ""
                End If
                If vCity <> "" Or vpin <> "" Then
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                End If
                Vrowcout = 0
                psize = psize + 8
                Filewrite.WriteLine()
                'Filewrite.WriteLine(Space(2) & "Dear " & vPrefix & Space(1) & vName)
                Filewrite.WriteLine(Space(2) & "Dear Sir/Madam")
                Filewrite.WriteLine()
                psize = psize + 3
                SSQL = "SELECT KOTNO,KOTDATE,MCODE,MNAME,BILLAMOUNT FROM KOT_HDR WHERE KOTNO = '" & Trim(Order) & "' AND PAYMENTTYPE = 'CREDIT' AND                DELFLAG <> 'Y'"
                gconnection.getDataSet(SSQL, "LETTER")
                Filewrite.WriteLine(Space(2) & "Ref.: Party Bill No. " & gdataset.Tables("Letter").Rows(0).Item("Kotno") & " Dated " & Format(gdataset.Tables("Letter").Rows(0).Item("Kotdate"), "dd/MM/yyyy"))
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Space(2) & "The above party bill for Rs. " & gdataset.Tables("Letter").Rows(0).Item("billamount") & " is sent herewith for payment.")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "As per the Club Rules, the party bill is to be settled within,")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "THREE DAYS of the party.")
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "Yours faithfully")
                Filewrite.WriteLine(Space(2) & "for THE PRESIDENCY CLUB")
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "EXECUTIVE SECRETARY")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "Encl : Party Bill")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "If payment is already made please ignore this letter")

                'Filewrite.WriteLine(Chr(12))
                'pno = pno + 1
            Next
            'For I = 0 To 5
            '    Filewrite.WriteLine()
            'Next
            Filewrite.Close()
            If gPrint = False Then
                Call OpenTextFile(vOutfile)
            Else
                Call PrintTextFile(vOutfile)
            End If
        End If
    End Sub
    Private Sub PrintOperation1()
        Dim MNTH, vbilldate As String
        Dim noofdays As Double
        Dim I, J, vhead
        Dim vFromDate, vToDate, SSQL As String
        Dim appcode() As String
        Randomize()
        If Cmb_ReminderType.Text <> "MEMBER" Then
            MsgBox("Contact Admin!!!")
            Exit Sub
        End If
        Dim vpageNo, vtdueamt As Double
        Dim Loopindex, vPhone, Vdate, vTotAmtDue, vCrAmt, Vrowcout, vPrnAmt, vMonth, vletterno
        Dim monthcnt As Integer
        Dim pno, psize As Integer
        Dim vString, vPrefix, vCompany, vMid, vName, vAdd1, vAdd2, vCity, vState, vpin, vadd3, vslcode
        Dim vSql, mdate, gAdd As String
        Dim dbltotop As Double
        Dim vsplit() As String
        vletterno = CMBLETERNO.Text
        If dtpASNODATE.Value > Dtp_CutOffDate.Value Then
            MsgBox("Please Check the Sales Upto Date", vbOKOnly, vbInformation)
            Exit Sub
        End If
        If CHKCATEGORY.CheckedItems.Count = 0 Then
            If TXTMCODEFrom.Text = "" Or TXTMCODETO.Text = "" Then
                MsgBox("Select Atleast any one Member Category")
                Exit Sub
            End If
        End If
        If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text = "" Then
            MsgBox("Member Code To Can't be Blank")
            Exit Sub
        ElseIf TXTMCODEFrom.Text = "" And TXTMCODETO.Text <> "" Then
            MsgBox("Member Code From Can't be Blank")
            Exit Sub
        End If
        'MONTH1 = Month(Dtp_CutOffDate.Value)
        MONTH1 = Month(dtpASNODATE.Value)
        SSQL = ""
        'sqlString = "Select isnull(slcode,'') as mcode,isnull(slname,'') as mname,"
        sqlString = "SELECT isnull(Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
        Call Opbalance()
        'If Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") = "31-Mar-2009" Then
        '    SSQL = " Select * From Vw_Reminder1 WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        'Else
        '    SSQL = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        'End If
        sqlString = sqlString & "  isnull(membertypecode,'') in ("
        'SSQL = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
            appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
            'SSQL = SSQL & " '" & appcode(0) & "', "
            sqlString = sqlString & " '" & appcode(0) & "', "
        Next
        'SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        'SSQL = SSQL & ")"
        sqlString = Mid(sqlString, 1, Len(sqlString) - 2)
        sqlString = sqlString & ") AND CURENTSTATUS = 'LIVE' order by A.slcode "
        If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text <> "" Then
            SSQL = SSQL & " AND MCODE BETWEEN '" & Trim(TXTMCODEFrom.Text) & "' AND '" & Trim(TXTMCODETO.Text) & "' "
        End If
        'SSQL = SSQL & " and ClosingBalance >=  " & Val(Txt_CreditLimit.Text) & "  order by mcode "
        'gconnection.getDataSet(sqlString, "REMINDER")
        Dim Viewer As New ReportViwer
        Dim r As New Reminder1
        Viewer.ssql = sqlString
        If vletterno = 1 Then
            Viewer.Report = r
        ElseIf vletterno = 2 Then

        End If
        Viewer.TableName = "VW_REMINDER"
        Viewer.Show()
        'If gdataset.Tables("REMINDER").Rows.Count > 0 Then
        '    vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
        '    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        '    Filewrite = File.AppendText(VFilePath)

        '    vletterno = CMBLETERNO.Text
        '    pno = 1
        '    psize = 0

        '    For I = 0 To gdataset.Tables("REMINDER").Rows.Count - 1
        '        'vSql = "select * from accountssubledgermaster where  slcode ='" & Trim(gdataset.Tables("REMINDER").Rows(I).Item("Mcode")) & "' and accode = 'dr1001'"
        '        vSql = "select ISNULL(MID,'') AS MID,ISNULL(COMPANY,'') AS COMPANY,ISNULL(PREFIX,'') AS PREFIX,isnull(mcode,'') as SLCODE,ISNULL(MNAME,'') AS SLNAME,ISNULL(PADD1,'') AS ADDRESS1, ISNULL(PADD2,'') AS ADDRESS2,ISNULL(PADD3,'') AS ADDRESS3,ISNULL(PCITY,'') AS CITY,ISNULL(PSTATE,'') AS STATE,ISNULL(PPIN,'') AS PIN from MEMBERMASTER where  Mcode ='" & Trim(gdataset.Tables("REMINDER").Rows(I).Item("Mcode")) & "'"
        '        gconnection.getDataSet(vSql, "MEMBER")
        '        If gdataset.Tables("MEMBER").Rows.Count > 0 Then
        '            vslcode = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLCODE") & "")
        '            vPrefix = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PREFIX") & "")
        '            vCompany = Trim(gdataset.Tables("MEMBER").Rows(0).Item("COMPANY") & "")
        '            vMid = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MID") & "")
        '            vName = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLNAME") & "")
        '            vAdd1 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS1") & "")
        '            vAdd2 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS2") & "")
        '            vadd3 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS3") & "")
        '            vCity = Trim(gdataset.Tables("MEMBER").Rows(0).Item("CITY") & "")
        '            vState = Trim(gdataset.Tables("MEMBER").Rows(0).Item("STATE") & "")
        '            vpin = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PIN") & "")
        '        End If
        '        For J = 0 To 2
        '            Filewrite.WriteLine()
        '        Next
        '        psize = psize + 2
        '        gAdd = "CHENNAI - 600008"
        '        Filewrite.WriteLine(Space(15) & Chr(18) & Chr(14) & gCompanyname & Chr(18))
        '        Filewrite.WriteLine(Space(18) & Chr(18) & Chr(14) & gAdd & Chr(18))
        '        ' Filewrite.WriteLine(Space(2) & gCompanyAddress(0) & "," & gCompanyAddress(1))
        '        'Filewrite.WriteLine(Space(2) & gCompanyAddress(1))
        '        'Filewrite.WriteLine(Space(2) & gCompanyAddress(2))
        '        psize = psize + 2

        '        For J = 0 To 2
        '            Filewrite.WriteLine()
        '        Next
        '        Filewrite.WriteLine(Space(2) & Format(Dtp_CutOffDate.Value, "dd/MM/yyyy"))
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine(Space(2) & vPrefix & Space(1) & vMid & Space(1) & vName & Space(2) & "(" & vslcode & ")")
        '        If vCompany <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCompany)
        '        Else
        '            Filewrite.WriteLine(Space(2) & vAdd1)
        '            vAdd1 = ""
        '        End If
        '        If vAdd1 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd1)
        '        ElseIf vAdd2 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd2)
        '            vAdd2 = ""
        '        Else
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '            vadd3 = ""
        '        End If
        '        If vAdd2 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd2)
        '        ElseIf vadd3 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '            vadd3 = ""
        '        Else
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '            vCity = ""
        '            vpin = ""
        '        End If
        '        If vadd3 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '        ElseIf vCity <> "" Or vpin <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '            vCity = ""
        '            vpin = ""
        '        End If
        '        If vCity <> "" Or vpin <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '        End If
        '        Vrowcout = 0
        '        psize = psize + 8
        '        If vletterno = 1 Then
        '            vhead = "FIRST"
        '        ElseIf vletterno = 2 Then
        '            vhead = "SECOND"
        '        Else
        '            vhead = "THIRD"
        '        End If
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine(Space(2) & "Dear " & vPrefix & Space(1) & vName)
        '        psize = psize + 3
        '        SSQL = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '        gconnection.getDataSet(SSQL, "LETTER")
        '        Dim samt() As String
        '        For Loopindex = 0 To gdataset.Tables("LETTER").Rows.Count - 1
        '            If InStr(gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE"), "(Rs.)") Then
        '                SSQL = gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE")
        '                samt = Split(SSQL, "(Rs.)")
        '                'SSQL = Space(2) & Trim(samt(0)) & " Rs." & Format(gdataset.Tables("REMINDER").Rows(I).Item("CLOSINGBALANCE"), "0.00") & " " & Trim(samt(1))
        '                SSQL = Space(2) & Trim(samt(0)) & " Rs." & Format(gdataset.Tables("REMINDER").Rows(I).Item("Amount"), "0.00") & " " & Trim(samt(1))
        '                Filewrite.WriteLine(SSQL)
        '                psize = psize + 1
        '            Else
        '                Filewrite.WriteLine(Space(2) & gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE"))
        '                psize = psize + 1
        '            End If
        '        Next
        '        Filewrite.WriteLine(Chr(12))
        '        pno = pno + 1
        '    Next
        '    For I = 0 To 5
        '        Filewrite.WriteLine()
        '    Next
        '    Filewrite.Close()
        '    If gPrint = False Then
        '        Call OpenTextFile(vOutfile)
        '    Else
        '        Call PrintTextFile(vOutfile)
        '    End If
        'End If
    End Sub

    Private Sub CHKCATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCATEGORY.SelectedIndexChanged
        Call remi()
    End Sub
    Private Sub remi()
        'Dim i As Long
        'Dim cat As String
        'posting = Nothing
        'catecode = ""
        'vtypedesc = ""
        'Try
        '    Dim remindercode, fromdate, todate, asondate, membertypecode As String
        '    Dim remindercount As Integer
        '    'fromdate = Format(DTPFROM.Value, "dd/MMM/yyyy")
        '    'Todate = Format(DTPFROM.Value, "dd/MMM/yyyy")
        '    asondate = Format(dtpASNODATE.Value, "dd/MMM/yyyy")

        '    If Trim(CMBLETERNO.Text) = 1 Then
        '        lettertype = "Subscription First Reminder Letter For :"
        '        addamt = 0
        '        vhead = "FIRST"
        '    ElseIf Trim(CMBLETERNO.Text) = 2 Then
        '        addamt = 100
        '        vhead = "SECOND"
        '        lettertype = "Subscription second Reminder Letter For :"
        '    ElseIf Trim(CMBLETERNO.Text) = 3 Then
        '        lettertype = "Subscription Third Reminder Letter For :"
        '        addamt = 0
        '        vhead = "THIRD"
        '    End If

        '    For i = 0 To CHKCATEGORY.Items.Count - 1
        '        If CHKCATEGORY.GetItemChecked(i) = True Then
        '            TempString = Split(CHKCATEGORY.Items.Item(i), ".")
        '            If catecode = "" Then
        '                catecode = "'" & TempString(0)
        '                cat = TempString(0)
        '                vtypedesc = TempString(1)
        '            Else
        '                catecode = catecode & "','" & TempString(0)
        '                vtypedesc = TempString(1)
        '            End If
        '        End If
        '    Next i
        '    catecode = catecode & "'"
        '    If ChKALL.Checked = False Then
        '        If Trim(CMBLETERNO.Text) <> "" And cat <> "" And Trim(cboBillingBasis.Text) <> "" Then
        '            sqlString = "SELECT ISNULL(ASONDATE,'') AS ASDATE,isnull(fromdate,'') as fromdate,isnull(todate,'') as todate FROM  reminderhistory "
        '            sqlString = sqlString & " where  remindercount=" & Trim(CMBLETERNO.Text)
        '            sqlString = sqlString & " and membertypecode='" & Trim(cat) & "'"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            posting = gconnection.GetValues(sqlString)
        '            If posting.Rows.Count > 0 Then
        '                'dtpASNODATE.Value = Format(posting.Rows(0).Item("asdate"), "dd/MM/yyyy")
        '                'DTPFROM.Value = Format(posting.Rows(0).Item("fromdate"), "dd/MM/yyyy")
        '                'DTPTO.Value = Format(posting.Rows(0).Item("todate"), "dd/MM/yyyy")
        '            End If
        '            firstdate = ""
        '            sqlString = "SELECT ISNULL(ASONDATE,'') AS ASDATE,isnull(fromdate,'') as fromdate,isnull(todate,'') as todate FROM  reminderhistory "
        '            sqlString = sqlString & " where  remindercount=1"
        '            sqlString = sqlString & " and membertypecode='" & Trim(cat) & "'"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            posting = gconnection.GetValues(sqlString)
        '            If posting.Rows.Count > 0 Then
        '                firstdate = Format(posting.Rows(0).Item("asdate"), "dd/MM/yyyy")
        '            End If
        '        End If
        '    Else
        '        firstdate = Format(Now(), "dd/MM/yyyy")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Function details()
        '        Dim sno, i, j, k As Integer
        '        Dim PERIOD, VTYPE As String
        '        Dim TAXAMOUNT As Double
        '        Dim dt As New DataTable
        '        Dim dt1 As New DataTable
        '        Dim ssql As String
        '        Dim lettertype, vhead, samt() As String
        '        Dim totbillamount, totadjamount, totbalamount, totaddamount, addamt
        '        Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount, netbal
        '        Dim pageno, pagesize
        '        Try
        '            If Trim(CMBLETERNO.Text) = 1 Then
        '                lettertype = "Subscription First Reminder Letter For :"
        '                addamt = 0
        '                vhead = "FIRST"
        '            ElseIf Trim(CMBLETERNO.Text) = 2 Then
        '                addamt = 100
        '                vhead = "SECOND"
        '                lettertype = "Subscription second Reminder Letter For :"
        '            ElseIf Trim(CMBLETERNO.Text) = 3 Then
        '                lettertype = "Subscription Third Reminder Letter For :"
        '                addamt = 0
        '                vhead = "THIRD"
        '            End If

        '            'PERIOD = Format(DTPFROM.Value, "dd-MMM-yyyy") & " TO " & Format(DTPTO.Value, "dd-MMM-yyyy")
        '            If ChKALL.Checked = False Then
        '                If Trim(TXTMCODEFrom.Text) <> "" And Trim(TXTMCODETO.Text) <> "" Then
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE AND C.PERIOD='" & Trim(PERIOD) & "' AND C.BILLINGBASIS='" & cboBillingBasis.Text & "'"
        '                    'ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND C.BILLINGBASIS='" & cboBillingBasis.Text & "' AND ISNULL(C.BILLINGBASIS,'')<>'' " 'AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' WHERE  A.Mcode BETWEEN '" & TXTMCODEFrom.Text & "' AND  '" & TXTMCODETO.Text & "'"
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2,A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & " HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  AND isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & " HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                Else
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE AND C.PERIOD='" & Trim(PERIOD) & "' AND C.BILLINGBASIS='" & cboBillingBasis.Text & "'"
        '                    'ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND C.BILLINGBASIS='" & cboBillingBasis.Text & "' AND ISNULL(C.BILLINGBASIS,'')<>'' " 'AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' "
        '                    ssql = ssql & " WHERE A.MEMBERTYPECODE IN (" & catecode & ") "
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2, A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 and isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                End If
        '            Else
        '                If Trim(TXTMCODEFrom.Text) <> "" And Trim(TXTMCODETO.Text) <> "" Then
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE "
        '                    ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND ISNULL(C.BILLINGBASIS,'')<>'' AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND  A.Mcode BETWEEN '" & TXTMCODEFrom.Text & "' AND  '" & TXTMCODETO.Text & "'"
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2,A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  AND isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                Else
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE "
        '                    ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    ssql = ssql & " AND ISNULL(C.BILLINGBASIS,'')<>'' AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' "
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2, A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 and isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                End If
        '            End If
        '            dt = Nothing
        '            dt = gconnection.GetValues(ssql)
        '            pageno = 1
        '            Randomize()
        '            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        '            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        '            Filewrite = File.AppendText(VFilePath)
        '            Filewrite.WriteLine()
        '            pagesize = 5
        '            If dt.Rows.Count > 0 Then
        '                sno = 1
        '                For i = 0 To dt.Rows.Count - 1
        '                    If Trim(CMBLETERNO.Text) = 1 Then
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine(Chr(27) + "E" & "THE SECRETARY" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "FIRST REMINDER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If j + 1 = dt1.Rows.Count Then
        '                                    'Filewrite.WriteLine(dt1.Rows(j).Item("message") & Space(1) & Format(DTPFROM.Value, "dd/MM/yyyy") & " To " & Format(DTPTO.Value, "dd/MM/yyyy"))
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                            Filewrite.WriteLine("as per Bill No :" & Chr(27) & "E" & Trim(dt.Rows(i).Item("voucherno")) & " Bill Amount Rs." & Format(dt.Rows(i).Item("amount"), "0.00" & "  Paid Amount "))
        '                            'Filewrite.WriteLine("Rs." & Format(dt.Rows(i).Item("adjamount"), "0.00") & " Due Amount Rs." & Format(dt.Rows(i).Item("balamount"), "0.00") & " is due from :" & Format(DTPFROM.Value, "dd/MM/yyyy") & Chr(27) & "F")
        '                            For j = 0 To 5
        '                                Filewrite.WriteLine("")
        '                            Next
        '                            Filewrite.WriteLine(Space(40) & "For The Presidency Club")
        '                            For j = 0 To 5
        '                                Filewrite.WriteLine("")
        '                            Next
        '                            Filewrite.WriteLine(Space(40) & "      SECRETARY")
        '                            Filewrite.WriteLine("")
        '                            Filewrite.WriteLine(StrDup(80, "-"))
        '                            Filewrite.WriteLine(Chr(27) + "E" & "If you have already paid please ignore this reminder." & Chr(27) + "F")
        '                            Filewrite.WriteLine(Chr(12))
        '                        End If
        '9:                  End If

        '                    If Trim(CMBLETERNO.Text) = 2 Then
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine("THE SECRETARY")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "SECOND REMINDER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        If Trim(cboBillingBasis.Text) = "QUARTERLY" Then
        '                            VTYPE = "QUARTER"
        '                        Else
        '                            VTYPE = "YEAR"
        '                        End If
        '                        Trim(cboBillingBasis.Text)
        '                        'Filewrite.WriteLine(Chr(27) + "E" & Space(15) & " Sub: Payment of Subscription for the " & Trim(VTYPE) & " ending " & Mid(Format(DTPTO.Value, "dd/MMM/yyyy"), 4, 3) & "-" & Year(DTPTO.Value) & Chr(27) + "F")
        '                        'Filewrite.WriteLine(Chr(27) + "E" & Space(15) & " Re.: Bill No. : " & dt.Rows(i).Item("voucherno") & " dated " & Format(DTPFROM.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            ssql = "select asondate from reminderhistory where  "
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
        '                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
        '                                    ssql = Trim(samt(0)) & " " & Trim(firstdate) & " " & Trim(samt(1))
        '                                    Filewrite.WriteLine(ssql)
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(StrDup(80, "-"))
        '                        'Filewrite.WriteLine(Chr(27) + "E" & "Bill No:" & Trim(dt.Rows(i).Item("voucherno")) & Space(5) & "Bill Period :" & Trim(Format(DTPFROM.Value, "dd/MM/yyyy")) & Space(2) & "To" & Space(2) & Trim(Format(DTPTO.Value, "dd/MM/yyyy")) & Chr(27) + "F")
        '                        Filewrite.WriteLine(Space(10) & "................................................................")
        '                        'PERIOD = Format(DTPFROM.Value, "dd-MMM-yyyy") & " TO " & Format(DTPTO.Value, "dd-MMM-yyyy")
        '                        If Trim(CMBLETERNO.Text) = 2 And Trim(cboBillingBasis.Text) = "YEARLY" Then
        '                            ssql = " SELECT a.MCODE,a.SUBSCODE,ISNULL(b.SUBSDESC,'') AS DESC1,ISNULL(a.AMOUNT,0) AS AMOUNT ,ISNULL(a.TAXAMOUNT,0) AS TAXAMOUNT "
        '                            ssql = ssql & " FROM SUBSPOSTING a, SUBSCRIPTIONMAST B WHERE A.PERIOD='" & Trim(PERIOD) & "' AND A.POSTINGCODE='" & cboBillingBasis.Text & "' AND B.SUBSDESC not like '%OPTIONAL%' AND A.Mcode='" & dt.Rows(i).Item("mcode") & "' AND A.SUBSCODE=B.SUBSCODE ORDER BY A.MCODE"
        '                        Else
        '                            ssql = " SELECT A.MCODE,A.SUBSCODE,ISNULL(B.SUBSDESC,'') AS DESC1,ISNULL(A.AMOUNT,0) AS AMOUNT ,ISNULL(A.TAXAMOUNT,0) AS TAXAMOUNT "
        '                            ssql = ssql & " FROM SUBSPOSTING  A,SUBSCRIPTIONMAST B WHERE A.PERIOD='" & Trim(PERIOD) & "' AND A.POSTINGCODE='" & cboBillingBasis.Text & "' AND B.SUBSDESC not like '%OPTIONAL%' AND A.Mcode='" & dt.Rows(i).Item("mcode") & "' AND A.SUBSCODE=B.SUBSCODE ORDER BY A.MCODE"
        '                        End If
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        netbal = 0
        '                        TAXAMOUNT = 0
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                Filewrite.WriteLine(Space(10) & Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30) & Space(30 - Len(Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30))) & Space(4) & Space(8 - Len(Format(dt1.Rows(j).Item("amount"), "0.00"))) & Format(dt1.Rows(j).Item("amount"), "0.00"))
        '                                netbal = netbal + Val(dt1.Rows(j).Item("amount"))
        '                                TAXAMOUNT = TAXAMOUNT + Val(dt1.Rows(j).Item("TAXamount"))
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(Space(10) & Mid(Trim("SERVICE TAX"), 1, 30) & Space(30 - Len(Mid(Trim("SERVICE TAX"), 1, 30))) & Space(4) & Space(8 - Len(Mid(Format(TAXAMOUNT, "0.00"), 1, 8))) & Mid(Format(TAXAMOUNT, "0.00"), 1, 8))
        '                        Filewrite.WriteLine(Space(10) & Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30) & Space(30 - Len(Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30))) & Space(4) & Space(8 - Len(Mid(Format(addamt, "0.00"), 1, 8))) & Mid(Format(addamt, "0.00"), 1, 8))
        '                        netbal = netbal + addamt + TAXAMOUNT
        '                        Filewrite.WriteLine(Space(40) & "-----------------")
        '                        Filewrite.WriteLine(Space(10) & "Total" & Space(29) & Space(8 - Len(Mid(Format(netbal, "0.00"), 1, 8))) & Mid(Format(netbal, "0.00"), 1, 8))
        '                        Filewrite.WriteLine(Space(40) & "-----------------")
        '                        'netbal = netbal + addamt
        '                        Filewrite.WriteLine(Space(10) & "................................................................")
        '                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
        '                    End If
        '                    If Trim(CMBLETERNO.Text) = 3 Then
        '                        'THIRD letter
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine("The SECRETARY")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "POSTING LETTER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
        '                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
        '                                    ssql = Trim(samt(0)) & " " & Trim(dtpASNODATE.Value) & " " & Trim(samt(1))
        '                                    Filewrite.WriteLine(ssql)
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
        '                    End If
        '                Next i
        '            End If
        '            Filewrite.Close()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        End Try
        '        If PRINTREP = False Then
        '            OpenTextFile(vOutfile)
        '        Else
        '            PrintTextFile(vOutfile)
        '        End If
    End Function

    Private Function SUMMARY()
        Try
            Dim pageno, pagesize, sno, k, i, j
            Dim ssql, appcode() As String
            Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount As Double
            Dim totbillamount, totadjamount, totbalamount, totaddamount As Double
            Dim Interest As Double
            Dim str, T As String

            'If Txt_Interest.Text = "" Then
            '    Txt_Interest.Text = 0
            '    'MsgBox("Please Enter the Interest Amount", vbOKOnly, vbInformation)
            '    'Exit Function
            'End If
            If dtpASNODATE.Value > Dtp_CutOffDate.Value Then
                MsgBox("Please Check the Sales Upto Date", vbOKOnly, vbInformation)
                Exit Function
            End If
            If CHKCATEGORY.CheckedItems.Count = 0 Then
                If TXTMCODEFrom.Text = "" Or TXTMCODETO.Text = "" Then
                    MsgBox("Select Atleast any one Member Category")

                    Exit Try

                End If
            End If
            If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text = "" Then
                MsgBox("Member Code To Can't be Blank")
                Exit Try
            ElseIf TXTMCODEFrom.Text = "" And TXTMCODETO.Text <> "" Then
                MsgBox("Member Code From Can't be Blank")
                Exit Try
            End If
            'MONTH1 = Month(Dtp_CutOffDate.Value)
            MONTH1 = Month(dtpASNODATE.Value)
            ssql = ""
            'sqlString = "Select isnull(slcode,'') as mcode,isnull(slname,'') as mname,"
            sqlString = "SELECT isnull(Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
            Call Opbalance()

            'If Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") = "31-Mar-2009" Then
            '    ssql = " Select * From Vw_Reminder1 WHERE ISNULL(MEMBERTYPECODE,'') IN ("
            'Else
            '    ssql = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
            'End If
            sqlString = sqlString & "  isnull(membertypecode,'') in ("
            For i = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(i), ".")
                ssql = ssql & " '" & appcode(0) & "', "
                sqlString = sqlString & " '" & appcode(0) & "', "
            Next
            ssql = Mid(ssql, 1, Len(ssql) - 2)
            ssql = ssql & ")"
            sqlString = Mid(sqlString, 1, Len(sqlString) - 2)
            sqlString = sqlString & ") AND CURENTSTATUS = 'LIVE' order by A.slcode"
            If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text <> "" Then
                ssql = ssql & " AND MCODE BETWEEN '" & Trim(TXTMCODEFrom.Text) & "' AND '" & Trim(TXTMCODETO.Text) & "' "
            End If
            'ssql = ssql & " and ClosingBalance >=  " & Val(Txt_CreditLimit.Text) & "  order by mcode "
            'gconnection.getDataSet(ssql, "REMINDER")
            'gconnection.getDataSet(sqlString, "REMINDER")

            Dim Viewer As New ReportViwer
            Dim r As New Remainder1Summary
            Viewer.ssql = sqlString
            Viewer.Report = r
            Viewer.TableName = "VW_REMINDER"
            Viewer.Show()


            'pageno = 1 : pagesize = 1
            'If gdataset.Tables("REMINDER").Rows.Count > 0 Then
            '    vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
            '    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            '    Filewrite = File.AppendText(VFilePath)

            '    CompanyAddress = "ETHIRAJ SALAI, EGMORE, MADRAS"
            '    Filewrite.WriteLine(Chr(27) & "@")
            '    Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            '    Filewrite.WriteLine(StrDup(80, "*"))
            '    Filewrite.WriteLine(Chr(27) & "E")
            '    Filewrite.WriteLine("{0,-80}", gCompanyname)
            '    Filewrite.Write(Chr(27) & "F")
            '    Filewrite.WriteLine("{0,-80}", CompanyAddress)
            '    'Filewrite.WriteLine("{0,-80}", StrDup(Len(CompanyAddress), "_"))
            '    Filewrite.Write(Chr(27) & "E")
            '    Filewrite.WriteLine("{0,-80}", "Report: Reminder Letter Summary")
            '    Filewrite.WriteLine(Chr(27) & "F")
            '    str = "{0,-20}{1," & (80 - 40) & "}"
            '    Filewrite.WriteLine(str, "Printed On: " & Date.Now, "Page Number:" & pageno)
            '    Filewrite.WriteLine(StrDup(80, "*"))

            '    Filewrite.WriteLine("Reminder Date: " & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Space(58)) '& "Page No:" & Trim(CStr(pageno)))
            '    Filewrite.WriteLine(StrDup(80, "-"))
            '    'Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                        Bill No            Date         Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '    Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                                                 Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '    Filewrite.WriteLine(StrDup(80, "-"))
            '    pagesize = pagesize + 5
            '    sno = 1

            '    For i = 0 To gdataset.Tables("REMINDER").Rows.Count - 1
            '        If pagesize >= 60 Then
            '            pageno = pageno + 1
            '            Filewrite.WriteLine(StrDup(80, "-"))

            '            CompanyAddress = "8, ADYAR CLUB GATE ROAD, MADRAS, 600 028"
            '            Filewrite.WriteLine(Chr(27) & "@")
            '            Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            '            Filewrite.WriteLine(StrDup(80, "*"))
            '            Filewrite.WriteLine(Chr(27) & "E")
            '            Filewrite.WriteLine("{0,-80}", gCompanyname)
            '            Filewrite.Write(Chr(27) & "F")
            '            Filewrite.WriteLine("{0,-80}", CompanyAddress)
            '            'Filewrite.WriteLine("{0,-80}", StrDup(Len(CompanyAddress), "_"))
            '            Filewrite.Write(Chr(27) & "E")
            '            Filewrite.WriteLine("{0,-80}", "Report: Reminder Letter Summary")
            '            Filewrite.WriteLine(Chr(27) & "F")
            '            str = "{0,-20}{1," & (80 - 40) & "}"
            '            Filewrite.WriteLine(str, "Printed On: " & Date.Now, "Page Number:" & pageno)
            '            Filewrite.WriteLine(StrDup(80, "*"))

            '            ssql = Space(10) & "              " & Space(47) & Space(10 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 10))) & Mid(Format(Val(totbillamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 10))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 10))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 10)
            '            Filewrite.WriteLine(ssql)
            '            Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
            '            pagebillamount = 0
            '            pageadjamount = 0
            '            pagebalamount = 0
            '            pageaddamount = 0
            '            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            '            pagesize = 1
            '            'Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F")
            '            If Len(vtypedesc) <= 74 Then
            '                Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F")
            '                pagesize = pagesize + 1
            '            Else
            '                Filewrite.Write(Chr(27) + "E" & Trim(lettertype))
            '                j = 0
            '                For k = 1 To Len(Trim(vtypedesc))
            '                    If j = 0 Then
            '                        Filewrite.WriteLine(Mid(Trim(vtypedesc), k, 74))
            '                        pagesize = pagesize + 1
            '                        k = k + 73
            '                    Else
            '                        Filewrite.WriteLine(Mid(Trim(vtypedesc), k, 115))
            '                        pagesize = pagesize + 1
            '                        k = k + 114
            '                    End If
            '                    j = j + 1
            '                Next
            '            End If
            '            'Filewrite.WriteLine("Period From " & Format(DTPFROM.Value, "dd/MM/yyyy") & " To " & Format(DTPTO.Value, "dd/MM/yyyy"))
            '            Filewrite.WriteLine("Reminder Date: " & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Space(58) & "Page No:" & Trim(CStr(pageno)))
            '            Filewrite.WriteLine(StrDup(80, "-"))
            '            Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                                                 Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '            Filewrite.WriteLine(StrDup(80, "-"))
            '            pagesize = pagesize + 5
            '        End If
            '        'Interest = Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE"))
            '        Interest = Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount"))
            '        Interest = (Interest * Val(Txt_Interest.Text)) / 100
            '        ssql = Space(1) & Mid(sno, 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & Space(1) & Mid(gdataset.Tables("REMINDER").Rows(i).Item("mcode"), 1, 7) & Space(7 - Len(Mid(gdataset.Tables("REMINDER").Rows(i).Item("mcode"), 1, 7))) & Mid(gdataset.Tables("REMINDER").Rows(i).Item("mname"), 1, 53) & Space(1) & Space(53 - Len(Mid(gdataset.Tables("REMINDER").Rows(i).Item("mname"), 1, 53)))
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE")), "0.00"), 1, 10)
            '        ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount")), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(addamt), "0.00"), 1, 10))) & Mid(Format(Val(addamt), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 10))) & Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 10)
            '        Filewrite.WriteLine(ssql)
            '        pagesize = pagesize + 1
            '        'pagebillamount = pagebillamount + Val(gdataset.Tables("REMINDER").Rows(i).Item("closingbalance"))
            '        pagebillamount = pagebillamount + Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount"))
            '        'pageadjamount = pageadjamount + Val(dt.Rows(i).Item("adjamount"))
            '        'pagebalamount = pagebalamount + Val(dt.Rows(i).Item("balamount")) + addamt
            '        'pageaddamount = pageaddamount + addamt
            '        ''totaddamount = pageaddamount + addamt
            '        'totbillamount = totbillamount + Val(dt.Rows(i).Item("amount"))
            '        'totadjamount = totadjamount + Val(dt.Rows(i).Item("adjamount"))
            '        'totbalamount = totbalamount + Val(dt.Rows(i).Item("balamount")) + addamt
            '        'totaddamount = totaddamount + addamt
            '        sno = sno + 1
            '    Next
            '    sno = sno - 1
            '    If pagesize <= 60 Then
            '        Filewrite.WriteLine(StrDup(80, "-"))
            '        ssql = Space(10) & "              " & Space(42) & Space(10 - Len(Mid(Format(Val(pagebillamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebillamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 10))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 10))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 10)
            '        Filewrite.WriteLine(ssql)
            '        Filewrite.WriteLine(StrDup(80, "-"))
            '        pagebillamount = 0
            '        pageadjamount = 0
            '        pagebalamount = 0
            '    End If
            '    ssql = "No.of(Members) =  " & Mid(Trim(CStr(sno)), 1, 5) & Space(5 - Len(Mid(Trim(CStr(sno)), 1, 5))) ' & Space(48) & Space(10 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 10))) & Mid(Format(Val(totbillamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totadjamount), "0.00"), 1, 10))) & Mid(Format(Val(totadjamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totaddamount), "0.00"), 1, 10))) & Mid(Format(Val(totaddamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totbalamount), "0.00"), 1, 10))) & Mid(Format(Val(totbalamount), "0.00"), 1, 10)
            '    Filewrite.WriteLine(ssql)
            '    Filewrite.WriteLine(StrDup(80, "-") & Chr(12))

            '    Filewrite.Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        'If gPrint = False Then
        '    OpenTextFile(vOutfile)
        'Else
        '    PrintTextFile(vOutfile)
        'End If
    End Function
    Private Sub screenprint()
        'Dim i As Integer
        'If Trim(CMBLETERNO.Text) = "" Then
        '    MessageBox.Show("Please Select Letter Code")
        '    Exit Sub
        'End If
        'If TXTMCODEFrom.Text = "" And TXTMCODETO.Text = "" Then
        '    If Trim(catecode) = "" Then
        '        MessageBox.Show("Please Select Category Code")
        '        Exit Sub
        '    End If
        'End If
        'If ChKALL.Checked = False Then
        '    If Trim(cboBillingBasis.Text) = "" Then
        '        MessageBox.Show("Please Select the Bill Type")
        '        Exit Sub
        '    End If
        'End If
        'catecode = ""
        'For i = 0 To CHKCATEGORY.Items.Count - 1
        '    If CHKCATEGORY.GetItemChecked(i) = True Then
        '        TempString = Split(CHKCATEGORY.Items.Item(i), ".")
        '        If catecode = "" Then
        '            catecode = "'" & TempString(0)
        '            vtypedesc = Trim(TempString(1))
        '        Else
        '            catecode = catecode & "','" & TempString(0)
        '            vtypedesc = Trim(vtypedesc) & "," & Trim(TempString(1))
        '        End If
        '    End If
        'Next i
        'catecode = catecode & "'"
        'If ChKALL.Checked = False Then
        '    If TXTMCODEFrom.Text = "" And TXTMCODETO.Text = "" Then
        '        If Trim(CMBLETERNO.Text) <> "" And catecode <> "" And Trim(cboBillingBasis.Text) <> "" Then
        '            sqlString = "update reminderhistory set  asondate='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '            sqlString = sqlString & " where  remindercount=" & Trim(CMBLETERNO.Text)
        '            sqlString = sqlString & " and membertypecode in(" & Trim(catecode) & ")"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            'sqlString = sqlString & " and  fromdate='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'"
        '            'sqlString = sqlString & " and  todate='" & Format(DTPTO.Value, "dd/MMM/yyyy") & "'"
        '            posting = gconnection.GetValues(sqlString)
        '        End If
        '    End If
        'End If
        'If RBTREMINDERLETTER.Checked = True Then
        '    Call details()
        'Else
        '    Call SUMMARY()
        'End If
    End Sub
    Private Sub BTNPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPRINT.Click
        '''gPrint = True
        '''If RBTREMINDERLETTER.Checked = True Then
        '''    Call PrintOperation1()
        '''End If
        '''If RBTREMINDERSUMMARY.Checked = True Then
        '''    Call SUMMARY()
        '''End If
        'Call screenprint()

        gPrint = False

        If CHKCATEGORY.CheckedItems.Count = 0 Then
            MessageBox.Show("Please Select  the Member Category")
            CHKCATEGORY.Focus()
            Exit Sub
        End If
        If CMBLETERNO.Text = "" Then
            MessageBox.Show("Please Select The Letter No ")
            CMBLETERNO.Focus()
            Exit Sub
        End If

        If CMBLETERNO.Text = "1" Or CMBLETERNO.Text = "2" Or CMBLETERNO.Text = "3" Or CMBLETERNO.Text = "4" Then
            If RBTREMINDERLETTER.Checked = True Then
                Call Printoperation2()
            End If
            If RBTREMINDERSUMMARY.Checked = True Then
                Call Summary2()

            End If
        End If
    End Sub
    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTMCODETO.Text = Trim(vform.keyfield & "")
            BTNSCREEN.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTMCODEFrom.Text = Trim(vform.keyfield & "")
            TXTMCODETO.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub dtpASNODATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpASNODATE.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODEFrom.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMCODETO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BTNSCREEN.Focus()
        End If
    End Sub
    Private Sub TXTMCODEFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub CHKCATEGORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CHKCATEGORY.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODEFrom.Focus()
        End If
    End Sub
    Private Sub CMBLETERNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBLETERNO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            'cboBillingBasis.Focus()
        End If
    End Sub
    Private Sub cboBillingBasis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            CHKCATEGORY.Focus()
        End If
    End Sub
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Hide()
    End Sub
    Private Sub TXTMCODEFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
            If TXTMCODEFrom.Text = "" Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTMCODETO.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
            If TXTMCODETO.Text = "" Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
            BTNSCREEN.Focus()
        End If
    End Sub
    Private Sub CHKCATEGORY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHKCATEGORY.LostFocus
        Call remi()
    End Sub
    Private Sub cboBillingBasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim i As Long
        'posting = Nothing
        'Try
        '    sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
        '    posting = gconnection.GetValues(sqlString)
        '    If posting.Rows.Count > 0 Then
        '        cboBillingBasis.Items.Clear()
        '        For i = 0 To posting.Rows.Count - 1
        '            cboBillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
        '        Next
        '    End If
        '    gconnection.closeConnection()
        '    dtpASNODATE.Focus()
        '    CMBLETERNO.SelectedIndex = 0
        '    cboBillingBasis.SelectedIndex = 0
        '    sqlString = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        '    posting = gconnection.GetValues(sqlString)
        '    CHKCATEGORY.Items.Clear()
        '    If posting.Rows.Count > 1 Then
        '        For i = 0 To (posting.Rows.Count - 1)
        '            CHKCATEGORY.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
        '        Next
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (CHKCATEGORY.Items.Count - 1)
                    CHKCATEGORY.SetSelected(Iteration, True)
                    CHKCATEGORY.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (CHKCATEGORY.Items.Count - 1)
                    CHKCATEGORY.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reminder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cmb_ReminderType.SelectedIndex = 0
        CMBLETERNO.SelectedIndex = 0
        Dim i As Long
        posting = Nothing
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Try
            CMBLETERNO.SelectedIndex = 0
            sqlString = "SELECT ISNULL(SUBTYPECODE,'') AS MEMBERTYPE,ISNULL(SUBTypeDesc,'') AS TYPEDESC FROM SUBCATEGORYMASTER"
            posting = gconnection.GetValues(sqlString)
            CHKCATEGORY.Items.Clear()
            If posting.Rows.Count > 1 Then
                For i = 0 To (posting.Rows.Count - 1)
                    CHKCATEGORY.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
                Next
            End If
            dtpASNODATE.Value = Date.Now
            Dtp_CutOffDate.Value = Date.Now
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        RBTREMINDERLETTER.Checked = True
        'Dtp_rem.Visible = True
        'DTP_FIRST.Visible = True
        PLoad()
        Call picture()
    End Sub
    Public Sub picture()
        'PIC1.Image = New Bitmap(AppPath & "\tnbsa logo.JPG")
        'gconnection.SaveCLUBFoto(AppPath & "\tnbsa logo.JPG", "RSIFRONT")
        'Dim SQLSTRING As String
        'Dim I As Integer
        'SQLSTRING = "SELECT clublogo FROM accountsSetUp "
        'gconnection.getDataSet(SQLSTRING, "PHOTO")
        ''If gdataset.Tables("PHOTO").Rows.Count > 0 Then
        ''    For I = 0 To gdataset.Tables("PHOTO").Rows.Count - 1
        ''        With SSGRID
        ''            .Row = I + 1
        ''            .Col = 1
        ''            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MCODE")
        ''            .Col = 2
        ''            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MNAME")
        ''            .MaxRows = .MaxRows + 1
        ''        End With
        ''    Next
        ''End If

        'Dim ssql As String
        'Dim MEMBERTYPE As New DataTable
        'ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        'MEMBERTYPE = gconnection.GetValues(ssql)
        'Dim Itration
        'For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        'Next
        'LoadUnitNO()
        'chk_Filter_Field.Focus()
        'RDOCOMBINEDNO.Checked = True
    End Sub
    Function Opbalance()
        'sqlString = " SELECT SLCODE,"
        Dim S, R As String
        S = Format(dtpASNODATE.Value, "MMM-yyyy")
        R = Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy")

        Select Case (MONTH1)
            Case 4
                sqlString = sqlString & "isnull(isnull(opdebits,0)- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE  from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull(isnull(opdebits,0)- (isnull(opcredits,0)+ isnull(APRcredits,0)+isnull(maycredits,0)),0)  > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 5
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "

                'sqlString = sqlString & "isnull((isnull(opdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 6
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 7
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 8
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 9
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 10
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 11
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 12
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 1
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 2
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 3
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0)+isnull(febdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0)+isnull(febdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
        End Select
    End Function

    Private Sub rbtPartyLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim pleter As New PLetter
        'pleter.Show()
    End Sub

    'Private Sub OrdernoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim vform As New ListOperation
    '    gSQLString = "Select Orderno ,Orderdate  from Party_Order"
    '    M_WhereCondition = " "
    '    vform.Field = "Orderno,Orderdate "
    '    vform.vFormatstring = "  Order No.  | Order Date                      "
    '    vform.vCaption = "Party Order Help"
    '    vform.KeyPos = 0
    '    vform.KeyPos1 = 1
    '    vform.ShowDialog(Me)
    '    If Trim(vform.keyfield & "") <> "" Then
    '        Txt_Orderno.Text = Trim(vform.keyfield & "")
    '    End If
    '    vform.Close()
    '    vform = Nothing
    'End Sub

    'Private Sub Txt_Orderno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If Txt_Orderno.Text = "" Then
    '            Call OrdernoHelp_Click(sender, e)
    '        End If
    '    End If
    '    If e.KeyCode = Keys.F4 Then
    '        Call OrdernoHelp_Click(sender, e)
    '    End If
    'End Sub

    Private Sub rbtPartyLetter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rbtPartyLetter.Checked = True Then
        '    Txt_Orderno.Visible = True
        '    OrdernoHelp.Visible = True
        'Else
        '    Txt_Orderno.Visible = False
        '    OrdernoHelp.Visible = False
        'End If
    End Sub

    Private Sub Summary1()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try
            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            If Val(Txt_CreditLimit.Text) > 0 Then
                If Txt_CreditLimit.Text = "" Then
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL <> 0 AND CURENTSTATUS = 'LIVE'"
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) <> 0 AND  "
                    'vSql = vSql & "isnull(membertypecode,'') in ( 'F ',  'HM ',  'I ',  'L ',  'LA ',  'R ',  'SD ',  'T ') AND CURENTSTATUS = 'LIVE' order by O.MCODE"
                Else
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & "  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND CURENTSTATUS = 'LIVE'"
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND  "
                End If
            End If
            vSql = ""
            If CMBLETERNO.Text = "1" Then
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= 1000 " & " AND "
            Else
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            End If

            vSql = vSql & " isnull(type,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next
            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND CURENTSTATUS = 'LIVE' order by MCODE "
            'DT = gconnection.GetValues(vSql)

            Dim Viewer As New ReportViwer
            Dim r As New Remainder1Summary
            Viewer.ssql = vSql
            Viewer.Report = r
            Viewer.TableName = "OUTSTANDRPT_SUMMARY"
            Viewer.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub
    Private Sub Printoperation2()
        Dim DT As New DataTable
        Dim billdate, todate As DateTime
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1, bill, bill1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try
            vSql = ""
            billdate = DateAdd(DateInterval.Day, -45, dtpASNODATE.Value)

            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(billdate, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            vSql = ""
            If Val(Txt_CreditLimit.Text) > 0 Then
                If Txt_CreditLimit.Text = "" Then

                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL <> 0 AND CURENTSTATUS = 'LIVE'"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    'vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) <> 0 AND  "

                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) > 250 AND "

                Else
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & "  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND CURENTSTATUS = 'LIVE'"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    'vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND  "

                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) > 250 AND "
                    'If CMBLETERNO.Text = "1" Then
                    '    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ADD1,ADD2,ADD3,CITY,PIN,"
                    '    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O  INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  "
                    '    vSql = vSql & " where isnull(CLBAL,0) >= 1000 " & " AND "
                    'Else
                    '    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ADD1,ADD2,ADD3,CITY,PIN,"
                    '    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O  INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  "
                    '    vSql = vSql & " where isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "

                    'End If
                End If
            End If
            vSql = ""
            If CMBLETERNO.Text = "1" Then
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= 250 AND "
                'vSql = "select * from OUTSTANDRPT_SUMMARY O,membermaster M,membertype MT  where O.Mcode=M.Mcode and O.Type=MT.MemberType and isnull(O.CLBAL,0) >= 1000 " & " AND "

            Else
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= 250 AND "
                'vSql = "select *  from OUTSTANDRPT_SUMMARY O,membermaster M,membertype MT  where O.Mcode=M.Mcode and O.Type=MT.MemberType and isnull(O.CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            End If

            vSql = vSql & " isnull(type,'') in ("
            'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next

            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND CURENTSTATUS IN('LIVE','ACTIVE') order by typeorder,prefix,orderno asc "
            'vSql = vSql & ") AND CURENTSTATUS = 'LIVE' order by prefix,orderno,mcode  "
            'DT = gconnection.GetValues(vSql)

            Dim Viewer As New ReportViwer

            Dim r As New Reminder1
            Dim r1 As New Reminder2
            Dim r3 As New Reminder3
            Dim r4 As New Remainder4
            Dim r5 As New ReminderHGA1
            Dim r6 As New ReminderHGA2
            Dim r7 As New ReminderHGA3
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialYearEnd, 7, 4)
            Viewer.ssql = vSql

            If CMBLETERNO.Text = "1" Then
                If gCompanyname = "HYDERABAD GOLF ASSOCIATION" Then
                    Viewer.Report = r5
                Else
                    Viewer.Report = r
                End If

            ElseIf CMBLETERNO.Text = "2" Then
                If gCompanyname = "HYDERABAD GOLF ASSOCIATION" Then
                    Viewer.Report = r6
                Else
                    Viewer.Report = r1
                End If
            ElseIf CMBLETERNO.Text = "3" Then
                If gCompanyname = "HYDERABAD GOLF ASSOCIATION" Then
                    Viewer.Report = r7
                Else
                    Viewer.Report = r3
                End If
            ElseIf CMBLETERNO.Text = "4" Then
                Viewer.Report = r4
            End If
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r1.ReportDefinition.ReportObjects("Text5")
            'txtobj1.Text = UCase(gCompanyname)
            'txtobj1 = r1.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r1.ReportDefinition.ReportObjects("Text8")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r1.ReportDefinition.ReportObjects("Text10")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r3.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyname)
            'txtobj1 = r3.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(1))

            'txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            'txtobj1.Text = dtpASNODATE.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = Format(dtpASNODATE.Value, "dd") & ", " & bill
            'txtobj1 = r1.ReportDefinition.ReportObjects("Text14")
            'txtobj1.Text = bill
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = Dtp_rem.Value
            txtobj1 = r.ReportDefinition.ReportObjects("Text18")
            txtobj1.Text = "Amount Received upto " & Dtp_CutOffDate.Text & "has been accounted for"
            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = bill
            Viewer.TableName = "OUTSTANDRPT_SUMMARY"
            Viewer.Show()
            'Viewer.TableName = "VW_REMINDER"
            Viewer.TableName = "OUTSTANDRPT_SUMMARY"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub Summary2()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try
            vSql = ""
            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            vSql = ""
            If Val(Txt_CreditLimit.Text) > 0 Then
                If Txt_CreditLimit.Text = "" Then
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL <> 0 AND CURENTSTATUS = 'LIVE'"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    'vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) <> 0 AND  "

                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) <> 0 AND "

                Else
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) > " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                End If
            End If
            vSql = ""
            If CMBLETERNO.Text = "1" Then
                vSql = "select ISNULL(O.MCODE,'') AS MCODE,ISNULL(O.SLNAME,'') AS SLNAME,ISNULL(M.CONTEMAIL,'') AS ADD1,ISNULL(M.CONTCELL,'') AS PHONE,ISNULL(O.CLBAL,0) AS CLBAL from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            Else
                vSql = "select ISNULL(O.MCODE,'') AS MCODE,ISNULL(O.SLNAME,'') AS SLNAME,ISNULL(M.CONTEMAIL,'') AS ADD1,ISNULL(M.CONTCELL,'') AS PHONE,ISNULL(O.CLBAL,0) AS CLBAL from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            End If

            vSql = vSql & " isnull(O.type,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next

            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND M.CURENTSTATUS IN('LIVE','ACTIVE') order by O.typeorder,O.prefix,O.orderno asc "
            Dim Viewer As New ReportViwer
            Dim r As New Remainder1Summary
            Viewer.ssql = vSql
            Viewer.Report = r
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(3))
            Viewer.TableName = "OUTSTANDRPT_SUMMARY"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub abv_10000_lttr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub reminder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If BTNSCREEN.Enabled = True Then
                BTNSCREEN_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F6 Then
            If BTNPRINT.Enabled = True Then
                BTNPRINT_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F11 Then
            Btn_close_Click(sender, e)
        End If
    End Sub


    Private Sub CMBLETERNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBLETERNO.SelectedIndexChanged
        PLoad()
    End Sub
    Public Sub PLoad()
        Dim sql As String
        If CMBLETERNO.Text = "1" Then
            sql = "Select convert(varchar,getdate()-25,103) as CDate"
            

        ElseIf CMBLETERNO.Text = "2" Then
            sql = "Select convert(varchar,getdate()-60,103) as CDate"
           
        ElseIf CMBLETERNO.Text = "3" Then
            sql = "Select convert(varchar,getdate()-70,103) as CDate"
          
        ElseIf CMBLETERNO.Text = "4" Then
            sql = "Select convert(varchar,getdate()-100,103) as CDate"
          

        End If
        posting = gconnection.GetValues(sql)
        If posting.Rows.Count > 0 Then
            dtpASNODATE.Value = (posting.Rows(0).Item("CDate"))

        End If
    End Sub
    Public Sub ParameterString(ByVal chkcat As String, ByVal bdate As String, ByVal rdate As String)
        Dim I As Integer
        Dim category, categoryall As String
        'For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
        '    category = Split(CHKCATEGORY.CheckedItems(I))
        '    categoryall =  '" & category(0) & "', "
        'Next



    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub Dtp_CutOffDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_CutOffDate.ValueChanged

    End Sub
    Private Sub TXTMCODEFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TXTMCODETO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMCODETO.TextChanged

    End Sub
    Private Sub letterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letterno.Click

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dtpASNODATE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpASNODATE.ValueChanged

    End Sub
    Private Sub Txt_CreditLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_CreditLimit.TextChanged

    End Sub
    Private Sub Cmb_ReminderType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_ReminderType.SelectedIndexChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmd_MCodefromHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_FIRST.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Dim _export As New EXPORT
        Try
            vSql = ""
            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            vSql = ""
            If Val(Txt_CreditLimit.Text) > 0 Then
                If Txt_CreditLimit.Text = "" Then
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL <> 0 AND CURENTSTATUS = 'LIVE'"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    'vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) <> 0 AND  "

                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) <> 0 AND "

                Else
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
                    vSql = vSql & "isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE  where isnull(CLBAL,0) > " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                End If
            End If
            vSql = ""
            If CMBLETERNO.Text = "1" Then
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            Else
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            End If
            'If CMBLETERNO.Text = "1" Then
            '    vSql = "select ISNULL(O.MCODE,'') AS MCODE,ISNULL(O.SLNAME,'') AS SLNAME,ISNULL(M.CONTEMAIL,'') AS ADD1,ISNULL(M.CONTCELL,'') AS PHONE,ISNULL(O.CLBAL,0) AS CLBAL from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            'Else
            '    vSql = "select ISNULL(O.MCODE,'') AS MCODE,ISNULL(O.SLNAME,'') AS SLNAME,ISNULL(M.CONTEMAIL,'') AS ADD1,ISNULL(M.CONTCELL,'') AS PHONE,ISNULL(O.CLBAL,0) AS CLBAL from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            'End If

            'vSql = vSql & " isnull(O.type,'') in ("
            'For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
            '    appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
            '    vSql = vSql & " '" & appcode(0) & "', "
            'Next

            'vSql = Mid(vSql, 1, Len(vSql) - 2)
            'vSql = vSql & ") AND ISNULL(O.CURENTSTATUS,'') IN('LIVE','ACTIVE') order by O.typeorder,O.prefix,O.orderno asc "
            'If CMBLETERNO.Text = "1" Then
            '    vSql = "select * from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            'Else
            '    vSql = "select * from OUTSTANDRPT_SUMMARY O,MEMBERMASTER M where M.MCODE=O.MCODE AND isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            'End If

            vSql = vSql & " isnull(type,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next

            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND CURENTSTATUS IN('LIVE','ACTIVE') order by typeorder,prefix,orderno asc "
            _export.TABLENAME = "OUTSTANDRPT_SUMMARY"
            Call _export.export_excel(vSql)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




End Class
