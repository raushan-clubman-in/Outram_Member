Imports System.Data.SqlClient
Imports System.IO
Public Class McodeFilter
    Inherits System.Windows.Forms.Form
    Dim gconnection As New globalclass
    Dim CorpFltr, sqlstring As String
    Dim dt As New DataTable

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
    Friend WithEvents txt_From As System.Windows.Forms.TextBox
    Friend WithEvents txt_To As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CorporateCodetoHelp As System.Windows.Forms.Button
    Friend WithEvents CorporateCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents txt_fromname As System.Windows.Forms.TextBox
    Friend WithEvents txt_toname As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(McodeFilter))
        Me.txt_From = New System.Windows.Forms.TextBox
        Me.txt_To = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_fromname = New System.Windows.Forms.TextBox
        Me.CorporateCodetoHelp = New System.Windows.Forms.Button
        Me.CorporateCodefromHelp = New System.Windows.Forms.Button
        Me.txt_toname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_From
        '
        Me.txt_From.Location = New System.Drawing.Point(104, 40)
        Me.txt_From.Name = "txt_From"
        Me.txt_From.Size = New System.Drawing.Size(96, 23)
        Me.txt_From.TabIndex = 0
        Me.txt_From.Text = ""
        '
        'txt_To
        '
        Me.txt_To.Location = New System.Drawing.Point(104, 88)
        Me.txt_To.Name = "txt_To"
        Me.txt_To.Size = New System.Drawing.Size(96, 23)
        Me.txt_To.TabIndex = 1
        Me.txt_To.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(56, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(64, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_fromname)
        Me.GroupBox1.Controls.Add(Me.CorporateCodetoHelp)
        Me.GroupBox1.Controls.Add(Me.CorporateCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.txt_From)
        Me.GroupBox1.Controls.Add(Me.txt_To)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_toname)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 152)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'txt_fromname
        '
        Me.txt_fromname.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txt_fromname.Location = New System.Drawing.Point(272, 40)
        Me.txt_fromname.Name = "txt_fromname"
        Me.txt_fromname.ReadOnly = True
        Me.txt_fromname.Size = New System.Drawing.Size(224, 23)
        Me.txt_fromname.TabIndex = 4
        Me.txt_fromname.Text = ""
        '
        'CorporateCodetoHelp
        '
        Me.CorporateCodetoHelp.Image = CType(resources.GetObject("CorporateCodetoHelp.Image"), System.Drawing.Image)
        Me.CorporateCodetoHelp.Location = New System.Drawing.Point(201, 88)
        Me.CorporateCodetoHelp.Name = "CorporateCodetoHelp"
        Me.CorporateCodetoHelp.Size = New System.Drawing.Size(23, 24)
        Me.CorporateCodetoHelp.TabIndex = 3
        '
        'CorporateCodefromHelp
        '
        Me.CorporateCodefromHelp.Image = CType(resources.GetObject("CorporateCodefromHelp.Image"), System.Drawing.Image)
        Me.CorporateCodefromHelp.Location = New System.Drawing.Point(201, 40)
        Me.CorporateCodefromHelp.Name = "CorporateCodefromHelp"
        Me.CorporateCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.CorporateCodefromHelp.TabIndex = 2
        '
        'txt_toname
        '
        Me.txt_toname.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txt_toname.Location = New System.Drawing.Point(272, 88)
        Me.txt_toname.Name = "txt_toname"
        Me.txt_toname.ReadOnly = True
        Me.txt_toname.Size = New System.Drawing.Size(224, 23)
        Me.txt_toname.TabIndex = 4
        Me.txt_toname.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CORPORATE LIST"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(392, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 18
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(264, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 17
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(24, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 16
        Me.CmdView.Text = "View[F9]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(32, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(144, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "Print[F12]"
        '
        'McodeFilter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 333)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "McodeFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CORPORATE LIST"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CorporateCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorporateCodefromHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select CMCorporateCode,CMCorporateName from CorporateMaster"
        M_WhereCondition = " "
        vform.Field = "CMCorporateCode,CMCorporateName"
        vform.vFormatstring = "  Corporate Code  | Corporate Name                           "
        vform.vCaption = "Corporate Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        txt_From.ReadOnly = False
        txt_fromname.ReadOnly = False
        If Trim(vform.keyfield & "") <> "" Then
            txt_From.Text = Trim(vform.keyfield & "")
            txt_fromname.Text = Trim(vform.keyfield1 & "")
            txt_To.Select()
        End If
        txt_From.ReadOnly = True
        txt_fromname.ReadOnly = True
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub CorporateCodetoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorporateCodetoHelp.Click
        Dim vform As New ListOperation
        gSQLString = "Select CMCorporateCode,CMCorporateName from CorporateMaster"
        M_WhereCondition = " "
        vform.Field = "CMCorporateCode,CMCorporateName"
        vform.vFormatstring = "  Corporate Code  | Corporate Name                           "
        vform.vCaption = "Corporate Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        txt_From.ReadOnly = False
        txt_fromname.ReadOnly = False
        If Trim(vform.keyfield & "") <> "" Then
            txt_To.Text = Trim(vform.keyfield & "")
            txt_toname.Text = Trim(vform.keyfield1 & "")
            CmdView.Select()
        End If
        txt_From.ReadOnly = True
        txt_fromname.ReadOnly = True
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        txt_From.ReadOnly = False
        txt_fromname.ReadOnly = False
        txt_From.ReadOnly = False
        txt_fromname.ReadOnly = False
        txt_From.Text = ""
        txt_To.Text = ""
        txt_fromname.Text = ""
        txt_toname.Text = ""
        txt_From.Focus()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            txt_From.Focus()
        End If
    End Sub
    Private Sub McodeFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txt_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_From.KeyDown
        If txt_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                Call CorporateCodefromHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_To.KeyDown
        If txt_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                Call CorporateCodetoHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Function printdata()
        Dim str()() As String
        Dim row, rowno, j, k, pageno As Integer
        Dim cnt, rcount As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim corcode As String
        Dim address(8) As String
        Dim write As File
        Dim corplist As DataTable
        Dim add1, add2 As String
        Dim STRARRAY(20) As String
        Dim totmember As Long
        Dim totcorporate As Long
        Dim corpname As String = ""
        pageno = 1
        Try
            'select isnull(cmcorporatecode,'')corcode,isnull(cmcorporatename,'') as corname,isnull(cmbilling,'') as billing,isnull(membershipfrom,'') as fromdate,isnull(membershipto,'') as todate,isnull(CurrentStatus,'') cstatus,isnull(CMNomembers,0) as Cormembers,isnull(CMAddress1,'') as  coradd1,isnull(CMAddress2,'') as  coradd2,isnull(CMAddress3,'') as  coradd3,isnull(CMCountry,'') as corcountry,isnull(CMCity,'') as corcity,isnull(CMState,'') as corstate,isnull(CMPin,'') as corpin,isnull(CMPhone,'') as phoneno from corporatemaster
            If txt_From.Text = "" And txt_To.Text = "" Then
                CorpFltr = ""
            ElseIf txt_From.Text <> "" And txt_To.Text = "" Then
                CorpFltr = " and CMCorporatecode = '" & Trim(txt_From.Text) & "'"
            ElseIf txt_From.Text = "" And txt_To.Text <> "" Then
                CorpFltr = " and Corcode = '" & Trim(txt_To.Text) & "'"
            Else
                CorpFltr = " and Corcode between  '" & Trim(txt_From.Text) & "' and '" & Trim(txt_To.Text) & "'"
            End If
            sqlstring = "select corcode,corname,billing,mfdate,mtdate,add1,add2,add3,city,state,pincode,status,mcode,mname from viewcormaster"
            sqlstring = sqlstring & " where  billing <> 'NONE'" & CorpFltr & " Order by corcode,MCODE"
            corplist = gconnection.GetValues(sqlstring)
            Randomize()
            vOutfile = Mid("corst" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            corcode = ""
            If corplist.Rows.Count > 0 Then
                row = 0
                'corcode = Trim(corplist.Rows(row).Item("corcode"))
                corcode = ""
                pageno = 1
                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                rcount = 6
                totcorporate = 0
                For row = 0 To corplist.Rows.Count - 1
                    rcount = rcount + 1
                    If rcount > 60 Then
                        Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                        pageno = pageno + 1
                        Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                        Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                        Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                        Filewrite.WriteLine("--------------------------------------------------------------------------------")
                        Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                        Filewrite.WriteLine("--------------------------------------------------------------------------------")
                        rcount = 6
                    End If
                    If corcode <> Trim(corplist.Rows(row).Item("corcode")) Then
                        totcorporate = totcorporate + 1
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        rcount = rcount + 2
                        address(0) = ""
                        address(1) = ""
                        address(2) = ""
                        address(3) = ""
                        address(4) = ""
                        address(5) = ""
                        address(6) = ""
                        address(7) = ""
                        k = 0
                        If Trim(corplist.Rows(row).Item("corname")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("corname"))
                            k = k + 1
                        End If
                        If Trim(corplist.Rows(row).Item("add1")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("add1"))
                            k = k + 1
                        End If
                        If Trim(corplist.Rows(row).Item("add2")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("add2"))
                            k = k + 1
                        End If
                        If Trim(corplist.Rows(row).Item("add3")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("add3"))
                            k = k + 1
                        End If
                        If Trim(corplist.Rows(row).Item("city")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("city")) & " " & Trim(corplist.Rows(row).Item("pincode"))
                            k = k + 1
                        End If
                        If Trim(corplist.Rows(row).Item("state")) <> "" Then
                            address(k) = Trim(corplist.Rows(row).Item("state"))
                            k = k + 1
                        End If
                        If address(0) <> "" Then
                            Filewrite.Write(Mid(corplist.Rows(row).Item("corname"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("corname"), 1, 30))))
                            Filewrite.Write(Space(10) & Mid(corplist.Rows(row).Item("billing"), 1, 10) & Space(10 - Len(Mid(corplist.Rows(row).Item("billing"), 1, 10))))
                            Filewrite.WriteLine(Space(3) & "(" & Mid(corplist.Rows(row).Item("mfdate"), 1, 11) & Space(11 - Len(Mid(corplist.Rows(row).Item("mfdate"), 1, 11))) & " To " & Mid(corplist.Rows(row).Item("mtdate"), 1, 11) & Space(11 - Len(Mid(corplist.Rows(row).Item("mtdate"), 1, 11))) & ")")
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        If address(1) <> "" Then
                            Filewrite.WriteLine(Mid(corplist.Rows(row).Item("add1"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("add1"), 1, 30))))
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        If address(2) <> "" Then
                            Filewrite.WriteLine(Mid(corplist.Rows(row).Item("add2"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("add2"), 1, 30))))
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        If address(3) <> "" Then
                            Filewrite.WriteLine(Mid(corplist.Rows(row).Item("add3"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("add3"), 1, 30))))
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        If address(4) <> "" Then
                            Filewrite.WriteLine(Mid(corplist.Rows(row).Item("city"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("city"), 1, 30))))
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        If address(5) <> "" Then
                            Filewrite.WriteLine(Mid(corplist.Rows(row).Item("state"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("state"), 1, 30))))
                            If rcount > 60 Then
                                Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                                pageno = pageno + 1
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                                Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                                Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                                Filewrite.WriteLine("--------------------------------------------------------------------------------")
                                rcount = 6
                            End If
                            rcount = rcount + 1
                        End If
                        Filewrite.WriteLine("---------------------------------------")
                        corcode = Trim(corplist.Rows(row).Item("corcode"))
                    End If
                    If corplist.Rows(row).Item("mcode") <> "" Then
                        totmember = totmember + 1
                        Filewrite.Write(Mid(corplist.Rows(row).Item("mcode"), 1, 7) & Space(7 - Len(Mid(corplist.Rows(row).Item("mcode"), 1, 7))))
                        Filewrite.Write(Space(3) & Mid(corplist.Rows(row).Item("mname"), 1, 30) & Space(30 - Len(Mid(corplist.Rows(row).Item("mname"), 1, 30))))
                        Filewrite.Write(Space(19) & Mid(corplist.Rows(row).Item("corcode"), 1, 7) & Space(7 - Len(Mid(corplist.Rows(row).Item("corcode"), 1, 7))))
                        Filewrite.WriteLine(Space(3) & Mid(corplist.Rows(row).Item("status"), 1, 7) & Space(7 - Len(Mid(corplist.Rows(row).Item("status"), 1, 7))))
                        If rcount > 60 Then
                            Filewrite.WriteLine("--------------------------------------------------------------------------------" & Chr(12))
                            pageno = pageno + 1
                            Filewrite.WriteLine(Space(30) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                            Filewrite.WriteLine(Space(30) & Chr(27) + "E" & "CORPORATE MEMBER LIST" & Chr(27) + "F")
                            Filewrite.WriteLine("RUN DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
                            Filewrite.WriteLine("--------------------------------------------------------------------------------")
                            Filewrite.WriteLine("MEMBER NO.   MEMBER NAME                    BILLING    CORP. CODE     STATUS    ")
                            Filewrite.WriteLine("--------------------------------------------------------------------------------")
                            rcount = 6
                        End If
                        rcount = rcount + 1
                    End If
                Next
                Filewrite.WriteLine("No. of Corporate Companies =" & CStr(Trim(totcorporate)))
                Filewrite.WriteLine("")
                Filewrite.WriteLine("No. of Corporate Members   =" & Trim(CStr(totmember)))
                Filewrite.WriteLine("--------------------------------------------------------------------------------")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, gCompanyname)
        End Try
        Filewrite.Close()
        If PRINTREP = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If
    End Function
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        Call printdata()
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        Call printdata()
    End Sub
    Private Sub txt_From_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_From.LostFocus
        sqlstring = "Select isnull(CMCorporateCode,'') CMCorporateCode,isnull(CMCorporateName,'') as CMCorporateName from CorporateMaster where CMCorporateCode='" & txt_From.Text & "'"
        dt = Nothing
        txt_fromname.Text = ""
        dt = gconnection.GetValues(sqlstring)
        If dt.Rows.Count > 0 Then
            txt_fromname.Text = dt.Rows(0).Item("CMCorporateName")
        End If
    End Sub
    Private Sub txt_To_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_To.LostFocus
        sqlstring = "Select isnull(CMCorporateCode,'') CMCorporateCode,isnull(CMCorporateName,'') as CMCorporateName from CorporateMaster where CMCorporateCode='" & txt_To.Text & "'"
        dt = Nothing
        dt = gconnection.GetValues(sqlstring)
        txt_toname.Text = ""
        If dt.Rows.Count > 0 Then
            txt_toname.Text = dt.Rows(0).Item("CMCorporateName")
        End If
    End Sub

    Private Sub McodeFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
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
End Class
