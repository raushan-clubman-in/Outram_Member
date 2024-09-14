Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class SubscriptionListDetails
    Inherits System.Windows.Forms.Form
    Dim FltrStr, TempString(2), DispString, addFltrStr, status As String
    Dim sqlStringFinal, sqlstring, ssql As String
    Dim dt, posting As New DataTable
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J As Integer
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
    Friend WithEvents chkList_Subscription As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_date As System.Windows.Forms.RadioButton
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_type As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TypeWise As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txttypeWise As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents Rdo_member As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RDB_SUB_SUMMARY As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubscriptionListDetails))
        Me.chkList_Subscription = New System.Windows.Forms.CheckedListBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RDB_SUB_SUMMARY = New System.Windows.Forms.RadioButton
        Me.chk_TypeWise = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Rdo_member = New System.Windows.Forms.RadioButton
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdb_date = New System.Windows.Forms.RadioButton
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Chk_type = New System.Windows.Forms.CheckBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.txttypeWise = New System.Windows.Forms.TextBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkList_Subscription
        '
        Me.chkList_Subscription.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chkList_Subscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkList_Subscription.ColumnWidth = 25
        Me.chkList_Subscription.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkList_Subscription.Location = New System.Drawing.Point(-80, -16)
        Me.chkList_Subscription.Name = "chkList_Subscription"
        Me.chkList_Subscription.ScrollAlwaysVisible = True
        Me.chkList_Subscription.Size = New System.Drawing.Size(48, 211)
        Me.chkList_Subscription.TabIndex = 4
        Me.chkList_Subscription.Visible = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.White
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(512, 496)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(112, 32)
        Me.cmdexit.TabIndex = 634
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdExport
        '
        Me.CmdExport.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExport.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExport.ForeColor = System.Drawing.Color.White
        Me.CmdExport.Image = CType(resources.GetObject("CmdExport.Image"), System.Drawing.Image)
        Me.CmdExport.Location = New System.Drawing.Point(392, 496)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(112, 32)
        Me.CmdExport.TabIndex = 633
        Me.CmdExport.Text = "Export[F12]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.White
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(152, 496)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(112, 32)
        Me.CmdClear.TabIndex = 631
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.White
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(272, 496)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(112, 32)
        Me.CmdView.TabIndex = 632
        Me.CmdView.Text = " View[F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(72, 472)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 80)
        Me.GroupBox1.TabIndex = 636
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RDB_SUB_SUMMARY)
        Me.GroupBox2.Controls.Add(Me.chk_TypeWise)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Rdo_member)
        Me.GroupBox2.Controls.Add(Me.Dtp_To)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 360)
        Me.GroupBox2.TabIndex = 638
        Me.GroupBox2.TabStop = False
        '
        'RDB_SUB_SUMMARY
        '
        Me.RDB_SUB_SUMMARY.AllowDrop = True
        Me.RDB_SUB_SUMMARY.Checked = True
        Me.RDB_SUB_SUMMARY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_SUB_SUMMARY.Location = New System.Drawing.Point(16, 280)
        Me.RDB_SUB_SUMMARY.Name = "RDB_SUB_SUMMARY"
        Me.RDB_SUB_SUMMARY.Size = New System.Drawing.Size(136, 24)
        Me.RDB_SUB_SUMMARY.TabIndex = 658
        Me.RDB_SUB_SUMMARY.TabStop = True
        Me.RDB_SUB_SUMMARY.Text = "Summary"
        '
        'chk_TypeWise
        '
        Me.chk_TypeWise.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_TypeWise.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_TypeWise.Location = New System.Drawing.Point(272, 32)
        Me.chk_TypeWise.Name = "chk_TypeWise"
        Me.chk_TypeWise.Size = New System.Drawing.Size(176, 194)
        Me.chk_TypeWise.Sorted = True
        Me.chk_TypeWise.TabIndex = 635
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(672, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TO DATE :"
        Me.Label3.Visible = False
        '
        'Rdo_member
        '
        Me.Rdo_member.BackColor = System.Drawing.Color.Transparent
        Me.Rdo_member.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdo_member.Location = New System.Drawing.Point(168, 280)
        Me.Rdo_member.Name = "Rdo_member"
        Me.Rdo_member.Size = New System.Drawing.Size(216, 24)
        Me.Rdo_member.TabIndex = 657
        Me.Rdo_member.Text = "Subscription Memberwise"
        '
        'Dtp_To
        '
        Me.Dtp_To.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(712, 304)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(115, 21)
        Me.Dtp_To.TabIndex = 640
        Me.Dtp_To.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BILL DATE :"
        Me.Label2.Visible = False
        '
        'rdb_date
        '
        Me.rdb_date.BackColor = System.Drawing.Color.Transparent
        Me.rdb_date.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_date.Location = New System.Drawing.Point(760, 376)
        Me.rdb_date.Name = "rdb_date"
        Me.rdb_date.Size = New System.Drawing.Size(168, 24)
        Me.rdb_date.TabIndex = 641
        Me.rdb_date.Text = " Between Date"
        Me.rdb_date.Visible = False
        '
        'Dtp_From
        '
        Me.Dtp_From.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(632, 56)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(111, 21)
        Me.Dtp_From.TabIndex = 639
        Me.Dtp_From.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(88, 120)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(208, 16)
        Me.chk_PrintAll.TabIndex = 643
        Me.chk_PrintAll.Text = "Select  All  Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(88, 144)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(216, 196)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 642
        '
        'Chk_type
        '
        Me.Chk_type.BackColor = System.Drawing.Color.Transparent
        Me.Chk_type.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_type.Location = New System.Drawing.Point(344, 120)
        Me.Chk_type.Name = "Chk_type"
        Me.Chk_type.Size = New System.Drawing.Size(208, 16)
        Me.Chk_type.TabIndex = 644
        Me.Chk_type.Text = "Select  Type"
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(88, 312)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(216, 21)
        Me.txtCategory.TabIndex = 645
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'txttypeWise
        '
        Me.txttypeWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttypeWise.Location = New System.Drawing.Point(344, 312)
        Me.txttypeWise.Name = "txttypeWise"
        Me.txttypeWise.Size = New System.Drawing.Size(168, 21)
        Me.txttypeWise.TabIndex = 646
        Me.txttypeWise.Text = ""
        Me.txttypeWise.Visible = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(472, 352)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 655
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(232, 352)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 654
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 653
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 17)
        Me.Label8.TabIndex = 652
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(392, 352)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 21)
        Me.tbx_filter_To.TabIndex = 651
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(152, 352)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 21)
        Me.tbx_Filter_From.TabIndex = 650
        Me.tbx_Filter_From.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 20)
        Me.Label10.TabIndex = 657
        Me.Label10.Text = "SUBSCRIPTION MONTH OF"
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(352, 72)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 26)
        Me.CbxMonth.TabIndex = 656
        '
        'SubscriptionListDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 590)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Controls.Add(Me.cmd_MCodefromHelp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbx_filter_To)
        Me.Controls.Add(Me.tbx_Filter_From)
        Me.Controls.Add(Me.Chk_type)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdExport)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.chkList_Subscription)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dtp_From)
        Me.Controls.Add(Me.rdb_date)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txttypeWise)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "SubscriptionListDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubscriptionListDetails"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SubscriptionListDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        chk_loadcategory()
        Loadtype()
        Rdo_member.Checked = True
        Show()
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub

    Private Sub Rnd_Summary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Loadtype()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExport.Click

    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click

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
            Call MeValidate()
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
            If RDB_SUB_SUMMARY.Checked = True Then
                Dim r As New Cry_Subscription_Summary
                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " SELECT SUBSCODE,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                ' sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND SUBSTYPE IN(" & STRSUBS & ")"
                If (txtCategory.Text <> "") Then
                    sqlstring = sqlstring & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
                End If
                If (txttypeWise.Text <> "") Then
                    sqlstring = sqlstring & " and SUBSTYPE in (" & txttypeWise.Text.Substring(0, txttypeWise.Text.Length - 1) & ")"
                End If

                sqlstring = sqlstring & " AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY SUBSCODE,SUBSDESC "
                sqlstring = sqlstring & " ORDER BY SUBSCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)
               
            ElseIf Rdo_member.Checked = True Then

                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                Dim r As New Cry_Subs_Details
                sqlstring = " SELECT MCODE,MEM_NAME,MNAME,ISNULL(SUM(SUBAMOUNT),0) AS  SUBAMOUNT,ISNULL(SUM(FLTAMOUNT),0) AS  FLTAMOUNT,ISNULL(SUM(MINAMOUNT),0) AS MINAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT  FROM VIEW_MEM_SUBS_DET "
                'sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND SUBSDESC IN(" & STRSUBS & ") "

                If (txtCategory.Text <> "") Then
                    sqlstring = sqlstring & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
                End If
                If (txttypeWise.Text <> "") Then
                    sqlstring = sqlstring & " and SUBSTYPE in (" & txttypeWise.Text.Substring(0, txttypeWise.Text.Length - 1) & ")"
                End If
                sqlstring = sqlstring & " AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME,MNAME,SUBSDESC "
                sqlstring = sqlstring & " ORDER BY MCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_REP_SUBS_FLT_MUM", r)

            End If
            txtobj1.Text = UCase(gCompanyname)
            txtobj2.Text = Format(SYSDATE, "dd/MM/yyyy")
            txtobj3.Text = Mid(gFinancialyearStart, 7, 4) & " - " & Mid(gFinancialYearEnd, 7, 4)
            txtobj4.Text = UCase(gUsername)
            txtobj5.Text = mthyar
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'If (chk_Filter_Field.CheckedItems.Count <= 0) Then
        '    MessageBox.Show("Select the Category Items!")
        '    Exit Sub
        'End If

        'If Rdo_member.Checked = True Then
        '    Call printdata1()
        'End If

    End Sub
    Private Sub printdata()
        'Try
        '    Dim cmdText As String
        '    cmdText = "select * from MM_SUBSCRIPTIONLIST"
        '    txtCategory.Text = ""
        '    Dim o As Object
        '    For Each o In chk_Filter_Field.CheckedItems
        '        txtCategory.Text += "'" & o.ToString() & "',"
        '    Next o
        '    txttypeWise.Text = ""
        '    Dim j As Object
        '    For Each j In chk_TypeWise.CheckedItems
        '        txttypeWise.Text += "'" & j.ToString() & "',"
        '    Next j
        '    If (txtCategory.Text <> "") Then
        '        cmdText = cmdText & " where typedesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
        '    End If
        '    If (txttypeWise.Text <> "") Then
        '        cmdText = cmdText & " and Type in (" & txttypeWise.Text.Substring(0, txttypeWise.Text.Length - 1) & ")"
        '    End If
        '    'If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
        '    '    cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
        '    'End If
        '    cmdText = cmdText & " order by mcode asc"
        '    Dim Viewer As New ReportViwer
        '    Dim r As New Cry_subscriptionlist
        '    Dim txtobj1 As TextObject
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '    txtobj1.Text = UCase(gCompanyname)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text2")
        '    txtobj1.Text = UCase(gCompanyAddress(1))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
        '    txtobj1.Text = UCase(gCompanyAddress(2))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
        '    txtobj1.Text = UCase(gCompanyAddress(3))

        '    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        '    txtobj1.Text = UCase(gUsername)

        '    Viewer.ssql = cmdText
        '    Viewer.Report = r
        '    Viewer.TableName = "MM_SUBSCRIPTIONLIST"
        '    Viewer.Show()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub printdata1()
        'Try
        '    Dim cmdText, billdate As String
        '    billdate = Format(Dtp_From.Value, "MMMyyyy")

        '    cmdText = "select * from MM_SUBSCRIPTION_SUMMARY"
        '    txtCategory.Text = ""
        '    Dim o As Object
        '    For Each o In chk_Filter_Field.CheckedItems
        '        txtCategory.Text += "'" & o.ToString() & "',"
        '    Next o
        '    txttypeWise.Text = ""
        '    Dim j As Object
        '    For Each j In chk_TypeWise.CheckedItems
        '        txttypeWise.Text += "'" & j.ToString() & "',"
        '    Next j
        '    If (txtCategory.Text <> "") Then
        '        cmdText = cmdText & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
        '    End If
        '    If (txttypeWise.Text <> "") Then
        '        cmdText = cmdText & " and Type in (" & txttypeWise.Text.Substring(0, txttypeWise.Text.Length - 1) & ")"
        '    End If
        '    'cmdText = cmdText & " and billdate = '" & Dtp_From.Text & "'"
        '    cmdText = cmdText & " AND MONTH(BILLDATE)=" & MONTH1
        '    cmdText = cmdText & " order by mcode asc"
        '    Dim Viewer As New ReportViwer
        '    Dim r As New Cry_Subscription_Det
        '    Dim txtobj1 As TextObject
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '    txtobj1.Text = UCase(gCompanyname)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text24")
        '    txtobj1.Text = UCase(gCompanyAddress(1))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text25")
        '    txtobj1.Text = UCase(gCompanyAddress(2))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
        '    txtobj1.Text = UCase(gCompanyAddress(3))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text16")
        '    txtobj1.Text = UCase(gUsername)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        '    txtobj1.Text = billdate
        '    Viewer.ssql = cmdText
        '    Viewer.Report = r
        '    Viewer.TableName = "MM_SUBSCRIPTION_SUMMARY"
        '    Viewer.Show()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub


    Private Sub chkList_Subscription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkList_Subscription.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

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
        'Me.cmdPrint.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    ' Me.cmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
                If Right(x) = "P" Then
                    'Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Dim i As Integer
            'cmb_Filter_By.Focus()
            'cmb_Filter_By.SelectedIndex = 1
            'tbx_Filter_From.Text = ""
            'tbx_filter_To.Text = ""
            'Rd_Win.Checked = True
            ' ssgrid1.ClearRange(1, 1, -1, -1, True)
            If rdb_date.Checked = True Then
                Dtp_From.Visible = True
                Dtp_To.Visible = True
            Else
                Dtp_From.Visible = False
                Dtp_To.Visible = False
            End If
            For i = 0 To (chk_Filter_Field.Items.Count - 1)
                chk_Filter_Field.SetItemChecked(i, False)
            Next
            For i = 0 To (chk_TypeWise.Items.Count - 1)
                chk_TypeWise.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub
    Private Sub chk_loadcategory()
        '    Try
        '        Dim i As Integer
        '        gconnection.getDataSet("SELECT distinct(MemberType) FROM MEMBERMASTER Where Freeze='N'", "MEMBERMASTER")
        '        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
        '            For i = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
        '                Me.chk_Filter_Field.Items.Add(Trim(gdataset.Tables("MEMBERMASTER").Rows(i).Item(0)))
        '            Next i
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        '    End Try
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        chk_Filter_Field.Focus()
    End Sub
    Private Sub Loadtype()
        Dim i As Integer
        'cbo_Type.Items.Clear()
        'cbo_Type.Visible = True
        sqlstring = "select distinct(Type) from subscriptionmast where freeze='N'"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            chk_TypeWise.Items.Add(dt.Rows(Itration).Item("Type"))
        Next
    End Sub


    Private Sub cbo_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Chk_type_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_type.CheckedChanged
        Dim Iteration As Integer
        If Chk_type.Checked = True Then
            Try
                For Iteration = 0 To (chk_TypeWise.Items.Count - 1)
                    chk_TypeWise.SetSelected(Iteration, True)
                    chk_TypeWise.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_TypeWise.Items.Count - 1)
                    chk_TypeWise.SetSelected(Iteration, False)
                    chk_TypeWise.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
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
                tbx_Filter_From.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")

            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
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
                tbx_filter_To.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")

            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub chk_TypeWise_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_TypeWise.SelectedIndexChanged

    End Sub

    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub

    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If e.KeyValue = Keys.Enter Then
            cmd_MCodefromHelp_Click(e, sender)
        End If
    End Sub

    Private Sub chk_Filter_Field_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_Filter_Field.KeyDown

    End Sub

    Private Sub SubscriptionListDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                'If CmdAdd.Enabled = True Then
                '    Call CmdAdd_Click(sender, e)
                '    Exit Sub
                'End If
            ElseIf e.KeyCode = Keys.F6 Then
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
                If CmdExport.Enabled = True Then
                    Call CmdExport_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmdexit.Enabled = True Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Dtp_From_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_From.ValueChanged

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Function MeValidate() As Boolean
        Try
            'MeValidate = True
            'Dim MTYPECODE(0) As String

            'If chk_Filter_Field.CheckedItems.Count > 0 Then
            '    For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
            '        MTYPECODE = Split(chk_Filter_Field.CheckedItems(I), "")
            '        STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
            '    Next
            '    STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
            '    'STR_TYPE = STR_TYPE & ")"
            'Else
            '    MsgBox("Please Select The Member Type ", vbInformation)
            '    MeValidate = False
            '    Exit Function
            'End If

            'If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
            '    For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
            '        MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), ".")
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

            'If chk_TypeWise.CheckedItems.Count > 0 Then
            '    For I = 0 To chk_TypeWise.CheckedItems.Count - 1
            '        MTYPECODE = Split(chk_TypeWise.CheckedItems(I), "")
            '        STRSUBS = STRSUBS & " '" & Trim(MTYPECODE(1)) & "', "
            '    Next
            '    STRSUBS = Mid(STRSUBS, 1, Len(STRSUBS) - 2)
            'Else
            '    MsgBox("Please Select The Subscription", vbInformation)
            '    MeValidate = False
            '    Exit Function
            'End If
            Dim cmdText, billdate As String
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            txttypeWise.Text = ""
            Dim j As Object
            For Each j In chk_TypeWise.CheckedItems
                txttypeWise.Text += "'" & j.ToString() & "',"
            Next j
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class
