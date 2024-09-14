Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class addresslist3
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Rd_Dos As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents rdb_all As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_address_strikers As System.Windows.Forms.RadioButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(addresslist))
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Rnd_address_strikers = New System.Windows.Forms.RadioButton
        Me.rdb_all = New System.Windows.Forms.RadioButton
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.Rd_Dos = New System.Windows.Forms.RadioButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(297, 29)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "MEMBER ADDRESS LIST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.cmb_Filter_By)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Cmb_add_filter)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 496)
        Me.GroupBox1.TabIndex = 380
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 611
        Me.Label3.Text = "Mcode"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(640, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 610
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(488, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 24)
        Me.TextBox1.TabIndex = 609
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(440, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(224, 220)
        Me.ListBox1.TabIndex = 608
        Me.ListBox1.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(32, 328)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(448, 21)
        Me.txtCategory.TabIndex = 607
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(664, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 18)
        Me.Label6.TabIndex = 602
        Me.Label6.Text = "Selected Member"
        Me.Label6.Visible = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(408, 368)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 395
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(264, 368)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 394
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(32, 64)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(248, 16)
        Me.chk_PrintAll.TabIndex = 393
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 370)
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
        Me.Label8.Location = New System.Drawing.Point(296, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "To"
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(184, 368)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 24)
        Me.tbx_Filter_From.TabIndex = 7
        Me.tbx_Filter_From.Text = ""
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(32, 96)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(392, 225)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 2
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status", "Member Code"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(184, 24)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(184, 25)
        Me.cmb_Filter_By.TabIndex = 0
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 18)
        Me.Label9.TabIndex = 388
        Me.Label9.Text = "CATEGORY  FILITER"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 389
        Me.Label10.Text = "ADDRESS  FILTER"
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Cmb_add_filter.ItemHeight = 17
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address", "Permanent Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(512, 24)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(184, 25)
        Me.Cmb_add_filter.TabIndex = 1
        Me.Cmb_add_filter.Text = "[select your filter]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Rd_Dos)
        Me.Panel1.Location = New System.Drawing.Point(32, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 136)
        Me.Panel1.TabIndex = 606
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnExport)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.Rnd_address_strikers)
        Me.GroupBox2.Controls.Add(Me.rdb_all)
        Me.GroupBox2.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(24, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 120)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBERSHIP NO"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Menu
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(328, 64)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(96, 32)
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
        Me.CmdClear.Location = New System.Drawing.Point(224, 64)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(91, 32)
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
        Me.cmdexit.Location = New System.Drawing.Point(440, 64)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(91, 32)
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
        Me.cmdPrint.Location = New System.Drawing.Point(120, 64)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(91, 32)
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
        Me.CmdView.Location = New System.Drawing.Point(16, 64)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(91, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'Rnd_address_strikers
        '
        Me.Rnd_address_strikers.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_address_strikers.Checked = True
        Me.Rnd_address_strikers.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_address_strikers.Location = New System.Drawing.Point(384, 32)
        Me.Rnd_address_strikers.Name = "Rnd_address_strikers"
        Me.Rnd_address_strikers.Size = New System.Drawing.Size(224, 20)
        Me.Rnd_address_strikers.TabIndex = 607
        Me.Rnd_address_strikers.TabStop = True
        Me.Rnd_address_strikers.Text = "Address Strikers List"
        '
        'rdb_all
        '
        Me.rdb_all.BackColor = System.Drawing.Color.Transparent
        Me.rdb_all.Checked = True
        Me.rdb_all.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_all.Location = New System.Drawing.Point(384, 8)
        Me.rdb_all.Name = "rdb_all"
        Me.rdb_all.Size = New System.Drawing.Size(224, 20)
        Me.rdb_all.TabIndex = 606
        Me.rdb_all.TabStop = True
        Me.rdb_all.Text = "All"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(264, 16)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 24)
        Me.tbx_filter_To.TabIndex = 8
        Me.tbx_filter_To.Text = ""
        '
        'Rd_Dos
        '
        Me.Rd_Dos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_Dos.Location = New System.Drawing.Point(96, 88)
        Me.Rd_Dos.Name = "Rd_Dos"
        Me.Rd_Dos.Size = New System.Drawing.Size(64, 24)
        Me.Rd_Dos.TabIndex = 604
        Me.Rd_Dos.Text = "Dos"
        Me.Rd_Dos.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(120, 328)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(552, 23)
        Me.ProgressBar1.TabIndex = 383
        Me.ProgressBar1.Visible = False
        '
        'ssgrid1
        '
        Me.ssgrid1.ContainingControl = Me
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(528, 96)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(168, 232)
        Me.ssgrid1.TabIndex = 603
        Me.ssgrid1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(168, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 378
        '
        'Lst_status1
        '
        Me.Lst_status1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.ACTIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(784, 304)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(72, 82)
        Me.Lst_status1.TabIndex = 382
        Me.Lst_status1.Visible = False
        '
        'Lst_status
        '
        Me.Lst_status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status.Items.AddRange(New Object() {"ACTIVE", "LIVE", "SUSPENDED", "DEFAULTER", "BLOCKED", "RESIGNED", "OUTSTATION", "TERMINATED", "EXPIRED", "POSTED"})
        Me.Lst_status.Location = New System.Drawing.Point(784, 424)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(72, 147)
        Me.Lst_status.TabIndex = 381
        Me.Lst_status.Visible = False
        '
        'addresslist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(782, 660)
        Me.Controls.Add(Me.Lst_status1)
        Me.Controls.Add(Me.Lst_status)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.KeyPreview = True
        Me.Name = "addresslist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addresssticker"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
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
            ElseIf e.KeyCode = Keys.F7 Then
                If btnExport.Enabled = True Then
                    Call btnExport_Click(sender, e)
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
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmb_Filter_By.SelectedIndex = 0
        Cmb_add_filter.SelectedIndex = 0
        Show()
        cmb_Filter_By.Focus()
        ' Rd_Win.Checked = True
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
            ListBox1.Items.Clear()
            ListBox1.Visible = False

            '  ssgrid1.ClearRange(1, 1, -1, -1, True)
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
        Try
            ' Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            If chkdatevalidate = False Then Exit Sub
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Sub
            End If
            Call chkfilterfield()
            sqlstring = sqlStringFinal & addFltrStr
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            Else
                'sqlstring = sqlstring & " AND DOJ >= '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND ISNULL(MembershipTo,'') <= '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
            End If
            'sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"

            sqlstring = sqlstring & " order by prefixmcode,msorderno"
            addlist = gconnection.GetValues(sqlstring)
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            pageno = 1
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            If Len(DispString) <= 65 Then
                Filewrite.WriteLine(Chr(27) + "E" & "ADDRESS LIST:" & Trim(DispString) & Chr(27) + "F")
                pagesize = pagesize + 1
            Else
                Filewrite.Write(Chr(27) + "E" & "ADDRESS LIST:")
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
                If pagesize > 60 Then
                    pagesize = 0
                    Filewrite.WriteLine("USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 80 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "ADDRESS LIST:" & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "ADDRESS LIST:")
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
                Filewrite.WriteLine("{0,-10}{1,24}{2,-25}", STR0, "", Trim(dr1("prefix")) & " " & STR1)
                If Trim(STR2) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR2) : pagesize = pagesize + 1
                If Trim(STR3) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR3) : pagesize = pagesize + 1
                If Trim(STR4) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR4) : pagesize = pagesize + 1
                If Trim(STR5) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR5) : pagesize = pagesize + 1
                'If Trim(STR6) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR6) : pagesize = pagesize + 1
                'If Trim(STR7) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR7) : pagesize = pagesize + 1
                If Trim(STR7) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR6 & STR7) : pagesize = pagesize + 1
                If Trim(STR8) <> "" And Trim(STR9) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR8 & Space(1) & STR9) : pagesize = pagesize + 1
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
        'chk_PrintAll.Checked = False
        'Dim MEMBERTYPE As New DataTable
        'Dim Fill_Chk_str As String
        'Cmb_add_filter.Enabled = True
        'Try
        '    chk_Filter_Field.Items.Clear()
        '    If cmb_Filter_By.Text = "Member Category" Then
        '        selectNo = 0
        '        FltrStr = "MemberTypeCode in ('"
        '        Fill_Chk_str = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        '        MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        '        Dim Itration
        '        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '            'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        '            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        '        Next
        '    ElseIf cmb_Filter_By.Text = "Member Status" Then
        '        selectNo = 1
        '        FltrStr = "CurentStatus in('"
        '        chk_Filter_Field.Items.Clear()
        '        chk_Filter_Field.Items.AddRange(Lst_status.Items())

        '    End If
        'Catch ex As Exception
        '    MsgBox("An invalided input…Please close the report filter and reopen it.")
        '    Exit Sub
        'End Try
        chk_PrintAll.Checked = False
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        Cmb_add_filter.Enabled = True
        Try
            chk_Filter_Field.Items.Clear()
            If cmb_Filter_By.Text = "Member Category" Then
                selectNo = 0
                FltrStr = "MemberTypeCode in ('"
                Fill_Chk_str = "SELECT subtypecode,subTypeDesc FROM SubCategorymaster"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("subtypecode") & "." & MEMBERTYPE.Rows(Itration).Item("subTypeDesc"))
                    'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                Next
                ListBox1.Items.Clear()
                ListBox1.Visible = False
                TextBox1.Visible = False
                Button1.Visible = False
                TextBox1.Visible = False
                Label3.Visible = False
                TextBox1.Text = ""

            ElseIf cmb_Filter_By.Text = "Member Status" Then
                selectNo = 1
                FltrStr = "CurentStatus in('"
                chk_Filter_Field.Items.Clear()
                chk_Filter_Field.Items.AddRange(Lst_status.Items())
                ListBox1.Items.Clear()
                ListBox1.Visible = False
                TextBox1.Visible = False
                Button1.Visible = False
                TextBox1.Visible = False
                Label3.Visible = False
                TextBox1.Text = ""
                'ListBox1.Items.Clear()

            ElseIf cmb_Filter_By.Text = "Member Code" Then
                selectNo = 2
                FltrStr = "Mcode in('"
                Fill_Chk_str = "SELECT mcode,mName FROM membermaster where isnull(Curentstatus,'')in('ACTIVE','LIVE')"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Mcode") & "." & MEMBERTYPE.Rows(Itration).Item("MNAME"))
                    'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                    ListBox1.Visible = True
                    Button1.Visible = True
                    TextBox1.Visible = True
                    Label3.Visible = True
                    TextBox1.Text = ""
                    TextBox1.Visible = True

                    ListBox1.Items.Clear()

                Next

            End If
        Catch ex As Exception
            MsgBox("An invalided input…Please close the report filter and reopen it.")
            Exit Sub
        End Try
    End Sub
    Private Sub Cmb_add_filter_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix,isnull(contcell,'') as contcell FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(ppin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'') as prefix,isnull(contcell,'') as contcell FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix ,isnull(contcell,'') as contcell FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix,ianull(contcell,'') as contcell  FROM membermaster where "
        End If
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
        If cmb_Filter_By.Text = "Member Code" Then
        Else
            If (chk_Filter_Field.CheckedItems.Count <= 0) Then
                MessageBox.Show("Select the Category Items")
                Exit Sub
            ElseIf tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
            End If
        End If
        PRINTREP = False
        If Rnd_address_strikers.Checked = True Then
            'Call print_strikers()
            Call printdata11()
        Else
            Call printdata3()
        End If


    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        ElseIf tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
        End If
        PRINTREP = True
        If Rnd_address_strikers.Checked = True Then
            'Call print_strikers()
            Call printdata11()
        Else
            Call printdata3()
        End If
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
                    chk_Filter_Field.SetSelected(Iteration, False)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmb_Filter_By_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Filter_By.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmb_add_filter.Focus()
        End If
    End Sub

    Private Sub Cmb_add_filter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_add_filter.KeyPress
        If Asc(e.KeyChar) = 13 Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ' Dtp_From.Focus()
        End If
    End Sub

    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub

    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tbx_filter_To.Focus()
        End If
    End Sub

    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_filter_To.TextChanged

    End Sub

    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub

    Private Sub Dtp_From_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'Dtp_To.Focus()
        End If
    End Sub

    Private Sub Dtp_To_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Private Function printdata11()
        Dim vMCode(2) As String
        Dim vMName(2) As String
        Dim vMAdd1(2) As String
        Dim vMAdd2(2) As String
        Dim vMAdd3(2) As String
        Dim sno As Integer
        Dim vMCity(2) As String
        Dim vMState(2) As String
        Dim vMTel(2) As String
        Dim vOption As Boolean
        Dim vMPinCode(2) As String
        Dim vsplit() As String
        Dim rcount As Integer
        Dim vAns As Double
        Dim str()() As String
        Dim i, j, lp, prn, lpNext1, lpNext2, pagesize As Integer
        Dim pageno As Long
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
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
        Dim vDoj(2) As String
        Dim vspouse(2) As String
        Dim vOrgName(2) As String
        Dim vDesignation(2) As String
        Dim vMCompany(2) As String
        Dim vMFax(2) As String
        Dim vMCell(2) As String
        Dim vMEmail(2), appcode() As String
        Dim tname As String
        Dim SMem As String
        Dim SelMem As String
        Dim loopindex As Integer
        Try
            Dim cmdText As String
            'Dim txtobj1 As TextObject
            'Dim txtobj2 As TextObject
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select ISNULL(MCODE,'')AS MCODE,ISNULL(PREFIX,'') AS PREFIX,ISNULL(SALUT,'') AS SALUT,ISNULL(MNAME,'')AS MNAME,ISNULL(CONTADD1,'')AS CONTADD1,ISNULL(CONTADD2,'')AS CONTADD2,ISNULL(CONTADD3,'')AS CONTADD3,ISNULL(CONTCITY,'')AS CONTCITY,ISNULL(CONTSTATE,'')AS CONTSTATE,ISNULL(CONTPIN,'')AS CONTPIN,ISNULL(CONTPHONE1,'')AS CONTPHONE1,ISNULL(CONTPHONE2,'')AS CONTPHONE2,ISNULL(CONTCELL,'')AS CONTCELL,ISNULL(CONTEMAIL,'')AS CONTEMAIL,ISNULL(PREFIXMCODE,'') AS PREFIXMCODE,ISNULL(MEMBERTYPE,'')AS MEMBERTYPE,ISNULL(MSORDERNO,0)AS MSORDERNO from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select * from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select * from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select * from MEMBERMASTER"
            End If
            'txtCategory.Text = ""
            'Dim o As Object
            'For Each o In chk_Filter_Field.CheckedItems
            '    txtCategory.Text += "'" & o.ToString() & "',"
            'Next o
            txtCategory.Text = ""
            'txtStatus.Text = ""
            If cmb_Filter_By.Text = "Member Code" Then
                cmdText = cmdText & " where isnull(mcode,'') in ("
                For i = 0 To ListBox1.Items.Count - 1
                    appcode = Split(ListBox1.Items(i), ".")
                    cmdText = cmdText & " '" & appcode(0) & "', "
                Next
            Else
                cmdText = cmdText & " where isnull(membertypecode,'') in ("
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    appcode = Split(chk_Filter_Field.CheckedItems(i), ".")
                    cmdText = cmdText & " '" & appcode(0) & "', "
                Next
            End If

            cmdText = Mid(cmdText, 1, Len(cmdText) - 2)
            cmdText = cmdText & ") and CurentStatus IN('LIVE','ACTIVE') and (RAcopyst1='Y' OR BAcopyst1='Y' OR PAcopyst1='Y')"


            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If

            cmdText = cmdText & " order by mCODE asc"
            Randomize()
            tname = "master1"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            pageno = 1
            dt = gconnection.GetValues(cmdText)
            pagesize = 1
            Dim icount As Integer
            'MessageBox.Show(dt.Rows.Count)
            If dt.Rows.Count > 0 Then

                sno = 1
                For i = 0 To dt.Rows.Count - 1
                    prn = 1
                    For j = 0 To 2
                        If i < dt.Rows.Count Then
                            vMCode(j) = Mid(Trim(dt.Rows(i).Item("mcode") & ""), 1, 40)
                            vMName(j) = Mid(Trim(dt.Rows(i).Item("SALUT") & ""), 1, 40) & " " & Mid(Trim(dt.Rows(i).Item("mname") & ""), 1, 40)
                            'vMName(j) = Mid(Trim(dt.Rows(i).Item("prefix") & ""), 1, 40)
                            vMAdd1(j) = Mid(Trim(dt.Rows(i).Item("contadd1") & ""), 1, 40)
                            vMAdd2(j) = Mid(Trim(dt.Rows(i).Item("contadd2") & ""), 1, 40)
                            vMAdd3(j) = Mid(Trim(dt.Rows(i).Item("contadd3") & ""), 1, 40)
                            vMCity(j) = Mid(Trim(dt.Rows(i).Item("contcity")) & IIf(Trim(dt.Rows(i).Item("contcity")) = "", "", "-") & Trim(dt.Rows(i).Item("contpin")), 1, 40)
                            vMTel(j) = "Tel. " & Trim(dt.Rows(i).Item("contphone1"))
                            i = i + 1
                        End If
                        sno = sno + 1
                    Next

                    Filewrite.WriteLine(Chr(18))
                    Filewrite.WriteLine(Mid(vMCode(0), 1, 15) & Space(15 - Len(Mid(vMCode(0), 1, 15))) & Space(16) & Mid(vMCode(1), 1, 15) & Space(15 - Len(Mid(vMCode(1), 1, 15))) & Space(16) & Mid(vMCode(2), 1, 15) & Space(15 - Len(Mid(vMCode(2), 1, 15))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMName(0), 1, 25) & Space(25 - Len(Mid(vMName(0), 1, 25))) & Space(6) & Mid(vMName(1), 1, 25) & Space(25 - Len(Mid(vMName(1), 1, 25))) & Space(6) & Mid(vMName(2), 1, 25) & Space(25 - Len(Mid(vMName(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd1(0), 1, 25) & Space(25 - Len(Mid(vMAdd1(0), 1, 25))) & Space(6) & Mid(vMAdd1(1), 1, 25) & Space(25 - Len(Mid(vMAdd1(1), 1, 25))) & Space(6) & Mid(vMAdd1(2), 1, 25) & Space(25 - Len(Mid(vMAdd1(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd2(0), 1, 25) & Space(25 - Len(Mid(vMAdd2(0), 1, 25))) & Space(6) & Mid(vMAdd2(1), 1, 25) & Space(25 - Len(Mid(vMAdd2(1), 1, 25))) & Space(6) & Mid(vMAdd2(2), 1, 25) & Space(25 - Len(Mid(vMAdd2(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd3(0), 1, 25) & Space(25 - Len(Mid(vMAdd3(0), 1, 25))) & Space(6) & Mid(vMAdd3(1), 1, 25) & Space(25 - Len(Mid(vMAdd3(1), 1, 25))) & Space(6) & Mid(vMAdd3(2), 1, 25) & Space(25 - Len(Mid(vMAdd3(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMCity(0), 1, 25) & Space(25 - Len(Mid(vMCity(0), 1, 25))) & Space(6) & Mid(vMCity(1), 1, 25) & Space(25 - Len(Mid(vMCity(1), 1, 25))) & Space(6) & Mid(vMCity(2), 1, 25) & Space(25 - Len(Mid(vMCity(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1


                    For j = 0 To 2
                        vMCode(j) = ""
                        vMName(j) = ""
                        vMAdd1(j) = ""
                        vMAdd2(j) = ""
                        vMAdd3(j) = ""
                        vMCity(j) = ""
                        vMState(j) = ""
                        vMPinCode(j) = ""
                        vMTel(j) = ""
                    Next
                    'vMCode(0) = ""

                    For j = 0 To 2
                        vMCode(j) = ""
                        vMName(j) = ""
                        vMAdd1(j) = ""
                        vMAdd2(j) = ""
                        vMAdd3(j) = ""
                        vMCity(j) = ""
                        vMState(j) = ""
                        vMPinCode(j) = ""
                        vMTel(j) = ""
                    Next
                    If i > dt.Rows.Count Then
                        i = dt.Rows.Count
                    Else
                        i = i - 1
                    End If
                Next
            Else
                MsgBox("No Record to View", MsgBoxStyle.Information, MyCompanyName)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function


    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            ssgrid1.InsertRows(ssgrid1.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid1.DeleteRows(ssgrid1.ActiveRow, 1)
        End If
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                .Row = .ActiveRow
                .Col = 1
                If Trim(.Text) <> "" Then
                    ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow + 1)
                End If
            End With
        End If
    End Sub
    Private Function printdata2()
        Dim vMCode(2) As String
        Dim vMName(2) As String
        Dim vMAdd1(2) As String
        Dim vMAdd2(2) As String
        Dim vMAdd3(2) As String
        Dim sno As Integer
        Dim vMCity(2) As String
        Dim vMState(2) As String
        Dim vMTel(2) As String
        Dim vOption As Boolean
        Dim vMPinCode(2) As String
        Dim vsplit() As String
        Dim rcount As Integer
        Dim vAns As Double
        Dim str()() As String
        Dim i, j, lp, prn, lpNext1, lpNext2, pagesize As Integer
        Dim pageno As Long
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
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
        Dim vDoj(2) As String
        Dim vspouse(2) As String
        Dim vOrgName(2) As String
        Dim vDesignation(2) As String
        Dim vMCompany(2) As String
        Dim vMFax(2) As String
        Dim vMCell(2) As String
        Dim vMEmail(2) As String
        Dim tname As String
        Dim SMem As String
        Dim SelMem As String
        Dim loopindex As Integer
        Try
            'Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            If chkdatevalidate = False Then Exit Function
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Function
            End If
            Call chkfilterfield()
            sqlstring = sqlstring & "ISNULL(CONTCELL,'') AS CONTCELL"
            'If ssgrid1.DataRowCnt > 0 Then
            SelMem = SelMem & "MCODE IN ("
            For loopindex = 1 To ssgrid1.DataRowCnt
                SMem = Nothing
                ssgrid1.GetText(1, loopindex, SMem)
                SelMem = SelMem & "'" & SMem & "',"
            Next
            SelMem = Mid(SelMem, 1, Len(SelMem) - 1)
            SelMem = SelMem & ") "

            If ssgrid1.DataRowCnt > 0 Then
                sqlstring = sqlStringFinal
            Else
                sqlstring = sqlStringFinal & addFltrStr
            End If


            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            ElseIf ssgrid1.DataRowCnt > 0 Then
                sqlstring = sqlstring & SelMem
            End If

            If rdb_all.Checked = False Then
                'sqlstring = sqlstring & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
            End If


            'End If
            'sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"

            'sqlstring = sqlstring & " order by prefixmcode,msorderno"
            sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno,mcode asc"
            'addlist = gconnection.GetValues(sqlstring)
            'dt = gconnection.GetValues(sqlstring)
            Dim Viewer As New ReportViwer
            Dim r As New Add_List
            Viewer.ssql = sqlstring
            Viewer.Report = r
            Viewer.TableName = "membermaster"
            Viewer.Show()
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Sub rdb_date_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If rdb_date.Checked = True Then
        '        Dtp_From.Visible = True
        '        Dtp_To.Visible = True
        '    Else
        '        Dtp_From.Visible = False
        '        Dtp_To.Visible = False
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try

            Dim _export As New EXPORT
            Dim cmdText As String
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select * from VW_MEMMASTER_CONT"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select * from VW_MEMMASTER_PA"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select * from VW_MEMMASTER_RA"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select * from VW_MEMMASTER_BA"
            End If
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o

            If (cmb_Filter_By.Text = "Member Category") Then
                cmdText = cmdText & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If

            cmdText = cmdText & " order by MCODE asc"

            If Trim(Cmb_add_filter.Text) = "Contact Address" Then

                _export.TABLENAME = "VW_MEMMASTER_CONT"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then

                _export.TABLENAME = "VW_MEMMASTER_PA"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then

                _export.TABLENAME = "VW_MEMMASTER_RA"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then

                _export.TABLENAME = "VW_MEMMASTER_BA"
            End If


            Call _export.export_excel(cmdText)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub printdata3()
        Try
            Dim cmdText As String
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select * from MM_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            End If
            txtCategory.Text = ""
            Dim o As Object
            Dim I As Integer
            Dim TYPE() As String
            Dim MEMBERTYPE As String
            If chk_Filter_Field.CheckedItems.Count > 0 Then
                For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    TYPE = Split(chk_Filter_Field.CheckedItems(I), ".")
                    MEMBERTYPE = MEMBERTYPE & "'" & TYPE(1) & "', "
                Next
                MEMBERTYPE = Mid(MEMBERTYPE, 1, Len(MEMBERTYPE) - 2)

                'Else
                '    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    chk_Filter_Field.Focus()
                '    Exit Sub
            End If
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            If (cmb_Filter_By.Text = "Member Category") Then
                'cmdText = cmdText & " where memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
                cmdText = cmdText & " where memberType in (" & MEMBERTYPE & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            cmdText = cmdText & "order by prefixmcode,msorderno asc"

            gconnection.getDataSet(cmdText, "MemMst")

            If gdataset.Tables("MemMst").Rows.Count <= 0 Then
                MessageBox.Show("Address Not Found Or Give Correct Input")

            Else
                Dim Viewer As New ReportViwer
                If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                    Dim r As New Cry_contactlist
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                    Dim r As New Cry_AddressList_PA
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                    Dim r As New Cry_contactlist
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    Viewer.TableName = "MM_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                    Dim r As New Cry_AddressList_BA
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function printdata1()
        Dim vMCode(2) As String
        Dim vMName(2) As String
        Dim vMAdd1(2) As String
        Dim vMAdd2(2) As String
        Dim vMAdd3(2) As String
        Dim sno As Integer
        Dim vMCity(2) As String
        Dim vMState(2) As String
        Dim vMTel(2) As String
        Dim vOption As Boolean
        Dim vMPinCode(2) As String
        Dim vsplit() As String
        Dim rcount As Integer
        Dim vAns As Double
        Dim str()() As String
        Dim i, j, lp, prn, lpNext1, lpNext2, pagesize As Integer
        Dim pageno As Long
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
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
        Dim vDoj(2) As String
        Dim vspouse(2) As String
        Dim vOrgName(2) As String
        Dim vDesignation(2) As String
        Dim vMCompany(2) As String
        Dim vMFax(2) As String
        Dim vMCell(2) As String
        Dim vMEmail(2) As String
        Dim tname As String
        Dim SMem As String
        Dim SelMem As String
        Dim loopindex As Integer
        Try
            Dim cmdText As String
            'Dim txtobj1 As TextObject
            'Dim txtobj2 As TextObject
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select * from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select * from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select * from MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select * from MEMBERMASTER"
            End If
            'txtCategory.Text = ""
            'Dim o As Object
            'For Each o In chk_Filter_Field.CheckedItems
            '    txtCategory.Text += "'" & o.ToString() & "',"
            'Next o
            txtCategory.Text = ""
            'txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            'Dim jj As Object
            'For Each jj In ChK_Memberstatus.CheckedItems

            '  txtStatus.Text += "'" & jj.ToString() & "',"
            ' Next jj

            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") "
            'cmdText = cmdText & " and CURENTSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"

            'If (cmb_Filter_By.Text = "Member Category") Then
            '    cmdText = cmdText & " where memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            'Else
            '    cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            'End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            'If (rdb_date.Checked = True) Then
            '    cmdText = cmdText & " and doj between Convert(datetime,'" & (Dtp_From.Text) & "',103) and Convert(datetime,'" & (Dtp_To.Text) & "',103)"
            'End If
            cmdText = cmdText & " order by mtorderno,prefixmcode,msorderno asc"
            'Call Checkdaterangevalidate(Dtp_From.Value, Dtp_To.Value)
            'If chkdatevalidate = False Then Exit Function
            'If chk_Filter_Field.CheckedItems.Count = 0 Then
            '    MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
            '    Exit Function
            'End If
            'Call chkfilterfield()

            'SelMem = SelMem & "MCODE IN ("
            'For loopindex = 1 To ssgrid1.DataRowCnt
            '    SMem = Nothing
            '    ssgrid1.GetText(1, loopindex, SMem)
            '    SelMem = SelMem & "'" & SMem & "',"
            'Next
            'SelMem = Mid(SelMem, 1, Len(SelMem) - 1)
            'SelMem = SelMem & ") "

            'If ssgrid1.DataRowCnt > 0 Then
            '    sqlstring = sqlStringFinal
            'Else
            '    sqlstring = sqlStringFinal & addFltrStr
            'End If

            'If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
            '    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            'ElseIf ssgrid1.DataRowCnt > 0 Then
            '    sqlstring = sqlstring & SelMem
            'End If
            'If rdb_all.Checked = False Then
            '    sqlstring = sqlstring & " AND DOJ Between '" & Format(Dtp_From.Value, "dd-MMM-yyyy") & "' AND '" & Format(Dtp_To.Value, "dd-MMM-yyyy") & "'"
            'End If

            ''sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            ''sqlstring = sqlstring & " ORDER BY MCODE"
            'sqlstring = sqlstring & " ORDER BY mtorderno,prefixmcode,msorderno,mcode asc"
            'addlist = gconnection.GetValues(sqlstring)
            Randomize()
            tname = "master1"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            pageno = 1
            'Filewrite.WriteLine("USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(87, "-"))
            'Filewrite.WriteLine(Chr(23) & "MEMBER CODE                       ADDRESS" & Chr(18))
            'Filewrite.WriteLine(StrDup(80, "-"))
            pagesize = pagesize + 4

            dt = gconnection.GetValues(cmdText)
            pagesize = 1
            Dim icount As Integer
            'MessageBox.Show(dt.Rows.Count)
            If dt.Rows.Count > 0 Then

                sno = 1
                For i = 0 To dt.Rows.Count - 1
                    prn = 1
                    For j = 0 To 2
                        If i < dt.Rows.Count Then
                            vMCode(j) = Mid(Trim(dt.Rows(i).Item("mcode") & ""), 1, 40)
                            vMName(j) = Mid(Trim(dt.Rows(i).Item("mname") & ""), 1, 40)
                            vMAdd1(j) = Mid(Trim(dt.Rows(i).Item("contadd1") & ""), 1, 40)
                            vMAdd2(j) = Mid(Trim(dt.Rows(i).Item("contadd2") & ""), 1, 40)
                            vMAdd3(j) = Mid(Trim(dt.Rows(i).Item("contadd3") & ""), 1, 40)
                            vMCity(j) = Mid(Trim(dt.Rows(i).Item("contcity")) & IIf(Trim(dt.Rows(i).Item("contcity")) = "", "", "-") & Trim(dt.Rows(i).Item("contpin")), 1, 40)
                            vMTel(j) = "Tel. " & Trim(dt.Rows(i).Item("contphone1"))
                            i = i + 1
                        End If
                        sno = sno + 1
                    Next
                    If pagesize > 56 Then
                        pagesize = 0
                        Filewrite.WriteLine(StrDup(87, "-"))
                        Filewrite.WriteLine("USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                        'Filewrite.WriteLine("")
                        'Filewrite.WriteLine("")
                        'Filewrite.WriteLine("")
                        'Filewrite.WriteLine("")
                        Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                        pageno = pageno + 1
                        Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO:" & Trim(CStr(pageno)))
                        Filewrite.WriteLine(StrDup(87, "-"))
                        pagesize = pagesize + 3
                    End If
                    Filewrite.WriteLine(Mid(vMCode(0), 1, 25) & Space(25 - Len(Mid(vMCode(0), 1, 25))) & Space(6) & Mid(vMCode(1), 1, 25) & Space(25 - Len(Mid(vMCode(1), 1, 25))) & Space(6) & Mid(vMCode(2), 1, 25) & Space(25 - Len(Mid(vMCode(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMName(0), 1, 25) & Space(25 - Len(Mid(vMName(0), 1, 25))) & Space(6) & Mid(vMName(1), 1, 25) & Space(25 - Len(Mid(vMName(1), 1, 25))) & Space(6) & Mid(vMName(2), 1, 25) & Space(25 - Len(Mid(vMName(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd1(0), 1, 25) & Space(25 - Len(Mid(vMAdd1(0), 1, 25))) & Space(6) & Mid(vMAdd1(1), 1, 25) & Space(25 - Len(Mid(vMAdd1(1), 1, 25))) & Space(6) & Mid(vMAdd1(2), 1, 25) & Space(25 - Len(Mid(vMAdd1(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd2(0), 1, 25) & Space(25 - Len(Mid(vMAdd2(0), 1, 25))) & Space(6) & Mid(vMAdd2(1), 1, 25) & Space(25 - Len(Mid(vMAdd2(1), 1, 25))) & Space(6) & Mid(vMAdd2(2), 1, 25) & Space(25 - Len(Mid(vMAdd2(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMAdd3(0), 1, 25) & Space(25 - Len(Mid(vMAdd3(0), 1, 25))) & Space(6) & Mid(vMAdd3(1), 1, 25) & Space(25 - Len(Mid(vMAdd3(1), 1, 25))) & Space(6) & Mid(vMAdd3(2), 1, 25) & Space(25 - Len(Mid(vMAdd3(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Mid(vMTel(0), 1, 25) & Space(25 - Len(Mid(vMTel(0), 1, 25))) & Space(6) & Mid(vMTel(1), 1, 25) & Space(25 - Len(Mid(vMTel(1), 1, 25))) & Space(6) & Mid(vMTel(2), 1, 25) & Space(25 - Len(Mid(vMTel(2), 1, 25))))
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1

                    'For j = prn To 4
                    '    Filewrite.WriteLine("")
                    'Next
                    For j = 0 To 2
                        vMCode(j) = ""
                        vMName(j) = ""
                        vMAdd1(j) = ""
                        vMAdd2(j) = ""
                        vMAdd3(j) = ""
                        vMCity(j) = ""
                        vMState(j) = ""
                        vMPinCode(j) = ""
                        vMTel(j) = ""
                    Next
                    If i > dt.Rows.Count Then
                        i = dt.Rows.Count
                    Else
                        i = i - 1
                    End If
                Next
            Else
                MsgBox("No Record to View", MsgBoxStyle.Information, MyCompanyName)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Public Sub print_strikers()
        Try
            Dim cmdText As String
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select * from MM_MEMBERMASTER"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select * from MM_VIEW_MEMBERMASTER"
            End If
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            If (cmb_Filter_By.Text = "Member Category") Then
                cmdText = cmdText & " where memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " where curentstatus in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            cmdText = cmdText & "order by prefixmcode,msorderno asc"

            gconnection.getDataSet(cmdText, "MemMst")

            If gdataset.Tables("MemMst").Rows.Count <= 0 Then
                MessageBox.Show("Address Not Found Or Give Correct Input")

            Else
                Dim Viewer As New ReportViwer
                If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                    Dim r As New Cry_contact_strikers
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                    Dim r As New Cry_AddressList_PA
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                    Dim r As New Cry_contactlist
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    Viewer.TableName = "MM_MEMBERMASTER"
                    Viewer.Show()
                ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                    Dim r As New Cry_AddressList_BA
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Rnd_address_strikers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_address_strikers.CheckedChanged

    End Sub

    Private Sub Rnd_address_strikers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rnd_address_strikers.Click
        rdb_all.Checked = False
    End Sub

    Private Sub rdb_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_all.CheckedChanged

    End Sub

    Private Sub rdb_all_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_all.Click
        Rnd_address_strikers.Checked = False
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub

    Private Sub Cmb_add_filter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedValueChanged

    End Sub

    Private Sub chk_Filter_Field_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chk_Filter_Field.ItemCheck
        Dim o As Object
        Dim I As Integer
        'For Each o In chk_Filter_Field.CheckedItems
        '    ListBox1.Items.Add(" & o.ToString() & ")
        'Next o
        Dim APPCODE() As String
        Dim item As String = chk_Filter_Field.SelectedItem

        If e.NewValue = CheckState.Checked Then
            'appcode = Split(chk_Filter_Field.CheckedItems(I), ".")
            'cmdText = cmdText & " '" & appcode(0) & "', "
            ListBox1.Items.Add(item)
        Else
            ListBox1.Items.Remove(item)
        End If

        'txtCategory.Text = chk_Filter_Field.SelectedItem



        'ListBox1.Items.Add(txtCategory.Text)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Validated
        'Cmb_add_filter.Focus()
    End Sub

    Private Sub chk_Filter_Field_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedValueChanged

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "" Then
                Call Button1_Click(sender, e)
            Else
                validate1()
                'txt_SubCategoryName.Focus()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            Call Button1_Click(sender, e)
        End If
    End Sub
    Public Sub validate1()
        Dim fill_chk_str As String
        Dim MEMBERTYPE As New DataTable
        fill_chk_str = "SELECT mcode,mname FROM membermaster where mcode='" & TextBox1.Text & "'AND CURENTSTATUS IN ('ACTIVE','LIVE')"
        MEMBERTYPE = gconnection.GetValues(fill_chk_str)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            ListBox1.Items.Add(MEMBERTYPE.Rows(Itration).Item("mcode") & "." & MEMBERTYPE.Rows(Itration).Item("mname"))
            'chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        TextBox1.Text = ""
        ' ListBox1.Items.Add(TextBox1.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " WHERE Curentstatus IN ('ACTIVE','LIVE')"
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            'ListBox1.Items.Add(Trim(vform.keyfield & "") & "." & Trim(vform.keyfield1))
            'MessageBox.Show()
            'tbx_filter_To.Text = Trim(vform.keyfield & "")
            'tbx_filter_To.Text = Trim(vform.keyfield1)
            'CmdView.Select()
            TextBox1.Text = Trim(vform.keyfield10)
            validate1()

        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmb_Filter_By_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.ContextMenuChanged

    End Sub

    Private Sub cmb_Filter_By_DockChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.DockChanged

    End Sub
End Class