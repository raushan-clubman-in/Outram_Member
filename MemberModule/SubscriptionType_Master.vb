Imports System.Data
Public Class SubscriptionType_Master
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Txtcode As System.Windows.Forms.TextBox
    Friend WithEvents cmdMasterHelp As System.Windows.Forms.Button
    Friend WithEvents Lbl_SerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubscriptionType_Master))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmdMasterHelp = New System.Windows.Forms.Button
        Me.Txtcode = New System.Windows.Forms.TextBox
        Me.Lbl_SerName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 56)
        Me.GroupBox2.TabIndex = 421
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(472, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 0
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(358, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(240, 16)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 1
        Me.Cmd_Add.Text = "Add[F7]"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(232, 272)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(228, 27)
        Me.lbl_Freeze.TabIndex = 426
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Wheat
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(248, 176)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 21)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = ""
        '
        'cmdMasterHelp
        '
        Me.cmdMasterHelp.Image = CType(resources.GetObject("cmdMasterHelp.Image"), System.Drawing.Image)
        Me.cmdMasterHelp.Location = New System.Drawing.Point(352, 120)
        Me.cmdMasterHelp.Name = "cmdMasterHelp"
        Me.cmdMasterHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdMasterHelp.TabIndex = 3
        '
        'Txtcode
        '
        Me.Txtcode.BackColor = System.Drawing.Color.Wheat
        Me.Txtcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcode.Location = New System.Drawing.Point(248, 120)
        Me.Txtcode.MaxLength = 10
        Me.Txtcode.Name = "Txtcode"
        Me.Txtcode.Size = New System.Drawing.Size(104, 21)
        Me.Txtcode.TabIndex = 1
        Me.Txtcode.Text = ""
        '
        'Lbl_SerName
        '
        Me.Lbl_SerName.AutoSize = True
        Me.Lbl_SerName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SerName.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SerName.Location = New System.Drawing.Point(112, 176)
        Me.Lbl_SerName.Name = "Lbl_SerName"
        Me.Lbl_SerName.Size = New System.Drawing.Size(109, 18)
        Me.Lbl_SerName.TabIndex = 427
        Me.Lbl_SerName.Text = "DESCRIPTIONS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 428
        Me.Label1.Text = "CODE:"
        '
        'SubscriptionType_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(664, 430)
        Me.Controls.Add(Me.Lbl_SerName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtcode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdMasterHelp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "SubscriptionType_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubscriptionType_Master"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        If Cmd_Add.Text = "Add[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = "Insert into Tbl_SubscriptionType_Master"
            sqlstring = sqlstring + "(Code,Name,Freeze,AddUser,Adddatetime)"
            sqlstring = sqlstring + "values('" + Trim(Txtcode.Text) + "','" + Trim(txtName.Text) + "', 'N','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "Tbl_SubscriptionType_Master")
            MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F5]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                    Exit Sub
                End If
            End If
            sqlstring = "Update Tbl_SubscriptionType_Master SET "
            sqlstring = sqlstring + "Name='" + Trim(txtName.Text) + "',Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' Where Code='" + Trim(Txtcode.Text) + "'"
            gconnection.dataOperation(2, sqlstring, "Tbl_SubscriptionType_Master")
            MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  Tbl_SubscriptionType_Master "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddatetime=getdate()"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "Tbl_SubscriptionType_Master")
            MessageBox.Show("Record Freeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add[F7]"
        Else
            sqlstring = "UPDATE  Tbl_SubscriptionType_Master "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime=getdate()"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "Tbl_SubscriptionType_Master")
            MessageBox.Show("Record UNFreeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM Tbl_SubscriptionType_Master"
        Gheader = " MASTER VIEW "
        FrReport.SsGridReport.SetText(2, 1, "CODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "NAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        FrReport.SsGridReport.SetText(3, 3, 55)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False
        ''********** Check  Server desc Can't be blank *********************'''
        If Trim(Txtcode.Text) = "" Then
            MessageBox.Show(" Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtcode.Focus()
            Exit Sub
        End If

        If Trim(txtName.Text) = "" Then
            MessageBox.Show(" Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add[F7]"
        Txtcode.ReadOnly = False
        txtName.ReadOnly = False
        Cmd_Freeze.Enabled = True
        Cmd_Add.Text = "Add[F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Txtcode.Focus()
    End Sub
    'Private Sub SubscriptionType_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.F6 Then
    '        Call Cmd_Clear_Click(Cmd_Clear, e)
    '        Exit Sub
    '    End If
    '    'If e.KeyCode = Keys.F8 Then
    '    '    Call Cmd_Freeze_Click(Cmd_Freeze, e)
    '    '    Exit Sub
    '    'End If
    '    'If e.KeyCode = Keys.F7 Then
    '    '    Call Cmd_Add_Click(Cmd_Add, e)
    '    '    Exit Sub
    '    'End If
    '    'If e.KeyCode = Keys.F9 Then
    '    '    Call Cmd_View_Click(Cmd_View, e)
    '    '    Exit Sub
    '    'End If
    '    If e.KeyCode = Keys.F8 Then
    '        If Cmd_Freeze.Enabled = True Then
    '            Call Cmd_Freeze_Click(Cmd_Freeze, e)
    '            Exit Sub
    '        End If
    '    End If
    '    If e.KeyCode = Keys.F7 Then
    '        If Cmd_Add.Enabled = True Then
    '            Call Cmd_Add_Click(Cmd_Add, e)
    '            Exit Sub
    '        End If
    '    End If
    '    If e.KeyCode = Keys.F9 Then
    '        If Cmd_View.Enabled = True Then
    '            Call Cmd_View_Click(Cmd_View, e)
    '            Exit Sub
    '        End If
    '    End If
    '    If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
    '        Call Cmd_Exit_Click(Cmd_Exit, e)
    '        Exit Sub
    '    End If
    'End Sub
    Private Sub SubscriptionType_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ServerMastbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub txtRankName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'If txtRankName.Text = "" Then
                '    cmdRankMasterHelp_Click(sender, e)

                'Else
                '    'cbo_Title.Focus()
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub SubscriptionType_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If Cmd_Add.Enabled = True Then
                    Call Cmd_Add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If Cmd_Clear.Enabled = True Then
                    Call Cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If Cmd_View.Enabled = True Then
                    Call Cmd_View_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If Cmd_Freeze.Enabled = True Then
                    Call Cmd_Freeze_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Cmd_Exit.Enabled = True Then
                    Call Cmd_Exit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SubscriptionType_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ServerMastbool = False
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcode.TextChanged

    End Sub


    Private Sub Txtcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txtcode.Text = "" Then
                    Call cmdMasterHelp_Click(sender, e)
                    txtName.Focus()
                Else
                    Call Txtcode_Validated(sender, e)
                    txtName.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmdMasterHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMasterHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME  FROM Tbl_SubscriptionType_Master "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "NAME"
        vform.vFormatstring = "  CODE   |   NAME             "
        vform.vCaption = "MASTER HELP "
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txtcode.Text = Trim(vform.keyfield & "")
            txtName.Text = Trim(vform.keyfield1 & "")
            Call Txtcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        Cmd_Add.Text = "Update[F5]"

        Dim dt As New DataTable
        Dim ssql As String
        ssql = " Select Freeze  From Tbl_SubscriptionType_Master Where Code='" & Txtcode.Text & "'"
        dt = gconnection.GetValues(ssql)
        If dt.Rows.Count > 0 Then

            If dt.Rows(0).Item("Freeze") = "Y" Then

                Me.Cmd_Freeze.Text = "UnFreeze[F7]"
            Else

                Me.Cmd_Freeze.Text = "Freeze[F7]"

            End If
            Me.Cmd_Add.Text = "Update[F5]"
        Else

            Me.Cmd_Add.Text = "Add[F7]"
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub Txtcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcode.Validated
        Try
            Dim I, J As Integer
            Dim Sqlstr As String
            If Txtcode.Text <> "" Then
                Sqlstr = " SELECT ISNULL(Code,'') AS CODE,ISNULL(Name,'')AS NAME,ISNULL(Freeze,'')AS Freeze FROM Tbl_SubscriptionType_Master  WHERE CODE='" & Trim(Txtcode.Text) & "'"
                gconnection.getDataSet(Sqlstr, "Master")
                If gdataset.Tables("Master").Rows.Count > 0 Then
                    Txtcode.ReadOnly = True
                    txtName.Text = gdataset.Tables("Master").Rows(0).Item("Name")
                    Me.Cmd_Add.Text = "Update[F5]"
                Else
                    txtName.Text = ""

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        getCharater(e)
    End Sub
End Class
