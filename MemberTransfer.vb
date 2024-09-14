Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Public Class MemberTransfer
    Inherits System.Windows.Forms.Form
    Dim ssql, ssql1, oldtype, newtype As String
    Dim stype, stype3, stype1(2) As String
    Dim validity As Boolean
    Dim datalist, datalist1 As DataTable
    Dim I As Long
    Dim boolchk As Boolean
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
    Friend WithEvents mname As System.Windows.Forms.Label
    Friend WithEvents oldmembertype As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdmemberhelp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmembercode As System.Windows.Forms.TextBox
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents commembertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdview As System.Windows.Forms.Button
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents lbl_PresentStatus As System.Windows.Forms.Label
    Friend WithEvents txt_PresentStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Txt_Newmember As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NewStatus As System.Windows.Forms.Label
    Friend WithEvents cbo_NewStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMD_TRANSFER As System.Windows.Forms.Button
    Friend WithEvents btn_Entancefee As System.Windows.Forms.Button
    Friend WithEvents btn_AccountsDetails As System.Windows.Forms.Button
    Friend WithEvents Cmd_MemAddress As System.Windows.Forms.Button
    Friend WithEvents Cmd_MemDep As System.Windows.Forms.Button
    Friend WithEvents Cmd_Education As System.Windows.Forms.Button
    Friend WithEvents cmd_RSIDetails As System.Windows.Forms.Button
    Friend WithEvents txtreason As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberTransfer))
        Me.mname = New System.Windows.Forms.Label
        Me.oldmembertype = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdmemberhelp = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmembercode = New System.Windows.Forms.TextBox
        Me.dtpdate = New System.Windows.Forms.DateTimePicker
        Me.commembertype = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdview = New System.Windows.Forms.Button
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cmdadd = New System.Windows.Forms.Button
        Me.lbl_PresentStatus = New System.Windows.Forms.Label
        Me.txt_PresentStatus = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.Txt_Newmember = New System.Windows.Forms.TextBox
        Me.lbl_NewStatus = New System.Windows.Forms.Label
        Me.cbo_NewStatus = New System.Windows.Forms.ComboBox
        Me.CMD_TRANSFER = New System.Windows.Forms.Button
        Me.btn_Entancefee = New System.Windows.Forms.Button
        Me.btn_AccountsDetails = New System.Windows.Forms.Button
        Me.Cmd_MemAddress = New System.Windows.Forms.Button
        Me.Cmd_MemDep = New System.Windows.Forms.Button
        Me.Cmd_Education = New System.Windows.Forms.Button
        Me.cmd_RSIDetails = New System.Windows.Forms.Button
        Me.txtreason = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mname
        '
        Me.mname.BackColor = System.Drawing.Color.Transparent
        Me.mname.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.ForeColor = System.Drawing.Color.Blue
        Me.mname.Location = New System.Drawing.Point(232, 176)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(360, 20)
        Me.mname.TabIndex = 25
        '
        'oldmembertype
        '
        Me.oldmembertype.BackColor = System.Drawing.Color.Transparent
        Me.oldmembertype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldmembertype.ForeColor = System.Drawing.Color.Blue
        Me.oldmembertype.Location = New System.Drawing.Point(232, 216)
        Me.oldmembertype.Name = "oldmembertype"
        Me.oldmembertype.Size = New System.Drawing.Size(200, 24)
        Me.oldmembertype.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Member Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Member Type"
        '
        'cmdmemberhelp
        '
        Me.cmdmemberhelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmemberhelp.Image = CType(resources.GetObject("cmdmemberhelp.Image"), System.Drawing.Image)
        Me.cmdmemberhelp.Location = New System.Drawing.Point(328, 96)
        Me.cmdmemberhelp.Name = "cmdmemberhelp"
        Me.cmdmemberhelp.Size = New System.Drawing.Size(23, 24)
        Me.cmdmemberhelp.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Member Name"
        '
        'txtmembercode
        '
        Me.txtmembercode.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txtmembercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmembercode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmembercode.Location = New System.Drawing.Point(232, 96)
        Me.txtmembercode.Name = "txtmembercode"
        Me.txtmembercode.Size = New System.Drawing.Size(96, 21)
        Me.txtmembercode.TabIndex = 19
        Me.txtmembercode.Text = ""
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(232, 376)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(104, 21)
        Me.dtpdate.TabIndex = 17
        '
        'commembertype
        '
        Me.commembertype.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.commembertype.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commembertype.Location = New System.Drawing.Point(232, 256)
        Me.commembertype.Name = "commembertype"
        Me.commembertype.Size = New System.Drawing.Size(288, 21)
        Me.commembertype.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "New Member Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Effective From"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Reason"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.cmdview)
        Me.GroupBox2.Controls.Add(Me.cmdprint)
        Me.GroupBox2.Controls.Add(Me.cmdadd)
        Me.GroupBox2.Location = New System.Drawing.Point(48, 464)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 56)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(400, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 15
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdclear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.White
        Me.cmdclear.Image = CType(resources.GetObject("cmdclear.Image"), System.Drawing.Image)
        Me.cmdclear.Location = New System.Drawing.Point(288, 16)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(104, 32)
        Me.cmdclear.TabIndex = 14
        Me.cmdclear.Text = "Clear[F6]"
        '
        'cmdview
        '
        Me.cmdview.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdview.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdview.ForeColor = System.Drawing.Color.White
        Me.cmdview.Image = CType(resources.GetObject("cmdview.Image"), System.Drawing.Image)
        Me.cmdview.Location = New System.Drawing.Point(176, 16)
        Me.cmdview.Name = "cmdview"
        Me.cmdview.Size = New System.Drawing.Size(104, 32)
        Me.cmdview.TabIndex = 12
        Me.cmdview.Text = "List View [F9]"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Image = CType(resources.GetObject("cmdprint.Image"), System.Drawing.Image)
        Me.cmdprint.Location = New System.Drawing.Point(288, 16)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(104, 32)
        Me.cmdprint.TabIndex = 13
        Me.cmdprint.Text = "Print[F12]"
        Me.cmdprint.Visible = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdadd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.Color.White
        Me.cmdadd.Image = CType(resources.GetObject("cmdadd.Image"), System.Drawing.Image)
        Me.cmdadd.Location = New System.Drawing.Point(64, 16)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(104, 32)
        Me.cmdadd.TabIndex = 11
        Me.cmdadd.Text = "Add New[F5]"
        '
        'lbl_PresentStatus
        '
        Me.lbl_PresentStatus.AutoSize = True
        Me.lbl_PresentStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PresentStatus.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PresentStatus.Location = New System.Drawing.Point(40, 296)
        Me.lbl_PresentStatus.Name = "lbl_PresentStatus"
        Me.lbl_PresentStatus.Size = New System.Drawing.Size(154, 22)
        Me.lbl_PresentStatus.TabIndex = 34
        Me.lbl_PresentStatus.Text = "Present Status "
        '
        'txt_PresentStatus
        '
        Me.txt_PresentStatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txt_PresentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_PresentStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PresentStatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PresentStatus.Location = New System.Drawing.Point(232, 296)
        Me.txt_PresentStatus.Name = "txt_PresentStatus"
        Me.txt_PresentStatus.Size = New System.Drawing.Size(288, 22)
        Me.txt_PresentStatus.TabIndex = 33
        Me.txt_PresentStatus.Text = ""
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(40, 136)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(192, 24)
        Me.Label53.TabIndex = 714
        Me.Label53.Text = "New Membership No"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Newmember
        '
        Me.Txt_Newmember.BackColor = System.Drawing.Color.White
        Me.Txt_Newmember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Newmember.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Newmember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Newmember.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Newmember.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Txt_Newmember.Location = New System.Drawing.Point(232, 136)
        Me.Txt_Newmember.MaxLength = 10
        Me.Txt_Newmember.Name = "Txt_Newmember"
        Me.Txt_Newmember.Size = New System.Drawing.Size(104, 22)
        Me.Txt_Newmember.TabIndex = 713
        Me.Txt_Newmember.Text = ""
        '
        'lbl_NewStatus
        '
        Me.lbl_NewStatus.AutoSize = True
        Me.lbl_NewStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NewStatus.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewStatus.Location = New System.Drawing.Point(40, 336)
        Me.lbl_NewStatus.Name = "lbl_NewStatus"
        Me.lbl_NewStatus.Size = New System.Drawing.Size(115, 22)
        Me.lbl_NewStatus.TabIndex = 716
        Me.lbl_NewStatus.Text = "New Status "
        '
        'cbo_NewStatus
        '
        Me.cbo_NewStatus.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cbo_NewStatus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_NewStatus.Location = New System.Drawing.Point(232, 336)
        Me.cbo_NewStatus.Name = "cbo_NewStatus"
        Me.cbo_NewStatus.Size = New System.Drawing.Size(288, 23)
        Me.cbo_NewStatus.TabIndex = 715
        '
        'CMD_TRANSFER
        '
        Me.CMD_TRANSFER.BackColor = System.Drawing.Color.Black
        Me.CMD_TRANSFER.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_TRANSFER.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_TRANSFER.ForeColor = System.Drawing.Color.White
        Me.CMD_TRANSFER.Image = CType(resources.GetObject("CMD_TRANSFER.Image"), System.Drawing.Image)
        Me.CMD_TRANSFER.Location = New System.Drawing.Point(592, 840)
        Me.CMD_TRANSFER.Name = "CMD_TRANSFER"
        Me.CMD_TRANSFER.Size = New System.Drawing.Size(128, 32)
        Me.CMD_TRANSFER.TabIndex = 747
        Me.CMD_TRANSFER.Text = "Update Membercode"
        '
        'btn_Entancefee
        '
        Me.btn_Entancefee.BackColor = System.Drawing.Color.White
        Me.btn_Entancefee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Entancefee.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Entancefee.ForeColor = System.Drawing.Color.White
        Me.btn_Entancefee.Image = CType(resources.GetObject("btn_Entancefee.Image"), System.Drawing.Image)
        Me.btn_Entancefee.Location = New System.Drawing.Point(456, 840)
        Me.btn_Entancefee.Name = "btn_Entancefee"
        Me.btn_Entancefee.Size = New System.Drawing.Size(120, 32)
        Me.btn_Entancefee.TabIndex = 746
        Me.btn_Entancefee.Text = "Application Details"
        '
        'btn_AccountsDetails
        '
        Me.btn_AccountsDetails.BackColor = System.Drawing.Color.White
        Me.btn_AccountsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AccountsDetails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AccountsDetails.ForeColor = System.Drawing.Color.White
        Me.btn_AccountsDetails.Image = CType(resources.GetObject("btn_AccountsDetails.Image"), System.Drawing.Image)
        Me.btn_AccountsDetails.Location = New System.Drawing.Point(464, 840)
        Me.btn_AccountsDetails.Name = "btn_AccountsDetails"
        Me.btn_AccountsDetails.Size = New System.Drawing.Size(112, 32)
        Me.btn_AccountsDetails.TabIndex = 745
        Me.btn_AccountsDetails.Text = "Accounts Details"
        Me.btn_AccountsDetails.Visible = False
        '
        'Cmd_MemAddress
        '
        Me.Cmd_MemAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_MemAddress.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemAddress.ForeColor = System.Drawing.Color.White
        Me.Cmd_MemAddress.Image = CType(resources.GetObject("Cmd_MemAddress.Image"), System.Drawing.Image)
        Me.Cmd_MemAddress.Location = New System.Drawing.Point(48, 840)
        Me.Cmd_MemAddress.Name = "Cmd_MemAddress"
        Me.Cmd_MemAddress.Size = New System.Drawing.Size(120, 32)
        Me.Cmd_MemAddress.TabIndex = 741
        Me.Cmd_MemAddress.Text = "Member Address"
        '
        'Cmd_MemDep
        '
        Me.Cmd_MemDep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_MemDep.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_MemDep.ForeColor = System.Drawing.Color.White
        Me.Cmd_MemDep.Image = CType(resources.GetObject("Cmd_MemDep.Image"), System.Drawing.Image)
        Me.Cmd_MemDep.Location = New System.Drawing.Point(176, 840)
        Me.Cmd_MemDep.Name = "Cmd_MemDep"
        Me.Cmd_MemDep.Size = New System.Drawing.Size(120, 32)
        Me.Cmd_MemDep.TabIndex = 742
        Me.Cmd_MemDep.Text = "Dependent Details"
        '
        'Cmd_Education
        '
        Me.Cmd_Education.BackColor = System.Drawing.Color.White
        Me.Cmd_Education.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Education.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Education.ForeColor = System.Drawing.Color.White
        Me.Cmd_Education.Image = CType(resources.GetObject("Cmd_Education.Image"), System.Drawing.Image)
        Me.Cmd_Education.Location = New System.Drawing.Point(320, 840)
        Me.Cmd_Education.Name = "Cmd_Education"
        Me.Cmd_Education.Size = New System.Drawing.Size(120, 32)
        Me.Cmd_Education.TabIndex = 743
        Me.Cmd_Education.Text = "Member Education"
        '
        'cmd_RSIDetails
        '
        Me.cmd_RSIDetails.BackColor = System.Drawing.Color.Black
        Me.cmd_RSIDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_RSIDetails.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_RSIDetails.ForeColor = System.Drawing.Color.White
        Me.cmd_RSIDetails.Image = CType(resources.GetObject("cmd_RSIDetails.Image"), System.Drawing.Image)
        Me.cmd_RSIDetails.Location = New System.Drawing.Point(736, 840)
        Me.cmd_RSIDetails.Name = "cmd_RSIDetails"
        Me.cmd_RSIDetails.Size = New System.Drawing.Size(120, 32)
        Me.cmd_RSIDetails.TabIndex = 744
        Me.cmd_RSIDetails.Text = "Proposer/Seconder"
        '
        'txtreason
        '
        Me.txtreason.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txtreason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreason.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreason.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreason.Location = New System.Drawing.Point(232, 408)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(288, 22)
        Me.txtreason.TabIndex = 748
        Me.txtreason.Text = ""
        '
        'MemberTransfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(672, 574)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.CMD_TRANSFER)
        Me.Controls.Add(Me.btn_Entancefee)
        Me.Controls.Add(Me.btn_AccountsDetails)
        Me.Controls.Add(Me.Cmd_MemAddress)
        Me.Controls.Add(Me.Cmd_MemDep)
        Me.Controls.Add(Me.Cmd_Education)
        Me.Controls.Add(Me.cmd_RSIDetails)
        Me.Controls.Add(Me.lbl_NewStatus)
        Me.Controls.Add(Me.Txt_Newmember)
        Me.Controls.Add(Me.lbl_PresentStatus)
        Me.Controls.Add(Me.txt_PresentStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmembercode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbo_NewStatus)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.oldmembertype)
        Me.Controls.Add(Me.cmdmemberhelp)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.commembertype)
        Me.Name = "MemberTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberTransfer"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dt As DataTable
    'Dim gconnection As New GlobalClass


    Private Sub MemberTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        membertype()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Show()
        txtmembercode.Focus()
    End Sub
    Private Sub membertype()
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        Try
            commembertype.Items.Clear()
            ssql = "SELECT Membertype,TypeDesc FROM MEMBERTYPE WHERE MEMBERTYPE<>'" & oldtype & "' AND ISNULL(FREEZE,'') <> 'Y' "
            MEMBERTYPE = gconnection.GetValues(ssql)

            For I = 0 To (MEMBERTYPE.Rows.Count - 1)
                commembertype.Items.Add(MEMBERTYPE.Rows(I).Item("Membertype") & "." & MEMBERTYPE.Rows(I).Item("TypeDesc"))
            Next

            commembertype.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
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
        Me.cmdadd.Enabled = False
        Me.cmdprint.Enabled = False
        Me.cmdview.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmdadd.Enabled = True
                    Me.cmdprint.Enabled = True
                    Me.cmdview.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmdadd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmdadd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmdadd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmdview.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdprint.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub txtmembercode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmembercode.TextChanged

    End Sub

    Private Sub txtmembercode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmembercode.Validated
        Dim sqlstring, sqlstring1, sqlstring2 As String
        Try
            If Trim(txtmembercode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME,Curentstatus FROM MEMBERMASTER WHERE MCODE='" & Trim(txtmembercode.Text) & "'"
                gconnection.getDataSet(sqlstring, "MEMBER")
                sqlstring1 = "Select Reason From membertypeconversion"
                gconnection.getDataSet(sqlstring1, "conversion")
                If gdataset.Tables("conversion").Rows.Count > 0 Then
                    'txtreason.Text = Trim(gdataset.Tables("conversion").Rows(0).Item("Reason"))
                Else
                    txtmembercode.Text = ""
                    mname.Text = ""
                    txt_PresentStatus.Text = ""
                    'txtmembercode.Focus()
                    Txt_Newmember.Focus()


                End If

                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txtmembercode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    txt_PresentStatus.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("Curentstatus"))
                    Call status()

                Else
                    txtmembercode.Text = ""
                    mname.Text = ""
                    txt_PresentStatus.Text = ""
                    txtmembercode.Focus()

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Status()
        Dim sqlstring As String
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM MemberStatusMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_NewStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
        'cbo_CurrentStatus.Items.Add("UnConfirmed")
    End Sub

    Private Sub cmdmemberhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmemberhelp.Click
        Dim vform As New ListOperation
        Try
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            listop = ""
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtmembercode.Text = Trim(vform.keyfield & "")
                mname.Text = Trim(vform.keyfield1 & "")
                Call txtmembercode_LostFocus1(sender, e)
                commembertype.Focus()
            End If
            vform.Close()
            vform = Nothing
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmdadd.Text = "Update[F5]"
    End Sub
    Private Sub txtmembercode_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmembercode.LostFocus
        If txtmembercode.Text <> "" Then
            If txtmembercode.Text <> "" Then
                'ssql = "select a.typedesc,a.membertype from membertype a,membermaster b where a.membertype=b.membertypecode and b.mcode='" & txtmembercode.Text & "' AND ISNULL(A.FREEZE,'') <> 'Y'"
                ssql = "select membertype from membermaster  where mcode='" & txtmembercode.Text & "' AND ISNULL(FREEZE,'') <> 'Y'"
                datalist = gconnection.GetValues(ssql)
                If datalist.Rows.Count > 0 Then
                    oldmembertype.Text = datalist.Rows(0).Item("membertype")
                    oldtype = datalist.Rows(0).Item("membertype")
                Else
                    oldmembertype.Text = ""
                    oldtype = ""
                End If
            End If
            ' Call membertype()
            commembertype.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtmembercode.Text = ""
        mname.Text = ""
        Txt_Newmember.Text = ""
        txt_PresentStatus.Text = ""
        cbo_NewStatus.Text = ""
        oldmembertype.Text = ""
        txtreason.Text = ""
        commembertype.Text = ""
        txtmembercode.Focus()
        cmdadd.Text = "Add New[F5]"
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub

    Private Sub MemberTransfer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmdadd_Click(sender, e)
        ElseIf e.KeyCode = Keys.F6 Then
            If cmdclear.Enabled = True Then
                Call cmdclear_Click(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If cmdview.Enabled = True Then
                Call cmdview_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            If cmdprint.Enabled = True Then
                Call cmdprint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            If cmdexit.Enabled = True Then
                Call cmdexit_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        If cmdadd.Text = "Update[F5]" Then
            Dim membername, status, sqlString As String
            Call validate1()
            membername = mname.Text
            'Vcatefile = Mid("membertempdet" & CStr(Int(Rnd() * 75000)), 1, 8)
            status = txt_PresentStatus.Text
            If validity = False Then Exit Sub
            stype1 = Split(commembertype.Text, ".")
            stype = stype1(0)
            stype3 = stype1(1)
            sqlString = "select * From sysobjects where type='U'and name='membertempdet'"
            gconnection.getDataSet(sqlString, "Temp")
            If gdataset.Tables("Temp").Rows.Count > 0 Then
                sqlString = "Drop table membertempdet "
                gconnection.dataOperation(6, sqlString, "Temp")

                sqlString = " select * into membertempdet from membermaster where mcode='" & txtmembercode.Text & "'"
                gconnection.dataOperation(6, sqlString, "Temp")

                ssql = "update membertempdet set mcode ='" & Txt_Newmember.Text & "',membertypecode='" & stype & "',membertype='" & stype3 & "' where mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)


                ssql = "INSERT into membermaster (TAG,MEMBERTYPECODE,COMPANY,SUBCD,MCODE,MNAME,MID,DOB,DOJ,SEX,MARITALSTATUS,SPOUSE,BG,OCCUPATION,BANKER,BANKACNO,HOBBIES,OTHERINFO,RESIDENT,EQUALIFICATION,PQUALIFICATION,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,PAcopyst,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,RAcopyst,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTCOUNTRY,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,EMPTYPE,BUSINESSNAME,BAcopyst,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,DOEPROFESSION,BUSINESSNATURE,POSITIONHELD,SERVICENAME,SERVICEYEAR,PANO,BBANKER,CCNO,ANNUALINCOME,UPDUSERID,UPDDATETIME,TERMINATION,TRN_CON_DATE,CON_MCODE,PFAX,CFAX,CONTFAX,REASON,PHOTO,CREDITLIMIT,LIMITAMOUNT,WEBSITE,Imagefile,sizefield,Vdate,Vyear,Validdate,TempTermination,TempTermDate,TempTermReason,Memberid,EndingDate,TotalYears,CardNo,CardExpDate,Validity,Period,Creditcardno,CreditExpDt,Type,STATUSDATEFROM,STATUSDATETO,CurentStatus,FirstName,MiddleName,Surname,Alias,Prefix,BillType,Nationality,NationalityAtbirth,Billbasis,BillHead,GDRLocker,LDRLocker,HPLocker,MembershipTo,salut,EntranceFee,DevelopmentFee,CriditNumber,SecurityDeposit,PlaceOfBirth,CountryOfBirth,LastArrivalInCal,PeriodOfStay_year,PeriodOfStay_Month,PreviouslyProposed,NoOfTimesProposed,DateOfProposal,NoOfTimesSeconded,DateOfSeconded,ResultOfProposal,Elected,FatherName,DOBfather,WifeDOB,MaidenNameWife,NationalityWife,WifesFatherName,WifeFatherDOB,ApplNo,ApplDate,Corporatest,CorporateCode,CompName,Designation,ProfessionInfo,BuisnessInfo,Products,AgentsDealers,ESTDdate,NoOfEmp,Turnover,Client,AppliedBut,PositionInChamber,Qulificationstatus,Qualification1,Details1,YearOfPassing1,Institute1,Division1,Qualification2,Details2,YearOfPassing2,Institute2,Division2,Qualification3,Details3,YearOfPassing3,Institute3,Division3,sportstatus,GameType1,NameOfGame1,Description1,GameType2,NameofGame2,Description2,GameType3,NameOfGame3,Description3,Childstatus,ChildName1,ChildDob1,ChildSex1,ChildExpairy1,ChildName2,ChildDob2,ChildSex2,ChildExpairy2,ChildName3,ChildDob3,ChildSex3,childExpairy3,Clubstatus,OtherClubName1,OCAddress1,OCStatus1,OtherClubName2,OCAddress2,OCStatus2,OtherClubname3,OCAddress3,OCStataus,adduser,adddate,freeze,Relativestatus,RelativeName1,Relation1,dateofbirth1,Relativeage1,RelativeSex1,Relativeaddress1,RelativeName2,Relation2,dateofbirth2,Relativeage2,RelativeSex2,Relativeaddress2,RelativeName3,Relation3,dateofbirth3,Relativeage3,RelativeSex3,Relativeaddress3,referentialst,mem_code1,mem_name1,refmem_date1,deleted1,mem_code2,mem_name2,refmem_date2,deleted2,mem_code3,mem_name3,refmem_date3,deleted3,entrancefeest,receiptno1,startdate1,amount1,receiptno2,startdate2,amount2,receiptno3,startdate3,amount3,OLD,CardAmt,MINIMUMUSAGE,CREDITNO,SPOUSEMOBILE,PADD4,CADD4,plotno,societyno,creditstopflag,creditstopdate,MSORDERNO,PrefixMcode,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,BTGroup,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,AnniversaryDate,RByMemberNo,RByMemberNo2,RByName,RByMemberName2,ArmyNo,RankName,BarcodeNo,DependentID,MemberType,MemImage,MemImageSign,SpouseImage,ChildFDob1,Email_Flag,EBill,Wedding_Date,TaxFlag,MLedgerName,F_Mcode,NOMINEE,SDOB,ENC_SMARTCARDNO,MTORDERNO,RAcopyst1,PAcopyst1,BAcopyst1) select TAG,MEMBERTYPECODE,COMPANY,SUBCD,MCODE,MNAME,MID,DOB,DOJ,SEX,MARITALSTATUS,SPOUSE,BG,OCCUPATION,BANKER,BANKACNO,HOBBIES,OTHERINFO,RESIDENT,EQUALIFICATION,PQUALIFICATION,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,PAcopyst,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,RAcopyst,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTCOUNTRY,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,EMPTYPE,BUSINESSNAME,BAcopyst,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,DOEPROFESSION,BUSINESSNATURE,POSITIONHELD,SERVICENAME,SERVICEYEAR,PANO,BBANKER,CCNO,ANNUALINCOME,UPDUSERID,UPDDATETIME,TERMINATION,TRN_CON_DATE,CON_MCODE,PFAX,CFAX,CONTFAX,REASON,PHOTO,CREDITLIMIT,LIMITAMOUNT,WEBSITE,Imagefile,sizefield,Vdate,Vyear,Validdate,TempTermination,TempTermDate,TempTermReason,Memberid,EndingDate,TotalYears,CardNo,CardExpDate,Validity,Period,Creditcardno,CreditExpDt,Type,STATUSDATEFROM,STATUSDATETO,CurentStatus,FirstName,MiddleName,Surname,Alias,Prefix,BillType,Nationality,NationalityAtbirth,Billbasis,BillHead,GDRLocker,LDRLocker,HPLocker,MembershipTo,salut,EntranceFee,DevelopmentFee,CriditNumber,SecurityDeposit,PlaceOfBirth,CountryOfBirth,LastArrivalInCal,PeriodOfStay_year,PeriodOfStay_Month,PreviouslyProposed,NoOfTimesProposed,DateOfProposal,NoOfTimesSeconded,DateOfSeconded,ResultOfProposal,Elected,FatherName,DOBfather,WifeDOB,MaidenNameWife,NationalityWife,WifesFatherName,WifeFatherDOB,ApplNo,ApplDate,Corporatest,CorporateCode,CompName,Designation,ProfessionInfo,BuisnessInfo,Products,AgentsDealers,ESTDdate,NoOfEmp,Turnover,Client,AppliedBut,PositionInChamber,Qulificationstatus,Qualification1,Details1,YearOfPassing1,Institute1,Division1,Qualification2,Details2,YearOfPassing2,Institute2,Division2,Qualification3,Details3,YearOfPassing3,Institute3,Division3,sportstatus,GameType1,NameOfGame1,Description1,GameType2,NameofGame2,Description2,GameType3,NameOfGame3,Description3,Childstatus,ChildName1,ChildDob1,ChildSex1,ChildExpairy1,ChildName2,ChildDob2,ChildSex2,ChildExpairy2,ChildName3,ChildDob3,ChildSex3,childExpairy3,Clubstatus,OtherClubName1,OCAddress1,OCStatus1,OtherClubName2,OCAddress2,OCStatus2,OtherClubname3,OCAddress3,OCStataus,adduser,adddate,freeze,Relativestatus,RelativeName1,Relation1,dateofbirth1,Relativeage1,RelativeSex1,Relativeaddress1,RelativeName2,Relation2,dateofbirth2,Relativeage2,RelativeSex2,Relativeaddress2,RelativeName3,Relation3,dateofbirth3,Relativeage3,RelativeSex3,Relativeaddress3,referentialst,mem_code1,mem_name1,refmem_date1,deleted1,mem_code2,mem_name2,refmem_date2,deleted2,mem_code3,mem_name3,refmem_date3,deleted3,entrancefeest,receiptno1,startdate1,amount1,receiptno2,startdate2,amount2,receiptno3,startdate3,amount3,OLD,CardAmt,MINIMUMUSAGE,CREDITNO,SPOUSEMOBILE,PADD4,CADD4,plotno,societyno,creditstopflag,creditstopdate,MSORDERNO,PrefixMcode,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,BTGroup,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,AnniversaryDate,RByMemberNo,RByMemberNo2,RByName,RByMemberName2,ArmyNo,RankName,BarcodeNo,DependentID,MemberType,MemImage,MemImageSign,SpouseImage,ChildFDob1,Email_Flag,EBill,Wedding_Date,TaxFlag,MLedgerName,F_Mcode,NOMINEE,SDOB,ENC_SMARTCARDNO,MTORDERNO,RAcopyst1,PAcopyst1,BAcopyst1 FROM membertempdet where mcode='" & Txt_Newmember.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "update membermaster set CurentStatus='" & cbo_NewStatus.Text & "' where mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "update accountssubledgermaster set slcode='" & Txt_Newmember.Text & "' where slcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "update MEMAPPLNO set Mcode='" & Txt_Newmember.Text & "' where Mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "update APPLMEMBERMASTER set Mcode='" & Txt_Newmember.Text & "' where Mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql1 = "insert into membertypeconversion(Mcode,OMembertype,CMembertype,Effectfrom,Reason) values('" & txtmembercode.Text & "','" & oldmembertype.Text & "','" & commembertype.Text & "','" & Format(CDate(dtpdate.Text), "yyyy/MM/dd") & "', '" & txtreason.Text & "')"
                datalist1 = gconnection.GetValues(ssql1)
            Else
                sqlString = " select * into membertempdet from membermaster where mcode='" & txtmembercode.Text & "'"
                gconnection.dataOperation(6, sqlString, "Temp")

                ssql = "update membertempdet set mcode ='" & Txt_Newmember.Text & "',membertypecode='" & stype & "',membertype='" & stype3 & "' where mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)


                ssql = "INSERT into membermaster(SEQUENCENO,TAG,MEMBERTYPECODE,COMPANY,SUBCD,MCODE,MNAME,MID,DOB,DOJ,SEX,MARITALSTATUS,SPOUSE,BG,OCCUPATION,BANKER,BANKACNO,HOBBIES,OTHERINFO,RESIDENT,EQUALIFICATION,PQUALIFICATION,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,PAcopyst,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,RAcopyst,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTCOUNTRY,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,EMPTYPE,BUSINESSNAME,BAcopyst,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,DOEPROFESSION,BUSINESSNATURE,POSITIONHELD,SERVICENAME,SERVICEYEAR,PANO,BBANKER,CCNO,ANNUALINCOME,UPDUSERID,UPDDATETIME,TERMINATION,TRN_CON_DATE,CON_MCODE,PFAX,CFAX,CONTFAX,REASON,PHOTO,CREDITLIMIT,LIMITAMOUNT,WEBSITE,Imagefile,sizefield,Vdate,Vyear,Validdate,TempTermination,TempTermDate,TempTermReason,Memberid,EndingDate,TotalYears,CardNo,CardExpDate,Validity,Period,Creditcardno,CreditExpDt,Type,STATUSDATEFROM,STATUSDATETO,CurentStatus,FirstName,MiddleName,Surname,Alias,Prefix,BillType,Nationality,NationalityAtbirth,Billbasis,BillHead,GDRLocker,LDRLocker,HPLocker,MembershipTo,salut,EntranceFee,DevelopmentFee,CriditNumber,SecurityDeposit,PlaceOfBirth,CountryOfBirth,LastArrivalInCal,PeriodOfStay_year,PeriodOfStay_Month,PreviouslyProposed,NoOfTimesProposed,DateOfProposal,NoOfTimesSeconded,DateOfSeconded,ResultOfProposal,Elected,FatherName,DOBfather,WifeDOB,MaidenNameWife,NationalityWife,WifesFatherName,WifeFatherDOB,ApplNo,ApplDate,Corporatest,CorporateCode,CompName,Designation,ProfessionInfo,BuisnessInfo,Products,AgentsDealers,ESTDdate,NoOfEmp,Turnover,Client,AppliedBut,PositionInChamber,Qulificationstatus,Qualification1,Details1,YearOfPassing1,Institute1,Division1,Qualification2,Details2,YearOfPassing2,Institute2,Division2,Qualification3,Details3,YearOfPassing3,Institute3,Division3,sportstatus,GameType1,NameOfGame1,Description1,GameType2,NameofGame2,Description2,GameType3,NameOfGame3,Description3,Childstatus,ChildName1,ChildDob1,ChildSex1,ChildExpairy1,ChildName2,ChildDob2,ChildSex2,ChildExpairy2,ChildName3,ChildDob3,ChildSex3,childExpairy3,Clubstatus,OtherClubName1,OCAddress1,OCStatus1,OtherClubName2,OCAddress2,OCStatus2,OtherClubname3,OCAddress3,OCStataus,adduser,adddate,freeze,Relativestatus,RelativeName1,Relation1,dateofbirth1,Relativeage1,RelativeSex1,Relativeaddress1,RelativeName2,Relation2,dateofbirth2,Relativeage2,RelativeSex2,Relativeaddress2,RelativeName3,Relation3,dateofbirth3,Relativeage3,RelativeSex3,Relativeaddress3,referentialst,mem_code1,mem_name1,refmem_date1,deleted1,mem_code2,mem_name2,refmem_date2,deleted2,mem_code3,mem_name3,refmem_date3,deleted3,entrancefeest,receiptno1,startdate1,amount1,receiptno2,startdate2,amount2,receiptno3,startdate3,amount3,OLD,CardAmt,MINIMUMUSAGE,CREDITNO,SPOUSEMOBILE,PADD4,CADD4,plotno,societyno,creditstopflag,creditstopdate,MSORDERNO,PrefixMcode,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,BTGroup,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,AnniversaryDate,RByMemberNo,RByMemberNo2,RByName,RByMemberName2,ArmyNo,RankName,BarcodeNo,DependentID,MemberType,MemImage,MemImageSign,SpouseImage,ChildFDob1,Email_Flag,EBill,Wedding_Date,TaxFlag,MLedgerName,F_Mcode,NOMINEE,SDOB,ENC_SMARTCARDNO,MTORDERNO,RAcopyst1,PAcopyst1,BAcopyst1) SELECT SequenceNo,TAG,MEMBERTYPECODE,COMPANY,SUBCD,MCODE,MNAME,MID,DOB,DOJ,SEX,MARITALSTATUS,SPOUSE,BG,OCCUPATION,BANKER,BANKACNO,HOBBIES,OTHERINFO,RESIDENT,EQUALIFICATION,PQUALIFICATION,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,PAcopyst,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,RAcopyst,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTCOUNTRY,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,EMPTYPE,BUSINESSNAME,BAcopyst,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,DOEPROFESSION,BUSINESSNATURE,POSITIONHELD,SERVICENAME,SERVICEYEAR,PANO,BBANKER,CCNO,ANNUALINCOME,UPDUSERID,UPDDATETIME,TERMINATION,TRN_CON_DATE,CON_MCODE,PFAX,CFAX,CONTFAX,REASON,PHOTO,CREDITLIMIT,LIMITAMOUNT,WEBSITE,Imagefile,sizefield,Vdate,Vyear,Validdate,TempTermination,TempTermDate,TempTermReason,Memberid,EndingDate,TotalYears,CardNo,CardExpDate,Validity,Period,Creditcardno,CreditExpDt,Type,STATUSDATEFROM,STATUSDATETO,CurentStatus,FirstName,MiddleName,Surname,Alias,Prefix,BillType,Nationality,NationalityAtbirth,Billbasis,BillHead,GDRLocker,LDRLocker,HPLocker,MembershipTo,salut,EntranceFee,DevelopmentFee,CriditNumber,SecurityDeposit,PlaceOfBirth,CountryOfBirth,LastArrivalInCal,PeriodOfStay_year,PeriodOfStay_Month,PreviouslyProposed,NoOfTimesProposed,DateOfProposal,NoOfTimesSeconded,DateOfSeconded,ResultOfProposal,Elected,FatherName,DOBfather,WifeDOB,MaidenNameWife,NationalityWife,WifesFatherName,WifeFatherDOB,ApplNo,ApplDate,Corporatest,CorporateCode,CompName,Designation,ProfessionInfo,BuisnessInfo,Products,AgentsDealers,ESTDdate,NoOfEmp,Turnover,Client,AppliedBut,PositionInChamber,Qulificationstatus,Qualification1,Details1,YearOfPassing1,Institute1,Division1,Qualification2,Details2,YearOfPassing2,Institute2,Division2,Qualification3,Details3,YearOfPassing3,Institute3,Division3,sportstatus,GameType1,NameOfGame1,Description1,GameType2,NameofGame2,Description2,GameType3,NameOfGame3,Description3,Childstatus,ChildName1,ChildDob1,ChildSex1,ChildExpairy1,ChildName2,ChildDob2,ChildSex2,ChildExpairy2,ChildName3,ChildDob3,ChildSex3,childExpairy3,Clubstatus,OtherClubName1,OCAddress1,OCStatus1,OtherClubName2,OCAddress2,OCStatus2,OtherClubname3,OCAddress3,OCStataus,adduser,adddate,freeze,Relativestatus,RelativeName1,Relation1,dateofbirth1,Relativeage1,RelativeSex1,Relativeaddress1,RelativeName2,Relation2,dateofbirth2,Relativeage2,RelativeSex2,Relativeaddress2,RelativeName3,Relation3,dateofbirth3,Relativeage3,RelativeSex3,Relativeaddress3,referentialst,mem_code1,mem_name1,refmem_date1,deleted1,mem_code2,mem_name2,refmem_date2,deleted2,mem_code3,mem_name3,refmem_date3,deleted3,entrancefeest,receiptno1,startdate1,amount1,receiptno2,startdate2,amount2,receiptno3,startdate3,amount3,OLD,CardAmt,MINIMUMUSAGE,CREDITNO,SPOUSEMOBILE,PADD4,CADD4,plotno,societyno,creditstopflag,creditstopdate,MSORDERNO,PrefixMcode,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,BTGroup,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,AnniversaryDate,RByMemberNo,RByMemberNo2,RByName,RByMemberName2,ArmyNo,RankName,BarcodeNo,DependentID,MemberType,MemImage,MemImageSign,SpouseImage,ChildFDob1,Email_Flag,EBill,Wedding_Date,TaxFlag,MLedgerName,F_Mcode,NOMINEE,SDOB,ENC_SMARTCARDNO,MTORDERNO,RAcopyst1,PAcopyst1,BAcopyst1 FROM membertempdet where mcode='" & Txt_Newmember.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "update membermaster set CurentStatus='" & cbo_NewStatus.Text & "' where mcode='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql1 = "insert into membertypeconversion(Mcode,OMembertype,CMembertype,Effectfrom,Reason) values('" & txtmembercode.Text & "','" & oldmembertype.Text & "','" & commembertype.Text & "','" & Format(CDate(dtpdate.Text), "yyyy/MM/dd") & "', '" & txtreason.Text & "')"
                datalist1 = gconnection.GetValues(ssql1)


            End If
            sqlString = "select * From sysobjects where type='U'and name='temp_memdet'"
            gconnection.getDataSet(sqlString, "Temp")

            If gdataset.Tables("Temp").Rows.Count > 0 Then
                sqlString = "Drop table temp_memdet "
                gconnection.dataOperation(6, sqlString, "Temp")

                sqlString = " select * into temp_memdet from memdet where MEM_code='" & txtmembercode.Text & "'"
                gconnection.dataOperation(6, sqlString, "Temp")

                ssql = "update temp_memdet set mEm_code ='" & Txt_Newmember.Text & "' where mEm_code='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "INSERT into memdet (mEm_code,type0,type1,start_dt,end_dt,amount,rct_no,remarks,swim_other,name,status,refmem_no,refmem_dt,address,relation,child_nm,sex,child_dob,aqua_game,memb_wife,freeze,adduserid,adddatetime,updateuserid,updatedatetime,edu_prof,qual_det,institute,year_PASS,division,deleted,pcode,pname,cardIssued,MEMIMAGE) select mEm_code,type0,type1,start_dt,end_dt,amount,rct_no,remarks,swim_other,name,status,refmem_no,refmem_dt,address,relation,child_nm,sex,child_dob,aqua_game,memb_wife,freeze,adduserid,adddatetime,updateuserid,updatedatetime,edu_prof,qual_det,institute,year_PASS,division,deleted,pcode,pname,cardIssued,MEMIMAGE from temp_memdet where MEM_code='" & Txt_Newmember.Text & "'"
                datalist = gconnection.GetValues(ssql)

            Else
                sqlString = " select * into temp_memdet from memdet where MEM_code='" & txtmembercode.Text & "'"
                gconnection.dataOperation(6, sqlString, "Temp")

                ssql = "update temp_memdet set mEm_code ='" & Txt_Newmember.Text & "' where mEm_code='" & txtmembercode.Text & "'"
                datalist = gconnection.GetValues(ssql)

                ssql = "INSERT into memdet (mEm_code,type0,type1,start_dt,end_dt,amount,rct_no,remarks,swim_other,name,status,refmem_no,refmem_dt,address,relation,child_nm,sex,child_dob,aqua_game,memb_wife,freeze,adduserid,adddatetime,updateuserid,updatedatetime,edu_prof,qual_det,institute,year_PASS,division,deleted,pcode,pname,cardIssued,MEMIMAGE) select mEm_code,type0,type1,start_dt,end_dt,amount,rct_no,remarks,swim_other,name,status,refmem_no,refmem_dt,address,relation,child_nm,sex,child_dob,aqua_game,memb_wife,freeze,adduserid,adddatetime,updateuserid,updatedatetime,edu_prof,qual_det,institute,year_PASS,division,deleted,pcode,pname,cardIssued,MEMIMAGE from temp_memdet where MEM_code='" & Txt_Newmember.Text & "'"
                datalist = gconnection.GetValues(ssql)

            End If



            MessageBox.Show("Member Category Changed Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmdclear_Click(sender, e)
        End If
    End Sub
    Function validate1()
        boolchk = False
        Dim ssql, type0(0), mem, sqlstring As String
        Try
            validity = True
            If Txt_Newmember.Text = "" Then
                MessageBox.Show(" Please Enter New Membership No", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                validity = False
                Exit Function
            End If
            ssql = "select mcode from membermaster  where mcode='" & Txt_Newmember.Text & "' AND ISNULL(FREEZE,'') <> 'Y'"
            datalist = gconnection.GetValues(ssql)
            If datalist.Rows.Count > 0 Then
                validity = False
                MessageBox.Show("Membership No: " & Txt_Newmember.Text & " Already Exists ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Function
            End If

            If commembertype.Text <> "" Then

                type0 = Split(commembertype.Text, ".")

                If Trim(oldmembertype.Text) = Trim(type0(1)) Then
                    validity = False
                    MessageBox.Show("Can not convert same Category", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Function
                End If
            Else
                validity = False
                MessageBox.Show(" Please Enter The Category ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            If Format(dtpdate.Value, "dd/MM/yyy") > Format(Now(), "dd/MM/yyyy") Then
                MessageBox.Show("Conversion Date cannot be greater than Systemdate", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                validity = False
                Exit Function
            End If
            If Format(dtpdate.Value, "dd/MM/yyy") < Format(Now(), "dd/MM/yyyy") Then
                MessageBox.Show("Conversion Date cannot be Less than Systemdate", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                validity = False
                Exit Function
            End If
            If cbo_NewStatus.Text = "Select New Status" Then
                MessageBox.Show(" Status Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbo_NewStatus.Focus()
                Exit Function
            End If
            '''***************************** $ Present Status can't be blank & **************************************'''
            If Trim(txt_PresentStatus.Text) = "" Then
                MessageBox.Show(" Present Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_PresentStatus.Focus()
                Exit Function
            End If
            '''***************************** $ New status can't be blank & **************************************'''
            If Trim(cbo_NewStatus.Text) = "" Then
                MessageBox.Show(" New Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbo_NewStatus.Focus()
                Exit Function
            End If
            If txtreason.Text = "" Then
                MessageBox.Show(" Please Enter The Reason ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                validity = False
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub cmdview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdview.Click

    End Sub

    Private Sub cmdprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprint.Click

    End Sub

    Private Sub txtmembercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmembercode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdmemberhelp_Click(sender, e)
        End If

    End Sub

    Private Sub txtmembercode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmembercode.KeyPress
        getAlphanumeric(e)
        If txtmembercode.Text = "" And Asc(e.KeyChar) = 13 Then
            Call cmdmemberhelp_Click(sender, e)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        End If
        If Asc(e.KeyChar) = 13 And txtmembercode.Text <> "" Then
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            commembertype.Focus()
        End If
        cmdadd.Text = "Update[F5]"
    End Sub

    Private Sub Txt_Newmember_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Newmember.TextChanged

    End Sub

    Private Sub txtmembercode_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmembercode.ModifiedChanged

    End Sub
End Class
