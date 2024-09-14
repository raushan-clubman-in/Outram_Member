Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.IO
Imports System.data.SqlClient

Public Class Facility_Report
    Inherits System.Windows.Forms.Form
    Dim FltrStr, TempString(2), DispString, addFltrStr, status As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Public selectNo As Integer
    Dim dt, posting As New DataTable
    Dim gconnection As New GlobalClass
    Dim txtobj1 As TextObject
    Dim STR_STATUS, STR_TYPE, STR_OPCTION, STRSUBS As String


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
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Chk_facilitywise As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Facility As System.Windows.Forms.CheckedListBox
    Friend WithEvents RDB_MEMBER_LIST_SUBS As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_Facility_List As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_faclitywise As System.Windows.Forms.TextBox
    Friend WithEvents Chk_Facility_wise As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Facility_Report))
        Me.txt_Tomcode = New System.Windows.Forms.TextBox
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.lblfrom = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.lblto = New System.Windows.Forms.Label
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Chk_facilitywise = New System.Windows.Forms.CheckBox
        Me.Chk_Facility_wise = New System.Windows.Forms.CheckBox
        Me.Chk_Facility = New System.Windows.Forms.CheckedListBox
        Me.Txt_faclitywise = New System.Windows.Forms.TextBox
        Me.RDB_MEMBER_LIST_SUBS = New System.Windows.Forms.RadioButton
        Me.RDB_Facility_List = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tomcode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(664, 432)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(120, 24)
        Me.txt_Tomcode.TabIndex = 642
        Me.txt_Tomcode.Text = ""
        Me.txt_Tomcode.Visible = False
        '
        'txt_mcode
        '
        Me.txt_mcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mcode.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(680, 288)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(120, 24)
        Me.txt_mcode.TabIndex = 639
        Me.txt_mcode.Text = ""
        Me.txt_mcode.Visible = False
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.BackColor = System.Drawing.Color.Transparent
        Me.lblfrom.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfrom.Location = New System.Drawing.Point(712, 480)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(52, 20)
        Me.lblfrom.TabIndex = 647
        Me.lblfrom.Text = "From "
        Me.lblfrom.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_Clear)
        Me.GroupBox4.Controls.Add(Me.cmd_view)
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Location = New System.Drawing.Point(232, 440)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 64)
        Me.GroupBox4.TabIndex = 653
        Me.GroupBox4.TabStop = False
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.White
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.Location = New System.Drawing.Point(128, 16)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(104, 32)
        Me.cmd_view.TabIndex = 12
        Me.cmd_view.Text = "VIEW [F9]"
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Image = CType(resources.GetObject("Btn_close.Image"), System.Drawing.Image)
        Me.Btn_close.Location = New System.Drawing.Point(240, 16)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp1.Image = CType(resources.GetObject("cmd_MemberCodeHelp1.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(744, 392)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp1.TabIndex = 643
        Me.cmd_MemberCodeHelp1.Visible = False
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(768, 248)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 640
        Me.cmd_MemberCodeHelp.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(168, 128)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(240, 24)
        Me.chk_PrintAll.TabIndex = 646
        Me.chk_PrintAll.Text = "Select All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(168, 152)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(272, 213)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 645
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.BackColor = System.Drawing.Color.Transparent
        Me.lblto.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblto.Location = New System.Drawing.Point(744, 344)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(33, 20)
        Me.lblto.TabIndex = 655
        Me.lblto.Text = "To:"
        Me.lblto.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(168, 312)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(264, 21)
        Me.txtCategory.TabIndex = 659
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'Chk_facilitywise
        '
        Me.Chk_facilitywise.BackColor = System.Drawing.Color.Transparent
        Me.Chk_facilitywise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_facilitywise.Location = New System.Drawing.Point(472, 368)
        Me.Chk_facilitywise.Name = "Chk_facilitywise"
        Me.Chk_facilitywise.Size = New System.Drawing.Size(240, 24)
        Me.Chk_facilitywise.TabIndex = 660
        Me.Chk_facilitywise.Text = "MemberWise"
        Me.Chk_facilitywise.Visible = False
        '
        'Chk_Facility_wise
        '
        Me.Chk_Facility_wise.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Facility_wise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Facility_wise.Location = New System.Drawing.Point(448, 128)
        Me.Chk_Facility_wise.Name = "Chk_Facility_wise"
        Me.Chk_Facility_wise.Size = New System.Drawing.Size(176, 24)
        Me.Chk_Facility_wise.TabIndex = 661
        Me.Chk_Facility_wise.Text = "Facilitywise"
        '
        'Chk_Facility
        '
        Me.Chk_Facility.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Chk_Facility.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Facility.Location = New System.Drawing.Point(448, 152)
        Me.Chk_Facility.Name = "Chk_Facility"
        Me.Chk_Facility.Size = New System.Drawing.Size(224, 212)
        Me.Chk_Facility.Sorted = True
        Me.Chk_Facility.TabIndex = 662
        '
        'Txt_faclitywise
        '
        Me.Txt_faclitywise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_faclitywise.Location = New System.Drawing.Point(456, 312)
        Me.Txt_faclitywise.Name = "Txt_faclitywise"
        Me.Txt_faclitywise.Size = New System.Drawing.Size(216, 21)
        Me.Txt_faclitywise.TabIndex = 663
        Me.Txt_faclitywise.Text = ""
        Me.Txt_faclitywise.Visible = False
        '
        'RDB_MEMBER_LIST_SUBS
        '
        Me.RDB_MEMBER_LIST_SUBS.AllowDrop = True
        Me.RDB_MEMBER_LIST_SUBS.BackColor = System.Drawing.Color.Transparent
        Me.RDB_MEMBER_LIST_SUBS.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_MEMBER_LIST_SUBS.Location = New System.Drawing.Point(168, 376)
        Me.RDB_MEMBER_LIST_SUBS.Name = "RDB_MEMBER_LIST_SUBS"
        Me.RDB_MEMBER_LIST_SUBS.Size = New System.Drawing.Size(224, 24)
        Me.RDB_MEMBER_LIST_SUBS.TabIndex = 664
        Me.RDB_MEMBER_LIST_SUBS.Text = "Facility Summary"
        '
        'RDB_Facility_List
        '
        Me.RDB_Facility_List.AllowDrop = True
        Me.RDB_Facility_List.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Facility_List.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_Facility_List.Location = New System.Drawing.Point(168, 408)
        Me.RDB_Facility_List.Name = "RDB_Facility_List"
        Me.RDB_Facility_List.Size = New System.Drawing.Size(256, 24)
        Me.RDB_Facility_List.TabIndex = 439
        Me.RDB_Facility_List.Text = "Facility Wise  Member"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(168, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 20)
        Me.Label10.TabIndex = 666
        Me.Label10.Text = "FACILITY FOR MONTH OF"
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(376, 88)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 665
        '
        'Facility_Report
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 590)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.RDB_MEMBER_LIST_SUBS)
        Me.Controls.Add(Me.Txt_faclitywise)
        Me.Controls.Add(Me.Chk_Facility)
        Me.Controls.Add(Me.Chk_Facility_wise)
        Me.Controls.Add(Me.Chk_facilitywise)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.txt_Tomcode)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.RDB_Facility_List)
        Me.Name = "Facility_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facility_Report"
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Facility_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call chk_loadcategory()
        Call LOADFACILITY()
    End Sub

    Private Sub CbxMonth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub chk_loadcategory()
        Try
            Dim i As Integer
            gconnection.getDataSet("SELECT distinct(SUBTypeDesc) FROM SUBCATEGORYMASTER Where Freeze='N'", "MEMBERTYPE")
            If gdataset.Tables("MEMBERTYPE").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
                    Me.chk_Filter_Field.Items.Add(Trim(gdataset.Tables("MEMBERTYPE").Rows(i).Item(0)))
                    ' Me.Cbo_servives.Items.Add(Trim(gdataset.Tables("Tbl_RankMaster").Rows(i).Item(0)))
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Rnd_Summary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblfrom.Visible = True
        lblto.Visible = True
        txt_mcode.Visible = True
        txt_Tomcode.Visible = True
        cmd_MemberCodeHelp.Visible = True
        cmd_MemberCodeHelp1.Visible = True
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblfrom.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_Tomcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Tomcode.TextChanged

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub lblto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblto.Click

    End Sub

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click

    End Sub

    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp1.Click

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
                    chk_Filter_Field.SetSelected(Iteration, False)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Dim sqlstring, bildt, mthyar As String
            Dim MONTH1, Noofdays As Integer
            Dim Viewer As New ReportViwer
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            STRSUBS = ""
            If MeValidate() = False Then Exit Sub

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then MONTH1 = 4 : Noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then MONTH1 = 5 : Noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then MONTH1 = 6 : Noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then MONTH1 = 7 : Noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then MONTH1 = 8 : Noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then MONTH1 = 9 : Noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then MONTH1 = 10 : Noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then MONTH1 = 11 : Noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then MONTH1 = 12 : Noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then MONTH1 = 1 : Noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then MONTH1 = 2 : Noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then MONTH1 = 3 : Noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            If (chk_Filter_Field.CheckedItems.Count <= 0) Then
                MessageBox.Show("Select the Category Items!")
                Exit Sub
            End If
            PRINTREP = False
            'If Chk_facilitywise.Checked = True Then
            '    Call printdata()
            'ElseIf Chk_memberwise.Checked = True Then
            '    Call printdata1()
            If RDB_MEMBER_LIST_SUBS.Checked = True Then
                Dim r As New Cry_Facility_Det
                mthyar = " FACILITY DETAILS FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " SELECT MCODE,MEM_NAME,MNAME,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(ISNULL(TAXAMOUNT,0)),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")AND SUBSDESC IN(" & Txt_faclitywise.Text.Substring(0, Txt_faclitywise.Text.Length - 1) & ") "
                sqlstring = sqlstring & " AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME,SUBSDESC,MNAME"
                sqlstring = sqlstring & " ORDER BY MCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                '  txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1 = r.ReportDefinition.ReportObjects("Text18")
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)

            ElseIf RDB_Facility_List.Checked = True Then
                Dim r As New Cry_Facilit_mem_List
                mthyar = "FACILITY DETAILS FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " select MCODE,MEM_NAME,MNAME,DNAME,SUBSDESC  FROM VIEW_FACILITY_LIST "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")AND SUBSDESC IN(" & Txt_faclitywise.Text.Substring(0, Txt_faclitywise.Text.Length - 1) & ") "
                ' sqlstring = sqlstring & " AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " ORDER BY MCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1 = r.ReportDefinition.ReportObjects("Text18")
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_FACILITY_LIST", r)
            End If
            txtobj1.Text = UCase(gCompanyname)
            txtobj1.Text = Format(SYSDATE, "dd/MM/yyyy")
            txtobj1.Text = Mid(gFinancialyearStart, 7, 4) & " - " & Mid(gFinancialYearEnd, 7, 4)
            txtobj1.Text = UCase(gUsername)
            txtobj1.Text = mthyar
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub printdata()
        Try

            Dim cmdText As String

            cmdText = "SELECT MCODE,MNAME,TYPEDESC,Curentstatus,Subscode,Subsdesc,total,fcode,fdesc,FROMDATE,TODATE, count(*)FROM MM_Facility"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where TYPEDESC in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txt_mcode.Text <> "" And txt_Tomcode.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            End If

            cmdText = cmdText & "GROUP BY MCODE,MNAME,TYPEDESC,Curentstatus,Subscode,Subsdesc,total,fcode,fdesc,FROMDATE,TODATE HAVING count(*) > 1"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_facility_List
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)

            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "MM_Facility"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub printdata1()
        Try
            Dim cmdText As String
            '           cmdText = "Select * From MM_Facility"
            cmdText = "SELECT MCODE,MNAME,TYPEDESC,Curentstatus,Subscode,Subsdesc,total,fcode,fdesc,FROMDATE,TODATE, count(*)FROM MM_Facility"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'Dim j As Object
            'For Each j In chk_Filter_Field.CheckedItems
            '    txtCategory.Text += "'" & j.ToString() & "',"
            'Next j
            'Dim k As Object
            cmdText = cmdText & " where TYPEDESC in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txt_mcode.Text <> "" And txt_Tomcode.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            End If
            cmdText = cmdText & "GROUP BY MCODE,MNAME,TYPEDESC,Curentstatus,Subscode,Subsdesc,total,fcode,fdesc,FROMDATE,TODATE HAVING count(*) > 1"
            'cmdText = cmdText & "ORDER BY MCODE asc"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Facilit_mem_List
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gUsername)

            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "MM_Facility"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            Dim i As Integer
            'cmb_Filter_By.Focus()
            'cmb_Filter_By.SelectedIndex = 1
            txt_mcode.Text = ""
            txt_Tomcode.Text = ""
            'Rd_Win.Checked = True
            'If rdb_date.Checked = True Then
            '    Dtp_From.Visible = True
            '    Dtp_To.Visible = True
            'Else
            '    Dtp_From.Visible = False
            '    Dtp_To.Visible = False
            'End If
            For i = 0 To (chk_Filter_Field.Items.Count - 1)
                chk_Filter_Field.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LOADFACILITY()
        Dim i As Integer
        sqlstring = "select distinct(FDESC) from FACILITY_HDR where isnull(FDESC,'')<>''"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Chk_Facility.Items.Add(dt.Rows(Itration).Item("FDESC"))
        Next
    End Sub
    Private Function MeValidate() As Boolean
        Try
            Dim Iteration, I, J As Integer
            MeValidate = True
            Dim MTYPECODE(0) As String
            Dim o As Object

            If chk_Filter_Field.CheckedItems.Count > 0 Then

                For Each o In chk_Filter_Field.CheckedItems
                    txtCategory.Text += "'" & o.ToString() & "',"
                Next o

                For Each o In Chk_Facility.CheckedItems
                    Txt_faclitywise.Text += "'" & o.ToString() & "',"
                Next o

                'For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
                '    MTYPECODE = chk_Filter_Field.CheckedItems(I)
                '    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
                'Next
                'STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            'If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
            '    For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
            '        MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), )
            '        STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
            '    Next
            '    STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            'Else
            '    MsgBox("Please Select The Member Status Name", vbInformation)
            '    MeValidate = False
            '    Exit Function
            'End If
            'If CHKLIST_SELECT.CheckedItems.Count > 0 Then
            '    For I = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
            '        MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(I), ".")
            '        STR_OPCTION = STR_OPCTION & " '" & Trim(MTYPECODE(0)) & "', "
            '    Next
            '    STR_OPCTION = Mid(STR_OPCTION, 1, Len(STR_OPCTION) - 2)
            'Else
            '    MsgBox("Please Select The Member(S)", vbInformation)
            '    Exit Function
            'End If

            'If CHKLIST_SUBSCRIPTIONMAST.CheckedItems.Count > 0 Then
            '    For I = 0 To CHKLIST_SUBSCRIPTIONMAST.CheckedItems.Count - 1
            '        MTYPECODE = Split(CHKLIST_SUBSCRIPTIONMAST.CheckedItems(I), ".")
            '        STRSUBS = STRSUBS & " '" & Trim(MTYPECODE(1)) & "', "
            '    Next
            '    STRSUBS = Mid(STRSUBS, 1, Len(STRSUBS) - 2)
            'Else
            '    MsgBox("Please Select The Member Subscription  Name", vbInformation)
            '    MeValidate = False
            '    Exit Function
            'End If

            'If Chk_Facility.CheckedItems.Count > 0 Then
            '    For I = 0 To Chk_Facility.CheckedItems.Count - 1
            '        MTYPECODE = Chk_Facility.CheckedItems(I)
            '        STRSUBS = STRSUBS & " '" & Trim(MTYPECODE(1)) & "', "
            '    Next
            '    STRSUBS = Mid(STRSUBS, 1, Len(STRSUBS) - 2)
            'Else
            '    MsgBox("Please Select The Member Subscription  Name", vbInformation)
            '    MeValidate = False
            '    Exit Function
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub Txt_faclitywise_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_faclitywise.TextChanged

    End Sub

    Private Sub Chk_Facility_wise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Facility_wise.CheckedChanged

        Dim Iteration As Integer
        If Chk_Facility_wise.Checked = True Then
            Try
                For Iteration = 0 To (Chk_Facility.Items.Count - 1)
                    Chk_Facility.SetSelected(Iteration, True)
                    Chk_Facility.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_Facility.Items.Count - 1)
                    Chk_Facility.SetSelected(Iteration, False)
                    Chk_Facility.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
