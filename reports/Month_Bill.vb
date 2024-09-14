Imports System.Data.SqlClient
Imports System.Math
Imports System.IO
Imports System.Data
Public Class Month_Bill
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim vmemopbal As Double
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents CHK_TMP As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Chk_Members_List As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllMember As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_SUMMARY As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Month_Bill))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CHK_SUMMARY = New System.Windows.Forms.CheckBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.CHK_TMP = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Chk_Members_List = New System.Windows.Forms.CheckedListBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_SelectAllMember = New System.Windows.Forms.CheckBox
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CHK_SUMMARY)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.CHK_TMP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.CbxMonth)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Chk_Members_List)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllMember)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 448)
        Me.GroupBox1.TabIndex = 442
        Me.GroupBox1.TabStop = False
        '
        'CHK_SUMMARY
        '
        Me.CHK_SUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SUMMARY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SUMMARY.Location = New System.Drawing.Point(256, 416)
        Me.CHK_SUMMARY.Name = "CHK_SUMMARY"
        Me.CHK_SUMMARY.Size = New System.Drawing.Size(144, 24)
        Me.CHK_SUMMARY.TabIndex = 457
        Me.CHK_SUMMARY.Text = "SUMMARY"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(344, 376)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 455
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(160, 376)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 454
        '
        'CHK_TMP
        '
        Me.CHK_TMP.BackColor = System.Drawing.Color.Transparent
        Me.CHK_TMP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_TMP.Location = New System.Drawing.Point(24, 416)
        Me.CHK_TMP.Name = "CHK_TMP"
        Me.CHK_TMP.Size = New System.Drawing.Size(216, 24)
        Me.CHK_TMP.TabIndex = 456
        Me.CHK_TMP.Text = "WITH OUT TEMPORARY MEMBER "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 453
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(240, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 17)
        Me.Label8.TabIndex = 452
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(264, 376)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 21)
        Me.tbx_filter_To.TabIndex = 451
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(88, 376)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 21)
        Me.tbx_Filter_From.TabIndex = 450
        Me.tbx_Filter_From.Text = ""
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(304, 48)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 21)
        Me.CbxMonth.TabIndex = 448
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 16)
        Me.Label10.TabIndex = 447
        Me.Label10.Text = "MEMBER BILL FOR THE MONTH OF : "
        '
        'Chk_Members_List
        '
        Me.Chk_Members_List.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Chk_Members_List.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Members_List.Location = New System.Drawing.Point(432, 112)
        Me.Chk_Members_List.Name = "Chk_Members_List"
        Me.Chk_Members_List.Size = New System.Drawing.Size(252, 244)
        Me.Chk_Members_List.Sorted = True
        Me.Chk_Members_List.TabIndex = 445
        Me.Chk_Members_List.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(40, 80)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(185, 23)
        Me.chk_PrintAll.TabIndex = 444
        Me.chk_PrintAll.Text = "Select All Categorys"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 29)
        Me.Label1.TabIndex = 442
        Me.Label1.Text = "MONTH BILL"
        '
        'Chk_SelectAllMember
        '
        Me.Chk_SelectAllMember.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllMember.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllMember.Location = New System.Drawing.Point(432, 88)
        Me.Chk_SelectAllMember.Name = "Chk_SelectAllMember"
        Me.Chk_SelectAllMember.Size = New System.Drawing.Size(192, 23)
        Me.Chk_SelectAllMember.TabIndex = 446
        Me.Chk_SelectAllMember.Text = "Select All Members"
        Me.Chk_SelectAllMember.Visible = False
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(32, 112)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(376, 244)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 443
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(64, 472)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(512, 56)
        Me.GroupBox2.TabIndex = 450
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(24, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(96, 32)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(384, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(96, 32)
        Me.cmdexit.TabIndex = 8
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(264, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(96, 32)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print[F9]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(144, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(88, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View[F8]"
        '
        'Month_Bill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(640, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Month_Bill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Month_Bill"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Month_Bill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FILLTYPE()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub FILLTYPE()
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        chk_Filter_Field.Items.Clear()
        Chk_Members_List.Items.Clear()
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "==>" & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
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
       
    Function Bill_Print()
        Try
            Randomize()
            Dim pageno, i, j, sval, rval As Double
            Dim Sqlstring As String
            Dim VRowCount As Long
            Dim vCaption As String
            Dim vCitywise As String
            Dim Loopindex, typeindex, SNO As Integer
            Dim vMemType As String
            Dim vTerm As String
            Dim SelectedMember, selectedtype, seletype, mtypecode() As String
            Dim VOutputfile As String
            pageno = 1
            Randomize()
            vOutfile = Mid("remlt" & (Rnd() * 650000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                If tbx_Filter_From.Text = "" Or tbx_Filter_From.Text = "" Then
                    MsgBox("Please Select The Group Name", vbInformation)
                    chk_Filter_Field.Focus()
                    Exit Function
                End If
            Else
                If chk_Filter_Field.CheckedItems.Count <= 0 Then
                    MsgBox("Please Select The Group Name", vbInformation)
                    chk_Filter_Field.Focus()
                    Exit Function
                End If
            End If
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                Sqlstring = "select isnull(A.MCODE,'') as slcode,isnull(A.MNAME,'') as slname,"
                Sqlstring = Sqlstring & "isnull(A.CONTADD1,'') as add1,isnull(A.CONTADD2,'') as add2,isnull(A.CONTADD3,'') as add3,"
                Sqlstring = Sqlstring & "isnull(A.CONTCITY,'') as city,isnull(A.CONTSTATE,'') as state,isnull(A.CONTPIN,'') as pincode,isnull(A.CONTPHONE1,'') as pphone1,isnull(A.CONTCELL,'') as CELLNO from MEMBERMASTER A, "
                Sqlstring = Sqlstring & " view_openingbalance_net B WHERE A.MCODE=B.SLCODE AND B.AMOUNT<>0 "
                Sqlstring = Sqlstring & "  AND ISNULL(A.FREEZE,'') <> 'Y' "
                Sqlstring = Sqlstring & " and  A.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            Else
                For j = 0 To chk_Filter_Field.Items.Count - 1
                    If chk_Filter_Field.GetItemChecked(j) = True Then

                        Sqlstring = "select isnull(A.MCODE,'') as slcode,isnull(A.MNAME,'') as slname,"
                        Sqlstring = Sqlstring & "isnull(A.CONTADD1,'') as add1,isnull(A.CONTADD2,'') as add2,isnull(A.CONTADD3,'') as add3,"
                        Sqlstring = Sqlstring & "isnull(A.CONTCITY,'') as city,isnull(A.CONTSTATE,'') as state,isnull(A.CONTPIN,'') as pincode,isnull(A.CONTPHONE1,'') as pphone1,isnull(A.CONTCELL,'') as CELLNO from MEMBERMASTER A, "

                        Sqlstring = Sqlstring & " view_openingbalance_net B WHERE A.MCODE=B.SLCODE AND B.AMOUNT<>0 "
                        Sqlstring = Sqlstring & "  AND ISNULL(A.FREEZE,'') <> 'Y' "

                        Sqlstring = Sqlstring & " AND  A.MEMBERTYPECODE IN ("
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            mtypecode = Split(chk_Filter_Field.CheckedItems(i), "==>")
                            Sqlstring = Sqlstring & " '" & mtypecode(0) & "', "
                        Next
                        Sqlstring = Mid(Sqlstring, 1, Len(Sqlstring) - 2)
                        Sqlstring = Sqlstring & ")"
                        Sqlstring = Sqlstring & "  AND ISNULL(A.FREEZE,'') <> 'Y' "
                    End If
                Next
            End If
            If CHK_TMP.Checked = True Then
                Sqlstring = Sqlstring & "  AND ISNULL(A.MEMBERTYPECODE,'') <> '06' "
            End If

            Dim vbal, opbal As Double
            Dim vrow As Long
            Dim vdate, vdate1 As String
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
            'vdate = Trim(noofdays & "/" & Mid(Me.CbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            vdate = Trim(1 & "/" & Mid(Me.CbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            vdate1 = Trim(noofdays & "/" & IIf(Val(month1) < 10, "0" & month1, month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")

            Sqlstring = Sqlstring & " order by A.MCODE "
            gconnection.getDataSet(Sqlstring, "MMASTER")

            If gdataset.Tables("MMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("MMASTER").Rows.Count - 1
                    sval = 0
                    rval = 0
                    vbal = 0
                    vrow = 0
                    SNO = 1
                    pageno = 1
                    'Call getopeningbalance_member(gdataset.Tables("MMASTER").Rows(i).Item("slcode"), month1)
                    Filewrite.WriteLine()
                    Filewrite.WriteLine()
                    Filewrite.WriteLine(Space(35) & "MEMBER LEDGER" & Space(20) & Now.Date)
                    Filewrite.WriteLine()
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & ""), 1, 47))) & "Club")
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slname") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slname") & ""), 1, 47))) & "No.8, MG ROAD")
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add1") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add1") & ""), 1, 47))) & "TIN NO: 33620862226")
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 1, 30) & "," & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 32, 47) & Space(46 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 1, 46))) & "Chennai")
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 1, 30) & "," & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 32, 47) & Space(46 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 1, 46))) & "600028")
                    Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("city") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("City") & ""), 1, 47))) & "PH: 24350121,245 FAX : 24320947")
                    Filewrite.WriteLine("Pin: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pincode") & ""), 1, 42) & Space(42 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pincode") & ""), 1, 42))) & "E-MAIL: madrasclub@satyam.net.in")
                    Filewrite.WriteLine("Res: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pphone1") & ""), 1, 30) & "  Mob: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("cellno") & ""), 1, 15) & Space(15 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("cellno") & ""), 1, 15))))
                    Filewrite.WriteLine()
                    Filewrite.WriteLine("Billing for the Month of : " & CbxMonth.Text & Space(32) & "PAGE NO: " & pageno)
                    Filewrite.WriteLine()
                    Filewrite.WriteLine(StrDup(83, "="))
                    Filewrite.WriteLine("Sno  Date       Ref. No.         Details                 Cr Amt     Dr Amt Balances")
                    Filewrite.WriteLine(StrDup(83, "="))
                    Filewrite.WriteLine(Space(3))
                    vrow = vrow + 17

                    Sqlstring = " select isnull(sum(dramount)- sum(cramount),0) as amount from view_openingbalance "
                    Sqlstring = Sqlstring & " where voucherdate<'" & vdate & "' and slcode='" & Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & "'" & "")
                    gconnection.getDataSet(Sqlstring, "OPL")
                    If gdataset.Tables("OPL").Rows.Count > 0 Then
                        vmemopbal = gdataset.Tables("OPL").Rows(0).Item("AMOUNT")
                    Else
                        vmemopbal = 0
                    End If
                    If vmemopbal < 0 Then
                        rval = rval + Abs(vmemopbal)
                    Else
                        sval = sval + Abs(vmemopbal)
                    End If
                    vbal = sval - rval
                    If vmemopbal < 0 Then
                        Filewrite.WriteLine(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))) & Space(28) & "Opening Balance--> " & Space(2) & Space(12 - Len(Format(Abs(vmemopbal), "0.00"))) & Format(Abs(vmemopbal), "0.00") & Space(11) & Space(8 - Len(Format(Abs(vmemopbal), "0.00"))) & Format(Abs(vmemopbal), "0.00") & "Cr")
                    Else
                        Filewrite.WriteLine(Mid(SNO, 1, 3) & Space(Len(5 - Mid(SNO, 1, 3))) & Space(28) & "Opening Balance--> " & Space(7) & Space(10 - Len(Format(Abs(vmemopbal), "0.00"))) & Format(Abs(vmemopbal), "0.00") & Space(10 - Len(Format(Abs(vmemopbal), "0.00"))) & Format(Abs(vmemopbal), "0.00") & IIf(Abs(vmemopbal) <> 0, "Dr", ""))
                    End If
                    vrow = vrow + 1
                    Sqlstring = " SELECT ISNULL(PERIOD,'') as PERIOD,isnull(BILLNO,'') as BILLNO,ISNULL(AMOUNT,0)+ISNULL(TAXAMOUNT,0) AS AMOUNT,ISNULL(BILLDATE,'') AS BILLDATE "
                    Sqlstring = Sqlstring & " FROM SUBSPOSTING WHERE MONTH(BILLDATE)=" & month1 & " AND "
                    Sqlstring = Sqlstring & " MCODE='" & Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & "'" & "")
                    gconnection.getDataSet(Sqlstring, "SUBSCRIPTION")
                    Filewrite.WriteLine()
                    vrow = vrow + 1
                    SNO = SNO + 1
                    If gdataset.Tables("SUBSCRIPTION").Rows.Count > 0 Then
                        For j = 0 To gdataset.Tables("SUBSCRIPTION").Rows.Count - 1
                            sval = sval + Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("Amount"), "0.00")
                            vbal = (sval - rval)
                            Filewrite.Write(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))))
                            Filewrite.Write(Mid(Trim(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("BILLDATE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("BILLDATE")), 1, 10))) & Space(1))
                            Filewrite.Write(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("BILLNO"), 1, 16) & Space(16 - Len(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("BILLNO"), 1, 16))) & Space(1))
                            Filewrite.Write(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("PERIOD"), 1, 24) & Space(24 - Len(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("PERIOD"), 1, 24))) & Space(8))
                            Filewrite.Write(Space(10 - Len(Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("amount"), "0.00"))) & Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("Amount"), "0.00"))
                            Filewrite.WriteLine(Space(10 - Len(Format(Abs(vbal), "0.00"))) & Format(Abs(vbal), "0.00") & "")
                            IIf(vbal < 0, "Cr", "Dr")
                            vrow = vrow + 1
                            Filewrite.WriteLine()
                            vrow = vrow + 1
                            SNO = SNO + 1
                        Next
                    End If
                    Sqlstring = "select isnull(voucherno,'') as voucherno,isnull(Vouchertype,'') as Vouchertype,isnull(voucherdate,'') as voucherdate,isnull(amount,0) as amount,isnull(description,'') as description,isnull(creditdebit,'')as crdr from Month_Bill where Slcode= '" & gdataset.Tables("MMASTER").Rows(i).Item("slcode") & "' and  month(voucherdate) = " & month1 & ""
                    Sqlstring = Sqlstring & "  and isnull(void,'')<>'Y' and isnull(void,'')<>'C' order by voucherdate,voucherno "
                    gconnection.getDataSet(Sqlstring, "ACCOUNTS")
                    If gdataset.Tables("ACCOUNTS").Rows.Count > 0 Then
                        For j = 0 To gdataset.Tables("ACCOUNTS").Rows.Count - 1
                            If vrow > 56 Then
                                pageno = pageno + 1
                                Filewrite.WriteLine(StrDup(83, "="))
                                Filewrite.WriteLine(Chr(12))
                                'HEADING STARTING
                                vrow = 0
                                Filewrite.WriteLine()
                                Filewrite.WriteLine()
                                Filewrite.WriteLine(Space(35) & "MEMBER LEDGER" & Space(20) & Now.Date)
                                Filewrite.WriteLine()
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slcode") & ""), 1, 47))) & "Club")
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slname") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("slname") & ""), 1, 47))) & "No.8, MG ROAD")
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add1") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add1") & ""), 1, 47))) & "TIN NO: 33620862226")
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 1, 30) & "," & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 32, 47) & Space(46 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add2") & ""), 1, 46))) & "Chennai")
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 1, 30) & "," & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 32, 47) & Space(46 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("add3") & ""), 1, 46))) & "600028")
                                Filewrite.WriteLine(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("city") & ""), 1, 47) & Space(47 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("City") & ""), 1, 47))) & "PH: 24350121,245 FAX : 24320947")
                                Filewrite.WriteLine("Pin: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pincode") & ""), 1, 42) & Space(42 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pincode") & ""), 1, 42))) & "E-MAIL: madrasclub@satyam.net.in")
                                Filewrite.WriteLine("Res: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("pphone1") & ""), 1, 30) & "  Mob: " & Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("cellno") & ""), 1, 15) & Space(15 - Len(Mid(Trim(gdataset.Tables("MMASTER").Rows(i).Item("cellno") & ""), 1, 15))))
                                Filewrite.WriteLine()
                                Filewrite.WriteLine("Billing for the Month of : " & CbxMonth.Text & Space(32) & "PAGE NO: " & pageno)
                                Filewrite.WriteLine()
                                Filewrite.WriteLine(StrDup(83, "="))
                                Filewrite.WriteLine("Sno  Date       Ref. No.         Details                 Cr Amt     Dr Amt Balances")
                                Filewrite.WriteLine(StrDup(83, "="))
                                Filewrite.WriteLine(Space(3))
                                vrow = vrow + 17
                                'HEADING ENDING
                            End If
                            If gdataset.Tables("ACCOUNTS").Rows(j).Item("crdr") = "CREDIT" Then
                                rval = rval + gdataset.Tables("ACCOUNTS").Rows(j).Item("AMOUNT")
                            Else
                                sval = sval + gdataset.Tables("ACCOUNTS").Rows(j).Item("AMOUNT")
                            End If
                            vbal = (sval - rval)
                            Filewrite.Write(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))))
                            Filewrite.Write(Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("voucherdate"), "dd/MM/yyyy") & Space(11 - Len(Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("voucherdate"), "dd/MM/yyyy"))) & "")
                            Filewrite.Write(Mid(Trim(gdataset.Tables("ACCOUNTS").Rows(j).Item("voucherno")), 1, 16) & Space(16 - Len(Mid(Trim(gdataset.Tables("ACCOUNTS").Rows(j).Item("voucherno")), 1, 16))) & Space(1) & "")
                            Filewrite.Write(Mid(Trim(gdataset.Tables("ACCOUNTS").Rows(j).Item("description")), 1, 24) & Space(24 - Len(Mid(Trim(gdataset.Tables("ACCOUNTS").Rows(j).Item("description")), 1, 24))), Space(24))
                            Filewrite.Write(IIf(gdataset.Tables("ACCOUNTS").Rows(j).Item("crdr") = "CREDIT", Space(9 - Len(Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("amount"), "0.00"))) & Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("amount"), "0.00") & Space(9), Space(9) & Space(9 - Len(Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("amount"), "0.00"))) & Format(gdataset.Tables("ACCOUNTS").Rows(j).Item("amount"), "0.00")) & "")
                            Filewrite.WriteLine(Space(10 - Len(Format(Abs(vbal), "0.00"))) & Format(Abs(vbal), "0.00") & "")
                            IIf(vbal < 0, "Cr", "Dr")
                            vrow = vrow + 1
                            Filewrite.WriteLine()
                            vrow = vrow + 1
                            SNO = SNO + 1
                        Next
                    End If
                    Filewrite.WriteLine(StrDup(83, "="))
                    Filewrite.WriteLine(Space(43) & "Total " & Space(15 - Len(Format(rval, "0.00"))) & Format(rval, "0.00") & Space(1) & Space(8 - Len(Mid(Format(sval, "0.00"), 1, 8))) & Format(sval, "0.00") & Space(10 - Len(Mid(Format(Abs(vbal), "0.00"), 1, 10))) & Format(Abs(vbal), "0.00") & IIf(vbal < 0, "Cr", "Dr"))
                    Filewrite.WriteLine(StrDup(83, "="))
                    Filewrite.WriteLine(Space(5))
                    'For I = vrow To 62
                    'Print #1, ""
                    'Next I
                    Filewrite.WriteLine(Chr(12))
                Next
            End If
            Filewrite.Close()
            If gPrint = False Then
                Call OpenTextFile(vOutfile)
            Else
                Call PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Function Bill_Print_SUMMARY()
        Try
            Randomize()
            Dim pageno, i, j, OPL_SUM, SUBS_SUM, REC_SUM, TRN_SUM As Double
            Dim Sqlstring, ssql As String
            Dim VRowCount As Long
            Dim vCaption As String
            Dim vCitywise As String
            Dim Loopindex, typeindex, SNO As Integer
            Dim vMemType As String
            Dim vTerm As String
            Dim SelectedMember, selectedtype, seletype, mtypecode() As String
            Dim VOutputfile As String
            pageno = 1
            Randomize()
            vOutfile = Mid("remlt" & (Rnd() * 650000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                If tbx_Filter_From.Text = "" Or tbx_Filter_From.Text = "" Then
                    MsgBox("Please Select The Group Name", vbInformation)
                    chk_Filter_Field.Focus()
                    Exit Function
                End If
            Else
                If chk_Filter_Field.CheckedItems.Count <= 0 Then
                    MsgBox("Please Select The Group Name", vbInformation)
                    chk_Filter_Field.Focus()
                    Exit Function
                End If
            End If
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                ssql = " B.MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            Else
                For j = 0 To chk_Filter_Field.Items.Count - 1
                    If chk_Filter_Field.GetItemChecked(j) = True Then
                        ssql = " B.MEMBERTYPECODE IN ("
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            mtypecode = Split(chk_Filter_Field.CheckedItems(i), "==>")
                            ssql = ssql & " '" & mtypecode(0) & "', "
                        Next
                        ssql = Mid(ssql, 1, Len(ssql) - 2)
                        ssql = ssql & ")"
                    End If
                Next
            End If
            If CHK_TMP.Checked = True Then
                ssql = ssql & "  AND ISNULL(B.MEMBERTYPECODE,'') <> '06' "
            End If
            'gconnection.getDataSet(Sqlstring, "MMASTER")
            Dim vbal, opbal As Double
            Dim vrow As Long
            Dim vdate, vdate1 As String
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
            vdate = Trim(1 & "/" & Mid(Me.CbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            vdate1 = Trim(noofdays & "/" & IIf(Val(month1) < 10, "0" & month1, month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            SNO = 1
            pageno = 1
            OPL_SUM = 0 : SUBS_SUM = 0 : TRN_SUM = 0 : REC_SUM = 0
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine("MEMBER LEDGER" & Space(20) & Now.Date)
            Filewrite.WriteLine("Club")
            Filewrite.WriteLine("No.8, MG ROAD")
            Filewrite.WriteLine("Bangalore-600028")
            Filewrite.WriteLine("Member Ledger - Summary For The Month of : " & CbxMonth.Text & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)))
            Filewrite.WriteLine(StrDup(83, "="))
            Filewrite.WriteLine("Sno          Description                                      Amount")
            Filewrite.WriteLine(StrDup(83, "="))
            Sqlstring = " Select isnull(sum(A.dramount)- sum(A.cramount),0) as amount from view_openingbalance A ,MEMBERMASTER B"
            Sqlstring = Sqlstring & " where A.voucherdate<'" & vdate & "' and  A.SLCODE=B.MCODE AND " & ssql
            gconnection.getDataSet(Sqlstring, "OPL")
            If gdataset.Tables("OPL").Rows.Count > 0 Then
                vmemopbal = gdataset.Tables("OPL").Rows(0).Item("AMOUNT")
            Else
                vmemopbal = 0
            End If
            If vmemopbal < 0 Then
                OPL_SUM = gdataset.Tables("OPL").Rows(0).Item("AMOUNT")
                Filewrite.WriteLine(Mid(SNO, 1, 13) & Space(13 - Len(Mid(SNO, 1, 13))) & "OPENING BALANCE" & Space(31) & Space(10 - Len(Mid(Format(Abs(vmemopbal), "0.00"), 1, 10))) & Mid(Format(Abs(vmemopbal), "0.00"), 1, 10) & IIf(Abs(vmemopbal) <> 0, "Cr", ""))
            Else
                OPL_SUM = gdataset.Tables("OPL").Rows(0).Item("AMOUNT")
                Filewrite.WriteLine(Mid(SNO, 1, 13) & Space(13 - Len(Mid(SNO, 1, 13))) & "OPENING BALANCE" & Space(31) & Space(10 - Len(Mid(Format(Abs(vmemopbal), "0.00"), 1, 10))) & Mid(Format(Abs(vmemopbal), "0.00"), 1, 10) & IIf(Abs(vmemopbal) <> 0, "Dr", ""))
            End If
            Sqlstring = " SELECT ISNULL(a.PERIOD,'') as PERIOD,ISNULL(sum(a.AMOUNT),0)+ISNULL(sum(a.TAXAMOUNT),0) AS AMOUNT "
            Sqlstring = Sqlstring & " FROM SUBSPOSTING A INNER JOIN  MEMBERMASTER B ON A.MCODE=B.MCODE AND " & ssql
            Sqlstring = Sqlstring & " WHERE MONTH(BILLDATE)=" & month1 & "  group by A.PERIOD "
            gconnection.getDataSet(Sqlstring, "SUBSCRIPTION")
            Filewrite.WriteLine()
            SNO = SNO + 1
            If gdataset.Tables("SUBSCRIPTION").Rows.Count > 0 Then
                For j = 0 To gdataset.Tables("SUBSCRIPTION").Rows.Count - 1
                    SUBS_SUM = Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("Amount"), "0.00")
                    Filewrite.Write(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))) & Space(10))
                    Filewrite.Write(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("PERIOD"), 1, 24) & Space(24 - Len(Mid(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("PERIOD"), 1, 24))) & Space(22))
                    Filewrite.WriteLine(Space(10 - Len(Mid(Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("amount"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("SUBSCRIPTION").Rows(j).Item("Amount"), "0.00"), 1, 10))
                    'Filewrite.WriteLine(Space(10 - Len(Format(Abs(vbal), "0.00"))) & Format(Abs(vbal), "0.00") & "")
                    Filewrite.WriteLine()
                    SNO = SNO + 1
                Next
            End If
            Sqlstring = "select isnull(sum(A.amount),0) as amount from Month_Bill A, MEMBERMASTER B where  month(A.voucherdate) = " & month1 & " AND A.SLCODE=B.MCODE "
            Sqlstring = Sqlstring & "  and isnull(A.void,'')<>'Y' and isnull(A.void,'')<>'C' and A.creditdebit='DEBIT' AND " & ssql
            gconnection.getDataSet(Sqlstring, "TRANSACTION")
            If gdataset.Tables("TRANSACTION").Rows.Count > 0 Then
                TRN_SUM = Format(gdataset.Tables("TRANSACTION").Rows(0).Item("amount"), "0.00")
                Filewrite.Write(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))) & Space(10))
                Filewrite.Write(Mid("TRANSACTION", 1, 24) & Space(24 - Len(Mid("PAYMENT", 1, 24))) & Space(18))
                Filewrite.Write(Space(10 - Len(Format(gdataset.Tables("TRANSACTION").Rows(0).Item("amount"), "0.00"))) & Format(gdataset.Tables("TRANSACTION").Rows(0).Item("Amount"), "0.00"))
                Filewrite.WriteLine()
                SNO = SNO + 1
            End If
            Sqlstring = "select isnull(sum(A.amount),0) as amount from Month_Bill A, MEMBERMASTER B where  month(A.voucherdate) = " & month1 & " AND A.SLCODE=B.MCODE "
            Sqlstring = Sqlstring & "  and isnull(A.void,'')<>'Y' and isnull(A.void,'')<>'C' and A.creditdebit='CREDIT' AND " & ssql
            'Sqlstring = Sqlstring & "  and isnull(void,'')<>'Y' and isnull(void,'')<>'C' and creditdebit='credit' AND & ssql"
            gconnection.getDataSet(Sqlstring, "payment")
            If gdataset.Tables("Payment").Rows.Count > 0 Then
                Filewrite.WriteLine()
                REC_SUM = Format(gdataset.Tables("payment").Rows(0).Item("amount"), "0.00")
                Filewrite.Write(Mid(SNO, 1, 3) & Space(3 - Len(Mid(SNO, 1, 3))) & Space(10))
                Filewrite.Write(Mid("RECEIPT", 1, 24) & Space(24 - Len(Mid("PAYMENT", 1, 24))) & Space(22))
                Filewrite.Write(Space(10 - Len(Format(gdataset.Tables("payment").Rows(0).Item("amount"), "0.00"))) & Format(gdataset.Tables("payment").Rows(0).Item("Amount"), "0.00"))
                Filewrite.WriteLine()
                SNO = SNO + 1
            End If
            'TOTAL = (OPL_SUM + SUBS_  SUM + TRN_SUM) - REC_SUM
            Filewrite.WriteLine(StrDup(83, "="))
            Filewrite.WriteLine(Space(13) & "Total " & Space(35) & Space(15 - Len(Format((OPL_SUM + SUBS_SUM + TRN_SUM) - REC_SUM, "0.00"))) & Format((OPL_SUM + SUBS_SUM + TRN_SUM) - REC_SUM, "0.00") & IIf((OPL_SUM + SUBS_SUM + TRN_SUM) - REC_SUM < 0, "Cr", "Dr"))
            Filewrite.WriteLine(StrDup(83, "="))
            Filewrite.WriteLine(Space(5))
            'For I = vrow To 62
            'Print #1, ""
            'Next I
            Filewrite.WriteLine(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                Call OpenTextFile(vOutfile)
            Else
                Call PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
   



    Private Sub tbx_Filter_From_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            tbx_filter_To.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tbx_filter_To_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub

    Private Sub tbx_filter_To_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub


    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Dim Iteration
        Call FILLTYPE()
        chk_PrintAll.Checked = False
        Chk_SelectAllMember.Checked = False
        CbxMonth.Focus()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        If CHK_SUMMARY.Checked = True Then
            Call Bill_Print_SUMMARY()
        Else
            Call Bill_Print()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gPrint = True
        Call Bill_Print()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub




    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
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


    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
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




    Private Sub Chk_SelectAllMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllMember.CheckedChanged
        Dim Iteration As Integer
        If Chk_SelectAllMember.Checked = True Then
            Try
                For Iteration = 0 To (Chk_Members_List.Items.Count - 1)
                    Chk_Members_List.SetSelected(Iteration, True)
                    Chk_Members_List.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_Members_List.Items.Count - 1)
                    Chk_Members_List.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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


    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged
        Dim ssql, mtypecode() As String
        Dim i, j As Integer
        For j = 0 To chk_Filter_Field.Items.Count - 1
            If chk_Filter_Field.GetItemChecked(j) = True Then
                ssql = " SELECT isnull(MCODE,'') as MCODE, isnull(MNAME,'') as MNAME from MEMBERMASTER "
                ssql = ssql & " WHERE MEMBERTYPECODE IN ("
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    mtypecode = Split(chk_Filter_Field.CheckedItems(i), "==>")
                    ssql = ssql & " '" & mtypecode(0) & "', "
                Next
                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ")"

            End If
        Next
    End Sub

   
    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub

    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_filter_To.TextChanged

    End Sub
End Class