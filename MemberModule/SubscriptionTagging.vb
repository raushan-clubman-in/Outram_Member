Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class SubscriptionTagging
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
    Public WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents lbl_MembeName As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents chkList_Subscription As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_freeze As System.Windows.Forms.CheckBox
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubscriptionTagging))
        Me.lbl_MembeName = New System.Windows.Forms.Label
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.Label124 = New System.Windows.Forms.Label
        Me.chkList_Subscription = New System.Windows.Forms.CheckedListBox
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.cmd_Freeze = New System.Windows.Forms.Button
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.Grp_Print = New System.Windows.Forms.GroupBox
        Me.Chk_freeze = New System.Windows.Forms.CheckBox
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMD_WINDOWS = New System.Windows.Forms.Button
        Me.CMD_DOS = New System.Windows.Forms.Button
        Me.Grp_Print.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_MembeName
        '
        Me.lbl_MembeName.AutoSize = True
        Me.lbl_MembeName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MembeName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MembeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_MembeName.Location = New System.Drawing.Point(360, 97)
        Me.lbl_MembeName.Name = "lbl_MembeName"
        Me.lbl_MembeName.Size = New System.Drawing.Size(126, 20)
        Me.lbl_MembeName.TabIndex = 12
        Me.lbl_MembeName.Text = "Member Name :"
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_MemberCode.Location = New System.Drawing.Point(72, 97)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(135, 20)
        Me.lbl_MemberCode.TabIndex = 11
        Me.lbl_MemberCode.Text = "Member  Code :"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.BackColor = System.Drawing.Color.Transparent
        Me.Label124.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label124.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.Black
        Me.Label124.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label124.Location = New System.Drawing.Point(64, 144)
        Me.Label124.Name = "Label124"
        Me.Label124.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label124.Size = New System.Drawing.Size(182, 20)
        Me.Label124.TabIndex = 14
        Me.Label124.Text = "Select Subscription"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkList_Subscription
        '
        Me.chkList_Subscription.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chkList_Subscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkList_Subscription.ColumnWidth = 25
        Me.chkList_Subscription.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkList_Subscription.Location = New System.Drawing.Point(64, 176)
        Me.chkList_Subscription.Name = "chkList_Subscription"
        Me.chkList_Subscription.ScrollAlwaysVisible = True
        Me.chkList_Subscription.Size = New System.Drawing.Size(656, 211)
        Me.chkList_Subscription.TabIndex = 3
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(488, 96)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.Size = New System.Drawing.Size(232, 21)
        Me.txt_MemberName.TabIndex = 2
        Me.txt_MemberName.Text = ""
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(328, 94)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(208, 96)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(120, 21)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.BackgroundImage = CType(resources.GetObject("cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_Exit.Location = New System.Drawing.Point(552, 472)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 8
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_Clear.Location = New System.Drawing.Point(440, 472)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 7
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.Color.Transparent
        Me.cmd_ListView.BackgroundImage = CType(resources.GetObject("cmd_ListView.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Image = CType(resources.GetObject("cmd_ListView.Image"), System.Drawing.Image)
        Me.cmd_ListView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_ListView.Location = New System.Drawing.Point(224, 472)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 5
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Delete.BackgroundImage = CType(resources.GetObject("cmd_Delete.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_Delete.Location = New System.Drawing.Point(392, 472)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 6
        Me.cmd_Delete.Text = "Delete [F7]"
        Me.cmd_Delete.Visible = False
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.Color.Transparent
        Me.cmd_AddNew.BackgroundImage = CType(resources.GetObject("cmd_AddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Image = CType(resources.GetObject("cmd_AddNew.Image"), System.Drawing.Image)
        Me.cmd_AddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_AddNew.Location = New System.Drawing.Point(112, 472)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 4
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'cmd_Freeze
        '
        Me.cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.cmd_Freeze.Image = CType(resources.GetObject("cmd_Freeze.Image"), System.Drawing.Image)
        Me.cmd_Freeze.Location = New System.Drawing.Point(336, 472)
        Me.cmd_Freeze.Name = "cmd_Freeze"
        Me.cmd_Freeze.Size = New System.Drawing.Size(96, 32)
        Me.cmd_Freeze.TabIndex = 358
        Me.cmd_Freeze.Text = "Freeze[F9]"
        '
        'lbl_Frez
        '
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(224, 416)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Frez.TabIndex = 359
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Chk_freeze)
        Me.Grp_Print.Controls.Add(Me.CMDEXIT)
        Me.Grp_Print.Controls.Add(Me.CMD_WINDOWS)
        Me.Grp_Print.Controls.Add(Me.CMD_DOS)
        Me.Grp_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Print.Location = New System.Drawing.Point(184, 384)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(352, 64)
        Me.Grp_Print.TabIndex = 657
        Me.Grp_Print.TabStop = False
        Me.Grp_Print.Visible = False
        '
        'Chk_freeze
        '
        Me.Chk_freeze.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_freeze.Location = New System.Drawing.Point(352, 24)
        Me.Chk_freeze.Name = "Chk_freeze"
        Me.Chk_freeze.Size = New System.Drawing.Size(88, 24)
        Me.Chk_freeze.TabIndex = 3
        Me.Chk_freeze.Text = "Freeze"
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.White
        Me.CMDEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDEXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.White
        Me.CMDEXIT.Image = CType(resources.GetObject("CMDEXIT.Image"), System.Drawing.Image)
        Me.CMDEXIT.Location = New System.Drawing.Point(248, 16)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(96, 32)
        Me.CMDEXIT.TabIndex = 2
        Me.CMDEXIT.Text = "EXIT"
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.BackColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.ForeColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.Image = CType(resources.GetObject("CMD_WINDOWS.Image"), System.Drawing.Image)
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(136, 16)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(96, 32)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        '
        'CMD_DOS
        '
        Me.CMD_DOS.BackColor = System.Drawing.Color.White
        Me.CMD_DOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.ForeColor = System.Drawing.Color.White
        Me.CMD_DOS.Image = CType(resources.GetObject("CMD_DOS.Image"), System.Drawing.Image)
        Me.CMD_DOS.Location = New System.Drawing.Point(24, 16)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(96, 32)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        '
        'SubscriptionTagging
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 558)
        Me.Controls.Add(Me.Grp_Print)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_Freeze)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_MembeName)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.Label124)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.chkList_Subscription)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "SubscriptionTagging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubscriptionTagging "
        Me.Grp_Print.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim sqlstring, TempString(2) As String
    Dim subscode, subsdesc As String
    Dim i As Integer
    Private Sub SubscriptionTagging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DR As DataRow
        'sqlstring = "SELECT isnull(subscode,'') as subscode,isnull(SubsDesc,'') as SubsDesc FROM subscriptionmast  where  ltrim(rtrim(type))='SPECIAL'"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        sqlstring = "SELECT isnull(subscode,'') as subscode,isnull(SubsDesc,'') as SubsDesc FROM subscriptionmast where Type='SPECIAL'order by SubsDesc"
        gconnection.getDataSet(sqlstring, "substagging")
        Try
            If gdataset.Tables("substagging").Rows.Count > 0 Then
                For Each DR In gdataset.Tables("substagging").Rows
                    '                    chkList_Subscription.Items.Add(Trim(DR("subscode")) & " | " & Trim(DR("subsdesc")))
                    chkList_Subscription.Items.Add(Trim(Mid(DR("subsdesc"), 1, 50)) & Space(50 - Len(Trim(Mid(DR("subsdesc"), 1, 50)))) & Space(200) & " | " & DR("subscode"))
                Next
                gdataset.Tables("SubsTagging").Dispose()
            End If
        Catch ex As Exception
            MsgBox("Sorry! there is an Error! Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
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
        Me.cmd_AddNew.Enabled = False
        Me.cmd_Delete.Enabled = False
        Me.cmd_ListView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_AddNew.Enabled = True
                    Me.cmd_Delete.Enabled = True
                    Me.cmd_ListView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_AddNew.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_ListView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MemberName.Focus()
        End If
    End Sub

    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            chkList_Subscription.Focus()
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_MemberCode.Text = Trim(vform.keyfield & "")
            txt_MemberName.Text = Trim(vform.keyfield1)
            Call txt_MemberCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        sqlstring = "SELECT count(MCODE) FROM subscriptionTagging WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
        gconnection.openConnection()
        gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
        gdreader = gcommand.ExecuteReader
        If gdreader.Read Then
            If gdreader(0) = 0 Then
                cmd_AddNew.Text = "Add New[F5]"
            Else
                cmd_AddNew.Text = "Update[F5]"
            End If
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        Else
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End If
    End Sub
    Private Sub chkList_Subscription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkList_Subscription.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    txt_MemberCode.Focus()
        'End If

    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        clearform(Me)
        For i = 0 To chkList_Subscription.Items.Count - 1
            chkList_Subscription.SetItemChecked(i, False)
        Next i
        txt_MemberCode.Enabled = True
        txt_MemberCode.Focus()
        chkList_Subscription.Enabled = True
        cmd_AddNew.Text = "Add New[F5]"
        Me.cmd_Freeze.Text = "Freeze[F9]"
    End Sub
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Try
            Call checkValidation() '''--->CHECK VALIDATION
            If boolchk = False Then Exit Sub
            If cmd_AddNew.Text = "Add New[F5]" Then
                For i = 0 To chkList_Subscription.Items.Count - 1
                    If chkList_Subscription.GetItemChecked(i) = True Then
                        TempString = Split(chkList_Subscription.Items.Item(i), " | ")
                        subscode = Trim(TempString(1))
                        subsdesc = Trim(TempString(0))
                        sqlstring = "INSERT INTO  SubscriptionTagging "
                        sqlstring = sqlstring & "(MCODE,MNAME,SUBSCRIPTIONTYPE,SUBSCODE,USERID,ADDDATE) VALUES ('" & Trim(txt_MemberCode.Text) & " ' ,'" & Trim(txt_MemberName.Text) & "','" & _
                        subsdesc & " ','" & subscode & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        'chkList_Subscription.Items.Item(i) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        gconnection.dataOperation(1, sqlstring, "SubscriptionMast")
                        subscode = ""
                        subsdesc = ""
                    End If
                Next i
                MessageBox.Show("Record Saved ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                sqlstring = " DELETE FROM SubscriptionTagging WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(6, sqlstring, "SubscriptionTagging")
                For i = 0 To chkList_Subscription.Items.Count - 1
                    If chkList_Subscription.GetItemChecked(i) = True Then
                        TempString = Split(chkList_Subscription.Items.Item(i), " | ")
                        subscode = Trim(TempString(1))
                        subsdesc = Trim(TempString(0))
                        sqlstring = "INSERT INTO  SubscriptionTagging "
                        sqlstring = sqlstring & "(MCODE,MNAME,SUBSCRIPTIONTYPE,SUBSCODE,USERID,ADDDATE) VALUES ('" & Trim(txt_MemberCode.Text) & " ' ,'" & Trim(txt_MemberName.Text) & "','" & _
                        subsdesc & " ','" & subscode & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        gconnection.dataOperation(2, sqlstring, "SubscriptionMast")
                        subscode = ""
                        subsdesc = ""
                        'sqlstring = "INSERT INTO  SubscriptionTagging "
                        'sqlstring = sqlstring & "(MCODE,MNAME,SUBSCRIPTIONTYPE,USERID,ADDDATE) VALUES ('" & Trim(txt_MemberCode.Text) & " ' ,'" & Trim(txt_MemberName.Text) & "','" & _
                        'chkList_Subscription.Items.Item(i) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "' )"
                        'gconnection.dataOperation(2, sqlstring, "SubscriptionMast")
                    End If
                Next i
                MessageBox.Show("Record Updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd_AddNew.Text = "Add New[F5]"
            End If
            gconnection.dataOperation(2, "UPDATE MEMBERMASTER SET TAG = 'Y' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "'", "MemberMaster")
            Me.cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Member Code is blank
        If Trim(txt_MemberCode.Text) = "" Then
            MessageBox.Show(" Member Code can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''********** Check Member Name is blank
        If Trim(txt_MemberName.Text) = "" Then
            MessageBox.Show(" Member Name can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberName.Focus()
            Exit Sub
        End If
        '''********** Check Subscription Field is blank
        If chkList_Subscription.CheckedItems.Count = 0 Then
            MessageBox.Show(" Subscription Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            chkList_Subscription.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub SubscriptionTagging_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Grp_Print.Visible = True
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Try
            Call checkValidation() '''--->CHECK VALIDATION
            If boolchk = False Then Exit Sub
            sqlstring = " DELETE FROM SubscriptionTagging WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
            gconnection.dataOperation(6, sqlstring, "SubscriptionTagging")
            MessageBox.Show("Record Deleted ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            gconnection.dataOperation(2, "UPDATE MEMBERMASTER SET TAG = 'N'", "MemberMaster")
            Me.cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubscriptionTagging_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        subscriptiontaggingbool = False
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strsubscription, STRSQL As String
        Dim dr As DataRow
        Dim j As Long
        If txt_MemberCode.Text <> "" Then
            sqlstring = " SELECT *  FROM Membermaster WHERE mcode='" & Me.txt_MemberCode.Text & "'"
            gconnection.getDataSet(sqlstring, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                Me.txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("mname")
            Else
                MsgBox("member not available.........")
                txt_MemberCode.Focus()
            End If
        End If
        sqlstring = "SELECT  subscriptiontype,freeze FROM subscriptiontagging WHERE mcode='" & txt_MemberCode.Text & "'"
        gconnection.getDataSet(sqlstring, "substagging")
        ''Try
        ''    If gdataset.Tables("substagging").Rows.Count > 0 Then
        ''        For i = 0 To chkList_Subscription.Items.Count - 1
        ''            If gdataset.Tables("substagging").Rows(0).Item("subscriptiontype") = Trim(CStr(chkList_Subscription.Items.Item(i))) Then
        ''                chkList_Subscription.SetItemChecked(i, True)
        ''            End If
        ''        Next i
        ''    End If
        ''Catch ex As Exception
        ''    MsgBox("Sorry! there is an Error! Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        ''End Try
        'gconnection.openConnection()
        'gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
        'gdreader = gcommand.ExecuteReader
        'If gdreader.Read Then
        ''If gdataset.Tables("substagging").Rows.Count > 0 Then
        ''    cmd_AddNew.Text = "Update[F5]"
        ''    'Do
        ''    For i = 0 To chkList_Subscription.Items.Count - 1
        ''        TempString = Split(chkList_Subscription.Items.Item(i), ".")
        ''        subscode = Trim(TempString(0))
        ''        subsdesc = Trim(TempString(1))
        ''        'If Trim(CStr(gdreader("subscriptiontype"))) = Trim(CStr(chkList_Subscription.Items.Item(i))) Then
        ''        If gdataset.Tables("substagging").Rows.Count > i Then
        ''            If Trim(CStr(gdataset.Tables("substagging").Rows(i).Item("subscriptiontype"))) = Trim(CStr(subsdesc)) Then
        ''                chkList_Subscription.SetItemChecked(i, True)
        ''            End If
        ''        End If
        ''    Next i
        ''    subscode = ""
        ''    subsdesc = ""
        'If gdataset.Tables("substagging").Rows(i).Item("freeze") = "F" Then
        '    Me.lbl_Frez.Visible = True
        '    Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(gdataset.Tables("substagging").Rows(i).Item("AddDate"), "dd-MMM-yyyy")
        '    Me.cmd_Delete.Text = "UnFreeze[F7]"
        'Else
        '    Me.lbl_Frez.Visible = False
        '    Me.lbl_Frez.Text = "Record Freezed  On "
        '    Me.cmd_Delete.Text = "Freeze[F7]"
        'End If
        If gdataset.Tables("substagging").Rows.Count > 0 Then
            cmd_AddNew.Text = "Update[F5]"
            'Do
            For i = 0 To gdataset.Tables("substagging").Rows.Count - 1
                For j = 0 To chkList_Subscription.Items.Count - 1
                    TempString = Split(chkList_Subscription.Items.Item(j), " | ")
                    subscode = Trim(TempString(1))
                    subsdesc = Trim(TempString(0))
                    If Trim(CStr(gdataset.Tables("substagging").Rows(i).Item("subscriptiontype"))) = Trim(CStr(subsdesc)) Then
                        chkList_Subscription.SetItemChecked(j, True)
                    End If
                    subscode = ""
                    subsdesc = ""
                Next j
            Next i
            'Loop Until Not gdreader.Read
            'gdreader.Close()
            'gcommand.Dispose()
            'gconnection.closeConnection()
        Else
            'cmd_AddNew.Text = "Add New[F5]"
            'gdreader.Close()
            'gcommand.Dispose()
            'gconnection.closeConnection()
        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        If e.KeyCode = Keys.Return Then
            If txt_MemberCode.Text = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
    End Sub


    Private Sub cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Freeze.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
            gconnection.dataOperation(3, sqlstring, "MCODE")

            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, sqlstring, "MCODE")
            gconnection.closeConnection()
            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        Else
            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
            gconnection.dataOperation(4, sqlstring, "MCODE")

            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, sqlstring, "MCODE")
            gconnection.closeConnection()
            MessageBox.Show("Record UNFreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        End If

    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_DOS.Click
        Dim FrReport As New ReportDesigner
        tables = "FROM subscriptiontagging"
        Gheader = "SUBSCRIPTION TAGGING"
        FrReport.SsGridReport.SetText(2, 1, "MCODE")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "SUBSCRIPTIONTYPE")
        FrReport.SsGridReport.SetText(3, 2, 50)
        FrReport.Show()
    End Sub

    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New ReportViwer
        Dim r As New Cry_SUBSCRIPTIONTAGGING
        'If Chk_freeze.Checked = True Then
        '    sqlstring = "select * from MM_VIEW_SUBSCRIPTIONTAGGING where freeze='Y'"
        'Else
        sqlstring = "select * from MM_VIEW_SUBSCRIPTIONTAGGING "
        'End If
        Call Viewer.GetDetails1(sqlstring, "MM_VIEW_SUBSCRIPTIONTAGGING", r)
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
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub
End Class
