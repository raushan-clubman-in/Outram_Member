Imports System.Data.SqlClient
Public Class NewStatusconversion
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
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_EffectiveTo As System.Windows.Forms.Label
    Friend WithEvents lbl_Effectivefrom As System.Windows.Forms.Label
    Friend WithEvents lbl_NewStatus As System.Windows.Forms.Label
    Friend WithEvents lbl_PresentStatus As System.Windows.Forms.Label
    Friend WithEvents txt_PresentStatus As System.Windows.Forms.TextBox
    Friend WithEvents dtp_EffectiveTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_EffectiveFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_NewStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_reasons As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewStatusconversion))
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_EffectiveTo = New System.Windows.Forms.Label
        Me.lbl_Effectivefrom = New System.Windows.Forms.Label
        Me.lbl_NewStatus = New System.Windows.Forms.Label
        Me.lbl_PresentStatus = New System.Windows.Forms.Label
        Me.txt_PresentStatus = New System.Windows.Forms.TextBox
        Me.dtp_EffectiveTo = New System.Windows.Forms.DateTimePicker
        Me.dtp_EffectiveFrom = New System.Windows.Forms.DateTimePicker
        Me.cbo_NewStatus = New System.Windows.Forms.ComboBox
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.Cbo_reasons = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(272, 64)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(32, 200)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(75, 21)
        Me.lbl_Remarks.TabIndex = 20
        Me.lbl_Remarks.Text = "Remarks :"
        '
        'lbl_EffectiveTo
        '
        Me.lbl_EffectiveTo.AutoSize = True
        Me.lbl_EffectiveTo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_EffectiveTo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EffectiveTo.Location = New System.Drawing.Point(832, 272)
        Me.lbl_EffectiveTo.Name = "lbl_EffectiveTo"
        Me.lbl_EffectiveTo.Size = New System.Drawing.Size(95, 21)
        Me.lbl_EffectiveTo.TabIndex = 23
        Me.lbl_EffectiveTo.Text = "Effective To :"
        Me.lbl_EffectiveTo.Visible = False
        '
        'lbl_Effectivefrom
        '
        Me.lbl_Effectivefrom.AutoSize = True
        Me.lbl_Effectivefrom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Effectivefrom.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Effectivefrom.Location = New System.Drawing.Point(32, 256)
        Me.lbl_Effectivefrom.Name = "lbl_Effectivefrom"
        Me.lbl_Effectivefrom.Size = New System.Drawing.Size(114, 21)
        Me.lbl_Effectivefrom.TabIndex = 22
        Me.lbl_Effectivefrom.Text = "Effective From :"
        Me.lbl_Effectivefrom.Visible = False
        '
        'lbl_NewStatus
        '
        Me.lbl_NewStatus.AutoSize = True
        Me.lbl_NewStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NewStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewStatus.Location = New System.Drawing.Point(32, 160)
        Me.lbl_NewStatus.Name = "lbl_NewStatus"
        Me.lbl_NewStatus.Size = New System.Drawing.Size(89, 21)
        Me.lbl_NewStatus.TabIndex = 19
        Me.lbl_NewStatus.Text = "New Status :"
        '
        'lbl_PresentStatus
        '
        Me.lbl_PresentStatus.AutoSize = True
        Me.lbl_PresentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PresentStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PresentStatus.Location = New System.Drawing.Point(32, 112)
        Me.lbl_PresentStatus.Name = "lbl_PresentStatus"
        Me.lbl_PresentStatus.Size = New System.Drawing.Size(109, 21)
        Me.lbl_PresentStatus.TabIndex = 18
        Me.lbl_PresentStatus.Text = "Present Status :"
        '
        'txt_PresentStatus
        '
        Me.txt_PresentStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_PresentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PresentStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PresentStatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PresentStatus.Location = New System.Drawing.Point(152, 112)
        Me.txt_PresentStatus.Name = "txt_PresentStatus"
        Me.txt_PresentStatus.Size = New System.Drawing.Size(224, 22)
        Me.txt_PresentStatus.TabIndex = 3
        Me.txt_PresentStatus.Text = ""
        '
        'dtp_EffectiveTo
        '
        Me.dtp_EffectiveTo.CustomFormat = "dd/MM/yyyy"
        Me.dtp_EffectiveTo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_EffectiveTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_EffectiveTo.Location = New System.Drawing.Point(800, 360)
        Me.dtp_EffectiveTo.Name = "dtp_EffectiveTo"
        Me.dtp_EffectiveTo.Size = New System.Drawing.Size(8, 21)
        Me.dtp_EffectiveTo.TabIndex = 7
        Me.dtp_EffectiveTo.Visible = False
        '
        'dtp_EffectiveFrom
        '
        Me.dtp_EffectiveFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtp_EffectiveFrom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_EffectiveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_EffectiveFrom.Location = New System.Drawing.Point(152, 256)
        Me.dtp_EffectiveFrom.Name = "dtp_EffectiveFrom"
        Me.dtp_EffectiveFrom.Size = New System.Drawing.Size(152, 21)
        Me.dtp_EffectiveFrom.TabIndex = 6
        Me.dtp_EffectiveFrom.Visible = False
        '
        'cbo_NewStatus
        '
        Me.cbo_NewStatus.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_NewStatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_NewStatus.Location = New System.Drawing.Point(152, 160)
        Me.cbo_NewStatus.Name = "cbo_NewStatus"
        Me.cbo_NewStatus.Size = New System.Drawing.Size(224, 23)
        Me.cbo_NewStatus.TabIndex = 4
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(32, 64)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(109, 21)
        Me.lbl_MemberCode.TabIndex = 15
        Me.lbl_MemberCode.Text = "Member Code :"
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(304, 64)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(114, 21)
        Me.lbl_MemberName.TabIndex = 16
        Me.lbl_MemberName.Text = "Member Name :"
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(424, 64)
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 22)
        Me.txt_MemberName.TabIndex = 2
        Me.txt_MemberName.Text = ""
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.BackgroundImage = CType(resources.GetObject("cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(496, 360)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 12
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 378
        Me.Label1.Text = "Press [F4] For Help"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(384, 360)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 11
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ListView.BackgroundImage = CType(resources.GetObject("cmd_ListView.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Image = CType(resources.GetObject("cmd_ListView.Image"), System.Drawing.Image)
        Me.cmd_ListView.Location = New System.Drawing.Point(160, 360)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 9
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Delete.BackgroundImage = CType(resources.GetObject("cmd_Delete.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Delete.Enabled = False
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(272, 360)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 10
        Me.cmd_Delete.Text = "Delete [F7]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_AddNew.BackgroundImage = CType(resources.GetObject("cmd_AddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Image = CType(resources.GetObject("cmd_AddNew.Image"), System.Drawing.Image)
        Me.cmd_AddNew.Location = New System.Drawing.Point(48, 360)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 8
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(152, 64)
        Me.txt_MemberCode.MaxLength = 10
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(120, 22)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'Cbo_reasons
        '
        Me.Cbo_reasons.BackColor = System.Drawing.Color.White
        Me.Cbo_reasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_reasons.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_reasons.Location = New System.Drawing.Point(152, 200)
        Me.Cbo_reasons.Name = "Cbo_reasons"
        Me.Cbo_reasons.Size = New System.Drawing.Size(392, 27)
        Me.Cbo_reasons.TabIndex = 710
        '
        'NewStatusconversion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(662, 436)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_EffectiveTo)
        Me.Controls.Add(Me.lbl_Effectivefrom)
        Me.Controls.Add(Me.lbl_NewStatus)
        Me.Controls.Add(Me.lbl_PresentStatus)
        Me.Controls.Add(Me.txt_PresentStatus)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.dtp_EffectiveFrom)
        Me.Controls.Add(Me.cbo_NewStatus)
        Me.Controls.Add(Me.dtp_EffectiveTo)
        Me.Controls.Add(Me.Cbo_reasons)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "NewStatusconversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBERSHIP ACTIVATION"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim SqlString, TERMINATED, ter As String
    Dim gconnection As New GlobalClass
    Private Sub NewStatusconversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtp_EffectiveFrom.Value = Now
        'dtp_EffectiveTo.Value = Now
        If gUserCategory <> "S" Then
            Call GetRights()
            TERMINATED = "N"
        Else
            TERMINATED = "Y"
        End If
        Call Reasons()
        Call Status()
        statusconversionbool = True
        Me.txt_MemberCode.Enabled = True
        Me.txt_MemberName.ReadOnly = True
        Me.txt_PresentStatus.ReadOnly = True
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
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Try
            Dim pstatus, nstatus As String
            If cmd_AddNew.Text = "Update[F5]" Then
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!")
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If

                If (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then

                    pstatus = txt_PresentStatus.Text
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        'nstatus = "LIVE"
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    '  End If
                    lbl_Effectivefrom.Visible = True
                    dtp_EffectiveFrom.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "ABSENTEE") Or (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "SUSPENDED") Or (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (Trim(txt_PresentStatus.Text) = "DEFAULTER" And Trim(cbo_NewStatus.Text) = "ABSENTEE" Or Trim((txt_PresentStatus.Text) = "ABSENTEE" And Trim(cbo_NewStatus.Text) = "DEFAULTER")) Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = False
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = False
                ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "SUSPENDED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "EXPIRED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (txt_PresentStatus.Text = "EXPIRED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "BLOCKED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "INACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "N" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "LIVE" And cbo_NewStatus.Text = "INACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "LIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "SUSPENDED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "TERMINATED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True


                ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "DEFAULTER") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "TERMINATED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "EXPIRED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True

                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "EXPIRED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True


                Else
                    'MessageBox.Show("Your Select Status cannot Convert!")
                    'cbo_NewStatus.Select()
                    'lbl_Effectivefrom.Visible = False
                    'lbl_EffectiveTo.Visible = False
                    'dtp_EffectiveFrom.Visible = False
                    'dtp_EffectiveTo.Visible = False
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                End If
            End If

            If cmd_AddNew.Text = "Add New[F5]" Then
                pstatus = txt_PresentStatus.Text
                nstatus = cbo_NewStatus.Text
            
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!", MyCompanyName)
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If

                'MsgBox("Member Not available...")
                '''******************************************************** $ Insert record into MEMBER LEDGER $ **************************************************************'''
                Call checkValidation() '''---> CHECK VALIDATION
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO  Memberledger"
                SqlString = SqlString & "(MCODE,MNAME,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,USERID,ADDDATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & Trim(pstatus) & "','" & Trim(nstatus) & "','" & Trim(Cbo_reasons.Text) & "',"
                SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                gconnection.dataOperation(1, SqlString, "Memberledger")
                '''''******************************************************* $ Update record into MEMBER MASTER $ **************************************************************'''
                SqlString = " UPDATE membermaster SET CurentStatus='" & cbo_NewStatus.Text & "' WHERE MCODE='" & txt_MemberCode.Text & "'"
                gconnection.dataOperation(2, SqlString, "Memberledger")

                SqlString = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons.Text & "')"
                gconnection.dataOperation(2, SqlString, "Memberledger")

                MessageBox.Show("Record Saved Successfully!", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)

            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                '''******************************************************** $ Update record into MEMBER LEDGER $ ****************************************************************'''
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!")
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If
                Call checkValidation() '''---> CHECK VALIDATION
                Dim SQLSTRING1 As String
                Dim SQLSTRING2 As String
                If boolchk = False Then Exit Sub
                SQLSTRING1 = "insert into Memberledger (MCODE,MNAME,NEWSTATUS,PRESENTSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,USERID,ADDDATE) values('" & txt_MemberCode.Text & "','" & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & txt_PresentStatus.Text & "','" & Cbo_reasons.Text & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'DBS',getdate())"
                SQLSTRING2 = " UPDATE membermaster SET CurentStatus='" & Trim(nstatus) & "',StatusDateFrom=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),StatusDateTo=Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103) WHERE MCODE='" & txt_MemberCode.Text & "'"

                gconnection.dataOperation(2, SQLSTRING1, "Memberledger")
                gconnection.dataOperation(1, SQLSTRING2, "MemberMaster")

                SqlString = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons.Text & "')"
                gconnection.dataOperation(2, SqlString, "Memberledger")

                MessageBox.Show("Record Updated Successfully! ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click

    End Sub

    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM memberledger"
        Gheader = "MEMBER LEDGER"
        FrReport.SsGridReport.SetText(2, 1, "MCODE")
        FrReport.SsGridReport.SetText(3, 1, 15)
        '        FrReport.SsGridReport.SetText(2, 2, "MNAME")
        '        FrReport.SsGridReport.SetText(3, 2, 50)
        FrReport.SsGridReport.SetText(2, 2, "NEWSTATUS")
        FrReport.SsGridReport.SetText(3, 2, 20)
        FrReport.SsGridReport.SetText(2, 3, "PRESENTSTATUS")
        FrReport.SsGridReport.SetText(3, 3, 20)
        FrReport.SsGridReport.SetText(2, 4, "REMARKS")
        FrReport.SsGridReport.SetText(3, 4, 50)
        FrReport.SsGridReport.SetText(2, 5, "EFFECTIVEFROM")
        FrReport.SsGridReport.SetText(3, 5, 10)
        FrReport.SsGridReport.SetText(2, 6, "EFFECTIVETO")
        FrReport.SsGridReport.SetText(3, 6, 10)
        FrReport.Show()
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        Cbo_reasons.Text = ""
        dtp_EffectiveFrom.Text = ""
        dtp_EffectiveTo.Text = ""
        txt_MemberCode.Enabled = True
        txt_MemberCode.Focus()
        lbl_Effectivefrom.Visible = False
        lbl_EffectiveTo.Visible = False
        dtp_EffectiveFrom.Visible = False
        dtp_EffectiveTo.Visible = False
        cmd_AddNew.Text = "Add New[F5]"
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    txt_MemberCode.Focus()
        'End If
    End Sub

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_MemberName.Focus()
        End If
    End Sub

    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PresentStatus.Focus()
        End If
    End Sub

    Private Sub txt_PresentStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PresentStatus.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_NewStatus.Focus()
        End If
    End Sub

    Private Sub cbo_NewStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_NewStatus.KeyPress
        BLANK(e)
        If Asc(e.KeyChar) = 13 Then
            Cbo_reasons.Focus()
        End If
    End Sub

    Private Sub txt_Remarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            dtp_EffectiveFrom.Focus()
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        Call cmd_Clear_Click(sender, e)
        '''************************************** $ View MCODE,MNAME from Membermaster $ **************************************'''
        gSQLString = "SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME,isnull(CURENTSTATUS,'') as CURENTSTATUS FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME,CURENTSTATUS"
        vform.vFormatstring = "  Member Code  | Member Name  | Current Status                          "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_MemberCode.Text = Trim(vform.keyfield & "")
            txt_MemberName.Text = Trim(vform.keyfield1)
            If (vform.keyfield2 = "LIVE") Or (vform.keyfield2 = "ACTIVE") Then
                'txt_PresentStatus.Text = Trim(vform.keyfield2)
                txt_PresentStatus.Text = "ACTIVE"
            Else
                txt_PresentStatus.Text = Trim(vform.keyfield2)
            End If

        End If
        vform.Close()
        vform = Nothing
        '''************************************************************ $ End Validating $ *******************************************************'''
        '''************************************* $ Check if MCODE is present in MEMBERLEDGER then update command will show $ *********************'''
        SqlString = "SELECT count(MCODE) FROM Memberledger WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
        gconnection.openConnection()
        gcommand = New SqlCommand(SqlString, gconnection.Myconn)
        gdreader = gcommand.ExecuteReader
        If gdreader.Read Then
            If gdreader(0) = 0 Then
                cmd_AddNew.Text = "Add New[F5]"
                txt_MemberCode.Enabled = False
                txt_MemberName.ReadOnly = True
                txt_PresentStatus.ReadOnly = True
                cbo_NewStatus.Focus()
            Else
                cmd_AddNew.Text = "Update[F5]"
                txt_MemberCode.Enabled = False
                txt_MemberName.ReadOnly = True
                txt_PresentStatus.ReadOnly = True
                cbo_NewStatus.Focus()
            End If
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        Else
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End If
        '''************************************************************ $ End Validating $ ******************************************************'''
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Try
            '''******************************************** $ Validate Member Code while entering data $ **********************************'''
            SqlString = "SELECT count(mcode) FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "'"
            gconnection.closeConnection()
            gconnection.openConnection()
            gcommand = New SqlCommand(SqlString, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read = False Then
                If gdreader(0) = 0 Then
                    txt_MemberCode.Text = ""
                    txt_MemberCode.Enabled = True
                    txt_MemberCode.Focus()
                Else
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                    Exit Sub
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            '----------
            '''*********************************************************** $ End Validating $ ********************************************'''
            '''*********************************************************** $ View all record $ *******************************************'''
            Dim Statusconv As New DataTable
            Dim Statusconv1 As New DataTable
            Dim strSQL As String
            'strSQL = " SELECT isnull(ReferenceNo,'') as ReferenceNo,isnull(ReferenceName,'') as ReferenceName,isnull(MCODE,'') as MCODE,isnull(PRESENTSTATUS,'') as PRESENTSTATUS,isnull(NEWSTATUS,'') as NEWSTATUS,isnull(REMARKS,'') as REMARKS,isnull(EFFECTIVEFROM,'') as EFFECTIVEFROM,isnull(EFFECTIVETO,'') as EFFECTIVETO,isnull(USERID,'') as USERID,isnull(ADDDATE,'') as ADDDATE FROM memberledger WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
            strSQL = " SELECT isnull(ReferenceNo,'') as ReferenceNo,isnull(ReferenceName,'') as ReferenceName,isnull(MCODE,'') as MCODE,isnull(PRESENTSTATUS,'') as PRESENTSTATUS,isnull(NEWSTATUS,'') as NEWSTATUS,isnull(REMARKS,'') as REMARKS,isnull(Convert(datetime,EFFECTIVEFROM,103),'') as EFFECTIVEFROM,isnull(Convert(datetime,EFFECTIVETO,103),'') as EFFECTIVETO,isnull(USERID,'') as USERID,isnull(Convert(datetime,ADDDATE,103),'') as ADDDATE FROM memberledger WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "' AND slno = (select max(slno) from memberledger where mcode = '" & Trim(Me.txt_MemberCode.Text) & "') "
            Statusconv = gconnection.GetValues(strSQL)
            If Statusconv.Rows.Count > 0 Then
                Me.txt_MemberCode.Enabled = False
                Me.txt_MemberName.ReadOnly = True
                Me.txt_PresentStatus.ReadOnly = True
                Me.txt_PresentStatus.Text = Statusconv.Rows(0).Item("NEWSTATUS")
                Me.cbo_NewStatus.Text = Statusconv.Rows(0).Item("PRESENTSTATUS")
                Me.Cbo_reasons.Text = Statusconv.Rows(0).Item("REMARKS")
                Me.dtp_EffectiveFrom.Text = Statusconv.Rows(0).Item("EFFECTIVEFROM")
                Me.dtp_EffectiveTo.Text = Statusconv.Rows(0).Item("EFFECTIVETO")
                strSQL = " SELECT isnull(mname,'') as mname,isnull(curentstatus,'') as curentstatus,isnull(Convert(datetime,doj,103),'') as doj FROM memberMASTER WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
                Statusconv1 = gconnection.GetValues(strSQL)
                If Statusconv.Rows.Count > 0 Then
                    'Me.txt_PresentStatus.Text = Statusconv1.Rows(0).Item("CURENTSTATUS")
                    'Me.cbo_NewStatus.Text = "ACTIVE"
                    Me.cmd_AddNew.Text = "Add New[F5]"
                End If
                Me.cmd_AddNew.Text = "Update[F5]"
            Else
                strSQL = " SELECT isnull(mname,'') as mname,isnull(curentstatus,'') as curentstatus,isnull(Convert(datetime,doj,103),'') as doj FROM memberMASTER WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
                Statusconv = gconnection.GetValues(strSQL)
                If Statusconv.Rows.Count > 0 Then
                    Me.txt_MemberCode.Enabled = False
                    Me.txt_MemberName.ReadOnly = True
                    Me.txt_PresentStatus.ReadOnly = True
                    Me.txt_MemberName.Text = Statusconv.Rows(0).Item("MNAME")
                    Me.cbo_NewStatus.Text = "Select New Status"
                    'Me.txt_Remarks.Text = "No Details availabel in Data Base"
                    'Me.dtp_EffectiveFrom.Text = Statusconv.Rows(0).Item("DOJ")
                    Me.cmd_AddNew.Text = "Add New[F5]"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        lbl_Effectivefrom.Visible = True
        lbl_EffectiveTo.Visible = True
        dtp_EffectiveFrom.Visible = True
        dtp_EffectiveTo.Visible = True
    End Sub
    Private Sub dtp_EffectiveFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_EffectiveFrom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_EffectiveTo.Focus()
        End If
    End Sub
    Private Sub dtp_EffectiveTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_EffectiveTo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        If cbo_NewStatus.Text = "Select New Status" Then
            MessageBox.Show(" Status Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_NewStatus.Focus()
            Exit Sub
        End If
        '''****************************** $ Check Member Code is blank $ **************************************'''
        If Trim(txt_MemberCode.Text) = "" Then
            MessageBox.Show(" Member Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''***************************** $ Check Member Name is blank & **************************************'''
        If Trim(txt_MemberName.Text) = "" Then
            MessageBox.Show(" Member Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberName.Focus()
            Exit Sub
        End If
        '''***************************** $ Present Status can't be blank & **************************************'''
        If Trim(txt_PresentStatus.Text) = "" Then
            MessageBox.Show(" Present Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_PresentStatus.Focus()
            Exit Sub
        End If
        '''***************************** $ New status can't be blank & **************************************'''
        If Trim(cbo_NewStatus.Text) = "" Then
            MessageBox.Show(" New Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_NewStatus.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub NewStatusconversion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        statusconversionbool = False
    End Sub

    Private Sub NewStatusconversion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        Dim posting As DataTable
        Dim sqlstr As String
        Dim vform As New ListOperation
        Dim dr As SqlDataReader
        If e.KeyCode = Keys.Enter And Trim(txt_MemberCode.Text) <> "" Then
            gSQLString = "SELECT MCODE,MNAME,curentstatus FROM membermaster where mcode='" & txt_MemberCode.Text & "'"
            posting = gconnection.GetValues(gSQLString)
            If posting.Rows.Count > 0 Then
                txt_MemberName.Text = posting.Rows(0).Item("mname")
                txt_PresentStatus.Text = posting.Rows(0).Item("curentstatus")
                txt_PresentStatus.Focus()
            End If
            gconnection.closeConnection()
            SqlString = "SELECT count(MCODE) FROM Memberledger WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            gconnection.openConnection()
            gcommand = New SqlCommand(SqlString, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) = 0 Then
                    cmd_AddNew.Text = "Add New[F5]"
                    txt_MemberCode.Enabled = False
                    txt_MemberName.ReadOnly = True
                    txt_PresentStatus.ReadOnly = True
                    cbo_NewStatus.Focus()
                Else
                    cmd_AddNew.Text = "Update[F5]"
                    txt_MemberCode.Enabled = False
                    txt_MemberName.ReadOnly = True
                    txt_PresentStatus.ReadOnly = True
                    cbo_NewStatus.Focus()
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        End If
        If e.KeyCode = Keys.Enter And Trim(txt_MemberCode.Text) = "" Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
        '  Call cmd_MemberCodeHelp_Click(sender, e)
        cmd_AddNew.Text = "Update[F5]"
    End Sub


    Private Sub cbo_NewStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_NewStatus.SelectedIndexChanged
        If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
            MessageBox.Show("Present Status and Current Status should'nt be same!")
            cbo_NewStatus.Text = ""
            Exit Sub
        End If
        If (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "LIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "LIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "INACTIVE") Or (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "ABSENTEE") Or (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "TERIMINATED") Or (txt_PresentStatus.Text = "TERIMINATED" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ABSENTEE") Then
            lbl_Effectivefrom.Visible = False
            lbl_EffectiveTo.Visible = False
            dtp_EffectiveFrom.Visible = False
            dtp_EffectiveTo.Visible = False
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "DEFAULTER") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        Else
            'MessageBox.Show("Your Select Status cannot Convert!")
            cbo_NewStatus.Select()
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = False
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = False

            Exit Sub
        End If

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
    Public Sub Status()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT distinct(Name) FROM MemberStatusMaster where isnull(STATUS,'')='RELEASE' and freeze<>'Y'and isnull(STATUS,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_NewStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub
End Class
