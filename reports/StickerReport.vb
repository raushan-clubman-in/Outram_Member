Imports System.Data.SqlClient
Imports System.IO
Public Class McodeFilter
    Inherits System.Windows.Forms.Form
    Dim gconnection As New globalclass
    Dim CorpFltr, sqlstring As String
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
        Me.GroupBox1.Location = New System.Drawing.Point(176, 96)
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
        Me.Label3.Location = New System.Drawing.Point(352, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Corporate  List"
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
        Me.GroupBox2.Location = New System.Drawing.Point(160, 392)
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
        Me.ClientSize = New System.Drawing.Size(888, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(64, Byte))
        Me.KeyPreview = True
        Me.Name = "McodeFilter"
        Me.Text = "McodeFilter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        Me.Hide()
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
        ElseIf e.KeyCode = Keys.F11 Then
            Me.Close()
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
        Dim row, rowno, j, pageno As Integer
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim write As File
        Dim corplist As DataTable
        Dim STRARRAY(20) As String
        Dim corpname As String = ""
        Try
            PRINTREP = False
            If txt_From.Text = "" And txt_To.Text = "" Then
                CorpFltr = ""
            ElseIf txt_From.Text <> "" And txt_To.Text = "" Then
                CorpFltr = " and CMCorporatecode = '" & Trim(txt_From.Text) & "'"
            ElseIf txt_From.Text = "" And txt_To.Text <> "" Then
                CorpFltr = " and CMCorporatecode = '" & Trim(txt_To.Text) & "'"
            Else
                CorpFltr = " and CMCorporatecode between  '" & Trim(txt_From.Text) & "' and '" & Trim(txt_To.Text) & "'"
            End If
            sqlstring = "select isnull(CMCorporatecode,'') as CMCorporatecode"
            sqlstring = sqlstring & ",isnull(cmcorporatename,'') as cmcorporatename"
            sqlstring = sqlstring & ",isnull(cmbilling,'') as cmbilling"
            sqlstring = sqlstring & ",isnull(membershipfrom,'') as membershipfrom"
            sqlstring = sqlstring & ",isnull(membershipto,'') as membershipto"
            sqlstring = sqlstring & ",isnull(cmaddress1,'') as cmaddress1"
            sqlstring = sqlstring & ",isnull(cmaddress2,'') as cmaddress2"
            sqlstring = sqlstring & ",isnull(cmaddress3,'') as cmaddress3"
            sqlstring = sqlstring & ",isnull(cmcity,'') as cmcity"
            sqlstring = sqlstring & ",isnull(cmstate,'') as cmstate"
            sqlstring = sqlstring & " FROM corporatemaster  where  cmbilling <> 'NONE'" & CorpFltr
            corplist = gconnection.GetValues(sqlstring)
            Randomize()
            vOutfile = Mid("corst" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine(" CORPORATE MEMBER LIST")
            If corplist.Rows.Count > 1 Then
                Try
                    pageno = 1
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    Filewrite.WriteLine(gCompanyAddress(1) & "," & Trim(gCompanyAddress(2)))
                    Filewrite.WriteLine(gCompanyAddress(3) & "-" & Trim(gCompanyAddress(5)))
                    Filewrite.WriteLine(Chr(27) + "E" & " CORPORATE MEMBER LIST" & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
                    Filewrite.WriteLine("------------------------------------------------------------------------------")
                    Filewrite.WriteLine("COMPANY NAME & ADDRESS ", "BILLING", "PERIOD (FROM DATE - TO DATE)")
                    Filewrite.WriteLine("MEMBER CODE", "MEMBER NAME", "CORP.CODE", "STATUS")
                    Filewrite.WriteLine("------------------------------------------------------------------------------")
                    For row = 0 To corplist.Rows.Count - 1
                        If rowno = 55 Then
                            PageFoter(80)
                            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                            Filewrite.WriteLine(gCompanyAddress(1) & "," & Trim(gCompanyAddress(2)))
                            Filewrite.WriteLine(gCompanyAddress(3) & "-" & Trim(gCompanyAddress(5)))
                            Filewrite.WriteLine(Chr(27) + "E" & " CORPORATE MEMBER LIST" & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
                            Filewrite.WriteLine("------------------------------------------------------------------------------")
                            Filewrite.WriteLine(Mid("COMPANY NAME & ADDRESS    BILLING     PERIOD-FROM DATE - TO DATE", 1, 80))
                            Filewrite.WriteLine(Mid("MEMBER CODE    MEMBER NAME   CORP_CODE  STATUS", 1, 80))
                            Filewrite.WriteLine("------------------------------------------------------------------------------")
                            pageno = pageno + 1
                        End If
                        STRARRAY(1) = Trim(corplist.Rows(row).Item("cmcorporatename")) & "( " & corplist.Rows(row).Item("CMCorporatecode") & " )"
                        STRARRAY(2) = Trim(corplist.Rows(row).Item("cmbilling"))
                        STRARRAY(3) = Trim(Format(corplist.Rows(row).Item("membershipfrom"), "dd-MMM-yy") & " to " & Format(corplist.Rows(row).Item("membershipto"), "dd-MMM-yy"))
                        STRARRAY(4) = Trim(corplist.Rows(row).Item("cmaddress1"))
                        STRARRAY(5) = Trim(corplist.Rows(row).Item("cmaddress2"))
                        STRARRAY(6) = Trim(corplist.Rows(row).Item("cmaddress3"))
                        STRARRAY(7) = Trim(corplist.Rows(row).Item("cmcity"))
                        STRARRAY(8) = Trim(corplist.Rows(row).Item("cmstate"))
                        Filewrite.WriteLine("{0,-35}{1,-15}{2,-25}", STRARRAY(1), STRARRAY(2), STRARRAY(3))
                        Filewrite.WriteLine(StrDup(35, "_"))
                        Filewrite.Write(IIf(STRARRAY(4) <> "", STRARRAY(4), ""), STRARRAY(4))
                        Filewrite.Write(IIf(STRARRAY(5) <> "", "  " & STRARRAY(5), ""))
                        Filewrite.WriteLine("")
                        Filewrite.Write(IIf(STRARRAY(6) <> "", STRARRAY(6), ""), STRARRAY(6))
                        Filewrite.Write(IIf(STRARRAY(7) <> "", "  " & STRARRAY(7), ""))
                        Filewrite.Write(IIf(STRARRAY(8) <> "", "  " & STRARRAY(8), ""))
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(StrDup(35, "_"))
                        rowno = rowno + 12
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, gCompanyname)
                End Try
            End If
            PageFoter(80)
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        Call printdata()
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        Call printdata()
    End Sub
End Class
