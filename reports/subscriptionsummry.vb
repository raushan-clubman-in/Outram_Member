Imports System.Data.SqlClient
Imports System.IO
Public Class subscriptionsummry
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents ChkList_month As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents rdsummary As System.Windows.Forms.RadioButton
    Friend WithEvents rddetails As System.Windows.Forms.RadioButton
    Friend WithEvents RdMember As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(subscriptionsummry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rddetails = New System.Windows.Forms.RadioButton
        Me.rdsummary = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_year = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.ChkList_month = New System.Windows.Forms.CheckedListBox
        Me.RdMember = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rddetails)
        Me.GroupBox1.Controls.Add(Me.rdsummary)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_year)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.RdMember)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 441)
        Me.GroupBox1.TabIndex = 389
        Me.GroupBox1.TabStop = False
        '
        'rddetails
        '
        Me.rddetails.BackColor = System.Drawing.Color.Transparent
        Me.rddetails.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rddetails.Location = New System.Drawing.Point(464, 404)
        Me.rddetails.Name = "rddetails"
        Me.rddetails.Size = New System.Drawing.Size(104, 32)
        Me.rddetails.TabIndex = 368
        Me.rddetails.Text = "DETAILS"
        '
        'rdsummary
        '
        Me.rdsummary.BackColor = System.Drawing.Color.Transparent
        Me.rdsummary.Checked = True
        Me.rdsummary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdsummary.Location = New System.Drawing.Point(320, 408)
        Me.rdsummary.Name = "rdsummary"
        Me.rdsummary.Size = New System.Drawing.Size(136, 24)
        Me.rdsummary.TabIndex = 367
        Me.rdsummary.TabStop = True
        Me.rdsummary.Text = "SUMMARY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 358
        Me.Label1.Text = "POSTING DATE"
        Me.Label1.Visible = False
        '
        'dtp_year
        '
        Me.dtp_year.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_year.CustomFormat = "yyyy"
        Me.dtp_year.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_year.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_year.Location = New System.Drawing.Point(336, 25)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(112, 26)
        Me.dtp_year.TabIndex = 0
        Me.dtp_year.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox3.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbo_BillingBasis)
        Me.GroupBox3.Controls.Add(Me.ChkList_month)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 360)
        Me.GroupBox3.TabIndex = 364
        Me.GroupBox3.TabStop = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(16, 32)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(164, 23)
        Me.chk_PrintAll.TabIndex = 427
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.AntiqueWhite
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(8, 57)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(296, 256)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 386
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 362
        Me.Label4.Text = "Type of Posting"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(319, 54)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(312, 27)
        Me.cbo_BillingBasis.TabIndex = 1
        '
        'ChkList_month
        '
        Me.ChkList_month.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ChkList_month.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_month.Location = New System.Drawing.Point(320, 81)
        Me.ChkList_month.Name = "ChkList_month"
        Me.ChkList_month.Size = New System.Drawing.Size(312, 235)
        Me.ChkList_month.TabIndex = 2
        '
        'RdMember
        '
        Me.RdMember.Checked = True
        Me.RdMember.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdMember.Location = New System.Drawing.Point(96, 408)
        Me.RdMember.Name = "RdMember"
        Me.RdMember.Size = New System.Drawing.Size(192, 24)
        Me.RdMember.TabIndex = 369
        Me.RdMember.TabStop = True
        Me.RdMember.Text = "MEMBER SUMMARY"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(359, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(393, 32)
        Me.Label6.TabIndex = 387
        Me.Label6.Text = "SUBSCRIPTION SUMMARY"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(168, 560)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 56)
        Me.GroupBox2.TabIndex = 390
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(288, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 6
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(424, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 7
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(160, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(32, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 4
        Me.CmdView.Text = "View[F9]"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Menu
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(560, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "EXPORT"
        '
        'subscriptionsummry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(960, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "subscriptionsummry"
        Me.Text = "Subscription Summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlString, chk_month As String
    Public sqlStringFinal, DispString, membertype As String
    Dim iNumber, row, PageSize, PageNo As Integer
    Dim billno As Long
    Dim addFltrStr, FltrStr As String
    Public TempString(2), bill, catecode As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype, Vcatefile, sout, rout As String
    Dim subsummary, memd, posting As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Processed_Chk(4) As Integer
    Private Sub subscriptionsummry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call DETAILS()
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
        Me.cmdPrint.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub DETAILS()
        Dim i As Long
        posting = Nothing
        chk_PrintAll.Checked = False
        cbo_BillingBasis.Items.Clear()
        Try
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gconnection.closeConnection()
        dtp_year.Focus()
        cbo_BillingBasis.SelectedIndex = 0
        sqlString = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        posting = gconnection.GetValues(sqlString)
        chk_Filter_Field.Items.Clear()
        If posting.Rows.Count > 1 Then
            For i = 0 To (posting.Rows.Count - 1)
                chk_Filter_Field.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
            Next
        End If
    End Sub
    Private Sub dtp_year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_year.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub ChkList_type_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub fillpostingtype()
        ChkList_month.Items.Clear()
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select isnull(postingsno,0) as postingsno, isnull(POSTINGCODE,'') AS POSTINGTYPE,ISNULL(POSTINGDESC,'') as postingdesc,isnull(postingsno,0) as postingsno "
            sqlString = sqlString & " from postingmast where  isnull(postingcode,'')='" & Me.cbo_BillingBasis.Text & "' order by postingsno"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    ChkList_month.Items.Add(posting.Rows(i).Item("POSTINGSNO") & "." & posting.Rows(i).Item("POSTINGDESC"))
                Next
            Else
                ChkList_month.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub dtp_year_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_year.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub subscriptionsummry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call cmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        If RdMember.Checked = True Then
            Call subsmember()
        Else
            If rdsummary.Checked = True Then
                Call subssummary()
            Else
                Call subsdetails()
            End If
        End If
    End Sub
    Private Sub subsdetails()
        Dim sqlstring, sqlstring1, postingsno, postingsdesc As String
        Dim CHK As Boolean
        Dim subsamt, taxamt, tsubsamt, ttaxamt As Double
        Dim i, j, sno As Integer
        Dim NEWMCODE, adddet(5), PRESENTMCODE As String
        Dim Hedd1 As String
        Dim addFilterStr2 As String
        membertype = ""
        postingsno = ""
        Try
            If chk_Filter_Field.SelectedIndex < 0 Then
                MessageBox.Show(" ", "Club", MessageBoxButtons.OK)
                Exit Sub
            End If

            If ChkList_month.SelectedIndex < 0 Then
                MessageBox.Show("Please Select Month", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If membertype = "" Then
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = "('" & TempString(0)
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = membertype & "','" & TempString(0)
                End If
            Next i
            membertype = membertype & "')"
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If postingsno = "" Then
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = "('" & TempString(0)
                    postingsdesc = TempString(1)
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = postingsno & "','" & TempString(0)
                    postingsdesc = postingsdesc & "," & TempString(1)
                End If
            Next i
            postingsno = postingsno & "')"
            Randomize()
            vOutfile = Mid("ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            sqlstring = "select isnull(mcode,'') as mcode,period "
            sqlstring = sqlstring & " from subsposting  where postingsno in " & postingsno & " and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
            sqlstring = sqlstring & " and membertype in " & membertype & " group by mcode,period order by mcode"
            memd = gconnection.GetValues(sqlstring)
            If memd.Rows.Count > 0 Then
                PageSize = 0
                PageNo = 1
                Filewrite.WriteLine()
                Filewrite.WriteLine(Mid(gCompanyAddress(0), 1, 50) & Space(50 - Len(Mid(gCompanyAddress(0), 1, 50))))
                'Filewrite.WriteLine("Subscription Summary Report From :" & memd.Rows(0).Item("Period") & Space(30) & "Page No :" & Trim(PageNo))
                Filewrite.WriteLine("Subscription Summary Report For :" & postingsdesc & Space(30) & "Page No :" & Trim(PageNo))
                Filewrite.WriteLine("======================================================================================================================")
                Filewrite.WriteLine(" Sno    Mcode          Mname                    MemberCategory            Subscription Type              Amount       ")
                Filewrite.WriteLine("======================================================================================================================")
                sno = 1
                For i = 0 To memd.Rows.Count - 1
                    If PageSize > 55 Then
                        PageNo = PageNo + 1
                        Filewrite.WriteLine("======================================================================================================================")
                        Filewrite.WriteLine(Chr(12))
                        Filewrite.WriteLine(Mid(gCompanyAddress(0), 1, 50) & Space(50 - Len(Mid(gCompanyAddress(0), 1, 50))))
                        Filewrite.WriteLine("Subscription Summary Report From :" & memd.Rows(0).Item("Period") & Space(30) & "Page No :" & Trim(PageNo))
                        Filewrite.WriteLine("======================================================================================================================")
                        Filewrite.WriteLine(" Sno    Mcode          Mname                    MemberCategory            Subscription Type              Amount       ")
                        Filewrite.WriteLine("======================================================================================================================")
                        PageSize = 0
                    End If
                    sqlstring = " select isnull(a.mcode,'') as mcode,isnull(d.mname,'') as mname,"
                    sqlstring = sqlstring & " isnull(a.membertype,'') as membertype,isnull(d.CurentStatus,'') as CurentStatus,isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,"
                    sqlstring = sqlstring & " isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,isnull(a.taxcode,'') as taxcode, "
                    sqlstring = sqlstring & " isnull(a.billingbasis,'') as billingbasis,isnull(a.amount,0) as amount,isnull(a.taxamount,0) as taxamount,isnull(a.period,'') as period "
                    sqlstring = sqlstring & " from subsposting a,membertype b,subscriptionmast c,membermaster d "
                    sqlstring = sqlstring & " where a.mcode= '" & memd.Rows(i).Item("mcode") & "' and a.mcode=d.mcode"
                    sqlstring = sqlstring & " and a.membertype=b.membertype and a.subscode=c.subscode"
                    sqlstring = sqlstring & " and a.postingsno in " & postingsno & " and a.postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
                    sqlstring = sqlstring & " and a.membertype in " & membertype & ""
                    sqlstring = sqlstring & " order by a.mcode"
                    subsummary = gconnection.GetValues(sqlstring)
                    If subsummary.Rows.Count > 0 Then
                        sqlstring = Space(1) & Mid(sno, 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & Space(2) & Mid(Trim(subsummary.Rows(0).Item("mcode")), 1, 7) & Space(7 - Len(Mid(Trim(subsummary.Rows(0).Item("mcode")), 1, 7)))
                        sqlstring = sqlstring & Space(2) & Mid(Trim(subsummary.Rows(0).Item("mname")), 1, 30) & Space(30 - Len(Mid(Trim(subsummary.Rows(0).Item("mname")), 1, 30)))
                        sqlstring = sqlstring & Space(2) & Mid(Trim(subsummary.Rows(0).Item("typedesc")), 1, 25) & Space(25 - Len(Mid(Trim(subsummary.Rows(0).Item("typedesc")), 1, 25)))
                        For j = 0 To subsummary.Rows.Count - 1
                            sqlstring = sqlstring & Space(2) & Mid(Trim(subsummary.Rows(j).Item("subsdesc")), 1, 25) & Space(30 - Len(Mid(Trim(subsummary.Rows(j).Item("subsdesc")), 1, 25)))
                            sqlstring = sqlstring & Space(2) & Space(12 - Len(Mid(Format(Val(subsummary.Rows(j).Item("amount")), "0.00"), 1, 12))) & Mid(Format(Val(subsummary.Rows(j).Item("amount")), "0.00"), 1, 12)
                            taxamt = taxamt + Val(subsummary.Rows(j).Item("taxamount"))
                            subsamt = subsamt + Val(subsummary.Rows(j).Item("amount"))
                            ttaxamt = ttaxamt + Val(subsummary.Rows(j).Item("taxamount"))
                            tsubsamt = tsubsamt + Val(subsummary.Rows(j).Item("amount"))
                            Filewrite.WriteLine(sqlstring)
                            sqlstring = Space(73)
                            PageSize = PageSize + 1
                            If PageSize > 55 Then
                                PageNo = PageNo + 1
                                Filewrite.WriteLine("======================================================================================================================")
                                Filewrite.WriteLine(Chr(12))
                                Filewrite.WriteLine(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))))
                                Filewrite.WriteLine("Subscription Summary Report From :" & memd.Rows(0).Item("Period") & Space(30) & "Page No :" & Trim(PageNo))
                                Filewrite.WriteLine("======================================================================================================================")
                                Filewrite.WriteLine(" Sno    Mcode          Mname                    MemberCategory            Subscription Type              Amount       ")
                                Filewrite.WriteLine("======================================================================================================================")
                                PageSize = 0
                            End If
                        Next
                        sno = sno + 1
                        sqlstring = Space(96) & "Subs Amt  :" & Space(12 - Len(Mid(Format(Val(subsamt), "0.00"), 1, 12))) & Mid(Format(Val(subsamt), "0.00"), 1, 12)
                        Filewrite.WriteLine(sqlstring)
                        sqlstring = Space(96) & "Tax Amt   :" & Space(12 - Len(Mid(Format(Val(taxamt), "0.00"), 1, 12))) & Mid(Format(Val(taxamt), "0.00"), 1, 12)
                        Filewrite.WriteLine(sqlstring)
                        sqlstring = Space(96) & "Total Amt :" & Space(12 - Len(Mid(Format(Val(taxamt + subsamt), "0.00"), 1, 12))) & Mid(Format(Val(taxamt + subsamt), "0.00"), 1, 12)
                        Filewrite.WriteLine(sqlstring)
                        Filewrite.WriteLine("")
                        PageSize = PageSize + 3
                        taxamt = 0
                        subsamt = 0
                        If PageSize > 55 Then
                            PageNo = PageNo + 1
                            Filewrite.WriteLine("======================================================================================================================")
                            Filewrite.WriteLine(Chr(12))
                            Filewrite.WriteLine(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))))
                            Filewrite.WriteLine("Subscription Summary Report From :" & memd.Rows(0).Item("Period") & Space(30) & "Page No :" & Trim(PageNo))
                            Filewrite.WriteLine("======================================================================================================================")
                            Filewrite.WriteLine(" Sno    Mcode          Mname                    MemberCategory            Subscription Type              Amount       ")
                            Filewrite.WriteLine("======================================================================================================================")
                            PageSize = 0
                        End If
                    End If
                Next
                Filewrite.WriteLine("======================================================================================================================")
                sqlstring = Space(92) & "Total of subs:" & Space(12 - Len(Mid(Format(Val(tsubsamt), "0.00"), 1, 12))) & Mid(Format(Val(tsubsamt), "0.00"), 1, 12)
                Filewrite.WriteLine(sqlstring)
                sqlstring = Space(92) & "Tax          :" & Space(12 - Len(Mid(Format(Val(ttaxamt), "0.00"), 1, 12))) & Mid(Format(Val(ttaxamt), "0.00"), 1, 12)
                Filewrite.WriteLine(sqlstring)
                sqlstring = Space(92) & "Total Amt    :" & Space(12 - Len(Mid(Format(Val(tsubsamt + ttaxamt), "0.00"), 1, 12))) & Mid(Format(Val(tsubsamt + ttaxamt), "0.00"), 1, 12)
                Filewrite.WriteLine(sqlstring)
                Filewrite.WriteLine("======================================================================================================================")
                ttaxamt = 0
                tsubsamt = 0
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub chkmonth()
        Dim i As Long
        Try
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = TempString(1)
                    chk_month = " a.billingbasis=" & "'" & cbo_BillingBasis.Text & "'"
                    chk_month = chk_month & " and a.postingsno in(" & Trim(TempString(0))
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = DispString & ", " & TempString(1)
                    chk_month = chk_month & " , '" & Trim(TempString(0)) & "'"
                End If
            Next i
            chk_month = chk_month & ")"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        If rdsummary.Checked = True Then
            Call subssummary()
        Else
            Call subsdetails()
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Call DETAILS()
    End Sub
    Private Sub subssummary()
        Dim sqlstring, sqlstring1, postingsno, postingsdesc As String
        Dim CHK As Boolean
        Dim subsamt, taxamt, tsubsamt, ttaxamt As Double
        Dim i, j, pagesize, sno As Integer
        Dim NEWMCODE, adddet(5), PRESENTMCODE As String
        Dim Hedd1 As String
        Dim addFilterStr2 As String
        membertype = ""
        Try
            If chk_Filter_Field.SelectedIndex < 0 Then
                MessageBox.Show(" ", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            If ChkList_month.SelectedIndex < 0 Then
                MessageBox.Show("Please Select Month", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If membertype = "" Then
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = "('" & TempString(0)
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = membertype & "','" & TempString(0)
                End If
            Next i
            membertype = membertype & "')"
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If postingsno = "" Then
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = "('" & TempString(0)
                    postingsdesc = TempString(1)
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = postingsno & "','" & TempString(0)
                    postingsdesc = postingsdesc & "," & TempString(1)
                End If
            Next i
            postingsno = postingsno & "')"
            Randomize()
            vOutfile = Mid("sub" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            sqlstring = " select a.subscode,b.subsdesc,isnull(sum(isnull(a.amount,0)),0) as amount,isnull(sum(isnull(a.taxamount,0)),0) as taxamount,(isnull(sum(isnull(a.Amount,0)),0)+isnull(sum(isnull(a.taxamount,0)),0)) as Totalamount from subsposting a, subscriptionmast b   where  a.subscode=b.subscode and a.postingsno in " & postingsno & " and a.postingcode='" & Trim(cbo_BillingBasis.Text) & "' and a.membertype in " & membertype & "  group by a.subscode,b.subsdesc order by a.subscode"
            memd = gconnection.GetValues(sqlstring)
            sno = 1

            If memd.Rows.Count > 0 Then
                pagesize = 0
                PageNo = 1
                Filewrite.WriteLine(gCompanyAddress(0))
                'Filewrite.WriteLine("Subscription Summary For the Month of :" & Mid(UCase(Format(dtp_year.Value, "dd/MMM/yyyy")), 4, 3) & "-" & Mid(Format(dtp_year.Value, "dd/MMM/yyyy"), 8, 4))
                Filewrite.WriteLine("Subscription Summary For the Month of :" & postingsdesc & Space(10) & "Page No. " & PageNo)
                Filewrite.WriteLine("========================================================================")
                Filewrite.WriteLine(" Sno    Membertype                        Amount   Taxamount    Totalamt")
                Filewrite.WriteLine("========================================================================")
                Dim totamt As Long
                taxamt = 0
                taxamt = 0
                For i = 0 To memd.Rows.Count - 1
                    Filewrite.Write(Mid(sno, 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & Space(3))
                    Filewrite.Write(Mid(Trim(memd.Rows(i).Item("subsdesc")), 1, 30) & Space(30 - Len(Mid(Trim(memd.Rows(i).Item("subsdesc")), 1, 30))) & Space(2))
                    Filewrite.Write(Space(10 - Len(Mid(Format(Val(memd.Rows(i).Item("amount")), "0.00"), 1, 10))) & Mid(Format(Val(memd.Rows(i).Item("amount")), "0.00"), 1, 10))
                    Filewrite.Write(Space(10 - Len(Mid(Format(Val(memd.Rows(i).Item("taxamount")), "0.00"), 1, 10))) & Mid(Format(Val(memd.Rows(i).Item("Taxamount")), "0.00"), 1, 10))
                    Filewrite.WriteLine(Space(12 - Len(Mid(Format(Val(memd.Rows(i).Item("Totalamount")), "0.00"), 1, 12))) & Mid(Format(Val(memd.Rows(i).Item("Totalamount")), "0.00"), 1, 12))
                    totamt = totamt + Val(memd.Rows(i).Item("amount"))
                    taxamt = taxamt + Val(memd.Rows(i).Item("taxamount"))
                    sno = sno + 1
                Next
                Filewrite.WriteLine("========================================================================")
                Filewrite.Write(Space(39) & Space(10 - Len(Mid(Format(Val(totamt), "0.00"), 1, 10))) & Mid(Format(Val(totamt), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(taxamt), "0.00"), 1, 10))) & Mid(Format(Val(taxamt), "0.00"), 1, 10))
                Filewrite.WriteLine(Space(12 - Len(Mid(Format(Val(totamt + taxamt), "0.00"), 1, 12))) & Mid(Format(Val(totamt + taxamt), "0.00"), 1, 12))
                Filewrite.WriteLine("========================================================================")
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
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
    Private Sub subsmember()
        Dim sqlstring, sqlstring1, postingsno, postingsdesc As String
        Dim CHK As Boolean
        Dim subsamt, taxamt, tsubsamt, ttaxamt As Double
        Dim i, j, pagesize, sno As Integer
        Dim NEWMCODE, adddet(5), PRESENTMCODE As String
        Dim Hedd1 As String
        Dim Code As String
        Dim addFilterStr2 As String
        membertype = ""
        Try
            If chk_Filter_Field.SelectedIndex < 0 Then
                MessageBox.Show("Please Select Category", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If
            If ChkList_month.SelectedIndex < 0 Then
                MessageBox.Show("Please Select Month", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If membertype = "" Then
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = "('" & TempString(0)
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = membertype & "','" & TempString(0)
                End If
            Next i
            membertype = membertype & "')"
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If postingsno = "" Then
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = "('" & TempString(0)
                    postingsdesc = TempString(1)
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = postingsno & "','" & TempString(0)
                    postingsdesc = postingsdesc & "," & TempString(1)
                End If
            Next i
            postingsno = postingsno & "')"
            Randomize()
            vOutfile = Mid("subbill" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            'sqlstring = " select a.subscode,b.subsdesc,isnull(sum(isnull(a.amount,0)),0) as amount,isnull(sum(isnull(a.taxamount,0)),0) as taxamount from subsposting a, subscriptionmast b   where  a.subscode=b.subscode and a.postingsno in " & postingsno & " and a.postingcode='" & Trim(cbo_BillingBasis.Text) & "' and a.membertype in " & membertype & "  group by a.subscode,b.subsdesc order by a.subscode"
            sqlstring = "SELECT SUBSCODE,SUBSDESC,S.MCODE,(ISNULL(PREFIX,'')+ISNULL(MNAME,'')) AS MNAME FROM SUBSPOSTING S,MEMBERMASTER M WHERE S.MCODE = M.MCODE AND S.postingsno IN " & postingsno & " AND postingcode = '" & Trim(cbo_BillingBasis.Text) & "'AND membertype in " & membertype & " GROUP BY SUBSCODE,SUBSDESC,S.MCODE,PREFIX,MNAME ORDER BY SUBSDESC"

            memd = gconnection.GetValues(sqlstring)
            sno = 1

            If memd.Rows.Count > 0 Then
                pagesize = 0
                PageNo = 1
                Filewrite.WriteLine(gCompanyAddress(0))
                'Filewrite.WriteLine("Subscription Summary Report From :" & Format(dtp_year.Value, "dd/MM/yyyy") & Space(10) & "Page No. " & PageNo)
                Filewrite.WriteLine("Subscription Summary Report of :" & postingsdesc & Space(10) & "Page No. " & PageNo)
                Filewrite.WriteLine("========================================================================")
                Filewrite.WriteLine(" SubDesc     Sl No.   MemberCode    Member Name                         ")
                Filewrite.WriteLine("========================================================================")
                pagesize = pagesize + 5
                For i = 0 To memd.Rows.Count - 1
                    If pagesize > 56 Then
                        pagesize = 0
                        PageNo = PageNo + 1
                        Filewrite.WriteLine("-----------------------------------------------------------------------")
                        Filewrite.WriteLine("User Name =" & gUsername & Chr(12))
                        Filewrite.WriteLine(gCompanyAddress(0))
                        Filewrite.WriteLine("Subscription Summary Report From :" & Format(dtp_year.Value, "dd/MM/yyyy") & Space(10) & "Page No. " & PageNo)
                        Filewrite.WriteLine("========================================================================")
                        Filewrite.WriteLine(" SubDesc     Sl No.   MemberCode    Member Name                         ")
                        Filewrite.WriteLine("========================================================================")
                        pagesize = pagesize + 5
                    End If
                    If Code <> Trim(memd.Rows(i).Item("subscode")) Then
                        Filewrite.WriteLine(Space(1) & Trim(memd.Rows(i).Item("subsdesc")))
                        Filewrite.WriteLine("----------------------")
                        pagesize = pagesize + 2
                        Code = Trim(memd.Rows(i).Item("subscode"))
                        sno = 1
                    End If
                    Filewrite.Write("{0,12}{1,6}", " ", sno)
                    Filewrite.Write("{0,4}{1,-14}", " ", Trim(memd.Rows(i).Item("mcode")))
                    Filewrite.WriteLine("{0,-35}", Trim(memd.Rows(i).Item("mname")))
                    pagesize = pagesize + 1
                    sno = sno + 1
                Next
                Filewrite.WriteLine("============================================================")
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlstring, sqlstring1, postingsno, postingsdesc As String
        Dim CHK As Boolean
        Dim subsamt, taxamt, tsubsamt, ttaxamt As Double
        Dim i, j, pagesize, sno As Integer
        Dim NEWMCODE, adddet(5), PRESENTMCODE As String
        Dim Hedd1 As String
        Dim addFilterStr2 As String
        membertype = ""
        Dim TYPE(0) As String
        Dim _export As New EXPORT
        Try
            If chk_Filter_Field.SelectedIndex < 0 Then
                MessageBox.Show(" ", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            If ChkList_month.SelectedIndex < 0 Then
                MessageBox.Show("Please Select Month", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If membertype = "" Then
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = "('" & TempString(0)
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    membertype = membertype & "','" & TempString(0)
                End If
            Next i
            membertype = membertype & "')"
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If postingsno = "" Then
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = "('" & TempString(0)
                    postingsdesc = TempString(1)
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    postingsno = postingsno & "','" & TempString(0)
                    postingsdesc = postingsdesc & "," & TempString(1)
                End If
            Next i
            sqlstring = " SELECT * FROM VIEW_SUBSCRIPTION_NET  WHERE MEMBERTYPECODE in " & membertype & " "
            _export.TABLENAME = "VIEW_SUBSCRIPTION_NET"
            Call _export.export_excel(sqlstring)
            _export.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class



