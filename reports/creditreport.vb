Imports System.Data.SqlClient
Imports System.IO
Public Class creditreport
    Inherits System.Windows.Forms.Form
    Dim FltrStr, status, TempString(2), DispString, addFltrStr, ssql As String
    Dim sqlStringFinal, sqlstring As String
    Dim addlist As DataTable
    Dim SNO As Integer = 1
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents withdeposit As System.Windows.Forms.RadioButton
    Friend WithEvents withoutdeposit As System.Windows.Forms.RadioButton
    Friend WithEvents ChK_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(creditreport))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChK_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chk_STATUS = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.withoutdeposit = New System.Windows.Forms.RadioButton
        Me.withdeposit = New System.Windows.Forms.RadioButton
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 26)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "CREDIT  NUMBER LIST "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(208, 560)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 56)
        Me.GroupBox2.TabIndex = 411
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(264, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(392, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 8
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(144, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(24, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View[F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChK_Memberstatus)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chk_STATUS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.withoutdeposit)
        Me.GroupBox1.Controls.Add(Me.withdeposit)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Lst_status1)
        Me.GroupBox1.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox1.Controls.Add(Me.Lst_status)
        Me.GroupBox1.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox1.Controls.Add(Me.cmb_Filter_By)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(168, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 421)
        Me.GroupBox1.TabIndex = 409
        Me.GroupBox1.TabStop = False
        '
        'ChK_Memberstatus
        '
        Me.ChK_Memberstatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.ChK_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.ChK_Memberstatus.Location = New System.Drawing.Point(338, 128)
        Me.ChK_Memberstatus.Name = "ChK_Memberstatus"
        Me.ChK_Memberstatus.Size = New System.Drawing.Size(248, 213)
        Me.ChK_Memberstatus.Sorted = True
        Me.ChK_Memberstatus.TabIndex = 421
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(86, 99)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(164, 23)
        Me.chk_PrintAll.TabIndex = 419
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(62, 128)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(252, 213)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 416
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 417
        Me.Label2.Text = "MEMBER CATEGORY "
        '
        'chk_STATUS
        '
        Me.chk_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.chk_STATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_STATUS.Location = New System.Drawing.Point(389, 99)
        Me.chk_STATUS.Name = "chk_STATUS"
        Me.chk_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.chk_STATUS.TabIndex = 420
        Me.chk_STATUS.Text = "Print All Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 418
        Me.Label3.Text = "MEMBER STATUS"
        '
        'withoutdeposit
        '
        Me.withoutdeposit.Checked = True
        Me.withoutdeposit.Location = New System.Drawing.Point(344, 344)
        Me.withoutdeposit.Name = "withoutdeposit"
        Me.withoutdeposit.Size = New System.Drawing.Size(160, 24)
        Me.withoutdeposit.TabIndex = 411
        Me.withoutdeposit.TabStop = True
        Me.withoutdeposit.Text = "With Out  Deposit"
        '
        'withdeposit
        '
        Me.withdeposit.Location = New System.Drawing.Point(176, 344)
        Me.withdeposit.Name = "withdeposit"
        Me.withdeposit.Size = New System.Drawing.Size(112, 24)
        Me.withdeposit.TabIndex = 410
        Me.withdeposit.Text = "With Deposit"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(400, 376)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 409
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(270, 376)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 408
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(158, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 406
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 405
        Me.Label8.Text = "To"
        '
        'Lst_status1
        '
        Me.Lst_status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status1.ItemHeight = 18
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.LIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(606, 244)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status1.TabIndex = 397
        Me.Lst_status1.Visible = False
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(336, 376)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 24)
        Me.tbx_filter_To.TabIndex = 4
        Me.tbx_filter_To.Text = ""
        '
        'Lst_status
        '
        Me.Lst_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_status.ItemHeight = 18
        Me.Lst_status.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.Lst_status.Location = New System.Drawing.Point(590, 348)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status.TabIndex = 396
        Me.Lst_status.Visible = False
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(206, 376)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 24)
        Me.tbx_Filter_From.TabIndex = 3
        Me.tbx_Filter_From.Text = ""
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmb_Filter_By.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Filter_By.ItemHeight = 18
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(264, 24)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 26)
        Me.cmb_Filter_By.TabIndex = 0
        Me.cmb_Filter_By.Text = "[select your filter]"
        Me.cmb_Filter_By.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(104, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 19)
        Me.Label9.TabIndex = 402
        Me.Label9.Text = "CATEGORY  FILITER"
        Me.Label9.Visible = False
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Cmb_add_filter.ItemHeight = 18
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(776, 224)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(168, 26)
        Me.Cmb_add_filter.TabIndex = 407
        Me.Cmb_add_filter.Text = "[select your filter]"
        Me.Cmb_add_filter.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(792, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 408
        Me.Label10.Text = "ADDRESS  FILTER"
        Me.Label10.Visible = False
        '
        'creditreport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(944, 678)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cmb_add_filter)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "creditreport"
        Me.Text = "creditreport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub creditreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Filter_By.Focus()
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cmb_Filter_By.SelectedIndex = 1
        Cmb_add_filter.SelectedIndex = 1
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
    Private Sub creditreport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call cmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
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
        '            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        '        Next
        '    ElseIf cmb_Filter_By.Text = "Member Status" Then
        '        selectNo = 1
        '        FltrStr = "CurentStatus in('"
        '        chk_Filter_Field.Items.Clear()
        '        chk_Filter_Field.Items.AddRange(Lst_status.Items())
        '    End If
        'Catch ex As Exception
        '    MsgBox("An invalided input�Please close the report filter and reopen it.")
        '    Exit Sub
        'End Try
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Filter_By.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        cmb_Filter_By.Focus()
        'chk_Filter_Field.Items.Clear()
        cmb_Filter_By.SelectedIndex = 1
        tbx_Filter_From.Text = ""
        tbx_filter_To.Text = ""
        chk_PrintAll.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
        chk_STATUS.Checked = False
        Call chk_STATUS_CheckedChanged(sender, e)
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            tbx_Filter_From.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                Call cmd_MCodefromHelp_Click(sender, e)
                tbx_filter_To.Focus()
            End If
        End If
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        status = ""
        DispString = ""
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(TempString(1))
                    addFltrStr = FltrStr & Trim(TempString(selectNo))
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(DispString) & "," & Trim(TempString(1))
                    addFltrStr = addFltrStr & "','" & Trim(TempString(selectNo))
                End If
            Next i
            For i = 0 To ChK_Memberstatus.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = TempString(1)
                Else
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = status & "','" & TempString(1)

                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(contpin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
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
        PRINTREP = False
        If withdeposit.Checked = True Then
            Call lockerlist()
        Else
            Call lockerlist1()
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        If withdeposit.Checked = True Then
            Call lockerlist()
        Else
            Call lockerlist1()
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
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    Private Sub lockerlist()
        Dim str()() As String
        Dim i, j, row, pagesize, pageno As Integer
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
        Try
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Sub
            End If
            Call chkfilterfield()
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "%' AND '" & tbx_filter_To.Text & "%'"
            Else
                sqlstring = ""
            End If
            FinalString = "select MCODE,MNAME,CurentStatus,criditNumber,SecurityDeposit from membermaster where (criditnumber <> '' )  and membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "')"
            FinalString = FinalString & sqlstring & " ORDER BY MCODE"
            addlist = gconnection.GetValues(FinalString)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            pagesize = 5
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            If Len(DispString) <= 80 Then
                Filewrite.WriteLine(Chr(27) + "E" & "CREDIT NUMBER LIST:" & Trim(DispString) & Chr(27) + "F")
                pagesize = pagesize + 1
            Else
                Filewrite.Write(Chr(27) + "E" & "CREDIT NUMBER LIST:")
                j = 0
                For i = 1 To Len(Trim(DispString))
                    If j = 0 Then
                        Filewrite.WriteLine(Mid(Trim(DispString), 1, 60))
                        pagesize = pagesize + 1
                        i = i + 59
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
            Filewrite.WriteLine("|SNO |CODE    |NAME                         |STATUS   |CREDIT NO     |  DEPOSIT|")
            Filewrite.WriteLine(StrDup(80, "-"))
            SNO = 1
            For row = 0 To addlist.Rows.Count - 1
                If pagesize > 60 Then
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(80, "-"))
                    Filewrite.WriteLine("User Name: " & gUsername & Space(30) & "Date :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 80 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "CREDIT NUMBER LIST:" & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "CREDIT NUMBER LIST:")
                        j = 0
                        For i = 1 To Len(Trim(DispString))
                            If j = 0 Then
                                Filewrite.WriteLine(Mid(Trim(DispString), 1, 60))
                                pagesize = pagesize + 1
                                i = i + 59
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
                    Filewrite.WriteLine("|SNO |CODE    |NAME                         |STATUS   |CREDIT NO     |  DEPOSIT|")
                    Filewrite.WriteLine(StrDup(80, "-"))
                    pagesize = 5
                End If
                STR1 = (addlist.Rows(row).Item("mcode"))
                STR2 = Mid((addlist.Rows(row).Item("mname")), 1, 27)
                STR3 = Mid((addlist.Rows(row).Item("curentstatus")), 1, 9)
                STR4 = (addlist.Rows(row).Item("CRIDITNUMBER"))
                ssql = Space(9 - Len(Mid(Format(addlist.Rows(row).Item("SECURITYDEPOSIT"), "0.00"), 1, 9))) & Mid(Format((addlist.Rows(row).Item("SECURITYDEPOSIT")), "0.00"), 1, 9)
                STR5 = ssql
                Filewrite.Write("{0,-5}{1,-9}{2,-30}{3,-10}{4,-15}{5,1}", "|" & SNO, "|" & STR1, "|" & STR2, "|" & STR3, "|" & STR4, "|")
                Filewrite.WriteLine(ssql & "|")
                SNO = SNO + 1
                pagesize = pagesize + 1
            Next row
            SNO = SNO - 1
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.WriteLine("NO. OF CREDIT MEMBER LIST =" & Trim(CStr(SNO)) & Space(5) & "USER NAME:" & gUsername & Space(15) & "DATE:" & Format(Date.Now, "dd/MM/yyyy"))
            Filewrite.WriteLine(StrDup(82, "-") & Chr(12))
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, gCompanyname)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmb_add_filter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_add_filter.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Filter_From.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_filter_To.Focus()
        End If
    End Sub
    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Filter_By.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_add_filter.Focus()
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_add_filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub lockerlist1()
        Dim str()() As String
        Dim i, j, row, pagesize, pageno As Integer
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
        Try
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, gCompanyAddress(0))
                Exit Sub
            End If
            Call chkfilterfield()
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                sqlstring = " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "%' AND '" & tbx_filter_To.Text & "%'"
            Else
                sqlstring = ""
            End If
            FinalString = "select MCODE,MNAME,CurentStatus,criditNumber,SecurityDeposit from membermaster where (criditnumber <> '' ) and membertypecode in ('" & addFltrStr & "')" & " and curentstatus in('" & status & "')"
            FinalString = FinalString & sqlstring & " ORDER BY MCODE"
            addlist = gconnection.GetValues(FinalString)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            pagesize = 5
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            If Len(DispString) <= 80 Then
                Filewrite.WriteLine(Chr(27) + "E" & "CREDIT NUMBER LIST:" & Trim(DispString) & Chr(27) + "F")
                pagesize = pagesize + 1
            Else
                Filewrite.Write(Chr(27) + "E" & "CREDIT NUMBER LIST:")
                j = 0
                For i = 1 To Len(Trim(DispString))
                    If j = 0 Then
                        Filewrite.WriteLine(Mid(Trim(DispString), 1, 60))
                        pagesize = pagesize + 1
                        i = i + 59
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
            Filewrite.WriteLine("|SNO   |CODE    |NAME                         |  STATUS  |CREDIT NO    |")
            Filewrite.WriteLine(StrDup(80, "-"))
            SNO = 1
            For row = 0 To addlist.Rows.Count - 1
                If pagesize > 60 Then
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(80, "-"))
                    Filewrite.WriteLine("User Name: " & gUsername & Space(30) & "Date :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    If Len(DispString) <= 80 Then
                        Filewrite.WriteLine(Chr(27) + "E" & "CREDIT NUMBER LIST:" & Trim(DispString) & Chr(27) + "F")
                        pagesize = pagesize + 1
                    Else
                        Filewrite.Write(Chr(27) + "E" & "CREDIT NUMBER LIST:")
                        j = 0
                        For i = 1 To Len(Trim(DispString))
                            If j = 0 Then
                                Filewrite.WriteLine(Mid(Trim(DispString), 1, 60))
                                pagesize = pagesize + 1
                                i = i + 59
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
                    Filewrite.WriteLine("|SNO   |CODE    |NAME                         |  STATUS  |CREDIT NO    |")
                    Filewrite.WriteLine(StrDup(80, "-"))
                    pagesize = 5
                End If
                STR1 = (addlist.Rows(row).Item("mcode"))
                STR2 = Mid((addlist.Rows(row).Item("mname")), 1, 29)
                STR3 = Mid((addlist.Rows(row).Item("curentstatus")), 1, 11)
                STR4 = (addlist.Rows(row).Item("CRIDITNUMBER"))
                STR5 = ssql
                Filewrite.WriteLine("{0,-7}{1,-9}{2,-30}{3,-11}{4,-15}{5,1}", "|" & SNO, "|" & STR1, "|" & STR2, "|" & STR3, "|" & STR4, "|")
                SNO = SNO + 1
                pagesize = pagesize + 1
            Next row
            SNO = SNO - 1
            Filewrite.WriteLine(StrDup(80, "-"))
            Filewrite.WriteLine("NO. OF CREDIT MEMBER LIST =" & Trim(CStr(SNO)) & Space(5) & "USER NAME:" & gUsername & Space(15) & "DATE:" & Format(Date.Now, "dd/MM/yyyy"))
            Filewrite.WriteLine(StrDup(82, "-") & Chr(12))
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, gCompanyname)
            Exit Sub
        End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
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
    Private Sub chk_STATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_STATUS.CheckedChanged
        Dim Iteration As Integer
        If chk_STATUS.Checked = True Then
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetSelected(Iteration, True)
                    ChK_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
