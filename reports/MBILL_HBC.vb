Imports System.Data.SqlClient
'Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
'Imports System.Configuration
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.ComponentModel.Design
Imports System.IO
'Imports CrystalDecisions.reportsource
'Imports CrystalDecisions.shared
'Imports CrystalDecisions.web
Public Class MBILL_HBC
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5 As String
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim dr, dr1, dr2, dr4 As DataRow
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
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents chk_summary As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_subscriptionsummary As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DuplicateBill As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bill As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_MEMBERTYPE As System.Windows.Forms.CheckBox
    Friend WithEvents chklist_MEMBERTYPE As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_VATNOTE As System.Windows.Forms.TextBox
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents CHK_SERVICE As System.Windows.Forms.CheckBox
    Friend WithEvents chk_bulk As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MBILL_HBC))
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.txt_Tomcode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button
        Me.txt_Tomname = New System.Windows.Forms.TextBox
        Me.txt_note = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmd_print = New System.Windows.Forms.Button
        Me.chk_summary = New System.Windows.Forms.CheckBox
        Me.Chk_subscriptionsummary = New System.Windows.Forms.CheckBox
        Me.chk_DuplicateBill = New System.Windows.Forms.CheckBox
        Me.chk_bill = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Chk_MEMBERTYPE = New System.Windows.Forms.CheckBox
        Me.chklist_MEMBERTYPE = New System.Windows.Forms.CheckedListBox
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_VATNOTE = New System.Windows.Forms.TextBox
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.CHK_SERVICE = New System.Windows.Forms.CheckBox
        Me.chk_bulk = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MM/yyyy"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(408, 40)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 434
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(104, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(304, 16)
        Me.Label10.TabIndex = 435
        Me.Label10.Text = "MEMBER BILL FOR THE MONTH OF : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 35)
        Me.Label2.TabIndex = 436
        Me.Label2.Text = "MONTH BILL"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 437
        Me.Label3.Text = "Member Code"
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(168, 328)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(168, 22)
        Me.txt_mcode.TabIndex = 438
        Me.txt_mcode.Text = ""
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(72, 504)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 570
        Me.cmd_view.Text = "View [F8]"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(344, 328)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemberCodeHelp.TabIndex = 577
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 578
        Me.Label1.Text = "Member Name"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(168, 368)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(168, 22)
        Me.txt_mname.TabIndex = 579
        Me.txt_mname.Text = ""
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(392, 328)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(168, 22)
        Me.txt_Tomcode.TabIndex = 580
        Me.txt_Tomcode.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 581
        Me.Label4.Text = "From"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(391, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 582
        Me.Label5.Text = "To"
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp1.Image = CType(resources.GetObject("cmd_MemberCodeHelp1.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(568, 328)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemberCodeHelp1.TabIndex = 583
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(392, 368)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(168, 22)
        Me.txt_Tomname.TabIndex = 584
        Me.txt_Tomname.Text = ""
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(168, 400)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(432, 24)
        Me.txt_note.TabIndex = 585
        Me.txt_note.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 586
        Me.Label6.Text = "MISC1"
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.Location = New System.Drawing.Point(200, 504)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_print.TabIndex = 587
        Me.cmd_print.Text = "Print [F9]"
        '
        'chk_summary
        '
        Me.chk_summary.BackColor = System.Drawing.Color.Transparent
        Me.chk_summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_summary.Location = New System.Drawing.Point(16, 472)
        Me.chk_summary.Name = "chk_summary"
        Me.chk_summary.TabIndex = 588
        Me.chk_summary.Text = "Summary"
        '
        'Chk_subscriptionsummary
        '
        Me.Chk_subscriptionsummary.BackColor = System.Drawing.Color.Transparent
        Me.Chk_subscriptionsummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_subscriptionsummary.Location = New System.Drawing.Point(136, 472)
        Me.Chk_subscriptionsummary.Name = "Chk_subscriptionsummary"
        Me.Chk_subscriptionsummary.Size = New System.Drawing.Size(152, 24)
        Me.Chk_subscriptionsummary.TabIndex = 589
        Me.Chk_subscriptionsummary.Text = "Subscription Summary"
        '
        'chk_DuplicateBill
        '
        Me.chk_DuplicateBill.BackColor = System.Drawing.Color.Transparent
        Me.chk_DuplicateBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_DuplicateBill.Location = New System.Drawing.Point(560, 472)
        Me.chk_DuplicateBill.Name = "chk_DuplicateBill"
        Me.chk_DuplicateBill.Size = New System.Drawing.Size(96, 24)
        Me.chk_DuplicateBill.TabIndex = 590
        Me.chk_DuplicateBill.Text = "Duplicate Bill"
        '
        'chk_bill
        '
        Me.chk_bill.BackColor = System.Drawing.Color.Transparent
        Me.chk_bill.Checked = True
        Me.chk_bill.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_bill.Location = New System.Drawing.Point(448, 472)
        Me.chk_bill.Name = "chk_bill"
        Me.chk_bill.Size = New System.Drawing.Size(96, 24)
        Me.chk_bill.TabIndex = 591
        Me.chk_bill.Text = "Original Bill"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(160, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(424, 24)
        Me.Label7.TabIndex = 594
        Me.Label7.Text = "MEMBER TYPE :"
        '
        'Chk_MEMBERTYPE
        '
        Me.Chk_MEMBERTYPE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_MEMBERTYPE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_MEMBERTYPE.Location = New System.Drawing.Point(160, 64)
        Me.Chk_MEMBERTYPE.Name = "Chk_MEMBERTYPE"
        Me.Chk_MEMBERTYPE.Size = New System.Drawing.Size(132, 24)
        Me.Chk_MEMBERTYPE.TabIndex = 593
        Me.Chk_MEMBERTYPE.Text = "SELECT ALL"
        '
        'chklist_MEMBERTYPE
        '
        Me.chklist_MEMBERTYPE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_MEMBERTYPE.Location = New System.Drawing.Point(160, 112)
        Me.chklist_MEMBERTYPE.Name = "chklist_MEMBERTYPE"
        Me.chklist_MEMBERTYPE.Size = New System.Drawing.Size(424, 193)
        Me.chklist_MEMBERTYPE.TabIndex = 592
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(448, 504)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_exit.TabIndex = 595
        Me.cmd_exit.Text = "Exit [F11]"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 597
        Me.Label8.Text = "MISC2"
        '
        'TXT_VATNOTE
        '
        Me.TXT_VATNOTE.Location = New System.Drawing.Point(168, 432)
        Me.TXT_VATNOTE.Multiline = True
        Me.TXT_VATNOTE.Name = "TXT_VATNOTE"
        Me.TXT_VATNOTE.Size = New System.Drawing.Size(432, 24)
        Me.TXT_VATNOTE.TabIndex = 596
        Me.TXT_VATNOTE.Text = ""
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Location = New System.Drawing.Point(328, 504)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_clear.TabIndex = 598
        Me.cmd_clear.Text = "Clear [F6]"
        '
        'CHK_SERVICE
        '
        Me.CHK_SERVICE.Location = New System.Drawing.Point(896, 504)
        Me.CHK_SERVICE.Name = "CHK_SERVICE"
        Me.CHK_SERVICE.Size = New System.Drawing.Size(96, 24)
        Me.CHK_SERVICE.TabIndex = 599
        Me.CHK_SERVICE.Text = "Service Bill"
        Me.CHK_SERVICE.Visible = False
        '
        'chk_bulk
        '
        Me.chk_bulk.BackColor = System.Drawing.Color.Transparent
        Me.chk_bulk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_bulk.Location = New System.Drawing.Point(317, 472)
        Me.chk_bulk.Name = "chk_bulk"
        Me.chk_bulk.Size = New System.Drawing.Size(96, 24)
        Me.chk_bulk.TabIndex = 600
        Me.chk_bulk.Text = "Bulk"
        '
        'MBILL_HBC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 542)
        Me.Controls.Add(Me.chk_bulk)
        Me.Controls.Add(Me.CHK_SERVICE)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_VATNOTE)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.txt_Tomname)
        Me.Controls.Add(Me.txt_Tomcode)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_bill)
        Me.Controls.Add(Me.cmd_exit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chk_MEMBERTYPE)
        Me.Controls.Add(Me.chklist_MEMBERTYPE)
        Me.Controls.Add(Me.chk_DuplicateBill)
        Me.Controls.Add(Me.Chk_subscriptionsummary)
        Me.Controls.Add(Me.chk_summary)
        Me.Controls.Add(Me.cmd_print)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MBILL_HBC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBILL"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        gPrint = False
        If Chk_subscriptionsummary.Checked = True Then
            Call Reportdetails_summary_subscription()
            Exit Sub
        End If

        If chk_DuplicateBill.Checked = True Then
            Call Reportdetails_duplicate()
            Exit Sub
        End If

        If chk_summary.Checked = True Then
            Call Reportdetails_summary()
        ElseIf chk_bill.Checked = True Then
            Call Reportdetails_All()
        ElseIf CHK_SERVICE.Checked = True Then
            Call Reportdetails_Service()

        End If
    End Sub
    Public Function Reportdetails()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR, SQLSTR1, SQLSTR2, SQLSTR3, SQLSTR4, SQLSTR5, SQLSTR6, SQLSTR7, SQLSTR8, SQLSTR9 As String
        Dim PAGESIZE As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
            Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
            Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            sqlstring = "SELECT ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(B.MNAME,'') AS MNAME,ISNULL(B.PADD1,'') AS CONTADD1,ISNULL(B.PADD2,'') AS CONTADD2,ISNULL(B.PADD3,'') AS CONTADD3,ISNULL(B.PCITY,'') AS CONTCITY,ISNULL(B.PSTATE,'') AS CONTSTATE,ISNULL(B.PPIN,'') AS CONTPIN,ISNULL(B.PPHONE1,'') AS CONTPHONE1,ISNULL(B.PPHONE2,'') AS CONTPHONE2  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(A.BILLDATE) = " & month1 & "  GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(B.PADD1,'') ,ISNULL(B.PADD2,'') ,ISNULL(B.PADD3,'') ,ISNULL(B.PCITY,'') ,ISNULL(B.PSTATE,''),ISNULL(B.PPIN,''),ISNULL(B.PPHONE1,''),ISNULL(B.PPHONE2,''),ISNULL(B.MNAME,''),ISNULL(B.SUBCD,'') ORDER BY ISNULL(A.MCODE,'')"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    For I = 1 To 4
                        Filewrite.WriteLine()
                    Next I
                    '1
                    SQLSTR1 = "" 'Space(29)
                    '1,1
                    'ENTRANCE FEE

                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='2020' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,2
                    'MEMBER
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND  ISNULL(ACCOUNTCODE,'') IN ('7030','7040','7020','7031','7012','7060','7050','7032','7014','7010')  and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,3
                    'DEP MEMBER
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('7000') AND ISNULL(SLCODE,'') IN ('7011') and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If

                    '1,4
                    'CATERING MAIN
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8010' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(8)
                    End If
                    '1,5
                    'CATERING SAILING
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8023' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,6
                    'CATERING CHINESE
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8012' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,7
                    'BAR MAIN
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8020' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,8
                    'BAR SAILING
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8021' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,9
                    'CONTINENCY TAX
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2398') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If

                    '1,10
                    'CLUB SHOP
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8030' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(10)
                    End If


                    '1,11
                    'MONTH
                    SQLSTR1 = SQLSTR1 & Mid(Format(CDate(CbxMonth.Text), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4) & Space(7)


                    '1,12
                    'BILLNO
                    SQLSTR1 = SQLSTR1 & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8) & Space(17)


                    SQLSTR1 = SQLSTR1 & Mid(Format(CDate(CbxMonth.Text), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4) & Space(7)

                    '2,1
                    SQLSTR2 = ""
                    'OTHER GAMES
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='3598' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,2
                    'TENNIS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8041' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,3
                    'TABLE TENNIS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8042' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,4
                    'BADMINTON
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8043' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(8)
                    End If

                    '2,5
                    'SQUASH
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8044' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,6
                    'BILLIARDS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8045' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,7
                    'SWIMMING
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8046' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,8
                    'SAILING
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8047' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,9
                    'CARD ROOM
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8048' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,10
                    'HEALTH CLUB
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8049' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR2 = SQLSTR2 & Space(10)
                    End If

                    '2,9
                    'BILLNO
                    '                    SQLSTR2 = SQLSTR2 & Space(42) & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8)

                    SQLSTR2 = SQLSTR2 & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30)))) & Space(14) & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30))))


                    '3,1
                    SQLSTR3 = ""
                    'LOCKER
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8050' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,2
                    'LIBRARY
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8051' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,3
                    'SALOON
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8052','8061','8062') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If

                    '3,4
                    'TELE/STD
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8053' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(8)
                    End If


                    '3,5
                    'P&T/FAX
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8056','8113') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,6
                    'TRANSIT QUARTERS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8035' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,7
                    'SPL. DINNER
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8013','8014') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,8
                    'BANK CHARGES
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('3910') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,9
                    'BENE FUND
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2346','2347') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    '3,10
                    'NEW YEAR GIFT
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2348') AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR3 = SQLSTR3 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR3 = SQLSTR3 & Space(10)
                    End If

                    SQLSTR3 = SQLSTR3 & Trim(Mid(dr("CONTCITY"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTCITY"), 1, 30))))


                    '4
                    SQLSTR4 = ""

                    '4,1
                    'OTHER EVENTS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE='8068' AND ISNULL(SLCODE,'')='' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,2
                    'GUEST CHARGES
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('8071','8072','8073','8074','8075') and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,3
                    'MISCELLNEOUS
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('2320','2321','2365','2366','2367','2368','2369','2361') and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 7) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(8)
                    End If

                    '4,4
                    'BILL FOR THE MONTH
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,5
                    'DEBIT BF
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,6
                    'CREDIT BF
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,7
                    'PENALTY
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' AND ACCOUNTCODE IN ('1681') and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,8
                    'AMOUNT TO YOUR CREDIT
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        '                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(3)
                        SQLSTR4 = SQLSTR4 & Space(10)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If

                    '4,9
                    'AMOUNT TO YOUR DEBIT
                    sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & dr("MCODE") & "' and MONTH(BILLDATE) = " & month1
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(9 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9))) & Mid(Format(Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")), "0.00"), 1, 9) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(10)
                    End If



                    '4,10
                    'DINNING
                    sqlstring = "SELECT KOTDETAILS FROM KOT_DET WHERE ISNULL(DELFLAG,'')<>'Y' AND ISNULL(KOTSTATUS,'')<>'Y' AND CATEGORY='CANTEEN' AND MCODE='" & dr("MCODE") & "' and MONTH(KOTDATE) = " & month1 & " GROUP BY KOTDETAILS"
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows.Count) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(3 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0.00"), 1, 3))) & Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0"), 1, 3) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(4)
                    End If

                    '4,11
                    'BAR
                    sqlstring = "SELECT KOTDETAILS FROM KOT_DET WHERE ISNULL(DELFLAG,'')<>'Y' AND ISNULL(KOTSTATUS,'')<>'Y' AND CATEGORY='CANTEEN' AND MCODE='" & dr("MCODE") & "' and MONTH(KOTDATE) = " & month1 & " GROUP BY KOTDETAILS"
                    gconnection.getDataSet(sqlstring, "BILL")
                    If Val(gdataset.Tables("BILL").Rows.Count) > 0 Then
                        SQLSTR4 = SQLSTR4 & Space(3 - Len(Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0.00"), 1, 3))) & Mid(Format(Val(gdataset.Tables("BILL").Rows.Count), "0"), 1, 3) & Space(1)
                    Else
                        SQLSTR4 = SQLSTR4 & Space(4)
                    End If


                    SQLSTR4 = SQLSTR4 & "Due date for the bill " & Format(DateAdd(DateInterval.Day, 35, dr("BILLDATE")), "dd MMM yyyy")
                    '                    Filewrite.WriteLine(SQLSTR)

                    'PRINTING
                    '5
                    Filewrite.WriteLine(SQLSTR1)
                    '6
                    Filewrite.WriteLine()

                    SQLSTR = Space(92) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10)))) & Space(10) & Trim(Mid(dr("MEMBERTYPE"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MEMBERTYPE"), 1, 30)))) & Space(15) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    Filewrite.WriteLine(SQLSTR)
                    '7

                    Filewrite.WriteLine(SQLSTR2)
                    '8
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 1, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 31, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 31, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    SQLSTR = Space(92) & Trim(Mid(dr("CONTADD1"), 61, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 61, 30))))
                    Filewrite.WriteLine(SQLSTR)
                    '9
                    Filewrite.WriteLine(SQLSTR3)
                    '10

                    SQLSTR = Space(92) & Trim(Mid(dr("CONTPIN"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPIN"), 1, 30))))
                    Filewrite.WriteLine(SQLSTR)

                    SQLSTR = Space(92) & "Payments Accounted Upto " & Format(DateAdd(DateInterval.Day, 6, dr("BILLDATE")), "dd MMM yyyy")
                    Filewrite.WriteLine(SQLSTR)

                    Filewrite.WriteLine(SQLSTR4)
                    '12

                    SQLSTR = Space(92) & Trim(Mid(dr("CONTPHONE1"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 15)))) & Space(10) & Trim(Mid(dr("CONTPHONE2"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE2"), 1, 15))))
                    Filewrite.WriteLine(SQLSTR)

                    '18
                    '                    SQLSTR = Space(96) & Format(dr("BILLDATE"), "dd/MM/yyyy")
                    '                   Filewrite.WriteLine(SQLSTR)

                    For I = 1 To 3
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            'Filewrite.Write(Chr(12))
            For I = 1 To 7
                Filewrite.WriteLine()
            Next I

            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function Reportdetails_PROPOSED()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            sqlstring = "SELECT MCODE FROM MEMBER_MONTH_BILL WHERE MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & "  GROUP BY MCODE ORDER BY MCODE "
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    For I = 1 To 8
                        Filewrite.WriteLine()
                    Next I
                    sqlstring = "SELECT isnull(rowno,0) as rowno FROM MEMBER_MONTH_BILL_SETUP GROUP BY ROWNO"
                    gconnection.getDataSet(sqlstring, "BILLROW")
                    If gdataset.Tables("BILLROW").Rows.Count > 0 Then
                        For Each dr4 In gdataset.Tables("BILLROW").Rows
                            SQLSTR = Space(15)
                            Filewrite.WriteLine()
                            sqlstring = "SELECT isnull(rowno,0) as rowno,isnull(colno,0) as colno,isnull(accountcode,'') as accountcode,isnull(slcode,'') as slcode,isnull(flag,'') as flag FROM MEMBER_MONTH_BILL_SETUP WHERE ROWNO=" & dr4("ROWNO") & " ORDER BY COLNO"
                            gconnection.getDataSet(sqlstring, "BILLSETUP")
                            If gdataset.Tables("BILLSETUP").Rows.Count > 0 Then
                                For Each dr1 In gdataset.Tables("BILLSETUP").Rows
                                    If Trim(dr1("FLAG")) = "N" Then
                                        SQLSTR = SQLSTR & Space(18)
                                    Else
                                        sqlstring = "SELECT ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT FROM MEMBER_MONTH_BILL WHERE MCODE='" & Trim(dr("MCODE")) & "' AND MONTH(BILLDATE) = " & month1 & " AND ACCOUNTCODE+ISNULL(SLCODE,'') IN (SELECT ACCOUNTCODE+ISNULL(SLCODE,'') FROM MEMBER_MONTH_BILL_SETUP WHERE ROWNO=" & Trim(dr1("ROWNO")) & " AND COLNO=" & Trim(dr1("COLNO")) & ")"
                                        gconnection.getDataSet(sqlstring, "BILL")
                                        If Val(gdataset.Tables("BILL").Rows(0).Item("AMOUNT")) > 0 Then
                                            For Each dr2 In gdataset.Tables("BILL").Rows
                                                SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(dr2("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr2("AMOUNT"), "0.00"), 1, 8) & Space(10)
                                            Next
                                        Else
                                            SQLSTR = SQLSTR & Space(18)
                                        End If
                                    End If
                                Next
                            End If
                            Filewrite.WriteLine(SQLSTR)
                        Next
                    End If
                    For I = 1 To 2
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function Reportdetails_summary_subscription()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT, TTAXAMOUNT, TNOOFPERSON, TOTALAMOUNT, TOTALTAXAMOUNT, NETAMOUNT, NETTAXAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31
            month1 = Month(CbxMonth.Value)

            sqlstring = "SELECT MEMBERTYPE,TYPEDESC,SUBSCODE,SUBSDESC,AMOUNT,TAXAMOUNT,BILLDATE,NOOFPERSON FROM JHIC_SUBSCRIPTION_SUMMARY where  MONTH(BILLDATE) = " & month1 & " ORDER BY MEMBERTYPE"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                Call PrintHeader_SUBSCRIPTION(CbxMonth.Text)
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    If PAGESIZE > 58 Then
                        Filewrite.Write(StrDup(105, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader_SUBSCRIPTION(CbxMonth.Text)
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                    End If
                    SQLSTR = Trim(Mid(CStr(dr2("MEMBERTYPE")), 1, 3)) & Space(3 - Len(Trim(Mid(CStr(dr2("MEMBERTYPE")), 1, 3)))) & Space(1)
                    SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("TYPEDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("TYPEDESC")), 1, 25)))) & Space(1)
                    ' SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SUBSCODE")), 1, 3)) & Space(3 - Len(Trim(Mid(CStr(dr2("SUBSCODE")), 1, 3)))) & Space(1)
                    'SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("SUBSDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr2("SUBSDESC")), 1, 25)))) & Space(1)
                    SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("TAXAMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("TAXAMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(11 - Len(Mid(Format(CDate(dr2("BILLDATE")), "dd/MM/yyyy"), 1, 11))) & Mid(Format(CDate(dr2("BILLDATE")), "dd/MM/yyyy"), 1, 11) & Space(1)
                    SQLSTR = SQLSTR & Space(4 - Len(Mid(Format(Val(dr2("NOOFPERSON")), "0"), 1, 4))) & Mid(Format(Val(dr2("NOOFPERSON")), "0"), 1, 4) & Space(1)
                    TOTALAMOUNT = 0
                    TOTALTAXAMOUNT = 0

                    TOTALAMOUNT = Val(dr2("AMOUNT")) * Val(dr2("NOOFPERSON"))
                    TOTALTAXAMOUNT = Val(dr2("TAXAMOUNT")) * Val(dr2("NOOFPERSON"))
                    ' SQLSTR = SQLSTR & Space(8 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 8) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALAMOUNT), "0.00"), 1, 12) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALTAXAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALTAXAMOUNT), "0.00"), 1, 12) & Space(1)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TOTALTAXAMOUNT) + Val(TOTALAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TOTALTAXAMOUNT) + Val(TOTALAMOUNT), "0.00"), 1, 12)

                    Filewrite.WriteLine(SQLSTR)
                    PAGESIZE = PAGESIZE + 1
                    NETAMOUNT = NETAMOUNT + TOTALAMOUNT
                    NETTAXAMOUNT = NETTAXAMOUNT + TOTALTAXAMOUNT
                    TAMOUNT = TAMOUNT + TOTALTAXAMOUNT + TOTALAMOUNT
                    TNOOFPERSON = TNOOFPERSON + Val(dr2("NOOFPERSON"))

                Next dr2
                SQLSTR = Space(58) & Space(6 - Len(Mid(Format(Val(TNOOFPERSON), "0"), 1, 6))) & Mid(Format(Val(TNOOFPERSON), "0"), 1, 6) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(NETAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(NETAMOUNT), "0.00"), 1, 12) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(NETTAXAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(NETTAXAMOUNT), "0.00"), 1, 12) & Space(1)
                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12) & Space(1)
                Filewrite.WriteLine(StrDup(105, "="))
                Filewrite.WriteLine(SQLSTR)
                Filewrite.WriteLine(StrDup(105, "="))
                PAGESIZE = PAGESIZE + 3
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function


    Public Function Reportdetails_summary()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            '            Filewrite.Write(Chr(15))


            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31

            month1 = Month(CbxMonth.Value)

            sqlstring = "select accountcode,isnull(accountcodedesc,'') as accountcodedesc,ISNULL(sum(ISNULL(amount,0)),0) as amount from VIEW_JHIC_MONTHBILL_SUMMARY where  MONTHNO = " & month1 & "  and accountcode not in ('31207','g-rooms','c-sales')  group by accountcode,isnull(accountcodedesc,'') order by accountcode"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                Call PrintHeader(CbxMonth.Text)
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    If PAGESIZE > 58 Then
                        Filewrite.Write(StrDup(72, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(CbxMonth.Text)
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                    End If
                    SQLSTR = Trim(Mid(CStr(dr2("ACCOUNTCODE")), 1, 15)) & Space(15 - Len(Trim(Mid(CStr(dr2("ACCOUNTCODE")), 1, 15)))) & Space(2)
                    SQLSTR = SQLSTR & Trim(Mid(CStr(dr2("ACCOUNTCODEDESC")), 1, 40)) & Space(40 - Len(Trim(Mid(CStr(dr2("ACCOUNTCODEDESC")), 1, 40)))) & Space(2)
                    SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 12)
                    Filewrite.WriteLine(SQLSTR)
                    PAGESIZE = PAGESIZE + 1
                    TAMOUNT = TAMOUNT + Val(dr2("AMOUNT"))
                Next dr2
                SQLSTR = Space(60) & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12)
                Filewrite.WriteLine(StrDup(72, "="))
                Filewrite.WriteLine(SQLSTR)
                Filewrite.WriteLine(StrDup(72, "="))
                PAGESIZE = PAGESIZE + 3
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal Heading As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("{0,10}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-50}{1,10}", "MONTH BILL SUMMARY FOR " & Heading, " PAGE : " & pageno + 1)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(72, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ACCOUNT CODE     ACCOUNT DESCRIPTION                             AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(72, "="))
            'Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
            'Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
            'Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeader_SUBSCRIPTION(ByVal Heading As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("{0,10}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-50}{1,10}", "MONTH BILL SUBSCRIPTION SUMMARY FOR " & Heading, " PAGE : " & pageno + 1)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(105, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("TYPE  TYPEDESC                  AMOUNT TAXAMOUNT BILLDATE    NOS     TAMOUNT       TTAX        TOTAL")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(105, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    txt_Tomcode.Focus()
                    'cmd_view.Focus()
                Else
                    txt_mcode.Text = ""
                    'txt_mcode.Focus()
                End If
            Else
                txt_mcode.Text = ""
                'txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MBILL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillMEMBERTYPE()
        txt_mcode.Focus()

        sqlstring = "SELECT ISNULL(MBILLDATE,'') AS BILLDATE FROM POS_FUND_MASTER"
        gconnection.getDataSet(sqlstring, "membertype")
        If gdataset.Tables("membertype").Rows.Count - 1 >= 0 Then
            CbxMonth.Text = gdataset.Tables("membertype").Rows.Item(0).Item("BILLDATE")
        End If
        Show()
    End Sub
    Private Sub FillMEMBERTYPE()
        Dim i As Integer
        sqlstring = "SELECT ISNULL(MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(TYPEDESC,'') AS TYPEDESC FROM MEMBERTYPE ORDER BY MEMBERTYPE "
        gconnection.getDataSet(sqlstring, "membertype")
        chklist_MEMBERTYPE.Items.Clear()
        If gdataset.Tables("membertype").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("membertype").Rows.Count - 1
                With gdataset.Tables("membertype").Rows(i)
                    chklist_MEMBERTYPE.Items.Add(Trim(.Item("MEMBERTYPE")) & "-->" & Trim(.Item("TYPEDESC")))
                End With
            Next i
        End If
        chklist_MEMBERTYPE.Sorted = True
    End Sub

    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_Tomcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Tomcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp1_Click(sender, e)
            Else
                txt_Tomcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp1.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Tomcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_Tomcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tomcode.Validated
        Try
            If Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_Tomcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_Tomcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_Tomname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    cmd_view.Focus()
                Else
                    txt_Tomcode.Text = ""
                    txt_Tomcode.Focus()
                End If
            Else
                txt_Tomcode.Text = ""
                txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Validation()
        '        boolchk = False
        If txt_mcode.Text = "" Then
            MessageBox.Show(" From MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_mcode.Focus()
            Exit Sub
        End If
        If txt_Tomcode.Text = "" Then
            MessageBox.Show(" To MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Tomcode.Focus()
            Exit Sub
        End If
        '       boolchk = True
    End Sub

    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        gPrint = True
        If Chk_subscriptionsummary.Checked = True Then
            Call Reportdetails_summary_subscription()
            Exit Sub
        End If

        If chk_DuplicateBill.Checked = True Then
            Call Reportdetails_duplicate()
            Exit Sub
        End If

        If chk_summary.Checked = True Then
            Call Reportdetails_summary()
        ElseIf chk_bill.Checked = True Then
            Call Reportdetails_All()
        ElseIf CHK_SERVICE.Checked = True Then
            Call Reportdetails_Service()

        End If
    End Sub
    Public Function Reportdetails_duplicate()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT As Double
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            sqlstring = "SELECT ISNULL(B.MSORDERNO,0), ISNULL(B.SUBCD,''),C.TYPEDESC AS MEMBERTYPE,A.BILLNUMBER AS BILLNO,A.BILLDATE,A.MCODE,ISNULL(A.MNAME,'') AS MNAME,ISNULL(A.CONTADD1,'') AS CONTADD1,ISNULL(A.CONTADD2,'') AS CONTADD2,ISNULL(A.CONTADD3,'') AS CONTADD3,ISNULL(A.CONTCITY,'') AS CONTCITY,ISNULL(A.CONTSTATE,'') AS CONTSTATE,ISNULL(A.CONTPHONE1,'') AS CONTPHONE1,ISNULL(A.CONTPHONE2,'') AS CONTPHONE2,ISNULL(A.CONTPIN,'') AS CONTPIN  FROM MEMBER_MONTH_BILL A, MEMBERMASTER B,MEMBERTYPE C WHERE B.MEMBERTYPECODE=C.MEMBERTYPE AND A.MCODE=B.MCODE AND A.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(A.BILLDATE) = " & Month(CbxMonth.Value) & "  AND ISNULL(A.SUBSCRIPTIONTYPE,'')='' GROUP BY C.TYPEDESC,A.MCODE,A.BILLNUMBER,A.BILLDATE,ISNULL(A.CONTADD1,'') ,ISNULL(A.CONTADD2,'') ,ISNULL(A.CONTADD3,'') ,ISNULL(A.CONTCITY,'') ,ISNULL(A.CONTSTATE,''),ISNULL(A.CONTPHONE1,''),ISNULL(A.CONTPHONE2,''),ISNULL(A.CONTPIN,''),ISNULL(A.MNAME,''),ISNULL(B.SUBCD,''),ISNULL(B.MSORDERNO,0) ORDER BY ISNULL(B.MSORDERNO,0),ISNULL(B.SUBCD,'')"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr2 In gdataset.Tables("MEMBER").Rows
                    TAMOUNT = 0
                    Call PrintHeader_Duplicate(CbxMonth.Text, dr2("MCODE"), dr2("MNAME"), dr2("CONTADD1"), dr2("CONTADD2"), dr2("CONTADD3"), dr2("CONTCITY"), dr2("BILLNO"))
                    sqlstring = "select isnull(billsno,0) as billsno,isnull(accountcode,'') as accountcode,isnull(accountcodedesc,'') as accountcodedesc,isnull(sum(isnull(amount,0)),0) as amount from VIEW_JHIC_MONTHBILL_DUPLICATE where  MCODE='" & dr2("MCODE") & "' AND MONTHNO = " & Month(CbxMonth.Value) & "  AND ISNULL(SUBSCRIPTIONTYPE,'')='' group by accountcode,isnull(accountcodedesc,''),isnull(billsno,0) order by BILLSNO,accountcode"
                    gconnection.getDataSet(sqlstring, "BILL")
                    If gdataset.Tables("BILL").Rows.Count > 0 Then
                        For Each dr1 In gdataset.Tables("BILL").Rows
                            If PAGESIZE > 58 Then
                                'Filewrite.Write(StrDup(72, "-"))
                                'Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                'Call PrintHeader_Duplicate(CbxMonth.Text, dr2("MCODE"), dr2("MNAME"), dr2("CONTADD1"), dr2("CONTADD2"), dr2("CONTADD3"), dr2("CONTCITY"), dr2("BILLNO"))
                                ' Filewrite.WriteLine()
                                PAGESIZE = PAGESIZE + 1
                            End If
                            SQLSTR = Space(2 - Len(Mid(Format(Val(dr1("BILLSNO")), "0"), 1, 2))) & Mid(Format(Val(dr1("BILLSNO")), "0"), 1, 2) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(CStr(dr1("ACCOUNTCODE")), 1, 10)) & Space(10 - Len(Trim(Mid(CStr(dr1("ACCOUNTCODE")), 1, 10)))) & Space(1)
                            SQLSTR = SQLSTR & Trim(Mid(CStr(dr1("ACCOUNTCODEDESC")), 1, 25)) & Space(25 - Len(Trim(Mid(CStr(dr1("ACCOUNTCODEDESC")), 1, 25)))) & Space(1)
                            SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12)
                            Filewrite.WriteLine(SQLSTR)
                            PAGESIZE = PAGESIZE + 1
                            TAMOUNT = TAMOUNT + Val(dr1("AMOUNT"))
                        Next
                        Filewrite.WriteLine(StrDup(79, "-"))
                        SQLSTR = Space(14) & "TOTAL FOR THE MONTH.." & Space(5) & Space(12 - Len(Mid(Format(Val(TAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(TAMOUNT), "0.00"), 1, 12)
                        Filewrite.WriteLine(SQLSTR)
                        Filewrite.WriteLine(StrDup(79, "-"))
                        PAGESIZE = PAGESIZE + 3

                        sqlstring = "select isnull(billsno,0) as billsno,isnull(accountcode,'') as accountcode,isnull(accountcodedesc,'') as accountcodedesc,ISNULL(SUBSCRIPTIONTYPE,'') AS SUBSCRIPTIONTYPE,isnull(sum(isnull(amount,0)),0) as amount from VIEW_JHIC_MONTHBILL_DUPLICATE where  MCODE='" & dr2("MCODE") & "' AND MONTHNO = " & Month(CbxMonth.Value) & "  AND ISNULL(SUBSCRIPTIONTYPE,'')<>'' and isnull(subscriptiontype,'') in (SELECT subscriptiontype FROM SC_MONTH_BILL_SETUP where isnull(subscriptiontype,'')<>'') group by accountcode,isnull(accountcodedesc,''),isnull(billsno,0),SUBSCRIPTIONTYPE order by BILLSNO,accountcode,SUBSCRIPTIONTYPE"
                        gconnection.getDataSet(sqlstring, "BILL")
                        If gdataset.Tables("BILL").Rows.Count > 0 Then
                            For Each dr1 In gdataset.Tables("BILL").Rows
                                If PAGESIZE > 58 Then
                                    'Filewrite.Write(StrDup(72, "-"))
                                    'Filewrite.Write(Chr(12))
                                    'pageno = pageno + 1
                                    'Call PrintHeader_Duplicate(CbxMonth.Text, dr2("MCODE"), dr2("MNAME"), dr2("CONTADD1"), dr2("CONTADD2"), dr2("CONTADD3"), dr2("CONTCITY"), dr2("BILLNO"))
                                    'Filewrite.WriteLine()
                                    PAGESIZE = PAGESIZE + 1
                                End If

                                SQLSTR = Space(4) & Trim(Mid(CStr(dr1("SUBSCRIPTIONTYPE")), 1, 35)) & Space(35 - Len(Trim(Mid(CStr(dr1("SUBSCRIPTIONTYPE")), 1, 35)))) & Space(1)
                                SQLSTR = SQLSTR & Space(12 - Len(Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12))) & Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 12)
                                Filewrite.WriteLine(SQLSTR)
                                PAGESIZE = PAGESIZE + 1
                            Next
                        End If
                        Filewrite.WriteLine(StrDup(79, "-"))
                        PAGESIZE = PAGESIZE + 1
                    End If
                    Filewrite.WriteLine(" Your Attention is drawn to the provisions of Bye-Law no 12(a) ")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine(" regarding credit stoppage and deposits for not clearing  the dues on due dates.")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine(Space(32) & " *Please ignore this if payment is already made")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("PRINTED ON : " & Format(Now, "dd/MM/yyyy") & " Prepared By :" & Trim(gUsername))
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine(Space(40) & " Sd/-")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine(Space(40) & " SECRETARY")
                    PAGESIZE = PAGESIZE + 1
                    PAGESIZE = 60
                    Filewrite.Write(Chr(12))
                Next dr2
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Function PrintHeader_Duplicate(ByVal Heading As String, ByVal MCODE As String, ByVal MNAME As String, ByVal ADD1 As String, ByVal ADD2 As String, ByVal ADD3 As String, ByVal ADD4 As String, ByVal BILLNO As String)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("                  JUBLIEE HILLS INTERNATIOANL CENTRE")
                Filewrite.WriteLine("            ROAD NO.14, JUBILEE HILLS, HYDERABAD - 500 033")
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Chr(18))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("M.S.No:" & Mid(Trim(MCODE), 1, 10) & Space(10 - Len(Mid(Trim(MCODE), 1, 10))) & Space(30) & " For the Month of " & Heading, " PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("M.S.Name:" & Mid(Trim(MNAME), 1, 40) & Space(40 - Len(Mid(Trim(MNAME), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("Address :" & Mid(Trim(ADD1), 1, 40) & Space(40 - Len(Mid(Trim(ADD1), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD2), 1, 40) & Space(40 - Len(Mid(Trim(ADD2), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD3), 1, 40) & Space(40 - Len(Mid(Trim(ADD3), 1, 40))))
            pagesize = pagesize + 1
            Filewrite.WriteLine("        :" & Mid(Trim(ADD4), 1, 40) & Space(40 - Len(Mid(Trim(ADD4), 1, 40))) & Space(2) & "BILL NO...: " & Trim(BILLNO))
            pagesize = pagesize + 1

            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("Bill Account   Particulares                  Amount")
            Filewrite.WriteLine("SNo. Code                                     (Rs.)")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            pageno = pageno + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Sub Chk_MEMBERTYPE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_MEMBERTYPE.CheckedChanged
        Dim i As Integer
        If Chk_MEMBERTYPE.Checked = True Then
            For i = 0 To chklist_MEMBERTYPE.Items.Count - 1
                chklist_MEMBERTYPE.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_MEMBERTYPE.Items.Count - 1
                chklist_MEMBERTYPE.SetItemChecked(i, False)
            Next
        End If
    End Sub
    ''''Public Function Reportdetails_All()
    ''''    Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
    ''''    Dim Membername As String
    ''''    Dim Memberbool, POSbool As Boolean
    ''''    Dim USERNAME, BILLNO, BILLDETAILS As String
    ''''    Dim I As Integer
    ''''    Dim POSdesc() As String
    ''''    Dim STRSTRING, SQLSTR, SQLSTR1, SQLSTR2, SQLSTR3, SQLSTR4, SQLSTR5, SQLSTR6, SQLSTR7, SQLSTR8, SQLSTR9 As String
    ''''    Dim PAGESIZE As Integer
    ''''    Dim PYMTUPTO, DUEDATE As Date

    ''''    Try
    ''''        Randomize()
    ''''        AppPath = Application.StartupPath
    ''''        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
    ''''        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
    ''''        Filewrite = File.AppendText(VFilePath)
    ''''        printfile = VFilePath

    ''''        Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
    ''''        Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
    ''''        Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

    ''''        sqlstring = " SELECT PYMTUPTO,DUEDATE FROM POS_FUND_MASTER "
    ''''        gconnection.getDataSet(sqlstring, "MEMBER")
    ''''        If gdataset.Tables("MEMBER").Rows.Count > 0 Then
    ''''            For Each dr In gdataset.Tables("MEMBER").Rows
    ''''                PYMTUPTO = dr("PYMTUPTO")
    ''''                DUEDATE = dr("DUEDATE")
    ''''            Next
    ''''        End If
    ''''        If chk_bulk.Checked = True Then
    ''''            sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT a, POS_PENDING b WHERE a.mcode=b.mcode and "
    ''''            sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
    ''''            If txt_mcode.Text <> "" Then
    ''''                sqlstring = sqlstring & " AND a.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
    ''''            End If
    ''''            If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
    ''''                sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
    ''''                For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
    ''''                    POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
    ''''                    sqlstring = sqlstring & " '" & POSdesc(0) & "', "
    ''''                Next
    ''''                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''''                sqlstring = sqlstring & ")"
    ''''            End If
    ''''            '                sqlstring = sqlstring & " ORDER BY b.autoid,MEMBERTYPE,MESS_CD,a.MCODE"
    ''''            sqlstring = sqlstring & " ORDER BY b.autoid,a.MCODE"
    ''''        Else
    ''''            sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT WHERE "
    ''''            sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
    ''''            If txt_mcode.Text <> "" Then
    ''''                sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
    ''''            End If
    ''''            If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
    ''''                sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
    ''''                For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
    ''''                    POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
    ''''                    sqlstring = sqlstring & " '" & POSdesc(0) & "', "
    ''''                Next
    ''''                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''''                sqlstring = sqlstring & ")"
    ''''            End If
    ''''            '                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MESS_CD,MCODE"
    ''''            sqlstring = sqlstring & " ORDER BY MCODE"
    ''''        End If
    ''''        gconnection.getDataSet(sqlstring, "MEMBER")

    ''''        If gdataset.Tables("MEMBER").Rows.Count > 0 Then
    ''''            For Each dr In gdataset.Tables("MEMBER").Rows
    ''''                For I = 1 To 3
    ''''                    Filewrite.WriteLine()
    ''''                Next I
    ''''                '1

    ''''                SQLSTR1 = Space(29)
    ''''                '1,3
    ''''                'GROOM
    ''''                'SQLSTR1 = ""
    ''''                If Val(dr("GROOM")) <> 0 Then
    ''''                    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("GROOM")), "0"), 1, 7))) & Mid(Format(Val(dr("GROOM")), "0"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR1 = SQLSTR1 & Space(14)
    ''''                End If

    ''''                '1,4
    ''''                'TT

    ''''                If Val(dr("TT")) <> 0 Then
    ''''                    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("TT")), "0"), 1, 7))) & Mid(Format(Val(dr("TT")), "0"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR1 = SQLSTR1 & Space(15)
    ''''                End If


    ''''                '1,5
    ''''                'GUEST

    ''''                If Val(dr("GUEST")) <> 0 Then
    ''''                    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("GUEST")), "0.00"), 1, 7))) & Mid(Format(Val(dr("GUEST")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR1 = SQLSTR1 & Space(14)
    ''''                End If


    ''''                '1,6
    ''''                'LIB

    ''''                If Val(dr("LIB")) <> 0 Then
    ''''                    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("LIB")), "0.00"), 1, 7))) & Mid(Format(Val(dr("LIB")), "0.00"), 1, 7) & Space(11)
    ''''                Else
    ''''                    SQLSTR1 = SQLSTR1 & Space(18)
    ''''                End If

    ''''                '1,7
    ''''                'CATR
    ''''                If Val(dr("CATR")) <> 0 Then
    ''''                    SQLSTR1 = SQLSTR1 & Space(9 - Len(Mid(Format(Val(dr("CATR")), "0.00"), 1, 9))) & Mid(Format(Val(dr("CATR")), "0.00"), 1, 9) & Space(9)
    ''''                Else
    ''''                    SQLSTR1 = SQLSTR1 & Space(18)
    ''''                End If


    ''''                '1,8
    ''''                SQLSTR1 = SQLSTR1 & Mid(Format(dr("BILLDATE"), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4) & Space(7)

    ''''                '1,9
    ''''                SQLSTR1 = SQLSTR1 & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8) & Space(4)

    ''''                SQLSTR2 = ""

    ''''                '2,1
    ''''                'MEM SUBS
    ''''                If Val(dr("MEMSUBS")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(dr("MEMSUBS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("MEMSUBS")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(14)
    ''''                End If

    ''''                '2,2
    ''''                'BILLDS

    ''''                If Val(dr("BILLDS")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(dr("BILLDS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BILLDS")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(15)
    ''''                End If

    ''''                '2,3
    ''''                'CARDS
    ''''                If Val(dr("CARDS")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(dr("CARDS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CARDS")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(14)
    ''''                End If

    ''''                '2,4
    ''''                'SQUASH

    ''''                If Val(dr("SQUASH")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(dr("SQUASH")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SQUASH")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(15)
    ''''                End If


    ''''                '2,5
    ''''                'TEL
    ''''                If Val(dr("TEL")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(7 - Len(Mid(Format(Val(dr("TEL")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TEL")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(15)
    ''''                End If


    ''''                '2,6
    ''''                'INET

    ''''                If Val(dr("INET")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(9 - Len(Mid(Format(Val(dr("INET")), "0.00"), 1, 9))) & Mid(Format(Val(dr("INET")), "0.00"), 1, 9) & Space(9)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(18)
    ''''                End If

    ''''                '2,7
    ''''                'BAR
    ''''                If Val(dr("BAR")) <> 0 Then
    ''''                    SQLSTR2 = SQLSTR2 & Space(8 - Len(Mid(Format(Val(dr("BAR")), "0.00"), 1, 8))) & Mid(Format(Val(dr("BAR")), "0.00"), 1, 8) & Space(4)
    ''''                Else
    ''''                    SQLSTR2 = SQLSTR2 & Space(12)
    ''''                End If


    ''''                '2,9
    ''''                'BILLNO
    ''''                SQLSTR2 = SQLSTR2 & Space(42) & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8)


    ''''                SQLSTR3 = ""

    ''''                '3,1
    ''''                'DMSF
    ''''                If Val(dr("DMSF")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(dr("DMSF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("DMSF")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(14)
    ''''                End If


    ''''                '3,2
    ''''                'BCF
    ''''                If Val(dr("BCF")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(dr("BCF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BCF")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(15)
    ''''                End If


    ''''                '3,3
    ''''                'BASKBL
    ''''                If Val(dr("BASKBL")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(dr("BASKBL")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BASKBL")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(14)
    ''''                End If


    ''''                '3,4
    ''''                'HEALTH
    ''''                If Val(dr("HEALTH")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(dr("HEALTH")), "0.00"), 1, 7))) & Mid(Format(Val(dr("HEALTH")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(14)
    ''''                End If


    ''''                '3,5
    ''''                'POST

    ''''                If Val(dr("POST")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(7 - Len(Mid(Format(Val(dr("POST")), "0.00"), 1, 7))) & Mid(Format(Val(dr("POST")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(15)
    ''''                End If

    ''''                '3,6
    ''''                'CREC

    ''''                If Val(dr("CREC")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(10 - Len(Mid(Format(Val(dr("CREC")), "0.00"), 1, 10))) & Mid(Format(Val(dr("CREC")), "0.00"), 1, 10) & Space(7)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(17)
    ''''                End If


    ''''                '3,7
    ''''                'OTHS1
    ''''                If Val(dr("OTHS1")) <> 0 Then
    ''''                    SQLSTR3 = SQLSTR3 & Space(8 - Len(Mid(Format(Val(dr("OTHS1")), "0.00"), 1, 8))) & Mid(Format(Val(dr("OTHS1")), "0.00"), 1, 8) & Space(4)
    ''''                Else
    ''''                    SQLSTR3 = SQLSTR3 & Space(12)
    ''''                End If


    ''''                '4
    ''''                SQLSTR4 = Space(29)


    ''''                '4,3
    ''''                'SLF
    ''''                If Val(dr("SLF")) <> 0 Then
    ''''                    SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(dr("SLF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SLF")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR4 = SQLSTR4 & Space(14)
    ''''                End If


    ''''                '4,4
    ''''                'SPOOL
    ''''                If Val(dr("SPOOL")) <> 0 Then
    ''''                    SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(dr("SPOOL")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SPOOL")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR4 = SQLSTR4 & Space(15)
    ''''                End If

    ''''                '4,5
    ''''                'CC
    ''''                If Val(dr("CC")) <> 0 Then
    ''''                    SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(dr("CC")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CC")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR4 = SQLSTR4 & Space(15)
    ''''                End If


    ''''                '4,6
    ''''                'GOLF

    ''''                If Val(dr("GOLF")) <> 0 Then
    ''''                    SQLSTR4 = SQLSTR4 & Space(7 - Len(Mid(Format(Val(dr("GOLF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("GOLF")), "0.00"), 1, 7) & Space(10)
    ''''                Else
    ''''                    SQLSTR4 = SQLSTR4 & Space(17)
    ''''                End If

    ''''                '4,7
    ''''                SQLSTR4 = SQLSTR4 & Space(12)

    ''''                '4,8
    ''''                'CSHNAME
    ''''                SQLSTR4 = SQLSTR4 & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30)))) & Space(4)


    ''''                '5 START
    ''''                SQLSTR5 = ""


    ''''                '5,1
    ''''                'TENS
    ''''                If Val(dr("TENS")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("TENS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TENS")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(14)
    ''''                End If

    ''''                '5,2
    ''''                'SBF
    ''''                If Val(dr("SBF")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("SBF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SBF")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(15)
    ''''                End If


    ''''                '5,3
    ''''                'TENLOC
    ''''                If Val(dr("TENLOC")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("TENLOC")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TENLOC")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(14)
    ''''                End If

    ''''                '5,4
    ''''                'YOGA
    ''''                If Val(dr("YOGA")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("YOGA")), "0.00"), 1, 7))) & Mid(Format(Val(dr("YOGA")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(15)
    ''''                End If

    ''''                '5,5
    ''''                'INT
    ''''                If Val(dr("INT")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("INT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("INT")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(15)
    ''''                End If

    ''''                '5,6
    ''''                'SPCARD
    ''''                If Val(dr("SPCARD")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(7 - Len(Mid(Format(Val(dr("SPCARD")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SPCARD")), "0.00"), 1, 7) & Space(10)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(17)
    ''''                End If


    ''''                '5,7
    ''''                'TOT
    ''''                If Val(dr("TOT")) <> 0 Then
    ''''                    SQLSTR5 = SQLSTR5 & Space(9 - Len(Mid(Format(Val(dr("TOT")), "0.00"), 1, 9))) & Mid(Format(Val(dr("TOT")), "0.00"), 1, 9) & Space(3)
    ''''                Else
    ''''                    SQLSTR5 = SQLSTR5 & Space(12)
    ''''                End If

    ''''                '5,8
    ''''                '
    ''''                SQLSTR5 = SQLSTR5 & Trim(Mid(dr("CONTADD2"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD2"), 1, 30)))) & Space(8)

    ''''                SQLSTR5 = SQLSTR5 & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))

    ''''                SQLSTR6 = ""
    ''''                '6,1
    ''''                'TCF
    ''''                If Val(dr("TCF")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("TCF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TCF")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(14)
    ''''                End If

    ''''                '6,2
    ''''                'SCF
    ''''                If Val(dr("SCF")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("SCF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SCF")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(15)
    ''''                End If

    ''''                '6,3
    ''''                'SWPLOC
    ''''                If Val(dr("SWPLOC")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("SWPLOC")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SWPLOC")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(14)
    ''''                End If


    ''''                '6,4
    ''''                'AERB
    ''''                If Val(dr("AERB")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("AERB")), "0.00"), 1, 7))) & Mid(Format(Val(dr("AERB")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(15)
    ''''                End If

    ''''                '6,5
    ''''                'DINCHI
    ''''                If Val(dr("DINCHI")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("DINCHI")), "0"), 1, 7))) & Mid(Format(Val(dr("DINCHI")), "0"), 1, 7) & Space(1)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(14)
    ''''                End If


    ''''                '6,6
    ''''                ''CONT
    ''''                'If Val(dr("CONT")) <> 0 Then
    ''''                '    SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("CONT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CONT")), "0.00"), 1, 7) & Space(10)
    ''''                'Else
    ''''                '    SQLSTR6 = SQLSTR6 & Space(17)
    ''''                'End If


    ''''                '6,6
    ''''                'SERVICETAX
    ''''                If Val(dr("SERVICETAX")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & "CONT." & Space(7 - Len(Mid(Format(Val(dr("SERVICETAX")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SERVICETAX")), "0.00"), 1, 7) & Space(8)
    ''''                Else
    ''''                    SQLSTR6 = SQLSTR6 & Space(15)
    ''''                End If

    ''''                '6,7
    ''''                'DEBBF
    ''''                If Val(dr("DEBBF")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(8 - Len(Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 8))) & Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 8) & "Dr" & Space(2)
    ''''                ElseIf Val(dr("CREBF")) <> 0 Then
    ''''                    SQLSTR6 = SQLSTR6 & Space(8 - Len(Mid(Format(Val(dr("CREBF")), "0.00"), 1, 8))) & Mid(Format(Val(dr("CREBF")), "0.00"), 1, 8) & "Cr" & Space(2)
    ''''                Else
    ''''                    'SQLSTR6 = SQLSTR6 & Space(12)
    ''''                    SQLSTR6 = SQLSTR6 & Space(16)
    ''''                End If


    ''''                '6,8
    ''''                SQLSTR6 = SQLSTR6 & Trim(Mid(dr("CONTCITY"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTCITY"), 1, 30))))


    ''''                SQLSTR7 = ""
    ''''                '7,1
    ''''                'LIGHT
    ''''                If Val(dr("LIGHT")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(7 - Len(Mid(Format(Val(dr("LIGHT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("LIGHT")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(14)
    ''''                End If

    ''''                '7,2
    ''''                'CSC
    ''''                If Val(dr("CSC")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(7 - Len(Mid(Format(Val(dr("CSC")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CSC")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(14)
    ''''                End If

    ''''                '7,3
    ''''                'HCLOC
    ''''                If Val(dr("HCLOC")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(7 - Len(Mid(Format(Val(dr("HCLOC")), "0.00"), 1, 7))) & Mid(Format(Val(dr("HCLOC")), "0.00"), 1, 7) & Space(7)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(14)
    ''''                End If


    ''''                '7,4
    ''''                'GYM
    ''''                If Val(dr("GYM")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(8 - Len(Mid(Format(Val(dr("GYM")), "0.00"), 1, 8))) & Mid(Format(Val(dr("GYM")), "0.00"), 1, 8) & Space(8)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(16)
    ''''                End If


    ''''                '7,5
    ''''                'BARCHI
    ''''                If Val(dr("BARCHI")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(8 - Len(Mid(Format(Val(dr("BARCHI")), "0"), 1, 8))) & Mid(Format(Val(dr("BARCHI")), "0"), 1, 8) & Space(8)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(16)
    ''''                End If


    ''''                '7,6
    ''''                'BFUND
    ''''                If Val(dr("BFUND")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & "BFUND " & Space(8 - Len(Mid(Format(Val(dr("BFUND")), "0.00"), 1, 8))) & Mid(Format(Val(dr("BFUND")), "0.00"), 1, 8)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(14)
    ''''                End If

    ''''                '                    SQLSTR7 = SQLSTR7 & Space(22)

    ''''                '7,7
    ''''                'NET 
    ''''                If Val(dr("AMTDEB")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(8 - Len(Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 8))) & Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 8) & "Dr" & Space(15)
    ''''                ElseIf Val(dr("AMTCRE")) <> 0 Then
    ''''                    SQLSTR7 = SQLSTR7 & Space(8 - Len(Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 8))) & Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 8) & "Cr" & Space(15)
    ''''                Else
    ''''                    SQLSTR7 = SQLSTR7 & Space(25)
    ''''                End If


    ''''                SQLSTR7 = SQLSTR7 & Space(20) & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 1, 30))))

    ''''                ''PRINTING
    ''''                ''5

    ''''                'Filewrite.WriteLine(Space(72) & Trim(TXT_VATNOTE.Text))

    ''''                'Filewrite.WriteLine(SQLSTR1)
    ''''                ''6
    ''''                'Filewrite.WriteLine()

    ''''                'SQLSTR = Space(95) & Trim(Mid(dr("MCODE"), 1, 8)) & Space(8 - Len(Trim(Mid(dr("MCODE"), 1, 8)))) & Space(32) & Trim(Mid(dr("MCODE"), 1, 8)) & Space(8 - Len(Trim(Mid(dr("MCODE"), 1, 8))))
    ''''                'Filewrite.WriteLine(SQLSTR)
    ''''                ''7
    ''''                'Filewrite.WriteLine(Space(103) & Trim(Mid(dr("MEMBERTYPE"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MEMBERTYPE"), 1, 30)))))

    ''''                'Filewrite.WriteLine(SQLSTR2)
    ''''                ''8
    ''''                'SQLSTR = Space(97) & Trim(Mid(dr("CONTADD1"), 1, 50)) & Space(50 - Len(Trim(Mid(dr("CONTADD1"), 1, 50))))
    ''''                'Filewrite.WriteLine(SQLSTR)
    ''''                'SQLSTR = Space(97) & Trim(Mid(dr("CONTADD2"), 1, 50)) & Space(50 - Len(Trim(Mid(dr("CONTADD2"), 1, 50))))
    ''''                'Filewrite.WriteLine(SQLSTR)
    ''''                'SQLSTR = Space(97) & Trim(Mid(dr("CONTADD3"), 1, 50)) & Space(50 - Len(Trim(Mid(dr("CONTADD3"), 1, 50))))
    ''''                'Filewrite.WriteLine(SQLSTR)
    ''''                ''9
    ''''                'Filewrite.WriteLine(SQLSTR3)
    ''''                ''10

    ''''                'SQLSTR = Space(97) & Trim(Mid(dr("CONTPIN"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPIN"), 1, 30))))
    ''''                'Filewrite.WriteLine(SQLSTR)

    ''''                'Filewrite.WriteLine()

    ''''                'SQLSTR = Space(87) & "Payments Accounted Upto " & Format(dr("PYMTUPTO"), "dd MMM yyyy")
    ''''                'Filewrite.WriteLine(SQLSTR)

    ''''                'Filewrite.WriteLine(SQLSTR4)
    ''''                ''12

    ''''                'SQLSTR = Space(92) & Trim(Mid(dr("CONTPHONE1"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 15)))) & Space(10) & Trim(Mid(dr("CONTPHONE2"), 1, 15)) & Space(15 - Len(Trim(Mid(dr("CONTPHONE2"), 1, 15))))
    ''''                'Filewrite.WriteLine(SQLSTR)
    ''''                'Filewrite.WriteLine(Space(87) & Trim(txt_note.Text))

    ''''                'For I = 1 To 4
    ''''                '    Filewrite.WriteLine()
    ''''                'Next I



    ''''                'PRINTING
    ''''                '5
    ''''                Filewrite.WriteLine(SQLSTR1)
    ''''                '6
    ''''                SQLSTR = Space(118) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                '7
    ''''                Filewrite.WriteLine(SQLSTR2)
    ''''                '8
    ''''                SQLSTR = Space(113) & Trim(Mid(dr("MEMBERTYPE"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MEMBERTYPE"), 1, 30))))
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                '9
    ''''                Filewrite.WriteLine(SQLSTR3)
    ''''                '10
    ''''                '4,9
    ''''                SQLSTR = Space(148) & Mid(Format(dr("BILLDATE"), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4)
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                '11
    ''''                Filewrite.WriteLine(SQLSTR4)
    ''''                '12
    ''''                SQLSTR = Space(102)
    ''''                SQLSTR = SQLSTR & Trim(Mid(dr("CONTADD1"), 1, 50)) & Space(50 - Len(Trim(Mid(dr("CONTADD1"), 1, 50))))
    ''''                ' SQLSTR = SQLSTR & Space(15) & Trim(Mid(dr("MCODE"), 1, 20)) & Space(20 - Len(Trim(Mid(dr("MCODE"), 1, 20))))
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                '13
    ''''                Filewrite.WriteLine(SQLSTR5)
    ''''                '14
    ''''                SQLSTR = Space(102) & Trim(Mid(dr("CONTADD3"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD3"), 1, 30))))
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                '15
    ''''                Filewrite.WriteLine(SQLSTR6)
    ''''                '16
    ''''                If Val(dr("CONT")) <> 0 Then
    ''''                    SQLSTR = Space(66) & "CHRG." & Space(29) '&  Trim(Mid(dr("CONTPHONE1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 30))))
    ''''                Else
    ''''                    SQLSTR = Space(73) & Space(29)  '&  Trim(Mid(dr("CONTPHONE1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 30))))
    ''''                End If
    ''''                Filewrite.WriteLine(SQLSTR)

    ''''                '17
    ''''                Filewrite.WriteLine(SQLSTR7)


    ''''                '18
    ''''                If Len((txt_note.Text)) > 0 Or Len((TXT_VATNOTE.Text)) > 0 Or Val(dr("BFUND")) <> 0 Then
    ''''                    If Val(dr("OTHS1")) <> 0 Then
    ''''                        SQLSTR = Trim(Mid(txt_note.Text, 1, 30)) & Space(30 - Len(Trim(Mid(txt_note.Text, 1, 30))))
    ''''                        SQLSTR = SQLSTR & Space(1) & Trim(Mid(TXT_VATNOTE.Text, 1, 30)) & Space(30 - Len(Trim(Mid(TXT_VATNOTE.Text, 1, 30))))
    ''''                    Else
    ''''                        SQLSTR = Space(61)
    ''''                    End If
    ''''                    If Val(dr("BFUND")) <> 0 Then
    ''''                        SQLSTR = SQLSTR & "Month Rcpt" & Space(8 - Len(Mid(Format(Val(dr("RCPT")), "0.00"), 1, 8))) & Mid(Format(Val(dr("RCPT")), "0.00"), 1, 8)
    ''''                    Else
    ''''                        SQLSTR = SQLSTR & Space(18)
    ''''                    End If
    ''''                    SQLSTR = SQLSTR & Space(38) & Format(dr("BILLDATE"), "dd/MM/yyyy")
    ''''                Else
    ''''                    SQLSTR = Space(117) & Format(dr("BILLDATE"), "dd/MM/yyyy")
    ''''                End If
    ''''                Filewrite.WriteLine(SQLSTR)
    ''''                For I = 1 To 7
    ''''                    Filewrite.WriteLine()
    ''''                Next I

    ''''                'For I = 1 To 3
    ''''                '    Filewrite.WriteLine()
    ''''                'Next I

    ''''            Next dr
    ''''        Else
    ''''            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    ''''            Exit Function
    ''''        End If
    ''''        '            For I = 1 To 7
    ''''        '            Filewrite.WriteLine()
    ''''        '            Next I

    ''''        Filewrite.Close()
    ''''        If gPrint = False Then
    ''''            OpenTextFile(vOutfile)
    ''''        Else
    ''''            PrintTextFile(vOutfile)
    ''''        End If
    ''''    Catch ex As Exception
    ''''        MsgBox(ex.Message & ex.Source & ex.ToString)
    ''''        Exit Function
    ''''    End Try
    ''''End Function

    Public Function Reportdetails_All()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim POSdesc() As String
        Dim STRSTRING, SQLSTR, SQLSTR1, SQLSTR2, SQLSTR3, SQLSTR4, SQLSTR5, SQLSTR6, SQLSTR7, SQLSTR8, SQLSTR9 As String
        Dim PAGESIZE As Integer
        Dim PYMTUPTO, DUEDATE As Date


        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath

            'Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
            'Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
            'Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

            sqlstring = " SELECT PYMTUPTO,DUEDATE FROM POS_FUND_MASTER "
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    PYMTUPTO = dr("PYMTUPTO")
                    DUEDATE = dr("DUEDATE")
                Next
            End If
            If chk_bulk.Checked = True Then
                sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT a, POS_PENDING b WHERE a.mcode=b.mcode and "
                sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
                If txt_mcode.Text <> "" Then
                    sqlstring = sqlstring & " AND a.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
                End If
                If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
                    For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
                        POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
                        sqlstring = sqlstring & " '" & POSdesc(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                End If
                '                sqlstring = sqlstring & " ORDER BY b.autoid,MEMBERTYPE,MESS_CD,a.MCODE"
                sqlstring = sqlstring & " ORDER BY a.MCODE"
            Else
                sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT WHERE "
                sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
                If txt_mcode.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"

                    '************************************  filter of member *************************************************
                    ''''''''If ONE_chk.Checked = True Then
                    ''''''''    sqlstring = sqlstring & " AND substring(mcode,1,1)='" & Mid(txt_mcode.Text, 1, 1) & "' AND MCODE NOT  LIKE '%(L)%' and (substring(mcode,3,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 3, 5) & " as int ) AND cast('" & Mid(txt_Tomcode.Text, 3, 5) & "' as int)   order by substring(mcode,1,1),cast(substring(mcode,3,5) as int)"
                    ''''''''ElseIf TWO_CHK.Checked = True Then
                    ''''''''    sqlstring = sqlstring & " AND substring(mcode,1,2)='" & Mid(txt_mcode.Text, 1, 2) & "' AND MCODE NOT  LIKE '%(L)%'and (substring(mcode,4,5)  BETWEEN " & Mid(txt_mcode.Text, 4, 5) & " AND " & Mid(txt_Tomcode.Text, 4, 5) & ")   order by cast(substring(mcode,4,5) as int)"
                    ''''''''    'ElseIf L_CHK.Checked = True Then
                    ''''''''    '    sqlstring = sqlstring & " AND substring(mcode,1,1)='" & Mid(txt_mcode.Text, 1, 1) & "'  AND MCODE NOT  LIKE '%(L)%' and (substring(mcode,4,5)  BETWEEN '" & Mid(txt_mcode.Text, 4, 5) & "' AND ' " & Mid(txt_Tomcode.Text, 4, 5) & "')    order by cast(substring(mcode,3,5) as int)"
                    ''''''''Else
                    ''''''''    sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
                    ''''''''End If
                    ''''''''' sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"

                    ''''If ONE_CHK.Checked = True Then
                    ''''    sqlstring = sqlstring & " AND (substring(mcode,1,1) BETWEEN  '" & Mid(txt_mcode.Text, 1, 1) & "' AND '" & Mid(txt_Tomcode.Text, 1, 1) & "' )  AND MCODE NOT LIKE '%(L)%'   and (substring(mcode,3,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 3, 5) & "'as int ) AND cast('" & Mid(txt_Tomcode.Text, 3, 5) & "' as int))   order by substring(mcode,1,1),cast(substring(mcode,3,5) as int)"
                    ''''ElseIf TWO_CHK.Checked = True Then
                    ''''    sqlstring = sqlstring & " AND (substring(mcode,1,2)  BETWEEN  '" & Mid(txt_mcode.Text, 1, 2) & "' AND '" & Mid(txt_Tomcode.Text, 1, 2) & "') AND MCODE NOT LIKE '%(L)%'  and (substring(mcode,4,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 4, 5) & "' as int ) AND cast('" & Mid(txt_Tomcode.Text, 4, 5) & "' as int))   order by substring(mcode,1,2),cast(substring(mcode,4,5) as int)"

                    ''''    'sqlstring = sqlstring & " AND substring(mcode,1,2)='" & Mid(txt_mcode.Text, 1, 2) & "' AND MCODE NOT  LIKE '%(L)%'and (substring(mcode,4,5)  BETWEEN " & Mid(txt_mcode.Text, 4, 5) & " AND " & Mid(txt_Tomcode.Text, 4, 5) & ")   order by cast(substring(mcode,4,5) as int)"
                    ''''End If
                    '************************************  filter of member *************************************************
                    'sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"


                    '                    sqlstring = sqlstring & " AND ISNULL(MSORDERNO,0)  BETWEEN  (SELECT ISNULL(MSORDERNO,0) FROM MEMBERMASTER WHERE MCODE='" & txt_mcode.Text & "')"
                    '                    sqlstring = sqlstring & " AND  (SELECT ISNULL(MSORDERNO,0)  FROM MEMBERMASTER WHERE MCODE='" & txt_Tomcode.Text & "')"
                End If

                If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
                    For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
                        POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
                        sqlstring = sqlstring & " '" & POSdesc(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"

                End If
                '                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MESS_CD,MCODE"
                sqlstring = sqlstring & " ORDER BY MCODE"
            End If
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows

                    For I = 1 To 6
                        Filewrite.WriteLine()
                    Next
                    '1
                    SQLSTR1 = Space(15) & Mid(Format(dr("BILLDATE"), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4)
                    SQLSTR1 = SQLSTR1 & Space(30) & Trim(Mid(dr("MCODE"), 1, 10))  '& Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    SQLSTR1 = SQLSTR1 & " - " & Trim(Mid(dr("MEMBERTYPECODE"), 1, 10)) '& Space(10 - Len(Trim(Mid(dr("MEMBERTYPECODE"), 1, 10))))

                    Filewrite.WriteLine(SQLSTR1)
                    '2
                    Filewrite.WriteLine()

                    '2
                    Filewrite.WriteLine()

                    SQLSTR1 = Space(5) & Trim(Mid(dr("MNAME"), 1, 60)) & Space(60 - Len(Trim(Mid(dr("MNAME"), 1, 60))))
                    '3
                    '                    Filewrite.WriteLine()

                    '4
                    Filewrite.WriteLine(SQLSTR1)
                    '5
                    Filewrite.WriteLine()
                    '6
                    Filewrite.WriteLine()

                    '7
                    '   Filewrite.WriteLine()

                    'SUBS 
                    SQLSTR1 = Space(12)
                    If Val(dr("SUBS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("SUBS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SUBS")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'BUILDFUND
                    If Val(dr("BUILDFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BUILDFUND")), "0"), 1, 7))) & Mid(Format(Val(dr("BUILDFUND")), "0"), 1, 7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(7)
                    End If
                    SQLSTR1 = SQLSTR1 & Space(3) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    '8
                    Filewrite.WriteLine(SQLSTR1)
                    SQLSTR1 = Space(49) & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 3, 10))))
                    '9
                    Filewrite.WriteLine(SQLSTR1)

                    'GUESTFEE
                    SQLSTR1 = Space(12)
                    If Val(dr("GUESTFEE")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("GUESTFEE")), "0.00"), 1, 7))) & Mid(Format(Val(dr("GUESTFEE")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'RELFUND
                    If Val(dr("RELFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("RELFUND")), "0.00"), 1, 7))) & Mid(Format(Val(dr("RELFUND")), "0.00"), 1, 7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(7)
                    End If

                    'LINE4
                    SQLSTR1 = SQLSTR1 & Space(3) & Trim(Mid(dr("CONTADD1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 3, 10))))
                    '10
                    Filewrite.WriteLine(SQLSTR1)

                    SQLSTR1 = Space(49) & Trim(Mid(dr("CONTADD2"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD2"), 3, 10))))
                    '11
                    Filewrite.WriteLine(SQLSTR1)


                    'SERTAX
                    SQLSTR1 = Space(12)
                    If Val(dr("SERTAX")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("SERTAX")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SERTAX")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'BAR
                    If Val(dr("BAR")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BAR")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BAR")), "0.00"), 1, 7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(7)
                    End If


                    'LINE5
                    SQLSTR1 = SQLSTR1 & Space(3) & Trim(Mid(dr("CONTADD3"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD3"), 3, 10))))
                    '12
                    Filewrite.WriteLine(SQLSTR1)

                    ' SQLSTR1 = Space(50) & Trim(Mid(dr("CONTCITY"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTCITY"), 1, 30))))
                    '13
                    'Filewrite.WriteLine(SQLSTR1)

                    'SERTAX
                    SQLSTR1 = Space(12)
                    SQLSTR1 = SQLSTR1 & Space(27)

                    ''VAT
                    'If Val(dr("VAT")) <> 0 Then
                    '    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("VAT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("VAT")), "0.00"), 1, 7) & Space(7)
                    'Else
                    '    SQLSTR1 = SQLSTR1 & Space(14)
                    'End If

                    SQLSTR1 = Space(49) & Trim(Mid(dr("CONTPIN"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPIN"), 1, 30))))

                    '13
                    Filewrite.WriteLine(SQLSTR1)

                    'BILLIARDS
                    SQLSTR1 = Space(12)
                    If Val(dr("BILLIARDS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BILLIARDS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BILLIARDS")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'CANTEEN
                    If Val(dr("CANTEEN")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("CANTEEN")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CANTEEN")), "0.00"), 1, 7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(7)
                    End If

                    '14
                    Filewrite.WriteLine(SQLSTR1)
                    SQLSTR1 = Space(49) & Trim(Mid(dr("CONTPHONE1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTPHONE1"), 1, 30))))

                    '15
                    Filewrite.WriteLine(SQLSTR1)




                    'BILLIARDS
                    SQLSTR1 = Space(12)
                    SQLSTR1 = SQLSTR1 & Space(27)

                    'TOT
                    'If Val(dr("TOT")) <> 0 Then
                    '    SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("TOT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TOT")), "0.00"), 1, 7) & Space(3)
                    'Else
                    '    SQLSTR1 = SQLSTR1 & Space(10)
                    'End If

                    '                    Filewrite.WriteLine(SQLSTR1)
                    '                   Filewrite.WriteLine()



                    'TENNIS
                    SQLSTR1 = Space(12)
                    If Val(dr("TENNIS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("TENNIS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TENNIS")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'CREBF
                    If Val(dr("CREBF")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("CREBF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CREBF")), "0.00"), 1, 7) & "Cr"
                    ElseIf Val(dr("DEBBF")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 7) & "Dr"
                    Else
                        SQLSTR1 = SQLSTR1 & Space(9)
                    End If

                    '16
                    Filewrite.WriteLine(SQLSTR1)
                    '17
                    Filewrite.WriteLine()



                    'MMBFUND
                    SQLSTR1 = Space(12)
                    If Val(dr("MMBFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("MMBFUND")), "0.00"), 1, 7))) & Mid(Format(Val(dr("MMBFUND")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'RCPT
                    If Val(dr("RCPT")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("RCPT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("RCPT")), "0.00"), 1, 7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(7)
                    End If

                    '18
                    Filewrite.WriteLine(SQLSTR1)
                    '19
                    Filewrite.WriteLine()



                    'OTHERS
                    SQLSTR1 = Space(12)
                    If Val(dr("OTHERS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("OTHERS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("OTHERS")), "0.00"), 1, 7) & Space(20)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(27)
                    End If

                    'AMTCRE
                    If Val(dr("AMTCRE")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 7))) & Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 7) & "Cr"
                    ElseIf Val(dr("AMTDEB")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 7))) & Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 7) & "Dr"
                    Else
                        SQLSTR1 = SQLSTR1 & Space(9)
                    End If

                    '20
                    Filewrite.WriteLine(SQLSTR1)
                    '21
                    Filewrite.WriteLine()

                    '22
                    Filewrite.WriteLine()
                    '23
                    Filewrite.WriteLine()
                    '24
                    Filewrite.WriteLine()

                    SQLSTR1 = Space(25) & Format(dr("DUEDATE"), "dd-MM-yyyy")
                    '25
                    Filewrite.WriteLine(SQLSTR1)

                    'DINCHI
                    If Val(dr("DINCHI")) <> 0 Then
                        SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("DINCHI")), "0"), 1, 7))) & Mid(Format(Val(dr("DINCHI")), "0"), 1, 7) & Space(3)
                    Else
                        SQLSTR6 = SQLSTR6 & Space(10)
                    End If

                    For I = 1 To 6
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                    MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Function
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function


    Public Function Reportdetails_All_OLD07012011()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim POSdesc() As String
        Dim STRSTRING, SQLSTR, SQLSTR1, SQLSTR2, SQLSTR3, SQLSTR4, SQLSTR5, SQLSTR6, SQLSTR7, SQLSTR8, SQLSTR9 As String
        Dim PAGESIZE As Integer
        Dim PYMTUPTO, DUEDATE As Date


        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath

            'Filewrite.Write(Chr(27) + Chr(67) + Chr(24))
            'Filewrite.Write(Chr(27) + Chr(33) + Chr(1))
            'Filewrite.Write(Chr(27) + Chr(106) + Chr(205))

            sqlstring = " SELECT PYMTUPTO,DUEDATE FROM POS_FUND_MASTER "
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    PYMTUPTO = dr("PYMTUPTO")
                    DUEDATE = dr("DUEDATE")
                Next
            End If
            If chk_bulk.Checked = True Then
                sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT a, POS_PENDING b WHERE a.mcode=b.mcode and "
                sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
                If txt_mcode.Text <> "" Then
                    sqlstring = sqlstring & " AND a.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
                End If
                If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
                    For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
                        POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
                        sqlstring = sqlstring & " '" & POSdesc(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                End If
                '                sqlstring = sqlstring & " ORDER BY b.autoid,MEMBERTYPE,MESS_CD,a.MCODE"
                sqlstring = sqlstring & " ORDER BY b.autoid,a.MSORDERNO"
            Else
                sqlstring = "SELECT * FROM SC_MONTH_BILL_PRINT WHERE "
                sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
                If txt_mcode.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"

                    '************************************  filter of member *************************************************
                    ''''''''If ONE_chk.Checked = True Then
                    ''''''''    sqlstring = sqlstring & " AND substring(mcode,1,1)='" & Mid(txt_mcode.Text, 1, 1) & "' AND MCODE NOT  LIKE '%(L)%' and (substring(mcode,3,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 3, 5) & " as int ) AND cast('" & Mid(txt_Tomcode.Text, 3, 5) & "' as int)   order by substring(mcode,1,1),cast(substring(mcode,3,5) as int)"
                    ''''''''ElseIf TWO_CHK.Checked = True Then
                    ''''''''    sqlstring = sqlstring & " AND substring(mcode,1,2)='" & Mid(txt_mcode.Text, 1, 2) & "' AND MCODE NOT  LIKE '%(L)%'and (substring(mcode,4,5)  BETWEEN " & Mid(txt_mcode.Text, 4, 5) & " AND " & Mid(txt_Tomcode.Text, 4, 5) & ")   order by cast(substring(mcode,4,5) as int)"
                    ''''''''    'ElseIf L_CHK.Checked = True Then
                    ''''''''    '    sqlstring = sqlstring & " AND substring(mcode,1,1)='" & Mid(txt_mcode.Text, 1, 1) & "'  AND MCODE NOT  LIKE '%(L)%' and (substring(mcode,4,5)  BETWEEN '" & Mid(txt_mcode.Text, 4, 5) & "' AND ' " & Mid(txt_Tomcode.Text, 4, 5) & "')    order by cast(substring(mcode,3,5) as int)"
                    ''''''''Else
                    ''''''''    sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
                    ''''''''End If
                    ''''''''' sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"

                    ''''If ONE_CHK.Checked = True Then
                    ''''    sqlstring = sqlstring & " AND (substring(mcode,1,1) BETWEEN  '" & Mid(txt_mcode.Text, 1, 1) & "' AND '" & Mid(txt_Tomcode.Text, 1, 1) & "' )  AND MCODE NOT LIKE '%(L)%'   and (substring(mcode,3,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 3, 5) & "'as int ) AND cast('" & Mid(txt_Tomcode.Text, 3, 5) & "' as int))   order by substring(mcode,1,1),cast(substring(mcode,3,5) as int)"
                    ''''ElseIf TWO_CHK.Checked = True Then
                    ''''    sqlstring = sqlstring & " AND (substring(mcode,1,2)  BETWEEN  '" & Mid(txt_mcode.Text, 1, 2) & "' AND '" & Mid(txt_Tomcode.Text, 1, 2) & "') AND MCODE NOT LIKE '%(L)%'  and (substring(mcode,4,5)  BETWEEN  cast('" & Mid(txt_mcode.Text, 4, 5) & "' as int ) AND cast('" & Mid(txt_Tomcode.Text, 4, 5) & "' as int))   order by substring(mcode,1,2),cast(substring(mcode,4,5) as int)"

                    ''''    'sqlstring = sqlstring & " AND substring(mcode,1,2)='" & Mid(txt_mcode.Text, 1, 2) & "' AND MCODE NOT  LIKE '%(L)%'and (substring(mcode,4,5)  BETWEEN " & Mid(txt_mcode.Text, 4, 5) & " AND " & Mid(txt_Tomcode.Text, 4, 5) & ")   order by cast(substring(mcode,4,5) as int)"
                    ''''End If
                    '************************************  filter of member *************************************************
                    'sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"


                    sqlstring = sqlstring & " AND ISNULL(MSORDERNO,0)  BETWEEN  (SELECT ISNULL(MSORDERNO,0) FROM MEMBERMASTER WHERE MCODE='" & txt_mcode.Text & "')"
                    sqlstring = sqlstring & " AND  (SELECT ISNULL(MSORDERNO,0)  FROM MEMBERMASTER WHERE MCODE='" & txt_Tomcode.Text & "')"
                End If

                If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
                    For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
                        POSdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
                        sqlstring = sqlstring & " '" & POSdesc(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"

                End If
                '                sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MESS_CD,MCODE"
                sqlstring = sqlstring & " ORDER BY MSORDERNO"
            End If
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows

                    'LINE1
                    SQLSTR1 = Space(10) & Space(8 - Len(Mid(Format(Val(dr("BILLNO")), "0"), 1, 8))) & Mid(Format(Val(dr("BILLNO")), "0"), 1, 8)
                    SQLSTR1 = SQLSTR1 & Space(10) & Format(dr("BILLDATE"), "dd-MM-yyyy")
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()

                    'LIN2
                    SQLSTR1 = Space(10) & Mid(Format(dr("BILLDATE"), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 3, 4)
                    SQLSTR1 = SQLSTR1 & Space(10) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    SQLSTR1 = SQLSTR1 & Space(10) & Trim(Mid(dr("MNAME"), 1, 25)) & Space(25 - Len(Trim(Mid(dr("MNAME"), 1, 25))))
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()

                    'SUBS
                    SQLSTR1 = Space(15)
                    If Val(dr("SUBS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("SUBS")), "0"), 1, 7))) & Mid(Format(Val(dr("SUBS")), "0"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'BUILDFUND
                    If Val(dr("BUILDFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BUILDFUND")), "0"), 1, 7))) & Mid(Format(Val(dr("BUILDFUND")), "0"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If
                    SQLSTR1 = SQLSTR1 & Space(5) & Trim(Mid(dr("MCODE"), 1, 10)) & Space(10 - Len(Trim(Mid(dr("MCODE"), 1, 10))))
                    'LINE3
                    Filewrite.WriteLine(SQLSTR1)
                    SQLSTR1 = Space(48) & Trim(Mid(dr("MNAME"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("MNAME"), 3, 10))))
                    Filewrite.WriteLine(SQLSTR1)

                    'GUESTFEE
                    SQLSTR1 = Space(15)
                    If Val(dr("GUESTFEE")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("GUESTFEE")), "0.00"), 1, 7))) & Mid(Format(Val(dr("GUESTFEE")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'RELFUND
                    If Val(dr("RELFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("RELFUND")), "0.00"), 1, 7))) & Mid(Format(Val(dr("RELFUND")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE4
                    SQLSTR1 = SQLSTR1 & Space(5) & Trim(Mid(dr("CONTADD1"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD1"), 3, 10))))

                    Filewrite.WriteLine(SQLSTR1)

                    SQLSTR1 = Space(48) & Trim(Mid(dr("CONTADD2"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD2"), 3, 10))))

                    Filewrite.WriteLine(SQLSTR1)


                    'SERTAX
                    SQLSTR1 = Space(15)
                    If Val(dr("SERTAX")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("SERTAX")), "0.00"), 1, 7))) & Mid(Format(Val(dr("SERTAX")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'BAR
                    If Val(dr("BAR")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BAR")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BAR")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If


                    'LINE5
                    SQLSTR1 = SQLSTR1 & Space(5) & Trim(Mid(dr("CONTADD3"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTADD3"), 3, 10))))

                    Filewrite.WriteLine(SQLSTR1)

                    SQLSTR1 = Space(50) & Trim(Mid(dr("CONTCITY"), 1, 30)) & Space(30 - Len(Trim(Mid(dr("CONTCITY"), 1, 30))))

                    Filewrite.WriteLine(SQLSTR1)

                    'SERTAX
                    SQLSTR1 = Space(15)
                    SQLSTR1 = SQLSTR1 & Space(14)

                    'VAT
                    If Val(dr("VAT")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("VAT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("VAT")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If


                    'LINE6
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()


                    'BILLIARDS
                    SQLSTR1 = Space(15)
                    If Val(dr("BILLIARDS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("BILLIARDS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("BILLIARDS")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'CANTEEN
                    If Val(dr("CANTEEN")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("CANTEEN")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CANTEEN")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE7
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()



                    'BILLIARDS
                    SQLSTR1 = Space(15)
                    SQLSTR1 = SQLSTR1 & Space(14)

                    'TOT
                    If Val(dr("TOT")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("TOT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TOT")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE8
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()



                    'TENNIS
                    SQLSTR1 = Space(15)
                    If Val(dr("TENNIS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("TENNIS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("TENNIS")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'CREBF
                    If Val(dr("CREBF")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("CREBF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("CREBF")), "0.00"), 1, 7) & " Cr" & Space(4)
                    ElseIf Val(dr("DEBBF")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 7))) & Mid(Format(Val(dr("DEBBF")), "0.00"), 1, 7) & " Dr" & Space(4)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE9
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()



                    'MMBFUND
                    SQLSTR1 = Space(15)
                    If Val(dr("MMBFUND")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("MMBFUND")), "0.00"), 1, 7))) & Mid(Format(Val(dr("MMBFUND")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'RCPT
                    If Val(dr("RCPT")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("RCPT")), "0.00"), 1, 7))) & Mid(Format(Val(dr("RCPT")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE10
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()



                    'OTHERS
                    SQLSTR1 = Space(15)
                    If Val(dr("OTHERS")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("OTHERS")), "0.00"), 1, 7))) & Mid(Format(Val(dr("OTHERS")), "0.00"), 1, 7) & Space(7)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'AMTCRE
                    If Val(dr("AMTCRE")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 7))) & Mid(Format(Val(dr("AMTCRE")), "0.00"), 1, 7) & " Cr" & Space(4)
                    ElseIf Val(dr("AMTDEB")) <> 0 Then
                        SQLSTR1 = SQLSTR1 & Space(7 - Len(Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 7))) & Mid(Format(Val(dr("AMTDEB")), "0.00"), 1, 7) & " Dr" & Space(4)
                    Else
                        SQLSTR1 = SQLSTR1 & Space(14)
                    End If

                    'LINE11
                    Filewrite.WriteLine(SQLSTR1)
                    Filewrite.WriteLine()


                    SQLSTR1 = Space(30) & Format(dr("DUEDATE"), "dd-MM-yyyy")
                    Filewrite.WriteLine(SQLSTR1)

                    'DINCHI
                    If Val(dr("DINCHI")) <> 0 Then
                        SQLSTR6 = SQLSTR6 & Space(7 - Len(Mid(Format(Val(dr("DINCHI")), "0"), 1, 7))) & Mid(Format(Val(dr("DINCHI")), "0"), 1, 7) & Space(3)
                    Else
                        SQLSTR6 = SQLSTR6 & Space(10)
                    End If


                    For I = 1 To 8
                        Filewrite.WriteLine()
                    Next I
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        Dim I As Integer
        TXT_VATNOTE.Text = ""
        txt_note.Text = ""
        txt_mcode.Text = ""
        txt_mname.Text = ""
        txt_Tomname.Text = ""
        txt_Tomcode.Text = ""
        Call FillMEMBERTYPE()
        CbxMonth.Focus()
    End Sub
    Public Function Reportdetails_Service()
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc() As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING, SQLSTR As String
        Dim PAGESIZE As Integer
        Dim TAMOUNT As Double
        Dim MCODE As String
        Dim DBLNET As Double
        Dim C As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Filewrite.Write(Chr(15))

            sqlstring = "SELECT * FROM SC_VIEW_MEMBER_SERVICE WHERE "
            sqlstring = sqlstring & " BILLMONTH = " & Month(CbxMonth.Text) & " AND BILLYEAR = " & Year(CbxMonth.Text)
            If txt_mcode.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'"
            End If
            If chk_bulk.Checked = True Then
                sqlstring = sqlstring & " AND MCODE in (select mcode from POS_PENDING)"
            End If

            If chklist_MEMBERTYPE.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND MEMBERTYPECODE IN ("
                For I = 0 To chklist_MEMBERTYPE.CheckedItems.Count - 1
                    Posdesc = Split(chklist_MEMBERTYPE.CheckedItems(I), "-->")
                    sqlstring = sqlstring & " '" & Posdesc(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            End If
            sqlstring = sqlstring & " ORDER BY MEMBERTYPE,MESS_CD,MCODE"
            gconnection.getDataSet(sqlstring, "MEMBER")
            If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("MEMBER").Rows
                    If MCODE <> dr("MCODE") Then
                        If DBLNET > 0 Then
                            Filewrite.WriteLine(StrDup(77, "_"))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine(Space(5) & "Total : " & Space(43) & Space(8 - Len(Mid(Format(Val(DBLNET), "0.00"), 1, 8))) & Mid(Format(Val(DBLNET), "0.00"), 1, 8))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine(StrDup(77, "_"))
                            PAGESIZE = PAGESIZE + 1
                        End If
                        DBLNET = 0
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 4
                        Filewrite.WriteLine("Membership No : " & Mid(dr("MCODE"), 1, 8) & Space(8 - Len(Mid(dr("MCODE"), 1, 8))) & " Name : " & Mid(dr("MNAME"), 1, 40) & Space(40 - Len(Mid(dr("MNAME"), 1, 40))) & Space(1) & Mid(dr("MESS_CD"), 1, 10))
                        Filewrite.WriteLine("Details of Other Games, Spl Dinner, Other Events & Misc Services For " & Mid(Format(CDate(CbxMonth.Text), "MMM"), 1, 3) & "-" & Mid(CStr(Year(dr("BILLDATE"))), 1, 4))
                        PAGESIZE = PAGESIZE + 2
                        Filewrite.WriteLine(StrDup(77, "_"))
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("SNo. Charge Description                                Amount(Rs.)")
                        Filewrite.WriteLine(StrDup(77, "_"))
                        PAGESIZE = PAGESIZE + 2
                        MCODE = dr("MCODE")
                        C = 0
                    End If
                    C = C + 1
                    Filewrite.Write(Space(4 - Len(Mid(Format(C, "0"), 1, 4))) & Mid(Format(C, "0"), 1, 4))
                    Filewrite.Write(Space(1) & Mid(dr("ACCOUNTCODEDESC"), 1, 50) & Space(50 - Len(Mid(dr("ACCOUNTCODEDESC"), 1, 50))))
                    Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))
                    DBLNET = DBLNET + dr("AMOUNT")
                    PAGESIZE = PAGESIZE + 1
                Next dr
                Filewrite.WriteLine(StrDup(77, "_"))
                PAGESIZE = PAGESIZE + 1
                Filewrite.WriteLine(Space(5) & "Total : " & Space(43) & Space(8 - Len(Mid(Format(Val(DBLNET), "0.00"), 1, 8))) & Mid(Format(Val(DBLNET), "0.00"), 1, 8))
                PAGESIZE = PAGESIZE + 1
                Filewrite.WriteLine(StrDup(77, "_"))
                PAGESIZE = PAGESIZE + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Sub chk_bill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bill.CheckedChanged
        If chk_bill.Checked = True Then
            CHK_SERVICE.Checked = False
        ElseIf chk_bill.Checked = False Then
            CHK_SERVICE.Checked = True
        End If
    End Sub
    Private Sub CHK_SERVICE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SERVICE.CheckedChanged
        If CHK_SERVICE.Checked = True Then
            chk_bill.Checked = False
        ElseIf CHK_SERVICE.Checked = False Then
            chk_bill.Checked = True
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txt_Tomcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tomcode.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub TXT_VATNOTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_VATNOTE.TextChanged

    End Sub

    Private Sub MBILL_HBC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call cmd_clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_view_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call cmd_print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
End Class
