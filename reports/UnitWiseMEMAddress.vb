Imports System.Data
Imports System.IO
Imports System
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class UnitWiseMEMAddress
    Inherits System.Windows.Forms.Form
    Dim FltrStr, TempString(2), DispString, addFltrStr, status As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Public selectNo As Integer
    Dim dt, posting As New DataTable
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Rd_Win As System.Windows.Forms.RadioButton
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rdb_all As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_date As System.Windows.Forms.RadioButton
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rd_Dos As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_UnitWise As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAllUnitWise As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents txtUnitWise As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UnitWiseMEMAddress))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUnitWise = New System.Windows.Forms.TextBox
        Me.chk_PrintAllUnitWise = New System.Windows.Forms.CheckBox
        Me.chk_UnitWise = New System.Windows.Forms.CheckedListBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Rd_Win = New System.Windows.Forms.RadioButton
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdb_all = New System.Windows.Forms.RadioButton
        Me.rdb_date = New System.Windows.Forms.RadioButton
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker
        Me.Rd_Dos = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtUnitWise)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAllUnitWise)
        Me.GroupBox1.Controls.Add(Me.chk_UnitWise)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cmb_Filter_By)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 432)
        Me.GroupBox1.TabIndex = 381
        Me.GroupBox1.TabStop = False
        '
        'txtUnitWise
        '
        Me.txtUnitWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitWise.Location = New System.Drawing.Point(448, 280)
        Me.txtUnitWise.Name = "txtUnitWise"
        Me.txtUnitWise.Size = New System.Drawing.Size(216, 21)
        Me.txtUnitWise.TabIndex = 610
        Me.txtUnitWise.Text = ""
        Me.txtUnitWise.Visible = False
        '
        'chk_PrintAllUnitWise
        '
        Me.chk_PrintAllUnitWise.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAllUnitWise.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAllUnitWise.Location = New System.Drawing.Point(448, 72)
        Me.chk_PrintAllUnitWise.Name = "chk_PrintAllUnitWise"
        Me.chk_PrintAllUnitWise.Size = New System.Drawing.Size(200, 16)
        Me.chk_PrintAllUnitWise.TabIndex = 609
        Me.chk_PrintAllUnitWise.Text = "Print All Unit Wise"
        '
        'chk_UnitWise
        '
        Me.chk_UnitWise.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_UnitWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_UnitWise.Location = New System.Drawing.Point(448, 96)
        Me.chk_UnitWise.Name = "chk_UnitWise"
        Me.chk_UnitWise.Size = New System.Drawing.Size(216, 196)
        Me.chk_UnitWise.Sorted = True
        Me.chk_UnitWise.TabIndex = 608
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(32, 280)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(368, 21)
        Me.txtCategory.TabIndex = 607
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'Rd_Win
        '
        Me.Rd_Win.BackColor = System.Drawing.Color.Transparent
        Me.Rd_Win.Checked = True
        Me.Rd_Win.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_Win.Location = New System.Drawing.Point(96, 440)
        Me.Rd_Win.Name = "Rd_Win"
        Me.Rd_Win.Size = New System.Drawing.Size(88, 24)
        Me.Rd_Win.TabIndex = 605
        Me.Rd_Win.TabStop = True
        Me.Rd_Win.Text = "Windows"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(440, 320)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 395
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(200, 320)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 394
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(32, 72)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(216, 16)
        Me.chk_PrintAll.TabIndex = 393
        Me.chk_PrintAll.Text = "Print All Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 392
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 18)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(360, 320)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 21)
        Me.tbx_filter_To.TabIndex = 8
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(120, 320)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 21)
        Me.tbx_Filter_From.TabIndex = 7
        Me.tbx_Filter_From.Text = ""
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(32, 96)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(368, 196)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 2
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(320, 32)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 21)
        Me.cmb_Filter_By.TabIndex = 0
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(152, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 388
        Me.Label9.Text = "CATEGORY  FILITER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.rdb_all)
        Me.Panel1.Controls.Add(Me.rdb_date)
        Me.Panel1.Controls.Add(Me.Dtp_From)
        Me.Panel1.Controls.Add(Me.Dtp_To)
        Me.Panel1.Location = New System.Drawing.Point(32, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 104)
        Me.Panel1.TabIndex = 606
        '
        'rdb_all
        '
        Me.rdb_all.Checked = True
        Me.rdb_all.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_all.Location = New System.Drawing.Point(16, 32)
        Me.rdb_all.Name = "rdb_all"
        Me.rdb_all.Size = New System.Drawing.Size(64, 24)
        Me.rdb_all.TabIndex = 606
        Me.rdb_all.TabStop = True
        Me.rdb_all.Text = "All"
        '
        'rdb_date
        '
        Me.rdb_date.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_date.Location = New System.Drawing.Point(80, 32)
        Me.rdb_date.Name = "rdb_date"
        Me.rdb_date.Size = New System.Drawing.Size(168, 24)
        Me.rdb_date.TabIndex = 605
        Me.rdb_date.Text = "DOJ  Between Date"
        '
        'Dtp_From
        '
        Me.Dtp_From.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_From.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(248, 32)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(111, 21)
        Me.Dtp_From.TabIndex = 400
        Me.Dtp_From.Visible = False
        '
        'Dtp_To
        '
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(376, 32)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(115, 21)
        Me.Dtp_To.TabIndex = 401
        Me.Dtp_To.Visible = False
        '
        'Rd_Dos
        '
        Me.Rd_Dos.BackColor = System.Drawing.Color.Transparent
        Me.Rd_Dos.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_Dos.Location = New System.Drawing.Point(208, 440)
        Me.Rd_Dos.Name = "Rd_Dos"
        Me.Rd_Dos.Size = New System.Drawing.Size(64, 24)
        Me.Rd_Dos.TabIndex = 604
        Me.Rd_Dos.Text = "Dos"
        Me.Rd_Dos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 29)
        Me.Label2.TabIndex = 382
        Me.Label2.Text = "UNIT WISE MEMBER ADDRESS LIST"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(96, 488)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 56)
        Me.GroupBox2.TabIndex = 383
        Me.GroupBox2.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Menu
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(328, 16)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 32)
        Me.btnExport.TabIndex = 17
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
        Me.CmdClear.Location = New System.Drawing.Point(224, 16)
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
        Me.cmdexit.Location = New System.Drawing.Point(432, 16)
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
        Me.cmdPrint.Location = New System.Drawing.Point(120, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 16
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
        Me.CmdView.Location = New System.Drawing.Point(16, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'Lst_status
        '
        Me.Lst_status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status.Items.AddRange(New Object() {"LIVE", "SUSPENDED", "DEFAULTER", "BLOCKED", "RESIGNED", "OUTSTATION", "TERMINATED", "EXPIRED"})
        Me.Lst_status.Location = New System.Drawing.Point(744, 136)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(72, 147)
        Me.Lst_status.TabIndex = 384
        Me.Lst_status.Visible = False
        '
        'UnitWiseMEMAddress
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 590)
        Me.Controls.Add(Me.Lst_status)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Rd_Win)
        Me.Controls.Add(Me.Rd_Dos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnitWiseMEMAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnitWiseMEMAddress"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub UnitWiseMEMAddress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmb_Filter_By.SelectedIndex = 1
        LoadUnitNO()
        Show()
        cmb_Filter_By.Focus()
        Rd_Win.Checked = True
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
            cmb_Filter_By.SelectedIndex = 1
            tbx_Filter_From.Text = ""
            tbx_filter_To.Text = ""
            Rd_Win.Checked = True
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
            For i = 0 To (chk_UnitWise.Items.Count - 1)
                chk_UnitWise.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then

            For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                chk_Filter_Field.SetSelected(Iteration, True)
                chk_Filter_Field.SetItemChecked(Iteration, True)
            Next

        Else

            For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                chk_Filter_Field.SetSelected(Iteration, False)
                chk_Filter_Field.SetItemChecked(Iteration, False)
            Next

        End If
    End Sub

    Private Sub chk_PrintAllUnitWise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAllUnitWise.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAllUnitWise.Checked = True Then

            For Iteration = 0 To (chk_UnitWise.Items.Count - 1)
                chk_UnitWise.SetSelected(Iteration, True)
                chk_UnitWise.SetItemChecked(Iteration, True)
            Next

        Else

            For Iteration = 0 To (chk_UnitWise.Items.Count - 1)
                chk_UnitWise.SetSelected(Iteration, False)
                chk_UnitWise.SetItemChecked(Iteration, False)
            Next

        End If
    End Sub

    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
        chk_PrintAll.Checked = False
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        Try
            chk_Filter_Field.Items.Clear()
            If cmb_Filter_By.Text = "Member Category" Then
                selectNo = 0
                FltrStr = "MemberTypeCode in ('"
                Fill_Chk_str = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
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

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items!")
            Exit Sub

        End If

        PRINTREP = False
        'Call Memberlist()
        'Call printdata1()
        If Rd_Dos.Checked = True Then
            'Call printdata1()
        ElseIf Rd_Win.Checked = True Then
            'Call printdata2()
            Call printdata3()
        End If
    End Sub

    Public Sub printdata3()
        Try

            Dim cmdText As String
            cmdText = "Select * From VW_UNITWISE_MEMBER"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'If chk_Filter_Field.

            txtUnitWise.Text = ""
            Dim j As Object
            For Each j In chk_UnitWise.CheckedItems


                txtUnitWise.Text += "'" & j.ToString() & "',"
            Next j


            If (cmb_Filter_By.Text = "Member Category") Then
                cmdText = cmdText & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

            If (txtUnitWise.Text <> "") Then
                'cmdText = cmdText & " and unitno in (" & txtUnitWise.Text.Substring(0, txtUnitWise.Text.Length - 1) & ")"
                cmdText = cmdText & " and UNITNAME in (" & txtUnitWise.Text.Substring(0, txtUnitWise.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            If (rdb_all.Text <> "All") Then

                cmdText = cmdText & " and doj between '" & Dtp_From.Value & "' and '" & Dtp_To.Value & "'"

            End If

            cmdText = cmdText & " order by mcode asc"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_UnitWiseMember
            Dim txtobj1 As TextObject
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "VW_UNITWISE_MEMBER"
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
            cmdText = "Select * From VW_UNITWISE_MEMBER"

            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'If chk_Filter_Field.


            txtUnitWise.Text = ""
            Dim j As Object
            For Each j In chk_UnitWise.CheckedItems

                txtUnitWise.Text += "'" & j.ToString() & "',"
            Next j


            If (cmb_Filter_By.Text = "Member Category") Then
                cmdText = cmdText & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

            If (txtUnitWise.Text <> "") Then
                cmdText = cmdText & " and unitno in (" & txtUnitWise.Text.Substring(0, txtUnitWise.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            If (rdb_all.Text <> "All") Then

                cmdText = cmdText & " and doj between '" & Dtp_From.Value & "' and '" & Dtp_To.Value & "'"

            End If

            cmdText = cmdText & " order by mcode asc"

            _export.TABLENAME = "VW_UNITWISE_MEMBER"
            Call _export.export_excel(cmdText)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadUnitNO()
        sqlstring = "select unitname from tbl_unitmaster where freeze='N'"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            chk_UnitWise.Items.Add(dt.Rows(Itration).Item("unitname"))
        Next
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If (Rd_Win.Checked = True) Then
            Call printdata3()
        End If
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
            tbx_filter_To.Select()
        End If
        vform.Close()
        vform = Nothing
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

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Rd_Dos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rd_Dos.CheckedChanged

    End Sub
End Class
