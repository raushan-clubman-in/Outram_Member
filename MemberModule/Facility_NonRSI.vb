Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Facility_NONRSI
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim frmdate As Date, todate As Date
    Dim _frmdate As Date, _todate As Date
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
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents LIST_FACILITY As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents txtFacilities As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents PNL_FACILITY As System.Windows.Forms.Panel
    Friend WithEvents SSGRIND1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid_Fac As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Facility_NONRSI))
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.LIST_FACILITY = New System.Windows.Forms.CheckedListBox
        Me.Label101 = New System.Windows.Forms.Label
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.cmd_Add = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.lbl_mname = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.lbl_CorporateCode = New System.Windows.Forms.Label
        Me.txtFacilities = New System.Windows.Forms.TextBox
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.ssgrid_Fac = New AxFPSpreadADO.AxfpSpread
        Me.AxfpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.PNL_FACILITY = New System.Windows.Forms.Panel
        Me.SSGRIND1 = New AxFPSpreadADO.AxfpSpread
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_FACILITY.SuspendLayout()
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_Caption.Location = New System.Drawing.Point(376, 24)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(251, 30)
        Me.lbl_Caption.TabIndex = 27
        Me.lbl_Caption.Text = "FACILITIES DETAILS"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LIST_FACILITY
        '
        Me.LIST_FACILITY.Location = New System.Drawing.Point(768, 424)
        Me.LIST_FACILITY.Name = "LIST_FACILITY"
        Me.LIST_FACILITY.Size = New System.Drawing.Size(16, 79)
        Me.LIST_FACILITY.TabIndex = 121
        Me.LIST_FACILITY.Visible = False
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.Color.Transparent
        Me.Label101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label101.Location = New System.Drawing.Point(232, 600)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(512, 56)
        Me.Label101.TabIndex = 122
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(616, 616)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 127
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(280, 615)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 126
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.White
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(504, 616)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 124
        Me.cmd_View.Text = "Export"
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.White
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.Location = New System.Drawing.Point(392, 615)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Add.TabIndex = 123
        Me.cmd_Add.Text = "Add[F7]"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(560, 104)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(27, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 584
        '
        'lbl_mname
        '
        Me.lbl_mname.AutoSize = True
        Me.lbl_mname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mname.Location = New System.Drawing.Point(591, 104)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(0, 21)
        Me.lbl_mname.TabIndex = 583
        '
        'txt_mcode
        '
        Me.txt_mcode.BackColor = System.Drawing.Color.White
        Me.txt_mcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_mcode.Location = New System.Drawing.Point(496, 104)
        Me.txt_mcode.MaxLength = 35
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(64, 24)
        Me.txt_mcode.TabIndex = 582
        Me.txt_mcode.Text = ""
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(376, 104)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(128, 21)
        Me.lbl_CorporateCode.TabIndex = 580
        Me.lbl_CorporateCode.Text = "MemberShip No:"
        '
        'txtFacilities
        '
        Me.txtFacilities.Location = New System.Drawing.Point(592, 448)
        Me.txtFacilities.Name = "txtFacilities"
        Me.txtFacilities.TabIndex = 586
        Me.txtFacilities.Text = ""
        Me.txtFacilities.Visible = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(848, 656)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 587
        Me.Cmd_Print.Text = "Print[F10]"
        Me.Cmd_Print.Visible = False
        '
        'ssgrid_Fac
        '
        Me.ssgrid_Fac.DataSource = Nothing
        Me.ssgrid_Fac.Location = New System.Drawing.Point(64, 136)
        Me.ssgrid_Fac.Name = "ssgrid_Fac"
        Me.ssgrid_Fac.OcxState = CType(resources.GetObject("ssgrid_Fac.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_Fac.Size = New System.Drawing.Size(904, 456)
        Me.ssgrid_Fac.TabIndex = 589
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.ContainingControl = Me
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.OcxState = CType(resources.GetObject("AxfpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxfpSpread1.Size = New System.Drawing.Size(599, 227)
        Me.AxfpSpread1.TabIndex = 590
        '
        'PNL_FACILITY
        '
        Me.PNL_FACILITY.BackgroundImage = CType(resources.GetObject("PNL_FACILITY.BackgroundImage"), System.Drawing.Image)
        Me.PNL_FACILITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_FACILITY.Controls.Add(Me.SSGRIND1)
        Me.PNL_FACILITY.Location = New System.Drawing.Point(64, 8)
        Me.PNL_FACILITY.Name = "PNL_FACILITY"
        Me.PNL_FACILITY.Size = New System.Drawing.Size(312, 128)
        Me.PNL_FACILITY.TabIndex = 590
        Me.PNL_FACILITY.Visible = False
        '
        'SSGRIND1
        '
        Me.SSGRIND1.ContainingControl = Me
        Me.SSGRIND1.DataSource = Nothing
        Me.SSGRIND1.Location = New System.Drawing.Point(0, 0)
        Me.SSGRIND1.Name = "SSGRIND1"
        Me.SSGRIND1.OcxState = CType(resources.GetObject("SSGRIND1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRIND1.Size = New System.Drawing.Size(312, 128)
        Me.SSGRIND1.TabIndex = 590
        '
        'Facility_NONRSI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(960, 678)
        Me.Controls.Add(Me.PNL_FACILITY)
        Me.Controls.Add(Me.ssgrid_Fac)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.txtFacilities)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Add)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.LIST_FACILITY)
        Me.KeyPreview = True
        Me.Name = "Facility_NONRSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FacilityMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_FACILITY.ResumeLayout(False)
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Facility_NONRSI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_mcode.Focus()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmd_Clear_Click(sender, e)
    End Sub
    Function Fac_Validate()
        Try
            Dim ssql, sname, type, _sname, _type As String
            Dim i, j, Actrow As Integer
            With ssgrid_Fac
                For j = 1 To .DataRowCnt
                    .Col = 5
                    .Row = .ActiveRow
                    If .Text <> "" Then
                        frmdate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    .Col = 6
                    .Row = .ActiveRow
                    If .Text <> "" Then
                        todate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    If frmdate.ToString <> "" And todate.ToString <> "" Then
                        If Checkdaterangevalidate(frmdate, todate) = False Then
                            .Col = 6
                            .Row = .ActiveRow
                            .Text = ""
                            .Focus()
                            Return False
                            Exit Function
                        End If
                    End If
                Next
            End With
            For i = 1 To ssgrid_Fac.DataRowCnt
                sname = ""
                type = ""
                With ssgrid_Fac
                    .Col = 2
                    .Row = i
                    sname = Trim(.Text)
                    .Col = 3
                    .Row = i
                    type = Trim(.Text)
                    .Col = 5
                    .Row = i
                    If .Text <> "" Then
                        frmdate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    .Col = 6
                    .Row = i
                    If .Text <> "" Then
                        todate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    If sname <> "" And type <> "" Then
                        For j = 1 To .DataRowCnt
                            If i <> j Then
                                _sname = ""
                                _type = ""
                                .Col = 2
                                .Row = j
                                _sname = Trim(.Text)
                                .Col = 3
                                .Row = j
                                _type = Trim(.Text)
                                .Col = 5
                                .Row = j
                                If .Text <> "" Then
                                    _frmdate = Format(CDate(.Text), "dd/MM/yyyy")
                                End If
                                .Col = 6
                                .Row = j
                                If .Text <> "" Then
                                    _todate = Format(CDate(.Text), "dd/MM/yyyy")
                                End If
                                If _frmdate.ToString <> "" And _todate.ToString <> "" And _type <> "" And _sname <> "" Then
                                    If sname = _sname And type = _type And frmdate = _frmdate And todate = _todate Then
                                        MessageBox.Show("Alread Entered,Kindly Remove The Any one Record")
                                        .Col = 3
                                        .Row = .ActiveRow
                                        .Focus()
                                        Return False
                                        Exit Function
                                    End If
                                End If
                            End If
                        Next
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
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
        Me.cmd_Add.Enabled = False
        'Me.cmd_Freeze.Enabled = False
        Me.cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_Add.Enabled = True
                    'Me.cmd_Freeze.Enabled = True
                    Me.cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub
    Public Function facilities()
        Dim I As Integer
        LIST_FACILITY.Items.Clear()
        sqlstring = " Select isnull(subscode,'')as poscode,isnull(subsdesc,'')as posdesc from subscriptionmast where isnull(facility_flg,'')='F'"
        gconnection.getDataSet(sqlstring, "FACILITY_MST")
        If gdataset.Tables("FACILITY_MST").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("FACILITY_MST").Rows.Count - 1
                With gdataset.Tables("FACILITY_MST").Rows(I)
                    LIST_FACILITY.Items.Add(Trim(.Item("POSCODE")) & "==>" & Trim(.Item("POSDESC")))
                End With
            Next I
        End If

    End Function
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click

        Dim vform As New ListOperation
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " "
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        'Dim vsplit(), type() As String
        'Dim j As Integer
        'Try
        '    If Trim(txt_mcode.Text) <> "" Then

        '        sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_mcode.Text & "'"
        '        gconnection.getDataSet(sqlstring, "MNAME")
        '        If gdataset.Tables("MNAME").Rows.Count > 0 Then
        '            lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))
        '        End If

        '        sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(TYPE,'') AS TYPE,ISNULL(DNAME,'') AS DNAME,ISNULL(FCODE,'') AS FCODE,ISNULL(FROMDATE,'') AS FROMDATE,ISNULL(TODATE,'') AS TODATE,ISNULL(ACT_FLAG,'') AS ACTFLAG FROM facility_HDR WHERE MCODE='" & txt_mcode.Text & "'"
        '        gconnection.getDataSet(sqlstring, "FACILITY")
        '        If gdataset.Tables("FACILITY").Rows.Count > 0 Then
        '            ssgrid_Fac.ClearRange(1, 1, -1, 1 - 1, True)
        '            SSGRIND1.ClearRange(1, 1, -1, 1 - 1, True)
        '            txt_mcode.Text = Trim(gdataset.Tables("FACILITY").Rows(0).Item("MCODE"))
        '            txt_mcode.ReadOnly = True
        '            ssgrid_Fac.SetActiveCell(1, 1)
        '            ssgrid_Fac.Focus()
        '            With ssgrid_Fac
        '                For j = 0 To gdataset.Tables("FACILITY").Rows.Count - 1
        '                    .Col = 1
        '                    .Row = j + 1
        '                    .Text = gdataset.Tables("FACILITY").Rows(j).Item("TYPE")
        '                    .Col = 2
        '                    .Row = j + 1
        '                    .Text = gdataset.Tables("FACILITY").Rows(j).Item("DNAME")
        '                    .Col = 3
        '                    .Row = j + 1
        '                    .Text = gdataset.Tables("FACILITY").Rows(j).Item("FCODE")

        '                    sqlstring = "SELECT ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(SUBSDESC,'') AS SUBSDESC  FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & gdataset.Tables("FACILITY").Rows(j).Item("FCODE") & "'"
        '                    gconnection.getDataSet(sqlstring, "FDESC")
        '                    If gdataset.Tables("FDESC").Rows.Count > 0 Then
        '                        .Col = 4
        '                        .Row = j + 1
        '                        .Text = Trim(gdataset.Tables("FDESC").Rows(0).Item("SUBSDESC"))
        '                    End If

        '                    .Col = 5
        '                    .Row = j + 1
        '                    .Text = Format(CDate(gdataset.Tables("FACILITY").Rows(j).Item("FROMDATE")), "dd/MM/yyy")
        '                    .Col = 6
        '                    .Row = j + 1
        '                    .Text = Format(CDate(gdataset.Tables("FACILITY").Rows(j).Item("TODATE")), "dd/MM/yyy")
        '                    .Col = 7
        '                    .Row = j + 1
        '                    .Text = IIf(gdataset.Tables("FACILITY").Rows(j).Item("ACTFLAG") = "Y", 1, 0)

        '                Next
        '            End With
        '            ssgrid_Fac.SetActiveCell(1, 1)
        '            ssgrid_Fac.Focus()

        '        Else
        '            sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_mcode.Text & "'"
        '            gconnection.getDataSet(sqlstring, "MNAME")
        '            If gdataset.Tables("MNAME").Rows.Count > 0 Then
        '                lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))
        '                txt_mcode.ReadOnly = True
        '                'ssgrid_Fac.SetActiveCell(1, 1)
        '                'ssgrid_Fac.Focus()
        '            End If
        '        End If
        '    End If
        '    ssgrid_Fac.SetActiveCell(1, 1)
        '    ssgrid_Fac.Focus()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        Dim vsplit(), type() As String
        Dim j As Integer
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(TYPE,'') AS TYPE,ISNULL(DNAME,'') AS DNAME,ISNULL(FCODE,'') AS FCODE,ISNULL(FROMDATE,'') AS FROMDATE,ISNULL(TODATE,'') AS TODATE,ISNULL(ACT_FLAG,'') AS ACTFLAG FROM facility_HDR WHERE MCODE='" & txt_mcode.Text & "'"
                gconnection.getDataSet(sqlstring, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    ssgrid_Fac.ClearRange(1, 1, -1, 1 - 1, True)
                    SSGRIND1.ClearRange(1, 1, -1, 1 - 1, True)
                    txt_mcode.Text = Trim(gdataset.Tables("FACILITY").Rows(0).Item("MCODE"))
                    txt_mcode.ReadOnly = True
                    ssgrid_Fac.SetActiveCell(1, 1)
                    ssgrid_Fac.Focus()
                    With ssgrid_Fac
                        For j = 0 To gdataset.Tables("FACILITY").Rows.Count - 1
                            .Col = 1
                            .Row = j + 1
                            .Text = gdataset.Tables("FACILITY").Rows(j).Item("TYPE")
                            .Col = 2
                            .Row = j + 1
                            .Text = gdataset.Tables("FACILITY").Rows(j).Item("DNAME")
                            .Col = 3
                            .Row = j + 1
                            .Text = gdataset.Tables("FACILITY").Rows(j).Item("FCODE")

                            sqlstring = "SELECT ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(SUBSDESC,'') AS SUBSDESC  FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & gdataset.Tables("FACILITY").Rows(j).Item("FCODE") & "'"
                            gconnection.getDataSet(sqlstring, "FDESC")
                            If gdataset.Tables("FDESC").Rows.Count > 0 Then
                                .Col = 4
                                .Row = j + 1
                                .Text = Trim(gdataset.Tables("FDESC").Rows(0).Item("SUBSDESC"))
                            End If
                            .Col = 5
                            .Row = j + 1
                            .Text = Format(CDate(gdataset.Tables("FACILITY").Rows(j).Item("FROMDATE")), "dd/MM/yyy")
                            .Col = 6
                            .Row = j + 1
                            .Text = Format(CDate(gdataset.Tables("FACILITY").Rows(j).Item("TODATE")), "dd/MM/yyy")
                            .Col = 7
                            .Row = j + 1
                            .Text = IIf(gdataset.Tables("FACILITY").Rows(j).Item("ACTFLAG") = "Y", 1, 0)
                        Next
                    End With
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_mcode.Text & "'"
                    gconnection.getDataSet(sqlstring, "MNAME")
                    If gdataset.Tables("MNAME").Rows.Count > 0 Then
                        lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))
                    End If
                Else
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_mcode.Text & "'"
                    gconnection.getDataSet(sqlstring, "MNAME")
                    If gdataset.Tables("MNAME").Rows.Count > 0 Then
                        lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))
                        txt_mcode.ReadOnly = True
                        ssgrid_Fac.SetActiveCell(1, 1)
                        ssgrid_Fac.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub LIST_FACILITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIST_FACILITY.SelectedIndexChanged
        Dim vcount As String
        Dim Loopindex As Long
        Dim vsplit(), str As String
        Dim i As Integer
        txtFacilities.Text = ""
        vcount = ""
        If LIST_FACILITY.CheckedItems.Count <> 0 Then
            For i = 0 To LIST_FACILITY.CheckedItems.Count - 1
                vsplit = Split(LIST_FACILITY.CheckedItems(i), "==>")
                str = str & vsplit(0) & ","
            Next
        End If
        txtFacilities.Text = Trim(str)
    End Sub
    Private Sub cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Add.Click

        Dim SQLSTR As String
        Dim vcount As String
        Dim Loopindex As Long
        Dim i, J, k, Qty, fmth, mth, _year As Integer
        Dim store() As String
        Dim Insert(0) As String
        Dim vsplit(), Str, type(), _TYPE, _DNAME, _FCODE, _FDESC As String
        Try
            Dim strSQL, SSQL, Update(0), Taxpercent() As String
            If txt_mcode.Text <> "" Then
                If MsgBox("Want to Add.........", MsgBoxStyle.OKCancel, "ok") = MsgBoxResult.Cancel Then
                    ssgrid_Fac.SetActiveCell(1, 1)
                    ssgrid_Fac.Focus()
                    Exit Sub
                End If
            Else
                txt_mcode.Focus()
                cmd_MemberCodeHelp_Click(sender, e)
                Exit Sub

            End If
            Call checkValidation()

            If boolchk = False Then Exit Sub

            strSQL = "delete FROM facility_HDR where mcode='" & txt_mcode.Text & "'"
            Insert(0) = strSQL

            strSQL = "delete FROM facility_det where mcode='" & txt_mcode.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL

            For i = 1 To ssgrid_Fac.DataRowCnt Step 1

                strSQL = "INSERT INTO facility_HDR(MCODE,TYPE,DNAME,FCODE,FDESC,FROMDATE,TODATE,ACT_FLAG,FREEZE)"
                strSQL = strSQL & " VALUES ( '" & Trim(txt_mcode.Text) & "','"

                ssgrid_Fac.Col = 1
                ssgrid_Fac.Row = i
                strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                _TYPE = Trim(ssgrid_Fac.Text)

                ssgrid_Fac.Col = 2
                ssgrid_Fac.Row = i
                strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                _DNAME = Trim(ssgrid_Fac.Text)

                ssgrid_Fac.Col = 3
                ssgrid_Fac.Row = i
                strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                _FCODE = Trim(ssgrid_Fac.Text)


                ssgrid_Fac.Col = 4
                ssgrid_Fac.Row = i
                strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                _FDESC = Trim(ssgrid_Fac.Text)

                ssgrid_Fac.Col = 5
                ssgrid_Fac.Row = i
                strSQL = strSQL & Format(CDate(Trim(ssgrid_Fac.Text)), "dd/MMM/yyyy") & "','"

                frmdate = Format(CDate(Trim(ssgrid_Fac.Text)), "dd/MMM/yyyy")
                ssgrid_Fac.Col = 6
                ssgrid_Fac.Row = i
                strSQL = strSQL & Format(CDate(Trim(ssgrid_Fac.Text)), "dd/MMM/yyyy") & "','"
                todate = Format(CDate(Trim(ssgrid_Fac.Text)), "dd/MMM/yyyy")

                ssgrid_Fac.Col = 7
                ssgrid_Fac.Row = i

                strSQL = strSQL & IIf(Val(Trim(ssgrid_Fac.Text)) > 0, "Y", "N") & "','N')"

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = strSQL

                For J = 1 To DateDiff(DateInterval.Month, frmdate, todate) + 1
                    SSQL = "INSERT INTO facility_DET(mcode,TYPE,DNAME,FCODE,FDATE,MONTHNO)"
                    SSQL = SSQL & " VALUES ( '" & Trim(txt_mcode.Text) & "','"
                    SSQL = SSQL & _TYPE & "','" & _DNAME & "','" & _FCODE & "','"

                    If J = 1 Then
                        mth = Month(frmdate)
                        _year = Year(frmdate)
                    Else
                        If mth = 12 Then
                            mth = 1
                            _year = _year + 1
                        Else
                            mth = mth + 1
                        End If
                    End If

                    SSQL = SSQL & _year & "/" & mth & "/" & "01'," & mth & ")"

                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = SSQL

                Next
            Next i

            gconnection.MoreTrans(Insert)
            Call cmd_Clear_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub checkValidation()
        Try
            boolchk = False
            If txt_mcode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_mcode.Focus()
                Exit Sub
            End If
            If ssgrid_Fac.DataRowCnt <= 0 Then
                txt_mcode.Focus()
                Exit Sub
            End If
            If Fac_Validate() = False Then
                Exit Sub
            End If
            boolchk = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            cmd_Add.Text = "Add[F7]"
            txt_mcode.ReadOnly = False
            txt_mcode.Focus()
            txt_mcode.Text = ""
            lbl_mname.Text = " "
            Me.ssgrid_Fac.ClearRange(1, 1, -1, -1, True)
            SSGRIND1.ClearRange(1, 1, -1, -1, True)
            PNL_FACILITY.Visible = False
            txtFacilities.Text = ""
            txt_mcode.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT
            _export.TABLENAME = "facility_hdr"
            sqlstring = "SELECT * FROM facility_hdr"
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Call cmd_View_Click(sender, e)
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub
    Public Function facilities1()
        Dim I As Integer
        ssgrid_Fac.ClearRange(1, 1, -1, -1, True)
        sqlstring = "select isnull(SUBSCODE,'')as poscode,isnull(SUBSdesc,'')as posdesc from SUBSCRIPTIONMAST  WHERE ISNULL(FACILITY_FLG,'')='F' "
        gconnection.getDataSet(sqlstring, "FACILITY_MST")
        If gdataset.Tables("FACILITY_MST").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("FACILITY_MST").Rows.Count - 1
                With ssgrid_Fac
                    .Row = I + 1
                    .Col = 1
                    .Text = gdataset.Tables("FACILITY_MST").Rows(I).Item("POSCODE")
                    .Col = 2
                    .Text = gdataset.Tables("FACILITY_MST").Rows(I).Item("POSDESC")
                    .Col = 3
                    .Text = 1
                End With
            Next I
        End If
    End Function

    Private Sub FillGrid()
        '''*********************************** TO FILL TAX FROM ACCOUNTSTAXMASTER IF ITEMTYPE IS NOT THERE ******************'''
        Try
            Dim j, i, COUNTER As Integer
            sqlstring = " SELECT MCODE,MNAME,FACILITY,QTY FROM FACILITY WHERE MCODE = '" & txt_mcode.Text & "' AND ISNULL(FREEZE,'') <> 'Y'"
            gconnection.getDataSet(sqlstring, "Facility")
            If gdataset.Tables("Facility").Rows.Count > 0 Then
                For j = 0 To gdataset.Tables("Facility").Rows.Count - 1
                    For i = 1 To ssgrid_Fac.DataRowCnt
                        ssgrid_Fac.Row = i
                        ssgrid_Fac.Col = 1
                        COUNTER = String.Compare(Trim(ssgrid_Fac.Text), Trim(gdataset.Tables("Facility").Rows(j).Item("FACILITY")))
                        If COUNTER = 0 Then
                            'ssgrid_Fac.Col = 3
                            ssgrid_Fac.SetText(3, i, Trim(gdataset.Tables("Facility").Rows(j).Item("QTY")))
                            ssgrid_Fac.SetText(4, i, "True")
                            ssgrid_Fac.SetActiveCell(1, i)
                        End If
                    Next
                Next j
            End If
        Catch ex As Exception
            MessageBox.Show("Handle the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid_Fac.Advance
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_Fac.KeyDownEvent
        Try
            Dim ssql, TYPE, name As String
            Dim I As Integer

            If e.keyCode = Keys.F3 Then
                SSGRIND1.ClearRange(1, 1, -1, -1, True)
                PNL_FACILITY.Visible = False
                ssgrid_Fac.Row = ssgrid_Fac.ActiveRow
                ssgrid_Fac.ClearRange(1, ssgrid_Fac.ActiveRow, 1, ssgrid_Fac.ActiveRow, True)
                ssgrid_Fac.DeleteRows(ssgrid_Fac.ActiveRow, 1)
                'If ssgrid_Fac.Row > 1 Then
                '   ssgrid_Fac.ActiveRow = ssgrid_Fac.Row - 1
                ssgrid_Fac.SetActiveCell(1, ssgrid_Fac.ActiveRow)
                'End If
                ssgrid_Fac.Focus()
            End If

            If e.keyCode = Keys.Enter Then
                With ssgrid_Fac

                    If .ActiveCol = 1 Then
                        .Col = 1
                        .Row = .ActiveRow
                        TYPE = .Text
                        If Trim(.Text) = "" Then
                            Call FILLTYPE()
                        Else
                            ssql = "SELECT FCODE,FNAME FROM FACILITYTYPE WHERE FCODE='" & Trim(.Text) & "'"
                            gconnection.getDataSet(ssql, "FTYPE")
                            If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                MessageBox.Show("MISMATCH FACILITY CODE,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                .Text = ""
                                .Col = 1
                                .Row = .ActiveRow
                                .Focus()
                                Exit Sub
                            Else
                                ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & TYPE & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                SSGRIND1.ClearRange(1, 1, -1, -1, True)
                                SSGRIND1.SetActiveCell(1, 1)
                                If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                                    For I = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                                        With SSGRIND1
                                            .Col = 1
                                            .Row = I + 1
                                            .Text = gdataset.Tables("FTYPE").Rows(I).Item("CNAME")
                                        End With
                                    Next
                                    PNL_FACILITY.Visible = True
                                    SSGRIND1.SetActiveCell(1, 1)
                                    SSGRIND1.Focus()
                                ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                                    ssgrid_Fac.Col = 2
                                    ssgrid_Fac.Row = .ActiveRow
                                    ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                                End If
                            End If
                            If (.Text) = "GT" Then
                                .Col = 2
                                .Row = .ActiveRow
                                .Lock = False
                                .Focus()
                            Else
                                .Col = 2
                                .Row = .ActiveRow
                                .Lock = True
                                ssgrid_Fac.Focus()
                                If PNL_FACILITY.Visible = True Then
                                    SSGRIND1.Focus()
                                End If
                            End If
                        End If
                    ElseIf .ActiveCol = 2 Then
                        '.Col = 1
                        '.Row = .ActiveRow
                        'TYPE = Trim(.Text)
                        .Col = 2
                        .Row = .ActiveRow
                        If Trim(.Text) = "" Then
                            Call FILLDEPT(TYPE)
                        Else
                            If TYPE <> "GT" Then
                                ssql = "SELECT CNAME,RELATION FROM FACILITY_MEMDET WHERE CNAME='" & Trim(.Text) & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                    MessageBox.Show("MISMATCH NAME,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                    .Text = ""
                                    .Col = 2
                                    .Row = .ActiveRow
                                    .Focus()
                                    Exit Sub
                                End If
                            End If
                        End If
                        .Col = 1
                        .Row = .ActiveRow
                        If (.Text) = "GT" Then
                            ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ssgrid_Fac.Lock = False
                            ssgrid_Fac.Focus()
                        Else
                            .Col = 2
                            .Row = .ActiveRow
                            'ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ssgrid_Fac.Lock = True
                        End If
                    ElseIf .ActiveCol = 3 Then
                        .Col = 2
                        .Row = .ActiveRow
                        name = Trim(.Text)
                        .Col = 3
                        .Row = .ActiveRow
                        If Trim(.Text) = "" And name <> "" Then
                            Call FACILITY(name)
                        Else
                            If name <> "" Then
                                ssql = "SELECT ISNULL(SUBSDESC,'') AS SUBSDESC FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & Trim(.Text) & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                    MessageBox.Show("MISMATCH FACILITY CODE,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                    .Col = 3
                                    .Row = .ActiveRow
                                    .Text = ""
                                    .Focus()
                                    Exit Sub
                                Else
                                    .Col = 4
                                    .Row = .ActiveRow
                                    .Text = gdataset.Tables("FTYPE").Rows(0).Item("SUBSDESC")
                                End If
                            Else
                                .Col = 3
                                .Row = .ActiveRow
                                .Text = ""
                                .Focus()
                            End If
                        End If
                        'Fac_Validate()
                    ElseIf .ActiveCol = 6 Then
                        .Col = 5
                        .Row = .ActiveRow
                        If .Text <> "" Then
                            frmdate = Format(CDate(.Text), "dd/MM/yyyy")
                        End If
                        .Col = 6
                        .Row = .ActiveRow
                        If .Text <> "" Then
                            todate = Format(CDate(.Text), "dd/MM/yyyy")
                        End If
                        If frmdate.ToString <> "" And todate.ToString <> "" Then
                            If Checkdaterangevalidate(frmdate, todate) = False Then
                                .Col = 6
                                .Row = .ActiveRow
                                .Text = ""
                                .Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End With
            End If
            If e.keyCode = Keys.F4 Then
                With ssgrid_Fac
                    If .ActiveCol = 2 Then
                        .Col = 1
                        .Row = .ActiveRow
                        TYPE = Trim(.Text)
                        .Col = 2
                        Call FILLDEPT(TYPE)
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FILLDEPT(ByVal TYPE As String)
        Try
            Dim vform As New ListOperation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = "SELECT CNAME,RELATION FROM FACILITY_MEMDET  "
            If Trim(Search) = " " Then
                'M_WhereCondition = " WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & TYPE & "'"
                M_WhereCondition = " WHERE MCODE='" & txt_mcode.Text & "'"
            Else
                'M_WhereCondition = " WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & TYPE & "'"
                M_WhereCondition = " WHERE MCODE='" & txt_mcode.Text & "'"
            End If
            vform.Field = "CNAME,RELATION"
            vform.vFormatstring = "                    NAME                                  |                   RELATION                         | "
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 2
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FILLTYPE()
        Try
            Dim vform As New ListOperation
            Dim ssql As String
            Dim i As Integer
            gSQLString = "SELECT FCODE,FNAME FROM FACILITYTYPE  "
            If Trim(Search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = ""
            End If
            vform.Field = "FCODE,FNAME"
            vform.vFormatstring = "                     CODE                 |                      NAME                           |"
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 1
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                    If (.Text) = "GT" Then
                        .Lock = False
                    Else
                        .Lock = True
                    End If

                    ssql = "SELECT TYPE,CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & vform.keyfield & "'"
                    gconnection.getDataSet(ssql, "FTYPE")
                    SSGRIND1.ClearRange(1, 1, -1, -1, True)
                    SSGRIND1.SetActiveCell(1, 1)
                    If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                        For i = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                            With SSGRIND1
                                .Col = 1
                                .Row = i + 1
                                .Text = gdataset.Tables("FTYPE").Rows(i).Item("TYPE")
                                .Col = 2
                                .Row = i + 1
                                .Text = gdataset.Tables("FTYPE").Rows(i).Item("CNAME")
                            End With
                        Next
                        PNL_FACILITY.Visible = True
                        SSGRIND1.SetActiveCell(1, 1)
                        SSGRIND1.Focus()
                    ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                        ssgrid_Fac.Col = 1
                        ssgrid_Fac.Row = .ActiveRow
                        ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("TYPE")
                        ssgrid_Fac.Col = 2
                        ssgrid_Fac.Row = .ActiveRow
                        ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                        ssgrid_Fac.Focus()
                    End If

                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FACILITY(ByVal name As String)
        Try
            Dim vform As New ListOperation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT ISNULL(SUBSDESC,'') AS SUBSDESC,ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(TOTAL,0) AS AMOUNT FROM SUBSCRIPTIONMAST "
            If Trim(Search) = " " Then
                M_WhereCondition = " WHERE FACILITY_FLG='F'"
            Else
                M_WhereCondition = " WHERE FACILITY_FLG='F'"
            End If
            vform.Field = "SUBSDESC,SUBSCODE"
            vform.vFormatstring = "     FACILITY                      |      FACILITY CODE                     |       AMOUNT        |"
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 3
                    .Row = .ActiveRow
                    .Text = vform.keyfield1
                    .Col = 4
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ssgrid_LeaveCell(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid_Fac.LeaveCell
        Try
            Dim frmdate As Date, todate As Date
            Dim ssql, TYPE, name As String
            Dim I As Integer
            With ssgrid_Fac
                If .ActiveCol = 1 Then
                    .Col = 1
                    .Row = .ActiveRow
                    TYPE = .Text
                    If Trim(.Text) <> "" Then
                        ssql = "SELECT FCODE,FNAME FROM FACILITYTYPE WHERE FCODE='" & Trim(.Text) & "'"
                        gconnection.getDataSet(ssql, "FTYPE")
                        If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                            .Text = ""
                            .Col = 1
                            .Row = .ActiveRow
                            .Focus()
                            Exit Sub
                        Else
                            ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & TYPE & "'"
                            gconnection.getDataSet(ssql, "FTYPE")
                            SSGRIND1.ClearRange(1, 1, -1, -1, True)
                            SSGRIND1.SetActiveCell(1, 1)
                            If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                                For I = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                                    With SSGRIND1
                                        .Col = 1
                                        .Row = I + 1
                                        .Text = gdataset.Tables("FTYPE").Rows(I).Item(0)
                                    End With
                                Next
                            ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                                ssgrid_Fac.Col = 2
                                ssgrid_Fac.Row = .ActiveRow
                                ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                            End If
                            .Col = 1
                            .Row = .ActiveRow
                            If (.Text) = "GT" Then
                                .Col = 2
                                .Row = .ActiveRow
                                ssgrid_Fac.Lock = False
                                ssgrid_Fac.Focus()
                            Else
                                .Col = 2
                                .Row = .ActiveRow
                                .Lock = True
                                ssgrid_Fac.Focus()
                                If PNL_FACILITY.Visible = True Then
                                    SSGRIND1.Focus()
                                End If
                            End If
                        End If
                    End If
                ElseIf .ActiveCol = 2 Then
                    .Col = 1
                    .Row = .ActiveRow
                    TYPE = .Text
                    .Col = 2
                    .Row = .ActiveRow
                    If Trim(.Text) <> "" And TYPE <> "GT" Then
                        ssql = "SELECT CNAME,RELATION FROM FACILITY_MEMDET WHERE CNAME='" & Trim(.Text) & "'"
                        gconnection.getDataSet(ssql, "FTYPE")
                        If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                            .Col = 2
                            .Row = .ActiveRow
                            .Text = ""
                            .Focus()
                            Exit Sub
                        End If
                    End If
                    .Col = 1
                    .Row = .ActiveRow
                    If (.Text) = "GT" Then
                        .Col = 2
                        .Row = .ActiveRow
                        ssgrid_Fac.Lock = False
                    Else
                        .Col = 2
                        .Row = .ActiveRow
                        .Lock = True
                    End If
                ElseIf .ActiveCol = 3 Then
                    .Col = 2
                    .Row = .ActiveRow
                    name = Trim(.Text)
                    .Col = 3
                    .Row = .ActiveRow
                    If name <> "" Then
                        If Trim(.Text) <> "" Then
                            ssql = "SELECT ISNULL(SUBSDESC,'') AS SUBSDESC FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & Trim(.Text) & "'"
                            gconnection.getDataSet(ssql, "FTYPE")
                            If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                .Text = ""
                                .Col = 3
                                .Row = .ActiveRow
                                .Focus()
                                Exit Sub
                            Else
                                .Col = 4
                                .Row = .ActiveRow
                                .Text = gdataset.Tables("FTYPE").Rows(0).Item("SUBSDESC")
                                .Focus()
                            End If
                        End If
                    Else
                        .Col = 3
                        .Row = .ActiveRow
                        .Text = ""
                    End If
                ElseIf .ActiveCol = 6 Then
                    .Col = 5
                    .Row = .ActiveRow
                    If .Text <> "" Then
                        frmdate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    .Col = 6
                    .Row = .ActiveRow
                    If .Text <> "" Then
                        todate = Format(CDate(.Text), "dd/MM/yyyy")
                    End If
                    If frmdate.ToString <> "" And todate.ToString <> "" Then
                        'If Checkdaterangevalidate(frmdate, todate) = False Then
                        '    .Col = 6
                        '    .Row = .ActiveRow
                        '    .Text = ""
                        '    .Focus()
                        '    Exit Sub
                        'End If
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SSGRIND1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRIND1.KeyDownEvent
        Try
            Dim SSQL, PNAME As String
            With SSGRIND1
                If e.keyCode = Keys.Enter Then
                    If .ActiveCol = 1 Then
                        .Col = 1
                        .Row = .ActiveRow
                        PNAME = Trim(.Text)
                        If PNAME <> "" Then
                            With ssgrid_Fac
                                .Col = 2
                                .Row = .ActiveRow
                                .Text = PNAME
                                .Focus()
                            End With
                            PNL_FACILITY.Visible = False
                        End If
                    End If
                ElseIf e.keyCode = Keys.Escape Then
                    SSGRIND1.ClearRange(1, 1, -1, -1, True)
                    PNL_FACILITY.Visible = False
                    ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Facility_NONRSI_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                If cmd_Add.Enabled = True Then
                    Call cmd_Add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                Call cmd_View_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                If cmd_Add.Enabled = True Then
                    Call cmd_Add_Click(cmd_Add, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If cmd_View.Enabled = True Then
                    Call cmd_View_Click(cmd_View, e)
                    Exit Sub
                End If

            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Cmd_Print.Enabled = True Then
                    Call cmd_Exit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SSGRIND1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRIND1.Advance

    End Sub

    Private Sub txt_mcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ssgrid_Fac.SetActiveCell(1, 1)
        End If
    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub txt_mcode_GotFFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.GotFocus

    End Sub

    Private Sub txt_mcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.LostFocus
        ssgrid_Fac.SetActiveCell(1, 1)
    End Sub
End Class
