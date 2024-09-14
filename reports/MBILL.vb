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
Public Class MBILL
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5, ssql6, bildt As String
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim posting, posting1 As New DataTable
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
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Dtp_duedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmd_Export As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MBILL))
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.txt_Tomcode = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button
        Me.txt_Tomname = New System.Windows.Forms.TextBox
        Me.txt_note = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Dtp_duedate = New System.Windows.Forms.DateTimePicker
        Me.Cmd_Export = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(344, 80)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 21)
        Me.CbxMonth.TabIndex = 434
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 16)
        Me.Label10.TabIndex = 435
        Me.Label10.Text = "MEMBER BILL FOR THE MONTH OF : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 436
        Me.Label2.Text = "MONTH BILL"
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(88, 424)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(120, 21)
        Me.txt_mcode.TabIndex = 438
        Me.txt_mcode.Text = ""
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(136, 560)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 570
        Me.cmd_view.Text = "View [F8]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.Location = New System.Drawing.Point(264, 560)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 575
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(208, 424)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 577
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(88, 456)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(144, 21)
        Me.txt_mname.TabIndex = 579
        Me.txt_mname.Text = ""
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(312, 424)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(120, 21)
        Me.txt_Tomcode.TabIndex = 580
        Me.txt_Tomcode.Text = ""
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp1.Image = CType(resources.GetObject("cmd_MemberCodeHelp1.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(432, 424)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp1.TabIndex = 583
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(312, 456)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(144, 21)
        Me.txt_Tomname.TabIndex = 584
        Me.txt_Tomname.Text = ""
        '
        'txt_note
        '
        Me.txt_note.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(88, 488)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(168, 56)
        Me.txt_note.TabIndex = 585
        Me.txt_note.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 496)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 586
        Me.Label6.Text = "Notes"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 588
        Me.Label7.Text = "Due Date"
        '
        'Dtp_duedate
        '
        Me.Dtp_duedate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_duedate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Dtp_duedate.Location = New System.Drawing.Point(344, 496)
        Me.Dtp_duedate.Name = "Dtp_duedate"
        Me.Dtp_duedate.Size = New System.Drawing.Size(112, 21)
        Me.Dtp_duedate.TabIndex = 589
        '
        'Cmd_Export
        '
        Me.Cmd_Export.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Export.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Export.Location = New System.Drawing.Point(280, 520)
        Me.Cmd_Export.Name = "Cmd_Export"
        Me.Cmd_Export.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Export.TabIndex = 590
        Me.Cmd_Export.Text = "Export [F9]"
        Me.Cmd_Export.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(96, 96)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(164, 24)
        Me.chk_PrintAll.TabIndex = 592
        Me.chk_PrintAll.Text = "Select All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(88, 120)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(368, 292)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 591
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 593
        Me.Label3.Text = "MCODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 593
        Me.Label1.Text = "MNAME"
        '
        'MBILL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 606)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.Cmd_Export)
        Me.Controls.Add(Me.Dtp_duedate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.txt_Tomname)
        Me.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.Controls.Add(Me.txt_Tomcode)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MBILL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MBILL"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            Dim Viewer As New ReportViwer
            Dim r As New MonthBill0910

            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS = 'LIVE' AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell ORDER BY M.MCODE"
                sqlstring1 = "SELECT * "
                sqlstring1 = sqlstring1 & "FROM MM_BILL WHERE LTRIM(RTRIM(MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " ORDER BY MCODE,BILLDATE"
                ssql = "SELECT SLCODE,HEADDESC,SUM(AMOUNT) AS AMOUNT,BILLNO,BILLDATE FROM MAINCASHRECEIPT WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC,BILLDATE,BILLNO"
                ssql2 = "SELECT SLCODE,HEADDESC,SUM(AMOUNT) AS AMOUNT FROM DEBITNOTEPAYMENT WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC"
                ssql1 = "SELECT * FROM VIEW_MONTHBILL_ROOM WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " ORDER BY SLCODE,BILLDATE"
                SSQL4 = "SELECT billdate,locdesc,slcode,sum(amount)as amount,loccode FROM ROOM_BILL WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(CHKDATE) = " & month1 & " group by slcode,billdate,locdesc,loccode ORDER BY LOCDESC"
                SSQL5 = ""
                SSQL5 = "SELECT BILLNO,billdate,locdesc,slcode,sum(amount) as amount ,loccode FROM HOUSE_BILL WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & "  group by slcode,billdate,locdesc,loccode,BILLNO"
            Else
                membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)
                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") "
                sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS = 'LIVE' AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell ORDER BY M.MCODE"

                'sqlstring1 = "SELECT a.*"
                'sqlstring1 = sqlstring1 & " FROM MM_BILL  a, membermaster b "
                'sqlstring1 = sqlstring1 & " WHERE LTRIM(RTRIM(B.membertypecode)) IN(" & membertype & ") AND A.MCODE=B.MCODE"            
                'sqlstring1 = sqlstring1 & " AND MONTH(BILLDATE) = " & month1 & " ORDER BY A.MCODE,A.BILLDATE"

                ssql = "SELECT A.BILLNO,A.SLCODE AS SLCODE,A.HEADDESC,SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO"
                ssql2 = " SELECT A.SLCODE AS SLCODE,A.HEADDESC,SUM(A.AMOUNT) AS AMOUNT FROM DEBITNOTEPAYMENT A, MEMBERMASTER B "
                ssql2 = ssql2 & " WHERE Month(BILLDATE) = " & month1
                ssql2 = ssql2 & " AND B.membertypecode IN(" & membertype & ") AND  A.SLCODE=B.MCODE and isnull(b.freeze,'')<>'Y' "
                ssql2 = ssql2 & " GROUP BY A.SLCODE,A.HEADDESC"
                SSQL4 = " SELECT A.billdate,A.locdesc,A.SLCODE AS SLCODE,sum(A.amount)as amount,A.loccode FROM ROOM_BILL A,MEMBERMASTER B "
                SSQL4 = SSQL4 & " WHERE MONTH(CHKDATE) = " & month1 & " "
                SSQL4 = SSQL4 & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE and isnull(b.freeze,'')<>'Y' "
                SSQL4 = SSQL4 & " group by A.SLCODE,A.billdate,A.locdesc,A.loccode ORDER BY A.LOCDESC"
                SSQL5 = ""
                SSQL5 = " SELECT A.BILLNO,A.billdate,A.locdesc,A.SLCODE,sum(A.amount) as amount,A.loccode FROM HOUSE_BILL A,MEMBERMASTER B "
                SSQL5 = SSQL5 & " WHERE MONTH(BILLDATE) = " & month1 & "  "
                SSQL5 = SSQL5 & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE and isnull(b.freeze,'')<>'Y' "
                SSQL5 = SSQL5 & " group by A.SLCODE,A.billdate,A.locdesc,A.loccode,A.BILLNO"
            End If

            Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(ssql, "MAINCASHRECEIPT", r)
            Call Viewer.GetDetails1(ssql2, "DEBITNOTEPAYMENT", r)
            Call Viewer.GetDetails1(SSQL4, "ROOM_BILL", r)
            Call Viewer.GetDetails1(SSQL5, "HOUSE_BILL", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            txtobj = r.ReportDefinition.ReportObjects("Text10")
            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj.Text = txt_note.Text
            txtobj1.Text = Format(Dtp_duedate.Value, "dd/MM/yyyy")
            'txtobj2.Text = IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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
                Else
                    txt_mcode.Text = ""
                    txt_mcode.Focus()
                End If
            Else
                'txt_mcode.Text = ""
                'txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MBILL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        chk_Filter_Field.Focus()
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

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
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
                'txt_Tomcode.Text = ""
                'txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Validation()
        'boolchk = False
        'If txt_mcode.Text = "" Then
        '    MessageBox.Show(" From MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_mcode.Focus()
        '    Exit Sub
        'End If
        'If txt_Tomcode.Text = "" Then
        '    MessageBox.Show(" To MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txt_Tomcode.Focus()
        '    Exit Sub
        'End If
        boolchk = True
    End Sub

    Private Sub Dtp_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_duedate.ValueChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub txt_Tomcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tomcode.TextChanged

    End Sub
End Class
