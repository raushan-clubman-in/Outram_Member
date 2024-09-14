Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine

Public Class memberconversion
    Inherits System.Windows.Forms.Form
    Dim ssql, ssql1, ssql2, ssql3, oldtype, oldtypecode, newtype, SqlString As String
    Dim stype, stype3, stype1(2) As String
    Dim validity As Boolean
    Dim datalist, datalist1 As DataTable
    Dim I As Long
    Dim gconnection As New GlobalClass
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdmemberhelp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmembercode As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.Label
    Friend WithEvents oldmembertype As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdview As System.Windows.Forms.Button
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents Cbo_reasons As System.Windows.Forms.ComboBox
    Friend WithEvents commembertype1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(memberconversion))
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cbo_reasons = New System.Windows.Forms.ComboBox
        Me.mname = New System.Windows.Forms.Label
        Me.oldmembertype = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdmemberhelp = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmembercode = New System.Windows.Forms.TextBox
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.commembertype1 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdview = New System.Windows.Forms.Button
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "New Member Type"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cbo_reasons)
        Me.GroupBox1.Controls.Add(Me.mname)
        Me.GroupBox1.Controls.Add(Me.oldmembertype)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdmemberhelp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtmembercode)
        Me.GroupBox1.Controls.Add(Me.dtpdate)
        Me.GroupBox1.Controls.Add(Me.commembertype1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Cbo_reasons
        '
        Me.Cbo_reasons.BackColor = System.Drawing.Color.White
        Me.Cbo_reasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_reasons.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_reasons.Location = New System.Drawing.Point(184, 224)
        Me.Cbo_reasons.Name = "Cbo_reasons"
        Me.Cbo_reasons.Size = New System.Drawing.Size(392, 27)
        Me.Cbo_reasons.TabIndex = 710
        '
        'mname
        '
        Me.mname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.ForeColor = System.Drawing.Color.Blue
        Me.mname.Location = New System.Drawing.Point(184, 60)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(360, 20)
        Me.mname.TabIndex = 12
        '
        'oldmembertype
        '
        Me.oldmembertype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldmembertype.ForeColor = System.Drawing.Color.Blue
        Me.oldmembertype.Location = New System.Drawing.Point(184, 104)
        Me.oldmembertype.Name = "oldmembertype"
        Me.oldmembertype.Size = New System.Drawing.Size(200, 24)
        Me.oldmembertype.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Member Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Member Type"
        '
        'cmdmemberhelp
        '
        Me.cmdmemberhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmemberhelp.Image = CType(resources.GetObject("cmdmemberhelp.Image"), System.Drawing.Image)
        Me.cmdmemberhelp.Location = New System.Drawing.Point(272, 24)
        Me.cmdmemberhelp.Name = "cmdmemberhelp"
        Me.cmdmemberhelp.Size = New System.Drawing.Size(23, 24)
        Me.cmdmemberhelp.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Member Name"
        '
        'txtmembercode
        '
        Me.txtmembercode.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txtmembercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmembercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmembercode.Location = New System.Drawing.Point(184, 24)
        Me.txtmembercode.MaxLength = 10
        Me.txtmembercode.Name = "txtmembercode"
        Me.txtmembercode.Size = New System.Drawing.Size(88, 21)
        Me.txtmembercode.TabIndex = 6
        Me.txtmembercode.Text = ""
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(184, 184)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(104, 21)
        Me.dtpdate.TabIndex = 4
        '
        'commembertype1
        '
        Me.commembertype1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.commembertype1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commembertype1.Items.AddRange(New Object() {"ASSOCIATE MEMBER", "CORPORATE", "FULL MEMBER", "PERMANENT MEMBER", "SENIOR CITIZEN MEMBER", "DONOR MEMBER", "NON RESIDENTIAL LIFE MEMBERS", "NON RESIDENTIAL MEMBER", "PERMANENT MEMBERS", "PROMOTTEE", "HONORARY MEMBERS", "FILM MEMBER", "NULL", "SINGLE LADY MEMBERS", "CORPORATE MEMBERS", "NON RESIDENT INDIANS MEMBERS", "MEMBER SPOUSE", "PATRON MEMBERS", "TEMPORARY MEMBERS", "PROMOTEE-""D""", "ASSOCIATE MEMBERS", "LIFE MEMBER", "AFFLIATED CLUB MEMBER", "HONOURABLE TEMPARARY MEMBER"})
        Me.commembertype1.Location = New System.Drawing.Point(184, 144)
        Me.commembertype1.Name = "commembertype1"
        Me.commembertype1.Size = New System.Drawing.Size(232, 21)
        Me.commembertype1.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Effective From"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Reason"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.cmdview)
        Me.GroupBox2.Controls.Add(Me.cmdprint)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 56)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(456, 15)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 15
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdclear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.White
        Me.cmdclear.Image = CType(resources.GetObject("cmdclear.Image"), System.Drawing.Image)
        Me.cmdclear.Location = New System.Drawing.Point(344, 15)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(104, 32)
        Me.cmdclear.TabIndex = 14
        Me.cmdclear.Text = "Clear[F6]"
        '
        'cmdview
        '
        Me.cmdview.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdview.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdview.ForeColor = System.Drawing.Color.White
        Me.cmdview.Image = CType(resources.GetObject("cmdview.Image"), System.Drawing.Image)
        Me.cmdview.Location = New System.Drawing.Point(120, 15)
        Me.cmdview.Name = "cmdview"
        Me.cmdview.Size = New System.Drawing.Size(104, 32)
        Me.cmdview.TabIndex = 12
        Me.cmdview.Text = "List View [F9]"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Image = CType(resources.GetObject("cmdprint.Image"), System.Drawing.Image)
        Me.cmdprint.Location = New System.Drawing.Point(232, 15)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(104, 32)
        Me.cmdprint.TabIndex = 13
        Me.cmdprint.Text = "Print[F12]"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdadd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.Color.White
        Me.cmdadd.Image = CType(resources.GetObject("cmdadd.Image"), System.Drawing.Image)
        Me.cmdadd.Location = New System.Drawing.Point(8, 15)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(104, 32)
        Me.cmdadd.TabIndex = 11
        Me.cmdadd.Text = "Add New[F5]"
        '
        'memberconversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "memberconversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Category Conversion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub commembertype_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles commembertype1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtpdate.Focus()
        End If
    End Sub
    Private Sub dtpdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cbo_reasons.Focus()
        End If
    End Sub
    Private Sub txtreason_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cmdadd.Focus()
        End If
    End Sub
    Private Sub membertype()
        Dim MEMBERTYPE As New DataTable
        Dim MEMBERTYPE1 As New DataTable
        'Dim commembertype As SQL
        ' stype1 = Split(commembertype.Text, ".")
        Dim Fill_Chk_str, MEM As String
        Dim J As Integer
        Try

            commembertype1.Items.Clear()
            ' ssql = "SELECT subtypecode,subtypedesc FROM subcategorymaster WHERE typecode<>'" & oldtype & "' AND ISNULL(FREEZE,'') <> 'Y'"
            'MEMBERTYPE = gconnection.GetValues(ssql)
            ssql = "SELECT Membertypecode,Membersubtypecode,Membertype FROM MemberCategoryConversion WHERE Membersubtypecode='" & oldtypecode & "' AND ISNULL(FREEZE,'') <> 'Y'"
            MEMBERTYPE = gconnection.GetValues(ssql)
            If MEMBERTYPE.Rows.Count > 0 Then
                For I = 0 To (MEMBERTYPE.Rows.Count - 1)
                    MEM = MEMBERTYPE.Rows(I).Item("MEMBERTYPE")
                    ssql = "select subtypecode from subcategorymaster where subtypedesc='" & MEM & "' AND ISNULL(FREEZE,'')<>'Y'"
                    MEMBERTYPE1 = gconnection.GetValues(ssql)
                    If MEMBERTYPE1.Rows.Count > 0 Then
                        For J = 0 To (MEMBERTYPE1.Rows.Count - 1)
                            commembertype1.Items.Add(MEMBERTYPE1.Rows(J).Item("subtypecode") & "." & MEMBERTYPE.Rows(I).Item("membertype"))
                        Next
                    End If

                Next
            Else
                MessageBox.Show("Current Categ          ory Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
                Exit Sub
            End If

            commembertype1.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub memberconversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'membertype()
        Call Reasons()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Show()
        txtmembercode.Focus()
    End Sub
    Private Sub memberconversion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmdadd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            If cmdclear.Enabled = True Then
                Call cmdclear_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If cmdview.Enabled = True Then
                Call cmdview_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If cmdprint.Enabled = True Then
                Call cmdprint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            If cmdexit.Enabled = True Then
                Call cmdexit_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub
    Function validate1()
        Dim ssql, type0(0) As String
        Try
            validity = True
            If Cbo_reasons.Text = "" Then
                MessageBox.Show(" Please Enter The Reason ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                validity = False
                Exit Function
            End If
            If COMMEMBERTYPE1.Text <> "" Then

                type0 = Split(COMMEMBERTYPE1.Text, ".")

                If Trim(oldmembertype.Text) = Trim(type0(1)) Then
                    ' If Trim(oldmembertype.Text = commembertype.Text) Then
                    validity = False
                    MessageBox.Show("Can not convert same Category", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If


            Else
                validity = False
                MessageBox.Show(" Please Enter The Category ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            If Format(dtpdate.Value, "dd/MM/yyy") > Format(Now(), "dd/MM/yyyy") Then
                MessageBox.Show("Conversion Date cannot be greater than Systemdate", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                validity = False
                Exit Function
            End If
            If Format(dtpdate.Value, "dd/MM/yyy") < Format(Now(), "dd/MM/yyyy") Then
                MessageBox.Show("Conversion Date cannot be Less than Systemdate", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                validity = False
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub membertypelist()
        Dim SqlString As String
        Dim txtobj1 As TextObject
        Dim Viewer As New ReportViwer
        Dim r As New Cry_categoryconversion
        SqlString = "SELECT * FROM MM_Categoryconversion"
        Call Viewer.GetDetails1(SqlString, "MM_Categoryconversion", r)
        txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        txtobj1.Text = UCase(gCompanyname)
        txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        txtobj1.Text = UCase(gCompanyAddress(1))
        txtobj1 = r.ReportDefinition.ReportObjects("Text9")
        txtobj1.Text = UCase(gCompanyAddress(2))
        txtobj1 = r.ReportDefinition.ReportObjects("Text8")
        txtobj1.Text = UCase(gCompanyAddress(3))
        txtobj1 = r.ReportDefinition.ReportObjects("Text13")
        txtobj1.Text = UCase(gUsername)
        Viewer.Show()
        ''Dim str()() As String
        ''Dim i, j, row, pagesize, pageno, SNO As Integer
        ''Dim cnt As Integer
        ''Dim dr1 As DataRow
        ''Dim dr2 As DataRow
        ''Dim STR0 As String
        ''Dim STR1 As String
        ''Dim STR2 As String
        ''Dim STR3 As String
        ''Dim STR4 As String
        ''Dim STR5 As String
        ''Dim STR6 As String
        ''Dim STR7 As String
        ''Dim STR8 As String
        ''Dim STR9 As String
        ''Try
        ''    pageno = 1
        ''    Randomize()
        ''    vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        ''    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        ''    Filewrite = File.AppendText(VFilePath)
        ''    Filewrite.WriteLine()
        ''    pagesize = 5
        ''    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
        ''    Filewrite.WriteLine(Chr(27) + "E" & " MEMBER CONVERSION DETAILS :" & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
        ''    Filewrite.WriteLine(StrDup(80, "-"))
        ''    Filewrite.WriteLine("SNo   CODE      NAME                           OLD.TYPE    CURRENT.TYPE")
        ''    Filewrite.WriteLine(StrDup(80, "-"))
        ''    pagesize = 7
        ''    ssql = "SELECT A.MCODE,B.MNAME,A.OMEMBERTYPE,A.CMEMBERTYPE,A.EFFECTFROM,A.REASON FROM MEMBERTYPECONVERSION A,MEMBERMASTER B WHERE A.MCODE=B.MCODE"
        ''    datalist = gconnection.GetValues(ssql)
        ''    If datalist.Rows.Count > 0 Then
        ''        SNO = 1
        ''        For row = 0 To datalist.Rows.Count - 1
        ''            If pagesize > 55 Then
        ''                Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
        ''                Filewrite.WriteLine(gCompanyAddress(1) & "," & Trim(gCompanyAddress(2)))
        ''                Filewrite.WriteLine(gCompanyAddress(3) & "-" & Trim(gCompanyAddress(4)))
        ''                Filewrite.WriteLine(Chr(27) + "E" & " LOCKER NUMBER  WISE MEMBER LIST" & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
        ''                Filewrite.WriteLine(StrDup(80, "_"))
        ''                Filewrite.WriteLine("SNo   CODE      NAME                           OLD.TYPE           CURRENT.TYPE")
        ''                Filewrite.WriteLine(StrDup(80, "_"))
        ''                pageno = pageno + 1
        ''                pagesize = 7
        ''            End If
        ''            Filewrite.Write(Mid(SNO, 1, 4) & Space(4 - Len(Mid(SNO, 1, 4))) & Space(2) & Mid(Trim(datalist.Rows(row).Item("mcode")), 1, 7) & Space(7 - Len(Mid(Trim(datalist.Rows(row).Item("mcode")), 1, 7))) & Space(2))
        ''            Filewrite.WriteLine(Mid(Trim(datalist.Rows(row).Item("MNAME")), 1, 30) & Space(6) & Mid(Trim(datalist.Rows(row).Item("OMEMBERTYPE")), 1, 5) & Space(5 - Len(Mid(Trim(datalist.Rows(row).Item("OMEMBERTYPE")), 1, 5))) & Space(10) & Mid(Trim(datalist.Rows(row).Item("CMEMBERTYPE")), 1, 5) & Space(5 - Len(Mid(Trim(datalist.Rows(row).Item("CMEMBERTYPE")), 1, 5))))
        ''            pagesize = pagesize + 1
        ''            SNO = SNO + 1
        ''        Next row
        ''        Filewrite.WriteLine(StrDup(80, "_"))
        ''        Filewrite.WriteLine("User Name: " & gUsername & Space(30) & "Date :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
        ''        Filewrite.Close()
        ''        If PRINTREP = False Then
        ''            OpenTextFile(vOutfile)
        ''        Else
        ''            PrintTextFile(vOutfile)
        ''        End If
        ''    End If
        ''Catch ex As Exception
        ''    MsgBox("Data not found..!")
        ''    Exit Sub
        ''End Try
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
        Me.cmdadd.Enabled = False
        Me.cmdprint.Enabled = False
        Me.cmdview.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmdadd.Enabled = True
                    Me.cmdprint.Enabled = True
                    Me.cmdview.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmdadd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmdadd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmdadd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmdview.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdprint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub txtmembercode_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmembercode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdmemberhelp_Click(sender, e)
            'cmdadd.Text = "Update[F5]"
        End If
    End Sub
    Private Sub txtmembercode_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmembercode.KeyPress
        getAlphanumeric(e)
        If txtmembercode.Text = "" And Asc(e.KeyChar) = 13 Then
            Call cmdmemberhelp_Click(sender, e)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        End If
        If Asc(e.KeyChar) = 13 And txtmembercode.Text <> "" Then
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            commembertype1.Focus()
        End If
        cmdadd.Text = "Update[F5]"
    End Sub
    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Text = "Update[F5]" Then
            Call validate1()
            If validity = False Then Exit Sub
            stype1 = Split(commembertype1.Text, ".")
            stype = stype1(0)
            stype3 = stype1(1)
            '============
            ssql = "select ISNULL(SUBTYPECODE,'') SUBTYPECODE from SUBCATEGORYMASTER where SUBtypedesc='" & stype3 & " '"
            datalist = gconnection.GetValues(ssql)
            If datalist.Rows.Count > 0 Then
                stype = datalist.Rows(0).Item("SUBTYPECODE")
            End If
            'ssql = "select ISNULLSUBTYPECODE from SUBCATEGORYMASTER where SUBtypedesc='" & stype3 & " '"
            'datalist = gconnection.GetValues(ssql)
            'If datalist.Rows.Count > 0 Then
            '    stype = datalist.Rows(0).Item("membertype")
            'End If
            ssql = "update membermaster set membertypecode='" & stype & "',membertype='" & stype3 & "' where mcode='" & txtmembercode.Text & "'"
            datalist = gconnection.GetValues(ssql)
            ssql2 = "update membermaster set CATLIMIT=(SELECT ISNULL(CREDITLIMIT,0) FROM SUBCATEGORYMASTER WHERE MEMBERMASTER.MEMBERTYPECODE=SUBTYPECODE),MEMLIMIT=(SELECT ISNULL(CREDITLIMIT,0) FROM SUBCATEGORYMASTER WHERE MEMBERMASTER.MEMBERTYPECODE=SUBTYPECODE)  where mcode='" & txtmembercode.Text & "' AND ISNULL(CATLIMIT,0)=ISNULL(MEMLIMIT,0)"
            datalist = gconnection.GetValues(ssql2)
            ssql3 = "update membermaster set CATLIMIT=(SELECT ISNULL(CREDITLIMIT,0) FROM SUBCATEGORYMASTER WHERE MEMBERMASTER.MEMBERTYPECODE=SUBTYPECODE)   where mcode='" & txtmembercode.Text & "' AND ISNULL(CATLIMIT,0)<>ISNULL(MEMLIMIT,0)"
            datalist = gconnection.GetValues(ssql3)
            ssql1 = "insert into membertypeconversion(Mcode,OMembertype,CMembertype,Effectfrom,Reason) values('" & txtmembercode.Text & "','" & oldmembertype.Text & "','" & commembertype1.Text & "','" & Format(CDate(dtpdate.Text), "yyyy/MM/dd") & "', '" & Cbo_reasons.Text & "')"
            datalist1 = gconnection.GetValues(ssql1)
            MessageBox.Show("Member Category Changed Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmdclear_Click(sender, e)
        End If
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub

    Private Sub cmdview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdview.Click
        PRINTREP = False
        Call membertypelist()
    End Sub
    Private Sub txtmembercode_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmembercode.LostFocus
        If txtmembercode.Text <> "" Then
            If txtmembercode.Text <> "" Then
                'ssql = "select a.typedesc,a.membertype from membertype a,membermaster b where a.membertype=b.membertypecode and b.mcode='" & txtmembercode.Text & "' AND ISNULL(A.FREEZE,'') <> 'Y'"
                ssql = "select Membertypecode,membertype from membermaster  where mcode='" & txtmembercode.Text & "' AND ISNULL(FREEZE,'') <> 'Y'"
                datalist = gconnection.GetValues(ssql)
                If datalist.Rows.Count > 0 Then
                    oldmembertype.Text = datalist.Rows(0).Item("membertype")
                    oldtype = datalist.Rows(0).Item("membertype")
                    oldtypecode = datalist.Rows(0).Item("Membertypecode")
                Else
                    oldmembertype.Text = ""
                    oldtype = ""
                End If
            End If
            'Call membertype()
            'commembertype.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtmembercode.Text = ""
        mname.Text = ""
        oldmembertype.Text = ""
        Cbo_reasons.Text = ""
        commembertype1.Text = ""
        txtmembercode.Focus()
        cmdadd.Text = "Add New[F5]"
    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click
        PRINTREP = True
        Call membertypelist()
    End Sub

    Private Sub cmdmemberhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmemberhelp.Click
        Dim vform As New ListOperation
        Try
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            listop = ""
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtmembercode.Text = Trim(vform.keyfield & "")
                mname.Text = Trim(vform.keyfield1 & "")
                'Call txtmembercode_LostFocus1(sender, e)
                Call membertype()
                'commembertype1.Focus()
            End If
            vform.Close()
            vform = Nothing
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmdadd.Text = "Update[F5]"
    End Sub
    Private Sub txtmembercode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmembercode.Validated
        Dim sqlstring, sqlstring1 As String
        Try
            If Trim(txtmembercode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txtmembercode.Text) & "'"
                sqlstring1 = "Select Reason From membertypeconversion"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txtmembercode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    Call membertype()
                Else
                    txtmembercode.Text = ""
                    mname.Text = ""
                    txtmembercode.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub commembertype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commembertype1.SelectedIndexChanged

    End Sub

    Private Sub txtmembercode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmembercode.TextChanged

    End Sub
    Public Sub Reasons()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT distinct(Name) FROM ReasonMaster where freeze='N'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_reasons.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub

    Private Sub Cbo_reasons_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_reasons.SelectedIndexChanged

    End Sub
End Class