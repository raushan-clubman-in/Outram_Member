Imports System.Data

Public Class AffiliatedClubFacility
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Lbl_SerName As System.Windows.Forms.Label
    Friend WithEvents Lbl_SerCode As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFacilityDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtFacilityCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdAffiliatedFacilityHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AffiliatedClubFacility))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmdAffiliatedFacilityHelp = New System.Windows.Forms.Button
        Me.Lbl_SerName = New System.Windows.Forms.Label
        Me.txtFacilityDescription = New System.Windows.Forms.TextBox
        Me.Lbl_SerCode = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFacilityCode = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(315, 17)
        Me.Label5.TabIndex = 448
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(512, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 17)
        Me.Label4.TabIndex = 447
        Me.Label4.Text = "[F4]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 441
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
        Me.Cmd_Freeze.Location = New System.Drawing.Point(244, 16)
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
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(240, 224)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 446
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(96, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(448, 29)
        Me.Label16.TabIndex = 442
        Me.Label16.Text = "AFFLIATED CLUB FACILITY DETAILS"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAffiliatedFacilityHelp
        '
        Me.cmdAffiliatedFacilityHelp.Image = CType(resources.GetObject("cmdAffiliatedFacilityHelp.Image"), System.Drawing.Image)
        Me.cmdAffiliatedFacilityHelp.Location = New System.Drawing.Point(488, 96)
        Me.cmdAffiliatedFacilityHelp.Name = "cmdAffiliatedFacilityHelp"
        Me.cmdAffiliatedFacilityHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdAffiliatedFacilityHelp.TabIndex = 439
        '
        'Lbl_SerName
        '
        Me.Lbl_SerName.AutoSize = True
        Me.Lbl_SerName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SerName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SerName.Location = New System.Drawing.Point(64, 136)
        Me.Lbl_SerName.Name = "Lbl_SerName"
        Me.Lbl_SerName.Size = New System.Drawing.Size(149, 17)
        Me.Lbl_SerName.TabIndex = 445
        Me.Lbl_SerName.Text = "FACILITY DESCRIPTION :"
        '
        'txtFacilityDescription
        '
        Me.txtFacilityDescription.BackColor = System.Drawing.Color.Wheat
        Me.txtFacilityDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacilityDescription.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacilityDescription.Location = New System.Drawing.Point(280, 136)
        Me.txtFacilityDescription.MaxLength = 50
        Me.txtFacilityDescription.Name = "txtFacilityDescription"
        Me.txtFacilityDescription.Size = New System.Drawing.Size(208, 26)
        Me.txtFacilityDescription.TabIndex = 440
        Me.txtFacilityDescription.Text = ""
        '
        'Lbl_SerCode
        '
        Me.Lbl_SerCode.AutoSize = True
        Me.Lbl_SerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SerCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SerCode.Location = New System.Drawing.Point(64, 96)
        Me.Lbl_SerCode.Name = "Lbl_SerCode"
        Me.Lbl_SerCode.Size = New System.Drawing.Size(102, 17)
        Me.Lbl_SerCode.TabIndex = 444
        Me.Lbl_SerCode.Text = "FACILITY CODE :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtFacilityCode)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(40, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 152)
        Me.GroupBox1.TabIndex = 443
        Me.GroupBox1.TabStop = False
        '
        'txtFacilityCode
        '
        Me.txtFacilityCode.BackColor = System.Drawing.Color.Wheat
        Me.txtFacilityCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacilityCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacilityCode.Location = New System.Drawing.Point(240, 48)
        Me.txtFacilityCode.MaxLength = 50
        Me.txtFacilityCode.Name = "txtFacilityCode"
        Me.txtFacilityCode.Size = New System.Drawing.Size(208, 26)
        Me.txtFacilityCode.TabIndex = 431
        Me.txtFacilityCode.Text = ""
        '
        'AffiliatedClubFacility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(656, 350)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdAffiliatedFacilityHelp)
        Me.Controls.Add(Me.Lbl_SerName)
        Me.Controls.Add(Me.txtFacilityDescription)
        Me.Controls.Add(Me.Lbl_SerCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AffiliatedClubFacility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AffiliatedClubFacility"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        txtFacilityCode.Text = ""
        txtFacilityDescription.Text = ""
        txtFacilityCode.Focus()
        Cmd_Add.Text = "Add[F7]"
        txtFacilityCode.ReadOnly = False
        txtFacilityDescription.ReadOnly = False
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM Tbl_AffiliatedFacilityMaster"
        Gheader = " AFFILIATED FACILITY MASTER VIEW "
        FrReport.SsGridReport.SetText(2, 1, "FACILITYCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "FACILITYDESCRIPTION")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        FrReport.SsGridReport.SetText(3, 4, 55)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  Tbl_AffiliatedFacilityMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE FacilityCode = '" & Trim(txtFacilityCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "Tbl_AffiliatedFacilityMaster")
            MessageBox.Show("Record Freeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add[F7]"
        Else
            sqlstring = "UPDATE  Tbl_AffiliatedFacilityMaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE FacilityCode = '" & Trim(txtFacilityCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "Tbl_AffiliatedFacilityMaster")
            MessageBox.Show("Record UNFreeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            If Cmd_Add.Text = "Add[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                sqlstring = "Insert into Tbl_AffiliatedFacilityMaster"
                sqlstring = sqlstring + "(FacilityCode,FacilityDescription,Freeze,AddUser,Adddatetime)"
                sqlstring = sqlstring + "values('" + Trim(txtFacilityCode.Text) + "','" + Trim(txtFacilityDescription.Text) + "', 'N','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                gconnection.dataOperation(1, sqlstring, "Tbl_AffiliatedFacilityMaster")
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
                sqlstring = "Update Tbl_AffiliatedFacilityMaster SET "
                sqlstring = sqlstring + "FacilityDescription='" + Trim(txtFacilityDescription.Text) + "',Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' Where FacilityCode='" + Trim(txtFacilityCode.Text) + "'"
                gconnection.dataOperation(2, sqlstring, "Tbl_AffiliatedFacilityMaster")
                MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add[F7]"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdAffiliatedFacilityHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAffiliatedFacilityHelp.Click
        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(FACILITYCODE,'') AS FACILITYCODE, ISNULL(FACILITYDESCRIPTION,'') AS FACILITYDESCRIPTION  FROM Tbl_AffiliatedFacilityMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "FACILITYCODE, FACILITYDESCRIPTION"
        vform.vFormatstring = "         FACILITY CODE                    |                 FACILITY DESCRIPTION              "
        vform.vCaption = "AFFILIATED FACILITY MASTER HELP "
        vform.KeyPos = 0
        vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtFacilityCode.Text = Trim(vform.keyfield & "")
            txtFacilityDescription.Text = Trim(vform.keyfield1 & "")
            txtFacilityCode.Select()
            txtFacilityCode.ReadOnly = True
            'txtRankDescription.ReadOnly = True
        End If
        vform.Close()
        vform = Nothing
        Cmd_Add.Text = "Update[F5]"
    End Sub

    Public Sub checkValidation()
        boolchk = False
        
        '''********** Check  Server desc Can't be blank *********************'''
        If Trim(txtFacilityCode.Text) = "" Then
            MessageBox.Show(" Facility Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFacilityCode.Focus()
            Exit Sub
        End If

        If Trim(txtFacilityDescription.Text) = "" Then
            MessageBox.Show(" Facility Description can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFacilityDescription.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub AffiliatedClubFacility_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F8 Then
        '    Call Cmd_Freeze_Click(Cmd_Freeze, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call Cmd_View_Click(Cmd_View, e)
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.F8 Then
            If Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub
    Private Sub AffiliatedClubFacility_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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

    Private Sub AffiliatedClubFacility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdAffiliatedFacilityHelp.Enabled = True
        ServerMastbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
End Class
