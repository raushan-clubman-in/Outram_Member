Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class MemberDirectory
    Inherits System.Windows.Forms.Form
    Dim FltrStr, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Dim txtobj1 As TextObject
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents rdb_all As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_date As System.Windows.Forms.RadioButton
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents chk_sur As System.Windows.Forms.CheckBox
    Friend WithEvents chk_first As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberDirectory))
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.rdb_all = New System.Windows.Forms.RadioButton
        Me.rdb_date = New System.Windows.Forms.RadioButton
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.chk_sur = New System.Windows.Forms.CheckBox
        Me.chk_first = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 29)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "MEMBER DIRECTORY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rdb_all)
        Me.GroupBox1.Controls.Add(Me.rdb_date)
        Me.GroupBox1.Controls.Add(Me.Dtp_To)
        Me.GroupBox1.Controls.Add(Me.Dtp_From)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 264)
        Me.GroupBox1.TabIndex = 380
        Me.GroupBox1.TabStop = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(32, 16)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(296, 16)
        Me.chk_PrintAll.TabIndex = 393
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(32, 40)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(448, 194)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(304, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'rdb_all
        '
        Me.rdb_all.BackColor = System.Drawing.Color.Transparent
        Me.rdb_all.Checked = True
        Me.rdb_all.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_all.Location = New System.Drawing.Point(8, 192)
        Me.rdb_all.Name = "rdb_all"
        Me.rdb_all.Size = New System.Drawing.Size(8, 24)
        Me.rdb_all.TabIndex = 2333
        Me.rdb_all.TabStop = True
        Me.rdb_all.Text = "All"
        Me.rdb_all.Visible = False
        '
        'rdb_date
        '
        Me.rdb_date.BackColor = System.Drawing.Color.Transparent
        Me.rdb_date.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_date.Location = New System.Drawing.Point(56, 192)
        Me.rdb_date.Name = "rdb_date"
        Me.rdb_date.Size = New System.Drawing.Size(8, 24)
        Me.rdb_date.TabIndex = 2332
        Me.rdb_date.Text = "DOJ  Between Date"
        Me.rdb_date.Visible = False
        '
        'Dtp_To
        '
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(256, 192)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(8, 24)
        Me.Dtp_To.TabIndex = 2331
        Me.Dtp_To.Visible = False
        '
        'Dtp_From
        '
        Me.Dtp_From.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_From.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(384, 192)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(8, 24)
        Me.Dtp_From.TabIndex = 2330
        Me.Dtp_From.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(128, 376)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(368, 21)
        Me.txtCategory.TabIndex = 2334
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(456, 424)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 385
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(288, 424)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 394
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 392
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(360, 424)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(96, 21)
        Me.tbx_filter_To.TabIndex = 8
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(192, 424)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(96, 21)
        Me.tbx_Filter_From.TabIndex = 7
        Me.tbx_Filter_From.Text = ""
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(312, 88)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 21)
        Me.cmb_Filter_By.TabIndex = 0
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 20)
        Me.Label9.TabIndex = 388
        Me.Label9.Text = "CATEGORY  FILITER"
        '
        'Lst_status
        '
        Me.Lst_status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status.Items.AddRange(New Object() {"ABSENTEE", "ACTIVE", "CEASED", "DEFAULTER", "EXPIRED", "INACTIVE", "LIVE", "RESIGNED", "SUSPENDED", "TERMINATED", "POSTED"})
        Me.Lst_status.Location = New System.Drawing.Point(616, 160)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(72, 147)
        Me.Lst_status.TabIndex = 385
        Me.Lst_status.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(128, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 378
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chk_first)
        Me.GroupBox2.Controls.Add(Me.chk_sur)
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(128, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 112)
        Me.GroupBox2.TabIndex = 383
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MemberShip"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Menu
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(344, 64)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 32)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "Export[F7]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(232, 64)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 5
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
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(456, 64)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 6
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
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(120, 64)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 4
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(8, 64)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'chk_sur
        '
        Me.chk_sur.Location = New System.Drawing.Point(384, 8)
        Me.chk_sur.Name = "chk_sur"
        Me.chk_sur.Size = New System.Drawing.Size(152, 24)
        Me.chk_sur.TabIndex = 19
        Me.chk_sur.Text = "Order By Surname"
        '
        'chk_first
        '
        Me.chk_first.Location = New System.Drawing.Point(384, 32)
        Me.chk_first.Name = "chk_first"
        Me.chk_first.Size = New System.Drawing.Size(152, 24)
        Me.chk_first.TabIndex = 20
        Me.chk_first.Text = "Order By Firstname"
        '
        'MemberDirectory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(790, 604)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbx_Filter_From)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbx_filter_To)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Lst_status)
        Me.Controls.Add(Me.cmd_MCodefromHelp)
        Me.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Controls.Add(Me.cmb_Filter_By)
        Me.Controls.Add(Me.GroupBox2)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.KeyPreview = True
        Me.Name = "MemberDirectory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBER DIRECTORY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub addresssticker_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub
    Private Sub addresssticker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Filter_By.Focus()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmb_Filter_By.SelectedIndex = 0
        'Cmb_add_filter.SelectedIndex = 0
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
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Dim i As Integer
            cmb_Filter_By.Focus()
            cmb_Filter_By.SelectedIndex = 0
            tbx_Filter_From.Text = ""
            tbx_filter_To.Text = ""
            chk_sur.Checked = False
            chk_first.Checked = False
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    cmb_Filter_By.Focus()
        'End If
    End Sub
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(TempString(1))
                    addFltrStr = FltrStr & Trim(TempString(selectNo)) & "'"
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = DispString & "," & Trim(TempString(1))
                    addFltrStr = addFltrStr & ",'" & Trim(TempString(selectNo)) & "'"
                End If
            Next i
            addFltrStr = addFltrStr & ")"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Memberlist()
        Dim str()() As String
        Dim i, j, row, sno, pageno, pagesize As Long
        Dim dr1 As DataRow
        Dim pr As String
        Dim STR0 As String
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim STR4 As String
        Dim STR5 As String
        Dim STR6 As String
        Dim STR7 As String
        Dim STR8 As String
        Dim STR9 As String
        Dim STR10 As String
        Dim STR11 As String
        Dim MEMBERTYPECODE As String
        Dim MEMBERTYPE As String
        Dim OADD1, OADD2, OADD3, OCITY, OSTATE, OCOUNTRY, OPIN, OPHONE1, OPHONE2 As String
        Try
            Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            If chkdatevalidate = False Then Exit Sub
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Sub
            End If
            Call chkfilterfield()
            sqlStringFinal = " select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(ppin,'') as pincode,isnull(pphone1,'') as phone1, isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1, isnull(membertypecode,'') as membertypecode, isnull(prefix,'') as prefix,isnull(cemail,'') as email,isnull(cfax,'') as fax,isnull(typedesc,'') as type  FROM membermaster a,membertype b where a.membertypecode = b.membertype and "
            sqlstring = sqlStringFinal & addFltrStr
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            End If
            If rdb_all.Checked = False Then
                sqlstring = sqlstring & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
            End If
            'sqlstring = sqlstring & " order by prefixmcode,msorderno"
            sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno,mcode asc"
            addlist = gconnection.GetValues(sqlstring)
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            pageno = 1
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            If Len(DispString) <= 65 Then
                Filewrite.WriteLine(Chr(27) + "E" & "MEMBER DIRECTORY: " & Trim(DispString) & Chr(27) + "F")
                pagesize = pagesize + 1
            Else
                Filewrite.Write(Chr(27) + "E" & "MEMBER DIRECTORY: ")
                j = 0
                For i = 1 To Len(Trim(DispString))
                    If j = 0 Then
                        Filewrite.WriteLine(Mid(Trim(DispString), 1, 65))
                        pagesize = pagesize + 1
                        i = i + 64
                    Else
                        Filewrite.WriteLine(Mid(Trim(DispString), i, 80))
                        pagesize = pagesize + 1
                        i = i + 79
                    End If
                    j = j + 1
                Next
            End If
            Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.WriteLine(Chr(18) & "MEMBER CODE                       ADDRESS" & Chr(18))
            Filewrite.WriteLine(StrDup(80, "-"))
            pagesize = pagesize + 4
            sno = 1
            For row = 0 To addlist.Rows.Count - 1
                dr1 = addlist.NewRow
                dr1 = addlist.Rows(row)
                STR0 = dr1(0)
                STR1 = dr1(1)
                STR2 = dr1(2)
                STR3 = dr1(3)
                STR4 = dr1(4)
                STR5 = dr1(5)
                STR6 = dr1(6)
                STR7 = dr1(7)
                STR8 = dr1(8)
                STR9 = dr1(9)
                OADD1 = dr1(10)
                OADD2 = dr1(11)
                OADD3 = dr1(12)
                OCITY = dr1(13)
                OSTATE = dr1(14)
                OCOUNTRY = dr1(15)
                OPIN = dr1(16)
                OPHONE1 = dr1(17)
                OPHONE2 = dr1(18)
                MEMBERTYPECODE = dr1(19)
                STR10 = dr1(20)
                STR11 = dr1(21)
                MEMBERTYPE = dr1(22)
                If pagesize > 60 Then
                    pagesize = 0
                    Filewrite.WriteLine("USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 80 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "MEMBER DIRECTORY:" & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "MEMBER DIRECTORY:")
                        j = 0
                        For i = 1 To Len(Trim(DispString))
                            If j = 0 Then
                                Filewrite.WriteLine(Mid(Trim(DispString), 1, 65))
                                pagesize = pagesize + 1
                                i = i + 64
                            Else
                                Filewrite.WriteLine(Mid(Trim(DispString), i, 80))
                                pagesize = pagesize + 1
                                i = i + 79
                            End If
                            j = j + 1
                        Next
                    End If
                    pageno = pageno + 1
                    Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO:" & Trim(CStr(pageno)))
                    Filewrite.WriteLine(StrDup(80, "-"))
                    Filewrite.WriteLine(Chr(18) & "MEMBER CODE                       ADDRESS" & Chr(18))
                    Filewrite.WriteLine(StrDup(80, "-"))
                    pagesize = pagesize + 4
                End If
                'Filewrite.WriteLine(Chr(27) & "E" & "{0,-10}{1,-25}{2,25}", STR0, "", Trim(dr1("prefix")) & " " & STR1 & Chr(27) & "F")
                pr = Trim(dr1("prefix")) & ""
                If pr <> "" Then
                    pr = Trim(dr1("prefix")) & " "
                Else
                    pr = ""
                End If
                'Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", STR0, "", pr & STR1)
                'Filewrite.WriteLine("RESIDENCE ADDRESS") : pagesize = pagesize + 1
                'If Trim(STR2) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR2) : pagesize = pagesize + 1
                'If Trim(STR3) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR3) : pagesize = pagesize + 1
                'If Trim(STR5) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR5) : pagesize = pagesize + 1
                'If Trim(STR6) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR6) : pagesize = pagesize + 1
                'If Trim(STR7) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR7) : pagesize = pagesize + 1
                'If Trim(STR8) <> "" And Trim(STR9) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR8 & STR9) : pagesize = pagesize + 1
                'Filewrite.WriteLine() : pagesize = pagesize + 1
                'Filewrite.WriteLine("OFFICE ADDRESS") : pagesize = pagesize + 1
                'If Trim(OADD1) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OADD1) : pagesize = pagesize + 1
                'If Trim(OADD2) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OADD2) : pagesize = pagesize + 1
                'If Trim(OADD3) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OADD3) : pagesize = pagesize + 1
                'If Trim(OCITY) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OCITY) : pagesize = pagesize + 1
                'If Trim(OSTATE) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OSTATE) : pagesize = pagesize + 1
                'If Trim(OCOUNTRY) <> "" And Trim(OPIN) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OCOUNTRY & OPIN) : pagesize = pagesize + 1
                'If Trim(OPHONE1) <> "" And Trim(OPHONE2) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", OPHONE1 & OPHONE2) : pagesize = pagesize + 1

                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", STR0, "Off:   ", OADD1) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", pr & STR1, "(" & Mid(MEMBERTYPE, 1, 3) & ")" & "   ", OADD2) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "Ph." & OPHONE1, "", OADD3) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "", "", OCITY) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "", "", OPIN) : pagesize = pagesize + 1
                Filewrite.WriteLine() : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "", "Res:   ", STR2) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "Ph." & STR8 & STR9, "", STR3) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", STR10, "", STR4) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", STR11, "", STR5) : pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-25}{1,10}{2,-45}", "", "", STR8) : pagesize = pagesize + 1

                Filewrite.WriteLine(StrDup(80, "-"))
                Filewrite.WriteLine(" ")
                pagesize = pagesize + 5
                STR0 = ""
                STR1 = ""
                STR2 = ""
                STR3 = ""
                STR4 = ""
                STR5 = ""
                STR6 = ""
                STR7 = ""
                STR8 = ""
                STR9 = ""
                OADD1 = ""
                OADD2 = ""
                OADD3 = ""
                OCITY = ""
                OSTATE = ""
                OCOUNTRY = ""
                OPIN = ""
                OPHONE1 = ""
                OPHONE2 = ""
                MEMBERTYPECODE = dr1(19)
                STR10 = ""
                STR11 = ""
                MEMBERTYPE = ""
                sno = sno + 1
            Next row
            sno = sno - 1
            Filewrite.Write("NO. OF ADDRESS LIST = " & Trim(CStr(sno)) & Space(5) & "USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox("Data not found..!")
            Exit Sub
        End Try
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        'Cmb_add_filter.Enabled = True
        Try
            chk_Filter_Field.Items.Clear()
            If cmb_Filter_By.Text = "Member Category" Then
                selectNo = 0
                FltrStr = "MemberTypeCode in ('"
                Fill_Chk_str = "SELECT SUBTYPECODE,SUBTypeDesc FROM SUBCATEGORYMASTER"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("SUBTypeDesc"))
                Next
            ElseIf cmb_Filter_By.Text = "Member Status" Then
                selectNo = 1
                FltrStr = "CurentStatus in('"
                chk_Filter_Field.Items.Clear()
                chk_Filter_Field.Items.AddRange(Lst_status.Items())

            End If
        Catch ex As Exception
            MsgBox("An invalided input…Please close the report filter and reopen it.")
            Exit Sub
        End Try
    End Sub
    Private Sub Cmb_add_filter_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
        '    sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
        '    sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix FROM membermaster where "
        'ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
        '    sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(ppin,'') as pincode,"
        '    sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'') as prefix FROM membermaster where "
        'ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
        '    sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        'ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
        '    sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        'End If
        sqlStringFinal = " select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,  ,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1, isnull(prefix,'') as prefix,isnull(cemail,'') as email,isnull(typedesc,'') as type  FROM membermaster a,membertype b where a.membertypecode = b.membertype and  "
    End Sub
    Private Sub tbx_Filter_From_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
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
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        Else
            PRINTREP = False
            Call Memberlist1()
        End If

    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        'Call Memberlist()
        Call Memberlist1()
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

    Private Sub CmdClear_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles CmdClear.ChangeUICues

    End Sub

    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub
    Private Sub rdb_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_date.CheckedChanged
        Try
            If rdb_date.Checked = True Then
                Dtp_From.Visible = True
                Dtp_To.Visible = True
            Else
                Dtp_From.Visible = False
                Dtp_To.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Memberlist1()
        Try
            Dim SQL, SQL1 As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Member_List_Photo
            If chk_sur.Checked = True Then
                SQL = "SELECT MEMIMAGE,ISNULL(SPOUSE,'')AS SPOUSE,ISNULL(MCODE,'')AS MCODE,ISNULL(SURNAME,'') + ' ' + ISNULL(MIDDLENAME,'')+ ' '+ ISNULL(FIRSTNAME,'') AS MNAME,ISNULL(CONTCELL,'')AS CONTCELL,ISNULL(CONTADD1,'')AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'')AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTEMAIL,'')AS CONTEMAIL ,MEMBERTYPECODE,MEMBERTYPE,ISNULL(CONTPIN,'') AS CONTPIN,ISNULL(DOJ,'') AS DOJ,ISNULL(SPOUSEIMAGE,'') AS SPOUSEIMAGE FROM MEMBERMASTER"
            ElseIf chk_first.Checked = True Then
                SQL = "SELECT MEMIMAGE,ISNULL(SPOUSE,'')AS SPOUSE,ISNULL(MCODE,'')AS MCODE,ISNULL(FIRSTNAME,'') + ' '+ ISNULL(MIDDLENAME,'')+ ' ' + ISNULL(SURNAME,'') AS MNAME,ISNULL(CONTCELL,'')AS CONTCELL,ISNULL(CONTADD1,'')AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'')AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTEMAIL,'')AS CONTEMAIL ,MEMBERTYPECODE,MEMBERTYPE,ISNULL(CONTPIN,'') AS CONTPIN,ISNULL(DOJ,'') AS DOJ,ISNULL(SPOUSEIMAGE,'') AS SPOUSEIMAGE FROM MEMBERMASTER"
            Else
                SQL = "SELECT MEMIMAGE,ISNULL(SPOUSE,'')AS SPOUSE,ISNULL(MCODE,'')AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CONTCELL,'')AS CONTCELL,ISNULL(CONTADD1,'')AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'')AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTEMAIL,'')AS CONTEMAIL ,MEMBERTYPECODE,MEMBERTYPE,ISNULL(CONTPIN,'') AS CONTPIN,ISNULL(DOJ,'') AS DOJ,ISNULL(SPOUSEIMAGE,'') AS SPOUSEIMAGE FROM MEMBERMASTER"

            End If


            txtCategory.Text = ""
            'txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            'For Each j In ChK_Memberstatus.CheckedItems
            '    txtStatus.Text += "'" & j.ToString() & "',"
            'Next j
            If (cmb_Filter_By.Text = "Member Category") Then
                SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                SQL = SQL & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            'If (txtCategory.Text <> "") Then
            '    SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in ('ACTIVE','LIVE')"
            'End If
            ''If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
            ''    SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            ''Else
            '    'MessageBox.Show("SELECT FROM AND TO MCODE NUMBER !")
            'End If
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " AND DOJ between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If
            If chk_sur.Checked = True Then
                SQL = SQL & " AND ISNULL(SURNAME,'')<>''"
            End If
            'SQL = SQL & " AND MEMIMAGE IS NOT NULL"
            If chk_sur.Checked = True Then
                SQL = SQL & " order by ISNULL(SURNAME,'') + ' ' + ISNULL(MIDDLENAME,'')+ ' '+ ISNULL(FIRSTNAME,'') Asc"
            ElseIf chk_first.Checked = True Then
                SQL = SQL & " order by firstname Asc"
            Else
                SQL = SQL & " order by mcode Asc"
            End If

            Call Viewer.GetDetails1(SQL, "MEMBERMASTER", r)
            'Call Viewer.GetDetails1(SQL1, "MEMBERIMAGE", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            'txtobj1.Text = UCase(gUsername)


            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim _export As New EXPORT
            'Dim Sqlstr As String = "  select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix,isnull(contcell,'') as contcell FROM membermaster where "

            Dim cmdText As String
            cmdText = "Select * From VW_MEMBERDIRECTORY"

            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'If chk_Filter_Field.


            If (cmb_Filter_By.Text = "Member Category") Then
                cmdText = cmdText & " where Type in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If


            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            If (rdb_all.Text <> "All") Then

                cmdText = cmdText & " and doj between '" & Dtp_From.Value & "' and '" & Dtp_To.Value & "'"

            End If

            cmdText = cmdText & " order by mcode asc"

            _export.TABLENAME = "VW_MEMBERDIRECTORY"
            Call _export.export_excel(cmdText)
            _export.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rdb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_all.CheckedChanged

    End Sub

    Private Sub chk_sur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_sur.CheckedChanged
        If chk_sur.Checked = True Then
            chk_first.Checked = False

        End If
    End Sub

    Private Sub chk_first_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_first.CheckedChanged
        If chk_first.Checked = True Then
            chk_sur.Checked = False

        End If
    End Sub
End Class
