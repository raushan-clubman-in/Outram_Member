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
Public Class PartyBill
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3 As String
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_AdvPayment As System.Windows.Forms.TextBox
    Friend WithEvents VoucherHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PartyBill))
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.VoucherHelp = New System.Windows.Forms.Button
        Me.txt_AdvPayment = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Todate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 35)
        Me.Label2.TabIndex = 437
        Me.Label2.Text = "PARTY BILL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.VoucherHelp)
        Me.GroupBox1.Controls.Add(Me.txt_AdvPayment)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_mname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox1.Controls.Add(Me.txt_mcode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(168, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 272)
        Me.GroupBox1.TabIndex = 587
        Me.GroupBox1.TabStop = False
        '
        'VoucherHelp
        '
        Me.VoucherHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.VoucherHelp.Image = CType(resources.GetObject("VoucherHelp.Image"), System.Drawing.Image)
        Me.VoucherHelp.Location = New System.Drawing.Point(424, 128)
        Me.VoucherHelp.Name = "VoucherHelp"
        Me.VoucherHelp.Size = New System.Drawing.Size(24, 20)
        Me.VoucherHelp.TabIndex = 593
        '
        'txt_AdvPayment
        '
        Me.txt_AdvPayment.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AdvPayment.Location = New System.Drawing.Point(244, 128)
        Me.txt_AdvPayment.Name = "txt_AdvPayment"
        Me.txt_AdvPayment.Size = New System.Drawing.Size(168, 22)
        Me.txt_AdvPayment.TabIndex = 592
        Me.txt_AdvPayment.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 16)
        Me.Label5.TabIndex = 591
        Me.Label5.Text = "Advance Voucher Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Todate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Fromdate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 88)
        Me.GroupBox2.TabIndex = 590
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PARTY DATE"
        '
        'Todate
        '
        Me.Todate.CalendarMonthBackground = System.Drawing.Color.White
        Me.Todate.CustomFormat = "MMMMM"
        Me.Todate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Todate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Todate.Location = New System.Drawing.Point(328, 48)
        Me.Todate.Name = "Todate"
        Me.Todate.Size = New System.Drawing.Size(152, 26)
        Me.Todate.TabIndex = 590
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 22)
        Me.Label4.TabIndex = 589
        Me.Label4.Text = "TO"
        '
        'Fromdate
        '
        Me.Fromdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.Fromdate.CustomFormat = "MMMMM"
        Me.Fromdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fromdate.Location = New System.Drawing.Point(88, 48)
        Me.Fromdate.Name = "Fromdate"
        Me.Fromdate.Size = New System.Drawing.Size(152, 26)
        Me.Fromdate.TabIndex = 588
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 22)
        Me.Label10.TabIndex = 587
        Me.Label10.Text = "FROM"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(244, 87)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(168, 22)
        Me.txt_mname.TabIndex = 589
        Me.txt_mname.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 588
        Me.Label1.Text = "Member Name"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(428, 36)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemberCodeHelp.TabIndex = 587
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(244, 38)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(168, 22)
        Me.txt_mcode.TabIndex = 586
        Me.txt_mcode.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 585
        Me.Label3.Text = "Member Code"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmd_Exit)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.cmd_view)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Location = New System.Drawing.Point(168, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox3.TabIndex = 588
        Me.GroupBox3.TabStop = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.Location = New System.Drawing.Point(304, 13)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 579
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(296, 21)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(108, 30)
        Me.Label42.TabIndex = 580
        Me.Label42.Text = "Label42"
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(136, 13)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 577
        Me.cmd_view.Text = "View [F8]"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(128, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(108, 30)
        Me.Label29.TabIndex = 578
        Me.Label29.Text = "Label29"
        '
        'PartyBill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(856, 470)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PartyBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PartyBill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    'cmd_view.Focus()
                Else
                    txt_mcode.Text = ""
                    txt_mcode.Focus()
                End If
            Else
                txt_mcode.Text = ""
                txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Validation()
        boolchk = False
        If txt_mcode.Text = "" Then
            MessageBox.Show(" From MCode can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_mcode.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Dim Fmonth, Tmonth As String
        Fmonth = Format(Fromdate.Value, "dd/MMM/yyyy")
        Tmonth = Format(Todate.Value, "dd/MMM/yyyy")
        Call Validation()
        If boolchk = False Then Exit Sub

        'SSQL3 = "SELECT SLCODE,(SUM(DEBIT)-SUM(CREDIT)) AS AMOUNT FROM OPENINGBAL WHERE MONTH(BILLDATE) < " & month1 & " GROUP BY SLCODE"
        'gconnection.getDataSet(SSQL3, "OPL")
        'If gdataset.Tables("OPL").Rows.Count > 0 Then
        '    opl = gdataset.Tables("OPL").Rows(0).Item("AMOUNT")
        'End If

        Dim Viewer As New ReportViwer
        Dim r As New MonthlyPartyBill

        ssql1 = "SELECT BILLDETAILS,KOTDATE,MCODE,MNAME,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTPIN FROM PARTY_BILL WHERE MCODE = '" & txt_mcode.Text & "' AND CAST(CONVERT(VARCHAR,KOTDATE,106) AS DATETIME) BETWEEN '" & Fmonth & "' AND '" & Tmonth & "' GROUP BY KOTDATE,BILLDETAILS,MCODE,MNAME,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTPIN"
        sqlstring = "SELECT * FROM PARTY_BILL WHERE MCODE = '" & txt_mcode.Text & "' AND CAST(CONVERT(VARCHAR,KOTDATE,106) AS DATETIME) BETWEEN '" & Fmonth & "' AND '" & Tmonth & "' ORDER BY BILLDETAILS,KOTDATE,ITEMDESC"
        'sqlstring1 = "SELECT * FROM PARTY_BILLTAX WHERE MCODE = '" & txt_mcode.Text & "' AND MONTH(KOTDATE) BETWEEN " & Fmonth & " AND " & Tmonth & ""
        sqlstring1 = "SELECT KOTDATE,BILLDETAILS,MCODE,SUM(ISNULL(SERVICETAX,0)) AS SERVICETAX,SUM(ISNULL(SALESTAX,0)) AS SALESTAX FROM FINAL_PARTY_BILLTAX WHERE MCODE = '" & txt_mcode.Text & "' AND CAST(CONVERT(VARCHAR,KOTDATE,106) AS DATETIME) BETWEEN '" & Fmonth & "' AND '" & Tmonth & "' GROUP BY KOTDATE,BILLDETAILS,MCODE"
        ssql2 = "SELECT * FROM HALL_CHARGE WHERE MCODE = '" & txt_mcode.Text & "' AND CAST(CONVERT(VARCHAR,KOTDATE,106) AS DATETIME) BETWEEN '" & Fmonth & "' AND '" & Tmonth & "'"
        SSQL3 = "SELECT SLCODE,VOUCHERNO,AMOUNT FROM VOUCHERNUMBER WHERE VOUCHERNO = '" & txt_AdvPayment.Text & "' AND SLCODE = '" & txt_mcode.Text & "'"


        Call Viewer.GetDetails1(ssql1, "PARTY_MEMBER", r)
        Call Viewer.GetDetails1(sqlstring, "PARTY_BILL", r)
        Call Viewer.GetDetails1(sqlstring1, "FINAL_PARTY_BILLTAX", r)
        Call Viewer.GetDetails1(ssql2, "HALL_CHARGE", r)
        Call Viewer.GetDetails1(SSQL3, "PARTY_ADV", r)

        Viewer.Show()

        'Dim txtobj As TextObject
        'txtobj = r.ReportDefinition.ReportObjects("Text10")
        'txtobj.Text = "Company Name: -" & MyCompanyName & Space(120) & "01-04-" & gFinancalyearStart & " To " & "31-03-" & gFinancialYearEnd & Space(10) & "User Name: -" & gUsername

    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub


    Private Sub VoucherHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT VOUCHERNO,VOUCHERDATE,SLCODE,CASHBANK,INSTRUMENTNO FROM VOUCHERNUMBER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "VOUCHERNO,VOUCHERDATE,SLCODE,CASHBANK,INSTRUMENTNO"
        vform.vFormatstring = "     VOUCHERNO    |     VOUCHERDATE       |   SLCODE              |   CASHBANK         | INSTRUMENTNO         "
        vform.vCaption = "VOUCHER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_AdvPayment.Text = Trim(vform.keyfield & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_AdvPayment_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_AdvPayment.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT VOUCHERNO,SLCODE,CASHBANK,INSTRUMENTNO FROM VOUCHERNUMBER WHERE VOUCHERNO='" & Trim(txt_AdvPayment.Text) & "'"
                gconnection.getDataSet(sqlstring, "VOUCHER")
                If gdataset.Tables("VOUCHER").Rows.Count > 0 Then
                    txt_AdvPayment.Text = Trim(gdataset.Tables("VOUCHER").Rows(0).Item("VOUCHERNO"))
                Else
                    txt_AdvPayment.Text = ""
                    txt_AdvPayment.Focus()
                End If
            Else
                txt_AdvPayment.Text = ""
                txt_AdvPayment.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_AdvPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_AdvPayment.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_AdvPayment.Text) = "" Then
                Call VoucherHelp_Click(sender, e)
            Else
                txt_AdvPayment_Validated(sender, e)
            End If
        End If
    End Sub
End Class
