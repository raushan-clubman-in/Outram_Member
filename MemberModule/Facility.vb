Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Public Class Facility
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim strSQL, SSQL, Taxpercent() As String
    Dim sqlstring As String
    Dim frmdate As Date, todate As Date
    Dim _frmdate As Date, _todate As Date
    Dim Sqlstr, Insert(0) As String
    Dim subscode, subsdesc As String
    Dim strPhotoFilePath, strPhotoFilePath_SIG, strPhotoFilePath_Spouse As String
    Dim emailst As Boolean
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;pwd=" & strDataSqlPwd & ";Initial Catalog=  " & gDatabase & ";"


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
    Friend WithEvents ssgrid_Fac As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents PNL_FACILITY As System.Windows.Forms.Panel
    Friend WithEvents SSGRIND1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_mname As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Facility))
        Me.ssgrid_Fac = New AxFPSpreadADO.AxfpSpread
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_Add = New System.Windows.Forms.Button
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_CorporateCode = New System.Windows.Forms.Label
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.PNL_FACILITY = New System.Windows.Forms.Panel
        Me.SSGRIND1 = New AxFPSpreadADO.AxfpSpread
        Me.lbl_mname = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_FACILITY.SuspendLayout()
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssgrid_Fac
        '
        Me.ssgrid_Fac.DataSource = Nothing
        Me.ssgrid_Fac.Location = New System.Drawing.Point(80, 152)
        Me.ssgrid_Fac.Name = "ssgrid_Fac"
        Me.ssgrid_Fac.OcxState = CType(resources.GetObject("ssgrid_Fac.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_Fac.Size = New System.Drawing.Size(624, 344)
        Me.ssgrid_Fac.TabIndex = 590
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(456, 528)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 598
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.White
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(328, 528)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 597
        Me.cmd_View.Text = "View[F9]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(584, 528)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 596
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(88, 528)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 595
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.White
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.Location = New System.Drawing.Point(208, 528)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Add.TabIndex = 594
        Me.cmd_Add.Text = "Add[F7]"
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.White
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_MemberCode.Location = New System.Drawing.Point(224, 96)
        Me.txt_MemberCode.MaxLength = 35
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(88, 24)
        Me.txt_MemberCode.TabIndex = 600
        Me.txt_MemberCode.Text = ""
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(80, 96)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(135, 20)
        Me.lbl_CorporateCode.TabIndex = 599
        Me.lbl_CorporateCode.Text = "MemberShip No:"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(312, 96)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(27, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 601
        '
        'PNL_FACILITY
        '
        Me.PNL_FACILITY.BackgroundImage = CType(resources.GetObject("PNL_FACILITY.BackgroundImage"), System.Drawing.Image)
        Me.PNL_FACILITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_FACILITY.Controls.Add(Me.SSGRIND1)
        Me.PNL_FACILITY.Location = New System.Drawing.Point(312, 241)
        Me.PNL_FACILITY.Name = "PNL_FACILITY"
        Me.PNL_FACILITY.Size = New System.Drawing.Size(312, 128)
        Me.PNL_FACILITY.TabIndex = 603
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
        'lbl_mname
        '
        Me.lbl_mname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mname.Location = New System.Drawing.Point(344, 96)
        Me.lbl_mname.Name = "lbl_mname"
        Me.lbl_mname.Size = New System.Drawing.Size(296, 23)
        Me.lbl_mname.TabIndex = 604
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(480, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 20)
        Me.Label3.TabIndex = 605
        Me.Label3.Text = "Press [F3] For Delete Row"
        '
        'Facility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 638)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.lbl_mname)
        Me.Controls.Add(Me.ssgrid_Fac)
        Me.Controls.Add(Me.PNL_FACILITY)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_Add)
        Me.Name = "Facility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facility"
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_FACILITY.ResumeLayout(False)
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")
            End If
            vform.Close()
            vform = Nothing
            Call txt_MemberCode_Validated(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub
    Private Sub Facility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txt_MemberCode.Focus()
    End Sub

    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Try
        '        Dim vform As New ListOperation
        '        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        '        M_WhereCondition = " "
        '        vform.Field = "MCODE,MNAME"
        '        vform.vFormatstring = "  Member Code  | Member Name                           "
        '        vform.vCaption = "Member Master Help"
        '        vform.KeyPos = 0
        '        vform.KeyPos1 = 1
        '        vform.ShowDialog(Me)
        '        If Trim(vform.keyfield & "") <> "" Then
        '            txt_MemberCode.Text = Trim(vform.keyfield & "")
        '        End If
        '        vform.Close()
        '        vform = Nothing
        '        Call txt_MemberCode_Validated(sender, e)
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        '    End Try
        'End If
        Try

            If e.KeyCode = Keys.Enter Then
                If txt_MemberCode.Text = "" Then
                    cmd_MemberCodeHelp_Click(sender, e)
                Else
                    'cbo_Title.Focus()
                    ssgrid_Fac.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub ssgrid_Fac_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid_Fac.Advance
        Me.txt_MemberCode.Focus()
    End Sub

    Private Sub ssgrid_Fac_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_Fac.KeyDownEvent
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
                            'Call FILLTYPE()
                        Else
                            'ssql = "SELECT FCODE,FNAME FROM FACILITYTYPE WHERE FCODE='" & Trim(.Text) & "'"
                            ssql = "SELECT Relation,Child_nm FROM memdet WHERE Mem_Code='" & Trim(.Text) & "'"
                            gconnection.getDataSet(ssql, "FTYPE")
                            If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                MessageBox.Show("MISMATCH FACILITY CODE,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                .Text = ""
                                .Col = 1
                                .Row = .ActiveRow
                                .Focus()
                                Exit Sub
                            Else
                                'ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_mcode.Text & "' AND TYPE='" & TYPE & "'"
                                ssql = "SELECT Relation,Child_nm FROM memdet WHERE Mem_Code='" & Trim(.Text) & "'AND TYPE='" & TYPE & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                SSGRIND1.ClearRange(1, 1, -1, -1, True)
                                SSGRIND1.SetActiveCell(1, 1)
                                If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                                    For I = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                                        With SSGRIND1
                                            .Col = 1
                                            .Row = I + 1
                                            '.Text = gdataset.Tables("FTYPE").Rows(I).Item("CNAME")
                                            .Text = gdataset.Tables("FTYPE").Rows(I).Item("Child_nm")
                                        End With
                                    Next
                                    '            PNL_FACILITY.Visible = True
                                    '            SSGRIND1.SetActiveCell(1, 1)
                                    '            SSGRIND1.Focus()
                                ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                                    '            ssgrid_Fac.Col = 2
                                    '            ssgrid_Fac.Row = .ActiveRow
                                    '            'ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                                    '            ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("Child_nm")

                                Else
                                    '            ssgrid_Fac.Col = 1
                                    '            ssgrid_Fac.Row = .ActiveRow
                                End If
                            End If
                            If (.Text) = "GT" Then
                                '        .Col = 2
                                '        .Row = .ActiveRow
                                '        .Lock = False
                                '        .Focus()
                            Else
                                '        .Col = 2
                                '        .Row = .ActiveRow
                                '        .Lock = True
                                '        ssgrid_Fac.Focus()
                                If PNL_FACILITY.Visible = True Then
                                    '            SSGRIND1.Focus()
                                End If
                            End If
                        End If
                    ElseIf .ActiveCol = 2 Then
                        '    .Col = 1
                        '    .Row = .ActiveRow
                        '    TYPE = Trim(.Text)
                        '    .Col = 2
                        '    .Row = .ActiveRow
                        If Trim(.Text) = "" Then
                            'Call FILLDEPT(TYPE)
                        Else
                            If TYPE <> "GT" Then
                                ''        'ssql = "SELECT CNAME,RELATION FROM FACILITY_MEMDET WHERE CNAME='" & Trim(.Text) & "'"
                                ''        ssql = "SELECT Relation,Child_nm FROM memdet WHERE Mem_Code='" & Trim(.Text) & "'"
                                ''        gconnection.getDataSet(ssql, "FTYPE")
                                If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                    ''            MessageBox.Show("MISMATCH NAME,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                    ''            .Text = ""
                                    ''            .Col = 2
                                    ''            .Row = .ActiveRow
                                    ''            .Focus()
                                    Exit Sub
                                End If
                            End If
                        End If
                        .Col = 1
                        .Row = .ActiveRow
                        If (.Text) = "GT" Then
                            ''    ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ''    ssgrid_Fac.Lock = False
                            ''    ssgrid_Fac.Focus()
                        Else
                            ''    .Col = 2
                            ''    .Row = .ActiveRow
                            ''    'ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ''    ssgrid_Fac.Lock = True
                        End If
                    ElseIf .ActiveCol = 3 Then
                        '.Col = 2
                        .Col = 1
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
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub FILLTYPE()
        Try
            Dim vform As New ListOperation
            Dim ssql As String
            Dim i As Integer
            'gSQLString = "SELECT FCODE,FNAME FROM FACILITYTYPE  "
            gSQLString = "SELECT Relation,Child_nm FROM MEMDET  "
            If Trim(Search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = ""
            End If
            'vform.Field = "FCODE,FNAME"
            vform.Field = "Relation,Child_nm"
            vform.vFormatstring = "                     RELATION                 |                      NAME                           |"
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
                    'ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & vform.keyfield & "'"
                    ssql = "SELECT child_nm FROM MEMDET WHERE MEM_CODE='" & txt_MemberCode.Text & "' AND Relation ='" & vform.keyfield & "'"
                    gconnection.getDataSet(ssql, "FTYPE")
                    SSGRIND1.ClearRange(1, 1, -1, -1, True)
                    SSGRIND1.SetActiveCell(1, 1)
                    If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                        For i = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                            With SSGRIND1
                                .Col = 1
                                .Row = i + 1
                                '.Text = gdataset.Tables("FTYPE").Rows(i).Item("CNAME")
                                .Text = gdataset.Tables("FTYPE").Rows(i).Item("child_nm")
                            End With
                        Next
                        PNL_FACILITY.Visible = True
                        SSGRIND1.SetActiveCell(1, 1)
                        SSGRIND1.Focus()
                    ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                        ssgrid_Fac.Col = 2
                        ssgrid_Fac.Row = .ActiveRow
                        'ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                        ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("child_nm")
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
    Private Sub FILLDEPT(ByVal TYPE As String)
        Try
            Dim vform As New ListOperation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            'gSQLString = "SELECT CNAME,RELATION FROM FACILITY_MEMDET  "
            gSQLString = "SELECT Relation,child_nm FROM MEMDET" ' WHERE MEM_CODE='" & txt_MemberCode.Text & "' AND Relation ='" & vform.keyfield & "'"
            If Trim(Search) = " " Then
                'M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & TYPE & "'"
                'M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND Relation='" & TYPE & "'"
                M_WhereCondition = ""
            Else
                'M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & TYPE & "'"
                ''M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND Relation='" & TYPE & "'"
                M_WhereCondition = ""
            End If
            'vform.Field = "CNAME,RELATION"
            'vform.Field = ",CHILD_NM,RELATION"
            'vform.vFormatstring = "                    NAME                                  |                   RELATION                         | "
            vform.Field = "Relation,Child_nm"
            vform.vFormatstring = "                     RELATION                 |                      NAME                           |"
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

    Private Sub txt_MemberCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.LostFocus
        'ssgrid_Fac.Focus()
    End Sub

    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub

    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim vsplit(), type() As String
        Dim j As Integer
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(RELATION,'') AS RELATION,ISNULL(DNAME,'') AS DNAME,ISNULL(FCODE,'') AS FCODE,ISNULL(FROMDATE,'') AS FROMDATE,ISNULL(TODATE,'') AS TODATE,ISNULL(ACT_FLAG,'') AS ACTFLAG FROM facility_HDR WHERE MCODE='" & txt_MemberCode.Text & "'"
                gconnection.getDataSet(sqlstring, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    cmd_Add.Text = "Update[F7]"
                    ssgrid_Fac.ClearRange(1, 1, -1, 1 - 1, True)
                    SSGRIND1.ClearRange(1, 1, -1, 1 - 1, True)
                    txt_MemberCode.Text = Trim(gdataset.Tables("FACILITY").Rows(0).Item("MCODE"))
                    txt_MemberCode.ReadOnly = True
                    ssgrid_Fac.SetActiveCell(1, 1)
                    ssgrid_Fac.Focus()
                    With ssgrid_Fac
                        For j = 0 To gdataset.Tables("FACILITY").Rows.Count - 1
                            .Col = 1
                            .Row = j + 1
                            .Text = gdataset.Tables("FACILITY").Rows(j).Item("RELATION")
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
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(sqlstring, "MNAME")
                    If gdataset.Tables("MNAME").Rows.Count > 0 Then
                        lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))

                    End If
                Else
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE ISNULL(MCODE,'')='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(sqlstring, "MNAME")
                    If gdataset.Tables("MNAME").Rows.Count > 0 Then
                        lbl_mname.Text = Trim(gdataset.Tables("MNAME").Rows(0).Item("MNAME"))
                        txt_MemberCode.ReadOnly = True
                        ssgrid_Fac.SetActiveCell(1, 1)
                        'cmd_Add.Text = "Add[F7]"
                    End If
                End If
            End If
            ssgrid_Fac.SetActiveCell(1, 1)
            ssgrid_Fac.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Facility_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '  MessageBox.Show("hai")

        'If e.KeyCode = Keys.F7 Then
        'Call cmd_Add_Click(sender, e)
        'Exit Sub
        'ElseIf e.KeyCode = Keys.F6 Then
        '   Call cmd_Clear_Click(sender, e)
        '  Exit Sub
        'ElseIf e.KeyCode = Keys.F9 Then
        '   Call cmd_View_Click(sender, e)
        '  Exit Sub
        'ElseIf e.KeyCode = Keys.F10 Then
        '   Call Cmd_Print_Click(sender, e)
        '  Exit Sub
        'ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
        '   Call cmd_Exit_Click(sender, e)
        '  Exit Sub
        'End If

        Try
            If e.KeyCode = Keys.F7 Then
                If cmd_Add.Enabled = True Then
                    Call cmd_Add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If cmd_Clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If cmd_View.Enabled = True Then
                    Call cmd_View_Click(sender, e)
                    Exit Sub
                End If
                'ElseIf e.KeyCode = Keys.F12 Then
                '   If CmdExport.Enabled = True Then
                '  Call CmdExport_Click(sender, e)
                ' Exit Sub
                'End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmd_Exit.Enabled = True Then
                    Call cmd_Exit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            cmd_Add.Text = "Add[F7]"
            txt_MemberCode.ReadOnly = False
            txt_MemberCode.Focus()
            txt_MemberCode.Text = ""
            lbl_mname.Text = " "
            Me.ssgrid_Fac.ClearRange(1, 1, -1, -1, True)
            SSGRIND1.ClearRange(1, 1, -1, -1, True)
            PNL_FACILITY.Visible = False
            'txtFacilities.Text = ""
            Me.txt_MemberCode.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Add.Click
        Dim vcount As String
        Dim Loopindex As Long
        Dim i, J, k, Qty, fmth, mth, _year As Integer
        Dim store() As String
        Dim Insert(0) As String
        Dim vsplit(), Str, type(), _TYPE, _DNAME, _FCODE, _FNAME As String
        If cmd_Add.Text = "Add[F7]" Then
            Try
                Call checkValidation()
                'If boolchk = False Then Exit Sub

                'strSQL = "delete FROM facility_HDR where mcode='" & txt_MemberCode.Text & "'"

                Insert(0) = strSQL


                For i = 1 To ssgrid_Fac.DataRowCnt Step 1
                    strSQL = "INSERT INTO facility_HDR(MCODE,RELATION,DNAME,FCODE,FDESC,FROMDATE,TODATE,ACT_FLAG,FREEZE)"
                    strSQL = strSQL & " VALUES ( '" & Trim(txt_MemberCode.Text) & "','"
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
                    _FNAME = Trim(ssgrid_Fac.Text)

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

                    gconnection.dataOperation(1, strSQL, "memdet")

                Next i
                MessageBox.Show("Transaction Completed Record Saved")
                Me.cmd_Clear_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Information)
            End Try

        ElseIf cmd_Add.Text = "Update[F7]" Then

            Try
                Call checkValidation() '''--->CHECK VALIDATION
                '    If boolchk = False Then Exit Sub
                'If cmd_AddNew.Text = "Add New[F5]" Then
                ' For i = 0 To chkList_Subscription.Items.Count - 1
                strSQL = " DELETE FROM facility_HDR WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(1, strSQL, "memdet")

                'Update(0) = strSQL
                For i = 1 To ssgrid_Fac.DataRowCnt Step 1
                    strSQL = "INSERT INTO facility_HDR(MCODE,RELATION,DNAME,FCODE,FDESC,FROMDATE,TODATE,ACT_FLAG,FREEZE)"
                    strSQL = strSQL & " VALUES ( '" & Trim(txt_MemberCode.Text) & "','"
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
                    _FNAME = Trim(ssgrid_Fac.Text)

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

                    gconnection.dataOperation(1, strSQL, "memdet")
                    'ReDim Preserve Insert(Insert.Length)
                    'Insert(Insert.Length - 1) = strSQL
                Next i
                gconnection.dataOperation(2, "UPDATE MEMBERMASTER SET TAG = 'Y' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "'", "MemberMaster")
                MessageBox.Show("Update Record Successfully")
                Me.cmd_Clear_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        Call printdata()
    End Sub
    Private Sub printdata()
        Try
            Dim cmdText As String
            Dim txtobj1 As TextObject
            cmdText = "Select * From FACILITY_MASTER"
            Dim o As Object
            cmdText = cmdText & " order by mcode asc"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_facility_List
            Viewer.ssql = cmdText
            Viewer.Report = r
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            Viewer.TableName = "FACILITY_MASTER"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        'gPrint = True
        Facility_Print()
    End Sub
    Private Sub Facility_Print()
        Try
            Dim Sqlstring, GroupCode() As String
            Dim i, J As Integer
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            With ssgrid_Fac
                For i = 1 To ssgrid_Fac.DataRowCnt
                    .Col = 7
                    .Row = .ActiveRow
                    If Val(.Text) > 0 Then
                        Filewrite.WriteLine(Chr(14) & Chr(27) + "E" & UCase(gCompanyname) & Chr(27) + "F" & Chr(18))
                        Filewrite.WriteLine(StrDup(40, "-"))
                        Filewrite.WriteLine("Date:" & Format(Now(), "dd/MM/yyyy"))
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("Mcode:" & Trim(txt_MemberCode.Text) & Space(1))
                        .Col = 2
                        .Row = .ActiveRow
                        If (.Text) <> "" Then
                            Filewrite.WriteLine("")
                            .Col = 1
                            .Row = .ActiveRow
                            If Trim(.Text) = "MM" Then
                                .Col = 2
                                .Row = .ActiveRow
                                Filewrite.WriteLine("M.NAME:" & Trim(.Text))
                            ElseIf Trim(.Text) = "SP" Then
                                .Col = 2
                                .Row = .ActiveRow
                                Filewrite.WriteLine("SPOUSE:" & Trim(.Text))
                            ElseIf Trim(.Text) = "SN" Then
                                .Col = 2
                                .Row = .ActiveRow
                                Filewrite.WriteLine("SON:" & Trim(.Text))
                            ElseIf Trim(.Text) = "DR" Then
                                .Col = 2
                                .Row = .ActiveRow
                                Filewrite.WriteLine("DAUGHTER:" & Trim(.Text))
                            ElseIf Trim(.Text) = "GT" Then
                                .Col = 2
                                .Row = .ActiveRow
                                Filewrite.WriteLine("GUEST:" & Trim(.Text))
                            End If
                        End If
                        Filewrite.WriteLine("")
                    End If
                    .Col = 4
                    .Row = .ActiveRow
                    If (.Text) <> "" Then
                        Filewrite.WriteLine("Facility:" & Chr(14) & Chr(27) + "E" & UCase(Trim(.Text)) & Chr(27) + "F" & Chr(18))
                    End If
                    Filewrite.WriteLine(StrDup(40, "-"))
                    For J = 0 To 5
                        Filewrite.WriteLine("")
                    Next
                Next
            End With
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub checkValidation()
        Dim i As Integer
        Dim type, facility, facilitydesc, from, todate As String
        Try
            boolchk = False
            If txt_MemberCode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_MemberCode.Focus()
                Exit Sub
            End If
            For i = 1 To ssgrid_Fac.DataRowCnt Step 1
                ssgrid_Fac.Col = 1
                ssgrid_Fac.Row = i
                type = Trim(ssgrid_Fac.Text)
                If (type = "") Then
                    MessageBox.Show("Please enter MemberType")
                    ssgrid_Fac.Col = 1
                    ssgrid_Fac.Row = ssgrid_Fac.ActiveRow
                End If
            Next i
            If Fac_Validate() = False Then
                Exit Sub
            End If
            boolchk = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub lbl_Caption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbl_mname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_mname.Click

    End Sub

    Private Sub lbl_CorporateCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CorporateCode.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Facility_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        Me.txt_MemberCode.Focus()
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Facility_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
       
    End Sub
End Class
