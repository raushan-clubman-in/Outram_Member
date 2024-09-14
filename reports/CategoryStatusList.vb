Imports System.Data.SqlClient
Imports System.IO
Public Class CategoryStatusList
    Inherits System.Windows.Forms.Form
    Dim FltrStr, status, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Dim SNO As Integer = 1
    Public selectNo As Integer
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CategoryStatusList))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 31)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "MEMBER CATEGORY STATUS REPORT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 256)
        Me.GroupBox1.TabIndex = 412
        Me.GroupBox1.TabStop = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(336, 216)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 410
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(160, 216)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 409
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 412
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(239, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 411
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(272, 216)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 24)
        Me.tbx_filter_To.TabIndex = 408
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(96, 216)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 24)
        Me.tbx_Filter_From.TabIndex = 407
        Me.tbx_Filter_From.Text = ""
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(25, 16)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(164, 23)
        Me.chk_PrintAll.TabIndex = 10
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(25, 48)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(360, 137)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(16, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 64)
        Me.GroupBox2.TabIndex = 413
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
        Me.CmdClear.Location = New System.Drawing.Point(274, 19)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 4
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
        Me.cmdexit.Location = New System.Drawing.Point(402, 19)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 5
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
        Me.cmdPrint.Location = New System.Drawing.Point(154, 19)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 3
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
        Me.CmdView.Location = New System.Drawing.Point(34, 19)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 2
        Me.CmdView.Text = "View[F9]"
        '
        'CategoryStatusList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(552, 446)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "CategoryStatusList"
        Me.Text = "CategoryStatusList"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CategoryStatusList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        chk_Filter_Field.Focus()
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
    Private Sub chkfilterfield()
        Dim i As Long
        status = ""
        DispString = ""
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(TempString(1))
                    addFltrStr = FltrStr & Trim(TempString(selectNo))
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(DispString) & "," & Trim(TempString(1))
                    addFltrStr = addFltrStr & "','" & Trim(TempString(selectNo))
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Member_Status_Report()
        Dim dr1, dr2 As DataRow
        Dim str()() As String
        Dim Ssql, Ssql1, tmp, SLNO As String
        Dim cnt, i, j, row, pagesize, pageno As Integer
        Dim SQLSTR, MEMCODE, MEMNAME, Category As String
        Try
            'If chkdatevalidate = False Then Exit Sub
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text = "" And tbx_filter_To.Text <> "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text = "" Then
                    MsgBox("Please Select Any One Category OR Give Both From and To Member Codes", MsgBoxStyle.Critical, gCompanyAddress(0))
                    Exit Sub
                End If
            End If
            Call chkfilterfield()
            sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE "
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "' "
            Else
                sqlstring = sqlstring & " membertypecode in ('" & addFltrStr & "')" & " "
            End If
            addlist = gconnection.GetValues(sqlstring)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            pagesize = 0
            Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(119, "-"))
            Filewrite.WriteLine("CODE         NAME                       OLD STATUS       CURRENT STATUS    FROM DATE    TO DATE   ")
            Filewrite.WriteLine(StrDup(119, "-"))
            SNO = 1
            For row = 0 To addlist.Rows.Count - 1
                MEMCODE = addlist.Rows(row).Item("MCODE")
                MEMNAME = addlist.Rows(row).Item("MNAME")
                If pagesize > 60 Then
                    pagesize = 0
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(119, "-"))
                    Filewrite.WriteLine("USER NAME : " & gUsername & Space(30) & "DATE : " & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    Filewrite.WriteLine("PRINT DATE : " & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO : " & Trim(CStr(pageno)))
                    Filewrite.WriteLine(StrDup(119, "-"))
                    'Filewrite.WriteLine("CODE       |NAME                                             |OLD STATUS          |CURRENT STATUS   |FROM DATE     |TO DATE        |")
                    Filewrite.WriteLine("CODE         NAME                       OLD STATUS       CURRENT STATUS    FROM DATE    TO DATE   ")
                    Filewrite.WriteLine(StrDup(119, "-"))
                End If
                SQLSTR = "SELECT * FROM STATUS_VIEW WHERE MCODE = '" & MEMCODE & "' ORDER BY SNO"
                gconnection.getDataSet(SQLSTR, "Status")
                If gdataset.Tables("Status").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("Status").Rows.Count - 1
                        If SLNO <> gdataset.Tables("Status").Rows(i).Item("SNO") Then
                            If gdataset.Tables("Status").Rows(i).Item("SNO") = "1" Then
                                Category = "Starting Status"
                            ElseIf gdataset.Tables("Status").Rows(i).Item("SNO") = "2" Then
                                Category = "Category Changes"
                            ElseIf gdataset.Tables("Status").Rows(i).Item("SNO") = "3" Then
                                Category = "Status Changes"
                            End If
                            Filewrite.WriteLine(Category)
                            Filewrite.WriteLine("----------------")
                            Filewrite.Write("{0,-11}{1,2}", gdataset.Tables("Status").Rows(i).Item("MCODE"), "")
                            Filewrite.WriteLine("{0,-25}{1,2}", MEMNAME, "")
                            SLNO = gdataset.Tables("Status").Rows(i).Item("SNO")
                        End If
                        Filewrite.Write("{0,-11}{1,2}", "", "")
                        Filewrite.Write("{0,-25}{1,2}", "", "")
                        Filewrite.Write("{0,-15}{1,2}", gdataset.Tables("Status").Rows(i).Item("OLDSTATUS"), "")
                        Filewrite.Write("{0,-15}{1,2}", gdataset.Tables("Status").Rows(i).Item("CURENTSTATUS"), "")
                        Filewrite.Write("{0,11}{1,2}", Format(gdataset.Tables("Status").Rows(i).Item("FROMDATE"), "dd/MM/yyyy"), "")
                        Filewrite.WriteLine("{0,11}{1,2}", Format(gdataset.Tables("Status").Rows(i).Item("TODATE"), "dd/MM/yyyy"), "")
                    Next
                End If
            Next row
            Filewrite.WriteLine(StrDup(119, "-") & Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("Data not found..!")
            Exit Sub
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        Call Member_Status_Report()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gPrint = True
        Call Member_Status_Report()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click

    End Sub

    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
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
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            tbx_Filter_From.Text = Trim(vform.keyfield & "")
            'tbx_filter_To.Text = Trim(vform.keyfield1)
            tbx_filter_To.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
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
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            tbx_filter_To.Text = Trim(vform.keyfield & "")
            'tbx_filter_To.Text = Trim(vform.keyfield1)
            CmdView.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub CategoryStatusList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If CmdClear.Enabled = True Then
                    Call CmdClear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If CmdView.Enabled = True Then
                    Call CmdView_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If cmdPrint.Enabled = True Then
                    Call cmdPrint_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmdexit.Enabled = True Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
