Option Strict Off
Option Explicit On 
Imports Microsoft.VisualBasic
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.IO
Public Class MEMEBRVIEW
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5, bildt, bildt1 As String
    Dim gconnection As New GlobalClass
    Dim month1, month2, noofdays As Integer
    Dim Vconn As New GlobalClass
    Dim FormUnload As Boolean
    Dim vTotal As Double
    Dim VRowCount As Short
    Dim SideLedgerName, MemberCode, vMemAcc, vUser, vSql, gPicture, mondesc, mondesc1, HEAD, HEAD1 As String

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Public WithEvents sSgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MEMEBRVIEW))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.sSgrid = New AxFPSpreadADO.AxfpSpread
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txt_mname)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CbxMonth)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_mcode)
        Me.Panel1.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Panel1.Location = New System.Drawing.Point(24, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 48)
        Me.Panel1.TabIndex = 582
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(248, 13)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(272, 22)
        Me.txt_mname.TabIndex = 583
        Me.txt_mname.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(528, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 582
        Me.Label10.Text = "MONTH"
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(608, 11)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 581
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 578
        Me.Label3.Text = "Member Code"
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(128, 12)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(88, 22)
        Me.txt_mcode.TabIndex = 579
        Me.txt_mcode.Text = ""
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(220, 13)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemberCodeHelp.TabIndex = 580
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.sSgrid)
        Me.Panel2.Location = New System.Drawing.Point(24, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 560)
        Me.Panel2.TabIndex = 583
        '
        'sSgrid
        '
        Me.sSgrid.ContainingControl = Me
        Me.sSgrid.DataSource = Nothing
        Me.sSgrid.Location = New System.Drawing.Point(20, 7)
        Me.sSgrid.Name = "sSgrid"
        Me.sSgrid.OcxState = CType(resources.GetObject("sSgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sSgrid.Size = New System.Drawing.Size(695, 545)
        Me.sSgrid.TabIndex = 48
        '
        'Cmd_View
        '
        Me.Cmd_View.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.Location = New System.Drawing.Point(544, 40)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(88, 32)
        Me.Cmd_View.TabIndex = 584
        Me.Cmd_View.Text = "View"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 35)
        Me.Label2.TabIndex = 585
        Me.Label2.Text = "MEMBER BALANCE"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 586
        Me.Label1.Text = "Exit"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.Location = New System.Drawing.Point(632, 40)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(56, 32)
        Me.Cmd_Print.TabIndex = 587
        Me.Cmd_Print.Text = "Print"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(688, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 32)
        Me.Button1.TabIndex = 588
        Me.Button1.Text = "Export"
        '
        'MEMEBRVIEW
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 702)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "MEMEBRVIEW"
        Me.Text = "Member Balance View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
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

    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub GetOpBal()
        Dim i As Integer
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim ssql As String
        Dim a As String
        Dim b As DateTime
        Dim vReceipts, vSales As Double
        Dim vopbal As Double
        ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND VOUCHERDATE < '" & bildt & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
        Vconn.getDataSet(ssql, "Outstanding")
        If gdataset.Tables("Outstanding").Rows.Count > 0 Then
            vopbal = 0
            For i = 0 To gdataset.Tables("Outstanding").Rows.Count - 1
                If UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                    vReceipts = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                ElseIf UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "DEBIT" Then
                    vSales = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                End If
            Next
        End If
        If Month(CbxMonth.Value) = 4 Then
            vopbal = vSales - vReceipts

        Else
                vopbal = vSales - vReceipts
        End If


        ' sSgrid.SetText(1, 1, "For The Month " & mondesc & " " & Mid(gFinancalyearStart, 8, 10))
        sSgrid.SetText(1, 1, "      PARTICULARS")
        sSgrid.SetText(2, 1, "             DEBIT")
        sSgrid.SetText(3, 1, "           CREDIT")
        a = Trim(Me.txt_mcode.Text)
        b = Date.Now
        sSgrid.SetText(1, 2, " " & Trim(Me.txt_mcode.Text) & " " & Space(2) & " " & Trim(Me.txt_mname.Text) & "")
        sSgrid.SetText(2, 2, " " & Date.Now & " ")
        sSgrid.SetText(2, 3, "  ")
        'sSgrid.SetText(1, 4, "For The Month " & mondesc & " " & Mid(gFinancalyearStart, 8, 10))
        sSgrid.SetText(1, 4, "For The Month " & mondesc & " " & Mid(Year(bildt), 3, 4))
        sSgrid.SetText(1, 5, " ")
        sSgrid.SetText(2, 5, " ")
        sSgrid.SetText(3, 5, " ")
        If sSgrid.DataRowCnt = 5 Then
            If vopbal >= 0 Then

                sSgrid.SetText(1, 6, "Opening Balance  -->")
                sSgrid.SetText(2, 6, Format(vopbal, "0.00"))
                vTotal = vopbal
            ElseIf vopbal <= 0 Then
                vTotal = vopbal
                vopbal = -(vopbal)
                sSgrid.SetText(1, 6, "Opening Balance  -->")
                sSgrid.SetText(3, 6, Format(vopbal, "0.00"))
            End If
        End If
        'Call GetTotal()
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Call FillGrid1()
        sSgrid.Focus()
    End Sub
    Private Sub FillGrid1()
        Try

            Dim MainMenu As Object
        ' Dim gDebtors As Object
        Dim ADODB As Object
        Dim sstr As String
        Dim Count As Integer
        Dim loopindex, i, j, H As Integer
        'If lblmcode.Text = "" Then
        '    MsgBox("Member Code should visible", MsgBoxStyle.Critical, Me.Text)
        '    Exit Sub
        'End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 3 : month2 = 4 : mondesc = "OPL" : mondesc1 = "Apr" : noofdays = 30 : bildt = "01/APR/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 4 : month2 = 5 : mondesc = "Apr" : mondesc1 = "May" : noofdays = 31 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 5 : month2 = 6 : mondesc = "May" : mondesc1 = "Jun" : noofdays = 30 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 6 : month2 = 7 : mondesc = "Jun" : mondesc1 = "Jul" : noofdays = 31 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 7 : month2 = 8 : mondesc = "Jul" : mondesc1 = "Aug" : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 8 : month2 = 9 : mondesc = "Aug" : mondesc1 = "Sep" : noofdays = 30 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 9 : month2 = 10 : mondesc = "Sep" : mondesc1 = "Oct" : noofdays = 31 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 10 : month2 = 11 : mondesc = "Oct" : mondesc1 = "Nov" : noofdays = 30 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 11 : month2 = 12 : mondesc = "Nov" : mondesc1 = "Dec" : noofdays = 31 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 12 : month2 = 1 : mondesc = "Dec" : mondesc1 = "Jan" : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4) : bildt1 = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 1 : month2 = 2 : mondesc = "Jan" : mondesc1 = "Feb" : noofdays = 28 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 2 : month2 = 3 : mondesc = "Feb" : mondesc1 = "Mar" : noofdays = 31 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4) : bildt1 = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)


        sSgrid.ClearRange(1, 1, -1, -1, True)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        vTotal = 0
        vMemAcc = Trim(txt_mcode.Text)
        Call GetOpBal()
        j = month1
        If j > 0 Then
            sstr = "SELECT MONTH(BILLDATE)AS MONTHVALUE,SNO,CREDITDEBIT,HEADDESC,SUM(AMOUNT) AS AMOUNT FROM MEMBER_BALANCE_VIEW "
            sstr = sstr & " WHERE SLCODE = '" & Trim(vMemAcc) & "' AND MONTH(BILLDATE)IN(" & j & ") GROUP BY HEADDESC,MONTH(BILLDATE),SNO,CREDITDEBIT ORDER BY MONTH(BILLDATE),SNO"
            Vconn.getDataSet(sstr, "Journalentry")
            'If loopindex < 3 Then
            '    loopindex = 3
            'End If
            If loopindex < 7 Then
                loopindex = 7
            End If
            If gdataset.Tables("Journalentry").Rows.Count > 0 Then
                For H = 1 To 10
                    If H = 1 Then HEAD = "Subscription"
                    If H = 2 Then HEAD = "Minimum Charges"
                    If H = 3 Then HEAD = "House Bill"
                    If H = 4 Then HEAD = "Golf House Bill"
                    If H = 5 Then HEAD = "Room"
                    If H = 6 Then HEAD = "Banquet"
                    If H = 7 Then HEAD = "Other"
                    If H = 8 Then HEAD = "Receipts"
                    If H = 9 Then HEAD = "Room Cash"
                    If H = 10 Then HEAD = "Others"
                    Count = 0
                    For i = 0 To gdataset.Tables("Journalentry").Rows.Count - 1
                        ' For i = 1 To gdataset.Tables("Journalentry").Rows.Count
                        If UCase(HEAD) = UCase(Trim(gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))) Then
                            sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))
                            'sSgrid.SetText(2, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))
                            Count = Count + 1
                            HEAD1 = gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC")
                            If UCase(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                                'sSgrid.Col = 3
                                sSgrid.Col = 3
                                sSgrid.Row = loopindex
                                sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT"), "0.00")
                                vTotal = vTotal - gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT")
                            Else
                                sSgrid.Col = 2
                                sSgrid.Row = loopindex
                                sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT"), "0.00")
                                vTotal = vTotal + gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT")
                            End If
                            loopindex = loopindex + 1
                            'Exit For
                        Else
                            'sSgrid.SetText(1, loopindex, HEAD)
                            'sSgrid.Col = 2
                            'sSgrid.Row = loopindex
                            'sSgrid.Text = "0"
                            'loopindex = loopindex + 1
                        End If
                        If loopindex > 50 Then
                            sSgrid.MaxRows = sSgrid.MaxRows + 1
                        End If
                        'Count = 0
                    Next
                    If Count < 1 And HEAD <> HEAD1 Then
                        sSgrid.SetText(1, loopindex, HEAD)
                        sSgrid.Col = 2
                        sSgrid.Row = loopindex
                        sSgrid.Text = "0"
                        loopindex = loopindex + 1
                        Count = 0
                    End If
                Next
            Else
                'MsgBox("There is no Transactions", MsgBoxStyle.Information, Me.Text)
                'Me.Cursor = System.Windows.Forms.Cursors.Default
                'Exit Sub
                For H = 1 To 10
                    If H = 1 Then HEAD = "Subscription"
                    If H = 2 Then HEAD = "Minimum Charges"
                    If H = 3 Then HEAD = "House Bill"
                    If H = 4 Then HEAD = "Golf House Bill"
                    If H = 5 Then HEAD = "Room"
                    If H = 6 Then HEAD = "Banquet"
                    If H = 7 Then HEAD = "Other"
                    If H = 8 Then HEAD = "Receipts"
                    If H = 9 Then HEAD = "Room Cash"
                    If H = 10 Then HEAD = "Others"
                    sSgrid.SetText(1, loopindex, HEAD)
                    sSgrid.Col = 2
                    sSgrid.Row = loopindex
                    sSgrid.Text = "0"
                    loopindex = loopindex + 1
                    Count = 0
                Next
            End If
            sSgrid.Col = 1
            sSgrid.Row = loopindex
            If j = month1 Then
                'sSgrid.Text = "Closing Balance For " & mondesc & " " & Mid(gFinancalyearStart, 8, 10)
                sSgrid.Text = "Closing Balance For " & mondesc & " " & Mid(Year(bildt), 3, 4)
            Else
                'sSgrid.Text = "Closing Balance For " & mondesc1 & " " & Mid(gFinancalyearStart, 8, 10)
                sSgrid.Text = "Closing Balance For " & mondesc1 & " " & Mid(Year(bildt1), 3, 4)
            End If
            If vTotal >= 0 Then
                sSgrid.Col = 2
                sSgrid.Row = loopindex
                sSgrid.Text = Format(vTotal, "0.00")
            Else
                sSgrid.Col = 3
                sSgrid.Row = loopindex
                sSgrid.Text = Format(vTotal, "0.00")
            End If
            loopindex = loopindex + 2
        End If

        '======= for second month 


        j = month2
        If j > 0 Then
            sstr = "SELECT MONTH(BILLDATE)AS MONTHVALUE,SNO,CREDITDEBIT,HEADDESC,SUM(AMOUNT) AS AMOUNT FROM MEMBER_BALANCE_VIEW "
            sstr = sstr & " WHERE SLCODE = '" & Trim(vMemAcc) & "' AND MONTH(BILLDATE)IN(" & j & ") GROUP BY HEADDESC,MONTH(BILLDATE),SNO,CREDITDEBIT ORDER BY MONTH(BILLDATE),SNO"
            Vconn.getDataSet(sstr, "Journalentry")
            'If loopindex < 3 Then
            '    loopindex = 3
            'End If
            If loopindex < 7 Then
                loopindex = 7
            End If
            If gdataset.Tables("Journalentry").Rows.Count > 0 Then
                For H = 1 To 10
                    If H = 1 Then HEAD = "Subscription"
                    If H = 2 Then HEAD = "Minimum Charges"
                    If H = 3 Then HEAD = "House Bill"
                    If H = 4 Then HEAD = "Golf House Bill"
                    If H = 5 Then HEAD = "Room"
                    If H = 6 Then HEAD = "Banquet"
                    If H = 7 Then HEAD = "Other"
                    If H = 8 Then HEAD = "Receipts"
                    If H = 9 Then HEAD = "Room Cash"
                    If H = 10 Then HEAD = "Others"
                    Count = 0
                    For i = 0 To gdataset.Tables("Journalentry").Rows.Count - 1
                        ' For i = 1 To gdataset.Tables("Journalentry").Rows.Count
                        If UCase(HEAD) = UCase(Trim(gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))) Then
                            sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))
                            'sSgrid.SetText(2, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC"))
                            Count = Count + 1
                            HEAD1 = gdataset.Tables("Journalentry").Rows(i).Item("HEADDESC")
                            If UCase(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                                'sSgrid.Col = 3
                                sSgrid.Col = 3
                                sSgrid.Row = loopindex
                                sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT"), "0.00")
                                vTotal = vTotal - gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT")
                            Else
                                sSgrid.Col = 2
                                sSgrid.Row = loopindex
                                sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT"), "0.00")
                                vTotal = vTotal + gdataset.Tables("Journalentry").Rows(i).Item("AMOUNT")
                            End If
                            loopindex = loopindex + 1
                            'Exit For
                        Else
                            'sSgrid.SetText(1, loopindex, HEAD)
                            'sSgrid.Col = 2
                            'sSgrid.Row = loopindex
                            'sSgrid.Text = "0"
                            'loopindex = loopindex + 1
                        End If
                        If loopindex > 50 Then
                            sSgrid.MaxRows = sSgrid.MaxRows + 1
                        End If
                        'Count = 0
                    Next
                    If Count < 1 And HEAD <> HEAD1 Then
                        sSgrid.SetText(1, loopindex, HEAD)
                        sSgrid.Col = 2
                        sSgrid.Row = loopindex
                        sSgrid.Text = "0"
                        loopindex = loopindex + 1
                        Count = 0
                    End If
                Next
            Else
                'MsgBox("There is no Transactions", MsgBoxStyle.Information, Me.Text)
                'Me.Cursor = System.Windows.Forms.Cursors.Default
                'Exit Sub
                For H = 1 To 10
                    If H = 1 Then HEAD = "Subscription"
                    If H = 2 Then HEAD = "Minimum Charges"
                    If H = 3 Then HEAD = "House Bill"
                    If H = 4 Then HEAD = "Golf House Bill"
                    If H = 5 Then HEAD = "Room"
                    If H = 6 Then HEAD = "Banquet"
                    If H = 7 Then HEAD = "Other"
                    If H = 8 Then HEAD = "Receipts"
                    If H = 9 Then HEAD = "Room Cash"
                    If H = 10 Then HEAD = "Others"
                    sSgrid.SetText(1, loopindex, HEAD)
                    sSgrid.Col = 2
                    sSgrid.Row = loopindex
                    sSgrid.Text = "0"
                    loopindex = loopindex + 1
                    Count = 0
                Next
            End If
            sSgrid.Col = 1
            sSgrid.Row = loopindex
            If j = month1 Then
                sSgrid.Text = "Closing Balance For " & mondesc & " " & Mid(Year(bildt), 3, 4)
                'sSgrid.Text = "Closing Balance For " & mondesc & " " & Mid(gFinancalyearStart, 8, 10)
            Else
                'sSgrid.Text = "Closing Balance For " & mondesc1 & " " & Mid(gFinancalyearStart, 8, 10)
                sSgrid.Text = "Closing Balance For " & mondesc1 & " " & Mid(Year(bildt1), 3, 4)
            End If
            If vTotal >= 0 Then
                sSgrid.Col = 2
                sSgrid.Row = loopindex
                sSgrid.Text = Format(vTotal, "0.00")
            Else
                sSgrid.Col = 3
                sSgrid.Row = loopindex
                sSgrid.Text = Format(vTotal, "0.00")
            End If
            loopindex = loopindex + 2
        End If
            'Call GetTotal()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub MEMEBRVIEW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call Label1_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        ''gPrint = True
        ''If sSgrid.DataRowCnt > 0 And txt_mcode.Text <> "" Then
        ''Call Grid_DotMatirx_View()
        ''Else
        ''  MessageBox.Show("First Click View Then Print")
        ''Exit Sub
        ''End If


        With sSgrid
            If .DataRowCnt = 0 Then
                MsgBox("Grid details cannot be Blank")
                Exit Sub
            End If
            If MsgBox("Do you want to Print", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then
                Exit Sub
            End If
            Dim sstr As String
            .Row = 1
            .RowHidden = False
            .Col = 1
            .Col2 = .MaxCols
            .Row = 1
            .Row2 = .DataRowCnt
            .BlockMode = True
            .BlockMode = False
            .PrintAbortMsg = "Printing - Click Cancel to quit"
            .PrintJobName = "Room Bill"
            .PrintColHeaders = True
            .PrintRowHeaders = True

            .PrintBorder = True
            .PrintColor = True
            .PrintGrid = False
            .PrintMarginTop = 2700
            .PrintMarginBottom = 700
            .PrintMarginLeft = 750
            .PrintMarginRight = 0
            .PrintType = 0
            .PrintOrientation = 1
            .PrintRowHeaders = True
            .PrintShadows = False
            .PrintUseDataMax = True
            .Action = 32

        End With
    End Sub

    Private Sub Grid_DotMatirx_View()
        'SSGRID.ExportToTextFile("MEMLIST", 35, 35, 9999, FPSpreadADO.ExportToTextFileConstants.ExportToTextFileCreateNewFile, "TEST")
        'SSGRID.ExportRangeToTextFile(1, 1, 15, 9999, "TESTM", 1, 2, 2, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileAllHeaders, "TEST1")
        'SSGRID.ExportToExcel("MEMEXCEL", "ONE", "LOG1")
        'SSGRID.SaveToFile("MEMSAVE", True)
        Dim i, j As Int16
        Dim vpageno As Int16
        Dim vRowcnt As Integer
        Dim vstr, fields, fieldsgroup(300), Particular As String
        Dim VNETBALANCE, Damt, Camt As Double
        vpageno = 1
        Randomize()
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        Dim vcaption, Ssql As String
        vcaption = "MEMBERS BALANCE VIEW"
        Ssql = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE MCODE = '" & Trim(txt_mcode.Text) & "' "
        Vconn.getDataSet(Ssql, "MEMBER")
        Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyname & Chr(15))
        Filewrite.WriteLine(Chr(14) & Chr(15) & vcaption & Chr(15))
        Filewrite.WriteLine("Accounting Period :")
        Filewrite.Write("" & gFinancalyearStart & "  -  " & "" & gFinancialYearEnd)
        Filewrite.WriteLine(Space(67) & "Run Date :" & Format(Now, "dd-MMM-yyyy"))
        Filewrite.WriteLine(Space(106) & "Page No :" & Val(vpageno))
        Filewrite.WriteLine(gdataset.Tables("MEMBER").Rows(0).Item("MNAME") & " (" & gdataset.Tables("MEMBER").Rows(0).Item("MCODE") & ")")
        Filewrite.WriteLine(StrDup(70, "="))
        Filewrite.WriteLine(" PARTICULARS              			    DEBIT      CREDIT     ")
        Filewrite.WriteLine(StrDup(70, "="))
        vRowcnt = 10
        For i = 1 To sSgrid.DataRowCnt
            If vRowcnt > 65 Then
                Filewrite.WriteLine(StrDup(70, "="))
                Filewrite.Write(Chr(12))
                Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyname & Chr(15))
                Filewrite.WriteLine(Chr(14) & Chr(15) & vcaption & Chr(15))
                Filewrite.WriteLine("Accounting Period :")
                Filewrite.Write("" & gFinancalyearStart & "  -  " & "" & gFinancialYearEnd)
                Filewrite.WriteLine(Space(67) & "Run Date :" & Format(Now, "dd-MMM-yyyy"))
                Filewrite.WriteLine(Space(106) & "Page No :" & Val(vpageno))
                Filewrite.WriteLine(StrDup(70, "="))
                Filewrite.WriteLine(" PARTICULARS              			    DEBIT      CREDIT     ")
                Filewrite.WriteLine(StrDup(70, "="))
                vRowcnt = 9
            End If
            With sSgrid
                .Row = i
                .Col = 1
                Particular = .Text
                .Col = 2
                Damt = Val(.Text)
                .Col = 3
                Camt = Val(.Text)
                Filewrite.Write(Mid(Particular, 1, 35) & Space(35 - Len(Mid(Particular, 1, 35))) & Space(1) & "|")
                If Particular <> "" And Mid(Particular, 1, 3) <> "FOR" Then
                    Filewrite.Write(Space(14 - Len(Mid(Format(Damt, "0.00"), 1, 12))) & Mid(Format(Damt, "0.00"), 1, 12) & Space(1) & "|")
                    Filewrite.Write(Space(10 - Len(Mid(Format(Camt, "0.00"), 1, 10))) & Mid(Format(Camt, "0.00"), 1, 10) & Space(1) & "|")
                End If
                Filewrite.WriteLine("")
                vRowcnt = vRowcnt + 1
            End With
        Next
        Filewrite.WriteLine(StrDup(70, "-"))
        Filewrite.Write(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(vOutfile)
        End If
    End Sub

    Private Sub sSgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles sSgrid.Advance

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            X = sSgrid.ExportRangeToTextFile(0, 0, sSgrid.Col2, sSgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With sSgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
End Class
