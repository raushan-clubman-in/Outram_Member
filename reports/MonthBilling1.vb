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
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class MonthBilling1
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, sqlstring2, sqlstring3, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5, ssql6, bildt, bildt1 As String
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim posting, posting1, dt As New DataTable
    Dim GCONN As New GlobalClass

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
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Rnd_Summary As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitWise As System.Windows.Forms.TextBox
    Friend WithEvents chk_PrintAllUnitWise As System.Windows.Forms.CheckBox
    Friend WithEvents chk_UnitWise As System.Windows.Forms.CheckedListBox
    Friend WithEvents Gbx_summardet As System.Windows.Forms.GroupBox
    Friend WithEvents Rnd_summardet As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Excel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_print As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MonthBilling1))
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.DTPduedate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Rnd_Summary = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_Excel = New System.Windows.Forms.Button
        Me.txt_note = New System.Windows.Forms.TextBox
        Me.txtUnitWise = New System.Windows.Forms.TextBox
        Me.chk_PrintAllUnitWise = New System.Windows.Forms.CheckBox
        Me.chk_UnitWise = New System.Windows.Forms.CheckedListBox
        Me.Gbx_summardet = New System.Windows.Forms.GroupBox
        Me.Rnd_summardet = New System.Windows.Forms.RadioButton
        Me.dtp_print = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.Gbx_summardet.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.Location = New System.Drawing.Point(192, 16)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 12
        Me.cmd_view.Text = "XML [F9]"
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Image = CType(resources.GetObject("Btn_close.Image"), System.Drawing.Image)
        Me.Btn_close.Location = New System.Drawing.Point(304, 16)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(80, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(216, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 602
        Me.Label10.Text = "SELECT MONTH  : "
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(320, 64)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 24)
        Me.CbxMonth.TabIndex = 601
        '
        'DTPduedate
        '
        Me.DTPduedate.CustomFormat = "dd/MM/yyyy"
        Me.DTPduedate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPduedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPduedate.Location = New System.Drawing.Point(184, 128)
        Me.DTPduedate.Name = "DTPduedate"
        Me.DTPduedate.Size = New System.Drawing.Size(144, 24)
        Me.DTPduedate.TabIndex = 626
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "DUE DATE"
        '
        'Rnd_Summary
        '
        Me.Rnd_Summary.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Summary.Checked = True
        Me.Rnd_Summary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Summary.Location = New System.Drawing.Point(248, 16)
        Me.Rnd_Summary.Name = "Rnd_Summary"
        Me.Rnd_Summary.TabIndex = 628
        Me.Rnd_Summary.TabStop = True
        Me.Rnd_Summary.Text = "Bill"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_Clear)
        Me.GroupBox4.Controls.Add(Me.cmd_view)
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_Excel)
        Me.GroupBox4.Location = New System.Drawing.Point(96, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(584, 64)
        Me.GroupBox4.TabIndex = 629
        Me.GroupBox4.TabStop = False
        '
        'Btn_Excel
        '
        Me.Btn_Excel.BackgroundImage = CType(resources.GetObject("Btn_Excel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Excel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.ForeColor = System.Drawing.Color.White
        Me.Btn_Excel.Location = New System.Drawing.Point(416, 16)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Excel.TabIndex = 639
        Me.Btn_Excel.Text = "Excel[F12]"
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(648, 528)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(16, 32)
        Me.txt_note.TabIndex = 630
        Me.txt_note.Text = ""
        Me.txt_note.Visible = False
        '
        'txtUnitWise
        '
        Me.txtUnitWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitWise.Location = New System.Drawing.Point(856, 312)
        Me.txtUnitWise.Name = "txtUnitWise"
        Me.txtUnitWise.Size = New System.Drawing.Size(8, 21)
        Me.txtUnitWise.TabIndex = 636
        Me.txtUnitWise.Text = ""
        Me.txtUnitWise.Visible = False
        '
        'chk_PrintAllUnitWise
        '
        Me.chk_PrintAllUnitWise.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAllUnitWise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAllUnitWise.Location = New System.Drawing.Point(816, 104)
        Me.chk_PrintAllUnitWise.Name = "chk_PrintAllUnitWise"
        Me.chk_PrintAllUnitWise.Size = New System.Drawing.Size(8, 16)
        Me.chk_PrintAllUnitWise.TabIndex = 635
        Me.chk_PrintAllUnitWise.Text = "Print All Unit Wise"
        Me.chk_PrintAllUnitWise.Visible = False
        '
        'chk_UnitWise
        '
        Me.chk_UnitWise.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_UnitWise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_UnitWise.Location = New System.Drawing.Point(864, 128)
        Me.chk_UnitWise.Name = "chk_UnitWise"
        Me.chk_UnitWise.Size = New System.Drawing.Size(8, 194)
        Me.chk_UnitWise.Sorted = True
        Me.chk_UnitWise.TabIndex = 634
        Me.chk_UnitWise.Visible = False
        '
        'Gbx_summardet
        '
        Me.Gbx_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Summary)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_summardet)
        Me.Gbx_summardet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_summardet.Location = New System.Drawing.Point(96, 160)
        Me.Gbx_summardet.Name = "Gbx_summardet"
        Me.Gbx_summardet.Size = New System.Drawing.Size(584, 96)
        Me.Gbx_summardet.TabIndex = 637
        Me.Gbx_summardet.TabStop = False
        Me.Gbx_summardet.Text = "PRINT DETAILS"
        '
        'Rnd_summardet
        '
        Me.Rnd_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_summardet.Checked = True
        Me.Rnd_summardet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_summardet.Location = New System.Drawing.Point(248, 48)
        Me.Rnd_summardet.Name = "Rnd_summardet"
        Me.Rnd_summardet.Size = New System.Drawing.Size(184, 32)
        Me.Rnd_summardet.TabIndex = 632
        Me.Rnd_summardet.TabStop = True
        Me.Rnd_summardet.Text = "Member Details"
        '
        'dtp_print
        '
        Me.dtp_print.CustomFormat = "dd/MM/yyyy"
        Me.dtp_print.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_print.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_print.Location = New System.Drawing.Point(464, 128)
        Me.dtp_print.Name = "dtp_print"
        Me.dtp_print.Size = New System.Drawing.Size(144, 24)
        Me.dtp_print.TabIndex = 638
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 639
        Me.Label1.Text = "PRINT DATE"
        '
        'MonthBilling1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 374)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_print)
        Me.Controls.Add(Me.txtUnitWise)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_PrintAllUnitWise)
        Me.Controls.Add(Me.chk_UnitWise)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DTPduedate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Gbx_summardet)
        Me.Name = "MonthBilling1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonthBilling"
        Me.GroupBox4.ResumeLayout(False)
        Me.Gbx_summardet.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
      
            Call Xml()
       
   
    End Sub
   
    Private Sub Xml()
  
        Dim XMLSTR, tempstr, tempstr1, tempstr2 As String
        Randomize()
        AppPath = Application.StartupPath
        Dim cmdText, vSql As String
        Dim I As Integer
        Dim total, total1 As Double
        Dim dr, dr1, dr2, dr4 As DataRow
        Dim duedate, membertype, TYPE(0), month2 As String

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "04" : month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/apr/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "05" : month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "06" : month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "07" : month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "08" : month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "09" : month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "10" : month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "11" : month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "12" : month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "01" : month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "02" : month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "28/feb/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "03" : month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/mar/" & Mid(gFinancialYearEnd, 7, 4)

        VFilePath = AppPath & "\Reports\" & vOutfile & ".Xml"

        If File.Exists(VFilePath) = True Then
            File.Delete(VFilePath)
        End If
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        'for new one
        If Rnd_Summary.Checked = True Then
            vSql = "EXEC MONTH_SUMMARY_BILL  " & "'" & bildt & "','" & bildt1 & "','" & Format(DTPduedate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_print.Value, "dd-MMM-yyyy") & "'"
            GCONN.GetValues(vSql)

            sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.MNAME,'')AS MNAME,ISNULL(A.BILLFROMDATE,'') AS BILLFROMDATE,ISNULL(A.BILLTODATE,'') AS BILLTODATE,ISNULL(A.DUEDATE,'') AS DUEDATE,ISNULL(A.BILLPRINTDATE,'') AS PRINTDATE,ISNULL(A.OPENING,0) AS OPENING,ISNULL(A.USAGE,0) AS USAGE FROM MONTHSUMMARY_MBCBILL A,MEMBERMASTER M WHERE A.MCODE=M.MCODE "
            gconnection.getDataSet(sqlstring, "membermaster")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                XMLSTR = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?>" + Environment.NewLine

                XMLSTR = XMLSTR & " <bill>" + Environment.NewLine
                XMLSTR = XMLSTR & " <clubname>" & Replace(MyCompanyName, "&", " AND ") & "</clubname>" + Environment.NewLine
                XMLSTR = XMLSTR & " <address>" & Replace(Address1, "&", " AND ") & "</address>" + Environment.NewLine
                If Address2 <> "" Then
                    XMLSTR = XMLSTR & " <city>" & Replace(Address2, "&", " AND ") & "</city>" + Environment.NewLine
                Else '
                    XMLSTR = XMLSTR & " <city>NIL</city>" + Environment.NewLine
                End If
                tempstr = "MEMBER BILL FOR THE  MONTH " & CbxMonth.Text & " - " & Year(bildt)
                'XMLSTR = XMLSTR & " <title>" & tempstr & "</title>" + Environment.NewLine

                Dim NetPayable As Double
                For Each dr In gdataset.Tables("MEMBERMASTER").Rows
                    XMLSTR = XMLSTR & " <member>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <membernumber>" & Trim(Mid(dr("MCODE"), 1, 8)) & "</membernumber>" + Environment.NewLine
                    '                        tempstr = dr("MCODE") & "/" & Format(CDate(bildt), "MMM") & "/" & Format(CDate(bildt), "yyyy")

                    'tempstr = Format(dr("BILLNUMBER"), "0")

                    'XMLSTR = XMLSTR & " <billnumber>Bill No. : " & tempstr & "</billnumber>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <membername>" & Replace(Trim(Mid(dr("MNAME"), 1, 30)), "&", " AND ") & "</membername>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <billfromdate>" & Replace(Trim(Mid(dr("billfromdate"), 1, 30)), "&", " AND ") & "</billfromdate>" + Environment.NewLine

                    XMLSTR = XMLSTR & " <billtodate>" & Replace(Trim(Mid(dr("billtodate"), 1, 30)), "&", " AND ") & "</billtodate>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <billprintdate>" & Replace(Trim(Mid(dr("printdate"), 1, 50)), "&", " AND ") & "</billprintdate>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <duedate>" & Replace(Trim(Mid(dr("duedate"), 1, 50)), "&", " AND ") & "</duedate>" + Environment.NewLine
                    total = Val(dr("opening")) + Val(dr("usage"))

                    XMLSTR = XMLSTR & " <total>" & total & "</total>" + Environment.NewLine
                   


                    XMLSTR = XMLSTR & "  </member>" + Environment.NewLine
                    'XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
                    Filewrite.WriteLine(XMLSTR)
                    XMLSTR = ""
                Next

                XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
                Filewrite.WriteLine(XMLSTR)
            End If
        Else
            'vSql = "EXEC MONTH_SUMMARY_BILL  " & "'" & bildt & "','" & bildt1 & "','" & Format(DTPduedate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_print.Value, "dd-MMM-yyyy") & "'"
            'GCONN.GetValues(vSql)

            sqlstring = "SELECT * FROM MEMBER_EXPORT"
            gconnection.getDataSet(sqlstring, "membermaster")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                XMLSTR = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?>" + Environment.NewLine

                XMLSTR = XMLSTR & " <bill>" + Environment.NewLine
                XMLSTR = XMLSTR & " <clubname>" & Replace(MyCompanyName, "&", " AND ") & "</clubname>" + Environment.NewLine
                XMLSTR = XMLSTR & " <address>" & Replace(Address1, "&", " AND ") & "</address>" + Environment.NewLine
                If Address2 <> "" Then
                    XMLSTR = XMLSTR & " <city>" & Replace(Address2, "&", " AND ") & "</city>" + Environment.NewLine
                Else '
                    XMLSTR = XMLSTR & " <city>NIL</city>" + Environment.NewLine
                End If
                tempstr = "MEMBER DETAILS"
                'XMLSTR = XMLSTR & " <title>" & tempstr & "</title>" + Environment.NewLine

                Dim NetPayable As Double
                For Each dr In gdataset.Tables("MEMBERMASTER").Rows
                    XMLSTR = XMLSTR & " <member>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <membernumber>" & Trim(Mid(dr("MCODE"), 1, 8)) & "</membernumber>" + Environment.NewLine
                    '                        tempstr = dr("MCODE") & "/" & Format(CDate(bildt), "MMM") & "/" & Format(CDate(bildt), "yyyy")

                    'tempstr = Format(dr("BILLNUMBER"), "0")

                    'XMLSTR = XMLSTR & " <billnumber>Bill No. : " & tempstr & "</billnumber>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <membername>" & Replace(Trim(Mid(dr("MNAME"), 1, 30)), "&", " AND ") & "</membername>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <dob>" & Replace(Trim(Mid(dr("dob"), 1, 30)), "&", " AND ") & "</dob>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <mobile>" & Replace(Trim(Mid(dr("contcell"), 1, 50)), "&", " AND ") & "</mobile>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <email>" & Replace(Trim(Mid(dr("contemail"), 1, 50)), "&", " AND ") & "</email>" + Environment.NewLine
                  
                    XMLSTR = XMLSTR & "  </member>" + Environment.NewLine
                    'XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
                    Filewrite.WriteLine(XMLSTR)
                    XMLSTR = ""
                Next

                XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
                Filewrite.WriteLine(XMLSTR)
            End If
        End If

        '                Filewrite.WriteLine("over")
        Filewrite.Close()

        If gPrint = False Then
            OpenTextFileXML(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If

        Exit Sub


    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub

    Private Sub MonthBilling1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
 
    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        If Rnd_Summary.Checked = True Then
            Dim cmdText, note As String
            cmdText = "Select * From VW_UNITWISE_MEMBER"
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Dim unit(0) As String
            Dim unitno As String
            Dim ranklist As String
            Dim dr, dr1, dr2, dr4 As DataRow
            'Call Validation()

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "04" : month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "05" : month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "06" : month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "07" : month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "08" : month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "09" : month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "10" : month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "11" : month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "30/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then vOutfile = Mid(gFinancialyearStart, 7, 4) & "12" : month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "31/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "01" : month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/jan/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "02" : month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "28/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then vOutfile = Mid(gFinancialYearEnd, 7, 4) & "03" : month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "31/mar/" & Mid(gFinancialYearEnd, 7, 4)

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
            Dim ssql, VSQL As String
            vSql = "EXEC MONTH_SUMMARY_BILL  " & "'" & bildt & "','" & bildt1 & "','" & Format(DTPduedate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_print.Value, "dd-MMM-yyyy") & "'"
            GCONN.GetValues(vSql)

            Try
                Dim _export As New EXPORT
                Dim SQLSTR As String

                SQLSTR = "SELECT * FROM MM_VIEW_MONTHBILL"
                _export.TABLENAME = "MM_VIEW_MONTHBILL"
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
           
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Dim unit(0) As String
            Dim unitno As String
            Dim ranklist As String
            Dim dr, dr1, dr2, dr4 As DataRow
            'Call Validation()
            Dim ssql As String
            Try
                Dim _export As New EXPORT
                Dim SQLSTR As String
                SQLSTR = "SELECT * FROM MEMBER_EXPORT"
                _export.TABLENAME = "MEMBER_EXPORT"
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
      
    End Sub




End Class
