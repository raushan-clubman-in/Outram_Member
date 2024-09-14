Imports CrystalDecisions.CrystalReports.Engine
Public Class ArmServicesList
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
    Friend WithEvents Txt_address_Filter As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_allrank As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Chk_ranklist As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtrankWise As System.Windows.Forms.TextBox
    Friend WithEvents chk_Alladdress As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_address As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_phone As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_email As System.Windows.Forms.CheckBox
    Friend WithEvents ChK_None As System.Windows.Forms.CheckBox
    Friend WithEvents Rd_Win As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Dos As System.Windows.Forms.RadioButton
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ArmServicesList))
        Me.Txt_address_Filter = New System.Windows.Forms.TextBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chk_Alladdress = New System.Windows.Forms.CheckBox
        Me.Chk_allrank = New System.Windows.Forms.CheckBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Chk_ranklist = New System.Windows.Forms.CheckedListBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.txtCategory = New System.Windows.Forms.TextBox
        Me.txtrankWise = New System.Windows.Forms.TextBox
        Me.Chk_address = New System.Windows.Forms.CheckBox
        Me.Chk_phone = New System.Windows.Forms.CheckBox
        Me.Chk_email = New System.Windows.Forms.CheckBox
        Me.ChK_None = New System.Windows.Forms.CheckBox
        Me.Rd_Win = New System.Windows.Forms.RadioButton
        Me.Rd_Dos = New System.Windows.Forms.RadioButton
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_address_Filter
        '
        Me.Txt_address_Filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_address_Filter.Location = New System.Drawing.Point(632, 360)
        Me.Txt_address_Filter.Name = "Txt_address_Filter"
        Me.Txt_address_Filter.Size = New System.Drawing.Size(120, 21)
        Me.Txt_address_Filter.TabIndex = 650
        Me.Txt_address_Filter.Text = ""
        Me.Txt_address_Filter.Visible = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(468, 427)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 649
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(228, 427)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 648
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 17)
        Me.Label7.TabIndex = 647
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(340, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 17)
        Me.Label8.TabIndex = 646
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(388, 427)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 21)
        Me.tbx_filter_To.TabIndex = 645
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(148, 427)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 21)
        Me.tbx_Filter_From.TabIndex = 644
        Me.tbx_Filter_From.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(636, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 643
        Me.Label4.Text = "ADDRESS TYPE"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 642
        Me.Label3.Text = "ARM SERVICES"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 641
        Me.Label1.Text = "CATEGORY LIST"
        '
        'chk_Alladdress
        '
        Me.chk_Alladdress.BackColor = System.Drawing.Color.Transparent
        Me.chk_Alladdress.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Alladdress.Location = New System.Drawing.Point(640, 144)
        Me.chk_Alladdress.Name = "chk_Alladdress"
        Me.chk_Alladdress.Size = New System.Drawing.Size(168, 16)
        Me.chk_Alladdress.TabIndex = 640
        Me.chk_Alladdress.Text = "Print All Address"
        Me.chk_Alladdress.Visible = False
        '
        'Chk_allrank
        '
        Me.Chk_allrank.BackColor = System.Drawing.Color.Transparent
        Me.Chk_allrank.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_allrank.Location = New System.Drawing.Point(424, 131)
        Me.Chk_allrank.Name = "Chk_allrank"
        Me.Chk_allrank.Size = New System.Drawing.Size(168, 16)
        Me.Chk_allrank.TabIndex = 638
        Me.Chk_allrank.Text = "Print All Rank"
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(56, 131)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(168, 16)
        Me.chk_PrintAll.TabIndex = 637
        Me.chk_PrintAll.Text = "Print All Categorys"
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
        Me.GroupBox2.Location = New System.Drawing.Point(56, 491)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox2.TabIndex = 633
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
        Me.btnExport.Location = New System.Drawing.Point(336, 16)
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
        Me.CmdClear.Location = New System.Drawing.Point(232, 16)
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
        Me.cmdexit.Location = New System.Drawing.Point(448, 16)
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
        Me.cmdPrint.Location = New System.Drawing.Point(120, 16)
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
        Me.CmdView.Location = New System.Drawing.Point(16, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(91, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(56, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 72)
        Me.Panel1.TabIndex = 632
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(56, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 72)
        Me.Panel2.TabIndex = 608
        '
        'Chk_ranklist
        '
        Me.Chk_ranklist.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Chk_ranklist.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ranklist.Location = New System.Drawing.Point(424, 147)
        Me.Chk_ranklist.Name = "Chk_ranklist"
        Me.Chk_ranklist.Size = New System.Drawing.Size(184, 228)
        Me.Chk_ranklist.Sorted = True
        Me.Chk_ranklist.TabIndex = 631
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(56, 147)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(360, 228)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 630
        '
        'txtCategory
        '
        Me.txtCategory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(56, 379)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(312, 21)
        Me.txtCategory.TabIndex = 635
        Me.txtCategory.Text = ""
        Me.txtCategory.Visible = False
        '
        'txtrankWise
        '
        Me.txtrankWise.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrankWise.Location = New System.Drawing.Point(424, 379)
        Me.txtrankWise.Name = "txtrankWise"
        Me.txtrankWise.Size = New System.Drawing.Size(216, 21)
        Me.txtrankWise.TabIndex = 636
        Me.txtrankWise.Text = ""
        Me.txtrankWise.Visible = False
        '
        'Chk_address
        '
        Me.Chk_address.BackColor = System.Drawing.Color.Transparent
        Me.Chk_address.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_address.Location = New System.Drawing.Point(640, 176)
        Me.Chk_address.Name = "Chk_address"
        Me.Chk_address.Size = New System.Drawing.Size(168, 16)
        Me.Chk_address.TabIndex = 651
        Me.Chk_address.Text = "Address"
        Me.Chk_address.Visible = False
        '
        'Chk_phone
        '
        Me.Chk_phone.BackColor = System.Drawing.Color.Transparent
        Me.Chk_phone.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_phone.Location = New System.Drawing.Point(640, 208)
        Me.Chk_phone.Name = "Chk_phone"
        Me.Chk_phone.Size = New System.Drawing.Size(168, 16)
        Me.Chk_phone.TabIndex = 652
        Me.Chk_phone.Text = "Phone"
        Me.Chk_phone.Visible = False
        '
        'Chk_email
        '
        Me.Chk_email.BackColor = System.Drawing.Color.Transparent
        Me.Chk_email.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_email.Location = New System.Drawing.Point(640, 240)
        Me.Chk_email.Name = "Chk_email"
        Me.Chk_email.Size = New System.Drawing.Size(168, 16)
        Me.Chk_email.TabIndex = 653
        Me.Chk_email.Text = "Email"
        Me.Chk_email.Visible = False
        '
        'ChK_None
        '
        Me.ChK_None.BackColor = System.Drawing.Color.Transparent
        Me.ChK_None.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK_None.Location = New System.Drawing.Point(640, 272)
        Me.ChK_None.Name = "ChK_None"
        Me.ChK_None.Size = New System.Drawing.Size(168, 16)
        Me.ChK_None.TabIndex = 654
        Me.ChK_None.Text = "None"
        Me.ChK_None.Visible = False
        '
        'Rd_Win
        '
        Me.Rd_Win.Checked = True
        Me.Rd_Win.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_Win.Location = New System.Drawing.Point(688, 0)
        Me.Rd_Win.Name = "Rd_Win"
        Me.Rd_Win.Size = New System.Drawing.Size(88, 24)
        Me.Rd_Win.TabIndex = 658
        Me.Rd_Win.TabStop = True
        Me.Rd_Win.Text = "Windows"
        Me.Rd_Win.Visible = False
        '
        'Rd_Dos
        '
        Me.Rd_Dos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rd_Dos.Location = New System.Drawing.Point(672, 0)
        Me.Rd_Dos.Name = "Rd_Dos"
        Me.Rd_Dos.Size = New System.Drawing.Size(64, 24)
        Me.Rd_Dos.TabIndex = 657
        Me.Rd_Dos.Text = "Dos"
        Me.Rd_Dos.Visible = False
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Cmb_add_filter.ItemHeight = 16
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(672, 0)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(48, 24)
        Me.Cmb_add_filter.TabIndex = 656
        Me.Cmb_add_filter.Text = "[select your filter]"
        Me.Cmb_add_filter.Visible = False
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(688, 0)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(48, 24)
        Me.cmb_Filter_By.TabIndex = 655
        Me.cmb_Filter_By.Text = "[select your filter]"
        Me.cmb_Filter_By.Visible = False
        '
        'ArmServicesList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(672, 582)
        Me.Controls.Add(Me.Rd_Win)
        Me.Controls.Add(Me.Rd_Dos)
        Me.Controls.Add(Me.Cmb_add_filter)
        Me.Controls.Add(Me.cmb_Filter_By)
        Me.Controls.Add(Me.ChK_None)
        Me.Controls.Add(Me.Chk_email)
        Me.Controls.Add(Me.Chk_phone)
        Me.Controls.Add(Me.Chk_address)
        Me.Controls.Add(Me.Txt_address_Filter)
        Me.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Controls.Add(Me.cmd_MCodefromHelp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbx_filter_To)
        Me.Controls.Add(Me.tbx_Filter_From)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_Alladdress)
        Me.Controls.Add(Me.Chk_allrank)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chk_ranklist)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtrankWise)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ArmServicesList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArmServicesList"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    Private Sub Chk_allrank_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_allrank.CheckedChanged
        Dim Iteration As Integer
        'Call chk_loadarmservices()
        If Chk_allrank.Checked = True Then
            Try
                For Iteration = 0 To (Chk_ranklist.Items.Count - 1)
                    Chk_ranklist.SetSelected(Iteration, True)
                    Chk_ranklist.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_ranklist.Items.Count - 1)
                    Chk_ranklist.SetSelected(Iteration, False)
                    Chk_ranklist.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub chk_address_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Alladdress.CheckedChanged
        'Dim Iteration As Integer
        'If Chk_address.Checked = True Then
        '    Try
        '        For Iteration = 0 To (chk_contact.Items.Count - 1)
        '            chk_contact.SetSelected(Iteration, True)
        '            chk_contact.SetItemChecked(Iteration, True)
        '        Next
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Else
        '    Try
        '        For Iteration = 0 To (chk_contact.Items.Count - 1)
        '            chk_contact.SetSelected(Iteration, False)
        '            chk_contact.SetItemChecked(Iteration, False)
        '        Next
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items!")
            Exit Sub
        End If
        PRINTREP = False
        Call printdata()
    End Sub
    Private Sub printdata()
        Try

            Dim cmdText As String
            cmdText = "Select * From MM_MEMBERMASTER"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            txtrankWise.Text = ""
            Dim j As Object
            For Each j In Chk_ranklist.CheckedItems
                txtrankWise.Text += "'" & j.ToString() & "',"
            Next j
            'Dim k As Object
            'For Each k In chk_Alladdress .CheckedItems
            '    Txt_address_Filter.Text += "'" & k.ToString() & "',"
            'Next k
            'If (txtCategory.Text <> "") Then
            cmdText = cmdText & " where membertypecode in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            'End If
            'cmdText = cmdText & " where membertypecode in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txtrankWise.Text <> "") Then
                cmdText = cmdText & " and Armservice in (" & txtrankWise.Text.Substring(0, txtrankWise.Text.Length - 1) & ")"
            End If
            'If (Txt_address_Filter.Text <> "") Then
            '    cmdText = cmdText & " and PADD1 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    cmdText = cmdText & " and PPHONE1 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    cmdText = cmdText & " and PEMAIL in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    cmdText = cmdText & " and PCELL in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            'End If
            'If (chk_Alladdress.Checked = True) Then
            '    cmdText = cmdText & " and PADD1 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    'cmdText = cmdText & " and PADD2 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    'cmdText = cmdText & " and PADD3 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    'cmdText = cmdText & " and PCITY in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            'ElseIf (Chk_phone.Checked = True) Then
            '    cmdText = cmdText & " and PPHONE1 in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            '    cmdText = cmdText & " and PCELL in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            'ElseIf (Chk_email.Checked = True) Then
            '    cmdText = cmdText & " and PEMAIL in (" & Txt_address_Filter.Text.Substring(0, Txt_address_Filter.Text.Length - 1) & ")"
            'End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            cmdText = cmdText & " order by mcode asc"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_ArmServicesList
            Dim txtobj1 As TextObject
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(3))

            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "MM_MEMBERMASTER"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items!")
            Exit Sub
        End If
        PRINTREP = False
        Call printdata()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub ArmServicesList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call chk_loadcategory()
        'Call chk_addressload()
        Show()
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
    Private Sub chk_loadcategory()
        Try
            Dim i As Integer
            gconnection.getDataSet("SELECT distinct(MemberTypeCode) FROM MEMBERMASTER Where Freeze='N'", "MEMBERMASTER")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
                    Me.chk_Filter_Field.Items.Add(Trim(gdataset.Tables("MEMBERMASTER").Rows(i).Item(0)))
                Next i
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
        Call chk_loadarmservices()
    End Sub

    Private Sub chk_loadarmservices()
        ''Try
        ''    Dim i As Integer
        ''    gconnection.getDataSet("SELECT distinct(ArmService) FROM MEMBERMASTER Where Freeze='N'", "MEMBERMASTER")
        ''    If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
        ''        For i = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
        ''            Me.Chk_ranklist.Items.Add(Trim(gdataset.Tables("MEMBERMASTER").Rows(i).Item(0)))
        ''        Next i
        ''    End If
        ''Catch ex As Exception
        ''    MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        ''End Try
        Dim i As Integer
        sqlstring = "select distinct(ArmService) from MEMBERMASTER where freeze='N'"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Chk_ranklist.Items.Add(dt.Rows(Itration).Item("ArmService"))
        Next
    End Sub
    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Dim i As Integer
            'cmb_Filter_By.Focus()
            'cmb_Filter_By.SelectedIndex = 1
            tbx_Filter_From.Text = ""
            tbx_filter_To.Text = ""
            'Rd_Win.Checked = True
            'ssgrid1.ClearRange(1, 1, -1, -1, True)
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
            For i = 0 To (chk_Filter_Field.Items.Count - 1)
                Chk_ranklist.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim _export As New EXPORT
            Dim cmdText As String
            cmdText = "Select * From MM_MEMBERMASTER"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems

                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            txtrankWise.Text = ""
            Dim j As Object
            For Each j In Chk_ranklist.CheckedItems
                txtrankWise.Text += "'" & j.ToString() & "',"
            Next j
            cmdText = cmdText & " where membertypecode in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If (txtrankWise.Text <> "") Then
                cmdText = cmdText & " and Armservice in (" & txtrankWise.Text.Substring(0, txtrankWise.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If

            cmdText = cmdText & " order by mcode asc"

            'If Trim(Cmb_add_filter.Text) = "Contact Address" Then
            '    _export.TABLENAME = "VW_MEMMASTER_CONT"
            'ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then

            '    _export.TABLENAME = "VW_MEMMASTER_PA"
            'ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then

            '    _export.TABLENAME = "VW_MEMMASTER_RA"
            'ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then

            '    _export.TABLENAME = "VW_MEMMASTER_BA"
            'End If

            _export.TABLENAME = "MM_MEMBERMASTER"
            Call _export.export_excel(cmdText)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_filter_To.TextChanged

    End Sub

    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub
End Class
